using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a limitation applied to a software license.
    /// </summary>
    public partial class LocalLicenseLimitModel
    {
        /// <summary>
        ///     Gets or sets the type of limitation applied to the license.
        /// </summary>
        public LicenseLimitTypes Type
        {
            get { return this.ModifiedData.Type.ConvertTo<LicenseLimitTypes>(); }
            set { this.ModifiedData.Type = value.ConvertTo<Int32>(); }
        }

        /// <summary>
        ///     Gets or sets the description of the limitation applied to the license.
        /// </summary>
        public String TypeDescription
        {
            get { return this.Type.ConvertTo<String>(); }
        }
    }
}
