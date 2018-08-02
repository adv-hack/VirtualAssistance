using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;

namespace Consensus.Marketing
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PromotionMaster : Proxy<IPromotionMasterModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Region" /> member.
        /// </summary>
        private Consensus.Common.Code _region;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CmpId" /> member.
        /// </summary>
        private Consensus.Marketing.Campaign _cmpId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CourseId" /> member.
        /// </summary>
        private Consensus.Learning.Event _courseId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Manager" /> member.
        /// </summary>
        private Consensus.Contact.Role _manager;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Approver" /> member.
        /// </summary>
        private Consensus.Contact.Role _approver;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PromotionPromotionMaster" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.Promotion, Consensus.Marketing.IPromotionModel> _promotionPromotionMaster;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_REGION" field.
        /// </summary>
        public Consensus.Common.Code Region
        {
            get
            {
                if (_region == null && this.Model.Region != null)
                    _region = new Consensus.Common.Code(this.Model.Region);
                if (_region == null)
                    _region = Consensus.Common.Code.Create();
                return _region;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_REGION" field.
        /// </summary>
        public System.String RegionCode
        {
            get { return this.Model.RegionCode; }
            set { this.Model.RegionCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BUDGET_COST" field.
        /// </summary>
        public System.Nullable<System.Double> BudgetCost
        {
            get { return this.Model.BudgetCost; }
            set { this.Model.BudgetCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ACTUAL_COST" field.
        /// </summary>
        public System.Nullable<System.Double> ActualCost
        {
            get { return this.Model.ActualCost; }
            set { this.Model.ActualCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_REPLIES" field.
        /// </summary>
        public System.Nullable<System.Double> ActualReplies
        {
            get { return this.Model.ActualReplies; }
            set { this.Model.ActualReplies = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ORDERS" field.
        /// </summary>
        public System.Nullable<System.Double> SoldOpp
        {
            get { return this.Model.SoldOpp; }
            set { this.Model.SoldOpp = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ORDER_VALUE" field.
        /// </summary>
        public System.Nullable<System.Double> OppVal
        {
            get { return this.Model.OppVal; }
            set { this.Model.OppVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_UPDATED" field.
        /// </summary>
        public System.Nullable<System.DateTime> Updated
        {
            get { return this.Model.Updated; }
            set { this.Model.Updated = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_CMP_ID" field.
        /// </summary>
        public Consensus.Marketing.Campaign CmpId
        {
            get
            {
                if (_cmpId == null && this.Model.CmpId != null)
                    _cmpId = new Consensus.Marketing.Campaign(this.Model.CmpId);
                if (_cmpId == null)
                    _cmpId = Consensus.Marketing.Campaign.Create();
                return _cmpId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_CMP_ID" field.
        /// </summary>
        public System.String CmpIdId
        {
            get { return this.Model.CmpIdId; }
            set { this.Model.CmpIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_MAILINGS" field.
        /// </summary>
        public System.Nullable<System.Int32> Mailings
        {
            get { return this.Model.Mailings; }
            set { this.Model.Mailings = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOOKINGS" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualBook
        {
            get { return this.Model.ActualBook; }
            set { this.Model.ActualBook = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_OPP_TOT" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualOpp
        {
            get { return this.Model.ActualOpp; }
            set { this.Model.ActualOpp = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QUOTES" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualQuotes
        {
            get { return this.Model.ActualQuotes; }
            set { this.Model.ActualQuotes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QUO_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> ActualQuotesVal
        {
            get { return this.Model.ActualQuotesVal; }
            set { this.Model.ActualQuotesVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_CALC_ACT" field.
        /// </summary>
        public System.Nullable<System.Double> CalculatedActualCost
        {
            get { return this.Model.CalculatedActualCost; }
            set { this.Model.CalculatedActualCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_CALC_EST" field.
        /// </summary>
        public System.Nullable<System.Double> CalculatedBudgetCost
        {
            get { return this.Model.CalculatedBudgetCost; }
            set { this.Model.CalculatedBudgetCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOOK_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> ActualBookVal
        {
            get { return this.Model.ActualBookVal; }
            set { this.Model.ActualBookVal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_COURSE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PM_MST_COURSE_ID" field.
        /// </summary>
        public System.String CourseIdId
        {
            get { return this.Model.CourseIdId; }
            set { this.Model.CourseIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_OPP" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetOpp
        {
            get { return this.Model.TargetOpp; }
            set { this.Model.TargetOpp = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_REPLIES" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetReplies
        {
            get { return this.Model.TargetReplies; }
            set { this.Model.TargetReplies = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_OPP_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> TargetOppVal
        {
            get { return this.Model.TargetOppVal; }
            set { this.Model.TargetOppVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_BOOK_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> TargetBookVal
        {
            get { return this.Model.TargetBookVal; }
            set { this.Model.TargetBookVal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role Manager
        {
            get
            {
                if (_manager == null && this.Model.Manager != null)
                    _manager = new Consensus.Contact.Role(this.Model.Manager);
                if (_manager == null)
                    _manager = Consensus.Contact.Role.Create();
                return _manager;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_PROLE_ID" field.
        /// </summary>
        public System.String ManagerId
        {
            get { return this.Model.ManagerId; }
            set { this.Model.ManagerId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_APP_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role Approver
        {
            get
            {
                if (_approver == null && this.Model.Approver != null)
                    _approver = new Consensus.Contact.Role(this.Model.Approver);
                if (_approver == null)
                    _approver = Consensus.Contact.Role.Create();
                return _approver;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_APP_PROLE_ID" field.
        /// </summary>
        public System.String ApproverId
        {
            get { return this.Model.ApproverId; }
            set { this.Model.ApproverId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_SENT" field.
        /// </summary>
        public System.Int32 EmailsSentActual
        {
            get { return this.Model.EmailsSentActual; }
            set { this.Model.EmailsSentActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_OPENED" field.
        /// </summary>
        public System.Int32 EmailsOpenedActual
        {
            get { return this.Model.EmailsOpenedActual; }
            set { this.Model.EmailsOpenedActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LINKS_CLICKED" field.
        /// </summary>
        public System.Int32 LinksClickedActual
        {
            get { return this.Model.LinksClickedActual; }
            set { this.Model.LinksClickedActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LZ_CLICKED" field.
        /// </summary>
        public System.Int32 LzClickedActual
        {
            get { return this.Model.LzClickedActual; }
            set { this.Model.LzClickedActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_SURVEYS_COMPLETED" field.
        /// </summary>
        public System.Int32 SurveysCompletedActual
        {
            get { return this.Model.SurveysCompletedActual; }
            set { this.Model.SurveysCompletedActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        public System.Int32 GlobalUnsubscribesActual
        {
            get { return this.Model.GlobalUnsubscribesActual; }
            set { this.Model.GlobalUnsubscribesActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LIST_UNSUBSCRIBES" field.
        /// </summary>
        public System.Int32 ListUnsubscribesActual
        {
            get { return this.Model.ListUnsubscribesActual; }
            set { this.Model.ListUnsubscribesActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_DOCS_DOWNLOADS" field.
        /// </summary>
        public System.Int32 DocsDownloadsActual
        {
            get { return this.Model.DocsDownloadsActual; }
            set { this.Model.DocsDownloadsActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOUNCE_BACKS" field.
        /// </summary>
        public System.Int32 BounceBacksActual
        {
            get { return this.Model.BounceBacksActual; }
            set { this.Model.BounceBacksActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_SENT_TARGET" field.
        /// </summary>
        public System.Int32 EmailsSentTarget
        {
            get { return this.Model.EmailsSentTarget; }
            set { this.Model.EmailsSentTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_OPENED_TARGET" field.
        /// </summary>
        public System.Int32 EmailsOpenedTarget
        {
            get { return this.Model.EmailsOpenedTarget; }
            set { this.Model.EmailsOpenedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LINKS_CLICKED_TARGET" field.
        /// </summary>
        public System.Int32 LinksClickedTarget
        {
            get { return this.Model.LinksClickedTarget; }
            set { this.Model.LinksClickedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LZ_CLICKED_TARGET" field.
        /// </summary>
        public System.Int32 LzClickedTarget
        {
            get { return this.Model.LzClickedTarget; }
            set { this.Model.LzClickedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        public System.Int32 SurveysCompletedTarget
        {
            get { return this.Model.SurveysCompletedTarget; }
            set { this.Model.SurveysCompletedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public System.Int32 GlobalUnsubscribesTarget
        {
            get { return this.Model.GlobalUnsubscribesTarget; }
            set { this.Model.GlobalUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public System.Int32 ListUnsubscribesTarget
        {
            get { return this.Model.ListUnsubscribesTarget; }
            set { this.Model.ListUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        public System.Int32 DocsDownloadsTarget
        {
            get { return this.Model.DocsDownloadsTarget; }
            set { this.Model.DocsDownloadsTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        public System.Int32 BounceBacksTarget
        {
            get { return this.Model.BounceBacksTarget; }
            set { this.Model.BounceBacksTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QCODE" field.
        /// </summary>
        public System.String Qcode
        {
            get { return this.Model.Qcode; }
            set { this.Model.Qcode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionModel" /> instances that reference this <see cref="!:PromotionMasterModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.Promotion> PromotionPromotionMaster
        {
            get
            {
                if (_promotionPromotionMaster == null)
                    _promotionPromotionMaster = new ProxyCollection<Consensus.Marketing.Promotion, Consensus.Marketing.IPromotionModel>(this.Model.PromotionPromotionMaster, model => new Consensus.Marketing.Promotion(model));
                return _promotionPromotionMaster;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PromotionMaster(IPromotionMasterModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PromotionMasterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PromotionMasterModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.PromotionMaster Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PromotionMaster.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PromotionMasterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PromotionMasterModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.PromotionMaster Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.IPromotionMasterModel model = provider.Marketing.PromotionMaster.Create();
            return model == null ? null : new Consensus.Marketing.PromotionMaster(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PromotionMasterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.PromotionMaster> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PromotionMaster.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PromotionMasterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.PromotionMaster> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IPromotionMasterModel> collection = provider.Marketing.PromotionMaster.FetchAll();
            return collection.Select(model => new Consensus.Marketing.PromotionMaster(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PromotionMasterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PromotionMasterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.PromotionMaster FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PromotionMaster.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PromotionMasterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PromotionMasterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.PromotionMaster FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.IPromotionMasterModel model = provider.Marketing.PromotionMaster.FetchById(id);
            return model == null ? null : new Consensus.Marketing.PromotionMaster(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PromotionMaster.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.PromotionMaster.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="cmpIdId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="cmpIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.PromotionMaster> FetchAllByCmpIdId(System.String cmpIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PromotionMaster.FetchAllByCmpIdId(site,cmpIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="cmpIdId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="cmpIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.PromotionMaster> FetchAllByCmpIdId(ConsensusSite site, System.String cmpIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IPromotionMasterModel> collection = provider.Marketing.PromotionMaster.FetchAllByCmpIdId(cmpIdId);
            return collection.Select(model => new Consensus.Marketing.PromotionMaster(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.PromotionMaster> FetchAllByCourseIdId(System.String courseIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PromotionMaster.FetchAllByCourseIdId(site,courseIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.PromotionMaster> FetchAllByCourseIdId(ConsensusSite site, System.String courseIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IPromotionMasterModel> collection = provider.Marketing.PromotionMaster.FetchAllByCourseIdId(courseIdId);
            return collection.Select(model => new Consensus.Marketing.PromotionMaster(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.PromotionMaster> FetchAllByManagerId(System.String managerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PromotionMaster.FetchAllByManagerId(site,managerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.PromotionMaster> FetchAllByManagerId(ConsensusSite site, System.String managerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IPromotionMasterModel> collection = provider.Marketing.PromotionMaster.FetchAllByManagerId(managerId);
            return collection.Select(model => new Consensus.Marketing.PromotionMaster(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.PromotionMaster> FetchAllByApproverId(System.String approverId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PromotionMaster.FetchAllByApproverId(site,approverId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionMasterModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionMasterModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.PromotionMaster> FetchAllByApproverId(ConsensusSite site, System.String approverId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IPromotionMasterModel> collection = provider.Marketing.PromotionMaster.FetchAllByApproverId(approverId);
            return collection.Select(model => new Consensus.Marketing.PromotionMaster(model));
        }

        #endregion
    }
}
