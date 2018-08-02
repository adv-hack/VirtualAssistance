using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PackModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPackFactory : LocalFactory<LocalPackModel, PackRecord, String>, IPackFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PackModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PackModel' /> instance.
        /// </returns>
        public LocalPackModel Create()
        {
            return new LocalPackModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PackModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PackModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPackModel> FetchAll()
        {
            IEnumerable<PackRecord> recordCollection = this.Provider.DataProvider.Document.Pack.FetchAll();
            foreach (PackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PackModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PackModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPackModel FetchById(String id)
        {
            PackRecord record = this.Provider.DataProvider.Document.Pack.FetchById(id);
            if (record == null)
                return null;
            return new LocalPackModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Pack/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.Pack.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PackModel' /> instances.
        /// </summary>
        /// <param name="packEmailBodyId">
        ///     The value which identifies the <see cref='PackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackModel' /> instances that match the specified <paramref name='packEmailBodyId' />.
        /// </returns>
        public IEnumerable<LocalPackModel> FetchAllByPackEmailBodyId(String packEmailBodyId)
        {
            IEnumerable<PackRecord> recordCollection = this.Provider.DataProvider.Document.Pack.FetchAllByEmailBody(packEmailBodyId);
            foreach (PackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PackModel' /> instances.
        /// </summary>
        /// <param name="packSenderIdId">
        ///     The value which identifies the <see cref='PackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackModel' /> instances that match the specified <paramref name='packSenderIdId' />.
        /// </returns>
        public IEnumerable<LocalPackModel> FetchAllByPackSenderIdId(String packSenderIdId)
        {
            IEnumerable<PackRecord> recordCollection = this.Provider.DataProvider.Document.Pack.FetchAllBySendProleId(packSenderIdId);
            foreach (PackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PackModel' /> instances.
        /// </summary>
        /// <param name="packOutputQueueIdId">
        ///     The value which identifies the <see cref='PackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackModel' /> instances that match the specified <paramref name='packOutputQueueIdId' />.
        /// </returns>
        public IEnumerable<LocalPackModel> FetchAllByPackOutputQueueIdId(String packOutputQueueIdId)
        {
            IEnumerable<PackRecord> recordCollection = this.Provider.DataProvider.Document.Pack.FetchAllByPqId(packOutputQueueIdId);
            foreach (PackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PackModel' /> instances.
        /// </summary>
        /// <param name="packSellingCompanyIdId">
        ///     The value which identifies the <see cref='PackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackModel' /> instances that match the specified <paramref name='packSellingCompanyIdId' />.
        /// </returns>
        public IEnumerable<LocalPackModel> FetchAllByPackSellingCompanyIdId(String packSellingCompanyIdId)
        {
            IEnumerable<PackRecord> recordCollection = this.Provider.DataProvider.Document.Pack.FetchAllBySelcoSpId(packSellingCompanyIdId);
            foreach (PackRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Checks if iCalMessage name exist.
        /// </summary>
        /// <param name="packName">
        ///     Name of the iCalendar Message.
        /// </param>
        /// <param name="packId">
        ///     Id of the iCalendar Message.
        /// </param>
        /// <returns>
        ///     Whether iCalendar Message's name exist in database.
        /// </returns>
        System.Boolean IPackFactory.CheckIfNameExist(System.String packName, System.String packId)
        {
            return this.CheckIfNameExist(packName, packId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PackModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackModel" /> instance.
        /// </returns>
        Consensus.Document.IPackModel IPackFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackModel> IPackFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IPackModel IPackFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPackFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packEmailBodyId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packEmailBodyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackModel> IPackFactory.FetchAllByPackEmailBodyId(System.String packEmailBodyId)
        {
            return this.FetchAllByPackEmailBodyId(packEmailBodyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packSenderIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packSenderIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackModel> IPackFactory.FetchAllByPackSenderIdId(System.String packSenderIdId)
        {
            return this.FetchAllByPackSenderIdId(packSenderIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packOutputQueueIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packOutputQueueIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackModel> IPackFactory.FetchAllByPackOutputQueueIdId(System.String packOutputQueueIdId)
        {
            return this.FetchAllByPackOutputQueueIdId(packOutputQueueIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackModel" /> instances.
        /// </summary>
        /// <param name="packSellingCompanyIdId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackModel" /> instances that match the specified <paramref name="packSellingCompanyIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackModel> IPackFactory.FetchAllByPackSellingCompanyIdId(System.String packSellingCompanyIdId)
        {
            return this.FetchAllByPackSellingCompanyIdId(packSellingCompanyIdId);
        }

        #endregion
    }
}
