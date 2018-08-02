using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Generates the dynamic-code file for the <see cref="DomainEntity"/>-driven repository class.
    /// </summary>
    public class SqlServerRepositoryFromEntityDynamic : GeneratedClass
    {
        #region fields

        /// <summary>
        ///     The domain entity from which the repository is generated.
        /// </summary>
        private DomainEntity _entity;

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
        ///     Gets whether the file should be overwritten, if the file already exists.
        /// </summary>
        public override Boolean FileIsEditable
        {
            get { return true; }
        }

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
            get { return "Provides the persistence and retrieval of the <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> instances in a Microsoft SQL Server database"; }
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
            get { return "SqlServer" + this.Entity.EntityName + "Repository"; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public override String TypeBase
        {
            get
            {
                return "SqlServerRepository<" + this.Entity.ReferencedTable.ProgrammaticName + "Record, " + this.Entity.ReferencedTable.TableKey.ProgrammaticType + ">";
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
                yield return "I" + this.Entity.EntityName + "Repository";
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
                    XmlSummary = "Gets the namespace in which the data type is contained.",
                    PropertyAbstraction = CSharpAbstractions.Override,
                    PropertyType = "String",
                    Name = "TypeNamespace",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorCode = new String[] { "return \"" + this.Entity.Container.ContainerName + "\";" },
                        AccessorModifier = CSharpModifiers.Protected
                    }
                };

                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the name of the data type which is persisted by this repository.",
                    PropertyAbstraction = CSharpAbstractions.Override,
                    PropertyType = "String",
                    Name = "TypeName",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorCode = new String[] { "return \"" + this.Entity.ReferencedTable.ProgrammaticName + "\";" },
                        AccessorModifier = CSharpModifiers.Protected
                    }
                };

                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" />",
                    PropertyAbstraction = CSharpAbstractions.Override,
                    PropertyType = "String",
                    Name = "TypeKeyName",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorCode = new String[] { "return \"" + this.Entity.ReferencedTable.TableKey.ParameterName + "\";" },
                        AccessorModifier = CSharpModifiers.Protected
                    }
                };

                yield return new CSharpProperty(this)
                {
                    XmlSummary = "Gets the underlying table name that this repository sit over.",
                    PropertyAbstraction = CSharpAbstractions.Override,
                    PropertyType = "String",
                    Name = "TableName",
                    PropertyGetter = new CSharpAccessor()
                    {
                        AccessorCode = new String[] { "return \"" + this.Entity.ReferencedTable.TableName + "\";" },
                        AccessorModifier = CSharpModifiers.Public
                    }
                };

                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Maps an <see cref=\"IDataRecord\" /> to the specified <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" />",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Override,
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
                            XmlSummary = "The <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> instance to be mapped to.",
                            ParameterType = this.Entity.ReferencedTable.ProgrammaticName + "Record",
                            ParameterName = "record"
                        }
                    },
                    MethodCode = this.Entity.ReferencedTable.TableColumns.Select(col => String.Format("record.{0} = dataRecord[\"{1}\"].ConvertTo<{2}>();", col.ProgrammaticName, col.ColumnName, col.ProgrammaticType)).ToArray()
                };

                List<String> parameterMappings = this.Entity.ReferencedTable.TableColumns.Where(column => !column.ColumnIsAuditor).Select(column => String.Format("this.MapParameterIn(command, \"{0}\", {1});", column.ParameterName, GetRecordValueExpression(column))).ToList();
                parameterMappings.Add("this.MapParameterIn(command, \"@_AUDIT_USER_ID\", UserId);");
                parameterMappings.Add("this.MapParameterIn(command, \"@PA_RETURN_ID\", record.Id);");
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Sets the parameter values for the specified <paramref name=\"command\" /> based on the specified <typeparamref name=\"TRecord\" /> instance.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Override,
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
                            XmlSummary = "The <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> instance to be mapped.",
                            ParameterType = this.Entity.ReferencedTable.ProgrammaticName + "Record",
                            ParameterName = "record"
                        },
                        new CSharpParameter()
                        {
                            XmlSummary = "Is the procedure being run an old version 6.x procedure? (the null value handling logic is different)",
                            ParameterType = "bool",
                            ParameterName = "useV6Logic"
                        }
                    },
                    MethodCode = parameterMappings.ToArray()
                };

                parameterMappings = this.Entity.ReferencedTable.TableColumns.Where(column => !column.ColumnIsAuditor).Select(column => String.Format("record.{1} = this.MapParameterOut(command, \"{0}\", record.{1});", column.ParameterName, column.ProgrammaticName)).ToList();
                parameterMappings.Add("record.Id = this.MapParameterOut(command, \"@PA_RETURN_ID\", record.Id);");
                yield return new CSharpMethod(this)
                {
                    XmlSummary = "Extracts the parameter values for the specified <paramref name=\"command\" /> and applies the values to the specified <typeparamref name=\"TRecord\" /> instance.",
                    MethodModifier = CSharpModifiers.Protected,
                    MethodAbstraction = CSharpAbstractions.Override,
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
                            XmlSummary = "The <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> instance to be updated.",
                            ParameterType = this.Entity.ReferencedTable.ProgrammaticName + "Record",
                            ParameterName = "record"
                        }
                    },
                    MethodCode = parameterMappings.ToArray()
                };

                DomainEntityAttribute[] referenceAttributes = this.Entity.Container.Domain.Containers
                    .SelectMany(entity => entity.ContainerEntities)
                    .Where(entity => entity.Exists && entity.ReferencedTable == this.Entity.ReferencedTable)
                    .SelectMany(entity => entity.EntityAttributes
                    .Where(attr => attr.Entity == entity && attr.ReferencedEntity != null && attr.ReferencedEntity.Exists && !String.Equals(attr.ReferencedEntity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase)))
                    .ToArray();
                foreach (DomainEntityAttribute attribute in referenceAttributes)
                {
                    String parameterName = attribute.Column.ProgrammaticName.Substring(0, 1).ToLower() + attribute.Column.ProgrammaticName.Substring(1);               
                    yield return new CSharpMethod(this)
                    {
                        XmlSummary = "Retrieves a collection of <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> instances from the data store.",
                        XmlReturns = "The collection of <see cref=\"" + this.Entity.ReferencedTable.ProgrammaticName + "Record\" /> instances that match the specified <paramref name='" + parameterName + "' />.",
                        MethodModifier = CSharpModifiers.Public,
                        MethodType = "IEnumerable<" + this.Entity.ReferencedTable.ProgrammaticName + "Record>",
                        Name = "FetchAllBy" + attribute.Column.ProgrammaticName,
                        MethodParameters = new CSharpParameter[]
                        {
                            new CSharpParameter()
                            {
                                XmlSummary = "The value which identifies the <see cref='" + this.Entity.EntityName + "Model' /> instances to be returned.",
                                ParameterType = attribute.Column.ProgrammaticType,
                                ParameterName = parameterName
                            }
                        },
                        MethodCode = new String[] {
                            "DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, \"" + attribute.Column.ProgrammaticName + "\");",
                            "this.MapParameterIn(command, \"" + attribute.Column.ParameterName + "\", " + parameterName + ");",
                            "return this.Execute(command);"
                        }
                    };
                }
            }
        }

        protected string GetRecordValueExpression(DomainTableColumn column)
        {
            StringBuilder expression = new StringBuilder();

            string valueType = column.ProgrammaticType.Replace("?", "");

            Type progType = Type.GetType("System." + valueType);

            if (progType != null && progType.IsSignedNumericOrDate())
            {
                expression.AppendFormat("record.{0} == {1}.MinValue ? ", column.ProgrammaticName, valueType);
                if (!column.ColumnNullable && !string.IsNullOrEmpty(column.ColumnDefaultValue))
                {
                    if (progType.Equals(typeof(Decimal)))
                        expression.Append(column.ColumnDefaultValue + "M"); // The standard represtation of an number needs an "M" appended to make it a decimal, e.g. 0 === int or double, 0M === decimal
                    else if (progType.Equals(typeof(DateTime)))
                    {
                        if (column.ColumnDefaultValue.Equals("getdate()", StringComparison.InvariantCultureIgnoreCase))
                            expression.Append("DateTime.Now");
                        else
                            expression.Append("new DateTime(1900,1,1)");
                    }
                    else
                        expression.Append(column.ColumnDefaultValue);
                }
                else
                {
                    expression.Append("( useV6Logic ? ");
                    if (progType.Equals(typeof(System.DateTime)))
                    {
                        if (!string.IsNullOrEmpty(column.ColumnDefaultValue) && column.ColumnDefaultValue.Equals("getdate()", StringComparison.InvariantCultureIgnoreCase))
                            expression.Append("new DateTime?(DateTime.Now)");
                        else
                            expression.Append("new DateTime?(new DateTime(1900,1,1))");
                    }
                    else
                    {
                        expression.AppendFormat("new {0}?({1}{2})", valueType, column.ColumnDefaultValue ?? "0", progType.Equals(typeof(Decimal)) ? "M" : "");
                    }
                    expression.Append(" : null )");
                }
                expression.Append(" : record." + column.ProgrammaticName);
            }

            if (expression.Length == 0)
                expression.Append("record." + column.ProgrammaticName);

            return expression.ToString(); ;
        }


        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="SqlServerRepositoryFromEntityDynamic" /> instance.
        /// </summary>
        /// <param name="project">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        /// <param name="entity">
        ///     Sets the domain entity from which the repository is generated.
        /// </param>
        public SqlServerRepositoryFromEntityDynamic(GeneratedProject project, DomainEntity entity) : base(project)
        {
            _entity = entity;
        }

        #endregion
    }
}
