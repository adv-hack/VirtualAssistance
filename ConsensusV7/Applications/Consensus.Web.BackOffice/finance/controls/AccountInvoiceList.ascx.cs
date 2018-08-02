using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class AccountInvoiceList : BaseListControl
    {
        #region properties
        private string _accountid;

        public string AccountId
        {
            get { return _accountid; }
            set { _accountid = value; }
        }
        
        public override String DataTypeName
        {
            get { return "Account Invoice List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.AccountInvoiceLists; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("INV_ID")
                    .Select("INV_REF")
                    .Select("INV_DATE")
                    .Select("INV_BK_ORG_CUST_AC")
                    .Select("INV_PERSON_ID")
                    .Select("INV_ORG_ID")
                    .Select("PROLE_PN_NAME")
                    .Select("INV_INV_ORG_NAME")
                    .Select("INV_CURRENCY_TYPE")
                    .Select("INV_GROSS_TOTAL")
                    .Select("INV_DUE_DATE")
                    .Select("INV_UNPAID_VAL")
                    .Select("INV_ACC_ID")
                    .Select("uri")
                    .From(QuerySources.AccountInvoiceCreditNotes)
                    .Where("INV_ACC_ID", QueryConditionTypes.Equal, this.AccountId)
                    .And("INV_TYPE",QueryConditionTypes.Equal,"Invoice")
                    .OrderBy("INV_DATE",false);        
            }
        }
        #endregion

        #region pagecycle
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}