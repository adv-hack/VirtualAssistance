using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Giftaid : Proxy<IGiftaidModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PnId" /> member.
        /// </summary>
        private Consensus.Contact.Person _pnId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "GIF_ACTIVE" field.
        /// </summary>
        public System.Boolean Active
        {
            get { return this.Model.Active; }
            set { this.Model.Active = value; }
        }

        /// <summary>
        ///     Gets the The value of the "GIF_PN_ID" field.
        /// </summary>
        public Consensus.Contact.Person PnId
        {
            get
            {
                if (_pnId == null && this.Model.PnId != null)
                    _pnId = new Consensus.Contact.Person(this.Model.PnId);
                if (_pnId == null)
                    _pnId = Consensus.Contact.Person.Create();
                return _pnId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GIF_PN_ID" field.
        /// </summary>
        public System.String PnIdId
        {
            get { return this.Model.PnIdId; }
            set { this.Model.PnIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "GIF_TYPE" field.
        /// </summary>
        public Consensus.Common.Code Type
        {
            get
            {
                if (_type == null && this.Model.Type != null)
                    _type = new Consensus.Common.Code(this.Model.Type);
                if (_type == null)
                    _type = Consensus.Common.Code.Create();
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GIF_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_COMMUNICATION" field.
        /// </summary>
        public System.Byte Communication
        {
            get { return this.Model.Communication; }
            set { this.Model.Communication = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_FIRST_NAME" field.
        /// </summary>
        public System.String FirstName
        {
            get { return this.Model.FirstName; }
            set { this.Model.FirstName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_SURNAME" field.
        /// </summary>
        public System.String Surname
        {
            get { return this.Model.Surname; }
            set { this.Model.Surname = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Giftaid(IGiftaidModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:GiftaidModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GiftaidModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Giftaid Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaid.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:GiftaidModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GiftaidModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Giftaid Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IGiftaidModel model = provider.Contact.Giftaid.Create();
            return model == null ? null : new Consensus.Contact.Giftaid(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GiftaidModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GiftaidModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Giftaid> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaid.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GiftaidModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GiftaidModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Giftaid> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IGiftaidModel> collection = provider.Contact.Giftaid.FetchAll();
            return collection.Select(model => new Consensus.Contact.Giftaid(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GiftaidModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GiftaidModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Giftaid FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaid.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GiftaidModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GiftaidModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Giftaid FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IGiftaidModel model = provider.Contact.Giftaid.FetchById(id);
            return model == null ? null : new Consensus.Contact.Giftaid(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaid.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Giftaid.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidModel" /> instances.
        /// </summary>
        /// <param name="pnIdId">
        ///     The value which identifies the <see cref="!:GiftaidModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidModel" /> instances that match the specified <paramref name="pnIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Giftaid> FetchAllByPnIdId(System.String pnIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Giftaid.FetchAllByPnIdId(site,pnIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidModel" /> instances.
        /// </summary>
        /// <param name="pnIdId">
        ///     The value which identifies the <see cref="!:GiftaidModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidModel" /> instances that match the specified <paramref name="pnIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Giftaid> FetchAllByPnIdId(ConsensusSite site, System.String pnIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IGiftaidModel> collection = provider.Contact.Giftaid.FetchAllByPnIdId(pnIdId);
            return collection.Select(model => new Consensus.Contact.Giftaid(model));
        }

        #endregion
    }
}
