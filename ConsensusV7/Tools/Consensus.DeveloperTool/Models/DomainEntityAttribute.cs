using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    public class DomainEntityAttribute : VersionData
    {
        #region fields

        /// <summary>
        ///     The domain entity that the attribute belongs to.
        /// </summary>
        private DomainEntity _entity;

        /// <summary>
        ///     The database column that the attribute corresponds to.
        /// </summary>
        private DomainTableColumn _column;

        /// <summary>
        ///     The domain entity that is referenced by the attribute.
        /// </summary>
        private DomainEntity _referencedEntity;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the domain entity that the attribute belongs to.
        /// </summary>
        public DomainEntity Entity
        {
            get { return _entity; }
        }

        /// <summary>
        ///    Gets the database column that the attribute corresponds to.
        /// </summary>
        public DomainTableColumn Column
        {
            get { return _column; }
            set { _column = value; }
        }

        /// <summary>
        ///     Gets or sets the name of the attribute.
        /// </summary>
        public String AttributeName
        {
            get { return base.GetValue<String>("name") ?? this.Column.ProgrammaticName; }
            set { base.SetValue<String>("name", value == this.Column.ProgrammaticName ? null : value); }
        }

        /// <summary>
        ///     Gets or sets the description for the attribute.
        /// </summary>
        public String AttributeDescription
        {
            get { return base.GetValue<String>("description") ?? this.Column.ColumnDescription; }
            set { base.SetValue<String>("description", value == this.Column.ColumnDescription ? null : value); }
        }

        /// <summary>
        ///     Gets or sets whether the attribute is exposed within the business logic layer.s
        /// </summary>
        public Boolean AttributeExposed
        {
            get { return base.GetValue<Boolean>("exposed"); }
            set { base.SetValue<Boolean>("exposed", value); }
        }

        /// <summary>
        ///     Gets the level of exposure for the attribute.
        /// </summary>
        public DomainEntityAttributeExposure AttributeExposure
        {
            get { return base.GetValue<DomainEntityAttributeExposure>("exposure"); }
            set { base.SetValue<DomainEntityAttributeExposure>("exposure", value); }
        }

        /// <summary>
        ///     Gets or sets the code type used for the attribute.
        /// </summary>
        public String AttributeCode
        {
            get { return base.GetValue<String>("code"); }
            set { base.SetValue<String>("code", value); }
        }

        /// <summary>
        ///     Gets the name of the database column.
        /// </summary>
        public String ColumnName
        {
            get { return this.Column.ColumnName; }
        }

        /// <summary>
        ///     Gets the name of the referenced entity (if any)
        /// </summary>
        public String ReferencedEntityName
        {
            get
            {
                if (this.ReferencedEntity == null)
                    return String.Empty;
                else if (String.Equals(this.ReferencedEntity.ReferencedTable.TableName, DomainTable.CODE_TABLE, StringComparison.OrdinalIgnoreCase) && !String.IsNullOrEmpty(this.AttributeCode))
                    return String.Format("{0} ({1})", this.ReferencedEntity.EntityName, this.AttributeCode.ToPascal());
                else
                    return this.ReferencedEntity.EntityName;
            }
        }

        /// <summary>
        ///     Gets or sets the entity that is referenced by the attribute.
        /// </summary>
        public DomainEntity ReferencedEntity
        {
            get
            {
                if (_referencedEntity == null)
                    _referencedEntity = this.Entity.Container.Domain.Containers.SelectMany(container => container.ContainerEntities).FirstOrDefault(entity => entity.Guid == this.GetValue<Guid?>("reference"));

                return _referencedEntity;
            }
            set
            {
                this.SetValue<Guid?>("reference", value == null ? null : (Guid?)value.Guid);
                _referencedEntity = value;
            }
        }

        /// <summary>
        ///     Gets or sets the property name used for the entity reference.
        /// </summary>
        public String ReferencedName
        {
            get { return this.ReferencedEntity == null ? null : base.GetValue<String>("referenceName") ?? this.Entity.EntityName.ToPlural(); }
            set { base.SetValue<String>("referenceName", this.ReferencedEntity == null || value == this.Entity.EntityName.ToPlural() ? null : value); }
        }

        /// <summary>
        ///     Gets whether the collection property, that is generated on the referenced entity, will be marked for exclusion from serialisation.
        /// </summary>
        public Boolean ReferenceExcludeSerialisation
        {
            get { return base.GetValue<Boolean>("do_not_serialize"); }
            set { base.SetValue<Boolean>("do_not_serialize", value); }
        }

        /// <summary>
        ///    Gets the current version of the object to inspect.
        /// </summary>
        public override Version Version
        {
            get { return this.Entity.Version; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="DomainEntityAttribute" /> instance.
        /// </summary>
        public DomainEntityAttribute(DomainEntity entity, DomainTableColumn column) : base(entity.Version)
        {
            _entity = entity;
            _column = column;
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
                XmlNode xmlNode = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement("attribute"));
                xmlNode.Attributes.Append(parentNode.OwnerDocument.CreateAttribute("column")).Value = this.Column.Guid.ToString();
                base.Serialise(xmlNode);
            }

        }

        /// <summary>
        ///     Deserialises the version history from the specified xml element.
        /// </summary>
        internal new void Deserialise(XmlNode parentNode)
        {
            XmlNode node = parentNode.SelectSingleNode("attribute[@column='" + this.Column.Guid.ToString() + "']");
            if (node != null)
                base.Deserialise(node);
        }

        #endregion
    }
}
