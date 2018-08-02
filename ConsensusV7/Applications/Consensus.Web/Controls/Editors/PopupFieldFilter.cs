using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web.Controls
{
    public class PopupFieldFilter
    {
        /// <summary>
        ///     Gets or sets the name of the URL parameter that is passed into the popup url.
        /// </summary>
        public String ParameterName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the type of filter to be applied
        /// </summary>
        public PopupFieldFilterTypes Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the filter or the ID of the control to filter on.
        /// </summary>
        public String Value
        {
            get;
            set;
        }
    }
}
