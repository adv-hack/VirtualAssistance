using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Data
{
    /// <summary>
    ///     Generates the repository interface for each entity within the data model.
    /// </summary>
    public class BlankRepository : TypeInterface
    {
        /// <summary>
        ///     Gets the sub-namespace for the type, relative to the project namespace.
        /// </summary>
        public override String TypeNamespace
        {
            get { return (this.DataSource as DataEntity).CodeDomain.Name; }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the persistence and retrieval operations that relate to the <see cref='" + (this.DataSource as DataEntity).CodeName + "Record' /> data structure."; }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public override CSharpModifier TypeModifier
        {
            get { return CSharpModifier.Public; }
        }

        /// <summary>
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return (this.DataSource as DataEntity).CodeName + "Repository"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "Repository<" + (this.DataSource as DataEntity).CodeName + "Record, " + (this.DataSource as DataEntity).KeyField.CodeTypeName + ">"; }
        }
    }
}
