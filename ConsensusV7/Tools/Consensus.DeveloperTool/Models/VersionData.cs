using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a version-controlled object.
    /// </summary>
    public abstract class VersionData : MarshalByRefObject
    {
        #region fields

        /// <summary>
        ///     The globally unique identifier for the object.
        /// </summary>
        private Guid _guid;

        /// <summary>
        ///     The version that has been cached.
        /// </summary>
        private Version? _cachedVersion;

        /// <summary>
        ///     The values that have been cached for the current version.
        /// </summary>
        private Dictionary<String, Object> _cache;

        /// <summary>
        ///     The version history for the object.
        /// </summary>
        private Dictionary<Version, Dictionary<String, Object>> _history;

        /// <summary>
        ///     The version in which the data was created.
        /// </summary>
        private Version _created;

        /// <summary>
        ///     The version in which the data is marked as deleted.
        /// </summary>
        private Version? _deleted;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the globally unique identifier for the object.
        /// </summary>
        public Guid Guid
        {
            get { return _guid; }
            private set { _guid = value; }
        }

        /// <summary>
        ///    Gets the current version of the object to inspect.
        /// </summary>
        public abstract Version Version
        {
            get;
        }
        
        /// <summary>
        ///    Gets the values that have been cached for the current version.
        /// </summary>
        private Dictionary<String, Object> Cache
        {
            get
            {
                if (_cachedVersion == null || _cachedVersion.Value != this.Version)
                    this.UpdateCache();

                return _cache;
            }
        }

        /// <summary>
        ///    Gets the version history for the object.
        /// </summary>
        private Dictionary<Version, Dictionary<String, Object>> History
        {
            get
            {
                if (_history == null)
                    _history = new Dictionary<Version, Dictionary<String, Object>>();

                return _history;
            }
        }
        
        /// <summary>
        ///    Gets or sets the version in which the data was created.
        /// </summary>
        protected Version Created
        {
            get { return _created; }
            private set { _created = value; }
        }

        /// <summary>
        ///    Gets or sets the version in which the data is marked as deleted.
        /// </summary>
        protected Version? Deleted
        {
            get { return _deleted; }
            private set { _deleted = value; }
        }

        /// <summary>
        ///     Gets whether the object exists in the current version.
        /// </summary>
        public Boolean Exists
        {
            get
            {
                if (this.Created > this.Version)
                    return false;
                else if (this.Deleted.HasValue && this.Deleted.Value <= this.Version)
                    return false;
                else
                    return true;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="VersionData" /> instance.
        /// </summary>
        public VersionData(Version created)
        {
            this.Created = created;
            this.Guid = Guid.NewGuid();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Marks the data as deleted.
        /// </summary>
        public void Delete()
        {
            if (this.Deleted == null || this.Deleted > this.Version)
                this.Deleted = this.Version;
        }

        /// <summary>
        ///     Deserialises the version history from the specified xml element.
        /// </summary>
        protected void Deserialise(XmlNode node)
        {
            this.Guid = node.Attributes["guid"].Value.ConvertTo<Guid>();
            this.Created = new Version(node.Attributes["created"].Value);
            if (node.Attributes["deleted"] != null && !String.IsNullOrEmpty(node.Attributes["deleted"].Value))
                this.Deleted = new Version(node.Attributes["deleted"].Value) as Version?;

            foreach (XmlNode dataNode in node.SelectNodes("data"))
            {
                Version version = new Version(dataNode.Attributes["version"].Value);
                this.History.Add(version, new Dictionary<String, Object>());
                foreach (XmlNode itemNode in dataNode.SelectNodes("item"))
                    this.History[version][itemNode.Attributes["name"].Value] = itemNode.Attributes["value"].Value.ConvertTo(Type.GetType(itemNode.Attributes["type"].Value));
            }

            this.UpdateCache();
        }

        /// <summary>
        ///     Serialises the version history from into the specified xml element.
        /// </summary>
        internal virtual void Serialise(XmlNode node)
        {
            node.Attributes.Append(node.OwnerDocument.CreateAttribute("guid")).Value = this.Guid.ToString();
            node.Attributes.Append(node.OwnerDocument.CreateAttribute("created")).Value = this.Created.ToString();
            if (this.Deleted.HasValue)
                node.Attributes.Append(node.OwnerDocument.CreateAttribute("deleted")).Value = this.Deleted.Value.ToString();

            foreach (Version version in this.History.Keys)
            {
                XmlNode dataNode = node.AppendChild(node.OwnerDocument.CreateElement("data"));
                dataNode.Attributes.Append(node.OwnerDocument.CreateAttribute("version")).Value = version.ToString();
                foreach (String item in this.History[version].Keys)
                {
                    XmlNode itemNode = dataNode.AppendChild(node.OwnerDocument.CreateElement("item"));
                    itemNode.Attributes.Append(node.OwnerDocument.CreateAttribute("name")).Value = item;
                    itemNode.Attributes.Append(node.OwnerDocument.CreateAttribute("type")).Value = (this.History[version][item] == null ? typeof(Object) : this.History[version][item].GetType()).FullName;
                    itemNode.Attributes.Append(node.OwnerDocument.CreateAttribute("value")).Value = this.History[version][item].ConvertTo<String>();
                }
            }
        }

        /// <summary>
        ///     Gets the value of the specified <paramref name="property"/>.
        /// </summary>
        /// <typeparam name="TValue">
        ///     The data type of the value to be returned.
        /// </typeparam>
        /// <param name="name">
        ///     The name of the property whose value is returned.
        /// </param>
        /// <returns>
        ///     The value of the specified property.
        /// </returns>       
        protected TValue GetValue<TValue>(String property)
        {
            if (!this.Cache.ContainsKey(property))
                if (this.History.ContainsKey(this.Version) && this.History[this.Version].ContainsKey(property))
                    this.Cache.Add(property, this.History[this.Version][property]);
                else if (this.History.Keys.Any(version => version < this.Version && this.History[version].ContainsKey(property)))
                    this.Cache.Add(property, this.History.OrderBy(kvp => kvp.Key).Last(kvp => kvp.Key < this.Version && kvp.Value.ContainsKey(property)).Value[property]);
                else
                    this.Cache.Add(property, default(TValue));


            if (this.Cache[property] is TValue == false)
                this.Cache[property] = default(TValue);
                
            return (TValue)(Object)this.Cache[property];
        }

        /// <summary>
        ///     Sets the value of the specified <paramref name="property"/>.
        /// </summary>
        /// <typeparam name="TValue">
        ///     The data type of the value to be set.
        /// </typeparam>
        /// <param name="property">
        ///     The name of the property whose value is set.
        /// </param>
        /// <param name="value">
        ///     The value of the specified property.
        /// </param>
        protected void SetValue<TValue>(String property, TValue value)
        {
            // Check that the value is being changed.
            if (!Object.Equals(this.GetValue<TValue>(property), value))
            {
                // If the value has been defined in the current version and is being reverted to the value defined in the previous version, remove the value from the current version.
                Object previousValue = this.History.OrderBy(kvp => kvp.Key).Where(kvp => kvp.Key < this.Version && kvp.Value.ContainsKey(property)).Select(kvp => kvp.Value[property]).LastOrDefault();
                if (this.History.ContainsKey(this.Version) && this.History[this.Version].ContainsKey(property) && Object.Equals(value, previousValue))
                {
                    this.History[this.Version].Remove(property);
                    if (this.History.Count == 0)
                        this.History.Remove(this.Version);
                }
                else
                {
                    if (!this.History.ContainsKey(this.Version))
                        this.History.Add(this.Version, new Dictionary<String, Object>());
                    this.History[this.Version][property] = value;
                }
                
                // Update the value that has been cached for the current version.
                this.Cache[property] = value;
            }
        }

        /// <summary>
        ///     Updates the cached values and cached version state.
        /// </summary>
        private void UpdateCache()
        {
            // Retain the version that has been cached.
            _cachedVersion = this.Version;

            // Clear the cached values (cache will repopulate as each value is accessed).
            _cache = new Dictionary<String, Object>();
        }

        /// <summary>
        ///     Obtains a lifetime service object to control the lifetime policy for this instance.
        /// </summary>
        /// <returns>
        ///     Returns null.
        /// </returns>
        [SecurityPermissionAttribute(SecurityAction.Demand, Flags = SecurityPermissionFlag.Infrastructure)]
        public override Object InitializeLifetimeService()
        {
            return null;
        }

        #endregion
    }
}
