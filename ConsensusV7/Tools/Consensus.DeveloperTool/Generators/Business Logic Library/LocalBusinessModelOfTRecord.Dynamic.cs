using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class LocalBusinessModelOfTRecordDynamic : GeneratedClass
    {
        #region properties

        /// <summary>
        ///     Gets the name of the generated file.
        /// </summary>
        public override String FileName
        {
            get { return base.FileName + ".gen"; }
        }

        /// <summary>
        ///     Gets the name of the project item that this item is nested beneath.
        /// </summary>
        public override String FileNesting
        {
            get { return base.FileName + "." + base.FileExtension; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for locally-executable business factories which support business model instantiation"; }
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
                yield return "System.Linq";
                yield return "System.Transactions";
            }
        }

        /// <summary>
        ///     Gets the abstraction of the generated runtime type.
        /// </summary>
        public override CSharpAbstractions TypeAbstraction
        {
            get { return CSharpAbstractions.Abstract; }
        }

        /// <summary>
        ///     Gets whether the generated runtime type is defined over multiple files.
        /// </summary>
        public override Boolean TypeIsPartial
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "LocalModel"; }
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
                    GenericName = "TRecord",
                    XmlSummary = "The data type of the record that is encapsulated by the business model.",
                    GenericConstraints = new String[] { "Record", "Cloneable<TRecord>", "IEquatable<TRecord>", "new()" }
                };
            }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get { return "LocalModel"; }
        }

        /// <summary>
        ///     Gets the members that are defined within the generated type.
        /// </summary>
        public override IEnumerable<CSharpMember> TypeMembers
        {
            get
            {
                yield return new CSharpField(this)
                {
                    XmlSummary = "Specifies whether the underlying data structure has been persisted within the the persistence mechanism.",
                    FieldModifier = CSharpModifiers.Private,
                    FieldType = "Boolean",
                    Name = "_isPersisted"
                };
                yield return new CSharpField(this)
                {
                    XmlSummary = "The data structure that was originally loaded from the persistence mechanism or originally instantiated.",
                    FieldModifier = CSharpModifiers.Private,
                    FieldType = "TRecord",
                    Name = "_originalData"
                };
                yield return new CSharpField(this)
                {
                    XmlSummary = "The data structure that is exposed for in-memory modification.",
                    FieldModifier = CSharpModifiers.Private,
                    FieldType = "TRecord",
                    Name = "_modifiedData"
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets whether the underlying data structure has been persisted within the the persistence mechanism.",
                    PropertyType = "Boolean",
                    Name = "IsPersisted",
                    PropertyAbstraction = CSharpAbstractions.Override,
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Public, AccessorCode = new String[] { "return _isPersisted;" } }
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets whether the underlying data has been modified since instantiation.",
                    PropertyType = "Boolean",
                    Name = "IsModified",
                    PropertyAbstraction = CSharpAbstractions.Override,
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Public, AccessorCode = new String[] { "return !this.OriginalData.Equals(this.ModifiedData);" } }
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the data structure that was originally loaded from the persistence mechanism or originally instantiated.",
                    PropertyType = "TRecord",
                    Name = "OriginalData",
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Protected, AccessorCode = new String[] { "return _originalData;" } },
                    PropertySetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Private, AccessorCode = new String[] { "_originalData = value;" } }
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets data structure that is exposed for in-memory modification.",
                    PropertyType = "TRecord",
                    Name = "ModifiedData",
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Protected, AccessorCode = new String[] { "return _modifiedData;" } },
                    PropertySetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Private, AccessorCode = new String[] { "_modifiedData = value;" } }
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism",
                    PropertyAbstraction = CSharpAbstractions.Virtual,
                    PropertyType = "Action<TRecord>",
                    Name = "DataCreator",
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Protected, AccessorCode = new String[] { "return null;" } }
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism",
                    PropertyAbstraction = CSharpAbstractions.Virtual,
                    PropertyType = "Action<TRecord>",
                    Name = "DataModifier",
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Protected, AccessorCode = new String[] { "return null;" }}
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism",
                    PropertyAbstraction = CSharpAbstractions.Virtual,
                    PropertyType = "Action<TRecord>",
                    Name = "DataRemover",
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Protected, AccessorCode = new String[] { "return null;" } }
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Validates that the underlying data is compliant with the standardised business rules and is therefore eligible for persistence.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "void",
                    Name = "Validate"
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Provides denormalisation upon the underlying data structure prior to persistence.",
                    MethodModifier = CSharpModifiers.Protected_Internal,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "void",
                    Name = "Denormalise"
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Provides initialisation for a new instance of the model.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "void",
                    Name = "Initialise"
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Resolves the dependencies by means of persisting all models that this model is referencing.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "void",
                    Name = "ResolveDependency"
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Resolves the dependencies by means of persisting all models that this model is referencing.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "void",
                    Name = "ResolveGeneratedDependency"
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Resolves the dependent models by means of updating all models that reference this model.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "void",
                    Name = "ResolveDependent"
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Resolves the dependent models by means of updating all models that reference this model.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "void",
                    Name = "ResolveGeneratedDependent"
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Stores the underlying data within the persistence mechanism.",
                    MethodAbstraction = CSharpAbstractions.Override,
                    MethodModifier = CSharpModifiers.Public,
                    Name = "Save",
                    MethodCode = new String[] { "this.Save(this.IsPersisted ? this.DataModifier : this.DataCreator);" }
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Stores the underlying data within the persistence mechanism.",
                    MethodAbstraction = CSharpAbstractions.None,
                    MethodModifier = CSharpModifiers.Protected,
                    Name = "Save",
                    MethodParameters = new CSharpParameter[] {
                        new CSharpParameter() { ParameterName = "dataFunction", ParameterType = "Action<TRecord>", XmlSummary = "The delegated data-provider function for saving the record" }
                    },
                    MethodCode = new String[] 
                    { 
                        "// Create a new transaction, or reuse the existing ambient transaction where one already exists.",
                        "using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))",
                        "{",
                        "    this.ResolveDependency();",
                        "    this.ResolveGeneratedDependency();",
                        "    if (this.IsModified)",
                        "    {",
                        "        // Denormalise and validate the encapsulated data record.",
                        "        this.Denormalise();",
                        "        this.Validate();",
                        "",
                        "        // Save the data record to the underlying persistence mechanism.",
                        "        if (dataFunction != null)",
                        "            dataFunction.Invoke(this.ModifiedData);",
                        "",
                        "        this.Set(true);",
                        "    }",
                        "",
                        "    // Save the business models which reference this object.",
                        "    this.ResolveDependent();",
                        "    this.ResolveGeneratedDependent();",
                        "    transaction.Complete();",
                        "}"
                    }
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Validates that the object can be removed from the system.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "void",
                    Name = "ValidateRemoval"
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Resolves the dependent models by means of deleting all models that are direct descendents of this model.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "void",
                    Name = "ResolveDeleteDependent"
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Removes the underlying data from the persistence mechanism.",
                    MethodAbstraction = CSharpAbstractions.Override,
                    MethodModifier = CSharpModifiers.Public,
                    Name = "Delete",
                    MethodCode = new String[] 
                    { 
                        "// Create a new transaction, or reuse the existing ambient transaction where one already exists.",
                        "using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))",
                        "{",
                        "    if (this.IsPersisted)",
                        "    {",
                        "        // Validate that the data is removable.",
                        "        this.ValidateRemoval();",
                        "        this.ResolveDeleteDependent();",
                        "        if (this.DataRemover != null)",
                        "            this.DataRemover.Invoke(this.ModifiedData);",
                        "",
                        "        // Update the state of the object.",
                        "        this.Set(false);",
                        "        transaction.Complete();",
                        "    }",
                        "}"
                    }
                };
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Sets the internal object state.",
                    MethodModifier = CSharpModifiers.Internal,
                    Name = "Set",
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "Specifies whether the object is stored within the underlying persistence mechanism.",
                            ParameterType = "Boolean",
                            ParameterName = "isPersisted"
                        }
                    },
                    MethodCode = new String[] 
                    {
                        "this.OriginalData = this.ModifiedData.Clone();",
                        "_isPersisted = isPersisted;",
                    }
                };
                yield return new CSharpConstructor(this)
                {
                    XmlSummary = "Initialises a new <see cref=\"LocalModel{TModel}\" /> instance.",
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
                    },
                    ConstructorCode = new String[] 
                    {
                        "this.ModifiedData = new TRecord();",
                        "this.Initialise();",
                        "this.OriginalData = this.ModifiedData.Clone();",
                        "_isPersisted = false;"
                    }
                };

                yield return new CSharpConstructor(this)
                {
                    XmlSummary = "Initialises a new <see cref=\"LocalModel{TModel}\" /> instance.",
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
                            ParameterType = "TRecord", 
                            ParameterName = "record" 
                        }
                    },
                    ConstructorBase = new String[] 
                    {
                        "provider"
                    },
                    ConstructorCode = new String[] 
                    {
                        "this.ModifiedData = record.Clone();",
                        "this.OriginalData = record.Clone();",
                        "_isPersisted = true;"
                    }
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="LocalBusinessModelDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public LocalBusinessModelOfTRecordDynamic(GeneratedProject project) : base(project)
        {
        }

        #endregion
    }
}
