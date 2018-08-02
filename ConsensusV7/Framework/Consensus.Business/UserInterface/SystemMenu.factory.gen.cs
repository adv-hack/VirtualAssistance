using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SystemMenuModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISystemMenuFactory : IFactory<ISystemMenuModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SystemMenuModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SystemMenuModel" /> instance.
        /// </returns>
        Consensus.UserInterface.ISystemMenuModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SystemMenuModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SystemMenuModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ISystemMenuModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SystemMenuModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SystemMenuModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.ISystemMenuModel FetchById(System.Int32 id);

        System.String GetTableName();

        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ISystemMenuModel> FetchAllByParentId(System.Nullable<System.Int32> parentId);
    }
}
