using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a current or historic authentication session.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class UserSession : Proxy<IUserSessionModel, Guid>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="User" /> member.
        /// </summary>
        private Consensus.Security.UserAccount _user;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the status of the authentication session.
        /// </summary>
        public Consensus.Security.UserSessionStates Status
        {
            get { return this.Model.Status; }
        }

        /// <summary>
        ///     Gets the The user account that has been authenticated.
        /// </summary>
        public Consensus.Security.UserAccount User
        {
            get
            {
                if (_user == null && this.Model.User != null)
                    _user = new Consensus.Security.UserAccount(this.Model.User);
                if (_user == null)
                    _user = Consensus.Security.UserAccount.Create();
                return _user;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for The user account that has been authenticated.
        /// </summary>
        public System.Int32 UserId
        {
            get { return this.Model.UserId; }
            set { this.Model.UserId = value; }
        }

        /// <summary>
        ///     Gets or sets The date and time on which the session became active.
        /// </summary>
        public System.DateTime Active
        {
            get { return this.Model.Active; }
            set { this.Model.Active = value; }
        }

        /// <summary>
        ///     Gets or sets The date and time on which the session automatically expires, or was terminated.
        /// </summary>
        public System.DateTime Expiry
        {
            get { return this.Model.Expiry; }
            set { this.Model.Expiry = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal UserSession(IUserSessionModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets the authentication session for the currently logged on user.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:Consensus.Security.IUserSessionModel" /> for the currently authenticated user.
        /// </returns>
        public static Consensus.Security.UserSession FetchCurrent()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserSession.FetchCurrent(site);
        }

        /// <summary>
        ///     Gets the authentication session for the currently logged on user.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:Consensus.Security.IUserSessionModel" /> for the currently authenticated user.
        /// </returns>
        public static Consensus.Security.UserSession FetchCurrent(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserSessionModel model = provider.Security.UserSession.FetchCurrent();
            return model == null ? null : new Consensus.Security.UserSession(model);
        }

        /// <summary>
        ///     Authenticates a user account using pre-shared credentials.
        /// </summary>
        /// <param name="username">
        ///     The unique name which distinctly identifies the account to be authenticated.
        /// </param>
        /// <param name="password">
        ///     The pre-shared secret which confirms the identity of the authenticating user.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Security.IUserSessionModel" /> instance for the authenticated user.
        /// </returns>
        public static void Login(System.String username, System.String password)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            UserSession.Login(site,username,password);
        }

        /// <summary>
        ///     Authenticates a user account using pre-shared credentials.
        /// </summary>
        /// <param name="username">
        ///     The unique name which distinctly identifies the account to be authenticated.
        /// </param>
        /// <param name="password">
        ///     The pre-shared secret which confirms the identity of the authenticating user.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Security.IUserSessionModel" /> instance for the authenticated user.
        /// </returns>
        public static void Login(ConsensusSite site, System.String username, System.String password)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            provider.Security.UserSession.Login(username,password);
        }

        /// <summary>
        ///     Extends the expiry period for the current authentication session.
        /// </summary>
        public static void Update()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            UserSession.Update(site);
        }

        /// <summary>
        ///     Extends the expiry period for the current authentication session.
        /// </summary>
        public static void Update(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            provider.Security.UserSession.Update();
        }

        /// <summary>
        ///     Terminates the current authentication session.
        /// </summary>
        public static void Logout()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            UserSession.Logout(site);
        }

        /// <summary>
        ///     Terminates the current authentication session.
        /// </summary>
        public static void Logout(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            provider.Security.UserSession.Logout();
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserSessionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserSessionModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserSession Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserSession.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserSessionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserSessionModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserSession Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserSessionModel model = provider.Security.UserSession.Create();
            return model == null ? null : new Consensus.Security.UserSession(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserSessionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserSessionModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserSession> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserSession.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserSessionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserSessionModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserSession> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserSessionModel> collection = provider.Security.UserSession.FetchAll();
            return collection.Select(model => new Consensus.Security.UserSession(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserSessionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserSessionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserSessionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserSession FetchById(System.Guid id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserSession.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserSessionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserSessionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserSessionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserSession FetchById(ConsensusSite site, System.Guid id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserSessionModel model = provider.Security.UserSession.FetchById(id);
            return model == null ? null : new Consensus.Security.UserSession(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserSession.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserSession.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserSessionModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:UserSessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserSessionModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserSession> FetchAllByUserId(System.Int32 userId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserSession.FetchAllByUserId(site,userId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserSessionModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:UserSessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserSessionModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserSession> FetchAllByUserId(ConsensusSite site, System.Int32 userId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserSessionModel> collection = provider.Security.UserSession.FetchAllByUserId(userId);
            return collection.Select(model => new Consensus.Security.UserSession(model));
        }

        #endregion
    }
}
