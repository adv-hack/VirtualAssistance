using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class AccountXref : Proxy<IAccountXrefModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Account" /> member.
        /// </summary>
        private Consensus.Finance.Account _account;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Address" /> member.
        /// </summary>
        private Consensus.Contact.Address _address;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Role" /> member.
        /// </summary>
        private Consensus.Contact.Role _role;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "ACXREF_ACC_ID" field.
        /// </summary>
        public Consensus.Finance.Account Account
        {
            get
            {
                if (_account == null && this.Model.Account != null)
                    _account = new Consensus.Finance.Account(this.Model.Account);
                if (_account == null)
                    _account = Consensus.Finance.Account.Create();
                return _account;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_ACC_ID" field.
        /// </summary>
        public System.String AccountId
        {
            get { return this.Model.AccountId; }
            set { this.Model.AccountId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation Organisation
        {
            get
            {
                if (_organisation == null && this.Model.Organisation != null)
                    _organisation = new Consensus.Contact.Organisation(this.Model.Organisation);
                if (_organisation == null)
                    _organisation = Consensus.Contact.Organisation.Create();
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_ADD_ID" field.
        /// </summary>
        public Consensus.Contact.Address Address
        {
            get
            {
                if (_address == null && this.Model.Address != null)
                    _address = new Consensus.Contact.Address(this.Model.Address);
                if (_address == null)
                    _address = Consensus.Contact.Address.Create();
                return _address;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_ADD_ID" field.
        /// </summary>
        public System.String AddressId
        {
            get { return this.Model.AddressId; }
            set { this.Model.AddressId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_MAIN" field.
        /// </summary>
        public System.Nullable<System.Byte> Main
        {
            get { return this.Model.Main; }
            set { this.Model.Main = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_INVOICE" field.
        /// </summary>
        public System.Nullable<System.Byte> Invoice
        {
            get { return this.Model.Invoice; }
            set { this.Model.Invoice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_STATEMENT" field.
        /// </summary>
        public System.Nullable<System.Byte> Statement
        {
            get { return this.Model.Statement; }
            set { this.Model.Statement = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_NO_ADD_CHANGE" field.
        /// </summary>
        public System.Nullable<System.Byte> MustUse
        {
            get { return this.Model.MustUse; }
            set { this.Model.MustUse = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role Role
        {
            get
            {
                if (_role == null && this.Model.Role != null)
                    _role = new Consensus.Contact.Role(this.Model.Role);
                if (_role == null)
                    _role = Consensus.Contact.Role.Create();
                return _role;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_PROLE_ID" field.
        /// </summary>
        public System.String RoleId
        {
            get { return this.Model.RoleId; }
            set { this.Model.RoleId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal AccountXref(IAccountXrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Checks if a contact already exist for that account in database.
        /// </summary>
        /// <param name="accountId">
        ///     accountId.
        /// </param>
        /// <param name="roleId">
        ///     RoleId.
        /// </param>
        /// <param name="accounteexrefid">
        ///     accounteexrefid.
        /// </param>
        /// <returns>
        ///     Whether that person already exist for that committee in database.
        /// </returns>
        public static System.Boolean CheckIfSameContactAlreadyExists(System.String accountId, System.String roleId, System.String accounteexrefid)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.CheckIfSameContactAlreadyExists(site,accountId,roleId,accounteexrefid);
        }

        /// <summary>
        ///     Checks if a contact already exist for that account in database.
        /// </summary>
        /// <param name="accountId">
        ///     accountId.
        /// </param>
        /// <param name="roleId">
        ///     RoleId.
        /// </param>
        /// <param name="accounteexrefid">
        ///     accounteexrefid.
        /// </param>
        /// <returns>
        ///     Whether that person already exist for that committee in database.
        /// </returns>
        public static System.Boolean CheckIfSameContactAlreadyExists(ConsensusSite site, System.String accountId, System.String roleId, System.String accounteexrefid)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.AccountXref.CheckIfSameContactAlreadyExists(accountId,roleId,accounteexrefid);
        }

        /// <summary>
        ///     Checks if a contact already exist for that account in database.
        /// </summary>
        /// <param name="accountId">
        ///     accountId.
        /// </param>
        /// <param name="personId">
        ///     PersonId.
        /// </param>
        /// <param name="orgId">
        ///     Organisation Id.
        /// </param>
        /// <param name="accounteexrefid">
        ///     accounteexrefid.
        /// </param>
        /// <returns>
        ///     Whether that person already exist for that committee in database.
        /// </returns>
        public static System.Boolean CheckIfSameOrganisationAlreadyExists(System.String accountId, System.String personId, System.String orgId, System.String accounteexrefid)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.CheckIfSameOrganisationAlreadyExists(site,accountId,personId,orgId,accounteexrefid);
        }

        /// <summary>
        ///     Checks if a contact already exist for that account in database.
        /// </summary>
        /// <param name="accountId">
        ///     accountId.
        /// </param>
        /// <param name="personId">
        ///     PersonId.
        /// </param>
        /// <param name="orgId">
        ///     Organisation Id.
        /// </param>
        /// <param name="accounteexrefid">
        ///     accounteexrefid.
        /// </param>
        /// <returns>
        ///     Whether that person already exist for that committee in database.
        /// </returns>
        public static System.Boolean CheckIfSameOrganisationAlreadyExists(ConsensusSite site, System.String accountId, System.String personId, System.String orgId, System.String accounteexrefid)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.AccountXref.CheckIfSameOrganisationAlreadyExists(accountId,personId,orgId,accounteexrefid);
        }

        /// <summary>
        ///     Checks if a contact or organization exists while the data is saved.
        /// </summary>
        /// <param name="orgId">
        ///     Organization Id.
        /// </param>
        /// <param name="personid">
        ///     PersonId.
        /// </param>
        /// <returns>
        ///     Whether that person already exist for that committee in database.
        /// </returns>
        public static System.Boolean CheckIfContactOrOrganizationExists(System.String orgId, System.String personid)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.CheckIfContactOrOrganizationExists(site,orgId,personid);
        }

        /// <summary>
        ///     Checks if a contact or organization exists while the data is saved.
        /// </summary>
        /// <param name="orgId">
        ///     Organization Id.
        /// </param>
        /// <param name="personid">
        ///     PersonId.
        /// </param>
        /// <returns>
        ///     Whether that person already exist for that committee in database.
        /// </returns>
        public static System.Boolean CheckIfContactOrOrganizationExists(ConsensusSite site, System.String orgId, System.String personid)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.AccountXref.CheckIfContactOrOrganizationExists(orgId,personid);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AccountXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AccountXrefModel" /> instance.
        /// </returns>
        public static Consensus.Finance.AccountXref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AccountXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AccountXrefModel" /> instance.
        /// </returns>
        public static Consensus.Finance.AccountXref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IAccountXrefModel model = provider.Finance.AccountXref.Create();
            return model == null ? null : new Consensus.Finance.AccountXref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AccountXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AccountXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.AccountXref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AccountXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AccountXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.AccountXref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountXrefModel> collection = provider.Finance.AccountXref.FetchAll();
            return collection.Select(model => new Consensus.Finance.AccountXref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AccountXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.AccountXref FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AccountXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.AccountXref FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IAccountXrefModel model = provider.Finance.AccountXref.FetchById(id);
            return model == null ? null : new Consensus.Finance.AccountXref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.AccountXref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.AccountXref> FetchAllByAccountId(System.String accountId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.FetchAllByAccountId(site,accountId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.AccountXref> FetchAllByAccountId(ConsensusSite site, System.String accountId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountXrefModel> collection = provider.Finance.AccountXref.FetchAllByAccountId(accountId);
            return collection.Select(model => new Consensus.Finance.AccountXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.AccountXref> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.AccountXref> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountXrefModel> collection = provider.Finance.AccountXref.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Finance.AccountXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.AccountXref> FetchAllByAddressId(System.String addressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.FetchAllByAddressId(site,addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.AccountXref> FetchAllByAddressId(ConsensusSite site, System.String addressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountXrefModel> collection = provider.Finance.AccountXref.FetchAllByAddressId(addressId);
            return collection.Select(model => new Consensus.Finance.AccountXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.AccountXref> FetchAllByRoleId(System.String roleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AccountXref.FetchAllByRoleId(site,roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.AccountXref> FetchAllByRoleId(ConsensusSite site, System.String roleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IAccountXrefModel> collection = provider.Finance.AccountXref.FetchAllByRoleId(roleId);
            return collection.Select(model => new Consensus.Finance.AccountXref(model));
        }

        #endregion
    }
}
