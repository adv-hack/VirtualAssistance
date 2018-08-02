using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Learning;

namespace Consensus.Activities
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ActivityXref : Proxy<IActivityXrefModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Activity" /> member.
        /// </summary>
        private Consensus.Activities.Activity _activity;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Person" /> member.
        /// </summary>
        private Consensus.Contact.Person _person;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PersonRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _personRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        #endregion

        #region properties

        public Consensus.Activities.ActivityReferenceTypes ActivityReferenceType
        {
            get { return this.Model.ActivityReferenceType; }
            set { this.Model.ActivityReferenceType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        public Consensus.Activities.Activity Activity
        {
            get
            {
                if (_activity == null && this.Model.Activity != null)
                    _activity = new Consensus.Activities.Activity(this.Model.Activity);
                if (_activity == null)
                    _activity = Consensus.Activities.Activity.Create();
                return _activity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        public System.String ActivityId
        {
            get { return this.Model.ActivityId; }
            set { this.Model.ActivityId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        public Consensus.Contact.Person Person
        {
            get
            {
                if (_person == null && this.Model.Person != null)
                    _person = new Consensus.Contact.Person(this.Model.Person);
                if (_person == null)
                    _person = Consensus.Contact.Person.Create();
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        public System.String PersonId
        {
            get { return this.Model.PersonId; }
            set { this.Model.PersonId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACTXREF_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role PersonRole
        {
            get
            {
                if (_personRole == null && this.Model.PersonRole != null)
                    _personRole = new Consensus.Contact.Role(this.Model.PersonRole);
                if (_personRole == null)
                    _personRole = Consensus.Contact.Role.Create();
                return _personRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        public System.String PersonRoleId
        {
            get { return this.Model.PersonRoleId; }
            set { this.Model.PersonRoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ORG_NAME" field.
        /// </summary>
        public System.String OrgName
        {
            get { return this.Model.OrgName; }
            set { this.Model.OrgName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_PN_NAME" field.
        /// </summary>
        public System.String PnName
        {
            get { return this.Model.PnName; }
            set { this.Model.PnName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TRAINER" field.
        /// </summary>
        public System.Nullable<System.Byte> Trainer
        {
            get { return this.Model.Trainer; }
            set { this.Model.Trainer = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ADMIN" field.
        /// </summary>
        public System.Nullable<System.Byte> Admin
        {
            get { return this.Model.Admin; }
            set { this.Model.Admin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_SESSION" field.
        /// </summary>
        public System.Nullable<System.Byte> Session
        {
            get { return this.Model.Session; }
            set { this.Model.Session = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACTXREF_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_HOUR_RATE" field.
        /// </summary>
        public System.Nullable<System.Double> HourRate
        {
            get { return this.Model.HourRate; }
            set { this.Model.HourRate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_DAY_RATE" field.
        /// </summary>
        public System.Nullable<System.Double> DayRate
        {
            get { return this.Model.DayRate; }
            set { this.Model.DayRate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_CST_AC" field.
        /// </summary>
        public System.Nullable<System.Double> CstAc
        {
            get { return this.Model.CstAc; }
            set { this.Model.CstAc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TRAINER_T" field.
        /// </summary>
        public System.String TrainerT
        {
            get { return this.Model.TrainerT; }
            set { this.Model.TrainerT = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ADMIN_T" field.
        /// </summary>
        public System.String AdminT
        {
            get { return this.Model.AdminT; }
            set { this.Model.AdminT = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_PROF_KEY" field.
        /// </summary>
        public System.String ProfKey
        {
            get { return this.Model.ProfKey; }
            set { this.Model.ProfKey = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_UNT_TYPE" field.
        /// </summary>
        public System.String UntType
        {
            get { return this.Model.UntType; }
            set { this.Model.UntType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_INC_IN_BUDGET" field.
        /// </summary>
        public System.Byte IncInBudget
        {
            get { return this.Model.IncInBudget; }
            set { this.Model.IncInBudget = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ActivityXref(IActivityXrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ActivityXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActivityXrefModel" /> instance.
        /// </returns>
        public static Consensus.Activities.ActivityXref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActivityXref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ActivityXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActivityXrefModel" /> instance.
        /// </returns>
        public static Consensus.Activities.ActivityXref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IActivityXrefModel model = provider.Activities.ActivityXref.Create();
            return model == null ? null : new Consensus.Activities.ActivityXref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActivityXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActivityXref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActivityXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActivityXrefModel> collection = provider.Activities.ActivityXref.FetchAll();
            return collection.Select(model => new Consensus.Activities.ActivityXref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActivityXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActivityXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.ActivityXref FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActivityXref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActivityXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActivityXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.ActivityXref FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IActivityXrefModel model = provider.Activities.ActivityXref.FetchById(id);
            return model == null ? null : new Consensus.Activities.ActivityXref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActivityXref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Activities.ActivityXref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAllByActivityId(System.String activityId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActivityXref.FetchAllByActivityId(site,activityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAllByActivityId(ConsensusSite site, System.String activityId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActivityXrefModel> collection = provider.Activities.ActivityXref.FetchAllByActivityId(activityId);
            return collection.Select(model => new Consensus.Activities.ActivityXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAllByPersonId(System.String personId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActivityXref.FetchAllByPersonId(site,personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAllByPersonId(ConsensusSite site, System.String personId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActivityXrefModel> collection = provider.Activities.ActivityXref.FetchAllByPersonId(personId);
            return collection.Select(model => new Consensus.Activities.ActivityXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActivityXref.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActivityXrefModel> collection = provider.Activities.ActivityXref.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Activities.ActivityXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="personRoleId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="personRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAllByPersonRoleId(System.String personRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActivityXref.FetchAllByPersonRoleId(site,personRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="personRoleId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="personRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAllByPersonRoleId(ConsensusSite site, System.String personRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActivityXrefModel> collection = provider.Activities.ActivityXref.FetchAllByPersonRoleId(personRoleId);
            return collection.Select(model => new Consensus.Activities.ActivityXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ActivityXref.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.ActivityXref> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActivityXrefModel> collection = provider.Activities.ActivityXref.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Activities.ActivityXref(model));
        }

        #endregion
    }
}
