using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Generates the dynamic-code file for the <see cref="DomainEntity"/>-driven record class.
    /// </summary>
    public class GenericDataRecordFromEntityDynamic : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The domain entity from which the repository is generated.
        /// </summary>
        private DomainEntity _entity;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the name of the generated file.
        /// </summary>
        public override String FileName
        {
            get { return base.FileName + ".gen"; }
        }

        /// <summary>
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public override Boolean FileIsEditable
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the domain entity from which the repository is generated.
        /// </summary>
        public DomainEntity Entity
        {
            get { return _entity; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return String.IsNullOrEmpty(this.Entity.ReferencedTable.TableDescription) ? "Represents the \"" + this.Entity.ReferencedTable.TableName + "\" data structure" : this.Entity.ReferencedTable.TableDescription; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlRemarks
        {
            get { return "THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.\r\nDO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION."; }
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
        ///     Gets the scoping namespace of the runtime type.
        /// </summary>
        public override String TypeNamespace
        {
            get { return this.Entity.Container.ContainerName; }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return this.Entity.ReferencedTable.ProgrammaticName + "Record"; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get
            {
                return "Record<" + this.Entity.ReferencedTable.TableKey.ProgrammaticType + ">";
            }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "Cloneable<" + this.Entity.ReferencedTable.ProgrammaticName + "Record>";
                yield return "IEquatable<" + this.Entity.ReferencedTable.ProgrammaticName + "Record>";
            }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                // Output the properties
                foreach (DomainTableColumn column in this.Entity.ReferencedTable.TableColumns)
                {
                    if (column != this.Entity.ReferencedTable.TableKey)
                    {
                        String description = String.IsNullOrEmpty(column.ColumnDescription) ? "The value of the \"" + column.ColumnName + "\" field." : column.ColumnDescription;
                        String fieldName = "_" + column.ProgrammaticName.Substring(0, 1).ToLower() + column.ProgrammaticName.Substring(1);
                        yield return new CSharpField(this)
                        {
                            XmlSummary = description.Substring(0, 1).ToLower() + description.Substring(1),
                            FieldModifier = CSharpModifiers.Private,
                            FieldType = column.ProgrammaticType,
                            Name = fieldName,
                        };
                        yield return new CSharpProperty(this)
                        {
                            XmlSummary = description.Substring(0, 1).ToLower() + description.Substring(1),
                            PropertyType = column.ProgrammaticType,
                            Name = column.ProgrammaticName,
                            PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Public, AccessorCode = new String[] { "return " + fieldName + ";" } },
                            PropertySetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Public, AccessorCode = new String[] { "" + fieldName + " = value;" } }
                        };
                    }
                }

                // Define the clone method
                List<String> cloneLogic = new List<String>();
                cloneLogic.Add(this.Entity.ReferencedTable.ProgrammaticName + "Record record = new " + this.Entity.ReferencedTable.ProgrammaticName + "Record();");
                foreach (DomainTableColumn column in this.Entity.ReferencedTable.TableColumns)
                    cloneLogic.Add(String.Format("record.{0} = this.{0};", column.ProgrammaticName));
                cloneLogic.Add("return record;");
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Creates a new <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> object instance that is a shallow-copy of the current object instance.",
                    XmlReturns = "The shallow-copy of the current <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> object instance.",
                    MethodType = this.Entity.ReferencedTable.ProgrammaticName + "Record",
                    Name = "Clone",
                    MethodCode = cloneLogic.ToArray()
                };

                // Define the comparison method
                List<String> compareLogic = new List<String>();
                compareLogic.Add("Boolean result = true;");
                foreach (DomainTableColumn column in this.Entity.ReferencedTable.TableColumns.Where(column => !column.ColumnIsAuditor))
                {
                    if (column.ProgrammaticType == "String")
                        compareLogic.Add(String.Format("result = result && (this.{0}.TrimOrNullify() == that.{0}.TrimOrNullify());", column.ProgrammaticName));
                    else
                        compareLogic.Add(String.Format("result = result && (this.{0} == that.{0});", column.ProgrammaticName));
                }

                compareLogic.Add("return result;");
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Indicates whether the current <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> instance is equal to another <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> instance.",
                    XmlReturns = "True if both instances are considered equal; otherwise, false.",
                    MethodType = "Boolean",
                    Name = "Equals",
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> instance to be compared against this instance.",
                            ParameterType = this.Entity.ReferencedTable.ProgrammaticName + "Record",
                            ParameterName = "that"
                        }
                    },
                    MethodCode = compareLogic.ToArray()
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="GenericDataRecordFromEntityDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public GenericDataRecordFromEntityDynamic(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
        }

        #endregion
    }
}
