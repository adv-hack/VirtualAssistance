using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class SqlParameter
    {
        /// <summary>
        ///     Gets or sets the data type of the parameter.
        /// </summary>
        public String ParameterType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the name of the parameter
        /// </summary>
        public String ParameterName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the direction of the parameter
        /// </summary>
        public ParameterDirection ParameterDirection
        {
            get;
            set;
        }
    }
}
