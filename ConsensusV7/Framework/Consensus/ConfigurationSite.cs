using System;
using System.Configuration;

namespace Consensus
{
    /// <summary>
    ///     Represents the application configuration element for a site within the Consensus solution.
    /// </summary>
    public class ConfigurationSite : ConfigurationElement
    {
        #region properties

        /// <summary>
        ///     Gets the unique identifier assigned to the Consensus instance.
        /// </summary>
        [ConfigurationProperty("guid", IsRequired = false)]
        [RegexStringValidator("^$|^[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}$")]
        public String Guid
        {
            get { return base["guid"].ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets the unique name of the Consensus instance.
        /// </summary>
        [ConfigurationProperty("name", IsRequired = true)]
        [RegexStringValidator("^[A-Za-z0-9\\s]*$")]
        public String Name
        {
            get { return base["name"].ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets the display name for the Consensus instance.
        /// </summary>
        [ConfigurationProperty("displayName", IsRequired = false)]
        [DefaultSettingValue("Live")]
        public String DisplayName
        {
            get { return base["displayName"].ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets the product name for the Consensus instance.
        /// </summary>
        [ConfigurationProperty("productName", IsRequired = false)]
        [DefaultSettingValue("Consensus")]
        public String ProductName
        {
            get { return base["productName"].ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets the home page strapline for the Consensus instance.
        /// </summary>
        [ConfigurationProperty("productStrapline", IsRequired = false)]
        [DefaultSettingValue("Learning and Training Management")]
        public String ProductStrapline
        {
            get { return base["productStrapline"].ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets whether secure traffic is enforced.
        /// </summary>
        [ConfigurationProperty("sslPort", IsRequired = false)]
        [DefaultSettingValue("false")]
        public Int32? SSLPort
        {
            get { return base["sslPort"].ConvertTo<Int32?>(); }
        }

        /// <summary>
        ///     Gets whether the solution requires secure communications.
        /// </summary>
        [ConfigurationProperty("showErrors", IsRequired = false)]
        [RegexStringValidator("^(true|false|yes|no|enable|disable|enabled|disabled|on|off|t|f|y|n|1|0|X|O)?$")]
        public String ShowErrors
        {
            get { return base["showErrors"].ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets the URL for the legacy site.
        /// </summary>
        [ConfigurationProperty("version6", IsRequired = false)]
        public String Version6
        {
            get { return base["version6"].ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets the collection of configured services for the Consensus instance.
        /// </summary>
        [ConfigurationProperty("", IsDefaultCollection = true, IsRequired = true)]
        [ConfigurationCollection(typeof(ConfigurationServiceCollection), AddItemName = "service", CollectionType = ConfigurationElementCollectionType.BasicMap)]
        public ConfigurationServiceCollection Services
        {
            get { return base[""] as ConfigurationServiceCollection; }
        }

        #endregion
    }

    /// <summary>
    ///     Represents the collection of application configuration elements for the sites within the Consensus solution.
    /// </summary>
    public class ConfigurationSiteCollection : ConfigurationElementCollection
    {
        #region properties

        /// <summary>
        ///     Creates a new <see cref="ConfigurationSite" /> instance.
        /// </summary>
        /// <returns>
        ///     A new <see cref="ConfigurationSite" /> instance.
        /// </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConfigurationSite();
        }

        /// <summary>
        ///     Gets the unique key for a specified configuration element.
        /// </summary>
        /// <param name="element">
        ///     The <see cref="ConfigurationSite"/> to return the key for.
        /// </param>
        /// <returns>
        ///     An <see cref="Object"/> that acts as the unique key for the specified <see cref="ConfigurationSite"/>.
        /// </returns>
        protected override Object GetElementKey(ConfigurationElement element)
        {
            return (element as ConfigurationSite).Name;
        }

        #endregion
    }
}
