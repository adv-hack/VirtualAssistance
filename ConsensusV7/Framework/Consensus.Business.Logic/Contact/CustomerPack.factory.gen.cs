using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CustomerPackModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCustomerPackFactory : LocalFactory<LocalCustomerPackModel, CustomerPackRecord, Int32>, ICustomerPackFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CustomerPackModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CustomerPackModel' /> instance.
        /// </returns>
        public LocalCustomerPackModel Create()
        {
            return new LocalCustomerPackModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CustomerPackModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CustomerPackModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCustomerPackModel> FetchAll()
        {
            IEnumerable<CustomerPackRecord> recordCollection = this.Provider.DataProvider.Contact.CustomerPack.FetchAll();
            foreach (CustomerPackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCustomerPackModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CustomerPackModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CustomerPackModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CustomerPackModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCustomerPackModel FetchById(Int32 id)
        {
            CustomerPackRecord record = this.Provider.DataProvider.Contact.CustomerPack.FetchById(id);
            if (record == null)
                return null;
            return new LocalCustomerPackModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='CustomerPack/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.CustomerPack.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CustomerPackModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='CustomerPackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CustomerPackModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalCustomerPackModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<CustomerPackRecord> recordCollection = this.Provider.DataProvider.Contact.CustomerPack.FetchAllByOrgId(organisationId);
            foreach (CustomerPackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCustomerPackModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CustomerPackModel' /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref='CustomerPackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CustomerPackModel' /> instances that match the specified <paramref name='packId' />.
        /// </returns>
        public IEnumerable<LocalCustomerPackModel> FetchAllByPackId(String packId)
        {
            IEnumerable<CustomerPackRecord> recordCollection = this.Provider.DataProvider.Contact.CustomerPack.FetchAllByPackId(packId);
            foreach (CustomerPackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCustomerPackModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:CustomerPackModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CustomerPackModel" /> instance.
        /// </returns>
        Consensus.Contact.ICustomerPackModel ICustomerPackFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CustomerPackModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CustomerPackModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICustomerPackModel> ICustomerPackFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CustomerPackModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CustomerPackModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ICustomerPackModel ICustomerPackFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ICustomerPackFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CustomerPackModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:CustomerPackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICustomerPackModel> ICustomerPackFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CustomerPackModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:CustomerPackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICustomerPackModel> ICustomerPackFactory.FetchAllByPackId(System.String packId)
        {
            return this.FetchAllByPackId(packId);
        }

        #endregion
    }
}
