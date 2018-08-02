using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SearchTypeModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSearchTypeFactory : LocalFactory<LocalSearchTypeModel, SystemSearchesRecord, Int32>, ISearchTypeFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SearchTypeModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SearchTypeModel' /> instance.
        /// </returns>
        public LocalSearchTypeModel Create()
        {
            return new LocalSearchTypeModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SearchTypeModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SearchTypeModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSearchTypeModel> FetchAll()
        {
            IEnumerable<SystemSearchesRecord> recordCollection = this.Provider.DataProvider.Search.SearchType.FetchAll();
            foreach (SystemSearchesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSearchTypeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SearchTypeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SearchTypeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SearchTypeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSearchTypeModel FetchById(Int32 id)
        {
            SystemSearchesRecord record = this.Provider.DataProvider.Search.SearchType.FetchById(id);
            if (record == null)
                return null;
            return new LocalSearchTypeModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SearchType/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Search.SearchType.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SearchTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchTypeModel" /> instance.
        /// </returns>
        Consensus.Search.ISearchTypeModel ISearchTypeFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.ISearchTypeModel> ISearchTypeFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Search.ISearchTypeModel ISearchTypeFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ISearchTypeFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
