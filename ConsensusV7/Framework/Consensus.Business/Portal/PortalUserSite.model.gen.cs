using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PuSiteRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalUserSiteModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "PUSTE_PU_ID" field.
        /// </summary>
        Consensus.Portal.IPortalUserModel PortalUser
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUSTE_PU_ID" field.
        /// </summary>
        System.Nullable<System.Int32> PortalUserId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PUSTE_PS_ID" field.
        /// </summary>
        Consensus.Portal.IPortalSetupModel PortalSetup
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUSTE_PS_ID" field.
        /// </summary>
        System.Nullable<System.Int32> PortalSetupId
        {
            get;
            set;
        }
    }
}
