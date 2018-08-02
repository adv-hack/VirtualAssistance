using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Consensus.Web
{
    public interface IHaveListItems : ICustomisationCapability
    {
        /// <summary>
        ///     Gets the items displayed in this list.
        /// </summary>
        ListItemCollection Items
        {
            get;
        }

        /// <summary>
        ///     Gets whether the control is driven by an external datasource.
        /// </summary>
        Boolean HasDataSource
        {
            get;
        }
    }
}
