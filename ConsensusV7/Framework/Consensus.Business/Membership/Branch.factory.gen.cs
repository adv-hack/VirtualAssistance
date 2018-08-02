using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BranchModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBranchFactory : IFactory<IBranchModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:BranchModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BranchModel" /> instance.
        /// </returns>
        Consensus.Membership.IBranchModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BranchModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BranchModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IBranchModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:BranchModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BranchModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BranchModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IBranchModel FetchById(System.String id);

        System.String GetTableName();
    }
}
