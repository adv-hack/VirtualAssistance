using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="EventProductModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IEventProductFactory : IFactory<IEventProductModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:EventProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:EventProductModel" /> instance.
        /// </returns>
        Consensus.Learning.IEventProductModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:EventProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:EventProductModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventProductModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:EventProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:EventProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IEventProductModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventProductModel> FetchAllByEventId(System.String eventId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventProductModel> FetchAllByProductId(System.String productId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventProductModel> FetchAllByNotesId(System.String notesId);
    }
}
