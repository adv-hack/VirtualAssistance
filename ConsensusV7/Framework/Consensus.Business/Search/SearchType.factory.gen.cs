using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SearchTypeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISearchTypeFactory : IFactory<ISearchTypeModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SearchTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SearchTypeModel" /> instance.
        /// </returns>
        Consensus.Search.ISearchTypeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SearchTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SearchTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.ISearchTypeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SearchTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SearchTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SearchTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Search.ISearchTypeModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
