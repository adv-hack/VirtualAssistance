using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class CSharpParameter
    {
        #region properties

        /// <summary>
        ///     Gets the name of the parameter.
        /// </summary>
        public String ParameterName { get; set; }

        /// <summary>
        ///     Gets the data type of the parameter.
        /// </summary>
        public String ParameterType { get; set; }

        /// <summary>
        ///     Gets or sets the reference keyword for the parameter.
        /// </summary>
        public CSharpReference ParameterReference { get; set; }

        /// <summary>
        ///     Gets the xml documentation summary for the parameter.
        /// </summary>
        public String XmlSummary { get; set; }

        #endregion
    }
}