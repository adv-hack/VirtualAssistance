using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserCredentialModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserCredentialFactory : IFactory<IUserCredentialModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:UserCredentialModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserCredentialModel" /> instance.
        /// </returns>
        Consensus.Security.IUserCredentialModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserCredentialModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserCredentialModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserCredentialModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserCredentialModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserCredentialModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserCredentialModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.IUserCredentialModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserCredentialModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:UserCredentialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserCredentialModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserCredentialModel> FetchAllByUserId(System.Int32 userId);
    }
}
