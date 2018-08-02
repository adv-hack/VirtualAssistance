using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class SqlEntityFetchById : GeneratedSqlProcedure
    {
        public override String ProcedureName
        {
            get { return "spConsensusContactPersonFetchById"; }
        }
    }
}
