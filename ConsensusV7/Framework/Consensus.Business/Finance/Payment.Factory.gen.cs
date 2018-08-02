using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PaymentModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPaymentFactory : IFactory<IPaymentModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PaymentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PaymentModel" /> instance.
        /// </returns>
        Consensus.Finance.IPaymentModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PaymentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PaymentModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PaymentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PaymentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPaymentModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAllByMemberPeriodId(System.String memberPeriodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAllByBookingId(System.String bookingId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentModel" /> instances.
        /// </summary>
        /// <param name="refundId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instances that match the specified <paramref name="refundId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAllByRefundId(System.String refundId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAllByAddressId(System.String addressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAllByAccountId(System.String accountId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentModel" /> instances.
        /// </summary>
        /// <param name="letterTemplateId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instances that match the specified <paramref name="letterTemplateId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAllByLetterTemplateId(System.String letterTemplateId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentModel" /> instances.
        /// </summary>
        /// <param name="cardholderRoleId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentModel" /> instances that match the specified <paramref name="cardholderRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentModel> FetchAllByCardholderRoleId(System.String cardholderRoleId);
    }
}
