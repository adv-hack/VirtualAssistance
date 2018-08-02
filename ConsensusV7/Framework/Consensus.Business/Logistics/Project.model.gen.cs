using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Marketing;

namespace Consensus.Logistics
{
    /// <summary>
    ///     Encapsulates the <see cref="ProjectRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProjectModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "PROJ_STATUS" field.
        /// </summary>
        System.String Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_ORG_ID" field.
        /// </summary>
        System.String OrgId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_SELCO_SP_ID" field.
        /// </summary>
        System.String SelcoSpId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:ProjectModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ICampaignModel> CampaignProject
        {
            get;
        }
    }
}
