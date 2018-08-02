using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace Consensus.Web.Controls
{
    public class DataTableLinkColumn : DataTableColumn
    {
        #region fields

        /// <summary>
        ///     The text to display in the column.
        /// </summary>
        private String _linkText;

        /// <summary>
        ///     The url that the column is linked to.
        /// </summary>
        private String _linkHref;

        /// <summary>
        ///     The onclick event handler.
        /// </summary>
        private String _linkOnClick;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the text to display in the column.
        /// </summary>
        public String LinkText
        {
            get { return _linkText; }
            set { _linkText = value; }
        }

        /// <summary>
        ///    Gets or sets the 
        /// </summary>
        public String LinkHref
        {
            get { return _linkHref; }
            set { _linkHref = value == null ? null : value.StartsWith("~") ? VirtualPathUtility.ToAbsolute(value) : value; }
        }

        /// <summary>
        ///    Gets or sets the 
        /// </summary>
        public String LinkOnClick
        {
            get { return _linkOnClick; }
            set { _linkOnClick = value; }
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
                json.AppendLine("  title: " + HttpUtility.JavaScriptStringEncode(this.Title, true) + ", ");
                json.AppendLine("  tooltip: " + HttpUtility.JavaScriptStringEncode(this.Tooltip, true) + ", ");
                json.AppendLine("  orderable: " + this.Orderable.ToString().ToLower() + ", ");
                json.AppendLine("  visible: " + this.Visible.ToString().ToLower() + ",");
                json.AppendLine("  width: " + HttpUtility.JavaScriptStringEncode(this.Width.HasValue ? this.Width.Value.ToString() : "", true) + ", ");
                json.AppendLine("  render: function(data, type, row, meta) {");
                if (string.IsNullOrEmpty(this.LinkHref))
                    json.AppendLine("    var link = \"#\";");
                else
                    json.AppendLine("    var link = consensus.data.substitute(row, " + HttpUtility.JavaScriptStringEncode(this.LinkHref, true) + ");");
                json.AppendLine("    var text = consensus.data.substitute(row, " + HttpUtility.JavaScriptStringEncode(this.LinkText, true) + ");");
                if (string.IsNullOrEmpty(LinkOnClick))
                    json.AppendLine("    var click = \"\";");
                else
                    json.AppendLine("    var click = ' onclick=\"' + consensus.data.substitute(row, " + HttpUtility.JavaScriptStringEncode(this.LinkOnClick, true) + ") + '\"';");
                json.AppendLine("    return (text && text.length != 0) ? '<a href=\"' + link + '\"' + click + '>' + text + '</a>' : '';");
                json.AppendLine("  }, ");
                json.AppendLine("}");
                return json.ToString();
            }
        }

        #endregion
    }
}
