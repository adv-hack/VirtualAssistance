using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents specifies a permission that is held or withheld for a user or group.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserPermissionModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The security principal to whom the permission is applied.
        /// </summary>
        Consensus.Security.IUserPrincipalModel Principal
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal to whom the permission is applied.
        /// </summary>
        System.Int32 PrincipalId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The data type to which the permission is applied.
        /// </summary>
        System.String DataType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The type of action that is either permitted or prohibited.
        /// </summary>
        System.Int32 Action
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The value which indicates if the permission is granted (true) or denied (false).
        /// </summary>
        System.Boolean Allow
        {
            get;
            set;
        }
    }
}
