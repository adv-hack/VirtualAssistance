using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="QuickAccessLinkModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IQuickAccessLinkFactory : IFactory<IQuickAccessLinkModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:QuickAccessLinkModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:QuickAccessLinkModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IQuickAccessLinkModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:QuickAccessLinkModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:QuickAccessLinkModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IQuickAccessLinkModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:QuickAccessLinkModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:QuickAccessLinkModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:QuickAccessLinkModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IQuickAccessLinkModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:QuickAccessLinkModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:QuickAccessLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:QuickAccessLinkModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IQuickAccessLinkModel> FetchAllByUserId(System.Int32 userId);
    }
}
