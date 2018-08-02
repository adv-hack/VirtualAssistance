using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a current or historic credential used to authenticate a user.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class UserCredential : Proxy<IUserCredentialModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="User" /> member.
        /// </summary>
        private Consensus.Security.UserAccount _user;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The user account to whom the password belongs.
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
        ///     Gets or sets the unique code for The user account to whom the password belongs.
        /// </summary>
        public System.Int32 UserId
        {
            get { return this.Model.UserId; }
            set { this.Model.UserId = value; }
        }

        /// <summary>
        ///     Gets or sets The salting value for the password,.
        /// </summary>
        public System.Byte[] Salt
        {
            get { return this.Model.Salt; }
            set { this.Model.Salt = value; }
        }

        /// <summary>
        ///     Gets or sets The verifier for the password.
        /// </summary>
        public System.Byte[] Pass
        {
            get { return this.Model.Pass; }
            set { this.Model.Pass = value; }
        }

        /// <summary>
        ///     Gets or sets The date and time on which the password was set.
        /// </summary>
        public System.DateTime Modified
        {
            get { return this.Model.Modified; }
            set { this.Model.Modified = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal UserCredential(IUserCredentialModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:UserCredentialModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserCredentialModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserCredential Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserCredential.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserCredentialModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserCredentialModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserCredential Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserCredentialModel model = provider.Security.UserCredential.Create();
            return model == null ? null : new Consensus.Security.UserCredential(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserCredentialModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserCredentialModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserCredential> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserCredential.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserCredentialModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserCredentialModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserCredential> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserCredentialModel> collection = provider.Security.UserCredential.FetchAll();
            return collection.Select(model => new Consensus.Security.UserCredential(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserCredentialModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserCredentialModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserCredentialModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserCredential FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserCredential.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserCredentialModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserCredentialModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserCredentialModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserCredential FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserCredentialModel model = provider.Security.UserCredential.FetchById(id);
            return model == null ? null : new Consensus.Security.UserCredential(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserCredential.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserCredential.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserCredentialModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:UserCredentialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserCredentialModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserCredential> FetchAllByUserId(System.Int32 userId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserCredential.FetchAllByUserId(site,userId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserCredentialModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:UserCredentialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserCredentialModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserCredential> FetchAllByUserId(ConsensusSite site, System.Int32 userId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserCredentialModel> collection = provider.Security.UserCredential.FetchAllByUserId(userId);
            return collection.Select(model => new Consensus.Security.UserCredential(model));
        }

        #endregion
    }
}
