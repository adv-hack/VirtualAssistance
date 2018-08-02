using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.BackOffice.learning.controls;

namespace Consensus.Web.BackOffice.learning
{
    public partial class BookingPage : BaseStandardPage<Booking, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Booking - " + this.Data.Id; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "shopping_cart"; }
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
            Booking booking = this.Data;
            this.BookingDetails.DataSource = this.Data;
            this.BookingInvoiceDetails.DataSource = this.Data;
            this.BookingLineList.ID = this.Data.Id;
            this.BookingPaymentList.Booking = this.Data.Id;
            this.BookingInvoiceList.Booking = this.Data.Id;
            this.BookingCreditNoteList.DataSource = booking;
            this.BookingPaymentList.PaymentType = BookingPaymentList.PaymentListType.Booking;

            this.PopulateSideBar("javascript:confirmBooking('" + this.Data.Id + "');", "Confirm booking");
            this.PopulateSideBar("javascript:createInvoice('" + this.Data.Id + "','" + this.Data.SellingCompanyId + "');", "Create invoice");
            this.PopulateSideBar("javascript:cancelBooking('" + this.Data.Id + "');", "Cancel booking");
            //this.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, @"
            //    function confirmBooking(bookId) {                        
            //              consensus.network.send({
            //                method: 'post',
            //                url: 'learning/booking/GetConfirmedEvents?bookId=' + bookId,
            //                success: function (result) {

            //                  swal({ title: 'Success', text: 'Booking successfully confirmed', type: 'warning', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (success) { 
            //                    //window.location.href = consensus.resolveUrl('~/crm/person?id=' + result.Id);
            //                    });

            //                }
            //              });
            //    }
            //", true);

            SetSendPackSidebarOption();
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.BookingPaymentList.DataTable.CreateUrl += "&parent=booking";
        }
        #endregion
    }
}