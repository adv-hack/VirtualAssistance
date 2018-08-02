using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BatchModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBatchFactory : IFactory<IBatchModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:BatchModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BatchModel" /> instance.
        /// </returns>
        Consensus.Other.IBatchModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BatchModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BatchModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:BatchModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BatchModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IBatchModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BatchModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:BatchModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchModel> FetchAllByBatchEcIdId(System.Nullable<System.Int32> batchEcIdId);

        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchModel> FetchAllByBatchDiIdId(System.Nullable<System.Int32> batchDiIdId);
    }
}
