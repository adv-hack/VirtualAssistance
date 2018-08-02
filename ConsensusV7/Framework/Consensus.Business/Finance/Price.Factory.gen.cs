using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PriceModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPriceFactory : IFactory<IPriceModel, String>
    {
        Consensus.Finance.IPriceModel RecalculateMemberFee(System.String productId, System.String plId, System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, System.Int32 qtyTotal);

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instance that matches the specified <paramref name="productId" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceModel> FetchAllByProdidPriceListid(System.String productId, System.String plId);

        /// <summary>
        ///     Creates a new <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PriceModel" /> instance.
        /// </returns>
        Consensus.Finance.IPriceModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PriceModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PriceModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PriceModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPriceModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PriceModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceModel> FetchAllByPriceListId(System.String priceListId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PriceModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceModel> FetchAllByProductId(System.String productId);
    }
}
