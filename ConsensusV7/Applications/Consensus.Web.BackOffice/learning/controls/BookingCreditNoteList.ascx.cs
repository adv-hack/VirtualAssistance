using Consensus.Finance;
using Consensus.Learning;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class BookingCreditNoteList : BaseControl<Proxy>
    {
        
        public override String DataTypeName
        {
            get { return "Credit Note List"; }
        }

        protected override void PopulateControl()
        {
            String ColumnName = null;
            String ColumnValue = null;
            QuerySources querysource = QuerySources.BookingCreditNotes;
            if (this.DataSource is Booking)
            {
                ColumnName = "INV_BOOK_ID";
                ColumnValue = (this.DataSource as Booking).Id;
            }
            if (this.DataSource is Account)
            {
                ColumnName = "INV_ACC_ID";
                ColumnValue = (this.DataSource as Account).Id;
            }
            this.CreditNoteList.Data = Query.Create()
                .Select("INV_ID")
                    .Select("INV_DATE")
                    .Select("INV_TYPE")
                    .Select("INV_REF")
                    .Select("INV_GROSS_TOTAL")
                    .Select("INV_CURRENCY_TYPE")
                    .Select("INV_BK_ORG_CUST_AC")
                    .Select("INV_INV_ORG_NAME")
                    .Select("INV_CONTACT_NAME")
                    .Select("INV_PERSON_ID")
                    .Select("INV_ORG_ID")
                    .Select("InvoiceReference")
                    .Select("InvoiceID")
                    .Select("INV_ID2")
                    .Select("uri")
                    .From(querysource)
                    .Where(ColumnName, QueryConditionTypes.Equal, ColumnValue)
                    .OrderBy("INV_DATE", true);


        }



        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        #endregion
    }
}