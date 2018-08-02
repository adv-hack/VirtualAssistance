using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PackProductModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPackProductFactory : LocalFactory<LocalPackProductModel, ProductPackRecord, Int32>, IPackProductFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PackProductModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PackProductModel' /> instance.
        /// </returns>
        public LocalPackProductModel Create()
        {
            return new LocalPackProductModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PackProductModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PackProductModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPackProductModel> FetchAll()
        {
            IEnumerable<ProductPackRecord> recordCollection = this.Provider.DataProvider.Document.PackProduct.FetchAll();
            foreach (ProductPackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PackProductModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PackProductModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackProductModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPackProductModel FetchById(Int32 id)
        {
            ProductPackRecord record = this.Provider.DataProvider.Document.PackProduct.FetchById(id);
            if (record == null)
                return null;
            return new LocalPackProductModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PackProduct/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.PackProduct.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PackProductModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='PackProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackProductModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalPackProductModel> FetchAllByProductId(String productId)
        {
            IEnumerable<ProductPackRecord> recordCollection = this.Provider.DataProvider.Document.PackProduct.FetchAllByProdId(productId);
            foreach (ProductPackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PackProductModel' /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref='PackProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackProductModel' /> instances that match the specified <paramref name='packId' />.
        /// </returns>
        public IEnumerable<LocalPackProductModel> FetchAllByPackId(String packId)
        {
            IEnumerable<ProductPackRecord> recordCollection = this.Provider.DataProvider.Document.PackProduct.FetchAllByPackId(packId);
            foreach (ProductPackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackProductModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PackProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackProductModel" /> instance.
        /// </returns>
        Consensus.Document.IPackProductModel IPackProductFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackProductModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackProductModel> IPackProductFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IPackProductModel IPackProductFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IPackProductFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PackProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackProductModel> IPackProductFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackProductModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PackProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackProductModel> IPackProductFactory.FetchAllByPackId(System.String packId)
        {
            return this.FetchAllByPackId(packId);
        }

        #endregion
    }
}
