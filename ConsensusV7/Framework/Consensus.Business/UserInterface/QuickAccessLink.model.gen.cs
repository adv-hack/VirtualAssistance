using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Security;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="QuickaccesslinkRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IQuickAccessLinkModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "QAL_USER_ID" field.
        /// </summary>
        Consensus.Security.IUserAccountModel User
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QAL_USER_ID" field.
        /// </summary>
        System.Int32 UserId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_URL" field.
        /// </summary>
        System.String Url
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_ICON" field.
        /// </summary>
        System.String Icon
        {
            get;
            set;
        }
    }
}
