using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.SqlModel
{
    public class ProcedureParameter
    {
        /// <summary>
        ///     Gets or sets the name of parameter
        /// </summary>
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the type of parameter
        /// </summary>
        public String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the default value for parameter
        /// </summary>
        public String DefaultValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the direction of the parameter
        /// </summary>
        public ParameterDirection Direction
        {
            get;
            set;
        }
    }
}
