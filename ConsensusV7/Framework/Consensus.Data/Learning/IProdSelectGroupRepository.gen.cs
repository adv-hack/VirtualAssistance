using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProdselectgroupsRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProdSelectGroupRepository : IRepository<ProdselectgroupsRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProdselectgroupsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="product">
        ///     The value which identifies the <see cref="!:ProdSelectGroupModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProdselectgroupsRecord" /> instances that match the specified <paramref name="product" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProdselectgroupsRecord> FetchAllByProduct(System.String product);

        #endregion
    }
}
