using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class StoredProcFetchAll : GeneratedSqlProcedure
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
            get { return "spConsensus" + this.Entity.Container.ContainerName + this.Entity.ReferencedTable.ProgrammaticName + "FetchAll"; }
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
            }
        }

        #endregion

        #region constructors

        public StoredProcFetchAll(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
        }

        #endregion
    }
}
