using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProductProdXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IRelatedProductRepository : IRepository<ProductProdXrefRecord, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="relatedProdId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductProdXrefRecord" /> instances that match the specified <paramref name="relatedProdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductProdXrefRecord> FetchAllByRelatedProdId(System.String relatedProdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="schnId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductProdXrefRecord" /> instances that match the specified <paramref name="schnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductProdXrefRecord> FetchAllBySchnId(System.String schnId);

        #endregion
    }
}
