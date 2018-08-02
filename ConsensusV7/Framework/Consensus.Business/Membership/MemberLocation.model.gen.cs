using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Learning;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MemberLocationRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMemberLocationModel : IModel<String>
    {
        #region properties

        System.Boolean Overseas
        {
            get;
            set;
        }

        System.Decimal FeeAmount
        {
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MEM_ID" field.
        /// </summary>
        Consensus.Membership.IMembershipModel Membership
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MEM_ID" field.
        /// </summary>
        System.String MembershipId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MEP_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel MemberPeriod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MEP_ID" field.
        /// </summary>
        System.String MemberPeriodId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_START" field.
        /// </summary>
        System.Nullable<System.DateTime> Start
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_END" field.
        /// </summary>
        System.Nullable<System.DateTime> End
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_STATUS" field.
        /// </summary>
        System.Nullable<System.Int32> Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_TYPE" field.
        /// </summary>
        System.Nullable<System.Int32> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_FEE" field.
        /// </summary>
        System.Decimal Fee
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENCY" field.
        /// </summary>
        System.String Currency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEL_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel OrgId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_ORG_ID" field.
        /// </summary>
        System.String OrgIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Role
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_PROLE_ID" field.
        /// </summary>
        System.String RoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel MailAddId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MAIL_ADD_ID" field.
        /// </summary>
        System.String MailAddIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        Consensus.Finance.IInvoiceModel MailInvId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_MAIL_INV_ID" field.
        /// </summary>
        System.String MailInvIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_RENEW_LOC" field.
        /// </summary>
        System.Nullable<System.Byte> RenewLoc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PRINCIPAL" field.
        /// </summary>
        System.Nullable<System.Byte> Principal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VATCD" field.
        /// </summary>
        System.String Vatcd
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_REF" field.
        /// </summary>
        System.String Ref
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VAT_RATE" field.
        /// </summary>
        System.Decimal VatRate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_VAT_AMT" field.
        /// </summary>
        System.Decimal VatAmt
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEL_INVLN_ID" field.
        /// </summary>
        Consensus.Finance.IInvoiceLineModel InvlnId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_INVLN_ID" field.
        /// </summary>
        System.String InvlnIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_INVOICED" field.
        /// </summary>
        System.Nullable<System.Byte> Invoiced
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_SY_TYPE" field.
        /// </summary>
        System.Byte SyType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductMembershipModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENT" field.
        /// </summary>
        System.Byte Current
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_GROSS_FEE" field.
        /// </summary>
        System.Decimal GrossFee
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_REASON" field.
        /// </summary>
        System.String DiscReason
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_FEE_EXEMPT" field.
        /// </summary>
        System.Byte FeeExempt
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CURRENT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> CurrentDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CANCEL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> CancelDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MEL_PL_ID" field.
        /// </summary>
        Consensus.Finance.IPriceListModel PlId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MEL_PL_ID" field.
        /// </summary>
        System.String PlIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_ID" field.
        /// </summary>
        System.Nullable<System.Int32> DiscId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISCOUNT" field.
        /// </summary>
        System.Nullable<System.Decimal> Discount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_LIST_PRICE" field.
        /// </summary>
        System.Nullable<System.Decimal> ListPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PO_NUMBER" field.
        /// </summary>
        System.String PoNumber
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_QTY" field.
        /// </summary>
        System.Nullable<System.Int32> Qty
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DO_NOT_RENEW" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotRenew
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_CANCEL_REASON" field.
        /// </summary>
        System.String CancelReason
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_UNT_PRICE" field.
        /// </summary>
        System.Nullable<System.Decimal> UntPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_RENEWAL" field.
        /// </summary>
        System.Nullable<System.DateTime> DiscRenewal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_PRICE_MODIFIED" field.
        /// </summary>
        System.Byte PriceModified
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_DISC_PERCENT" field.
        /// </summary>
        System.Nullable<System.Decimal> DiscPercent
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_REV_CODE" field.
        /// </summary>
        System.String RevCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEL_COST_CODE" field.
        /// </summary>
        System.String CostCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:MemberLocationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> InvoiceLines
        {
            get;
        }

        #endregion

        #region methods

        void Save();

        #endregion
    }
}
