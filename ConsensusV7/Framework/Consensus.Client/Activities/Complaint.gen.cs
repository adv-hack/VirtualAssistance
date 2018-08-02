using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Marketing;

namespace Consensus.Activities
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Complaint : Proxy<IComplaintModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="FromProleId" /> member.
        /// </summary>
        private Consensus.Contact.Role _fromProleId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ReProleId" /> member.
        /// </summary>
        private Consensus.Contact.Role _reProleId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MgrProleId" /> member.
        /// </summary>
        private Consensus.Contact.Role _mgrProleId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MedtrProleId" /> member.
        /// </summary>
        private Consensus.Contact.Role _medtrProleId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Resolution" /> member.
        /// </summary>
        private Consensus.Common.Code _resolution;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Category" /> member.
        /// </summary>
        private Consensus.Common.Code _category;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Scheme" /> member.
        /// </summary>
        private Consensus.Common.Code _scheme;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PromotionID" /> member.
        /// </summary>
        private Consensus.Marketing.Promotion _promotionID;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DetailsId" /> member.
        /// </summary>
        private Consensus.Activities.C4text _detailsId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "CMPL_TITLE" field.
        /// </summary>
        public System.String Title
        {
            get { return this.Model.Title; }
            set { this.Model.Title = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role FromProleId
        {
            get
            {
                if (_fromProleId == null && this.Model.FromProleId != null)
                    _fromProleId = new Consensus.Contact.Role(this.Model.FromProleId);
                if (_fromProleId == null)
                    _fromProleId = Consensus.Contact.Role.Create();
                return _fromProleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        public System.String FromProleIdId
        {
            get { return this.Model.FromProleIdId; }
            set { this.Model.FromProleIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role ReProleId
        {
            get
            {
                if (_reProleId == null && this.Model.ReProleId != null)
                    _reProleId = new Consensus.Contact.Role(this.Model.ReProleId);
                if (_reProleId == null)
                    _reProleId = Consensus.Contact.Role.Create();
                return _reProleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        public System.String ReProleIdId
        {
            get { return this.Model.ReProleIdId; }
            set { this.Model.ReProleIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role MgrProleId
        {
            get
            {
                if (_mgrProleId == null && this.Model.MgrProleId != null)
                    _mgrProleId = new Consensus.Contact.Role(this.Model.MgrProleId);
                if (_mgrProleId == null)
                    _mgrProleId = Consensus.Contact.Role.Create();
                return _mgrProleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        public System.String MgrProleIdId
        {
            get { return this.Model.MgrProleIdId; }
            set { this.Model.MgrProleIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role MedtrProleId
        {
            get
            {
                if (_medtrProleId == null && this.Model.MedtrProleId != null)
                    _medtrProleId = new Consensus.Contact.Role(this.Model.MedtrProleId);
                if (_medtrProleId == null)
                    _medtrProleId = Consensus.Contact.Role.Create();
                return _medtrProleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        public System.String MedtrProleIdId
        {
            get { return this.Model.MedtrProleIdId; }
            set { this.Model.MedtrProleIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_STATUS_1" field.
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
        ///     Gets or sets the unique code for the value of the "CMPL_STATUS_1" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_STATUS_2" field.
        /// </summary>
        public Consensus.Common.Code Resolution
        {
            get
            {
                if (_resolution == null && this.Model.Resolution != null)
                    _resolution = new Consensus.Common.Code(this.Model.Resolution);
                if (_resolution == null)
                    _resolution = Consensus.Common.Code.Create();
                return _resolution;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_STATUS_2" field.
        /// </summary>
        public System.String ResolutionCode
        {
            get { return this.Model.ResolutionCode; }
            set { this.Model.ResolutionCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_TYPE_1" field.
        /// </summary>
        public Consensus.Common.Code Category
        {
            get
            {
                if (_category == null && this.Model.Category != null)
                    _category = new Consensus.Common.Code(this.Model.Category);
                if (_category == null)
                    _category = Consensus.Common.Code.Create();
                return _category;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_TYPE_1" field.
        /// </summary>
        public System.String CategoryCode
        {
            get { return this.Model.CategoryCode; }
            set { this.Model.CategoryCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_SCHEME" field.
        /// </summary>
        public Consensus.Common.Code Scheme
        {
            get
            {
                if (_scheme == null && this.Model.Scheme != null)
                    _scheme = new Consensus.Common.Code(this.Model.Scheme);
                if (_scheme == null)
                    _scheme = Consensus.Common.Code.Create();
                return _scheme;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_SCHEME" field.
        /// </summary>
        public System.String SchemeCode
        {
            get { return this.Model.SchemeCode; }
            set { this.Model.SchemeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_OF_COMPL" field.
        /// </summary>
        public System.Nullable<System.DateTime> DateOfCompl
        {
            get { return this.Model.DateOfCompl; }
            set { this.Model.DateOfCompl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_RCVD" field.
        /// </summary>
        public System.Nullable<System.DateTime> DateRcvd
        {
            get { return this.Model.DateRcvd; }
            set { this.Model.DateRcvd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_END" field.
        /// </summary>
        public System.Nullable<System.DateTime> DateEnd
        {
            get { return this.Model.DateEnd; }
            set { this.Model.DateEnd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_NEXT_ACT" field.
        /// </summary>
        public System.Nullable<System.DateTime> DateNextAct
        {
            get { return this.Model.DateNextAct; }
            set { this.Model.DateNextAct = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_PM_ID" field.
        /// </summary>
        public Consensus.Marketing.Promotion PromotionID
        {
            get
            {
                if (_promotionID == null && this.Model.PromotionID != null)
                    _promotionID = new Consensus.Marketing.Promotion(this.Model.PromotionID);
                if (_promotionID == null)
                    _promotionID = Consensus.Marketing.Promotion.Create();
                return _promotionID;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_PM_ID" field.
        /// </summary>
        public System.String PromotionIDId
        {
            get { return this.Model.PromotionIDId; }
            set { this.Model.PromotionIDId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        public Consensus.Activities.C4text DetailsId
        {
            get
            {
                if (_detailsId == null && this.Model.DetailsId != null)
                    _detailsId = new Consensus.Activities.C4text(this.Model.DetailsId);
                if (_detailsId == null)
                    _detailsId = Consensus.Activities.C4text.Create();
                return _detailsId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        public System.String DetailsIdId
        {
            get { return this.Model.DetailsIdId; }
            set { this.Model.DetailsIdId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Complaint(IComplaintModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ComplaintModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ComplaintModel" /> instance.
        /// </returns>
        public static Consensus.Activities.Complaint Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Complaint.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ComplaintModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ComplaintModel" /> instance.
        /// </returns>
        public static Consensus.Activities.Complaint Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IComplaintModel model = provider.Activities.Complaint.Create();
            return model == null ? null : new Consensus.Activities.Complaint(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ComplaintModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ComplaintModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Complaint.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ComplaintModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ComplaintModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IComplaintModel> collection = provider.Activities.Complaint.FetchAll();
            return collection.Select(model => new Consensus.Activities.Complaint(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ComplaintModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ComplaintModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.Complaint FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Complaint.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ComplaintModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ComplaintModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.Complaint FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IComplaintModel model = provider.Activities.Complaint.FetchById(id);
            return model == null ? null : new Consensus.Activities.Complaint(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Complaint.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Activities.Complaint.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="fromProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="fromProleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByFromProleIdId(System.String fromProleIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Complaint.FetchAllByFromProleIdId(site,fromProleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="fromProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="fromProleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByFromProleIdId(ConsensusSite site, System.String fromProleIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IComplaintModel> collection = provider.Activities.Complaint.FetchAllByFromProleIdId(fromProleIdId);
            return collection.Select(model => new Consensus.Activities.Complaint(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="reProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="reProleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByReProleIdId(System.String reProleIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Complaint.FetchAllByReProleIdId(site,reProleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="reProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="reProleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByReProleIdId(ConsensusSite site, System.String reProleIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IComplaintModel> collection = provider.Activities.Complaint.FetchAllByReProleIdId(reProleIdId);
            return collection.Select(model => new Consensus.Activities.Complaint(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="mgrProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="mgrProleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByMgrProleIdId(System.String mgrProleIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Complaint.FetchAllByMgrProleIdId(site,mgrProleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="mgrProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="mgrProleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByMgrProleIdId(ConsensusSite site, System.String mgrProleIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IComplaintModel> collection = provider.Activities.Complaint.FetchAllByMgrProleIdId(mgrProleIdId);
            return collection.Select(model => new Consensus.Activities.Complaint(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="medtrProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="medtrProleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByMedtrProleIdId(System.String medtrProleIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Complaint.FetchAllByMedtrProleIdId(site,medtrProleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="medtrProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="medtrProleIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByMedtrProleIdId(ConsensusSite site, System.String medtrProleIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IComplaintModel> collection = provider.Activities.Complaint.FetchAllByMedtrProleIdId(medtrProleIdId);
            return collection.Select(model => new Consensus.Activities.Complaint(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="promotionIDId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="promotionIDId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByPromotionIDId(System.String promotionIDId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Complaint.FetchAllByPromotionIDId(site,promotionIDId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="promotionIDId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="promotionIDId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByPromotionIDId(ConsensusSite site, System.String promotionIDId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IComplaintModel> collection = provider.Activities.Complaint.FetchAllByPromotionIDId(promotionIDId);
            return collection.Select(model => new Consensus.Activities.Complaint(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="detailsIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="detailsIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByDetailsIdId(System.String detailsIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Complaint.FetchAllByDetailsIdId(site,detailsIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="detailsIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="detailsIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Activities.Complaint> FetchAllByDetailsIdId(ConsensusSite site, System.String detailsIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IComplaintModel> collection = provider.Activities.Complaint.FetchAllByDetailsIdId(detailsIdId);
            return collection.Select(model => new Consensus.Activities.Complaint(model));
        }

        #endregion
    }
}
