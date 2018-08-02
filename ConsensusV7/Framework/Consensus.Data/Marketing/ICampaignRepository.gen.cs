using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CampaignRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICampaignRepository : IRepository<CampaignRecord, String>
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

        void Create(Consensus.Marketing.CampaignRecord record);

        void Modify(Consensus.Marketing.CampaignRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="projId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances that match the specified <paramref name="projId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.CampaignRecord> FetchAllByProjId(System.String projId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.CampaignRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.CampaignRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appProleId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances that match the specified <paramref name="appProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.CampaignRecord> FetchAllByAppProleId(System.String appProleId);

        #endregion
    }
}
