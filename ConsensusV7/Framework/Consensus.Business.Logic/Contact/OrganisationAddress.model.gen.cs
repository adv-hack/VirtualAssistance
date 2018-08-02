using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents An organisation address.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOrganisationAddressModel : LocalModel<AddressXrefRecord, String>, IOrganisationAddressModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ADDXREF_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _address;

        /// <summary>
        ///     The value of the "ADDXREF_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "ADDXREF_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AddressXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.OrganisationAddress.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AddressXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.OrganisationAddress.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<AddressXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.OrganisationAddress.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "ADDXREF_ADD_ID" field.
        /// </summary>
        public LocalAddressModel Address
        {
            get
            {
                if (_address == null && this.AddressId != null)
                    _address = this.Provider.Contact.Address.FetchById(this.AddressId);
                if (_address == null)
                    _address = this.Provider.Contact.Address.Create();
                
                return _address;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ADDXREF_ADD_ID" field.
        /// </summary>
        public String AddressId
        {
            get { return this.ModifiedData.AddId; }
            set
            {
                if (this.ModifiedData.AddId != value)
                     _address = null;
                this.ModifiedData.AddId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ADDXREF_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("ADDT", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("ADDT");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ADDXREF_TYPE" field.
        /// </summary>
        public String TypeCode
        {
            get { return this.ModifiedData.Type; }
            set
            {
                if (this.ModifiedData.Type != value)
                     _type = null;
                this.ModifiedData.Type = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ADDXREF_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ADDXREF_ORG_ID" field.
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
        ///     Gets or sets the value of the "ADDXREF_PRINCIPAL" field.
        /// </summary>
        public Byte? Principal
        {
            get { return this.ModifiedData.Principal; }
            set { this.ModifiedData.Principal = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalOrganisationAddressModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalOrganisationAddressModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalOrganisationAddressModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalOrganisationAddressModel(LocalProvider provider, AddressXrefRecord record) : base(provider, record)
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
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_address != null)
            {
                _address.Save();
                this.ModifiedData.AddId = _address.Id == null && this.ModifiedData.AddId != null ? "" : _address.Id;
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
        ///     Gets the The value of the "ADDXREF_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel IOrganisationAddressModel.Address
        {
            get { return this.Address; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ADDXREF_ADD_ID" field.
        /// </summary>
        System.String IOrganisationAddressModel.AddressId
        {
            get { return this.AddressId; }
            set { this.AddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ADDXREF_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IOrganisationAddressModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ADDXREF_TYPE" field.
        /// </summary>
        System.String IOrganisationAddressModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ADDXREF_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IOrganisationAddressModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ADDXREF_ORG_ID" field.
        /// </summary>
        System.String IOrganisationAddressModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADDXREF_PRINCIPAL" field.
        /// </summary>
        System.Nullable<System.Byte> IOrganisationAddressModel.Principal
        {
            get { return this.Principal; }
            set { this.Principal = (System.Nullable<System.Byte>)value; }
        }

        #endregion
    }
}
