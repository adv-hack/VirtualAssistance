using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BookingModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBookingFactory : IFactory<IBookingModel, String>
    {
        Consensus.Learning.IBookingModel GetConfirmedEvents(System.String bookId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> BookingGenerateGrpId(System.String bookId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> GetBookingLines(System.String bookId, System.String userLoginId, System.String sellingCompany);

        System.Boolean CheckIfBookingAlreadyCancelled(System.String bookId);

        /// <summary>
        ///     Creates a new <see cref="!:BookingModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BookingModel" /> instance.
        /// </returns>
        Consensus.Learning.IBookingModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BookingModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BookingModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:BookingModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BookingModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IBookingModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerOrgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByBookerOrgId(System.String bookerOrgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerPersonId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByBookerPersonId(System.String bookerPersonId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceAddressId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceAddressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByInvoiceAddressId(System.String invoiceAddressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByNotesId(System.String notesId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllBySourceCodeId(System.String sourceCodeId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceOrgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByInvoiceOrgId(System.String invoiceOrgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invExtNotesId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invExtNotesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByInvExtNotesId(System.String invExtNotesId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByPriceListId(System.String priceListId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByOpportunityId(System.String opportunityId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="delivAddId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="delivAddId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByDelivAddId(System.String delivAddId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerAddressId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerAddressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByBookerAddressId(System.String bookerAddressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerRoleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByBookerRoleId(System.String bookerRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceRoleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByInvoiceRoleId(System.String invoiceRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="salesChannelId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="salesChannelId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllBySalesChannelId(System.String salesChannelId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> FetchAllByAccountId(System.String accountId);
    }
}
