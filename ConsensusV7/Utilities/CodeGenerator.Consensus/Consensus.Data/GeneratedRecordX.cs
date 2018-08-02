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
    ///     Generates the record class that provides a POCO (plain-old-csharp-object) to represent each entity within the data model.
    /// </summary>
    public class GeneratedRecordX : TypeClass
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
            get { return (this.DataSource as DataEntity).CodeDescription; }
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
            get { return (this.DataSource as DataEntity).CodeName + "Record"; }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return "Record<" + (this.DataSource as DataEntity).KeyField.CodeTypeName + ">"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "Cloneable<" + (this.DataSource as DataEntity).CodeName + "Record>";
                yield return "IEquatable<" + (this.DataSource as DataEntity).CodeName + "Record>";
            }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                DataEntity entity = this.DataSource as DataEntity;

                List<String> cloneCode = new List<String>();
                cloneCode.Add(this.DeclarationName + " record = new " + this.DeclarationName + "();");

                List<String> equalCode = new List<String>();
                foreach (DataEntityField field in entity.Fields)
                {
                    cloneCode.Add("record." + (field == entity.KeyField ? "Id" : field.ObjectShortName) + " = this." + (field == entity.KeyField ? "Id" : field.ObjectShortName) + ";");
                    equalCode.Add("if (this." + (field == entity.KeyField ? "Id" : field.ObjectShortName) + " != that." + (field == entity.KeyField ? "Id" : field.ObjectShortName) + ")");
                    equalCode.Add("    return false;");
                }
                cloneCode.Add("return record;");
                equalCode.Add("");
                equalCode.Add("return true;");

                foreach (DataEntityField field in entity.Fields.Where(f => f != entity.KeyField))
                {
                    yield return new MemberField(this)
                    {
                        XmlSummary = "The value of the " + field.ObjectName + " field.",
                        MemberModifier = CSharpModifier.Public,
                        MemberName = field.ObjectShortName,
                        MemberType = field.CodeTypeName
                    };
                }

                yield return new MemberMethod(this) 
                {
                    XmlSummary = "Creates a new <see cref='" + this.DeclarationName + "' /> object instance that is a shallow-copy of the current object instance.",
                    XmlReturns = "The shallow-copy of the current <see cref='" + this.DeclarationName + "' /> object instance.",
                    MemberModifier = CSharpModifier.Public,
                    MemberType = this.DeclarationName,
                    MemberName = "Clone",
                    Code = cloneCode.ToArray()
                };
                
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Indicates whether the current <see cref='" + this.DeclarationName + "' /> instance is equal to another <see cref='" + this.DeclarationName + "' /> instance.",
                    XmlReturns = "True if both instances are considered equal; otherwise, false.",
                    MemberModifier = CSharpModifier.Public,
                    MemberType = "Boolean",
                    MemberName = "Equals",
                    MemberParameters = new MemberParameter[]
                    { 
                        new MemberParameter()
                        {
                            MemberType = this.DeclarationName,
                            MemberName = "that",
                            XmlSummary = "The <see cref='" + this.DeclarationName + "' /> instance to be compared against this instance."
                        }
                    },
                    Code = equalCode.ToArray()
                };
            }
        }
    }
}
