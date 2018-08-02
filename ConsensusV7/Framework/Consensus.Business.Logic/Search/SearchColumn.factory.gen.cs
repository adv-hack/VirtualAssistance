using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SearchColumnModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSearchColumnFactory : LocalFactory<LocalSearchColumnModel, SystemSearchesGridColumnsRecord, Int32>, ISearchColumnFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SearchColumnModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SearchColumnModel' /> instance.
        /// </returns>
        public LocalSearchColumnModel Create()
        {
            return new LocalSearchColumnModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SearchColumnModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SearchColumnModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSearchColumnModel> FetchAll()
        {
            IEnumerable<SystemSearchesGridColumnsRecord> recordCollection = this.Provider.DataProvider.Search.SearchColumn.FetchAll();
            foreach (SystemSearchesGridColumnsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSearchColumnModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SearchColumnModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SearchColumnModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SearchColumnModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSearchColumnModel FetchById(Int32 id)
        {
            SystemSearchesGridColumnsRecord record = this.Provider.DataProvider.Search.SearchColumn.FetchById(id);
            if (record == null)
                return null;
            return new LocalSearchColumnModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SearchColumn/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Search.SearchColumn.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SearchColumnModel' /> instances.
        /// </summary>
        /// <param name="searchTypeId">
        ///     The value which identifies the <see cref='SearchColumnModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SearchColumnModel' /> instances that match the specified <paramref name='searchTypeId' />.
        /// </returns>
        public IEnumerable<LocalSearchColumnModel> FetchAllBySearchTypeId(Int32 searchTypeId)
        {
            IEnumerable<SystemSearchesGridColumnsRecord> recordCollection = this.Provider.DataProvider.Search.SearchColumn.FetchAllBySyssId(searchTypeId);
            foreach (SystemSearchesGridColumnsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSearchColumnModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SearchColumnModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchColumnModel" /> instance.
        /// </returns>
        Consensus.Search.ISearchColumnModel ISearchColumnFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchColumnModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchColumnModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.ISearchColumnModel> ISearchColumnFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchColumnModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchColumnModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchColumnModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Search.ISearchColumnModel ISearchColumnFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ISearchColumnFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SearchColumnModel" /> instances.
        /// </summary>
        /// <param name="searchTypeId">
        ///     The value which identifies the <see cref="!:SearchColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchColumnModel" /> instances that match the specified <paramref name="searchTypeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.ISearchColumnModel> ISearchColumnFactory.FetchAllBySearchTypeId(System.Int32 searchTypeId)
        {
            return this.FetchAllBySearchTypeId(searchTypeId);
        }

        #endregion
    }
}
