using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class StoredProcRemoveById : GeneratedSqlProcedure
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
            get { return "spConsensus" + this.Entity.Container.ContainerName + this.Entity.ReferencedTable.ProgrammaticName + "RemoveById"; }
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
                yield return new SqlParameter() { ParameterName = this.Entity.ReferencedTable.TableKey.ParameterName, ParameterType = this.Entity.ReferencedTable.TableKey.ParameterType };
            }
        }

        public override IEnumerable<String> ProcedureCode
        {
            get
            {
                yield return "delete ";
                yield return "from dbo." + this.Entity.ReferencedTable.TableName;
                yield return "where " + this.Entity.ReferencedTable.TableKey.ColumnName + " = " + this.Entity.ReferencedTable.TableKey.ParameterName;
            }
        }

        #endregion

        #region constructors

        public StoredProcRemoveById(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
        }

        #endregion
    }
}
