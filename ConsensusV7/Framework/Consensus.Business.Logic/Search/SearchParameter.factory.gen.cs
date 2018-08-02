using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SearchParameterModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSearchParameterFactory : LocalFactory<LocalSearchParameterModel, SystemSearchesParameterFieldsRecord, Int32>, ISearchParameterFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SearchParameterModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SearchParameterModel' /> instance.
        /// </returns>
        public LocalSearchParameterModel Create()
        {
            return new LocalSearchParameterModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SearchParameterModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SearchParameterModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSearchParameterModel> FetchAll()
        {
            IEnumerable<SystemSearchesParameterFieldsRecord> recordCollection = this.Provider.DataProvider.Search.SearchParameter.FetchAll();
            foreach (SystemSearchesParameterFieldsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSearchParameterModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SearchParameterModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SearchParameterModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SearchParameterModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSearchParameterModel FetchById(Int32 id)
        {
            SystemSearchesParameterFieldsRecord record = this.Provider.DataProvider.Search.SearchParameter.FetchById(id);
            if (record == null)
                return null;
            return new LocalSearchParameterModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SearchParameter/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Search.SearchParameter.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SearchParameterModel' /> instances.
        /// </summary>
        /// <param name="searchTypeId">
        ///     The value which identifies the <see cref='SearchParameterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SearchParameterModel' /> instances that match the specified <paramref name='searchTypeId' />.
        /// </returns>
        public IEnumerable<LocalSearchParameterModel> FetchAllBySearchTypeId(Int32 searchTypeId)
        {
            IEnumerable<SystemSearchesParameterFieldsRecord> recordCollection = this.Provider.DataProvider.Search.SearchParameter.FetchAllBySyssId(searchTypeId);
            foreach (SystemSearchesParameterFieldsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSearchParameterModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SearchParameterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchParameterModel" /> instance.
        /// </returns>
        Consensus.Search.ISearchParameterModel ISearchParameterFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchParameterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchParameterModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.ISearchParameterModel> ISearchParameterFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchParameterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchParameterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchParameterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Search.ISearchParameterModel ISearchParameterFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ISearchParameterFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SearchParameterModel" /> instances.
        /// </summary>
        /// <param name="searchTypeId">
        ///     The value which identifies the <see cref="!:SearchParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchParameterModel" /> instances that match the specified <paramref name="searchTypeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.ISearchParameterModel> ISearchParameterFactory.FetchAllBySearchTypeId(System.Int32 searchTypeId)
        {
            return this.FetchAllBySearchTypeId(searchTypeId);
        }

        #endregion
    }
}
