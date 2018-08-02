using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqFilterFieldModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqFilterFieldFactory : IFactory<ISaqFilterFieldModel, Int64>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SaqFilterFieldModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqFilterFieldModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqFilterFieldModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqFilterFieldModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqFilterFieldModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqFilterFieldModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqFilterFieldModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqFilterFieldModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqFilterFieldModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqFilterFieldModel FetchById(System.Int64 id);

        System.String GetTableName();
    }
}
