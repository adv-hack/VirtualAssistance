using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Security
{
    public enum LicenseLimitTypes
    {
        /// <summary>
        ///     Specifies the maximum number of distinct users that can be logged on simultaneouly.
        /// </summary>
        /// <example>
        ///     If two users each authenticate twice, the two users will be counted towards this limitation type.
        /// </example>
        [Description("Pool A")] //Maximum number of users that can be logged on simultaneously
        PoolA,

        /// <summary>
        ///     Specifies the maximum number of authentication sessions that can be active simultaneouly.
        /// </summary>
        /// <example>
        ///     If two users each authenticate twice, the four sessions will be counted towards this limitation type.
        /// </example>
        [Description("Pool B")] //Maximum number of login sessions that can be active simultaneously
        PoolB
    }
}
