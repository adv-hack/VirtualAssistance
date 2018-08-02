using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Membership namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMembershipFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MembershipModel" /> objects.
        /// </summary>
        Consensus.Membership.IMembershipFactory Membership
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MemberPeriodModel" /> objects.
        /// </summary>
        Consensus.Membership.IMemberPeriodFactory MemberPeriod
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MemberLocationModel" /> objects.
        /// </summary>
        Consensus.Membership.IMemberLocationFactory MemberLocation
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MemberBomModel" /> objects.
        /// </summary>
        Consensus.Membership.IMemberBomFactory MemberBom
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BranchModel" /> objects.
        /// </summary>
        Consensus.Membership.IBranchFactory Branch
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BranchXrefModel" /> objects.
        /// </summary>
        Consensus.Membership.IBranchXrefFactory BranchXref
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CommitteeModel" /> objects.
        /// </summary>
        Consensus.Membership.ICommitteeFactory Committee
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:DistrictModel" /> objects.
        /// </summary>
        Consensus.Membership.IDistrictFactory District
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CommitteeXrefModel" /> objects.
        /// </summary>
        Consensus.Membership.ICommitteeXrefFactory CommitteeXref
        {
            get;
        }
    }
}
