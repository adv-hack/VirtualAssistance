using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Finance namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IFinanceFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AccountModel" /> objects.
        /// </summary>
        Consensus.Finance.IAccountFactory Account
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AccountXrefModel" /> objects.
        /// </summary>
        Consensus.Finance.IAccountXrefFactory AccountXref
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PaymentModel" /> objects.
        /// </summary>
        Consensus.Finance.IPaymentFactory Payment
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PriceListModel" /> objects.
        /// </summary>
        Consensus.Finance.IPriceListFactory PriceList
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PriceModel" /> objects.
        /// </summary>
        Consensus.Finance.IPriceFactory Price
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:InvoiceModel" /> objects.
        /// </summary>
        Consensus.Finance.IInvoiceFactory Invoice
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:InvoiceLineModel" /> objects.
        /// </summary>
        Consensus.Finance.IInvoiceLineFactory InvoiceLine
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CostCodeModel" /> objects.
        /// </summary>
        Consensus.Finance.ICostCodeFactory CostCode
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BookingTermsModel" /> objects.
        /// </summary>
        Consensus.Finance.IBookingTermsFactory BookingTerms
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PayscheduleheaderModel" /> objects.
        /// </summary>
        Consensus.Finance.IPayscheduleheaderFactory Payscheduleheader
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CurrencyModel" /> objects.
        /// </summary>
        Consensus.Finance.ICurrencyFactory Currency
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:DirectDebitModel" /> objects.
        /// </summary>
        Consensus.Finance.IDirectDebitFactory DirectDebit
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PayAllocationModel" /> objects.
        /// </summary>
        Consensus.Finance.IPayAllocationFactory PayAllocation
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PrepayAccountModel" /> objects.
        /// </summary>
        Consensus.Finance.IPrepayAccountFactory PrepayAccount
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:GiftaidclaimModel" /> objects.
        /// </summary>
        Consensus.Finance.IGiftaidclaimFactory Giftaidclaim
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PaymentChequeModel" /> objects.
        /// </summary>
        Consensus.Finance.IPaymentChequeFactory PaymentCheque
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PaymentCardModel" /> objects.
        /// </summary>
        Consensus.Finance.IPaymentCardFactory PaymentCard
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PaymentBacsModel" /> objects.
        /// </summary>
        Consensus.Finance.IPaymentBacsFactory PaymentBacs
        {
            get;
        }
    }
}
