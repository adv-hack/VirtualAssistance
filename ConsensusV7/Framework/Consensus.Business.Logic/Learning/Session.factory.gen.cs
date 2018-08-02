using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SessionModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSessionFactory : LocalFactory<LocalSessionModel, ActivityRecord, String>, ISessionFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SessionModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SessionModel' /> instance.
        /// </returns>
        public LocalSessionModel Create()
        {
            return new LocalSessionModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SessionModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SessionModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSessionModel> FetchAll()
        {
            IEnumerable<ActivityRecord> recordCollection = this.Provider.DataProvider.Activities.Activity.FetchAll();
            foreach (ActivityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SessionModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SessionModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSessionModel FetchById(String id)
        {
            ActivityRecord record = this.Provider.DataProvider.Activities.Activity.FetchById(id);
            if (record == null)
                return null;
            return new LocalSessionModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Session/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Activities.Activity.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SessionModel' /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref='SessionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionModel' /> instances that match the specified <paramref name='locationId' />.
        /// </returns>
        public IEnumerable<LocalSessionModel> FetchAllByLocationId(String locationId)
        {
            IEnumerable<ActivityRecord> recordCollection = this.Provider.DataProvider.Activities.Activity.FetchAllByLocId(locationId);
            foreach (ActivityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SessionModel' /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref='SessionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionModel' /> instances that match the specified <paramref name='opportunityId' />.
        /// </returns>
        public IEnumerable<LocalSessionModel> FetchAllByOpportunityId(String opportunityId)
        {
            IEnumerable<ActivityRecord> recordCollection = this.Provider.DataProvider.Activities.Activity.FetchAllByOppId(opportunityId);
            foreach (ActivityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SessionModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='SessionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalSessionModel> FetchAllByProductId(String productId)
        {
            IEnumerable<ActivityRecord> recordCollection = this.Provider.DataProvider.Activities.Activity.FetchAllBySyllabusId(productId);
            foreach (ActivityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SessionModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='SessionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalSessionModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<ActivityRecord> recordCollection = this.Provider.DataProvider.Activities.Activity.FetchAllByOrgId(organisationId);
            foreach (ActivityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SessionModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='SessionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalSessionModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<ActivityRecord> recordCollection = this.Provider.DataProvider.Activities.Activity.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (ActivityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SessionModel' /> instances.
        /// </summary>
        /// <param name="biillOfMaterialId">
        ///     The value which identifies the <see cref='SessionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionModel' /> instances that match the specified <paramref name='biillOfMaterialId' />.
        /// </returns>
        public IEnumerable<LocalSessionModel> FetchAllByBiillOfMaterialId(String biillOfMaterialId)
        {
            IEnumerable<ActivityRecord> recordCollection = this.Provider.DataProvider.Activities.Activity.FetchAllByBomId(biillOfMaterialId);
            foreach (ActivityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        Consensus.Learning.ISessionModel ISessionFactory.CreateFromEvent(System.String eventId)
        {
            return this.CreateFromEvent(eventId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SessionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SessionModel" /> instance.
        /// </returns>
        Consensus.Learning.ISessionModel ISessionFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SessionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SessionModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> ISessionFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SessionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SessionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ISessionModel ISessionFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ISessionFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> ISessionFactory.FetchAllByLocationId(System.String locationId)
        {
            return this.FetchAllByLocationId(locationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> ISessionFactory.FetchAllByOpportunityId(System.String opportunityId)
        {
            return this.FetchAllByOpportunityId(opportunityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> ISessionFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> ISessionFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> ISessionFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionModel" /> instances.
        /// </summary>
        /// <param name="biillOfMaterialId">
        ///     The value which identifies the <see cref="!:SessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionModel" /> instances that match the specified <paramref name="biillOfMaterialId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionModel> ISessionFactory.FetchAllByBiillOfMaterialId(System.String biillOfMaterialId)
        {
            return this.FetchAllByBiillOfMaterialId(biillOfMaterialId);
        }

        #endregion
    }
}
