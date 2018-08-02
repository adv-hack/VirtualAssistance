using Consensus.Finance;
using Consensus.Contact;
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
    public partial class InvoiceLinesList : BaseListControl
    {
        
          #region fields

        /// <summary>
        ///     The ID of the Invoice whose lines will be displayed.
        /// </summary>
        private String _invId;

        #endregion


        #region properties



        /// <summary>
        ///     Gets or sets the ID of the Invoice whose lines will be displayed.
        /// </summary>
        public String InvId
        {
            get { return _invId; }
            set { _invId = value; }
        }


        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Invoice Lines"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.ResultsTable; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                .Select("INVLN_ID")
                .Select("INVLN_PROD_NAME")
                .Select("MEM_REF")
                .Select("INVLN_BOOK_ID")
                .Select("INVLN_QTY")
                .Select("INVLN_NET")
                .Select("INVLN_VAT_CODE")
                .Select("INVLN_TOTAL_PRICE")
                .Select("INVLN_DESCRIPTION")
                .Select("INVLN_UNIT_PRICE")
                .Select("INVLN_PRODUCT_ID")
                .Select("PROD_NAME")
                .Select("PROD_URL")
                .Select("MEL_MEP_ID")
                .Select("book_URL")
                .Select("uri")
                .From(QuerySources.InvoiceLines)
                .Where("INVLN_INV_ID", QueryConditionTypes.Equal, this.InvId)
                .OrderBy("INVLN_ADD_DATE", false);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
                this.DataTable.Json = "{ uri: \"finance/InvoiceLine\", InvoiceId: " + HttpUtility.JavaScriptStringEncode(this.InvId, true) + " }";  
        }

        #endregion
    }
}