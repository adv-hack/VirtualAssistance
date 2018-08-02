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

namespace Consensus.Web.BackOffice.Reporting
{
    public partial class DataSetObjectPage : BaseStandardPage
    {
        public override string DefaultTitle
        {
            get
            {
                return ("Datasets");
            }
        }

        protected override void CreateHistoryLink(String URL)
        {
            //home page should not create a history link entry
        }

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
          base.OnLoad(e);

          ReportIframe.Src = Consensus.Security.UserAccount.ReportingURL("") + "&id=" + this.Request.QueryString["id"];
          //ReportIframe.Attributes.Add("onload", "FrameManager.registerFrame(this)");
        }
        #endregion

        #region methods

        #endregion
    }
}