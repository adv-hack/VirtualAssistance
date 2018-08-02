using System;
using System.Collections.Generic;

namespace Consensus
{
    /// <summary>
    ///     Represents a configured service for an instance of the Consensus solution.
    /// </summary>
    public class ConsensusService
    {
        #region fields

        /// <summary>
        ///     The name of the Consensus service.
        /// </summary>
        private String _name;

        /// <summary>
        ///     The name of the Consensus service provider.
        /// </summary>
        private String _type;

        /// <summary>
        ///     The settings for the Consensus service provider.
        /// </summary>
        private Dictionary<String, String> _settings;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the name of the Consensus service.
        /// </summary>
        public String Name
        {
            get { return _name; }
        }

        /// <summary>
        ///     Gets the name of the Consensus service provider.
        /// </summary>
        public String Type
        {
            get { return _type; }
        }

        /// <summary>
        ///     Gets the settings for the Consensus service provider.
        /// </summary>
        internal Dictionary<String, String> Settings
        {
            get { return _settings; }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="ConsensusService" /> instance.
        /// </summary>
        /// <param name="name">
        ///     Sets the name of the Consensus service.
        /// </param>
        /// <param name="providerType">
        ///     Sets the name of the Consensus service provider.
        /// </param>
        /// <param name="settings">
        ///     Sets the settings for the Consensus service provider.
        /// </param>
        private ConsensusService(String name, String providerType, Dictionary<String, String> settings)
        {
            _name = name;
            _type = providerType;
            _settings = settings;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Instantiates a new <see cref="ConsensusService" /> instance, initialised with the values from the application configuration file.
        /// </summary>
        /// <param name="configuration">
        ///     The configuration element, from the application configuration file.
        /// </param>
        /// <returns>
        ///     A new <see cref="ConsensusService" /> instance constructed from the application configuration element.
        /// </returns>
        internal static ConsensusService GetFromAppConfig(ConfigurationService configuration)
        {
            return new ConsensusService(configuration.Name, configuration.ProviderType, configuration.Settings);
        }

        #endregion
    }
}
