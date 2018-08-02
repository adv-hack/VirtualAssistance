using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MemberPeriodModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMemberPeriodFactory : IFactory<IMemberPeriodModel, String>
    {
        /// <summary>
        ///     Performs rollback membership on a single <see cref="!:MemberPeriodModel" /> instance.
        ///                     Functionality replicated from the SQL performed in V6.5.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instance to be modified.
        /// </param>
        /// <param name="status">
        ///     The status value which should be set.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        Consensus.Membership.IMemberPeriodModel RollbackMembership(System.String memberPeriodId, System.String status);

        /// <summary>
        ///     Cancels existing DDs on <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instance to be modified.
        /// </param>
        /// <param name="directDebitId">
        ///     The new Direct Debit Id which identifies the instance which should not be modified.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        Consensus.Membership.IMemberPeriodModel CancelExistingDirectDebits(System.String memberPeriodId, System.String directDebitId);

        /// <summary>
        ///     Creates a new <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberPeriodModel" /> instance.
        /// </returns>
        Consensus.Membership.IMemberPeriodModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberPeriodModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberPeriodModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IMemberPeriodModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="memIdId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="memIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> FetchAllByMemIdId(System.String memIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invOrganisationId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invOrganisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> FetchAllByInvOrganisationId(System.String invOrganisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invoiceRoleId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invoiceRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> FetchAllByInvoiceRoleId(System.String invoiceRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invAddressId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invAddressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> FetchAllByInvAddressId(System.String invAddressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> FetchAllBySourceCodeId(System.String sourceCodeId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> FetchAllByAccountId(System.String accountId);
    }
}
