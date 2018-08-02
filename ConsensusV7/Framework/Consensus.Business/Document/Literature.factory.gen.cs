using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LiteratureModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILiteratureFactory : IFactory<ILiteratureModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:LiteratureModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LiteratureModel" /> instance.
        /// </returns>
        Consensus.Document.ILiteratureModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LiteratureModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LiteratureModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILiteratureModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:LiteratureModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LiteratureModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LiteratureModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.ILiteratureModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LiteratureModel" /> instances.
        /// </summary>
        /// <param name="ltIdId">
        ///     The value which identifies the <see cref="!:LiteratureModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LiteratureModel" /> instances that match the specified <paramref name="ltIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILiteratureModel> FetchAllByLtIdId(System.String ltIdId);
    }
}
