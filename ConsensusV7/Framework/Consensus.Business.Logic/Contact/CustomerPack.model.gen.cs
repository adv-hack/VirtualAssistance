using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Document;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="CustomerPackRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCustomerPackModel : LocalModel<CustomerPackRecord, Int32>, ICustomerPackModel
    {
        #region fields

        /// <summary>
        ///     The value of the "CPA_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "CPA_PACK_ID" field.
        /// </summary>
        private LocalPackModel _pack;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CustomerPackRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.CustomerPack.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CustomerPackRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.CustomerPack.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CustomerPackRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.CustomerPack.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "CPA_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "CPA_ORG_ID" field.
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
        ///     Gets the The value of the "CPA_PACK_ID" field.
        /// </summary>
        public LocalPackModel Pack
        {
            get
            {
                if (_pack == null && this.PackId != null)
                    _pack = this.Provider.Document.Pack.FetchById(this.PackId);
                if (_pack == null)
                    _pack = this.Provider.Document.Pack.Create();
                
                return _pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CPA_PACK_ID" field.
        /// </summary>
        public String PackId
        {
            get { return this.ModifiedData.PackId; }
            set
            {
                if (this.ModifiedData.PackId != value)
                     _pack = null;
                this.ModifiedData.PackId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "CPA_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CPA_SUPPRESS" field.
        /// </summary>
        public Byte Suppress
        {
            get { return this.ModifiedData.Suppress; }
            set { this.ModifiedData.Suppress = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCustomerPackModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCustomerPackModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCustomerPackModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCustomerPackModel(LocalProvider provider, CustomerPackRecord record) : base(provider, record)
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
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_pack != null)
            {
                _pack.Save();
                this.ModifiedData.PackId = _pack.Id == null && this.ModifiedData.PackId != null ? "" : _pack.Id;
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
        ///     Gets the The value of the "CPA_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel ICustomerPackModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CPA_ORG_ID" field.
        /// </summary>
        System.String ICustomerPackModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CPA_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel ICustomerPackModel.Pack
        {
            get { return this.Pack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CPA_PACK_ID" field.
        /// </summary>
        System.String ICustomerPackModel.PackId
        {
            get { return this.PackId; }
            set { this.PackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CPA_TYPE" field.
        /// </summary>
        System.String ICustomerPackModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CPA_SUPPRESS" field.
        /// </summary>
        System.Byte ICustomerPackModel.Suppress
        {
            get { return this.Suppress; }
            set { this.Suppress = (System.Byte)value; }
        }

        #endregion
    }
}
