using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SystemSearchesRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISearchTypeRepository : IRepository<SystemSearchesRecord, Int32>
    {
        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }
    }
}
