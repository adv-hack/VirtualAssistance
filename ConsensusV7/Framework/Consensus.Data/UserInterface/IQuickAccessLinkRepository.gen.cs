using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="QuickaccesslinkRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IQuickAccessLinkRepository : IRepository<QuickaccesslinkRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.QuickaccesslinkRecord" /> instances from the data store.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:QuickAccessLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.QuickaccesslinkRecord" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.QuickaccesslinkRecord> FetchAllByUserId(System.Int32 userId);

        #endregion
    }
}
