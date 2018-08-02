using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CodeHeaderModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICodeHeaderFactory : IFactory<ICodeHeaderModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:CodeHeaderModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeHeaderModel" /> instance.
        /// </returns>
        Consensus.Common.ICodeHeaderModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CodeHeaderModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CodeHeaderModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ICodeHeaderModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeHeaderModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CodeHeaderModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeHeaderModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ICodeHeaderModel FetchById(System.String id);

        System.String GetTableName();
    }
}
