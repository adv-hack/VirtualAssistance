using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectColumnRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenObjectColumnModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "OBJCOL_OBJ_ID" field.
        /// </summary>
        Consensus.UserInterface.IScreenObjectModel ScreenObject
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJCOL_OBJ_ID" field.
        /// </summary>
        System.Int32 ScreenObjectId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_ORDINAL" field.
        /// </summary>
        System.Int32 Ordinal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_CUSTOM" field.
        /// </summary>
        System.String CustomTitle
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_EXPORTABLE" field.
        /// </summary>
        System.Boolean Exportable
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_VISIBLE" field.
        /// </summary>
        System.Boolean Visible
        {
            get;
            set;
        }
    }
}
