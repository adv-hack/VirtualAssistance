using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserSessionModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserSessionFactory : IFactory<IUserSessionModel, Guid>
    {
        /// <summary>
        ///     Gets the authentication session for the currently logged on user.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:Consensus.Security.IUserSessionModel" /> for the currently authenticated user.
        /// </returns>
        Consensus.Security.IUserSessionModel FetchCurrent();

        /// <summary>
        ///     Authenticates a user account using pre-shared credentials.
        /// </summary>
        /// <param name="username">
        ///     The unique name which distinctly identifies the account to be authenticated.
        /// </param>
        /// <param name="password">
        ///     The pre-shared secret which confirms the identity of the authenticating user.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Security.IUserSessionModel" /> instance for the authenticated user.
        /// </returns>
        void Login(System.String username, System.String password);

        /// <summary>
        ///     Extends the expiry period for the current authentication session.
        /// </summary>
        void Update();

        /// <summary>
        ///     Terminates the current authentication session.
        /// </summary>
        void Logout();

        /// <summary>
        ///     Creates a new <see cref="!:UserSessionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserSessionModel" /> instance.
        /// </returns>
        Consensus.Security.IUserSessionModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserSessionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserSessionModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserSessionModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserSessionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserSessionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserSessionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.IUserSessionModel FetchById(System.Guid id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserSessionModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:UserSessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserSessionModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserSessionModel> FetchAllByUserId(System.Int32 userId);
    }
}
