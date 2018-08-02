using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface IHaveCustomIcon : ICustomisationCapability
    {
        /// <summary>
        ///     Gets or sets the display icon for the control.
        /// </summary>
        String Icon { get; set; }
    }
}
