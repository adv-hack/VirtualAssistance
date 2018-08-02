using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProdSelectGroupModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProdSelectGroupFactory : LocalFactory<LocalProdSelectGroupModel, ProdselectgroupsRecord, Int32>, IProdSelectGroupFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProdSelectGroupModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProdSelectGroupModel' /> instance.
        /// </returns>
        public LocalProdSelectGroupModel Create()
        {
            return new LocalProdSelectGroupModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProdSelectGroupModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProdSelectGroupModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProdSelectGroupModel> FetchAll()
        {
            IEnumerable<ProdselectgroupsRecord> recordCollection = this.Provider.DataProvider.Learning.ProdSelectGroup.FetchAll();
            foreach (ProdselectgroupsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProdSelectGroupModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProdSelectGroupModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProdSelectGroupModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProdSelectGroupModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProdSelectGroupModel FetchById(Int32 id)
        {
            ProdselectgroupsRecord record = this.Provider.DataProvider.Learning.ProdSelectGroup.FetchById(id);
            if (record == null)
                return null;
            return new LocalProdSelectGroupModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProdSelectGroup/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.ProdSelectGroup.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProdSelectGroupModel' /> instances.
        /// </summary>
        /// <param name="prodIdId">
        ///     The value which identifies the <see cref='ProdSelectGroupModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProdSelectGroupModel' /> instances that match the specified <paramref name='prodIdId' />.
        /// </returns>
        public IEnumerable<LocalProdSelectGroupModel> FetchAllByProdIdId(String prodIdId)
        {
            IEnumerable<ProdselectgroupsRecord> recordCollection = this.Provider.DataProvider.Learning.ProdSelectGroup.FetchAllByProduct(prodIdId);
            foreach (ProdselectgroupsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProdSelectGroupModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProdSelectGroupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProdSelectGroupModel" /> instance.
        /// </returns>
        Consensus.Learning.IProdSelectGroupModel IProdSelectGroupFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProdSelectGroupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProdSelectGroupModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProdSelectGroupModel> IProdSelectGroupFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProdSelectGroupModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProdSelectGroupModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProdSelectGroupModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProdSelectGroupModel IProdSelectGroupFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IProdSelectGroupFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProdSelectGroupModel" /> instances.
        /// </summary>
        /// <param name="prodIdId">
        ///     The value which identifies the <see cref="!:ProdSelectGroupModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProdSelectGroupModel" /> instances that match the specified <paramref name="prodIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProdSelectGroupModel> IProdSelectGroupFactory.FetchAllByProdIdId(System.String prodIdId)
        {
            return this.FetchAllByProdIdId(prodIdId);
        }

        #endregion
    }
}
