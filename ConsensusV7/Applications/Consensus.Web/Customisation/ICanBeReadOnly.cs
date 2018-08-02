using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface ICanBeReadOnly : ICustomisationCapability
    {
        /// <summary>
        ///     Gets or sets whether the control is readonly.
        /// </summary>
        ConfigurableBoolean IsReadOnly { get; set; }
    }
}
