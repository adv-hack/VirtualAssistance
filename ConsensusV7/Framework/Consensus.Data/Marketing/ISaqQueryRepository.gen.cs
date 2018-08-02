using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SaqQueryRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqQueryRepository : IRepository<SaqQueryRecord, Int64>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances that match the specified <paramref name="pmId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryRecord> FetchAllByPmId(System.String pmId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryRecord> FetchAllByCourseId(System.String courseId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mgrProleId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances that match the specified <paramref name="mgrProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryRecord> FetchAllByMgrProleId(System.String mgrProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appByProleId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances that match the specified <paramref name="appByProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryRecord> FetchAllByAppByProleId(System.String appByProleId);

        #endregion
    }
}
