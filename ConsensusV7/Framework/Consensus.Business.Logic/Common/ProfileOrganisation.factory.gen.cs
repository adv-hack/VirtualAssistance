using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileOrganisationModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfileOrganisationFactory : LocalFactory<LocalProfileOrganisationModel, ProfileRecord, String>, IProfileOrganisationFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProfileOrganisationModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProfileOrganisationModel' /> instance.
        /// </returns>
        public LocalProfileOrganisationModel Create()
        {
            return new LocalProfileOrganisationModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProfileOrganisationModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProfileOrganisationModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProfileOrganisationModel> FetchAll()
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.Profile.FetchAll();
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileOrganisationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProfileOrganisationModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProfileOrganisationModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileOrganisationModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProfileOrganisationModel FetchById(String id)
        {
            ProfileRecord record = this.Provider.DataProvider.Common.Profile.FetchById(id);
            if (record == null)
                return null;
            return new LocalProfileOrganisationModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProfileOrganisation/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.Profile.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProfileOrganisationModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='ProfileOrganisationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileOrganisationModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalProfileOrganisationModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.Profile.FetchAllByOrgId(organisationId);
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileOrganisationModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProfileOrganisationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileOrganisationModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileOrganisationModel IProfileOrganisationFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileOrganisationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileOrganisationModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileOrganisationModel> IProfileOrganisationFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileOrganisationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileOrganisationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileOrganisationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileOrganisationModel IProfileOrganisationFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProfileOrganisationFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileOrganisationModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:ProfileOrganisationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileOrganisationModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileOrganisationModel> IProfileOrganisationFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        #endregion
    }
}
