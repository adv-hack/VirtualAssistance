using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Search namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSearchRepositoryCollection : SqlServerRepositoryCollection, ISearchRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SystemSearchesRecord" /> data structure.
        /// </summary>
        private SqlServerSearchTypeRepository _searchType;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SystemSearchesGridColumnsRecord" /> data structure.
        /// </summary>
        private SqlServerSearchColumnRepository _searchColumn;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SystemSearchesParameterFieldsRecord" /> data structure.
        /// </summary>
        private SqlServerSearchParameterRepository _searchParameter;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SystemSearchesRecord" /> data structure.
        /// </summary>
        public SqlServerSearchTypeRepository SearchType
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSearchTypeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _searchType);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SystemSearchesGridColumnsRecord" /> data structure.
        /// </summary>
        public SqlServerSearchColumnRepository SearchColumn
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSearchColumnRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _searchColumn);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SystemSearchesParameterFieldsRecord" /> data structure.
        /// </summary>
        public SqlServerSearchParameterRepository SearchParameter
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSearchParameterRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _searchParameter);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Search.SystemSearchesRecord" /> data structure.
        /// </summary>
        Consensus.Search.ISearchTypeRepository ISearchRepositoryCollection.SearchType
        {
            get { return this.SearchType; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Search.SystemSearchesGridColumnsRecord" /> data structure.
        /// </summary>
        Consensus.Search.ISearchColumnRepository ISearchRepositoryCollection.SearchColumn
        {
            get { return this.SearchColumn; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Search.SystemSearchesParameterFieldsRecord" /> data structure.
        /// </summary>
        Consensus.Search.ISearchParameterRepository ISearchRepositoryCollection.SearchParameter
        {
            get { return this.SearchParameter; }
        }

        #endregion
    }
}
