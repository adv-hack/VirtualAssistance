using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     The toolbar item used to print the data displayed in the DataTable.
    /// </summary>
    public class DataTableToolPrint : DataTableTool
    {
        #region fields

        /// <summary>
        ///     The indices of the columns that can be exported.
        /// </summary>
        private IEnumerable<Int32> _columnIndices;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the indices of the columns that can be exported.
        /// </summary>
        public IEnumerable<Int32> ColumnIndices
        {
            get { return _columnIndices; }
            set { _columnIndices = value; }
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
                        extend: 'print',
                        exportOptions: {
                            stripHtml: false,
                            format: { body: window.consensus.web.dataTable.formatExport }" + (this.ColumnIndices == null ? "" : @",
                            columns: [" + String.Join(",", this.ColumnIndices) + "],") + @"
                        }
                    }";
            }
        }

        #endregion
    }
}
