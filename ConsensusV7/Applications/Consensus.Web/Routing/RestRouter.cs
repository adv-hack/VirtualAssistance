using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;


namespace Consensus.Web
{
    public class RestRouter : IRouteHandler
    {
        #region fields

        /// <summary>
        ///     The singleton instance of the rest router.
        /// </summary>
        private static RestRouter _instance;

        /// <summary>
        ///     The parameter name used to identify the context of a RESTful service request.
        /// </summary>
        internal const String ContextParameter = "context";

        /// <summary>
        ///     The parameter name used to identify the element of a RESTful service request.
        /// </summary>
        internal const String ElementParameter = "element";

        /// <summary>
        ///     The parameter name used to identify the object instance of a RESTful service request.
        /// </summary>
        internal const String ObjectParameter = "object";

        /// <summary>
        ///     The parameter name used to identify the accessible member of a RESTful service request.
        /// </summary>
        internal const String MemberParameter = "member";

        #endregion

        #region properties

        /// <summary>
        ///    Gets the singleton instance of the rest router.
        /// </summary>
        private static RestRouter Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RestRouter();

                return _instance;
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the routing table.
        /// </summary>
        public static void Initialise()
        {
            RestRouter.Initialise(RestRouter.ContextParameter);
            RestRouter.Initialise(RestRouter.ContextParameter, RestRouter.ElementParameter);
            RestRouter.Initialise(RestRouter.ContextParameter, RestRouter.ElementParameter, RestRouter.ObjectParameter);
            RestRouter.Initialise(RestRouter.ContextParameter, RestRouter.ElementParameter, RestRouter.ObjectParameter, RestRouter.MemberParameter);
        }

        /// <summary>
        ///     Initialises the routing table with a URL format.
        /// </summary>
        public static void Initialise(params String[] parameters)
        {
            String url = String.Concat("rest/", String.Join("/", parameters.Select(param => String.Concat("{", param, "}"))));
            Route route = new Route(url, RestRouter.Instance);
            RouteTable.Routes.Add(route);
        }

        /// <summary>
        ///     Provides the object that processes the request.
        /// </summary>
        /// <param name="requestContext">
        ///     An object that encapsulates information about the request.
        /// </param>
        /// <returns>
        ///     The <see cref="RestHandler" /> that processes the request.
        /// </returns>
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new RestHandler(requestContext.RouteData.Values);
        }

        #endregion
    }
}