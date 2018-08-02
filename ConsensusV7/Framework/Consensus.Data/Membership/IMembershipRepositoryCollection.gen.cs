using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     The repository collection which pertains to the Membership namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMembershipRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.MembershipRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IMembershipRepository Membership
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.MemberPeriodRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IMemberPeriodRepository MemberPeriod
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.MemberLocationRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IMemberLocationRepository MemberLocation
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.MemberBomRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IMemberBomRepository MemberBom
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.BranchRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IBranchRepository Branch
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.BranchXrefRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IBranchXrefRepository BranchXref
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.CommitteeRecord" /> data structure.
        /// </summary>
        Consensus.Membership.ICommitteeRepository Committee
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.DistrictRecord" /> data structure.
        /// </summary>
        Consensus.Membership.IDistrictRepository District
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Membership.CommitteeXrefRecord" /> data structure.
        /// </summary>
        Consensus.Membership.ICommitteeXrefRepository CommitteeXref
        {
            get;
        }
    }
}
