using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Security
{
    /// <summary>
    ///     Enumerates the different states of a software license.
    /// </summary>
    public enum LicenseStatus
    {
        /// <summary>
        ///     The license is active and valid. 
        /// </summary>
        /// <remarks>
        ///     The license will be deemed valid if the active date has (inclusively) elapsed, the expiry date has not (exclusively) elapsed,
        ///     a digital signature has been provided by the software vendor and the signature matches the current license-protected data.
        /// </remarks>
        OK,

        /// <summary>
        ///     The license is not yet active.
        /// </summary>
        /// <remarks>
        ///     A license will be <see cref="Inactive"/> if the active date on the license has not elapsed. The license will
        ///     become valid from and including the active date, using a date-only comparison is performed (time of day is ineffective).
        /// </remarks>
        Inactive,
        
        /// <summary>
        ///     The license has expired.
        /// </summary>
        /// <remarks>
        ///     A license will become <see cref="Expired"/> if the expiry date on the license has elapsed. The license will
        ///     remain valid up to and including the expiry date, using a date-only comparison is performed (time of day is ineffective).
        /// </remarks>
        Expired,

        /// <summary>
        ///     The license has been invalidated.
        /// </summary>
        /// <remarks>
        ///     A license will become <see cref="Invalid"/> if any of the license-protected data has been changed 
        ///     and the license has not been signed by the software vendor to validate the new license.
        /// </remarks>
        Invalid,

        /// <summary>
        ///     The license has been revoked.
        /// </summary>
        /// <remarks>
        ///     A license will become <see cref="Revoked"/> if the digital signature for a license is removed.  Such recovation is recommended
        ///     for any license which has been superceded by a new license.
        /// </remarks>
        Revoked
    }
}
