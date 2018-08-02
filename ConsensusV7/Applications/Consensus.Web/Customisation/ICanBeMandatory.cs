using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface ICanBeMandatory : ICustomisationCapability
    {
        /// <summary>
        ///     Gets or sets whether the control is mandatory.
        /// </summary>
        ScreenObjectRequirement Requirement { get; set; }
    }
}
