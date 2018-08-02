using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Document namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerDocumentRepositoryCollection : SqlServerRepositoryCollection, IDocumentRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PackRecord" /> data structure.
        /// </summary>
        private SqlServerPackRepository _pack;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProductPackRecord" /> data structure.
        /// </summary>
        private SqlServerPackProductRepository _packProduct;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LettertmpltRecord" /> data structure.
        /// </summary>
        private SqlServerLetterTemplateRepository _letterTemplate;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LettmplttypeRecord" /> data structure.
        /// </summary>
        private SqlServerLetterTemplateTypeRepository _letterTemplateType;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PrintQueueRecord" /> data structure.
        /// </summary>
        private SqlServerOutputQueueRepository _outputQueue;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="IcalmessageRecord" /> data structure.
        /// </summary>
        private SqlServerICalMessageRepository _iCalMessage;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="IcalmessagetypeRecord" /> data structure.
        /// </summary>
        private SqlServerICalMessageTypeRepository _iCalMessageType;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PacktypeRecord" /> data structure.
        /// </summary>
        private SqlServerPacktypeRepository _packtype;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SmsMessageRecord" /> data structure.
        /// </summary>
        private SqlServerSmsMessageRepository _smsMessage;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SmsTypeRecord" /> data structure.
        /// </summary>
        private SqlServerSmsTypeRepository _smsType;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PackXrefRecord" /> data structure.
        /// </summary>
        private SqlServerPackXrefRepository _packXref;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LiteratureRecord" /> data structure.
        /// </summary>
        private SqlServerLiteratureRepository _literature;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PrintReqRecord" /> data structure.
        /// </summary>
        private SqlServerPrintRequestRepository _printRequest;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ArticleRecord" /> data structure.
        /// </summary>
        private SqlServerArticleRepository _article;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ArticlexrefRecord" /> data structure.
        /// </summary>
        private SqlServerArticlexrefRepository _articlexref;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PackRecord" /> data structure.
        /// </summary>
        public SqlServerPackRepository Pack
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPackRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _pack);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProductPackRecord" /> data structure.
        /// </summary>
        public SqlServerPackProductRepository PackProduct
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPackProductRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _packProduct);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LettertmpltRecord" /> data structure.
        /// </summary>
        public SqlServerLetterTemplateRepository LetterTemplate
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerLetterTemplateRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _letterTemplate);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LettmplttypeRecord" /> data structure.
        /// </summary>
        public SqlServerLetterTemplateTypeRepository LetterTemplateType
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerLetterTemplateTypeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _letterTemplateType);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PrintQueueRecord" /> data structure.
        /// </summary>
        public SqlServerOutputQueueRepository OutputQueue
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerOutputQueueRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _outputQueue);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="IcalmessageRecord" /> data structure.
        /// </summary>
        public SqlServerICalMessageRepository ICalMessage
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerICalMessageRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _iCalMessage);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="IcalmessagetypeRecord" /> data structure.
        /// </summary>
        public SqlServerICalMessageTypeRepository ICalMessageType
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerICalMessageTypeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _iCalMessageType);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PacktypeRecord" /> data structure.
        /// </summary>
        public SqlServerPacktypeRepository Packtype
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPacktypeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _packtype);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SmsMessageRecord" /> data structure.
        /// </summary>
        public SqlServerSmsMessageRepository SmsMessage
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSmsMessageRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _smsMessage);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SmsTypeRecord" /> data structure.
        /// </summary>
        public SqlServerSmsTypeRepository SmsType
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSmsTypeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _smsType);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PackXrefRecord" /> data structure.
        /// </summary>
        public SqlServerPackXrefRepository PackXref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPackXrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _packXref);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LiteratureRecord" /> data structure.
        /// </summary>
        public SqlServerLiteratureRepository Literature
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerLiteratureRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _literature);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PrintReqRecord" /> data structure.
        /// </summary>
        public SqlServerPrintRequestRepository PrintRequest
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPrintRequestRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _printRequest);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ArticleRecord" /> data structure.
        /// </summary>
        public SqlServerArticleRepository Article
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerArticleRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _article);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ArticlexrefRecord" /> data structure.
        /// </summary>
        public SqlServerArticlexrefRepository Articlexref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerArticlexrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _articlexref);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.PackRecord" /> data structure.
        /// </summary>
        Consensus.Document.IPackRepository IDocumentRepositoryCollection.Pack
        {
            get { return this.Pack; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.ProductPackRecord" /> data structure.
        /// </summary>
        Consensus.Document.IPackProductRepository IDocumentRepositoryCollection.PackProduct
        {
            get { return this.PackProduct; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.LettertmpltRecord" /> data structure.
        /// </summary>
        Consensus.Document.ILetterTemplateRepository IDocumentRepositoryCollection.LetterTemplate
        {
            get { return this.LetterTemplate; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.LettmplttypeRecord" /> data structure.
        /// </summary>
        Consensus.Document.ILetterTemplateTypeRepository IDocumentRepositoryCollection.LetterTemplateType
        {
            get { return this.LetterTemplateType; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.PrintQueueRecord" /> data structure.
        /// </summary>
        Consensus.Document.IOutputQueueRepository IDocumentRepositoryCollection.OutputQueue
        {
            get { return this.OutputQueue; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.IcalmessageRecord" /> data structure.
        /// </summary>
        Consensus.Document.IICalMessageRepository IDocumentRepositoryCollection.ICalMessage
        {
            get { return this.ICalMessage; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.IcalmessagetypeRecord" /> data structure.
        /// </summary>
        Consensus.Document.IICalMessageTypeRepository IDocumentRepositoryCollection.ICalMessageType
        {
            get { return this.ICalMessageType; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.PacktypeRecord" /> data structure.
        /// </summary>
        Consensus.Document.IPacktypeRepository IDocumentRepositoryCollection.Packtype
        {
            get { return this.Packtype; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.SmsMessageRecord" /> data structure.
        /// </summary>
        Consensus.Document.ISmsMessageRepository IDocumentRepositoryCollection.SmsMessage
        {
            get { return this.SmsMessage; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.SmsTypeRecord" /> data structure.
        /// </summary>
        Consensus.Document.ISmsTypeRepository IDocumentRepositoryCollection.SmsType
        {
            get { return this.SmsType; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.PackXrefRecord" /> data structure.
        /// </summary>
        Consensus.Document.IPackXrefRepository IDocumentRepositoryCollection.PackXref
        {
            get { return this.PackXref; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.LiteratureRecord" /> data structure.
        /// </summary>
        Consensus.Document.ILiteratureRepository IDocumentRepositoryCollection.Literature
        {
            get { return this.Literature; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.PrintReqRecord" /> data structure.
        /// </summary>
        Consensus.Document.IPrintRequestRepository IDocumentRepositoryCollection.PrintRequest
        {
            get { return this.PrintRequest; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.ArticleRecord" /> data structure.
        /// </summary>
        Consensus.Document.IArticleRepository IDocumentRepositoryCollection.Article
        {
            get { return this.Article; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Document.ArticlexrefRecord" /> data structure.
        /// </summary>
        Consensus.Document.IArticlexrefRepository IDocumentRepositoryCollection.Articlexref
        {
            get { return this.Articlexref; }
        }

        #endregion
    }
}
