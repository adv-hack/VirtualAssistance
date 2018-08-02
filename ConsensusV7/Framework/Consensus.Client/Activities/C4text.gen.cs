using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Learning;

namespace Consensus.Activities
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class C4text : Proxy<IC4textModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="TrainersFeeNoteText" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Trainer, Consensus.Contact.ITrainerModel> _trainersFeeNoteText;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="TrainersHotelReqText" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Trainer, Consensus.Contact.ITrainerModel> _trainersHotelReqText;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="TrainersOtherInfoText" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Trainer, Consensus.Contact.ITrainerModel> _trainersOtherInfoText;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProductsDescrip" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _productsDescrip;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProductsText1" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _productsText1;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProductsText2" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _productsText2;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProductsText3" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _productsText3;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProductsTrnRulesTxt" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _productsTrnRulesTxt;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PackEmailBody" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.Pack, Consensus.Document.IPackModel> _packEmailBody;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="HelpdeskDetails" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel> _helpdeskDetails;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="HelpdeskFixes" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel> _helpdeskFixes;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="HelpdeskWIPs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel> _helpdeskWIPs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ComplaintDetails" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel> _complaintDetails;

        #endregion

        #region properties

        /// <summary>
        ///     The resolved name of the user that created the record.
        /// </summary>
        public System.String AddByName
        {
            get { return this.Model.AddByName; }
        }

        /// <summary>
        ///     The resolved name of the user that last updated the record.
        /// </summary>
        public System.String ModByName
        {
            get { return this.Model.ModByName; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_ADD_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> AddDate
        {
            get { return this.Model.AddDate; }
            set { this.Model.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_ADD_BY" field.
        /// </summary>
        public System.String AddBy
        {
            get { return this.Model.AddBy; }
            set { this.Model.AddBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_MOD_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ModDate
        {
            get { return this.Model.ModDate; }
            set { this.Model.ModDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_MOD_BY" field.
        /// </summary>
        public System.String ModBy
        {
            get { return this.Model.ModBy; }
            set { this.Model.ModBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_OWNER_ID" field.
        /// </summary>
        public System.String OwnerId
        {
            get { return this.Model.OwnerId; }
            set { this.Model.OwnerId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_BODY" field.
        /// </summary>
        public System.String Body
        {
            get { return this.Model.Body; }
            set { this.Model.Body = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_HTML" field.
        /// </summary>
        public System.String Html
        {
            get { return this.Model.Html; }
            set { this.Model.Html = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_OWNER_URL" field.
        /// </summary>
        public System.String OwnerUrl
        {
            get { return this.Model.OwnerUrl; }
            set { this.Model.OwnerUrl = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Trainer> TrainersFeeNoteText
        {
            get
            {
                if (_trainersFeeNoteText == null)
                    _trainersFeeNoteText = new ProxyCollection<Consensus.Contact.Trainer, Consensus.Contact.ITrainerModel>(this.Model.TrainersFeeNoteText, model => new Consensus.Contact.Trainer(model));
                return _trainersFeeNoteText;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Trainer> TrainersHotelReqText
        {
            get
            {
                if (_trainersHotelReqText == null)
                    _trainersHotelReqText = new ProxyCollection<Consensus.Contact.Trainer, Consensus.Contact.ITrainerModel>(this.Model.TrainersHotelReqText, model => new Consensus.Contact.Trainer(model));
                return _trainersHotelReqText;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Trainer> TrainersOtherInfoText
        {
            get
            {
                if (_trainersOtherInfoText == null)
                    _trainersOtherInfoText = new ProxyCollection<Consensus.Contact.Trainer, Consensus.Contact.ITrainerModel>(this.Model.TrainersOtherInfoText, model => new Consensus.Contact.Trainer(model));
                return _trainersOtherInfoText;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Product> ProductsDescrip
        {
            get
            {
                if (_productsDescrip == null)
                    _productsDescrip = new ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel>(this.Model.ProductsDescrip, model => new Consensus.Learning.Product(model));
                return _productsDescrip;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Product> ProductsText1
        {
            get
            {
                if (_productsText1 == null)
                    _productsText1 = new ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel>(this.Model.ProductsText1, model => new Consensus.Learning.Product(model));
                return _productsText1;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Product> ProductsText2
        {
            get
            {
                if (_productsText2 == null)
                    _productsText2 = new ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel>(this.Model.ProductsText2, model => new Consensus.Learning.Product(model));
                return _productsText2;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Product> ProductsText3
        {
            get
            {
                if (_productsText3 == null)
                    _productsText3 = new ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel>(this.Model.ProductsText3, model => new Consensus.Learning.Product(model));
                return _productsText3;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Product> ProductsTrnRulesTxt
        {
            get
            {
                if (_productsTrnRulesTxt == null)
                    _productsTrnRulesTxt = new ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel>(this.Model.ProductsTrnRulesTxt, model => new Consensus.Learning.Product(model));
                return _productsTrnRulesTxt;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Document.Pack> PackEmailBody
        {
            get
            {
                if (_packEmailBody == null)
                    _packEmailBody = new ProxyCollection<Consensus.Document.Pack, Consensus.Document.IPackModel>(this.Model.PackEmailBody, model => new Consensus.Document.Pack(model));
                return _packEmailBody;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Helpdesk> HelpdeskDetails
        {
            get
            {
                if (_helpdeskDetails == null)
                    _helpdeskDetails = new ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel>(this.Model.HelpdeskDetails, model => new Consensus.Activities.Helpdesk(model));
                return _helpdeskDetails;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Helpdesk> HelpdeskFixes
        {
            get
            {
                if (_helpdeskFixes == null)
                    _helpdeskFixes = new ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel>(this.Model.HelpdeskFixes, model => new Consensus.Activities.Helpdesk(model));
                return _helpdeskFixes;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Helpdesk> HelpdeskWIPs
        {
            get
            {
                if (_helpdeskWIPs == null)
                    _helpdeskWIPs = new ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel>(this.Model.HelpdeskWIPs, model => new Consensus.Activities.Helpdesk(model));
                return _helpdeskWIPs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Complaint> ComplaintDetails
        {
            get
            {
                if (_complaintDetails == null)
                    _complaintDetails = new ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel>(this.Model.ComplaintDetails, model => new Consensus.Activities.Complaint(model));
                return _complaintDetails;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal C4text(IC4textModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public static IEnumerable<Consensus.Activities.C4text> FetchAllByOwnerUrlAndOwnerId(System.String ownerUrl, System.String ownerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return C4text.FetchAllByOwnerUrlAndOwnerId(site,ownerUrl,ownerId);
        }

        public static IEnumerable<Consensus.Activities.C4text> FetchAllByOwnerUrlAndOwnerId(ConsensusSite site, System.String ownerUrl, System.String ownerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IC4textModel> collection = provider.Activities.C4text.FetchAllByOwnerUrlAndOwnerId(ownerUrl,ownerId);
            return collection.Select(model => new Consensus.Activities.C4text(model));
        }

        /// <summary>
        ///     Creates a new <see cref="!:C4textModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:C4textModel" /> instance.
        /// </returns>
        public static Consensus.Activities.C4text Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return C4text.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:C4textModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:C4textModel" /> instance.
        /// </returns>
        public static Consensus.Activities.C4text Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IC4textModel model = provider.Activities.C4text.Create();
            return model == null ? null : new Consensus.Activities.C4text(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:C4textModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:C4textModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.C4text> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return C4text.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:C4textModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:C4textModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Activities.C4text> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Activities.IC4textModel> collection = provider.Activities.C4text.FetchAll();
            return collection.Select(model => new Consensus.Activities.C4text(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:C4textModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:C4textModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:C4textModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.C4text FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return C4text.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:C4textModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:C4textModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:C4textModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Activities.C4text FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Activities.IC4textModel model = provider.Activities.C4text.FetchById(id);
            return model == null ? null : new Consensus.Activities.C4text(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return C4text.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Activities.C4text.GetTableName();
        }

        #endregion
    }
}
