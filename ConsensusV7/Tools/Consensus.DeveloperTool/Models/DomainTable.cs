using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a database table within the domain.
    /// </summary>
    public class DomainTable : VersionData
    {
        #region fields

        /// <summary>
        ///     The name of the code value table
        /// </summary>
        public const String CODE_TABLE = "Code";

        /// <summary>
        ///     The domain that the table belongs to.
        /// </summary>
        private Domain _domain;

        /// <summary>
        ///     The column prefix used within the database table.
        /// </summary>
        private String _tablePrefix;

        /// <summary>
        ///     The column which is used as the primary key for the table.
        /// </summary>
        private DomainTableColumn _tableKey;

        /// <summary>
        ///     The collection of columns defined within the table.
        /// </summary>
        private List<DomainTableColumn> _tableColumns;

        /// <summary>
        ///     The collection of indexes defined within the table.
        /// </summary>
        private List<DomainTableIndex> _tableIndexes;

        /// <summary>
        ///     The collection of constraints defined within the table.
        /// </summary>
        private List<DomainTableConstraint> _tableConstraints;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the domain that the table belongs to.
        /// </summary>
        public Domain Domain
        {
            get { return _domain; }
        }
        
        /// <summary>
        ///     Gets or sets the name of the database table.
        /// </summary>
        public String TableName
        {
            get { return base.GetValue<String>("name"); }
            set { base.SetValue<String>("name", value); }
        }

        /// <summary>
        ///     Gets or sets the description for the database table.
        /// </summary>
        public String TableDescription
        {
            get { return base.GetValue<String>("description"); }
            set { base.SetValue<String>("description", value); }
        }

        /// <summary>
        ///     Gets the column prefix used within the database table.
        /// </summary>
        public String TablePrefix
        {
            get
            {
                if (_tablePrefix == null)
                {
                    String[] names = this.TableColumns.Where(column => !String.IsNullOrEmpty(column.ColumnName)).Select(column => column.ColumnName.ToUpper()).ToArray();
                    Int32[] lengths = Enumerable.Range(1, names.Max(name => name.Length)).ToArray();
                    String[] prefixes = lengths.SelectMany(length => names.Select(name => name.Substring(0, Math.Min(name.Length, length)).ToUpper())).Distinct().ToArray();
                    _tablePrefix = prefixes.LastOrDefault(prefix => names.All(name => name.StartsWith(prefix))) ?? String.Empty;
                }
                return _tablePrefix;
            }
        }

        /// <summary>
        ///    Gets the column which is used as the primary key for the table.
        /// </summary>
        public DomainTableColumn TableKey
        {
            get
            {
                if (_tableKey == null)
                    _tableKey = this.TableColumns.FirstOrDefault();

                return _tableKey;
            }
        }

        /// <summary>
        ///     Gets the collection of columns defined within the table.
        /// </summary>
        public DomainTableColumn[] TableColumns
        {
            get { return _tableColumns.ToArray(); }
        }

        /// <summary>
        ///     Gets the collection of indexes defined within the table.
        /// </summary>
        public DomainTableIndex[] TableIndexes
        {
            get { return _tableIndexes.ToArray(); }
        }

        /// <summary>
        ///     Gets the collection of constraints defined within the table.
        /// </summary>
        public DomainTableConstraint[] TableConstraints
        {
            get { return _tableConstraints.ToArray(); }
        }

        /// <summary>
        ///     Gets or sets the name used for type generation.
        /// </summary>
        public String ProgrammaticName
        {
            get { return base.GetValue<String>("programmaticName") ?? this.TableName.ToPascal(); }
            set { base.SetValue<String>("programmaticName", value == this.TableName.ToPascal() ? null : value); }
        }

        /// <summary>
        ///    Gets the current version of the object to inspect.
        /// </summary>
        public override Version Version
        {
            get { return this.Domain.Version; }
        }

        /// <summary>
        ///    Gets or sets the identifier for primary key allocations.
        /// </summary>
        public Int32? TableKeyAllocation
        {
            get { return base.GetValue<Int32?>("allocation"); }
            set { base.SetValue<Int32?>("allocation", value); }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="DomainTable" /> instance.
        /// </summary>
        public DomainTable(Domain domain) : base(domain.Version)
        {
            _domain = domain;
            _tableColumns = new List<DomainTableColumn>();
            _tableIndexes = new List<DomainTableIndex>();
            _tableConstraints = new List<DomainTableConstraint>();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new database column within the table.
        /// </summary>
        public DomainTableColumn CreateColumn()
        {
            DomainTableColumn column = new DomainTableColumn(this);
            _tableColumns.Add(column);
            return column;
        }

        /// <summary>
        ///     Creates a new database index within the table.
        /// </summary>
        public DomainTableIndex CreateIndex()
        {
            DomainTableIndex index = new DomainTableIndex(this);
            _tableIndexes.Add(index);
            return index;
        }

        /// <summary>
        ///     Creates a new database constraint within the table.
        /// </summary>
        public DomainTableConstraint CreateConstraint()
        {
            DomainTableConstraint constraint = new DomainTableConstraint(this);
            _tableConstraints.Add(constraint);
            return constraint;
        }

        /// <summary>
        ///     Serialises the version history from into the specified xml element.
        /// </summary>
        internal override void Serialise(XmlNode parentNode)
        {
            if (!this.Deleted.HasValue || this.Deleted.Value != this.Created)
            {
                XmlNode xmlNode = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement("table"));
                base.Serialise(xmlNode);
                this.TableColumns.Execute(item => item.Serialise(xmlNode));
                this.TableIndexes.Execute(item => item.Serialise(xmlNode));
                this.TableConstraints.Execute(item => item.Serialise(xmlNode));
            }
        }

        /// <summary>
        ///     Deserialises the version history from the specified xml element.
        /// </summary>
        internal static void Deserialise(Domain domain, XmlNode parentNode)
        {
            foreach (XmlNode xmlNode in parentNode.SelectNodes("table"))
            {
                DomainTable result = domain.CreateTable();
                result.Deserialise(xmlNode);
                DomainTableColumn.Deserialise(result, xmlNode);
                DomainTableIndex.Deserialise(result, xmlNode);
                DomainTableConstraint.Deserialise(result, xmlNode);
            }
        }

        #endregion
    }
}
