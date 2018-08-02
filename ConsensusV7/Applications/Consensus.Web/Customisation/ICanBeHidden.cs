using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface ICanBeHidden : ICustomisationCapability
    {
        /// <summary>
        ///     Gets or sets whether the control is hidden.
        /// </summary>
        ConfigurableBoolean IsHidden { get; set; }
    }
}
