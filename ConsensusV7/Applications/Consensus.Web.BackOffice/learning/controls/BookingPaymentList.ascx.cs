using Consensus.Web.Controls;
using Consensus.Searches;
using System;
using System.Web;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class BookingPaymentList : BaseListControl
    {
        #region enums

        /// <summary>
        ///     Enumerates the different modes that the associate list can be used for.
        /// </summary>
        public enum PaymentListType
        {
            Account,
            Booking,
            Payment
        }

        #endregion

        #region fields
        /// <summary>
        ///     The ID of the parent object that the records are linked to.
        /// </summary>
        private String _booking;

        /// <summary>
        ///     The mode that the opportunity list is be used for.
        /// </summary>
        private PaymentListType _paymentListType;


        /// <summary>
        /// account ID for the account payments.
        /// </summary>
        private string _accountId;


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

        public string AccountId
        {
            get { return _accountId; }
            set { _accountId = value; }
        }

        /// <summary>
        ///    Gets or sets the mode that the opportunity list is be used for.
        /// </summary>
        public PaymentListType PaymentType
        {
            get { return _paymentListType; }
            set { _paymentListType = value; }
        }



        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Payment List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.PaymentListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                IQueryOrderable result = null;
                IQueryConditionable query = Query.Create()
                    .Select("PAY_ID")
                    .Select("PAY_DATE")
                    .Select("PAY_REF")
                    .Select("PAY_TYPE")
                    .Select("ACC_SYSTEM_REF")
                    .Select("PAY_NAME")
                    .Select("ORG_NAME")
                    .Select("PAY_UNUSED_VAL")
                    .Select("PAY_RECVD")
                    .Select("PAY_CURR_TYPE")
                    .Select("uri")
                    .From(QuerySources.BookingPayments);
                switch (this.PaymentType)
                {
                    case PaymentListType.Booking: result = query.WhereRaw("(PAY_BOOK_ID = '" + this.Booking + "' or  exists (select PA_ID from Pay_Allocation where PA_PAY_ID = PAY_ID and PA_BOOK_ID = '" + this.Booking + "'))", null); break;
                    case PaymentListType.Account: result = query.Where("PAY_ACC_ID", QueryConditionTypes.Equal, this.AccountId); break;
                    case PaymentListType.Payment: result = query.Where("PAY_BOOK_ID", QueryConditionTypes.Equal, this.Booking); break;
                }
                return result.OrderBy("PAY_DATE", true);
            }
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.CreateUrl += "&bookingId=" + HttpUtility.UrlEncode(this.Booking);
            this.DataTable.Json = "{ uri: \"finance/payment\", bookId: " + HttpUtility.JavaScriptStringEncode(this.Booking, true) + "}";

        }

        #endregion
    }
}