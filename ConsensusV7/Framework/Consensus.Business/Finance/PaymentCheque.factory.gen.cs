using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PaymentChequeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPaymentChequeFactory : IFactory<IPaymentChequeModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PaymentChequeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PaymentChequeModel" /> instance.
        /// </returns>
        Consensus.Finance.IPaymentChequeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PaymentChequeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PaymentChequeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PaymentChequeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPaymentChequeModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PaymentChequeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:PaymentChequeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAllByMemberPeriodId(System.String memberPeriodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PaymentChequeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PaymentChequeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:PaymentChequeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAllByBookingId(System.String bookingId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </summary>
        /// <param name="refundId">
        ///     The value which identifies the <see cref="!:PaymentChequeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instances that match the specified <paramref name="refundId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAllByRefundId(System.String refundId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:PaymentChequeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAllByAddressId(System.String addressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:PaymentChequeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAllByAccountId(System.String accountId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </summary>
        /// <param name="letterTemplateId">
        ///     The value which identifies the <see cref="!:PaymentChequeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instances that match the specified <paramref name="letterTemplateId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAllByLetterTemplateId(System.String letterTemplateId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentChequeModel" /> instances.
        /// </summary>
        /// <param name="cardholderRoleId">
        ///     The value which identifies the <see cref="!:PaymentChequeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentChequeModel" /> instances that match the specified <paramref name="cardholderRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentChequeModel> FetchAllByCardholderRoleId(System.String cardholderRoleId);
    }
}
