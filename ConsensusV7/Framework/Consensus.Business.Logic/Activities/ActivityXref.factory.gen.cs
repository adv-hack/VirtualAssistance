using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ActivityXrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalActivityXrefFactory : LocalFactory<LocalActivityXrefModel, ActivityXrefRecord, String>, IActivityXrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ActivityXrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ActivityXrefModel' /> instance.
        /// </returns>
        public LocalActivityXrefModel Create()
        {
            return new LocalActivityXrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ActivityXrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ActivityXrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalActivityXrefModel> FetchAll()
        {
            IEnumerable<ActivityXrefRecord> recordCollection = this.Provider.DataProvider.Activities.ActivityXref.FetchAll();
            foreach (ActivityXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActivityXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ActivityXrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ActivityXrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActivityXrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalActivityXrefModel FetchById(String id)
        {
            ActivityXrefRecord record = this.Provider.DataProvider.Activities.ActivityXref.FetchById(id);
            if (record == null)
                return null;
            return new LocalActivityXrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ActivityXref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Activities.ActivityXref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ActivityXrefModel' /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref='ActivityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActivityXrefModel' /> instances that match the specified <paramref name='activityId' />.
        /// </returns>
        public IEnumerable<LocalActivityXrefModel> FetchAllByActivityId(String activityId)
        {
            IEnumerable<ActivityXrefRecord> recordCollection = this.Provider.DataProvider.Activities.ActivityXref.FetchAllByActId(activityId);
            foreach (ActivityXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActivityXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ActivityXrefModel' /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='ActivityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActivityXrefModel' /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<LocalActivityXrefModel> FetchAllByPersonId(String personId)
        {
            IEnumerable<ActivityXrefRecord> recordCollection = this.Provider.DataProvider.Activities.ActivityXref.FetchAllByPersonId(personId);
            foreach (ActivityXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActivityXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ActivityXrefModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='ActivityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActivityXrefModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalActivityXrefModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<ActivityXrefRecord> recordCollection = this.Provider.DataProvider.Activities.ActivityXref.FetchAllByOrgId(organisationId);
            foreach (ActivityXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActivityXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ActivityXrefModel' /> instances.
        /// </summary>
        /// <param name="personRoleId">
        ///     The value which identifies the <see cref='ActivityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActivityXrefModel' /> instances that match the specified <paramref name='personRoleId' />.
        /// </returns>
        public IEnumerable<LocalActivityXrefModel> FetchAllByPersonRoleId(String personRoleId)
        {
            IEnumerable<ActivityXrefRecord> recordCollection = this.Provider.DataProvider.Activities.ActivityXref.FetchAllByProleId(personRoleId);
            foreach (ActivityXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActivityXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ActivityXrefModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='ActivityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActivityXrefModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalActivityXrefModel> FetchAllByProductId(String productId)
        {
            IEnumerable<ActivityXrefRecord> recordCollection = this.Provider.DataProvider.Activities.ActivityXref.FetchAllByProdId(productId);
            foreach (ActivityXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActivityXrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ActivityXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActivityXrefModel" /> instance.
        /// </returns>
        Consensus.Activities.IActivityXrefModel IActivityXrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActivityXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> IActivityXrefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActivityXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActivityXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IActivityXrefModel IActivityXrefFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IActivityXrefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> IActivityXrefFactory.FetchAllByActivityId(System.String activityId)
        {
            return this.FetchAllByActivityId(activityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> IActivityXrefFactory.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> IActivityXrefFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="personRoleId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="personRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> IActivityXrefFactory.FetchAllByPersonRoleId(System.String personRoleId)
        {
            return this.FetchAllByPersonRoleId(personRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityXrefModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityXrefModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityXrefModel> IActivityXrefFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        #endregion
    }
}
