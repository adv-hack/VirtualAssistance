using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Data.SqlServer
{
    /// <summary>
    ///     Generates the repository class for each entity within the data model.
    /// </summary>
    public class GeneratedRepositoryX : TypeClass
    {
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
            get { return "Provides the persistence and retrieval operations for Microsoft SQL Server that relate to the <see cref='" + (this.DataSource as DataEntity).CodeName + "Record' /> data structure."; }
        }

        /// <summary>
        ///     Gets the name of the file.
        /// </summary>
        public override String FileName
        {
            get
            {
                String fileName = Path.GetFileNameWithoutExtension(base.FileName);
                String fileExtn = Path.GetExtension(base.FileName);
                return fileName + ".gen.cs";
            }
        }

        /// <summary>
        ///     Gets the name of the file that this file is nested under.
        /// </summary>
        public override String FileNesting
        {
            get { return base.FileName; }
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
            get { return "SqlServer" + (this.DataSource as DataEntity).CodeName + "Repository"; }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return "SqlServerRepository<" + (this.DataSource as DataEntity).CodeName + "Record, " + (this.DataSource as DataEntity).KeyField.CodeTypeName + ">"; }
        }
        
        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return (this.DataSource as DataEntity).CodeName + "Repository"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                DataEntity entity = this.DataSource as DataEntity;

                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the namespace in which the data type is contained.",
                    MemberAbstraction = CSharpAbstraction.Override,
                    MemberType = "String",
                    MemberName = "TypeNamespace",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return \"" + entity.CodeDomain.Name + "\";" } }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the name of the data type which is persisted by this repository.",
                    MemberAbstraction = CSharpAbstraction.Override,
                    MemberType = "String",
                    MemberName = "TypeName",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return \"" + entity.CodeName + "\";" } }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the name of the parameter which is used to specify the unique key.",
                    MemberAbstraction = CSharpAbstraction.Override,
                    MemberType = "String",
                    MemberName = "KeyParameter",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return \"@PA_" + entity.KeyField.ObjectName + "\";" } }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Maps an <see cref='IDataRecord' /> to the specified <see cref='" + entity.CodeName + "Record' />.",
                    MemberModifier = CSharpModifier.Protected,
                    MemberAbstraction = CSharpAbstraction.Override,
                    MemberType = "void",
                    MemberName = "MapRecord",
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter()
                        {
                            XmlSummary = "The <see cref='IDataRecord' /> to be mapped.",
                            MemberType = "IDataRecord",
                            MemberName = "dataRecord",

                        },
                        new MemberParameter()
                        {
                            XmlSummary = "The <see cref='" + entity.CodeName + "Record' /> instance to be mapped to.",
                            MemberType = entity.CodeName + "Record",
                            MemberName = "record",
                        }
                    },
                    Code = entity.Fields.Select(field => "record." + (field == entity.KeyField ? "Id" : field.ObjectShortName) + " = dataRecord[\"" + field.ObjectName + "\"].ConvertTo<" + field.CodeTypeName + ">();").ToArray()
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Performs the bi-directional mapping of the <paramref name='command' /> parameters to values defined on the <see cref='" + entity.CodeName + "Record' /> instance.",
                    MemberModifier = CSharpModifier.Protected,
                    MemberAbstraction = CSharpAbstraction.Override,
                    MemberType = "void",
                    MemberName = "MapParameters",
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter()
                        {
                            MemberType = "IDbCommand",
                            MemberName = "command",
                            XmlSummary = "The <see cref='IDbCommand' /> containing the parameters to be mapped."
                        },
                        new MemberParameter()
                        {
                            MemberType = "ParameterDirection",
                            MemberName = "direction",
                            XmlSummary = "The direction in which the parameters are mapped."
                        },
                        new MemberParameter()
                        {
                            MemberType = entity.CodeName + "Record",
                            MemberName = "record",
                            XmlSummary = "The instance of the <see cref='" + entity.CodeName + "Record' /> containing the values to be mapped."
                        }
                    },
                    Code = 
                    entity.Fields.Select(field => "this.MapParameter(command, direction, \"@PA_" + field.ObjectName + "\", ref record." + (field == entity.KeyField ? "Id" : field.ObjectShortName) + ");").ToArray()
                };
            }
        }
    }
}
