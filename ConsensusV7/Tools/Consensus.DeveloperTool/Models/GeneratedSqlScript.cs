using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class GeneratedSqlScript : GeneratedProjectItem
    {
        #region properties

        public override String FileExtension
        {
            get { return "sql"; }
        }
        
        public override GeneratedProjectAction TaskAction
        {
            get { return GeneratedProjectAction.None; }
        }

        public abstract String SqlScript
        {
            get;
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="GeneratedSqlScript" /> instance.
        /// </summary>
        /// <param name="taskList">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        public GeneratedSqlScript(GeneratedProject project) : base(project)
        {
        }

        #endregion

        #region methods

        protected override void GenerateContent(StreamWriter writer)
        {
            writer.Write(this.SqlScript);
        }

        #endregion
    }
}
