using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PayscheduleheaderRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPayscheduleheaderModel : LocalModel<PayscheduleheaderRecord, Int32>, IPayscheduleheaderModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="PayscheduleheaderModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _product;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="PayscheduleheaderModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _events;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="PayscheduleheaderModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PayscheduleheaderRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.Payscheduleheader.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PayscheduleheaderRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.Payscheduleheader.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PayscheduleheaderRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.Payscheduleheader.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSH_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="PayscheduleheaderModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> Product
        {
            get
            {
                if (_product == null)
                    _product = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByPaymentScheduleId(this.Id));
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="PayscheduleheaderModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> Events
        {
            get
            {
                if (_events == null)
                    _events = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByPayScheduleHeaderId(this.Id));
                
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="PayscheduleheaderModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllByPaymentScheduleId(this.Id));
                
                return _elements;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPayscheduleheaderModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPayscheduleheaderModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPayscheduleheaderModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPayscheduleheaderModel(LocalProvider provider, PayscheduleheaderRecord record) : base(provider, record)
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
                _product.Execute(obj => obj.PaymentScheduleId = this.Id).Execute(obj => obj.Save());
            if (_events != null)
                _events.Execute(obj => obj.PayScheduleHeaderId = this.Id).Execute(obj => obj.Save());
            if (_elements != null)
                _elements.Execute(obj => obj.PaymentScheduleId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "PSH_DESCRIPTION" field.
        /// </summary>
        System.String IPayscheduleheaderModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:PayscheduleheaderModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IPayscheduleheaderModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:PayscheduleheaderModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IPayscheduleheaderModel.Events
        {
            get { return this.Events; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:PayscheduleheaderModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> IPayscheduleheaderModel.Elements
        {
            get { return this.Elements; }
        }

        #endregion
    }
}
