using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SearchParameterModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISearchParameterFactory : IFactory<ISearchParameterModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SearchParameterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchParameterModel" /> instance.
        /// </returns>
        Consensus.Search.ISearchParameterModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchParameterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchParameterModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.ISearchParameterModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchParameterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchParameterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchParameterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Search.ISearchParameterModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SearchParameterModel" /> instances.
        /// </summary>
        /// <param name="searchTypeId">
        ///     The value which identifies the <see cref="!:SearchParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchParameterModel" /> instances that match the specified <paramref name="searchTypeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.ISearchParameterModel> FetchAllBySearchTypeId(System.Int32 searchTypeId);
    }
}
