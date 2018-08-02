using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents represents a membership to a user group.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserGroupMemberModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The security principal that is a member of the group.
        /// </summary>
        Consensus.Security.IUserPrincipalModel Principal
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal that is a member of the group.
        /// </summary>
        System.Int32 PrincipalId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The user group in which the member is included.
        /// </summary>
        Consensus.Security.IUserGroupModel Group
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for The user group in which the member is included.
        /// </summary>
        System.Int32 GroupId
        {
            get;
            set;
        }
    }
}
