using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Communications_Xref : Proxy<ICommunications_XrefModel, Int64>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Communication" /> member.
        /// </summary>
        private Consensus.Contact.Communications _communication;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        public Consensus.Contact.Communications Communication
        {
            get
            {
                if (_communication == null && this.Model.Communication != null)
                    _communication = new Consensus.Contact.Communications(this.Model.Communication);
                if (_communication == null)
                    _communication = Consensus.Contact.Communications.Create();
                return _communication;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        public System.Int64 CommunicationId
        {
            get { return this.Model.CommunicationId; }
            set { this.Model.CommunicationId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Communications_Xref(ICommunications_XrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:Communications_XrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:Communications_XrefModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Communications_Xref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Communications_Xref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:Communications_XrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:Communications_XrefModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Communications_Xref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ICommunications_XrefModel model = provider.Contact.Communications_Xref.Create();
            return model == null ? null : new Consensus.Contact.Communications_Xref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:Communications_XrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:Communications_XrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Communications_Xref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Communications_Xref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:Communications_XrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:Communications_XrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Communications_Xref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ICommunications_XrefModel> collection = provider.Contact.Communications_Xref.FetchAll();
            return collection.Select(model => new Consensus.Contact.Communications_Xref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:Communications_XrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:Communications_XrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:Communications_XrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Communications_Xref FetchById(System.Int64 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Communications_Xref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:Communications_XrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:Communications_XrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:Communications_XrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Communications_Xref FetchById(ConsensusSite site, System.Int64 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ICommunications_XrefModel model = provider.Contact.Communications_Xref.FetchById(id);
            return model == null ? null : new Consensus.Contact.Communications_Xref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Communications_Xref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Communications_Xref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:Communications_XrefModel" /> instances.
        /// </summary>
        /// <param name="communicationId">
        ///     The value which identifies the <see cref="!:Communications_XrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:Communications_XrefModel" /> instances that match the specified <paramref name="communicationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Communications_Xref> FetchAllByCommunicationId(System.Int64 communicationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Communications_Xref.FetchAllByCommunicationId(site,communicationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:Communications_XrefModel" /> instances.
        /// </summary>
        /// <param name="communicationId">
        ///     The value which identifies the <see cref="!:Communications_XrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:Communications_XrefModel" /> instances that match the specified <paramref name="communicationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Communications_Xref> FetchAllByCommunicationId(ConsensusSite site, System.Int64 communicationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ICommunications_XrefModel> collection = provider.Contact.Communications_Xref.FetchAllByCommunicationId(communicationId);
            return collection.Select(model => new Consensus.Contact.Communications_Xref(model));
        }

        #endregion
    }
}
