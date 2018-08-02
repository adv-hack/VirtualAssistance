using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProductMembershipModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProductMembershipFactory : IFactory<IProductMembershipModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProductMembershipModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductMembershipModel" /> instance.
        /// </returns>
        Consensus.Learning.IProductMembershipModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductMembershipModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductMembershipModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductMembershipModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProductMembershipModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodDescripId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByProdDescripId(System.String prodDescripId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodContentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByProdContentId(System.String prodContentId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodPrereqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByProdPrereqId(System.String prodPrereqId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodObjectiveId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByProdObjectiveId(System.String prodObjectiveId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByProleIdId(System.String proleIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="productManagerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByProductManagerId(System.String productManagerId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByBookingTermsId(System.String bookingTermsId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByLocationId(System.String locationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="joiningPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="joiningPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByJoiningPackId(System.String joiningPackId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind1PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind1PackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByRemind1PackId(System.String remind1PackId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind2PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind2PackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByRemind2PackId(System.String remind2PackId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="renewalPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="renewalPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByRenewalPackId(System.String renewalPackId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="lapsedPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="lapsedPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByLapsedPackId(System.String lapsedPackId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="cancelPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="cancelPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByCancelPackId(System.String cancelPackId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="authorPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByAuthorPersonId(System.String authorPersonId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind3PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind3PackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByRemind3PackId(System.String remind3PackId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="renewedPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="renewedPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByRenewedPackId(System.String renewedPackId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="appPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="appPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByAppPackId(System.String appPackId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="offerPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="offerPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByOfferPackId(System.String offerPackId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="venueId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByVenueId(System.String venueId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="productTrainingRulesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> FetchAllByProductTrainingRulesId(System.String productTrainingRulesId);
    }
}
