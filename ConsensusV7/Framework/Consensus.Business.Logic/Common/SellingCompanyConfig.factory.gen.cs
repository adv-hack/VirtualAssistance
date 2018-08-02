using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SellingCompanyConfigModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSellingCompanyConfigFactory : LocalFactory<LocalSellingCompanyConfigModel, SysConfigRecord, Int32>, ISellingCompanyConfigFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SellingCompanyConfigModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SellingCompanyConfigModel' /> instance.
        /// </returns>
        public LocalSellingCompanyConfigModel Create()
        {
            return new LocalSellingCompanyConfigModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SellingCompanyConfigModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SellingCompanyConfigModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSellingCompanyConfigModel> FetchAll()
        {
            IEnumerable<SysConfigRecord> recordCollection = this.Provider.DataProvider.Common.SellingCompanyConfig.FetchAll();
            foreach (SysConfigRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSellingCompanyConfigModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SellingCompanyConfigModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SellingCompanyConfigModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SellingCompanyConfigModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSellingCompanyConfigModel FetchById(Int32 id)
        {
            SysConfigRecord record = this.Provider.DataProvider.Common.SellingCompanyConfig.FetchById(id);
            if (record == null)
                return null;
            return new LocalSellingCompanyConfigModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SellingCompanyConfig/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.SellingCompanyConfig.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:SellingCompanyConfigModel" /> instance that matches the specified <paramref name="sellingCompanyId" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ISellingCompanyConfigModel> ISellingCompanyConfigFactory.FetchAllBySellingCompanyIdKeyName(System.String sellingCompanyId, System.String keyName)
        {
            return this.FetchAllBySellingCompanyIdKeyName(sellingCompanyId, keyName);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </returns>
        Consensus.Common.ISellingCompanyConfigModel ISellingCompanyConfigFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SellingCompanyConfigModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SellingCompanyConfigModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ISellingCompanyConfigModel> ISellingCompanyConfigFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SellingCompanyConfigModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SellingCompanyConfigModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ISellingCompanyConfigModel ISellingCompanyConfigFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ISellingCompanyConfigFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
