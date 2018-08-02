using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="HelpdeskRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IHelpdeskRepository : IRepository<HelpdeskRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="givenToId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="givenToId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> FetchAllByGivenToId(System.String givenToId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="detailsId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="detailsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> FetchAllByDetailsId(System.String detailsId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fixId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="fixId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> FetchAllByFixId(System.String fixId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="wipId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="wipId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> FetchAllByWipId(System.String wipId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="pmId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> FetchAllByPmId(System.String pmId);

        #endregion
    }
}
