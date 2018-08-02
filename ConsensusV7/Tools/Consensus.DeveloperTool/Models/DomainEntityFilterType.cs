using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Enumerates the types of filtering.
    /// </summary>
    public enum DomainEntityFilterType
    {
        /// <summary>
        ///     Equality match.
        /// </summary>
        [Description("==")]
        Equal,

        /// <summary>
        ///     Inequality match.
        /// </summary>
        [Description("!=")]
        Inequal,

        /// <summary>
        ///     Lesser match.
        /// </summary>
        [Description("<")]
        Lesser,

        /// <summary>
        ///     Lesser-or-equal match.
        /// </summary>
        [Description("<=")]
        LesserOrEqual,

        /// <summary>
        ///     Greater match.
        /// </summary>
        [Description(">")]
        Greater,

        /// <summary>
        ///     Greater-or-equal match.
        /// </summary>
        [Description(">=")]
        GreaterOrEqual,

        /// <summary>
        ///     List Match
        /// </summary>
        [Description("in")]
        List,

        /// <summary>
        ///     Not in List Match
        /// </summary>
        [Description("not in")]
        NotList,
    }
}
