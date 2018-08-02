using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="InvlineRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IInvoiceLineRepository : IRepository<InvlineRecord, String>
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

        void Create(Consensus.Finance.InvlineRecord record);

        void Modify(Consensus.Finance.InvlineRecord record);

        void RemoveById(Consensus.Finance.InvlineRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="invId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> FetchAllByInvId(System.String invId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="bookId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> FetchAllByBookId(System.String bookId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="elemId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="elemId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> FetchAllByElemId(System.String elemId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> FetchAllByCourseId(System.String courseId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="melId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="melId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> FetchAllByMelId(System.String melId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        #endregion
    }
}
