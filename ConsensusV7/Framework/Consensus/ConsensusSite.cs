using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Represents a configured instance of the Consensus solution.
    /// </summary>
    public class ConsensusSite
    {
        #region fields

        /// <summary>
        ///     The unique identifier assigned to the Consensus instance.
        /// </summary>
        private Guid _guid;

        /// <summary>
        ///     The name of the Consensus instance.
        /// </summary>
        private String _name;

        /// <summary>
        ///     The display name of the Consensus instance.
        /// </summary>
        private String _displayName;

        /// <summary>
        ///     The product name of the Consensus instance.
        /// </summary>
        private String _productName;

        /// <summary>
        ///     The product strapline of the Consensus instance.
        /// </summary>
        private String _productStrapline;

        /// <summary>
        ///     The SSL port to redirect insecure requests to.
        /// </summary>
        private Int32? _sslPort;

        /// <summary>
        ///     Specifies whether errors are displayed in full.
        /// </summary>
        private Boolean _showErrors;

        /// <summary>
        ///     The url of the legacy site.
        /// </summary>
        private String _version6;

        /// <summary>
        ///     The collection of configured services for the Consensus instance.
        /// </summary>
        private ConsensusService[] _services;

        /// <summary>
        ///     The collection of injected service providers.
        /// </summary>
        private Dictionary<Type, ConsensusProvider> _providers;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the unique identifier assigned to the Consensus instance.
        /// </summary>
        public Guid Guid
        {
            get { return _guid; }
        }

        /// <summary>
        ///     Gets the name of the Consensus instance.
        /// </summary>
        public String Name
        {
            get { return _name; }
        }

        /// <summary>
        ///     Gets the display name of the Consensus instance.
        /// </summary>
        public String DisplayName
        {
            get { return _displayName; }
        }

        /// <summary>
        ///     Gets the product name of the Consensus instance.
        /// </summary>
        public String ProductName
        {
            get { return _productName; }
        }

        /// <summary>
        ///     Gets the product name of the Consensus instance.
        /// </summary>
        public String ProductStrapline
        {
            get { return _productStrapline; }
        }

        /// <summary>
        ///     Gets the SSL port to redirect insecure requests to.
        /// </summary>
        public Int32? SSLPort
        {
            get { return _sslPort; }
        }

        /// <summary>
        ///     Gets whether errors are displayed in full.
        /// </summary>
        public Boolean ShowErrors
        {
            get { return _showErrors; }
        }

        /// <summary>
        ///     Gets the url of the legacy site.
        /// </summary>
        public String Version6
        {
            get { return _version6; }
        }

        /// <summary>
        ///     Gets the collection of configured services for the Consensus instance.
        /// </summary>
        private ConsensusService[] Services
        {
            get { return _services; }
        }

        /// <summary>
        ///     The collection of injected service providers.
        /// </summary>
        protected Dictionary<Type, ConsensusProvider> Providers
        {
            get
            {
                if (_providers == null)
                    _providers = new Dictionary<Type, ConsensusProvider>();

                return _providers;
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="ConsensusSite" /> instance.
        /// </summary>
        /// <param name="guid">
        ///     Sets unique identifier assigned to the Consensus instance.
        /// </param>
        /// <param name="name">
        ///     Sets the name of the Consensus instance.
        /// </param>
        /// <param name="services">
        ///     Sets the collection of configured services for the Consensus instance.
        /// </param>
        internal ConsensusSite(ConfigurationSite configuration)
        {
            _guid = configuration.Guid.ConvertTo<Guid?>() ?? Guid.NewGuid();
            _name = configuration.Name;
            _displayName = configuration.DisplayName;
            _productName = configuration.ProductName;
            _productStrapline = configuration.ProductStrapline;
            _sslPort = configuration.SSLPort.ConvertTo<Int32?>();
            _showErrors = configuration.ShowErrors.ConvertTo<Boolean>();
            _version6 = configuration.Version6;
            _services = configuration.Services.OfType<ConfigurationService>().Select(ConsensusService.GetFromAppConfig).ToArray();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets the injectable service provider for the current Consensus instance.
        /// </summary>
        /// <typeparam name="TService">
        ///     The type of service to be returned.
        /// </typeparam>
        /// <returns>
        ///     The injectable service provider that implements the specified <typeparamref name="TService" /> type.
        /// </returns>
        public TService GetService<TService>()
        {
            Type serviceType = typeof(TService);
            if (!this.Providers.ContainsKey(serviceType))
            {
                // Validate that the service has been configured
                ConsensusService service = this.Services.FirstOrDefault(svc => String.Equals(svc.Name, typeof(TService).Name, StringComparison.Ordinal));
                if (service == null)
                    throw new NotSupportedException(String.Format("The '{0}' service has not been defined for the '{1}' site.", serviceType.Name, this.Name));

                // Validate that the provider can be loaded
                Type providerType = Type.GetType(service.Type, false);
                if (providerType == null)
                    throw new NotSupportedException(String.Format("The '{0}' provider could not be loaded, please ensure the required libraries have been deployed with the product.", service.Type));

                // Validate that the provider supports the requested service
                if (!typeof(TService).IsAssignableFrom(providerType))
                    throw new NotSupportedException(String.Format("The '{0}' provider does not support the '{1}' service, please check the configuration file.", providerType.Name, serviceType.Name));

                // Validate that the provider is a Consensus service provider
                if (!providerType.IsSubclassOf(typeof(ConsensusProvider)))
                    throw new NotSupportedException(String.Format("The '{0}' provider is not a valid service provider, please check the configuration file.", providerType.Name));

                // Create a new instance of the service provider
                ConsensusProvider provider = Activator.CreateInstance(providerType) as ConsensusProvider;
                provider.Settings = service.Settings;
                provider.Site = this;
                this.Providers.Add(serviceType, provider);
            }
            return (TService)(Object)this.Providers[serviceType];
        }

        #endregion
    }
}
