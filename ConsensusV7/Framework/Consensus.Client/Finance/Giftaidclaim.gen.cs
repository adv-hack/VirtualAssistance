using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Giftaidclaim : Proxy<IGiftaidclaimModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Submitter" /> member.
        /// </summary>
        private Consensus.Contact.Role _submitter;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Trustee" /> member.
        /// </summary>
        private Consensus.Contact.Role _trustee;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role Submitter
        {
            get
            {
                if (_submitter == null && this.Model.Submitter != null)
                    _submitter = new Consensus.Contact.Role(this.Model.Submitter);
                if (_submitter == null)
                    _submitter = Consensus.Contact.Role.Create();
                return _submitter;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        public System.String SubmitterId
        {
            get { return this.Model.SubmitterId; }
            set { this.Model.SubmitterId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role Trustee
        {
            get
            {
                if (_trustee == null && this.Model.Trustee != null)
                    _trustee = new Consensus.Contact.Role(this.Model.Trustee);
                if (_trustee == null)
                    _trustee = Consensus.Contact.Role.Create();
                return _trustee;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        public System.String TrusteeId
        {
            get { return this.Model.TrusteeId; }
            set { this.Model.TrusteeId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "GAC_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "GAC_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_CLAIM_DATE" field.
        /// </summary>
        public System.DateTime ClaimDate
        {
            get { return this.Model.ClaimDate; }
            set { this.Model.ClaimDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_DONATIONS_FROM" field.
        /// </summary>
        public System.DateTime DonationsFrom
        {
            get { return this.Model.DonationsFrom; }
            set { this.Model.DonationsFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_DONATIONS_TO" field.
        /// </summary>
        public System.DateTime DonationsTo
        {
            get { return this.Model.DonationsTo; }
            set { this.Model.DonationsTo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_ACCOUNTING_PERIOD_END" field.
        /// </summary>
        public System.DateTime AccountingPeriodEnd
        {
            get { return this.Model.AccountingPeriodEnd; }
            set { this.Model.AccountingPeriodEnd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_HMRC_REFERENCE" field.
        /// </summary>
        public System.String HmrcReference
        {
            get { return this.Model.HmrcReference; }
            set { this.Model.HmrcReference = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_REGULATOR_NAME" field.
        /// </summary>
        public System.String RegulatorName
        {
            get { return this.Model.RegulatorName; }
            set { this.Model.RegulatorName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_REGULATOR_NUMBER" field.
        /// </summary>
        public System.String RegulatorNumber
        {
            get { return this.Model.RegulatorNumber; }
            set { this.Model.RegulatorNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_ADJUSTMENT" field.
        /// </summary>
        public System.Nullable<System.Decimal> Adjustment
        {
            get { return this.Model.Adjustment; }
            set { this.Model.Adjustment = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_PROCESS" field.
        /// </summary>
        public System.Byte Process
        {
            get { return this.Model.Process; }
            set { this.Model.Process = value; }
        }

        /// <summary>
        ///     Gets the The value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.Model.SellingCompany != null)
                    _sellingCompany = new Consensus.Common.SellingCompany(this.Model.SellingCompany);
                if (_sellingCompany == null)
                    _sellingCompany = Consensus.Common.SellingCompany.Create();
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Giftaidclaim(IGiftaidclaimModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:GiftaidclaimModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GiftaidclaimModel" /> instance.
        /// </returns>
        public static Consensus.Finance.Giftaidclaim Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaidclaim.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:GiftaidclaimModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GiftaidclaimModel" /> instance.
        /// </returns>
        public static Consensus.Finance.Giftaidclaim Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IGiftaidclaimModel model = provider.Finance.Giftaidclaim.Create();
            return model == null ? null : new Consensus.Finance.Giftaidclaim(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GiftaidclaimModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Giftaidclaim> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaidclaim.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GiftaidclaimModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Giftaidclaim> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IGiftaidclaimModel> collection = provider.Finance.Giftaidclaim.FetchAll();
            return collection.Select(model => new Consensus.Finance.Giftaidclaim(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GiftaidclaimModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GiftaidclaimModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.Giftaidclaim FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaidclaim.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GiftaidclaimModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GiftaidclaimModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.Giftaidclaim FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IGiftaidclaimModel model = provider.Finance.Giftaidclaim.FetchById(id);
            return model == null ? null : new Consensus.Finance.Giftaidclaim(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaidclaim.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.Giftaidclaim.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="submitterId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="submitterId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Giftaidclaim> FetchAllBySubmitterId(System.String submitterId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaidclaim.FetchAllBySubmitterId(site,submitterId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="submitterId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="submitterId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Giftaidclaim> FetchAllBySubmitterId(ConsensusSite site, System.String submitterId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IGiftaidclaimModel> collection = provider.Finance.Giftaidclaim.FetchAllBySubmitterId(submitterId);
            return collection.Select(model => new Consensus.Finance.Giftaidclaim(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="trusteeId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="trusteeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Giftaidclaim> FetchAllByTrusteeId(System.String trusteeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaidclaim.FetchAllByTrusteeId(site,trusteeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="trusteeId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="trusteeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Giftaidclaim> FetchAllByTrusteeId(ConsensusSite site, System.String trusteeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IGiftaidclaimModel> collection = provider.Finance.Giftaidclaim.FetchAllByTrusteeId(trusteeId);
            return collection.Select(model => new Consensus.Finance.Giftaidclaim(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Giftaidclaim> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaidclaim.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Giftaidclaim> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IGiftaidclaimModel> collection = provider.Finance.Giftaidclaim.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Finance.Giftaidclaim(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Giftaidclaim> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaidclaim.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Giftaidclaim> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IGiftaidclaimModel> collection = provider.Finance.Giftaidclaim.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Finance.Giftaidclaim(model));
        }

        #endregion
    }
}
