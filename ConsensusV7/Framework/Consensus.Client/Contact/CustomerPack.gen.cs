using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Document;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class CustomerPack : Proxy<ICustomerPackModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Pack" /> member.
        /// </summary>
        private Consensus.Document.Pack _pack;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "CPA_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation Organisation
        {
            get
            {
                if (_organisation == null && this.Model.Organisation != null)
                    _organisation = new Consensus.Contact.Organisation(this.Model.Organisation);
                if (_organisation == null)
                    _organisation = Consensus.Contact.Organisation.Create();
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CPA_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CPA_PACK_ID" field.
        /// </summary>
        public Consensus.Document.Pack Pack
        {
            get
            {
                if (_pack == null && this.Model.Pack != null)
                    _pack = new Consensus.Document.Pack(this.Model.Pack);
                if (_pack == null)
                    _pack = Consensus.Document.Pack.Create();
                return _pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CPA_PACK_ID" field.
        /// </summary>
        public System.String PackId
        {
            get { return this.Model.PackId; }
            set { this.Model.PackId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CPA_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CPA_SUPPRESS" field.
        /// </summary>
        public System.Byte Suppress
        {
            get { return this.Model.Suppress; }
            set { this.Model.Suppress = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal CustomerPack(ICustomerPackModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:CustomerPackModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CustomerPackModel" /> instance.
        /// </returns>
        public static Consensus.Contact.CustomerPack Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CustomerPack.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CustomerPackModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CustomerPackModel" /> instance.
        /// </returns>
        public static Consensus.Contact.CustomerPack Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ICustomerPackModel model = provider.Contact.CustomerPack.Create();
            return model == null ? null : new Consensus.Contact.CustomerPack(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CustomerPackModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CustomerPackModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CustomerPack> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CustomerPack.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CustomerPackModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CustomerPackModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CustomerPack> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ICustomerPackModel> collection = provider.Contact.CustomerPack.FetchAll();
            return collection.Select(model => new Consensus.Contact.CustomerPack(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CustomerPackModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CustomerPackModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.CustomerPack FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CustomerPack.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CustomerPackModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CustomerPackModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.CustomerPack FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ICustomerPackModel model = provider.Contact.CustomerPack.FetchById(id);
            return model == null ? null : new Consensus.Contact.CustomerPack(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CustomerPack.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.CustomerPack.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CustomerPackModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:CustomerPackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CustomerPack> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CustomerPack.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CustomerPackModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:CustomerPackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CustomerPack> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ICustomerPackModel> collection = provider.Contact.CustomerPack.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Contact.CustomerPack(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CustomerPackModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:CustomerPackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CustomerPack> FetchAllByPackId(System.String packId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CustomerPack.FetchAllByPackId(site,packId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CustomerPackModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:CustomerPackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CustomerPackModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.CustomerPack> FetchAllByPackId(ConsensusSite site, System.String packId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ICustomerPackModel> collection = provider.Contact.CustomerPack.FetchAllByPackId(packId);
            return collection.Select(model => new Consensus.Contact.CustomerPack(model));
        }

        #endregion
    }
}
