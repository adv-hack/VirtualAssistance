using System;
using System.Configuration;

namespace Consensus
{
    /// <summary>
    ///     The configuration section, within the application configuration file, which represents the Consensus configuration.
    /// </summary>
    public class Configuration : ConfigurationSection
    {
        #region properties

        /// <summary>
        ///     Gets the name of the default Consensus instance.
        /// </summary>
        [ConfigurationProperty("defaultSite", IsRequired = true)]
        [RegexStringValidator("^[A-Za-z0-9\\s]*$")]
        public String DefaultSite
        {
            get { return base["defaultSite"].ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets the collection of configured Consensus instances.
        /// </summary>
        [ConfigurationProperty("", IsDefaultCollection = true, IsRequired = true)]
        [ConfigurationCollection(typeof(ConfigurationSiteCollection), AddItemName = "site", CollectionType = ConfigurationElementCollectionType.BasicMap)]
        public ConfigurationSiteCollection Sites
        {
            get { return base[""] as ConfigurationSiteCollection; }
        }

        #endregion
    }
}
