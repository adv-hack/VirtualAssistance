using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CommunicationsModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommunicationsFactory : IFactory<ICommunicationsModel, Int64>
    {
        /// <summary>
        ///     Creates a new <see cref="!:CommunicationsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommunicationsModel" /> instance.
        /// </returns>
        Consensus.Contact.ICommunicationsModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommunicationsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommunicationsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunicationsModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommunicationsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommunicationsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ICommunicationsModel FetchById(System.Int64 id);

        System.String GetTableName();
    }
}
