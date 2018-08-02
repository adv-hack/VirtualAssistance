using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class StoredProcFetchAllByColumn : GeneratedSqlProcedure
    {
        #region fields

        /// <summary>
        ///     The domain entity from which the repository is generated.
        /// </summary>
        private DomainEntity _entity;

        /// <summary>
        ///     The domain entity from which the repository is generated.
        /// </summary>
        private DomainTableColumn _column;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the domain entity from which the repository is generated.
        /// </summary>
        public DomainEntity Entity
        {
            get { return _entity; }
        }

        /// <summary>
        ///     Gets the domain entity from which the repository is generated.
        /// </summary>
        public DomainTableColumn Column
        {
            get { return _column; }
        }

        public override String ProcedureName
        {
            get { return "spConsensus" + this.Entity.Container.ContainerName + this.Entity.ReferencedTable.ProgrammaticName + "FetchAllBy" + this.Column.ProgrammaticName.ToPascal(); }
        }

        public override IEnumerable<SqlParameter> ProcedureParameters
        {
            get
            {
                yield return new SqlParameter() { ParameterName = this.Column.ParameterName, ParameterType = this.Column.ParameterType };
            }
        }

        public override String FileFolder
        {
            get
            {
                return Path.Combine(this.Project.FileFolder, "Procedures", this.Entity.Container.ContainerName);
            }
        }

        public override IEnumerable<String> ProcedureCode
        {
            get
            {
                yield return "select ";

                DomainTableColumn[] columns = this.Entity.ReferencedTable.TableColumns.Where(col => col.Exists).ToArray();
                foreach (DomainTableColumn column in columns)
                    yield return "  " + column.ColumnName + (column == columns.Last() ? "" : ",");

                yield return "from dbo." + this.Entity.ReferencedTable.TableName;
                yield return "where " + this.Column.ColumnName + " = " + this.Column.ParameterName;
            }
        }

        #endregion

        #region constructors

        public StoredProcFetchAllByColumn(GeneratedProject project, DomainEntity entity, DomainTableColumn column) : base(project)
        {
            _entity = entity;
            _column = column;
        }

        #endregion
    }
}
