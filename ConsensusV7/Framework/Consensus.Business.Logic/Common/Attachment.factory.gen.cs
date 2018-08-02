using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AttachmentModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAttachmentFactory : LocalFactory<LocalAttachmentModel, AttachmentRecord, String>, IAttachmentFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='AttachmentModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='AttachmentModel' /> instance.
        /// </returns>
        public LocalAttachmentModel Create()
        {
            return new LocalAttachmentModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='AttachmentModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='AttachmentModel' /> instances.
        /// </returns>
        public IEnumerable<LocalAttachmentModel> FetchAll()
        {
            IEnumerable<AttachmentRecord> recordCollection = this.Provider.DataProvider.Common.Attachment.FetchAll();
            foreach (AttachmentRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAttachmentModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='AttachmentModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='AttachmentModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AttachmentModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalAttachmentModel FetchById(String id)
        {
            AttachmentRecord record = this.Provider.DataProvider.Common.Attachment.FetchById(id);
            if (record == null)
                return null;
            return new LocalAttachmentModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Attachment/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.Attachment.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Fetch the attachments for a particular instance of a model entity.
        /// </summary>
        /// <param name="Url">
        ///     The entity, e.g. "Contact/Person".
        /// </param>
        /// <param name="recordId">
        ///     The Id of the record in the entity.
        /// </param>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachmentModel> IAttachmentFactory.FetchAllByUrlAndRecordId(System.String Url, System.String recordId)
        {
            return this.FetchAllByUrlAndRecordId(Url, recordId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AttachmentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachmentModel" /> instance.
        /// </returns>
        Consensus.Common.IAttachmentModel IAttachmentFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachmentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachmentModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachmentModel> IAttachmentFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachmentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachmentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IAttachmentModel IAttachmentFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IAttachmentFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
