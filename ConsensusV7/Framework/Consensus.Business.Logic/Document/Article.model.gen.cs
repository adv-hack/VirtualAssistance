using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="ArticleRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalArticleModel : LocalModel<ArticleRecord, Int32>, IArticleModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ARTI_GROUP" field.
        /// </summary>
        private LocalCodeModel _artGroup;

        /// <summary>
        ///     The value of the "ARTI_CATEGORY" field.
        /// </summary>
        private LocalCodeModel _artCategory;

        /// <summary>
        ///     The value of the "ARTI_AREA" field.
        /// </summary>
        private LocalCodeModel _artArea;

        /// <summary>
        ///     The collection of <see cref="ArticlexrefModel" /> instances that reference this <see cref="ArticleModel" />.
        /// </summary>
        private LocalCollection<LocalArticlexrefModel, IArticlexrefModel> _articlesXrefs;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ArticleRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.Article.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ArticleRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.Article.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ArticleRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.Article.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_STATE" field.
        /// </summary>
        public Byte State
        {
            get { return this.ModifiedData.State; }
            set { this.ModifiedData.State = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return this.ModifiedData.AddDate; }
            set { this.ModifiedData.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NOTES_HTML" field.
        /// </summary>
        public String NotesHtml
        {
            get { return this.ModifiedData.NotesHtml; }
            set { this.ModifiedData.NotesHtml = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_GROUP" field.
        /// </summary>
        public LocalCodeModel ArtGroup
        {
            get
            {
                if (_artGroup == null && !String.IsNullOrEmpty(this.ArtGroupCode))
                    _artGroup = this.Provider.Common.Code.FetchByTypeAndCode("ARTGR", this.ArtGroupCode);
                if (_artGroup == null)
                    _artGroup = this.Provider.Common.Code.Create("ARTGR");
                return _artGroup;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_GROUP" field.
        /// </summary>
        public String ArtGroupCode
        {
            get { return this.ModifiedData.Group; }
            set
            {
                if (this.ModifiedData.Group != value)
                     _artGroup = null;
                this.ModifiedData.Group = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_KEYWORDS" field.
        /// </summary>
        public String Keywords
        {
            get { return this.ModifiedData.Keywords; }
            set { this.ModifiedData.Keywords = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_CATEGORY" field.
        /// </summary>
        public LocalCodeModel ArtCategory
        {
            get
            {
                if (_artCategory == null && !String.IsNullOrEmpty(this.ArtCategoryCode))
                    _artCategory = this.Provider.Common.Code.FetchByTypeAndCode("ARTCA", this.ArtCategoryCode);
                if (_artCategory == null)
                    _artCategory = this.Provider.Common.Code.Create("ARTCA");
                return _artCategory;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_CATEGORY" field.
        /// </summary>
        public String ArtCategoryCode
        {
            get { return this.ModifiedData.Category; }
            set
            {
                if (this.ModifiedData.Category != value)
                     _artCategory = null;
                this.ModifiedData.Category = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_SUMMARY" field.
        /// </summary>
        public String Summary
        {
            get { return this.ModifiedData.Summary; }
            set { this.ModifiedData.Summary = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_SUMMARY_HTML" field.
        /// </summary>
        public String SummaryHtml
        {
            get { return this.ModifiedData.SummaryHtml; }
            set { this.ModifiedData.SummaryHtml = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return this.ModifiedData.Web; }
            set { this.ModifiedData.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_IMAGE" field.
        /// </summary>
        public String Image
        {
            get { return this.ModifiedData.Image; }
            set { this.ModifiedData.Image = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_FEATURED" field.
        /// </summary>
        public Byte Featured
        {
            get { return this.ModifiedData.Featured; }
            set { this.ModifiedData.Featured = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_AREA" field.
        /// </summary>
        public LocalCodeModel ArtArea
        {
            get
            {
                if (_artArea == null && !String.IsNullOrEmpty(this.ArtAreaCode))
                    _artArea = this.Provider.Common.Code.FetchByTypeAndCode("ARTAR", this.ArtAreaCode);
                if (_artArea == null)
                    _artArea = this.Provider.Common.Code.Create("ARTAR");
                return _artArea;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_AREA" field.
        /// </summary>
        public String ArtAreaCode
        {
            get { return this.ModifiedData.Area; }
            set
            {
                if (this.ModifiedData.Area != value)
                     _artArea = null;
                this.ModifiedData.Area = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ArticlexrefModel" /> instances that reference this <see cref="ArticleModel" />.
        /// </summary>
        public LocalCollection<LocalArticlexrefModel, IArticlexrefModel> ArticlesXrefs
        {
            get
            {
                if (_articlesXrefs == null)
                    _articlesXrefs = new LocalCollection<LocalArticlexrefModel, IArticlexrefModel>(this.Provider.Document.Articlexref.FetchAllByRelArticleId(this.Id));
                
                return _articlesXrefs;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalArticleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalArticleModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalArticleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalArticleModel(LocalProvider provider, ArticleRecord record) : base(provider, record)
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
            if (_artGroup != null)
            {
                _artGroup.Save();
                this.ModifiedData.Group = _artGroup.Value1;
            }
            if (_artCategory != null)
            {
                _artCategory.Save();
                this.ModifiedData.Category = _artCategory.Value1;
            }
            if (_artArea != null)
            {
                _artArea.Save();
                this.ModifiedData.Area = _artArea.Value1;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_articlesXrefs != null)
                _articlesXrefs.Execute(obj => obj.RelArticleId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "ARTI_TYPE" field.
        /// </summary>
        System.Byte IArticleModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_STATE" field.
        /// </summary>
        System.Byte IArticleModel.State
        {
            get { return this.State; }
            set { this.State = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IArticleModel.AddDate
        {
            get { return this.AddDate; }
            set { this.AddDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NAME" field.
        /// </summary>
        System.String IArticleModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NOTES" field.
        /// </summary>
        System.String IArticleModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NOTES_HTML" field.
        /// </summary>
        System.String IArticleModel.NotesHtml
        {
            get { return this.NotesHtml; }
            set { this.NotesHtml = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel IArticleModel.ArtGroup
        {
            get { return this.ArtGroup; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_GROUP" field.
        /// </summary>
        System.String IArticleModel.ArtGroupCode
        {
            get { return this.ArtGroupCode; }
            set { this.ArtGroupCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_KEYWORDS" field.
        /// </summary>
        System.String IArticleModel.Keywords
        {
            get { return this.Keywords; }
            set { this.Keywords = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel IArticleModel.ArtCategory
        {
            get { return this.ArtCategory; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_CATEGORY" field.
        /// </summary>
        System.String IArticleModel.ArtCategoryCode
        {
            get { return this.ArtCategoryCode; }
            set { this.ArtCategoryCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_SUMMARY" field.
        /// </summary>
        System.String IArticleModel.Summary
        {
            get { return this.Summary; }
            set { this.Summary = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_SUMMARY_HTML" field.
        /// </summary>
        System.String IArticleModel.SummaryHtml
        {
            get { return this.SummaryHtml; }
            set { this.SummaryHtml = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_WEB" field.
        /// </summary>
        System.Byte IArticleModel.Web
        {
            get { return this.Web; }
            set { this.Web = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_IMAGE" field.
        /// </summary>
        System.String IArticleModel.Image
        {
            get { return this.Image; }
            set { this.Image = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_FEATURED" field.
        /// </summary>
        System.Byte IArticleModel.Featured
        {
            get { return this.Featured; }
            set { this.Featured = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_AREA" field.
        /// </summary>
        Consensus.Common.ICodeModel IArticleModel.ArtArea
        {
            get { return this.ArtArea; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_AREA" field.
        /// </summary>
        System.String IArticleModel.ArtAreaCode
        {
            get { return this.ArtAreaCode; }
            set { this.ArtAreaCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ArticlexrefModel" /> instances that reference this <see cref="!:ArticleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IArticlexrefModel> IArticleModel.ArticlesXrefs
        {
            get { return this.ArticlesXrefs; }
        }

        #endregion
    }
}
