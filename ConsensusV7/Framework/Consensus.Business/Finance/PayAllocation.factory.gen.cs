using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PayAllocationModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPayAllocationFactory : IFactory<IPayAllocationModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PayAllocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PayAllocationModel" /> instance.
        /// </returns>
        Consensus.Finance.IPayAllocationModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PayAllocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PayAllocationModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPayAllocationModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PayAllocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PayAllocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPayAllocationModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="invIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="invIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPayAllocationModel> FetchAllByInvIdId(System.String invIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="payIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="payIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPayAllocationModel> FetchAllByPayIdId(System.String payIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="creditIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="creditIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPayAllocationModel> FetchAllByCreditIdId(System.String creditIdId);
    }
}
