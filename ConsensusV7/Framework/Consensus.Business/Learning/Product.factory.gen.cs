using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProductModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProductFactory : IFactory<IProductModel, String>
    {
        /// <summary>
        ///     Retrieves a single <see cref="T:Consensus.Learning.LocalProductModel" /> instance.
        /// </summary>
        /// <param name="reference">
        ///     The value which identifies the <see cref="T:Consensus.Learning.LocalProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Learning.LocalProductModel" /> instance that match the specified <paramref name="reference" />.
        /// </returns>
        System.String FetchAllByReference(System.String reference);

        /// <summary>
        ///     Creates a new <see cref="!:ProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductModel" /> instance.
        /// </returns>
        Consensus.Learning.IProductModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProductModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="prodDescripId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByProdDescripId(System.String prodDescripId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="prodContentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByProdContentId(System.String prodContentId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="prodPrereqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByProdPrereqId(System.String prodPrereqId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="prodObjectiveId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByProdObjectiveId(System.String prodObjectiveId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByProleIdId(System.String proleIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="productManagerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByProductManagerId(System.String productManagerId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByBookingTermsId(System.String bookingTermsId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByLocationId(System.String locationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="authorPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByAuthorPersonId(System.String authorPersonId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="venueId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByVenueId(System.String venueId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="productTrainingRulesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> FetchAllByProductTrainingRulesId(System.String productTrainingRulesId);

        IEnumerable<Consensus.Common.DonationProduct> FetchDonationProduct();        
    }
}
