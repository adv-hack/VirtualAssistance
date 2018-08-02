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
    public class SqlServerRepositoryOfTRecordDynamic : GeneratedClass
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
                return "SqlServerRepository";
            }
        }

        /// <summary>
        ///     Gets the interfaces implemented by the generated type.
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get
            {
                yield return "IRepository<TRecord>";
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
                    GenericConstraints = new String[] { "Record", "new()" }
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
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Executes the specified database command and maps the resultset to an enumerable collection of <typeparamref name=\"TRecord\" /> instances.",
                    XmlReturns = "An enumerable collection of <typeparamref name=\"TRecord\" /> instances mapped from the command result.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodType = "IEnumerable<TRecord>",
                    Name = "Execute",
                    MethodParameters = new CSharpParameter[]
                    { 
                        new CSharpParameter() 
                        {
                            XmlSummary = "The database command to be executed.",
                            ParameterType = "DbCommand",
                            ParameterName = "command"
                        }
                    },
                    MethodCode = new String[] 
                    { 
                        "TRecord[] result;",
                        "using (IDataReader reader = this.Provider.Database.ExecuteReader(command))",
                        "    result = this.MapRecords(reader).ToArray();",
                        "",
                        "return result;"
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Maps the result set returned by an <see cref=\"IDataReader\" /> to an enumerable collection of <typeparamref name=\"TRecord\" /> instances.",
                    XmlReturns = "An enumerable collection of <typeparamref name=\"TRecord\" /> instances mapped from the records obtained from the specified <paramref name=\"dataReader\" />.",
                    MethodModifier = CSharpModifiers.Private,
                    MethodType = "IEnumerable<TRecord>",
                    Name = "MapRecords",
                    MethodParameters = new CSharpParameter[]
                    { 
                        new CSharpParameter() 
                        {
                            XmlSummary = "The <see cref=\"IDataReader\" /> which iterates through the <see cref=\"IDataRecord\" /> instances to be mapped.",
                            ParameterType = "IDataReader",
                            ParameterName = "dataReader"
                        }
                    },
                    MethodCode = new String[]
                    {
                        "while (dataReader != null & !dataReader.IsClosed && dataReader.Read())",
                        "    yield return this.MapRecord(dataReader);"
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Maps an <see cref=\"IDataRecord\" /> to a new instance of the <typeparamref name=\"TRecord\" /> class.",
                    XmlReturns = "A new <typeparamref name=\"TRecord\" /> instance pre-initialised with values obtained from the specified <paramref name=\"dataRecord\" />.",
                    MethodModifier = CSharpModifiers.Private,
                    MethodType = "TRecord",
                    Name = "MapRecord",
                    MethodParameters = new CSharpParameter[]
                    { 
                        new CSharpParameter() 
                        {
                            XmlSummary = "The <see cref=\"IDataRecord\" /> to be mapped.",
                            ParameterType = "IDataRecord",
                            ParameterName = "dataRecord"
                        }
                    },
                    MethodCode = new String[]
                    {
                        "TRecord record = new TRecord();",
                        "this.MapRecord(dataRecord, record);",
                        "return record;"
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Maps an <see cref=\"IDataRecord\" /> to the specified <paramref name=\"dataRecord\" />.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Abstract,
                    Name = "MapRecord",
                    MethodParameters = new CSharpParameter[]
                    { 
                        new CSharpParameter() 
                        {
                            XmlSummary = "The <see cref=\"IDataRecord\" /> to be mapped.",
                            ParameterType = "IDataRecord",
                            ParameterName = "dataRecord"
                        },
                        new CSharpParameter() 
                        {
                            XmlSummary = "The <typeparamref name=\"TRecord\" /> instance to be mapped to.",
                            ParameterType = "TRecord",
                            ParameterName = "record"
                        }
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Sets the parameter values for the specified <paramref name=\"command\" /> based on the specified <typeparamref name=\"TRecord\" /> instance.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Abstract,
                    Name = "MapParametersIn",
                    MethodParameters = new CSharpParameter[]
                    { 
                        new CSharpParameter() 
                        {
                            XmlSummary = "The <see cref=\"IDbCommand\" /> containing the parameters to be mapped.",
                            ParameterType = "IDbCommand",
                            ParameterName = "command"
                        },
                        new CSharpParameter() 
                        {
                            XmlSummary = "The instance of the <typeparamref name=\"TRecord\" /> containing the values to be mapped.",
                            ParameterType = "TRecord",
                            ParameterName = "record"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "Is the procedure being run an old version 6.x procedure? (the null value handling logic is different)",
                            ParameterType = "bool",
                            ParameterName = "useV6Logic"
                        }
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Extracts the parameter values for the specified <paramref name=\"command\" /> and applies the values to the specified <typeparamref name=\"TRecord\" /> instance.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Abstract,
                    Name = "MapParametersOut",
                    MethodParameters = new CSharpParameter[]
                    { 
                        new CSharpParameter() 
                        {
                            XmlSummary = "The <see cref=\"IDbCommand\" /> containing the parameters to be mapped.",
                            ParameterType = "IDbCommand",
                            ParameterName = "command"
                        },
                        new CSharpParameter() 
                        {
                            XmlSummary = "The instance of the <typeparamref name=\"TRecord\" /> to be updated.",
                            ParameterType = "TRecord",
                            ParameterName = "record"
                        }
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Sets the parameter for the specified <paramref name=\"command\" /> to the specified <paramref name=\"value\" />.",
                    MethodModifier = CSharpModifiers.Protected,
                    Name = "MapParameterIn",
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The <see cref=\"IDbCommand\" /> containing the parameters to be mapped.",
                            ParameterType = "IDbCommand",
                            ParameterName = "command"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "The name of the parameter to be set.",
                            ParameterType = "String",
                            ParameterName = "name"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "The value of the parameter to be set.",
                            ParameterType = "Object",
                            ParameterName = "value"
                        },
                    },
                    MethodCode = new String[]
                    {
                        "IDataParameter parameter = command.Parameters.Contains(name) ? command.Parameters[name] as IDataParameter : null;",
                        "if (parameter != null && (parameter.Direction == ParameterDirection.Input || parameter.Direction == ParameterDirection.InputOutput))",
                        "    parameter.Value = value;"
                    }
                };


                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Adds the standard error handling parameters for older procedures to the specified <paramref name=\"command\" />.",
                    MethodModifier = CSharpModifiers.Protected,
                    Name = "MapErrorParams",
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The <see cref=\"IDbCommand\" /> containing the parameters to be mapped.",
                            ParameterType = "IDbCommand",
                            ParameterName = "command"
                        }
                    },
                    MethodCode = new String[]
                    {
                        "MapParameterIn(command, \"@PA_ERRORCODE\", null);",
                        "MapParameterIn(command, \"@PA_ERRORDESC\", null);"
                    }
                };


                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Reads standard error handling parameters for older procedures and throws an ApplicationException if an error has been returned.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    Name = "CheckErrorParams",
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The <see cref=\"IDbCommand\" /> containing the parameters to be mapped.",
                            ParameterType = "IDbCommand",
                            ParameterName = "command"
                        }
                    },
                    MethodCode = new String[]
                    {
                        "int errCode = 0;",
                        "string errMsg = \"\";",
                        "errCode = this.MapParameterOut(command, \"@PA_ERRORCODE\", errCode);",
                        "errMsg = this.MapParameterOut(command, \"@PA_ERRORDESC\", errMsg);",
                        "",
                        "if (!string.IsNullOrEmpty(errMsg))",
                        "{",
                        "    throw new ApplicationException(errMsg);",
                        "}",
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Extracts the parameter value from the specified <paramref name=\"command\" />.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodType = "TValue",
                    Name = "MapParameterOut",
                    MethodGenerics = new CSharpGeneric[] 
                    {
                        new CSharpGeneric()
                        {
                            XmlSummary = "The data type of the value to be extracted.",
                            GenericName = "TValue"
                        }
                    },
                    MethodParameters = new CSharpParameter[]
                    {
                        new CSharpParameter()
                        {
                            XmlSummary = "The <see cref=\"IDbCommand\" /> containing the parameters to be extracted.",
                            ParameterType = "IDbCommand",
                            ParameterName = "command"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "The name of the parameter to be extracted.",
                            ParameterType = "String",
                            ParameterName = "name"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "The value of the parameter to be returned if the parameter is not found, or is not an output parameter.",
                            ParameterType = "TValue",
                            ParameterName = "value"
                        },
                    },
                    MethodCode = new String[]
                    {
                        "IDataParameter parameter = command.Parameters.Contains(name) ? command.Parameters[name] as IDataParameter : null;",
                        "if (parameter != null && (parameter.Direction == ParameterDirection.Output || parameter.Direction == ParameterDirection.InputOutput))",
                        "    value = parameter.Value.ConvertTo<TValue>();",
                        "",
                        "return value;"
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Retrieves all existing <typeparamref name=\"TRecord\" /> instances from the data store.",
                    XmlReturns = "The enumerable collection of <typeparamref name=\"TRecord\" /> instances that are persisted within the data store.",
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    MethodType = "IEnumerable<TRecord>",
                    Name = "FetchAll",
                    MethodCode = new String[]
                    {
                        "DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll);",
                        "return this.Execute(command);"
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Creates a new <typeparamref name=\"TRecord\" /> instance within the data store.",
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    Name = "Create",
                    MethodParameters = new CSharpParameter[] {
                        new CSharpParameter() {
                            XmlSummary = "The data structure to be created within the data store.",
                            ParameterType = "TRecord",
                            ParameterName = "record"
                        }
                    },
                    MethodCode = new String[]
                    {
                        "DbCommand command = this.GetStoredProcedure(SqlServerOperation.Create);",
                        "this.MapParametersIn(command, record, false);",
                        "this.Execute(command);",
                        "this.MapParametersOut(command, record);"
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Modifies an existing <typeparamref name=\"TRecord\" /> instance within the data store.",
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    Name = "Modify",
                    MethodParameters = new CSharpParameter[] {
                        new CSharpParameter() {
                            XmlSummary = "The data structure to be modified within the data store.",
                            ParameterType = "TRecord",
                            ParameterName = "record"
                        }
                    },
                    MethodCode = new String[]
                    {
                        "DbCommand command = this.GetStoredProcedure(SqlServerOperation.Modify);",
                        "this.MapParametersIn(command, record, false);",
                        "this.Execute(command);",
                        "this.MapParametersOut(command, record);"
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Removes an existing <typeparamref name=\"TRecord\" /> instance from the data store.",
                    MethodAbstraction = CSharpAbstractions.Virtual,
                    Name = "RemoveById",
                    MethodParameters = new CSharpParameter[] {
                        new CSharpParameter() {
                            XmlSummary = "The data structure to be removed from the data store.",
                            ParameterType = "TRecord",
                            ParameterName = "record"
                        }
                    },
                    MethodCode = new String[]
                    {
                        "DbCommand command = this.GetStoredProcedure(SqlServerOperation.Remove, \"Id\");",
                        "this.MapParametersIn(command, record, false);",
                        "this.Execute(command);",
                        "this.MapParametersOut(command, record);"
                    }
                };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="SqlServerRepositoryOfTRecordDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public SqlServerRepositoryOfTRecordDynamic(GeneratedProject project) : base(project)
        {
        }

        #endregion
    }
}
