using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="GiftaidclaimRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalGiftaidclaimModel : LocalModel<GiftaidclaimRecord, Int32>, IGiftaidclaimModel
    {
        #region fields

        /// <summary>
        ///     The value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _submitter;

        /// <summary>
        ///     The value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _trustee;

        /// <summary>
        ///     The value of the "GAC_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<GiftaidclaimRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.Giftaidclaim.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<GiftaidclaimRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.Giftaidclaim.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<GiftaidclaimRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.Giftaidclaim.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel Submitter
        {
            get
            {
                if (_submitter == null)
                    _submitter = this.Provider.Contact.Role.FetchById(this.SubmitterId);
                if (_submitter == null)
                    _submitter = this.Provider.Contact.Role.Create();
                
                return _submitter;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        public String SubmitterId
        {
            get { return this.ModifiedData.SubmitterProleId; }
            set
            {
                if (this.ModifiedData.SubmitterProleId != value)
                     _submitter = null;
                this.ModifiedData.SubmitterProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel Trustee
        {
            get
            {
                if (_trustee == null)
                    _trustee = this.Provider.Contact.Role.FetchById(this.TrusteeId);
                if (_trustee == null)
                    _trustee = this.Provider.Contact.Role.Create();
                
                return _trustee;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        public String TrusteeId
        {
            get { return this.ModifiedData.TrusteeProleId; }
            set
            {
                if (this.ModifiedData.TrusteeProleId != value)
                     _trustee = null;
                this.ModifiedData.TrusteeProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "GAC_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel Organisation
        {
            get
            {
                if (_organisation == null)
                    _organisation = this.Provider.Contact.Organisation.FetchById(this.OrganisationId);
                if (_organisation == null)
                    _organisation = this.Provider.Contact.Organisation.Create();
                
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_ORG_ID" field.
        /// </summary>
        public String OrganisationId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _organisation = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_CLAIM_DATE" field.
        /// </summary>
        public DateTime ClaimDate
        {
            get { return this.ModifiedData.ClaimDate; }
            set { this.ModifiedData.ClaimDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_DONATIONS_FROM" field.
        /// </summary>
        public DateTime DonationsFrom
        {
            get { return this.ModifiedData.DonationsFrom; }
            set { this.ModifiedData.DonationsFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_DONATIONS_TO" field.
        /// </summary>
        public DateTime DonationsTo
        {
            get { return this.ModifiedData.DonationsTo; }
            set { this.ModifiedData.DonationsTo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_ACCOUNTING_PERIOD_END" field.
        /// </summary>
        public DateTime AccountingPeriodEnd
        {
            get { return this.ModifiedData.AccountingPeriodEnd; }
            set { this.ModifiedData.AccountingPeriodEnd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_HMRC_REFERENCE" field.
        /// </summary>
        public String HmrcReference
        {
            get { return this.ModifiedData.HmrcReference; }
            set { this.ModifiedData.HmrcReference = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_REGULATOR_NAME" field.
        /// </summary>
        public String RegulatorName
        {
            get { return this.ModifiedData.RegulatorName; }
            set { this.ModifiedData.RegulatorName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_REGULATOR_NUMBER" field.
        /// </summary>
        public String RegulatorNumber
        {
            get { return this.ModifiedData.RegulatorNumber; }
            set { this.ModifiedData.RegulatorNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_ADJUSTMENT" field.
        /// </summary>
        public Decimal? Adjustment
        {
            get { return this.ModifiedData.Adjustment; }
            set { this.ModifiedData.Adjustment = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_PROCESS" field.
        /// </summary>
        public Byte Process
        {
            get { return this.ModifiedData.Process; }
            set { this.ModifiedData.Process = value; }
        }

        /// <summary>
        ///     Gets the The value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.SellingCompanyId != null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalGiftaidclaimModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalGiftaidclaimModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalGiftaidclaimModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalGiftaidclaimModel(LocalProvider provider, GiftaidclaimRecord record) : base(provider, record)
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
            if (_submitter != null)
            {
                _submitter.Save();
                this.ModifiedData.SubmitterProleId = _submitter.Id == null && this.ModifiedData.SubmitterProleId != null ? "" : _submitter.Id;
            }
            if (_trustee != null)
            {
                _trustee.Save();
                this.ModifiedData.TrusteeProleId = _trustee.Id == null && this.ModifiedData.TrusteeProleId != null ? "" : _trustee.Id;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
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

        /// <summary>
        ///     Gets the The value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IGiftaidclaimModel.Submitter
        {
            get { return this.Submitter; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        System.String IGiftaidclaimModel.SubmitterId
        {
            get { return this.SubmitterId; }
            set { this.SubmitterId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IGiftaidclaimModel.Trustee
        {
            get { return this.Trustee; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        System.String IGiftaidclaimModel.TrusteeId
        {
            get { return this.TrusteeId; }
            set { this.TrusteeId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "GAC_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IGiftaidclaimModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_ORG_ID" field.
        /// </summary>
        System.String IGiftaidclaimModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_CLAIM_DATE" field.
        /// </summary>
        System.DateTime IGiftaidclaimModel.ClaimDate
        {
            get { return this.ClaimDate; }
            set { this.ClaimDate = (System.DateTime)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_DONATIONS_FROM" field.
        /// </summary>
        System.DateTime IGiftaidclaimModel.DonationsFrom
        {
            get { return this.DonationsFrom; }
            set { this.DonationsFrom = (System.DateTime)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_DONATIONS_TO" field.
        /// </summary>
        System.DateTime IGiftaidclaimModel.DonationsTo
        {
            get { return this.DonationsTo; }
            set { this.DonationsTo = (System.DateTime)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_ACCOUNTING_PERIOD_END" field.
        /// </summary>
        System.DateTime IGiftaidclaimModel.AccountingPeriodEnd
        {
            get { return this.AccountingPeriodEnd; }
            set { this.AccountingPeriodEnd = (System.DateTime)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_HMRC_REFERENCE" field.
        /// </summary>
        System.String IGiftaidclaimModel.HmrcReference
        {
            get { return this.HmrcReference; }
            set { this.HmrcReference = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_REGULATOR_NAME" field.
        /// </summary>
        System.String IGiftaidclaimModel.RegulatorName
        {
            get { return this.RegulatorName; }
            set { this.RegulatorName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_REGULATOR_NUMBER" field.
        /// </summary>
        System.String IGiftaidclaimModel.RegulatorNumber
        {
            get { return this.RegulatorNumber; }
            set { this.RegulatorNumber = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_ADJUSTMENT" field.
        /// </summary>
        System.Nullable<System.Decimal> IGiftaidclaimModel.Adjustment
        {
            get { return this.Adjustment; }
            set { this.Adjustment = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_PROCESS" field.
        /// </summary>
        System.Byte IGiftaidclaimModel.Process
        {
            get { return this.Process; }
            set { this.Process = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IGiftaidclaimModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        System.String IGiftaidclaimModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        #endregion
    }
}
