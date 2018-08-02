using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AddressModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAddressFactory : IFactory<IAddressModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:AddressModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AddressModel" /> instance.
        /// </returns>
        Consensus.Contact.IAddressModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AddressModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AddressModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAddressModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:AddressModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AddressModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AddressModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IAddressModel FetchById(System.String id);

        System.String GetTableName();
    }
}
