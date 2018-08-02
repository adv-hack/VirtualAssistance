using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MembershipModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMembershipFactory : IFactory<IMembershipModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:MembershipModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MembershipModel" /> instance.
        /// </returns>
        Consensus.Membership.IMembershipModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MembershipModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MembershipModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMembershipModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:MembershipModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MembershipModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MembershipModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IMembershipModel FetchById(System.String id);

        System.String GetTableName();
    }
}
