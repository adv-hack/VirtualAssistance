using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PaymentRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPaymentRepository : IRepository<PaymentRecord, String>
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

        void Create(Consensus.Finance.PaymentRecord record);

        void CreateAndAllocate(Consensus.Finance.PaymentRecord record, System.String invoiceId);

        void Modify(Consensus.Finance.PaymentRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="mepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> FetchAllByMepId(System.String mepId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="pnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> FetchAllByPnId(System.String pnId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="bookId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> FetchAllByBookId(System.String bookId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="refundPayId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="refundPayId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> FetchAllByRefundPayId(System.String refundPayId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> FetchAllByAddId(System.String addId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="accId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> FetchAllByAccId(System.String accId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ltId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="ltId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> FetchAllByLtId(System.String ltId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cardholderProleId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="cardholderProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> FetchAllByCardholderProleId(System.String cardholderProleId);

        #endregion
    }
}
