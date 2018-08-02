using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="OrganisationAddressModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOrganisationAddressFactory : LocalFactory<LocalOrganisationAddressModel, AddressXrefRecord, String>, IOrganisationAddressFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='OrganisationAddressModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='OrganisationAddressModel' /> instance.
        /// </returns>
        public LocalOrganisationAddressModel Create()
        {
            return new LocalOrganisationAddressModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='OrganisationAddressModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='OrganisationAddressModel' /> instances.
        /// </returns>
        public IEnumerable<LocalOrganisationAddressModel> FetchAll()
        {
            IEnumerable<AddressXrefRecord> recordCollection = this.Provider.DataProvider.Contact.OrganisationAddress.FetchAll();
            foreach (AddressXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOrganisationAddressModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='OrganisationAddressModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='OrganisationAddressModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OrganisationAddressModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalOrganisationAddressModel FetchById(String id)
        {
            AddressXrefRecord record = this.Provider.DataProvider.Contact.OrganisationAddress.FetchById(id);
            if (record == null)
                return null;
            return new LocalOrganisationAddressModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='OrganisationAddress/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.OrganisationAddress.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OrganisationAddressModel' /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref='OrganisationAddressModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OrganisationAddressModel' /> instances that match the specified <paramref name='addressId' />.
        /// </returns>
        public IEnumerable<LocalOrganisationAddressModel> FetchAllByAddressId(String addressId)
        {
            IEnumerable<AddressXrefRecord> recordCollection = this.Provider.DataProvider.Contact.OrganisationAddress.FetchAllByAddId(addressId);
            foreach (AddressXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOrganisationAddressModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OrganisationAddressModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='OrganisationAddressModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OrganisationAddressModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalOrganisationAddressModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<AddressXrefRecord> recordCollection = this.Provider.DataProvider.Contact.OrganisationAddress.FetchAllByOrgId(organisationId);
            foreach (AddressXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOrganisationAddressModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:OrganisationAddressModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OrganisationAddressModel" /> instance.
        /// </returns>
        Consensus.Contact.IOrganisationAddressModel IOrganisationAddressFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OrganisationAddressModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OrganisationAddressModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IOrganisationAddressModel> IOrganisationAddressFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OrganisationAddressModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OrganisationAddressModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationAddressModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IOrganisationAddressModel IOrganisationAddressFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IOrganisationAddressFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationAddressModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:OrganisationAddressModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationAddressModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IOrganisationAddressModel> IOrganisationAddressFactory.FetchAllByAddressId(System.String addressId)
        {
            return this.FetchAllByAddressId(addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationAddressModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:OrganisationAddressModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationAddressModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IOrganisationAddressModel> IOrganisationAddressFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        #endregion
    }
}
