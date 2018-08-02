using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductEventRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProductEventModel : LocalModel<ProductEventRecord, Int32>, IProductEventModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PE_PROD_ID" field.
        /// </summary>
        private LocalProductModel _product;

        /// <summary>
        ///     The value of the "PE_ACADY_CODE" field.
        /// </summary>
        private LocalCodeModel _acadyCode;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductEventRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.ProductEvent.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductEventRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.ProductEvent.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductEventRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.ProductEvent.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PE_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PE_PROD_ID" field.
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
        ///     Gets or sets the value of the "PE_INSTANCE" field.
        /// </summary>
        public Int32 Instance
        {
            get { return this.ModifiedData.Instance; }
            set { this.ModifiedData.Instance = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PE_ACADY_CODE" field.
        /// </summary>
        public LocalCodeModel AcadyCode
        {
            get
            {
                if (_acadyCode == null && !String.IsNullOrEmpty(this.AcadyCodeCode))
                    _acadyCode = this.Provider.Common.Code.FetchByTypeAndCode("ACADY", this.AcadyCodeCode);
                if (_acadyCode == null)
                    _acadyCode = this.Provider.Common.Code.Create("ACADY");
                return _acadyCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PE_ACADY_CODE" field.
        /// </summary>
        public String AcadyCodeCode
        {
            get { return this.ModifiedData.AcadyCode; }
            set
            {
                if (this.ModifiedData.AcadyCode != value)
                     _acadyCode = null;
                this.ModifiedData.AcadyCode = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProductEventModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProductEventModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProductEventModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProductEventModel(LocalProvider provider, ProductEventRecord record) : base(provider, record)
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
            if (_acadyCode != null)
            {
                _acadyCode.Save();
                this.ModifiedData.AcadyCode = _acadyCode.Value1;
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
        ///     Gets the The value of the "PE_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IProductEventModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PE_PROD_ID" field.
        /// </summary>
        System.String IProductEventModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PE_INSTANCE" field.
        /// </summary>
        System.Int32 IProductEventModel.Instance
        {
            get { return this.Instance; }
            set { this.Instance = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PE_ACADY_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductEventModel.AcadyCode
        {
            get { return this.AcadyCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PE_ACADY_CODE" field.
        /// </summary>
        System.String IProductEventModel.AcadyCodeCode
        {
            get { return this.AcadyCodeCode; }
            set { this.AcadyCodeCode = (System.String)value; }
        }

        #endregion
    }
}
