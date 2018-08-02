using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LetterTemplateModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILetterTemplateFactory : IFactory<ILetterTemplateModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:LetterTemplateModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LetterTemplateModel" /> instance.
        /// </returns>
        Consensus.Document.ILetterTemplateModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LetterTemplateModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILetterTemplateModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:LetterTemplateModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LetterTemplateModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.ILetterTemplateModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="typeId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="typeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILetterTemplateModel> FetchAllByTypeId(System.String typeId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILetterTemplateModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LetterTemplateModel" /> instances.
        /// </summary>
        /// <param name="sendFromId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateModel" /> instances that match the specified <paramref name="sendFromId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILetterTemplateModel> FetchAllBySendFromId(System.String sendFromId);
    }
}
