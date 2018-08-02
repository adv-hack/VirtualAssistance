using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SalesChannelModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSalesChannelFactory : LocalFactory<LocalSalesChannelModel, SalesChannelRecord, String>, ISalesChannelFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SalesChannelModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SalesChannelModel' /> instance.
        /// </returns>
        public LocalSalesChannelModel Create()
        {
            return new LocalSalesChannelModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SalesChannelModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SalesChannelModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSalesChannelModel> FetchAll()
        {
            IEnumerable<SalesChannelRecord> recordCollection = this.Provider.DataProvider.Sales.SalesChannel.FetchAll();
            foreach (SalesChannelRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSalesChannelModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SalesChannelModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SalesChannelModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SalesChannelModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSalesChannelModel FetchById(String id)
        {
            SalesChannelRecord record = this.Provider.DataProvider.Sales.SalesChannel.FetchById(id);
            if (record == null)
                return null;
            return new LocalSalesChannelModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SalesChannel/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Sales.SalesChannel.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SalesChannelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SalesChannelModel" /> instance.
        /// </returns>
        Consensus.Sales.ISalesChannelModel ISalesChannelFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SalesChannelModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SalesChannelModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.ISalesChannelModel> ISalesChannelFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SalesChannelModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SalesChannelModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SalesChannelModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Sales.ISalesChannelModel ISalesChannelFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ISalesChannelFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
