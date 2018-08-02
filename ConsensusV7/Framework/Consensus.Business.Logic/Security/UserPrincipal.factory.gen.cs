using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserPrincipalModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserPrincipalFactory : LocalFactory<LocalUserPrincipalModel, UserPrincipalRecord, Int32>, IUserPrincipalFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='UserPrincipalModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='UserPrincipalModel' /> instance.
        /// </returns>
        public LocalUserPrincipalModel Create()
        {
            return new LocalUserPrincipalModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='UserPrincipalModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='UserPrincipalModel' /> instances.
        /// </returns>
        public IEnumerable<LocalUserPrincipalModel> FetchAll()
        {
            IEnumerable<UserPrincipalRecord> recordCollection = this.Provider.DataProvider.Security.UserPrincipal.FetchAll();
            foreach (UserPrincipalRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserPrincipalModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='UserPrincipalModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='UserPrincipalModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserPrincipalModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalUserPrincipalModel FetchById(Int32 id)
        {
            UserPrincipalRecord record = this.Provider.DataProvider.Security.UserPrincipal.FetchById(id);
            if (record == null)
                return null;
            return new LocalUserPrincipalModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='UserPrincipal/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Security.UserPrincipal.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:UserPrincipalModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserPrincipalModel" /> instance.
        /// </returns>
        Consensus.Security.IUserPrincipalModel IUserPrincipalFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserPrincipalModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserPrincipalModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserPrincipalModel> IUserPrincipalFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserPrincipalModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserPrincipalModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserPrincipalModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.IUserPrincipalModel IUserPrincipalFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IUserPrincipalFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
