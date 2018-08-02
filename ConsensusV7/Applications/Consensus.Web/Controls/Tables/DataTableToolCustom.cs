using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     A custom toolbar item for the data table.
    /// </summary>
    public class DataTableToolCustom : DataTableTool
    {
        #region fields

        /// <summary>
        ///     The client-side action performed when the button is clicked.
        /// </summary>
        private String _action;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the client-side action performed when the button is clicked.
        /// </summary>
        public String Action
        {
            get { return _action; }
            set { _action = value; }
        }

        /// <summary>
        ///     Gets the serializable definition for the toolbar item.
        /// </summary>
        internal override String Definition
        {
            get
            {
                return @"
                    { 
                        text: " + HttpUtility.JavaScriptStringEncode(this.Text, true) + @",
                        className: " + HttpUtility.JavaScriptStringEncode(this.CssClass, true) + @",
                        action: function ( e, dt, node, config ) { " + this.Action + @"; }
                    }";
            }
        }

        #endregion
    }
}
