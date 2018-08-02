using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CodeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICodeFactory : IFactory<ICodeModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <param name="codeType">
        ///     The type of the code.
        /// </param>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeModel" /> instance.
        /// </returns>
        Consensus.Common.ICodeModel Create(System.String codeType);

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ICodeModel FetchByTypeAndCode(System.String codeType, System.String codeValue);

        /// <summary>
        ///     Retrieves a single <see cref="!:CodeModel" /> instance from the data store.
        /// </summary>
        /// <param name="codeValue3">
        ///     The unique value which distinctly identifies the <see cref="!:CodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="codeValue3" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ICodeModel FetchByTypeAndCodeValue3(System.String codeType, System.String codeValue3);

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ICodeModel> FetchAllByType(System.String codeType);

        System.Collections.Generic.IEnumerable<System.Object> FetchAllInTree(System.String codeType);

        /// <summary>
        ///     Creates a new <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeModel" /> instance.
        /// </returns>
        Consensus.Common.ICodeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CodeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CodeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ICodeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ICodeModel FetchById(System.String id);

        System.String GetTableName();
    }
}
