using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business
{
    public class BlankProxy : TypeClass
    {
        /// <summary>
        ///     The data entity which drives the generation of this class.
        /// </summary>
        public DataEntity Entity
        {
            get { return this.DataSource as DataEntity; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {

                IEnumerable<String> referencedDomains = this.Entity.Fields
                    .Where(field => field.RelatedEntity != null)
                    .Where(field => field.RelatedEntity.CodeDomain != null)
                    .Where(field => !field.RelatedEntity.CodeDomain.Name.Equals(this.Entity.CodeDomain.Name, StringComparison.Ordinal))
                    .Where(field => !field.RelatedEntity.CodeDomain.Name.StartsWith(this.Entity.CodeDomain.Name + '.'))
                    .Select(field => field.RelatedEntity.CodeDomain.Name)
                    .Distinct();

                yield return "System.Linq";
                foreach (String domain in referencedDomains)
                    yield return this.ParentProject.ProjectNamespace + "." + domain;
            }
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
            get { return String.Format("{0}", this.Entity.CodeName); }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return String.Format("Proxy<{0}Model, {1}>", this.Entity.CodeName, this.Entity.KeyField.CodeTypeName); }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return String.Format("{0}Model", this.Entity.CodeName); }
        }
        
        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                // Return the required constructor
                yield return new MemberConstructor(this)
                {
                    XmlSummary = "Initialises a new instance of the client-consumable class.",
                    MemberModifier = CSharpModifier.Protected,
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter() 
                        { 
                            XmlSummary = "Sets underlying business model which is encapsulated by this consumable client class.",
                            MemberType = this.Entity.CodeName + "Model",
                            MemberName = "model",
                        }
                    },
                    MemberInvocation = "model"
                };
            }
        }
    }
}
