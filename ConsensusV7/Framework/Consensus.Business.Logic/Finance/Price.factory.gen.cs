using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PriceModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPriceFactory : LocalFactory<LocalPriceModel, PricesRecord, String>, IPriceFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PriceModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PriceModel' /> instance.
        /// </returns>
        public LocalPriceModel Create()
        {
            return new LocalPriceModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PriceModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PriceModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPriceModel> FetchAll()
        {
            IEnumerable<PricesRecord> recordCollection = this.Provider.DataProvider.Finance.Price.FetchAll();
            foreach (PricesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPriceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PriceModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PriceModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PriceModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPriceModel FetchById(String id)
        {
            PricesRecord record = this.Provider.DataProvider.Finance.Price.FetchById(id);
            if (record == null)
                return null;
            return new LocalPriceModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Price/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.Price.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PriceModel' /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref='PriceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PriceModel' /> instances that match the specified <paramref name='priceListId' />.
        /// </returns>
        public IEnumerable<LocalPriceModel> FetchAllByPriceListId(String priceListId)
        {
            IEnumerable<PricesRecord> recordCollection = this.Provider.DataProvider.Finance.Price.FetchAllByPlId(priceListId);
            foreach (PricesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPriceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PriceModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='PriceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PriceModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalPriceModel> FetchAllByProductId(String productId)
        {
            IEnumerable<PricesRecord> recordCollection = this.Provider.DataProvider.Finance.Price.FetchAllByProdId(productId);
            foreach (PricesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPriceModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        Consensus.Finance.IPriceModel IPriceFactory.RecalculateMemberFee(System.String productId, System.String plId, System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, System.Int32 qtyTotal)
        {
            return this.RecalculateMemberFee(productId, plId, startDate, endDate, qtyTotal);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instance that matches the specified <paramref name="productId" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceModel> IPriceFactory.FetchAllByProdidPriceListid(System.String productId, System.String plId)
        {
            return this.FetchAllByProdidPriceListid(productId, plId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PriceModel" /> instance.
        /// </returns>
        Consensus.Finance.IPriceModel IPriceFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PriceModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PriceModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceModel> IPriceFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PriceModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPriceModel IPriceFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPriceFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PriceModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceModel> IPriceFactory.FetchAllByPriceListId(System.String priceListId)
        {
            return this.FetchAllByPriceListId(priceListId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PriceModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPriceModel> IPriceFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        #endregion
    }
}
