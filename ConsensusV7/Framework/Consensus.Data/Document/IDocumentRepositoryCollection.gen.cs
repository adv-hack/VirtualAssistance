using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     The repository collection which pertains to the Document namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IDocumentRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.PackRecord" /> data structure.
        /// </summary>
        Consensus.Document.IPackRepository Pack
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.ProductPackRecord" /> data structure.
        /// </summary>
        Consensus.Document.IPackProductRepository PackProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.LettertmpltRecord" /> data structure.
        /// </summary>
        Consensus.Document.ILetterTemplateRepository LetterTemplate
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.LettmplttypeRecord" /> data structure.
        /// </summary>
        Consensus.Document.ILetterTemplateTypeRepository LetterTemplateType
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.PrintQueueRecord" /> data structure.
        /// </summary>
        Consensus.Document.IOutputQueueRepository OutputQueue
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.IcalmessageRecord" /> data structure.
        /// </summary>
        Consensus.Document.IICalMessageRepository ICalMessage
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.IcalmessagetypeRecord" /> data structure.
        /// </summary>
        Consensus.Document.IICalMessageTypeRepository ICalMessageType
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.PacktypeRecord" /> data structure.
        /// </summary>
        Consensus.Document.IPacktypeRepository Packtype
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.SmsMessageRecord" /> data structure.
        /// </summary>
        Consensus.Document.ISmsMessageRepository SmsMessage
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.SmsTypeRecord" /> data structure.
        /// </summary>
        Consensus.Document.ISmsTypeRepository SmsType
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.PackXrefRecord" /> data structure.
        /// </summary>
        Consensus.Document.IPackXrefRepository PackXref
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.LiteratureRecord" /> data structure.
        /// </summary>
        Consensus.Document.ILiteratureRepository Literature
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.PrintReqRecord" /> data structure.
        /// </summary>
        Consensus.Document.IPrintRequestRepository PrintRequest
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.ArticleRecord" /> data structure.
        /// </summary>
        Consensus.Document.IArticleRepository Article
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.ArticlexrefRecord" /> data structure.
        /// </summary>
        Consensus.Document.IArticlexrefRepository Articlexref
        {
            get;
        }
    }
}
