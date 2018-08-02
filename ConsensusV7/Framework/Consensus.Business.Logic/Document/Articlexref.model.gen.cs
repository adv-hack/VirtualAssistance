using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="ArticlexrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalArticlexrefModel : LocalModel<ArticlexrefRecord, Int32>, IArticlexrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        private LocalArticleModel _relArticle;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ArticlexrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.Articlexref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ArticlexrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.Articlexref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ArticlexrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.Articlexref.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTIXREF_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return this.ModifiedData.AddDate; }
            set { this.ModifiedData.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTIXREF_ARTI_ID" field.
        /// </summary>
        public String ArtiId
        {
            get { return this.ModifiedData.ArtiId; }
            set { this.ModifiedData.ArtiId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        public LocalArticleModel RelArticle
        {
            get
            {
                if (_relArticle == null)
                    _relArticle = this.Provider.Document.Article.FetchById(this.RelArticleId);
                if (_relArticle == null)
                    _relArticle = this.Provider.Document.Article.Create();
                
                return _relArticle;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        public Int32 RelArticleId
        {
            get { return this.ModifiedData.RelArtiId; }
            set
            {
                if (this.ModifiedData.RelArtiId != value)
                     _relArticle = null;
                this.ModifiedData.RelArtiId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalArticlexrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalArticlexrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalArticlexrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalArticlexrefModel(LocalProvider provider, ArticlexrefRecord record) : base(provider, record)
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
            if (_relArticle != null)
            {
                _relArticle.Save();
                this.ModifiedData.RelArtiId = _relArticle.Id;
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
        ///     Gets or sets the value of the "ARTIXREF_ADD_DATE" field.
        /// </summary>
        System.DateTime IArticlexrefModel.AddDate
        {
            get { return this.AddDate; }
            set { this.AddDate = (System.DateTime)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTIXREF_ARTI_ID" field.
        /// </summary>
        System.String IArticlexrefModel.ArtiId
        {
            get { return this.ArtiId; }
            set { this.ArtiId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        Consensus.Document.IArticleModel IArticlexrefModel.RelArticle
        {
            get { return this.RelArticle; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        System.Int32 IArticlexrefModel.RelArticleId
        {
            get { return this.RelArticleId; }
            set { this.RelArticleId = (System.Int32)value; }
        }

        #endregion
    }
}
