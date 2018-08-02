using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents represents a module that is included within a license.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILicenseModuleModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the module that is included within the license.
        /// </summary>
        Consensus.Security.LicenseModules Module
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_LIC_ID" field.
        /// </summary>
        System.Guid License
        {
            get;
            set;
        }
    }
}
