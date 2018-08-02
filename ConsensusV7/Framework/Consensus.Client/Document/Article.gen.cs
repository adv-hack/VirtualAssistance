using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Article : Proxy<IArticleModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ArtGroup" /> member.
        /// </summary>
        private Consensus.Common.Code _artGroup;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ArtCategory" /> member.
        /// </summary>
        private Consensus.Common.Code _artCategory;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ArtArea" /> member.
        /// </summary>
        private Consensus.Common.Code _artArea;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ArticlesXrefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.Articlexref, Consensus.Document.IArticlexrefModel> _articlesXrefs;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "ARTI_TYPE" field.
        /// </summary>
        public System.Byte Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_STATE" field.
        /// </summary>
        public System.Byte State
        {
            get { return this.Model.State; }
            set { this.Model.State = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_ADD_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> AddDate
        {
            get { return this.Model.AddDate; }
            set { this.Model.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NOTES_HTML" field.
        /// </summary>
        public System.String NotesHtml
        {
            get { return this.Model.NotesHtml; }
            set { this.Model.NotesHtml = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_GROUP" field.
        /// </summary>
        public Consensus.Common.Code ArtGroup
        {
            get
            {
                if (_artGroup == null && this.Model.ArtGroup != null)
                    _artGroup = new Consensus.Common.Code(this.Model.ArtGroup);
                if (_artGroup == null)
                    _artGroup = Consensus.Common.Code.Create();
                return _artGroup;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_GROUP" field.
        /// </summary>
        public System.String ArtGroupCode
        {
            get { return this.Model.ArtGroupCode; }
            set { this.Model.ArtGroupCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_KEYWORDS" field.
        /// </summary>
        public System.String Keywords
        {
            get { return this.Model.Keywords; }
            set { this.Model.Keywords = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_CATEGORY" field.
        /// </summary>
        public Consensus.Common.Code ArtCategory
        {
            get
            {
                if (_artCategory == null && this.Model.ArtCategory != null)
                    _artCategory = new Consensus.Common.Code(this.Model.ArtCategory);
                if (_artCategory == null)
                    _artCategory = Consensus.Common.Code.Create();
                return _artCategory;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_CATEGORY" field.
        /// </summary>
        public System.String ArtCategoryCode
        {
            get { return this.Model.ArtCategoryCode; }
            set { this.Model.ArtCategoryCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_SUMMARY" field.
        /// </summary>
        public System.String Summary
        {
            get { return this.Model.Summary; }
            set { this.Model.Summary = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_SUMMARY_HTML" field.
        /// </summary>
        public System.String SummaryHtml
        {
            get { return this.Model.SummaryHtml; }
            set { this.Model.SummaryHtml = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_WEB" field.
        /// </summary>
        public System.Byte Web
        {
            get { return this.Model.Web; }
            set { this.Model.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_IMAGE" field.
        /// </summary>
        public System.String Image
        {
            get { return this.Model.Image; }
            set { this.Model.Image = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_FEATURED" field.
        /// </summary>
        public System.Byte Featured
        {
            get { return this.Model.Featured; }
            set { this.Model.Featured = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_AREA" field.
        /// </summary>
        public Consensus.Common.Code ArtArea
        {
            get
            {
                if (_artArea == null && this.Model.ArtArea != null)
                    _artArea = new Consensus.Common.Code(this.Model.ArtArea);
                if (_artArea == null)
                    _artArea = Consensus.Common.Code.Create();
                return _artArea;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_AREA" field.
        /// </summary>
        public System.String ArtAreaCode
        {
            get { return this.Model.ArtAreaCode; }
            set { this.Model.ArtAreaCode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ArticlexrefModel" /> instances that reference this <see cref="!:ArticleModel" />.
        /// </summary>
        public Collection<Consensus.Document.Articlexref> ArticlesXrefs
        {
            get
            {
                if (_articlesXrefs == null)
                    _articlesXrefs = new ProxyCollection<Consensus.Document.Articlexref, Consensus.Document.IArticlexrefModel>(this.Model.ArticlesXrefs, model => new Consensus.Document.Articlexref(model));
                return _articlesXrefs;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Article(IArticleModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ArticleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ArticleModel" /> instance.
        /// </returns>
        public static Consensus.Document.Article Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Article.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ArticleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ArticleModel" /> instance.
        /// </returns>
        public static Consensus.Document.Article Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IArticleModel model = provider.Document.Article.Create();
            return model == null ? null : new Consensus.Document.Article(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ArticleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ArticleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.Article> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Article.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ArticleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ArticleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.Article> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IArticleModel> collection = provider.Document.Article.FetchAll();
            return collection.Select(model => new Consensus.Document.Article(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ArticleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ArticleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ArticleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.Article FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Article.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ArticleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ArticleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ArticleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.Article FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IArticleModel model = provider.Document.Article.FetchById(id);
            return model == null ? null : new Consensus.Document.Article(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Article.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.Article.GetTableName();
        }

        #endregion
    }
}
