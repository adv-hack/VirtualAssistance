using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfilePersonModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfilePersonFactory : IFactory<IProfilePersonModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProfilePersonModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfilePersonModel" /> instance.
        /// </returns>
        Consensus.Common.IProfilePersonModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfilePersonModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfilePersonModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfilePersonModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfilePersonModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfilePersonModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfilePersonModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfilePersonModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfilePersonModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ProfilePersonModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfilePersonModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfilePersonModel> FetchAllByPersonId(System.String personId);
    }
}
