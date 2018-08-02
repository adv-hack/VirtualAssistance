using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PromotionRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPromotionRepository : IRepository<PromotionRecord, String>
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

        void Create(Consensus.Marketing.PromotionRecord record);

        void Modify(Consensus.Marketing.PromotionRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cmpId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances that match the specified <paramref name="cmpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionRecord> FetchAllByCmpId(System.String cmpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appProleId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances that match the specified <paramref name="appProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionRecord> FetchAllByAppProleId(System.String appProleId);

        #endregion
    }
}
