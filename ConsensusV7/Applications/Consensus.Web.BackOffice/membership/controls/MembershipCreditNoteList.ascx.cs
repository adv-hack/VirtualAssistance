using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.Controls;
using Consensus.Searches;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MembershipCreditNoteList : BaseListControl
    {
        #region fields

        private string _membershipPeriodID;
        public string MembershipPeriodID
        {
            get { return _membershipPeriodID; }
            set { _membershipPeriodID = value; }
        }

     

        public override string DataTypeName
        {
            get
            {
                return "Credit Note List";
            }
        }

        public override DataTable DataTable
        {
            get
            {
                return this.CreditNoteList;
            }
        }

        public override object DataSource
        {
            get
            {

                return Query.Create()
                    .Select("InvoieID")
                    .Select("INV_DATE")
                    .Select("InvoiceType")
                    .Select("InvoiceRef")
                    .Select("InvGrossTotal")
                    .Select("InvoiceCurrType")
                    .Select("ARNumber")
                    .Select("InvOrgName")
                    .Select("INV_CONTACT_NAME")
                    .Select("InvPersonId")
                    .Select("InvOrgID")
                    .Select("CreditedInvoiceReference")
                    .Select("CreditedInvoiceID")
                    .Select("uri")
                    .From(QuerySources.MemebershipCreditNotes)
                    .Where("InvMemPerID", QueryConditionTypes.Equal, this.MembershipPeriodID)
                    .OrderBy("INV_DATE", true);
            }
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}