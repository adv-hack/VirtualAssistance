using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class AccountInvoiceRules : BaseControl<Account, String>
    {
        #region properties

        public override string DataTypeName
        {
            get { return "Invoice Rules"; }
        }

        #endregion

        #region Methods

        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);
            this.InvoiceRule.DataSource = Common.Code.FetchAllByType("IRUL");

            //Defaults for new Account
            if (this.DataSource != null && this.DataSource.Id != null)
            {
                if (this.DataSource.InvoiceRuleOffset <= 0)
                {
                    this.BeforeAfter.FieldValue = "-1";
                }
                else
                {
                    this.BeforeAfter.FieldValue = "1";
                }
                this.OffsetValue.FieldValue = Math.Abs(this.DataSource.InvoiceRuleOffset).ToString();
            }
        }

        #endregion
    }
}