using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web
{
    public interface IHaveCodeItems : ICustomisationCapability
    {
        /// <summary>
        ///     Gets or sets the type of the code that is displayed in the list.
        /// </summary>
        String CodeType
        {
            get;
            set;
        }
    }
}
