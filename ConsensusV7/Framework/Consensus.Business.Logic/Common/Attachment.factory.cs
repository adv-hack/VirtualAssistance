using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AttachmentModel" /> object.
    /// </summary>
    public partial class LocalAttachmentFactory
    {
        /// <summary>
        ///  Fetch the attachments for a particular instance of a model entity.
        /// </summary>
        /// <param name="Url">The entity, e.g. "Contact/Person"</param>
        /// <param name="recordId">The Id of the record in the entity.</param>
        /// <returns></returns>
        public IEnumerable<LocalAttachmentModel> FetchAllByUrlAndRecordId(String Url, String recordId)
        {
            IEnumerable<AttachmentRecord> recordCollection = this.Provider.DataProvider.Common.Attachment.FetchAllByUrlAndRecordId(Url, recordId);
            IEnumerable<LocalAttachmentModel> modelCollection = recordCollection.Select(record => new LocalAttachmentModel(this.Provider, record));
            return modelCollection;
        }
    }
}
