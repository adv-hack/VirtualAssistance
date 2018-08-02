using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ArticleModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IArticleFactory : IFactory<IArticleModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ArticleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ArticleModel" /> instance.
        /// </returns>
        Consensus.Document.IArticleModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ArticleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ArticleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IArticleModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ArticleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ArticleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ArticleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IArticleModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
