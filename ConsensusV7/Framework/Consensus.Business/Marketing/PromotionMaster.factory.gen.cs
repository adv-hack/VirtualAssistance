using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PromotionMasterModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPromotionMasterFactory : IFactory<IPromotionMasterModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PromotionMasterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PromotionMasterModel" /> instance.
        /// </returns>
        Consensus.Marketing.IPromotionMasterModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PromotionMasterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionMasterModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PromotionMasterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PromotionMasterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.IPromotionMasterModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="cmpIdId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="cmpIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionMasterModel> FetchAllByCmpIdId(System.String cmpIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionMasterModel> FetchAllByCourseIdId(System.String courseIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionMasterModel> FetchAllByManagerId(System.String managerId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.IPromotionMasterModel> FetchAllByApproverId(System.String approverId);
    }
}
