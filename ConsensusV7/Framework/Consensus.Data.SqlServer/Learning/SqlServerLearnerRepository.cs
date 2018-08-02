using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="DelegateRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerLearnerRepository
    {
        public override void Create(DelegateRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateDelegate");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Modify(DelegateRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateDelegate");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public DelegateRecord DelegatesToConfirm(String bookId, String approver)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusLearningDelegatesToConfirm");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", approver);
            this.MapParameterIn(command, "@PA_BOOK_ID", bookId);
            var delegates = this.Execute(command).FirstOrDefault();
            return delegates;
        }

        public DelegateRecord CancelBooking(String bookId, String userLoginId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusLearningDelegatesToCancel");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", userLoginId);
            this.MapParameterIn(command, "@PA_BOOK_ID", bookId);
            var bookings = this.Execute(command).FirstOrDefault();
            return bookings;
        }
    }
}
