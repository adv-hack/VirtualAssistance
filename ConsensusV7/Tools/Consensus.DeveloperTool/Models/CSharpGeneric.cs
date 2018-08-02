using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consensus.CodeGenerator
{
    public class CSharpGeneric
    {
        #region properties

        /// <summary>
        ///     Gets or sets the name of the generic parameter.
        /// </summary 
        public String GenericName { get; set; }

        /// <summary>
        ///     Gets or sets the constraints applicable to the generic parameter.
        /// </summary>
        public String[] GenericConstraints { get; set; }

        /// <summary>
        ///     Gets the xml documentation summary for the generic parameter.
        /// </summary>
        public String XmlSummary { get; set; }

        #endregion
    }
}
