using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Generates the dynamic-code file for the repository base class.
    /// </summary>
    public class SqlServerRepositoryDynamic : GeneratedClass
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
            get { return "Provides the abstraction for repositories which persist and retrieve data structures, in a Microsoft SQL Server database"; }
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
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "IRepository";
            }
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
                    XmlSummary = "The naming convention applied to the standard stored procedures",
                    FieldFlags = CSharpFieldFlags.ReadOnly | CSharpFieldFlags.Static,
                    FieldModifier = CSharpModifiers.Protected,
                    FieldType = "String",
                    FieldValue = "\"spConsensus{typeNamespace}{typeName}{operation}{parameters}\"",
                    Name = "StoredProcedureNamingConvention"
                };

                yield return new CSharpField(this)
                {
                    XmlSummary = "The <see cref=\"SqlServerProvider\" /> instance which exposes this repository.",
                    FieldModifier = CSharpModifiers.Private,
                    FieldType = "SqlServerProvider",
                    Name = "_provider"
                };

                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the namespace in which the data type is contained.",
                    PropertyAbstraction = CSharpAbstractions.Abstract,
                    PropertyType = "String",
                    Name = "TypeNamespace",
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Protected }
                };

                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the name of the data type which is persisted by this repository.",
                    PropertyAbstraction = CSharpAbstractions.Abstract,
                    PropertyType = "String",
                    Name = "TypeName",
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Protected }
                };

                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the underlying table name that this repository sit over.",
                    PropertyAbstraction = CSharpAbstractions.Abstract,
                    PropertyType = "String",
                    Name = "TableName",
                    PropertyGetter = new CSharpAccessor() { AccessorModifier = CSharpModifiers.Public }
                };

                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets <see cref=\"SqlServerProvider\" /> instance which exposes this repository.",
                    PropertyType = "SqlServerProvider",
                    Name = "Provider",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Protected,
                        AccessorCode = new String[] { "return _provider;" }
                    },
                    PropertySetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Private,
                        AccessorCode = new String[] { "_provider = value;" }
                    },
                };

                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the Role Id for the currently logged on user.",
                    PropertyAbstraction = CSharpAbstractions.None,
                    PropertyType = "String",
                    Name = "UserId",
                    PropertyGetter = new CSharpAccessor() {
                        AccessorModifier = CSharpModifiers.Protected,
                        AccessorCode = new String[] {
                            // This is a hack, which has a number of issues
                            // 1) it uses reflection
                            // 2) it refers to the HttpContext, which may not be available in this tier.
                            // The correct fix (I believe) is to restructure the create and modify methods to take the UserID
                            // which can be passed down from the client level.
                            "if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session == null)",
                            "{",
                            "    return \"-\";",
                            "}",
                            "else",
                            "{",
                            "   object oUser = System.Web.HttpContext.Current.Session[\"current_user\"];",
                            "   if (oUser != null)",
                            "   {",
                            "       Type localUserType = oUser.GetType();",
                            "       System.Reflection.PropertyInfo IdProp = localUserType.GetProperty(\"UserId\");",
                            "       if (IdProp != null)",
                            "       {",
                            "           return IdProp.GetValue(oUser).ToString();",
                            "       }",
                            "       else",
                            "       {",
                            "           return \"-\";",
                            "       }",
                            "   }",
                            "   else",
                            "   {",
                            "       return \"-\";",
                            "   }",
                            "}"
                        }
                    }
                };

                yield return new CSharpConstructor(this)
                {
                    XmlSummary = "Initialises a new <see cref=\"SqlServerRepository\" /> instance.",
                    XmlRemarks = "The use of an internal static instantiation method, combined with a protected constructor, allows common initialisation code to be centralised\r\nwithin an abstract class without creating a requirement for constructor implementation within the derived classes.",
                    ConstructorModifier = CSharpModifiers.Protected
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Creates a new <typeparamref name=\"TRepository\" /> instance and stores the instance within the specified <paramref name=\"reference\" />, unless the reference has already been initialised with a <typeparamref name=\"TRepository\" /> instance.",
                    XmlReturns = "The newly initialised instance, or the pre-existing instance, of the <typeparamref name=\"TRepository\" /> class.",
                    XmlRemarks = "The use of an internal static instantiation method, combined with a protected constructor, allows common initialisation code to be centralised\r\nwithin an abstract class without creating a requirement for constructor implementation within the derived classes.",
                    MethodModifier = CSharpModifiers.Internal,
                    MethodAbstraction = CSharpAbstractions.Static,
                    MethodType = "TRepository",
                    Name = "Create",
                    MethodGenerics = new CSharpGeneric[] 
                    {
                        new CSharpGeneric()
                        {
                            XmlSummary = "The type of repository to be checked and if required, instantiated and initialised.",
                            GenericName = "TRepository",
                            GenericConstraints = new String[] { "SqlServerRepository", "new()" }
                        }
                    },
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The data provider which programmatically exposes this repository.",
                            ParameterType = "SqlServerProvider",
                            ParameterName = "provider"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "The reference to the field which persists the instance of the repository within memory.",
                            ParameterReference = CSharpReference.Ref,
                            ParameterType = "TRepository",
                            ParameterName = "reference"
                        }
                    },
                    MethodCode = new String[] { 
                        "if (reference == null)", 
                        "    reference = new TRepository() { Provider = provider };",
                        "",
                        "return reference;"
                    } 
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Gets a <see cref=\"DbCommand\" /> instance for executing a sql statement.",
                    XmlReturns = "A new <see cref=\"DbCommand\" /> instance, pre-initialised for executing the specified <paramref name=\"statement\" />.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodType = "DbCommand",
                    Name = "GetSqlStatement",
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The sql statement to be executed by the <see cref=\"DbCommand\" />.",
                            ParameterType = "String",
                            ParameterName = "statement"
                        }
                    },
                    MethodCode = new String[]
                    {
                        "DbCommand command = this.Provider.Database.GetSqlStringCommand(statement);",
                        "command.Connection = this.Provider.Database.CreateConnection();",
                        "return command;"
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Gets a <see cref=\"DbCommand\" /> instance for executing a stored procedure.",
                    XmlReturns = "A new <see cref=\"DbCommand\" /> instance, pre-initialised for executing a stored procedure that performs the specified <paramref name=\"operation\" />.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodType = "DbCommand",
                    Name = "GetStoredProcedure",
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The operation that is performed by the stored procedure.",
                            ParameterType = "SqlServerOperation",
                            ParameterName = "operation"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "The name of the parameters that are required by the stored procedure.",
                            ParameterReference = CSharpReference.Params,
                            ParameterType = "String[]",
                            ParameterName = "parameters"
                        }
                    },
                    MethodCode = new String[]
                    {
                        "String procedureNameSuffix = (parameters.Length == 0 ? String.Empty : \"By\" + String.Join(\"And\", parameters));",
                        "String procedureNameFormat = SqlServerRepository.StoredProcedureNamingConvention.Replace(\"{typeNamespace}\", \"{0}\").Replace(\"{typeName}\", \"{1}\").Replace(\"{operation}\", \"{2}\").Replace(\"{parameters}\", \"{3}\");",
                        "String procedureName = String.Format(procedureNameFormat, this.TypeNamespace, this.TypeName, operation, procedureNameSuffix);",
                        "return this.Provider.GetStoredProcedure(procedureName);"
                    }
                };

            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="SqlServerRepositoryDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public SqlServerRepositoryDynamic(GeneratedProject project) : base(project)
        {
        }

        #endregion
    }
}
