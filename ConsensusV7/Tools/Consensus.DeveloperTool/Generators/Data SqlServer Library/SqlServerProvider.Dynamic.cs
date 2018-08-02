using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Generates the dynamic-code file for the dependency-injectable provider class.
    /// </summary>
    public class SqlServerProviderDynamic : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The domain containers whose repository collections are exposed by the generated provider.
        /// </summary>
        private DomainContainer[] _containers;

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
        ///     Gets the name of the project item that this item is nested beneath.
        /// </summary>
        public override String FileNesting
        {
            get { return base.FileName + "." + base.FileExtension; }
        }

        /// <summary>
        ///     Gets the domain containers whose repository collections are exposed by the generated provider.
        /// </summary>
        public DomainContainer[] Containers
        {
            get { return _containers; }
        }

        /// <summary>
        ///     Gets the xml documentation summary for the type.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the programmatic access to the repository collections for Microsoft SQL Server data access."; }
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
                yield return "Microsoft.Practices.EnterpriseLibrary.Data.Sql";
                yield return "System.Collections.Generic";
                yield return "System.Data";
                yield return "System.Data.Common";
                yield return "System.Data.SqlClient";
                yield return "System.Linq";
                foreach (DomainContainer container in this.Containers)
                    yield return this.Project.ProjectNamespace + "." + container.ContainerName;
            }
        }

        /// <summary>
        ///     Gets the name of the runtime type.
        /// </summary>
        public override String TypeName
        {
            get { return "SqlServerProvider"; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get
            {
                return "ConsensusProvider";
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
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "IDataProvider";
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
                    XmlSummary = "The connection to the Microsoft SQL Server database.",
                    FieldModifier = CSharpModifiers.Private,
                    FieldType = "SqlDatabase",
                    Name = "_database"
                };
                yield return new CSharpField(this)
                {
                    XmlSummary = "The cached collection of stored procedure parameters.",
                    FieldModifier = CSharpModifiers.Private,
                    FieldType = "Dictionary<String, IDataParameter[]>",
                    Name = "_cache"
                };
                yield return new CSharpField(this)
                {
                    XmlSummary = "The connection string builder which constructs the connection parameters for the Microsoft SQL Server database.",
                    FieldModifier = CSharpModifiers.Private,
                    FieldType = "SqlConnectionStringBuilder",
                    Name = "_connectionBuilder"
                };
                yield return new CSharpField(this)
                {
                    XmlSummary = "The name of the connection string field in the service definition in web.config.",
                    FieldModifier = CSharpModifiers.Private,
                    FieldType = "string",
                    Name = "_connectionStringField",
                    FieldValue = "\"connection\""
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the connection to the Microsoft SQL Server database.",
                    PropertyType = "SqlDatabase",
                    Name = "Database",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Internal,
                        AccessorCode = new String[] 
                        { 
                            "if (_database == null)",
                            "    _database = new SqlDatabase(this.ConnectionString);",
                            "return _database;" 
                        }
                    }
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the cached collection of stored procedure parameters.",
                    PropertyType = "Dictionary<String, IDataParameter[]>",
                    Name = "Cache",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Internal,
                        AccessorCode = new String[] 
                        { 
                            "if (_cache == null)",
                            "    _cache = new Dictionary<String, IDataParameter[]>();",
                            "return _cache;" 
                        }
                    }
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the connection string which defines the connection parameters for the Microsoft SQL Server database.",
                    PropertyType = "String",
                    Name = "ConnectionString",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Internal,
                        AccessorCode = new String[] 
                        { 
                            "if (_connectionBuilder == null)",
                            "    _connectionBuilder = new SqlConnectionStringBuilder(base[_connectionStringField]);",
                            "return _connectionBuilder.ConnectionString;" 
                        }
                    }
                };
                yield return new CSharpProperty(this)
                {
                    XmlSummary = "The name of the connection string field in the service definition in web.config.",
                    PropertyType = "String",
                    Name = "ConnectionStringField",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Internal,
                        AccessorCode = new String[]
                        {
                            "return _connectionStringField;"
                        }
                    },
                    PropertySetter = new CSharpAccessor()
                    {
                        AccessorModifier = CSharpModifiers.Internal,
                        AccessorCode = new String[]
                        {
                            "_connectionStringField = value;"
                        }
                    }
                };
                foreach (DomainContainer container in this.Containers)
                {
                    yield return new CSharpField(this)
                    {
                        XmlSummary = "The Microsoft SQL Server repository collection which pertains to " + (String.IsNullOrEmpty(container.ContainerDescription) ? "the " + container.ContainerName + " namespace" : container.ContainerDescription),
                        FieldModifier = CSharpModifiers.Private,
                        FieldType = "SqlServer" + container.ContainerName + "RepositoryCollection",
                        Name = "_" + container.ContainerName.Substring(0, 1).ToLower() + container.ContainerName.Substring(1)
                    };
                    yield return new CSharpProperty(this)
                    {
                        XmlSummary = "Gets the Microsoft SQL Server repository collection which pertains to " + (String.IsNullOrEmpty(container.ContainerDescription) ? "the " + container.ContainerName + " namespace" : container.ContainerDescription),
                        PropertyType = "SqlServer" + container.ContainerName + "RepositoryCollection",
                        Name = container.ContainerName,
                        PropertyGetter = new CSharpAccessor() { AccessorCode = new String[] { "return SqlServerRepositoryCollection.Create(this, ref _" + container.ContainerName.Substring(0, 1).ToLower() + container.ContainerName.Substring(1) + ");", } }
                    };
                }

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Gets a <see cref=\"DbCommand\" /> instance for executing a stored procedure.",
                    XmlReturns = "A new <see cref=\"DbCommand\" /> instance, pre-initialised for executing the specified <paramref name=\"procedure\" />.",
                    MethodModifier = CSharpModifiers.Internal,
                    MethodType = "DbCommand",
                    Name = "GetStoredProcedure",
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The name of the stored procedure to be executed by the <see cref=\"DbCommand\" />.",
                            ParameterType = "String",
                            ParameterName = "procedure"
                        }
                    },
                    MethodCode = new String[]
                    {
                        "// Create the command, connected to the database",
                        "DbCommand command = this.Database.GetStoredProcCommand(procedure);",
                        "command.Connection = this.Database.CreateConnection();",
                        "if (!this.Cache.ContainsKey(procedure))",
                        "{",
                        "    // Select the collection of parameters from the database and add to the cache.",
                        "    this.Database.DiscoverParameters(command);",
                        "    this.Cache.Add(procedure, command.Parameters.OfType<DbParameter>().Select(param => (param as ICloneable).Clone() as DbParameter).ToArray());",
                        "}",
                        "else",
                        "{",
                        "    // Construct a collection of cloned parameters from the cache and add to the command.",
                        "    foreach (IDataParameter parameter in this.Cache[procedure])",
                        "        command.Parameters.Add((parameter as ICloneable).Clone());",
                        "}",
                        "return command;"
                    }
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="SqlServerProviderDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain containers whose repository collections are exposed by the generated provider.
        /// </param>
        public SqlServerProviderDynamic(GeneratedProject project, DomainContainer[] containers) : base(project)
        {
            _containers = containers;
        }

        #endregion
    }
}
