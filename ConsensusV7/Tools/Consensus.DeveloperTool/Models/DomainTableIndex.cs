using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a database index within the domain.
    /// </summary>
    public class DomainTableIndex : VersionData
    {
        #region fields

        /// <summary>
        ///     The database table that the index belongs to.
        /// </summary>
        private DomainTable _table;

        /// <summary>
        ///     The collection of columns defined within the index.
        /// </summary>
        private List<DomainTableIndexColumn> _indexColumns;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the database table that the index belongs to.
        /// </summary>
        public DomainTable Table
        {
            get { return _table; }
        }

        /// <summary>
        ///     Gets or sets the name of the index.
        /// </summary>
        public String IndexName
        {
            get { return base.GetValue<String>("name"); }
            set { base.SetValue<String>("name", value); }
        }

        /// <summary>
        ///     Gets or sets the description for the index.
        /// </summary>
        public String IndexDescription
        {
            get { return base.GetValue<String>("description"); }
            set { base.SetValue<String>("description", value); }
        }

        /// <summary>
        ///     Gets or sets whether the index is unique.
        /// </summary>
        public Boolean IndexIsUnique
        {
            get { return base.GetValue<Boolean>("unique"); }
            set { base.SetValue<Boolean>("unique", value); }
        }

        /// <summary>
        ///    Gets the collection of columns defined within the index.
        /// </summary>
        public DomainTableIndexColumn[] IndexColumns
        {
            get { return _indexColumns.ToArray(); }
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
        ///     Initialises a new <see cref="DomainTableColumn" /> instance.
        /// </summary>
        public DomainTableIndex(DomainTable table) : base(table.Version)
        {
            _table = table;
            _indexColumns = new List<DomainTableIndexColumn>();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new indexed column within the index.
        /// </summary>
        public DomainTableIndexColumn CreateColumn()
        {
            DomainTableIndexColumn column = new DomainTableIndexColumn(this);
            _indexColumns.Add(column);
            return column;
        }

        /// <summary>
        ///     Serialises the version history from into the specified xml element.
        /// </summary>
        internal override void Serialise(XmlNode parentNode)
        {
            if (!this.Deleted.HasValue || this.Deleted.Value != this.Created)
            {
                XmlNode xmlNode = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement("index"));
                base.Serialise(xmlNode);
                this.IndexColumns.Execute(item => item.Serialise(xmlNode));
            }
        }

        /// <summary>
        ///     Deserialises the version history from the specified xml element.
        /// </summary>
        internal static void Deserialise(DomainTable table, XmlNode parentNode)
        {
            foreach (XmlNode xmlNode in parentNode.SelectNodes("index"))
            {
                DomainTableIndex result = table.CreateIndex();
                result.Deserialise(xmlNode);
                DomainTableIndexColumn.Deserialise(result, xmlNode);
            }
        }

        #endregion
    }
}
