using System;
using System.Collections.Generic;
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
    public partial class LocalFinanceFactoryCollection : LocalFactoryCollection, IFinanceFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="AccountModel" /> objects.
        /// </summary>
        private LocalAccountFactory _account;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="AccountXrefModel" /> objects.
        /// </summary>
        private LocalAccountXrefFactory _accountXref;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PaymentModel" /> objects.
        /// </summary>
        private LocalPaymentFactory _payment;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PriceListModel" /> objects.
        /// </summary>
        private LocalPriceListFactory _priceList;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PriceModel" /> objects.
        /// </summary>
        private LocalPriceFactory _price;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="InvoiceModel" /> objects.
        /// </summary>
        private LocalInvoiceFactory _invoice;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="InvoiceLineModel" /> objects.
        /// </summary>
        private LocalInvoiceLineFactory _invoiceLine;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CostCodeModel" /> objects.
        /// </summary>
        private LocalCostCodeFactory _costCode;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="BookingTermsModel" /> objects.
        /// </summary>
        private LocalBookingTermsFactory _bookingTerms;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PayscheduleheaderModel" /> objects.
        /// </summary>
        private LocalPayscheduleheaderFactory _payscheduleheader;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CurrencyModel" /> objects.
        /// </summary>
        private LocalCurrencyFactory _currency;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="DirectDebitModel" /> objects.
        /// </summary>
        private LocalDirectDebitFactory _directDebit;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PayAllocationModel" /> objects.
        /// </summary>
        private LocalPayAllocationFactory _payAllocation;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PrepayAccountModel" /> objects.
        /// </summary>
        private LocalPrepayAccountFactory _prepayAccount;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="GiftaidclaimModel" /> objects.
        /// </summary>
        private LocalGiftaidclaimFactory _giftaidclaim;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PaymentChequeModel" /> objects.
        /// </summary>
        private LocalPaymentChequeFactory _paymentCheque;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PaymentCardModel" /> objects.
        /// </summary>
        private LocalPaymentCardFactory _paymentCard;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PaymentBacsModel" /> objects.
        /// </summary>
        private LocalPaymentBacsFactory _paymentBacs;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="AccountModel" /> objects.
        /// </summary>
        public LocalAccountFactory Account
        {
            get { return LocalFactory.Create(this.Provider, ref _account); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="AccountXrefModel" /> objects.
        /// </summary>
        public LocalAccountXrefFactory AccountXref
        {
            get { return LocalFactory.Create(this.Provider, ref _accountXref); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PaymentModel" /> objects.
        /// </summary>
        public LocalPaymentFactory Payment
        {
            get { return LocalFactory.Create(this.Provider, ref _payment); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PriceListModel" /> objects.
        /// </summary>
        public LocalPriceListFactory PriceList
        {
            get { return LocalFactory.Create(this.Provider, ref _priceList); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PriceModel" /> objects.
        /// </summary>
        public LocalPriceFactory Price
        {
            get { return LocalFactory.Create(this.Provider, ref _price); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="InvoiceModel" /> objects.
        /// </summary>
        public LocalInvoiceFactory Invoice
        {
            get { return LocalFactory.Create(this.Provider, ref _invoice); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="InvoiceLineModel" /> objects.
        /// </summary>
        public LocalInvoiceLineFactory InvoiceLine
        {
            get { return LocalFactory.Create(this.Provider, ref _invoiceLine); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CostCodeModel" /> objects.
        /// </summary>
        public LocalCostCodeFactory CostCode
        {
            get { return LocalFactory.Create(this.Provider, ref _costCode); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="BookingTermsModel" /> objects.
        /// </summary>
        public LocalBookingTermsFactory BookingTerms
        {
            get { return LocalFactory.Create(this.Provider, ref _bookingTerms); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PayscheduleheaderModel" /> objects.
        /// </summary>
        public LocalPayscheduleheaderFactory Payscheduleheader
        {
            get { return LocalFactory.Create(this.Provider, ref _payscheduleheader); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CurrencyModel" /> objects.
        /// </summary>
        public LocalCurrencyFactory Currency
        {
            get { return LocalFactory.Create(this.Provider, ref _currency); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="DirectDebitModel" /> objects.
        /// </summary>
        public LocalDirectDebitFactory DirectDebit
        {
            get { return LocalFactory.Create(this.Provider, ref _directDebit); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PayAllocationModel" /> objects.
        /// </summary>
        public LocalPayAllocationFactory PayAllocation
        {
            get { return LocalFactory.Create(this.Provider, ref _payAllocation); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PrepayAccountModel" /> objects.
        /// </summary>
        public LocalPrepayAccountFactory PrepayAccount
        {
            get { return LocalFactory.Create(this.Provider, ref _prepayAccount); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="GiftaidclaimModel" /> objects.
        /// </summary>
        public LocalGiftaidclaimFactory Giftaidclaim
        {
            get { return LocalFactory.Create(this.Provider, ref _giftaidclaim); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PaymentChequeModel" /> objects.
        /// </summary>
        public LocalPaymentChequeFactory PaymentCheque
        {
            get { return LocalFactory.Create(this.Provider, ref _paymentCheque); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PaymentCardModel" /> objects.
        /// </summary>
        public LocalPaymentCardFactory PaymentCard
        {
            get { return LocalFactory.Create(this.Provider, ref _paymentCard); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PaymentBacsModel" /> objects.
        /// </summary>
        public LocalPaymentBacsFactory PaymentBacs
        {
            get { return LocalFactory.Create(this.Provider, ref _paymentBacs); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AccountModel" /> objects.
        /// </summary>
        Consensus.Finance.IAccountFactory IFinanceFactoryCollection.Account
        {
            get { return this.Account; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AccountXrefModel" /> objects.
        /// </summary>
        Consensus.Finance.IAccountXrefFactory IFinanceFactoryCollection.AccountXref
        {
            get { return this.AccountXref; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PaymentModel" /> objects.
        /// </summary>
        Consensus.Finance.IPaymentFactory IFinanceFactoryCollection.Payment
        {
            get { return this.Payment; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PriceListModel" /> objects.
        /// </summary>
        Consensus.Finance.IPriceListFactory IFinanceFactoryCollection.PriceList
        {
            get { return this.PriceList; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PriceModel" /> objects.
        /// </summary>
        Consensus.Finance.IPriceFactory IFinanceFactoryCollection.Price
        {
            get { return this.Price; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:InvoiceModel" /> objects.
        /// </summary>
        Consensus.Finance.IInvoiceFactory IFinanceFactoryCollection.Invoice
        {
            get { return this.Invoice; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:InvoiceLineModel" /> objects.
        /// </summary>
        Consensus.Finance.IInvoiceLineFactory IFinanceFactoryCollection.InvoiceLine
        {
            get { return this.InvoiceLine; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CostCodeModel" /> objects.
        /// </summary>
        Consensus.Finance.ICostCodeFactory IFinanceFactoryCollection.CostCode
        {
            get { return this.CostCode; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BookingTermsModel" /> objects.
        /// </summary>
        Consensus.Finance.IBookingTermsFactory IFinanceFactoryCollection.BookingTerms
        {
            get { return this.BookingTerms; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PayscheduleheaderModel" /> objects.
        /// </summary>
        Consensus.Finance.IPayscheduleheaderFactory IFinanceFactoryCollection.Payscheduleheader
        {
            get { return this.Payscheduleheader; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CurrencyModel" /> objects.
        /// </summary>
        Consensus.Finance.ICurrencyFactory IFinanceFactoryCollection.Currency
        {
            get { return this.Currency; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:DirectDebitModel" /> objects.
        /// </summary>
        Consensus.Finance.IDirectDebitFactory IFinanceFactoryCollection.DirectDebit
        {
            get { return this.DirectDebit; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PayAllocationModel" /> objects.
        /// </summary>
        Consensus.Finance.IPayAllocationFactory IFinanceFactoryCollection.PayAllocation
        {
            get { return this.PayAllocation; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PrepayAccountModel" /> objects.
        /// </summary>
        Consensus.Finance.IPrepayAccountFactory IFinanceFactoryCollection.PrepayAccount
        {
            get { return this.PrepayAccount; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:GiftaidclaimModel" /> objects.
        /// </summary>
        Consensus.Finance.IGiftaidclaimFactory IFinanceFactoryCollection.Giftaidclaim
        {
            get { return this.Giftaidclaim; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PaymentChequeModel" /> objects.
        /// </summary>
        Consensus.Finance.IPaymentChequeFactory IFinanceFactoryCollection.PaymentCheque
        {
            get { return this.PaymentCheque; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PaymentCardModel" /> objects.
        /// </summary>
        Consensus.Finance.IPaymentCardFactory IFinanceFactoryCollection.PaymentCard
        {
            get { return this.PaymentCard; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PaymentBacsModel" /> objects.
        /// </summary>
        Consensus.Finance.IPaymentBacsFactory IFinanceFactoryCollection.PaymentBacs
        {
            get { return this.PaymentBacs; }
        }

        #endregion
    }
}
