using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CommitteeXrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommitteeXrefFactory : IFactory<ICommitteeXrefModel, String>
    {
        System.Boolean CheckIfPersonExist(System.String committeeid, System.String personid, System.String committeexrefid);

        /// <summary>
        ///     Creates a new <see cref="!:CommitteeXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommitteeXrefModel" /> instance.
        /// </returns>
        Consensus.Membership.ICommitteeXrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommitteeXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommitteeXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeXrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommitteeXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommitteeXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.ICommitteeXrefModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeXrefModel" /> instances.
        /// </summary>
        /// <param name="committeeId">
        ///     The value which identifies the <see cref="!:CommitteeXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeXrefModel" /> instances that match the specified <paramref name="committeeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeXrefModel> FetchAllByCommitteeId(System.String committeeId);
    }
}
