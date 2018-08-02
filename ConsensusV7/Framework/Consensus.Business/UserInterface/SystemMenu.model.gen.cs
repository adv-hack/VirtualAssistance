using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="SystemmenusRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISystemMenuModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "SMENU_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_URL" field.
        /// </summary>
        System.String Page
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_GROUP" field.
        /// </summary>
        System.String Group
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_ICON" field.
        /// </summary>
        System.String Icon
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_RELATIVE_PATH" field.
        /// </summary>
        System.String RelativePath
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "SMENU_SMENU_ID" field.
        /// </summary>
        Consensus.UserInterface.ISystemMenuModel Parent
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMENU_SMENU_ID" field.
        /// </summary>
        System.Nullable<System.Int32> ParentId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SystemMenuModel" /> instances that reference this <see cref="!:SystemMenuModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.ISystemMenuModel> SystemMenus
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SystemMenuXRefModel" /> instances that reference this <see cref="!:SystemMenuModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.ISystemMenuXRefModel> Modules
        {
            get;
        }
    }
}
