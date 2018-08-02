using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="InvheaderRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IInvoiceRepository : IRepository<InvheaderRecord, String>
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

        void Create(Consensus.Finance.InvheaderRecord record);

        void Modify(Consensus.Finance.InvheaderRecord record);

        void RollbackInvoice(Consensus.Finance.InvheaderRecord record);

        void CreateInvoice(System.String Id, System.String userLoginId, System.String sellingCompany, System.Int32 booking);

        void CreditInvoice(Consensus.Finance.InvheaderRecord record, System.String invId, System.String userloginId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="salesmanId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="salesmanId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllBySalesmanId(System.String salesmanId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="add">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="add" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllByAdd(System.String add);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="creditNteRef">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="creditNteRef" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllByCreditNteRef(System.String creditNteRef);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="mepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllByMepId(System.String mepId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ltId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="ltId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllByLtId(System.String ltId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="accId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllByAccId(System.String accId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="salesProleId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="salesProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllBySalesProleId(System.String salesProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> FetchAllByProleId(System.String proleId);

        #endregion
    }
}
