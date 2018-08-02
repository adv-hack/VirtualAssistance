using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="InvheaderRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IInvoiceModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_ID" field.
        /// </summary>
        System.String Booking
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel Person
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_PERSON_ID" field.
        /// </summary>
        System.String PersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_SALESMAN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel SalesPerson
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_SALESMAN_ID" field.
        /// </summary>
        System.String SalesPersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CUST_ORDER_NO" field.
        /// </summary>
        System.String PurchaseOrderNumber
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_REF" field.
        /// </summary>
        System.String Reference
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> Date
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_ADD" field.
        /// </summary>
        Consensus.Contact.IAddressModel Add
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_ADD" field.
        /// </summary>
        System.String AddId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        Consensus.Finance.IInvoiceModel CreditNteRef
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_CREDIT_NTE_REF" field.
        /// </summary>
        System.String CreditNteRefId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_NET_TOTAL" field.
        /// </summary>
        System.Decimal NetTotal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_VAT_TOTAL" field.
        /// </summary>
        System.Decimal VatTotal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_GROSS_TOTAL" field.
        /// </summary>
        System.Decimal GrossTotal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CURRENCY_TYPE" field.
        /// </summary>
        System.String Currency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACCOUNT_TYPE" field.
        /// </summary>
        System.String AccountType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_COURSE_ID" field.
        /// </summary>
        System.String CourseId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_COURSE_NAME" field.
        /// </summary>
        System.String CourseName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CORS_STRT_DTE" field.
        /// </summary>
        System.Nullable<System.DateTime> CorsStrtDte
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_CORS_COST_CODE" field.
        /// </summary>
        System.String CorsCostCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_REF" field.
        /// </summary>
        System.String BookRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOKER" field.
        /// </summary>
        System.String PersonName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BOOK_ORG_NAME" field.
        /// </summary>
        System.String OrganisationName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ADD_MAILSTRING" field.
        /// </summary>
        System.String AddressMailstring
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_BK_ORG_CUST_AC" field.
        /// </summary>
        System.String ArNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_INV_ORG_NAME" field.
        /// </summary>
        System.String OrgName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_PERIOD" field.
        /// </summary>
        System.String Period
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_DUE_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> DueDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_UNPAID_VAL" field.
        /// </summary>
        System.Decimal UnpaidValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_APP_BY" field.
        /// </summary>
        System.String ApprovedBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_APP_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ApprovedDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_FOR_ATTN_OF" field.
        /// </summary>
        System.String ForTheAttentionOf
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_PRINTED" field.
        /// </summary>
        System.Nullable<System.Byte> Printed
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_MEP_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel MemberPeriod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_MEP_ID" field.
        /// </summary>
        System.String MemberPeriodId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_LT_ID" field.
        /// </summary>
        Consensus.Document.IPackModel Pack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_LT_ID" field.
        /// </summary>
        System.String PackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_USERCHAR_1" field.
        /// </summary>
        System.String Userchar1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_STATUS" field.
        /// </summary>
        System.String SOPStatus
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_REF" field.
        /// </summary>
        System.String SOPRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_NOTES" field.
        /// </summary>
        System.String SOPNotes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_MOD_BY" field.
        /// </summary>
        System.String SOPModBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INV_ACC_MOD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> SOPModDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_ACC_ID" field.
        /// </summary>
        Consensus.Finance.IAccountModel Account
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_ACC_ID" field.
        /// </summary>
        System.String AccountId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel SalesProleId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_SALES_PROLE_ID" field.
        /// </summary>
        System.String SalesProleIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INV_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ProleId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INV_PROLE_ID" field.
        /// </summary>
        System.String ProleIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> CreditNteRefInvoices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> InvoiceLines
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PayAllocationModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPayAllocationModel> PA_InvId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PayAllocationModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPayAllocationModel> PA_CreditId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:InvoiceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> MemberLocations
        {
            get;
        }
    }
}
