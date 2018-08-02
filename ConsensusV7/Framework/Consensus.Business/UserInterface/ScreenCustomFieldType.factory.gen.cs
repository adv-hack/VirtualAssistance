using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenCustomFieldTypeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenCustomFieldTypeFactory : IFactory<IScreenCustomFieldTypeModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldTypeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldTypeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldTypeModel FetchById(System.String id);

        System.String GetTableName();
    }
}
