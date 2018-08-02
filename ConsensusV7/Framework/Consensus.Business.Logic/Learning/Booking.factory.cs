using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BookingModel" /> object.
    /// </summary>
    public partial class LocalBookingFactory
    {
        public LocalBookingModel GetConfirmedEvents(System.String bookId)
        {
            //Update person details
            BookingRecord record = this.Provider.DataProvider.Learning.Booking.GetConfirmedEvents(bookId);
            LocalBookingModel model = record == null ? null : new LocalBookingModel(this.Provider, record);
            return model;
        }
        
        public IEnumerable<LocalBookingModel> BookingGenerateGrpId(String bookId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.BookingGenerateGrpId(bookId);
            IEnumerable<LocalBookingModel> modelCollection = recordCollection.Select(record => new LocalBookingModel(this.Provider, record));
            return modelCollection;
        }

        public IEnumerable<LocalBookingModel> GetBookingLines(String bookId, string userLoginId,String sellingCompany)
        {
            IEnumerable<BookingRecord> bookingrecords = this.Provider.DataProvider.Learning.Booking.GetBookingLines(bookId, userLoginId);
            IEnumerable<LocalBookingModel> bookingLines = bookingrecords.Select(record => new LocalBookingModel(this.Provider, record));
            if (bookingLines.Count() > 0)
            {
                this.Provider.DataProvider.Finance.Invoice.CreateInvoice(bookId, userLoginId, sellingCompany, 1);
                var invoiceLines = this.Provider.DataProvider.Finance.InvoiceLine.FetchAllByBookId(bookId).OrderByDescending(x => x.InvId);
                IEnumerable<LocalBookingModel> invoicedMember = this.Provider.Learning.Booking.FetchAll().Where(bk => bk.Id == bookId && bk.Invoiced == 1).ToList();

                return invoicedMember;
            }
            else
                return bookingLines;
        }

        public bool CheckIfBookingAlreadyCancelled(string bookId)
        {
            var booklist = this.FetchAll().ToList();
            var booked = booklist.Where(x => x.Id == bookId && x.Status == "99-Cancelled").ToList();
            bool result = false;
            if (booked.Count > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
