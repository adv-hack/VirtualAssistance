using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="DistrictModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IDistrictFactory : IFactory<IDistrictModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:DistrictModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DistrictModel" /> instance.
        /// </returns>
        Consensus.Membership.IDistrictModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DistrictModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DistrictModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IDistrictModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:DistrictModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DistrictModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DistrictModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IDistrictModel FetchById(System.String id);

        System.String GetTableName();
    }
}
