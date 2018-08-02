using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PackModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPackFactory : IFactory<IPackModel, String>
    {
        /// <summary>
        ///     Checks if iCalMessage name exist.
        /// </summary>
        /// <param name="packName">
        ///     Name of the iCalendar Message.
        /// </param>
        /// <param name="packId">
        ///     Id of the iCalendar Message.
        /// </param>
        /// <returns>
        ///     Whether iCalendar Message's name exist in database.
        /// </returns>
        System.Boolean CheckIfNameExist(System.String packName, System.String packId);

        /// <summary>
        ///     Creates a new <see cref="!:PackModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackModel" /> instance.
        /// </returns>
        Consensus.Document.IPackModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IPackModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packEmailBodyId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packEmailBodyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackModel> FetchAllByPackEmailBodyId(System.String packEmailBodyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packSenderIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packSenderIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackModel> FetchAllByPackSenderIdId(System.String packSenderIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packOutputQueueIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packOutputQueueIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackModel> FetchAllByPackOutputQueueIdId(System.String packOutputQueueIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packSellingCompanyIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packSellingCompanyIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackModel> FetchAllByPackSellingCompanyIdId(System.String packSellingCompanyIdId);
    }
}
