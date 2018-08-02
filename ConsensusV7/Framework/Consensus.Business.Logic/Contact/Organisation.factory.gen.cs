using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="OrganisationModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOrganisationFactory : LocalFactory<LocalOrganisationModel, OrganisationRecord, String>, IOrganisationFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='OrganisationModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='OrganisationModel' /> instance.
        /// </returns>
        public LocalOrganisationModel Create()
        {
            return new LocalOrganisationModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='OrganisationModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='OrganisationModel' /> instances.
        /// </returns>
        public IEnumerable<LocalOrganisationModel> FetchAll()
        {
            IEnumerable<OrganisationRecord> recordCollection = this.Provider.DataProvider.Contact.Organisation.FetchAll();
            foreach (OrganisationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOrganisationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='OrganisationModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='OrganisationModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OrganisationModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalOrganisationModel FetchById(String id)
        {
            OrganisationRecord record = this.Provider.DataProvider.Contact.Organisation.FetchById(id);
            if (record == null)
                return null;
            return new LocalOrganisationModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Organisation/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Organisation.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OrganisationModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='OrganisationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OrganisationModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalOrganisationModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<OrganisationRecord> recordCollection = this.Provider.DataProvider.Contact.Organisation.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (OrganisationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOrganisationModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:OrganisationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OrganisationModel" /> instance.
        /// </returns>
        Consensus.Contact.IOrganisationModel IOrganisationFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OrganisationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OrganisationModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IOrganisationModel> IOrganisationFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OrganisationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OrganisationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IOrganisationModel IOrganisationFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IOrganisationFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:OrganisationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IOrganisationModel> IOrganisationFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        #endregion
    }
}
