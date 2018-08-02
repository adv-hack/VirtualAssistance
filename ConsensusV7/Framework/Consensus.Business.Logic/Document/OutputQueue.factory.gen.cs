using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="OutputQueueModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOutputQueueFactory : LocalFactory<LocalOutputQueueModel, PrintQueueRecord, String>, IOutputQueueFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='OutputQueueModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='OutputQueueModel' /> instance.
        /// </returns>
        public LocalOutputQueueModel Create()
        {
            return new LocalOutputQueueModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='OutputQueueModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='OutputQueueModel' /> instances.
        /// </returns>
        public IEnumerable<LocalOutputQueueModel> FetchAll()
        {
            IEnumerable<PrintQueueRecord> recordCollection = this.Provider.DataProvider.Document.OutputQueue.FetchAll();
            foreach (PrintQueueRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOutputQueueModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='OutputQueueModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='OutputQueueModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OutputQueueModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalOutputQueueModel FetchById(String id)
        {
            PrintQueueRecord record = this.Provider.DataProvider.Document.OutputQueue.FetchById(id);
            if (record == null)
                return null;
            return new LocalOutputQueueModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='OutputQueue/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.OutputQueue.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OutputQueueModel' /> instances.
        /// </summary>
        /// <param name="adminProleId">
        ///     The value which identifies the <see cref='OutputQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OutputQueueModel' /> instances that match the specified <paramref name='adminProleId' />.
        /// </returns>
        public IEnumerable<LocalOutputQueueModel> FetchAllByAdminProleId(String adminProleId)
        {
            IEnumerable<PrintQueueRecord> recordCollection = this.Provider.DataProvider.Document.OutputQueue.FetchAllByAdminProleId(adminProleId);
            foreach (PrintQueueRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOutputQueueModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:OutputQueueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OutputQueueModel" /> instance.
        /// </returns>
        Consensus.Document.IOutputQueueModel IOutputQueueFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OutputQueueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OutputQueueModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IOutputQueueModel> IOutputQueueFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OutputQueueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OutputQueueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OutputQueueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IOutputQueueModel IOutputQueueFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IOutputQueueFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OutputQueueModel" /> instances.
        /// </summary>
        /// <param name="adminProleId">
        ///     The value which identifies the <see cref="!:OutputQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OutputQueueModel" /> instances that match the specified <paramref name="adminProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IOutputQueueModel> IOutputQueueFactory.FetchAllByAdminProleId(System.String adminProleId)
        {
            return this.FetchAllByAdminProleId(adminProleId);
        }

        #endregion
    }
}
