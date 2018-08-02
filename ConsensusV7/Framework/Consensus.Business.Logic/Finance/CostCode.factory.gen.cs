using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CostCodeModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCostCodeFactory : LocalFactory<LocalCostCodeModel, CostCodeRecord, String>, ICostCodeFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CostCodeModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CostCodeModel' /> instance.
        /// </returns>
        public LocalCostCodeModel Create()
        {
            return new LocalCostCodeModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CostCodeModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CostCodeModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCostCodeModel> FetchAll()
        {
            IEnumerable<CostCodeRecord> recordCollection = this.Provider.DataProvider.Finance.CostCode.FetchAll();
            foreach (CostCodeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCostCodeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CostCodeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CostCodeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CostCodeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCostCodeModel FetchById(String id)
        {
            CostCodeRecord record = this.Provider.DataProvider.Finance.CostCode.FetchById(id);
            if (record == null)
                return null;
            return new LocalCostCodeModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='CostCode/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.CostCode.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CostCodeModel' /> instances.
        /// </summary>
        /// <param name="selcoSpIdId">
        ///     The value which identifies the <see cref='CostCodeModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CostCodeModel' /> instances that match the specified <paramref name='selcoSpIdId' />.
        /// </returns>
        public IEnumerable<LocalCostCodeModel> FetchAllBySelcoSpIdId(String selcoSpIdId)
        {
            IEnumerable<CostCodeRecord> recordCollection = this.Provider.DataProvider.Finance.CostCode.FetchAllBySelcoSpId(selcoSpIdId);
            foreach (CostCodeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCostCodeModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Checks if Country's name or code exist.
        /// </summary>
        /// <param name="code">
        ///     Name of the country.
        /// </param>
        /// <param name="sellingCompId">
        ///     Code of the country.
        /// </param>
        /// <param name="costCodeId">
        ///     Id of the country.
        /// </param>
        /// <returns>
        ///     Whether country's name or code exist in database.
        /// </returns>
        System.Boolean ICostCodeFactory.CheckIfCodeExist(System.String code, System.String sellingCompId, System.String costCodeId)
        {
            return this.CheckIfCodeExist(code, sellingCompId, costCodeId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CostCodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CostCodeModel" /> instance.
        /// </returns>
        Consensus.Finance.ICostCodeModel ICostCodeFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CostCodeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CostCodeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.ICostCodeModel> ICostCodeFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CostCodeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CostCodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CostCodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.ICostCodeModel ICostCodeFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ICostCodeFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CostCodeModel" /> instances.
        /// </summary>
        /// <param name="selcoSpIdId">
        ///     The value which identifies the <see cref="!:CostCodeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CostCodeModel" /> instances that match the specified <paramref name="selcoSpIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.ICostCodeModel> ICostCodeFactory.FetchAllBySelcoSpIdId(System.String selcoSpIdId)
        {
            return this.FetchAllBySelcoSpIdId(selcoSpIdId);
        }

        #endregion
    }
}
