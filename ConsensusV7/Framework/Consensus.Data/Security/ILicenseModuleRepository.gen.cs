using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LicenseModuleRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILicenseModuleRepository : IRepository<LicenseModuleRecord, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.LicenseModuleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="licId">
        ///     The value which identifies the <see cref="!:LicenseModuleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.LicenseModuleRecord" /> instances that match the specified <paramref name="licId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.LicenseModuleRecord> FetchAllByLicId(System.Guid licId);

        #endregion
    }
}
