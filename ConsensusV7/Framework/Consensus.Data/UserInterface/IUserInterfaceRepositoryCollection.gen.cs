using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     The repository collection which pertains to the UserInterface namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserInterfaceRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.SystemmenusRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.ISystemMenuRepository SystemMenu
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.SystemmenusxrefRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.ISystemMenuXRefRepository SystemMenuXRef
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenObjectRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenObjectRepository ScreenObject
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenObjectDisplayRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenObjectDisplayRepository ScreenObjectDisplay
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenObjectEntryRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenObjectEntryRepository ScreenObjectEntry
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.QuickaccesslinkRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IQuickAccessLinkRepository QuickAccessLink
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.HistorylinkRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IHistoryLinkRepository HistoryLink
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenObjectColumnRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenObjectColumnRepository ScreenObjectColumn
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenCustomFieldRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldRepository ScreenCustomField
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenCustomFieldListitemRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldListitemRepository ScreenCustomFieldListitem
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenCustomFieldTypeRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldTypeRepository ScreenCustomFieldType
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.UserInterface.ScreenCustomFieldValueRecord" /> data structure.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldValueRepository ScreenCustomFieldValue
        {
            get;
        }
    }
}
