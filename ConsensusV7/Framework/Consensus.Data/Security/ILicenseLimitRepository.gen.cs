using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LicenseLimitRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILicenseLimitRepository : IRepository<LicenseLimitRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Security.LicenseLimitRecord" /> instances from the data store.
        /// </summary>
        /// <param name="licId">
        ///     The value which identifies the <see cref="!:LicenseLimitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.LicenseLimitRecord" /> instances that match the specified <paramref name="licId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.LicenseLimitRecord> FetchAllByLicId(System.Guid licId);

        #endregion
    }
}
