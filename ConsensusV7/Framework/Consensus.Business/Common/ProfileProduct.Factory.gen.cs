using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileProductModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileProductFactory : IFactory<IProfileProductModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProfileProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileProductModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileProductModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileProductModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileProductModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileProductModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ProfileProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileProductModel> FetchAllByProductId(System.String productId);
    }
}
