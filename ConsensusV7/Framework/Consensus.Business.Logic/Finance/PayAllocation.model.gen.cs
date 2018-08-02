using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PayAllocationRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPayAllocationModel : LocalModel<PayAllocationRecord, String>, IPayAllocationModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PA_INV_ID" field.
        /// </summary>
        private LocalInvoiceModel _invId;

        /// <summary>
        ///     The value of the "PA_PAY_ID" field.
        /// </summary>
        private LocalPaymentModel _payId;

        /// <summary>
        ///     The value of the "PA_CREDIT_ID" field.
        /// </summary>
        private LocalInvoiceModel _creditId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PayAllocationRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.PayAllocation.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PayAllocationRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.PayAllocation.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PayAllocationRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.PayAllocation.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return this.ModifiedData.Date; }
            set { this.ModifiedData.Date = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PA_INV_ID" field.
        /// </summary>
        public LocalInvoiceModel InvId
        {
            get
            {
                if (_invId == null && this.InvIdId != null)
                    _invId = this.Provider.Finance.Invoice.FetchById(this.InvIdId);
                if (_invId == null)
                    _invId = this.Provider.Finance.Invoice.Create();
                
                return _invId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_INV_ID" field.
        /// </summary>
        public String InvIdId
        {
            get { return this.ModifiedData.InvId; }
            set
            {
                if (this.ModifiedData.InvId != value)
                     _invId = null;
                this.ModifiedData.InvId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_INV_REF" field.
        /// </summary>
        public String InvRef
        {
            get { return this.ModifiedData.InvRef; }
            set { this.ModifiedData.InvRef = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PA_PAY_ID" field.
        /// </summary>
        public LocalPaymentModel PayId
        {
            get
            {
                if (_payId == null && this.PayIdId != null)
                    _payId = this.Provider.Finance.Payment.FetchById(this.PayIdId);
                if (_payId == null)
                    _payId = this.Provider.Finance.Payment.Create();
                
                return _payId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_PAY_ID" field.
        /// </summary>
        public String PayIdId
        {
            get { return this.ModifiedData.PayId; }
            set
            {
                if (this.ModifiedData.PayId != value)
                     _payId = null;
                this.ModifiedData.PayId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_HIDDEN" field.
        /// </summary>
        public Byte? Hidden
        {
            get { return this.ModifiedData.Hidden; }
            set { this.ModifiedData.Hidden = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_CURR_TYPE" field.
        /// </summary>
        public String CurrType
        {
            get { return this.ModifiedData.CurrType; }
            set { this.ModifiedData.CurrType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_VALUE" field.
        /// </summary>
        public Decimal Value
        {
            get { return this.ModifiedData.Value; }
            set { this.ModifiedData.Value = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PA_CREDIT_ID" field.
        /// </summary>
        public LocalInvoiceModel CreditId
        {
            get
            {
                if (_creditId == null && this.CreditIdId != null)
                    _creditId = this.Provider.Finance.Invoice.FetchById(this.CreditIdId);
                if (_creditId == null)
                    _creditId = this.Provider.Finance.Invoice.Create();
                
                return _creditId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_CREDIT_ID" field.
        /// </summary>
        public String CreditIdId
        {
            get { return this.ModifiedData.CreditId; }
            set
            {
                if (this.ModifiedData.CreditId != value)
                     _creditId = null;
                this.ModifiedData.CreditId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_CREDIT_REF" field.
        /// </summary>
        public String CreditRef
        {
            get { return this.ModifiedData.CreditRef; }
            set { this.ModifiedData.CreditRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_BOOK_ID" field.
        /// </summary>
        public String BookId
        {
            get { return this.ModifiedData.BookId; }
            set { this.ModifiedData.BookId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_MEP_ID" field.
        /// </summary>
        public String MepId
        {
            get { return this.ModifiedData.MepId; }
            set { this.ModifiedData.MepId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return this.ModifiedData.BatId; }
            set { this.ModifiedData.BatId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DEL_ID" field.
        /// </summary>
        public String DelId
        {
            get { return this.ModifiedData.DelId; }
            set { this.ModifiedData.DelId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_REFUND_ID" field.
        /// </summary>
        public String RefundId
        {
            get { return this.ModifiedData.RefundId; }
            set { this.ModifiedData.RefundId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DEALLOCATION" field.
        /// </summary>
        public Byte? Deallocation
        {
            get { return this.ModifiedData.Deallocation; }
            set { this.ModifiedData.Deallocation = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_REVERSES_PA_ID" field.
        /// </summary>
        public String ReversesPaId
        {
            get { return this.ModifiedData.ReversesPaId; }
            set { this.ModifiedData.ReversesPaId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPayAllocationModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPayAllocationModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPayAllocationModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPayAllocationModel(LocalProvider provider, PayAllocationRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_invId != null)
            {
                _invId.Save();
                this.ModifiedData.InvId = _invId.Id == null && this.ModifiedData.InvId != null ? "" : _invId.Id;
            }
            if (_payId != null)
            {
                _payId.Save();
                this.ModifiedData.PayId = _payId.Id == null && this.ModifiedData.PayId != null ? "" : _payId.Id;
            }
            if (_creditId != null)
            {
                _creditId.Save();
                this.ModifiedData.CreditId = _creditId.Id == null && this.ModifiedData.CreditId != null ? "" : _creditId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        System.String IPayAllocationModel.Paid
        {
            set { this.Paid = (System.String)value; }
        }

        System.Boolean IPayAllocationModel.Reverse
        {
            set { this.Reverse = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPayAllocationModel.Date
        {
            get { return this.Date; }
            set { this.Date = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PA_INV_ID" field.
        /// </summary>
        Consensus.Finance.IInvoiceModel IPayAllocationModel.InvId
        {
            get { return this.InvId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_INV_ID" field.
        /// </summary>
        System.String IPayAllocationModel.InvIdId
        {
            get { return this.InvIdId; }
            set { this.InvIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_INV_REF" field.
        /// </summary>
        System.String IPayAllocationModel.InvRef
        {
            get { return this.InvRef; }
            set { this.InvRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PA_PAY_ID" field.
        /// </summary>
        Consensus.Finance.IPaymentModel IPayAllocationModel.PayId
        {
            get { return this.PayId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_PAY_ID" field.
        /// </summary>
        System.String IPayAllocationModel.PayIdId
        {
            get { return this.PayIdId; }
            set { this.PayIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_HIDDEN" field.
        /// </summary>
        System.Nullable<System.Byte> IPayAllocationModel.Hidden
        {
            get { return this.Hidden; }
            set { this.Hidden = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_CURR_TYPE" field.
        /// </summary>
        System.String IPayAllocationModel.CurrType
        {
            get { return this.CurrType; }
            set { this.CurrType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_VALUE" field.
        /// </summary>
        System.Decimal IPayAllocationModel.Value
        {
            get { return this.Value; }
            set { this.Value = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PA_CREDIT_ID" field.
        /// </summary>
        Consensus.Finance.IInvoiceModel IPayAllocationModel.CreditId
        {
            get { return this.CreditId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_CREDIT_ID" field.
        /// </summary>
        System.String IPayAllocationModel.CreditIdId
        {
            get { return this.CreditIdId; }
            set { this.CreditIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_CREDIT_REF" field.
        /// </summary>
        System.String IPayAllocationModel.CreditRef
        {
            get { return this.CreditRef; }
            set { this.CreditRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_BOOK_ID" field.
        /// </summary>
        System.String IPayAllocationModel.BookId
        {
            get { return this.BookId; }
            set { this.BookId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_MEP_ID" field.
        /// </summary>
        System.String IPayAllocationModel.MepId
        {
            get { return this.MepId; }
            set { this.MepId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_BAT_ID" field.
        /// </summary>
        System.String IPayAllocationModel.BatId
        {
            get { return this.BatId; }
            set { this.BatId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DEL_ID" field.
        /// </summary>
        System.String IPayAllocationModel.DelId
        {
            get { return this.DelId; }
            set { this.DelId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_REFUND_ID" field.
        /// </summary>
        System.String IPayAllocationModel.RefundId
        {
            get { return this.RefundId; }
            set { this.RefundId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DEALLOCATION" field.
        /// </summary>
        System.Nullable<System.Byte> IPayAllocationModel.Deallocation
        {
            get { return this.Deallocation; }
            set { this.Deallocation = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_REVERSES_PA_ID" field.
        /// </summary>
        System.String IPayAllocationModel.ReversesPaId
        {
            get { return this.ReversesPaId; }
            set { this.ReversesPaId = (System.String)value; }
        }

        void IPayAllocationModel.Save()
        {
            this.Save();
        }

        #endregion
    }
}
