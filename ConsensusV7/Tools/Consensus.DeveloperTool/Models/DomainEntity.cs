using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    public class DomainEntity : VersionData
    {
        #region fields

        /// <summary>
        ///     The scoping container that the entity belongs to.
        /// </summary>
        private DomainContainer _container;

        /// <summary>
        ///     The database table that is referenced by the entity.
        /// </summary>
        private DomainTable _referencedTable;

        /// <summary>
        ///     The database column that is used to filter the entity.
        /// </summary>
        private DomainTableColumn _filterColumn;

        /// <summary>
        ///     The collection of attributes defined against the entity.
        /// </summary>
        private DomainEntityAttribute[] _entityAttributes;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the scoping container that the entity belongs to.
        /// </summary>
        public DomainContainer Container
        {
            get { return _container; }
        }

        /// <summary>
        ///     Gets or sets the name of the domain entity.
        /// </summary>
        public String EntityName
        {
            get { return base.GetValue<String>("name"); }
            set { base.SetValue<String>("name", value); }
        }

        /// <summary>
        ///     Gets or sets the description for the domain entity.
        /// </summary>
        public String EntityDescription
        {
            get { return base.GetValue<String>("description"); }
            set { base.SetValue<String>("description", value); }
        }

        /// <summary>
        ///    Gets the collection of attributes defined against the entity.
        /// </summary>
        public virtual DomainEntityAttribute[] EntityAttributes
        {
            get
            {
                if (_entityAttributes == null)
                    _entityAttributes = this.ReferencedTable.TableColumns.Select(column => new DomainEntityAttribute(this, column)).ToArray();
                
                _entityAttributes = _entityAttributes.Where(attr => attr.Column.Exists).ToArray();
                return _entityAttributes;
            }
        }

        /// <summary>
        ///     Gets or sets whether the entity is abstracted.
        /// </summary>
        public Boolean EntityIsAbstract
        {
            get { return base.GetValue<Boolean>("isAbstract"); }
            set { base.SetValue<Boolean>("isAbstract", value); }
        }

        /// <summary>
        ///     Gets or sets whether the entity is creatable.
        /// </summary>
        public Boolean EntityIsCreatable
        {
            get { return !base.GetValue<Boolean>("isNonCreatable"); }
            set { base.SetValue<Boolean>("isNonCreatable", !value); }
        }

        /// <summary>
        ///     Gets or sets whether the entity is modifiable.
        /// </summary>
        public Boolean EntityIsModifiable
        {
            get { return !base.GetValue<Boolean>("isNonModifiable"); }
            set { base.SetValue<Boolean>("isNonModifiable", !value); }
        }

        /// <summary>
        ///     Gets or sets whether the entity is removable.
        /// </summary>
        public Boolean EntityIsRemovable
        {
            get { return !base.GetValue<Boolean>("isNonRemovable"); }
            set { base.SetValue<Boolean>("isNonRemovable", !value); }
        }

        /// <summary>
        ///    Gets or sets the database column that is used to filter the entity.
        /// </summary>
        public DomainTableColumn FilterColumn
        {
            get
            {
                if (_filterColumn == null && this.ReferencedTable != null)
                    _filterColumn = this.ReferencedTable.TableColumns.FirstOrDefault(column => column.Guid == this.GetValue<Guid?>("filterColumn"));

                return _filterColumn;
            }
            set
            {
                this.SetValue<Guid?>("filterColumn", value == null ? null : (Guid?)value.Guid);
                _filterColumn = value;
            }
        }

        /// <summary>
        ///    Gets or sets the type of filter applied to the entity.
        /// </summary>
        public DomainEntityFilterType FilterType
        {
            get { return base.GetValue<DomainEntityFilterType>("filterType"); }
            set { base.SetValue<DomainEntityFilterType>("filterType", value); }
        }

        /// <summary>
        ///     Gets or sets the value of the filter.
        /// </summary>
        public String FilterValue
        {
            get { return base.GetValue<String>("filterValue"); }
            set { base.SetValue<String>("filterValue", value); }
        }

        /// <summary>
        ///     Gets the C# code for filtering the model.
        /// </summary>
        public String FilterCode
        {
            get
            {
                if (this.FilterColumn == null || String.IsNullOrEmpty(this.FilterValue))
                    return null;

                switch (this.FilterType)
                {
                    case DomainEntityFilterType.List:
                        return String.Join(" || ", this.FilterValue.Split(',').Select(value => DomainEntity.GetComparison(this.FilterColumn.ProgrammaticName, DomainEntityFilterType.Equal, value.Trim(), this.FilterColumn.ColumnType)));
                    case DomainEntityFilterType.NotList:
                        return String.Join(" && ", this.FilterValue.Split(',').Select(value => DomainEntity.GetComparison(this.FilterColumn.ProgrammaticName, DomainEntityFilterType.Inequal, value.Trim(), this.FilterColumn.ColumnType)));
                    default:
                        return DomainEntity.GetComparison(this.FilterColumn.ProgrammaticName, this.FilterType, this.FilterValue, this.FilterColumn.ColumnType);
                }
            }
        }

        /// <summary>
        ///     Gets or sets the database table that is referenced by the entity.
        /// </summary>
        public DomainTable ReferencedTable
        {
            get
            {
                if (_referencedTable == null)
                    _referencedTable = this.Container.Domain.Tables.FirstOrDefault(table => table.Guid == this.GetValue<Guid?>("table"));

                return _referencedTable;
            }
            set
            {
                this.SetValue<Guid?>("table", value == null ? null : (Guid?)value.Guid);
                _referencedTable = value;
            }
        }

        /// <summary>
        ///    Gets the current version of the object to inspect.
        /// </summary>
        public override Version Version
        {
            get { return this.Container.Version; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="DomainEntity" /> instance.
        /// </summary>
        public DomainEntity(DomainContainer container) : base(container.Version)
        {
            _container = container;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets whether this entity inherits the specified entity, directly or through the inheritence chain.
        /// </summary>
        public virtual Boolean Inherits(DomainEntity entity)
        {
            return false;
        }

        /// <summary>
        ///     Serialises the version history from into the specified xml element.
        /// </summary>
        internal override void Serialise(XmlNode parentNode)
        {
            this.Serialise(parentNode, "entity");
        }

        /// <summary>
        ///     Serialises the version history into the specified xml element.
        /// </summary>
        protected void Serialise(XmlNode parentNode, String nodeName)
        {
            if (!this.Deleted.HasValue || this.Deleted.Value != this.Created)
            {
                XmlNode xmlNode = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement(nodeName));
                base.Serialise(xmlNode);
                this.EntityAttributes.Where(item => item.AttributeExposed && item.Entity == this).Execute(attr => attr.Serialise(xmlNode));
            }
        }

        /// <summary>
        ///     Deserialises the version history from the specified xml element.
        /// </summary>
        internal static void Deserialise(DomainContainer container, XmlNode parentNode)
        {
            foreach (XmlNode xmlNode in parentNode.SelectNodes("entity"))
            {
                DomainEntity result = container.CreateEntity();
                result.Deserialise(xmlNode);
                result.EntityAttributes.Execute(item => item.Deserialise(xmlNode));
            }
        }

        private static String GetComparison(String member, DomainEntityFilterType type, String value, DomainDataType programmaticType)
        {
            DescriptionAttribute comparitiveOperator = typeof(DomainEntityFilterType).GetField(type.ToString(), BindingFlags.Public | BindingFlags.Static).GetCustomAttributes().OfType<DescriptionAttribute>().FirstOrDefault();
            switch (programmaticType)
            {
                case DomainDataType.Boolean: return String.Format("record.{0} {1} {2}", member, comparitiveOperator.Description, value.ConvertTo<Boolean>() ? "true" : "false");
                case DomainDataType.Byte: return String.Format("record.{0} {1} {2}", member, comparitiveOperator.Description, value.ConvertTo<Byte>().ToString());
                case DomainDataType.Char: return String.Format("record.{0} {1} \"{2}\"", member, comparitiveOperator.Description, value.Replace("\"", "\\\""));
                case DomainDataType.DateTime: return String.Format("record.{0} {1} new DateTime({2})", member, comparitiveOperator.Description, value.ConvertTo<DateTime>().ToString("yyyy, mm, dd"));
                case DomainDataType.Decimal: return String.Format("record.{0} {1} {2}M", member, comparitiveOperator.Description, value.ConvertTo<Decimal>().ToString());
                case DomainDataType.Double: return String.Format("record.{0} {1} {2}D", member, comparitiveOperator.Description, value.ConvertTo<Double>().ToString());
                case DomainDataType.Guid: return String.Format("record.{0} {1} new Guid(\"{2}\")", member, comparitiveOperator.Description, value.ConvertTo<Guid>().ToString());
                case DomainDataType.Int16: return String.Format("record.{0} {1} {2}", member, comparitiveOperator.Description, value.ConvertTo<Int16>().ToString());
                case DomainDataType.Int32: return String.Format("record.{0} {1} {2}", member, comparitiveOperator.Description, value.ConvertTo<Int32>().ToString());
                case DomainDataType.Int64: return String.Format("record.{0} {1} {2}", member, comparitiveOperator.Description, value.ConvertTo<Int64>().ToString());
                case DomainDataType.Single: return String.Format("record.{0} {1} {2}F", member, comparitiveOperator.Description, value.ConvertTo<Double>().ToString());
                case DomainDataType.NChar: return String.Format("record.{0} {1} \"{2}\"", member, comparitiveOperator.Description, value.Replace("\"", "\\\""));
                case DomainDataType.NVarchar: return String.Format("record.{0} {1} \"{2}\"", member, comparitiveOperator.Description, value.Replace("\"", "\\\""));
                case DomainDataType.Varchar: return String.Format("record.{0} {1} \"{2}\"", member, comparitiveOperator.Description, value.Replace("\"", "\\\""));
            }
            return null;
        }

        #endregion
    }
}
