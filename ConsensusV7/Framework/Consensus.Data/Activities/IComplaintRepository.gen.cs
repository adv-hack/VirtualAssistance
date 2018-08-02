using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ComplaintRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IComplaintRepository : IRepository<ComplaintRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fromProleId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="fromProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> FetchAllByFromProleId(System.String fromProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="reProleId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="reProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> FetchAllByReProleId(System.String reProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mgrProleId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="mgrProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> FetchAllByMgrProleId(System.String mgrProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="medtrProleId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="medtrProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> FetchAllByMedtrProleId(System.String medtrProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="pmId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> FetchAllByPmId(System.String pmId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="detailsId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="detailsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> FetchAllByDetailsId(System.String detailsId);

        #endregion
    }
}
