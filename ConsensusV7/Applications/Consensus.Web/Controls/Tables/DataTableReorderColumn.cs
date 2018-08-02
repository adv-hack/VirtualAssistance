using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Consensus.Web.Controls
{
    public class DataTableReorderColumn : DataTableColumn
    {
        #region fields
        
        #endregion

        #region properties

        /// <summary>
        ///     Gets the name of the field that is displayed.
        /// </summary>
        public String FieldName { get; set; }

        public string ModelFieldName { get; set; }
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
                json.AppendLine("  orderable: " + this.Orderable.ToString().ToLower() + ", ");
                json.AppendLine("  visible: " + this.Visible.ToString().ToLower() + ",");
                json.AppendLine("  title: " + HttpUtility.JavaScriptStringEncode(this.Title, true) + ", ");
                json.AppendLine("  tooltip: " + HttpUtility.JavaScriptStringEncode(this.Tooltip, true) + ", ");
                json.AppendLine("  width: " + HttpUtility.JavaScriptStringEncode(this.Width.HasValue ? this.Width.Value.ToString() : "", true));
                json.AppendLine("}");
                return json.ToString();
            }
        }

        #endregion
    }
}
