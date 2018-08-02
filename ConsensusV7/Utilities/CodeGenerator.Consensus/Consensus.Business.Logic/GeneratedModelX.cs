using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business.Logic
{
    /// <summary>
    ///     Generates the model implementations
    /// </summary>
    public class GeneratedModelX : TypeClass
    {
        /// <summary>
        ///     The collection of types which are compiled from the interfacing library
        /// </summary>
        public System.Type[] InterfaceLibrary
        {
            get;
            set;
        }

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
            get { return String.Format("Local{0}Model", this.Entity.CodeName); }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return String.Format("LocalModel<{0}Record, {1}>", this.Entity.CodeName, this.Entity.KeyField.CodeTypeName); }
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
                // Get the fields excluding those not intended to be exposed, nor the primary key field (this is exposed in the base class)
                DataEntityField[] fields = this.Entity.Fields
                    .Where(field => field != this.Entity.KeyField)
                    .Where(field => field.CodeExposure != DataEntityField.Exposure.Excluded)
                    .ToArray();

                foreach (DataEntityField field in fields)
                {
                    String fieldXml;
                    String fieldName = String.IsNullOrEmpty(field.CodeName) ? field.ObjectShortName : field.CodeName;
                    String fieldDesc = String.IsNullOrEmpty(field.CodeDescription) ? "the " + fieldName + "." : Char.ToLower(field.CodeDescription[0]) + field.CodeDescription.Substring(1);
                    
                    // Identify the comment that will be used for the property
                    switch (field.CodeExposure)
                    {
                        case DataEntityField.Exposure.Getter: fieldXml = "Gets "; break;
                        case DataEntityField.Exposure.Setter: fieldXml = "Sets "; break;
                        default: fieldXml = "Gets or sets "; break;
                    }

                    if (field.RelatedEntity == null)
                    {
                        yield return new MemberProperty(this)
                        {
                            XmlSummary = fieldXml + fieldDesc,
                            MemberType = field.CodeTypeName,
                            MemberName = fieldName,
                            GetAccessor = (field.CodeExposure & DataEntityField.Exposure.Getter) == DataEntityField.Exposure.Getter ? new MemberAccessor() { Code = new String[] { "return base.ModifiedData." + field.ObjectShortName + ";" } } : null,
                            SetAccessor = (field.CodeExposure & DataEntityField.Exposure.Setter) == DataEntityField.Exposure.Setter ? new MemberAccessor() { Code = new String[] { "base.ModifiedData." + field.ObjectShortName + " = " + (field.CodeType == typeof(String) ? "value.TrimOrNullify();" : "value;") } } : null
                        };
                    }
                    else if (String.Equals(field.RelatedEntity.ObjectName, "Code", StringComparison.OrdinalIgnoreCase))
                    {
                        yield return new MemberField(this)
                        {
                            XmlSummary = Char.ToUpper(fieldDesc[0]) + fieldDesc.Substring(1),
                            MemberModifier = CSharpModifier.Private,
                            MemberType = "LocalCodeModel",
                            MemberName = "_" + Char.ToLower(fieldName[0]) + fieldName.Substring(1),
                        };

                        yield return new MemberProperty(this)
                        {
                            XmlSummary = fieldXml + fieldDesc,
                            MemberType = field.CodeTypeName,
                            MemberName = fieldName + "Code",
                            GetAccessor = (field.CodeExposure & DataEntityField.Exposure.Getter) == DataEntityField.Exposure.Getter ? new MemberAccessor() { Code = new String[] { "return base.ModifiedData." + field.ObjectShortName + ";" } } : null,
                            SetAccessor = (field.CodeExposure & DataEntityField.Exposure.Setter) == DataEntityField.Exposure.Setter ? new MemberAccessor() { Code = new String[] { "base.ModifiedData." + field.ObjectShortName + " = value; _" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + " = null;" } } : null
                        };

                        yield return new MemberProperty(this)
                        {
                            XmlSummary = fieldXml + "the <see cref='CodeModel' /> relating to the <see cref='" + fieldName + "Code' /> property.",
                            MemberType = "LocalCodeModel",
                            MemberName = Char.ToUpper(fieldName[0]) + fieldName.Substring(1),
                            GetAccessor = new MemberAccessor()
                            {
                                Modifier = CSharpModifier.Public,
                                Code = new String[]
                                {
                                    "if (_" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + " == null)",
                                    "    _" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + " = this.Provider." + field.RelatedEntity.CodeDomain.Name + "." + field.RelatedEntity.CodeName + ".GetByTypeAndCode(\"" + field.CodeHeader + "\", this." + fieldName + "Code);",
                                    "",
                                    "if (_" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + " == null)",
                                    "    _" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + " = this.Provider." + field.RelatedEntity.CodeDomain.Name + "." + field.RelatedEntity.CodeName + ".Create();",
                                    "",
                                    "return _" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + ";"
                                }
                            }
                        };
                    }
                    else
                    {
                        yield return new MemberField(this)
                        {
                            XmlSummary = Char.ToUpper(fieldDesc[0]) + fieldDesc.Substring(1),
                            MemberModifier = CSharpModifier.Private,
                            MemberType = "Local" + field.RelatedEntity.CodeName + "Model",
                            MemberName = "_" + Char.ToLower(fieldName[0]) + fieldName.Substring(1),
                        };

                        yield return new MemberProperty(this)
                        {
                            XmlSummary = fieldXml + fieldDesc,
                            MemberType = field.CodeTypeName,
                            MemberName = fieldName + field.RelatedField.CodeName,
                            GetAccessor = (field.CodeExposure & DataEntityField.Exposure.Getter) == DataEntityField.Exposure.Getter ? new MemberAccessor() { Code = new String[] { "return base.ModifiedData." + field.ObjectShortName + ";" } } : null,
                            SetAccessor = (field.CodeExposure & DataEntityField.Exposure.Setter) == DataEntityField.Exposure.Setter ? new MemberAccessor() { Code = new String[] { "base.ModifiedData." + field.ObjectShortName + " = value; _" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + " = null;" } } : null
                        };

                        String initialiseCheck;
                        if (field.RelatedField.CodeType == typeof(String))
                            initialiseCheck = "!String.IsNullOrEmpty(this." + fieldName + field.RelatedField.CodeName + ")";
                        else if (field.RelatedField.CodeType.IsClass)
                            initialiseCheck = "this." + fieldName + field.RelatedField.CodeName + " != null";
                        else
                            initialiseCheck = "this." + fieldName + field.RelatedField.CodeName + " != default(" + field.RelatedField.CodeType.Name + ")";

                        yield return new MemberProperty(this)
                        {
                            XmlSummary = fieldXml + "the <see cref='" + field.RelatedEntity.CodeName + "Model' /> relating to the <see cref='" + fieldName + field.RelatedField.CodeName + "' /> property.",
                            MemberType = "Local" + field.RelatedEntity.CodeName + "Model",
                            MemberName = Char.ToUpper(fieldName[0]) + fieldName.Substring(1),
                            GetAccessor = new MemberAccessor()
                            {
                                Modifier = CSharpModifier.Public,
                                Code = new String[]
                                {
                                    "if (_" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + " == null)",
                                    "    _" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + " = this.Provider." + field.RelatedEntity.CodeDomain.Name + "." + field.RelatedEntity.CodeName + ".GetBy" + field.RelatedField.CodeName + "(this." + fieldName + field.RelatedField.CodeName + ");",
                                    "",
                                    "if (_" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + " == null)",
                                    "    _" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + " = this.Provider." + field.RelatedEntity.CodeDomain.Name + "." + field.RelatedEntity.CodeName + ".Create();",
                                    "",
                                    "return _" + Char.ToLower(fieldName[0]) + fieldName.Substring(1) + ";"
                                }
                            }
                        };
                    }
                }

                if (this.InterfaceLibrary != null)
                {
                    System.Type interfaceType = this.InterfaceLibrary.FirstOrDefault(type => type.Name == String.Format("{0}Model", this.Entity.CodeName));
                    if (interfaceType != null)
                    {
                        foreach (PropertyInfo property in interfaceType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                            yield return new MemberImplementor(this, property, this.GetDocumentation(property));
                        foreach (MethodInfo method in interfaceType.GetMethods(BindingFlags.Public | BindingFlags.Instance))
                            if (!method.IsSpecialName)
                                yield return new MemberImplementor(this, method, this.GetDocumentation(method));
                    }
                }
            }
        }
    }
}