using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SellingCompanyModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISellingCompanyFactory : IFactory<ISellingCompanyModel, String>
    {
        /// <summary>
        ///     Retrieves the default <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The default <see cref="!:SellingCompanyModel" /> instance; or null, if no default instance can be found.
        /// </returns>
        Consensus.Common.ISellingCompanyModel FetchDefault();

        /// <summary>
        ///     Creates a new <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SellingCompanyModel" /> instance.
        /// </returns>
        Consensus.Common.ISellingCompanyModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SellingCompanyModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SellingCompanyModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ISellingCompanyModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SellingCompanyModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SellingCompanyModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ISellingCompanyModel FetchById(System.String id);

        System.String GetTableName();
    }
}
