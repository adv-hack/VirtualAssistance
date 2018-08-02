using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SmsType : Proxy<ISmsTypeModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SmsMessages" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.SmsMessage, Consensus.Document.ISmsMessageModel> _smsMessages;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "SMT_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMT_VIEW" field.
        /// </summary>
        public System.String View
        {
            get { return this.Model.View; }
            set { this.Model.View = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMT_STORED_PROC" field.
        /// </summary>
        public System.String StoredProc
        {
            get { return this.Model.StoredProc; }
            set { this.Model.StoredProc = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SmsMessageModel" /> instances that reference this <see cref="!:SmsTypeModel" />.
        /// </summary>
        public Collection<Consensus.Document.SmsMessage> SmsMessages
        {
            get
            {
                if (_smsMessages == null)
                    _smsMessages = new ProxyCollection<Consensus.Document.SmsMessage, Consensus.Document.ISmsMessageModel>(this.Model.SmsMessages, model => new Consensus.Document.SmsMessage(model));
                return _smsMessages;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SmsType(ISmsTypeModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SmsTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SmsTypeModel" /> instance.
        /// </returns>
        public static Consensus.Document.SmsType Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsType.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SmsTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SmsTypeModel" /> instance.
        /// </returns>
        public static Consensus.Document.SmsType Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.ISmsTypeModel model = provider.Document.SmsType.Create();
            return model == null ? null : new Consensus.Document.SmsType(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SmsTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SmsTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.SmsType> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsType.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SmsTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SmsTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.SmsType> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ISmsTypeModel> collection = provider.Document.SmsType.FetchAll();
            return collection.Select(model => new Consensus.Document.SmsType(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SmsTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SmsTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.SmsType FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsType.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SmsTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SmsTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.SmsType FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.ISmsTypeModel model = provider.Document.SmsType.FetchById(id);
            return model == null ? null : new Consensus.Document.SmsType(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsType.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.SmsType.GetTableName();
        }

        #endregion
    }
}
