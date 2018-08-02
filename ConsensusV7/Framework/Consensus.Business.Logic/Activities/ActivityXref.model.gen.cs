using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Learning;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="ActivityXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalActivityXrefModel : LocalModel<ActivityXrefRecord, String>, IActivityXrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        private LocalActivityModel _activity;

        /// <summary>
        ///     The value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        private LocalPersonModel _person;

        /// <summary>
        ///     The value of the "ACTXREF_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _personRole;

        /// <summary>
        ///     The value of the "ACTXREF_PROD_ID" field.
        /// </summary>
        private LocalProductModel _product;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActivityXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Activities.ActivityXref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActivityXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Activities.ActivityXref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActivityXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Activities.ActivityXref.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        public LocalActivityModel Activity
        {
            get
            {
                if (_activity == null && this.ActivityId != null)
                    _activity = this.Provider.Activities.Activity.FetchById(this.ActivityId);
                if (_activity == null)
                    _activity = this.Provider.Activities.Activity.Create();
                
                return _activity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        public String ActivityId
        {
            get { return this.ModifiedData.ActId; }
            set
            {
                if (this.ModifiedData.ActId != value)
                     _activity = null;
                this.ModifiedData.ActId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        public LocalPersonModel Person
        {
            get
            {
                if (_person == null && this.PersonId != null)
                    _person = this.Provider.Contact.Person.FetchById(this.PersonId);
                if (_person == null)
                    _person = this.Provider.Contact.Person.Create();
                
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return this.ModifiedData.PersonId; }
            set
            {
                if (this.ModifiedData.PersonId != value)
                     _person = null;
                this.ModifiedData.PersonId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACTXREF_ORG_ID" field.
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
        ///     Gets the The value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel PersonRole
        {
            get
            {
                if (_personRole == null && this.PersonRoleId != null)
                    _personRole = this.Provider.Contact.Role.FetchById(this.PersonRoleId);
                if (_personRole == null)
                    _personRole = this.Provider.Contact.Role.Create();
                
                return _personRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        public String PersonRoleId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _personRole = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ORG_NAME" field.
        /// </summary>
        public String OrgName
        {
            get { return this.ModifiedData.OrgName; }
            set { this.ModifiedData.OrgName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_PN_NAME" field.
        /// </summary>
        public String PnName
        {
            get { return this.ModifiedData.PnName; }
            set { this.ModifiedData.PnName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TRAINER" field.
        /// </summary>
        public Byte? Trainer
        {
            get { return this.ModifiedData.Trainer; }
            set { this.ModifiedData.Trainer = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ADMIN" field.
        /// </summary>
        public Byte? Admin
        {
            get { return this.ModifiedData.Admin; }
            set { this.ModifiedData.Admin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_SESSION" field.
        /// </summary>
        public Byte? Session
        {
            get { return this.ModifiedData.Session; }
            set { this.ModifiedData.Session = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PROD_ID" field.
        /// </summary>
        public LocalProductModel Product
        {
            get
            {
                if (_product == null && this.ProductId != null)
                    _product = this.Provider.Learning.Product.FetchById(this.ProductId);
                if (_product == null)
                    _product = this.Provider.Learning.Product.Create();
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PROD_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return this.ModifiedData.ProdId; }
            set
            {
                if (this.ModifiedData.ProdId != value)
                     _product = null;
                this.ModifiedData.ProdId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_HOUR_RATE" field.
        /// </summary>
        public Double? HourRate
        {
            get { return this.ModifiedData.HourRate; }
            set { this.ModifiedData.HourRate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_DAY_RATE" field.
        /// </summary>
        public Double? DayRate
        {
            get { return this.ModifiedData.DayRate; }
            set { this.ModifiedData.DayRate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_CST_AC" field.
        /// </summary>
        public Double? CstAc
        {
            get { return this.ModifiedData.CstAc; }
            set { this.ModifiedData.CstAc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TRAINER_T" field.
        /// </summary>
        public String TrainerT
        {
            get { return this.ModifiedData.TrainerT; }
            set { this.ModifiedData.TrainerT = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ADMIN_T" field.
        /// </summary>
        public String AdminT
        {
            get { return this.ModifiedData.AdminT; }
            set { this.ModifiedData.AdminT = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_PROF_KEY" field.
        /// </summary>
        public String ProfKey
        {
            get { return this.ModifiedData.ProfKey; }
            set { this.ModifiedData.ProfKey = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_UNT_TYPE" field.
        /// </summary>
        public String UntType
        {
            get { return this.ModifiedData.UntType; }
            set { this.ModifiedData.UntType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_INC_IN_BUDGET" field.
        /// </summary>
        public Byte IncInBudget
        {
            get { return this.ModifiedData.IncInBudget; }
            set { this.ModifiedData.IncInBudget = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalActivityXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalActivityXrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalActivityXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalActivityXrefModel(LocalProvider provider, ActivityXrefRecord record) : base(provider, record)
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
            if (_activity != null)
            {
                _activity.Save();
                this.ModifiedData.ActId = _activity.Id == null && this.ModifiedData.ActId != null ? "" : _activity.Id;
            }
            if (_person != null)
            {
                _person.Save();
                this.ModifiedData.PersonId = _person.Id == null && this.ModifiedData.PersonId != null ? "" : _person.Id;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_personRole != null)
            {
                _personRole.Save();
                this.ModifiedData.ProleId = _personRole.Id == null && this.ModifiedData.ProleId != null ? "" : _personRole.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProdId = _product.Id == null && this.ModifiedData.ProdId != null ? "" : _product.Id;
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

        Consensus.Activities.ActivityReferenceTypes IActivityXrefModel.ActivityReferenceType
        {
            get { return this.ActivityReferenceType; }
            set { this.ActivityReferenceType = (Consensus.Activities.ActivityReferenceTypes)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        Consensus.Activities.IActivityModel IActivityXrefModel.Activity
        {
            get { return this.Activity; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        System.String IActivityXrefModel.ActivityId
        {
            get { return this.ActivityId; }
            set { this.ActivityId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IActivityXrefModel.Person
        {
            get { return this.Person; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        System.String IActivityXrefModel.PersonId
        {
            get { return this.PersonId; }
            set { this.PersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IActivityXrefModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_ORG_ID" field.
        /// </summary>
        System.String IActivityXrefModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IActivityXrefModel.PersonRole
        {
            get { return this.PersonRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        System.String IActivityXrefModel.PersonRoleId
        {
            get { return this.PersonRoleId; }
            set { this.PersonRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ORG_NAME" field.
        /// </summary>
        System.String IActivityXrefModel.OrgName
        {
            get { return this.OrgName; }
            set { this.OrgName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_PN_NAME" field.
        /// </summary>
        System.String IActivityXrefModel.PnName
        {
            get { return this.PnName; }
            set { this.PnName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IActivityXrefModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TRAINER" field.
        /// </summary>
        System.Nullable<System.Byte> IActivityXrefModel.Trainer
        {
            get { return this.Trainer; }
            set { this.Trainer = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ADMIN" field.
        /// </summary>
        System.Nullable<System.Byte> IActivityXrefModel.Admin
        {
            get { return this.Admin; }
            set { this.Admin = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_SESSION" field.
        /// </summary>
        System.Nullable<System.Byte> IActivityXrefModel.Session
        {
            get { return this.Session; }
            set { this.Session = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IActivityXrefModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PROD_ID" field.
        /// </summary>
        System.String IActivityXrefModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_HOUR_RATE" field.
        /// </summary>
        System.Nullable<System.Double> IActivityXrefModel.HourRate
        {
            get { return this.HourRate; }
            set { this.HourRate = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_DAY_RATE" field.
        /// </summary>
        System.Nullable<System.Double> IActivityXrefModel.DayRate
        {
            get { return this.DayRate; }
            set { this.DayRate = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_CST_AC" field.
        /// </summary>
        System.Nullable<System.Double> IActivityXrefModel.CstAc
        {
            get { return this.CstAc; }
            set { this.CstAc = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TRAINER_T" field.
        /// </summary>
        System.String IActivityXrefModel.TrainerT
        {
            get { return this.TrainerT; }
            set { this.TrainerT = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ADMIN_T" field.
        /// </summary>
        System.String IActivityXrefModel.AdminT
        {
            get { return this.AdminT; }
            set { this.AdminT = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_PROF_KEY" field.
        /// </summary>
        System.String IActivityXrefModel.ProfKey
        {
            get { return this.ProfKey; }
            set { this.ProfKey = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_UNT_TYPE" field.
        /// </summary>
        System.String IActivityXrefModel.UntType
        {
            get { return this.UntType; }
            set { this.UntType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_INC_IN_BUDGET" field.
        /// </summary>
        System.Byte IActivityXrefModel.IncInBudget
        {
            get { return this.IncInBudget; }
            set { this.IncInBudget = (System.Byte)value; }
        }

        #endregion
    }
}
