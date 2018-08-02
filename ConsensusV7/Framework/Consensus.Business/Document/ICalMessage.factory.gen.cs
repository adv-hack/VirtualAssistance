using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ICalMessageModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IICalMessageFactory : IFactory<IICalMessageModel, Int32>
    {
        /// <summary>
        ///     Checks if iCalMessage name exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the iCalendar Message.
        /// </param>
        /// <param name="iCalMessageId">
        ///     Id of the iCalendar Message.
        /// </param>
        /// <returns>
        ///     Whether iCalendar Message's name exist in database.
        /// </returns>
        System.Boolean CheckIfNameExist(System.String name, System.String iCalMessageId);

        /// <summary>
        ///     Creates a new <see cref="!:ICalMessageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ICalMessageModel" /> instance.
        /// </returns>
        Consensus.Document.IICalMessageModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ICalMessageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ICalMessageModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IICalMessageModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ICalMessageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ICalMessageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IICalMessageModel FetchById(System.Int32 id);

        System.String GetTableName();

        System.Collections.Generic.IEnumerable<Consensus.Document.IICalMessageModel> FetchAllByICalMessageTypeId(System.Nullable<System.Int32> iCalMessageTypeId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ICalMessageModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ICalMessageModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IICalMessageModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);
    }
}
