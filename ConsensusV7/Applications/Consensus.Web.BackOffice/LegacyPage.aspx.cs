using Consensus.UserInterface;
using Consensus.Web.BackOffice.assets.templates;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice
{
    public partial class LegacyPage : System.Web.UI.Page
    {
        public const String LegacyUriParameter = "_legacyUrl";

        public String RelativeUri
        {
            get { return this.Request.QueryString[LegacyPage.LegacyUriParameter]; }
        }

        public String UriParameters
        {
            get
            {
                StringBuilder parameters = new StringBuilder();
                foreach (String key in this.Request.QueryString.AllKeys)
                {
                    if (!String.Equals(key, LegacyPage.LegacyUriParameter, StringComparison.OrdinalIgnoreCase))
                    {
                        parameters.Append(parameters.Length == 0 ? "" : "&");
                        parameters.Append(HttpUtility.UrlEncode(key));
                        parameters.Append("=");
                        parameters.Append(HttpUtility.UrlEncode(this.Request.QueryString[key]));
                    }
                }

                return parameters.ToString();
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            ((String)null).ToString();
        }
    }
}