using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CommunicationsXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommunications_XrefRepository : IRepository<CommunicationsXrefRecord, Int64>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.CommunicationsXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="commId">
        ///     The value which identifies the <see cref="!:Communications_XrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.CommunicationsXrefRecord" /> instances that match the specified <paramref name="commId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.CommunicationsXrefRecord> FetchAllByCommId(System.Int64 commId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.CommunicationsXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="recordId">
        ///     The value which identifies the <see cref="!:Communications_XrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.CommunicationsXrefRecord" /> instances that match the specified <paramref name="recordId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.CommunicationsXrefRecord> FetchAllByRecordId(System.String recordId);

        #endregion
    }
}
