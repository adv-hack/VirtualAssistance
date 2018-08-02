using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security
{
    public partial class LicensePage : BaseStandardPage<License>
    {
        #region fields

        /// <summary>
        ///     The license being modified.
        /// </summary>
        private License _data;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the license being modified
        /// </summary>
        public override License Data
        {
            get
            {
                if (_data == null)
                    _data = License.GetCurrent();

                return _data;
            }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "key"; }
        }

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Software License"; }
        }

        /// <summary>
        ///     Gets the unique identifier for the license.
        /// </summary>
        public override String SaveId
        {
            get { return this.Data.Id.ToString(); }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.LicenseOwner.DataSource = this.Data;
            this.LicenseDetail.DataSource = this.Data;
            this.VerifyLicenseButton.Visible = LicenseKey.HasPrivateKey;            
            if ((this.WarningPanel.Visible = this.Data.Status != Security.LicenseStatus.OK))
                this.TabControl.SelectedPage = this.LicenseTab;
            
        }

        #endregion
    }
}