using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ArticlexrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IArticlexrefRepository : IRepository<ArticlexrefRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Document.ArticlexrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="relArtiId">
        ///     The value which identifies the <see cref="!:ArticlexrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.ArticlexrefRecord" /> instances that match the specified <paramref name="relArtiId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ArticlexrefRecord> FetchAllByRelArtiId(System.Int32 relArtiId);

        #endregion
    }
}
