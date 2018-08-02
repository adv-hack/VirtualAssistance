using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Security
{
    /// <summary>
    ///     Enumerates the standard operations that can be performed by a user
    /// </summary>
    public enum UserPermissionActions : int
    {
        /// <summary>
        ///     The user is granted or denied the permission to read data.
        /// </summary>
        Read = -268435456,

        /// <summary>
        ///     The user is granted or denied the permission to create data.
        /// </summary>
        Create = -268435455,

        /// <summary>
        ///     The user is granted or denied the permission to modify data.
        /// </summary>
        Modify = -268435454,

        /// <summary>
        ///     The user is granted or denied the permission to remove data.
        /// </summary>
        Remove = -268435453,
    }
}
