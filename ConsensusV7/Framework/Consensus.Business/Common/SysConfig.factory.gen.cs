using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SysConfigModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISysConfigFactory : IFactory<ISysConfigModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SysConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SysConfigModel" /> instance.
        /// </returns>
        Consensus.Common.ISysConfigModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SysConfigModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SysConfigModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ISysConfigModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SysConfigModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SysConfigModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SysConfigModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ISysConfigModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SysConfigModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SysConfigModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SysConfigModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ISysConfigModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);
    }
}
