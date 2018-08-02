using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a module that is included within a license.
    /// </summary>
    public partial class LocalLicenseModuleModel
    {
        #region properties

        /// <summary>
        ///     Gets or sets the module that is included within the license.
        /// </summary>
        public LicenseModules Module
        {
            get { return this.ModifiedData.ModId.ConvertTo<LicenseModules>(); }
            set { this.ModifiedData.ModId = value.ConvertTo<Guid>(); }
        }

        #endregion
    }
}
