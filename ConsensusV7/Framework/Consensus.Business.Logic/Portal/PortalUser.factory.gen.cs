using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalUserModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPortalUserFactory : LocalFactory<LocalPortalUserModel, PortalUserRecord, Int32>, IPortalUserFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PortalUserModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PortalUserModel' /> instance.
        /// </returns>
        public LocalPortalUserModel Create()
        {
            return new LocalPortalUserModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PortalUserModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PortalUserModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPortalUserModel> FetchAll()
        {
            IEnumerable<PortalUserRecord> recordCollection = this.Provider.DataProvider.Portal.PortalUser.FetchAll();
            foreach (PortalUserRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalUserModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PortalUserModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PortalUserModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalUserModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPortalUserModel FetchById(Int32 id)
        {
            PortalUserRecord record = this.Provider.DataProvider.Portal.PortalUser.FetchById(id);
            if (record == null)
                return null;
            return new LocalPortalUserModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PortalUser/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Portal.PortalUser.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PortalUserModel' /> instances.
        /// </summary>
        /// <param name="personRoleId">
        ///     The value which identifies the <see cref='PortalUserModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalUserModel' /> instances that match the specified <paramref name='personRoleId' />.
        /// </returns>
        public IEnumerable<LocalPortalUserModel> FetchAllByPersonRoleId(String personRoleId)
        {
            IEnumerable<PortalUserRecord> recordCollection = this.Provider.DataProvider.Portal.PortalUser.FetchAllByProleId(personRoleId);
            foreach (PortalUserRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalUserModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PortalUserModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='PortalUserModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PortalUserModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalPortalUserModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<PortalUserRecord> recordCollection = this.Provider.DataProvider.Portal.PortalUser.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (PortalUserRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPortalUserModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        System.Boolean IPortalUserFactory.CheckIfUsernameExist(System.String name, System.String userId)
        {
            return this.CheckIfUsernameExist(name, userId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PortalUserModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserModel" /> instance.
        /// </returns>
        Consensus.Portal.IPortalUserModel IPortalUserFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserModel> IPortalUserFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Portal.IPortalUserModel IPortalUserFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IPortalUserFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserModel" /> instances.
        /// </summary>
        /// <param name="personRoleId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instances that match the specified <paramref name="personRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserModel> IPortalUserFactory.FetchAllByPersonRoleId(System.String personRoleId)
        {
            return this.FetchAllByPersonRoleId(personRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserModel> IPortalUserFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        #endregion
    }
}
