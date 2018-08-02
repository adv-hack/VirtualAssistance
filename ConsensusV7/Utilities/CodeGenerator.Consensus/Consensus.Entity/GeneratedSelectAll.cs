using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGenerator.CodeModel;
using CodeGenerator.SqlModel;
using CodeGenerator.DataModel;

namespace CodeGenerator.Consensus.Entity
{
    public class GeneratedSelectAll : Procedure
    {
        /// <summary>
        ///     Gets the data source used to construct the procedure
        /// </summary>
        public new DataEntity DataSource
        {
            get { return base.DataSource as DataEntity; }
            set { base.DataSource = value; }
        }

        /// <summary>
        ///     Gets the folder in which the file is stored.
        /// </summary>
        public override String FileFolder
        {
            get { return String.Format("Procedures\\{0}\\{1}", this.DataSource.CodeDomain.Name.ToPascal(), this.DataSource.CodeName.ToPascal()); }
        }

        /// <summary>
        ///     Gets the name of the stored procedure.
        /// </summary>
        public override String ProcedureName
        {
            get { return String.Format("spCon{1}Select", this.DataSource.CodeDomain.Name.ToPascal(), this.DataSource.CodeName.ToPascal()); }
        }

        /// <summary>
        ///     Generates the body of the procedure
        /// </summary>
        public override void GenerateContent(StringBuilder output)
        {
            output.AppendLine("begin");
            output.AppendLine();
            output.AppendLine("    select");
            output.Append("      ");
            output.AppendLine(String.Join("," + Environment.NewLine + "      ", this.DataSource.Fields.Select(field => field.ObjectName)));
            output.AppendLine("    from dbo." + this.DataSource.ObjectName);
            output.AppendLine();
            output.AppendLine("end");
        }
    }
}
