using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SmsMessage : Proxy<ISmsMessageModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SmsMessageType" /> member.
        /// </summary>
        private Consensus.Document.SmsType _smsMessageType;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SmsId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PackXref, Consensus.Document.IPackXrefModel> _smsId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "SMS_SMT_ID" field.
        /// </summary>
        public Consensus.Document.SmsType SmsMessageType
        {
            get
            {
                if (_smsMessageType == null && this.Model.SmsMessageType != null)
                    _smsMessageType = new Consensus.Document.SmsType(this.Model.SmsMessageType);
                if (_smsMessageType == null)
                    _smsMessageType = Consensus.Document.SmsType.Create();
                return _smsMessageType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMS_SMT_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> SmsMessageTypeId
        {
            get { return this.Model.SmsMessageTypeId; }
            set { this.Model.SmsMessageTypeId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_TEXT" field.
        /// </summary>
        public System.String Text
        {
            get { return this.Model.Text; }
            set { this.Model.Text = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMS_CURRENT" field.
        /// </summary>
        public System.Nullable<System.Boolean> Current
        {
            get { return this.Model.Current; }
            set { this.Model.Current = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SMS_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.Model.SellingCompany != null)
                    _sellingCompany = new Consensus.Common.SellingCompany(this.Model.SellingCompany);
                if (_sellingCompany == null)
                    _sellingCompany = Consensus.Common.SellingCompany.Create();
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMS_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:SmsMessageModel" />.
        /// </summary>
        public Collection<Consensus.Document.PackXref> SmsId
        {
            get
            {
                if (_smsId == null)
                    _smsId = new ProxyCollection<Consensus.Document.PackXref, Consensus.Document.IPackXrefModel>(this.Model.SmsId, model => new Consensus.Document.PackXref(model));
                return _smsId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SmsMessage(ISmsMessageModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Checks if smsmessage name exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the smsmessage.
        /// </param>
        /// <param name="smsmessageId">
        ///     Id of the smsmessage.
        /// </param>
        /// <returns>
        ///     Whether smsmessage's name exist in database.
        /// </returns>
        public static System.Boolean CheckIfNameExist(System.String name, System.String smsmessageId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsMessage.CheckIfNameExist(site,name,smsmessageId);
        }

        /// <summary>
        ///     Checks if smsmessage name exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the smsmessage.
        /// </param>
        /// <param name="smsmessageId">
        ///     Id of the smsmessage.
        /// </param>
        /// <returns>
        ///     Whether smsmessage's name exist in database.
        /// </returns>
        public static System.Boolean CheckIfNameExist(ConsensusSite site, System.String name, System.String smsmessageId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.SmsMessage.CheckIfNameExist(name,smsmessageId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SmsMessageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SmsMessageModel" /> instance.
        /// </returns>
        public static Consensus.Document.SmsMessage Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsMessage.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SmsMessageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SmsMessageModel" /> instance.
        /// </returns>
        public static Consensus.Document.SmsMessage Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.ISmsMessageModel model = provider.Document.SmsMessage.Create();
            return model == null ? null : new Consensus.Document.SmsMessage(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SmsMessageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SmsMessageModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.SmsMessage> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsMessage.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SmsMessageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SmsMessageModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.SmsMessage> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ISmsMessageModel> collection = provider.Document.SmsMessage.FetchAll();
            return collection.Select(model => new Consensus.Document.SmsMessage(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SmsMessageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SmsMessageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsMessageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.SmsMessage FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsMessage.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SmsMessageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SmsMessageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsMessageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.SmsMessage FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.ISmsMessageModel model = provider.Document.SmsMessage.FetchById(id);
            return model == null ? null : new Consensus.Document.SmsMessage(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsMessage.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.SmsMessage.GetTableName();
        }

        public static IEnumerable<Consensus.Document.SmsMessage> FetchAllBySmsMessageTypeId(System.Nullable<System.Int32> smsMessageTypeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsMessage.FetchAllBySmsMessageTypeId(site,smsMessageTypeId);
        }

        public static IEnumerable<Consensus.Document.SmsMessage> FetchAllBySmsMessageTypeId(ConsensusSite site, System.Nullable<System.Int32> smsMessageTypeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ISmsMessageModel> collection = provider.Document.SmsMessage.FetchAllBySmsMessageTypeId(smsMessageTypeId);
            return collection.Select(model => new Consensus.Document.SmsMessage(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SmsMessageModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SmsMessageModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsMessageModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.SmsMessage> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SmsMessage.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SmsMessageModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SmsMessageModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsMessageModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.SmsMessage> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ISmsMessageModel> collection = provider.Document.SmsMessage.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Document.SmsMessage(model));
        }

        #endregion
    }
}
