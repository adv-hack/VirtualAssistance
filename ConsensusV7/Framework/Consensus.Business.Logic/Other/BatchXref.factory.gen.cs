using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BatchXrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBatchXrefFactory : LocalFactory<LocalBatchXrefModel, BatchXrefRecord, Int32>, IBatchXrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='BatchXrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='BatchXrefModel' /> instance.
        /// </returns>
        public LocalBatchXrefModel Create()
        {
            return new LocalBatchXrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='BatchXrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='BatchXrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalBatchXrefModel> FetchAll()
        {
            IEnumerable<BatchXrefRecord> recordCollection = this.Provider.DataProvider.Other.BatchXref.FetchAll();
            foreach (BatchXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBatchXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='BatchXrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='BatchXrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BatchXrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalBatchXrefModel FetchById(Int32 id)
        {
            BatchXrefRecord record = this.Provider.DataProvider.Other.BatchXref.FetchById(id);
            if (record == null)
                return null;
            return new LocalBatchXrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='BatchXref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Other.BatchXref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BatchXrefModel' /> instances.
        /// </summary>
        /// <param name="batchId">
        ///     The value which identifies the <see cref='BatchXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BatchXrefModel' /> instances that match the specified <paramref name='batchId' />.
        /// </returns>
        public IEnumerable<LocalBatchXrefModel> FetchAllByBatchId(String batchId)
        {
            IEnumerable<BatchXrefRecord> recordCollection = this.Provider.DataProvider.Other.BatchXref.FetchAllByBatId(batchId);
            foreach (BatchXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBatchXrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:BatchXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BatchXrefModel" /> instance.
        /// </returns>
        Consensus.Other.IBatchXrefModel IBatchXrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BatchXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BatchXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchXrefModel> IBatchXrefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BatchXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BatchXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IBatchXrefModel IBatchXrefFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IBatchXrefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BatchXrefModel" /> instances.
        /// </summary>
        /// <param name="batchId">
        ///     The value which identifies the <see cref="!:BatchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchXrefModel" /> instances that match the specified <paramref name="batchId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchXrefModel> IBatchXrefFactory.FetchAllByBatchId(System.String batchId)
        {
            return this.FetchAllByBatchId(batchId);
        }

        #endregion
    }
}
