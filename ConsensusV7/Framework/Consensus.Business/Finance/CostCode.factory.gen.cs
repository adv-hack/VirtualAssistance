using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CostCodeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICostCodeFactory : IFactory<ICostCodeModel, String>
    {
        /// <summary>
        ///     Checks if Country's name or code exist.
        /// </summary>
        /// <param name="code">
        ///     Name of the country.
        /// </param>
        /// <param name="sellingCompId">
        ///     Code of the country.
        /// </param>
        /// <param name="costCodeId">
        ///     Id of the country.
        /// </param>
        /// <returns>
        ///     Whether country's name or code exist in database.
        /// </returns>
        System.Boolean CheckIfCodeExist(System.String code, System.String sellingCompId, System.String costCodeId);

        /// <summary>
        ///     Creates a new <see cref="!:CostCodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CostCodeModel" /> instance.
        /// </returns>
        Consensus.Finance.ICostCodeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CostCodeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CostCodeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.ICostCodeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CostCodeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CostCodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CostCodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.ICostCodeModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CostCodeModel" /> instances.
        /// </summary>
        /// <param name="selcoSpIdId">
        ///     The value which identifies the <see cref="!:CostCodeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CostCodeModel" /> instances that match the specified <paramref name="selcoSpIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.ICostCodeModel> FetchAllBySelcoSpIdId(System.String selcoSpIdId);
    }
}
