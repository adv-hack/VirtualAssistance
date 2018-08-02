using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Data.SqlServer
{
    /// <summary>
    ///     Generates the dependency-injectable data provider.
    /// </summary>
    public class GeneratedDataProvider : TypeClass
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the programmatic access of the repositories within the Microsoft SQL Server."; }
        }

        /// <summary>
        ///     Gets the namespaces that are referenced by this type, in addition to System.
        /// </summary>
        public override IEnumerable<String> TypeReferences
        {
            get
            {
                List<String> references = new List<String>();
                references.Add("System.Data");
                references.Add("System.Data.SqlClient");
                references.Add("System.Collections.Generic");
                references.Add("Microsoft.Practices.EnterpriseLibrary.Data.Sql");

                foreach (DataDomain domain in (this.DataSource as DataDomain[]))
                    references.Add(this.ParentProject.ProjectNamespace + "." + domain.Name);

                return references;
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
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return "SqlServerDataProvider"; }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return "ConsensusProvider"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "DataProvider"; }
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
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "SqlDatabase",
                    MemberName = "_database",
                    XmlSummary = "The connection to the Microsoft SQL Server database."
                };
                yield return new MemberField(this)
                {
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "Dictionary<String, IDataParameter[]>",
                    MemberName = "_parameterCache",
                    XmlSummary = "The cached collection of stored procedure parameters."
                };
                yield return new MemberField(this)
                {
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "SqlConnectionStringBuilder",
                    MemberName = "_connectionBuilder",
                    XmlSummary = "The connection string builder which constructs the connection parameters for the Microsoft SQL Server database."
                };
                foreach (DataDomain domain in this.DataSource as DataDomain[])
                {
                    yield return new MemberField(this)
                    {
                        MemberModifier = CSharpModifier.Private,
                        MemberType = "SqlServer" + domain.Name + "RepositoryCollection",
                        MemberName = "_" + domain.Name.Substring(0, 1).ToLower() + domain.Name.Substring(1),
                        XmlSummary = "The collection of repository instances for Microsoft SQL Server which persist and retrieve data structures pertaining to " + domain.Description + "."
                    };
                }
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the connection to the Microsoft SQL Server database.",
                    MemberType = "SqlDatabase",
                    MemberName = "Database",
                    GetAccessor = new MemberAccessor()
                    {
                        Modifier = CSharpModifier.Internal,
                        Code = new String[] { 
                            "if (_database == null)",
                            "    _database = new SqlDatabase(this.ConnectionString);",
                            "",
                            "return _database;"
                        }
                    }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets the cached collection of stored procedure parameters.",
                    MemberType = "Dictionary<String, IDataParameter[]>",
                    MemberName = "ParameterCache",
                    GetAccessor = new MemberAccessor()
                    {
                        Modifier = CSharpModifier.Internal,
                        Code = new String[] { 
                            "if (_parameterCache == null)",
                            "    _parameterCache = new Dictionary<String, IDataParameter[]>();",
                            "",
                            "return _parameterCache;"
                        }
                    }
                };
                yield return new MemberProperty(this)
                {
                    XmlSummary = "Gets or sets the connection string which defines the connection parameters for the Microsoft SQL Server database.",
                    MemberType = "String",
                    MemberName = "ConnectionString",
                    GetAccessor = new MemberAccessor()
                    {
                        Modifier = CSharpModifier.Internal,
                        Code = new String[] { 
                            "if (_connectionBuilder == null)",
                            "    _connectionBuilder = new SqlConnectionStringBuilder(base[\"connection\"]);",
                            "",
                            "return _connectionBuilder.ConnectionString;"
                        }
                    }
                };
                foreach (DataDomain domain in this.DataSource as DataDomain[])
                {
                    yield return new MemberProperty(this)
                    {
                        XmlSummary = "Gets the collection of repository instances which persist and retrieve data structures pertaining to " + domain.Description + ".",
                        MemberType = domain.Name + "RepositoryCollection",
                        MemberName = domain.Name,
                        GetAccessor = new MemberAccessor() { Code = new String[] { "return SqlServerRepositoryCollection.Create(this, ref _" + domain.Name.Substring(0, 1).ToLower() + domain.Name.Substring(1) + ");" } }
                    };
                }
            }
        }
    }
}
