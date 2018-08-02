using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfileFactory : LocalFactory<LocalProfileModel, ProfileRecord, String>, IProfileFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProfileModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProfileModel' /> instance.
        /// </returns>
        public LocalProfileModel Create()
        {
            return new LocalProfileModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProfileModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProfileModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProfileModel> FetchAll()
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.Profile.FetchAll();
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProfileModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProfileModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProfileModel FetchById(String id)
        {
            ProfileRecord record = this.Provider.DataProvider.Common.Profile.FetchById(id);
            if (record == null)
                return null;
            return new LocalProfileModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Profile/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.Profile.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProfileModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileModel IProfileFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileModel> IProfileFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileModel IProfileFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProfileFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
