using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ViewLogModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IViewLogFactory : IFactory<IViewLogModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ViewLogModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ViewLogModel" /> instance.
        /// </returns>
        Consensus.Common.IViewLogModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ViewLogModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ViewLogModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IViewLogModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ViewLogModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ViewLogModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ViewLogModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IViewLogModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
