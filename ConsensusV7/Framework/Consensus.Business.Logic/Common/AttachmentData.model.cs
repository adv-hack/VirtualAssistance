using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using Consensus;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="AttachmentDataRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalAttachmentDataModel
    {
        public override void Save()
        {
            // Create an isolated transaction that doesn't inherit the wrapping transaction. 
            // This is because the Attachment_Data table may be in a different database
            // and we don't want to bother with having to use the distributed transaction
            // coordinator. This doesn't affect the behaviour significantly - underlying transactions will
            // still be rolled back if this throws an exception.
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Suppress))
            {
                base.Save();
                transaction.Complete();
            }
        }

        public override void Delete()
        {
            // Same for delete..
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Suppress))
            {
                base.Delete();
                transaction.Complete();
            }
        }

    }
}
