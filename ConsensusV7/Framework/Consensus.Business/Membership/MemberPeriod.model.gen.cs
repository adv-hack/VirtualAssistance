using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Marketing;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MemberPeriodRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMemberPeriodModel : IModel<String>
    {
        System.Int32 StatusNumber
        {
            get;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_MEM_ID" field.
        /// </summary>
        Consensus.Membership.IMembershipModel MemId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_MEM_ID" field.
        /// </summary>
        System.String MemIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductMembershipModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_MEM_GRADE" field.
        /// </summary>
        System.String MemGrade
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_START" field.
        /// </summary>
        System.Nullable<System.DateTime> Start
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_END" field.
        /// </summary>
        System.Nullable<System.DateTime> End
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_1" field.
        /// </summary>
        System.Nullable<System.Int32> Qty1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_2" field.
        /// </summary>
        System.Nullable<System.Int32> Qty2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_QTY_3" field.
        /// </summary>
        System.Nullable<System.Int32> Qty3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_FEE" field.
        /// </summary>
        System.Decimal Fee
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENCY" field.
        /// </summary>
        System.String Currency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PAY_METHOD" field.
        /// </summary>
        Consensus.Common.ICodeModel PayMethod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PAY_METHOD" field.
        /// </summary>
        System.String PayMethodCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PAY_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel PayStatus
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PAY_STATUS" field.
        /// </summary>
        System.String PayStatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel InvOrganisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_INV_ORG_ID" field.
        /// </summary>
        System.String InvOrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel InvoiceRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_INV_PROLE_ID" field.
        /// </summary>
        System.String InvoiceRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel InvAddress
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_INV_ADD_ID" field.
        /// </summary>
        System.String InvAddressId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_PRICE_LIST_ID" field.
        /// </summary>
        System.String PriceListId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENT" field.
        /// </summary>
        System.Nullable<System.Byte> Current
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_PM_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel SourceCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_PM_ID" field.
        /// </summary>
        System.String SourceCodeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_RENEWED_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> RenewedDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_LAPSED_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> LapsedDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_RENEWAL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> RenewalDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_OLD_MEP_ID" field.
        /// </summary>
        System.String OldMepId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CUST_ORDER_NO" field.
        /// </summary>
        System.String CustOrderNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        Consensus.Common.ICodeModel CancelReason
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_CANCEL_REASON" field.
        /// </summary>
        System.String CancelReasonCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_FOR_ATTN_OF" field.
        /// </summary>
        System.String ForAttnOf
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_ORG_CUST_AC" field.
        /// </summary>
        System.String AccountRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_CURRENT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> CurrentDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_LAPSE_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> LapseDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_INDEM_INSUR_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IndemInsurDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_ROLLBACK_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> RollbackDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_APP_METHOD" field.
        /// </summary>
        Consensus.Common.ICodeModel AppMethod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_APP_METHOD" field.
        /// </summary>
        System.String AppMethodCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_DO_NOT_INVOIC" field.
        /// </summary>
        System.Nullable<System.Byte> ManualInvoice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEP_ACC_ID" field.
        /// </summary>
        Consensus.Finance.IAccountModel Account
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEP_ACC_ID" field.
        /// </summary>
        System.String AccountId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEP_MEMBERSHIP_NAME" field.
        /// </summary>
        System.String MembershipName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> Learners
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPaymentModel> Payments
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> InvHeader
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:DirectDebitModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IDirectDebitModel> DirectDebits
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPrepayAccountModel> PrepayAccounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:MemberPeriodModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> MemberLocations
        {
            get;
        }
    }
}
