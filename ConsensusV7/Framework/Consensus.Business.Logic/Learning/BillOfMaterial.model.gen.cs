using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="BillOfMaterialRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBillOfMaterialModel : LocalModel<BillOfMaterialRecord, String>, IBillOfMaterialModel
    {
        #region fields

        /// <summary>
        ///     The value of the "BOM_PARENT_ID" field.
        /// </summary>
        private LocalProductModel _masterProduct;

        /// <summary>
        ///     The value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        private LocalProductModel _childProduct;

        /// <summary>
        ///     The value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        private LocalProductModel _accomProduct;

        /// <summary>
        ///     The value of the "BOM_ACT_TYPE" field.
        /// </summary>
        private LocalCodeModel _actType;

        /// <summary>
        ///     The value of the "BOM_PSG_ID" field.
        /// </summary>
        private LocalProdSelectGroupModel _psgId;

        /// <summary>
        ///     The collection of <see cref="TemplateModel" /> instances that reference this <see cref="BillOfMaterialModel" />.
        /// </summary>
        private LocalCollection<LocalTemplateModel, ITemplateModel> _templates;

        /// <summary>
        ///     The collection of <see cref="SessionModel" /> instances that reference this <see cref="BillOfMaterialModel" />.
        /// </summary>
        private LocalCollection<LocalSessionModel, ISessionModel> _sessions;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BillOfMaterialRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.BillOfMaterial.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BillOfMaterialRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.BillOfMaterial.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<BillOfMaterialRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.BillOfMaterial.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_PARENT_ID" field.
        /// </summary>
        public LocalProductModel MasterProduct
        {
            get
            {
                if (_masterProduct == null && this.MasterProductId != null)
                    _masterProduct = this.Provider.Learning.Product.FetchById(this.MasterProductId);
                if (_masterProduct == null)
                    _masterProduct = this.Provider.Learning.Product.Create();
                
                return _masterProduct;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_PARENT_ID" field.
        /// </summary>
        public String MasterProductId
        {
            get { return this.ModifiedData.ParentId; }
            set
            {
                if (this.ModifiedData.ParentId != value)
                     _masterProduct = null;
                this.ModifiedData.ParentId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        public LocalProductModel ChildProduct
        {
            get
            {
                if (_childProduct == null && this.ChildProductId != null)
                    _childProduct = this.Provider.Learning.Product.FetchById(this.ChildProductId);
                if (_childProduct == null)
                    _childProduct = this.Provider.Learning.Product.Create();
                
                return _childProduct;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        public String ChildProductId
        {
            get { return this.ModifiedData.SyllabusId; }
            set
            {
                if (this.ModifiedData.SyllabusId != value)
                     _childProduct = null;
                this.ModifiedData.SyllabusId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        public LocalProductModel AccomProduct
        {
            get
            {
                if (_accomProduct == null && this.AccomProductId != null)
                    _accomProduct = this.Provider.Learning.Product.FetchById(this.AccomProductId);
                if (_accomProduct == null)
                    _accomProduct = this.Provider.Learning.Product.Create();
                
                return _accomProduct;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        public String AccomProductId
        {
            get { return this.ModifiedData.ResourceId; }
            set
            {
                if (this.ModifiedData.ResourceId != value)
                     _accomProduct = null;
                this.ModifiedData.ResourceId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_REAL" field.
        /// </summary>
        public Byte? Real
        {
            get { return this.ModifiedData.Real; }
            set { this.ModifiedData.Real = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SESSION" field.
        /// </summary>
        public Byte? Session
        {
            get { return this.ModifiedData.Session; }
            set { this.ModifiedData.Session = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ELEMENT" field.
        /// </summary>
        public Byte? Element
        {
            get { return this.ModifiedData.Element; }
            set { this.ModifiedData.Element = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_START_DAY" field.
        /// </summary>
        public Double? StartDay
        {
            get { return this.ModifiedData.StartDay; }
            set { this.ModifiedData.StartDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_END_DAY" field.
        /// </summary>
        public Double? EndDay
        {
            get { return this.ModifiedData.EndDay; }
            set { this.ModifiedData.EndDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_START_TIME" field.
        /// </summary>
        public DateTime? StartTime
        {
            get { return this.ModifiedData.StartTime; }
            set { this.ModifiedData.StartTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_END_TIME" field.
        /// </summary>
        public DateTime? EndTime
        {
            get { return this.ModifiedData.EndTime; }
            set { this.ModifiedData.EndTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_QUANTITY" field.
        /// </summary>
        public Double? Quantity
        {
            get { return this.ModifiedData.Quantity; }
            set { this.ModifiedData.Quantity = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_MANDATORY" field.
        /// </summary>
        public Byte? Mandatory
        {
            get { return this.ModifiedData.Mandatory; }
            set { this.ModifiedData.Mandatory = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_CHARGEABLE" field.
        /// </summary>
        public Byte? Chargeable
        {
            get { return this.ModifiedData.Chargeable; }
            set { this.ModifiedData.Chargeable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_INVOICE_PRINT" field.
        /// </summary>
        public Byte? InvoicePrint
        {
            get { return this.ModifiedData.InvoicePrint; }
            set { this.ModifiedData.InvoicePrint = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_ACT_TYPE" field.
        /// </summary>
        public LocalCodeModel ActType
        {
            get
            {
                if (_actType == null && !String.IsNullOrEmpty(this.ActTypeCode))
                    _actType = this.Provider.Common.Code.FetchByTypeAndCode("ACT", this.ActTypeCode);
                if (_actType == null)
                    _actType = this.Provider.Common.Code.Create("ACT");
                return _actType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_ACT_TYPE" field.
        /// </summary>
        public String ActTypeCode
        {
            get { return this.ModifiedData.ActType; }
            set
            {
                if (this.ModifiedData.ActType != value)
                     _actType = null;
                this.ModifiedData.ActType = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SHOW_SALES" field.
        /// </summary>
        public Byte? ShowSales
        {
            get { return this.ModifiedData.ShowSales; }
            set { this.ModifiedData.ShowSales = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_NOTE" field.
        /// </summary>
        public String ActNote
        {
            get { return this.ModifiedData.ActNote; }
            set { this.ModifiedData.ActNote = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_MAIN_SESSION" field.
        /// </summary>
        public Byte? MainSession
        {
            get { return this.ModifiedData.MainSession; }
            set { this.ModifiedData.MainSession = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TYPE_SUB" field.
        /// </summary>
        public String TypeSub
        {
            get { return this.ModifiedData.TypeSub; }
            set { this.ModifiedData.TypeSub = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ROOM_LAYOUT" field.
        /// </summary>
        public Int32? RoomLayout
        {
            get { return this.ModifiedData.RoomLayout; }
            set { this.ModifiedData.RoomLayout = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_INC_IN_BUDGET" field.
        /// </summary>
        public Byte IncInBudget
        {
            get { return this.ModifiedData.IncInBudget; }
            set { this.ModifiedData.IncInBudget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TEACH_HRS" field.
        /// </summary>
        public Decimal? TeachHrs
        {
            get { return this.ModifiedData.TeachHrs; }
            set { this.ModifiedData.TeachHrs = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_STUD_WKS" field.
        /// </summary>
        public Decimal? StudWks
        {
            get { return this.ModifiedData.StudWks; }
            set { this.ModifiedData.StudWks = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_SESSION_NAME" field.
        /// </summary>
        public String ActSessionName
        {
            get { return this.ModifiedData.ActSessionName; }
            set { this.ModifiedData.ActSessionName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_PREDELIV" field.
        /// </summary>
        public Byte Predeliv
        {
            get { return this.ModifiedData.Predeliv; }
            set { this.ModifiedData.Predeliv = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_CODE" field.
        /// </summary>
        public String Code
        {
            get { return this.ModifiedData.Code; }
            set { this.ModifiedData.Code = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_PSG_ID" field.
        /// </summary>
        public LocalProdSelectGroupModel PsgId
        {
            get
            {
                if (_psgId == null && this.PsgIdId != null)
                    _psgId = this.Provider.Learning.ProdSelectGroup.FetchById(this.PsgIdId.Value);
                if (_psgId == null)
                    _psgId = this.Provider.Learning.ProdSelectGroup.Create();
                
                return _psgId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_PSG_ID" field.
        /// </summary>
        public Int32? PsgIdId
        {
            get { return this.ModifiedData.ProductSelectGroup; }
            set
            {
                if (this.ModifiedData.ProductSelectGroup != value)
                     _psgId = null;
                this.ModifiedData.ProductSelectGroup = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_REVENUE_SPLIT" field.
        /// </summary>
        public Double ActRevenueSplit
        {
            get { return this.ModifiedData.ActRevenueSplit; }
            set { this.ModifiedData.ActRevenueSplit = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_HOURS_SPLIT" field.
        /// </summary>
        public Double ActHoursSplit
        {
            get { return this.ModifiedData.ActHoursSplit; }
            set { this.ModifiedData.ActHoursSplit = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_EXP_OCCUPANCY" field.
        /// </summary>
        public Int32? ExpOccupancy
        {
            get { return this.ModifiedData.ExpOccupancy; }
            set { this.ModifiedData.ExpOccupancy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SHOW_ATT_LOG" field.
        /// </summary>
        public Byte? ShowAttLog
        {
            get { return this.ModifiedData.ShowAttLog; }
            set { this.ModifiedData.ShowAttLog = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="TemplateModel" /> instances that reference this <see cref="BillOfMaterialModel" />.
        /// </summary>
        public LocalCollection<LocalTemplateModel, ITemplateModel> Templates
        {
            get
            {
                if (_templates == null)
                    _templates = new LocalCollection<LocalTemplateModel, ITemplateModel>(this.Provider.Learning.Template.FetchAllByBillOfMaterialId(this.Id));
                
                return _templates;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SessionModel" /> instances that reference this <see cref="BillOfMaterialModel" />.
        /// </summary>
        public LocalCollection<LocalSessionModel, ISessionModel> Sessions
        {
            get
            {
                if (_sessions == null)
                    _sessions = new LocalCollection<LocalSessionModel, ISessionModel>(this.Provider.Learning.Session.FetchAllByBiillOfMaterialId(this.Id));
                
                return _sessions;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalBillOfMaterialModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalBillOfMaterialModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalBillOfMaterialModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalBillOfMaterialModel(LocalProvider provider, BillOfMaterialRecord record) : base(provider, record)
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
            if (_actType != null)
            {
                _actType.Save();
                this.ModifiedData.ActType = _actType.Value1;
            }
            if (_masterProduct != null)
            {
                _masterProduct.Save();
                this.ModifiedData.ParentId = _masterProduct.Id == null && this.ModifiedData.ParentId != null ? "" : _masterProduct.Id;
            }
            if (_childProduct != null)
            {
                _childProduct.Save();
                this.ModifiedData.SyllabusId = _childProduct.Id == null && this.ModifiedData.SyllabusId != null ? "" : _childProduct.Id;
            }
            if (_accomProduct != null)
            {
                _accomProduct.Save();
                this.ModifiedData.ResourceId = _accomProduct.Id == null && this.ModifiedData.ResourceId != null ? "" : _accomProduct.Id;
            }
            if (_psgId != null)
            {
                _psgId.Save();
                this.ModifiedData.ProductSelectGroup = _psgId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_templates != null)
                _templates.Execute(obj => obj.BillOfMaterialId = this.Id).Execute(obj => obj.Save());
            if (_sessions != null)
                _sessions.Execute(obj => obj.BiillOfMaterialId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the collection of <see cref="T:Consensus.Learning.ITemplateTrainerModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateTrainerModel> IBillOfMaterialModel.Trainers
        {
            get { return this.Trainers; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="T:Consensus.Learning.ITemplateTrainerModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateResourceModel> IBillOfMaterialModel.Resources
        {
            get { return this.Resources; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="T:Consensus.Learning.ITemplateTrainerModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateRoomModel> IBillOfMaterialModel.Rooms
        {
            get { return this.Rooms; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_PARENT_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IBillOfMaterialModel.MasterProduct
        {
            get { return this.MasterProduct; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_PARENT_ID" field.
        /// </summary>
        System.String IBillOfMaterialModel.MasterProductId
        {
            get { return this.MasterProductId; }
            set { this.MasterProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IBillOfMaterialModel.ChildProduct
        {
            get { return this.ChildProduct; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        System.String IBillOfMaterialModel.ChildProductId
        {
            get { return this.ChildProductId; }
            set { this.ChildProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IBillOfMaterialModel.AccomProduct
        {
            get { return this.AccomProduct; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        System.String IBillOfMaterialModel.AccomProductId
        {
            get { return this.AccomProductId; }
            set { this.AccomProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TYPE" field.
        /// </summary>
        System.String IBillOfMaterialModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_REAL" field.
        /// </summary>
        System.Nullable<System.Byte> IBillOfMaterialModel.Real
        {
            get { return this.Real; }
            set { this.Real = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SESSION" field.
        /// </summary>
        System.Nullable<System.Byte> IBillOfMaterialModel.Session
        {
            get { return this.Session; }
            set { this.Session = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ELEMENT" field.
        /// </summary>
        System.Nullable<System.Byte> IBillOfMaterialModel.Element
        {
            get { return this.Element; }
            set { this.Element = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_START_DAY" field.
        /// </summary>
        System.Nullable<System.Double> IBillOfMaterialModel.StartDay
        {
            get { return this.StartDay; }
            set { this.StartDay = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_END_DAY" field.
        /// </summary>
        System.Nullable<System.Double> IBillOfMaterialModel.EndDay
        {
            get { return this.EndDay; }
            set { this.EndDay = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_START_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IBillOfMaterialModel.StartTime
        {
            get { return this.StartTime; }
            set { this.StartTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_END_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IBillOfMaterialModel.EndTime
        {
            get { return this.EndTime; }
            set { this.EndTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_QUANTITY" field.
        /// </summary>
        System.Nullable<System.Double> IBillOfMaterialModel.Quantity
        {
            get { return this.Quantity; }
            set { this.Quantity = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_MANDATORY" field.
        /// </summary>
        System.Nullable<System.Byte> IBillOfMaterialModel.Mandatory
        {
            get { return this.Mandatory; }
            set { this.Mandatory = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_CHARGEABLE" field.
        /// </summary>
        System.Nullable<System.Byte> IBillOfMaterialModel.Chargeable
        {
            get { return this.Chargeable; }
            set { this.Chargeable = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_INVOICE_PRINT" field.
        /// </summary>
        System.Nullable<System.Byte> IBillOfMaterialModel.InvoicePrint
        {
            get { return this.InvoicePrint; }
            set { this.InvoicePrint = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_ACT_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IBillOfMaterialModel.ActType
        {
            get { return this.ActType; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_ACT_TYPE" field.
        /// </summary>
        System.String IBillOfMaterialModel.ActTypeCode
        {
            get { return this.ActTypeCode; }
            set { this.ActTypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SHOW_SALES" field.
        /// </summary>
        System.Nullable<System.Byte> IBillOfMaterialModel.ShowSales
        {
            get { return this.ShowSales; }
            set { this.ShowSales = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_NOTE" field.
        /// </summary>
        System.String IBillOfMaterialModel.ActNote
        {
            get { return this.ActNote; }
            set { this.ActNote = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_MAIN_SESSION" field.
        /// </summary>
        System.Nullable<System.Byte> IBillOfMaterialModel.MainSession
        {
            get { return this.MainSession; }
            set { this.MainSession = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TYPE_SUB" field.
        /// </summary>
        System.String IBillOfMaterialModel.TypeSub
        {
            get { return this.TypeSub; }
            set { this.TypeSub = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ROOM_LAYOUT" field.
        /// </summary>
        System.Nullable<System.Int32> IBillOfMaterialModel.RoomLayout
        {
            get { return this.RoomLayout; }
            set { this.RoomLayout = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_INC_IN_BUDGET" field.
        /// </summary>
        System.Byte IBillOfMaterialModel.IncInBudget
        {
            get { return this.IncInBudget; }
            set { this.IncInBudget = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TEACH_HRS" field.
        /// </summary>
        System.Nullable<System.Decimal> IBillOfMaterialModel.TeachHrs
        {
            get { return this.TeachHrs; }
            set { this.TeachHrs = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_STUD_WKS" field.
        /// </summary>
        System.Nullable<System.Decimal> IBillOfMaterialModel.StudWks
        {
            get { return this.StudWks; }
            set { this.StudWks = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_SESSION_NAME" field.
        /// </summary>
        System.String IBillOfMaterialModel.ActSessionName
        {
            get { return this.ActSessionName; }
            set { this.ActSessionName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_PREDELIV" field.
        /// </summary>
        System.Byte IBillOfMaterialModel.Predeliv
        {
            get { return this.Predeliv; }
            set { this.Predeliv = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_CODE" field.
        /// </summary>
        System.String IBillOfMaterialModel.Code
        {
            get { return this.Code; }
            set { this.Code = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_PSG_ID" field.
        /// </summary>
        Consensus.Learning.IProdSelectGroupModel IBillOfMaterialModel.PsgId
        {
            get { return this.PsgId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_PSG_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IBillOfMaterialModel.PsgIdId
        {
            get { return this.PsgIdId; }
            set { this.PsgIdId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_REVENUE_SPLIT" field.
        /// </summary>
        System.Double IBillOfMaterialModel.ActRevenueSplit
        {
            get { return this.ActRevenueSplit; }
            set { this.ActRevenueSplit = (System.Double)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_HOURS_SPLIT" field.
        /// </summary>
        System.Double IBillOfMaterialModel.ActHoursSplit
        {
            get { return this.ActHoursSplit; }
            set { this.ActHoursSplit = (System.Double)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_EXP_OCCUPANCY" field.
        /// </summary>
        System.Nullable<System.Int32> IBillOfMaterialModel.ExpOccupancy
        {
            get { return this.ExpOccupancy; }
            set { this.ExpOccupancy = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SHOW_ATT_LOG" field.
        /// </summary>
        System.Nullable<System.Byte> IBillOfMaterialModel.ShowAttLog
        {
            get { return this.ShowAttLog; }
            set { this.ShowAttLog = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TemplateModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateModel> IBillOfMaterialModel.Templates
        {
            get { return this.Templates; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionModel> IBillOfMaterialModel.Sessions
        {
            get { return this.Sessions; }
        }

        #endregion
    }
}
