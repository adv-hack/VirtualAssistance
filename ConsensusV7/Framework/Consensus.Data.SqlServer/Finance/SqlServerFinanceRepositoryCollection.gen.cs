using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Finance namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerFinanceRepositoryCollection : SqlServerRepositoryCollection, IFinanceRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AccountRecord" /> data structure.
        /// </summary>
        private SqlServerAccountRepository _account;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AccountXrefRecord" /> data structure.
        /// </summary>
        private SqlServerAccountXrefRepository _accountXref;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PaymentRecord" /> data structure.
        /// </summary>
        private SqlServerPaymentRepository _payment;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PriceListRecord" /> data structure.
        /// </summary>
        private SqlServerPriceListRepository _priceList;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PricesRecord" /> data structure.
        /// </summary>
        private SqlServerPriceRepository _price;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="InvheaderRecord" /> data structure.
        /// </summary>
        private SqlServerInvoiceRepository _invoice;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="InvlineRecord" /> data structure.
        /// </summary>
        private SqlServerInvoiceLineRepository _invoiceLine;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CostCodeRecord" /> data structure.
        /// </summary>
        private SqlServerCostCodeRepository _costCode;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BookingTermsRecord" /> data structure.
        /// </summary>
        private SqlServerBookingTermsRepository _bookingTerms;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PayscheduleheaderRecord" /> data structure.
        /// </summary>
        private SqlServerPayscheduleheaderRepository _payscheduleheader;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="C4currencyRecord" /> data structure.
        /// </summary>
        private SqlServerCurrencyRepository _currency;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="DirectdebitRecord" /> data structure.
        /// </summary>
        private SqlServerDirectDebitRepository _directDebit;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PayAllocationRecord" /> data structure.
        /// </summary>
        private SqlServerPayAllocationRepository _payAllocation;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="MasterClubRecord" /> data structure.
        /// </summary>
        private SqlServerPrepayAccountRepository _prepayAccount;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="GiftaidclaimRecord" /> data structure.
        /// </summary>
        private SqlServerGiftaidclaimRepository _giftaidclaim;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AccountRecord" /> data structure.
        /// </summary>
        public SqlServerAccountRepository Account
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerAccountRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _account);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AccountXrefRecord" /> data structure.
        /// </summary>
        public SqlServerAccountXrefRepository AccountXref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerAccountXrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _accountXref);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PaymentRecord" /> data structure.
        /// </summary>
        public SqlServerPaymentRepository Payment
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPaymentRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _payment);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PriceListRecord" /> data structure.
        /// </summary>
        public SqlServerPriceListRepository PriceList
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPriceListRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _priceList);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PricesRecord" /> data structure.
        /// </summary>
        public SqlServerPriceRepository Price
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPriceRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _price);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="InvheaderRecord" /> data structure.
        /// </summary>
        public SqlServerInvoiceRepository Invoice
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerInvoiceRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _invoice);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="InvlineRecord" /> data structure.
        /// </summary>
        public SqlServerInvoiceLineRepository InvoiceLine
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerInvoiceLineRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _invoiceLine);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CostCodeRecord" /> data structure.
        /// </summary>
        public SqlServerCostCodeRepository CostCode
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCostCodeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _costCode);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BookingTermsRecord" /> data structure.
        /// </summary>
        public SqlServerBookingTermsRepository BookingTerms
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerBookingTermsRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _bookingTerms);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PayscheduleheaderRecord" /> data structure.
        /// </summary>
        public SqlServerPayscheduleheaderRepository Payscheduleheader
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPayscheduleheaderRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _payscheduleheader);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="C4currencyRecord" /> data structure.
        /// </summary>
        public SqlServerCurrencyRepository Currency
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCurrencyRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _currency);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="DirectdebitRecord" /> data structure.
        /// </summary>
        public SqlServerDirectDebitRepository DirectDebit
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerDirectDebitRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _directDebit);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PayAllocationRecord" /> data structure.
        /// </summary>
        public SqlServerPayAllocationRepository PayAllocation
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPayAllocationRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _payAllocation);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="MasterClubRecord" /> data structure.
        /// </summary>
        public SqlServerPrepayAccountRepository PrepayAccount
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPrepayAccountRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _prepayAccount);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="GiftaidclaimRecord" /> data structure.
        /// </summary>
        public SqlServerGiftaidclaimRepository Giftaidclaim
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerGiftaidclaimRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _giftaidclaim);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.AccountRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IAccountRepository IFinanceRepositoryCollection.Account
        {
            get { return this.Account; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.AccountXrefRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IAccountXrefRepository IFinanceRepositoryCollection.AccountXref
        {
            get { return this.AccountXref; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.PaymentRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPaymentRepository IFinanceRepositoryCollection.Payment
        {
            get { return this.Payment; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.PriceListRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPriceListRepository IFinanceRepositoryCollection.PriceList
        {
            get { return this.PriceList; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.PricesRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPriceRepository IFinanceRepositoryCollection.Price
        {
            get { return this.Price; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.InvheaderRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IInvoiceRepository IFinanceRepositoryCollection.Invoice
        {
            get { return this.Invoice; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.InvlineRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IInvoiceLineRepository IFinanceRepositoryCollection.InvoiceLine
        {
            get { return this.InvoiceLine; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.CostCodeRecord" /> data structure.
        /// </summary>
        Consensus.Finance.ICostCodeRepository IFinanceRepositoryCollection.CostCode
        {
            get { return this.CostCode; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.BookingTermsRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IBookingTermsRepository IFinanceRepositoryCollection.BookingTerms
        {
            get { return this.BookingTerms; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.PayscheduleheaderRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPayscheduleheaderRepository IFinanceRepositoryCollection.Payscheduleheader
        {
            get { return this.Payscheduleheader; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.C4currencyRecord" /> data structure.
        /// </summary>
        Consensus.Finance.ICurrencyRepository IFinanceRepositoryCollection.Currency
        {
            get { return this.Currency; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.DirectdebitRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IDirectDebitRepository IFinanceRepositoryCollection.DirectDebit
        {
            get { return this.DirectDebit; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.PayAllocationRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPayAllocationRepository IFinanceRepositoryCollection.PayAllocation
        {
            get { return this.PayAllocation; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.MasterClubRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPrepayAccountRepository IFinanceRepositoryCollection.PrepayAccount
        {
            get { return this.PrepayAccount; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IGiftaidclaimRepository IFinanceRepositoryCollection.Giftaidclaim
        {
            get { return this.Giftaidclaim; }
        }

        #endregion
    }
}
