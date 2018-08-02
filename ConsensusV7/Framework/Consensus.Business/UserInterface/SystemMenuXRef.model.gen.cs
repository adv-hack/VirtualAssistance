using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="SystemmenusxrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISystemMenuXRefModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        Consensus.UserInterface.ISystemMenuModel SystemMenu
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        System.Int32 SystemMenuId
        {
            get;
            set;
        }
    }
}
