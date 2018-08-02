using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;
using Consensus.Sales;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="ActivityRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalActivityModel : LocalModel<ActivityRecord, String>, IActivityModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ACT_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "ACT_RESULT" field.
        /// </summary>
        private LocalCodeModel _result;

        /// <summary>
        ///     The value of the "ACT_OPP_ID" field.
        /// </summary>
        private LocalOpportunityModel _opportunity;

        /// <summary>
        ///     The value of the "ACT_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="ActivityModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        /// <summary>
        ///     The collection of <see cref="OpportunityModel" /> instances that reference this <see cref="ActivityModel" />.
        /// </summary>
        private LocalCollection<LocalOpportunityModel, IOpportunityModel> _opportunities;

        /// <summary>
        ///     The collection of <see cref="ActivityXrefModel" /> instances that reference this <see cref="ActivityModel" />.
        /// </summary>
        private LocalCollection<LocalActivityXrefModel, IActivityXrefModel> _activityXRefs;

        /// <summary>
        ///     The collection of <see cref="ActLinkXrefModel" /> instances that reference this <see cref="ActivityModel" />.
        /// </summary>
        private LocalCollection<LocalActLinkXrefModel, IActLinkXrefModel> _activityLinkXrefs;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActivityRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Activities.Activity.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActivityRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Activities.Activity.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActivityRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Activities.Activity.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("ACT", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("ACT");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_TYPE" field.
        /// </summary>
        public String TypeCode
        {
            get { return this.ModifiedData.Type; }
            set
            {
                if (this.ModifiedData.Type != value)
                     _type = null;
                this.ModifiedData.Type = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ACTION_DATE" field.
        /// </summary>
        public DateTime? ActionDate
        {
            get { return this.ModifiedData.ActionDate; }
            set { this.ModifiedData.ActionDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_TIME" field.
        /// </summary>
        public DateTime? Time
        {
            get { return this.ModifiedData.Time; }
            set { this.ModifiedData.Time = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_END_TIME" field.
        /// </summary>
        public DateTime? EndTime
        {
            get { return this.ModifiedData.EndTime; }
            set { this.ModifiedData.EndTime = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_RESULT" field.
        /// </summary>
        public LocalCodeModel Result
        {
            get
            {
                if (_result == null && !String.IsNullOrEmpty(this.ResultCode))
                    _result = this.Provider.Common.Code.FetchByTypeAndCode("TKST", this.ResultCode);
                if (_result == null)
                    _result = this.Provider.Common.Code.Create("TKST");
                return _result;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_RESULT" field.
        /// </summary>
        public String ResultCode
        {
            get { return this.ModifiedData.Result; }
            set
            {
                if (this.ModifiedData.Result != value)
                     _result = null;
                this.ModifiedData.Result = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_NOTE" field.
        /// </summary>
        public String Note
        {
            get { return this.ModifiedData.Note; }
            set { this.ModifiedData.Note = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_OPP_ID" field.
        /// </summary>
        public LocalOpportunityModel Opportunity
        {
            get
            {
                if (_opportunity == null && this.OpportunityId != null)
                    _opportunity = this.Provider.Sales.Opportunity.FetchById(this.OpportunityId);
                if (_opportunity == null)
                    _opportunity = this.Provider.Sales.Opportunity.Create();
                
                return _opportunity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_OPP_ID" field.
        /// </summary>
        public String OpportunityId
        {
            get { return this.ModifiedData.OppId; }
            set
            {
                if (this.ModifiedData.OppId != value)
                     _opportunity = null;
                this.ModifiedData.OppId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_SESSION_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.SessionName; }
            set { this.ModifiedData.SessionName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_NOTE_HTML" field.
        /// </summary>
        public String NoteHtml
        {
            get { return this.ModifiedData.NoteHtml; }
            set { this.ModifiedData.NoteHtml = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_SELCO_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="ActivityModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllByActivityId(this.Id));
                
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OpportunityModel" /> instances that reference this <see cref="ActivityModel" />.
        /// </summary>
        public LocalCollection<LocalOpportunityModel, IOpportunityModel> Opportunities
        {
            get
            {
                if (_opportunities == null)
                    _opportunities = new LocalCollection<LocalOpportunityModel, IOpportunityModel>(this.Provider.Sales.Opportunity.FetchAllByActivityId(this.Id));
                
                return _opportunities;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ActivityXrefModel" /> instances that reference this <see cref="ActivityModel" />.
        /// </summary>
        public LocalCollection<LocalActivityXrefModel, IActivityXrefModel> ActivityXRefs
        {
            get
            {
                if (_activityXRefs == null)
                    _activityXRefs = new LocalCollection<LocalActivityXrefModel, IActivityXrefModel>(this.Provider.Activities.ActivityXref.FetchAllByActivityId(this.Id));
                
                return _activityXRefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ActLinkXrefModel" /> instances that reference this <see cref="ActivityModel" />.
        /// </summary>
        public LocalCollection<LocalActLinkXrefModel, IActLinkXrefModel> ActivityLinkXrefs
        {
            get
            {
                if (_activityLinkXrefs == null)
                    _activityLinkXrefs = new LocalCollection<LocalActLinkXrefModel, IActLinkXrefModel>(this.Provider.Activities.ActLinkXref.FetchAllByActivityId(this.Id));
                
                return _activityLinkXrefs;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalActivityModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalActivityModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalActivityModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalActivityModel(LocalProvider provider, ActivityRecord record) : base(provider, record)
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
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_result != null)
            {
                _result.Save();
                this.ModifiedData.Result = _result.Value1;
            }
            if (_opportunity != null)
            {
                _opportunity.Save();
                this.ModifiedData.OppId = _opportunity.Id == null && this.ModifiedData.OppId != null ? "" : _opportunity.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_elements != null)
                _elements.Execute(obj => obj.ActivityId = this.Id).Execute(obj => obj.Save());
            if (_opportunities != null)
                _opportunities.Execute(obj => obj.ActivityId = this.Id).Execute(obj => obj.Save());
            if (_activityXRefs != null)
                _activityXRefs.Execute(obj => obj.ActivityId = this.Id).Execute(obj => obj.Save());
            if (_activityLinkXrefs != null)
                _activityLinkXrefs.Execute(obj => obj.ActivityId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the instance of the LocalActivityXrefModel which represents the activity salesperson.
        /// </summary>
        Consensus.Activities.IActivityXrefModel IActivityModel.EndUser
        {
            get { return this.EndUser; }
        }

        /// <summary>
        ///     Gets the instance of the LocalActivityXrefModel which represents the activity salesperson.
        /// </summary>
        Consensus.Activities.IActivityXrefModel IActivityModel.SalesPerson
        {
            get { return this.SalesPerson; }
        }

        System.String IActivityModel.EndUserId
        {
            get { return this.EndUserId; }
            set { this.EndUserId = (System.String)value; }
        }

        System.String IActivityModel.EndUserPersonId
        {
            get { return this.EndUserPersonId; }
            set { this.EndUserPersonId = (System.String)value; }
        }

        System.String IActivityModel.EndUserOrganisationId
        {
            get { return this.EndUserOrganisationId; }
            set { this.EndUserOrganisationId = (System.String)value; }
        }

        System.String IActivityModel.SalesPersonId
        {
            get { return this.SalesPersonId; }
            set { this.SalesPersonId = (System.String)value; }
        }

        /// <summary>
        ///     List of attachments for an activity. Created here to aid saving from the activity dialog.
        /// </summary>
        Consensus.Collection<Consensus.Common.IAttachmentModel> IActivityModel.Attachments
        {
            get { return this.Attachments; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IActivityModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_TYPE" field.
        /// </summary>
        System.String IActivityModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ACTION_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IActivityModel.ActionDate
        {
            get { return this.ActionDate; }
            set { this.ActionDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IActivityModel.Time
        {
            get { return this.Time; }
            set { this.Time = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IActivityModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_END_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IActivityModel.EndTime
        {
            get { return this.EndTime; }
            set { this.EndTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_RESULT" field.
        /// </summary>
        Consensus.Common.ICodeModel IActivityModel.Result
        {
            get { return this.Result; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_RESULT" field.
        /// </summary>
        System.String IActivityModel.ResultCode
        {
            get { return this.ResultCode; }
            set { this.ResultCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_NOTE" field.
        /// </summary>
        System.String IActivityModel.Note
        {
            get { return this.Note; }
            set { this.Note = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_OPP_ID" field.
        /// </summary>
        Consensus.Sales.IOpportunityModel IActivityModel.Opportunity
        {
            get { return this.Opportunity; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_OPP_ID" field.
        /// </summary>
        System.String IActivityModel.OpportunityId
        {
            get { return this.OpportunityId; }
            set { this.OpportunityId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_SESSION_NAME" field.
        /// </summary>
        System.String IActivityModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_NOTE_HTML" field.
        /// </summary>
        System.String IActivityModel.NoteHtml
        {
            get { return this.NoteHtml; }
            set { this.NoteHtml = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IActivityModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_SELCO_SP_ID" field.
        /// </summary>
        System.String IActivityModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> IActivityModel.Elements
        {
            get { return this.Elements; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityModel> IActivityModel.Opportunities
        {
            get { return this.Opportunities; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityXrefModel> IActivityModel.ActivityXRefs
        {
            get { return this.ActivityXRefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActLinkXrefModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActLinkXrefModel> IActivityModel.ActivityLinkXrefs
        {
            get { return this.ActivityLinkXrefs; }
        }

        #endregion
    }
}
