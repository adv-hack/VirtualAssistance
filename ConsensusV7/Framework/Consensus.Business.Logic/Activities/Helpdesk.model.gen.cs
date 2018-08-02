using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Marketing;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="HelpdeskRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalHelpdeskModel : LocalModel<HelpdeskRecord, String>, IHelpdeskModel
    {
        #region fields

        /// <summary>
        ///     The value of the "HD_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _orgId;

        /// <summary>
        ///     The value of the "HD_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _proleId;

        /// <summary>
        ///     The value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        private LocalRoleModel _givenToId;

        /// <summary>
        ///     The value of the "HD_DETAILS_ID" field.
        /// </summary>
        private LocalC4textModel _detailsId;

        /// <summary>
        ///     The value of the "HD_FIX_ID" field.
        /// </summary>
        private LocalC4textModel _fixId;

        /// <summary>
        ///     The value of the "HD_WIP_ID" field.
        /// </summary>
        private LocalC4textModel _wipId;

        /// <summary>
        ///     The value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _selcoSpId;

        /// <summary>
        ///     The value of the "HD_PM_ID" field.
        /// </summary>
        private LocalPromotionModel _pmId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<HelpdeskRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Activities.Helpdesk.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<HelpdeskRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Activities.Helpdesk.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<HelpdeskRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Activities.Helpdesk.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel OrgId
        {
            get
            {
                if (_orgId == null && this.OrgIdId != null)
                    _orgId = this.Provider.Contact.Organisation.FetchById(this.OrgIdId);
                if (_orgId == null)
                    _orgId = this.Provider.Contact.Organisation.Create();
                
                return _orgId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_ORG_ID" field.
        /// </summary>
        public String OrgIdId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _orgId = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_ORG_NAME" field.
        /// </summary>
        public String OrgName
        {
            get { return this.ModifiedData.OrgName; }
            set { this.ModifiedData.OrgName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel ProleId
        {
            get
            {
                if (_proleId == null && this.ProleIdId != null)
                    _proleId = this.Provider.Contact.Role.FetchById(this.ProleIdId);
                if (_proleId == null)
                    _proleId = this.Provider.Contact.Role.Create();
                
                return _proleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_PROLE_ID" field.
        /// </summary>
        public String ProleIdId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _proleId = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_PN_NAME" field.
        /// </summary>
        public String PnName
        {
            get { return this.ModifiedData.PnName; }
            set { this.ModifiedData.PnName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_GIVEN_TO" field.
        /// </summary>
        public String GivenTo
        {
            get { return this.ModifiedData.GivenTo; }
            set { this.ModifiedData.GivenTo = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        public LocalRoleModel GivenToId
        {
            get
            {
                if (_givenToId == null && this.GivenToIdId != null)
                    _givenToId = this.Provider.Contact.Role.FetchById(this.GivenToIdId);
                if (_givenToId == null)
                    _givenToId = this.Provider.Contact.Role.Create();
                
                return _givenToId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        public String GivenToIdId
        {
            get { return this.ModifiedData.GivenToId; }
            set
            {
                if (this.ModifiedData.GivenToId != value)
                     _givenToId = null;
                this.ModifiedData.GivenToId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_DETAILS_ID" field.
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
        ///     Gets or sets the unique code for the value of the "HD_DETAILS_ID" field.
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

        /// <summary>
        ///     Gets the The value of the "HD_FIX_ID" field.
        /// </summary>
        public LocalC4textModel FixId
        {
            get
            {
                if (_fixId == null && this.FixIdId != null)
                    _fixId = this.Provider.Activities.C4text.FetchById(this.FixIdId);
                if (_fixId == null)
                    _fixId = this.Provider.Activities.C4text.Create();
                
                return _fixId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_FIX_ID" field.
        /// </summary>
        public String FixIdId
        {
            get { return this.ModifiedData.FixId; }
            set
            {
                if (this.ModifiedData.FixId != value)
                     _fixId = null;
                this.ModifiedData.FixId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_CATEGORY" field.
        /// </summary>
        public String Category
        {
            get { return this.ModifiedData.Category; }
            set { this.ModifiedData.Category = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_FIX_CAT" field.
        /// </summary>
        public String FixCat
        {
            get { return this.ModifiedData.FixCat; }
            set { this.ModifiedData.FixCat = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_CALL_DATE" field.
        /// </summary>
        public DateTime? CallDate
        {
            get { return this.ModifiedData.CallDate; }
            set { this.ModifiedData.CallDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_SEVERITY" field.
        /// </summary>
        public String Severity
        {
            get { return this.ModifiedData.Severity; }
            set { this.ModifiedData.Severity = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return this.ModifiedData.Title; }
            set { this.ModifiedData.Title = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_WIP_ID" field.
        /// </summary>
        public LocalC4textModel WipId
        {
            get
            {
                if (_wipId == null && this.WipIdId != null)
                    _wipId = this.Provider.Activities.C4text.FetchById(this.WipIdId);
                if (_wipId == null)
                    _wipId = this.Provider.Activities.C4text.Create();
                
                return _wipId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_WIP_ID" field.
        /// </summary>
        public String WipIdId
        {
            get { return this.ModifiedData.WipId; }
            set
            {
                if (this.ModifiedData.WipId != value)
                     _wipId = null;
                this.ModifiedData.WipId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_RES_DATE" field.
        /// </summary>
        public DateTime? ResDate
        {
            get { return this.ModifiedData.ResDate; }
            set { this.ModifiedData.ResDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SelcoSpId
        {
            get
            {
                if (_selcoSpId == null && this.SelcoSpIdId != null)
                    _selcoSpId = this.Provider.Common.SellingCompany.FetchById(this.SelcoSpIdId);
                if (_selcoSpId == null)
                    _selcoSpId = this.Provider.Common.SellingCompany.Create();
                
                return _selcoSpId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpIdId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _selcoSpId = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "HD_PM_ID" field.
        /// </summary>
        public LocalPromotionModel PmId
        {
            get
            {
                if (_pmId == null && this.PmIdId != null)
                    _pmId = this.Provider.Marketing.Promotion.FetchById(this.PmIdId);
                if (_pmId == null)
                    _pmId = this.Provider.Marketing.Promotion.Create();
                
                return _pmId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_PM_ID" field.
        /// </summary>
        public String PmIdId
        {
            get { return this.ModifiedData.PmId; }
            set
            {
                if (this.ModifiedData.PmId != value)
                     _pmId = null;
                this.ModifiedData.PmId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalHelpdeskModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalHelpdeskModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalHelpdeskModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalHelpdeskModel(LocalProvider provider, HelpdeskRecord record) : base(provider, record)
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
            if (_orgId != null)
            {
                _orgId.Save();
                this.ModifiedData.OrgId = _orgId.Id == null && this.ModifiedData.OrgId != null ? "" : _orgId.Id;
            }
            if (_proleId != null)
            {
                _proleId.Save();
                this.ModifiedData.ProleId = _proleId.Id == null && this.ModifiedData.ProleId != null ? "" : _proleId.Id;
            }
            if (_givenToId != null)
            {
                _givenToId.Save();
                this.ModifiedData.GivenToId = _givenToId.Id == null && this.ModifiedData.GivenToId != null ? "" : _givenToId.Id;
            }
            if (_detailsId != null)
            {
                _detailsId.Save();
                this.ModifiedData.DetailsId = _detailsId.Id == null && this.ModifiedData.DetailsId != null ? "" : _detailsId.Id;
            }
            if (_fixId != null)
            {
                _fixId.Save();
                this.ModifiedData.FixId = _fixId.Id == null && this.ModifiedData.FixId != null ? "" : _fixId.Id;
            }
            if (_wipId != null)
            {
                _wipId.Save();
                this.ModifiedData.WipId = _wipId.Id == null && this.ModifiedData.WipId != null ? "" : _wipId.Id;
            }
            if (_selcoSpId != null)
            {
                _selcoSpId.Save();
                this.ModifiedData.SelcoSpId = _selcoSpId.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _selcoSpId.Id;
            }
            if (_pmId != null)
            {
                _pmId.Save();
                this.ModifiedData.PmId = _pmId.Id == null && this.ModifiedData.PmId != null ? "" : _pmId.Id;
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
        ///     Gets the The value of the "HD_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IHelpdeskModel.OrgId
        {
            get { return this.OrgId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_ORG_ID" field.
        /// </summary>
        System.String IHelpdeskModel.OrgIdId
        {
            get { return this.OrgIdId; }
            set { this.OrgIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_ORG_NAME" field.
        /// </summary>
        System.String IHelpdeskModel.OrgName
        {
            get { return this.OrgName; }
            set { this.OrgName = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IHelpdeskModel.ProleId
        {
            get { return this.ProleId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_PROLE_ID" field.
        /// </summary>
        System.String IHelpdeskModel.ProleIdId
        {
            get { return this.ProleIdId; }
            set { this.ProleIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_PN_NAME" field.
        /// </summary>
        System.String IHelpdeskModel.PnName
        {
            get { return this.PnName; }
            set { this.PnName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_GIVEN_TO" field.
        /// </summary>
        System.String IHelpdeskModel.GivenTo
        {
            get { return this.GivenTo; }
            set { this.GivenTo = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IHelpdeskModel.GivenToId
        {
            get { return this.GivenToId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        System.String IHelpdeskModel.GivenToIdId
        {
            get { return this.GivenToIdId; }
            set { this.GivenToIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_STATUS" field.
        /// </summary>
        System.String IHelpdeskModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_DETAILS_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel IHelpdeskModel.DetailsId
        {
            get { return this.DetailsId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_DETAILS_ID" field.
        /// </summary>
        System.String IHelpdeskModel.DetailsIdId
        {
            get { return this.DetailsIdId; }
            set { this.DetailsIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_FIX_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel IHelpdeskModel.FixId
        {
            get { return this.FixId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_FIX_ID" field.
        /// </summary>
        System.String IHelpdeskModel.FixIdId
        {
            get { return this.FixIdId; }
            set { this.FixIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_CATEGORY" field.
        /// </summary>
        System.String IHelpdeskModel.Category
        {
            get { return this.Category; }
            set { this.Category = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_FIX_CAT" field.
        /// </summary>
        System.String IHelpdeskModel.FixCat
        {
            get { return this.FixCat; }
            set { this.FixCat = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_CALL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IHelpdeskModel.CallDate
        {
            get { return this.CallDate; }
            set { this.CallDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_SEVERITY" field.
        /// </summary>
        System.String IHelpdeskModel.Severity
        {
            get { return this.Severity; }
            set { this.Severity = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_TITLE" field.
        /// </summary>
        System.String IHelpdeskModel.Title
        {
            get { return this.Title; }
            set { this.Title = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IHelpdeskModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_WIP_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel IHelpdeskModel.WipId
        {
            get { return this.WipId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_WIP_ID" field.
        /// </summary>
        System.String IHelpdeskModel.WipIdId
        {
            get { return this.WipIdId; }
            set { this.WipIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_RES_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IHelpdeskModel.ResDate
        {
            get { return this.ResDate; }
            set { this.ResDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IHelpdeskModel.SelcoSpId
        {
            get { return this.SelcoSpId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        System.String IHelpdeskModel.SelcoSpIdId
        {
            get { return this.SelcoSpIdId; }
            set { this.SelcoSpIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "HD_PM_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel IHelpdeskModel.PmId
        {
            get { return this.PmId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_PM_ID" field.
        /// </summary>
        System.String IHelpdeskModel.PmIdId
        {
            get { return this.PmIdId; }
            set { this.PmIdId = (System.String)value; }
        }

        #endregion
    }
}
