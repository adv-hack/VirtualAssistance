using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents An organisation address.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class OrganisationAddress : Proxy<IOrganisationAddressModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Address" /> member.
        /// </summary>
        private Consensus.Contact.Address _address;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "ADDXREF_ADD_ID" field.
        /// </summary>
        public Consensus.Contact.Address Address
        {
            get
            {
                if (_address == null && this.Model.Address != null)
                    _address = new Consensus.Contact.Address(this.Model.Address);
                if (_address == null)
                    _address = Consensus.Contact.Address.Create();
                return _address;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ADDXREF_ADD_ID" field.
        /// </summary>
        public System.String AddressId
        {
            get { return this.Model.AddressId; }
            set { this.Model.AddressId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ADDXREF_TYPE" field.
        /// </summary>
        public Consensus.Common.Code Type
        {
            get
            {
                if (_type == null && this.Model.Type != null)
                    _type = new Consensus.Common.Code(this.Model.Type);
                if (_type == null)
                    _type = Consensus.Common.Code.Create();
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ADDXREF_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ADDXREF_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ADDXREF_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADDXREF_PRINCIPAL" field.
        /// </summary>
        public System.Nullable<System.Byte> Principal
        {
            get { return this.Model.Principal; }
            set { this.Model.Principal = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal OrganisationAddress(IOrganisationAddressModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:OrganisationAddressModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OrganisationAddressModel" /> instance.
        /// </returns>
        public static Consensus.Contact.OrganisationAddress Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationAddress.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:OrganisationAddressModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OrganisationAddressModel" /> instance.
        /// </returns>
        public static Consensus.Contact.OrganisationAddress Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IOrganisationAddressModel model = provider.Contact.OrganisationAddress.Create();
            return model == null ? null : new Consensus.Contact.OrganisationAddress(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OrganisationAddressModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OrganisationAddressModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.OrganisationAddress> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationAddress.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OrganisationAddressModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OrganisationAddressModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.OrganisationAddress> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IOrganisationAddressModel> collection = provider.Contact.OrganisationAddress.FetchAll();
            return collection.Select(model => new Consensus.Contact.OrganisationAddress(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OrganisationAddressModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OrganisationAddressModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationAddressModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.OrganisationAddress FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationAddress.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OrganisationAddressModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OrganisationAddressModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationAddressModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.OrganisationAddress FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IOrganisationAddressModel model = provider.Contact.OrganisationAddress.FetchById(id);
            return model == null ? null : new Consensus.Contact.OrganisationAddress(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationAddress.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.OrganisationAddress.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationAddressModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:OrganisationAddressModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationAddressModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.OrganisationAddress> FetchAllByAddressId(System.String addressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationAddress.FetchAllByAddressId(site,addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationAddressModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:OrganisationAddressModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationAddressModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.OrganisationAddress> FetchAllByAddressId(ConsensusSite site, System.String addressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IOrganisationAddressModel> collection = provider.Contact.OrganisationAddress.FetchAllByAddressId(addressId);
            return collection.Select(model => new Consensus.Contact.OrganisationAddress(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationAddressModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:OrganisationAddressModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationAddressModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.OrganisationAddress> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OrganisationAddress.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationAddressModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:OrganisationAddressModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationAddressModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.OrganisationAddress> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IOrganisationAddressModel> collection = provider.Contact.OrganisationAddress.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Contact.OrganisationAddress(model));
        }

        #endregion
    }
}
