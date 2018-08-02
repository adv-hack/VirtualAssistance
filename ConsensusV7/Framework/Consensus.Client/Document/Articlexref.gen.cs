using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Articlexref : Proxy<IArticlexrefModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RelArticle" /> member.
        /// </summary>
        private Consensus.Document.Article _relArticle;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "ARTIXREF_ADD_DATE" field.
        /// </summary>
        public System.DateTime AddDate
        {
            get { return this.Model.AddDate; }
            set { this.Model.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTIXREF_ARTI_ID" field.
        /// </summary>
        public System.String ArtiId
        {
            get { return this.Model.ArtiId; }
            set { this.Model.ArtiId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        public Consensus.Document.Article RelArticle
        {
            get
            {
                if (_relArticle == null && this.Model.RelArticle != null)
                    _relArticle = new Consensus.Document.Article(this.Model.RelArticle);
                if (_relArticle == null)
                    _relArticle = Consensus.Document.Article.Create();
                return _relArticle;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        public System.Int32 RelArticleId
        {
            get { return this.Model.RelArticleId; }
            set { this.Model.RelArticleId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Articlexref(IArticlexrefModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Checks if the related article is already linked to the Parent article.
        /// </summary>
        /// <param name="articleId">
        ///     Parent Article ID.
        /// </param>
        /// <param name="relatedArticleId">
        ///     Related Article ID.
        /// </param>
        /// <param name="articleXrefId">
        ///     ArticleXref ID.
        /// </param>
        /// <returns>
        ///     Whether the related article is already linked or not.
        /// </returns>
        public static System.Boolean CheckIfRelatedArticleExist(System.String articleId, System.String relatedArticleId, System.String articleXrefId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Articlexref.CheckIfRelatedArticleExist(site,articleId,relatedArticleId,articleXrefId);
        }

        /// <summary>
        ///     Checks if the related article is already linked to the Parent article.
        /// </summary>
        /// <param name="articleId">
        ///     Parent Article ID.
        /// </param>
        /// <param name="relatedArticleId">
        ///     Related Article ID.
        /// </param>
        /// <param name="articleXrefId">
        ///     ArticleXref ID.
        /// </param>
        /// <returns>
        ///     Whether the related article is already linked or not.
        /// </returns>
        public static System.Boolean CheckIfRelatedArticleExist(ConsensusSite site, System.String articleId, System.String relatedArticleId, System.String articleXrefId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.Articlexref.CheckIfRelatedArticleExist(articleId,relatedArticleId,articleXrefId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ArticlexrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ArticlexrefModel" /> instance.
        /// </returns>
        public static Consensus.Document.Articlexref Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Articlexref.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ArticlexrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ArticlexrefModel" /> instance.
        /// </returns>
        public static Consensus.Document.Articlexref Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IArticlexrefModel model = provider.Document.Articlexref.Create();
            return model == null ? null : new Consensus.Document.Articlexref(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ArticlexrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ArticlexrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.Articlexref> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Articlexref.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ArticlexrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ArticlexrefModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.Articlexref> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IArticlexrefModel> collection = provider.Document.Articlexref.FetchAll();
            return collection.Select(model => new Consensus.Document.Articlexref(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ArticlexrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ArticlexrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ArticlexrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.Articlexref FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Articlexref.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ArticlexrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ArticlexrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ArticlexrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.Articlexref FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IArticlexrefModel model = provider.Document.Articlexref.FetchById(id);
            return model == null ? null : new Consensus.Document.Articlexref(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Articlexref.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.Articlexref.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ArticlexrefModel" /> instances.
        /// </summary>
        /// <param name="relArticleId">
        ///     The value which identifies the <see cref="!:ArticlexrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ArticlexrefModel" /> instances that match the specified <paramref name="relArticleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Articlexref> FetchAllByRelArticleId(System.Int32 relArticleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Articlexref.FetchAllByRelArticleId(site,relArticleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ArticlexrefModel" /> instances.
        /// </summary>
        /// <param name="relArticleId">
        ///     The value which identifies the <see cref="!:ArticlexrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ArticlexrefModel" /> instances that match the specified <paramref name="relArticleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Articlexref> FetchAllByRelArticleId(ConsensusSite site, System.Int32 relArticleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IArticlexrefModel> collection = provider.Document.Articlexref.FetchAllByRelArticleId(relArticleId);
            return collection.Select(model => new Consensus.Document.Articlexref(model));
        }

        #endregion
    }
}
