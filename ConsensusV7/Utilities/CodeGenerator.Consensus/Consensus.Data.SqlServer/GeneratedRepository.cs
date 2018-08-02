using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Data.SqlServer
{
    /// <summary>
    ///     Generates the repository abstract class.
    /// </summary>
    public class GeneratedRepository : TypeClass
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for repositories, which handle the persistence and retrieval operations for Microsoft SQL Server and relate to a specific data structure."; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                yield return "System.Data";
                yield return "System.Data.Common";
                yield return "System.Linq";
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
            get { return "SqlServerRepository"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "Repository"; }
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
                    MemberModifier = CSharpModifier.Protected,
                    MemberFieldType = MemberFieldType.Static_ReadOnly,
                    MemberType = "String",
                    MemberName = "NamingConvention",
                    MemberValue = "\"spCon{type}{operation}{parameter}\"",
                    XmlSummary = "The naming convention applied to the standard stored procedures."
                };
                yield return new MemberField(this)
                {
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "SqlServerDataProvider",
                    MemberName = "_provider",
                    XmlSummary = "The Microsoft SQL Server data provider which exposes this repository."
                };
                yield return new MemberProperty(this)
                {
                    MemberAbstraction = CSharpAbstraction.Abstract,
                    MemberType = "String",
                    MemberName = "TypeNamespace",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected },
                    XmlSummary = "Gets the namespace in which the data type is contained."
                };
                yield return new MemberProperty(this)
                {
                    MemberAbstraction = CSharpAbstraction.Abstract,
                    MemberType = "String",
                    MemberName = "TypeName",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected },
                    XmlSummary = "Gets the name of the data type which is persisted by this repository."
                };
                yield return new MemberProperty(this)
                {
                    MemberType = "SqlServerDataProvider",
                    MemberName = "Provider",
                    GetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Protected, Code = new String[] { "return _provider;" } },
                    SetAccessor = new MemberAccessor() { Modifier = CSharpModifier.Private, Code = new String[] { "_provider = value;" } },
                    XmlSummary = "Gets the Microsoft SQL Server data provider which exposes this repository."
                };
                yield return new MemberConstructor(this)
                {
                    MemberModifier = CSharpModifier.Protected,
                    XmlSummary = "Initialises a new <see cref='SqlServerRepository' /> instance."
                };
                yield return new MemberMethod(this)
                {
                    MemberModifier = CSharpModifier.Internal,
                    MemberAbstraction = CSharpAbstraction.Static,
                    MemberType = "TRepository",
                    MemberName = "Create",
                    MemberGenerics = new MemberGeneric[]
                    { 
                        new MemberGeneric() 
                        { 
                            MemberName = "TRepository",
                            MemberConstraint = new String[] { "SqlServerRepository", "new()" },
                            XmlSummary = "The type of repository to be validated and/or instantiated."
                        },
                    },
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter() 
                        {
                            MemberType = "SqlServerDataProvider",
                            MemberName = "provider",
                            XmlSummary = "The data provider which programmatically exposes this repository."
                        },
                        new MemberParameter()
                        {
                            MemberKeyword = CSharpKeyword.Ref,
                            MemberType = "TRepository",
                            MemberName = "reference",
                            XmlSummary = "The reference to the field which persists the instance of the repository within memory."
                        }
                    },
                    XmlSummary = "Creates a new <typeparamref name='TRepository' /> instance and stores the instance within the specified <paramref name='reference' />, unless the reference has already been initialised with a <typeparamref name='TRepository' /> instance.",
                    XmlReturns = "The new or existing instance of the <typeparamref name='TRepository' />.",
                    Code = new String[]
                    {
                        "if (reference == null)",
                        "    reference = new TRepository() { Provider = provider };",
                        "",
                        "return reference;"
                    }
                };
                yield return new MemberMethod(this)
                {
                    MemberModifier = CSharpModifier.Protected,
                    MemberType = "DbCommand",
                    MemberName = "GetSqlStatement",
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter() 
                        {
                            MemberType = "String",
                            MemberName = "sqlStatement",
                            XmlSummary = "The sql statement to be executed by the <see cref='DbCommand' />."
                        }
                    },
                    XmlSummary = "Gets a <see cref='DbCommand' /> instance for executing a sql statement.",
                    XmlReturns = "A new <see cref='DbCommand' /> instance, pre-initialised for executing the specified sql statement.",
                    Code = new String[] 
                    { 
                        "DbCommand command = this.Provider.Database.GetSqlStringCommand(sqlStatement);",
                        "command.Connection = this.Provider.Database.CreateConnection();",
                        "return command;"
                    }
                };
                yield return new MemberMethod(this)
                {
                    MemberModifier = CSharpModifier.Protected,
                    MemberType = "DbCommand",
                    MemberName = "GetStoredProcedure",
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter() 
                        {
                            MemberType = "DataOperation",
                            MemberName = "operation",
                            XmlSummary = "The standardised operation performed by the stored procedure."
                        },
                        new MemberParameter() 
                        {
                            MemberKeyword = CSharpKeyword.Params,
                            MemberType = "String[]",
                            MemberName = "parameters",
                            XmlSummary = "The name of the parameters that are required by the stored procedure."
                        }
                    },
                    XmlSummary = "Gets a <see cref='DbCommand' /> instance for executing a stored procedure.",
                    XmlReturns = "A new <see cref='DbCommand' /> instance, pre-initialised for executing the specified stored procedure.",
                    Code = new String[] 
                    { 
                        "String namingSuffix = parameters.Length == 0 ? String.Empty : \"By\" + String.Join(\"And\", parameters);",
                        "String namingFormat = SqlServerRepository.NamingConvention.Replace(\"{operation}\", \"{0}\").Replace(\"{type}\", \"{1}\").Replace(\"{namespace}\", \"{2}\").Replace(\"{parameter}\", \"{3}\");",
                        "String procedureName = String.Format(namingFormat, operation, this.TypeName, this.TypeNamespace, namingSuffix);",
                        "return this.GetStoredProcedure(procedureName);"
                    }
                };

                yield return new MemberMethod(this)
                {
                    MemberModifier = CSharpModifier.Protected,
                    MemberType = "DbCommand",
                    MemberName = "GetStoredProcedure",
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter() 
                        {
                            MemberType = "String",
                            MemberName = "procedureName",
                            XmlSummary = "The name of the stored procedure to be executed by the <see cref='DbCommand' />."
                        }
                    },
                    XmlSummary = "Gets a <see cref='DbCommand' /> instance for executing a stored procedure.",
                    XmlReturns = "A new <see cref='DbCommand' /> instance, pre-initialised for executing the specified stored procedure.",
                    Code = new String[] 
                    { 
                        "// Create the command, connected to the database",
                        "DbCommand command = this.Provider.Database.GetStoredProcCommand(procedureName);",
                        "command.Connection = this.Provider.Database.CreateConnection();",
                        "if (!this.Provider.ParameterCache.ContainsKey(procedureName))",
                        "{",
                        "    // Select the collection of parameters from the database and add to the cache",
                        "    this.Provider.Database.DiscoverParameters(command);",
                        "    this.Provider.ParameterCache.Add(procedureName, command.Parameters.OfType<DbParameter>().Select(param => (param as ICloneable).Clone() as DbParameter).ToArray());",
                        "}",
                        "else",
                        "{",
                        "    // Construct a collection of cloned parameters from the cache and add to the command",
                        "    foreach (IDataParameter parameter in this.Provider.ParameterCache[procedureName])",
                        "        command.Parameters.Add((parameter as ICloneable).Clone());",
                        "}",
                        "return command;"
                    }
                };
            }
        }
    }
}
