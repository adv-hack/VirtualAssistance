using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BillOfMaterialModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBillOfMaterialFactory : LocalFactory<LocalBillOfMaterialModel, BillOfMaterialRecord, String>, IBillOfMaterialFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='BillOfMaterialModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='BillOfMaterialModel' /> instance.
        /// </returns>
        public LocalBillOfMaterialModel Create()
        {
            return new LocalBillOfMaterialModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='BillOfMaterialModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='BillOfMaterialModel' /> instances.
        /// </returns>
        public IEnumerable<LocalBillOfMaterialModel> FetchAll()
        {
            IEnumerable<BillOfMaterialRecord> recordCollection = this.Provider.DataProvider.Learning.BillOfMaterial.FetchAll();
            foreach (BillOfMaterialRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBillOfMaterialModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='BillOfMaterialModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='BillOfMaterialModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BillOfMaterialModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalBillOfMaterialModel FetchById(String id)
        {
            BillOfMaterialRecord record = this.Provider.DataProvider.Learning.BillOfMaterial.FetchById(id);
            if (record == null)
                return null;
            return new LocalBillOfMaterialModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='BillOfMaterial/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.BillOfMaterial.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BillOfMaterialModel' /> instances.
        /// </summary>
        /// <param name="masterProductId">
        ///     The value which identifies the <see cref='BillOfMaterialModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BillOfMaterialModel' /> instances that match the specified <paramref name='masterProductId' />.
        /// </returns>
        public IEnumerable<LocalBillOfMaterialModel> FetchAllByMasterProductId(String masterProductId)
        {
            IEnumerable<BillOfMaterialRecord> recordCollection = this.Provider.DataProvider.Learning.BillOfMaterial.FetchAllByParentId(masterProductId);
            foreach (BillOfMaterialRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBillOfMaterialModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BillOfMaterialModel' /> instances.
        /// </summary>
        /// <param name="childProductId">
        ///     The value which identifies the <see cref='BillOfMaterialModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BillOfMaterialModel' /> instances that match the specified <paramref name='childProductId' />.
        /// </returns>
        public IEnumerable<LocalBillOfMaterialModel> FetchAllByChildProductId(String childProductId)
        {
            IEnumerable<BillOfMaterialRecord> recordCollection = this.Provider.DataProvider.Learning.BillOfMaterial.FetchAllBySyllabusId(childProductId);
            foreach (BillOfMaterialRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBillOfMaterialModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BillOfMaterialModel' /> instances.
        /// </summary>
        /// <param name="accomProductId">
        ///     The value which identifies the <see cref='BillOfMaterialModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BillOfMaterialModel' /> instances that match the specified <paramref name='accomProductId' />.
        /// </returns>
        public IEnumerable<LocalBillOfMaterialModel> FetchAllByAccomProductId(String accomProductId)
        {
            IEnumerable<BillOfMaterialRecord> recordCollection = this.Provider.DataProvider.Learning.BillOfMaterial.FetchAllByResourceId(accomProductId);
            foreach (BillOfMaterialRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBillOfMaterialModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BillOfMaterialModel' /> instances.
        /// </summary>
        /// <param name="psgIdId">
        ///     The value which identifies the <see cref='BillOfMaterialModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BillOfMaterialModel' /> instances that match the specified <paramref name='psgIdId' />.
        /// </returns>
        public IEnumerable<LocalBillOfMaterialModel> FetchAllByPsgIdId(Int32? psgIdId)
        {
            IEnumerable<BillOfMaterialRecord> recordCollection = this.Provider.DataProvider.Learning.BillOfMaterial.FetchAllByProductSelectGroup(psgIdId);
            foreach (BillOfMaterialRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBillOfMaterialModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:BillOfMaterialModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BillOfMaterialModel" /> instance.
        /// </returns>
        Consensus.Learning.IBillOfMaterialModel IBillOfMaterialFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BillOfMaterialModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBillOfMaterialModel> IBillOfMaterialFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BillOfMaterialModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BillOfMaterialModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IBillOfMaterialModel IBillOfMaterialFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IBillOfMaterialFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="masterProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="masterProductId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBillOfMaterialModel> IBillOfMaterialFactory.FetchAllByMasterProductId(System.String masterProductId)
        {
            return this.FetchAllByMasterProductId(masterProductId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="childProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="childProductId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBillOfMaterialModel> IBillOfMaterialFactory.FetchAllByChildProductId(System.String childProductId)
        {
            return this.FetchAllByChildProductId(childProductId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="accomProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="accomProductId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBillOfMaterialModel> IBillOfMaterialFactory.FetchAllByAccomProductId(System.String accomProductId)
        {
            return this.FetchAllByAccomProductId(accomProductId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.IBillOfMaterialModel> IBillOfMaterialFactory.FetchAllByPsgIdId(System.Nullable<System.Int32> psgIdId)
        {
            return this.FetchAllByPsgIdId(psgIdId);
        }

        #endregion
    }
}
