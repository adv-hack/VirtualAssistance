using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="AccountRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAccountModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "ACC_SYSTEM" field.
        /// </summary>
        System.String System
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_SYSTEM_REF" field.
        /// </summary>
        System.String ARNumber
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACC_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PRINCIPAL" field.
        /// </summary>
        System.Nullable<System.Byte> Principal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACC_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Role
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_PROLE_ID" field.
        /// </summary>
        System.String RoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACC_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel Address
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_ADD_ID" field.
        /// </summary>
        System.String AddressId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingComanpy
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingComanpyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAYMENT_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> PaymentDays
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACC_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAYMENT_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> PaymentType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_1" field.
        /// </summary>
        System.String PayTerms1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_2" field.
        /// </summary>
        System.String PayTerms2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_3" field.
        /// </summary>
        System.String PayTerms3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PAY_TERMS_4" field.
        /// </summary>
        System.String PayTerms4
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_CREDIT" field.
        /// </summary>
        System.Decimal Credit
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_SPECIAL_TERMS" field.
        /// </summary>
        System.String SpecialTerms
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACC_VATCD" field.
        /// </summary>
        Consensus.Common.ICodeModel Vatcd
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_VATCD" field.
        /// </summary>
        System.String VatcdCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_RULE" field.
        /// </summary>
        System.Byte InvoiceRule
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_RULE_OFFSET" field.
        /// </summary>
        System.Int16 InvoiceRuleOffset
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_INVOICE_WHEN_STATUS" field.
        /// </summary>
        System.String InvoiceWhenStatus
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_NAT_ACCOUNT" field.
        /// </summary>
        System.Nullable<System.Byte> NatAccount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACC_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_TITLE" field.
        /// </summary>
        System.String Title
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACC_DOCS_METHOD" field.
        /// </summary>
        Consensus.Common.ICodeModel DocsMethod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_DOCS_METHOD" field.
        /// </summary>
        System.String DocsMethodCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel InvPackId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACC_INV_PACK_ID" field.
        /// </summary>
        System.String InvPackIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_REQ_PAYMENT_DAYS" field.
        /// </summary>
        System.Int32 ReqPaymentDays
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_DEFAULT_INV_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> DefaultInvStatus
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_CURRENCY_TYPE" field.
        /// </summary>
        System.String CurrencyType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_VAT_REG_NUM" field.
        /// </summary>
        System.String VatRegNum
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_MEM_PAYMENT_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> MemPaymentDays
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_PO_REQ" field.
        /// </summary>
        System.Nullable<System.Byte> PoReq
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_DEFAULT" field.
        /// </summary>
        System.Nullable<System.Byte> Default
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACC_NAT_ACCOUNT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> NatAccountDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountXrefModel> AccountXrefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> Payments
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> Invoices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:AccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> MemberPeriods
        {
            get;
        }
    }
}
