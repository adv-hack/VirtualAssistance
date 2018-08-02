using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PortalUserRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPortalUserModel : LocalModel<PortalUserRecord, Int32>, IPortalUserModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PU_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _personRole;

        /// <summary>
        ///     The value of the "PU_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The collection of <see cref="PortalUserSiteModel" /> instances that reference this <see cref="PortalUserModel" />.
        /// </summary>
        private LocalCollection<LocalPortalUserSiteModel, IPortalUserSiteModel> _portalUserSites;

        /// <summary>
        ///     The collection of <see cref="PortalUserRoleModel" /> instances that reference this <see cref="PortalUserModel" />.
        /// </summary>
        private LocalCollection<LocalPortalUserRoleModel, IPortalUserRoleModel> _portalUserRoles;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortalUserRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Portal.PortalUser.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortalUserRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Portal.PortalUser.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortalUserRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Portal.PortalUser.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PU_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PU_PROLE_ID" field.
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
        ///     Gets or sets the value of the "PU_LOGIN_ID" field.
        /// </summary>
        public String LoginId
        {
            get { return this.ModifiedData.LoginId; }
            set { this.ModifiedData.LoginId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_BARRED" field.
        /// </summary>
        public Byte? Barred
        {
            get { return this.ModifiedData.Barred; }
            set { this.ModifiedData.Barred = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_NTUSERNAME" field.
        /// </summary>
        public String Ntusername
        {
            get { return this.ModifiedData.Ntusername; }
            set { this.ModifiedData.Ntusername = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PU_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PU_SELCO_SP_ID" field.
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

        /// <summary>
        ///     Gets or sets the value of the "PU_FIRST_LOGIN" field.
        /// </summary>
        public DateTime? FirstLogin
        {
            get { return this.ModifiedData.FirstLogin; }
            set { this.ModifiedData.FirstLogin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_LAST_LOGIN" field.
        /// </summary>
        public DateTime? LastLogin
        {
            get { return this.ModifiedData.LastLogin; }
            set { this.ModifiedData.LastLogin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_AUTH_PROVIDER" field.
        /// </summary>
        public String AuthProvider
        {
            get { return this.ModifiedData.AuthProvider; }
            set { this.ModifiedData.AuthProvider = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PortalUserSiteModel" /> instances that reference this <see cref="PortalUserModel" />.
        /// </summary>
        public LocalCollection<LocalPortalUserSiteModel, IPortalUserSiteModel> PortalUserSites
        {
            get
            {
                if (_portalUserSites == null)
                    _portalUserSites = new LocalCollection<LocalPortalUserSiteModel, IPortalUserSiteModel>(this.Provider.Portal.PortalUserSite.FetchAllByPortalUserId(this.Id));
                
                return _portalUserSites;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PortalUserRoleModel" /> instances that reference this <see cref="PortalUserModel" />.
        /// </summary>
        public LocalCollection<LocalPortalUserRoleModel, IPortalUserRoleModel> PortalUserRoles
        {
            get
            {
                if (_portalUserRoles == null)
                    _portalUserRoles = new LocalCollection<LocalPortalUserRoleModel, IPortalUserRoleModel>(this.Provider.Portal.PortalUserRole.FetchAllByPortalUserId(this.Id));
                
                return _portalUserRoles;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPortalUserModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPortalUserModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPortalUserModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPortalUserModel(LocalProvider provider, PortalUserRecord record) : base(provider, record)
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
            if (_personRole != null)
            {
                _personRole.Save();
                this.ModifiedData.ProleId = _personRole.Id == null && this.ModifiedData.ProleId != null ? "" : _personRole.Id;
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
            if (_portalUserSites != null)
                _portalUserSites.Execute(obj => obj.PortalUserId = this.Id).Execute(obj => obj.Save());
            if (_portalUserRoles != null)
                _portalUserRoles.Execute(obj => obj.PortalUserId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the new password entered from reset password screen.
        /// </summary>
        System.String IPortalUserModel.NewPassword
        {
            get { return this.NewPassword; }
            set { this.NewPassword = (System.String)value; }
        }

        /// <summary>
        ///     sets the password.
        /// </summary>
        System.String IPortalUserModel.Password
        {
            set { this.Password = (System.String)value; }
        }

        System.Boolean IPortalUserModel.IsModified
        {
            get { return this.IsModified; }
        }

        /// <summary>
        ///     Gets the The value of the "PU_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IPortalUserModel.PersonRole
        {
            get { return this.PersonRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PU_PROLE_ID" field.
        /// </summary>
        System.String IPortalUserModel.PersonRoleId
        {
            get { return this.PersonRoleId; }
            set { this.PersonRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_LOGIN_ID" field.
        /// </summary>
        System.String IPortalUserModel.LoginId
        {
            get { return this.LoginId; }
            set { this.LoginId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_BARRED" field.
        /// </summary>
        System.Nullable<System.Byte> IPortalUserModel.Barred
        {
            get { return this.Barred; }
            set { this.Barred = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_NTUSERNAME" field.
        /// </summary>
        System.String IPortalUserModel.Ntusername
        {
            get { return this.Ntusername; }
            set { this.Ntusername = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PU_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IPortalUserModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PU_SELCO_SP_ID" field.
        /// </summary>
        System.String IPortalUserModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_FIRST_LOGIN" field.
        /// </summary>
        System.Nullable<System.DateTime> IPortalUserModel.FirstLogin
        {
            get { return this.FirstLogin; }
            set { this.FirstLogin = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_LAST_LOGIN" field.
        /// </summary>
        System.Nullable<System.DateTime> IPortalUserModel.LastLogin
        {
            get { return this.LastLogin; }
            set { this.LastLogin = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_AUTH_PROVIDER" field.
        /// </summary>
        System.String IPortalUserModel.AuthProvider
        {
            get { return this.AuthProvider; }
            set { this.AuthProvider = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserSiteModel" /> instances that reference this <see cref="!:PortalUserModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserSiteModel> IPortalUserModel.PortalUserSites
        {
            get { return this.PortalUserSites; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserRoleModel" /> instances that reference this <see cref="!:PortalUserModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserRoleModel> IPortalUserModel.PortalUserRoles
        {
            get { return this.PortalUserRoles; }
        }

        void IPortalUserModel.UpdateUserRoles(System.Collections.ArrayList portaluserRoles)
        {
            this.UpdateUserRoles(portaluserRoles);
        }

        void IPortalUserModel.UpdateUserPortals(System.Collections.ArrayList portaluserPortals)
        {
            this.UpdateUserPortals(portaluserPortals);
        }

        #endregion
    }
}
