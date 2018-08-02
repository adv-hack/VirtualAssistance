using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents represents a current or historic authentication session.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserSessionModel : IModel<Guid>
    {
        /// <summary>
        ///     Gets the status of the authentication session.
        /// </summary>
        Consensus.Security.UserSessionStates Status
        {
            get;
        }

        /// <summary>
        ///     Gets the The user account that has been authenticated.
        /// </summary>
        Consensus.Security.IUserAccountModel User
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for The user account that has been authenticated.
        /// </summary>
        System.Int32 UserId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The date and time on which the session became active.
        /// </summary>
        System.DateTime Active
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The date and time on which the session automatically expires, or was terminated.
        /// </summary>
        System.DateTime Expiry
        {
            get;
            set;
        }
    }
}
