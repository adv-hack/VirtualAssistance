using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SysConfigRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISysConfigRepository : IRepository<SysConfigRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Common.SysConfigRecord" /> instances from the data store.
        /// </summary>
        /// <param name="spId">
        ///     The value which identifies the <see cref="!:SysConfigModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.SysConfigRecord" /> instances that match the specified <paramref name="spId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.SysConfigRecord> FetchAllBySpId(System.String spId);

        #endregion
    }
}
