using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a programmatic scoping container within a business domain.
    /// </summary>
    public class DomainContainer : VersionData
    {
        #region fields

        /// <summary>
        ///     The domain that the container belongs to.
        /// </summary>
        private Domain _domain;

        /// <summary>
        ///     The collection of entities defined within the container.
        /// </summary>
        private List<DomainEntity> _containerEntities;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the domain that the container belongs to.
        /// </summary>
        public Domain Domain
        {
            get { return _domain; }
        }

        /// <summary>
        ///     Gets or sets the name of the scoping container.
        /// </summary>
        public String ContainerName
        {
            get { return base.GetValue<String>("name"); }
            set { base.SetValue<String>("name", value); }
        }

        /// <summary>
        ///     Gets or sets the description for  the scoping container.
        /// </summary>
        public String ContainerDescription
        {
            get { return base.GetValue<String>("description"); }
            set { base.SetValue<String>("description", value); }
        }

        /// <summary>
        ///    Gets the collection of entities defined within the container.
        /// </summary>
        public DomainEntity[] ContainerEntities
        {
            get { return _containerEntities.ToArray(); }
        }

        /// <summary>
        ///    Gets the current version of the object to inspect.
        /// </summary>
        public override Version Version
        {
            get { return this.Domain.Version; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="DomainContainer" /> instance.
        /// </summary>
        public DomainContainer(Domain domain) : base(domain.Version)
        {
            _domain = domain;
            _containerEntities = new List<DomainEntity>();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new entity within the container.
        /// </summary>
        public DomainEntity CreateEntity()
        {
            DomainEntity entity = new DomainEntity(this);
            _containerEntities.Add(entity);
            return entity;
        }

        /// <summary>
        ///     Creates a new entity extender within the container.
        /// </summary>
        public DomainEntityExtender CreateEntityExtender()
        {
            DomainEntityExtender entity = new DomainEntityExtender(this);
            _containerEntities.Add(entity);
            return entity;
        }

        /// <summary>
        ///     Serialises the version history from into the specified xml element.
        /// </summary>
        internal override void Serialise(XmlNode parentNode)
        {
            if (!this.Deleted.HasValue || this.Deleted.Value != this.Created)
            {
                XmlNode xmlNode = parentNode.AppendChild(parentNode.OwnerDocument.CreateElement("container"));
                base.Serialise(xmlNode);
                this.ContainerEntities.Where(item => item.GetType() == typeof(DomainEntity)).OfType<DomainEntity>().Execute(item => item.Serialise(xmlNode));
                this.ContainerEntities.Where(item => item.GetType() == typeof(DomainEntityExtender)).OfType<DomainEntityExtender>().Execute(item => item.Serialise(xmlNode));
            }
        }

        /// <summary>
        ///     Deserialises the version history from the specified xml element.
        /// </summary>
        internal static void Deserialise(Domain domain, XmlNode parentNode)
        {
            foreach (XmlNode xmlNode in parentNode.SelectNodes("container"))
            {
                DomainContainer result = domain.CreateContainer();
                result.Deserialise(xmlNode);
                DomainEntity.Deserialise(result, xmlNode);
            }
        }

        internal static void DeserialiseExtenders(Domain domain, XmlNode parentNode)
        {
            foreach (DomainContainer container in domain.Containers)
                DomainEntityExtender.Deserialise(container, parentNode.SelectSingleNode("container[@guid='" + container.Guid.ToString() + "']"));
        }

        #endregion
    }
}
