using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.SqlModel
{
    public abstract class Procedure : ProjectItem
    {
        /// <summary>
        ///     Gets the build action for the type.
        /// </summary>
        public override ProjectBuildAction BuildAction
        {
            get { return ProjectBuildAction.None; }
        }

        /// <summary>
        ///     Gets the name of the file that this file is nested under.
        /// </summary>
        public override sealed String FileNesting
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the name of the file.
        /// </summary>
        public override String FileName
        {
            get { return String.Format("{0}.sql", this.ProcedureName); }
        }

        /// <summary>
        ///     Gets the name of the stored procedure.
        /// </summary>
        public abstract String ProcedureName { get; }

        /// <summary>
        ///     Gets the parameters for the stored procedure.
        /// </summary>
        public virtual IEnumerable<ProcedureParameter> ProcedureParameters
        {
            get { return null; }
        }

        /// <summary>
        ///     Generates the body of the procedure
        /// </summary>
        public abstract void GenerateContent(StringBuilder output);

        /// <summary>
        ///     Generates the code for the runtime type and appends the code to the specified string builder
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected override void Generate(StringBuilder output)
        {
            output.AppendLine("if not exists (select object_id from sys.objects where name = '" + this.ProcedureName + "' and type = 'p')");
            output.AppendLine("  exec ('create procedure dbo." + this.ProcedureName + " as select 1 as temp')");
            output.AppendLine("go");
            output.AppendLine();
            output.Append("alter procedure dbo." + this.ProcedureName);

            if (this.ProcedureParameters != null && this.ProcedureParameters.Count() > 0)
            {
                output.Append("(");
                output.Append(String.Join(", ", this.ProcedureParameters.Select(Procedure.Generate)));
                output.Append(")");
            }
            output.AppendLine(" as ");
            this.GenerateContent(output);
            output.AppendLine("go");
        }

        /// <summary>
        ///     Generates the parameter definition for the specified parameter
        /// </summary>
        private static String Generate(ProcedureParameter parameter)
        {
            StringBuilder output = new StringBuilder();
            output.Append(parameter.Name);
            output.Append(" ");
            output.Append(parameter.Type);
            if (parameter.DefaultValue != null)
                output.Append(" = " + parameter.DefaultValue);
            if (parameter.Direction == ParameterDirection.Output || parameter.Direction == ParameterDirection.InputOutput)
                output.Append(" output");

            return output.ToString();
        }
    }
}
