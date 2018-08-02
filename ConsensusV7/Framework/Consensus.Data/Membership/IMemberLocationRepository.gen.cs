using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MemberLocationRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMemberLocationRepository : IRepository<MemberLocationRecord, String>
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

        void Create(Consensus.Membership.MemberLocationRecord record);

        void CreateDiscount(Consensus.Membership.MemberLocationRecord record, System.Decimal feeamount);

        void Modify(Consensus.Membership.MemberLocationRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="memId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="memId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> FetchAllByMemId(System.String memId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="mepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> FetchAllByMepId(System.String mepId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mailAddId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="mailAddId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> FetchAllByMailAddId(System.String mailAddId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mailInvId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="mailInvId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> FetchAllByMailInvId(System.String mailInvId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invlnId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="invlnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> FetchAllByInvlnId(System.String invlnId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> FetchAllByProdId(System.String prodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="plId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> FetchAllByPlId(System.String plId);

        #endregion
    }
}
