using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductProdXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalRelatedProductModel : LocalModel<ProductProdXrefRecord, Int32>, IRelatedProductModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        private LocalProductModel _relatedProdId;

        /// <summary>
        ///     The value of the "PPX_SCHN_ID" field.
        /// </summary>
        private LocalSalesChannelModel _salesChannel;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductProdXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.RelatedProduct.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductProdXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.RelatedProduct.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductProdXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.RelatedProduct.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPX_MAST_PROD_ID" field.
        /// </summary>
        public String MastProdId
        {
            get { return this.ModifiedData.MastProdId; }
            set { this.ModifiedData.MastProdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        public LocalProductModel RelatedProdId
        {
            get
            {
                if (_relatedProdId == null && this.RelatedProdIdId != null)
                    _relatedProdId = this.Provider.Learning.Product.FetchById(this.RelatedProdIdId);
                if (_relatedProdId == null)
                    _relatedProdId = this.Provider.Learning.Product.Create();
                
                return _relatedProdId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        public String RelatedProdIdId
        {
            get { return this.ModifiedData.RelatedProdId; }
            set
            {
                if (this.ModifiedData.RelatedProdId != value)
                     _relatedProdId = null;
                this.ModifiedData.RelatedProdId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPX_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPX_PREREQ" field.
        /// </summary>
        public Byte Prereq
        {
            get { return this.ModifiedData.Prereq; }
            set { this.ModifiedData.Prereq = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PPX_SCHN_ID" field.
        /// </summary>
        public LocalSalesChannelModel SalesChannel
        {
            get
            {
                if (_salesChannel == null && this.SalesChannelId != null)
                    _salesChannel = this.Provider.Sales.SalesChannel.FetchById(this.SalesChannelId);
                if (_salesChannel == null)
                    _salesChannel = this.Provider.Sales.SalesChannel.Create();
                
                return _salesChannel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPX_SCHN_ID" field.
        /// </summary>
        public String SalesChannelId
        {
            get { return this.ModifiedData.SchnId; }
            set
            {
                if (this.ModifiedData.SchnId != value)
                     _salesChannel = null;
                this.ModifiedData.SchnId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalRelatedProductModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalRelatedProductModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalRelatedProductModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalRelatedProductModel(LocalProvider provider, ProductProdXrefRecord record) : base(provider, record)
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
            if (_relatedProdId != null)
            {
                _relatedProdId.Save();
                this.ModifiedData.RelatedProdId = _relatedProdId.Id == null && this.ModifiedData.RelatedProdId != null ? "" : _relatedProdId.Id;
            }
            if (_salesChannel != null)
            {
                _salesChannel.Save();
                this.ModifiedData.SchnId = _salesChannel.Id == null && this.ModifiedData.SchnId != null ? "" : _salesChannel.Id;
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
        ///     Gets or sets the value of the "PPX_MAST_PROD_ID" field.
        /// </summary>
        System.String IRelatedProductModel.MastProdId
        {
            get { return this.MastProdId; }
            set { this.MastProdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IRelatedProductModel.RelatedProdId
        {
            get { return this.RelatedProdId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        System.String IRelatedProductModel.RelatedProdIdId
        {
            get { return this.RelatedProdIdId; }
            set { this.RelatedProdIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPX_NOTES" field.
        /// </summary>
        System.String IRelatedProductModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPX_PREREQ" field.
        /// </summary>
        System.Byte IRelatedProductModel.Prereq
        {
            get { return this.Prereq; }
            set { this.Prereq = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PPX_SCHN_ID" field.
        /// </summary>
        Consensus.Sales.ISalesChannelModel IRelatedProductModel.SalesChannel
        {
            get { return this.SalesChannel; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPX_SCHN_ID" field.
        /// </summary>
        System.String IRelatedProductModel.SalesChannelId
        {
            get { return this.SalesChannelId; }
            set { this.SalesChannelId = (System.String)value; }
        }

        #endregion
    }
}
