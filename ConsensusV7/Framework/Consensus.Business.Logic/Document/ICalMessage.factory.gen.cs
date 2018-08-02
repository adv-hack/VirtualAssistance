using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ICalMessageModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalICalMessageFactory : LocalFactory<LocalICalMessageModel, IcalmessageRecord, Int32>, IICalMessageFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ICalMessageModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ICalMessageModel' /> instance.
        /// </returns>
        public LocalICalMessageModel Create()
        {
            return new LocalICalMessageModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ICalMessageModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ICalMessageModel' /> instances.
        /// </returns>
        public IEnumerable<LocalICalMessageModel> FetchAll()
        {
            IEnumerable<IcalmessageRecord> recordCollection = this.Provider.DataProvider.Document.ICalMessage.FetchAll();
            foreach (IcalmessageRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalICalMessageModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ICalMessageModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ICalMessageModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ICalMessageModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalICalMessageModel FetchById(Int32 id)
        {
            IcalmessageRecord record = this.Provider.DataProvider.Document.ICalMessage.FetchById(id);
            if (record == null)
                return null;
            return new LocalICalMessageModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ICalMessage/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.ICalMessage.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ICalMessageModel' /> instances.
        /// </summary>
        /// <param name="iCalMessageTypeId">
        ///     The value which identifies the <see cref='ICalMessageModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ICalMessageModel' /> instances that match the specified <paramref name='iCalMessageTypeId' />.
        /// </returns>
        public IEnumerable<LocalICalMessageModel> FetchAllByICalMessageTypeId(Int32? iCalMessageTypeId)
        {
            IEnumerable<IcalmessageRecord> recordCollection = this.Provider.DataProvider.Document.ICalMessage.FetchAllByIcmtId(iCalMessageTypeId);
            foreach (IcalmessageRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalICalMessageModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ICalMessageModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='ICalMessageModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ICalMessageModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalICalMessageModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<IcalmessageRecord> recordCollection = this.Provider.DataProvider.Document.ICalMessage.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (IcalmessageRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalICalMessageModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Checks if iCalMessage name exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the iCalendar Message.
        /// </param>
        /// <param name="iCalMessageId">
        ///     Id of the iCalendar Message.
        /// </param>
        /// <returns>
        ///     Whether iCalendar Message's name exist in database.
        /// </returns>
        System.Boolean IICalMessageFactory.CheckIfNameExist(System.String name, System.String iCalMessageId)
        {
            return this.CheckIfNameExist(name, iCalMessageId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ICalMessageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ICalMessageModel" /> instance.
        /// </returns>
        Consensus.Document.IICalMessageModel IICalMessageFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ICalMessageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ICalMessageModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IICalMessageModel> IICalMessageFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ICalMessageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ICalMessageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IICalMessageModel IICalMessageFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IICalMessageFactory.GetTableName()
        {
            return this.GetTableName();
        }

        System.Collections.Generic.IEnumerable<Consensus.Document.IICalMessageModel> IICalMessageFactory.FetchAllByICalMessageTypeId(System.Nullable<System.Int32> iCalMessageTypeId)
        {
            return this.FetchAllByICalMessageTypeId(iCalMessageTypeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ICalMessageModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ICalMessageModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IICalMessageModel> IICalMessageFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        #endregion
    }
}
