using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     The repository collection which pertains to the Search namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISearchRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Search.SystemSearchesRecord" /> data structure.
        /// </summary>
        Consensus.Search.ISearchTypeRepository SearchType
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Search.SystemSearchesGridColumnsRecord" /> data structure.
        /// </summary>
        Consensus.Search.ISearchColumnRepository SearchColumn
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Search.SystemSearchesParameterFieldsRecord" /> data structure.
        /// </summary>
        Consensus.Search.ISearchParameterRepository SearchParameter
        {
            get;
        }
    }
}
