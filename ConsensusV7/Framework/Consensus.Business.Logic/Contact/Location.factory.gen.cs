using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LocationModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLocationFactory : LocalFactory<LocalLocationModel, LocationRecord, String>, ILocationFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='LocationModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='LocationModel' /> instance.
        /// </returns>
        public LocalLocationModel Create()
        {
            return new LocalLocationModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='LocationModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='LocationModel' /> instances.
        /// </returns>
        public IEnumerable<LocalLocationModel> FetchAll()
        {
            IEnumerable<LocationRecord> recordCollection = this.Provider.DataProvider.Contact.Location.FetchAll();
            foreach (LocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='LocationModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='LocationModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LocationModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalLocationModel FetchById(String id)
        {
            LocationRecord record = this.Provider.DataProvider.Contact.Location.FetchById(id);
            if (record == null)
                return null;
            return new LocalLocationModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Location/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Location.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LocationModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='LocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LocationModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalLocationModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<LocationRecord> recordCollection = this.Provider.DataProvider.Contact.Location.FetchAllByOrgId(organisationId);
            foreach (LocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LocationModel' /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref='LocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LocationModel' /> instances that match the specified <paramref name='addressId' />.
        /// </returns>
        public IEnumerable<LocalLocationModel> FetchAllByAddressId(String addressId)
        {
            IEnumerable<LocationRecord> recordCollection = this.Provider.DataProvider.Contact.Location.FetchAllByAddId(addressId);
            foreach (LocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LocationModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='LocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LocationModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalLocationModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<LocationRecord> recordCollection = this.Provider.DataProvider.Contact.Location.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (LocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LocationModel' /> instances.
        /// </summary>
        /// <param name="locationRoleId">
        ///     The value which identifies the <see cref='LocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LocationModel' /> instances that match the specified <paramref name='locationRoleId' />.
        /// </returns>
        public IEnumerable<LocalLocationModel> FetchAllByLocationRoleId(String locationRoleId)
        {
            IEnumerable<LocationRecord> recordCollection = this.Provider.DataProvider.Contact.Location.FetchAllByLocProleId(locationRoleId);
            foreach (LocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LocationModel' /> instances.
        /// </summary>
        /// <param name="linkedLocationId">
        ///     The value which identifies the <see cref='LocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LocationModel' /> instances that match the specified <paramref name='linkedLocationId' />.
        /// </returns>
        public IEnumerable<LocalLocationModel> FetchAllByLinkedLocationId(String linkedLocationId)
        {
            IEnumerable<LocationRecord> recordCollection = this.Provider.DataProvider.Contact.Location.FetchAllByLinkedLocId(linkedLocationId);
            foreach (LocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLocationModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Check if Location Reference exist or not.
        /// </summary>
        /// <param name="reference">
        ///     Location Reference.
        /// </param>
        /// <param name="locationId">
        ///     Id of Location.
        /// </param>
        /// <returns>
        ///     Whether loction exist or not.
        /// </returns>
        System.Boolean ILocationFactory.CheckIfLocationReferenceExist(System.String reference, System.String locationId)
        {
            return this.CheckIfLocationReferenceExist(reference, locationId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LocationModel" /> instance.
        /// </returns>
        Consensus.Contact.ILocationModel ILocationFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LocationModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> ILocationFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ILocationModel ILocationFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ILocationFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> ILocationFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> ILocationFactory.FetchAllByAddressId(System.String addressId)
        {
            return this.FetchAllByAddressId(addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> ILocationFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="locationRoleId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="locationRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> ILocationFactory.FetchAllByLocationRoleId(System.String locationRoleId)
        {
            return this.FetchAllByLocationRoleId(locationRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="linkedLocationId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="linkedLocationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ILocationModel> ILocationFactory.FetchAllByLinkedLocationId(System.String linkedLocationId)
        {
            return this.FetchAllByLinkedLocationId(linkedLocationId);
        }

        #endregion
    }
}
