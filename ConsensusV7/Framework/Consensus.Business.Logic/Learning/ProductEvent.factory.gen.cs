using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProductEventModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProductEventFactory : LocalFactory<LocalProductEventModel, ProductEventRecord, Int32>, IProductEventFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProductEventModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProductEventModel' /> instance.
        /// </returns>
        public LocalProductEventModel Create()
        {
            return new LocalProductEventModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProductEventModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProductEventModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProductEventModel> FetchAll()
        {
            IEnumerable<ProductEventRecord> recordCollection = this.Provider.DataProvider.Learning.ProductEvent.FetchAll();
            foreach (ProductEventRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProductEventModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProductEventModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductEventModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProductEventModel FetchById(Int32 id)
        {
            ProductEventRecord record = this.Provider.DataProvider.Learning.ProductEvent.FetchById(id);
            if (record == null)
                return null;
            return new LocalProductEventModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProductEvent/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.ProductEvent.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductEventModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='ProductEventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductEventModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalProductEventModel> FetchAllByProductId(String productId)
        {
            IEnumerable<ProductEventRecord> recordCollection = this.Provider.DataProvider.Learning.ProductEvent.FetchAllByProdId(productId);
            foreach (ProductEventRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductEventModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProductEventModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductEventModel" /> instance.
        /// </returns>
        Consensus.Learning.IProductEventModel IProductEventFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductEventModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductEventModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductEventModel> IProductEventFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductEventModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductEventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductEventModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProductEventModel IProductEventFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IProductEventFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductEventModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ProductEventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductEventModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductEventModel> IProductEventFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        #endregion
    }
}
