using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="OpportunityXrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOpportunityXrefFactory : LocalFactory<LocalOpportunityXrefModel, OpportunityXrefRecord, String>, IOpportunityXrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='OpportunityXrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='OpportunityXrefModel' /> instance.
        /// </returns>
        public LocalOpportunityXrefModel Create()
        {
            return new LocalOpportunityXrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='OpportunityXrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='OpportunityXrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalOpportunityXrefModel> FetchAll()
        {
            IEnumerable<OpportunityXrefRecord> recordCollection = this.Provider.DataProvider.Sales.OpportunityXref.FetchAll();
            foreach (OpportunityXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOpportunityXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='OpportunityXrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='OpportunityXrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OpportunityXrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalOpportunityXrefModel FetchById(String id)
        {
            OpportunityXrefRecord record = this.Provider.DataProvider.Sales.OpportunityXref.FetchById(id);
            if (record == null)
                return null;
            return new LocalOpportunityXrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='OpportunityXref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Sales.OpportunityXref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OpportunityXrefModel' /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref='OpportunityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OpportunityXrefModel' /> instances that match the specified <paramref name='roleId' />.
        /// </returns>
        public IEnumerable<LocalOpportunityXrefModel> FetchAllByRoleId(String roleId)
        {
            IEnumerable<OpportunityXrefRecord> recordCollection = this.Provider.DataProvider.Sales.OpportunityXref.FetchAllByProleId(roleId);
            foreach (OpportunityXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOpportunityXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OpportunityXrefModel' /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref='OpportunityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OpportunityXrefModel' /> instances that match the specified <paramref name='opportunityId' />.
        /// </returns>
        public IEnumerable<LocalOpportunityXrefModel> FetchAllByOpportunityId(String opportunityId)
        {
            IEnumerable<OpportunityXrefRecord> recordCollection = this.Provider.DataProvider.Sales.OpportunityXref.FetchAllByOppId(opportunityId);
            foreach (OpportunityXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOpportunityXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='OpportunityXrefModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='OpportunityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='OpportunityXrefModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalOpportunityXrefModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<OpportunityXrefRecord> recordCollection = this.Provider.DataProvider.Sales.OpportunityXref.FetchAllByOrgId(organisationId);
            foreach (OpportunityXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalOpportunityXrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:OpportunityXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OpportunityXrefModel" /> instance.
        /// </returns>
        Consensus.Sales.IOpportunityXrefModel IOpportunityXrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OpportunityXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityXrefModel> IOpportunityXrefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OpportunityXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OpportunityXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Sales.IOpportunityXrefModel IOpportunityXrefFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IOpportunityXrefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityXrefModel> IOpportunityXrefFactory.FetchAllByRoleId(System.String roleId)
        {
            return this.FetchAllByRoleId(roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityXrefModel> IOpportunityXrefFactory.FetchAllByOpportunityId(System.String opportunityId)
        {
            return this.FetchAllByOpportunityId(opportunityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OpportunityXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OpportunityXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.IOpportunityXrefModel> IOpportunityXrefFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        #endregion
    }
}
