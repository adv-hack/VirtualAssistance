using System;
using System.Collections.Generic;
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
    public partial class LocalMembershipFactoryCollection : LocalFactoryCollection, IMembershipFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="MembershipModel" /> objects.
        /// </summary>
        private LocalMembershipFactory _membership;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="MemberPeriodModel" /> objects.
        /// </summary>
        private LocalMemberPeriodFactory _memberPeriod;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="MemberLocationModel" /> objects.
        /// </summary>
        private LocalMemberLocationFactory _memberLocation;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="MemberBomModel" /> objects.
        /// </summary>
        private LocalMemberBomFactory _memberBom;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="BranchModel" /> objects.
        /// </summary>
        private LocalBranchFactory _branch;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="BranchXrefModel" /> objects.
        /// </summary>
        private LocalBranchXrefFactory _branchXref;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CommitteeModel" /> objects.
        /// </summary>
        private LocalCommitteeFactory _committee;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="DistrictModel" /> objects.
        /// </summary>
        private LocalDistrictFactory _district;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CommitteeXrefModel" /> objects.
        /// </summary>
        private LocalCommitteeXrefFactory _committeeXref;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="MembershipModel" /> objects.
        /// </summary>
        public LocalMembershipFactory Membership
        {
            get { return LocalFactory.Create(this.Provider, ref _membership); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="MemberPeriodModel" /> objects.
        /// </summary>
        public LocalMemberPeriodFactory MemberPeriod
        {
            get { return LocalFactory.Create(this.Provider, ref _memberPeriod); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="MemberLocationModel" /> objects.
        /// </summary>
        public LocalMemberLocationFactory MemberLocation
        {
            get { return LocalFactory.Create(this.Provider, ref _memberLocation); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="MemberBomModel" /> objects.
        /// </summary>
        public LocalMemberBomFactory MemberBom
        {
            get { return LocalFactory.Create(this.Provider, ref _memberBom); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="BranchModel" /> objects.
        /// </summary>
        public LocalBranchFactory Branch
        {
            get { return LocalFactory.Create(this.Provider, ref _branch); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="BranchXrefModel" /> objects.
        /// </summary>
        public LocalBranchXrefFactory BranchXref
        {
            get { return LocalFactory.Create(this.Provider, ref _branchXref); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CommitteeModel" /> objects.
        /// </summary>
        public LocalCommitteeFactory Committee
        {
            get { return LocalFactory.Create(this.Provider, ref _committee); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="DistrictModel" /> objects.
        /// </summary>
        public LocalDistrictFactory District
        {
            get { return LocalFactory.Create(this.Provider, ref _district); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CommitteeXrefModel" /> objects.
        /// </summary>
        public LocalCommitteeXrefFactory CommitteeXref
        {
            get { return LocalFactory.Create(this.Provider, ref _committeeXref); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MembershipModel" /> objects.
        /// </summary>
        Consensus.Membership.IMembershipFactory IMembershipFactoryCollection.Membership
        {
            get { return this.Membership; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MemberPeriodModel" /> objects.
        /// </summary>
        Consensus.Membership.IMemberPeriodFactory IMembershipFactoryCollection.MemberPeriod
        {
            get { return this.MemberPeriod; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MemberLocationModel" /> objects.
        /// </summary>
        Consensus.Membership.IMemberLocationFactory IMembershipFactoryCollection.MemberLocation
        {
            get { return this.MemberLocation; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MemberBomModel" /> objects.
        /// </summary>
        Consensus.Membership.IMemberBomFactory IMembershipFactoryCollection.MemberBom
        {
            get { return this.MemberBom; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BranchModel" /> objects.
        /// </summary>
        Consensus.Membership.IBranchFactory IMembershipFactoryCollection.Branch
        {
            get { return this.Branch; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BranchXrefModel" /> objects.
        /// </summary>
        Consensus.Membership.IBranchXrefFactory IMembershipFactoryCollection.BranchXref
        {
            get { return this.BranchXref; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CommitteeModel" /> objects.
        /// </summary>
        Consensus.Membership.ICommitteeFactory IMembershipFactoryCollection.Committee
        {
            get { return this.Committee; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:DistrictModel" /> objects.
        /// </summary>
        Consensus.Membership.IDistrictFactory IMembershipFactoryCollection.District
        {
            get { return this.District; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CommitteeXrefModel" /> objects.
        /// </summary>
        Consensus.Membership.ICommitteeXrefFactory IMembershipFactoryCollection.CommitteeXref
        {
            get { return this.CommitteeXref; }
        }

        #endregion
    }
}
