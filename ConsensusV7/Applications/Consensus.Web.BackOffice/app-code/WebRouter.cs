using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.Routing;
using System.Web.UI;

namespace Consensus.Web.BackOffice
{
    public class WebRouter : IRouteHandler
    {
        #region fields

        /// <summary>
        ///     The singleton instance of the web router.
        /// </summary>
        private static WebRouter _instance;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the singleton instance of the web router.
        /// </summary>
        private static WebRouter Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WebRouter();

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
            RouteTable.Routes.RouteExistingFiles = false;
            RouteTable.Routes.Ignore("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.Add(new Route("{page}", WebRouter.Instance));
            RouteTable.Routes.Add(new Route("{namespace}/{page}", WebRouter.Instance));
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
            IHttpHandler handler = GetHandler(requestContext.RouteData.Values["namespace"], requestContext.RouteData.Values["page"]);
            if (handler == null)
            {
                requestContext.HttpContext.Response.Clear();
                requestContext.HttpContext.Response.StatusCode = 404;
                requestContext.HttpContext.Response.StatusDescription = "Not Found";
                requestContext.HttpContext.Response.End();
            }
            return handler;
        }

        private static IHttpHandler GetHandler(Object urlNamespace, Object urlPage)
        {
            IHttpHandler handler = null;
            if (urlNamespace != null && urlNamespace.ToString().Equals("search", StringComparison.OrdinalIgnoreCase))
            {
                String virtualPath = String.Concat("~/searchpage.aspx");
                String physicalPath = HttpContext.Current.Server.MapPath(virtualPath);
                if (File.Exists(physicalPath))
                {
                    handler = BuildManager.CreateInstanceFromVirtualPath(virtualPath, typeof(Page)) as IHttpHandler;
                    HttpContext.Current.Items["type"] = urlPage;
                }
            }
            else if (urlPage != null && !urlPage.ToString().Equals("search", StringComparison.OrdinalIgnoreCase))
            {
                String virtualPath = String.Concat("~/", urlNamespace, "/", urlPage + "page.aspx");
                String physicalPath = HttpContext.Current.Server.MapPath(virtualPath);
                if (File.Exists(physicalPath))
                    handler = BuildManager.CreateInstanceFromVirtualPath(virtualPath, typeof(Page)) as IHttpHandler;
            }

            return handler;
        }

        #endregion
    }
}