using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductPackRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPackProductModel : LocalModel<ProductPackRecord, Int32>, IPackProductModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PPA_PROD_ID" field.
        /// </summary>
        private LocalProductModel _product;

        /// <summary>
        ///     The value of the "PPA_PACK_ID" field.
        /// </summary>
        private LocalPackModel _pack;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductPackRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.PackProduct.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductPackRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.PackProduct.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductPackRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.PackProduct.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PPA_PROD_ID" field.
        /// </summary>
        public LocalProductModel Product
        {
            get
            {
                if (_product == null)
                    _product = this.Provider.Learning.Product.FetchById(this.ProductId);
                if (_product == null)
                    _product = this.Provider.Learning.Product.Create();
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPA_PROD_ID" field.
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
        ///     Gets the The value of the "PPA_PACK_ID" field.
        /// </summary>
        public LocalPackModel Pack
        {
            get
            {
                if (_pack == null && this.PackId != null)
                    _pack = this.Provider.Document.Pack.FetchById(this.PackId);
                if (_pack == null)
                    _pack = this.Provider.Document.Pack.Create();
                
                return _pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPA_PACK_ID" field.
        /// </summary>
        public String PackId
        {
            get { return this.ModifiedData.PackId; }
            set
            {
                if (this.ModifiedData.PackId != value)
                     _pack = null;
                this.ModifiedData.PackId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPA_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPA_SUPPRESS" field.
        /// </summary>
        public Byte Suppress
        {
            get { return this.ModifiedData.Suppress; }
            set { this.ModifiedData.Suppress = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPackProductModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPackProductModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPackProductModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPackProductModel(LocalProvider provider, ProductPackRecord record) : base(provider, record)
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
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProdId = _product.Id == null && this.ModifiedData.ProdId != null ? "" : _product.Id;
            }
            if (_pack != null)
            {
                _pack.Save();
                this.ModifiedData.PackId = _pack.Id == null && this.ModifiedData.PackId != null ? "" : _pack.Id;
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
        ///     Gets the The value of the "PPA_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IPackProductModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPA_PROD_ID" field.
        /// </summary>
        System.String IPackProductModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PPA_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel IPackProductModel.Pack
        {
            get { return this.Pack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPA_PACK_ID" field.
        /// </summary>
        System.String IPackProductModel.PackId
        {
            get { return this.PackId; }
            set { this.PackId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPA_TYPE" field.
        /// </summary>
        System.String IPackProductModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPA_SUPPRESS" field.
        /// </summary>
        System.Byte IPackProductModel.Suppress
        {
            get { return this.Suppress; }
            set { this.Suppress = (System.Byte)value; }
        }

        #endregion
    }
}
