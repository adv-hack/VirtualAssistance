using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ActLinkXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IActLinkXrefRepository : IRepository<ActLinkXrefRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActLinkXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref="!:ActLinkXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActLinkXrefRecord" /> instances that match the specified <paramref name="actId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActLinkXrefRecord> FetchAllByActId(System.String actId);

        #endregion
    }
}
