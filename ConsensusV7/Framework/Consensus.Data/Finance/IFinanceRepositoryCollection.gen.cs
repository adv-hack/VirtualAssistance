using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     The repository collection which pertains to the Finance namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IFinanceRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.AccountRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IAccountRepository Account
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.AccountXrefRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IAccountXrefRepository AccountXref
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.PaymentRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPaymentRepository Payment
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.PriceListRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPriceListRepository PriceList
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.PricesRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPriceRepository Price
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.InvheaderRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IInvoiceRepository Invoice
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.InvlineRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IInvoiceLineRepository InvoiceLine
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.CostCodeRecord" /> data structure.
        /// </summary>
        Consensus.Finance.ICostCodeRepository CostCode
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.BookingTermsRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IBookingTermsRepository BookingTerms
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.PayscheduleheaderRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPayscheduleheaderRepository Payscheduleheader
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.C4currencyRecord" /> data structure.
        /// </summary>
        Consensus.Finance.ICurrencyRepository Currency
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.DirectdebitRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IDirectDebitRepository DirectDebit
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.PayAllocationRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPayAllocationRepository PayAllocation
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.MasterClubRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IPrepayAccountRepository PrepayAccount
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> data structure.
        /// </summary>
        Consensus.Finance.IGiftaidclaimRepository Giftaidclaim
        {
            get;
        }
    }
}
