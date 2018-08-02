using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface IHaveCustomTitle : ICustomisationCapability
    {
        /// <summary>
        ///     Gets or sets the title or display text for the control.
        /// </summary>
        String Title { get; set; }
    }
}
