using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="GenericModelModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalGenericModelFactory : LocalFactory<LocalGenericModelModel, GenericmodeltableRecord, String>, IGenericModelFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='GenericModelModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='GenericModelModel' /> instance.
        /// </returns>
        public LocalGenericModelModel Create()
        {
            return new LocalGenericModelModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='GenericModelModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='GenericModelModel' /> instances.
        /// </returns>
        public IEnumerable<LocalGenericModelModel> FetchAll()
        {
            IEnumerable<GenericmodeltableRecord> recordCollection = this.Provider.DataProvider.Common.GenericModel.FetchAll();
            foreach (GenericmodeltableRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalGenericModelModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='GenericModelModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='GenericModelModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='GenericModelModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalGenericModelModel FetchById(String id)
        {
            GenericmodeltableRecord record = this.Provider.DataProvider.Common.GenericModel.FetchById(id);
            if (record == null)
                return null;
            return new LocalGenericModelModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='GenericModel/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.GenericModel.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="accId" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> IGenericModelFactory.FetchAllByAccIdAccountXref(System.String accId, System.String proleId)
        {
            return this.FetchAllByAccIdAccountXref(accId, proleId);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> IGenericModelFactory.FetchAllByCourseIdSessions(System.String courseid)
        {
            return this.FetchAllByCourseIdSessions(courseid);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> IGenericModelFactory.FetchAllByCourseIdPrices(System.String courseid, System.Int32 delcount)
        {
            return this.FetchAllByCourseIdPrices(courseid, delcount);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> IGenericModelFactory.FetchAllByProdIdPrices(System.String prodid, System.Int32 qty)
        {
            return this.FetchAllByProdIdPrices(prodid, qty);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> IGenericModelFactory.ValidateDelegate(System.String courseid, System.String proleid, System.String qualid, System.Int16 ignorefreeplaces, System.Int16 delquantity)
        {
            return this.ValidateDelegate(courseid, proleid, qualid, ignorefreeplaces, delquantity);
        }

        /// <summary>
        ///     Creates a new <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GenericModelModel" /> instance.
        /// </returns>
        Consensus.Common.IGenericModelModel IGenericModelFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GenericModelModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GenericModelModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> IGenericModelFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GenericModelModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IGenericModelModel IGenericModelFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IGenericModelFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
