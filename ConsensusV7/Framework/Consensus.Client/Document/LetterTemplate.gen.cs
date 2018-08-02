using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LetterTemplate : Proxy<ILetterTemplateModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Document.LetterTemplateType _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SendFrom" /> member.
        /// </summary>
        private Consensus.Contact.Role _sendFrom;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="LetterTemplateId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.Literature, Consensus.Document.ILiteratureModel> _letterTemplateId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Payments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel> _payments;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the file type based of the template record.
        /// </summary>
        public System.String FileType
        {
            get { return this.Model.FileType; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LT_TYPE" field.
        /// </summary>
        public Consensus.Document.LetterTemplateType Type
        {
            get
            {
                if (_type == null && this.Model.Type != null)
                    _type = new Consensus.Document.LetterTemplateType(this.Model.Type);
                if (_type == null)
                    _type = Consensus.Document.LetterTemplateType.Create();
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LT_TYPE" field.
        /// </summary>
        public System.String TypeId
        {
            get { return this.Model.TypeId; }
            set { this.Model.TypeId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_FILE_NAME" field.
        /// </summary>
        public System.String FileName
        {
            get { return this.Model.FileName; }
            set { this.Model.FileName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LT_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "LT_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PRINT_ONLY" field.
        /// </summary>
        public System.Nullable<System.Byte> PrintOnly
        {
            get { return this.Model.PrintOnly; }
            set { this.Model.PrintOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PDF" field.
        /// </summary>
        public System.Nullable<System.Byte> Pdf
        {
            get { return this.Model.Pdf; }
            set { this.Model.Pdf = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role SendFrom
        {
            get
            {
                if (_sendFrom == null && this.Model.SendFrom != null)
                    _sendFrom = new Consensus.Contact.Role(this.Model.SendFrom);
                if (_sendFrom == null)
                    _sendFrom = Consensus.Contact.Role.Create();
                return _sendFrom;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        public System.String SendFromId
        {
            get { return this.Model.SendFromId; }
            set { this.Model.SendFromId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_CURRENT" field.
        /// </summary>
        public System.Byte Current
        {
            get { return this.Model.Current; }
            set { this.Model.Current = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_EMAIL_BODY" field.
        /// </summary>
        public System.Byte EmailBody
        {
            get { return this.Model.EmailBody; }
            set { this.Model.EmailBody = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_PQ_ID" field.
        /// </summary>
        public System.String PqId
        {
            get { return this.Model.PqId; }
            set { this.Model.PqId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_ATT_ID" field.
        /// </summary>
        public System.String AttId
        {
            get { return this.Model.AttId; }
            set { this.Model.AttId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LT_LABEL" field.
        /// </summary>
        public System.Nullable<System.Byte> Label
        {
            get { return this.Model.Label; }
            set { this.Model.Label = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LiteratureModel" /> instances that reference this <see cref="!:LetterTemplateModel" />.
        /// </summary>
        public Collection<Consensus.Document.Literature> LetterTemplateId
        {
            get
            {
                if (_letterTemplateId == null)
                    _letterTemplateId = new ProxyCollection<Consensus.Document.Literature, Consensus.Document.ILiteratureModel>(this.Model.LetterTemplateId, model => new Consensus.Document.Literature(model));
                return _letterTemplateId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:LetterTemplateModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Payment> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel>(this.Model.Payments, model => new Consensus.Finance.Payment(model));
                return _payments;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal LetterTemplate(ILetterTemplateModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:LetterTemplateModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LetterTemplateModel" /> instance.
        /// </returns>
        public static Consensus.Document.LetterTemplate Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplate.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LetterTemplateModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LetterTemplateModel" /> instance.
        /// </returns>
        public static Consensus.Document.LetterTemplate Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.ILetterTemplateModel model = provider.Document.LetterTemplate.Create();
            return model == null ? null : new Consensus.Document.LetterTemplate(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LetterTemplateModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.LetterTemplate> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplate.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LetterTemplateModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.LetterTemplate> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ILetterTemplateModel> collection = provider.Document.LetterTemplate.FetchAll();
            return collection.Select(model => new Consensus.Document.LetterTemplate(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LetterTemplateModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LetterTemplateModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.LetterTemplate FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplate.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LetterTemplateModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LetterTemplateModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.LetterTemplate FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.ILetterTemplateModel model = provider.Document.LetterTemplate.FetchById(id);
            return model == null ? null : new Consensus.Document.LetterTemplate(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplate.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.LetterTemplate.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="typeId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="typeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.LetterTemplate> FetchAllByTypeId(System.String typeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplate.FetchAllByTypeId(site,typeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="typeId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="typeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.LetterTemplate> FetchAllByTypeId(ConsensusSite site, System.String typeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ILetterTemplateModel> collection = provider.Document.LetterTemplate.FetchAllByTypeId(typeId);
            return collection.Select(model => new Consensus.Document.LetterTemplate(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.LetterTemplate> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplate.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.LetterTemplate> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ILetterTemplateModel> collection = provider.Document.LetterTemplate.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Document.LetterTemplate(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="sendFromId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="sendFromId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.LetterTemplate> FetchAllBySendFromId(System.String sendFromId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplate.FetchAllBySendFromId(site,sendFromId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="sendFromId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="sendFromId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.LetterTemplate> FetchAllBySendFromId(ConsensusSite site, System.String sendFromId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ILetterTemplateModel> collection = provider.Document.LetterTemplate.FetchAllBySendFromId(sendFromId);
            return collection.Select(model => new Consensus.Document.LetterTemplate(model));
        }

        #endregion
    }
}
