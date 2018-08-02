using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LearnerModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILearnerFactory : IFactory<ILearnerModel, String>
    {
        Consensus.Learning.ILearnerModel DelegatesToConfirm(System.String bookId, System.String approver);

        Consensus.Learning.ILearnerModel CancelBooking(System.String bookId, System.String userLoginId);

        /// <summary>
        ///     Creates a new <see cref="!:LearnerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LearnerModel" /> instance.
        /// </returns>
        Consensus.Learning.ILearnerModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LearnerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LearnerModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:LearnerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LearnerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ILearnerModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> FetchAllByBookingId(System.String bookingId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateOrgId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> FetchAllByDelegateOrgId(System.String delegateOrgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegatePersonId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegatePersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> FetchAllByDelegatePersonId(System.String delegatePersonId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateRoleId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> FetchAllByDelegateRoleId(System.String delegateRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> FetchAllByMemberPeriodId(System.String memberPeriodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateAddressId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateAddressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> FetchAllByDelegateAddressId(System.String delegateAddressId);
    }
}
