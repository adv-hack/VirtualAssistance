using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Consensus.Web.Controls
{
    public class DataTableButtonColumnItem : Control
    {
        #region fields

        /// <summary>
        ///     The icon displayed for the button.
        /// </summary>
        private String _icon;

        /// <summary>
        ///     The tooltip displayed for the button.
        /// </summary>
        private String _tooltip;

        /// <summary>
        ///     The client-side onclick handler for the button.
        /// </summary>
        private String _onClick;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the icon displayed for the button.
        /// </summary>
        public String Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        /// <summary>
        ///    Gets or sets the tooltip displayed for the button.
        /// </summary>
        public String Tooltip
        {
            get { return _tooltip; }
            set { _tooltip = value; }
        }

        /// <summary>
        ///    Gets or sets the client-side onclick handler for the button.
        /// </summary>
        public String OnClick
        {
            get { return _onClick; }
            set { _onClick = value; }
        }

        /// <summary>
        ///     Gets the definition for the button
        /// </summary>
        internal String Definition
        {
            get { return String.Format("<a onclick=\\\"{0}\\\" class=\\\"icons8-{1}\\\" title=\\\"{2}\\\"></a>", this.OnClick, this.Icon, this.Tooltip); }
        }

        #endregion        
    }
}
