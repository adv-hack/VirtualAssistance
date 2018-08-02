using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

namespace Consensus.Web.BackOffice
{
    /// <summary>
    ///     Provides the abstraction for all pages that are displayed within a popup window.
    /// </summary>
    public abstract class BasePopupPage : BaseSecurePage
    {
        #region properties

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public abstract String DialogTitle
        {
            get;
        }

        /// <summary>
        ///     Gets the width of the popup page
        /// </summary>
        public virtual UInt32 DialogWidth
        {
            get { return 950; }
        }

        #endregion
    }
}