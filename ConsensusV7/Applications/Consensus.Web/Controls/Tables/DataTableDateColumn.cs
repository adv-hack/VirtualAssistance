using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Consensus.Web.Controls
{
    public class DataTableDateColumn : DataTableTextColumn
    {
        #region fields

        /// <summary>
        ///     The moment.js date format used to render the column
        /// </summary>
        private String _dateFormat;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the 
        /// </summary>
        public String DateFormat
        {
            get { return _dateFormat ?? "DD MMMM YYYY"; }
            set { _dateFormat = value; }
        }

        /// <summary>
        ///     Gets the serializable definition for the column.
        /// </summary>
        internal override String Definition
        {
            get
            {
                StringBuilder json = new StringBuilder();
                json.AppendLine("{");
                json.AppendLine("  class: \"" + this.CssClass + "\", ");
                json.AppendLine("  data: " + HttpUtility.JavaScriptStringEncode(this.FieldName, true) + ", ");
                json.AppendLine("  title: " + HttpUtility.JavaScriptStringEncode(this.Title, true) + ", ");
                json.AppendLine("  tooltip: " + HttpUtility.JavaScriptStringEncode(this.Tooltip, true) + ", ");
                json.AppendLine("  orderable: " + this.Orderable.ToString().ToLower() + ", ");
                json.AppendLine("  visible: " + this.Visible.ToString().ToLower() + ",");
                json.AppendLine("  width: " + HttpUtility.JavaScriptStringEncode(this.Width.HasValue ? this.Width.Value.ToString() : "", true) + ", ");
                json.AppendLine("  render: $.fn.dataTable.render.moment(" + HttpUtility.JavaScriptStringEncode(this.DateFormat, true) + ")");
                json.AppendLine("}");
                return json.ToString();
            }
        }

        #endregion
    }
}
