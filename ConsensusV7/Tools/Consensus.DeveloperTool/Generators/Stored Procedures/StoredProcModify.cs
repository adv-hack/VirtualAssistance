using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class StoredProcModify : GeneratedSqlProcedure
    {
        #region fields

        /// <summary>
        ///     The domain entity from which the repository is generated.
        /// </summary>
        private DomainEntity _entity;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the domain entity from which the repository is generated.
        /// </summary>
        public DomainEntity Entity
        {
            get { return _entity; }
        }

        public override String ProcedureName
        {
            get { return "spConsensus" + this.Entity.Container.ContainerName + this.Entity.ReferencedTable.ProgrammaticName + "Modify"; }
        }

        public override String FileFolder
        {
            get
            {
                return Path.Combine(this.Project.FileFolder, "Procedures", this.Entity.Container.ContainerName);
            }
        }

        public override IEnumerable<SqlParameter> ProcedureParameters
        {
            get
            {
                foreach (DomainTableColumn column in this.Entity.ReferencedTable.TableColumns)
                    if (!column.ColumnIsAuditor)
                        yield return new SqlParameter() { ParameterName = column.ParameterName, ParameterType = column.ParameterType };

                yield return new SqlParameter() { ParameterName = "@_AUDIT_USER_ID", ParameterDirection = ParameterDirection.Input, ParameterType = "varchar(3)" };
            }
        }

        public override IEnumerable<String> ProcedureCode
        {
            get
            {
                // Define the update audit columns
                yield return "update dbo." + this.Entity.ReferencedTable.TableName + " set";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "MOD_DATE"))
                    yield return "  " + this.Entity.ReferencedTable.TablePrefix + "MOD_DATE = getDate(),";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "MOD_BY"))
                    yield return "  " + this.Entity.ReferencedTable.TablePrefix + "MOD_BY = @_AUDIT_USER_ID,";
                
                // Define the update data columns
                DomainTableColumn[] columns = this.Entity.ReferencedTable.TableColumns.Where(column => column != column.Table.TableKey && !column.ColumnIsAuditor).ToArray();
                foreach (DomainTableColumn column in columns)
                    yield return "  " + column.ColumnName + " = " + column.ParameterName + (column == columns.Last() ? "" : ",");

                // Append the where clause
                yield return "where " + this.Entity.ReferencedTable.TableKey.ColumnName + " = " + this.Entity.ReferencedTable.TableKey.ParameterName + ";";
            }
        }

        #endregion

        #region constructors

        public StoredProcModify(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
        }

        #endregion
    }
}
