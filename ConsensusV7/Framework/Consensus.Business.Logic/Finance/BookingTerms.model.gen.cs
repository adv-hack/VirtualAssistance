using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="BookingTermsRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBookingTermsModel : LocalModel<BookingTermsRecord, String>, IBookingTermsModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="BookingTermsModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _product;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="BookingTermsModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _events;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="BookingTermsModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BookingTermsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.BookingTerms.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BookingTermsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.BookingTerms.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<BookingTermsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.BookingTerms.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BKT_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="BookingTermsModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> Product
        {
            get
            {
                if (_product == null)
                    _product = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByBookingTermsId(this.Id));
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="BookingTermsModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> Events
        {
            get
            {
                if (_events == null)
                    _events = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByBookingTermsId(this.Id));
                
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="BookingTermsModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllByBookingTermId(this.Id));
                
                return _elements;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalBookingTermsModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalBookingTermsModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalBookingTermsModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalBookingTermsModel(LocalProvider provider, BookingTermsRecord record) : base(provider, record)
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
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_product != null)
                _product.Execute(obj => obj.BookingTermsId = this.Id).Execute(obj => obj.Save());
            if (_events != null)
                _events.Execute(obj => obj.BookingTermsId = this.Id).Execute(obj => obj.Save());
            if (_elements != null)
                _elements.Execute(obj => obj.BookingTermId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "BKT_DESCRIPTION" field.
        /// </summary>
        System.String IBookingTermsModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:BookingTermsModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IBookingTermsModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:BookingTermsModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IBookingTermsModel.Events
        {
            get { return this.Events; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:BookingTermsModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> IBookingTermsModel.Elements
        {
            get { return this.Elements; }
        }

        #endregion
    }
}
