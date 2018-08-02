using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PackXref : Proxy<IPackXrefModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PackId" /> member.
        /// </summary>
        private Consensus.Document.Pack _packId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="LitId" /> member.
        /// </summary>
        private Consensus.Document.Literature _litId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SmsId" /> member.
        /// </summary>
        private Consensus.Document.SmsMessage _smsId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="IcmId" /> member.
        /// </summary>
        private Consensus.Document.ICalMessage _icmId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        public Consensus.Document.Pack PackId
        {
            get
            {
                if (_packId == null && this.Model.PackId != null)
                    _packId = new Consensus.Document.Pack(this.Model.PackId);
                if (_packId == null)
                    _packId = Consensus.Document.Pack.Create();
                return _packId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        public System.String PackIdId
        {
            get { return this.Model.PackIdId; }
            set { this.Model.PackIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        public Consensus.Document.Literature LitId
        {
            get
            {
                if (_litId == null && this.Model.LitId != null)
                    _litId = new Consensus.Document.Literature(this.Model.LitId);
                if (_litId == null)
                    _litId = Consensus.Document.Literature.Create();
                return _litId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        public System.String LitIdId
        {
            get { return this.Model.LitIdId; }
            set { this.Model.LitIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKXREF_SEQ" field.
        /// </summary>
        public System.Nullable<System.Int32> Seq
        {
            get { return this.Model.Seq; }
            set { this.Model.Seq = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        public Consensus.Document.SmsMessage SmsId
        {
            get
            {
                if (_smsId == null && this.Model.SmsId != null)
                    _smsId = new Consensus.Document.SmsMessage(this.Model.SmsId);
                if (_smsId == null)
                    _smsId = Consensus.Document.SmsMessage.Create();
                return _smsId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> SmsIdId
        {
            get { return this.Model.SmsIdId; }
            set { this.Model.SmsIdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        public Consensus.Document.ICalMessage IcmId
        {
            get
            {
                if (_icmId == null && this.Model.IcmId != null)
                    _icmId = new Consensus.Document.ICalMessage(this.Model.IcmId);
                if (_icmId == null)
                    _icmId = Consensus.Document.ICalMessage.Create();
                return _icmId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> IcmIdId
        {
            get { return this.Model.IcmIdId; }
            set { this.Model.IcmIdId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PackXref(IPackXrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PackXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackXrefModel" /> instance.
        /// </returns>
        public static Consensus.Document.PackXref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackXref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PackXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackXrefModel" /> instance.
        /// </returns>
        public static Consensus.Document.PackXref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IPackXrefModel model = provider.Document.PackXref.Create();
            return model == null ? null : new Consensus.Document.PackXref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackXref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackXref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackXrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackXref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackXrefModel> collection = provider.Document.PackXref.FetchAll();
            return collection.Select(model => new Consensus.Document.PackXref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.PackXref FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackXref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.PackXref FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IPackXrefModel model = provider.Document.PackXref.FetchById(id);
            return model == null ? null : new Consensus.Document.PackXref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackXref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.PackXref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackXrefModel" /> instances.
        /// </summary>
        /// <param name="packIdId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instances that match the specified <paramref name="packIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackXref> FetchAllByPackIdId(System.String packIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackXref.FetchAllByPackIdId(site,packIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackXrefModel" /> instances.
        /// </summary>
        /// <param name="packIdId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instances that match the specified <paramref name="packIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackXref> FetchAllByPackIdId(ConsensusSite site, System.String packIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackXrefModel> collection = provider.Document.PackXref.FetchAllByPackIdId(packIdId);
            return collection.Select(model => new Consensus.Document.PackXref(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackXrefModel" /> instances.
        /// </summary>
        /// <param name="litIdId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instances that match the specified <paramref name="litIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackXref> FetchAllByLitIdId(System.String litIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackXref.FetchAllByLitIdId(site,litIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackXrefModel" /> instances.
        /// </summary>
        /// <param name="litIdId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instances that match the specified <paramref name="litIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackXref> FetchAllByLitIdId(ConsensusSite site, System.String litIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackXrefModel> collection = provider.Document.PackXref.FetchAllByLitIdId(litIdId);
            return collection.Select(model => new Consensus.Document.PackXref(model));
        }

        public static IEnumerable<Consensus.Document.PackXref> FetchAllBySmsIdId(System.Nullable<System.Int32> smsIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackXref.FetchAllBySmsIdId(site,smsIdId);
        }

        public static IEnumerable<Consensus.Document.PackXref> FetchAllBySmsIdId(ConsensusSite site, System.Nullable<System.Int32> smsIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackXrefModel> collection = provider.Document.PackXref.FetchAllBySmsIdId(smsIdId);
            return collection.Select(model => new Consensus.Document.PackXref(model));
        }

        public static IEnumerable<Consensus.Document.PackXref> FetchAllByIcmIdId(System.Nullable<System.Int32> icmIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackXref.FetchAllByIcmIdId(site,icmIdId);
        }

        public static IEnumerable<Consensus.Document.PackXref> FetchAllByIcmIdId(ConsensusSite site, System.Nullable<System.Int32> icmIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackXrefModel> collection = provider.Document.PackXref.FetchAllByIcmIdId(icmIdId);
            return collection.Select(model => new Consensus.Document.PackXref(model));
        }

        #endregion
    }
}
