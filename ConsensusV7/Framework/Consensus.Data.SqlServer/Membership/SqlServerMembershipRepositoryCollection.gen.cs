using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Membership namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerMembershipRepositoryCollection : SqlServerRepositoryCollection, IMembershipRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="MembershipRecord" /> data structure.
        /// </summary>
        private SqlServerMembershipRepository _membership;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="MemberPeriodRecord" /> data structure.
        /// </summary>
        private SqlServerMemberPeriodRepository _memberPeriod;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="MemberLocationRecord" /> data structure.
        /// </summary>
        private SqlServerMemberLocationRepository _memberLocation;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="MemberBomRecord" /> data structure.
        /// </summary>
        private SqlServerMemberBomRepository _memberBom;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BranchRecord" /> data structure.
        /// </summary>
        private SqlServerBranchRepository _branch;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BranchXrefRecord" /> data structure.
        /// </summary>
        private SqlServerBranchXrefRepository _branchXref;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CommitteeRecord" /> data structure.
        /// </summary>
        private SqlServerCommitteeRepository _committee;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="DistrictRecord" /> data structure.
        /// </summary>
        private SqlServerDistrictRepository _district;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CommitteeXrefRecord" /> data structure.
        /// </summary>
        private SqlServerCommitteeXrefRepository _committeeXref;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="MembershipRecord" /> data structure.
        /// </summary>
        public SqlServerMembershipRepository Membership
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerMembershipRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _membership);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="MemberPeriodRecord" /> data structure.
        /// </summary>
        public SqlServerMemberPeriodRepository MemberPeriod
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerMemberPeriodRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _memberPeriod);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="MemberLocationRecord" /> data structure.
        /// </summary>
        public SqlServerMemberLocationRepository MemberLocation
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerMemberLocationRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _memberLocation);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="MemberBomRecord" /> data structure.
        /// </summary>
        public SqlServerMemberBomRepository MemberBom
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerMemberBomRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _memberBom);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BranchRecord" /> data structure.
        /// </summary>
        public SqlServerBranchRepository Branch
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerBranchRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _branch);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BranchXrefRecord" /> data structure.
        /// </summary>
        public SqlServerBranchXrefRepository BranchXref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerBranchXrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _branchXref);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CommitteeRecord" /> data structure.
        /// </summary>
        public SqlServerCommitteeRepository Committee
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCommitteeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _committee);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="DistrictRecord" /> data structure.
        /// </summary>
        public SqlServerDistrictRepository District
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerDistrictRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _district);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CommitteeXrefRecord" /> data structure.
        /// </summary>
        public SqlServerCommitteeXrefRepository CommitteeXref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCommitteeXrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _committeeXref);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.MembershipRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IMembershipRepository IMembershipRepositoryCollection.Membership
        {
            get { return this.Membership; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.MemberPeriodRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IMemberPeriodRepository IMembershipRepositoryCollection.MemberPeriod
        {
            get { return this.MemberPeriod; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.MemberLocationRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IMemberLocationRepository IMembershipRepositoryCollection.MemberLocation
        {
            get { return this.MemberLocation; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.MemberBomRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IMemberBomRepository IMembershipRepositoryCollection.MemberBom
        {
            get { return this.MemberBom; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.BranchRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IBranchRepository IMembershipRepositoryCollection.Branch
        {
            get { return this.Branch; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.BranchXrefRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IBranchXrefRepository IMembershipRepositoryCollection.BranchXref
        {
            get { return this.BranchXref; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.CommitteeRecord" /> data structure.
        /// </summary>
        Consensus.Membership.ICommitteeRepository IMembershipRepositoryCollection.Committee
        {
            get { return this.Committee; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.DistrictRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IDistrictRepository IMembershipRepositoryCollection.District
        {
            get { return this.District; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.CommitteeXrefRecord" /> data structure.
        /// </summary>
        Consensus.Membership.ICommitteeXrefRepository IMembershipRepositoryCollection.CommitteeXref
        {
            get { return this.CommitteeXref; }
        }

        #endregion
    }
}
