using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="RelatedProductModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalRelatedProductFactory : LocalFactory<LocalRelatedProductModel, ProductProdXrefRecord, Int32>, IRelatedProductFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='RelatedProductModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='RelatedProductModel' /> instance.
        /// </returns>
        public LocalRelatedProductModel Create()
        {
            return new LocalRelatedProductModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='RelatedProductModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='RelatedProductModel' /> instances.
        /// </returns>
        public IEnumerable<LocalRelatedProductModel> FetchAll()
        {
            IEnumerable<ProductProdXrefRecord> recordCollection = this.Provider.DataProvider.Learning.RelatedProduct.FetchAll();
            foreach (ProductProdXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalRelatedProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='RelatedProductModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='RelatedProductModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='RelatedProductModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalRelatedProductModel FetchById(Int32 id)
        {
            ProductProdXrefRecord record = this.Provider.DataProvider.Learning.RelatedProduct.FetchById(id);
            if (record == null)
                return null;
            return new LocalRelatedProductModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='RelatedProduct/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.RelatedProduct.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='RelatedProductModel' /> instances.
        /// </summary>
        /// <param name="relatedProdIdId">
        ///     The value which identifies the <see cref='RelatedProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='RelatedProductModel' /> instances that match the specified <paramref name='relatedProdIdId' />.
        /// </returns>
        public IEnumerable<LocalRelatedProductModel> FetchAllByRelatedProdIdId(String relatedProdIdId)
        {
            IEnumerable<ProductProdXrefRecord> recordCollection = this.Provider.DataProvider.Learning.RelatedProduct.FetchAllByRelatedProdId(relatedProdIdId);
            foreach (ProductProdXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalRelatedProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='RelatedProductModel' /> instances.
        /// </summary>
        /// <param name="salesChannelId">
        ///     The value which identifies the <see cref='RelatedProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='RelatedProductModel' /> instances that match the specified <paramref name='salesChannelId' />.
        /// </returns>
        public IEnumerable<LocalRelatedProductModel> FetchAllBySalesChannelId(String salesChannelId)
        {
            IEnumerable<ProductProdXrefRecord> recordCollection = this.Provider.DataProvider.Learning.RelatedProduct.FetchAllBySchnId(salesChannelId);
            foreach (ProductProdXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalRelatedProductModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:RelatedProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:RelatedProductModel" /> instance.
        /// </returns>
        Consensus.Learning.IRelatedProductModel IRelatedProductFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:RelatedProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:RelatedProductModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IRelatedProductModel> IRelatedProductFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:RelatedProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:RelatedProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IRelatedProductModel IRelatedProductFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IRelatedProductFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RelatedProductModel" /> instances.
        /// </summary>
        /// <param name="relatedProdIdId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instances that match the specified <paramref name="relatedProdIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IRelatedProductModel> IRelatedProductFactory.FetchAllByRelatedProdIdId(System.String relatedProdIdId)
        {
            return this.FetchAllByRelatedProdIdId(relatedProdIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RelatedProductModel" /> instances.
        /// </summary>
        /// <param name="salesChannelId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instances that match the specified <paramref name="salesChannelId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IRelatedProductModel> IRelatedProductFactory.FetchAllBySalesChannelId(System.String salesChannelId)
        {
            return this.FetchAllBySalesChannelId(salesChannelId);
        }

        #endregion
    }
}
