using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="EventProductRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalEventProductModel : LocalModel<EventProductRecord, Int32>, IEventProductModel
    {
        #region fields

        /// <summary>
        ///     The value of the "EP_COURSE_ID" field.
        /// </summary>
        private LocalEventModel _event;

        /// <summary>
        ///     The value of the "EP_PROD_ID" field.
        /// </summary>
        private LocalProductModel _product;

        /// <summary>
        ///     The value of the "EP_NOTES" field.
        /// </summary>
        private LocalNotesModel _notes;

        /// <summary>
        ///     The collection of <see cref="SessionXrefModel" /> instances that reference this <see cref="EventProductModel" />.
        /// </summary>
        private LocalCollection<LocalSessionXrefModel, ISessionXrefModel> _ePSessionXref;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<EventProductRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.EventProduct.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<EventProductRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.EventProduct.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<EventProductRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.EventProduct.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "EP_COURSE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "EP_COURSE_ID" field.
        /// </summary>
        public String EventId
        {
            get { return this.ModifiedData.EventId; }
            set
            {
                if (this.ModifiedData.EventId != value)
                     _event = null;
                this.ModifiedData.EventId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "EP_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "EP_PROD_ID" field.
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
        ///     Gets the The value of the "EP_NOTES" field.
        /// </summary>
        public LocalNotesModel Notes
        {
            get
            {
                if (_notes == null && this.NotesId != null)
                    _notes = this.Provider.Common.Notes.FetchById(this.NotesId);
                if (_notes == null)
                    _notes = this.Provider.Common.Notes.Create();
                
                return _notes;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "EP_NOTES" field.
        /// </summary>
        public String NotesId
        {
            get { return this.ModifiedData.Notes; }
            set
            {
                if (this.ModifiedData.Notes != value)
                     _notes = null;
                this.ModifiedData.Notes = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_QTY" field.
        /// </summary>
        public Int32? Qty
        {
            get { return this.ModifiedData.Qty; }
            set { this.ModifiedData.Qty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_DELEGATE_QTY" field.
        /// </summary>
        public Int32? DelegateQty
        {
            get { return this.ModifiedData.DelegateQty; }
            set { this.ModifiedData.DelegateQty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_PREDELIV" field.
        /// </summary>
        public Byte Predeliv
        {
            get { return this.ModifiedData.Predeliv; }
            set { this.ModifiedData.Predeliv = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SessionXrefModel" /> instances that reference this <see cref="EventProductModel" />.
        /// </summary>
        public LocalCollection<LocalSessionXrefModel, ISessionXrefModel> EPSessionXref
        {
            get
            {
                if (_ePSessionXref == null)
                    _ePSessionXref = new LocalCollection<LocalSessionXrefModel, ISessionXrefModel>(this.Provider.Learning.SessionXref.FetchAllByEventProductId(this.Id));
                
                return _ePSessionXref;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalEventProductModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalEventProductModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalEventProductModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalEventProductModel(LocalProvider provider, EventProductRecord record) : base(provider, record)
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
            if (_event != null)
            {
                _event.Save();
                this.ModifiedData.EventId = _event.Id == null && this.ModifiedData.EventId != null ? "" : _event.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProdId = _product.Id == null && this.ModifiedData.ProdId != null ? "" : _product.Id;
            }
            if (_notes != null)
            {
                _notes.Save();
                this.ModifiedData.Notes = _notes.Id == null && this.ModifiedData.Notes != null ? "" : _notes.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_ePSessionXref != null)
                _ePSessionXref.Execute(obj => obj.EventProductId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        Consensus.Learning.ISessionXrefModel IEventProductModel.SessionXrefMaster
        {
            get { return this.SessionXrefMaster; }
        }

        System.Boolean IEventProductModel.IsModified
        {
            get { return this.IsModified; }
        }

        /// <summary>
        ///     Gets the The value of the "EP_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel IEventProductModel.Event
        {
            get { return this.Event; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "EP_COURSE_ID" field.
        /// </summary>
        System.String IEventProductModel.EventId
        {
            get { return this.EventId; }
            set { this.EventId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "EP_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IEventProductModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "EP_PROD_ID" field.
        /// </summary>
        System.String IEventProductModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "EP_NOTES" field.
        /// </summary>
        Consensus.Common.INotesModel IEventProductModel.Notes
        {
            get { return this.Notes; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "EP_NOTES" field.
        /// </summary>
        System.String IEventProductModel.NotesId
        {
            get { return this.NotesId; }
            set { this.NotesId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_QTY" field.
        /// </summary>
        System.Nullable<System.Int32> IEventProductModel.Qty
        {
            get { return this.Qty; }
            set { this.Qty = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_DELEGATE_QTY" field.
        /// </summary>
        System.Nullable<System.Int32> IEventProductModel.DelegateQty
        {
            get { return this.DelegateQty; }
            set { this.DelegateQty = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_PREDELIV" field.
        /// </summary>
        System.Byte IEventProductModel.Predeliv
        {
            get { return this.Predeliv; }
            set { this.Predeliv = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionXrefModel" /> instances that reference this <see cref="!:EventProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionXrefModel> IEventProductModel.EPSessionXref
        {
            get { return this.EPSessionXref; }
        }

        #endregion
    }
}
