using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="GiftaidRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IGiftaidRepository : IRepository<GiftaidRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.GiftaidRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref="!:GiftaidModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.GiftaidRecord" /> instances that match the specified <paramref name="pnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.GiftaidRecord> FetchAllByPnId(System.String pnId);

        #endregion
    }
}
