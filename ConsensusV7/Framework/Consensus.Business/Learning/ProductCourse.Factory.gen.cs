using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProductCourseModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProductCourseFactory : IFactory<IProductCourseModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProductCourseModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductCourseModel" /> instance.
        /// </returns>
        Consensus.Learning.IProductCourseModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductCourseModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductCourseModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductCourseModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductCourseModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProductCourseModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="prodDescripId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByProdDescripId(System.String prodDescripId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="prodContentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByProdContentId(System.String prodContentId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="prodPrereqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByProdPrereqId(System.String prodPrereqId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="prodObjectiveId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByProdObjectiveId(System.String prodObjectiveId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByProleIdId(System.String proleIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="productManagerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByProductManagerId(System.String productManagerId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByBookingTermsId(System.String bookingTermsId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByLocationId(System.String locationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="authorPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByAuthorPersonId(System.String authorPersonId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="venueId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByVenueId(System.String venueId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="productTrainingRulesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> FetchAllByProductTrainingRulesId(System.String productTrainingRulesId);
    }
}
