using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Document namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalDocumentFactoryCollection : LocalFactoryCollection, IDocumentFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PackModel" /> objects.
        /// </summary>
        private LocalPackFactory _pack;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PackProductModel" /> objects.
        /// </summary>
        private LocalPackProductFactory _packProduct;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="LetterTemplateModel" /> objects.
        /// </summary>
        private LocalLetterTemplateFactory _letterTemplate;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="LetterTemplateTypeModel" /> objects.
        /// </summary>
        private LocalLetterTemplateTypeFactory _letterTemplateType;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="OutputQueueModel" /> objects.
        /// </summary>
        private LocalOutputQueueFactory _outputQueue;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ICalMessageModel" /> objects.
        /// </summary>
        private LocalICalMessageFactory _iCalMessage;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ICalMessageTypeModel" /> objects.
        /// </summary>
        private LocalICalMessageTypeFactory _iCalMessageType;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PacktypeModel" /> objects.
        /// </summary>
        private LocalPacktypeFactory _packtype;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SmsMessageModel" /> objects.
        /// </summary>
        private LocalSmsMessageFactory _smsMessage;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SmsTypeModel" /> objects.
        /// </summary>
        private LocalSmsTypeFactory _smsType;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PackXrefModel" /> objects.
        /// </summary>
        private LocalPackXrefFactory _packXref;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="LiteratureModel" /> objects.
        /// </summary>
        private LocalLiteratureFactory _literature;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PrintRequestModel" /> objects.
        /// </summary>
        private LocalPrintRequestFactory _printRequest;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ArticleModel" /> objects.
        /// </summary>
        private LocalArticleFactory _article;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ArticlexrefModel" /> objects.
        /// </summary>
        private LocalArticlexrefFactory _articlexref;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PackModel" /> objects.
        /// </summary>
        public LocalPackFactory Pack
        {
            get { return LocalFactory.Create(this.Provider, ref _pack); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PackProductModel" /> objects.
        /// </summary>
        public LocalPackProductFactory PackProduct
        {
            get { return LocalFactory.Create(this.Provider, ref _packProduct); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="LetterTemplateModel" /> objects.
        /// </summary>
        public LocalLetterTemplateFactory LetterTemplate
        {
            get { return LocalFactory.Create(this.Provider, ref _letterTemplate); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="LetterTemplateTypeModel" /> objects.
        /// </summary>
        public LocalLetterTemplateTypeFactory LetterTemplateType
        {
            get { return LocalFactory.Create(this.Provider, ref _letterTemplateType); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="OutputQueueModel" /> objects.
        /// </summary>
        public LocalOutputQueueFactory OutputQueue
        {
            get { return LocalFactory.Create(this.Provider, ref _outputQueue); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ICalMessageModel" /> objects.
        /// </summary>
        public LocalICalMessageFactory ICalMessage
        {
            get { return LocalFactory.Create(this.Provider, ref _iCalMessage); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ICalMessageTypeModel" /> objects.
        /// </summary>
        public LocalICalMessageTypeFactory ICalMessageType
        {
            get { return LocalFactory.Create(this.Provider, ref _iCalMessageType); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PacktypeModel" /> objects.
        /// </summary>
        public LocalPacktypeFactory Packtype
        {
            get { return LocalFactory.Create(this.Provider, ref _packtype); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SmsMessageModel" /> objects.
        /// </summary>
        public LocalSmsMessageFactory SmsMessage
        {
            get { return LocalFactory.Create(this.Provider, ref _smsMessage); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SmsTypeModel" /> objects.
        /// </summary>
        public LocalSmsTypeFactory SmsType
        {
            get { return LocalFactory.Create(this.Provider, ref _smsType); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PackXrefModel" /> objects.
        /// </summary>
        public LocalPackXrefFactory PackXref
        {
            get { return LocalFactory.Create(this.Provider, ref _packXref); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="LiteratureModel" /> objects.
        /// </summary>
        public LocalLiteratureFactory Literature
        {
            get { return LocalFactory.Create(this.Provider, ref _literature); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PrintRequestModel" /> objects.
        /// </summary>
        public LocalPrintRequestFactory PrintRequest
        {
            get { return LocalFactory.Create(this.Provider, ref _printRequest); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ArticleModel" /> objects.
        /// </summary>
        public LocalArticleFactory Article
        {
            get { return LocalFactory.Create(this.Provider, ref _article); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ArticlexrefModel" /> objects.
        /// </summary>
        public LocalArticlexrefFactory Articlexref
        {
            get { return LocalFactory.Create(this.Provider, ref _articlexref); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PackModel" /> objects.
        /// </summary>
        Consensus.Document.IPackFactory IDocumentFactoryCollection.Pack
        {
            get { return this.Pack; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PackProductModel" /> objects.
        /// </summary>
        Consensus.Document.IPackProductFactory IDocumentFactoryCollection.PackProduct
        {
            get { return this.PackProduct; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LetterTemplateModel" /> objects.
        /// </summary>
        Consensus.Document.ILetterTemplateFactory IDocumentFactoryCollection.LetterTemplate
        {
            get { return this.LetterTemplate; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LetterTemplateTypeModel" /> objects.
        /// </summary>
        Consensus.Document.ILetterTemplateTypeFactory IDocumentFactoryCollection.LetterTemplateType
        {
            get { return this.LetterTemplateType; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OutputQueueModel" /> objects.
        /// </summary>
        Consensus.Document.IOutputQueueFactory IDocumentFactoryCollection.OutputQueue
        {
            get { return this.OutputQueue; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ICalMessageModel" /> objects.
        /// </summary>
        Consensus.Document.IICalMessageFactory IDocumentFactoryCollection.ICalMessage
        {
            get { return this.ICalMessage; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ICalMessageTypeModel" /> objects.
        /// </summary>
        Consensus.Document.IICalMessageTypeFactory IDocumentFactoryCollection.ICalMessageType
        {
            get { return this.ICalMessageType; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PacktypeModel" /> objects.
        /// </summary>
        Consensus.Document.IPacktypeFactory IDocumentFactoryCollection.Packtype
        {
            get { return this.Packtype; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SmsMessageModel" /> objects.
        /// </summary>
        Consensus.Document.ISmsMessageFactory IDocumentFactoryCollection.SmsMessage
        {
            get { return this.SmsMessage; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SmsTypeModel" /> objects.
        /// </summary>
        Consensus.Document.ISmsTypeFactory IDocumentFactoryCollection.SmsType
        {
            get { return this.SmsType; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PackXrefModel" /> objects.
        /// </summary>
        Consensus.Document.IPackXrefFactory IDocumentFactoryCollection.PackXref
        {
            get { return this.PackXref; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LiteratureModel" /> objects.
        /// </summary>
        Consensus.Document.ILiteratureFactory IDocumentFactoryCollection.Literature
        {
            get { return this.Literature; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PrintRequestModel" /> objects.
        /// </summary>
        Consensus.Document.IPrintRequestFactory IDocumentFactoryCollection.PrintRequest
        {
            get { return this.PrintRequest; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ArticleModel" /> objects.
        /// </summary>
        Consensus.Document.IArticleFactory IDocumentFactoryCollection.Article
        {
            get { return this.Article; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ArticlexrefModel" /> objects.
        /// </summary>
        Consensus.Document.IArticlexrefFactory IDocumentFactoryCollection.Articlexref
        {
            get { return this.Articlexref; }
        }

        #endregion
    }
}
