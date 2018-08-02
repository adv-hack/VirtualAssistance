using System;
using System.Configuration;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Represents the configuration for the Consensus solution.
    /// </summary>
    public class ConsensusDomain
    {
        #region fields

        /// <summary>
        ///     The name of the organisation responsible for the development of the Consensus solution.
        /// </summary>
        public const String ProductOwner = "Advanced";

        /// <summary>
        ///     The internal product name of the Consensus solution.
        /// </summary>
        public const String ProductName = "Consensus";

        /// <summary>
        ///     The copyright protection notice for the Consensus solution.
        /// </summary>
        public const String ProductCopyright = "Copyright © 2017 " + ConsensusDomain.ProductOwner;
        
        /// <summary>
        ///     The major version number of the Consensus solution.
        /// </summary>
        public const String ProductVersion = "7.0.0";

        /// <summary>
        ///     The configuration for the Consensus solution.
        /// </summary>
        private static ConsensusDomain _configuration;

        /// <summary>
        ///     The name of the default Consensus instance.
        /// </summary>
        private String _defaultSite;

        /// <summary>
        ///     The collection of configured Consensus instances.
        /// </summary>
        private ConsensusSite[] _sites;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the configuration for the Consensus solution.
        /// </summary>
        public static ConsensusDomain Configuration
        {
            get
            {
                if (_configuration == null)
                    _configuration = ConsensusDomain.GetFromAppConfig(ConfigurationManager.GetSection("consensus") as Configuration);

                return _configuration;
            }
        }

        /// <summary>
        ///     Gets the name of the default Consensus instance.
        /// </summary>
        public String DefaultSite
        {
            get { return _defaultSite; }
        }

        /// <summary>
        ///     Gets the collection of configured Consensus instances.
        /// </summary>
        private ConsensusSite[] Sites
        {
            get { return _sites; }
        }

        /// <summary>
        ///     Gets a specific <see cref="ConsensusSite"/> instance by its unique identifier.
        /// </summary>
        /// <param name="guid">
        ///     The unique identifier assigned to the <see cref="ConsensusSite"/> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="ConsensusSite"/> instance matching the specified <paramref name="guid"/>; or null, if no instance can be found.
        /// </returns>
        public ConsensusSite this[Guid guid]
        {
            get { return this.Sites.FirstOrDefault(site => site.Guid == guid); }
        }

        /// <summary>
        ///     Gets a specific <see cref="ConsensusSite"/> instance by its unique name.
        /// </summary>
        /// <param name="name">
        ///     The unique name of the <see cref="ConsensusSite"/> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="ConsensusSite"/> instance matching the specified <paramref name="name"/>; or null, if no instance can be found.
        /// </returns>
        public ConsensusSite this[String name]
        {
            get { return this.Sites.FirstOrDefault(site => String.Equals(site.Name, name, StringComparison.OrdinalIgnoreCase)); }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="ConsensusDomain" /> instance.
        /// </summary>
        /// <param name="defaultSite">
        ///     Sets the name of the default Consensus instance.
        /// </param>
        /// <param name="sites">
        ///     Sets the collection of configured Consensus instances.
        /// </param>
        private ConsensusDomain(String defaultSite, ConsensusSite[] sites)
        {
            _defaultSite = defaultSite;
            _sites = sites;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Instantiates a new <see cref="ConsensusDomain" /> instance, initialised with the values from the application configuration file.
        /// </summary>
        /// <param name="configuration">
        ///     The configuration section, from the application configuration file.
        /// </param>
        /// <returns>
        ///     A new <see cref="ConsensusDomain" /> instance constructed from the application configuration section.
        /// </returns>
        private static ConsensusDomain GetFromAppConfig(Configuration configuration)
        {
            ConsensusSite[] sites = configuration.Sites.OfType<ConfigurationSite>().Select(config => new ConsensusSite(config)).ToArray();
            return new ConsensusDomain(configuration.DefaultSite, sites);
        }

        #endregion
    }
}
