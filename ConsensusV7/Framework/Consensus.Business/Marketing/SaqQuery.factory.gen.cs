using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqQueryModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqQueryFactory : IFactory<ISaqQueryModel, Int64>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SaqQueryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueryModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqQueryModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueryModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqQueryModel FetchById(System.Int64 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryModel> FetchAllBySourceCodeId(System.String sourceCodeId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryModel> FetchAllByEventId(System.String eventId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryModel> FetchAllByManagerId(System.String managerId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryModel> FetchAllByApproverId(System.String approverId);
    }
}
