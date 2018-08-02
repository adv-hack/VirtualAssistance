using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LicenseModuleModel" /> object.
    /// </summary>
    public partial class LocalLicenseModuleFactory
    {
        /// <summary>
        ///     Retrieves a collection of <see cref='LicenseModuleModel' /> instances.
        /// </summary>
        /// <param name="licenseId">
        ///     The value which identifies the <see cref='LicenseModuleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LicenseModuleModel' /> instances that match the specified <paramref name='licenseId' />.
        /// </returns>
        public IEnumerable<LocalLicenseModuleModel> FetchAllByLicenseId(Guid licenseId)
        {
            IEnumerable<LicenseModuleRecord> recordCollection = this.Provider.DataProvider.Security.LicenseModule.FetchAllByLicId(licenseId);
            foreach (LicenseModuleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLicenseModuleModel(this.Provider, record);
                }
            }
        }
    }
}
