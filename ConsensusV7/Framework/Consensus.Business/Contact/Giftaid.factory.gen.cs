using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="GiftaidModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IGiftaidFactory : IFactory<IGiftaidModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:GiftaidModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GiftaidModel" /> instance.
        /// </returns>
        Consensus.Contact.IGiftaidModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GiftaidModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GiftaidModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IGiftaidModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:GiftaidModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GiftaidModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IGiftaidModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidModel" /> instances.
        /// </summary>
        /// <param name="pnIdId">
        ///     The value which identifies the <see cref="!:GiftaidModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidModel" /> instances that match the specified <paramref name="pnIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IGiftaidModel> FetchAllByPnIdId(System.String pnIdId);
    }
}
