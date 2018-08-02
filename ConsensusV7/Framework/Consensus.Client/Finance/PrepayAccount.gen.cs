using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PrepayAccount : Proxy<IPrepayAccountModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Contact" /> member.
        /// </summary>
        private Consensus.Contact.Role _contact;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Membership" /> member.
        /// </summary>
        private Consensus.Membership.MemberPeriod _membership;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "MSTC_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "MSTC_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_MEMB_VAL" field.
        /// </summary>
        public System.Decimal TotalPaidToDate
        {
            get { return this.Model.TotalPaidToDate; }
            set { this.Model.TotalPaidToDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_CONTACT" field.
        /// </summary>
        public Consensus.Contact.Role Contact
        {
            get
            {
                if (_contact == null && this.Model.Contact != null)
                    _contact = new Consensus.Contact.Role(this.Model.Contact);
                if (_contact == null)
                    _contact = Consensus.Contact.Role.Create();
                return _contact;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_CONTACT" field.
        /// </summary>
        public System.String ContactId
        {
            get { return this.Model.ContactId; }
            set { this.Model.ContactId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_PAY_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> PayDate
        {
            get { return this.Model.PayDate; }
            set { this.Model.PayDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_TOT_POINTS" field.
        /// </summary>
        public System.Decimal TotalPoints
        {
            get { return this.Model.TotalPoints; }
            set { this.Model.TotalPoints = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_REMAIN_PTS" field.
        /// </summary>
        public System.Decimal RemainPts
        {
            get { return this.Model.RemainPts; }
            set { this.Model.RemainPts = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_STATUS" field.
        /// </summary>
        public Consensus.Common.Code Status
        {
            get
            {
                if (_status == null && this.Model.Status != null)
                    _status = new Consensus.Common.Code(this.Model.Status);
                if (_status == null)
                    _status = Consensus.Common.Code.Create();
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_PROD_ID" field.
        /// </summary>
        public Consensus.Learning.Product Product
        {
            get
            {
                if (_product == null && this.Model.Product != null)
                    _product = new Consensus.Learning.Product(this.Model.Product);
                if (_product == null)
                    _product = Consensus.Learning.Product.Create();
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_STOP_FLAG" field.
        /// </summary>
        public System.Nullable<System.Byte> Stopped
        {
            get { return this.Model.Stopped; }
            set { this.Model.Stopped = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAMED_USERS" field.
        /// </summary>
        public System.Nullable<System.Byte> NamedUsers
        {
            get { return this.Model.NamedUsers; }
            set { this.Model.NamedUsers = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_CURRENCY_TYPE" field.
        /// </summary>
        public System.String CurrencyType
        {
            get { return this.Model.CurrencyType; }
            set { this.Model.CurrencyType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MSTC_MEP_ID" field.
        /// </summary>
        public Consensus.Membership.MemberPeriod Membership
        {
            get
            {
                if (_membership == null && this.Model.Membership != null)
                    _membership = new Consensus.Membership.MemberPeriod(this.Model.Membership);
                if (_membership == null)
                    _membership = Consensus.Membership.MemberPeriod.Create();
                return _membership;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MSTC_MEP_ID" field.
        /// </summary>
        public System.String MembershipId
        {
            get { return this.Model.MembershipId; }
            set { this.Model.MembershipId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAMED_BOOKERS" field.
        /// </summary>
        public System.Nullable<System.Byte> NamedBookers
        {
            get { return this.Model.NamedBookers; }
            set { this.Model.NamedBookers = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MSTC_UNIQUE_REF" field.
        /// </summary>
        public System.String UniqueRef
        {
            get { return this.Model.UniqueRef; }
            set { this.Model.UniqueRef = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PrepayAccount(IPrepayAccountModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PrepayAccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PrepayAccountModel" /> instance.
        /// </returns>
        public static Consensus.Finance.PrepayAccount Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrepayAccount.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PrepayAccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PrepayAccountModel" /> instance.
        /// </returns>
        public static Consensus.Finance.PrepayAccount Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPrepayAccountModel model = provider.Finance.PrepayAccount.Create();
            return model == null ? null : new Consensus.Finance.PrepayAccount(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PrepayAccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PrepayAccount> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrepayAccount.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PrepayAccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PrepayAccount> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPrepayAccountModel> collection = provider.Finance.PrepayAccount.FetchAll();
            return collection.Select(model => new Consensus.Finance.PrepayAccount(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PrepayAccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PrepayAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.PrepayAccount FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrepayAccount.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PrepayAccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PrepayAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.PrepayAccount FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPrepayAccountModel model = provider.Finance.PrepayAccount.FetchById(id);
            return model == null ? null : new Consensus.Finance.PrepayAccount(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrepayAccount.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.PrepayAccount.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PrepayAccount> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrepayAccount.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PrepayAccount> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPrepayAccountModel> collection = provider.Finance.PrepayAccount.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Finance.PrepayAccount(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="contactId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="contactId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PrepayAccount> FetchAllByContactId(System.String contactId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrepayAccount.FetchAllByContactId(site,contactId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="contactId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="contactId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PrepayAccount> FetchAllByContactId(ConsensusSite site, System.String contactId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPrepayAccountModel> collection = provider.Finance.PrepayAccount.FetchAllByContactId(contactId);
            return collection.Select(model => new Consensus.Finance.PrepayAccount(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PrepayAccount> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrepayAccount.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PrepayAccount> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPrepayAccountModel> collection = provider.Finance.PrepayAccount.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Finance.PrepayAccount(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="membershipId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="membershipId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PrepayAccount> FetchAllByMembershipId(System.String membershipId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PrepayAccount.FetchAllByMembershipId(site,membershipId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="membershipId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="membershipId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PrepayAccount> FetchAllByMembershipId(ConsensusSite site, System.String membershipId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPrepayAccountModel> collection = provider.Finance.PrepayAccount.FetchAllByMembershipId(membershipId);
            return collection.Select(model => new Consensus.Finance.PrepayAccount(model));
        }

        #endregion
    }
}
