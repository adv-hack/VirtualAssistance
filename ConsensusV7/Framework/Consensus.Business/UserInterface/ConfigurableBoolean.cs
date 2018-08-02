using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Enumerates the possible values for a configurable boolean.
    /// </summary>
    public enum ConfigurableBoolean
    {
        /// <summary>
        ///     The value is true by default, but can be re-configured.
        /// </summary>
        True = 1,

        /// <summary>
        ///     The value is false by default, but can be re-configured.
        /// </summary>
        False = -1,

        /// <summary>
        ///     The value is always true and cannot be re-configured.
        /// </summary>
        TrueEnforced = 2,

        /// <summary>
        ///     The value is always false and cannot be re-configured.
        /// </summary>
        FalseEnforced = -2
    }
}
