using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenCustomFieldValueModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenCustomFieldValueFactory : IFactory<IScreenCustomFieldValueModel, Int32>
    {
        Consensus.UserInterface.IScreenCustomFieldValueModel FetchByFieldIdAndRecordId(System.Int32 fieldId, System.String recordId);

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldValueModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldValueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldValueModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldValueModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldValueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldValueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldValueModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldValueModel" /> instances.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldValueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldValueModel" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldValueModel> FetchAllByCfieldId(System.Int32 cfieldId);
    }
}
