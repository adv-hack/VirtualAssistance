using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    public class DomainTableConstraint : VersionData
    {
        #region fields

        /// <summary>
        ///     The database table that the constraint belongs to.
        /// </summary>
        private DomainTable _table;

        /// <summary>
        ///     The database table that is referenced by the constraint.
        /// </summary>
        private DomainTable _referencedTable;

        /// <summary>
        ///     The collection of columns defined within the constraint.
        /// </summary>
        private List<DomainTableConstraintColumn> _constraintColumns;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the database table that the constraint belongs to.
        /// </summary>
        public DomainTable Table
        {
            get { return _table; }
        }

        /// <summary>
        ///     Gets or sets the constraint of the index.
        /// </summary>
        public String ConstraintName
        {
            get { return base.GetValue<String>("name"); }
            set { base.SetValue<String>("name", value); }
        }

        /// <summary>
        ///     Gets or sets the description for the constraint.
        /// </summary>
        public String ConstraintDescription
        {
            get { return base.GetValue<String>("description"); }
            set { base.SetValue<String>("description", value); }
        }

        /// <summary>
        ///    Gets the collection of columns defined within the constraint.
        /// </summary>
        public DomainTableConstraintColumn[] ConstraintColumns
        {
            get { return _constraintColumns.ToArray(); }
        }

        /// <summary>
        ///     Gets or sets the database table that is referenced by the constraint.
        /// </summary>
        public DomainTable ReferencedTable
        {
            get
            {
                if (_referencedTable == null)
                    _referencedTable = this.Table.Domain.Tables.FirstOrDefault(table => table.Guid == this.GetValue<Guid?>("reference"));

                return _referencedTable;
            }
            set
            {
                this.SetValue<Guid?>("reference", value == null ? null : (Guid?)value.Guid);
                _referencedTable = value;
            }
        }

        /// <summary>
        ///    Gets the current version of the object to inspect.
        /// </summary>
        public override Version Version
        {
            get { return this.Table.Version; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="DomainTableConstraint" /> instance.
        /// </summary>
        public DomainTableConstraint(DomainTable table) : base(table.Version)
        {
            _table = table;
            _constraintColumns = new List<DomainTableConstraintColumn>();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new indexed column within the index.
        /// </summary>
        public DomainTableConstraintColumn CreateColumn()
        {
            DomainTableConstraintColumn column = new DomainTableConstraintColumn(this);
            _constraintColumns.Add(column);
            return column;
        }

        /// <summary>
        ///     Serialises the version history from into the specified xml element.
        /// </summary>
        internal override void Serialise(XmlNode parentNode)
        {
            if (!this.Deleted.HasValue || this.Deleted.Value != this.Created)
            {
                XmlNode xmlNode = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement("constraint"));
                base.Serialise(xmlNode);
                this.ConstraintColumns.Execute(item => item.Serialise(xmlNode));
            }
        }

        /// <summary>
        ///     Deserialises the version history from the specified xml element.
        /// </summary>
        internal static void Deserialise(DomainTable table, XmlNode parentNode)
        {
            foreach (XmlNode xmlNode in parentNode.SelectNodes("constraint"))
            {
                DomainTableConstraint result = table.CreateConstraint();
                result.Deserialise(xmlNode);
                DomainTableConstraintColumn.Deserialise(result, xmlNode);
            }
        }

        #endregion
    }
}
