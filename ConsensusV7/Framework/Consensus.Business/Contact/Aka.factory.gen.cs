using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AkaModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAkaFactory : IFactory<IAkaModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:AkaModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AkaModel" /> instance.
        /// </returns>
        Consensus.Contact.IAkaModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AkaModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AkaModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAkaModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:AkaModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AkaModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IAkaModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AkaModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:AkaModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAkaModel> FetchAllByOrgIdId(System.String orgIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AkaModel" /> instances.
        /// </summary>
        /// <param name="pnIdId">
        ///     The value which identifies the <see cref="!:AkaModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instances that match the specified <paramref name="pnIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAkaModel> FetchAllByPnIdId(System.String pnIdId);
    }
}
