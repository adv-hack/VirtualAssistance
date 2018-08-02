using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfilePersonModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfilePersonFactory : LocalFactory<LocalProfilePersonModel, ProfileRecord, String>, IProfilePersonFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProfilePersonModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProfilePersonModel' /> instance.
        /// </returns>
        public LocalProfilePersonModel Create()
        {
            return new LocalProfilePersonModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProfilePersonModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProfilePersonModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProfilePersonModel> FetchAll()
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.Profile.FetchAll();
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfilePersonModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProfilePersonModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProfilePersonModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfilePersonModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProfilePersonModel FetchById(String id)
        {
            ProfileRecord record = this.Provider.DataProvider.Common.Profile.FetchById(id);
            if (record == null)
                return null;
            return new LocalProfilePersonModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProfilePerson/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.Profile.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProfilePersonModel' /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='ProfilePersonModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfilePersonModel' /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<LocalProfilePersonModel> FetchAllByPersonId(String personId)
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.Profile.FetchAllByPersonId(personId);
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfilePersonModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProfilePersonModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfilePersonModel" /> instance.
        /// </returns>
        Consensus.Common.IProfilePersonModel IProfilePersonFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfilePersonModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfilePersonModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfilePersonModel> IProfilePersonFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfilePersonModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfilePersonModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfilePersonModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfilePersonModel IProfilePersonFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProfilePersonFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfilePersonModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ProfilePersonModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfilePersonModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfilePersonModel> IProfilePersonFactory.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        #endregion
    }
}
