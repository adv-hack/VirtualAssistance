using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consensus.Web.BackOffice
{
    public enum PopupButtons
    {
        /// <summary>
        ///     Neither cancel nor clear options are available.
        /// </summary>
        None = 0,

        /// <summary>
        ///     A single button is displayed, labelled "cancel" which closes the popup
        /// </summary>
        Cancel = 1,

        /// <summary>
        ///     A single button is displayed, labelled "cancel" which closes the popup and instructs the caller to clear any existing value.
        /// </summary>
        Clear = 2,

        /// <summary>
        ///     Two separate buttons are displayed labelled "cancel" (which closes the popup) and "clear" (which closes the popup and
        ///     instructs the caller to clear any existing value).
        /// </summary>        
        Both = 3
    }
}