using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a database column within the domain.
    /// </summary>
    public class DomainTableColumn : VersionData
    {
        #region fields

        /// <summary>
        ///     The database table that the column belongs to.
        /// </summary>
        private DomainTable _table;

        #endregion

        #region properties

        /// <summary>
        ///     Gets whether the column is used for auditing purposes
        /// </summary>
        public Boolean ColumnIsAuditor
        {
            get
            {
                return
                    String.Equals(this.ColumnName, this.Table.TablePrefix + "ADD_DATE", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(this.ColumnName, this.Table.TablePrefix + "ADD_BY", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(this.ColumnName, this.Table.TablePrefix + "MOD_DATE", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(this.ColumnName, this.Table.TablePrefix + "MOD_BY", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(this.ColumnName, this.Table.TablePrefix + "RCV_DATE", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(this.ColumnName, this.Table.TablePrefix + "RCV_BY", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(this.ColumnName, this.Table.TablePrefix + "RCV_FROM", StringComparison.OrdinalIgnoreCase);
            }
        }

        /// <summary>
        ///    Gets the database table that the column belongs to.
        /// </summary>
        public DomainTable Table
        {
            get { return _table; }
        }

        /// <summary>
        ///     Gets or sets the ordinal position of the database column.
        /// </summary>
        public Int32 ColumnOrdinal
        {
            get { return base.GetValue<Int32>("ordinal"); }
            set { base.SetValue<Int32>("ordinal", value); }
        }
        
        /// <summary>
        ///     Gets the name of the database column
        /// </summary>
        public String ColumnName
        {
            get { return base.GetValue<String>("name"); }
            set { base.SetValue<String>("name", value); }
        }

        /// <summary>
        ///     Gets or sets the description for the column.
        /// </summary>
        public String ColumnDescription
        {
            get { return base.GetValue<String>("description"); }
            set { base.SetValue<String>("description", value); }
        }

        /// <summary>
        ///     Gets or sets the type of the column.
        /// </summary>
        public DomainDataType ColumnType
        {
            get { return base.GetValue<DomainDataType>("type"); }
            set { base.SetValue<DomainDataType>("type", value); }
        }

        /// <summary>
        ///     Gets or sets the length of the column.
        /// </summary>
        public Int32 ColumnLength
        {
            get { return base.GetValue<Int32>("length"); }
            set { base.SetValue<Int32>("length", value); }
        }

        /// <summary>
        ///     Gets or sets the precision of the column.
        /// </summary>
        public Int32 ColumnScale
        {
            get { return base.GetValue<Int32>("scale"); }
            set { base.SetValue<Int32>("scale", value); }
        }

        /// <summary>
        ///     Gets or sets the scale of the column.
        /// </summary>
        public Boolean ColumnNullable
        {
            get { return base.GetValue<Boolean>("nullable"); }
            set { base.SetValue<Boolean>("nullable", value); }
        }

        /// <summary>
        ///     Gets or sets the default value of the column.
        /// </summary>
        public String ColumnDefaultValue
        {
            get { return base.GetValue<String>("default"); }
            set { base.SetValue<String>("default", value); }
        }

        /// <summary>
        ///     Gets or sets the name used for type generation.
        /// </summary>
        public String ProgrammaticName
        {
            get
            {
                String result;
                if (this == this.Table.TableKey)
                    result = "Id";
                else if (!String.IsNullOrEmpty(base.GetValue<String>("programmaticName")))
                    result = base.GetValue<String>("programmaticName");                
                else if (String.IsNullOrEmpty(this.ColumnName))
                    result = String.Empty;
                else if (this.ColumnName.StartsWith(this.Table.TablePrefix) && !String.Equals(this.ColumnName, this.Table.TablePrefix, StringComparison.OrdinalIgnoreCase))
                    result = this.ColumnName.Substring(this.Table.TablePrefix.Length).ToPascal();
                else
                    result = this.ColumnName.ToPascal();

                return result;
            }
            set
            {
                base.SetValue<String>("programmaticName", value == this.ColumnName.Substring(this.Table.TablePrefix.Length).ToPascal() ? null : value);
            }
        }

        /// <summary>
        ///     Gets the Microsoft.NET type that corresponds to the data type of the column.
        /// </summary>
        public String ProgrammaticType
        {
            get
            {
                switch (this.ColumnType)
                {
                    case DomainDataType.VarBinary: return "Byte[]";
                    case DomainDataType.Char: return "String";
                    case DomainDataType.NChar: return "String";
                    case DomainDataType.NVarchar: return "String";
                    case DomainDataType.Varchar: return "String";
                    default: return this.ColumnType.ToString() + (this.ColumnNullable ? "?" : "");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the name of the parameter name that corresponds to the column.
        /// </summary>
        public String ParameterName
        {
            get { return base.GetValue<String>("parameterName") ?? "@PA_" + this.ColumnName; }
            set { base.SetValue<String>("parameterName", value == "@PA_" + this.ColumnName ? null : value); }
        }

        /// <summary>
        ///     Gets the parameter data type definition
        /// </summary>
        public String ParameterType
        {
            get
            {
                switch (this.ColumnType)
                {
                    case DomainDataType.Decimal: return String.Format("{0}({1}, {2})", this.ColumnType.ToString().ToLower(), this.ColumnLength, this.ColumnScale);
                    case DomainDataType.Char:
                    case DomainDataType.NChar:
                    case DomainDataType.NVarchar:
                    case DomainDataType.VarBinary:
                    case DomainDataType.Varchar: return String.Format("{0}({1})", this.ColumnType.ToString().ToLower(), this.ColumnLength <= 0 ? "max" : this.ColumnLength.ToString());
                    case DomainDataType.Boolean: return "bit";
                    case DomainDataType.Guid: return "uniqueidentifier";
                    case DomainDataType.Byte: return "tinyint";
                    case DomainDataType.Int16: return "smallint";
                    case DomainDataType.Int32: return "integer";
                    case DomainDataType.Int64: return "bigint";
                    case DomainDataType.Double: return "float";
                    case DomainDataType.Single: return "real";
                    default: return this.ColumnType.ToString().ToLower();
                }
            }
        }

        /// <summary>
        ///    Gets the current version of the object to inspect.
        /// </summary>
        public override Version Version
        {
            get { return this.Table.Version; }
        }
        
        /// <summary>
        ///     Gets or sets the length of the column.
        /// </summary>
        public String ColumnLengthText
        {
            get
            {
                switch (this.ColumnType)
                {
                    case DomainDataType.VarBinary:
                    case DomainDataType.Char:
                    case DomainDataType.NChar:
                    case DomainDataType.NVarchar:
                    case DomainDataType.Varchar:
                        return this.ColumnLength <= 0 ? "(max)" : this.ColumnLength.ToString();
                    case DomainDataType.Decimal:
                        return this.ColumnLength.ToString();
                    default:
                        return String.Empty;
                }
            }
            set
            {
                Int32 parsedValue;
                switch (this.ColumnType)
                {
                    case DomainDataType.VarBinary:
                    case DomainDataType.Char:
                    case DomainDataType.NChar:
                    case DomainDataType.NVarchar:
                    case DomainDataType.Varchar:
                        if (String.Equals(value, "(max)", StringComparison.OrdinalIgnoreCase) || String.Equals(value, "(max)", StringComparison.OrdinalIgnoreCase))
                            this.ColumnLength = 0;
                        else if (Int32.TryParse(value, out parsedValue))
                            this.ColumnLength = parsedValue;
                        break;
                    case DomainDataType.Decimal:
                        if (Int32.TryParse(value, out parsedValue))
                            this.ColumnLength = parsedValue;   
                        break;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the precision of the column.
        /// </summary>
        public String ColumnScaleText
        {
            get
            {
                switch (this.ColumnType)
                {
                    case DomainDataType.Decimal:
                        return this.ColumnScale.ToString();
                    default:
                        return String.Empty;
                }
            }
            set
            {
                Int32 parsedValue;
                switch (this.ColumnType)
                {
                    case DomainDataType.Decimal:
                        if (Int32.TryParse(value, out parsedValue))
                            this.ColumnScale = parsedValue;
                        break;
                }
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="DomainTableColumn" /> instance.
        /// </summary>
        public DomainTableColumn(DomainTable table) : base(table.Version)
        {
            _table = table;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Serialises the version history from into the specified xml element.
        /// </summary>
        internal override void Serialise(XmlNode parentNode)
        {
            if (!this.Deleted.HasValue || this.Deleted.Value != this.Created)
            {
                XmlNode xmlNode = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement("column"));
                base.Serialise(xmlNode);
            }
        }

        /// <summary>
        ///     Deserialises the version history from the specified xml element.
        /// </summary>
        internal static void Deserialise(DomainTable table, XmlNode parentNode)
        {
            foreach (XmlNode xmlNode in parentNode.SelectNodes("column"))
            {
                DomainTableColumn result = table.CreateColumn();
                result.Deserialise(xmlNode);
            }
        }

        #endregion
    }
}
