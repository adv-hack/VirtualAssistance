using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PriceListModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPriceListFactory : IFactory<IPriceListModel, String>
    {
        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.IPriceListModel" /> instances, that are referenced by the valid prices recorded against a given product.
        /// </summary>
        /// <param name="productId">
        ///     The unique identifier for the product whoses prices are inspected.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.IPriceListModel" /> that are referenced by the valid prices recorded against the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceListModel> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Creates a new <see cref="!:PriceListModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PriceListModel" /> instance.
        /// </returns>
        Consensus.Finance.IPriceListModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PriceListModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PriceListModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceListModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceListModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PriceListModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceListModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPriceListModel FetchById(System.String id);

        System.String GetTableName();
    }
}
