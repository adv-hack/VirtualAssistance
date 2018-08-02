using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileTrainerModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfileTrainerFactory : LocalFactory<LocalProfileTrainerModel, ProfileRecord, String>, IProfileTrainerFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProfileTrainerModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProfileTrainerModel' /> instance.
        /// </returns>
        public LocalProfileTrainerModel Create()
        {
            return new LocalProfileTrainerModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProfileTrainerModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProfileTrainerModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProfileTrainerModel> FetchAll()
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.ProfileTrainer.FetchAll();
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileTrainerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProfileTrainerModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProfileTrainerModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileTrainerModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProfileTrainerModel FetchById(String id)
        {
            ProfileRecord record = this.Provider.DataProvider.Common.ProfileTrainer.FetchById(id);
            if (record == null)
                return null;
            return new LocalProfileTrainerModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProfileTrainer/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.ProfileTrainer.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProfileTrainerModel' /> instances.
        /// </summary>
        /// <param name="trainerId">
        ///     The value which identifies the <see cref='ProfileTrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileTrainerModel' /> instances that match the specified <paramref name='trainerId' />.
        /// </returns>
        public IEnumerable<LocalProfileTrainerModel> FetchAllByTrainerId(String trainerId)
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.ProfileTrainer.FetchAllByTrainId(trainerId);
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileTrainerModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProfileTrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileTrainerModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileTrainerModel IProfileTrainerFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileTrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileTrainerModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileTrainerModel> IProfileTrainerFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileTrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileTrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileTrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileTrainerModel IProfileTrainerFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProfileTrainerFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileTrainerModel" /> instances.
        /// </summary>
        /// <param name="trainerId">
        ///     The value which identifies the <see cref="!:ProfileTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileTrainerModel" /> instances that match the specified <paramref name="trainerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileTrainerModel> IProfileTrainerFactory.FetchAllByTrainerId(System.String trainerId)
        {
            return this.FetchAllByTrainerId(trainerId);
        }

        #endregion
    }
}
