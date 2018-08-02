using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CommitteeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommitteeFactory : IFactory<ICommitteeModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:CommitteeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommitteeModel" /> instance.
        /// </returns>
        Consensus.Membership.ICommitteeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommitteeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommitteeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommitteeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommitteeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.ICommitteeModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="disIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="disIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeModel> FetchAllByDisIdId(System.String disIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="prodIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="prodIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeModel> FetchAllByProdIdId(System.String prodIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="brIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="brIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeModel> FetchAllByBrIdId(System.String brIdId);
    }
}
