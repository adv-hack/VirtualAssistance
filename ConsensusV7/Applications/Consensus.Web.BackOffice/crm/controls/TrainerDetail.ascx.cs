using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class TrainerDetail : BaseControl<Trainer, String>
    {
        #region properties

        public override string DataTypeName
        {
            get { return "Trainer"; }
        }

        #endregion

        #region Methods

        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            this.AinModBy.FieldValue = this.CurrentSession.UserId.ToString();
            if (this.DataSource == null || this.DataSource.Id == null)
            {
                this.SellingCompany.FieldValue = this.CurrentSession.User.SellingCompanyId;
                this.SyType.FieldValue = Convert.ToInt32(TrainerSyType.Associate).ToString();                
                this.AinAddBy.FieldValue = this.CurrentSession.UserId.ToString();                
            }
            else
            {               
                if (this.DataSource.AinWeb == 1)
                {
                    this.WebEnabled.FieldValue = true;
                }
                else
                {
                    this.WebEnabled.FieldValue = false;
                }
            }
        }

        #endregion
    }
}