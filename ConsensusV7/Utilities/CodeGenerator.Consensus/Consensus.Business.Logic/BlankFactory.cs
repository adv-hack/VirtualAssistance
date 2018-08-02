using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business.Logic
{
    public class BlankFactory : TypeClass
    {
        /// <summary>
        ///     Gets the underlying data source for this class
        /// </summary>
        public DataEntity Entity
        {
            get { return base.DataSource as DataEntity; }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "The locally-executed factory which instantiates the <see cref='" + this.Entity.CodeName + "Model' /> business model class."; }
        }

        /// <summary>
        ///     Gets whether the type will be generated.
        /// </summary>
        public override ProjectGeneration TypeGeneration
        {
            get { return ProjectGeneration.Missing; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                yield return "System.Linq";
            }
        }

        /// <summary>
        ///     Gets the sub-namespace for the type, relative to the project namespace.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Entity.CodeDomain.Name; }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public override CSharpModifier TypeModifier
        {
            get { return CSharpModifier.Public; }
        }

        /// <summary>
        ///     Gets whether the class definition is spread over multiple files.
        /// </summary>
        public override Boolean TypePartial
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return String.Format("Local{0}Factory", this.Entity.CodeName); }
        }
    }
}
