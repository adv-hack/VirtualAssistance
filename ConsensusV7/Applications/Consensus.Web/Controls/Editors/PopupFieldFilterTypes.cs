using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web.Controls
{
    public enum PopupFieldFilterTypes
    {
        /// <summary>
        ///     The popup field is filtered to the value of another control.
        /// </summary>
        Control,

        /// <summary>
        ///     The popup field is filtered by a specific, static value.
        /// </summary>
        Value
    }
}
