using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BookingRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBookingRepository : IRepository<BookingRecord, String>
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

        void Create(Consensus.Learning.BookingRecord record);

        void Modify(Consensus.Learning.BookingRecord record);

        Consensus.Learning.BookingRecord GetConfirmedEvents(System.String bookId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> BookingGenerateGrpId(System.String bookId);

        /// <summary>
        ///     Get Booking Lines if available to Create Invoice.
        /// </summary>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> GetBookingLines(System.String bookId, System.String UserLoginId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invAdd">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="invAdd" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByInvAdd(System.String invAdd);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notes">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="notes" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByNotes(System.String notes);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sourceCode">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="sourceCode" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllBySourceCode(System.String sourceCode);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invOrgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="invOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByInvOrgId(System.String invOrgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invExtNotes">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="invExtNotes" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByInvExtNotes(System.String invExtNotes);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="plId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByPlId(System.String plId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="oppId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByOppId(System.String oppId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="delivAdd">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="delivAdd" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByDelivAdd(System.String delivAdd);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByAddId(System.String addId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invProleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="invProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByInvProleId(System.String invProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="schnId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="schnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllBySchnId(System.String schnId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="accId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> FetchAllByAccId(System.String accId);

        #endregion
    }
}
