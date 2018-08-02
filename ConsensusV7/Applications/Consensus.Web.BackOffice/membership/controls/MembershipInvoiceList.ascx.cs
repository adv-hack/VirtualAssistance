using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MembershipInvoiceList : BaseListControl
    {
        #region fields

        private String _memberPeriodId;

        #endregion

        #region properties
        /// <summary>
        public String MemberPeriodId
        {
            get { return _memberPeriodId; }
            set { _memberPeriodId = value; }
        }
        public override String DataTypeName
        {
            get { return "Invoice List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.MemberInvoices; }
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
                    .Select("INV_DATE")
                    .Select("INV_TYPE")
                    .Select("INV_REF")
                    .Select("INV_GROSS_TOTAL")
                    .Select("INV_CURRENCY_TYPE")
                    .Select("INV_BK_ORG_CUST_AC")
                    .Select("INV_INV_ORG_NAME")
                    .Select("INV_DUE_DATE")
                    .Select("INV_UNPAID_VAL")
                    .Select("INV_CONTACT_NAME")
                    .Select("INV_PERSON_ID")
                    .Select("INV_ORG_ID")
                    .Select("uri")
                    .From(QuerySources.MembershipInvoices)
                    .Where("INV_MEP_ID", QueryConditionTypes.Equal, this.MemberPeriodId)
                    .OrderBy("INV_DATE", true);
            }
        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        #endregion

    }
}