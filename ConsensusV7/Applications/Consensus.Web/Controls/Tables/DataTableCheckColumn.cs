using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Consensus.Web.Controls
{
    public class DataTableCheckColumn : DataTableTextColumn
    {
        #region properties

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
                json.AppendLine("  orderable: " + this.Orderable.ToString().ToLower() + ", ");
                json.AppendLine("  visible: " + this.Visible.ToString().ToLower() + ",");
                json.AppendLine("  width: " + HttpUtility.JavaScriptStringEncode(this.Width.HasValue ? this.Width.Value.ToString() : "", true) + ", ");
                json.AppendLine("  render: function(data, type, row, meta) {");
                json.AppendLine("    var checkGuid = 'check_' + consensus.data.guid();");
                json.AppendLine("    var inputValue = consensus.data.getValue(row, " + HttpUtility.JavaScriptStringEncode(this.FieldName, true) + ");");
                json.AppendLine("    var parseValue = (typeof(inputValue) != 'undefined' && inputValue != null && inputValue != 0 && inputValue != '0' && inputValue.toString().toLowerCase() != 'no' && inputValue.toString().toLowerCase() != 'false');");
                json.AppendLine("    var checkField = $('<input />').addClass('stylised').attr('checked', parseValue ? 'checked' : null).attr('id', checkGuid).attr('onclick', 'window.consensus.web.dataTable.toggle(this, " + HttpUtility.JavaScriptStringEncode(this.FieldName, true) + ");').attr('type', 'checkbox');");
                json.AppendLine("    var labelField = $('<label />').attr('for', checkGuid);");
                json.AppendLine("    return $('<div />').append(checkField).append(labelField).html();");
                json.AppendLine("  }");
                json.AppendLine("}");
                return json.ToString();
            }
        }

        #endregion
    }
}
