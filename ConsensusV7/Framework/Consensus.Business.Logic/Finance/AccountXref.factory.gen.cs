using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AccountXrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAccountXrefFactory : LocalFactory<LocalAccountXrefModel, AccountXrefRecord, String>, IAccountXrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='AccountXrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='AccountXrefModel' /> instance.
        /// </returns>
        public LocalAccountXrefModel Create()
        {
            return new LocalAccountXrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='AccountXrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='AccountXrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalAccountXrefModel> FetchAll()
        {
            IEnumerable<AccountXrefRecord> recordCollection = this.Provider.DataProvider.Finance.AccountXref.FetchAll();
            foreach (AccountXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='AccountXrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='AccountXrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountXrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalAccountXrefModel FetchById(String id)
        {
            AccountXrefRecord record = this.Provider.DataProvider.Finance.AccountXref.FetchById(id);
            if (record == null)
                return null;
            return new LocalAccountXrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='AccountXref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.AccountXref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AccountXrefModel' /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref='AccountXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountXrefModel' /> instances that match the specified <paramref name='accountId' />.
        /// </returns>
        public IEnumerable<LocalAccountXrefModel> FetchAllByAccountId(String accountId)
        {
            IEnumerable<AccountXrefRecord> recordCollection = this.Provider.DataProvider.Finance.AccountXref.FetchAllByAccId(accountId);
            foreach (AccountXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AccountXrefModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='AccountXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountXrefModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalAccountXrefModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<AccountXrefRecord> recordCollection = this.Provider.DataProvider.Finance.AccountXref.FetchAllByOrgId(organisationId);
            foreach (AccountXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AccountXrefModel' /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref='AccountXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountXrefModel' /> instances that match the specified <paramref name='addressId' />.
        /// </returns>
        public IEnumerable<LocalAccountXrefModel> FetchAllByAddressId(String addressId)
        {
            IEnumerable<AccountXrefRecord> recordCollection = this.Provider.DataProvider.Finance.AccountXref.FetchAllByAddId(addressId);
            foreach (AccountXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AccountXrefModel' /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref='AccountXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountXrefModel' /> instances that match the specified <paramref name='roleId' />.
        /// </returns>
        public IEnumerable<LocalAccountXrefModel> FetchAllByRoleId(String roleId)
        {
            IEnumerable<AccountXrefRecord> recordCollection = this.Provider.DataProvider.Finance.AccountXref.FetchAllByProleId(roleId);
            foreach (AccountXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountXrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

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
        System.Boolean IAccountXrefFactory.CheckIfSameContactAlreadyExists(System.String accountId, System.String roleId, System.String accounteexrefid)
        {
            return this.CheckIfSameContactAlreadyExists(accountId, roleId, accounteexrefid);
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
        System.Boolean IAccountXrefFactory.CheckIfSameOrganisationAlreadyExists(System.String accountId, System.String personId, System.String orgId, System.String accounteexrefid)
        {
            return this.CheckIfSameOrganisationAlreadyExists(accountId, personId, orgId, accounteexrefid);
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
        System.Boolean IAccountXrefFactory.CheckIfContactOrOrganizationExists(System.String orgId, System.String personid)
        {
            return this.CheckIfContactOrOrganizationExists(orgId, personid);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AccountXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AccountXrefModel" /> instance.
        /// </returns>
        Consensus.Finance.IAccountXrefModel IAccountXrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AccountXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AccountXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountXrefModel> IAccountXrefFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Finance.IAccountXrefModel IAccountXrefFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IAccountXrefFactory.GetTableName()
        {
            return this.GetTableName();
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
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountXrefModel> IAccountXrefFactory.FetchAllByAccountId(System.String accountId)
        {
            return this.FetchAllByAccountId(accountId);
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
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountXrefModel> IAccountXrefFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
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
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountXrefModel> IAccountXrefFactory.FetchAllByAddressId(System.String addressId)
        {
            return this.FetchAllByAddressId(addressId);
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
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountXrefModel> IAccountXrefFactory.FetchAllByRoleId(System.String roleId)
        {
            return this.FetchAllByRoleId(roleId);
        }

        #endregion
    }
}
