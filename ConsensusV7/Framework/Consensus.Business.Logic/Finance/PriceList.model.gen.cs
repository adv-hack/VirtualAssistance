using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PriceListRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPriceListModel : LocalModel<PriceListRecord, String>, IPriceListModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="PriceListModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="PriceListModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        /// <summary>
        ///     The collection of <see cref="PriceModel" /> instances that reference this <see cref="PriceListModel" />.
        /// </summary>
        private LocalCollection<LocalPriceModel, IPriceModel> _prices;

        /// <summary>
        ///     The collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="PriceListModel" />.
        /// </summary>
        private LocalCollection<LocalMemberLocationModel, IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PriceListRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.PriceList.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PriceListRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.PriceList.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PriceListRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.PriceList.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return this.ModifiedData.Currency; }
            set { this.ModifiedData.Currency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VALID_FROM" field.
        /// </summary>
        public DateTime? ValidFrom
        {
            get { return this.ModifiedData.ValidFrom; }
            set { this.ModifiedData.ValidFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VALID_UNTIL" field.
        /// </summary>
        public DateTime? ValidUntil
        {
            get { return this.ModifiedData.ValidUntil; }
            set { this.ModifiedData.ValidUntil = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_ORG_ONLY" field.
        /// </summary>
        public Byte? OrgOnly
        {
            get { return this.ModifiedData.OrgOnly; }
            set { this.ModifiedData.OrgOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_STATUS" field.
        /// </summary>
        public Byte? Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VAT_CODE" field.
        /// </summary>
        public String VatCode
        {
            get { return this.ModifiedData.VatCode; }
            set { this.ModifiedData.VatCode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="PriceListModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByPriceListId(this.Id));
                
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllByPriceListId(this.Id));
                
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PriceModel" /> instances that reference this <see cref="PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPriceModel, IPriceModel> Prices
        {
            get
            {
                if (_prices == null)
                    _prices = new LocalCollection<LocalPriceModel, IPriceModel>(this.Provider.Finance.Price.FetchAllByPriceListId(this.Id));
                
                return _prices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalMemberLocationModel, IMemberLocationModel> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new LocalCollection<LocalMemberLocationModel, IMemberLocationModel>(this.Provider.Membership.MemberLocation.FetchAllByPlIdId(this.Id));
                
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPriceListModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPriceListModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPriceListModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPriceListModel(LocalProvider provider, PriceListRecord record) : base(provider, record)
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
            if (_bookings != null)
                _bookings.Execute(obj => obj.PriceListId = this.Id).Execute(obj => obj.Save());
            if (_elements != null)
                _elements.Execute(obj => obj.PriceListId = this.Id).Execute(obj => obj.Save());
            if (_prices != null)
                _prices.Execute(obj => obj.PriceListId = this.Id).Execute(obj => obj.Save());
            if (_memberLocations != null)
                _memberLocations.Execute(obj => obj.PlIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "PL_CURRENCY" field.
        /// </summary>
        System.String IPriceListModel.Currency
        {
            get { return this.Currency; }
            set { this.Currency = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_NAME" field.
        /// </summary>
        System.String IPriceListModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VALID_FROM" field.
        /// </summary>
        System.Nullable<System.DateTime> IPriceListModel.ValidFrom
        {
            get { return this.ValidFrom; }
            set { this.ValidFrom = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VALID_UNTIL" field.
        /// </summary>
        System.Nullable<System.DateTime> IPriceListModel.ValidUntil
        {
            get { return this.ValidUntil; }
            set { this.ValidUntil = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_ORG_ONLY" field.
        /// </summary>
        System.Nullable<System.Byte> IPriceListModel.OrgOnly
        {
            get { return this.OrgOnly; }
            set { this.OrgOnly = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> IPriceListModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VAT_CODE" field.
        /// </summary>
        System.String IPriceListModel.VatCode
        {
            get { return this.VatCode; }
            set { this.VatCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> IPriceListModel.Bookings
        {
            get { return this.Bookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IElementModel> IPriceListModel.Elements
        {
            get { return this.Elements; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PriceModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPriceModel> IPriceListModel.Prices
        {
            get { return this.Prices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> IPriceListModel.MemberLocations
        {
            get { return this.MemberLocations; }
        }

        #endregion
    }
}
