using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProductEventModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProductEventFactory : IFactory<IProductEventModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProductEventModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductEventModel" /> instance.
        /// </returns>
        Consensus.Learning.IProductEventModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductEventModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductEventModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductEventModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductEventModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductEventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductEventModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProductEventModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductEventModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ProductEventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductEventModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductEventModel> FetchAllByProductId(System.String productId);
    }
}
