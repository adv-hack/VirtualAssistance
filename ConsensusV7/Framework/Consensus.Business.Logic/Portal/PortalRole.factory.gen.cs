using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalRoleModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPortalRoleFactory : LocalFactory<LocalPortalRoleModel, PortalRoleRecord, Int32>, IPortalRoleFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PortalRoleModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PortalRoleModel' /> instance.
        /// </returns>
        public LocalPortalRoleModel Create()
        {
            return new LocalPortalRoleModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PortalRoleModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PortalRoleModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPortalRoleModel> FetchAll()
        {
            IEnumerable<PortalRoleRecord> recordCollection = this.Provider.DataProvider.Portal.PortalRole.FetchAll();
            foreach (PortalRoleRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalRoleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PortalRoleModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PortalRoleModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalRoleModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPortalRoleModel FetchById(Int32 id)
        {
            PortalRoleRecord record = this.Provider.DataProvider.Portal.PortalRole.FetchById(id);
            if (record == null)
                return null;
            return new LocalPortalRoleModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PortalRole/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Portal.PortalRole.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PortalRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalRoleModel" /> instance.
        /// </returns>
        Consensus.Portal.IPortalRoleModel IPortalRoleFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalRoleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalRoleModel> IPortalRoleFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Portal.IPortalRoleModel IPortalRoleFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IPortalRoleFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
