using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="TrainProdXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTrainProdXrefModel : LocalModel<TrainProdXrefRecord, String>, ITrainProdXrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        private LocalTrainerModel _trainer;

        /// <summary>
        ///     The value of the "TPXREF_PROD_ID" field.
        /// </summary>
        private LocalProductModel _product;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TrainProdXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.TrainProdXref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TrainProdXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.TrainProdXref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<TrainProdXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.TrainProdXref.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return this.ModifiedData.RcvFrom; }
            set { this.ModifiedData.RcvFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return this.ModifiedData.RcvDate; }
            set { this.ModifiedData.RcvDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        public LocalTrainerModel Trainer
        {
            get
            {
                if (_trainer == null && this.TrainerId != null)
                    _trainer = this.Provider.Contact.Trainer.FetchById(this.TrainerId);
                if (_trainer == null)
                    _trainer = this.Provider.Contact.Trainer.Create();
                
                return _trainer;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        public String TrainerId
        {
            get { return this.ModifiedData.TrainId; }
            set
            {
                if (this.ModifiedData.TrainId != value)
                     _trainer = null;
                this.ModifiedData.TrainId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_LOC_ID" field.
        /// </summary>
        public String LocId
        {
            get { return this.ModifiedData.LocId; }
            set { this.ModifiedData.LocId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TPXREF_PROD_ID" field.
        /// </summary>
        public LocalProductModel Product
        {
            get
            {
                if (_product == null && this.ProductId != null)
                    _product = this.Provider.Learning.Product.FetchById(this.ProductId);
                if (_product == null)
                    _product = this.Provider.Learning.Product.Create();
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TPXREF_PROD_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return this.ModifiedData.ProdId; }
            set
            {
                if (this.ModifiedData.ProdId != value)
                     _product = null;
                this.ModifiedData.ProdId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_GRADE" field.
        /// </summary>
        public String Grade
        {
            get { return this.ModifiedData.Grade; }
            set { this.ModifiedData.Grade = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_COST" field.
        /// </summary>
        public Decimal? Cost
        {
            get { return this.ModifiedData.Cost; }
            set { this.ModifiedData.Cost = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalTrainProdXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalTrainProdXrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalTrainProdXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalTrainProdXrefModel(LocalProvider provider, TrainProdXrefRecord record) : base(provider, record)
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
            if (_trainer != null)
            {
                _trainer.Save();
                this.ModifiedData.TrainId = _trainer.Id == null && this.ModifiedData.TrainId != null ? "" : _trainer.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProdId = _product.Id == null && this.ModifiedData.ProdId != null ? "" : _product.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_RCV_FROM" field.
        /// </summary>
        System.String ITrainProdXrefModel.RcvFrom
        {
            get { return this.RcvFrom; }
            set { this.RcvFrom = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_RCV_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ITrainProdXrefModel.RcvDate
        {
            get { return this.RcvDate; }
            set { this.RcvDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        Consensus.Contact.ITrainerModel ITrainProdXrefModel.Trainer
        {
            get { return this.Trainer; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        System.String ITrainProdXrefModel.TrainerId
        {
            get { return this.TrainerId; }
            set { this.TrainerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_LOC_ID" field.
        /// </summary>
        System.String ITrainProdXrefModel.LocId
        {
            get { return this.LocId; }
            set { this.LocId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TPXREF_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel ITrainProdXrefModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TPXREF_PROD_ID" field.
        /// </summary>
        System.String ITrainProdXrefModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ITrainProdXrefModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ITrainProdXrefModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_STATUS" field.
        /// </summary>
        System.String ITrainProdXrefModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_GRADE" field.
        /// </summary>
        System.String ITrainProdXrefModel.Grade
        {
            get { return this.Grade; }
            set { this.Grade = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_NOTES" field.
        /// </summary>
        System.String ITrainProdXrefModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_COST" field.
        /// </summary>
        System.Nullable<System.Decimal> ITrainProdXrefModel.Cost
        {
            get { return this.Cost; }
            set { this.Cost = (System.Nullable<System.Decimal>)value; }
        }

        #endregion
    }
}
