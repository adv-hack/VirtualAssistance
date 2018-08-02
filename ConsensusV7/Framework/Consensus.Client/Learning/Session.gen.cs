using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Session : Proxy<ISessionModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SessionXrefMaster" /> member.
        /// </summary>
        private Consensus.Learning.SessionXref _sessionXrefMaster;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Location" /> member.
        /// </summary>
        private Consensus.Contact.Location _location;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BiillOfMaterial" /> member.
        /// </summary>
        private Consensus.Learning.BillOfMaterial _biillOfMaterial;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SessionXrefActivity" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.SessionXref, Consensus.Learning.ISessionXrefModel> _sessionXrefActivity;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="EndUser" /> member.
        /// </summary>
        private Consensus.Activities.ActivityXref _endUser;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SalesPerson" /> member.
        /// </summary>
        private Consensus.Activities.ActivityXref _salesPerson;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Attachments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Common.Attachment, Consensus.Common.IAttachmentModel> _attachments;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Result" /> member.
        /// </summary>
        private Consensus.Common.Code _result;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Opportunity" /> member.
        /// </summary>
        private Consensus.Sales.Opportunity _opportunity;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Opportunities" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Sales.Opportunity, Consensus.Sales.IOpportunityModel> _opportunities;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ActivityXRefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.ActivityXref, Consensus.Activities.IActivityXrefModel> _activityXRefs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ActivityLinkXrefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.ActLinkXref, Consensus.Activities.IActLinkXrefModel> _activityLinkXrefs;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        public Consensus.Learning.SessionXref SessionXrefMaster
        {
            get
            {
                if (_sessionXrefMaster == null && this.Model.SessionXrefMaster != null)
                    _sessionXrefMaster = new Consensus.Learning.SessionXref(this.Model.SessionXrefMaster);
                if (_sessionXrefMaster == null)
                    _sessionXrefMaster = Consensus.Learning.SessionXref.Create();
                return _sessionXrefMaster;
            }
        }

        public System.Boolean IsModified
        {
            get { return this.Model.IsModified; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_DONE_IT" field.
        /// </summary>
        public System.Nullable<System.Byte> DoneIt
        {
            get { return this.Model.DoneIt; }
            set { this.Model.DoneIt = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_LOC_ID" field.
        /// </summary>
        public Consensus.Contact.Location Location
        {
            get
            {
                if (_location == null && this.Model.Location != null)
                    _location = new Consensus.Contact.Location(this.Model.Location);
                if (_location == null)
                    _location = Consensus.Contact.Location.Create();
                return _location;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_LOC_ID" field.
        /// </summary>
        public System.String LocationId
        {
            get { return this.Model.LocationId; }
            set { this.Model.LocationId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_SYLLABUS_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACT_SYLLABUS_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_MAX_PLACES" field.
        /// </summary>
        public System.Nullable<System.Double> MaxPlaces
        {
            get { return this.Model.MaxPlaces; }
            set { this.Model.MaxPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_MIN_PLACES" field.
        /// </summary>
        public System.Nullable<System.Double> MinPlaces
        {
            get { return this.Model.MinPlaces; }
            set { this.Model.MinPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_FREE_PLACES" field.
        /// </summary>
        public System.Nullable<System.Double> FreePlaces
        {
            get { return this.Model.FreePlaces; }
            set { this.Model.FreePlaces = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACT_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ADDRESS" field.
        /// </summary>
        public System.String Address
        {
            get { return this.Model.Address; }
            set { this.Model.Address = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_PQ_ID" field.
        /// </summary>
        public System.String PqId
        {
            get { return this.Model.PqId; }
            set { this.Model.PqId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ROOM_LAYOUT" field.
        /// </summary>
        public System.Nullable<System.Int32> RoomLayout
        {
            get { return this.Model.RoomLayout; }
            set { this.Model.RoomLayout = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_TEACH_HRS" field.
        /// </summary>
        public System.Nullable<System.Decimal> TeachHrs
        {
            get { return this.Model.TeachHrs; }
            set { this.Model.TeachHrs = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_STUD_WKS" field.
        /// </summary>
        public System.Nullable<System.Decimal> StudWks
        {
            get { return this.Model.StudWks; }
            set { this.Model.StudWks = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_BOM_ID" field.
        /// </summary>
        public Consensus.Learning.BillOfMaterial BiillOfMaterial
        {
            get
            {
                if (_biillOfMaterial == null && this.Model.BiillOfMaterial != null)
                    _biillOfMaterial = new Consensus.Learning.BillOfMaterial(this.Model.BiillOfMaterial);
                if (_biillOfMaterial == null)
                    _biillOfMaterial = Consensus.Learning.BillOfMaterial.Create();
                return _biillOfMaterial;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_BOM_ID" field.
        /// </summary>
        public System.String BiillOfMaterialId
        {
            get { return this.Model.BiillOfMaterialId; }
            set { this.Model.BiillOfMaterialId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_CG_CODE" field.
        /// </summary>
        public System.String UnitNumber
        {
            get { return this.Model.UnitNumber; }
            set { this.Model.UnitNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_SHOW_ATT_LOG" field.
        /// </summary>
        public System.Nullable<System.Byte> ShowAttLog
        {
            get { return this.Model.ShowAttLog; }
            set { this.Model.ShowAttLog = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionXrefModel" /> instances that reference this <see cref="!:SessionModel" />.
        /// </summary>
        public Collection<Consensus.Learning.SessionXref> SessionXrefActivity
        {
            get
            {
                if (_sessionXrefActivity == null)
                    _sessionXrefActivity = new ProxyCollection<Consensus.Learning.SessionXref, Consensus.Learning.ISessionXrefModel>(this.Model.SessionXrefActivity, model => new Consensus.Learning.SessionXref(model));
                return _sessionXrefActivity;
            }
        }

        /// <summary>
        ///     Gets the instance of the LocalActivityXrefModel which represents the activity salesperson.
        /// </summary>
        public Consensus.Activities.ActivityXref EndUser
        {
            get
            {
                if (_endUser == null && this.Model.EndUser != null)
                    _endUser = new Consensus.Activities.ActivityXref(this.Model.EndUser);
                if (_endUser == null)
                    _endUser = Consensus.Activities.ActivityXref.Create();
                return _endUser;
            }
        }

        /// <summary>
        ///     Gets the instance of the LocalActivityXrefModel which represents the activity salesperson.
        /// </summary>
        public Consensus.Activities.ActivityXref SalesPerson
        {
            get
            {
                if (_salesPerson == null && this.Model.SalesPerson != null)
                    _salesPerson = new Consensus.Activities.ActivityXref(this.Model.SalesPerson);
                if (_salesPerson == null)
                    _salesPerson = Consensus.Activities.ActivityXref.Create();
                return _salesPerson;
            }
        }

        public System.String EndUserId
        {
            get { return this.Model.EndUserId; }
            set { this.Model.EndUserId = value; }
        }

        public System.String EndUserPersonId
        {
            get { return this.Model.EndUserPersonId; }
            set { this.Model.EndUserPersonId = value; }
        }

        public System.String EndUserOrganisationId
        {
            get { return this.Model.EndUserOrganisationId; }
            set { this.Model.EndUserOrganisationId = value; }
        }

        public System.String SalesPersonId
        {
            get { return this.Model.SalesPersonId; }
            set { this.Model.SalesPersonId = value; }
        }

        /// <summary>
        ///     List of attachments for an activity. Created here to aid saving from the activity dialog.
        /// </summary>
        public Collection<Consensus.Common.Attachment> Attachments
        {
            get
            {
                if (_attachments == null)
                    _attachments = new ProxyCollection<Consensus.Common.Attachment, Consensus.Common.IAttachmentModel>(this.Model.Attachments, model => new Consensus.Common.Attachment(model));
                return _attachments;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_TYPE" field.
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
        ///     Gets or sets the unique code for the value of the "ACT_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ACTION_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ActionDate
        {
            get { return this.Model.ActionDate; }
            set { this.Model.ActionDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> Time
        {
            get { return this.Model.Time; }
            set { this.Model.Time = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_END_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndTime
        {
            get { return this.Model.EndTime; }
            set { this.Model.EndTime = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_RESULT" field.
        /// </summary>
        public Consensus.Common.Code Result
        {
            get
            {
                if (_result == null && this.Model.Result != null)
                    _result = new Consensus.Common.Code(this.Model.Result);
                if (_result == null)
                    _result = Consensus.Common.Code.Create();
                return _result;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_RESULT" field.
        /// </summary>
        public System.String ResultCode
        {
            get { return this.Model.ResultCode; }
            set { this.Model.ResultCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_NOTE" field.
        /// </summary>
        public System.String Note
        {
            get { return this.Model.Note; }
            set { this.Model.Note = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_OPP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACT_OPP_ID" field.
        /// </summary>
        public System.String OpportunityId
        {
            get { return this.Model.OpportunityId; }
            set { this.Model.OpportunityId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_SESSION_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_NOTE_HTML" field.
        /// </summary>
        public System.String NoteHtml
        {
            get { return this.Model.NoteHtml; }
            set { this.Model.NoteHtml = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ACT_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Element> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel>(this.Model.Elements, model => new Consensus.Learning.Element(model));
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        public Collection<Consensus.Sales.Opportunity> Opportunities
        {
            get
            {
                if (_opportunities == null)
                    _opportunities = new ProxyCollection<Consensus.Sales.Opportunity, Consensus.Sales.IOpportunityModel>(this.Model.Opportunities, model => new Consensus.Sales.Opportunity(model));
                return _opportunities;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        public Collection<Consensus.Activities.ActivityXref> ActivityXRefs
        {
            get
            {
                if (_activityXRefs == null)
                    _activityXRefs = new ProxyCollection<Consensus.Activities.ActivityXref, Consensus.Activities.IActivityXrefModel>(this.Model.ActivityXRefs, model => new Consensus.Activities.ActivityXref(model));
                return _activityXRefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActLinkXrefModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        public Collection<Consensus.Activities.ActLinkXref> ActivityLinkXrefs
        {
            get
            {
                if (_activityLinkXrefs == null)
                    _activityLinkXrefs = new ProxyCollection<Consensus.Activities.ActLinkXref, Consensus.Activities.IActLinkXrefModel>(this.Model.ActivityLinkXrefs, model => new Consensus.Activities.ActLinkXref(model));
                return _activityLinkXrefs;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Session(ISessionModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public static Consensus.Learning.Session CreateFromEvent(System.String eventId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.CreateFromEvent(site,eventId);
        }

        public static Consensus.Learning.Session CreateFromEvent(ConsensusSite site, System.String eventId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ISessionModel model = provider.Learning.Session.CreateFromEvent(eventId);
            return model == null ? null : new Consensus.Learning.Session(model);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SessionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SessionModel" /> instance.
        /// </returns>
        public static Consensus.Learning.Session Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SessionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SessionModel" /> instance.
        /// </returns>
        public static Consensus.Learning.Session Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ISessionModel model = provider.Learning.Session.Create();
            return model == null ? null : new Consensus.Learning.Session(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SessionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SessionModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SessionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SessionModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionModel> collection = provider.Learning.Session.FetchAll();
            return collection.Select(model => new Consensus.Learning.Session(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SessionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SessionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.Session FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SessionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SessionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.Session FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ISessionModel model = provider.Learning.Session.FetchById(id);
            return model == null ? null : new Consensus.Learning.Session(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.Session.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllByLocationId(System.String locationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.FetchAllByLocationId(site,locationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllByLocationId(ConsensusSite site, System.String locationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionModel> collection = provider.Learning.Session.FetchAllByLocationId(locationId);
            return collection.Select(model => new Consensus.Learning.Session(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllByOpportunityId(System.String opportunityId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.FetchAllByOpportunityId(site,opportunityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllByOpportunityId(ConsensusSite site, System.String opportunityId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionModel> collection = provider.Learning.Session.FetchAllByOpportunityId(opportunityId);
            return collection.Select(model => new Consensus.Learning.Session(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionModel> collection = provider.Learning.Session.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Learning.Session(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionModel> collection = provider.Learning.Session.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Learning.Session(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionModel> collection = provider.Learning.Session.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Learning.Session(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="biillOfMaterialId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="biillOfMaterialId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllByBiillOfMaterialId(System.String biillOfMaterialId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Session.FetchAllByBiillOfMaterialId(site,biillOfMaterialId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="biillOfMaterialId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="biillOfMaterialId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Session> FetchAllByBiillOfMaterialId(ConsensusSite site, System.String biillOfMaterialId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionModel> collection = provider.Learning.Session.FetchAllByBiillOfMaterialId(biillOfMaterialId);
            return collection.Select(model => new Consensus.Learning.Session(model));
        }

        #endregion
    }
}
