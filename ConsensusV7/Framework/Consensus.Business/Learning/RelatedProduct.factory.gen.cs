using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="RelatedProductModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IRelatedProductFactory : IFactory<IRelatedProductModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:RelatedProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:RelatedProductModel" /> instance.
        /// </returns>
        Consensus.Learning.IRelatedProductModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:RelatedProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:RelatedProductModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IRelatedProductModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:RelatedProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:RelatedProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IRelatedProductModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RelatedProductModel" /> instances.
        /// </summary>
        /// <param name="relatedProdIdId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instances that match the specified <paramref name="relatedProdIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IRelatedProductModel> FetchAllByRelatedProdIdId(System.String relatedProdIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RelatedProductModel" /> instances.
        /// </summary>
        /// <param name="salesChannelId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instances that match the specified <paramref name="salesChannelId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IRelatedProductModel> FetchAllBySalesChannelId(System.String salesChannelId);
    }
}
