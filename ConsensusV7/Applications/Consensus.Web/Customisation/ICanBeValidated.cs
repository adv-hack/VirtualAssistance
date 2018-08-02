using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface ICanBeValidated : ICustomisationCapability
    {
        /// <summary>
        ///     Gets or sets the regular expression used to validate the field
        /// </summary>
        String ValidatorExpression { get; set; }

        /// <summary>
        ///     Gets or sets the message to display when the control value fails validation.
        /// </summary>
        String ValidatorMessage { get; set; }

        /// <summary>
        ///     Gets or sets whether the validation is deemed critical and should prevent data changes.
        /// </summary>
        Boolean ValidatorCritical { get; set; }
    }
}
