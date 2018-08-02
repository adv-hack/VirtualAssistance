using System;
using System.Collections.Generic;
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
    public partial class LocalUserInterfaceFactoryCollection : LocalFactoryCollection, IUserInterfaceFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SystemMenuModel" /> objects.
        /// </summary>
        private LocalSystemMenuFactory _systemMenu;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SystemMenuXRefModel" /> objects.
        /// </summary>
        private LocalSystemMenuXRefFactory _systemMenuXRef;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ScreenObjectModel" /> objects.
        /// </summary>
        private LocalScreenObjectFactory _screenObject;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ScreenObjectDisplayModel" /> objects.
        /// </summary>
        private LocalScreenObjectDisplayFactory _screenObjectDisplay;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ScreenObjectEntryModel" /> objects.
        /// </summary>
        private LocalScreenObjectEntryFactory _screenObjectEntry;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="QuickAccessLinkModel" /> objects.
        /// </summary>
        private LocalQuickAccessLinkFactory _quickAccessLink;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="HistoryLinkModel" /> objects.
        /// </summary>
        private LocalHistoryLinkFactory _historyLink;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ScreenObjectColumnModel" /> objects.
        /// </summary>
        private LocalScreenObjectColumnFactory _screenObjectColumn;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ScreenCustomFieldModel" /> objects.
        /// </summary>
        private LocalScreenCustomFieldFactory _screenCustomField;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ScreenCustomFieldListitemModel" /> objects.
        /// </summary>
        private LocalScreenCustomFieldListitemFactory _screenCustomFieldListitem;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ScreenCustomFieldTypeModel" /> objects.
        /// </summary>
        private LocalScreenCustomFieldTypeFactory _screenCustomFieldType;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ScreenCustomFieldValueModel" /> objects.
        /// </summary>
        private LocalScreenCustomFieldValueFactory _screenCustomFieldValue;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SystemMenuModel" /> objects.
        /// </summary>
        public LocalSystemMenuFactory SystemMenu
        {
            get { return LocalFactory.Create(this.Provider, ref _systemMenu); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SystemMenuXRefModel" /> objects.
        /// </summary>
        public LocalSystemMenuXRefFactory SystemMenuXRef
        {
            get { return LocalFactory.Create(this.Provider, ref _systemMenuXRef); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ScreenObjectModel" /> objects.
        /// </summary>
        public LocalScreenObjectFactory ScreenObject
        {
            get { return LocalFactory.Create(this.Provider, ref _screenObject); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ScreenObjectDisplayModel" /> objects.
        /// </summary>
        public LocalScreenObjectDisplayFactory ScreenObjectDisplay
        {
            get { return LocalFactory.Create(this.Provider, ref _screenObjectDisplay); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ScreenObjectEntryModel" /> objects.
        /// </summary>
        public LocalScreenObjectEntryFactory ScreenObjectEntry
        {
            get { return LocalFactory.Create(this.Provider, ref _screenObjectEntry); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="QuickAccessLinkModel" /> objects.
        /// </summary>
        public LocalQuickAccessLinkFactory QuickAccessLink
        {
            get { return LocalFactory.Create(this.Provider, ref _quickAccessLink); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="HistoryLinkModel" /> objects.
        /// </summary>
        public LocalHistoryLinkFactory HistoryLink
        {
            get { return LocalFactory.Create(this.Provider, ref _historyLink); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ScreenObjectColumnModel" /> objects.
        /// </summary>
        public LocalScreenObjectColumnFactory ScreenObjectColumn
        {
            get { return LocalFactory.Create(this.Provider, ref _screenObjectColumn); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ScreenCustomFieldModel" /> objects.
        /// </summary>
        public LocalScreenCustomFieldFactory ScreenCustomField
        {
            get { return LocalFactory.Create(this.Provider, ref _screenCustomField); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ScreenCustomFieldListitemModel" /> objects.
        /// </summary>
        public LocalScreenCustomFieldListitemFactory ScreenCustomFieldListitem
        {
            get { return LocalFactory.Create(this.Provider, ref _screenCustomFieldListitem); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ScreenCustomFieldTypeModel" /> objects.
        /// </summary>
        public LocalScreenCustomFieldTypeFactory ScreenCustomFieldType
        {
            get { return LocalFactory.Create(this.Provider, ref _screenCustomFieldType); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ScreenCustomFieldValueModel" /> objects.
        /// </summary>
        public LocalScreenCustomFieldValueFactory ScreenCustomFieldValue
        {
            get { return LocalFactory.Create(this.Provider, ref _screenCustomFieldValue); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SystemMenuModel" /> objects.
        /// </summary>
        Consensus.UserInterface.ISystemMenuFactory IUserInterfaceFactoryCollection.SystemMenu
        {
            get { return this.SystemMenu; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SystemMenuXRefModel" /> objects.
        /// </summary>
        Consensus.UserInterface.ISystemMenuXRefFactory IUserInterfaceFactoryCollection.SystemMenuXRef
        {
            get { return this.SystemMenuXRef; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenObjectModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenObjectFactory IUserInterfaceFactoryCollection.ScreenObject
        {
            get { return this.ScreenObject; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenObjectDisplayModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenObjectDisplayFactory IUserInterfaceFactoryCollection.ScreenObjectDisplay
        {
            get { return this.ScreenObjectDisplay; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenObjectEntryModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenObjectEntryFactory IUserInterfaceFactoryCollection.ScreenObjectEntry
        {
            get { return this.ScreenObjectEntry; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:QuickAccessLinkModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IQuickAccessLinkFactory IUserInterfaceFactoryCollection.QuickAccessLink
        {
            get { return this.QuickAccessLink; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:HistoryLinkModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IHistoryLinkFactory IUserInterfaceFactoryCollection.HistoryLink
        {
            get { return this.HistoryLink; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenObjectColumnModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenObjectColumnFactory IUserInterfaceFactoryCollection.ScreenObjectColumn
        {
            get { return this.ScreenObjectColumn; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenCustomFieldModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldFactory IUserInterfaceFactoryCollection.ScreenCustomField
        {
            get { return this.ScreenCustomField; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenCustomFieldListitemModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldListitemFactory IUserInterfaceFactoryCollection.ScreenCustomFieldListitem
        {
            get { return this.ScreenCustomFieldListitem; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenCustomFieldTypeModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldTypeFactory IUserInterfaceFactoryCollection.ScreenCustomFieldType
        {
            get { return this.ScreenCustomFieldType; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ScreenCustomFieldValueModel" /> objects.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldValueFactory IUserInterfaceFactoryCollection.ScreenCustomFieldValue
        {
            get { return this.ScreenCustomFieldValue; }
        }

        #endregion
    }
}
