using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    public interface IDocumentFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PackModel" /> objects.
        /// </summary>
        Consensus.Document.IPackFactory Pack
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PackProductModel" /> objects.
        /// </summary>
        Consensus.Document.IPackProductFactory PackProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LetterTemplateModel" /> objects.
        /// </summary>
        Consensus.Document.ILetterTemplateFactory LetterTemplate
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LetterTemplateTypeModel" /> objects.
        /// </summary>
        Consensus.Document.ILetterTemplateTypeFactory LetterTemplateType
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OutputQueueModel" /> objects.
        /// </summary>
        Consensus.Document.IOutputQueueFactory OutputQueue
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ICalMessageModel" /> objects.
        /// </summary>
        Consensus.Document.IICalMessageFactory ICalMessage
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ICalMessageTypeModel" /> objects.
        /// </summary>
        Consensus.Document.IICalMessageTypeFactory ICalMessageType
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PacktypeModel" /> objects.
        /// </summary>
        Consensus.Document.IPacktypeFactory Packtype
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SmsMessageModel" /> objects.
        /// </summary>
        Consensus.Document.ISmsMessageFactory SmsMessage
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SmsTypeModel" /> objects.
        /// </summary>
        Consensus.Document.ISmsTypeFactory SmsType
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PackXrefModel" /> objects.
        /// </summary>
        Consensus.Document.IPackXrefFactory PackXref
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LiteratureModel" /> objects.
        /// </summary>
        Consensus.Document.ILiteratureFactory Literature
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PrintRequestModel" /> objects.
        /// </summary>
        Consensus.Document.IPrintRequestFactory PrintRequest
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ArticleModel" /> objects.
        /// </summary>
        Consensus.Document.IArticleFactory Article
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ArticlexrefModel" /> objects.
        /// </summary>
        Consensus.Document.IArticlexrefFactory Articlexref
        {
            get;
        }
    }
}
