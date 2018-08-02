using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="AkaRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAkaModel : LocalModel<AkaRecord, Int32>, IAkaModel
    {
        #region fields

        /// <summary>
        ///     The value of the "AKA_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _orgId;

        /// <summary>
        ///     The value of the "AKA_PN_ID" field.
        /// </summary>
        private LocalPersonModel _pnId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AkaRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Aka.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AkaRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Aka.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<AkaRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Aka.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "AKA_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "AKA_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel OrgId
        {
            get
            {
                if (_orgId == null && this.OrgIdId != null)
                    _orgId = this.Provider.Contact.Organisation.FetchById(this.OrgIdId);
                if (_orgId == null)
                    _orgId = this.Provider.Contact.Organisation.Create();
                
                return _orgId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "AKA_ORG_ID" field.
        /// </summary>
        public String OrgIdId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _orgId = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "AKA_PN_ID" field.
        /// </summary>
        public LocalPersonModel PnId
        {
            get
            {
                if (_pnId == null && this.PnIdId != null)
                    _pnId = this.Provider.Contact.Person.FetchById(this.PnIdId);
                if (_pnId == null)
                    _pnId = this.Provider.Contact.Person.Create();
                
                return _pnId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "AKA_PN_ID" field.
        /// </summary>
        public String PnIdId
        {
            get { return this.ModifiedData.PnId; }
            set
            {
                if (this.ModifiedData.PnId != value)
                     _pnId = null;
                this.ModifiedData.PnId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalAkaModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalAkaModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalAkaModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalAkaModel(LocalProvider provider, AkaRecord record) : base(provider, record)
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
            if (_orgId != null)
            {
                _orgId.Save();
                this.ModifiedData.OrgId = _orgId.Id == null && this.ModifiedData.OrgId != null ? "" : _orgId.Id;
            }
            if (_pnId != null)
            {
                _pnId.Save();
                this.ModifiedData.PnId = _pnId.Id == null && this.ModifiedData.PnId != null ? "" : _pnId.Id;
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
        ///     Gets or sets the value of the "AKA_NAME" field.
        /// </summary>
        System.String IAkaModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "AKA_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IAkaModel.OrgId
        {
            get { return this.OrgId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "AKA_ORG_ID" field.
        /// </summary>
        System.String IAkaModel.OrgIdId
        {
            get { return this.OrgIdId; }
            set { this.OrgIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "AKA_PN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IAkaModel.PnId
        {
            get { return this.PnId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "AKA_PN_ID" field.
        /// </summary>
        System.String IAkaModel.PnIdId
        {
            get { return this.PnIdId; }
            set { this.PnIdId = (System.String)value; }
        }

        #endregion
    }
}
