using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserAccountModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserAccountFactory : LocalFactory<LocalUserAccountModel, UserAccountRecord, Int32>, IUserAccountFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='UserAccountModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='UserAccountModel' /> instance.
        /// </returns>
        public LocalUserAccountModel Create()
        {
            return new LocalUserAccountModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='UserAccountModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='UserAccountModel' /> instances.
        /// </returns>
        public IEnumerable<LocalUserAccountModel> FetchAll()
        {
            IEnumerable<UserAccountRecord> recordCollection = this.Provider.DataProvider.Security.UserAccount.FetchAll();
            foreach (UserAccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='UserAccountModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='UserAccountModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserAccountModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalUserAccountModel FetchById(Int32 id)
        {
            UserAccountRecord record = this.Provider.DataProvider.Security.UserAccount.FetchById(id);
            if (record == null)
                return null;
            return new LocalUserAccountModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='UserAccount/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Security.UserAccount.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='UserAccountModel' /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref='UserAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserAccountModel' /> instances that match the specified <paramref name='principalId' />.
        /// </returns>
        public IEnumerable<LocalUserAccountModel> FetchAllByPrincipalId(Int32 principalId)
        {
            IEnumerable<UserAccountRecord> recordCollection = this.Provider.DataProvider.Security.UserAccount.FetchAllByPrincipalId(principalId);
            foreach (UserAccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='UserAccountModel' /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='UserAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserAccountModel' /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<LocalUserAccountModel> FetchAllByPersonId(String personId)
        {
            IEnumerable<UserAccountRecord> recordCollection = this.Provider.DataProvider.Security.UserAccount.FetchAllByPersonId(personId);
            foreach (UserAccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='UserAccountModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='UserAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserAccountModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalUserAccountModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<UserAccountRecord> recordCollection = this.Provider.DataProvider.Security.UserAccount.FetchAllBySelcoId(sellingCompanyId);
            foreach (UserAccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='UserAccountModel' /> instances.
        /// </summary>
        /// <param name="reportIdId">
        ///     The value which identifies the <see cref='UserAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserAccountModel' /> instances that match the specified <paramref name='reportIdId' />.
        /// </returns>
        public IEnumerable<LocalUserAccountModel> FetchAllByReportIdId(String reportIdId)
        {
            IEnumerable<UserAccountRecord> recordCollection = this.Provider.DataProvider.Security.UserAccount.FetchAllByRepId(reportIdId);
            foreach (UserAccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserAccountModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <param name="username">
        ///     The unique username which distinctly identifies the <see cref="!:UserAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instance that matches the specified <paramref name="username" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.IUserAccountModel IUserAccountFactory.FetchByUsername(System.String username)
        {
            return this.FetchByUsername(username);
        }

        /// <summary>
        ///     Gets the reporting URL.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.String" /> containing a URL.
        /// </returns>
        System.String IUserAccountFactory.ReportingURL(System.String portalPage)
        {
            return this.ReportingURL(portalPage);
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
        System.Boolean IUserAccountFactory.CheckPoolBUserAllowed(System.String userAccountId, System.String licenseType, System.String status)
        {
            return this.CheckPoolBUserAllowed(userAccountId, licenseType, status);
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
        System.Boolean IUserAccountFactory.CheckIsUserAllowed(System.Boolean isUserAllowed, System.String userAccountId)
        {
            return this.CheckIsUserAllowed(isUserAllowed, userAccountId);
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
        System.Boolean IUserAccountFactory.CheckIfUsernameExist(System.String username, System.String userId)
        {
            return this.CheckIfUsernameExist(username, userId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserAccountModel" /> instance.
        /// </returns>
        Consensus.Security.IUserAccountModel IUserAccountFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserAccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserAccountModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserAccountModel> IUserAccountFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Security.IUserAccountModel IUserAccountFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IUserAccountFactory.GetTableName()
        {
            return this.GetTableName();
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
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserAccountModel> IUserAccountFactory.FetchAllByPrincipalId(System.Int32 principalId)
        {
            return this.FetchAllByPrincipalId(principalId);
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
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserAccountModel> IUserAccountFactory.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
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
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserAccountModel> IUserAccountFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
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
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserAccountModel> IUserAccountFactory.FetchAllByReportIdId(System.String reportIdId)
        {
            return this.FetchAllByReportIdId(reportIdId);
        }

        #endregion
    }
}
