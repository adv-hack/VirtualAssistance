using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LicenseRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILicenseRepository : IRepository<LicenseRecord, Guid>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Security.LicenseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="owner">
        ///     The value which identifies the <see cref="!:LicenseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.LicenseRecord" /> instances that match the specified <paramref name="owner" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.LicenseRecord> FetchAllByOwner(System.String owner);

        #endregion
    }
}
