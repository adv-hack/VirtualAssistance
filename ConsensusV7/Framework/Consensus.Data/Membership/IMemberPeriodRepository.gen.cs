using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MemberPeriodRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMemberPeriodRepository : IRepository<MemberPeriodRecord, String>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        void Create(Consensus.Membership.MemberPeriodRecord record);

        void Modify(Consensus.Membership.MemberPeriodRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="memId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="memId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> FetchAllByMemId(System.String memId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> FetchAllByProdId(System.String prodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invOrgId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="invOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> FetchAllByInvOrgId(System.String invOrgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invProleId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="invProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> FetchAllByInvProleId(System.String invProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invAddId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="invAddId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> FetchAllByInvAddId(System.String invAddId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="pmId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> FetchAllByPmId(System.String pmId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="accId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> FetchAllByAccId(System.String accId);

        #endregion
    }
}
