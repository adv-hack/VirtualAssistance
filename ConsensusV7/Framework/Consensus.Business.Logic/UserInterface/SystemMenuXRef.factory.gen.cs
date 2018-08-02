using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SystemMenuXRefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSystemMenuXRefFactory : LocalFactory<LocalSystemMenuXRefModel, SystemmenusxrefRecord, Int32>, ISystemMenuXRefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SystemMenuXRefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SystemMenuXRefModel' /> instance.
        /// </returns>
        public LocalSystemMenuXRefModel Create()
        {
            return new LocalSystemMenuXRefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SystemMenuXRefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SystemMenuXRefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSystemMenuXRefModel> FetchAll()
        {
            IEnumerable<SystemmenusxrefRecord> recordCollection = this.Provider.DataProvider.UserInterface.SystemMenuXRef.FetchAll();
            foreach (SystemmenusxrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSystemMenuXRefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SystemMenuXRefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SystemMenuXRefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SystemMenuXRefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSystemMenuXRefModel FetchById(Int32 id)
        {
            SystemmenusxrefRecord record = this.Provider.DataProvider.UserInterface.SystemMenuXRef.FetchById(id);
            if (record == null)
                return null;
            return new LocalSystemMenuXRefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SystemMenuXRef/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.SystemMenuXRef.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SystemMenuXRefModel' /> instances.
        /// </summary>
        /// <param name="systemMenuId">
        ///     The value which identifies the <see cref='SystemMenuXRefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SystemMenuXRefModel' /> instances that match the specified <paramref name='systemMenuId' />.
        /// </returns>
        public IEnumerable<LocalSystemMenuXRefModel> FetchAllBySystemMenuId(Int32 systemMenuId)
        {
            IEnumerable<SystemmenusxrefRecord> recordCollection = this.Provider.DataProvider.UserInterface.SystemMenuXRef.FetchAllBySmenuId(systemMenuId);
            foreach (SystemmenusxrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSystemMenuXRefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SystemMenuXRefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SystemMenuXRefModel" /> instance.
        /// </returns>
        Consensus.UserInterface.ISystemMenuXRefModel ISystemMenuXRefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SystemMenuXRefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SystemMenuXRefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ISystemMenuXRefModel> ISystemMenuXRefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SystemMenuXRefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SystemMenuXRefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuXRefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.ISystemMenuXRefModel ISystemMenuXRefFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ISystemMenuXRefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SystemMenuXRefModel" /> instances.
        /// </summary>
        /// <param name="systemMenuId">
        ///     The value which identifies the <see cref="!:SystemMenuXRefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SystemMenuXRefModel" /> instances that match the specified <paramref name="systemMenuId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ISystemMenuXRefModel> ISystemMenuXRefFactory.FetchAllBySystemMenuId(System.Int32 systemMenuId)
        {
            return this.FetchAllBySystemMenuId(systemMenuId);
        }

        #endregion
    }
}
