using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business.Logic
{
    /// <summary>
    ///     Generates the generically-typed base class for model implementations
    /// </summary>
    public class GeneratedModelOfTRecord : TypeClass
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for locally-executable business model instance which implements the standardised rules for the Consensus solution."; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                yield return "System.Linq";
                yield return "System.Transactions";
            }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public override CSharpModifier TypeModifier
        {
            get { return CSharpModifier.Public; }
        }

        /// <summary>
        ///     Gets the abstraction of the class.
        /// </summary>
        public override CSharpAbstraction TypeAbstraction
        {
            get { return CSharpAbstraction.Abstract; }
        }

        /// <summary>
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return "LocalModel"; }
        }

        /// <summary>
        ///     Gets the generic parameters for the type.
        /// </summary>
        public override IEnumerable<MemberGeneric> TypeGenerics
        {
            get
            {
                yield return new MemberGeneric()
                {
                    XmlSummary = "The type of the data record which is encapsulated by this business model.",
                    MemberName = "TRecord",
                    MemberConstraint = new String[] { "Record", "Cloneable<TRecord>", "IEquatable<TRecord>", "new()" }
                };
            }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return "LocalModel"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                yield return new MemberField(this)
                {
                    XmlSummary = "Tracks whether the underlying data structure has been persisted within the the persistence mechanism.",
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "Boolean",
                    MemberName = "_isPersisted"
                };
                yield return new MemberField(this)
                {
                    XmlSummary = "The data structure that was originally loaded from the persistence mechanism.",
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "TRecord",
                    MemberName = "_originalData"
                };
                yield return new MemberField(this)
                {
                    XmlSummary = "The data structure that is exposed to in-memory modification.",
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "TRecord",
                    MemberName = "_modifiedData"
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets whether the underlying data has been persisted within the the persistence mechanism.",
                    MemberAbstraction = CSharpAbstraction.Override,
                    MemberType = "Boolean",
                    MemberName = "IsPersisted",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return _isPersisted;" } }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets whether the underlying data has been modified since instantiation.",
                    MemberAbstraction = CSharpAbstraction.Override,
                    MemberType = "Boolean",
                    MemberName = "IsModified",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return !this.OriginalData.Equals(this.ModifiedData);" } }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the data structure that was originally loaded from the persistence mechanism.",
                    MemberType = "TRecord",
                    MemberName = "OriginalData",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return _originalData;" } }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the data structure that is exposed to in-memory modification.",
                    MemberType = "TRecord",
                    MemberName = "ModifiedData",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return _modifiedData;" } }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the function that is responsible for persisting a new instance of the data record.",
                    MemberAbstraction = CSharpAbstraction.Virtual,
                    MemberType = "Action<TRecord>",
                    MemberName = "RecordCreator",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return null;" } }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the function that is responsible for persisting an existing instance of the data record.",
                    MemberAbstraction = CSharpAbstraction.Virtual,
                    MemberType = "Action<TRecord>",
                    MemberName = "RecordModifier",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return null;" } }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Updates the underlying data with all denormalised values.",
                    MemberAbstraction = CSharpAbstraction.Virtual,
                    MemberModifier = CSharpModifier.Protected,
                    MemberName = "Denormalise",
                    MemberType = "void"
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Validates that the underlying data is compliant with the Consensus business rules and is therefore eligible for persistence.",
                    MemberAbstraction = CSharpAbstraction.Virtual,
                    MemberModifier = CSharpModifier.Protected,
                    MemberName = "Validate",
                    MemberType = "void"
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Saves each business logic instance which this object is dependent upon.",
                    MemberAbstraction = CSharpAbstraction.Virtual,
                    MemberModifier = CSharpModifier.Protected,
                    MemberName = "ResolveDependency",
                    MemberType = "void"
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Saves each business logic instance that is a collection ",
                    MemberAbstraction = CSharpAbstraction.Virtual,
                    MemberModifier = CSharpModifier.Protected,
                    MemberName = "ResolveDependent",
                    MemberType = "void"
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Saves the business model.",
                    MemberAbstraction = CSharpAbstraction.Override,
                    MemberModifier = CSharpModifier.Public,
                    MemberName = "Save",
                    MemberType = "void",
                    Code = new String[]
                    {
                        "// Create a new transaction, or reuse the existing ambient transaction where one already exists.",
                        "using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))",
                        "{",
                        "    if (this.IsModified || !this.IsPersisted)",
                        "    {",
                        "        // Denormalise and validate the encapsulated data record.",
                        "        this.ResolveDependency();",
                        "        this.Denormalise();",
                        "        this.Validate();",
                        "",
                        "        // Save the data record to the underlying persistence mechanism.",
                        "        Action<TRecord> persistFunction = !this.IsPersisted ? this.RecordCreator : this.RecordModifier;", 
                        "        if (persistFunction != null)",
                        "        {",
                        "            persistFunction.Invoke(this.ModifiedData);",
                        "            _originalData = _modifiedData.Clone();",
                        "            _isPersisted = true;",
                        "        }",
                        "    }",
                        "",
                        "    // Save the business models which reference this object.",
                        "    this.ResolveDependent();",
                        "",
                        "}"
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Creates and returns a new <typeparamref name='TModel' /> instance.",
                    XmlReturns = "The new instance of the <typeparamref name='TModel' /> class.",
                    MemberModifier = CSharpModifier.Internal,
                    MemberAbstraction = CSharpAbstraction.Static,
                    MemberType = "TModel",
                    MemberName = "Create",
                    MemberGenerics = new MemberGeneric[]
                    {
                        new MemberGeneric()
                        {
                            XmlSummary = "The type of locally-executable model that will be instantiated.",
                            MemberName = "TModel",
                            MemberConstraint = new String[] { "LocalModel<TRecord>", "new()" }
                        }
                    },
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter() { XmlSummary = "The business provider to which the business model is bound.", MemberType = "LocalBusinessProvider", MemberName = "provider" },
                    },
                    Code = new String[] 
                    { 
                        "return Create<TModel>(provider, new TRecord());"
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Creates and returns a new <typeparamref name='TModel' /> instance.",
                    XmlReturns = "The new instance of the <typeparamref name='TModel' /> class.",
                    MemberModifier = CSharpModifier.Internal,
                    MemberAbstraction = CSharpAbstraction.Static,
                    MemberType = "TModel",
                    MemberName = "Create",
                    MemberGenerics = new MemberGeneric[]
                    {
                        new MemberGeneric()
                        {
                            XmlSummary = "The type of locally-executable model that will be instantiated.",
                            MemberName = "TModel",
                            MemberConstraint = new String[] { "LocalModel<TRecord>", "new()" }
                        }
                    },
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter() { XmlSummary = "The business provider to which the business model is bound.", MemberType = "LocalBusinessProvider", MemberName = "provider" },
                        new MemberParameter() { XmlSummary = "The data record which is encapsulated by the business model.", MemberType = "TRecord", MemberName = "record" }
                    },
                    Code = new String[]
                    {
                        "TModel localModel = null;",
                        "if (record != null)",
                        "{",
                        "    localModel = new TModel() { Provider = provider };",
                        "    localModel._originalData = record;",
                        "    localModel._modifiedData = record.Clone();",
                        "    localModel._isPersisted = true;",
                        "}",
                        "return localModel;"
                    }
                };
            }
        }
    }
}
