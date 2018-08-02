using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ICalMessageType : Proxy<IICalMessageTypeModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ICalendarMessages" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.ICalMessage, Consensus.Document.IICalMessageModel> _iCalendarMessages;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "ICMT_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICMT_VIEW" field.
        /// </summary>
        public System.String View
        {
            get { return this.Model.View; }
            set { this.Model.View = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICMT_PROC" field.
        /// </summary>
        public System.String Proc
        {
            get { return this.Model.Proc; }
            set { this.Model.Proc = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ICalMessageModel" /> instances that reference this <see cref="!:ICalMessageTypeModel" />.
        /// </summary>
        public Collection<Consensus.Document.ICalMessage> ICalendarMessages
        {
            get
            {
                if (_iCalendarMessages == null)
                    _iCalendarMessages = new ProxyCollection<Consensus.Document.ICalMessage, Consensus.Document.IICalMessageModel>(this.Model.ICalendarMessages, model => new Consensus.Document.ICalMessage(model));
                return _iCalendarMessages;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ICalMessageType(IICalMessageTypeModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ICalMessageTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ICalMessageTypeModel" /> instance.
        /// </returns>
        public static Consensus.Document.ICalMessageType Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessageType.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ICalMessageTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ICalMessageTypeModel" /> instance.
        /// </returns>
        public static Consensus.Document.ICalMessageType Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IICalMessageTypeModel model = provider.Document.ICalMessageType.Create();
            return model == null ? null : new Consensus.Document.ICalMessageType(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ICalMessageTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ICalMessageTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.ICalMessageType> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessageType.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ICalMessageTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ICalMessageTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.ICalMessageType> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IICalMessageTypeModel> collection = provider.Document.ICalMessageType.FetchAll();
            return collection.Select(model => new Consensus.Document.ICalMessageType(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ICalMessageTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ICalMessageTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.ICalMessageType FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessageType.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ICalMessageTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ICalMessageTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.ICalMessageType FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IICalMessageTypeModel model = provider.Document.ICalMessageType.FetchById(id);
            return model == null ? null : new Consensus.Document.ICalMessageType(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessageType.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.ICalMessageType.GetTableName();
        }

        #endregion
    }
}
