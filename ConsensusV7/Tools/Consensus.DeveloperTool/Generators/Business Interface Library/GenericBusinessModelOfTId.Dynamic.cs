using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class GenericBusinessModelOfTIdDynamic : GeneratedInterface
    {
        #region fields

        /// <summary>
        ///     The domain within which the interface is defined.
        /// </summary>
        private Domain _domain;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the domain within which the interface is defined.
        /// </summary>
        public Domain Domain
        {
            get { return _domain; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Defines the members that have been exposed by a business model instance, which implements the standardised rules for the " + this.Domain.DomainName + " solution."; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlRemarks
        {
            get { return "THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.\r\nDO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION."; }
        }

        /// <summary>
        ///     Gets the name of the generated file.
        /// </summary>
        public override String FileName
        {
            get { return base.FileName + ".gen"; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                yield return "System.Collections.Generic";
                yield return "System.Data";
                yield return "System.Data.Common";
                yield return "System.Linq";
            }
        }

        /// <summary>
        ///     Gets the generic parameters for the type.
        /// </summary>
        public override IEnumerable<CSharpGeneric> TypeGenerics
        {
            get
            {
                yield return new CSharpGeneric()
                {
                    XmlSummary = "The data type of the unique id which distinctly identifies the instance of the business model.",
                    GenericName = "TId",
                    GenericConstraints = new String[] { "IComparable<TId>", "IEquatable<TId>" }
                };
            }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "IModel";
            }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "IModel"; }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the unique id which distinctly identifies the instance of the business model.",
                    PropertyType = "TId",
                    Name = "Id",
                    PropertyGetter = new CSharpAccessor(),
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="GenericDataRepositoryDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public GenericBusinessModelOfTIdDynamic(GeneratedProject project, Domain domain) : base(project)
        {
            _domain = domain;
        }

        #endregion
    }
}
