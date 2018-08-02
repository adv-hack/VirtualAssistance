using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SearchColumnModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISearchColumnFactory : IFactory<ISearchColumnModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SearchColumnModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchColumnModel" /> instance.
        /// </returns>
        Consensus.Search.ISearchColumnModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchColumnModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchColumnModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.ISearchColumnModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchColumnModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchColumnModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchColumnModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Search.ISearchColumnModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SearchColumnModel" /> instances.
        /// </summary>
        /// <param name="searchTypeId">
        ///     The value which identifies the <see cref="!:SearchColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchColumnModel" /> instances that match the specified <paramref name="searchTypeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.ISearchColumnModel> FetchAllBySearchTypeId(System.Int32 searchTypeId);
    }
}
