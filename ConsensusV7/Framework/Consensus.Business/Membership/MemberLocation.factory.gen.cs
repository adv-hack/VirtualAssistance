using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MemberLocationModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMemberLocationFactory : IFactory<IMemberLocationModel, String>
    {
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> CheckMemLocLinesToInvoice(System.String memberPeriodId, System.String userLoginId);

        /// <summary>
        ///     Checks if Consultant scheme product already exist in database.
        /// </summary>
        /// <param name="productId">
        ///     Id of the Product.
        /// </param>
        /// <param name="memberLocationId">
        ///     Id of the Member Location.
        /// </param>
        /// <param name="memberPeriodId">
        ///     Id of the Member Period.
        /// </param>
        /// <returns>
        ///     Whether Consultant scheme product already exist in database.
        /// </returns>
        System.Boolean CheckIfProductExist(System.String productId, System.String memberLocationId, System.String memberPeriodId);

        /// <summary>
        ///     Creates a new <see cref="!:MemberLocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberLocationModel" /> instance.
        /// </returns>
        Consensus.Membership.IMemberLocationModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberLocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberLocationModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberLocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberLocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IMemberLocationModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="membershipId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="membershipId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> FetchAllByMembershipId(System.String membershipId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> FetchAllByMemberPeriodId(System.String memberPeriodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> FetchAllByOrgIdId(System.String orgIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> FetchAllByRoleId(System.String roleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="mailAddIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="mailAddIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> FetchAllByMailAddIdId(System.String mailAddIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="mailInvIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="mailInvIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> FetchAllByMailInvIdId(System.String mailInvIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="invlnIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="invlnIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> FetchAllByInvlnIdId(System.String invlnIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="plIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="plIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> FetchAllByPlIdId(System.String plIdId);
    }
}
