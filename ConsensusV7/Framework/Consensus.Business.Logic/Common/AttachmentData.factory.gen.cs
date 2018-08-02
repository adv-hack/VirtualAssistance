using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AttachmentDataModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAttachmentDataFactory : LocalFactory<LocalAttachmentDataModel, AttachmentDataRecord, Int32>, IAttachmentDataFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='AttachmentDataModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='AttachmentDataModel' /> instance.
        /// </returns>
        public LocalAttachmentDataModel Create()
        {
            return new LocalAttachmentDataModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='AttachmentDataModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='AttachmentDataModel' /> instances.
        /// </returns>
        public IEnumerable<LocalAttachmentDataModel> FetchAll()
        {
            IEnumerable<AttachmentDataRecord> recordCollection = this.Provider.DataProvider.Common.AttachmentData.FetchAll();
            foreach (AttachmentDataRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAttachmentDataModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='AttachmentDataModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='AttachmentDataModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AttachmentDataModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalAttachmentDataModel FetchById(Int32 id)
        {
            AttachmentDataRecord record = this.Provider.DataProvider.Common.AttachmentData.FetchById(id);
            if (record == null)
                return null;
            return new LocalAttachmentDataModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='AttachmentData/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.AttachmentData.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AttachmentDataModel' /> instances.
        /// </summary>
        /// <param name="attIdId">
        ///     The value which identifies the <see cref='AttachmentDataModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AttachmentDataModel' /> instances that match the specified <paramref name='attIdId' />.
        /// </returns>
        public IEnumerable<LocalAttachmentDataModel> FetchAllByAttIdId(String attIdId)
        {
            IEnumerable<AttachmentDataRecord> recordCollection = this.Provider.DataProvider.Common.AttachmentData.FetchAllByAttId(attIdId);
            foreach (AttachmentDataRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAttachmentDataModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:AttachmentDataModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachmentDataModel" /> instance.
        /// </returns>
        Consensus.Common.IAttachmentDataModel IAttachmentDataFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachmentDataModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachmentDataModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachmentDataModel> IAttachmentDataFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachmentDataModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachmentDataModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentDataModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IAttachmentDataModel IAttachmentDataFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IAttachmentDataFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachmentDataModel" /> instances.
        /// </summary>
        /// <param name="attIdId">
        ///     The value which identifies the <see cref="!:AttachmentDataModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentDataModel" /> instances that match the specified <paramref name="attIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachmentDataModel> IAttachmentDataFactory.FetchAllByAttIdId(System.String attIdId)
        {
            return this.FetchAllByAttIdId(attIdId);
        }

        #endregion
    }
}
