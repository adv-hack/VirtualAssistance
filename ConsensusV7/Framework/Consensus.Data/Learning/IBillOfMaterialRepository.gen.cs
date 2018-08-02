using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BillOfMaterialRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBillOfMaterialRepository : IRepository<BillOfMaterialRecord, String>
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

        void Modify(Consensus.Learning.BillOfMaterialRecord record);

        void Create(Consensus.Learning.BillOfMaterialRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="parentId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances that match the specified <paramref name="parentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BillOfMaterialRecord> FetchAllByParentId(System.String parentId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syllabusId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances that match the specified <paramref name="syllabusId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BillOfMaterialRecord> FetchAllBySyllabusId(System.String syllabusId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="resourceId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances that match the specified <paramref name="resourceId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BillOfMaterialRecord> FetchAllByResourceId(System.String resourceId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.BillOfMaterialRecord> FetchAllByProductSelectGroup(System.Nullable<System.Int32> productSelectGroup);

        #endregion
    }
}
