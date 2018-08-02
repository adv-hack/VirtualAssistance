using System;
using System.Collections.Generic;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for all interchangeable service providers which are injectable into the Consensus solution.
    /// </summary>
    public abstract class ConsensusProvider
    {
        #region fields

        /// <summary>
        ///     The Consensus instance which is served by the provider.
        /// </summary>
        private ConsensusSite _site;

        /// <summary>
        ///     The settings for the Consensus service provider.
        /// </summary>
        private Dictionary<String, String> _settings;

        #endregion
        
        #region properties

        /// <summary>
        ///     Sets the settings for the Consensus service provider.
        /// </summary>
        public Dictionary<String, String> Settings
        {
            get { return _settings; }
            set { _settings = value; }
        }

        /// <summary>
        ///     Gets the Consensus instance which is served by the provider. 
        /// </summary>
        public ConsensusSite Site
        {
            get { return _site; }
            set { _site = value; }
        }

        /// <summary>
        ///     Returns a configuration setting instance by its unique name.
        /// </summary>
        /// <param name="name">
        ///     The unique name of the configuration setting to be returned.
        /// </param>
        /// <returns>
        ///     The configuration setting matching the specified <paramref name="name"/>; or null, if no setting can be found.
        /// </returns>
        public String this[String name]
        {
            get { return this.Settings.ContainsKey(name) ? this.Settings[name] : null; }
        }

        #endregion
    }
}
