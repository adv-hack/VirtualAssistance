using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface IHaveDefaultValue : ICustomisationCapability
    {
        /// <summary>
        ///     Gets or sets the default value to be applied when a new record is created.
        /// </summary>
        Object DefaultValue { get; set; }
    }
}
