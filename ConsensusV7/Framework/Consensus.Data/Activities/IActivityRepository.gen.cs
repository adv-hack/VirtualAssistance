using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ActivityRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IActivityRepository : IRepository<ActivityRecord, String>
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

        void Create(Consensus.Activities.ActivityRecord record);

        void Modify(Consensus.Activities.ActivityRecord record);

        void RemoveById(Consensus.Activities.ActivityRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="locId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> FetchAllByLocId(System.String locId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syllabusId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="syllabusId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> FetchAllBySyllabusId(System.String syllabusId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bomId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="bomId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> FetchAllByBomId(System.String bomId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="oppId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> FetchAllByOppId(System.String oppId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        #endregion
    }
}
