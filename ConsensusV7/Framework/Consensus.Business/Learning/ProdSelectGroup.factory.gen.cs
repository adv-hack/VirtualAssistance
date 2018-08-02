using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProdSelectGroupModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProdSelectGroupFactory : IFactory<IProdSelectGroupModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProdSelectGroupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProdSelectGroupModel" /> instance.
        /// </returns>
        Consensus.Learning.IProdSelectGroupModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProdSelectGroupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProdSelectGroupModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProdSelectGroupModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProdSelectGroupModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProdSelectGroupModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProdSelectGroupModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProdSelectGroupModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProdSelectGroupModel" /> instances.
        /// </summary>
        /// <param name="prodIdId">
        ///     The value which identifies the <see cref="!:ProdSelectGroupModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProdSelectGroupModel" /> instances that match the specified <paramref name="prodIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProdSelectGroupModel> FetchAllByProdIdId(System.String prodIdId);
    }
}
