using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenObjectColumnModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenObjectColumnFactory : IFactory<IScreenObjectColumnModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenObjectColumnModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectColumnModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectColumnModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectColumnModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectColumnModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectColumnModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenObjectColumnModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectColumnModel" /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref="!:ScreenObjectColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectColumnModel" /> instances that match the specified <paramref name="screenObjectId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectColumnModel> FetchAllByScreenObjectId(System.Int32 screenObjectId);
    }
}
