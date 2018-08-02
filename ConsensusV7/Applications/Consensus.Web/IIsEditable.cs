using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Supports the toggling of edit mode.
    /// </summary>
    public interface IIsEditable
    {
        /// <summary>
        ///     Gets whether the page is initially rendered in editing mode.
        /// </summary>
        Boolean IsEditable { get; }
    }
}
