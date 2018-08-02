using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Reporting;
using Consensus.UserInterface;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents an individual user.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class UserAccount : Proxy<IUserAccountModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Principal" /> member.
        /// </summary>
        private Consensus.Security.UserPrincipal _principal;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Person" /> member.
        /// </summary>
        private Consensus.Contact.Person _person;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ReportId" /> member.
        /// </summary>
        private Consensus.Reporting.Report _reportId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="QuickAccessLinks" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.QuickAccessLink, Consensus.UserInterface.IQuickAccessLinkModel> _quickAccessLinks;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="HistoryLinks" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.HistoryLink, Consensus.UserInterface.IHistoryLinkModel> _historyLinks;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Credentials" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.UserCredential, Consensus.Security.IUserCredentialModel> _credentials;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="UserSessions" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.UserSession, Consensus.Security.IUserSessionModel> _userSessions;

        #endregion

        #region properties

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        public System.Boolean IsModified
        {
            get { return this.Model.IsModified; }
        }

        /// <summary>
        ///     Gets or sets the name of the user.
        /// </summary>
        public System.String Username
        {
            get { return this.Model.Username; }
            set { this.Model.Username = value; }
        }

        /// <summary>
        ///     Sets the users new password.
        /// </summary>
        public System.String Password
        {
            set { this.Model.Password = value; }
        }

        /// <summary>
        ///     Gets the The security principal referenced by the account.
        /// </summary>
        public Consensus.Security.UserPrincipal Principal
        {
            get
            {
                if (_principal == null && this.Model.Principal != null)
                    _principal = new Consensus.Security.UserPrincipal(this.Model.Principal);
                if (_principal == null)
                    _principal = Consensus.Security.UserPrincipal.Create();
                return _principal;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal referenced by the account.
        /// </summary>
        public System.Int32 PrincipalId
        {
            get { return this.Model.PrincipalId; }
            set { this.Model.PrincipalId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "USER_PERSON_ID" field.
        /// </summary>
        public Consensus.Contact.Person Person
        {
            get
            {
                if (_person == null && this.Model.Person != null)
                    _person = new Consensus.Contact.Person(this.Model.Person);
                if (_person == null)
                    _person = Consensus.Contact.Person.Create();
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "USER_PERSON_ID" field.
        /// </summary>
        public System.String PersonId
        {
            get { return this.Model.PersonId; }
            set { this.Model.PersonId = value; }
        }

        /// <summary>
        ///     Gets the The selling company settings applied to the user.
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
        ///     Gets or sets the unique code for The selling company settings applied to the user.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets The enumerated status of the user account.
        /// </summary>
        public System.Int32 Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets or sets The number of login attempts that have failed since the user last logged on successfully.
        /// </summary>
        public System.Int32 FailCount
        {
            get { return this.Model.FailCount; }
            set { this.Model.FailCount = value; }
        }

        /// <summary>
        ///     Gets or sets The date and time of the last successful authentication.
        /// </summary>
        public System.Nullable<System.DateTime> LastLogin
        {
            get { return this.Model.LastLogin; }
            set { this.Model.LastLogin = value; }
        }

        /// <summary>
        ///     Gets or sets The name of the authentication provider.
        /// </summary>
        public System.String AuthenticationProvider
        {
            get { return this.Model.AuthenticationProvider; }
            set { this.Model.AuthenticationProvider = value; }
        }

        /// <summary>
        ///     Gets or sets Sys admin flag.
        /// </summary>
        public System.Nullable<System.Byte> SysAdmin
        {
            get { return this.Model.SysAdmin; }
            set { this.Model.SysAdmin = value; }
        }

        /// <summary>
        ///     Gets or sets Determines whether user is  in Pool A or Pool B.
        /// </summary>
        public System.Int32 LicenseType
        {
            get { return this.Model.LicenseType; }
            set { this.Model.LicenseType = value; }
        }

        /// <summary>
        ///     Gets the It's use for set the Home page dashboard report id.
        /// </summary>
        public Consensus.Reporting.Report ReportId
        {
            get
            {
                if (_reportId == null && this.Model.ReportId != null)
                    _reportId = new Consensus.Reporting.Report(this.Model.ReportId);
                if (_reportId == null)
                    _reportId = Consensus.Reporting.Report.Create();
                return _reportId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for It's use for set the Home page dashboard report id.
        /// </summary>
        public System.String ReportIdId
        {
            get { return this.Model.ReportIdId; }
            set { this.Model.ReportIdId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:QuickAccessLinkModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.QuickAccessLink> QuickAccessLinks
        {
            get
            {
                if (_quickAccessLinks == null)
                    _quickAccessLinks = new ProxyCollection<Consensus.UserInterface.QuickAccessLink, Consensus.UserInterface.IQuickAccessLinkModel>(this.Model.QuickAccessLinks, model => new Consensus.UserInterface.QuickAccessLink(model));
                return _quickAccessLinks;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HistoryLinkModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.HistoryLink> HistoryLinks
        {
            get
            {
                if (_historyLinks == null)
                    _historyLinks = new ProxyCollection<Consensus.UserInterface.HistoryLink, Consensus.UserInterface.IHistoryLinkModel>(this.Model.HistoryLinks, model => new Consensus.UserInterface.HistoryLink(model));
                return _historyLinks;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserCredentialModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        public Collection<Consensus.Security.UserCredential> Credentials
        {
            get
            {
                if (_credentials == null)
                    _credentials = new ProxyCollection<Consensus.Security.UserCredential, Consensus.Security.IUserCredentialModel>(this.Model.Credentials, model => new Consensus.Security.UserCredential(model));
                return _credentials;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserSessionModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        public Collection<Consensus.Security.UserSession> UserSessions
        {
            get
            {
                if (_userSessions == null)
                    _userSessions = new ProxyCollection<Consensus.Security.UserSession, Consensus.Security.IUserSessionModel>(this.Model.UserSessions, model => new Consensus.Security.UserSession(model));
                return _userSessions;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal UserAccount(IUserAccountModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public System.Boolean HasPermission<Type>(System.Enum permission)
        {
            return this.Model.HasPermission<Type>(permission);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <param name="username">
        ///     The unique username which distinctly identifies the <see cref="!:UserAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instance that matches the specified <paramref name="username" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserAccount FetchByUsername(System.String username)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.FetchByUsername(site,username);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <param name="username">
        ///     The unique username which distinctly identifies the <see cref="!:UserAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instance that matches the specified <paramref name="username" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserAccount FetchByUsername(ConsensusSite site, System.String username)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserAccountModel model = provider.Security.UserAccount.FetchByUsername(username);
            return model == null ? null : new Consensus.Security.UserAccount(model);
        }

        /// <summary>
        ///     Gets the reporting URL.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.String" /> containing a URL.
        /// </returns>
        public static System.String ReportingURL(System.String portalPage)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.ReportingURL(site,portalPage);
        }

        /// <summary>
        ///     Gets the reporting URL.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.String" /> containing a URL.
        /// </returns>
        public static System.String ReportingURL(ConsensusSite site, System.String portalPage)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserAccount.ReportingURL(portalPage);
        }

        /// <summary>
        ///     Checks whether Pool B user is allowed to create account.
        /// </summary>
        /// <param name="userAccountId">
        ///     Id of UserAccount.
        /// </param>
        /// <param name="licenseType">
        ///     Type of License whether its Pool A or Pool B.
        /// </param>
        /// <param name="status">
        ///     Determins whether status is Active.
        /// </param>
        /// <returns>
        ///     Whether PoolB account can be created or not.
        /// </returns>
        public static System.Boolean CheckPoolBUserAllowed(System.String userAccountId, System.String licenseType, System.String status)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.CheckPoolBUserAllowed(site,userAccountId,licenseType,status);
        }

        /// <summary>
        ///     Checks whether Pool B user is allowed to create account.
        /// </summary>
        /// <param name="userAccountId">
        ///     Id of UserAccount.
        /// </param>
        /// <param name="licenseType">
        ///     Type of License whether its Pool A or Pool B.
        /// </param>
        /// <param name="status">
        ///     Determins whether status is Active.
        /// </param>
        /// <returns>
        ///     Whether PoolB account can be created or not.
        /// </returns>
        public static System.Boolean CheckPoolBUserAllowed(ConsensusSite site, System.String userAccountId, System.String licenseType, System.String status)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserAccount.CheckPoolBUserAllowed(userAccountId,licenseType,status);
        }

        /// <summary>
        ///     Checks if user is allowed to create Pool B license.
        /// </summary>
        /// <param name="isUserAllowed">
        ///     Whether PoolB account can be created or not.
        /// </param>
        /// <param name="userAccountId">
        ///     Id of User account.
        /// </param>
        /// <returns>
        ///     Whether PoolB account can be created or not.
        /// </returns>
        public static System.Boolean CheckIsUserAllowed(System.Boolean isUserAllowed, System.String userAccountId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.CheckIsUserAllowed(site,isUserAllowed,userAccountId);
        }

        /// <summary>
        ///     Checks if user is allowed to create Pool B license.
        /// </summary>
        /// <param name="isUserAllowed">
        ///     Whether PoolB account can be created or not.
        /// </param>
        /// <param name="userAccountId">
        ///     Id of User account.
        /// </param>
        /// <returns>
        ///     Whether PoolB account can be created or not.
        /// </returns>
        public static System.Boolean CheckIsUserAllowed(ConsensusSite site, System.Boolean isUserAllowed, System.String userAccountId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserAccount.CheckIsUserAllowed(isUserAllowed,userAccountId);
        }

        /// <summary>
        ///     Checks if username already exist in database.
        /// </summary>
        /// <param name="username">
        ///     Username of User account.
        /// </param>
        /// <param name="userId">
        ///     Id of User.
        /// </param>
        /// <returns>
        ///     Whether username already exist in database.
        /// </returns>
        public static System.Boolean CheckIfUsernameExist(System.String username, System.String userId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.CheckIfUsernameExist(site,username,userId);
        }

        /// <summary>
        ///     Checks if username already exist in database.
        /// </summary>
        /// <param name="username">
        ///     Username of User account.
        /// </param>
        /// <param name="userId">
        ///     Id of User.
        /// </param>
        /// <returns>
        ///     Whether username already exist in database.
        /// </returns>
        public static System.Boolean CheckIfUsernameExist(ConsensusSite site, System.String username, System.String userId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserAccount.CheckIfUsernameExist(username,userId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserAccountModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserAccount Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserAccountModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserAccount Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserAccountModel model = provider.Security.UserAccount.Create();
            return model == null ? null : new Consensus.Security.UserAccount(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserAccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserAccountModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserAccount> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserAccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserAccountModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserAccount> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserAccountModel> collection = provider.Security.UserAccount.FetchAll();
            return collection.Select(model => new Consensus.Security.UserAccount(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserAccount FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserAccount FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserAccountModel model = provider.Security.UserAccount.FetchById(id);
            return model == null ? null : new Consensus.Security.UserAccount(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserAccount.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserAccount> FetchAllByPrincipalId(System.Int32 principalId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.FetchAllByPrincipalId(site,principalId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserAccount> FetchAllByPrincipalId(ConsensusSite site, System.Int32 principalId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserAccountModel> collection = provider.Security.UserAccount.FetchAllByPrincipalId(principalId);
            return collection.Select(model => new Consensus.Security.UserAccount(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserAccount> FetchAllByPersonId(System.String personId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.FetchAllByPersonId(site,personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserAccount> FetchAllByPersonId(ConsensusSite site, System.String personId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserAccountModel> collection = provider.Security.UserAccount.FetchAllByPersonId(personId);
            return collection.Select(model => new Consensus.Security.UserAccount(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserAccount> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserAccount> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserAccountModel> collection = provider.Security.UserAccount.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Security.UserAccount(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="reportIdId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="reportIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserAccount> FetchAllByReportIdId(System.String reportIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserAccount.FetchAllByReportIdId(site,reportIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="reportIdId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="reportIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserAccount> FetchAllByReportIdId(ConsensusSite site, System.String reportIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserAccountModel> collection = provider.Security.UserAccount.FetchAllByReportIdId(reportIdId);
            return collection.Select(model => new Consensus.Security.UserAccount(model));
        }

        #endregion
    }
}
