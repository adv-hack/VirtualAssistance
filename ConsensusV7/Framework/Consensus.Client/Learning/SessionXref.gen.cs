using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SessionXref : Proxy<ISessionXrefModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Event" /> member.
        /// </summary>
        private Consensus.Learning.Event _event;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Session" /> member.
        /// </summary>
        private Consensus.Learning.Session _session;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="VatCode" /> member.
        /// </summary>
        private Consensus.Common.Code _vatCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="EventProduct" /> member.
        /// </summary>
        private Consensus.Learning.EventProduct _eventProduct;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RegionCode" /> member.
        /// </summary>
        private Consensus.Common.Code _regionCode;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "SXREF_COURSE_ID" field.
        /// </summary>
        public Consensus.Learning.Event Event
        {
            get
            {
                if (_event == null && this.Model.Event != null)
                    _event = new Consensus.Learning.Event(this.Model.Event);
                if (_event == null)
                    _event = Consensus.Learning.Event.Create();
                return _event;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_COURSE_ID" field.
        /// </summary>
        public System.String EventId
        {
            get { return this.Model.EventId; }
            set { this.Model.EventId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_ACT_ID" field.
        /// </summary>
        public Consensus.Learning.Session Session
        {
            get
            {
                if (_session == null && this.Model.Session != null)
                    _session = new Consensus.Learning.Session(this.Model.Session);
                if (_session == null)
                    _session = Consensus.Learning.Session.Create();
                return _session;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_ACT_ID" field.
        /// </summary>
        public System.String SessionId
        {
            get { return this.Model.SessionId; }
            set { this.Model.SessionId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_REAL" field.
        /// </summary>
        public System.Nullable<System.Byte> Real
        {
            get { return this.Model.Real; }
            set { this.Model.Real = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_ELEMENT" field.
        /// </summary>
        public System.Nullable<System.Byte> Element
        {
            get { return this.Model.Element; }
            set { this.Model.Element = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MANDATORY" field.
        /// </summary>
        public System.Nullable<System.Byte> Mandatory
        {
            get { return this.Model.Mandatory; }
            set { this.Model.Mandatory = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_INV_PRINT" field.
        /// </summary>
        public System.Nullable<System.Byte> InvPrint
        {
            get { return this.Model.InvPrint; }
            set { this.Model.InvPrint = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_CURRENCY" field.
        /// </summary>
        public System.String Currency
        {
            get { return this.Model.Currency; }
            set { this.Model.Currency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PRICE" field.
        /// </summary>
        public System.Decimal Price
        {
            get { return this.Model.Price; }
            set { this.Model.Price = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_BLOCK_PRICE" field.
        /// </summary>
        public System.Decimal BlockPrice
        {
            get { return this.Model.BlockPrice; }
            set { this.Model.BlockPrice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_VATCD" field.
        /// </summary>
        public Consensus.Common.Code VatCode
        {
            get
            {
                if (_vatCode == null && this.Model.VatCode != null)
                    _vatCode = new Consensus.Common.Code(this.Model.VatCode);
                if (_vatCode == null)
                    _vatCode = Consensus.Common.Code.Create();
                return _vatCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_VATCD" field.
        /// </summary>
        public System.String VatCodeCode
        {
            get { return this.Model.VatCodeCode; }
            set { this.Model.VatCodeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_SHOW_SALES" field.
        /// </summary>
        public System.Nullable<System.Byte> ShowSales
        {
            get { return this.Model.ShowSales; }
            set { this.Model.ShowSales = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_RETAIL_PRICE" field.
        /// </summary>
        public System.Decimal RetailPrice
        {
            get { return this.Model.RetailPrice; }
            set { this.Model.RetailPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_COST_PRICE" field.
        /// </summary>
        public System.Decimal CostPrice
        {
            get { return this.Model.CostPrice; }
            set { this.Model.CostPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_DEFAULT" field.
        /// </summary>
        public System.Nullable<System.Byte> Default
        {
            get { return this.Model.Default; }
            set { this.Model.Default = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PL_ID" field.
        /// </summary>
        public System.String PlId
        {
            get { return this.Model.PlId; }
            set { this.Model.PlId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_QTY_MIN" field.
        /// </summary>
        public System.Nullable<System.Int32> QtyMin
        {
            get { return this.Model.QtyMin; }
            set { this.Model.QtyMin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_QTY_MAX" field.
        /// </summary>
        public System.Nullable<System.Int32> QtyMax
        {
            get { return this.Model.QtyMax; }
            set { this.Model.QtyMax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_FROM" field.
        /// </summary>
        public System.Nullable<System.DateTime> ValidFrom
        {
            get { return this.Model.ValidFrom; }
            set { this.Model.ValidFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_UNTIL" field.
        /// </summary>
        public System.Nullable<System.DateTime> ValidUntil
        {
            get { return this.Model.ValidUntil; }
            set { this.Model.ValidUntil = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MAIN_SESSION" field.
        /// </summary>
        public System.Nullable<System.Byte> MainSession
        {
            get { return this.Model.MainSession; }
            set { this.Model.MainSession = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MAST_SESS" field.
        /// </summary>
        public System.Nullable<System.Int32> MastSess
        {
            get { return this.Model.MastSess; }
            set { this.Model.MastSess = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PL_NAME" field.
        /// </summary>
        public System.String PlName
        {
            get { return this.Model.PlName; }
            set { this.Model.PlName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PRS_ID" field.
        /// </summary>
        public System.String PrsId
        {
            get { return this.Model.PrsId; }
            set { this.Model.PrsId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MEMBER" field.
        /// </summary>
        public System.Nullable<System.Byte> Member
        {
            get { return this.Model.Member; }
            set { this.Model.Member = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_START_DAY" field.
        /// </summary>
        public System.Nullable<System.Int32> StartDay
        {
            get { return this.Model.StartDay; }
            set { this.Model.StartDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_END_DAY" field.
        /// </summary>
        public System.Nullable<System.Int32> EndDay
        {
            get { return this.Model.EndDay; }
            set { this.Model.EndDay = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_EP_ID" field.
        /// </summary>
        public Consensus.Learning.EventProduct EventProduct
        {
            get
            {
                if (_eventProduct == null && this.Model.EventProduct != null)
                    _eventProduct = new Consensus.Learning.EventProduct(this.Model.EventProduct);
                if (_eventProduct == null)
                    _eventProduct = Consensus.Learning.EventProduct.Create();
                return _eventProduct;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_EP_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> EventProductId
        {
            get { return this.Model.EventProductId; }
            set { this.Model.EventProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_DATE" field.
        /// </summary>
        public System.Byte ValidDate
        {
            get { return this.Model.ValidDate; }
            set { this.Model.ValidDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_REGION" field.
        /// </summary>
        public Consensus.Common.Code RegionCode
        {
            get
            {
                if (_regionCode == null && this.Model.RegionCode != null)
                    _regionCode = new Consensus.Common.Code(this.Model.RegionCode);
                if (_regionCode == null)
                    _regionCode = Consensus.Common.Code.Create();
                return _regionCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_REGION" field.
        /// </summary>
        public System.String RegionCodeCode
        {
            get { return this.Model.RegionCodeCode; }
            set { this.Model.RegionCodeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_CSG_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> CsgId
        {
            get { return this.Model.CsgId; }
            set { this.Model.CsgId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:SessionXrefModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Element> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel>(this.Model.Elements, model => new Consensus.Learning.Element(model));
                return _elements;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SessionXref(ISessionXrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SessionXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SessionXrefModel" /> instance.
        /// </returns>
        public static Consensus.Learning.SessionXref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SessionXref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SessionXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SessionXrefModel" /> instance.
        /// </returns>
        public static Consensus.Learning.SessionXref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ISessionXrefModel model = provider.Learning.SessionXref.Create();
            return model == null ? null : new Consensus.Learning.SessionXref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SessionXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SessionXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.SessionXref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SessionXref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SessionXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SessionXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.SessionXref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionXrefModel> collection = provider.Learning.SessionXref.FetchAll();
            return collection.Select(model => new Consensus.Learning.SessionXref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SessionXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SessionXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.SessionXref FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SessionXref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SessionXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SessionXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.SessionXref FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ISessionXrefModel model = provider.Learning.SessionXref.FetchById(id);
            return model == null ? null : new Consensus.Learning.SessionXref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SessionXref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.SessionXref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionXrefModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:SessionXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.SessionXref> FetchAllByEventId(System.String eventId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SessionXref.FetchAllByEventId(site,eventId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionXrefModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:SessionXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.SessionXref> FetchAllByEventId(ConsensusSite site, System.String eventId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionXrefModel> collection = provider.Learning.SessionXref.FetchAllByEventId(eventId);
            return collection.Select(model => new Consensus.Learning.SessionXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionXrefModel" /> instances.
        /// </summary>
        /// <param name="sessionId">
        ///     The value which identifies the <see cref="!:SessionXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instances that match the specified <paramref name="sessionId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.SessionXref> FetchAllBySessionId(System.String sessionId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SessionXref.FetchAllBySessionId(site,sessionId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionXrefModel" /> instances.
        /// </summary>
        /// <param name="sessionId">
        ///     The value which identifies the <see cref="!:SessionXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instances that match the specified <paramref name="sessionId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.SessionXref> FetchAllBySessionId(ConsensusSite site, System.String sessionId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionXrefModel> collection = provider.Learning.SessionXref.FetchAllBySessionId(sessionId);
            return collection.Select(model => new Consensus.Learning.SessionXref(model));
        }

        public static IEnumerable<Consensus.Learning.SessionXref> FetchAllByEventProductId(System.Nullable<System.Int32> eventProductId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SessionXref.FetchAllByEventProductId(site,eventProductId);
        }

        public static IEnumerable<Consensus.Learning.SessionXref> FetchAllByEventProductId(ConsensusSite site, System.Nullable<System.Int32> eventProductId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ISessionXrefModel> collection = provider.Learning.SessionXref.FetchAllByEventProductId(eventProductId);
            return collection.Select(model => new Consensus.Learning.SessionXref(model));
        }

        #endregion
    }
}
