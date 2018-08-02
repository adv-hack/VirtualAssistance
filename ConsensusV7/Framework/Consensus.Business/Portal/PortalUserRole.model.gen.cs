using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PortaluserroleRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalUserRoleModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "PUR_PU_ID" field.
        /// </summary>
        Consensus.Portal.IPortalUserModel PortalUser
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUR_PU_ID" field.
        /// </summary>
        System.Int32 PortalUserId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PUR_PR_ID" field.
        /// </summary>
        Consensus.Portal.IPortalRoleModel PortalRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUR_PR_ID" field.
        /// </summary>
        System.Int32 PortalRoleId
        {
            get;
            set;
        }
    }
}
