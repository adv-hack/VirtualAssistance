using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class StoredProcCreate : GeneratedSqlProcedure
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
            get { return "spConsensus" + this.Entity.Container.ContainerName + this.Entity.ReferencedTable.ProgrammaticName + "Create"; }
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
                String name = this.Name;

                // Obtain the primary key allocation
                if (this.Entity.ReferencedTable.TableKeyAllocation != null)
                {
                    yield return "exec spNextID " + this.Entity.ReferencedTable.TableKeyAllocation.ConvertTo<String>() + ", " + this.Entity.ReferencedTable.TableKey.ParameterName + " output";
                    yield return "";
                }
                else if (this.Entity.ReferencedTable.TableKey.ColumnType == DomainDataType.Guid)
                {
                    yield return "set " + this.Entity.ReferencedTable.TableKey.ParameterName + " = newid();";
                    yield return "";
                }

                // Define the insert key column
                yield return "insert into dbo." + this.Entity.ReferencedTable.TableName + "(";
                if (this.Entity.ReferencedTable.TableKeyAllocation != null || this.Entity.ReferencedTable.TableKey.ColumnType == DomainDataType.Guid)
                    yield return "  " + this.Entity.ReferencedTable.TableKey.ColumnName + ",";

                // Append the insert audit columns
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "ADD_DATE"))
                    yield return "  " + this.Entity.ReferencedTable.TablePrefix + "ADD_DATE,";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "ADD_BY"))
                    yield return "  " + this.Entity.ReferencedTable.TablePrefix + "ADD_BY,";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "MOD_DATE"))
                    yield return "  " + this.Entity.ReferencedTable.TablePrefix + "MOD_DATE,";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "MOD_BY"))
                    yield return "  " + this.Entity.ReferencedTable.TablePrefix + "MOD_BY,";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "RCV_DATE"))
                    yield return "  " + this.Entity.ReferencedTable.TablePrefix + "RCV_DATE,";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "RCV_BY"))
                    yield return "  " + this.Entity.ReferencedTable.TablePrefix + "RCV_BY,";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "RCV_FROM"))
                    yield return "  " + this.Entity.ReferencedTable.TablePrefix + "RCV_FROM,";
                
                // Define the insert data columns
                DomainTableColumn[] columns = this.Entity.ReferencedTable.TableColumns.Where(column => column != column.Table.TableKey && !column.ColumnIsAuditor).ToArray();
                foreach (DomainTableColumn column in columns)
                    yield return "  " + column.ColumnName + (column == columns.Last() ? "" : ",");

                // Define the insert key value
                yield return ") values (";
                if (this.Entity.ReferencedTable.TableKeyAllocation != null || this.Entity.ReferencedTable.TableKey.ColumnType == DomainDataType.Guid)
                    yield return "  " + this.Entity.ReferencedTable.TableKey.ParameterName + ",";

                // Append the insert audit values
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "ADD_DATE"))
                    yield return "  getDate(),";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "ADD_BY"))
                    yield return "  @_AUDIT_USER_ID,";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "MOD_DATE"))
                    yield return "  getDate(),";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "MOD_BY"))
                    yield return "  @_AUDIT_USER_ID,";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "RCV_DATE"))
                    yield return "  getDate(),";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "RCV_BY"))
                    yield return "  '',";
                if (this.Entity.ReferencedTable.TableColumns.Any(column => column.ColumnName == this.Entity.ReferencedTable.TablePrefix + "RCV_FROM"))
                    yield return "  '',";

                // Define the insert data values
                foreach (DomainTableColumn column in columns)
                    if (this.Entity.ReferencedTable.TableKeyAllocation != null || column != this.Entity.ReferencedTable.TableKey)
                        yield return "  " + column.ParameterName + (column == columns.Last() ? "" : ",");
                
                yield return ");";

                // Ensure that the procedure returns the ID of the new record back to the data access layer
                if (this.Entity.ReferencedTable.TableKeyAllocation == null && this.Entity.ReferencedTable.TableKey.ColumnType != DomainDataType.Guid)
                    yield return "  set " + this.Entity.ReferencedTable.TableKey.ParameterName + " = @@identity;";
            }
        }

        #endregion

        #region constructors

        public StoredProcCreate(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
        }

        #endregion
    }
}
