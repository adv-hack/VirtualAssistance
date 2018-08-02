using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SysConfigModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSysConfigFactory : LocalFactory<LocalSysConfigModel, SysConfigRecord, Int32>, ISysConfigFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SysConfigModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SysConfigModel' /> instance.
        /// </returns>
        public LocalSysConfigModel Create()
        {
            return new LocalSysConfigModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SysConfigModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SysConfigModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSysConfigModel> FetchAll()
        {
            IEnumerable<SysConfigRecord> recordCollection = this.Provider.DataProvider.Common.SysConfig.FetchAll();
            foreach (SysConfigRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSysConfigModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SysConfigModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SysConfigModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SysConfigModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSysConfigModel FetchById(Int32 id)
        {
            SysConfigRecord record = this.Provider.DataProvider.Common.SysConfig.FetchById(id);
            if (record == null)
                return null;
            return new LocalSysConfigModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SysConfig/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.SysConfig.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SysConfigModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='SysConfigModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SysConfigModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalSysConfigModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<SysConfigRecord> recordCollection = this.Provider.DataProvider.Common.SysConfig.FetchAllBySpId(sellingCompanyId);
            foreach (SysConfigRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSysConfigModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SysConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SysConfigModel" /> instance.
        /// </returns>
        Consensus.Common.ISysConfigModel ISysConfigFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SysConfigModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SysConfigModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ISysConfigModel> ISysConfigFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SysConfigModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SysConfigModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SysConfigModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ISysConfigModel ISysConfigFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ISysConfigFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SysConfigModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SysConfigModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SysConfigModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ISysConfigModel> ISysConfigFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        #endregion
    }
}
