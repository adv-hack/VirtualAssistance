using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenCustomFieldModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenCustomFieldFactory : IFactory<IScreenCustomFieldModel, Int32>
    {
        /// <summary>
        ///     Fetch the custom fields for a page.
        /// </summary>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldModel> FetchAllByPage(System.String page);

        /// <summary>
        ///     Updates the page configuration.
        /// </summary>
        void Update(System.Collections.ArrayList customFields);

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldModel" /> instances.
        /// </summary>
        /// <param name="cftypeId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldModel" /> instances that match the specified <paramref name="cftypeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldModel> FetchAllByCftypeId(System.String cftypeId);
    }
}
