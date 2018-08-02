using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="RoleModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalRoleFactory : LocalFactory<LocalRoleModel, PersonRoleRecord, String>, IRoleFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='RoleModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='RoleModel' /> instance.
        /// </returns>
        public LocalRoleModel Create()
        {
            return new LocalRoleModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='RoleModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='RoleModel' /> instances.
        /// </returns>
        public IEnumerable<LocalRoleModel> FetchAll()
        {
            IEnumerable<PersonRoleRecord> recordCollection = this.Provider.DataProvider.Contact.Role.FetchAll();
            foreach (PersonRoleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalRoleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='RoleModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='RoleModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='RoleModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalRoleModel FetchById(String id)
        {
            PersonRoleRecord record = this.Provider.DataProvider.Contact.Role.FetchById(id);
            if (record == null)
                return null;
            return new LocalRoleModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Role/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Role.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='RoleModel' /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='RoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='RoleModel' /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<LocalRoleModel> FetchAllByPersonId(String personId)
        {
            IEnumerable<PersonRoleRecord> recordCollection = this.Provider.DataProvider.Contact.Role.FetchAllByPersonId(personId);
            foreach (PersonRoleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalRoleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='RoleModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='RoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='RoleModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalRoleModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<PersonRoleRecord> recordCollection = this.Provider.DataProvider.Contact.Role.FetchAllByOrgId(organisationId);
            foreach (PersonRoleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalRoleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='RoleModel' /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref='RoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='RoleModel' /> instances that match the specified <paramref name='addressId' />.
        /// </returns>
        public IEnumerable<LocalRoleModel> FetchAllByAddressId(String addressId)
        {
            IEnumerable<PersonRoleRecord> recordCollection = this.Provider.DataProvider.Contact.Role.FetchAllByAddId(addressId);
            foreach (PersonRoleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalRoleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='RoleModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='RoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='RoleModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalRoleModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<PersonRoleRecord> recordCollection = this.Provider.DataProvider.Contact.Role.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (PersonRoleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalRoleModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:RoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:RoleModel" /> instance.
        /// </returns>
        Consensus.Contact.IRoleModel IRoleFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:RoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:RoleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IRoleModel> IRoleFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:RoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:RoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IRoleModel IRoleFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IRoleFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IRoleModel> IRoleFactory.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IRoleModel> IRoleFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IRoleModel> IRoleFactory.FetchAllByAddressId(System.String addressId)
        {
            return this.FetchAllByAddressId(addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IRoleModel> IRoleFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        #endregion
    }
}
