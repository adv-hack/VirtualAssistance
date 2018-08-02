using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Generates the dynamic-code file for the generic-typed repository base class.
    /// </summary>
    public class SqlServerRepositoryOfTRecordTIdDynamic : GeneratedClass
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
            get { return "Provides the abstraction for repositories which persist and retrieve the <typeparamref name=\"TRecord\" /> data structure, in a Microsoft SQL Server database"; }
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
            get { return "SqlServerRepository"; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get
            {
                return "SqlServerRepository<TRecord>";
            }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "IRepository<TRecord, TId>";
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
                    XmlSummary = "The type of data structure which is persisted within the repository.",
                    GenericName = "TRecord",
                    GenericConstraints = new String[] { "Record<TId>", "new()" }
                };
                yield return new CSharpGeneric()
                {
                    XmlSummary = "The data type of the unique value which distinctly identifies an instance of the data structure.",
                    GenericName = "TId",
                    GenericConstraints = new String[] { "IComparable<TId>", "IEquatable<TId>" }
                };
            }
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
                    XmlSummary = "Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <typeparamref name=\"TRecord\" />",
                    PropertyAbstraction = CSharpAbstractions.Abstract,
                    PropertyType = "String",
                    Name = "TypeKeyName",
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Protected }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Retrieves a single <typeparamref name=\"TRecord\" /> instance from the data store.",
                    XmlReturns = "The <typeparamref name=\"TRecord\" /> instance that matches the specified <paramref name=\"id\" />; or null, if no matching instance can be found.",
                    MethodModifier = CSharpModifiers.Public,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "TRecord",
                    Name = "FetchById",
                    MethodParameters = new CSharpParameter[] 
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The unique value which distinctly identifies the <typeparamref name=\"TRecord\" /> instance to be returned.",
                            ParameterType = "TId",
                            ParameterName = "id"
                        }
                    },
                    MethodCode = new String[] {
                        "DbCommand command = this.GetStoredProcedure(SqlServerOperation.Fetch, \"Id\");",
                        "this.MapParameterIn(command, this.TypeKeyName, id);",
                        "return this.Execute(command).FirstOrDefault();"
                    }
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="SqlServerRepositoryOfTRecordTIdDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public SqlServerRepositoryOfTRecordTIdDynamic(GeneratedProject project) : base(project)
        {
        }

        #endregion
    }
}
