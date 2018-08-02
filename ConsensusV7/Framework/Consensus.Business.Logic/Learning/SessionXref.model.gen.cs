using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="SessionXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSessionXrefModel : LocalModel<SessionXrefRecord, String>, ISessionXrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "SXREF_COURSE_ID" field.
        /// </summary>
        private LocalEventModel _event;

        /// <summary>
        ///     The value of the "SXREF_ACT_ID" field.
        /// </summary>
        private LocalSessionModel _session;

        /// <summary>
        ///     The value of the "SXREF_VATCD" field.
        /// </summary>
        private LocalCodeModel _vatCode;

        /// <summary>
        ///     The value of the "SXREF_EP_ID" field.
        /// </summary>
        private LocalEventProductModel _eventProduct;

        /// <summary>
        ///     The value of the "SXREF_REGION" field.
        /// </summary>
        private LocalCodeModel _regionCode;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="SessionXrefModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SessionXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.SessionXref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SessionXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.SessionXref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SessionXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.SessionXref.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_COURSE_ID" field.
        /// </summary>
        public LocalEventModel Event
        {
            get
            {
                if (_event == null && this.EventId != null)
                    _event = this.Provider.Learning.Event.FetchById(this.EventId);
                if (_event == null)
                    _event = this.Provider.Learning.Event.Create();
                
                return _event;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_COURSE_ID" field.
        /// </summary>
        public String EventId
        {
            get { return this.ModifiedData.CourseId; }
            set
            {
                if (this.ModifiedData.CourseId != value)
                     _event = null;
                this.ModifiedData.CourseId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_ACT_ID" field.
        /// </summary>
        public LocalSessionModel Session
        {
            get
            {
                if (_session == null && this.SessionId != null)
                    _session = this.Provider.Learning.Session.FetchById(this.SessionId);
                if (_session == null)
                    _session = this.Provider.Learning.Session.Create();
                
                return _session;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_ACT_ID" field.
        /// </summary>
        public String SessionId
        {
            get { return this.ModifiedData.ActId; }
            set
            {
                if (this.ModifiedData.ActId != value)
                     _session = null;
                this.ModifiedData.ActId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_REAL" field.
        /// </summary>
        public Byte? Real
        {
            get { return this.ModifiedData.Real; }
            set { this.ModifiedData.Real = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_ELEMENT" field.
        /// </summary>
        public Byte? Element
        {
            get { return this.ModifiedData.Element; }
            set { this.ModifiedData.Element = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MANDATORY" field.
        /// </summary>
        public Byte? Mandatory
        {
            get { return this.ModifiedData.Mandatory; }
            set { this.ModifiedData.Mandatory = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_INV_PRINT" field.
        /// </summary>
        public Byte? InvPrint
        {
            get { return this.ModifiedData.InvPrint; }
            set { this.ModifiedData.InvPrint = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return this.ModifiedData.Currency; }
            set { this.ModifiedData.Currency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PRICE" field.
        /// </summary>
        public Decimal Price
        {
            get { return this.ModifiedData.Price; }
            set { this.ModifiedData.Price = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_BLOCK_PRICE" field.
        /// </summary>
        public Decimal BlockPrice
        {
            get { return this.ModifiedData.BlockPrice; }
            set { this.ModifiedData.BlockPrice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_VATCD" field.
        /// </summary>
        public LocalCodeModel VatCode
        {
            get
            {
                if (_vatCode == null && !String.IsNullOrEmpty(this.VatCodeCode))
                    _vatCode = this.Provider.Common.Code.FetchByTypeAndCode("VATCD", this.VatCodeCode);
                if (_vatCode == null)
                    _vatCode = this.Provider.Common.Code.Create("VATCD");
                return _vatCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_VATCD" field.
        /// </summary>
        public String VatCodeCode
        {
            get { return this.ModifiedData.Vatcd; }
            set
            {
                if (this.ModifiedData.Vatcd != value)
                     _vatCode = null;
                this.ModifiedData.Vatcd = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_SHOW_SALES" field.
        /// </summary>
        public Byte? ShowSales
        {
            get { return this.ModifiedData.ShowSales; }
            set { this.ModifiedData.ShowSales = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_RETAIL_PRICE" field.
        /// </summary>
        public Decimal RetailPrice
        {
            get { return this.ModifiedData.RetailPrice; }
            set { this.ModifiedData.RetailPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_COST_PRICE" field.
        /// </summary>
        public Decimal CostPrice
        {
            get { return this.ModifiedData.CostPrice; }
            set { this.ModifiedData.CostPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_DEFAULT" field.
        /// </summary>
        public Byte? Default
        {
            get { return this.ModifiedData.Default; }
            set { this.ModifiedData.Default = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PL_ID" field.
        /// </summary>
        public String PlId
        {
            get { return this.ModifiedData.PlId; }
            set { this.ModifiedData.PlId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_QTY_MIN" field.
        /// </summary>
        public Int32? QtyMin
        {
            get { return this.ModifiedData.QtyMin; }
            set { this.ModifiedData.QtyMin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_QTY_MAX" field.
        /// </summary>
        public Int32? QtyMax
        {
            get { return this.ModifiedData.QtyMax; }
            set { this.ModifiedData.QtyMax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_FROM" field.
        /// </summary>
        public DateTime? ValidFrom
        {
            get { return this.ModifiedData.ValidFrom; }
            set { this.ModifiedData.ValidFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_UNTIL" field.
        /// </summary>
        public DateTime? ValidUntil
        {
            get { return this.ModifiedData.ValidUntil; }
            set { this.ModifiedData.ValidUntil = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MAIN_SESSION" field.
        /// </summary>
        public Byte? MainSession
        {
            get { return this.ModifiedData.MainSession; }
            set { this.ModifiedData.MainSession = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MAST_SESS" field.
        /// </summary>
        public Int32? MastSess
        {
            get { return this.ModifiedData.MastSess; }
            set { this.ModifiedData.MastSess = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PL_NAME" field.
        /// </summary>
        public String PlName
        {
            get { return this.ModifiedData.PlName; }
            set { this.ModifiedData.PlName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PRS_ID" field.
        /// </summary>
        public String PrsId
        {
            get { return this.ModifiedData.PrsId; }
            set { this.ModifiedData.PrsId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MEMBER" field.
        /// </summary>
        public Byte? Member
        {
            get { return this.ModifiedData.Member; }
            set { this.ModifiedData.Member = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_START_DAY" field.
        /// </summary>
        public Int32? StartDay
        {
            get { return this.ModifiedData.StartDay; }
            set { this.ModifiedData.StartDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_END_DAY" field.
        /// </summary>
        public Int32? EndDay
        {
            get { return this.ModifiedData.EndDay; }
            set { this.ModifiedData.EndDay = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_EP_ID" field.
        /// </summary>
        public LocalEventProductModel EventProduct
        {
            get
            {
                if (_eventProduct == null && this.EventProductId != null)
                    _eventProduct = this.Provider.Learning.EventProduct.FetchById(this.EventProductId.Value);
                if (_eventProduct == null)
                    _eventProduct = this.Provider.Learning.EventProduct.Create();
                
                return _eventProduct;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_EP_ID" field.
        /// </summary>
        public Int32? EventProductId
        {
            get { return this.ModifiedData.EpId; }
            set
            {
                if (this.ModifiedData.EpId != value)
                     _eventProduct = null;
                this.ModifiedData.EpId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_DATE" field.
        /// </summary>
        public Byte ValidDate
        {
            get { return this.ModifiedData.ValidDate; }
            set { this.ModifiedData.ValidDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_REGION" field.
        /// </summary>
        public LocalCodeModel RegionCode
        {
            get
            {
                if (_regionCode == null && !String.IsNullOrEmpty(this.RegionCodeCode))
                    _regionCode = this.Provider.Common.Code.FetchByTypeAndCode("ROREG", this.RegionCodeCode);
                if (_regionCode == null)
                    _regionCode = this.Provider.Common.Code.Create("ROREG");
                return _regionCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_REGION" field.
        /// </summary>
        public String RegionCodeCode
        {
            get { return this.ModifiedData.Region; }
            set
            {
                if (this.ModifiedData.Region != value)
                     _regionCode = null;
                this.ModifiedData.Region = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_CSG_ID" field.
        /// </summary>
        public Int32? CsgId
        {
            get { return this.ModifiedData.CsgId; }
            set { this.ModifiedData.CsgId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="SessionXrefModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllBySessionXrefsId(this.Id));
                
                return _elements;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSessionXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSessionXrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSessionXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSessionXrefModel(LocalProvider provider, SessionXrefRecord record) : base(provider, record)
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
            if (_vatCode != null)
            {
                _vatCode.Save();
                this.ModifiedData.Vatcd = _vatCode.Value1;
            }
            if (_regionCode != null)
            {
                _regionCode.Save();
                this.ModifiedData.Region = _regionCode.Value1;
            }
            if (_event != null)
            {
                _event.Save();
                this.ModifiedData.CourseId = _event.Id == null && this.ModifiedData.CourseId != null ? "" : _event.Id;
            }
            if (_session != null)
            {
                _session.Save();
                this.ModifiedData.ActId = _session.Id == null && this.ModifiedData.ActId != null ? "" : _session.Id;
            }
            if (_eventProduct != null)
            {
                _eventProduct.Save();
                this.ModifiedData.EpId = _eventProduct.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_elements != null)
                _elements.Execute(obj => obj.SessionXrefsId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "SXREF_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel ISessionXrefModel.Event
        {
            get { return this.Event; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_COURSE_ID" field.
        /// </summary>
        System.String ISessionXrefModel.EventId
        {
            get { return this.EventId; }
            set { this.EventId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_ACT_ID" field.
        /// </summary>
        Consensus.Learning.ISessionModel ISessionXrefModel.Session
        {
            get { return this.Session; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_ACT_ID" field.
        /// </summary>
        System.String ISessionXrefModel.SessionId
        {
            get { return this.SessionId; }
            set { this.SessionId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_REAL" field.
        /// </summary>
        System.Nullable<System.Byte> ISessionXrefModel.Real
        {
            get { return this.Real; }
            set { this.Real = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_ELEMENT" field.
        /// </summary>
        System.Nullable<System.Byte> ISessionXrefModel.Element
        {
            get { return this.Element; }
            set { this.Element = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MANDATORY" field.
        /// </summary>
        System.Nullable<System.Byte> ISessionXrefModel.Mandatory
        {
            get { return this.Mandatory; }
            set { this.Mandatory = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_INV_PRINT" field.
        /// </summary>
        System.Nullable<System.Byte> ISessionXrefModel.InvPrint
        {
            get { return this.InvPrint; }
            set { this.InvPrint = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_CURRENCY" field.
        /// </summary>
        System.String ISessionXrefModel.Currency
        {
            get { return this.Currency; }
            set { this.Currency = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PRICE" field.
        /// </summary>
        System.Decimal ISessionXrefModel.Price
        {
            get { return this.Price; }
            set { this.Price = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_BLOCK_PRICE" field.
        /// </summary>
        System.Decimal ISessionXrefModel.BlockPrice
        {
            get { return this.BlockPrice; }
            set { this.BlockPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_VATCD" field.
        /// </summary>
        Consensus.Common.ICodeModel ISessionXrefModel.VatCode
        {
            get { return this.VatCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_VATCD" field.
        /// </summary>
        System.String ISessionXrefModel.VatCodeCode
        {
            get { return this.VatCodeCode; }
            set { this.VatCodeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_SHOW_SALES" field.
        /// </summary>
        System.Nullable<System.Byte> ISessionXrefModel.ShowSales
        {
            get { return this.ShowSales; }
            set { this.ShowSales = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_RETAIL_PRICE" field.
        /// </summary>
        System.Decimal ISessionXrefModel.RetailPrice
        {
            get { return this.RetailPrice; }
            set { this.RetailPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_COST_PRICE" field.
        /// </summary>
        System.Decimal ISessionXrefModel.CostPrice
        {
            get { return this.CostPrice; }
            set { this.CostPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_DEFAULT" field.
        /// </summary>
        System.Nullable<System.Byte> ISessionXrefModel.Default
        {
            get { return this.Default; }
            set { this.Default = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PL_ID" field.
        /// </summary>
        System.String ISessionXrefModel.PlId
        {
            get { return this.PlId; }
            set { this.PlId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_QTY_MIN" field.
        /// </summary>
        System.Nullable<System.Int32> ISessionXrefModel.QtyMin
        {
            get { return this.QtyMin; }
            set { this.QtyMin = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_QTY_MAX" field.
        /// </summary>
        System.Nullable<System.Int32> ISessionXrefModel.QtyMax
        {
            get { return this.QtyMax; }
            set { this.QtyMax = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_FROM" field.
        /// </summary>
        System.Nullable<System.DateTime> ISessionXrefModel.ValidFrom
        {
            get { return this.ValidFrom; }
            set { this.ValidFrom = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_UNTIL" field.
        /// </summary>
        System.Nullable<System.DateTime> ISessionXrefModel.ValidUntil
        {
            get { return this.ValidUntil; }
            set { this.ValidUntil = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MAIN_SESSION" field.
        /// </summary>
        System.Nullable<System.Byte> ISessionXrefModel.MainSession
        {
            get { return this.MainSession; }
            set { this.MainSession = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MAST_SESS" field.
        /// </summary>
        System.Nullable<System.Int32> ISessionXrefModel.MastSess
        {
            get { return this.MastSess; }
            set { this.MastSess = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PL_NAME" field.
        /// </summary>
        System.String ISessionXrefModel.PlName
        {
            get { return this.PlName; }
            set { this.PlName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PRS_ID" field.
        /// </summary>
        System.String ISessionXrefModel.PrsId
        {
            get { return this.PrsId; }
            set { this.PrsId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MEMBER" field.
        /// </summary>
        System.Nullable<System.Byte> ISessionXrefModel.Member
        {
            get { return this.Member; }
            set { this.Member = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_START_DAY" field.
        /// </summary>
        System.Nullable<System.Int32> ISessionXrefModel.StartDay
        {
            get { return this.StartDay; }
            set { this.StartDay = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_END_DAY" field.
        /// </summary>
        System.Nullable<System.Int32> ISessionXrefModel.EndDay
        {
            get { return this.EndDay; }
            set { this.EndDay = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_EP_ID" field.
        /// </summary>
        Consensus.Learning.IEventProductModel ISessionXrefModel.EventProduct
        {
            get { return this.EventProduct; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_EP_ID" field.
        /// </summary>
        System.Nullable<System.Int32> ISessionXrefModel.EventProductId
        {
            get { return this.EventProductId; }
            set { this.EventProductId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_DATE" field.
        /// </summary>
        System.Byte ISessionXrefModel.ValidDate
        {
            get { return this.ValidDate; }
            set { this.ValidDate = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel ISessionXrefModel.RegionCode
        {
            get { return this.RegionCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_REGION" field.
        /// </summary>
        System.String ISessionXrefModel.RegionCodeCode
        {
            get { return this.RegionCodeCode; }
            set { this.RegionCodeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_CSG_ID" field.
        /// </summary>
        System.Nullable<System.Int32> ISessionXrefModel.CsgId
        {
            get { return this.CsgId; }
            set { this.CsgId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:SessionXrefModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> ISessionXrefModel.Elements
        {
            get { return this.Elements; }
        }

        #endregion
    }
}
