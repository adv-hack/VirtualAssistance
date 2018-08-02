using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserCredentialModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserCredentialFactory : LocalFactory<LocalUserCredentialModel, UserCredentialRecord, Int32>, IUserCredentialFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='UserCredentialModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='UserCredentialModel' /> instance.
        /// </returns>
        public LocalUserCredentialModel Create()
        {
            return new LocalUserCredentialModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='UserCredentialModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='UserCredentialModel' /> instances.
        /// </returns>
        public IEnumerable<LocalUserCredentialModel> FetchAll()
        {
            IEnumerable<UserCredentialRecord> recordCollection = this.Provider.DataProvider.Security.UserCredential.FetchAll();
            foreach (UserCredentialRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserCredentialModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='UserCredentialModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='UserCredentialModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserCredentialModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalUserCredentialModel FetchById(Int32 id)
        {
            UserCredentialRecord record = this.Provider.DataProvider.Security.UserCredential.FetchById(id);
            if (record == null)
                return null;
            return new LocalUserCredentialModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='UserCredential/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Security.UserCredential.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='UserCredentialModel' /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref='UserCredentialModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserCredentialModel' /> instances that match the specified <paramref name='userId' />.
        /// </returns>
        public IEnumerable<LocalUserCredentialModel> FetchAllByUserId(Int32 userId)
        {
            IEnumerable<UserCredentialRecord> recordCollection = this.Provider.DataProvider.Security.UserCredential.FetchAllByUser(userId);
            foreach (UserCredentialRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalUserCredentialModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:UserCredentialModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserCredentialModel" /> instance.
        /// </returns>
        Consensus.Security.IUserCredentialModel IUserCredentialFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserCredentialModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserCredentialModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserCredentialModel> IUserCredentialFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserCredentialModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserCredentialModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserCredentialModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.IUserCredentialModel IUserCredentialFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IUserCredentialFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserCredentialModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:UserCredentialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserCredentialModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserCredentialModel> IUserCredentialFactory.FetchAllByUserId(System.Int32 userId)
        {
            return this.FetchAllByUserId(userId);
        }

        #endregion
    }
}
