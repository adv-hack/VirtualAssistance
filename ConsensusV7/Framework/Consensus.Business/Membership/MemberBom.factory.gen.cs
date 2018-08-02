using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MemberBomModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMemberBomFactory : IFactory<IMemberBomModel, String>
    {
        /// <summary>
        ///     Check if same grade already exist.
        /// </summary>
        /// <param name="parentProdId">
        ///     Parent product Id.
        /// </param>
        /// <param name="gradeId">
        ///     Existing Grade Id.
        /// </param>
        /// <param name="MBomId">
        ///     available Grade Id.
        /// </param>
        /// <returns>
        ///     returns true if same grade alraedy exists for memebershipProduct - parentProdId.
        /// </returns>
        System.Boolean CheckIfGradeExist(System.String parentProdId, System.String gradeId, System.String MBomId);

        /// <summary>
        ///     Creates a new <see cref="!:MemberBomModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberBomModel" /> instance.
        /// </returns>
        Consensus.Membership.IMemberBomModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberBomModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberBomModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberBomModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberBomModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberBomModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IMemberBomModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberBomModel" /> instances.
        /// </summary>
        /// <param name="prodParentIdId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instances that match the specified <paramref name="prodParentIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberBomModel> FetchAllByProdParentIdId(System.String prodParentIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberBomModel" /> instances.
        /// </summary>
        /// <param name="gradeProdId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instances that match the specified <paramref name="gradeProdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberBomModel> FetchAllByGradeProdId(System.String gradeProdId);
    }
}
