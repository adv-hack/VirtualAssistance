using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ArticlexrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IArticlexrefFactory : IFactory<IArticlexrefModel, Int32>
    {
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
        System.Boolean CheckIfRelatedArticleExist(System.String articleId, System.String relatedArticleId, System.String articleXrefId);

        /// <summary>
        ///     Creates a new <see cref="!:ArticlexrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ArticlexrefModel" /> instance.
        /// </returns>
        Consensus.Document.IArticlexrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ArticlexrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ArticlexrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IArticlexrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ArticlexrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ArticlexrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ArticlexrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IArticlexrefModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ArticlexrefModel" /> instances.
        /// </summary>
        /// <param name="relArticleId">
        ///     The value which identifies the <see cref="!:ArticlexrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ArticlexrefModel" /> instances that match the specified <paramref name="relArticleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IArticlexrefModel> FetchAllByRelArticleId(System.Int32 relArticleId);
    }
}
