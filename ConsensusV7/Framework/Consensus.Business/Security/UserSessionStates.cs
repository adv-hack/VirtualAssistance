using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Security
{
    /// <summary>
    ///     Enumerates the different states of an authentication session.
    /// </summary>
    public enum UserSessionStates
    {
        /// <summary>
        ///     The authentication session is currently active.
        /// </summary>
        Active = 0,

        /// <summary>
        ///     The authentication session ended at the users request.
        /// </summary>
        LoggedOff = 2,

        /// <summary>
        ///     The authentication session was terminated due to a period of inactivity.
        /// </summary>
        Expired = 1,

        /// <summary>
        ///     The authentication session was terminated at an administrators request.
        /// </summary>
        Terminated = 3
    }
}
