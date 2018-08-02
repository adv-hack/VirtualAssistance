using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ActivityModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalActivityFactory : LocalFactory<LocalActivityModel, ActivityRecord, String>, IActivityFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ActivityModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ActivityModel' /> instance.
        /// </returns>
        public LocalActivityModel Create()
        {
            return new LocalActivityModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ActivityModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ActivityModel' /> instances.
        /// </returns>
        public IEnumerable<LocalActivityModel> FetchAll()
        {
            IEnumerable<ActivityRecord> recordCollection = this.Provider.DataProvider.Activities.Activity.FetchAll();
            foreach (ActivityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActivityModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ActivityModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ActivityModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActivityModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalActivityModel FetchById(String id)
        {
            ActivityRecord record = this.Provider.DataProvider.Activities.Activity.FetchById(id);
            if (record == null)
                return null;
            return new LocalActivityModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Activity/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Activities.Activity.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ActivityModel' /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref='ActivityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActivityModel' /> instances that match the specified <paramref name='opportunityId' />.
        /// </returns>
        public IEnumerable<LocalActivityModel> FetchAllByOpportunityId(String opportunityId)
        {
            IEnumerable<ActivityRecord> recordCollection = this.Provider.DataProvider.Activities.Activity.FetchAllByOppId(opportunityId);
            foreach (ActivityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActivityModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ActivityModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='ActivityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActivityModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalActivityModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<ActivityRecord> recordCollection = this.Provider.DataProvider.Activities.Activity.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (ActivityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActivityModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ActivityModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActivityModel" /> instance.
        /// </returns>
        Consensus.Activities.IActivityModel IActivityFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActivityModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActivityModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityModel> IActivityFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActivityModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActivityModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IActivityModel IActivityFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IActivityFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityModel> IActivityFactory.FetchAllByOpportunityId(System.String opportunityId)
        {
            return this.FetchAllByOpportunityId(opportunityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActivityModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActivityModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActivityModel> IActivityFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        #endregion
    }
}
