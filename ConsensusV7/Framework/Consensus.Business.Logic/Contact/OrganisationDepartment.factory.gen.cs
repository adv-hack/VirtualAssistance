using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="OrganisationDepartmentModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOrganisationDepartmentFactory : LocalFactory<LocalOrganisationDepartmentModel, DepartmentRecord, String>, IOrganisationDepartmentFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='OrganisationDepartmentModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='OrganisationDepartmentModel' /> instance.
        /// </returns>
        public LocalOrganisationDepartmentModel Create()
        {
            return new LocalOrganisationDepartmentModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='OrganisationDepartmentModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='OrganisationDepartmentModel' /> instances.
        /// </returns>
        public IEnumerable<LocalOrganisationDepartmentModel> FetchAll()
        {
            IEnumerable<DepartmentRecord> recordCollection = this.Provider.DataProvider.Contact.OrganisationDepartment.FetchAll();
            foreach (DepartmentRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOrganisationDepartmentModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='OrganisationDepartmentModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='OrganisationDepartmentModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OrganisationDepartmentModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalOrganisationDepartmentModel FetchById(String id)
        {
            DepartmentRecord record = this.Provider.DataProvider.Contact.OrganisationDepartment.FetchById(id);
            if (record == null)
                return null;
            return new LocalOrganisationDepartmentModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='OrganisationDepartment/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.OrganisationDepartment.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OrganisationDepartmentModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='OrganisationDepartmentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OrganisationDepartmentModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalOrganisationDepartmentModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<DepartmentRecord> recordCollection = this.Provider.DataProvider.Contact.OrganisationDepartment.FetchAllByOrgId(organisationId);
            foreach (DepartmentRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOrganisationDepartmentModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:OrganisationDepartmentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OrganisationDepartmentModel" /> instance.
        /// </returns>
        Consensus.Contact.IOrganisationDepartmentModel IOrganisationDepartmentFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OrganisationDepartmentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OrganisationDepartmentModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IOrganisationDepartmentModel> IOrganisationDepartmentFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OrganisationDepartmentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OrganisationDepartmentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationDepartmentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IOrganisationDepartmentModel IOrganisationDepartmentFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IOrganisationDepartmentFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationDepartmentModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:OrganisationDepartmentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationDepartmentModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IOrganisationDepartmentModel> IOrganisationDepartmentFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        #endregion
    }
}
