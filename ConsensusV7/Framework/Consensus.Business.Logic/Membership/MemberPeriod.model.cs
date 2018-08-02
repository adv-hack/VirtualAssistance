using Consensus.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MemberPeriodRecord" /> with standardised business rules.
    /// </summary>
    [LicenseModuleRestriction(LicenseModules.Membership)]
    [UserPermissionAttribute(typeof(MemberPeriodPermission))]
    [DisplayName("Membership Period")]
    public partial class LocalMemberPeriodModel
    {
        #region fields

        /// <summary>
        ///     Defines the custom permissions for membership periods.
        /// </summary>
        public enum MemberPeriodPermission
        {
            /// <summary>
            ///     Renew a member period.
            /// </summary>
            Renew,
        }

        #endregion

        #region properties

        public Int32 StatusNumber
        {
            get
            {
                Int32 result = 0;
                if (!String.IsNullOrEmpty(this.StatusCode) && this.StatusCode.Length > 2)
                    result = this.StatusCode.Substring(0, 2).ConvertTo<Int32>();
                
                return result;
            }
        }

        #endregion
    }
}
