using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CampaignModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCampaignFactory : LocalFactory<LocalCampaignModel, CampaignRecord, String>, ICampaignFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CampaignModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CampaignModel' /> instance.
        /// </returns>
        public LocalCampaignModel Create()
        {
            return new LocalCampaignModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CampaignModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CampaignModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCampaignModel> FetchAll()
        {
            IEnumerable<CampaignRecord> recordCollection = this.Provider.DataProvider.Marketing.Campaign.FetchAll();
            foreach (CampaignRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCampaignModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CampaignModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CampaignModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CampaignModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCampaignModel FetchById(String id)
        {
            CampaignRecord record = this.Provider.DataProvider.Marketing.Campaign.FetchById(id);
            if (record == null)
                return null;
            return new LocalCampaignModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Campaign/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.Campaign.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CampaignModel' /> instances.
        /// </summary>
        /// <param name="projectId">
        ///     The value which identifies the <see cref='CampaignModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CampaignModel' /> instances that match the specified <paramref name='projectId' />.
        /// </returns>
        public IEnumerable<LocalCampaignModel> FetchAllByProjectId(String projectId)
        {
            IEnumerable<CampaignRecord> recordCollection = this.Provider.DataProvider.Marketing.Campaign.FetchAllByProjId(projectId);
            foreach (CampaignRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCampaignModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CampaignModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='CampaignModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CampaignModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalCampaignModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<CampaignRecord> recordCollection = this.Provider.DataProvider.Marketing.Campaign.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (CampaignRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCampaignModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CampaignModel' /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref='CampaignModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CampaignModel' /> instances that match the specified <paramref name='managerId' />.
        /// </returns>
        public IEnumerable<LocalCampaignModel> FetchAllByManagerId(String managerId)
        {
            IEnumerable<CampaignRecord> recordCollection = this.Provider.DataProvider.Marketing.Campaign.FetchAllByProleId(managerId);
            foreach (CampaignRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCampaignModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CampaignModel' /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref='CampaignModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CampaignModel' /> instances that match the specified <paramref name='approverId' />.
        /// </returns>
        public IEnumerable<LocalCampaignModel> FetchAllByApproverId(String approverId)
        {
            IEnumerable<CampaignRecord> recordCollection = this.Provider.DataProvider.Marketing.Campaign.FetchAllByAppProleId(approverId);
            foreach (CampaignRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCampaignModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:CampaignModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CampaignModel" /> instance.
        /// </returns>
        Consensus.Marketing.ICampaignModel ICampaignFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CampaignModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CampaignModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ICampaignModel> ICampaignFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CampaignModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CampaignModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ICampaignModel ICampaignFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ICampaignFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="projectId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="projectId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ICampaignModel> ICampaignFactory.FetchAllByProjectId(System.String projectId)
        {
            return this.FetchAllByProjectId(projectId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ICampaignModel> ICampaignFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ICampaignModel> ICampaignFactory.FetchAllByManagerId(System.String managerId)
        {
            return this.FetchAllByManagerId(managerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ICampaignModel> ICampaignFactory.FetchAllByApproverId(System.String approverId)
        {
            return this.FetchAllByApproverId(approverId);
        }

        #endregion
    }
}
