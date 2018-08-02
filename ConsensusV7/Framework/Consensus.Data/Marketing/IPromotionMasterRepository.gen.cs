using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PromotionMasterRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPromotionMasterRepository : IRepository<PromotionMasterRecord, String>
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

        void Create(Consensus.Marketing.PromotionMasterRecord record);

        void Modify(Consensus.Marketing.PromotionMasterRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cmpId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances that match the specified <paramref name="cmpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionMasterRecord> FetchAllByCmpId(System.String cmpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionMasterRecord> FetchAllByCourseId(System.String courseId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionMasterRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appProleId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances that match the specified <paramref name="appProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionMasterRecord> FetchAllByAppProleId(System.String appProleId);

        #endregion
    }
}
