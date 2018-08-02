using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserPrincipalModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserPrincipalFactory : IFactory<IUserPrincipalModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:UserPrincipalModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserPrincipalModel" /> instance.
        /// </returns>
        Consensus.Security.IUserPrincipalModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserPrincipalModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserPrincipalModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserPrincipalModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserPrincipalModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserPrincipalModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserPrincipalModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.IUserPrincipalModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
