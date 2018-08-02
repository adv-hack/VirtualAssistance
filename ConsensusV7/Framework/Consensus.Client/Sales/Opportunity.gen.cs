using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Learning;
using Consensus.Marketing;

namespace Consensus.Sales
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Opportunity : Proxy<IOpportunityModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ClientOppXref" /> member.
        /// </summary>
        private Consensus.Sales.OpportunityXref _clientOppXref;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SalesOppXref" /> member.
        /// </summary>
        private Consensus.Sales.OpportunityXref _salesOppXref;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PromId" /> member.
        /// </summary>
        private Consensus.Marketing.Promotion _promId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProdInterest" /> member.
        /// </summary>
        private Consensus.Common.Code _prodInterest;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Source" /> member.
        /// </summary>
        private Consensus.Common.Code _source;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Activity" /> member.
        /// </summary>
        private Consensus.Activities.Activity _activity;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Competitor" /> member.
        /// </summary>
        private Consensus.Common.Code _competitor;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SalesType" /> member.
        /// </summary>
        private Consensus.Common.Code _salesType;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CourseId" /> member.
        /// </summary>
        private Consensus.Learning.Event _courseId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Service" /> member.
        /// </summary>
        private Consensus.Common.Code _service;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SearchGroup" /> member.
        /// </summary>
        private Consensus.Common.Code _searchGroup;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Events" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _events;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Bookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _bookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="OpportunityXrefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Sales.OpportunityXref, Consensus.Sales.IOpportunityXrefModel> _opportunityXrefs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ActivityOpportunity" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Activity, Consensus.Activities.IActivityModel> _activityOpportunity;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the client for the opp.
        /// </summary>
        public Consensus.Sales.OpportunityXref ClientOppXref
        {
            get
            {
                if (_clientOppXref == null && this.Model.ClientOppXref != null)
                    _clientOppXref = new Consensus.Sales.OpportunityXref(this.Model.ClientOppXref);
                if (_clientOppXref == null)
                    _clientOppXref = Consensus.Sales.OpportunityXref.Create();
                return _clientOppXref;
            }
            set
            {
                _clientOppXref = value;
                this.Model.ClientOppXref = value.Model;
            }
        }

        /// <summary>
        ///     Gets or sets the main sales person for the opp.
        /// </summary>
        public Consensus.Sales.OpportunityXref SalesOppXref
        {
            get
            {
                if (_salesOppXref == null && this.Model.SalesOppXref != null)
                    _salesOppXref = new Consensus.Sales.OpportunityXref(this.Model.SalesOppXref);
                if (_salesOppXref == null)
                    _salesOppXref = Consensus.Sales.OpportunityXref.Create();
                return _salesOppXref;
            }
            set
            {
                _salesOppXref = value;
                this.Model.SalesOppXref = value.Model;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_QUO_ID" field.
        /// </summary>
        public System.String QuoId
        {
            get { return this.Model.QuoId; }
            set { this.Model.QuoId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROM_ID" field.
        /// </summary>
        public Consensus.Marketing.Promotion PromId
        {
            get
            {
                if (_promId == null && this.Model.PromId != null)
                    _promId = new Consensus.Marketing.Promotion(this.Model.PromId);
                if (_promId == null)
                    _promId = Consensus.Marketing.Promotion.Create();
                return _promId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROM_ID" field.
        /// </summary>
        public System.String PromIdId
        {
            get { return this.Model.PromIdId; }
            set { this.Model.PromIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_STATUS" field.
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
        ///     Gets or sets the unique code for the value of the "OPP_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_DATE_ENQ" field.
        /// </summary>
        public System.Nullable<System.DateTime> DateEnq
        {
            get { return this.Model.DateEnq; }
            set { this.Model.DateEnq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_DATE_DEC" field.
        /// </summary>
        public System.Nullable<System.DateTime> DateDec
        {
            get { return this.Model.DateDec; }
            set { this.Model.DateDec = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_VAL_POT" field.
        /// </summary>
        public System.Nullable<System.Double> ValPot
        {
            get { return this.Model.ValPot; }
            set { this.Model.ValPot = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_PROB_PURCH" field.
        /// </summary>
        public System.Nullable<System.Byte> ProbPurch
        {
            get { return this.Model.ProbPurch; }
            set { this.Model.ProbPurch = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_PROB_WIN" field.
        /// </summary>
        public System.Nullable<System.Byte> ProbWin
        {
            get { return this.Model.ProbWin; }
            set { this.Model.ProbWin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_ROLL_QTY" field.
        /// </summary>
        public System.Nullable<System.Double> RollQty
        {
            get { return this.Model.RollQty; }
            set { this.Model.RollQty = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        public Consensus.Common.Code ProdInterest
        {
            get
            {
                if (_prodInterest == null && this.Model.ProdInterest != null)
                    _prodInterest = new Consensus.Common.Code(this.Model.ProdInterest);
                if (_prodInterest == null)
                    _prodInterest = Consensus.Common.Code.Create();
                return _prodInterest;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        public System.String ProdInterestCode
        {
            get { return this.Model.ProdInterestCode; }
            set { this.Model.ProdInterestCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_MEDIUM" field.
        /// </summary>
        public Consensus.Common.Code Source
        {
            get
            {
                if (_source == null && this.Model.Source != null)
                    _source = new Consensus.Common.Code(this.Model.Source);
                if (_source == null)
                    _source = Consensus.Common.Code.Create();
                return _source;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_MEDIUM" field.
        /// </summary>
        public System.String SourceCode
        {
            get { return this.Model.SourceCode; }
            set { this.Model.SourceCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_ACT_ID" field.
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
        ///     Gets or sets the unique code for the value of the "OPP_ACT_ID" field.
        /// </summary>
        public System.String ActivityId
        {
            get { return this.Model.ActivityId; }
            set { this.Model.ActivityId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_COMPETITOR" field.
        /// </summary>
        public Consensus.Common.Code Competitor
        {
            get
            {
                if (_competitor == null && this.Model.Competitor != null)
                    _competitor = new Consensus.Common.Code(this.Model.Competitor);
                if (_competitor == null)
                    _competitor = Consensus.Common.Code.Create();
                return _competitor;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_COMPETITOR" field.
        /// </summary>
        public System.String CompetitorCode
        {
            get { return this.Model.CompetitorCode; }
            set { this.Model.CompetitorCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_COMMIT" field.
        /// </summary>
        public System.Nullable<System.Byte> Commit
        {
            get { return this.Model.Commit; }
            set { this.Model.Commit = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "OPP_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SALES_TYPE" field.
        /// </summary>
        public Consensus.Common.Code SalesType
        {
            get
            {
                if (_salesType == null && this.Model.SalesType != null)
                    _salesType = new Consensus.Common.Code(this.Model.SalesType);
                if (_salesType == null)
                    _salesType = Consensus.Common.Code.Create();
                return _salesType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SALES_TYPE" field.
        /// </summary>
        public System.String SalesTypeCode
        {
            get { return this.Model.SalesTypeCode; }
            set { this.Model.SalesTypeCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_COURSE_ID" field.
        /// </summary>
        public Consensus.Learning.Event CourseId
        {
            get
            {
                if (_courseId == null && this.Model.CourseId != null)
                    _courseId = new Consensus.Learning.Event(this.Model.CourseId);
                if (_courseId == null)
                    _courseId = Consensus.Learning.Event.Create();
                return _courseId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_COURSE_ID" field.
        /// </summary>
        public System.String CourseIdId
        {
            get { return this.Model.CourseIdId; }
            set { this.Model.CourseIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "OPP_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_COST_CODE" field.
        /// </summary>
        public System.String CostCode
        {
            get { return this.Model.CostCode; }
            set { this.Model.CostCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SERVICE" field.
        /// </summary>
        public Consensus.Common.Code Service
        {
            get
            {
                if (_service == null && this.Model.Service != null)
                    _service = new Consensus.Common.Code(this.Model.Service);
                if (_service == null)
                    _service = Consensus.Common.Code.Create();
                return _service;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SERVICE" field.
        /// </summary>
        public System.String ServiceCode
        {
            get { return this.Model.ServiceCode; }
            set { this.Model.ServiceCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        public Consensus.Common.Code SearchGroup
        {
            get
            {
                if (_searchGroup == null && this.Model.SearchGroup != null)
                    _searchGroup = new Consensus.Common.Code(this.Model.SearchGroup);
                if (_searchGroup == null)
                    _searchGroup = Consensus.Common.Code.Create();
                return _searchGroup;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        public System.String SearchGroupCode
        {
            get { return this.Model.SearchGroupCode; }
            set { this.Model.SearchGroupCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_SY_TYPE" field.
        /// </summary>
        public System.Int32 SyType
        {
            get { return this.Model.SyType; }
            set { this.Model.SyType = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Event> Events
        {
            get
            {
                if (_events == null)
                    _events = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.Events, model => new Consensus.Learning.Event(model));
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Booking> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel>(this.Model.Bookings, model => new Consensus.Learning.Booking(model));
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityXrefModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        public Collection<Consensus.Sales.OpportunityXref> OpportunityXrefs
        {
            get
            {
                if (_opportunityXrefs == null)
                    _opportunityXrefs = new ProxyCollection<Consensus.Sales.OpportunityXref, Consensus.Sales.IOpportunityXrefModel>(this.Model.OpportunityXrefs, model => new Consensus.Sales.OpportunityXref(model));
                return _opportunityXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Activity> ActivityOpportunity
        {
            get
            {
                if (_activityOpportunity == null)
                    _activityOpportunity = new ProxyCollection<Consensus.Activities.Activity, Consensus.Activities.IActivityModel>(this.Model.ActivityOpportunity, model => new Consensus.Activities.Activity(model));
                return _activityOpportunity;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Opportunity(IOpportunityModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:OpportunityModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OpportunityModel" /> instance.
        /// </returns>
        public static Consensus.Sales.Opportunity Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Opportunity.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:OpportunityModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OpportunityModel" /> instance.
        /// </returns>
        public static Consensus.Sales.Opportunity Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Sales.IOpportunityModel model = provider.Sales.Opportunity.Create();
            return model == null ? null : new Consensus.Sales.Opportunity(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OpportunityModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OpportunityModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Opportunity.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OpportunityModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OpportunityModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.IOpportunityModel> collection = provider.Sales.Opportunity.FetchAll();
            return collection.Select(model => new Consensus.Sales.Opportunity(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OpportunityModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OpportunityModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Sales.Opportunity FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Opportunity.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OpportunityModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OpportunityModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Sales.Opportunity FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Sales.IOpportunityModel model = provider.Sales.Opportunity.FetchById(id);
            return model == null ? null : new Consensus.Sales.Opportunity(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Opportunity.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Sales.Opportunity.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="promIdId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="promIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAllByPromIdId(System.String promIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Opportunity.FetchAllByPromIdId(site,promIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="promIdId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="promIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAllByPromIdId(ConsensusSite site, System.String promIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.IOpportunityModel> collection = provider.Sales.Opportunity.FetchAllByPromIdId(promIdId);
            return collection.Select(model => new Consensus.Sales.Opportunity(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAllByActivityId(System.String activityId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Opportunity.FetchAllByActivityId(site,activityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAllByActivityId(ConsensusSite site, System.String activityId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.IOpportunityModel> collection = provider.Sales.Opportunity.FetchAllByActivityId(activityId);
            return collection.Select(model => new Consensus.Sales.Opportunity(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Opportunity.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.IOpportunityModel> collection = provider.Sales.Opportunity.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Sales.Opportunity(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAllByCourseIdId(System.String courseIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Opportunity.FetchAllByCourseIdId(site,courseIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAllByCourseIdId(ConsensusSite site, System.String courseIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.IOpportunityModel> collection = provider.Sales.Opportunity.FetchAllByCourseIdId(courseIdId);
            return collection.Select(model => new Consensus.Sales.Opportunity(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Opportunity.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Sales.Opportunity> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.IOpportunityModel> collection = provider.Sales.Opportunity.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Sales.Opportunity(model));
        }

        #endregion
    }
}
