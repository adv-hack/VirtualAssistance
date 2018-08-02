using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="SysParamsRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalSellingCompanyModel
    {
        #region fields

        /// <summary>
        ///     The collection of system configuration values for the selling company.
        /// </summary>
        private List<LocalSellingCompanyConfigModel> _configurations;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the collection of system configuration values for the selling company.
        /// </summary>
        internal List<LocalSellingCompanyConfigModel> Configurations
        {
            get
            {
                if (_configurations == null)
                    _configurations = this.Provider.Common.SellingCompanyConfig.FetchAllBySellingCompanyId(this.Id).ToList();

                return _configurations;
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependents by means of persisting all models that reference this model.
        /// </summary>
        protected override void ResolveDependent()
        {
            base.ResolveDependent();
            if (_configurations != null)
                _configurations.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
        }

        /// <summary>
        ///     Gets a configuration value for the selling company.
        /// </summary>
        public TValue GetConfiguration<TValue>(String name, TValue defaultValue)
        {
            TValue returnValue = defaultValue;

            // Identify the configuration value for the selling company
            LocalSellingCompanyConfigModel configuration = this.Configurations.FirstOrDefault(config => String.Equals(config.KeyName, name, StringComparison.OrdinalIgnoreCase));
            if (configuration != null)
                returnValue = configuration.Value.ConvertTo<TValue>(defaultValue);

            return returnValue;
        }

        /// <summary>
        ///     Gets a configuration value for the selling company.
        /// </summary>
        public void SetConfiguration<TValue>(String name, SellingCompanyConfigTypes type, TValue value)
        {
            // Identify the configuration for the selling company.
            LocalSellingCompanyConfigModel configuration = this.Configurations.FirstOrDefault(config => String.Equals(config.KeyName, name, StringComparison.OrdinalIgnoreCase));
            if (configuration == null)
            {
                configuration = this.Provider.Common.SellingCompanyConfig.Create();
                configuration.KeyName = name;
            }

            // Set the configuration value.
            configuration.ValueToUse = type.ConvertTo<Int32>().ConvertTo<Byte>();
            configuration.Value = value;
        }

        #endregion
    }
}
