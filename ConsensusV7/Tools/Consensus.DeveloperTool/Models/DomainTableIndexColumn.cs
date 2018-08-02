using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents an indexed database column within the domain.
    /// </summary>
    public class DomainTableIndexColumn : VersionData
    {
        #region fields

        /// <summary>
        ///     The database index that the indexed column belongs to.
        /// </summary>
        private DomainTableIndex _index;

        /// <summary>
        ///     The database table column that is included within the index.
        /// </summary>
        private DomainTableColumn _referencedColumn;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the database index that the indexed column belongs to.
        /// </summary>
        public DomainTableIndex Index
        {
            get { return _index; }
        }

        /// <summary>
        ///     Gets the database table column that is included within the index.
        /// </summary>
        public DomainTableColumn ReferencedColumn
        {
            get
            {
                if (_referencedColumn == null)
                    _referencedColumn = this.Index.Table.TableColumns.FirstOrDefault(column => column.Guid == this.GetValue<Guid?>("reference"));

                return _referencedColumn;
            }
            set
            {
                this.SetValue<Guid?>("reference", value == null ? null : (Guid?)value.Guid);
                _referencedColumn = value;
            }
        }

        /// <summary>
        ///    Gets the current version of the object to inspect.
        /// </summary>
        public override Version Version
        {
            get { return this.Index.Version; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="DomainTableIndexColumn" /> instance.
        /// </summary>
        public DomainTableIndexColumn(DomainTableIndex index) : base(index.Version)
        {
            _index = index;
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
        internal static void Deserialise(DomainTableIndex index, XmlNode parentNode)
        {
            foreach (XmlNode xmlNode in parentNode.SelectNodes("column"))
            {
                DomainTableIndexColumn result = index.CreateColumn();
                result.Deserialise(xmlNode);
            }
        }

        #endregion
    }
}
