using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PortalSetupRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalSetupModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "PS_PORTAL_TITLE" field.
        /// </summary>
        System.String PortalTitle
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PS_PORTAL_URL" field.
        /// </summary>
        System.String PortalUrl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserSiteModel" /> instances that reference this <see cref="!:PortalSetupModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserSiteModel> PortalUserSites
        {
            get;
        }
    }
}
