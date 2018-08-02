using Consensus.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice
{
    public partial class HomePage : BaseStandardPage
    {
        public override string DefaultTitle
        {
            get 
            {
                return (this.CurrentSession == null || this.CurrentSession.User == null || this.CurrentSession.User.Person == null ? null : "Welcome back, " + this.CurrentSession.User.Person.FirstName); 
            }
        }

        protected override void CreateHistoryLink(String URL)
        {
            //home page should not create a history link entry
        }

        #region page cycle

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.BlockCustomFields = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if(!(this.CurrentSession == null || this.CurrentSession.User == null || string.IsNullOrWhiteSpace(this.CurrentSession.User.ReportIdId)))
            {
                if (this.CurrentSession.User.ReportId.PortalMenuId.GetValueOrDefault(0) > 0 && this.CurrentSession.User.ReportId.Current > 0)
                {
                    ReportIframe.Src = Consensus.Security.UserAccount.ReportingURL(Convert.ToString(this.CurrentSession.User.ReportId.PortalMenuId.GetValueOrDefault(0)));

                }
            }
        }
        #endregion
    }


}