using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LearnerModel" /> object.
    /// </summary>
    public partial class LocalLearnerFactory
    {
        public LocalLearnerModel DelegatesToConfirm(System.String bookId, System.String approver)
        {
            //Update person details
            DelegateRecord record = this.Provider.DataProvider.Learning.Learner.DelegatesToConfirm(bookId,approver);
            LocalLearnerModel model = record == null ? null : new LocalLearnerModel(this.Provider, record);
            return model;
        }

        public LocalLearnerModel CancelBooking(System.String bookId, System.String userLoginId)
        {
            //Update person details
            DelegateRecord record = this.Provider.DataProvider.Learning.Learner.CancelBooking(bookId, userLoginId);
            LocalLearnerModel model = record == null ? null : new LocalLearnerModel(this.Provider, record);
            return model;
        }
    }
}
