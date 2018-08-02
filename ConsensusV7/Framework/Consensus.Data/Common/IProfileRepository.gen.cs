using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProfileRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileRepository : IRepository<ProfileRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trainId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="trainId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> FetchAllByTrainId(System.String trainId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="volId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="volId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> FetchAllByVolId(System.String volId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> FetchAllByOrgId(System.String orgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> FetchAllByProdId(System.String prodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:ProfileModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.ProfileRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ProfileRecord> FetchAllByCourseId(System.String courseId);

        #endregion
    }
}
