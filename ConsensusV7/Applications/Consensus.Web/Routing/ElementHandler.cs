using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Routing;
using System.Web.Script.Serialization;
using System.IO;
using System.Collections;
using System.Web.SessionState;
using Consensus.Security;

namespace Consensus.Web
{
    /// <summary>
    ///     General base class for handling HTTP requests. 
    /// </summary>
    public abstract class ElementHandler : IHttpHandler, IRequiresSessionState
    {
        #region fields

        /// <summary>
        ///     The serializer for JSON conversion
        /// </summary>
        protected static JavaScriptSerializer _serializer;

        /// <summary>
        ///     The collection of key-value pairs defined within the routing framework.
        /// </summary>
        protected RouteValueDictionary _routingData;

        /// <summary>
        ///     The runtime type corresponding to the element.
        /// </summary>
        protected Type _restType;

        #endregion

        #region properties

        /// <summary>
        ///     Gets a value indicating whether another request can use this <see cref="IHttpHandler" /> instance.
        /// </summary>
        public Boolean IsReusable
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the serializer for JSON conversion
        /// </summary>
        public static JavaScriptSerializer Serializer
        {
            get
            {
                if (_serializer == null)
                {
                    _serializer = new JavaScriptSerializer();
                    _serializer.RegisterConverters(new JavaScriptConverter[] { RestSerializer.Instance });
                }
                return _serializer;
            }
        }

        /// <summary>
        ///     Gets the context or namespace of the rest object that is being referenced by the web request.
        /// </summary>
        public String RestContext
        {
            get { return _routingData.ContainsKey(RestRouter.ContextParameter) ? _routingData[RestRouter.ContextParameter].ConvertTo<String>() : null; }
        }

        /// <summary>
        ///     Gets the element or model of the rest object that is being referenced by the web request.
        /// </summary>
        public String RestElement
        {
            get { return _routingData.ContainsKey(RestRouter.ElementParameter) ? _routingData[RestRouter.ElementParameter].ConvertTo<String>() : null; }
        }

        /// <summary>
        ///     Gets the identifier of the rest object that is being referenced by the web request, or where a static method
        ///     is being executed, the name of the static method.
        /// </summary>
        public String RestObject
        {
            get { return _routingData.ContainsKey(RestRouter.ObjectParameter) ? _routingData[RestRouter.ObjectParameter].ConvertTo<String>() : null; }
        }

        /// <summary>
        ///     Gets the assembly qualified name of the runtime type corresponding to the element.
        /// </summary>
        public String RestTypeName
        {
            get { return String.Format("{0}.{1}.{2}, {3}", typeof(Proxy).Namespace, this.RestContext, this.RestElement, typeof(Proxy).Assembly.FullName); }
        }

