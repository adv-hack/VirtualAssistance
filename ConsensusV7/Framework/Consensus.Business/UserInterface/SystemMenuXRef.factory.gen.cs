using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SystemMenuXRefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISystemMenuXRefFactory : IFactory<ISystemMenuXRefModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SystemMenuXRefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SystemMenuXRefModel" /> instance.
        /// </returns>
        Consensus.UserInterface.ISystemMenuXRefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SystemMenuXRefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SystemMenuXRefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ISystemMenuXRefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SystemMenuXRefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SystemMenuXRefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuXRefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.ISystemMenuXRefModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SystemMenuXRefModel" /> instances.
        /// </summary>
        /// <param name="systemMenuId">
        ///     The value which identifies the <see cref="!:SystemMenuXRefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuXRefModel" /> instances that match the specified <paramref name="systemMenuId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ISystemMenuXRefModel> FetchAllBySystemMenuId(System.Int32 systemMenuId);
    }
}
