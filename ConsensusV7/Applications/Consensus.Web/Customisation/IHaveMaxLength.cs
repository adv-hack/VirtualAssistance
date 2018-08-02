using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface IHaveMaxLength : ICustomisationCapability
    {
        /// <summary>
        ///     Gets or sets the maximum number of characters that can be entered into the field.
        /// </summary>
        Int32 MaximumLength { get; set; }
    }
}
