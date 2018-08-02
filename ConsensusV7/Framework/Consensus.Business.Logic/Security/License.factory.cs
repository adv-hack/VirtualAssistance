using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LicenseModel" /> object.
    /// </summary>
    public partial class LocalLicenseFactory
    {
        /// <summary>
        ///     The singleton instance of the current license.
        /// </summary>
        private static LocalLicenseModel _license;

        /// <summary>
        ///     Gets the active software license.
        /// </summary>
        /// <returns>
        ///     The most applicable software license.
        /// </returns>
        public LocalLicenseModel GetCurrent()
        {
            if (_license == null)
                _license = this.Provider.Security.License.FetchAll().OrderBy(license =>
                    license.Status == LicenseStatus.OK ? 1 :
                    license.Status == LicenseStatus.Invalid ? 2 :
                    license.Status == LicenseStatus.Expired ? 3 : 
                    license.Status == LicenseStatus.Inactive ? 4 :
                    license.Status == LicenseStatus.Revoked ? 5 : 6
                ).FirstOrDefault();

            return _license;    
        }

        /// <summary>
        ///     Generates a signature for the specified license verification code.
        /// </summary>
        public String Sign(String verification)
        {
            Byte parsedValue;
            List<Byte> result = new List<Byte>();

            // Construct the byte array from the specified verification
            if (String.IsNullOrEmpty(verification) || verification.Length != 128)
                throw new InvalidOperationException("Specified value is not a valid license verifier");
            for (Int32 i = 0; i < verification.Length; i += 2)
                if (!Byte.TryParse(verification.Substring(i, 2), NumberStyles.HexNumber, null, out parsedValue))
                    throw new InvalidOperationException("Specified value is not a valid license verifier");
                else
                    result.Add(parsedValue);
            
            // Sign the specified verification
            if (LicenseKey.PrivateKey != null)
                return String.Join("", LicenseKey.PrivateKey.Sign(result.ToArray()).Select(b => b.ToString("x2")));
            else
                throw new UnauthorizedAccessException();
        }

        /// <summary>
        ///     Clears the cached license from memory so that the updated license can be reloaded and recached.
        /// </summary>
        internal void Reset()
        {
            _license = null;
        }
    }
}
