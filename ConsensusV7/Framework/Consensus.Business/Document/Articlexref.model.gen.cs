using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="ArticlexrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IArticlexrefModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "ARTIXREF_ADD_DATE" field.
        /// </summary>
        System.DateTime AddDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTIXREF_ARTI_ID" field.
        /// </summary>
        System.String ArtiId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        Consensus.Document.IArticleModel RelArticle
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        System.Int32 RelArticleId
        {
            get;
            set;
        }
    }
}
