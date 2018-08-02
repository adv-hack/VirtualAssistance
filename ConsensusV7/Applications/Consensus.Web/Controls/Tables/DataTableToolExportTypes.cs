using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web.Controls
{
    public enum DataTableToolExportTypes
    {
        /// <summary>
        ///     Exports to Excel
        /// </summary>
        Excel,

        /// <summary>
        ///     Exports to PDF
        /// </summary>
        PDF,
        
        /// <summary>
        ///     Exports to CSV
        /// </summary>
        CSV,

        /// <summary>
        ///     Exports to the clipboard
        /// </summary>
        Copy,
    }
}
