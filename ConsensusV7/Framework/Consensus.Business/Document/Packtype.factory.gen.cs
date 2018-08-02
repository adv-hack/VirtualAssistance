using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PacktypeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPacktypeFactory : IFactory<IPacktypeModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PacktypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PacktypeModel" /> instance.
        /// </returns>
        Consensus.Document.IPacktypeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PacktypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PacktypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPacktypeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PacktypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PacktypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PacktypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IPacktypeModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
