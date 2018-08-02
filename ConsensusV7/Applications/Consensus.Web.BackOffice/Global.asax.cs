using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Consensus.Web.BackOffice
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(Object sender, EventArgs e)
        {
            RestRouter.Initialise();
            FileRouter.Initialise();
            WebRouter.Initialise();
        }

        protected void Application_Error(Object sender, EventArgs e)
        {
            // HttpContext.Current.Server.Transfer(WebGlobals.ErrorPage, false);
        }
    }
}