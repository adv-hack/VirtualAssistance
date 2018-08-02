using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BatchXrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBatchXrefFactory : IFactory<IBatchXrefModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:BatchXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BatchXrefModel" /> instance.
        /// </returns>
        Consensus.Other.IBatchXrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BatchXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BatchXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchXrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:BatchXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BatchXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IBatchXrefModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BatchXrefModel" /> instances.
        /// </summary>
        /// <param name="batchId">
        ///     The value which identifies the <see cref="!:BatchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BatchXrefModel" /> instances that match the specified <paramref name="batchId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IBatchXrefModel> FetchAllByBatchId(System.String batchId);
    }
}
