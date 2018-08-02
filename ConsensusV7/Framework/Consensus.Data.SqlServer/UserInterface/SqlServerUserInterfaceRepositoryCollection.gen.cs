using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the UserInterface namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerUserInterfaceRepositoryCollection : SqlServerRepositoryCollection, IUserInterfaceRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SystemmenusRecord" /> data structure.
        /// </summary>
        private SqlServerSystemMenuRepository _systemMenu;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SystemmenusxrefRecord" /> data structure.
        /// </summary>
        private SqlServerSystemMenuXRefRepository _systemMenuXRef;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenObjectRecord" /> data structure.
        /// </summary>
        private SqlServerScreenObjectRepository _screenObject;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenObjectDisplayRecord" /> data structure.
        /// </summary>
        private SqlServerScreenObjectDisplayRepository _screenObjectDisplay;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenObjectEntryRecord" /> data structure.
        /// </summary>
        private SqlServerScreenObjectEntryRepository _screenObjectEntry;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="QuickaccesslinkRecord" /> data structure.
        /// </summary>
        private SqlServerQuickAccessLinkRepository _quickAccessLink;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="HistorylinkRecord" /> data structure.
        /// </summary>
        private SqlServerHistoryLinkRepository _historyLink;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenObjectColumnRecord" /> data structure.
        /// </summary>
        private SqlServerScreenObjectColumnRepository _screenObjectColumn;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenCustomFieldRecord" /> data structure.
        /// </summary>
        private SqlServerScreenCustomFieldRepository _screenCustomField;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenCustomFieldListitemRecord" /> data structure.
        /// </summary>
        private SqlServerScreenCustomFieldListitemRepository _screenCustomFieldListitem;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenCustomFieldTypeRecord" /> data structure.
        /// </summary>
        private SqlServerScreenCustomFieldTypeRepository _screenCustomFieldType;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenCustomFieldValueRecord" /> data structure.
        /// </summary>
        private SqlServerScreenCustomFieldValueRepository _screenCustomFieldValue;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SystemmenusRecord" /> data structure.
        /// </summary>
        public SqlServerSystemMenuRepository SystemMenu
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSystemMenuRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _systemMenu);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SystemmenusxrefRecord" /> data structure.
        /// </summary>
        public SqlServerSystemMenuXRefRepository SystemMenuXRef
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSystemMenuXRefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _systemMenuXRef);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenObjectRecord" /> data structure.
        /// </summary>
        public SqlServerScreenObjectRepository ScreenObject
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerScreenObjectRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _screenObject);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenObjectDisplayRecord" /> data structure.
        /// </summary>
        public SqlServerScreenObjectDisplayRepository ScreenObjectDisplay
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerScreenObjectDisplayRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _screenObjectDisplay);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenObjectEntryRecord" /> data structure.
        /// </summary>
        public SqlServerScreenObjectEntryRepository ScreenObjectEntry
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerScreenObjectEntryRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _screenObjectEntry);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="QuickaccesslinkRecord" /> data structure.
        /// </summary>
        public SqlServerQuickAccessLinkRepository QuickAccessLink
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerQuickAccessLinkRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _quickAccessLink);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="HistorylinkRecord" /> data structure.
        /// </summary>
        public SqlServerHistoryLinkRepository HistoryLink
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerHistoryLinkRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _historyLink);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenObjectColumnRecord" /> data structure.
        /// </summary>
        public SqlServerScreenObjectColumnRepository ScreenObjectColumn
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerScreenObjectColumnRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _screenObjectColumn);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenCustomFieldRecord" /> data structure.
        /// </summary>
        public SqlServerScreenCustomFieldRepository ScreenCustomField
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerScreenCustomFieldRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _screenCustomField);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenCustomFieldListitemRecord" /> data structure.
        /// </summary>
        public SqlServerScreenCustomFieldListitemRepository ScreenCustomFieldListitem
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerScreenCustomFieldListitemRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _screenCustomFieldListitem);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenCustomFieldTypeRecord" /> data structure.
        /// </summary>
        public SqlServerScreenCustomFieldTypeRepository ScreenCustomFieldType
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerScreenCustomFieldTypeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _screenCustomFieldType);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ScreenCustomFieldValueRecord" /> data structure.
        /// </summary>
        public SqlServerScreenCustomFieldValueRepository ScreenCustomFieldValue
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerScreenCustomFieldValueRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _screenCustomFieldValue);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.SystemmenusRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.ISystemMenuRepository IUserInterfaceRepositoryCollection.SystemMenu
        {
            get { return this.SystemMenu; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.SystemmenusxrefRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.ISystemMenuXRefRepository IUserInterfaceRepositoryCollection.SystemMenuXRef
        {
            get { return this.SystemMenuXRef; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenObjectRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenObjectRepository IUserInterfaceRepositoryCollection.ScreenObject
        {
            get { return this.ScreenObject; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenObjectDisplayRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenObjectDisplayRepository IUserInterfaceRepositoryCollection.ScreenObjectDisplay
        {
            get { return this.ScreenObjectDisplay; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenObjectEntryRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenObjectEntryRepository IUserInterfaceRepositoryCollection.ScreenObjectEntry
        {
            get { return this.ScreenObjectEntry; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.QuickaccesslinkRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IQuickAccessLinkRepository IUserInterfaceRepositoryCollection.QuickAccessLink
        {
            get { return this.QuickAccessLink; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.HistorylinkRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IHistoryLinkRepository IUserInterfaceRepositoryCollection.HistoryLink
        {
            get { return this.HistoryLink; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenObjectColumnRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenObjectColumnRepository IUserInterfaceRepositoryCollection.ScreenObjectColumn
        {
            get { return this.ScreenObjectColumn; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenCustomFieldRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldRepository IUserInterfaceRepositoryCollection.ScreenCustomField
        {
            get { return this.ScreenCustomField; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenCustomFieldListitemRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldListitemRepository IUserInterfaceRepositoryCollection.ScreenCustomFieldListitem
        {
            get { return this.ScreenCustomFieldListitem; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenCustomFieldTypeRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldTypeRepository IUserInterfaceRepositoryCollection.ScreenCustomFieldType
        {
            get { return this.ScreenCustomFieldType; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenCustomFieldValueRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldValueRepository IUserInterfaceRepositoryCollection.ScreenCustomFieldValue
        {
            get { return this.ScreenCustomFieldValue; }
        }

        #endregion
    }
}
