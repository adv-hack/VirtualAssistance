using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface ICustomFieldContainer : ICustomisationCapability
    {
        System.Web.UI.WebControls.Panel CustomFieldInsertPoint { get; }
        string Title { get; set; }
        // int[] CustomFieldColumnWidths { get; set; }
        bool BlockCustomFields { get; set; }
    }
}
