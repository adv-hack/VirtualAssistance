using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="InvoiceModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IInvoiceFactory : IFactory<IInvoiceModel, String>
    {
        System.Boolean CheckIfInvoiceCredited(System.String invId);

        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> CreditInvoice(System.String invId, System.String userloginId);

        /// <summary>
        ///     Creates a new <see cref="!:InvoiceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:InvoiceModel" /> instance.
        /// </returns>
        Consensus.Finance.IInvoiceModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:InvoiceModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:InvoiceModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:InvoiceModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:InvoiceModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IInvoiceModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="salesPersonId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="salesPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllBySalesPersonId(System.String salesPersonId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllByAddId(System.String addId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="creditNteRefId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="creditNteRefId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllByCreditNteRefId(System.String creditNteRefId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllByMemberPeriodId(System.String memberPeriodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllByPackId(System.String packId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllByAccountId(System.String accountId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="salesProleIdId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="salesProleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllBySalesProleIdId(System.String salesProleIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> FetchAllByProleIdId(System.String proleIdId);
    }
}
