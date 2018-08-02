using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="InvoiceLineModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IInvoiceLineFactory : IFactory<IInvoiceLineModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:InvoiceLineModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:InvoiceLineModel" /> instance.
        /// </returns>
        Consensus.Finance.IInvoiceLineModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:InvoiceLineModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:InvoiceLineModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:InvoiceLineModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IInvoiceLineModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="invoiceId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="invoiceId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> FetchAllByInvoiceId(System.String invoiceId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="productIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="productIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> FetchAllByProductIdId(System.String productIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> FetchAllByBookingId(System.String bookingId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="elementId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="elementId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> FetchAllByElementId(System.String elementId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> FetchAllByCourseIdId(System.String courseIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="melIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="melIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> FetchAllByMelIdId(System.String melIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);
    }
}
