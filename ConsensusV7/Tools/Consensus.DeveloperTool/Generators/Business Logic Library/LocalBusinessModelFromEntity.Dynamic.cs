using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessModelFromEntityDynamic : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The domain entity from which the repository is generated.
        /// </summary>
        private DomainEntity _entity;

        /// <summary>
        ///     The domain for which the repository is being generated.
        /// </summary>
        //private Domain _domain;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the domain entity from which the repository is generated.
        /// </summary>
        public DomainEntity Entity
        {
            get { return _entity; }
        }

        /// <summary>
        ///     Gets the domain entity from which the repository is generated.
        /// </summary>
        //public Domain Domain
        //{
        //    get { return _domain; }
        //}

        /// <summary>
        ///     Gets the name of the generated file.
        /// </summary>
        public override String FileName
        {
            get { return this.Entity.EntityName + ".model.gen"; }
        }

        /// <summary>
        ///     Gets the name of the project item that this item is nested beneath.
        /// </summary>
        public override String FileNesting
        {
            get { return this.Entity.EntityName + ".model." + base.FileExtension; }
        }

        /// <summary>
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public override Boolean FileIsEditable
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return (String.IsNullOrEmpty(this.Entity.EntityDescription) ? "Encapsulates the <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> with standardised business rules" : "Represents " + this.Entity.EntityDescription); }
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
                List<String> references = new List<String>();
                references.Add("System.Collections.Generic");
                references.Add("System.Linq");

                String[] containers = this.Entity.EntityAttributes.Where(attr => attr.Exists && attr.Entity == this.Entity && attr.AttributeExposed && attr.Column != this.Entity.ReferencedTable.TableKey && attr.ReferencedEntity != null && attr.ReferencedEntity.Container != this.Entity.Container).Select(attr => attr.ReferencedEntity.Container.ContainerName).Distinct().ToArray();
                foreach (String container in containers)
                    references.Add(this.Project.ProjectNamespace + "." + container);

                DomainEntityExtender extender = this.Entity as DomainEntityExtender;
                if (extender != null && extender.Container != extender.ReferencedEntity.Container && !references.Contains(this.Project.ProjectNamespace + "." + extender.ReferencedEntity.Container.ContainerName))
                    references.Add(this.Project.ProjectNamespace + "." + extender.ReferencedEntity.Container.ContainerName);

                if (!String.Equals(this.Entity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase))
                {
                    //DomainEntityAttribute[] referenceAttributes = this.Entity.Container.Domain.Containers
                    //    .SelectMany(container => container.ContainerEntities)
                    //    .Where(entity => entity.Exists)
                    //    .SelectMany(entity => entity.EntityAttributes)
                    //    .Where(attr => attr.Exists && attr.ReferencedEntity == this.Entity)
                    //    .ToArray();

                    //String[] attrContainers = referenceAttributes.Select(attr => attr.Entity.Container.ContainerName).Distinct().ToArray();

                    String[] attrContainers;

                    if (MainForm.Runtime != null && MainForm.Runtime.ContainersMap.ContainsKey(this.Entity.Guid))
                    {
                        attrContainers = MainForm.Runtime.ContainersMap[this.Entity.Guid];
                    }
                    else
                    {
                        DomainEntityAttribute[] referenceAttributes = this.Entity.Container.Domain.Containers
                            .SelectMany(container => container.ContainerEntities)
                            .Where(entity => entity.Exists)
                            .SelectMany(entity => entity.EntityAttributes)
                            .Where(attr => attr.Exists && attr.ReferencedEntity == this.Entity)
                            .ToArray();

                        attrContainers = referenceAttributes.Select(attr => attr.Entity.Container.ContainerName).Distinct().ToArray();

                        if (MainForm.Runtime != null)
                        {
                            MainForm.Runtime.ContainersMap.Add(this.Entity.Guid, attrContainers);
                        }
                    }

                    foreach (String container in attrContainers)
                        if (!String.Equals(container, this.Entity.Container.ContainerName, StringComparison.OrdinalIgnoreCase) && !references.Contains(this.Project.ProjectNamespace + "." + container))
                            references.Add(this.Project.ProjectNamespace + "." + container);
                }

                return references;
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
            get { return "Local" + this.Entity.EntityName + "Model"; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get
            {
                DomainEntityExtender extender = (this.Entity as DomainEntityExtender);
                if (extender == null)
                    return "LocalModel<" + this.Entity.ReferencedTable.ProgrammaticName + "Record, " + this.Entity.ReferencedTable.TableKey.ProgrammaticType + ">";
                else
                    return "Local" + extender.ReferencedEntity.EntityName + "Model";
            }
        }

        /// <summary>
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override Boolean TypeIsPartial
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the abstraction of the generated runtime type.
        /// </summary>
        public override CSharpAbstractions TypeAbstraction
        {
            get { return this.Entity.EntityIsAbstract ? CSharpAbstractions.Abstract : CSharpAbstractions.None; }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "I" + this.Entity.EntityName + "Model";
            }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                // Find the base entity
                DomainEntity baseEntity = this.Entity;
                while (baseEntity is DomainEntityExtender)
                    baseEntity = (baseEntity as DomainEntityExtender).ReferencedEntity;

                // Implement the abstraction
                if (this.Entity.EntityIsCreatable)
                {
                    yield return new CSharpProperty(this)
                    {
                        XmlSummary = "Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism",
                        PropertyAbstraction = CSharpAbstractions.Override,
                        PropertyType = "Action<" + this.Entity.ReferencedTable.ProgrammaticName + "Record>",
                        Name = "DataCreator",
                        PropertyGetter = new CSharpAccessor()
                        {
                            AccessorModifier = CSharpModifiers.Protected,
                            AccessorCode = new String[] { "return this.Provider.DataProvider." + baseEntity.Container.ContainerName + "." + baseEntity.EntityName + ".Create;" }
                        }
                    };
                }
                if (this.Entity.EntityIsModifiable)
                {
                    yield return new CSharpProperty(this)
                    {
                        XmlSummary = "Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism",
                        PropertyAbstraction = CSharpAbstractions.Override,
                        PropertyType = "Action<" + this.Entity.ReferencedTable.ProgrammaticName + "Record>",
                        Name = "DataModifier",
                        PropertyGetter = new CSharpAccessor()
                        {
                            AccessorModifier = CSharpModifiers.Protected,
                            AccessorCode = new String[] { "return this.Provider.DataProvider." + baseEntity.Container.ContainerName + "." + baseEntity.EntityName + ".Modify;" }
                        }
                    };
                }
                if (this.Entity.EntityIsRemovable)
                {
                    yield return new CSharpProperty(this)
                    {
                        XmlSummary = "Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism",
                        PropertyAbstraction = CSharpAbstractions.Override,
                        PropertyType = "Action<" + this.Entity.ReferencedTable.ProgrammaticName + "Record>",
                        Name = "DataRemover",
                        PropertyGetter = new CSharpAccessor()
                        {
                            AccessorModifier = CSharpModifiers.Protected,
                            AccessorCode = new String[] { "return this.Provider.DataProvider." + baseEntity.Container.ContainerName + "." + baseEntity.EntityName + ".RemoveById;" }
                        }
                    };
                }

                // Add the model properties
                DomainEntityAttribute[] attributes = this.Entity.EntityAttributes.Where(attr => attr.Exists && attr.Entity == this.Entity && attr.AttributeExposed && attr.Column != this.Entity.ReferencedTable.TableKey).ToArray();
                foreach (DomainEntityAttribute attribute in attributes)
                {
                    if (attribute.ReferencedEntity == null)
                    {
                        yield return new CSharpProperty(this)
                        {
                            XmlSummary = "Gets or sets " + (String.IsNullOrEmpty(attribute.AttributeDescription) ? ("the value of the \"" + attribute.Column.ColumnName + "\" field") : attribute.AttributeDescription),
                            PropertyType = attribute.Column.ProgrammaticType,
                            Name = attribute.AttributeName,
                            PropertyGetter = attribute.AttributeExposure == DomainEntityAttributeExposure.WriteOnly ? null : new CSharpAccessor() { AccessorCode = new String[] { "return this.ModifiedData." + attribute.Column.ProgrammaticName + ";" } },
                            PropertySetter = attribute.AttributeExposure == DomainEntityAttributeExposure.ReadOnly ? null : new CSharpAccessor() { AccessorCode = new String[] { "this.ModifiedData." + attribute.Column.ProgrammaticName + " = value;" } }, // + (attribute.Column.ProgrammaticType == "String" ? ".TrimOrNullify()" + (attribute.Column.ColumnNullable ? "" : " ?? String.Empty") : "") + ";" } },
                        };
                    }
                    else if (String.Equals(attribute.ReferencedEntity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase))
                    {
                        yield return new CSharpField(this)
                        {
                            XmlSummary = String.IsNullOrEmpty(attribute.AttributeDescription) ? ("The value of the \"" + attribute.Column.ColumnName + "\" field") : attribute.AttributeDescription,
                            FieldType = "Local" + attribute.ReferencedEntity.EntityName + "Model",
                            FieldModifier = CSharpModifiers.Private,
                            Name = "_" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1)
                        };
                        if (attribute.AttributeExposure != DomainEntityAttributeExposure.WriteOnly)
                        {
                            yield return new CSharpProperty(this)
                            {
                                XmlSummary = "Gets the " + (String.IsNullOrEmpty(attribute.AttributeDescription) ? ("The value of the \"" + attribute.Column.ColumnName + "\" field") : attribute.AttributeDescription),
                                PropertyType = "Local" + attribute.ReferencedEntity.EntityName + "Model",
                                Name = attribute.AttributeName,
                                PropertyGetter = new CSharpAccessor()
                                {
                                    AccessorCode = new String[]
                                    {
                                        "if (_" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) +" == null && !String.IsNullOrEmpty(this." + attribute.AttributeName + "Code))",
                                        "    _" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) + " = this.Provider." + attribute.ReferencedEntity.Container.ContainerName + "." + attribute.ReferencedEntity.EntityName + ".FetchByTypeAndCode(\"" + attribute.AttributeCode + "\", this." + attribute.AttributeName + "Code);",
                                        "if (_" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) +" == null)",
                                        "    _" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) + " = this.Provider." + attribute.ReferencedEntity.Container.ContainerName + "." + attribute.ReferencedEntity.EntityName + ".Create(\"" + attribute.AttributeCode + "\");",
                                        "return _" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) + ";"
                                    }
                                }
                            };
                        }
                        yield return new CSharpProperty(this)
                        {
                            XmlSummary = "Gets or sets the unique code for " + (String.IsNullOrEmpty(attribute.AttributeDescription) ? ("the value of the \"" + attribute.Column.ColumnName + "\" field") : attribute.AttributeDescription),
                            PropertyType = attribute.Column.ProgrammaticType,
                            Name = attribute.AttributeName + "Code",
                            PropertyGetter = attribute.AttributeExposure == DomainEntityAttributeExposure.WriteOnly ? null : new CSharpAccessor() { AccessorCode = new String[] { "return this.ModifiedData." + attribute.Column.ProgrammaticName + ";" } },
                            PropertySetter = attribute.AttributeExposure == DomainEntityAttributeExposure.ReadOnly ? null : new CSharpAccessor()
                            {
                                AccessorCode = new String[]
                                {
                                    "if (this.ModifiedData." + attribute.Column.ProgrammaticName + " != value)",
                                    "     _" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) + " = null;",
                                    "this.ModifiedData." + attribute.Column.ProgrammaticName + " = value;" // .TrimOrNullify()
                                }
                            },
                        };
                    }
                    else
                    {
                        yield return new CSharpField(this)
                        {
                            XmlSummary = String.IsNullOrEmpty(attribute.AttributeDescription) ? ("The value of the \"" + attribute.Column.ColumnName + "\" field") : attribute.AttributeDescription,
                            FieldType = "Local" + attribute.ReferencedEntity.EntityName + "Model",
                            FieldModifier = CSharpModifiers.Private,
                            Name = "_" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1)
                        };
                        if (attribute.AttributeExposure != DomainEntityAttributeExposure.WriteOnly)
                        {
                            yield return new CSharpProperty(this)
                            {
                                XmlSummary = "Gets the " + (String.IsNullOrEmpty(attribute.AttributeDescription) ? ("The value of the \"" + attribute.Column.ColumnName + "\" field") : attribute.AttributeDescription),
                                PropertyType = "Local" + attribute.ReferencedEntity.EntityName + "Model",
                                Name = attribute.AttributeName,
                                PropertyGetter = new CSharpAccessor()
                                {
                                    AccessorCode = new String[]
                                    {
                                        "if (_" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) +" == null" + (attribute.Column.ColumnNullable ? " && this." + attribute.AttributeName + "Id != null" : "") + ")",
                                        "    _" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) + " = this.Provider." + attribute.ReferencedEntity.Container.ContainerName + "." + attribute.ReferencedEntity.EntityName + ".FetchById(this." + attribute.AttributeName + "Id" + (attribute.Column.ProgrammaticType.EndsWith("?") ? ".Value" : "") + ");",
                                        "if (_" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) +" == null)",
                                        "    _" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) + " = this.Provider." + attribute.ReferencedEntity.Container.ContainerName + "." + attribute.ReferencedEntity.EntityName + ".Create();",
                                        "",
                                        "return _" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) + ";"
                                    }
                                }
                            };
                        }
                        yield return new CSharpProperty(this)
                        {
                            XmlSummary = "Gets or sets the unique code for " + (String.IsNullOrEmpty(attribute.AttributeDescription) ? ("the value of the \"" + attribute.Column.ColumnName + "\" field") : attribute.AttributeDescription),
                            PropertyType = attribute.Column.ProgrammaticType,
                            Name = attribute.AttributeName + "Id",
                            PropertyGetter = attribute.AttributeExposure == DomainEntityAttributeExposure.WriteOnly ? null : new CSharpAccessor() { AccessorCode = new String[] { "return this.ModifiedData." + attribute.Column.ProgrammaticName + ";" } },
                            PropertySetter = attribute.AttributeExposure == DomainEntityAttributeExposure.ReadOnly ? null : new CSharpAccessor()
                            {
                                AccessorCode = new String[]
                                {
                                    "if (this.ModifiedData." + attribute.Column.ProgrammaticName + " != value)",
                                    "     _" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1) + " = null;",
                                    "this.ModifiedData." + attribute.Column.ProgrammaticName + " = value;" // + (attribute.Column.ProgrammaticType == "String" ? ".TrimOrNullify()" : "") + ";"
                                }
                            }
                        };
                    }
                }

                // Add the collection properties
                DomainEntityAttribute[] referenceAttributes = this.Entity.Container.Domain.Containers
                    .SelectMany(container => container.ContainerEntities)
                    .Where(entity => entity.Exists)
                    .SelectMany(entity => entity.EntityAttributes.Where(attr => attr.Entity == entity))
                    .Where(attr => attr.Exists && attr.ReferencedEntity == this.Entity)
                    .ToArray();

                if (!String.Equals(this.Entity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase))
                {
                    foreach (DomainEntityAttribute attribute in referenceAttributes)
                    {
                        String fieldName = "_" + attribute.ReferencedName.Substring(0, 1).ToLower() + attribute.ReferencedName.Substring(1);
                        yield return new CSharpField(this)
                        {
                            XmlSummary = "The collection of <see cref=\"" + attribute.Entity.EntityName + "Model\" /> instances that reference this <see cref=\"" + this.Entity.EntityName + "Model\" />",
                            FieldType = "LocalCollection<Local" + attribute.Entity.EntityName + "Model, I" + attribute.Entity.EntityName + "Model>",
                            FieldModifier = CSharpModifiers.Private,
                            Name = fieldName
                        };
                        yield return new CSharpProperty(this)
                        {
                            XmlSummary = "Gets the collection of <see cref=\"" + attribute.Entity.EntityName + "Model\" /> instances that reference this <see cref=\"" + this.Entity.EntityName + "Model\" />",
                            PropertyType = "LocalCollection<Local" + attribute.Entity.EntityName + "Model, I" + attribute.Entity.EntityName + "Model>",
                            Attributes = attribute.ReferenceExcludeSerialisation ? new String[] { "NonSerializedAttribute" } : null,
                            Name = attribute.ReferencedName,
                            PropertyGetter = new CSharpAccessor()
                            {
                                AccessorCode = new String[]
                                {
                                    "if (" + fieldName + " == null)",
                                    "    " + fieldName + " = new LocalCollection<Local" + attribute.Entity.EntityName + "Model, I" + attribute.Entity.EntityName + "Model>(this.Provider." + attribute.Entity.Container.ContainerName + "." + attribute.Entity.EntityName + ".FetchAllBy" + attribute.AttributeName + "Id(this.Id));",
                                    "",
                                    "return " + fieldName +";"
                                }
                            }
                        };
                    }
                }

                // Define the constructors
                yield return new CSharpConstructor(this)
                {
                    XmlSummary = "Initialises a new <see cref=\"Local" + this.Entity.EntityName + "Model\" /> instance.",
                    ConstructorModifier = CSharpModifiers.Internal,
                    ConstructorParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The business provider to which the business model is bound.",
                            ParameterType = "LocalProvider",
                            ParameterName = "provider"
                        },
                    },
                    ConstructorBase = new String[]
                    {
                        "provider"
                    }
                };
                yield return new CSharpConstructor(this)
                {
                    XmlSummary = "Initialises a new <see cref=\"Local" + this.Entity.EntityName + "Model\" /> instance.",
                    ConstructorModifier = CSharpModifiers.Internal,
                    ConstructorParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The business provider to which the business model is bound.",
                            ParameterType = "LocalProvider",
                            ParameterName = "provider"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "The data record which is encapsulated by the business model.",
                            ParameterType = this.Entity.ReferencedTable.ProgrammaticName + "Record",
                            ParameterName = "record"
                        }
                    },
                    ConstructorBase = new String[]
                    {
                        "provider",
                        "record"
                    }
                };

                // Add the resolve dependency method
                if (this.Entity.EntityIsCreatable || this.Entity.EntityIsModifiable)
                {
                    if (!String.Equals(this.Entity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase))
                    {
                        List<String> resolveDependency = new List<String>();
                        resolveDependency.Add("base.ResolveGeneratedDependency();");
                        foreach (DomainEntityAttribute attribute in attributes.Where(attr => attr.ReferencedEntity != null && String.Equals(attr.ReferencedEntity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase)))
                        {
                            String fieldName = "_" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1);
                            resolveDependency.Add("if (" + fieldName + " != null)");
                            resolveDependency.Add("{");
                            resolveDependency.Add("    " + fieldName + ".Save();");
                            resolveDependency.Add("    this.ModifiedData." + attribute.Column.ProgrammaticName + " = " + fieldName + ".Value1;");
                            resolveDependency.Add("}");
                        }
                        foreach (DomainEntityAttribute attribute in attributes.Where(attr => attr.ReferencedEntity != null && !String.Equals(attr.ReferencedEntity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase)))
                        {
                            String fieldName = "_" + attribute.AttributeName.Substring(0, 1).ToLower() + attribute.AttributeName.Substring(1);
                            resolveDependency.Add("if (" + fieldName + " != null)");
                            resolveDependency.Add("{");
                            resolveDependency.Add("    " + fieldName + ".Save();");
                            if (attribute.ReferencedEntity.EntityAttributes.FirstOrDefault(a => a.AttributeName == "Id").Column.ProgrammaticType == "String")
                                resolveDependency.Add("    this.ModifiedData." + attribute.Column.ProgrammaticName + " = " + fieldName + ".Id == null && this.ModifiedData." + attribute.Column.ProgrammaticName + " != null ? \"\" : " + fieldName + ".Id;");
                            else
                                resolveDependency.Add("    this.ModifiedData." + attribute.Column.ProgrammaticName + " = " + fieldName + ".Id;");
                            resolveDependency.Add("}");
                        }
                        yield return new CSharpMethod(this)
                        {
                            XmlSummary = "Resolves the dependencies by means of persisting all models that this model is referencing.",
                            MethodAbstraction = CSharpAbstractions.Override,
                            MethodModifier = CSharpModifiers.Protected,
                            Name = "ResolveGeneratedDependency",
                            MethodCode = resolveDependency.ToArray()
                        };

                        // Add the resolve dependency method
                        List<String> resolveDependent = new List<String>();
                        resolveDependent.Add("base.ResolveGeneratedDependent();");
                        foreach (DomainEntityAttribute attribute in referenceAttributes)
                        {
                            String fieldName = "_" + attribute.ReferencedName.Substring(0, 1).ToLower() + attribute.ReferencedName.Substring(1);
                            resolveDependent.Add("if (" + fieldName + " != null)");
                            resolveDependent.Add("    " + fieldName + ".Execute(obj => obj." + attribute.AttributeName + "Id = this.Id).Execute(obj => obj.Save());");
                        }
                        yield return new CSharpMethod(this)
                        {
                            XmlSummary = "Resolves the dependent models by means of updating all models that reference this model.",
                            MethodAbstraction = CSharpAbstractions.Override,
                            MethodModifier = CSharpModifiers.Protected,
                            Name = "ResolveGeneratedDependent",
                            MethodCode = resolveDependent.ToArray()
                        };
                    }
                }
                else
                {
                    yield return new CSharpMethod(this)
                    {
                        XmlSummary = "Stores the underlying data within the persistence mechanism.",
                        MethodAbstraction = CSharpAbstractions.Override,
                        MethodModifier = CSharpModifiers.Public,
                        Name = "Save",
                        MethodCode = new String[] { "throw new NotSupportedException();" }
                    };
                }
                if (!this.Entity.EntityIsRemovable)
                {
                    yield return new CSharpMethod(this)
                    {
                        XmlSummary = "Removes the underlying data from the persistence mechanism.",
                        MethodAbstraction = CSharpAbstractions.Override,
                        MethodModifier = CSharpModifiers.Public,
                        Name = "Delete",
                        MethodCode = new String[] { "throw new NotSupportedException();" }
                    };
                }
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="SqlServerRepositoryFromEntityUser" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public LocalBusinessModelFromEntityDynamic(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
            //_domain = domain;
        }

        #endregion
    }
}
