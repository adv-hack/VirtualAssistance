using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PortaluserroleRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalUserRoleRepository : IRepository<PortaluserroleRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Portal.PortaluserroleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="puId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Portal.PortaluserroleRecord" /> instances that match the specified <paramref name="puId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.PortaluserroleRecord> FetchAllByPuId(System.Int32 puId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Portal.PortaluserroleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Portal.PortaluserroleRecord" /> instances that match the specified <paramref name="prId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.PortaluserroleRecord> FetchAllByPrId(System.Int32 prId);

        #endregion
    }
}
