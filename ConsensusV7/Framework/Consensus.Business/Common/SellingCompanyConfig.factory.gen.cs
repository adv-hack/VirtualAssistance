using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SellingCompanyConfigModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISellingCompanyConfigFactory : IFactory<ISellingCompanyConfigModel, Int32>
    {
        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:SellingCompanyConfigModel" /> instance that matches the specified <paramref name="sellingCompanyId" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ISellingCompanyConfigModel> FetchAllBySellingCompanyIdKeyName(System.String sellingCompanyId, System.String keyName);

        /// <summary>
        ///     Creates a new <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </returns>
        Consensus.Common.ISellingCompanyConfigModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SellingCompanyConfigModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SellingCompanyConfigModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ISellingCompanyConfigModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SellingCompanyConfigModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SellingCompanyConfigModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ISellingCompanyConfigModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
