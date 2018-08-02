using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a module that is included within a license.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LicenseModule : Proxy<ILicenseModuleModel, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the module that is included within the license.
        /// </summary>
        public Consensus.Security.LicenseModules Module
        {
            get { return this.Model.Module; }
            set { this.Model.Module = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_LIC_ID" field.
        /// </summary>
        public System.Guid License
        {
            get { return this.Model.License; }
            set { this.Model.License = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal LicenseModule(ILicenseModuleModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseModuleModel" /> instances.
        /// </summary>
        /// <param name="licenseId">
        ///     The value which identifies the <see cref="!:LicenseModuleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModuleModel" /> instances that match the specified <paramref name="licenseId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.LicenseModule> FetchAllByLicenseId(System.Guid licenseId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LicenseModule.FetchAllByLicenseId(site,licenseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseModuleModel" /> instances.
        /// </summary>
        /// <param name="licenseId">
        ///     The value which identifies the <see cref="!:LicenseModuleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModuleModel" /> instances that match the specified <paramref name="licenseId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.LicenseModule> FetchAllByLicenseId(ConsensusSite site, System.Guid licenseId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.ILicenseModuleModel> collection = provider.Security.LicenseModule.FetchAllByLicenseId(licenseId);
            return collection.Select(model => new Consensus.Security.LicenseModule(model));
        }

        /// <summary>
        ///     Creates a new <see cref="!:LicenseModuleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseModuleModel" /> instance.
        /// </returns>
        public static Consensus.Security.LicenseModule Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LicenseModule.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LicenseModuleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseModuleModel" /> instance.
        /// </returns>
        public static Consensus.Security.LicenseModule Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.ILicenseModuleModel model = provider.Security.LicenseModule.Create();
            return model == null ? null : new Consensus.Security.LicenseModule(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseModuleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseModuleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.LicenseModule> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LicenseModule.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseModuleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseModuleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.LicenseModule> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.ILicenseModuleModel> collection = provider.Security.LicenseModule.FetchAll();
            return collection.Select(model => new Consensus.Security.LicenseModule(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseModuleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseModuleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModuleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.LicenseModule FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LicenseModule.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseModuleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseModuleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModuleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.LicenseModule FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.ILicenseModuleModel model = provider.Security.LicenseModule.FetchById(id);
            return model == null ? null : new Consensus.Security.LicenseModule(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LicenseModule.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.LicenseModule.GetTableName();
        }

        #endregion
    }
}
