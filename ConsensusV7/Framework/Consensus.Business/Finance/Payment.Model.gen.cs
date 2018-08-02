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
    ///     Encapsulates the <see cref="PaymentRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPaymentModel : IModel<String>
    {
        #region properties

        /// <summary>
        ///     Sets the invoice ID to specify which invoice this payment needs to be allocated against when saved.
        /// </summary>
        System.String InvoiceId
        {
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NUMBER" field.
        /// </summary>
        System.String AccountNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_APPVL_REF" field.
        /// </summary>
        System.String ApprovalReference
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CURR_TYPE" field.
        /// </summary>
        System.String Currency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_RECVD" field.
        /// </summary>
        System.Decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_RECVD_BC" field.
        /// </summary>
        System.Decimal AmountBC
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> Date
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CUSTOMER_ACC" field.
        /// </summary>
        System.String CustomerAcc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_UNUSED_VAL" field.
        /// </summary>
        System.Decimal UnusedVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_GL_CODE" field.
        /// </summary>
        System.String GeneralLedgerCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_HIDDEN" field.
        /// </summary>
        System.Nullable<System.Byte> Hidden
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CHEQUE_NO" field.
        /// </summary>
        System.String ChequeNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_SORT_CODE" field.
        /// </summary>
        System.String SortCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CURR_RATE_BC" field.
        /// </summary>
        System.Decimal ConversionRate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_MEP_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel MemberPeriod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_MEP_ID" field.
        /// </summary>
        System.String MemberPeriodId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_PN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel Person
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_PN_ID" field.
        /// </summary>
        System.String PersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REF" field.
        /// </summary>
        System.String Reference
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_BOOK_ID" field.
        /// </summary>
        Consensus.Learning.IBookingModel Booking
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_BOOK_ID" field.
        /// </summary>
        System.String BookingId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        Consensus.Finance.IPaymentModel Refund
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        System.String RefundId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REFUND_PAY_REF" field.
        /// </summary>
        System.String RefundPayRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_TXN_TYPE" field.
        /// </summary>
        System.Nullable<System.Int32> TxnType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_BANKING_REF" field.
        /// </summary>
        System.String BankingReference
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_BANK_CHG" field.
        /// </summary>
        System.Decimal BankCharges
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_PURPOSE" field.
        /// </summary>
        System.Nullable<System.Byte> Purpose
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_SCHN_ID" field.
        /// </summary>
        System.String SalesChannel
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel Address
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_ADD_ID" field.
        /// </summary>
        System.String AddressId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REVERSE_RES" field.
        /// </summary>
        System.String ReverseRes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ACC_ID" field.
        /// </summary>
        Consensus.Finance.IAccountModel Account
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_ACC_ID" field.
        /// </summary>
        System.String AccountId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_LT_ID" field.
        /// </summary>
        Consensus.Document.ILetterTemplateModel LetterTemplate
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_LT_ID" field.
        /// </summary>
        System.String LetterTemplateId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel CardholderRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        System.String CardholderRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:PaymentModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> Refunds
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PayAllocationModel" /> instances that reference this <see cref="!:PaymentModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPayAllocationModel> PA_PayId
        {
            get;
        }

        #endregion

        #region methods

        void Save();

        #endregion
    }
}
