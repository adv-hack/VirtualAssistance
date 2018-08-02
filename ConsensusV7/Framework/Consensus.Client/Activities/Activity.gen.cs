using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;
using Consensus.Sales;

namespace Consensus.Activities
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Activity : Proxy<IActivityModel, String>
    {
        #region fields

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
        internal Activity(IActivityModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ActivityModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActivityModel" /> instance.
        /// </returns>
        public static Consensus.Activities.Activity Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Activity.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ActivityModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActivityModel" /> instance.
        /// </returns>
        public static Consensus.Activities.Activity Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IActivityModel model = provider.Activities.Activity.Create();
            return model == null ? null : new Consensus.Activities.Activity(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActivityModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActivityModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Activity> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Activity.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActivityModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActivityModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Activity> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActivityModel> collection = provider.Activities.Activity.FetchAll();
            return collection.Select(model => new Consensus.Activities.Activity(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActivityModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActivityModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.Activity FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Activity.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActivityModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActivityModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.Activity FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IActivityModel model = provider.Activities.Activity.FetchById(id);
            return model == null ? null : new Consensus.Activities.Activity(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Activity.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Activities.Activity.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Activity> FetchAllByOpportunityId(System.String opportunityId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Activity.FetchAllByOpportunityId(site,opportunityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Activity> FetchAllByOpportunityId(ConsensusSite site, System.String opportunityId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActivityModel> collection = provider.Activities.Activity.FetchAllByOpportunityId(opportunityId);
            return collection.Select(model => new Consensus.Activities.Activity(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Activity> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Activity.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Activity> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IActivityModel> collection = provider.Activities.Activity.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Activities.Activity(model));
        }

        #endregion
    }
}
