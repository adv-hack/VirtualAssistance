using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web.Controls
{
    public enum DataTableModes
    {
        /// <summary>
        ///     When creating or editing a record, a popup window will be opened and the data will be saved (via the REST API)
        ///     immediately upon the closure of the popup window.
        /// </summary>
        RealTime,

        /// <summary>
        ///     When creating or editing a record, the user will be redirected to a different page in order to perform the modification.
        /// </summary>
        Redirect,

        /// <summary>
        ///     When creating or editing a record, a popup window will be opened and the data will be held in memory and saved
        ///     with the parent record.
        /// </summary>
        Stateful
    }
}
