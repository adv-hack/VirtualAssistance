using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace Consensus.Web.Controls
{
    [ParseChildren(true)]
    public class DataTableButtonColumn : DataTableColumn
    {
        #region fields

        /// <summary>
        ///    The collection of buttons displayed in the column.
        /// </summary>
        private List<DataTableButtonColumnItem> _buttons;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the collection of buttons displayed in the column.
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public List<DataTableButtonColumnItem> Buttons
        {
            get
            {
                if (_buttons == null)
                    _buttons = new List<DataTableButtonColumnItem>();

                return _buttons;
            }
            set
            {
                _buttons = value;
            }
        }

        /// <summary>
        ///    Gets or sets whether the column is exportable.
        /// </summary>
        public override Boolean Exportable
        {
            get { return false; }
            set { base.Exportable = value; }
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
                json.AppendLine("  data: null, ");
                json.AppendLine("  class: \"datatable-buttons " + this.CssClass + "\", ");
                json.AppendLine("  orderable: " + this.Orderable.ToString().ToLower() + ", ");
                json.AppendLine("  defaultContent: \"" + String.Join(" ", this.Buttons.Select(button => button.Definition)) + "\", ");
                json.AppendLine("  width: " + HttpUtility.JavaScriptStringEncode(this.Width.HasValue ? this.Width.Value.ToString() : "", true));
                json.AppendLine("}");
                return json.ToString();
            }
        }

        #endregion
    }
}
