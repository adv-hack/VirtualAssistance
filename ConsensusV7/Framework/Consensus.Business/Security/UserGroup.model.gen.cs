using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents represents a collection of users.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserGroupModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The security principal referenced by the group.
        /// </summary>
        Consensus.Security.IUserPrincipalModel Principal
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal referenced by the group.
        /// </summary>
        System.Int32 PrincipalId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserGroupMemberModel" /> instances that reference this <see cref="!:UserGroupModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserGroupMemberModel> UserGroupMemberships
        {
            get;
        }
    }
}
