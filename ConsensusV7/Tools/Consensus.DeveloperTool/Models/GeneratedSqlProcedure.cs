using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class GeneratedSqlProcedure : GeneratedSqlScript
    {
        #region properties

        public abstract String ProcedureName
        {
            get;
        }

        public override String FileName
        {
            get { return this.ProcedureName; }
        }

        public virtual IEnumerable<SqlParameter> ProcedureParameters
        {
            get { return null; }
        }

        public virtual IEnumerable<String> ProcedureCode
        {
            get { return null; }
        }

        public override String SqlScript
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("if not exists (select object_id from sys.objects where type = 'P' and name = '" + this.ProcedureName + "')");
                builder.AppendLine("  exec ('create procedure dbo." + this.ProcedureName + " as select 1 as temp')");
                builder.AppendLine("go");
                builder.Append("alter procedure dbo." + this.ProcedureName);
                if (this.ProcedureParameters != null && this.ProcedureParameters.Any())
                    builder.Append("(" + String.Join(", ", this.ProcedureParameters.Select(param => param.ParameterName + " " + param.ParameterType + " = null" + (param.ParameterDirection == ParameterDirection.Input ? "" : " output"))) + ")");
                builder.AppendLine(" as ");
                builder.AppendLine("begin");
                if (this.ProcedureCode != null && this.ProcedureCode.Any())
                    foreach (String procedureCode in this.ProcedureCode)
                        builder.AppendLine("  " + procedureCode);
                builder.AppendLine("end");
                builder.AppendLine("go");
                return builder.ToString();
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="GeneratedSqlProcedure" /> instance.
        /// </summary>
        /// <param name="taskList">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        public GeneratedSqlProcedure(GeneratedProject project) : base(project)
        {
        }

        #endregion
    }
}
