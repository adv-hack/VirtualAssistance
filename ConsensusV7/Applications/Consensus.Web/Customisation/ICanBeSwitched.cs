using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface ICanBeSwitched : ICustomisationCapability
    {
        /// <summary>
        ///    Gets or sets the text to display when the switch is on.
        /// </summary>
        String OnText { get; set; }

        /// <summary>
        ///    Gets or sets the bootstrap colour that is used when the switch is on.
        /// </summary>
        String OnColour { get; set; }

        /// <summary>
        ///    Gets or sets the text to display when the switch is off.
        /// </summary>
        String OffText { get; set; }

        /// <summary>
        ///    Gets or sets the bootstrap colour that is used when the switch is off.
        /// </summary>
        String OffColour { get; set; }
    }
}
