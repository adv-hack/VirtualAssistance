using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents represents a current or historic credential used to authenticate a user.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserCredentialModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The user account to whom the password belongs.
        /// </summary>
        Consensus.Security.IUserAccountModel User
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for The user account to whom the password belongs.
        /// </summary>
        System.Int32 UserId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The salting value for the password,.
        /// </summary>
        System.Byte[] Salt
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The verifier for the password.
        /// </summary>
        System.Byte[] Pass
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The date and time on which the password was set.
        /// </summary>
        System.DateTime Modified
        {
            get;
            set;
        }
    }
}
