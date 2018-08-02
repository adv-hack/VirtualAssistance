using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectEntryRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenObjectEntryModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        Consensus.UserInterface.IScreenObjectModel ScreenObject
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        System.Int32 ScreenObjectId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_NORMAL" field.
        /// </summary>
        System.String Normal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_CUSTOM" field.
        /// </summary>
        System.String Custom
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_HIDE" field.
        /// </summary>
        System.Boolean Hide
        {
            get;
            set;
        }
    }
}
