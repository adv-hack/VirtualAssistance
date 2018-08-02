using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;

namespace Consensus.Portal
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PortalUser : Proxy<IPortalUserModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PersonRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _personRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PortalUserSites" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Portal.PortalUserSite, Consensus.Portal.IPortalUserSiteModel> _portalUserSites;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PortalUserRoles" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Portal.PortalUserRole, Consensus.Portal.IPortalUserRoleModel> _portalUserRoles;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the new password entered from reset password screen.
        /// </summary>
        public System.String NewPassword
        {
            get { return this.Model.NewPassword; }
            set { this.Model.NewPassword = value; }
        }

        /// <summary>
        ///     sets the password.
        /// </summary>
        public System.String Password
        {
            set { this.Model.Password = value; }
        }

        public System.Boolean IsModified
        {
            get { return this.Model.IsModified; }
        }

        /// <summary>
        ///     Gets the The value of the "PU_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role PersonRole
        {
            get
            {
                if (_personRole == null && this.Model.PersonRole != null)
                    _personRole = new Consensus.Contact.Role(this.Model.PersonRole);
                if (_personRole == null)
                    _personRole = Consensus.Contact.Role.Create();
                return _personRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PU_PROLE_ID" field.
        /// </summary>
        public System.String PersonRoleId
        {
            get { return this.Model.PersonRoleId; }
            set { this.Model.PersonRoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_LOGIN_ID" field.
        /// </summary>
        public System.String LoginId
        {
            get { return this.Model.LoginId; }
            set { this.Model.LoginId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_BARRED" field.
        /// </summary>
        public System.Nullable<System.Byte> Barred
        {
            get { return this.Model.Barred; }
            set { this.Model.Barred = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_NTUSERNAME" field.
        /// </summary>
        public System.String Ntusername
        {
            get { return this.Model.Ntusername; }
            set { this.Model.Ntusername = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PU_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.Model.SellingCompany != null)
                    _sellingCompany = new Consensus.Common.SellingCompany(this.Model.SellingCompany);
                if (_sellingCompany == null)
                    _sellingCompany = Consensus.Common.SellingCompany.Create();
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PU_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_FIRST_LOGIN" field.
        /// </summary>
        public System.Nullable<System.DateTime> FirstLogin
        {
            get { return this.Model.FirstLogin; }
            set { this.Model.FirstLogin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_LAST_LOGIN" field.
        /// </summary>
        public System.Nullable<System.DateTime> LastLogin
        {
            get { return this.Model.LastLogin; }
            set { this.Model.LastLogin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_AUTH_PROVIDER" field.
        /// </summary>
        public System.String AuthProvider
        {
            get { return this.Model.AuthProvider; }
            set { this.Model.AuthProvider = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserSiteModel" /> instances that reference this <see cref="!:PortalUserModel" />.
        /// </summary>
        public Collection<Consensus.Portal.PortalUserSite> PortalUserSites
        {
            get
            {
                if (_portalUserSites == null)
                    _portalUserSites = new ProxyCollection<Consensus.Portal.PortalUserSite, Consensus.Portal.IPortalUserSiteModel>(this.Model.PortalUserSites, model => new Consensus.Portal.PortalUserSite(model));
                return _portalUserSites;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserRoleModel" /> instances that reference this <see cref="!:PortalUserModel" />.
        /// </summary>
        public Collection<Consensus.Portal.PortalUserRole> PortalUserRoles
        {
            get
            {
                if (_portalUserRoles == null)
                    _portalUserRoles = new ProxyCollection<Consensus.Portal.PortalUserRole, Consensus.Portal.IPortalUserRoleModel>(this.Model.PortalUserRoles, model => new Consensus.Portal.PortalUserRole(model));
                return _portalUserRoles;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PortalUser(IPortalUserModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public void UpdateUserRoles(System.Collections.ArrayList portaluserRoles)
        {
            this.Model.UpdateUserRoles(portaluserRoles);
        }

        public void UpdateUserPortals(System.Collections.ArrayList portaluserPortals)
        {
            this.Model.UpdateUserPortals(portaluserPortals);
        }

        public static System.Boolean CheckIfUsernameExist(System.String name, System.String userId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUser.CheckIfUsernameExist(site,name,userId);
        }

        public static System.Boolean CheckIfUsernameExist(ConsensusSite site, System.String name, System.String userId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Portal.PortalUser.CheckIfUsernameExist(name,userId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PortalUserModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserModel" /> instance.
        /// </returns>
        public static Consensus.Portal.PortalUser Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUser.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PortalUserModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserModel" /> instance.
        /// </returns>
        public static Consensus.Portal.PortalUser Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Portal.IPortalUserModel model = provider.Portal.PortalUser.Create();
            return model == null ? null : new Consensus.Portal.PortalUser(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUser> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUser.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUser> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalUserModel> collection = provider.Portal.PortalUser.FetchAll();
            return collection.Select(model => new Consensus.Portal.PortalUser(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Portal.PortalUser FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUser.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Portal.PortalUser FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Portal.IPortalUserModel model = provider.Portal.PortalUser.FetchById(id);
            return model == null ? null : new Consensus.Portal.PortalUser(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUser.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Portal.PortalUser.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserModel" /> instances.
        /// </summary>
        /// <param name="personRoleId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instances that match the specified <paramref name="personRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUser> FetchAllByPersonRoleId(System.String personRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUser.FetchAllByPersonRoleId(site,personRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserModel" /> instances.
        /// </summary>
        /// <param name="personRoleId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instances that match the specified <paramref name="personRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUser> FetchAllByPersonRoleId(ConsensusSite site, System.String personRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalUserModel> collection = provider.Portal.PortalUser.FetchAllByPersonRoleId(personRoleId);
            return collection.Select(model => new Consensus.Portal.PortalUser(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUser> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PortalUser.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Portal.PortalUser> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Portal.IPortalUserModel> collection = provider.Portal.PortalUser.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Portal.PortalUser(model));
        }

        #endregion
    }
}
