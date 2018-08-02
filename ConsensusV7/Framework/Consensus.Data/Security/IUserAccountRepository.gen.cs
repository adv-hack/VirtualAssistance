using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="UserAccountRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserAccountRepository : IRepository<UserAccountRecord, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a single <see cref="T:Consensus.Security.UserAccountRecord" /> instance from the data store.
        /// </summary>
        /// <param name="username">
        ///     The value which identifies the <see cref="T:Consensus.Security.UserAccountRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Security.UserAccountRecord" /> instance which matches the specified <paramref name="username" />.
        /// </returns>
        Consensus.Security.UserAccountRecord FetchByUsername(System.String username);

        /// <summary>
        ///     Retrieves a string <see cref="T:System.String" /> value which contains the reporting URL.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:System.String" /> reporting URL.
        /// </returns>
        System.String ReportingURL(System.String portalPage);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserAccountRecord> FetchAllByPrincipalId(System.Int32 principalId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserAccountRecord> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances that match the specified <paramref name="selcoId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserAccountRecord> FetchAllBySelcoId(System.String selcoId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="repId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances that match the specified <paramref name="repId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserAccountRecord> FetchAllByRepId(System.String repId);

        #endregion
    }
}
