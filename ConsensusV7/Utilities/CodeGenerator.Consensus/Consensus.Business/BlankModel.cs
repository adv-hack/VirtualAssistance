using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business
{
    public class BlankModel : TypeInterface
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
            get { return "Represents " + this.Entity.CodeDescription; }
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
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return String.Format("{0}Model", this.Entity.CodeName); }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return String.Format("Model<{0}>", this.Entity.KeyField.CodeTypeName); }
        }
    }
}
