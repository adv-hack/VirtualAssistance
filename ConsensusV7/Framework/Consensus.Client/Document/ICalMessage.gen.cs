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
    public partial class ICalMessage : Proxy<IICalMessageModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ICalMessageType" /> member.
        /// </summary>
        private Consensus.Document.ICalMessageType _iCalMessageType;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ICalMessageId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PackXref, Consensus.Document.IPackXrefModel> _iCalMessageId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "ICM_ICMT_ID" field.
        /// </summary>
        public Consensus.Document.ICalMessageType ICalMessageType
        {
            get
            {
                if (_iCalMessageType == null && this.Model.ICalMessageType != null)
                    _iCalMessageType = new Consensus.Document.ICalMessageType(this.Model.ICalMessageType);
                if (_iCalMessageType == null)
                    _iCalMessageType = Consensus.Document.ICalMessageType.Create();
                return _iCalMessageType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ICM_ICMT_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> ICalMessageTypeId
        {
            get { return this.Model.ICalMessageTypeId; }
            set { this.Model.ICalMessageTypeId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_CURRENT" field.
        /// </summary>
        public System.Nullable<System.Byte> Current
        {
            get { return this.Model.Current; }
            set { this.Model.Current = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_METHOD" field.
        /// </summary>
        public System.Nullable<System.Byte> Method
        {
            get { return this.Model.Method; }
            set { this.Model.Method = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_SUBJECT" field.
        /// </summary>
        public System.String Subject
        {
            get { return this.Model.Subject; }
            set { this.Model.Subject = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_LOCATION" field.
        /// </summary>
        public System.String Location
        {
            get { return this.Model.Location; }
            set { this.Model.Location = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_TEXT" field.
        /// </summary>
        public System.String Text
        {
            get { return this.Model.Text; }
            set { this.Model.Text = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ICM_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ICM_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:ICalMessageModel" />.
        /// </summary>
        public Collection<Consensus.Document.PackXref> ICalMessageId
        {
            get
            {
                if (_iCalMessageId == null)
                    _iCalMessageId = new ProxyCollection<Consensus.Document.PackXref, Consensus.Document.IPackXrefModel>(this.Model.ICalMessageId, model => new Consensus.Document.PackXref(model));
                return _iCalMessageId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ICalMessage(IICalMessageModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Checks if iCalMessage name exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the iCalendar Message.
        /// </param>
        /// <param name="iCalMessageId">
        ///     Id of the iCalendar Message.
        /// </param>
        /// <returns>
        ///     Whether iCalendar Message's name exist in database.
        /// </returns>
        public static System.Boolean CheckIfNameExist(System.String name, System.String iCalMessageId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessage.CheckIfNameExist(site,name,iCalMessageId);
        }

        /// <summary>
        ///     Checks if iCalMessage name exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the iCalendar Message.
        /// </param>
        /// <param name="iCalMessageId">
        ///     Id of the iCalendar Message.
        /// </param>
        /// <returns>
        ///     Whether iCalendar Message's name exist in database.
        /// </returns>
        public static System.Boolean CheckIfNameExist(ConsensusSite site, System.String name, System.String iCalMessageId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.ICalMessage.CheckIfNameExist(name,iCalMessageId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ICalMessageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ICalMessageModel" /> instance.
        /// </returns>
        public static Consensus.Document.ICalMessage Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessage.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ICalMessageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ICalMessageModel" /> instance.
        /// </returns>
        public static Consensus.Document.ICalMessage Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IICalMessageModel model = provider.Document.ICalMessage.Create();
            return model == null ? null : new Consensus.Document.ICalMessage(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ICalMessageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ICalMessageModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.ICalMessage> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessage.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ICalMessageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ICalMessageModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.ICalMessage> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IICalMessageModel> collection = provider.Document.ICalMessage.FetchAll();
            return collection.Select(model => new Consensus.Document.ICalMessage(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ICalMessageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ICalMessageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.ICalMessage FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessage.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ICalMessageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ICalMessageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.ICalMessage FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IICalMessageModel model = provider.Document.ICalMessage.FetchById(id);
            return model == null ? null : new Consensus.Document.ICalMessage(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessage.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.ICalMessage.GetTableName();
        }

        public static IEnumerable<Consensus.Document.ICalMessage> FetchAllByICalMessageTypeId(System.Nullable<System.Int32> iCalMessageTypeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessage.FetchAllByICalMessageTypeId(site,iCalMessageTypeId);
        }

        public static IEnumerable<Consensus.Document.ICalMessage> FetchAllByICalMessageTypeId(ConsensusSite site, System.Nullable<System.Int32> iCalMessageTypeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IICalMessageModel> collection = provider.Document.ICalMessage.FetchAllByICalMessageTypeId(iCalMessageTypeId);
            return collection.Select(model => new Consensus.Document.ICalMessage(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ICalMessageModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ICalMessageModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.ICalMessage> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ICalMessage.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ICalMessageModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ICalMessageModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.ICalMessage> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IICalMessageModel> collection = provider.Document.ICalMessage.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Document.ICalMessage(model));
        }

        #endregion
    }
}
