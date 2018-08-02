using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AccountModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAccountFactory : LocalFactory<LocalAccountModel, AccountRecord, String>, IAccountFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='AccountModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='AccountModel' /> instance.
        /// </returns>
        public LocalAccountModel Create()
        {
            return new LocalAccountModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='AccountModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='AccountModel' /> instances.
        /// </returns>
        public IEnumerable<LocalAccountModel> FetchAll()
        {
            IEnumerable<AccountRecord> recordCollection = this.Provider.DataProvider.Finance.Account.FetchAll();
            foreach (AccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='AccountModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='AccountModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalAccountModel FetchById(String id)
        {
            AccountRecord record = this.Provider.DataProvider.Finance.Account.FetchById(id);
            if (record == null)
                return null;
            return new LocalAccountModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Account/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.Account.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AccountModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='AccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalAccountModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<AccountRecord> recordCollection = this.Provider.DataProvider.Finance.Account.FetchAllByOrgId(organisationId);
            foreach (AccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AccountModel' /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref='AccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountModel' /> instances that match the specified <paramref name='roleId' />.
        /// </returns>
        public IEnumerable<LocalAccountModel> FetchAllByRoleId(String roleId)
        {
            IEnumerable<AccountRecord> recordCollection = this.Provider.DataProvider.Finance.Account.FetchAllByProleId(roleId);
            foreach (AccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AccountModel' /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref='AccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountModel' /> instances that match the specified <paramref name='addressId' />.
        /// </returns>
        public IEnumerable<LocalAccountModel> FetchAllByAddressId(String addressId)
        {
            IEnumerable<AccountRecord> recordCollection = this.Provider.DataProvider.Finance.Account.FetchAllByAddId(addressId);
            foreach (AccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AccountModel' /> instances.
        /// </summary>
        /// <param name="sellingComanpyId">
        ///     The value which identifies the <see cref='AccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountModel' /> instances that match the specified <paramref name='sellingComanpyId' />.
        /// </returns>
        public IEnumerable<LocalAccountModel> FetchAllBySellingComanpyId(String sellingComanpyId)
        {
            IEnumerable<AccountRecord> recordCollection = this.Provider.DataProvider.Finance.Account.FetchAllBySelcoSpId(sellingComanpyId);
            foreach (AccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AccountModel' /> instances.
        /// </summary>
        /// <param name="invPackIdId">
        ///     The value which identifies the <see cref='AccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountModel' /> instances that match the specified <paramref name='invPackIdId' />.
        /// </returns>
        public IEnumerable<LocalAccountModel> FetchAllByInvPackIdId(String invPackIdId)
        {
            IEnumerable<AccountRecord> recordCollection = this.Provider.DataProvider.Finance.Account.FetchAllByInvPackId(invPackIdId);
            foreach (AccountRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAccountModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instance that matches the specified <paramref name="roleId" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> IAccountFactory.FetchByXrefRoleIdandOrgId(System.String roleId, System.String orgId, System.String spId)
        {
            return this.FetchByXrefRoleIdandOrgId(roleId, orgId, spId);
        }

        /// <summary>
        ///     Checks if ARNumber exist.
        /// </summary>
        /// <param name="arNumber">
        ///     ARNumber of Account.
        /// </param>
        /// <param name="sellingCompId">
        ///     Id of Selling Company.
        /// </param>
        /// <param name="accountId">
        ///     Id of the Account.
        /// </param>
        /// <returns>
        ///     Whether ARNumber exist in database.
        /// </returns>
        System.Boolean IAccountFactory.CheckIfARNumberExist(System.String arNumber, System.String sellingCompId, System.String accountId)
        {
            return this.CheckIfARNumberExist(arNumber, sellingCompId, accountId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AccountModel" /> instance.
        /// </returns>
        Consensus.Finance.IAccountModel IAccountFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AccountModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> IAccountFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IAccountModel IAccountFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IAccountFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> IAccountFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> IAccountFactory.FetchAllByRoleId(System.String roleId)
        {
            return this.FetchAllByRoleId(roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> IAccountFactory.FetchAllByAddressId(System.String addressId)
        {
            return this.FetchAllByAddressId(addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="sellingComanpyId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="sellingComanpyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> IAccountFactory.FetchAllBySellingComanpyId(System.String sellingComanpyId)
        {
            return this.FetchAllBySellingComanpyId(sellingComanpyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="invPackIdId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="invPackIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> IAccountFactory.FetchAllByInvPackIdId(System.String invPackIdId)
        {
            return this.FetchAllByInvPackIdId(invPackIdId);
        }

        #endregion
    }
}
