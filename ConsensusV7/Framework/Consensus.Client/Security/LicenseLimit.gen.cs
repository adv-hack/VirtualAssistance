using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a limitation applied to a software license.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LicenseLimit : Proxy<ILicenseLimitModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="License" /> member.
        /// </summary>
        private Consensus.Security.License _license;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the type of limitation applied to the license.
        /// </summary>
        public Consensus.Security.LicenseLimitTypes Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the description of the limitation applied to the license.
        /// </summary>
        public System.String TypeDescription
        {
            get { return this.Model.TypeDescription; }
        }

        /// <summary>
        ///     Gets the The value of the "LL_LIC_ID" field.
        /// </summary>
        public Consensus.Security.License License
        {
            get
            {
                if (_license == null && this.Model.License != null)
                    _license = new Consensus.Security.License(this.Model.License);
                if (_license == null)
                    _license = Consensus.Security.License.Create();
                return _license;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LL_LIC_ID" field.
        /// </summary>
        public System.Guid LicenseId
        {
            get { return this.Model.LicenseId; }
            set { this.Model.LicenseId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LL_VALUE" field.
        /// </summary>
        public System.Int32 Value
        {
            get { return this.Model.Value; }
            set { this.Model.Value = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal LicenseLimit(ILicenseLimitModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:LicenseLimitModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseLimitModel" /> instance.
        /// </returns>
        public static Consensus.Security.LicenseLimit Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LicenseLimit.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LicenseLimitModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseLimitModel" /> instance.
        /// </returns>
        public static Consensus.Security.LicenseLimit Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.ILicenseLimitModel model = provider.Security.LicenseLimit.Create();
            return model == null ? null : new Consensus.Security.LicenseLimit(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseLimitModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseLimitModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.LicenseLimit> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LicenseLimit.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseLimitModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseLimitModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.LicenseLimit> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.ILicenseLimitModel> collection = provider.Security.LicenseLimit.FetchAll();
            return collection.Select(model => new Consensus.Security.LicenseLimit(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseLimitModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseLimitModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseLimitModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.LicenseLimit FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LicenseLimit.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseLimitModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseLimitModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseLimitModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.LicenseLimit FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.ILicenseLimitModel model = provider.Security.LicenseLimit.FetchById(id);
            return model == null ? null : new Consensus.Security.LicenseLimit(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LicenseLimit.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.LicenseLimit.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseLimitModel" /> instances.
        /// </summary>
        /// <param name="licenseId">
        ///     The value which identifies the <see cref="!:LicenseLimitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseLimitModel" /> instances that match the specified <paramref name="licenseId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.LicenseLimit> FetchAllByLicenseId(System.Guid licenseId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LicenseLimit.FetchAllByLicenseId(site,licenseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseLimitModel" /> instances.
        /// </summary>
        /// <param name="licenseId">
        ///     The value which identifies the <see cref="!:LicenseLimitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseLimitModel" /> instances that match the specified <paramref name="licenseId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.LicenseLimit> FetchAllByLicenseId(ConsensusSite site, System.Guid licenseId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.ILicenseLimitModel> collection = provider.Security.LicenseLimit.FetchAllByLicenseId(licenseId);
            return collection.Select(model => new Consensus.Security.LicenseLimit(model));
        }

        #endregion
    }
}
