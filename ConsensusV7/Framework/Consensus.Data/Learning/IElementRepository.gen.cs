using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ElementRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IElementRepository : IRepository<ElementRecord, String>
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

        void Create(Consensus.Learning.ElementRecord record);

        void Modify(Consensus.Learning.ElementRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="delId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="delId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllByDelId(System.String delId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllByProdId(System.String prodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="actId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllByActId(System.String actId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllByCourseId(System.String courseId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="bookId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllByBookId(System.String bookId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="plId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllByPlId(System.String plId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sxrefId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="sxrefId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllBySxrefId(System.String sxrefId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prsId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="prsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllByPrsId(System.String prsId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="elemId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="elemId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllByElemId(System.String elemId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bktId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="bktId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllByBktId(System.String bktId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> FetchAllByPshId(System.Nullable<System.Int32> pshId);

        #endregion
    }
}
