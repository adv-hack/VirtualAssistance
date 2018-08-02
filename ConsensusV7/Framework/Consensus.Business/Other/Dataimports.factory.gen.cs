using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="DataimportsModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IDataimportsFactory : IFactory<IDataimportsModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:DataimportsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DataimportsModel" /> instance.
        /// </returns>
        Consensus.Other.IDataimportsModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DataimportsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DataimportsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IDataimportsModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:DataimportsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DataimportsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DataimportsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IDataimportsModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
