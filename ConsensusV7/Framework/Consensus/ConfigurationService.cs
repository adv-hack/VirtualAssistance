using System;
using System.Collections.Generic;
using System.Configuration;

namespace Consensus
{
    /// <summary>
    ///     Represents the application configuration element for a service within the Consensus solution.
    /// </summary>
    public class ConfigurationService : ConfigurationElement
    {
        #region fields

        /// <summary>
        ///     The settings for the Consensus service provider.
        /// </summary>
        private Dictionary<String, String> _settings;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the name of the Consensus service.
        /// </summary>
        [ConfigurationProperty("name", IsRequired = true)]
        [RegexStringValidator("^[A-Za-z0-9\\s]*$")]
        public String Name
        {
            get { return base["name"].ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets the name of the Consensus service provider.
        /// </summary>
        [ConfigurationProperty("type", IsRequired = true)]
        [RegexStringValidator("^[A-Za-z0-9\\.\\,_\\s]*$")]
        public String ProviderType
        {
            get { return base["type"].ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets the settings for the Consensus service provider.
        /// </summary>
        public Dictionary<String, String> Settings
        {
            get
            {
                if (_settings == null)
                    _settings = new Dictionary<String, String>();

                return _settings;
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets a value indicating whether an unknown attribute is encountered during deserialization.
        /// </summary>
        /// <param name="name">
        ///     The name of the unrecognized attribute.
        /// </param>
        /// <param name="value">
        ///     The value of the unrecognized attribute
        /// </param>
        /// <returns>
        ///     True when an unknown attribute is encountered while deserializing; otherwise, false.
        /// </returns>
        protected override Boolean OnDeserializeUnrecognizedAttribute(String name, String value)
        {
            this.Settings[name] = value;
            return true;
        }

        #endregion
    }

    /// <summary>
    ///     Represents the collection of application configuration elements for the services within the Consensus solution.
    /// </summary>
    public class ConfigurationServiceCollection : ConfigurationElementCollection
    {
        #region properties

        /// <summary>
        ///     Creates a new <see cref="ConfigurationService" /> instance.
        /// </summary>
        /// <returns>
        ///     A new <see cref="ConfigurationService" /> instance.
        /// </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConfigurationService();
        }

        /// <summary>
        ///     Gets the unique key for a specified configuration element.
        /// </summary>
        /// <param name="element">
        ///     The <see cref="ConfigurationService"/> to return the key for.
        /// </param>
        /// <returns>
        ///     An <see cref="Object"/> that acts as the unique key for the specified <see cref="ConfigurationService"/>.
        /// </returns>
        protected override Object GetElementKey(ConfigurationElement element)
        {
            return (element as ConfigurationService).Name;
        }

        #endregion
    }
}
