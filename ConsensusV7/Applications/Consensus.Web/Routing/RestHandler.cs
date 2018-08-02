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
using Consensus.Searches;
using System.Transactions;

namespace Consensus.Web
{
    public class RestHandler : ElementHandler
    {
        #region fields

        private string[] testKeys = { "serialization", "gotodepth", "listsatdepth", "liststodepth" }; // These keys are to control serialization, not to be passed as method params
        
        #endregion

        #region properties

        /// <summary>
        ///     Gets the name of the property member that is being referenced on the rest object that is being referenced by the web request, or where a static method
        ///     is being executed, the name of the static method.
        /// </summary>
        public String RestMember
        {
            get { return _routingData.ContainsKey(RestRouter.MemberParameter) ? _routingData[RestRouter.MemberParameter].ConvertTo<String>() : null; }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Instantiates a new <see cref="RestHandler" /> instance.
        /// </summary>
        /// <param name="routingData">
        ///    Sets the collection of key-value pairs defined within the routing framework.
        /// </param>
        public RestHandler(RouteValueDictionary routingData) : base(routingData) { }
        //public RestHandler(RouteValueDictionary routingData) 
        //{
        //    _routingData = routingData;
        //}

        #endregion

        #region methods

        protected override void HandleRequest(HttpContext httpContext)
        {
            // Identify the logic required to respond to the request.
            switch (httpContext.Request.HttpMethod.ToUpper())
            {
                case "GET": this.ProcessGetRequest(); break;
                case "PUT": this.ProcessPutRequest(); break;
                case "PATCH": this.ProcessPutRequest(); break;
                case "DELETE": this.ProcessDeleteRequest(); break;
                case "POST": this.ProcessPostRequest(); break;
                default: this.ProcessResponse(405, "Method Not Supported"); break;
            }
        }

        /// <summary>
        ///     Processes a HTTP GET request.
        /// </summary>
        /// <remarks>
        ///     The GET request is used to perform a fetch in order to return one or more records.
        /// </remarks>
        private void ProcessGetRequest()
        {
            // Deserialize the JSON request into an object graph.
            Dictionary<String, Object> table = new Dictionary<string, object>();
            List<string> parameterNames = new List<string>();
            List<string> parameterValues = new List<string>();

            foreach (String key in HttpContext.Current.Request.QueryString)
            {
                if (testKeys.Any(t => string.Equals(t, key, StringComparison.InvariantCultureIgnoreCase)))
                {
                    table[key.ToLower()] = HttpContext.Current.Request.QueryString[key];
                }
                else
                {
                    parameterNames.Add(key);
                    parameterValues.Add(HttpContext.Current.Request.QueryString[key]);
                }
            }

            if (String.IsNullOrEmpty(this.RestObject))
            {
                // Identify the name and value for any url parameters that have been specified
                //String[] parameterNames = HttpContext.Current.Request.QueryString.Keys.Cast<String>().ToArray();
                //String[] parameterValues = parameterNames.Select(key => HttpContext.Current.Request.QueryString[key]).ToArray();

                // Identify the method required to return the data
                String methodName = parameterNames.Count == 0 ? "" : "By" + String.Join("And", parameterNames);
                MethodInfo method = this.GetMethod("Fetch" + methodName, parameterNames.ToArray()) ?? this.GetMethod("FetchAll" + methodName, parameterNames.ToArray());
                if (method == null)
                    throw new NotSupportedException();

                // Execute the identified method to obtain the requested data.
                Object[] methodParams = method.GetParameters().Select(param => parameterValues[parameterNames.IndexOf(param.Name)]).ToArray();
                Object methodResult = this.InvokeMethod(method, null, methodParams);
                this.ProcessResponse(methodResult, table);
            }
            else if (String.IsNullOrEmpty(this.RestMember))
            {
                // Execute the FetchById method to return the requested object
                MethodInfo method = this.GetMethod("FetchById", "Id");
                if (method == null)
                    throw new NotSupportedException();

                // Execute the identified method to obtain the requested data.
                Proxy methodResult = this.InvokeMethod(method, null, new Object[] { this.RestObject.ConvertTo(method.GetParameters().First().ParameterType) }) as Proxy;
                if (methodResult == null)
                    throw new KeyNotFoundException();

                // Return the result of the method call.
                this.ProcessResponse(methodResult, table);
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        ///     Processes a HTTP PUT request.
        /// </summary>
        /// <remarks>
        ///     The PUT request is used to create a new instance of a model, or update an existing instance if an id is passed.
        /// </remarks>
        private void ProcessPutRequest()
        {
            if (String.IsNullOrEmpty(this.RestObject) || String.IsNullOrEmpty(this.RestMember))
            {
                Dictionary<String, Object> table = new Dictionary<string, object>();

                foreach (String key in HttpContext.Current.Request.QueryString)
                    table[key.ToLower()] = HttpContext.Current.Request.QueryString[key];

                Proxy methodResult = null;
                MethodInfo method = null;
                if (String.IsNullOrEmpty(this.RestObject))
                {
                    // Identify the method for creating a new instance of the requested object.
                    method = this.GetMethod("Create");
                    if (method == null)
                        throw new NotSupportedException();

                    // Create a new instance of the object.
                    methodResult = this.InvokeMethod(method, null, new Object[0]) as Proxy;
                }
                else
                {
                    // Identify the method for fetching an existing instance of the requested object
                    method = this.GetMethod("FetchById", "id");
                    if (method == null)
                        throw new NotSupportedException();

                    // Obtain the existing instance of the object.
                    methodResult = this.InvokeMethod(method, null, new Object[] { this.RestObject.ConvertTo(method.GetParameters().First().ParameterType) }) as Proxy;
                }

                if (methodResult == null)
                    throw new KeyNotFoundException();

                // Update with object with the data from the JSON request, save the object instance and return the response.
                List<UserInterface.ScreenCustomFieldValue> customFields = new List<UserInterface.ScreenCustomFieldValue>();
                this.ProcessJSONRequest(methodResult, customFields);
                if (customFields.Count > 0)
                {
                    using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))
                    {
                        methodResult.Save();

                        foreach (UserInterface.ScreenCustomFieldValue customField in customFields)
                        {
                            customField.RecordId = methodResult.GetType().GetProperty("Id").GetValue(methodResult).ToString();
                            customField.Save();
                        }

                        transaction.Complete();
                    }
                }
                else
                {
                    methodResult.Save();
                }
                // Fetching the newly saved instance of the object back from the databa
                method = this.GetMethod("FetchById", "id");
                PropertyInfo idInfo = methodResult.GetType().GetProperty("Id");
                if (method != null && idInfo != null)
                    methodResult = this.InvokeMethod(method, null, new Object[] { idInfo.GetValue(methodResult) }) as Proxy;

                this.ProcessResponse(methodResult, table);
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        ///     Processes a HTTP DELETE request.
        /// </summary>
        /// <remarks>
        ///     The DELETE request is used to remove an existing instance of a model.
        /// </remarks>
        private void ProcessDeleteRequest()
        {
            if (String.IsNullOrEmpty(this.RestObject) || !String.IsNullOrEmpty(this.RestMember))
                throw new NotSupportedException();
            
            // Identify the method for fetching an existing instance of the requested object
            MethodInfo method = this.GetMethod("FetchById", "id");
            if (method == null)
                throw new NotSupportedException();

            // Obtain the existing new instance of the object.
            Proxy methodResult = this.InvokeMethod(method, null, new Object[] { this.RestObject.ConvertTo(method.GetParameters().First().ParameterType) }) as Proxy;
            if (methodResult == null)
                throw new KeyNotFoundException();

            // Delete the object
            methodResult.Delete();
            this.ProcessResponse(204, "No Content");
        }

        /// <summary>
        ///     Processes a HTTP POST request.
        /// </summary>
        /// <remarks>
        ///     The POST request is used to execute a static or instance method.
        /// </remarks>
        private void ProcessPostRequest()
        {
            // Validate that an object identifer (for instance methods) or method name (for static methods) has been provided.
            // Otherwise, assume the post is designed to create or update a model.
            if (String.IsNullOrEmpty(this.RestObject))
            {
                this.ProcessPutRequest();
            }
            else
            {
                // Deserialize the JSON request into an object graph.
                Dictionary<String, Object> table;
                Dictionary<String, Object> szTable = new Dictionary<string, object>();

                using (StreamReader requestReader = new StreamReader(HttpContext.Current.Request.InputStream))
                    table = RestHandler.Serializer.Deserialize<Dictionary<String, Object>>(requestReader.ReadToEnd()) ?? new Dictionary<String, Object>();

                foreach (String key in HttpContext.Current.Request.QueryString)
                    table[key] = HttpContext.Current.Request.QueryString[key];

                List<string> movedKeys = new List<string>();
                foreach (string key in table.Keys)
                {
                    if (testKeys.Any(t => string.Equals(t, key, StringComparison.InvariantCultureIgnoreCase)))
                    {
                        movedKeys.Add(key);
                        szTable[key.ToLower()] = table[key];
                    }
                }
                movedKeys.Execute(key => table.Remove(key));

                if (String.IsNullOrEmpty(this.RestMember))
                {
                    // Identify the method that corresponds to the rest API call.
                    MethodInfo method = this.GetMethod(BindingFlags.Public | BindingFlags.Static, this.RestObject, table.Keys.ToArray());
                    if (method == null)
                        throw new NotSupportedException();

                    // Execute the static method and return the result.
                    Object[] methodParams = method.GetParameters().Select(param =>
                        table[param.Name] == null ? null :
                        table[param.Name].GetType() == param.ParameterType ? table[param.Name] :
                        table[param.Name] is IDictionary<String, Object> && RestSerializer.Instance.SupportedTypes.Contains(param.ParameterType) ? RestSerializer.Instance.Deserialize(table[param.Name] as IDictionary<String, Object>, param.ParameterType, RestHandler.Serializer) :
                        param.ParameterType.IsGenericParameter ? table[param.Name] : table[param.Name].ConvertTo(param.ParameterType)
                    ).ToArray();
                    Object methodResult = this.InvokeMethod(method, null, methodParams);
                    this.ProcessResponse(methodResult, szTable);
                }
                else
                {
                    // Identify the method for fetching an existing instance of the requested object
                    MethodInfo fetch = this.GetMethod("FetchById", "id");
                    if (fetch == null)
                        throw new NotSupportedException();

                    // Obtain the existing instance of the object.
                    Proxy fetchResult = this.InvokeMethod(fetch, null, new Object[] { this.RestObject }) as Proxy;
                    if (fetchResult == null)
                        throw new KeyNotFoundException();

                    // Identify the method that corresponds to the rest API call.
                    MethodInfo method = this.GetMethod(BindingFlags.Public | BindingFlags.Instance, this.RestMember, table.Keys.ToArray());
                    if (method == null)
                        throw new NotSupportedException();

                    // Execute the instance method and return the result.
                    Object[] methodParams = method.GetParameters().Select(param =>
                        table[param.Name] == null ? null :
                        table[param.Name].GetType() == param.ParameterType ? table[param.Name] :
                        table[param.Name] is IDictionary<String, Object> && RestSerializer.Instance.SupportedTypes.Contains(param.ParameterType) ? RestSerializer.Instance.Deserialize(table[param.Name] as IDictionary<String, Object>, param.ParameterType, RestHandler.Serializer) :
                        param.ParameterType.IsGenericParameter ? table[param.Name] : table[param.Name].ConvertTo(param.ParameterType)
                    ).ToArray();
                    this.ProcessResponse(this.InvokeMethod(method, fetchResult, methodParams), szTable);
                }
            }
        }

        /// <summary>
        ///     Processes the HTTP request JSON data, updating the specified <paramref name="objectInstance"/> with the data from the request.
        /// </summary>
        /// <param name="objectInstance">
        ///     A <see cref="Proxy"/> object which will be updated with the values specified in the HTTP request JSON data.
        /// </param>
        private void ProcessJSONRequest(Proxy objectInstance, List<UserInterface.ScreenCustomFieldValue> customFieldValues)
        {
            // Deserialize the JSON request into an object graph.
            Dictionary<String, Object> table;
            using (StreamReader requestReader = new StreamReader(HttpContext.Current.Request.InputStream))
                table = RestHandler.Serializer.Deserialize<Dictionary<String, Object>>(requestReader.ReadToEnd());

            if (table.ContainsKey("_customFields"))
            {
                ResolveCustomFields(objectInstance, customFieldValues, table);
            }

            // Apply the JSON data onto the object instance
            RestSerializer.Instance.Deserialize(table, objectInstance, true);
        }
        
        private void ResolveCustomFields(Proxy objectInstance, List<UserInterface.ScreenCustomFieldValue> customFieldValues, Dictionary<String, Object> table)
        {
            Dictionary<String, Object> customFieldsTable = table["_customFields"] as Dictionary<String, Object>;

            foreach (string fieldName in customFieldsTable.Keys)
            {
                Dictionary<String, Object> fieldProperties = customFieldsTable[fieldName] as Dictionary<String, Object>;
                if (fieldProperties != null)
                {
                    int fieldId = fieldProperties["FieldId"].ConvertTo<int>();
                    UserInterface.ScreenCustomFieldValue fieldValue = table.ContainsKey("Id") ? UserInterface.ScreenCustomFieldValue.FetchByFieldIdAndRecordId(fieldId, table["Id"].ToString()) : null;
                    if (fieldValue == null)
                    {
                        fieldValue = UserInterface.ScreenCustomFieldValue.Create();
                        fieldValue.CfieldId = fieldId;
                        // Note: RecordId is set in ProcessPutRequest after the parent record has been saved..
                    }
                    UserInterface.ScreenCustomField fieldDef = UserInterface.ScreenCustomField.FetchById(fieldId);

                    if (fieldDef != null)
                    {
                        switch (fieldDef.CftypeId)
                        {
                            case "Text":
                            case "MultiLine":
                                fieldValue.Text = fieldProperties["Value"].ToString();
                                break;
                            case "Checkbox":
                                fieldValue.Number = fieldProperties["Value"].ConvertTo<bool>() ? 1 : 0;
                                break;
                            case "Date":
                                fieldValue.Date = fieldProperties["Value"].ConvertTo<DateTime?>();
                                break;
                            case "Number":
                                fieldValue.Number = fieldProperties["Value"].ConvertTo<decimal?>();
                                break;
                            case "List":
                                fieldValue.IdValue = fieldProperties["Value"].ToString();
                                break;
                            case "PopupSearch":
                                fieldValue.IdValue = fieldProperties["Value"].ToString();
                                fieldValue.Text = fieldProperties["Text"].ToString();
                                break;
                        }

                        customFieldValues.Add(fieldValue);
                    }
                }
            }
        }

        /// <summary>
        ///     Identifies the required method to be executed dynamically.
        /// </summary>
        /// <param name="name">
        ///     The name of the method.
        /// </param>
        /// <param name="parameters">
        ///     The parameters that need to be accepted by the method.
        /// </param>
        /// <returns>
        ///     The method that matches the specified <paramref name="name"/> and <paramref name="parameters"/>.
        /// </returns>
        private MethodInfo GetMethod(String name, params String[] parameters)
        {
            return this.GetMethod(BindingFlags.Public | BindingFlags.Static, name, parameters);
        }

        /// <summary>
        ///     Identifies the required method to be executed dynamically.
        /// </summary>
        /// <param name="flags">
        ///     The binding flags for the method.
        /// </param>
        /// <param name="name">
        ///     The name of the method.
        /// </param>
        /// <param name="parameters">
        ///     The parameters that need to be accepted by the method.
        /// </param>
        /// <returns>
        ///     The method that matches the specified <paramref name="name"/> and <paramref name="parameters"/>.
        /// </returns>
        private MethodInfo GetMethod(BindingFlags flags, String name, params String[] parameters)
        {
            return this.RestType.GetMethods(flags).FirstOrDefault(method =>
                String.Equals(method.Name, name, StringComparison.OrdinalIgnoreCase) &&
                method.GetParameters().Length == parameters.Length &&
                method.GetParameters().All(param =>
                    parameters.Any(parameter => String.Equals(parameter, param.Name, StringComparison.OrdinalIgnoreCase))
                )
            );
        }

        /// <summary>
        ///     Invokes the specified method against the target object instance, accounting for late-bound generic methods.
        /// </summary>
        private Object InvokeMethod(MethodInfo method, Object target, Object[] values)
        {
            Type[] generics = method.GetGenericArguments();

            // Match parameter types to the generic arguments for the method.
            if (generics.Length != 0)
            {
                for (Int32 i = 0; i < generics.Length; i++)
                {
                    ParameterInfo[] parameters = method.GetParameters().Where(param => param.ParameterType == generics[i]).ToArray();
                    IGrouping<Type, ParameterInfo>[] parameterTypes = parameters.GroupBy(param => values[param.Position].GetType()).ToArray();
                    if (parameterTypes.Length == 1)
                        generics[i] = parameterTypes[0].Key;
                }

                // Ensure all generics have been matched and then apply to the method
                if (!generics.Any(generic => generic.IsGenericParameter))
                    method = method.MakeGenericMethod(generics);
            }

            // Invoke the method
            Object[] methodParams = method.GetParameters().Select(param => values[param.Position].ConvertTo(param.ParameterType)).ToArray();
            Object methodResult = method.Invoke(target, methodParams);
            return methodResult;
        }

        #endregion
    }
}