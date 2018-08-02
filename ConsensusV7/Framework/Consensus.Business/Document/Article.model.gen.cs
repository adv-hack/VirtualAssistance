using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="ArticleRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IArticleModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "ARTI_TYPE" field.
        /// </summary>
        System.Byte Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_STATE" field.
        /// </summary>
        System.Byte State
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> AddDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_NOTES_HTML" field.
        /// </summary>
        System.String NotesHtml
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel ArtGroup
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_GROUP" field.
        /// </summary>
        System.String ArtGroupCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_KEYWORDS" field.
        /// </summary>
        System.String Keywords
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel ArtCategory
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_CATEGORY" field.
        /// </summary>
        System.String ArtCategoryCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_SUMMARY" field.
        /// </summary>
        System.String Summary
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_SUMMARY_HTML" field.
        /// </summary>
        System.String SummaryHtml
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_WEB" field.
        /// </summary>
        System.Byte Web
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_IMAGE" field.
        /// </summary>
        System.String Image
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ARTI_FEATURED" field.
        /// </summary>
        System.Byte Featured
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ARTI_AREA" field.
        /// </summary>
        Consensus.Common.ICodeModel ArtArea
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ARTI_AREA" field.
        /// </summary>
        System.String ArtAreaCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ArticlexrefModel" /> instances that reference this <see cref="!:ArticleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IArticlexrefModel> ArticlesXrefs
        {
            get;
        }
    }
}
