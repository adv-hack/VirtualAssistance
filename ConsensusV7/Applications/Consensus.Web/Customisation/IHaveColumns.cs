using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface IHaveColumns : ICustomisationCapability
    {
        /// <summary>
        ///     Gets the list of columns for the table
        /// </summary>
        List<DataTableColumn> Columns
        {
            get;
        }
    }
}
