using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AddressModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAddressFactory : LocalFactory<LocalAddressModel, AddressRecord, String>, IAddressFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='AddressModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='AddressModel' /> instance.
        /// </returns>
        public LocalAddressModel Create()
        {
            return new LocalAddressModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='AddressModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='AddressModel' /> instances.
        /// </returns>
        public IEnumerable<LocalAddressModel> FetchAll()
        {
            IEnumerable<AddressRecord> recordCollection = this.Provider.DataProvider.Contact.Address.FetchAll();
            foreach (AddressRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAddressModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='AddressModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='AddressModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AddressModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalAddressModel FetchById(String id)
        {
            AddressRecord record = this.Provider.DataProvider.Contact.Address.FetchById(id);
            if (record == null)
                return null;
            return new LocalAddressModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Address/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Address.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:AddressModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AddressModel" /> instance.
        /// </returns>
        Consensus.Contact.IAddressModel IAddressFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AddressModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AddressModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAddressModel> IAddressFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AddressModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AddressModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AddressModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IAddressModel IAddressFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IAddressFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
