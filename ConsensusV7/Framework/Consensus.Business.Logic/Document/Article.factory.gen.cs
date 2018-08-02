using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ArticleModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalArticleFactory : LocalFactory<LocalArticleModel, ArticleRecord, Int32>, IArticleFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ArticleModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ArticleModel' /> instance.
        /// </returns>
        public LocalArticleModel Create()
        {
            return new LocalArticleModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ArticleModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ArticleModel' /> instances.
        /// </returns>
        public IEnumerable<LocalArticleModel> FetchAll()
        {
            IEnumerable<ArticleRecord> recordCollection = this.Provider.DataProvider.Document.Article.FetchAll();
            foreach (ArticleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalArticleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ArticleModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ArticleModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ArticleModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalArticleModel FetchById(Int32 id)
        {
            ArticleRecord record = this.Provider.DataProvider.Document.Article.FetchById(id);
            if (record == null)
                return null;
            return new LocalArticleModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Article/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.Article.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ArticleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ArticleModel" /> instance.
        /// </returns>
        Consensus.Document.IArticleModel IArticleFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ArticleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ArticleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IArticleModel> IArticleFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Document.IArticleModel IArticleFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IArticleFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
