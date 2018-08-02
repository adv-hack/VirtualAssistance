using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CourseRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IEventRepository : IRepository<CourseRecord, String>
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

        void Modify(Consensus.Learning.CourseRecord record);

        void Create(Consensus.Learning.CourseRecord record);

        /// <summary>
        ///     Retrieves a single <see cref="T:Consensus.Learning.CourseRecord" /> instance from the data store.
        /// </summary>
        /// <param name="courseParentId">
        ///     The value which identifies the <see cref="T:Consensus.Learning.CourseRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Learning.CourseRecord" /> instance which matches the specified <paramref name="courseParentId" />.
        /// </returns>
        Consensus.Learning.CourseRecord FetchByCourseParentId(System.String courseParentId);

        void CalculateCourseNumbers(System.String courseId);

        void CalculateCourseStartEnd(System.String courseId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="locId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByLocId(System.String locId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notes">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="notes" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByNotes(System.String notes);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="supplierId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="supplierId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllBySupplierId(System.String supplierId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="oppId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByOppId(System.String oppId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByAddId(System.String addId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="supRoleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="supRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllBySupRoleId(System.String supRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bktId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="bktId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByBktId(System.String bktId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="contprolId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="contprolId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByContprolId(System.String contprolId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="provOrgId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="provOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByProvOrgId(System.String provOrgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="provProleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="provProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByProvProleId(System.String provProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fundedOrgId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="fundedOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByFundedOrgId(System.String fundedOrgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="intNotes">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="intNotes" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByIntNotes(System.String intNotes);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mtrProleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="mtrProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByMtrProleId(System.String mtrProleId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> FetchAllByPshId(System.Nullable<System.Int32> pshId);

        #endregion
    }
}
