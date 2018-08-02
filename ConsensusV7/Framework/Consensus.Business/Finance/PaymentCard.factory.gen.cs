using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PaymentCardModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPaymentCardFactory : IFactory<IPaymentCardModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PaymentCardModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PaymentCardModel" /> instance.
        /// </returns>
        Consensus.Finance.IPaymentCardModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PaymentCardModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PaymentCardModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PaymentCardModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PaymentCardModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPaymentCardModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAllByMemberPeriodId(System.String memberPeriodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAllByBookingId(System.String bookingId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="refundId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="refundId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAllByRefundId(System.String refundId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAllByAddressId(System.String addressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAllByAccountId(System.String accountId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="letterTemplateId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="letterTemplateId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAllByLetterTemplateId(System.String letterTemplateId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="cardholderRoleId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="cardholderRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> FetchAllByCardholderRoleId(System.String cardholderRoleId);
    }
}
