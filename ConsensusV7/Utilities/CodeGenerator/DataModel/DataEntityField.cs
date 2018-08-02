using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.DataModel
{
    /// <summary>
    ///     Represents a field that has been defined against an entity.
    /// </summary>
    [Serializable]
    public class DataEntityField
    {
        #region enum

        [Flags]
        public enum Exposure
        {
            Excluded = 0,
            Getter = 1,
            Setter = 2
        }

        #endregion

        #region fields

        /// <summary>
        ///     The exposure of the field
        /// </summary>
        private Exposure? _codeExposure;

        /// <summary>
        ///     The entity that this field relates to
        /// </summary>
        private String _relatedEntityName;

        /// <summary>
        ///     The field that this field relates to
        /// </summary>
        private String _relatedFieldName;

        #endregion
        
        #region properties

        /// <summary>
        ///     Gets the entity in which the field is defined.
        /// </summary>
        internal DataEntity Parent { get; private set; }

        /// <summary>
        ///     Gets or sets whether the field stores a primary key identifier
        /// </summary>
        public Boolean IsPrimaryKey { get; private set; }

        /// <summary>
        ///     Gets or sets the identifier of the underlying data object.
        /// </summary>
        public Int32 ObjectId { get; set; }

        /// <summary>
        ///     Gets or sets the name of the underlying data object.
        /// </summary>
        public String ObjectName { get; set; }

        /// <summary>
        ///     Gets the name of the underlying data object, without the object prefix
        /// </summary>
        public String ObjectShortName
        {
            get 
            { 
                String shortName = this.ObjectName.Substring(this.Parent.ObjectPrefix.Length + 1).ToPascal();
                if (shortName.All(chr => Char.IsDigit(chr)))
                    shortName = UInt64.Parse(shortName).ToText().ToPascal();
                else if (Char.IsDigit((shortName[0])))
                    shortName = "Num" + shortName;

                return shortName;
            }
        }

        /// <summary>
        ///     Gets or sets the name of the underlying data type.
        /// </summary>
        public String ObjectType { get; set; }

        /// <summary>
        ///     Gets or sets the name of the underlying data type along with the size and precision, where applicable
        /// </summary>
        public String ObjectTypeFull { get; set; }

        /// <summary>
        ///     Gets or sets whether the underlying data object is nullable.
        /// </summary>
        public Boolean ObjectNull { get; set; }

        /// <summary>
        ///     Gets the fields database type.
        /// </summary>
        public DbType DataType
        {
            get
            {
                switch (this.ObjectType.ToLower())
                {
                    case "bigint": return DbType.Int64;
                    case "binary": return DbType.Binary;
                    case "bit": return DbType.Boolean;
                    case "char": return DbType.StringFixedLength;
                    case "date": return DbType.Date;
                    case "datetime": return DbType.DateTime;
                    case "datetime2": return DbType.DateTime2;
                    case "datetimeoffset": return DbType.DateTimeOffset;
                    case "decimal": return DbType.Decimal;
                    case "float": return DbType.Double;
                    case "image": return DbType.Binary;
                    case "int": return DbType.Int32;
                    case "money": return DbType.Currency;
                    case "nchar": return DbType.AnsiStringFixedLength;
                    case "ntext": return DbType.AnsiString;
                    case "numeric": return DbType.Decimal;
                    case "nvarchar": return DbType.AnsiString;
                    case "real": return DbType.Single;
                    case "smalldatetime": return DbType.DateTime;
                    case "smallint": return DbType.Int16;
                    case "smallmoney": return DbType.Currency;
                    case "text": return DbType.String;
                    case "time": return DbType.Time;
                    case "timestamp": return DbType.Time;
                    case "tinyint": return DbType.Byte;
                    case "uniqueidentifier": return DbType.Guid;
                    case "varbinary": return DbType.Binary;
                    case "varchar": return DbType.String;
                    case "xml": return DbType.Xml;
                    default: return DbType.Object;
                }
            }
        }
        
        /// <summary>
        ///     Gets or sets the programmatic name of the field.
        /// </summary>
        public String CodeName { get; set; }

        /// <summary>
        ///     Gets or sets the programmatic description for field.
        /// </summary>
        public String CodeDescription { get; set; }

        /// <summary>
        ///     Gets or sets the unique name of the code header.
        /// </summary>
        public String CodeHeader { get; set; }

        /// <summary>
        ///     Gets or sets the exposure of the field
        /// </summary>
        public Exposure CodeExposure
        {
            get
            {
                if (_codeExposure.HasValue)
                    return _codeExposure.Value;
                else if (!String.IsNullOrEmpty(this.CodeName))
                    return Exposure.Getter | Exposure.Setter;
                else
                    return Exposure.Excluded;                
            }
            set
            {
                _codeExposure = value;
            }
        }

        /// <summary>
        ///     Gets the fields programmatic data type.
        /// </summary>
        public System.Type CodeType
        {
            get
            {
                switch (this.DataType)
                {
                    case DbType.AnsiString: return typeof(String);
                    case DbType.AnsiStringFixedLength: return typeof(String);
                    case DbType.Binary: return typeof(Byte[]);
                    case DbType.Boolean: return typeof(Boolean);
                    case DbType.Byte: return typeof(Byte);
                    case DbType.Currency: return typeof(Decimal);
                    case DbType.Date: return typeof(DateTime);
                    case DbType.DateTime: return typeof(DateTime);
                    case DbType.Decimal: return typeof(Decimal);
                    case DbType.Double: return typeof(Double);
                    case DbType.Guid: return typeof(Guid);
                    case DbType.Int16: return typeof(Int16);
                    case DbType.Int32: return typeof(Int32);
                    case DbType.Int64: return typeof(Int64);
                    case DbType.SByte: return typeof(SByte);
                    case DbType.Single: return typeof(Single);
                    case DbType.String: return typeof(String);
                    case DbType.StringFixedLength: return typeof(String);
                    case DbType.Time: return typeof(TimeSpan);
                    case DbType.UInt16: return typeof(UInt16);
                    case DbType.UInt32: return typeof(UInt32);
                    case DbType.UInt64: return typeof(UInt64);
                    case DbType.VarNumeric: return typeof(Decimal);
                    default: return typeof(Object);
                }
            }
        }

        /// <summary>
        ///     Gets the name of the fields programmatic data type.
        /// </summary>
        public String CodeTypeName
        {
            get
            {
                if (this.CodeType.IsArray)
                    return this.CodeType.GetElementType().Name;
                else if (!this.CodeType.IsClass && this.ObjectNull)
                    return this.CodeType.Name + "?";
                else
                    return this.CodeType.Name;
            }
        }

        /// <summary>
        ///     Gets or sets the entity that this field relates to
        /// </summary>
        public DataEntity RelatedEntity
        {
            get { return this.Parent.Parent.Domains.SelectMany(domain => domain.Entities).FirstOrDefault(ent => ent.ObjectName == _relatedEntityName); }
            set { _relatedEntityName = (value == null) ? null : value.ObjectName; }
        }

        /// <summary>
        ///     Gets or sets the field that this field relates to
        /// </summary>
        public DataEntityField RelatedField
        {
            get { return this.RelatedEntity == null ? null : this.RelatedEntity.Fields.FirstOrDefault(field => field.ObjectName == _relatedFieldName); }
            set { _relatedFieldName = (value == null) ? null : value.ObjectName; }
        }

        /// <summary>
        ///     Gets or sets whether the field stores a unique value
        /// </summary>
        public Boolean IsUnique { get; set; }
        
        #endregion

        #region methods

        /// <summary>
        ///     Saves changes to the entity
        /// </summary>
        public void Save()
        {
            this.Parent.Parent.Execute("SaveEntityField", 
                this.Parent.ObjectId, 
                this.Parent.ObjectName, 
                this.ObjectId, 
                this.ObjectName, 
                this.CodeName, 
                this.CodeDescription, 
                _relatedEntityName, 
                _relatedFieldName, 
                this.CodeHeader,
                this.IsUnique ? 1 : 0);
        }

        private static DataEntityField Parse(IDataRecord record, DataEntity entity)
        {
            DataEntityField field = new DataEntityField()
            {
                Parent = entity,
                ObjectId = record["ObjectId"].ConvertTo<Int32>(),
                ObjectName = record["ObjectName"].ConvertTo<String>(),
                ObjectType = record["ObjectType"].ConvertTo<String>(),
                ObjectTypeFull = record["ObjectTypeFull"].ConvertTo<String>(),
                ObjectNull = record["ObjectNull"].ConvertTo<Boolean>(),
                CodeName = record["CodeName"].ConvertTo<String>(),
                CodeDescription = record["CodeDescription"].ConvertTo<String>(),
                CodeHeader = record["CodeHeader"].ConvertTo<String>(),
                IsPrimaryKey = record["IsPrimaryKey"].ConvertTo<Boolean>(),
                IsUnique = record["IsUnique"].ConvertTo<Boolean>(),
                _relatedEntityName = record["RelatedEntity"].ConvertTo<String>(),
                _relatedFieldName = record["RelatedField"].ConvertTo<String>(),
            };

            // Ensure primary keys use static code name 
            if (field.IsPrimaryKey && (String.IsNullOrEmpty(field.CodeName) || !String.Equals(field.CodeName, "Id", StringComparison.OrdinalIgnoreCase)))
            {
                field.CodeName = "Id";
                field.Save();
            }

            // Ensure primary keys use static code description
            if (field.IsPrimaryKey && (String.IsNullOrEmpty(field.CodeDescription) || !String.Equals(field.CodeDescription, "The unique value which distinctly identifies this data instance.", StringComparison.OrdinalIgnoreCase)))
            {
                field.CodeDescription = (field.IsPrimaryKey && String.IsNullOrEmpty(field.CodeDescription)) ? "The unique value which distinctly identifies this data instance." : field.CodeDescription;
                field.Save();
            }

            return field;
        }

        /// <summary>
        ///     Gets all fields defined for a specific entity.
        /// </summary>
        /// <param name="entity">
        ///     The data entities to which, the returned fields will belong.
        /// </param>
        /// <returns>
        ///     An enumerable collection of data entity fields.
        /// </returns>
        public static IEnumerable<DataEntityField> GetAll(DataEntity entity)
        {
            return entity.Parent.Execute(DataEntityField.Parse, entity, "GetEntityField", entity.ObjectId);
        }

        #endregion
    }
}
