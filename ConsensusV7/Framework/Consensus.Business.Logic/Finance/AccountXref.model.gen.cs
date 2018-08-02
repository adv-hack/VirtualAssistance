using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="AccountXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAccountXrefModel : LocalModel<AccountXrefRecord, String>, IAccountXrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ACXREF_ACC_ID" field.
        /// </summary>
        private LocalAccountModel _account;

        /// <summary>
        ///     The value of the "ACXREF_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "ACXREF_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _address;

        /// <summary>
        ///     The value of the "ACXREF_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _role;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AccountXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.AccountXref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AccountXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.AccountXref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<AccountXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.AccountXref.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_ACC_ID" field.
        /// </summary>
        public LocalAccountModel Account
        {
            get
            {
                if (_account == null && this.AccountId != null)
                    _account = this.Provider.Finance.Account.FetchById(this.AccountId);
                if (_account == null)
                    _account = this.Provider.Finance.Account.Create();
                
                return _account;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_ACC_ID" field.
        /// </summary>
        public String AccountId
        {
            get { return this.ModifiedData.AccId; }
            set
            {
                if (this.ModifiedData.AccId != value)
                     _account = null;
                this.ModifiedData.AccId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACXREF_ORG_ID" field.
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
        ///     Gets the The value of the "ACXREF_ADD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACXREF_ADD_ID" field.
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
        ///     Gets or sets the value of the "ACXREF_MAIN" field.
        /// </summary>
        public Byte? Main
        {
            get { return this.ModifiedData.Main; }
            set { this.ModifiedData.Main = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_INVOICE" field.
        /// </summary>
        public Byte? Invoice
        {
            get { return this.ModifiedData.Invoice; }
            set { this.ModifiedData.Invoice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_STATEMENT" field.
        /// </summary>
        public Byte? Statement
        {
            get { return this.ModifiedData.Statement; }
            set { this.ModifiedData.Statement = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_NO_ADD_CHANGE" field.
        /// </summary>
        public Byte? MustUse
        {
            get { return this.ModifiedData.NoAddChange; }
            set { this.ModifiedData.NoAddChange = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACXREF_PROLE_ID" field.
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

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalAccountXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalAccountXrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalAccountXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalAccountXrefModel(LocalProvider provider, AccountXrefRecord record) : base(provider, record)
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
            if (_account != null)
            {
                _account.Save();
                this.ModifiedData.AccId = _account.Id == null && this.ModifiedData.AccId != null ? "" : _account.Id;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_address != null)
            {
                _address.Save();
                this.ModifiedData.AddId = _address.Id == null && this.ModifiedData.AddId != null ? "" : _address.Id;
            }
            if (_role != null)
            {
                _role.Save();
                this.ModifiedData.ProleId = _role.Id == null && this.ModifiedData.ProleId != null ? "" : _role.Id;
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
        ///     Gets the The value of the "ACXREF_ACC_ID" field.
        /// </summary>
        Consensus.Finance.IAccountModel IAccountXrefModel.Account
        {
            get { return this.Account; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_ACC_ID" field.
        /// </summary>
        System.String IAccountXrefModel.AccountId
        {
            get { return this.AccountId; }
            set { this.AccountId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IAccountXrefModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_ORG_ID" field.
        /// </summary>
        System.String IAccountXrefModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel IAccountXrefModel.Address
        {
            get { return this.Address; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_ADD_ID" field.
        /// </summary>
        System.String IAccountXrefModel.AddressId
        {
            get { return this.AddressId; }
            set { this.AddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_MAIN" field.
        /// </summary>
        System.Nullable<System.Byte> IAccountXrefModel.Main
        {
            get { return this.Main; }
            set { this.Main = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_INVOICE" field.
        /// </summary>
        System.Nullable<System.Byte> IAccountXrefModel.Invoice
        {
            get { return this.Invoice; }
            set { this.Invoice = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_STATEMENT" field.
        /// </summary>
        System.Nullable<System.Byte> IAccountXrefModel.Statement
        {
            get { return this.Statement; }
            set { this.Statement = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_NO_ADD_CHANGE" field.
        /// </summary>
        System.Nullable<System.Byte> IAccountXrefModel.MustUse
        {
            get { return this.MustUse; }
            set { this.MustUse = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IAccountXrefModel.Role
        {
            get { return this.Role; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_PROLE_ID" field.
        /// </summary>
        System.String IAccountXrefModel.RoleId
        {
            get { return this.RoleId; }
            set { this.RoleId = (System.String)value; }
        }

        #endregion
    }
}
