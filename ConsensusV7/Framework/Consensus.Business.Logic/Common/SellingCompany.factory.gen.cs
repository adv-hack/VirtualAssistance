using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SellingCompanyModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSellingCompanyFactory : LocalFactory<LocalSellingCompanyModel, SysParamsRecord, String>, ISellingCompanyFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SellingCompanyModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SellingCompanyModel' /> instance.
        /// </returns>
        public LocalSellingCompanyModel Create()
        {
            return new LocalSellingCompanyModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SellingCompanyModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SellingCompanyModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSellingCompanyModel> FetchAll()
        {
            IEnumerable<SysParamsRecord> recordCollection = this.Provider.DataProvider.Common.SellingCompany.FetchAll();
            foreach (SysParamsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSellingCompanyModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SellingCompanyModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SellingCompanyModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SellingCompanyModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSellingCompanyModel FetchById(String id)
        {
            SysParamsRecord record = this.Provider.DataProvider.Common.SellingCompany.FetchById(id);
            if (record == null)
                return null;
            return new LocalSellingCompanyModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SellingCompany/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.SellingCompany.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves the default <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The default <see cref="!:SellingCompanyModel" /> instance; or null, if no default instance can be found.
        /// </returns>
        Consensus.Common.ISellingCompanyModel ISellingCompanyFactory.FetchDefault()
        {
            return this.FetchDefault();
        }

        /// <summary>
        ///     Creates a new <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SellingCompanyModel" /> instance.
        /// </returns>
        Consensus.Common.ISellingCompanyModel ISellingCompanyFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SellingCompanyModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SellingCompanyModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ISellingCompanyModel> ISellingCompanyFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SellingCompanyModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SellingCompanyModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ISellingCompanyModel ISellingCompanyFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ISellingCompanyFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
