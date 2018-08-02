using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PaymentBacsModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPaymentBacsFactory : IFactory<IPaymentBacsModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PaymentBacsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PaymentBacsModel" /> instance.
        /// </returns>
        Consensus.Finance.IPaymentBacsModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PaymentBacsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PaymentBacsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PaymentBacsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPaymentBacsModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAllByMemberPeriodId(System.String memberPeriodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAllByBookingId(System.String bookingId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="refundId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="refundId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAllByRefundId(System.String refundId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAllByAddressId(System.String addressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAllByAccountId(System.String accountId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="letterTemplateId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="letterTemplateId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAllByLetterTemplateId(System.String letterTemplateId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="cardholderRoleId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="cardholderRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> FetchAllByCardholderRoleId(System.String cardholderRoleId);
    }
}