        /// <summary>
        ///     Gets the runtime type corresponding to the element.
        /// </summary>
        public Type RestType
        {
            get
            {
                if (_restType == null)
                    _restType = Type.GetType(this.RestTypeName, false, true);

                return _restType;
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Instantiates a new <see cref="RestHandler" /> instance.
        /// </summary>
        /// <param name="routingData">
        ///    Sets the collection of key-value pairs defined within the routing framework.
        /// </param>
        public ElementHandler(RouteValueDictionary routingData)
        {
            _routingData = routingData;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Processes a HTTP web request.
        /// </summary>
        /// <param name="context">
        ///     The <see cref="HttpContext"/> object object that provides references to the intrinsic server objects that are used to service the request.
        /// </param>
        public void ProcessRequest(HttpContext httpContext)
        {
            try
            {
                // Validate that a context and element have been provided
                if (String.IsNullOrEmpty(this.RestContext))
                    throw new NotSupportedException();
                if (String.IsNullOrEmpty(this.RestElement))
                    throw new NotSupportedException();
                if (this.RestType == null)
                    throw new NotSupportedException();

                // Unless the REST request is targeting the user session object, ensure that the user has authenticated.
                //if (!String.Equals(this.RestContext, "security", StringComparison.OrdinalIgnoreCase) || !String.Equals(this.RestElement, "usersession", StringComparison.OrdinalIgnoreCase))
                //{
                //    UserSession session = UserSession.FetchCurrent();
                //    if (session == null || session.Expiry < DateTime.Now)
                //        throw new UnauthorizedAccessException();

                //    UserSession.Update();
                //}

                HandleRequest(httpContext);
            }
            catch (ApplicationException ax)
            {
                if (ax.InnerException != null)
                {
                    this.ProcessResponse(400, ax.InnerException.Message);
                }
                else
                {
                    this.ProcessResponse(400, ax.Message);
                }
            }
            catch (UnauthorizedAccessException)
            {
                this.ProcessResponse(401, "Unauthorized");
            }
            catch (NotSupportedException)
            {
                this.ProcessResponse(405, "Method Not Supported");
            }
            catch (KeyNotFoundException)
            {
                this.ProcessResponse(410, "Not Found");
            }
        }

        protected abstract void HandleRequest(HttpContext httpContext);

        /// <summary>
        ///     Returns the HTTP response containing JSON serialised data.
        /// </summary>
        /// <param name="data">
        ///     The data to be serialized and returned within the response.
        /// </param>
        public void ProcessResponse(Object data)
        {
            ProcessResponse(data, null);
        }

        /// <summary>
        ///     Returns the HTTP response containing JSON serialised data.
        /// </summary>
        /// <param name="data">
        ///     The data to be serialized and returned within the response.
        /// </param>
        /// <param name="table">
        ///     A table contain serialisation instructions derived from the request parameters.
        /// </param>
        public void ProcessResponse(Object data, Dictionary<String, Object> table)
        {
            HttpContext.Current.Response.Clear();
            if (data == null)
            {
                HttpContext.Current.Response.StatusCode = 204;
                HttpContext.Current.Response.StatusDescription = "No Content";
            }
            else
            {
                String result = serializeResponse(data, table);
                HttpContext.Current.Response.ContentType = "application/json";
                HttpContext.Current.Response.StatusCode = 200;
                HttpContext.Current.Response.StatusDescription = "OK";
                HttpContext.Current.Response.Write(result ?? "");
            }
        }

        private string serializeResponse(object data, Dictionary<String, Object> table)
        {
            String result = "";

            // table may contain a "serialisation" block with serialisation parameters from the
            // body of a post, or it may contain indeividual serialisation parameters which were provided
            // in the query string. Either way we need a one-off serialiser instance to process it.
            if (table != null && 
                (table.ContainsKey("serialization")
                || table.ContainsKey("gotodepth")
                || table.ContainsKey("listsatdepth")
                || table.ContainsKey("liststodepth"))) // These keys have already been forced to lower case...
            {

                var bespokeSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();

                RestSerializer bespokeConverter = new RestSerializer();
                if (table.ContainsKey("serialization"))
                {
                    Dictionary<String, Object> serializationParams = table["serialization"] as Dictionary<String, Object>;
                    if (serializationParams != null)
                    {
                        // ...but these keys haven't
                        string key = serializationParams.Keys.FirstOrDefault(k => k.Equals("listsatdepth", StringComparison.InvariantCultureIgnoreCase));
                        if (!string.IsNullOrEmpty(key))
                        {
                            string sListsToDepth = serializationParams[key].ToString();
                            RestSerializationDepth eListsToDepth;
                            if (Enum.TryParse<RestSerializationDepth>(sListsToDepth, out eListsToDepth))
                            {
                                bespokeConverter.ListsAtDepth = eListsToDepth;
                            }
                        }

                        key = serializationParams.Keys.FirstOrDefault(k => k.Equals("gotodepth", StringComparison.InvariantCultureIgnoreCase));
                        if (!string.IsNullOrEmpty(key))
                        {
                            string sGoToDepth = serializationParams[key].ToString();
                            RestSerializationDepth eGoToDepth;
                            if (Enum.TryParse<RestSerializationDepth>(sGoToDepth, out eGoToDepth))
                            {
                                bespokeConverter.GoToDepth = eGoToDepth;
                            }
                        }

                        key = serializationParams.Keys.FirstOrDefault(k => k.Equals("liststodepth", StringComparison.InvariantCultureIgnoreCase));
                        if (!string.IsNullOrEmpty(key))
                        {
                            string sListsToDepth = serializationParams[key].ToString();
                            bespokeConverter.ListsToDepth = resolveDepthSetting(sListsToDepth, bespokeConverter.ListsToDepth);
                            //RestSerializationDepth eListsToDepth;
                            //if (Enum.TryParse<RestSerializationDepth>(sListsToDepth, out eListsToDepth))
                            //{
                            //    bespokeConverter.ListsToDepth = eListsToDepth;
                            //}
                        }

                        key = serializationParams.Keys.FirstOrDefault(k => k.Equals("ignore", StringComparison.InvariantCultureIgnoreCase));
                        if (!string.IsNullOrEmpty(key))
                        {
                            foreach (object oIgnoreType in serializationParams[key] as Dictionary<String, Object>)
                            {
                                KeyValuePair<string, object> ignoreType = (KeyValuePair<string, object>)oIgnoreType;
                                Type onType = Type.GetType("Consensus." + ignoreType.Key + ", Consensus.Client");
                                ArrayList toIgnore = ignoreType.Value as ArrayList;

                                if (onType != null && toIgnore != null && toIgnore.Count > 0)
                                    bespokeConverter.Ignore.Add(onType, toIgnore.ToArray().ToList().ConvertAll<string>(i => i.ToString()));
                            }
                        }

                        key = serializationParams.Keys.FirstOrDefault(k => k.Equals("include", StringComparison.InvariantCultureIgnoreCase));
                        if (!string.IsNullOrEmpty(key))
                        {
                            foreach (object oIncludeType in serializationParams[key] as Dictionary<String, Object>)
                            {
                                KeyValuePair<string, object> includeType = (KeyValuePair<string, object>)oIncludeType;
                                Type onType = Type.GetType("Consensus." + includeType.Key + ", Consensus.Client");
                                ArrayList toInclude = includeType.Value as ArrayList;

                                if (onType != null && toInclude != null && toInclude.Count > 0)
                                    bespokeConverter.Include.Add(onType, toInclude.ToArray().ToList().ConvertAll<string>(i => i.ToString()));
                            }
                        }

                        key = serializationParams.Keys.FirstOrDefault(k => k.Equals("namedlistsresolvetodepth", StringComparison.InvariantCultureIgnoreCase));
                        if (!string.IsNullOrEmpty(key))
                        {
                            foreach (object oContainingType in serializationParams[key] as Dictionary<String, Object>)
                            {
                                KeyValuePair<string, object> containingType = (KeyValuePair<string, object>)oContainingType;
                                Type onType = Type.GetType("Consensus." + containingType.Key + ", Consensus.Client");
                                Dictionary<String, Object> lists = containingType.Value as Dictionary<String, Object>;
                                if (onType != null && lists != null)
                                {
                                    Dictionary<string, RestSerializationDepth> typeListSettings = new Dictionary<string, RestSerializationDepth>();
                                    foreach (KeyValuePair<string, object> list in lists)
                                    {
                                        RestSerializationDepth eListToDepth;
                                        if (Enum.TryParse<RestSerializationDepth>(list.Value.ToString(), out eListToDepth))
                                        {
                                            typeListSettings.Add(list.Key, eListToDepth);
                                        }
                                    }
                                    if (typeListSettings.Count > 0)
                                        bespokeConverter.NamedListsResolveToDepth.Add(onType, typeListSettings);
                                }
                            }
                        }
                    }
                }
                if (table.ContainsKey("gotodepth"))
                {
                    string sGoToDepth = table["gotodepth"].ToString();
                    RestSerializationDepth eGoToDepth;
                    if (Enum.TryParse<RestSerializationDepth>(sGoToDepth, out eGoToDepth))
                    {
                        bespokeConverter.GoToDepth = eGoToDepth;
                    }
                }
                if (table.ContainsKey("listsatdepth"))
                {
                    string sListsAtDepth = table["listsatdepth"].ToString();
                    RestSerializationDepth eListsAtDepth;
                    if (Enum.TryParse<RestSerializationDepth>(sListsAtDepth, out eListsAtDepth))
                    {
                        bespokeConverter.ListsAtDepth = eListsAtDepth;
                    }
                }
                if (table.ContainsKey("liststodepth"))
                {
                    string sListsToDepth = table["liststodepth"].ToString();
                    bespokeConverter.ListsToDepth = resolveDepthSetting(sListsToDepth, bespokeConverter.ListsToDepth);
                    //RestSerializationDepth eListsToDepth;
                    //if (Enum.TryParse<RestSerializationDepth>(sListsToDepth, out eListsToDepth))
                    //{
                    //    bespokeConverter.ListsToDepth = eListsToDepth;
                    //}
                }

                bespokeSerializer.RegisterConverters(new System.Web.Script.Serialization.JavaScriptConverter[] { bespokeConverter });
                return bespokeSerializer.Serialize(data);
            }
            else
            {
                result = RestHandler.Serializer.Serialize(data);
            }

            return result;
        }

        private RestSerializationDepth resolveDepthSetting(string setting, RestSerializationDepth property)
        {
            RestSerializationDepth eSetting;
            if (Enum.TryParse<RestSerializationDepth>(setting, out eSetting))
            {
                property = eSetting;
            }
            return property;
        }

        /// <summary>
        ///     Clears and terminates the HTTP response, returning the specified <paramref name="code" /> and <paramref name="description" />.
        /// </summary>
        /// <param name="code">
        ///     The HTTP status code to be returned in the response.
        /// </param>
        /// <param name="description">
        ///     The textual description to be returned in the response.
        /// </param>
        public void ProcessResponse(Int32 code, String description)
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.StatusCode = code;
            HttpContext.Current.Response.StatusDescription = description;
        }
        #endregion
    }
}
