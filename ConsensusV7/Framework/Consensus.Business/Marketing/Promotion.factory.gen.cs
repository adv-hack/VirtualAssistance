using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PromotionModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPromotionFactory : IFactory<IPromotionModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PromotionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PromotionModel" /> instance.
        /// </returns>
        Consensus.Marketing.IPromotionModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PromotionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PromotionModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PromotionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PromotionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.IPromotionModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="promotionMasterId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="promotionMasterId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionModel> FetchAllByPromotionMasterId(System.String promotionMasterId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionModel> FetchAllByManagerId(System.String managerId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionModel> FetchAllByApproverId(System.String approverId);
    }
}
