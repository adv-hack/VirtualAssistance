using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    public abstract class DataTableColumn : Control
    {
        #region fields

        /// <summary>
        ///     The CSS class applied to the column.
        /// </summary>
        private String _cssClass;

        /// <summary>
        ///     The title of the column that is displayed.
        /// </summary>
        private String _title;

        /// <summary>
        ///     The tooltip text that is displayed in the column header.
        /// </summary>
        private String _tooltip;

        /// <summary>
        ///     Specifies whether the column is exportable.
        /// </summary>
        private Boolean? _exportable;

        /// <summary>
        ///     Specifies whether the column can be used for ordering the data.
        /// </summary>
        private Boolean? _orderable;

        /// <summary>
        ///     The fixed width of the column.
        /// </summary>
        private Unit? _width;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the CSS class applied to the column.
        /// </summary>
        public String CssClass
        {
            get { return _cssClass; }
            set { _cssClass = value.TrimOrNullify(); }
        }

        /// <summary>
        ///     Gets the title of the column that is displayed.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value.TrimOrNullify(); }
        }

        /// <summary>
        ///    Gets or sets the tooltip text that is displayed in the column header.
        /// </summary>
        public String Tooltip
        {
            get { return _tooltip; }
            set { _tooltip = value.TrimOrNullify(); }
        }

        /// <summary>
        ///    Gets or sets whether the column is exportable.
        /// </summary>
        public virtual Boolean Exportable
        {
            get { return _exportable ?? true; }
            set { _exportable = value; }
        }

        /// <summary>
        ///    Gets or sets whether the column can be used for ordering the data.
        /// </summary>
        public Boolean Orderable
        {
            get { return _orderable ?? true; }
            set { _orderable = value; }
        }

        /// <summary>
        ///    Gets or sets the fixed width of the column.
        /// </summary>
        public Unit? Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        ///     Gets the serializable definition for the column.
        /// </summary>
        internal abstract String Definition
        {
            get;
        }

        #endregion
    }
}
