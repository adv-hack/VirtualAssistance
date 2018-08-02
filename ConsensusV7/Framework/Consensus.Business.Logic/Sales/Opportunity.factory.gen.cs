using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="OpportunityModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOpportunityFactory : LocalFactory<LocalOpportunityModel, OpportunityRecord, String>, IOpportunityFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='OpportunityModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='OpportunityModel' /> instance.
        /// </returns>
        public LocalOpportunityModel Create()
        {
            return new LocalOpportunityModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='OpportunityModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='OpportunityModel' /> instances.
        /// </returns>
        public IEnumerable<LocalOpportunityModel> FetchAll()
        {
            IEnumerable<OpportunityRecord> recordCollection = this.Provider.DataProvider.Sales.Opportunity.FetchAll();
            foreach (OpportunityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOpportunityModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='OpportunityModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='OpportunityModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OpportunityModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalOpportunityModel FetchById(String id)
        {
            OpportunityRecord record = this.Provider.DataProvider.Sales.Opportunity.FetchById(id);
            if (record == null)
                return null;
            return new LocalOpportunityModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Opportunity/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Sales.Opportunity.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OpportunityModel' /> instances.
        /// </summary>
        /// <param name="promIdId">
        ///     The value which identifies the <see cref='OpportunityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OpportunityModel' /> instances that match the specified <paramref name='promIdId' />.
        /// </returns>
        public IEnumerable<LocalOpportunityModel> FetchAllByPromIdId(String promIdId)
        {
            IEnumerable<OpportunityRecord> recordCollection = this.Provider.DataProvider.Sales.Opportunity.FetchAllByPromId(promIdId);
            foreach (OpportunityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOpportunityModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OpportunityModel' /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref='OpportunityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OpportunityModel' /> instances that match the specified <paramref name='activityId' />.
        /// </returns>
        public IEnumerable<LocalOpportunityModel> FetchAllByActivityId(String activityId)
        {
            IEnumerable<OpportunityRecord> recordCollection = this.Provider.DataProvider.Sales.Opportunity.FetchAllByActId(activityId);
            foreach (OpportunityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOpportunityModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OpportunityModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='OpportunityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OpportunityModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalOpportunityModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<OpportunityRecord> recordCollection = this.Provider.DataProvider.Sales.Opportunity.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (OpportunityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOpportunityModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OpportunityModel' /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref='OpportunityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OpportunityModel' /> instances that match the specified <paramref name='courseIdId' />.
        /// </returns>
        public IEnumerable<LocalOpportunityModel> FetchAllByCourseIdId(String courseIdId)
        {
            IEnumerable<OpportunityRecord> recordCollection = this.Provider.DataProvider.Sales.Opportunity.FetchAllByCourseId(courseIdId);
            foreach (OpportunityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOpportunityModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OpportunityModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='OpportunityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OpportunityModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalOpportunityModel> FetchAllByProductId(String productId)
        {
            IEnumerable<OpportunityRecord> recordCollection = this.Provider.DataProvider.Sales.Opportunity.FetchAllByProdId(productId);
            foreach (OpportunityRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOpportunityModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:OpportunityModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OpportunityModel" /> instance.
        /// </returns>
        Consensus.Sales.IOpportunityModel IOpportunityFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OpportunityModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OpportunityModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> IOpportunityFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OpportunityModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OpportunityModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Sales.IOpportunityModel IOpportunityFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IOpportunityFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="promIdId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="promIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> IOpportunityFactory.FetchAllByPromIdId(System.String promIdId)
        {
            return this.FetchAllByPromIdId(promIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> IOpportunityFactory.FetchAllByActivityId(System.String activityId)
        {
            return this.FetchAllByActivityId(activityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> IOpportunityFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> IOpportunityFactory.FetchAllByCourseIdId(System.String courseIdId)
        {
            return this.FetchAllByCourseIdId(courseIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityModel> IOpportunityFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        #endregion
    }
}
