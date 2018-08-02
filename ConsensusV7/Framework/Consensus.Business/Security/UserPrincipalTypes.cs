using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Security
{
    public enum UserPrincipalTypes
    {
        /// <summary>
        ///     The principal represents a user group.
        /// </summary>
        Group = 0,

        /// <summary>
        ///     The principal represents a user account.
        /// </summary>
        User = 1,

        /// <summary>
        ///     The principal is not recognised.
        /// </summary>
        Unknown = Int32.MaxValue
    }
}
