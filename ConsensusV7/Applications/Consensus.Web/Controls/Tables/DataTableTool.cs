using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     A toolbar item for the data table.
    /// </summary>
    public abstract class DataTableTool : Control
    {
        #region fields

        /// <summary>
        ///     The text displayed on the button.
        /// </summary>
        private String _text;

        /// <summary>
        ///     The CSS class for the button.
        /// </summary>
        private String _cssClass;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the text displayed on the button.
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        ///    Gets or sets the CSS class for the button.
        /// </summary>
        public String CssClass
        {
            get { return _cssClass; }
            set { _cssClass = value; }
        }

        /// <summary>
        ///     Gets the serializable definition for the column
        /// </summary>
        internal abstract String Definition
        { 
            get;
        }

        #endregion
    }
}
