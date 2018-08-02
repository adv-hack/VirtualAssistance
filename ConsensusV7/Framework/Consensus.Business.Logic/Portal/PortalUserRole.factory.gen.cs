using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalUserRoleModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPortalUserRoleFactory : LocalFactory<LocalPortalUserRoleModel, PortaluserroleRecord, Int32>, IPortalUserRoleFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PortalUserRoleModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PortalUserRoleModel' /> instance.
        /// </returns>
        public LocalPortalUserRoleModel Create()
        {
            return new LocalPortalUserRoleModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PortalUserRoleModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PortalUserRoleModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPortalUserRoleModel> FetchAll()
        {
            IEnumerable<PortaluserroleRecord> recordCollection = this.Provider.DataProvider.Portal.PortalUserRole.FetchAll();
            foreach (PortaluserroleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalUserRoleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PortalUserRoleModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PortalUserRoleModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalUserRoleModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPortalUserRoleModel FetchById(Int32 id)
        {
            PortaluserroleRecord record = this.Provider.DataProvider.Portal.PortalUserRole.FetchById(id);
            if (record == null)
                return null;
            return new LocalPortalUserRoleModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PortalUserRole/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Portal.PortalUserRole.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PortalUserRoleModel' /> instances.
        /// </summary>
        /// <param name="portalUserId">
        ///     The value which identifies the <see cref='PortalUserRoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalUserRoleModel' /> instances that match the specified <paramref name='portalUserId' />.
        /// </returns>
        public IEnumerable<LocalPortalUserRoleModel> FetchAllByPortalUserId(Int32 portalUserId)
        {
            IEnumerable<PortaluserroleRecord> recordCollection = this.Provider.DataProvider.Portal.PortalUserRole.FetchAllByPuId(portalUserId);
            foreach (PortaluserroleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalUserRoleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PortalUserRoleModel' /> instances.
        /// </summary>
        /// <param name="portalRoleId">
        ///     The value which identifies the <see cref='PortalUserRoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalUserRoleModel' /> instances that match the specified <paramref name='portalRoleId' />.
        /// </returns>
        public IEnumerable<LocalPortalUserRoleModel> FetchAllByPortalRoleId(Int32 portalRoleId)
        {
            IEnumerable<PortaluserroleRecord> recordCollection = this.Provider.DataProvider.Portal.PortalUserRole.FetchAllByPrId(portalRoleId);
            foreach (PortaluserroleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalUserRoleModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PortalUserRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserRoleModel" /> instance.
        /// </returns>
        Consensus.Portal.IPortalUserRoleModel IPortalUserRoleFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserRoleModel> IPortalUserRoleFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Portal.IPortalUserRoleModel IPortalUserRoleFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IPortalUserRoleFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </summary>
        /// <param name="portalUserId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instances that match the specified <paramref name="portalUserId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserRoleModel> IPortalUserRoleFactory.FetchAllByPortalUserId(System.Int32 portalUserId)
        {
            return this.FetchAllByPortalUserId(portalUserId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </summary>
        /// <param name="portalRoleId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instances that match the specified <paramref name="portalRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserRoleModel> IPortalUserRoleFactory.FetchAllByPortalRoleId(System.Int32 portalRoleId)
        {
            return this.FetchAllByPortalRoleId(portalRoleId);
        }

        #endregion
    }
}
