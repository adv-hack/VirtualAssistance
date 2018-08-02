using Consensus.Learning;
using System;
using Consensus.Web.BackOffice.learning.controls;

namespace Consensus.Web.BackOffice.learning
{
    public partial class DonationBookingPage : BaseStandardPage<Booking, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Donation "; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "money_transfer"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Booking> DataLoader
        {
            get { return Booking.FetchById; }
        }

        //public override Func<Booking> DataCreator
        //{
        //    get { return Booking.Create; }
        //}


        #endregion
        #region methods

        protected override void PopulateControls()
        {
            this.DonationBookingDetails.DataSource = this.Data;
            this.DonationPaymentDetails.DataSource = this.Data;
            this.DonationAmountList.Booking = this.Data.Id;
            this.BookingPaymentList.Booking = this.Data.Id;
            this.BookingPaymentList.PaymentType = BookingPaymentList.PaymentListType.Payment;
            //this.BookingInvoiceList.Booking = this.Data.Id;

        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }

        #endregion
    }
}