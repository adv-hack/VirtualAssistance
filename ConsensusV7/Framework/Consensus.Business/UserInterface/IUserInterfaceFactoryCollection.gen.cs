using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the UserInterface namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserInterfaceFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SystemMenuModel" /> objects.
        /// </summary>
        Consensus.UserInterface.ISystemMenuFactory SystemMenu
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SystemMenuXRefModel" /> objects.
        /// </summary>
        Consensus.UserInterface.ISystemMenuXRefFactory SystemMenuXRef
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenObjectModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenObjectFactory ScreenObject
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenObjectDisplayModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenObjectDisplayFactory ScreenObjectDisplay
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenObjectEntryModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenObjectEntryFactory ScreenObjectEntry
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:QuickAccessLinkModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IQuickAccessLinkFactory QuickAccessLink
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:HistoryLinkModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IHistoryLinkFactory HistoryLink
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenObjectColumnModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenObjectColumnFactory ScreenObjectColumn
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenCustomFieldModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldFactory ScreenCustomField
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenCustomFieldListitemModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldListitemFactory ScreenCustomFieldListitem
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenCustomFieldTypeModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldTypeFactory ScreenCustomFieldType
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenCustomFieldValueModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldValueFactory ScreenCustomFieldValue
        {
            get;
        }
    }
}
