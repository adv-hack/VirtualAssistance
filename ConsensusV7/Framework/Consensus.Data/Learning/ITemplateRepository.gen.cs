using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="TemplateXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITemplateRepository : IRepository<TemplateXrefRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bomId">
        ///     The value which identifies the <see cref="!:TemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances that match the specified <paramref name="bomId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.TemplateXrefRecord> FetchAllByBomId(System.String bomId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:TemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.TemplateXrefRecord> FetchAllByProdId(System.String prodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trainProleId">
        ///     The value which identifies the <see cref="!:TemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.TemplateXrefRecord" /> instances that match the specified <paramref name="trainProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.TemplateXrefRecord> FetchAllByTrainProleId(System.String trainProleId);

        #endregion
    }
}
