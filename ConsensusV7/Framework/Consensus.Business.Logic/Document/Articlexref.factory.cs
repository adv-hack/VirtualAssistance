using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ArticlexrefModel" /> object.
    /// </summary>
    public partial class LocalArticlexrefFactory
    {
        /// <summary>
        /// Checks if the related article is already linked to the Parent article
        /// </summary>
        /// <param name="articleId">Parent Article ID</param>
        /// <param name="relatedArticleId">Related Article ID</param>
        /// <param name="articleXrefId">ArticleXref ID</param>
        /// <returns>Whether the related article is already linked or not </returns>
        public bool CheckIfRelatedArticleExist(string articleId, string relatedArticleId,string articleXrefId)
        {
            var articles = this.FetchAll();
            var relatedArticleList = articles.Where(x => x.ArtiId == articleId && x.RelArticleId == Convert.ToInt32(relatedArticleId)).ToList();
            bool result = false;
            if (relatedArticleList.Count > 0)
            {
                if (string.IsNullOrEmpty(articleXrefId))
                {
                    result = true;
                }
                else
                {
                    if (relatedArticleList.All(x => x.Id != Convert.ToInt32(articleXrefId)))
                    {
                        result = true;
                    }
                }
            }
            return result;

        }
    }
}
