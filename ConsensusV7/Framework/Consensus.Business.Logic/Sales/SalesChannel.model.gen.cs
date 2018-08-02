using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Sales
{
    /// <summary>
    ///     Encapsulates the <see cref="SalesChannelRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSalesChannelModel : LocalModel<SalesChannelRecord, String>, ISalesChannelModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="RelatedProductModel" /> instances that reference this <see cref="SalesChannelModel" />.
        /// </summary>
        private LocalCollection<LocalRelatedProductModel, IRelatedProductModel> _relatedProducts;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="SalesChannelModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SalesChannelRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Sales.SalesChannel.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SalesChannelRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Sales.SalesChannel.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SalesChannelRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Sales.SalesChannel.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SCHN_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="RelatedProductModel" /> instances that reference this <see cref="SalesChannelModel" />.
        /// </summary>
        public LocalCollection<LocalRelatedProductModel, IRelatedProductModel> RelatedProducts
        {
            get
            {
                if (_relatedProducts == null)
                    _relatedProducts = new LocalCollection<LocalRelatedProductModel, IRelatedProductModel>(this.Provider.Learning.RelatedProduct.FetchAllBySalesChannelId(this.Id));
                
                return _relatedProducts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="SalesChannelModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllBySalesChannelId(this.Id));
                
                return _bookings;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSalesChannelModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSalesChannelModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSalesChannelModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSalesChannelModel(LocalProvider provider, SalesChannelRecord record) : base(provider, record)
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
            if (_relatedProducts != null)
                _relatedProducts.Execute(obj => obj.SalesChannelId = this.Id).Execute(obj => obj.Save());
            if (_bookings != null)
                _bookings.Execute(obj => obj.SalesChannelId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "SCHN_NAME" field.
        /// </summary>
        System.String ISalesChannelModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RelatedProductModel" /> instances that reference this <see cref="!:SalesChannelModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IRelatedProductModel> ISalesChannelModel.RelatedProducts
        {
            get { return this.RelatedProducts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:SalesChannelModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> ISalesChannelModel.Bookings
        {
            get { return this.Bookings; }
        }

        #endregion
    }
}
