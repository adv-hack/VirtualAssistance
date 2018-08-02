using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Defines the attribute that is rendered for each item within a list control.
    /// </summary>
    public class ListAttribute : Control
    {
        /// <summary>
        ///     The name of the attribute
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        ///     The data-bound value of the attribute
        /// </summary>
        public String Value { get; set; }
    }
}
