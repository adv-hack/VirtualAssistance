using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Data.SqlServer
{
    /// <summary>
    ///     Generates a generically-types repository abstract.
    /// </summary>
    public class GeneratedRepositoryOfTRecord : TypeClass
    {
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
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Provides the abstraction for repositories, which handle the persistence and retrieval operations for Microsoft SQL Server and relate to the <typeparamref name='TRecord' /> data structure."; }
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
        ///     Gets the generic parameters for the type.
        /// </summary>
        public override IEnumerable<MemberGeneric> TypeGenerics
        {
            get
            {
                yield return new MemberGeneric()
                {
                    MemberConstraint = new String[] { "Record", "new()" },
                    MemberName = "TRecord",
                    XmlSummary = "The type of data structure which is persisted within the repository."
                };
            }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public override String TypeInheritence
        {
            get { return "SqlServerRepository"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "Repository<TRecord>"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Executes the specified database command and maps the resultset to an enumerable collection of <typeparamref name='TRecord' /> instances.",
                    XmlReturns = "An enumerable collection of <typeparamref name='TRecord' /> instances mapped from the command result.",
                    MemberModifier = CSharpModifier.Protected,
                    MemberType = "IEnumerable<TRecord>",
                    MemberName = "Execute",
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter()
                        {
                            MemberType = "DbCommand",
                            MemberName = "command",
                            XmlSummary = "The database command to be executed."
                        }
                    },
                    Code = new String[]
                    {
                        "TRecord[] result;",
                        "using (IDataReader reader = this.Provider.Database.ExecuteReader(command))",
                        "    result = this.MapRecords(reader).ToArray();",
                        "",
                        "return result;"
                    }                    
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Maps the result set returned by an <see cref='IDataReader' /> to an enumerable collection of <typeparamref name='TRecord' /> instances.",
                    XmlReturns = "An enumerable collection of <typeparamref name='TRecord' /> instances mapped from the records obtained from the specified <paramref name='dataReader' />.",
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "IEnumerable<TRecord>",
                    MemberName = "MapRecords",
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter()
                        {
                            MemberType = "IDataReader",
                            MemberName = "dataReader",
                            XmlSummary = "The <see cref='IDataReader' /> which provides the <see cref='IDataRecord' /> instances to be mapped."
                        }
                    },
                    Code = new String[] 
                    {
                        "while (dataReader != null & !dataReader.IsClosed && dataReader.Read())",
                        "    yield return this.MapRecord(dataReader);"
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Maps an <see cref='IDataRecord' /> to a new instance of the <typeparamref name='TRecord' /> class.",
                    XmlReturns = "A new <typeparamref name='TRecord' /> instance pre-initialised with values obtained from the specified <paramref name='dataRecord' />.",
                    MemberModifier = CSharpModifier.Private,
                    MemberType = "TRecord",
                    MemberName = "MapRecord",
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter()
                        {
                            MemberType = "IDataRecord",
                            MemberName = "dataRecord",
                            XmlSummary = "The <see cref='IDataRecord' /> to be mapped."
                        }
                    },
                    Code = new String[]
                    {
                        "TRecord record = new TRecord();",
                        "this.MapRecord(dataRecord, record);",
                        "return record;"
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Maps an <see cref='IDataRecord' /> to the specified <paramref name='dataRecord' />.",
                    MemberModifier = CSharpModifier.Protected,
                    MemberAbstraction = CSharpAbstraction.Abstract,
                    MemberType = "void",
                    MemberName = "MapRecord",
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter()
                        {
                            MemberType = "IDataRecord",
                            MemberName = "dataRecord",
                            XmlSummary = "The <see cref='IDataRecord' /> to be mapped."
                        },
                        new MemberParameter()
                        {
                            MemberType = "TRecord",
                            MemberName = "record",
                            XmlSummary = "The <typeparamref name='TRecord' /> instance to be mapped to."
                        }
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Performs the bi-directional mapping of <paramref name='command' /> parameters to values defined on the <typeparamref name='TRecord' /> instance.",
                    MemberModifier = CSharpModifier.Protected,
                    MemberAbstraction = CSharpAbstraction.Abstract,
                    MemberType = "void",
                    MemberName = "MapParameters",
                    MemberParameters = new MemberParameter[] 
                    { 
                        new MemberParameter()
                        {
                            MemberType = "IDbCommand",
                            MemberName = "command",
                            XmlSummary = "The <see cref='IDbCommand' /> containing the parameters to be mapped."
                        },
                        new MemberParameter()
                        {
                            MemberType = "ParameterDirection",
                            MemberName = "direction",
                            XmlSummary = "The direction in which the parameters are mapped."
                        },
                        new MemberParameter()
                        {
                            MemberType = "TRecord",
                            MemberName = "record",
                            XmlSummary = "The instance of the <typeparamref name='TRecord' /> containing the values to be mapped."
                        }
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Performs the bi-directional mapping of a specific <paramref name='command' /> parameter to a referenced member.",
                    MemberModifier = CSharpModifier.Protected,
                    MemberType = "void",
                    MemberName = "MapParameter",
                    MemberGenerics = new MemberGeneric[]
                    {
                        new MemberGeneric()
                        {
                            XmlSummary = "The data type of the value to be mapped.",
                            MemberName = "TValue"
                        }
                    },
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter()
                        {
                            XmlSummary = "The <see cref='IDbCommand' /> containing the parameters to be mapped.",
                            MemberType = "IDbCommand",
                            MemberName = "command",
                        },
                        new MemberParameter()
                        {
                            XmlSummary = "The direction of the parameters which will be mapped.",
                            MemberType = "ParameterDirection",
                            MemberName = "direction"
                        },
                        new MemberParameter()
                        {
                            XmlSummary = "The name of the parameter to be mapped.",
                            MemberType = "String",
                            MemberName = "name"
                        },
                        new MemberParameter()
                        {
                            XmlSummary = "The value to be mapped.",
                            MemberKeyword = CSharpKeyword.Ref,
                            MemberType = "TValue",
                            MemberName = "value"
                        }
                    },
                    Code = new String[]
                    {
                        "IDataParameter parameter = command.Parameters.Contains(name) ? command.Parameters[name] as IDataParameter : null;",
                        "if (parameter != null)",
                        "{",
                        "    if (direction == ParameterDirection.Input && (parameter.Direction == ParameterDirection.Input || parameter.Direction == ParameterDirection.InputOutput))",
                        "        parameter.Value = value;",
                        "    if (direction == ParameterDirection.Output && (parameter.Direction == ParameterDirection.Output || parameter.Direction == ParameterDirection.InputOutput))",
                        "        value = parameter.Value.ConvertTo<TValue>();",
                        "}"
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Performs one-way mapping of a value to a specific <paramref name='command' /> parameter.",
                    MemberModifier = CSharpModifier.Protected,
                    MemberType = "void",
                    MemberName = "MapParameter",
                    MemberParameters = new MemberParameter[]
                    {
                        new MemberParameter()
                        {
                            XmlSummary = "The <see cref='IDbCommand' /> containing the parameters to be mapped.",
                            MemberType = "IDbCommand",
                            MemberName = "command",
                        },
                        new MemberParameter()
                        {
                            XmlSummary = "The name of the parameter to be mapped.",
                            MemberType = "String",
                            MemberName = "name"
                        },
                        new MemberParameter()
                        {
                            XmlSummary = "The value to be mapped.",
                            MemberType = "Object",
                            MemberName = "value"
                        }
                    },
                    Code = new String[]
                    {
                        "IDataParameter parameter = command.Parameters.Contains(name) ? command.Parameters[name] as IDataParameter : null;",
                        "if (parameter != null)",
                        "    parameter.Value = value;"
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Retrieves all existing <typeparamref name='TRecord' /> instances from the data store.",
                    XmlReturns = "The enumerable collection of <typeparamref name='TRecord' /> instances that are persisted within the data store.",
                    MemberModifier = CSharpModifier.Public,
                    MemberType = "IEnumerable<TRecord>",
                    MemberName = "SelectAll",
                    Code = new String[]
                    {
                        "DbCommand command = this.GetStoredProcedure(DataOperation.SelectAll);",
                        "return this.Execute(command);"
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Creates a new <typeparamref name='TRecord' /> instance within the data store.",
                    MemberModifier = CSharpModifier.Public,
                    MemberType = "void",
                    MemberName = "Create",
                    MemberParameters = new MemberParameter[] 
                    {
                        new MemberParameter()
                        {
                            XmlSummary = "The data structure to be created within the data store.",
                            MemberType = "TRecord",
                            MemberName = "record"
                        }
                    },
                    Code = new String[]
                    {
                        "DbCommand command = this.GetStoredProcedure(DataOperation.Create);",
                        "this.MapParameters(command, ParameterDirection.Input, record);",
                        "this.Execute(command);",
                        "this.MapParameters(command, ParameterDirection.Output, record);"
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Modifies an existing <typeparamref name='TRecord' /> instance within the data store.",
                    MemberModifier = CSharpModifier.Public,
                    MemberType = "void",
                    MemberName = "Modify",
                    MemberParameters = new MemberParameter[] 
                    {
                        new MemberParameter()
                        {
                            XmlSummary = "The data structure to be modified within the data store.",
                            MemberType = "TRecord",
                            MemberName = "record"
                        }
                    },
                    Code = new String[]
                    {
                        "DbCommand command = this.GetStoredProcedure(DataOperation.Modify);",
                        "this.MapParameters(command, ParameterDirection.Input, record);",
                        "this.Execute(command);",
                        "this.MapParameters(command, ParameterDirection.Output, record);"
                    }
                };
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Removes an existing <typeparamref name='TRecord' /> instance from the data store.",
                    MemberModifier = CSharpModifier.Public,
                    MemberType = "void",
                    MemberName = "Remove",
                    MemberParameters = new MemberParameter[] 
                    {
                        new MemberParameter()
                        {
                            XmlSummary = "The data structure to be removed from the data store.",
                            MemberType = "TRecord",
                            MemberName = "record"
                        }
                    },
                    Code = new String[]
                    {
                        "DbCommand command = this.GetStoredProcedure(DataOperation.Remove);",
                        "this.MapParameters(command, ParameterDirection.Input, record);",
                        "this.Execute(command);",
                        "this.MapParameters(command, ParameterDirection.Output, record);"
                    }
                };
            }
        }
    }
}
