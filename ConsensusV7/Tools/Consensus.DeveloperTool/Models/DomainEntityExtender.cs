using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    public class DomainEntityExtender : DomainEntity
    {
        #region fields

        /// <summary>
        ///     The domain entity that is extended by this entity extender.
        /// </summary>
        private DomainEntity _referencedEntity;

        /// <summary>
        ///     The collection of attributes defined against the entity extender.
        /// </summary>
        private DomainEntityAttribute[] _entityAttributes;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the domain entity that is extended by this entity extender.
        /// </summary>
        public DomainEntity ReferencedEntity
        {
            get
            {
                if (_referencedEntity == null)
                    _referencedEntity = this.Container.Domain.Containers.SelectMany(container => container.ContainerEntities).FirstOrDefault(entity => entity.Guid == this.GetValue<Guid?>("entity"));

                return _referencedEntity;
            }
            set
            {
                this.SetValue<Guid?>("entity", value == null ? null : (Guid?)value.Guid);
                _referencedEntity = value;
            }
        }

        /// <summary>
        ///    Gets the collection of attributes defined against the entity.
        /// </summary>
        public override DomainEntityAttribute[] EntityAttributes
        {
            get
            {
                if (_entityAttributes == null)
                    _entityAttributes = this.ReferencedTable.TableColumns.Select(column => new DomainEntityAttribute(this, column)).ToArray();

                // For each column defined in the table, return either:
                //  •  The attribute that is defined in the underlying model, or
                //  •  The attribute that is defined in this model, or
                //  •  A new attribute (in case a column has been added to the table since the entity was initialised)
                return this.ReferencedTable.TableColumns.Select(column =>
                    this.ReferencedEntity.EntityAttributes.FirstOrDefault(attr => attr.Column == column && attr.AttributeExposed) ??
                    _entityAttributes.FirstOrDefault(attr => attr.Column == column) ??
                    new DomainEntityAttribute(this, column)
                ).ToArray();
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="DomainEntityExtender" /> instance.
        /// </summary>
        public DomainEntityExtender(DomainContainer container) : base(container)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets whether this entity inherits the specified entity, directly or through the inheritence chain.
        /// </summary>
        public override Boolean Inherits(DomainEntity entity)
        {
            if (this.ReferencedEntity == null)
                return false;
            else if (this.ReferencedEntity == entity)
                return true;
            else if (this.ReferencedEntity.Inherits(entity))
                return true;
            else
                return base.Inherits(entity);
        }

        /// <summary>
        ///     Serialises the version history from into the specified xml element.
        /// </summary>
        internal override void Serialise(XmlNode parentNode)
        {
            this.Serialise(parentNode, "extender");
        }

        /// <summary>
        ///     Deserialises the version history from the specified xml element.
        /// </summary>
        internal static new void Deserialise(DomainContainer container, XmlNode parentNode)
        {
            foreach (XmlNode xmlNode in parentNode.SelectNodes("extender"))
            {
                DomainEntityExtender result = container.CreateEntityExtender();
                result.Deserialise(xmlNode);
                result.EntityAttributes.Execute(item => item.Deserialise(xmlNode));
            }
        }

        #endregion
    }
}
