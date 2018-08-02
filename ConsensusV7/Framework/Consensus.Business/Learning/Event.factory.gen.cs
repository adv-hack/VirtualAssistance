using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="EventModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IEventFactory : IFactory<IEventModel, String>
    {
        /// <summary>
        ///     Retrieves a single <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <param name="courseParentId">
        ///     The value which identifies the <see cref="!:EventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instance that match the specified <paramref name="courseParentId" />.
        /// </returns>
        Consensus.Learning.IEventModel FetchByCourseParentId(System.String courseParentId);

        void CalculateCourseNumbers(System.String courseId);

        void CalculateCourseStartEnd(System.String courseId);

        /// <summary>
        ///     Creates a new <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:EventModel" /> instance.
        /// </returns>
        Consensus.Learning.IEventModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:EventModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:EventModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:EventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IEventModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByManagerId(System.String managerId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByLocationId(System.String locationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByNotesId(System.String notesId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="commissionedId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="commissionedId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByCommissionedId(System.String commissionedId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByOpportunityId(System.String opportunityId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByAddressId(System.String addressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="commissionedRoleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="commissionedRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByCommissionedRoleId(System.String commissionedRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByBookingTermsId(System.String bookingTermsId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="contactId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="contactId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByContactId(System.String contactId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="supplierOrgId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="supplierOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllBySupplierOrgId(System.String supplierOrgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="supplierRoleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="supplierRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllBySupplierRoleId(System.String supplierRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="fundingOrganisationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="fundingOrganisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByFundingOrganisationId(System.String fundingOrganisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="intNotesId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="intNotesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByIntNotesId(System.String intNotesId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="mainTrainerId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="mainTrainerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByMainTrainerId(System.String mainTrainerId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> FetchAllByPayScheduleHeaderId(System.Nullable<System.Int32> payScheduleHeaderId);
    }
}
