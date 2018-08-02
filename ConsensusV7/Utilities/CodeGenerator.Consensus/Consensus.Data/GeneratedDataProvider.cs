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
    ///     Generates the dependency-injectable data provider.
    /// </summary>
    public class GeneratedDataProvider : TypeInterface
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the programmatic access of the repositories within the persistence mechanism."; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get { return (this.DataSource as DataDomain[]).Select(domain => this.ParentProject.ProjectNamespace + "." + domain.Name); }
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
            get { return "DataProvider"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                foreach (DataDomain domain in this.DataSource as DataDomain[])
                {
                    yield return new MemberProperty(this)
                    {
                        XmlSummary = "Gets the collection of repository instances which persist and retrieve data structures pertaining to " + domain.Description + ".",
                        MemberType = domain.Name + "RepositoryCollection",
                        MemberName = domain.Name,
                        GetAccessor = new MemberAccessor()
                    };
                }
            }
        }
    }
}
