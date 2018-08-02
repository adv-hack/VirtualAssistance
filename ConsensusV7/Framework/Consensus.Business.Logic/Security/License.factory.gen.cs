using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LicenseModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLicenseFactory : LocalFactory<LocalLicenseModel, LicenseRecord, Guid>, ILicenseFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='LicenseModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='LicenseModel' /> instance.
        /// </returns>
        public LocalLicenseModel Create()
        {
            return new LocalLicenseModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='LicenseModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='LicenseModel' /> instances.
        /// </returns>
        public IEnumerable<LocalLicenseModel> FetchAll()
        {
            IEnumerable<LicenseRecord> recordCollection = this.Provider.DataProvider.Security.License.FetchAll();
            foreach (LicenseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLicenseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='LicenseModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='LicenseModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LicenseModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalLicenseModel FetchById(Guid id)
        {
            LicenseRecord record = this.Provider.DataProvider.Security.License.FetchById(id);
            if (record == null)
                return null;
            return new LocalLicenseModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='License/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Security.License.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LicenseModel' /> instances.
        /// </summary>
        /// <param name="ownerId">
        ///     The value which identifies the <see cref='LicenseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LicenseModel' /> instances that match the specified <paramref name='ownerId' />.
        /// </returns>
        public IEnumerable<LocalLicenseModel> FetchAllByOwnerId(String ownerId)
        {
            IEnumerable<LicenseRecord> recordCollection = this.Provider.DataProvider.Security.License.FetchAllByOwner(ownerId);
            foreach (LicenseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLicenseModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the active software license.
        /// </summary>
        /// <returns>
        ///     The most applicable software license.
        /// </returns>
        Consensus.Security.ILicenseModel ILicenseFactory.GetCurrent()
        {
            return this.GetCurrent();
        }

        /// <summary>
        ///     Generates a signature for the specified license verification code.
        /// </summary>
        System.String ILicenseFactory.Sign(System.String verification)
        {
            return this.Sign(verification);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LicenseModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseModel" /> instance.
        /// </returns>
        Consensus.Security.ILicenseModel ILicenseFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseModel> ILicenseFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.ILicenseModel ILicenseFactory.FetchById(System.Guid id)
        {
            return this.FetchById(id);
        }

        System.String ILicenseFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseModel" /> instances.
        /// </summary>
        /// <param name="ownerId">
        ///     The value which identifies the <see cref="!:LicenseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModel" /> instances that match the specified <paramref name="ownerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseModel> ILicenseFactory.FetchAllByOwnerId(System.String ownerId)
        {
            return this.FetchAllByOwnerId(ownerId);
        }

        #endregion
    }
}
