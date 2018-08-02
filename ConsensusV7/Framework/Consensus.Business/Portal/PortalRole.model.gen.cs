using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PortalRoleRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalRoleModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "PR_TITLE" field.
        /// </summary>
        System.String Title
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserRoleModel" /> instances that reference this <see cref="!:PortalRoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserRoleModel> PortalUserRoles
        {
            get;
        }
    }
}
