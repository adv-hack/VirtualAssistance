using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="TemplateXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTemplateResourceModel : LocalTemplateModel, ITemplateResourceModel
    {
        #region fields

        /// <summary>
        ///     The value of the "TXREF_PROD_ID" field.
        /// </summary>
        private LocalProductModel _resource;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Template.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Template.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Template.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "TXREF_PROD_ID" field.
        /// </summary>
        public LocalProductModel Resource
        {
            get
            {
                if (_resource == null && this.ResourceId != null)
                    _resource = this.Provider.Learning.Product.FetchById(this.ResourceId);
                if (_resource == null)
                    _resource = this.Provider.Learning.Product.Create();
                
                return _resource;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_PROD_ID" field.
        /// </summary>
        public String ResourceId
        {
            get { return this.ModifiedData.ProdId; }
            set
            {
                if (this.ModifiedData.ProdId != value)
                     _resource = null;
                this.ModifiedData.ProdId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalTemplateResourceModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalTemplateResourceModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalTemplateResourceModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalTemplateResourceModel(LocalProvider provider, TemplateXrefRecord record) : base(provider, record)
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
            if (_resource != null)
            {
                _resource.Save();
                this.ModifiedData.ProdId = _resource.Id == null && this.ModifiedData.ProdId != null ? "" : _resource.Id;
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
        ///     Gets the The value of the "TXREF_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel ITemplateResourceModel.Resource
        {
            get { return this.Resource; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_PROD_ID" field.
        /// </summary>
        System.String ITemplateResourceModel.ResourceId
        {
            get { return this.ResourceId; }
            set { this.ResourceId = (System.String)value; }
        }

        #endregion
    }
}
