using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenObjectDisplayRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenObjectDisplayRepository : IRepository<ScreenObjectDisplayRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenObjectDisplayRecord" /> instances from the data store.
        /// </summary>
        /// <param name="objId">
        ///     The value which identifies the <see cref="!:ScreenObjectDisplayModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenObjectDisplayRecord" /> instances that match the specified <paramref name="objId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenObjectDisplayRecord> FetchAllByObjId(System.Int32 objId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenObjectDisplayRecord" /> instances from the data store.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:ScreenObjectDisplayModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenObjectDisplayRecord" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenObjectDisplayRecord> FetchAllByPrincipalId(System.Int32 principalId);

        #endregion
    }
}
