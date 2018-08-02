using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Consensus.Web
{
    public class FileRouter : IRouteHandler
    {
        #region fields

        /// <summary>
        ///     The singleton instance of the rest router.
        /// </summary>
        private static FileRouter _instance;

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
        
        #endregion

        #region properties

        /// <summary>
        ///    Gets the singleton instance of the rest router.
        /// </summary>
        private static FileRouter Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FileRouter();

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
            FileRouter.Initialise(FileRouter.ContextParameter);
            FileRouter.Initialise(FileRouter.ContextParameter, FileRouter.ElementParameter);
            FileRouter.Initialise(FileRouter.ContextParameter, FileRouter.ElementParameter, FileRouter.ObjectParameter);
        }

        /// <summary>
        ///     Initialises the routing table with a URL format.
        /// </summary>
        public static void Initialise(params String[] parameters)
        {
            String url = String.Concat("file/", String.Join("/", parameters.Select(param => String.Concat("{", param, "}"))));
            Route route = new Route(url, FileRouter.Instance);
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
            return new FileHandler(requestContext.RouteData.Values);
        }

        #endregion
    }
}