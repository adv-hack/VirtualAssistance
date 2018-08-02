using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Marketing;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="ComplaintRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalComplaintModel : LocalModel<ComplaintRecord, String>, IComplaintModel
    {
        #region fields

        /// <summary>
        ///     The value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _fromProleId;

        /// <summary>
        ///     The value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _reProleId;

        /// <summary>
        ///     The value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _mgrProleId;

        /// <summary>
        ///     The value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _medtrProleId;

        /// <summary>
        ///     The value of the "CMPL_STATUS_1" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "CMPL_STATUS_2" field.
        /// </summary>
        private LocalCodeModel _resolution;

        /// <summary>
        ///     The value of the "CMPL_TYPE_1" field.
        /// </summary>
        private LocalCodeModel _category;

        /// <summary>
        ///     The value of the "CMPL_SCHEME" field.
        /// </summary>
        private LocalCodeModel _scheme;

        /// <summary>
        ///     The value of the "CMPL_PM_ID" field.
        /// </summary>
        private LocalPromotionModel _promotionID;

        /// <summary>
        ///     The value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        private LocalC4textModel _detailsId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ComplaintRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Activities.Complaint.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ComplaintRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Activities.Complaint.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ComplaintRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Activities.Complaint.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return this.ModifiedData.Title; }
            set { this.ModifiedData.Title = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel FromProleId
        {
            get
            {
                if (_fromProleId == null && this.FromProleIdId != null)
                    _fromProleId = this.Provider.Contact.Role.FetchById(this.FromProleIdId);
                if (_fromProleId == null)
                    _fromProleId = this.Provider.Contact.Role.Create();
                
                return _fromProleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        public String FromProleIdId
        {
            get { return this.ModifiedData.FromProleId; }
            set
            {
                if (this.ModifiedData.FromProleId != value)
                     _fromProleId = null;
                this.ModifiedData.FromProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel ReProleId
        {
            get
            {
                if (_reProleId == null && this.ReProleIdId != null)
                    _reProleId = this.Provider.Contact.Role.FetchById(this.ReProleIdId);
                if (_reProleId == null)
                    _reProleId = this.Provider.Contact.Role.Create();
                
                return _reProleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        public String ReProleIdId
        {
            get { return this.ModifiedData.ReProleId; }
            set
            {
                if (this.ModifiedData.ReProleId != value)
                     _reProleId = null;
                this.ModifiedData.ReProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel MgrProleId
        {
            get
            {
                if (_mgrProleId == null && this.MgrProleIdId != null)
                    _mgrProleId = this.Provider.Contact.Role.FetchById(this.MgrProleIdId);
                if (_mgrProleId == null)
                    _mgrProleId = this.Provider.Contact.Role.Create();
                
                return _mgrProleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        public String MgrProleIdId
        {
            get { return this.ModifiedData.MgrProleId; }
            set
            {
                if (this.ModifiedData.MgrProleId != value)
                     _mgrProleId = null;
                this.ModifiedData.MgrProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel MedtrProleId
        {
            get
            {
                if (_medtrProleId == null && this.MedtrProleIdId != null)
                    _medtrProleId = this.Provider.Contact.Role.FetchById(this.MedtrProleIdId);
                if (_medtrProleId == null)
                    _medtrProleId = this.Provider.Contact.Role.Create();
                
                return _medtrProleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        public String MedtrProleIdId
        {
            get { return this.ModifiedData.MedtrProleId; }
            set
            {
                if (this.ModifiedData.MedtrProleId != value)
                     _medtrProleId = null;
                this.ModifiedData.MedtrProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_STATUS_1" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("CMPS1", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("CMPS1");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_STATUS_1" field.
        /// </summary>
        public String StatusCode
        {
            get { return this.ModifiedData.Status1; }
            set
            {
                if (this.ModifiedData.Status1 != value)
                     _status = null;
                this.ModifiedData.Status1 = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_STATUS_2" field.
        /// </summary>
        public LocalCodeModel Resolution
        {
            get
            {
                if (_resolution == null && !String.IsNullOrEmpty(this.ResolutionCode))
                    _resolution = this.Provider.Common.Code.FetchByTypeAndCode("CMPS2", this.ResolutionCode);
                if (_resolution == null)
                    _resolution = this.Provider.Common.Code.Create("CMPS2");
                return _resolution;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_STATUS_2" field.
        /// </summary>
        public String ResolutionCode
        {
            get { return this.ModifiedData.Status2; }
            set
            {
                if (this.ModifiedData.Status2 != value)
                     _resolution = null;
                this.ModifiedData.Status2 = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_TYPE_1" field.
        /// </summary>
        public LocalCodeModel Category
        {
            get
            {
                if (_category == null && !String.IsNullOrEmpty(this.CategoryCode))
                    _category = this.Provider.Common.Code.FetchByTypeAndCode("CMPT1", this.CategoryCode);
                if (_category == null)
                    _category = this.Provider.Common.Code.Create("CMPT1");
                return _category;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_TYPE_1" field.
        /// </summary>
        public String CategoryCode
        {
            get { return this.ModifiedData.Type1; }
            set
            {
                if (this.ModifiedData.Type1 != value)
                     _category = null;
                this.ModifiedData.Type1 = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_SCHEME" field.
        /// </summary>
        public LocalCodeModel Scheme
        {
            get
            {
                if (_scheme == null && !String.IsNullOrEmpty(this.SchemeCode))
                    _scheme = this.Provider.Common.Code.FetchByTypeAndCode("CMPSC", this.SchemeCode);
                if (_scheme == null)
                    _scheme = this.Provider.Common.Code.Create("CMPSC");
                return _scheme;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_SCHEME" field.
        /// </summary>
        public String SchemeCode
        {
            get { return this.ModifiedData.Scheme; }
            set
            {
                if (this.ModifiedData.Scheme != value)
                     _scheme = null;
                this.ModifiedData.Scheme = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_OF_COMPL" field.
        /// </summary>
        public DateTime? DateOfCompl
        {
            get { return this.ModifiedData.DateOfCompl; }
            set { this.ModifiedData.DateOfCompl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_RCVD" field.
        /// </summary>
        public DateTime? DateRcvd
        {
            get { return this.ModifiedData.DateRcvd; }
            set { this.ModifiedData.DateRcvd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_END" field.
        /// </summary>
        public DateTime? DateEnd
        {
            get { return this.ModifiedData.DateEnd; }
            set { this.ModifiedData.DateEnd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_NEXT_ACT" field.
        /// </summary>
        public DateTime? DateNextAct
        {
            get { return this.ModifiedData.DateNextAct; }
            set { this.ModifiedData.DateNextAct = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_PM_ID" field.
        /// </summary>
        public LocalPromotionModel PromotionID
        {
            get
            {
                if (_promotionID == null && this.PromotionIDId != null)
                    _promotionID = this.Provider.Marketing.Promotion.FetchById(this.PromotionIDId);
                if (_promotionID == null)
                    _promotionID = this.Provider.Marketing.Promotion.Create();
                
                return _promotionID;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_PM_ID" field.
        /// </summary>
        public String PromotionIDId
        {
            get { return this.ModifiedData.PmId; }
            set
            {
                if (this.ModifiedData.PmId != value)
                     _promotionID = null;
                this.ModifiedData.PmId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        public LocalC4textModel DetailsId
        {
            get
            {
                if (_detailsId == null && this.DetailsIdId != null)
                    _detailsId = this.Provider.Activities.C4text.FetchById(this.DetailsIdId);
                if (_detailsId == null)
                    _detailsId = this.Provider.Activities.C4text.Create();
                
                return _detailsId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        public String DetailsIdId
        {
            get { return this.ModifiedData.DetailsId; }
            set
            {
                if (this.ModifiedData.DetailsId != value)
                     _detailsId = null;
                this.ModifiedData.DetailsId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalComplaintModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalComplaintModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalComplaintModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalComplaintModel(LocalProvider provider, ComplaintRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_status != null)
            {
                _status.Save();
                this.ModifiedData.Status1 = _status.Value1;
            }
            if (_resolution != null)
            {
                _resolution.Save();
                this.ModifiedData.Status2 = _resolution.Value1;
            }
            if (_category != null)
            {
                _category.Save();
                this.ModifiedData.Type1 = _category.Value1;
            }
            if (_scheme != null)
            {
                _scheme.Save();
                this.ModifiedData.Scheme = _scheme.Value1;
            }
            if (_fromProleId != null)
            {
                _fromProleId.Save();
                this.ModifiedData.FromProleId = _fromProleId.Id == null && this.ModifiedData.FromProleId != null ? "" : _fromProleId.Id;
            }
            if (_reProleId != null)
            {
                _reProleId.Save();
                this.ModifiedData.ReProleId = _reProleId.Id == null && this.ModifiedData.ReProleId != null ? "" : _reProleId.Id;
            }
            if (_mgrProleId != null)
            {
                _mgrProleId.Save();
                this.ModifiedData.MgrProleId = _mgrProleId.Id == null && this.ModifiedData.MgrProleId != null ? "" : _mgrProleId.Id;
            }
            if (_medtrProleId != null)
            {
                _medtrProleId.Save();
                this.ModifiedData.MedtrProleId = _medtrProleId.Id == null && this.ModifiedData.MedtrProleId != null ? "" : _medtrProleId.Id;
            }
            if (_promotionID != null)
            {
                _promotionID.Save();
                this.ModifiedData.PmId = _promotionID.Id == null && this.ModifiedData.PmId != null ? "" : _promotionID.Id;
            }
            if (_detailsId != null)
            {
                _detailsId.Save();
                this.ModifiedData.DetailsId = _detailsId.Id == null && this.ModifiedData.DetailsId != null ? "" : _detailsId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "CMPL_TITLE" field.
        /// </summary>
        System.String IComplaintModel.Title
        {
            get { return this.Title; }
            set { this.Title = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IComplaintModel.FromProleId
        {
            get { return this.FromProleId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        System.String IComplaintModel.FromProleIdId
        {
            get { return this.FromProleIdId; }
            set { this.FromProleIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IComplaintModel.ReProleId
        {
            get { return this.ReProleId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        System.String IComplaintModel.ReProleIdId
        {
            get { return this.ReProleIdId; }
            set { this.ReProleIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IComplaintModel.MgrProleId
        {
            get { return this.MgrProleId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        System.String IComplaintModel.MgrProleIdId
        {
            get { return this.MgrProleIdId; }
            set { this.MgrProleIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IComplaintModel.MedtrProleId
        {
            get { return this.MedtrProleId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        System.String IComplaintModel.MedtrProleIdId
        {
            get { return this.MedtrProleIdId; }
            set { this.MedtrProleIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_STATUS_1" field.
        /// </summary>
        Consensus.Common.ICodeModel IComplaintModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_STATUS_1" field.
        /// </summary>
        System.String IComplaintModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_STATUS_2" field.
        /// </summary>
        Consensus.Common.ICodeModel IComplaintModel.Resolution
        {
            get { return this.Resolution; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_STATUS_2" field.
        /// </summary>
        System.String IComplaintModel.ResolutionCode
        {
            get { return this.ResolutionCode; }
            set { this.ResolutionCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_TYPE_1" field.
        /// </summary>
        Consensus.Common.ICodeModel IComplaintModel.Category
        {
            get { return this.Category; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_TYPE_1" field.
        /// </summary>
        System.String IComplaintModel.CategoryCode
        {
            get { return this.CategoryCode; }
            set { this.CategoryCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_SCHEME" field.
        /// </summary>
        Consensus.Common.ICodeModel IComplaintModel.Scheme
        {
            get { return this.Scheme; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_SCHEME" field.
        /// </summary>
        System.String IComplaintModel.SchemeCode
        {
            get { return this.SchemeCode; }
            set { this.SchemeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_OF_COMPL" field.
        /// </summary>
        System.Nullable<System.DateTime> IComplaintModel.DateOfCompl
        {
            get { return this.DateOfCompl; }
            set { this.DateOfCompl = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_RCVD" field.
        /// </summary>
        System.Nullable<System.DateTime> IComplaintModel.DateRcvd
        {
            get { return this.DateRcvd; }
            set { this.DateRcvd = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_END" field.
        /// </summary>
        System.Nullable<System.DateTime> IComplaintModel.DateEnd
        {
            get { return this.DateEnd; }
            set { this.DateEnd = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_NEXT_ACT" field.
        /// </summary>
        System.Nullable<System.DateTime> IComplaintModel.DateNextAct
        {
            get { return this.DateNextAct; }
            set { this.DateNextAct = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_NOTES" field.
        /// </summary>
        System.String IComplaintModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_PM_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel IComplaintModel.PromotionID
        {
            get { return this.PromotionID; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_PM_ID" field.
        /// </summary>
        System.String IComplaintModel.PromotionIDId
        {
            get { return this.PromotionIDId; }
            set { this.PromotionIDId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel IComplaintModel.DetailsId
        {
            get { return this.DetailsId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        System.String IComplaintModel.DetailsIdId
        {
            get { return this.DetailsIdId; }
            set { this.DetailsIdId = (System.String)value; }
        }

        #endregion
    }
}
