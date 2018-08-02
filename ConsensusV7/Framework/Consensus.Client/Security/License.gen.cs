using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a software license.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class License : Proxy<ILicenseModel, Guid>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Owner" /> member.
        /// </summary>
        private Consensus.Contact.Role _owner;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Limits" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.LicenseLimit, Consensus.Security.ILicenseLimitModel> _limits;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the collection of enabled modules;.
        /// </summary>
        public Consensus.Security.LicenseModuleState[] Modules
        {
            get { return this.Model.Modules; }
            set { this.Model.Modules = value; }
        }

        /// <summary>
        ///     Gets the computed status of the license.
        /// </summary>
        public System.String StatusText
        {
            get { return this.Model.StatusText; }
        }

        /// <summary>
        ///     Gets the computed status of the license.
        /// </summary>
        public Consensus.Security.LicenseStatus Status
        {
            get { return this.Model.Status; }
        }

        /// <summary>
        ///     Gets the hexadecimal encoded hash of the license-protected data which is signed to verify the license.
        /// </summary>
        public System.String Verification
        {
            get { return this.Model.Verification; }
        }

        /// <summary>
        ///     Gets the digital signature for the license.
        /// </summary>
        public System.String Signature
        {
            get { return this.Model.Signature; }
            set { this.Model.Signature = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIC_ACTIVE" field.
        /// </summary>
        public System.DateTime Active
        {
            get { return this.Model.Active; }
            set { this.Model.Active = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIC_EXPIRY" field.
        /// </summary>
        public System.Nullable<System.DateTime> Expiry
        {
            get { return this.Model.Expiry; }
            set { this.Model.Expiry = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIC_OWNER" field.
        /// </summary>
        public Consensus.Contact.Role Owner
        {
            get
            {
                if (_owner == null && this.Model.Owner != null)
                    _owner = new Consensus.Contact.Role(this.Model.Owner);
                if (_owner == null)
                    _owner = Consensus.Contact.Role.Create();
                return _owner;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIC_OWNER" field.
        /// </summary>
        public System.String OwnerId
        {
            get { return this.Model.OwnerId; }
            set { this.Model.OwnerId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LicenseLimitModel" /> instances that reference this <see cref="!:LicenseModel" />.
        /// </summary>
        public Collection<Consensus.Security.LicenseLimit> Limits
        {
            get
            {
                if (_limits == null)
                    _limits = new ProxyCollection<Consensus.Security.LicenseLimit, Consensus.Security.ILicenseLimitModel>(this.Model.Limits, model => new Consensus.Security.LicenseLimit(model));
                return _limits;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal License(ILicenseModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public void Save()
        {
            this.Model.Save();
        }

        /// <summary>
        ///     Gets the active software license.
        /// </summary>
        /// <returns>
        ///     The most applicable software license.
        /// </returns>
        public static Consensus.Security.License GetCurrent()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return License.GetCurrent(site);
        }

        /// <summary>
        ///     Gets the active software license.
        /// </summary>
        /// <returns>
        ///     The most applicable software license.
        /// </returns>
        public static Consensus.Security.License GetCurrent(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.ILicenseModel model = provider.Security.License.GetCurrent();
            return model == null ? null : new Consensus.Security.License(model);
        }

        /// <summary>
        ///     Generates a signature for the specified license verification code.
        /// </summary>
        public static System.String Sign(System.String verification)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return License.Sign(site,verification);
        }

        /// <summary>
        ///     Generates a signature for the specified license verification code.
        /// </summary>
        public static System.String Sign(ConsensusSite site, System.String verification)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.License.Sign(verification);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LicenseModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseModel" /> instance.
        /// </returns>
        public static Consensus.Security.License Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return License.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LicenseModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseModel" /> instance.
        /// </returns>
        public static Consensus.Security.License Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.ILicenseModel model = provider.Security.License.Create();
            return model == null ? null : new Consensus.Security.License(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.License> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return License.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.License> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.ILicenseModel> collection = provider.Security.License.FetchAll();
            return collection.Select(model => new Consensus.Security.License(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.License FetchById(System.Guid id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return License.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.License FetchById(ConsensusSite site, System.Guid id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.ILicenseModel model = provider.Security.License.FetchById(id);
            return model == null ? null : new Consensus.Security.License(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return License.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.License.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseModel" /> instances.
        /// </summary>
        /// <param name="ownerId">
        ///     The value which identifies the <see cref="!:LicenseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModel" /> instances that match the specified <paramref name="ownerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.License> FetchAllByOwnerId(System.String ownerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return License.FetchAllByOwnerId(site,ownerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseModel" /> instances.
        /// </summary>
        /// <param name="ownerId">
        ///     The value which identifies the <see cref="!:LicenseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModel" /> instances that match the specified <paramref name="ownerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Security.License> FetchAllByOwnerId(ConsensusSite site, System.String ownerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.ILicenseModel> collection = provider.Security.License.FetchAllByOwnerId(ownerId);
            return collection.Select(model => new Consensus.Security.License(model));
        }

        #endregion
    }
}
