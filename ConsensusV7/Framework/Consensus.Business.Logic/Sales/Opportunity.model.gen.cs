using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Learning;
using Consensus.Marketing;

namespace Consensus.Sales
{
    /// <summary>
    ///     Encapsulates the <see cref="OpportunityRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOpportunityModel : LocalModel<OpportunityRecord, String>, IOpportunityModel
    {
        #region fields

        /// <summary>
        ///     The value of the "OPP_PROM_ID" field.
        /// </summary>
        private LocalPromotionModel _promId;

        /// <summary>
        ///     The value of the "OPP_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        private LocalCodeModel _prodInterest;

        /// <summary>
        ///     The value of the "OPP_MEDIUM" field.
        /// </summary>
        private LocalCodeModel _source;

        /// <summary>
        ///     The value of the "OPP_ACT_ID" field.
        /// </summary>
        private LocalActivityModel _activity;

        /// <summary>
        ///     The value of the "OPP_COMPETITOR" field.
        /// </summary>
        private LocalCodeModel _competitor;

        /// <summary>
        ///     The value of the "OPP_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "OPP_SALES_TYPE" field.
        /// </summary>
        private LocalCodeModel _salesType;

        /// <summary>
        ///     The value of the "OPP_COURSE_ID" field.
        /// </summary>
        private LocalEventModel _courseId;

        /// <summary>
        ///     The value of the "OPP_PROD_ID" field.
        /// </summary>
        private LocalProductModel _product;

        /// <summary>
        ///     The value of the "OPP_SERVICE" field.
        /// </summary>
        private LocalCodeModel _service;

        /// <summary>
        ///     The value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        private LocalCodeModel _searchGroup;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="OpportunityModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _events;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="OpportunityModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        /// <summary>
        ///     The collection of <see cref="OpportunityXrefModel" /> instances that reference this <see cref="OpportunityModel" />.
        /// </summary>
        private LocalCollection<LocalOpportunityXrefModel, IOpportunityXrefModel> _opportunityXrefs;

        /// <summary>
        ///     The collection of <see cref="ActivityModel" /> instances that reference this <see cref="OpportunityModel" />.
        /// </summary>
        private LocalCollection<LocalActivityModel, IActivityModel> _activityOpportunity;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<OpportunityRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Sales.Opportunity.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<OpportunityRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Sales.Opportunity.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<OpportunityRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Sales.Opportunity.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_QUO_ID" field.
        /// </summary>
        public String QuoId
        {
            get { return this.ModifiedData.QuoId; }
            set { this.ModifiedData.QuoId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROM_ID" field.
        /// </summary>
        public LocalPromotionModel PromId
        {
            get
            {
                if (_promId == null && this.PromIdId != null)
                    _promId = this.Provider.Marketing.Promotion.FetchById(this.PromIdId);
                if (_promId == null)
                    _promId = this.Provider.Marketing.Promotion.Create();
                
                return _promId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROM_ID" field.
        /// </summary>
        public String PromIdId
        {
            get { return this.ModifiedData.PromId; }
            set
            {
                if (this.ModifiedData.PromId != value)
                     _promId = null;
                this.ModifiedData.PromId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("STATU", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("STATU");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_STATUS" field.
        /// </summary>
        public String StatusCode
        {
            get { return this.ModifiedData.Status; }
            set
            {
                if (this.ModifiedData.Status != value)
                     _status = null;
                this.ModifiedData.Status = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_DATE_ENQ" field.
        /// </summary>
        public DateTime? DateEnq
        {
            get { return this.ModifiedData.DateEnq; }
            set { this.ModifiedData.DateEnq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_DATE_DEC" field.
        /// </summary>
        public DateTime? DateDec
        {
            get { return this.ModifiedData.DateDec; }
            set { this.ModifiedData.DateDec = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_VAL_POT" field.
        /// </summary>
        public Double? ValPot
        {
            get { return this.ModifiedData.ValPot; }
            set { this.ModifiedData.ValPot = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_PROB_PURCH" field.
        /// </summary>
        public Byte? ProbPurch
        {
            get { return this.ModifiedData.ProbPurch; }
            set { this.ModifiedData.ProbPurch = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_PROB_WIN" field.
        /// </summary>
        public Byte? ProbWin
        {
            get { return this.ModifiedData.ProbWin; }
            set { this.ModifiedData.ProbWin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_ROLL_QTY" field.
        /// </summary>
        public Double? RollQty
        {
            get { return this.ModifiedData.RollQty; }
            set { this.ModifiedData.RollQty = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        public LocalCodeModel ProdInterest
        {
            get
            {
                if (_prodInterest == null && !String.IsNullOrEmpty(this.ProdInterestCode))
                    _prodInterest = this.Provider.Common.Code.FetchByTypeAndCode("PRGRP", this.ProdInterestCode);
                if (_prodInterest == null)
                    _prodInterest = this.Provider.Common.Code.Create("PRGRP");
                return _prodInterest;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        public String ProdInterestCode
        {
            get { return this.ModifiedData.ProdInterest; }
            set
            {
                if (this.ModifiedData.ProdInterest != value)
                     _prodInterest = null;
                this.ModifiedData.ProdInterest = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_MEDIUM" field.
        /// </summary>
        public LocalCodeModel Source
        {
            get
            {
                if (_source == null && !String.IsNullOrEmpty(this.SourceCode))
                    _source = this.Provider.Common.Code.FetchByTypeAndCode("OPSOU", this.SourceCode);
                if (_source == null)
                    _source = this.Provider.Common.Code.Create("OPSOU");
                return _source;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_MEDIUM" field.
        /// </summary>
        public String SourceCode
        {
            get { return this.ModifiedData.Medium; }
            set
            {
                if (this.ModifiedData.Medium != value)
                     _source = null;
                this.ModifiedData.Medium = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_ACT_ID" field.
        /// </summary>
        public LocalActivityModel Activity
        {
            get
            {
                if (_activity == null && this.ActivityId != null)
                    _activity = this.Provider.Activities.Activity.FetchById(this.ActivityId);
                if (_activity == null)
                    _activity = this.Provider.Activities.Activity.Create();
                
                return _activity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_ACT_ID" field.
        /// </summary>
        public String ActivityId
        {
            get { return this.ModifiedData.ActId; }
            set
            {
                if (this.ModifiedData.ActId != value)
                     _activity = null;
                this.ModifiedData.ActId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_COMPETITOR" field.
        /// </summary>
        public LocalCodeModel Competitor
        {
            get
            {
                if (_competitor == null && !String.IsNullOrEmpty(this.CompetitorCode))
                    _competitor = this.Provider.Common.Code.FetchByTypeAndCode("COMPT", this.CompetitorCode);
                if (_competitor == null)
                    _competitor = this.Provider.Common.Code.Create("COMPT");
                return _competitor;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_COMPETITOR" field.
        /// </summary>
        public String CompetitorCode
        {
            get { return this.ModifiedData.Competitor; }
            set
            {
                if (this.ModifiedData.Competitor != value)
                     _competitor = null;
                this.ModifiedData.Competitor = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_COMMIT" field.
        /// </summary>
        public Byte? Commit
        {
            get { return this.ModifiedData.Commit; }
            set { this.ModifiedData.Commit = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.SellingCompanyId != null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SELCO_SP_ID" field.
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
        ///     Gets the The value of the "OPP_SALES_TYPE" field.
        /// </summary>
        public LocalCodeModel SalesType
        {
            get
            {
                if (_salesType == null && !String.IsNullOrEmpty(this.SalesTypeCode))
                    _salesType = this.Provider.Common.Code.FetchByTypeAndCode("OPTYP", this.SalesTypeCode);
                if (_salesType == null)
                    _salesType = this.Provider.Common.Code.Create("OPTYP");
                return _salesType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SALES_TYPE" field.
        /// </summary>
        public String SalesTypeCode
        {
            get { return this.ModifiedData.SalesType; }
            set
            {
                if (this.ModifiedData.SalesType != value)
                     _salesType = null;
                this.ModifiedData.SalesType = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_COURSE_ID" field.
        /// </summary>
        public LocalEventModel CourseId
        {
            get
            {
                if (_courseId == null && this.CourseIdId != null)
                    _courseId = this.Provider.Learning.Event.FetchById(this.CourseIdId);
                if (_courseId == null)
                    _courseId = this.Provider.Learning.Event.Create();
                
                return _courseId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_COURSE_ID" field.
        /// </summary>
        public String CourseIdId
        {
            get { return this.ModifiedData.CourseId; }
            set
            {
                if (this.ModifiedData.CourseId != value)
                     _courseId = null;
                this.ModifiedData.CourseId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROD_ID" field.
        /// </summary>
        public LocalProductModel Product
        {
            get
            {
                if (_product == null && this.ProductId != null)
                    _product = this.Provider.Learning.Product.FetchById(this.ProductId);
                if (_product == null)
                    _product = this.Provider.Learning.Product.Create();
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROD_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return this.ModifiedData.ProdId; }
            set
            {
                if (this.ModifiedData.ProdId != value)
                     _product = null;
                this.ModifiedData.ProdId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return this.ModifiedData.CostCode; }
            set { this.ModifiedData.CostCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SERVICE" field.
        /// </summary>
        public LocalCodeModel Service
        {
            get
            {
                if (_service == null && !String.IsNullOrEmpty(this.ServiceCode))
                    _service = this.Provider.Common.Code.FetchByTypeAndCode("OPSVR", this.ServiceCode);
                if (_service == null)
                    _service = this.Provider.Common.Code.Create("OPSVR");
                return _service;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SERVICE" field.
        /// </summary>
        public String ServiceCode
        {
            get { return this.ModifiedData.Service; }
            set
            {
                if (this.ModifiedData.Service != value)
                     _service = null;
                this.ModifiedData.Service = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        public LocalCodeModel SearchGroup
        {
            get
            {
                if (_searchGroup == null && !String.IsNullOrEmpty(this.SearchGroupCode))
                    _searchGroup = this.Provider.Common.Code.FetchByTypeAndCode("OSGRP", this.SearchGroupCode);
                if (_searchGroup == null)
                    _searchGroup = this.Provider.Common.Code.Create("OSGRP");
                return _searchGroup;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        public String SearchGroupCode
        {
            get { return this.ModifiedData.SearchGroup; }
            set
            {
                if (this.ModifiedData.SearchGroup != value)
                     _searchGroup = null;
                this.ModifiedData.SearchGroup = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_SY_TYPE" field.
        /// </summary>
        public Int32 SyType
        {
            get { return this.ModifiedData.SyType; }
            set { this.ModifiedData.SyType = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="OpportunityModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> Events
        {
            get
            {
                if (_events == null)
                    _events = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByOpportunityId(this.Id));
                
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="OpportunityModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByOpportunityId(this.Id));
                
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OpportunityXrefModel" /> instances that reference this <see cref="OpportunityModel" />.
        /// </summary>
        public LocalCollection<LocalOpportunityXrefModel, IOpportunityXrefModel> OpportunityXrefs
        {
            get
            {
                if (_opportunityXrefs == null)
                    _opportunityXrefs = new LocalCollection<LocalOpportunityXrefModel, IOpportunityXrefModel>(this.Provider.Sales.OpportunityXref.FetchAllByOpportunityId(this.Id));
                
                return _opportunityXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ActivityModel" /> instances that reference this <see cref="OpportunityModel" />.
        /// </summary>
        public LocalCollection<LocalActivityModel, IActivityModel> ActivityOpportunity
        {
            get
            {
                if (_activityOpportunity == null)
                    _activityOpportunity = new LocalCollection<LocalActivityModel, IActivityModel>(this.Provider.Activities.Activity.FetchAllByOpportunityId(this.Id));
                
                return _activityOpportunity;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalOpportunityModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalOpportunityModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalOpportunityModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalOpportunityModel(LocalProvider provider, OpportunityRecord record) : base(provider, record)
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
                this.ModifiedData.Status = _status.Value1;
            }
            if (_prodInterest != null)
            {
                _prodInterest.Save();
                this.ModifiedData.ProdInterest = _prodInterest.Value1;
            }
            if (_source != null)
            {
                _source.Save();
                this.ModifiedData.Medium = _source.Value1;
            }
            if (_competitor != null)
            {
                _competitor.Save();
                this.ModifiedData.Competitor = _competitor.Value1;
            }
            if (_salesType != null)
            {
                _salesType.Save();
                this.ModifiedData.SalesType = _salesType.Value1;
            }
            if (_service != null)
            {
                _service.Save();
                this.ModifiedData.Service = _service.Value1;
            }
            if (_searchGroup != null)
            {
                _searchGroup.Save();
                this.ModifiedData.SearchGroup = _searchGroup.Value1;
            }
            if (_promId != null)
            {
                _promId.Save();
                this.ModifiedData.PromId = _promId.Id == null && this.ModifiedData.PromId != null ? "" : _promId.Id;
            }
            if (_activity != null)
            {
                _activity.Save();
                this.ModifiedData.ActId = _activity.Id == null && this.ModifiedData.ActId != null ? "" : _activity.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_courseId != null)
            {
                _courseId.Save();
                this.ModifiedData.CourseId = _courseId.Id == null && this.ModifiedData.CourseId != null ? "" : _courseId.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProdId = _product.Id == null && this.ModifiedData.ProdId != null ? "" : _product.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_events != null)
                _events.Execute(obj => obj.OpportunityId = this.Id).Execute(obj => obj.Save());
            if (_bookings != null)
                _bookings.Execute(obj => obj.OpportunityId = this.Id).Execute(obj => obj.Save());
            if (_opportunityXrefs != null)
                _opportunityXrefs.Execute(obj => obj.OpportunityId = this.Id).Execute(obj => obj.Save());
            if (_activityOpportunity != null)
                _activityOpportunity.Execute(obj => obj.OpportunityId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the client for the opp.
        /// </summary>
        Consensus.Sales.IOpportunityXrefModel IOpportunityModel.ClientOppXref
        {
            get { return this.ClientOppXref; }
            set { this.ClientOppXref = (Consensus.Sales.LocalOpportunityXrefModel)value; }
        }

        /// <summary>
        ///     Gets or sets the main sales person for the opp.
        /// </summary>
        Consensus.Sales.IOpportunityXrefModel IOpportunityModel.SalesOppXref
        {
            get { return this.SalesOppXref; }
            set { this.SalesOppXref = (Consensus.Sales.LocalOpportunityXrefModel)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_QUO_ID" field.
        /// </summary>
        System.String IOpportunityModel.QuoId
        {
            get { return this.QuoId; }
            set { this.QuoId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROM_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel IOpportunityModel.PromId
        {
            get { return this.PromId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROM_ID" field.
        /// </summary>
        System.String IOpportunityModel.PromIdId
        {
            get { return this.PromIdId; }
            set { this.PromIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IOpportunityModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_STATUS" field.
        /// </summary>
        System.String IOpportunityModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_DATE_ENQ" field.
        /// </summary>
        System.Nullable<System.DateTime> IOpportunityModel.DateEnq
        {
            get { return this.DateEnq; }
            set { this.DateEnq = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_DATE_DEC" field.
        /// </summary>
        System.Nullable<System.DateTime> IOpportunityModel.DateDec
        {
            get { return this.DateDec; }
            set { this.DateDec = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_VAL_POT" field.
        /// </summary>
        System.Nullable<System.Double> IOpportunityModel.ValPot
        {
            get { return this.ValPot; }
            set { this.ValPot = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_NAME" field.
        /// </summary>
        System.String IOpportunityModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_NOTES" field.
        /// </summary>
        System.String IOpportunityModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_PROB_PURCH" field.
        /// </summary>
        System.Nullable<System.Byte> IOpportunityModel.ProbPurch
        {
            get { return this.ProbPurch; }
            set { this.ProbPurch = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_PROB_WIN" field.
        /// </summary>
        System.Nullable<System.Byte> IOpportunityModel.ProbWin
        {
            get { return this.ProbWin; }
            set { this.ProbWin = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_ROLL_QTY" field.
        /// </summary>
        System.Nullable<System.Double> IOpportunityModel.RollQty
        {
            get { return this.RollQty; }
            set { this.RollQty = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        Consensus.Common.ICodeModel IOpportunityModel.ProdInterest
        {
            get { return this.ProdInterest; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        System.String IOpportunityModel.ProdInterestCode
        {
            get { return this.ProdInterestCode; }
            set { this.ProdInterestCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_MEDIUM" field.
        /// </summary>
        Consensus.Common.ICodeModel IOpportunityModel.Source
        {
            get { return this.Source; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_MEDIUM" field.
        /// </summary>
        System.String IOpportunityModel.SourceCode
        {
            get { return this.SourceCode; }
            set { this.SourceCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_ACT_ID" field.
        /// </summary>
        Consensus.Activities.IActivityModel IOpportunityModel.Activity
        {
            get { return this.Activity; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_ACT_ID" field.
        /// </summary>
        System.String IOpportunityModel.ActivityId
        {
            get { return this.ActivityId; }
            set { this.ActivityId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_COMPETITOR" field.
        /// </summary>
        Consensus.Common.ICodeModel IOpportunityModel.Competitor
        {
            get { return this.Competitor; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_COMPETITOR" field.
        /// </summary>
        System.String IOpportunityModel.CompetitorCode
        {
            get { return this.CompetitorCode; }
            set { this.CompetitorCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_COMMIT" field.
        /// </summary>
        System.Nullable<System.Byte> IOpportunityModel.Commit
        {
            get { return this.Commit; }
            set { this.Commit = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IOpportunityModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SELCO_SP_ID" field.
        /// </summary>
        System.String IOpportunityModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SALES_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IOpportunityModel.SalesType
        {
            get { return this.SalesType; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SALES_TYPE" field.
        /// </summary>
        System.String IOpportunityModel.SalesTypeCode
        {
            get { return this.SalesTypeCode; }
            set { this.SalesTypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel IOpportunityModel.CourseId
        {
            get { return this.CourseId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_COURSE_ID" field.
        /// </summary>
        System.String IOpportunityModel.CourseIdId
        {
            get { return this.CourseIdId; }
            set { this.CourseIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IOpportunityModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROD_ID" field.
        /// </summary>
        System.String IOpportunityModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_COST_CODE" field.
        /// </summary>
        System.String IOpportunityModel.CostCode
        {
            get { return this.CostCode; }
            set { this.CostCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SERVICE" field.
        /// </summary>
        Consensus.Common.ICodeModel IOpportunityModel.Service
        {
            get { return this.Service; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SERVICE" field.
        /// </summary>
        System.String IOpportunityModel.ServiceCode
        {
            get { return this.ServiceCode; }
            set { this.ServiceCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel IOpportunityModel.SearchGroup
        {
            get { return this.SearchGroup; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        System.String IOpportunityModel.SearchGroupCode
        {
            get { return this.SearchGroupCode; }
            set { this.SearchGroupCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_SY_TYPE" field.
        /// </summary>
        System.Int32 IOpportunityModel.SyType
        {
            get { return this.SyType; }
            set { this.SyType = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IOpportunityModel.Events
        {
            get { return this.Events; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> IOpportunityModel.Bookings
        {
            get { return this.Bookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityXrefModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityXrefModel> IOpportunityModel.OpportunityXrefs
        {
            get { return this.OpportunityXrefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityModel> IOpportunityModel.ActivityOpportunity
        {
            get { return this.ActivityOpportunity; }
        }

        #endregion
    }
}
