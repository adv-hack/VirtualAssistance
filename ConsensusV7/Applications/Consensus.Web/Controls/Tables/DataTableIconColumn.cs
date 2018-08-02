using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Consensus.Web.Controls
{
    public class DataTableIconColumn : DataTableTextColumn
    {
        #region fields

        /// <summary>
        ///     The icon displayed when the value is true.
        /// </summary>
        private String _trueIcon;

        /// <summary>
        ///     The tooltip displayed when the value is true.
        /// </summary>
        private String _trueTooltip;

        /// <summary>
        ///     The CSS class used when the value is true.
        /// </summary>
        private String _trueClass;

        /// <summary>
        ///     The icon displayed when the value is false.
        /// </summary>
        private String _falseIcon;

        /// <summary>
        ///     The tooltip displayed when the value is false.
        /// </summary>
        private String _falseTooltip;

        /// <summary>
        ///     The CSS class used when the value is false.
        /// </summary>
        private String _falseClass;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the icon displayed when the value is true.
        /// </summary>
        public String TrueIcon
        {
            get { return _trueIcon ?? "icons8-checkmark"; }
            set { _trueIcon = value.TrimOrNullify(); }
        }

        /// <summary>
        ///    Gets or sets the tooltip displayed when the value is true.
        /// </summary>
        public String TrueTooltip
        {
            get { return _trueTooltip; }
            set { _trueTooltip = value.TrimOrNullify(); }
        }

        /// <summary>
        ///    Gets or sets the CSS class used when the value is true.
        /// </summary>
        public String TrueClass
        {
            get { return _trueClass; }
            set { _trueClass = value.TrimOrNullify(); }
        }

        /// <summary>
        ///    Gets or sets the icon displayed when the value is false.
        /// </summary>
        public String FalseIcon
        {
            get { return _falseIcon ?? "icons8-delete_sign"; }
            set { _falseIcon = value.TrimOrNullify(); }
        }

        /// <summary>
        ///    Gets or sets the tooltip displayed when the value is false.
        /// </summary>
        public String FalseTooltip
        {
            get { return _falseTooltip; }
            set { _falseTooltip = value.TrimOrNullify(); }
        }

        /// <summary>
        ///    Gets or sets the CSS class used when the value is false.
        /// </summary>
        public String FalseClass
        {
            get { return _falseClass; }
            set { _falseClass = value.TrimOrNullify(); }
        }

        /// <summary>
        ///     Gets the client-side definition of the column.
        /// </summary>
        internal override String Definition
        {
            get
            {
                StringBuilder json = new StringBuilder();
                json.AppendLine("{");
                json.AppendLine("  class: \"" + this.CssClass + "\", ");
                json.AppendLine("  title: " + HttpUtility.JavaScriptStringEncode(this.Title, true) + ", ");
                json.AppendLine("  tooltip: " + HttpUtility.JavaScriptStringEncode(this.Tooltip, true) + ", ");
                json.AppendLine("  visible: " + this.Visible.ToString().ToLower() + ",");
                json.AppendLine("  orderable: " + this.Orderable.ToString().ToLower() + ", ");
                json.AppendLine("  width: " + HttpUtility.JavaScriptStringEncode(this.Width.HasValue ? this.Width.Value.ToString() : "", true) + ", ");
                json.AppendLine("  render: function(data, type, row, meta) {");
                json.AppendLine("    var inputValue = consensus.data.getValue(row, " + HttpUtility.JavaScriptStringEncode(this.FieldName, true) + ");");
                json.AppendLine("    var parseValue = (typeof(inputValue) != 'undefined' && inputValue != null && inputValue != 0 && inputValue != '0' && inputValue.toString().toLowerCase() != 'no' && inputValue.toString().toLowerCase() != 'false');");
                json.AppendLine("    var tooltipVal = consensus.data.substitute(row, parseValue ? " + HttpUtility.JavaScriptStringEncode(this.TrueTooltip, true) + " : " + HttpUtility.JavaScriptStringEncode(this.FalseTooltip, true) + ");");
                json.Append("    var result = $('<i />')");
                json.Append(String.Format(".addClass(parseValue ? {0} : {1})", HttpUtility.JavaScriptStringEncode(this.TrueIcon, true), HttpUtility.JavaScriptStringEncode(this.FalseIcon, true)));
                json.Append(String.Format(".addClass(parseValue ? {0} : {1})", HttpUtility.JavaScriptStringEncode(this.TrueClass, true), HttpUtility.JavaScriptStringEncode(this.FalseClass, true)));
                json.AppendLine(".attr(\"title\", tooltipVal);");
                json.AppendLine("    return result[0].outerHTML;");
                json.AppendLine("  }");
                json.AppendLine("}");
                return json.ToString();
            }
        }

        #endregion
    }
}
