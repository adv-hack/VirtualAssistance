using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ArticlexrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalArticlexrefFactory : LocalFactory<LocalArticlexrefModel, ArticlexrefRecord, Int32>, IArticlexrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ArticlexrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ArticlexrefModel' /> instance.
        /// </returns>
        public LocalArticlexrefModel Create()
        {
            return new LocalArticlexrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ArticlexrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ArticlexrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalArticlexrefModel> FetchAll()
        {
            IEnumerable<ArticlexrefRecord> recordCollection = this.Provider.DataProvider.Document.Articlexref.FetchAll();
            foreach (ArticlexrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalArticlexrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ArticlexrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ArticlexrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ArticlexrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalArticlexrefModel FetchById(Int32 id)
        {
            ArticlexrefRecord record = this.Provider.DataProvider.Document.Articlexref.FetchById(id);
            if (record == null)
                return null;
            return new LocalArticlexrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Articlexref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.Articlexref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ArticlexrefModel' /> instances.
        /// </summary>
        /// <param name="relArticleId">
        ///     The value which identifies the <see cref='ArticlexrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ArticlexrefModel' /> instances that match the specified <paramref name='relArticleId' />.
        /// </returns>
        public IEnumerable<LocalArticlexrefModel> FetchAllByRelArticleId(Int32 relArticleId)
        {
            IEnumerable<ArticlexrefRecord> recordCollection = this.Provider.DataProvider.Document.Articlexref.FetchAllByRelArtiId(relArticleId);
            foreach (ArticlexrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalArticlexrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

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
        System.Boolean IArticlexrefFactory.CheckIfRelatedArticleExist(System.String articleId, System.String relatedArticleId, System.String articleXrefId)
        {
            return this.CheckIfRelatedArticleExist(articleId, relatedArticleId, articleXrefId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ArticlexrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ArticlexrefModel" /> instance.
        /// </returns>
        Consensus.Document.IArticlexrefModel IArticlexrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ArticlexrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ArticlexrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IArticlexrefModel> IArticlexrefFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Document.IArticlexrefModel IArticlexrefFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IArticlexrefFactory.GetTableName()
        {
            return this.GetTableName();
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
        System.Collections.Generic.IEnumerable<Consensus.Document.IArticlexrefModel> IArticlexrefFactory.FetchAllByRelArticleId(System.Int32 relArticleId)
        {
            return this.FetchAllByRelArticleId(relArticleId);
        }

        #endregion
    }
}
