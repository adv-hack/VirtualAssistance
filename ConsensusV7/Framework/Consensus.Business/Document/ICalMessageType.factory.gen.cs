using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ICalMessageTypeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IICalMessageTypeFactory : IFactory<IICalMessageTypeModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ICalMessageTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ICalMessageTypeModel" /> instance.
        /// </returns>
        Consensus.Document.IICalMessageTypeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ICalMessageTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ICalMessageTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IICalMessageTypeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ICalMessageTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ICalMessageTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IICalMessageTypeModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
