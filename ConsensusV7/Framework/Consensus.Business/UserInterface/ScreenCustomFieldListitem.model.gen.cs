using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenCustomFieldListitemRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenCustomFieldListitemModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldModel Cfield
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        System.Int32 CfieldId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CFLITEM_ID_VALUE" field.
        /// </summary>
        System.String IdValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CFLITEM_TEXT" field.
        /// </summary>
        System.String Text
        {
            get;
            set;
        }
    }
}
