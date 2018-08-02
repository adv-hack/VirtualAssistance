using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a constrained database column within the domain.
    /// </summary>
    public class DomainTableConstraintColumn : VersionData
    {
        #region fields

        /// <summary>
        ///     The database constraint that the constrained column belongs to.
        /// </summary>
        private DomainTableConstraint _constraint;

        /// <summary>
        ///     The database table column that is included within the constraint.
        /// </summary>
        private DomainTableColumn _constraintColumn;

        /// <summary>
        ///     The referenced database table column that is included within the constraint.
        /// </summary>
        private DomainTableColumn _referencedColumn;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the database constraint that the constrained column belongs to.
        /// </summary>
        public DomainTableConstraint Constraint
        {
            get { return _constraint; }
        }

        /// <summary>
        ///     Gets the database table column that is included within the constraint.
        /// </summary>
        public DomainTableColumn ConstraintColumn
        {
            get
            {
                if (_constraintColumn == null)
                    _constraintColumn = this.Constraint.Table.TableColumns.FirstOrDefault(column => column.Guid == this.GetValue<Guid?>("column"));

                return _constraintColumn;
            }
            set
            {
                this.SetValue<Guid?>("column", value == null ? null : (Guid?)value.Guid);
                _constraintColumn = value;
            }
        }

        /// <summary>
        ///     Gets the referenced database table column that is included within the constraint.
        /// </summary>
        public DomainTableColumn ReferencedColumn
        {
            get
            {
                if (_referencedColumn == null)
                    _referencedColumn = this.Constraint.ReferencedTable.TableColumns.FirstOrDefault(column => column.Guid == this.GetValue<Guid?>("reference"));

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
            get { return this.Constraint.Version; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="DomainTableConstraintColumn" /> instance.
        /// </summary>
        public DomainTableConstraintColumn(DomainTableConstraint constraint) : base(constraint.Version)
        {
            _constraint = constraint;
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
        internal static void Deserialise(DomainTableConstraint constraint, XmlNode parentNode)
        {
            foreach (XmlNode xmlNode in parentNode.SelectNodes("column"))
            {
                DomainTableConstraintColumn result = constraint.CreateColumn();
                result.Deserialise(xmlNode);
            }
        }

        #endregion
    }
}
