using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Sales
{
    /// <summary>
    ///     Encapsulates the <see cref="OpportunityXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOpportunityXrefModel : LocalModel<OpportunityXrefRecord, String>, IOpportunityXrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _role;

        /// <summary>
        ///     The value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        private LocalOpportunityModel _opportunity;

        /// <summary>
        ///     The value of the "OPPXREF_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<OpportunityXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Sales.OpportunityXref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<OpportunityXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Sales.OpportunityXref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<OpportunityXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Sales.OpportunityXref.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel Role
        {
            get
            {
                if (_role == null && this.RoleId != null)
                    _role = this.Provider.Contact.Role.FetchById(this.RoleId);
                if (_role == null)
                    _role = this.Provider.Contact.Role.Create();
                
                return _role;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        public String RoleId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _role = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        public LocalOpportunityModel Opportunity
        {
            get
            {
                if (_opportunity == null && this.OpportunityId != null)
                    _opportunity = this.Provider.Sales.Opportunity.FetchById(this.OpportunityId);
                if (_opportunity == null)
                    _opportunity = this.Provider.Sales.Opportunity.Create();
                
                return _opportunity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        public String OpportunityId
        {
            get { return this.ModifiedData.OppId; }
            set
            {
                if (this.ModifiedData.OppId != value)
                     _opportunity = null;
                this.ModifiedData.OppId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PRINCIPAL" field.
        /// </summary>
        public Byte? Principal
        {
            get { return this.ModifiedData.Principal; }
            set { this.ModifiedData.Principal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_ORG_NAME" field.
        /// </summary>
        public String OrgName
        {
            get { return this.ModifiedData.OrgName; }
            set { this.ModifiedData.OrgName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PN_NAME" field.
        /// </summary>
        public String SalesPerson
        {
            get { return this.ModifiedData.PnName; }
            set { this.ModifiedData.PnName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel Organisation
        {
            get
            {
                if (_organisation == null && this.OrganisationId != null)
                    _organisation = this.Provider.Contact.Organisation.FetchById(this.OrganisationId);
                if (_organisation == null)
                    _organisation = this.Provider.Contact.Organisation.Create();
                
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_ORG_ID" field.
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
        ///     Gets or sets the value of the "OPPXREF_ORG_PHONE" field.
        /// </summary>
        public String OrgPhone
        {
            get { return this.ModifiedData.OrgPhone; }
            set { this.ModifiedData.OrgPhone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PN_PHONE" field.
        /// </summary>
        public String PnPhone
        {
            get { return this.ModifiedData.PnPhone; }
            set { this.ModifiedData.PnPhone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_VALUE" field.
        /// </summary>
        public Decimal? Value
        {
            get { return this.ModifiedData.Value; }
            set { this.ModifiedData.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_SHARE" field.
        /// </summary>
        public Decimal? Share
        {
            get { return this.ModifiedData.Share; }
            set { this.ModifiedData.Share = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalOpportunityXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalOpportunityXrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalOpportunityXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalOpportunityXrefModel(LocalProvider provider, OpportunityXrefRecord record) : base(provider, record)
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
            if (_role != null)
            {
                _role.Save();
                this.ModifiedData.ProleId = _role.Id == null && this.ModifiedData.ProleId != null ? "" : _role.Id;
            }
            if (_opportunity != null)
            {
                _opportunity.Save();
                this.ModifiedData.OppId = _opportunity.Id == null && this.ModifiedData.OppId != null ? "" : _opportunity.Id;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
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
        ///     Gets or sets the type of person that is linked to the opportunity.
        /// </summary>
        Consensus.Sales.OpportunityPersonType IOpportunityXrefModel.PersonType
        {
            get { return this.PersonType; }
            set { this.PersonType = (Consensus.Sales.OpportunityPersonType)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IOpportunityXrefModel.Role
        {
            get { return this.Role; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        System.String IOpportunityXrefModel.RoleId
        {
            get { return this.RoleId; }
            set { this.RoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        Consensus.Sales.IOpportunityModel IOpportunityXrefModel.Opportunity
        {
            get { return this.Opportunity; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        System.String IOpportunityXrefModel.OpportunityId
        {
            get { return this.OpportunityId; }
            set { this.OpportunityId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PRINCIPAL" field.
        /// </summary>
        System.Nullable<System.Byte> IOpportunityXrefModel.Principal
        {
            get { return this.Principal; }
            set { this.Principal = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_ORG_NAME" field.
        /// </summary>
        System.String IOpportunityXrefModel.OrgName
        {
            get { return this.OrgName; }
            set { this.OrgName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PN_NAME" field.
        /// </summary>
        System.String IOpportunityXrefModel.SalesPerson
        {
            get { return this.SalesPerson; }
            set { this.SalesPerson = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IOpportunityXrefModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_ORG_ID" field.
        /// </summary>
        System.String IOpportunityXrefModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_ORG_PHONE" field.
        /// </summary>
        System.String IOpportunityXrefModel.OrgPhone
        {
            get { return this.OrgPhone; }
            set { this.OrgPhone = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PN_PHONE" field.
        /// </summary>
        System.String IOpportunityXrefModel.PnPhone
        {
            get { return this.PnPhone; }
            set { this.PnPhone = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_VALUE" field.
        /// </summary>
        System.Nullable<System.Decimal> IOpportunityXrefModel.Value
        {
            get { return this.Value; }
            set { this.Value = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_SHARE" field.
        /// </summary>
        System.Nullable<System.Decimal> IOpportunityXrefModel.Share
        {
            get { return this.Share; }
            set { this.Share = (System.Nullable<System.Decimal>)value; }
        }

        #endregion
    }
}
