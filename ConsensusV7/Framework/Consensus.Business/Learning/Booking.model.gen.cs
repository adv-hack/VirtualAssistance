using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Marketing;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="BookingRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBookingModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "BOOK_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel BookerOrg
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ORG_ID" field.
        /// </summary>
        System.String BookerOrgId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel BookerPerson
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PERSON_ID" field.
        /// </summary>
        System.String BookerPersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CUST_ORD_NO" field.
        /// </summary>
        System.String CustOrdNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_ORDER_TYPE" field.
        /// </summary>
        System.String Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_ADD" field.
        /// </summary>
        Consensus.Contact.IAddressModel InvoiceAddress
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_ADD" field.
        /// </summary>
        System.String InvoiceAddressId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_NOTES" field.
        /// </summary>
        Consensus.Common.INotesModel Notes
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_NOTES" field.
        /// </summary>
        System.String NotesId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_NET_TOTAL" field.
        /// </summary>
        System.Decimal NetTotal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_VAT_TOTAL" field.
        /// </summary>
        System.Decimal VatTotal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_GROSS_TOTAL" field.
        /// </summary>
        System.Decimal GrossTotal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CONFIRMED" field.
        /// </summary>
        System.Nullable<System.DateTime> Confirmed
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVED" field.
        /// </summary>
        System.Nullable<System.Byte> Approved
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVED_BY" field.
        /// </summary>
        System.String ApprovedBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_APPROVE_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ApproveDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        Consensus.Common.ICodeModel BookingMethod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_BOOKING_METHD" field.
        /// </summary>
        System.String BookingMethodCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PAYMENT_METHD" field.
        /// </summary>
        Consensus.Common.ICodeModel PaymentMethod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PAYMENT_METHD" field.
        /// </summary>
        System.String PaymentMethodCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel SourceCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_SOURCE_CODE" field.
        /// </summary>
        System.String SourceCodeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_STUDENT_PRICE" field.
        /// </summary>
        System.Decimal GiftAidTotal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel InvoiceOrg
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_ORG_ID" field.
        /// </summary>
        System.String InvoiceOrgId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        Consensus.Common.INotesModel InvExtNotes
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_EXT_NOTES" field.
        /// </summary>
        System.String InvExtNotesId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICED" field.
        /// </summary>
        System.Nullable<System.Byte> Invoiced
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_FOR_ATTN_OF" field.
        /// </summary>
        System.String ForAttentionOf
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DO_NOT_INVOIC" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotInvoice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PL_ID" field.
        /// </summary>
        Consensus.Finance.IPriceListModel PriceList
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PL_ID" field.
        /// </summary>
        System.String PriceListId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_REASON" field.
        /// </summary>
        Consensus.Common.ICodeModel Reason
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_REASON" field.
        /// </summary>
        System.String ReasonCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_PAID" field.
        /// </summary>
        System.Nullable<System.Byte> Paid
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> CancelDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_BY" field.
        /// </summary>
        System.String CancelBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_OPP_ID" field.
        /// </summary>
        Consensus.Sales.IOpportunityModel Opportunity
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_OPP_ID" field.
        /// </summary>
        System.String OpportunityId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        Consensus.Contact.IAddressModel DelivAdd
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_DELIV_ADD" field.
        /// </summary>
        System.String DelivAddId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        Consensus.Common.ICodeModel DocsMethod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_DOCS_METHOD" field.
        /// </summary>
        System.String DocsMethodCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANC_REASON" field.
        /// </summary>
        System.String CancReason
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CURRENCY_TYPE" field.
        /// </summary>
        System.String CurrencyType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel BookerAddress
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ADD_ID" field.
        /// </summary>
        System.String BookerAddressId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel BookerRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_PROLE_ID" field.
        /// </summary>
        System.String BookerRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_VATCD_OVRRIDE" field.
        /// </summary>
        System.String VatcdOvrride
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_ORG_CUST_AC" field.
        /// </summary>
        System.String InvoiceAccountRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DELIV_FAO" field.
        /// </summary>
        System.String DelivFao
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DELIV_PHONE" field.
        /// </summary>
        System.String DelivPhone
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel InvoiceRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INV_PROLE_ID" field.
        /// </summary>
        System.String InvoiceRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_SCHN_ID" field.
        /// </summary>
        Consensus.Sales.ISalesChannelModel SalesChannel
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_SCHN_ID" field.
        /// </summary>
        System.String SalesChannelId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_RULE" field.
        /// </summary>
        System.Byte InvoiceRule
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_RULE_OFFSET" field.
        /// </summary>
        System.Int16 InvoiceRuleOffset
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_DO_NOT_INVOICE_REASON" field.
        /// </summary>
        System.String DoNotInvoiceReason
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_OFFSET_TYPE" field.
        /// </summary>
        System.String InvoiceOffsetType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel InvoiceWhenStatus
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_INVOICE_WHEN_STATUS" field.
        /// </summary>
        System.String InvoiceWhenStatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_MUST_USE_RULE" field.
        /// </summary>
        System.Byte InvoiceMustUseRule
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_CONSOLIDATE" field.
        /// </summary>
        System.Byte InvoiceConsolidate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOOK_ACC_ID" field.
        /// </summary>
        Consensus.Finance.IAccountModel Account
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOOK_ACC_ID" field.
        /// </summary>
        System.String AccountId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_RESV_TO_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ResvToDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_PER_DEL" field.
        /// </summary>
        System.Byte InvoicePerDel
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_CANCEL_REF" field.
        /// </summary>
        System.String CancelRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_INVOICE_PER_PERSON" field.
        /// </summary>
        System.Byte InvoicePerPerson
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOOK_PROMO_CODE" field.
        /// </summary>
        System.String PromoCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:BookingModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> Learners
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:BookingModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:BookingModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> Payments
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:BookingModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> InvoiceLines
        {
            get;
        }
    }
}
