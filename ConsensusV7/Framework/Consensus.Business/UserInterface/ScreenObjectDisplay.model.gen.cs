using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Security;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectDisplayRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenObjectDisplayModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the visibility mode of the screen object.
        /// </summary>
        Consensus.UserInterface.ScreenObjectVisibility Visibility
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OBJDIS_OBJ_ID" field.
        /// </summary>
        Consensus.UserInterface.IScreenObjectModel ScreenObject
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJDIS_OBJ_ID" field.
        /// </summary>
        System.Int32 ScreenObjectId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        Consensus.Security.IUserPrincipalModel Principal
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        System.Int32 PrincipalId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJDIS_DISPLAY" field.
        /// </summary>
        System.Byte Display
        {
            get;
            set;
        }
    }
}
