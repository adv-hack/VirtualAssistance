using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PackProductModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPackProductFactory : IFactory<IPackProductModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PackProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackProductModel" /> instance.
        /// </returns>
        Consensus.Document.IPackProductModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackProductModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackProductModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IPackProductModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PackProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackProductModel> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackProductModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PackProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackProductModel> FetchAllByPackId(System.String packId);
    }
}
