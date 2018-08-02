using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LetterTemplateTypeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILetterTemplateTypeFactory : IFactory<ILetterTemplateTypeModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </returns>
        Consensus.Document.ILetterTemplateTypeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LetterTemplateTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LetterTemplateTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILetterTemplateTypeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LetterTemplateTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.ILetterTemplateTypeModel FetchById(System.String id);

        System.String GetTableName();
    }
}
