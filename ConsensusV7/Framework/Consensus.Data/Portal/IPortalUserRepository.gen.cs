using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PortalUserRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalUserRepository : IRepository<PortalUserRecord, Int32>
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

        void Create(Consensus.Portal.PortalUserRecord record);

        void Modify(Consensus.Portal.PortalUserRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Portal.PortalUserRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Portal.PortalUserRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.PortalUserRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Portal.PortalUserRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Portal.PortalUserRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.PortalUserRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        #endregion
    }
}
