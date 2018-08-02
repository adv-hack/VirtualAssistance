using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BookingRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerBookingRepository
    {
        public override void Create(BookingRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateBooking");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(BookingRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateBooking");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public BookingRecord GetConfirmedEvents(String bookId)
        {

            DbCommand command = this.Provider.GetStoredProcedure("spConsensusLearningConfirmedEvents");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParameterIn(command, "@PA_BOOK_ID", bookId);
            var courseCount = this.Execute(command).FirstOrDefault();
            return courseCount;
        }

        public IEnumerable<BookingRecord> BookingGenerateGrpId(String bookId)
        {
          DbCommand command = this.Provider.GetStoredProcedure("spConsensusLearningBookingGenerateGrpId");
          this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
          this.MapParameterIn(command, "@PA_BOOK_ID", bookId);
          return this.Execute(command);
        }
        /// <summary>
        /// Get Booking Lines if available to Create Invoice
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="UserLoginId"></param>
        /// <returns></returns>
        public IEnumerable<BookingRecord> GetBookingLines(String bookId, String UserLoginId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusLearningBookLinesToInvoice");
            //this.MapParameterIn(command, "@PA_USER_LOGIN_ID", UserLoginId);
            this.MapParameterIn(command, "@PA_BOOK_ID", bookId);
            var bookingLines = this.Execute(command);
            return bookingLines;
        }

    }
}
