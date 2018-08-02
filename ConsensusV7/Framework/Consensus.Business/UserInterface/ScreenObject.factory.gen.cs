using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenObjectModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenObjectFactory : IFactory<IScreenObjectModel, Int32>
    {
        /// <summary>
        ///     Updates the page configuration.
        /// </summary>
        void Update(System.String url, System.Collections.ArrayList controls);

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenObjectModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenObjectModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
