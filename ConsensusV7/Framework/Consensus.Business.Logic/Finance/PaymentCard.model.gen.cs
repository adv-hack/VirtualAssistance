using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PaymentRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPaymentCardModel : LocalPaymentModel, IPaymentCardModel
    {
        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PaymentRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.Payment.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PaymentRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.Payment.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PaymentRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.Payment.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CCARD_TYPE" field.
        /// </summary>
        public String CardType
        {
            get { return this.ModifiedData.CcardType; }
            set { this.ModifiedData.CcardType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_EXPY_DTE" field.
        /// </summary>
        public DateTime? CardExpiryDate
        {
            get { return this.ModifiedData.ExpyDte; }
            set { this.ModifiedData.ExpyDte = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_ISSUE_NO" field.
        /// </summary>
        public String CardIssueNo
        {
            get { return this.ModifiedData.IssueNo; }
            set { this.ModifiedData.IssueNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_VALID_DATE" field.
        /// </summary>
        public DateTime? CardStartDate
        {
            get { return this.ModifiedData.ValidDate; }
            set { this.ModifiedData.ValidDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CARD_SEC_ID" field.
        /// </summary>
        public String CardSecurityNumber
        {
            get { return this.ModifiedData.CardSecId; }
            set { this.ModifiedData.CardSecId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_GATEWAY_ACC_ID" field.
        /// </summary>
        public String GatewayAccount
        {
            get { return this.ModifiedData.GatewayAccId; }
            set { this.ModifiedData.GatewayAccId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPaymentCardModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPaymentCardModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPaymentCardModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPaymentCardModel(LocalProvider provider, PaymentRecord record) : base(provider, record)
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

        /// <summary>
        ///     Gets or sets the value of the "PAY_CCARD_TYPE" field.
        /// </summary>
        System.String IPaymentCardModel.CardType
        {
            get { return this.CardType; }
            set { this.CardType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_EXPY_DTE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPaymentCardModel.CardExpiryDate
        {
            get { return this.CardExpiryDate; }
            set { this.CardExpiryDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_ISSUE_NO" field.
        /// </summary>
        System.String IPaymentCardModel.CardIssueNo
        {
            get { return this.CardIssueNo; }
            set { this.CardIssueNo = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_VALID_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPaymentCardModel.CardStartDate
        {
            get { return this.CardStartDate; }
            set { this.CardStartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CARD_SEC_ID" field.
        /// </summary>
        System.String IPaymentCardModel.CardSecurityNumber
        {
            get { return this.CardSecurityNumber; }
            set { this.CardSecurityNumber = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_GATEWAY_ACC_ID" field.
        /// </summary>
        System.String IPaymentCardModel.GatewayAccount
        {
            get { return this.GatewayAccount; }
            set { this.GatewayAccount = (System.String)value; }
        }

        #endregion
    }
}
