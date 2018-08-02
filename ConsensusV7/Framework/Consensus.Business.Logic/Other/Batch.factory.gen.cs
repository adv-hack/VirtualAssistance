using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BatchModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBatchFactory : LocalFactory<LocalBatchModel, BatchRecord, String>, IBatchFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='BatchModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='BatchModel' /> instance.
        /// </returns>
        public LocalBatchModel Create()
        {
            return new LocalBatchModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='BatchModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='BatchModel' /> instances.
        /// </returns>
        public IEnumerable<LocalBatchModel> FetchAll()
        {
            IEnumerable<BatchRecord> recordCollection = this.Provider.DataProvider.Other.Batch.FetchAll();
            foreach (BatchRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBatchModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='BatchModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='BatchModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BatchModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalBatchModel FetchById(String id)
        {
            BatchRecord record = this.Provider.DataProvider.Other.Batch.FetchById(id);
            if (record == null)
                return null;
            return new LocalBatchModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Batch/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Other.Batch.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BatchModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='BatchModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BatchModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalBatchModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<BatchRecord> recordCollection = this.Provider.DataProvider.Other.Batch.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (BatchRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBatchModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BatchModel' /> instances.
        /// </summary>
        /// <param name="batchEcIdId">
        ///     The value which identifies the <see cref='BatchModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BatchModel' /> instances that match the specified <paramref name='batchEcIdId' />.
        /// </returns>
        public IEnumerable<LocalBatchModel> FetchAllByBatchEcIdId(Int32? batchEcIdId)
        {
            IEnumerable<BatchRecord> recordCollection = this.Provider.DataProvider.Other.Batch.FetchAllByEcId(batchEcIdId);
            foreach (BatchRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBatchModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BatchModel' /> instances.
        /// </summary>
        /// <param name="batchDiIdId">
        ///     The value which identifies the <see cref='BatchModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BatchModel' /> instances that match the specified <paramref name='batchDiIdId' />.
        /// </returns>
        public IEnumerable<LocalBatchModel> FetchAllByBatchDiIdId(Int32? batchDiIdId)
        {
            IEnumerable<BatchRecord> recordCollection = this.Provider.DataProvider.Other.Batch.FetchAllByDiId(batchDiIdId);
            foreach (BatchRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBatchModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:BatchModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BatchModel" /> instance.
        /// </returns>
        Consensus.Other.IBatchModel IBatchFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BatchModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BatchModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchModel> IBatchFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BatchModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BatchModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IBatchModel IBatchFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IBatchFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BatchModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:BatchModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchModel> IBatchFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchModel> IBatchFactory.FetchAllByBatchEcIdId(System.Nullable<System.Int32> batchEcIdId)
        {
            return this.FetchAllByBatchEcIdId(batchEcIdId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchModel> IBatchFactory.FetchAllByBatchDiIdId(System.Nullable<System.Int32> batchDiIdId)
        {
            return this.FetchAllByBatchDiIdId(batchDiIdId);
        }

        #endregion
    }
}
