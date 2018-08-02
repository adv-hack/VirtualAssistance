using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ElementModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IElementFactory : IFactory<IElementModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ElementModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ElementModel" /> instance.
        /// </returns>
        Consensus.Learning.IElementModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ElementModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ElementModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ElementModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ElementModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IElementModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="delegateId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="delegateId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllByDelegateId(System.String delegateId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllByActivityId(System.String activityId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllByCourseId(System.String courseId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllByBookingId(System.String bookingId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllByPriceListId(System.String priceListId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="sessionXrefsId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="sessionXrefsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllBySessionXrefsId(System.String sessionXrefsId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="priceIdId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="priceIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllByPriceIdId(System.String priceIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="parentElementId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="parentElementId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllByParentElementId(System.String parentElementId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="bookingTermId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="bookingTermId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllByBookingTermId(System.String bookingTermId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId);
    }
}
