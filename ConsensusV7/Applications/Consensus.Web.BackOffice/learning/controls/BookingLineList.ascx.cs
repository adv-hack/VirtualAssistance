using Consensus.Web.Controls;
using Consensus.Searches;
using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class BookingLineList : BaseListControl
    {
        #region fields
        /// <summary>
        ///     The ID of the parent object that the records are linked to.
        /// </summary>
        private String _booking;


        #endregion
        #region properties
        /// <summary>
        ///     Gets or sets the Id of the parent object that the session records are linked to.
        /// </summary>
        public String Booking
        {
            get { return _booking; }
            set { _booking = value; }
        }



        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Booking Line List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.BookingLineListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("ELEM_ID")
                    .Select("PROLE_PN_NAME")
                    .Select("ELEM_TYPE_DESC")
                    .Select("ELEM_STATUS_DESC")
                    .Select("ELEM_DESCRIPTION")
                    .Select("ELEM_QTY")
                    .Select("ELEM_UNT_PRICE")
                    .Select("ELEM_PRICE")
                    .Select("ELEM_VAT_AMT")
                    .Select("ELEM_START_DATE")
                    .Select("ELEM_END_DATE")
                    .Select("ELEM_INVOICED")
                    .Select("ELEM_MAIN_SESSION")
                    .Select("ELEM_BOOK_ID")
                    .Select("ELEM_DEL_ID")
                    .Select("ELEM_GRP_ID")
                    .Select("ELEM_CANCELLED")
                    .Select("PROLE_ID")
                    .Select("uri")
                    .From(QuerySources.BookingLines)
                    .Where("ELEM_BOOK_ID", QueryConditionTypes.Equal, this.ID)
                    //.And("ELEM_CANCELLED", QueryConditionTypes.Equal, "0")
                    .And("ELEM_SHOW_SALES", QueryConditionTypes.Equal, "1")
                    .OrderBy("PN_SURNAME", true)
                    .ThenBy("ELEM_DEL_ID")
                    .ThenBy("ELEM_GRP_ID")
                    .ThenBy("ELEM_MAIN_SESSION",false)
                    .ThenBy("ELEM_START_DATE")
                    .ThenBy("ELEM_END_DATE")
                    .ThenBy("ELEM_DESCRIPTION");
            }
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //this.DataTable.CreateUrl += "&bookingId=" + HttpUtility.UrlEncode(this.Booking);
            this.DataTable.Json = "{ uri: \"finance/payment\", bookId: " + HttpUtility.JavaScriptStringEncode(this.Booking, true) + "}"; ;

        }

        #endregion
    }
}