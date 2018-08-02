using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Sales
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class OpportunityXref : Proxy<IOpportunityXrefModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Role" /> member.
        /// </summary>
        private Consensus.Contact.Role _role;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Opportunity" /> member.
        /// </summary>
        private Consensus.Sales.Opportunity _opportunity;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the type of person that is linked to the opportunity.
        /// </summary>
        public Consensus.Sales.OpportunityPersonType PersonType
        {
            get { return this.Model.PersonType; }
            set { this.Model.PersonType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role Role
        {
            get
            {
                if (_role == null && this.Model.Role != null)
                    _role = new Consensus.Contact.Role(this.Model.Role);
                if (_role == null)
                    _role = Consensus.Contact.Role.Create();
                return _role;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        public System.String RoleId
        {
            get { return this.Model.RoleId; }
            set { this.Model.RoleId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        public Consensus.Sales.Opportunity Opportunity
        {
            get
            {
                if (_opportunity == null && this.Model.Opportunity != null)
                    _opportunity = new Consensus.Sales.Opportunity(this.Model.Opportunity);
                if (_opportunity == null)
                    _opportunity = Consensus.Sales.Opportunity.Create();
                return _opportunity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        public System.String OpportunityId
        {
            get { return this.Model.OpportunityId; }
            set { this.Model.OpportunityId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PRINCIPAL" field.
        /// </summary>
        public System.Nullable<System.Byte> Principal
        {
            get { return this.Model.Principal; }
            set { this.Model.Principal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_ORG_NAME" field.
        /// </summary>
        public System.String OrgName
        {
            get { return this.Model.OrgName; }
            set { this.Model.OrgName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PN_NAME" field.
        /// </summary>
        public System.String SalesPerson
        {
            get { return this.Model.SalesPerson; }
            set { this.Model.SalesPerson = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "OPPXREF_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_ORG_PHONE" field.
        /// </summary>
        public System.String OrgPhone
        {
            get { return this.Model.OrgPhone; }
            set { this.Model.OrgPhone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PN_PHONE" field.
        /// </summary>
        public System.String PnPhone
        {
            get { return this.Model.PnPhone; }
            set { this.Model.PnPhone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_VALUE" field.
        /// </summary>
        public System.Nullable<System.Decimal> Value
        {
            get { return this.Model.Value; }
            set { this.Model.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_SHARE" field.
        /// </summary>
        public System.Nullable<System.Decimal> Share
        {
            get { return this.Model.Share; }
            set { this.Model.Share = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal OpportunityXref(IOpportunityXrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:OpportunityXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OpportunityXrefModel" /> instance.
        /// </returns>
        public static Consensus.Sales.OpportunityXref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OpportunityXref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:OpportunityXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OpportunityXrefModel" /> instance.
        /// </returns>
        public static Consensus.Sales.OpportunityXref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Sales.IOpportunityXrefModel model = provider.Sales.OpportunityXref.Create();
            return model == null ? null : new Consensus.Sales.OpportunityXref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OpportunityXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Sales.OpportunityXref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OpportunityXref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OpportunityXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Sales.OpportunityXref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.IOpportunityXrefModel> collection = provider.Sales.OpportunityXref.FetchAll();
            return collection.Select(model => new Consensus.Sales.OpportunityXref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OpportunityXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OpportunityXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Sales.OpportunityXref FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OpportunityXref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OpportunityXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OpportunityXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Sales.OpportunityXref FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Sales.IOpportunityXrefModel model = provider.Sales.OpportunityXref.FetchById(id);
            return model == null ? null : new Consensus.Sales.OpportunityXref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OpportunityXref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Sales.OpportunityXref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.OpportunityXref> FetchAllByRoleId(System.String roleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OpportunityXref.FetchAllByRoleId(site,roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.OpportunityXref> FetchAllByRoleId(ConsensusSite site, System.String roleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.IOpportunityXrefModel> collection = provider.Sales.OpportunityXref.FetchAllByRoleId(roleId);
            return collection.Select(model => new Consensus.Sales.OpportunityXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.OpportunityXref> FetchAllByOpportunityId(System.String opportunityId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OpportunityXref.FetchAllByOpportunityId(site,opportunityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.OpportunityXref> FetchAllByOpportunityId(ConsensusSite site, System.String opportunityId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.IOpportunityXrefModel> collection = provider.Sales.OpportunityXref.FetchAllByOpportunityId(opportunityId);
            return collection.Select(model => new Consensus.Sales.OpportunityXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.OpportunityXref> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return OpportunityXref.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.OpportunityXref> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.IOpportunityXrefModel> collection = provider.Sales.OpportunityXref.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Sales.OpportunityXref(model));
        }

        #endregion
    }
}
