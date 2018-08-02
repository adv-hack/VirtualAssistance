using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PriceListModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPriceListFactory : LocalFactory<LocalPriceListModel, PriceListRecord, String>, IPriceListFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PriceListModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PriceListModel' /> instance.
        /// </returns>
        public LocalPriceListModel Create()
        {
            return new LocalPriceListModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PriceListModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PriceListModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPriceListModel> FetchAll()
        {
            IEnumerable<PriceListRecord> recordCollection = this.Provider.DataProvider.Finance.PriceList.FetchAll();
            foreach (PriceListRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPriceListModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PriceListModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PriceListModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PriceListModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPriceListModel FetchById(String id)
        {
            PriceListRecord record = this.Provider.DataProvider.Finance.PriceList.FetchById(id);
            if (record == null)
                return null;
            return new LocalPriceListModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PriceList/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.PriceList.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.IPriceListModel" /> instances, that are referenced by the valid prices recorded against a given product.
        /// </summary>
        /// <param name="productId">
        ///     The unique identifier for the product whoses prices are inspected.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.IPriceListModel" /> that are referenced by the valid prices recorded against the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceListModel> IPriceListFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PriceListModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PriceListModel" /> instance.
        /// </returns>
        Consensus.Finance.IPriceListModel IPriceListFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PriceListModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PriceListModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceListModel> IPriceListFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceListModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PriceListModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceListModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPriceListModel IPriceListFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPriceListFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
