using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PriceList : Proxy<IPriceListModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Bookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _bookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Prices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Price, Consensus.Finance.IPriceModel> _prices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberLocations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PL_CURRENCY" field.
        /// </summary>
        public System.String Currency
        {
            get { return this.Model.Currency; }
            set { this.Model.Currency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VALID_FROM" field.
        /// </summary>
        public System.Nullable<System.DateTime> ValidFrom
        {
            get { return this.Model.ValidFrom; }
            set { this.Model.ValidFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VALID_UNTIL" field.
        /// </summary>
        public System.Nullable<System.DateTime> ValidUntil
        {
            get { return this.Model.ValidUntil; }
            set { this.Model.ValidUntil = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_ORG_ONLY" field.
        /// </summary>
        public System.Nullable<System.Byte> OrgOnly
        {
            get { return this.Model.OrgOnly; }
            set { this.Model.OrgOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_STATUS" field.
        /// </summary>
        public System.Nullable<System.Byte> Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PL_VAT_CODE" field.
        /// </summary>
        public System.String VatCode
        {
            get { return this.Model.VatCode; }
            set { this.Model.VatCode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Booking> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel>(this.Model.Bookings, model => new Consensus.Learning.Booking(model));
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Element> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel>(this.Model.Elements, model => new Consensus.Learning.Element(model));
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PriceModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Finance.Price> Prices
        {
            get
            {
                if (_prices == null)
                    _prices = new ProxyCollection<Consensus.Finance.Price, Consensus.Finance.IPriceModel>(this.Model.Prices, model => new Consensus.Finance.Price(model));
                return _prices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:PriceListModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Membership.MemberLocation> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel>(this.Model.MemberLocations, model => new Consensus.Membership.MemberLocation(model));
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PriceList(IPriceListModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.IPriceListModel" /> instances, that are referenced by the valid prices recorded against a given product.
        /// </summary>
        /// <param name="productId">
        ///     The unique identifier for the product whoses prices are inspected.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.IPriceListModel" /> that are referenced by the valid prices recorded against the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PriceList> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PriceList.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.IPriceListModel" /> instances, that are referenced by the valid prices recorded against a given product.
        /// </summary>
        /// <param name="productId">
        ///     The unique identifier for the product whoses prices are inspected.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.IPriceListModel" /> that are referenced by the valid prices recorded against the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PriceList> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPriceListModel> collection = provider.Finance.PriceList.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Finance.PriceList(model));
        }

        /// <summary>
        ///     Creates a new <see cref="!:PriceListModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PriceListModel" /> instance.
        /// </returns>
        public static Consensus.Finance.PriceList Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PriceList.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PriceListModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PriceListModel" /> instance.
        /// </returns>
        public static Consensus.Finance.PriceList Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPriceListModel model = provider.Finance.PriceList.Create();
            return model == null ? null : new Consensus.Finance.PriceList(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PriceListModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PriceListModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PriceList> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PriceList.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PriceListModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PriceListModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PriceList> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPriceListModel> collection = provider.Finance.PriceList.FetchAll();
            return collection.Select(model => new Consensus.Finance.PriceList(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceListModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PriceListModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceListModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.PriceList FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PriceList.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceListModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PriceListModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceListModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.PriceList FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPriceListModel model = provider.Finance.PriceList.FetchById(id);
            return model == null ? null : new Consensus.Finance.PriceList(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PriceList.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.PriceList.GetTableName();
        }

        #endregion
    }
}
