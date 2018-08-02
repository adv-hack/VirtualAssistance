using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserSessionModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserSessionFactory : LocalFactory<LocalUserSessionModel, UserSessionRecord, Guid>, IUserSessionFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='UserSessionModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='UserSessionModel' /> instance.
        /// </returns>
        public LocalUserSessionModel Create()
        {
            return new LocalUserSessionModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='UserSessionModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='UserSessionModel' /> instances.
        /// </returns>
        public IEnumerable<LocalUserSessionModel> FetchAll()
        {
            IEnumerable<UserSessionRecord> recordCollection = this.Provider.DataProvider.Security.UserSession.FetchAll();
            foreach (UserSessionRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserSessionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='UserSessionModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='UserSessionModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserSessionModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalUserSessionModel FetchById(Guid id)
        {
            UserSessionRecord record = this.Provider.DataProvider.Security.UserSession.FetchById(id);
            if (record == null)
                return null;
            return new LocalUserSessionModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='UserSession/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Security.UserSession.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='UserSessionModel' /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref='UserSessionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserSessionModel' /> instances that match the specified <paramref name='userId' />.
        /// </returns>
        public IEnumerable<LocalUserSessionModel> FetchAllByUserId(Int32 userId)
        {
            IEnumerable<UserSessionRecord> recordCollection = this.Provider.DataProvider.Security.UserSession.FetchAllByUserId(userId);
            foreach (UserSessionRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserSessionModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the authentication session for the currently logged on user.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:Consensus.Security.IUserSessionModel" /> for the currently authenticated user.
        /// </returns>
        Consensus.Security.IUserSessionModel IUserSessionFactory.FetchCurrent()
        {
            return this.FetchCurrent();
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
        void IUserSessionFactory.Login(System.String username, System.String password)
        {
            this.Login(username, password);
        }

        /// <summary>
        ///     Extends the expiry period for the current authentication session.
        /// </summary>
        void IUserSessionFactory.Update()
        {
            this.Update();
        }

        /// <summary>
        ///     Terminates the current authentication session.
        /// </summary>
        void IUserSessionFactory.Logout()
        {
            this.Logout();
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserSessionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserSessionModel" /> instance.
        /// </returns>
        Consensus.Security.IUserSessionModel IUserSessionFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserSessionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserSessionModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserSessionModel> IUserSessionFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Security.IUserSessionModel IUserSessionFactory.FetchById(System.Guid id)
        {
            return this.FetchById(id);
        }

        System.String IUserSessionFactory.GetTableName()
        {
            return this.GetTableName();
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
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserSessionModel> IUserSessionFactory.FetchAllByUserId(System.Int32 userId)
        {
            return this.FetchAllByUserId(userId);
        }

        #endregion
    }
}
