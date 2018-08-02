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
    ///     Generates the repository collection interface for each domain within the data model.
    /// </summary>
    public class GeneratedRepositoryCollectionX : TypeInterface
    {
        /// <summary>
        ///     Gets the sub-namespace for the type, relative to the project namespace.
        /// </summary>
        public override String TypeNamespace
        {
            get { return (this.DataSource as DataDomain).Name; }
        }

        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Represents the collection of repository instances which persist and retrieve data structures pertaining to " + (this.DataSource as DataDomain).Description + "."; }
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
            get { return (this.DataSource as DataDomain).Name + "RepositoryCollection"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "RepositoryCollection"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                foreach (DataEntity entity in (this.DataSource as DataDomain).Entities)
                {
                    yield return new MemberProperty(this)
                    {
                        XmlSummary = "Gets the repository which persists and retrieves instances of the <see cref='" + entity.CodeName + "Record' /> data structure.",
                        MemberType = entity.CodeName + "Repository",
                        MemberName = entity.CodeName,
                        GetAccessor = new MemberAccessor()
                    };
                }
            }
        }
    }
}
