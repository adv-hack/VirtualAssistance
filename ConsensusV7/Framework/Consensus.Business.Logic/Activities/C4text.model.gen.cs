using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Learning;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="C4textRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalC4textModel : LocalModel<C4textRecord, String>, IC4textModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="TrainerModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalTrainerModel, ITrainerModel> _trainersFeeNoteText;

        /// <summary>
        ///     The collection of <see cref="TrainerModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalTrainerModel, ITrainerModel> _trainersHotelReqText;

        /// <summary>
        ///     The collection of <see cref="TrainerModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalTrainerModel, ITrainerModel> _trainersOtherInfoText;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _productsDescrip;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _productsText1;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _productsText2;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _productsText3;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _productsTrnRulesTxt;

        /// <summary>
        ///     The collection of <see cref="PackModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalPackModel, IPackModel> _packEmailBody;

        /// <summary>
        ///     The collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalHelpdeskModel, IHelpdeskModel> _helpdeskDetails;

        /// <summary>
        ///     The collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalHelpdeskModel, IHelpdeskModel> _helpdeskFixes;

        /// <summary>
        ///     The collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalHelpdeskModel, IHelpdeskModel> _helpdeskWIPs;

        /// <summary>
        ///     The collection of <see cref="ComplaintModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        private LocalCollection<LocalComplaintModel, IComplaintModel> _complaintDetails;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<C4textRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Activities.C4text.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<C4textRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Activities.C4text.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<C4textRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Activities.C4text.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return this.ModifiedData.AddDate; }
            set { this.ModifiedData.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return this.ModifiedData.AddBy; }
            set { this.ModifiedData.AddBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return this.ModifiedData.ModDate; }
            set { this.ModifiedData.ModDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return this.ModifiedData.ModBy; }
            set { this.ModifiedData.ModBy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_OWNER_ID" field.
        /// </summary>
        public String OwnerId
        {
            get { return this.ModifiedData.OwnerId; }
            set { this.ModifiedData.OwnerId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_BODY" field.
        /// </summary>
        public String Body
        {
            get { return this.ModifiedData.Body; }
            set { this.ModifiedData.Body = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_HTML" field.
        /// </summary>
        public String Html
        {
            get { return this.ModifiedData.Html; }
            set { this.ModifiedData.Html = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_OWNER_URL" field.
        /// </summary>
        public String OwnerUrl
        {
            get { return this.ModifiedData.OwnerUrl; }
            set { this.ModifiedData.OwnerUrl = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="TrainerModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalTrainerModel, ITrainerModel> TrainersFeeNoteText
        {
            get
            {
                if (_trainersFeeNoteText == null)
                    _trainersFeeNoteText = new LocalCollection<LocalTrainerModel, ITrainerModel>(this.Provider.Contact.Trainer.FetchAllByFeeNotesTextId(this.Id));
                
                return _trainersFeeNoteText;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="TrainerModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalTrainerModel, ITrainerModel> TrainersHotelReqText
        {
            get
            {
                if (_trainersHotelReqText == null)
                    _trainersHotelReqText = new LocalCollection<LocalTrainerModel, ITrainerModel>(this.Provider.Contact.Trainer.FetchAllByHotelReqTextId(this.Id));
                
                return _trainersHotelReqText;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="TrainerModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalTrainerModel, ITrainerModel> TrainersOtherInfoText
        {
            get
            {
                if (_trainersOtherInfoText == null)
                    _trainersOtherInfoText = new LocalCollection<LocalTrainerModel, ITrainerModel>(this.Provider.Contact.Trainer.FetchAllByOtherInfoTextId(this.Id));
                
                return _trainersOtherInfoText;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> ProductsDescrip
        {
            get
            {
                if (_productsDescrip == null)
                    _productsDescrip = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByProdDescripId(this.Id));
                
                return _productsDescrip;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> ProductsText1
        {
            get
            {
                if (_productsText1 == null)
                    _productsText1 = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByProdContentId(this.Id));
                
                return _productsText1;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> ProductsText2
        {
            get
            {
                if (_productsText2 == null)
                    _productsText2 = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByProdPrereqId(this.Id));
                
                return _productsText2;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> ProductsText3
        {
            get
            {
                if (_productsText3 == null)
                    _productsText3 = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByProdObjectiveId(this.Id));
                
                return _productsText3;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> ProductsTrnRulesTxt
        {
            get
            {
                if (_productsTrnRulesTxt == null)
                    _productsTrnRulesTxt = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByProductTrainingRulesId(this.Id));
                
                return _productsTrnRulesTxt;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PackModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalPackModel, IPackModel> PackEmailBody
        {
            get
            {
                if (_packEmailBody == null)
                    _packEmailBody = new LocalCollection<LocalPackModel, IPackModel>(this.Provider.Document.Pack.FetchAllByPackEmailBodyId(this.Id));
                
                return _packEmailBody;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalHelpdeskModel, IHelpdeskModel> HelpdeskDetails
        {
            get
            {
                if (_helpdeskDetails == null)
                    _helpdeskDetails = new LocalCollection<LocalHelpdeskModel, IHelpdeskModel>(this.Provider.Activities.Helpdesk.FetchAllByDetailsIdId(this.Id));
                
                return _helpdeskDetails;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalHelpdeskModel, IHelpdeskModel> HelpdeskFixes
        {
            get
            {
                if (_helpdeskFixes == null)
                    _helpdeskFixes = new LocalCollection<LocalHelpdeskModel, IHelpdeskModel>(this.Provider.Activities.Helpdesk.FetchAllByFixIdId(this.Id));
                
                return _helpdeskFixes;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalHelpdeskModel, IHelpdeskModel> HelpdeskWIPs
        {
            get
            {
                if (_helpdeskWIPs == null)
                    _helpdeskWIPs = new LocalCollection<LocalHelpdeskModel, IHelpdeskModel>(this.Provider.Activities.Helpdesk.FetchAllByWipIdId(this.Id));
                
                return _helpdeskWIPs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ComplaintModel" /> instances that reference this <see cref="C4textModel" />.
        /// </summary>
        public LocalCollection<LocalComplaintModel, IComplaintModel> ComplaintDetails
        {
            get
            {
                if (_complaintDetails == null)
                    _complaintDetails = new LocalCollection<LocalComplaintModel, IComplaintModel>(this.Provider.Activities.Complaint.FetchAllByDetailsIdId(this.Id));
                
                return _complaintDetails;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalC4textModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalC4textModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalC4textModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalC4textModel(LocalProvider provider, C4textRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_trainersFeeNoteText != null)
                _trainersFeeNoteText.Execute(obj => obj.FeeNotesTextId = this.Id).Execute(obj => obj.Save());
            if (_trainersHotelReqText != null)
                _trainersHotelReqText.Execute(obj => obj.HotelReqTextId = this.Id).Execute(obj => obj.Save());
            if (_trainersOtherInfoText != null)
                _trainersOtherInfoText.Execute(obj => obj.OtherInfoTextId = this.Id).Execute(obj => obj.Save());
            if (_productsDescrip != null)
                _productsDescrip.Execute(obj => obj.ProdDescripId = this.Id).Execute(obj => obj.Save());
            if (_productsText1 != null)
                _productsText1.Execute(obj => obj.ProdContentId = this.Id).Execute(obj => obj.Save());
            if (_productsText2 != null)
                _productsText2.Execute(obj => obj.ProdPrereqId = this.Id).Execute(obj => obj.Save());
            if (_productsText3 != null)
                _productsText3.Execute(obj => obj.ProdObjectiveId = this.Id).Execute(obj => obj.Save());
            if (_productsTrnRulesTxt != null)
                _productsTrnRulesTxt.Execute(obj => obj.ProductTrainingRulesId = this.Id).Execute(obj => obj.Save());
            if (_packEmailBody != null)
                _packEmailBody.Execute(obj => obj.PackEmailBodyId = this.Id).Execute(obj => obj.Save());
            if (_helpdeskDetails != null)
                _helpdeskDetails.Execute(obj => obj.DetailsIdId = this.Id).Execute(obj => obj.Save());
            if (_helpdeskFixes != null)
                _helpdeskFixes.Execute(obj => obj.FixIdId = this.Id).Execute(obj => obj.Save());
            if (_helpdeskWIPs != null)
                _helpdeskWIPs.Execute(obj => obj.WipIdId = this.Id).Execute(obj => obj.Save());
            if (_complaintDetails != null)
                _complaintDetails.Execute(obj => obj.DetailsIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     The resolved name of the user that created the record.
        /// </summary>
        System.String IC4textModel.AddByName
        {
            get { return this.AddByName; }
        }

        /// <summary>
        ///     The resolved name of the user that last updated the record.
        /// </summary>
        System.String IC4textModel.ModByName
        {
            get { return this.ModByName; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IC4textModel.AddDate
        {
            get { return this.AddDate; }
            set { this.AddDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_ADD_BY" field.
        /// </summary>
        System.String IC4textModel.AddBy
        {
            get { return this.AddBy; }
            set { this.AddBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_MOD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IC4textModel.ModDate
        {
            get { return this.ModDate; }
            set { this.ModDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_MOD_BY" field.
        /// </summary>
        System.String IC4textModel.ModBy
        {
            get { return this.ModBy; }
            set { this.ModBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_TYPE" field.
        /// </summary>
        System.String IC4textModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_OWNER_ID" field.
        /// </summary>
        System.String IC4textModel.OwnerId
        {
            get { return this.OwnerId; }
            set { this.OwnerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_BODY" field.
        /// </summary>
        System.String IC4textModel.Body
        {
            get { return this.Body; }
            set { this.Body = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_HTML" field.
        /// </summary>
        System.String IC4textModel.Html
        {
            get { return this.Html; }
            set { this.Html = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_OWNER_URL" field.
        /// </summary>
        System.String IC4textModel.OwnerUrl
        {
            get { return this.OwnerUrl; }
            set { this.OwnerUrl = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainerModel> IC4textModel.TrainersFeeNoteText
        {
            get { return this.TrainersFeeNoteText; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainerModel> IC4textModel.TrainersHotelReqText
        {
            get { return this.TrainersHotelReqText; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainerModel> IC4textModel.TrainersOtherInfoText
        {
            get { return this.TrainersOtherInfoText; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IC4textModel.ProductsDescrip
        {
            get { return this.ProductsDescrip; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IC4textModel.ProductsText1
        {
            get { return this.ProductsText1; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IC4textModel.ProductsText2
        {
            get { return this.ProductsText2; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IC4textModel.ProductsText3
        {
            get { return this.ProductsText3; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IC4textModel.ProductsTrnRulesTxt
        {
            get { return this.ProductsTrnRulesTxt; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackModel> IC4textModel.PackEmailBody
        {
            get { return this.PackEmailBody; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> IC4textModel.HelpdeskDetails
        {
            get { return this.HelpdeskDetails; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> IC4textModel.HelpdeskFixes
        {
            get { return this.HelpdeskFixes; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> IC4textModel.HelpdeskWIPs
        {
            get { return this.HelpdeskWIPs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> IC4textModel.ComplaintDetails
        {
            get { return this.ComplaintDetails; }
        }

        #endregion
    }
}
