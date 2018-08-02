using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PayAllocationRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPayAllocationModel : IModel<String>
    {
        #region properties

        System.String Paid
        {
            set;
        }

        System.Boolean Reverse
        {
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> Date
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PA_INV_ID" field.
        /// </summary>
        Consensus.Finance.IInvoiceModel InvId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_INV_ID" field.
        /// </summary>
        System.String InvIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_INV_REF" field.
        /// </summary>
        System.String InvRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PA_PAY_ID" field.
        /// </summary>
        Consensus.Finance.IPaymentModel PayId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_PAY_ID" field.
        /// </summary>
        System.String PayIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_HIDDEN" field.
        /// </summary>
        System.Nullable<System.Byte> Hidden
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_CURR_TYPE" field.
        /// </summary>
        System.String CurrType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_VALUE" field.
        /// </summary>
        System.Decimal Value
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PA_CREDIT_ID" field.
        /// </summary>
        Consensus.Finance.IInvoiceModel CreditId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_CREDIT_ID" field.
        /// </summary>
        System.String CreditIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_CREDIT_REF" field.
        /// </summary>
        System.String CreditRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_BOOK_ID" field.
        /// </summary>
        System.String BookId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_MEP_ID" field.
        /// </summary>
        System.String MepId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_BAT_ID" field.
        /// </summary>
        System.String BatId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DEL_ID" field.
        /// </summary>
        System.String DelId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_REFUND_ID" field.
        /// </summary>
        System.String RefundId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DEALLOCATION" field.
        /// </summary>
        System.Nullable<System.Byte> Deallocation
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_REVERSES_PA_ID" field.
        /// </summary>
        System.String ReversesPaId
        {
            get;
            set;
        }

        #endregion

        #region methods

        void Save();

        #endregion
    }
}
