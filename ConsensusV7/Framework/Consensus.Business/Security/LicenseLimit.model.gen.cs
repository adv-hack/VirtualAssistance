using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents represents a limitation applied to a software license.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILicenseLimitModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the type of limitation applied to the license.
        /// </summary>
        Consensus.Security.LicenseLimitTypes Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the description of the limitation applied to the license.
        /// </summary>
        System.String TypeDescription
        {
            get;
        }

        /// <summary>
        ///     Gets the The value of the "LL_LIC_ID" field.
        /// </summary>
        Consensus.Security.ILicenseModel License
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LL_LIC_ID" field.
        /// </summary>
        System.Guid LicenseId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LL_VALUE" field.
        /// </summary>
        System.Int32 Value
        {
            get;
            set;
        }
    }
}
