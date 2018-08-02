using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.auth
{
    public partial class LoginPage : BasePage
    {
        public String Destination
        {
            get
            {
                if (String.Equals(this.Request.RawUrl, VirtualPathUtility.ToAbsolute(WebGlobals.LoginUrl), StringComparison.OrdinalIgnoreCase))
                    return WebGlobals.HomeUrl;
                if (String.Equals(this.Request.RawUrl, VirtualPathUtility.ToAbsolute(this.AppRelativeVirtualPath), StringComparison.OrdinalIgnoreCase))
                    return WebGlobals.HomeUrl;
                
                return HttpUtility.JavaScriptStringEncode(this.Request.RawUrl);
            }
        }
    }
}