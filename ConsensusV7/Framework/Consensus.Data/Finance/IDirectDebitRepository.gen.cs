using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="DirectdebitRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IDirectDebitRepository : IRepository<DirectdebitRecord, String>
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

        void Create(Consensus.Finance.DirectdebitRecord record);

        void Modify(Consensus.Finance.DirectdebitRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.DirectdebitRecord" /> instances from the data store.
        /// </summary>
        /// <param name="recId">
        ///     The value which identifies the <see cref="!:DirectDebitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.DirectdebitRecord" /> instances that match the specified <paramref name="recId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.DirectdebitRecord> FetchAllByRecId(System.String recId);

        #endregion
    }
}
