using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BranchXrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBranchXrefFactory : IFactory<IBranchXrefModel, String>
    {
        /// <summary>
        ///     Checks if district already exist for that branch in database.
        /// </summary>
        /// <param name="branchid">
        ///     BranchId.
        /// </param>
        /// <param name="districtid">
        ///     DistrictId.
        /// </param>
        /// <param name="branchxrefid">
        ///     BranchXrefId.
        /// </param>
        /// <returns>
        ///     Whether that district already exist for that branch in database.
        /// </returns>
        System.Boolean CheckIfDistrictExist(System.String branchid, System.String districtid, System.String branchxrefid);

        /// <summary>
        ///     Creates a new <see cref="!:BranchXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BranchXrefModel" /> instance.
        /// </returns>
        Consensus.Membership.IBranchXrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BranchXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BranchXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IBranchXrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:BranchXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BranchXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BranchXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IBranchXrefModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BranchXrefModel" /> instances.
        /// </summary>
        /// <param name="branchId">
        ///     The value which identifies the <see cref="!:BranchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BranchXrefModel" /> instances that match the specified <paramref name="branchId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IBranchXrefModel> FetchAllByBranchId(System.String branchId);
    }
}
