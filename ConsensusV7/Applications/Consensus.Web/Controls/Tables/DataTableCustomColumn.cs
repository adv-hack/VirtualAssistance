using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace Consensus.Web.Controls
{
    public class DataTableCustomColumn : DataTableColumn
    {
        internal override String Definition
        {
            get
            {
                LiteralControl literal = this.Controls.OfType<LiteralControl>().FirstOrDefault();
                StringBuilder json = new StringBuilder();
                json.AppendLine("{");
                json.AppendLine("  class: \"" + this.CssClass + "\", ");
                json.AppendLine("  title: " + HttpUtility.JavaScriptStringEncode(this.Title, true) + ", ");
                json.AppendLine("  orderable: " + this.Orderable.ToString().ToLower() + ", ");
                json.AppendLine("  tooltip: " + HttpUtility.JavaScriptStringEncode(this.Tooltip, true) + ", ");
                json.AppendLine("  visible: " + this.Visible.ToString().ToLower() + ",");
                json.AppendLine("  width: " + HttpUtility.JavaScriptStringEncode(this.Width.HasValue ? this.Width.Value.ToString() : "", true) + ", ");
                json.AppendLine("  render: function(data, type, row, meta) {");
                json.AppendLine("    " + (literal == null ? null : literal.Text));
                json.AppendLine("  }");
                json.AppendLine("}");
                return json.ToString();
            }
        }
    }
}
