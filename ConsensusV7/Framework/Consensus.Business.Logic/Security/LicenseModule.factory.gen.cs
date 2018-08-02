using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LicenseModuleModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLicenseModuleFactory : LocalFactory<LocalLicenseModuleModel, LicenseModuleRecord, Int32>, ILicenseModuleFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='LicenseModuleModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='LicenseModuleModel' /> instance.
        /// </returns>
        public LocalLicenseModuleModel Create()
        {
            return new LocalLicenseModuleModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='LicenseModuleModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='LicenseModuleModel' /> instances.
        /// </returns>
        public IEnumerable<LocalLicenseModuleModel> FetchAll()
        {
            IEnumerable<LicenseModuleRecord> recordCollection = this.Provider.DataProvider.Security.LicenseModule.FetchAll();
            foreach (LicenseModuleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLicenseModuleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='LicenseModuleModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='LicenseModuleModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LicenseModuleModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalLicenseModuleModel FetchById(Int32 id)
        {
            LicenseModuleRecord record = this.Provider.DataProvider.Security.LicenseModule.FetchById(id);
            if (record == null)
                return null;
            return new LocalLicenseModuleModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='LicenseModule/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Security.LicenseModule.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseModuleModel" /> instances.
        /// </summary>
        /// <param name="licenseId">
        ///     The value which identifies the <see cref="!:LicenseModuleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModuleModel" /> instances that match the specified <paramref name="licenseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseModuleModel> ILicenseModuleFactory.FetchAllByLicenseId(System.Guid licenseId)
        {
            return this.FetchAllByLicenseId(licenseId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LicenseModuleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseModuleModel" /> instance.
        /// </returns>
        Consensus.Security.ILicenseModuleModel ILicenseModuleFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseModuleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseModuleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseModuleModel> ILicenseModuleFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseModuleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseModuleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModuleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.ILicenseModuleModel ILicenseModuleFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ILicenseModuleFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
