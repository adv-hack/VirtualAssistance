using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenCustomFieldListitemModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenCustomFieldListitemFactory : IFactory<IScreenCustomFieldListitemModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldListitemModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldListitemModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldListitemModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldListitemModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldListitemModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldListitemModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldListitemModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldListitemModel" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldListitemModel> FetchAllByCfieldId(System.Int32 cfieldId);
    }
}
