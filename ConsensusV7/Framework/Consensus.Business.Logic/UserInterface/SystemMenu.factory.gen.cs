using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SystemMenuModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSystemMenuFactory : LocalFactory<LocalSystemMenuModel, SystemmenusRecord, Int32>, ISystemMenuFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SystemMenuModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SystemMenuModel' /> instance.
        /// </returns>
        public LocalSystemMenuModel Create()
        {
            return new LocalSystemMenuModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SystemMenuModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SystemMenuModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSystemMenuModel> FetchAll()
        {
            IEnumerable<SystemmenusRecord> recordCollection = this.Provider.DataProvider.UserInterface.SystemMenu.FetchAll();
            foreach (SystemmenusRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSystemMenuModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SystemMenuModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SystemMenuModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SystemMenuModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSystemMenuModel FetchById(Int32 id)
        {
            SystemmenusRecord record = this.Provider.DataProvider.UserInterface.SystemMenu.FetchById(id);
            if (record == null)
                return null;
            return new LocalSystemMenuModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SystemMenu/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.SystemMenu.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SystemMenuModel' /> instances.
        /// </summary>
        /// <param name="parentId">
        ///     The value which identifies the <see cref='SystemMenuModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SystemMenuModel' /> instances that match the specified <paramref name='parentId' />.
        /// </returns>
        public IEnumerable<LocalSystemMenuModel> FetchAllByParentId(Int32? parentId)
        {
            IEnumerable<SystemmenusRecord> recordCollection = this.Provider.DataProvider.UserInterface.SystemMenu.FetchAllBySmenuId(parentId);
            foreach (SystemmenusRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSystemMenuModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SystemMenuModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SystemMenuModel" /> instance.
        /// </returns>
        Consensus.UserInterface.ISystemMenuModel ISystemMenuFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SystemMenuModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SystemMenuModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ISystemMenuModel> ISystemMenuFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SystemMenuModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SystemMenuModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.ISystemMenuModel ISystemMenuFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ISystemMenuFactory.GetTableName()
        {
            return this.GetTableName();
        }

        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ISystemMenuModel> ISystemMenuFactory.FetchAllByParentId(System.Nullable<System.Int32> parentId)
        {
            return this.FetchAllByParentId(parentId);
        }

        #endregion
    }
}
