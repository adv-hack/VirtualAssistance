using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileVolunteerModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfileVolunteerFactory : LocalFactory<LocalProfileVolunteerModel, ProfileRecord, String>, IProfileVolunteerFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProfileVolunteerModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProfileVolunteerModel' /> instance.
        /// </returns>
        public LocalProfileVolunteerModel Create()
        {
            return new LocalProfileVolunteerModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProfileVolunteerModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProfileVolunteerModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProfileVolunteerModel> FetchAll()
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.ProfileVolunteer.FetchAll();
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileVolunteerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProfileVolunteerModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProfileVolunteerModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileVolunteerModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProfileVolunteerModel FetchById(String id)
        {
            ProfileRecord record = this.Provider.DataProvider.Common.ProfileVolunteer.FetchById(id);
            if (record == null)
                return null;
            return new LocalProfileVolunteerModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProfileVolunteer/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.ProfileVolunteer.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProfileVolunteerModel' /> instances.
        /// </summary>
        /// <param name="volunteerId">
        ///     The value which identifies the <see cref='ProfileVolunteerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileVolunteerModel' /> instances that match the specified <paramref name='volunteerId' />.
        /// </returns>
        public IEnumerable<LocalProfileVolunteerModel> FetchAllByVolunteerId(String volunteerId)
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.ProfileVolunteer.FetchAllByVolId(volunteerId);
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileVolunteerModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProfileVolunteerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileVolunteerModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileVolunteerModel IProfileVolunteerFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileVolunteerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileVolunteerModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileVolunteerModel> IProfileVolunteerFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileVolunteerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileVolunteerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileVolunteerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileVolunteerModel IProfileVolunteerFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProfileVolunteerFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileVolunteerModel" /> instances.
        /// </summary>
        /// <param name="volunteerId">
        ///     The value which identifies the <see cref="!:ProfileVolunteerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileVolunteerModel" /> instances that match the specified <paramref name="volunteerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileVolunteerModel> IProfileVolunteerFactory.FetchAllByVolunteerId(System.String volunteerId)
        {
            return this.FetchAllByVolunteerId(volunteerId);
        }

        #endregion
    }
}
