using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalUserSiteModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPortalUserSiteFactory : LocalFactory<LocalPortalUserSiteModel, PuSiteRecord, Int32>, IPortalUserSiteFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PortalUserSiteModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PortalUserSiteModel' /> instance.
        /// </returns>
        public LocalPortalUserSiteModel Create()
        {
            return new LocalPortalUserSiteModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PortalUserSiteModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PortalUserSiteModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPortalUserSiteModel> FetchAll()
        {
            IEnumerable<PuSiteRecord> recordCollection = this.Provider.DataProvider.Portal.PortalUserSite.FetchAll();
            foreach (PuSiteRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalUserSiteModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PortalUserSiteModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PortalUserSiteModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalUserSiteModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPortalUserSiteModel FetchById(Int32 id)
        {
            PuSiteRecord record = this.Provider.DataProvider.Portal.PortalUserSite.FetchById(id);
            if (record == null)
                return null;
            return new LocalPortalUserSiteModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PortalUserSite/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Portal.PortalUserSite.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PortalUserSiteModel' /> instances.
        /// </summary>
        /// <param name="portalUserId">
        ///     The value which identifies the <see cref='PortalUserSiteModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalUserSiteModel' /> instances that match the specified <paramref name='portalUserId' />.
        /// </returns>
        public IEnumerable<LocalPortalUserSiteModel> FetchAllByPortalUserId(Int32? portalUserId)
        {
            IEnumerable<PuSiteRecord> recordCollection = this.Provider.DataProvider.Portal.PortalUserSite.FetchAllByPuId(portalUserId);
            foreach (PuSiteRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalUserSiteModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PortalUserSiteModel' /> instances.
        /// </summary>
        /// <param name="portalSetupId">
        ///     The value which identifies the <see cref='PortalUserSiteModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalUserSiteModel' /> instances that match the specified <paramref name='portalSetupId' />.
        /// </returns>
        public IEnumerable<LocalPortalUserSiteModel> FetchAllByPortalSetupId(Int32? portalSetupId)
        {
            IEnumerable<PuSiteRecord> recordCollection = this.Provider.DataProvider.Portal.PortalUserSite.FetchAllByPsId(portalSetupId);
            foreach (PuSiteRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalUserSiteModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PortalUserSiteModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserSiteModel" /> instance.
        /// </returns>
        Consensus.Portal.IPortalUserSiteModel IPortalUserSiteFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserSiteModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserSiteModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserSiteModel> IPortalUserSiteFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserSiteModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserSiteModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserSiteModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Portal.IPortalUserSiteModel IPortalUserSiteFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IPortalUserSiteFactory.GetTableName()
        {
            return this.GetTableName();
        }

        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserSiteModel> IPortalUserSiteFactory.FetchAllByPortalUserId(System.Nullable<System.Int32> portalUserId)
        {
            return this.FetchAllByPortalUserId(portalUserId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserSiteModel> IPortalUserSiteFactory.FetchAllByPortalSetupId(System.Nullable<System.Int32> portalSetupId)
        {
            return this.FetchAllByPortalSetupId(portalSetupId);
        }

        #endregion
    }
}
