using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="Communications_XrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommunications_XrefFactory : IFactory<ICommunications_XrefModel, Int64>
    {
        /// <summary>
        ///     Creates a new <see cref="!:Communications_XrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:Communications_XrefModel" /> instance.
        /// </returns>
        Consensus.Contact.ICommunications_XrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:Communications_XrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:Communications_XrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunications_XrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:Communications_XrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:Communications_XrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:Communications_XrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ICommunications_XrefModel FetchById(System.Int64 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:Communications_XrefModel" /> instances.
        /// </summary>
        /// <param name="communicationId">
        ///     The value which identifies the <see cref="!:Communications_XrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:Communications_XrefModel" /> instances that match the specified <paramref name="communicationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunications_XrefModel> FetchAllByCommunicationId(System.Int64 communicationId);
    }
}
