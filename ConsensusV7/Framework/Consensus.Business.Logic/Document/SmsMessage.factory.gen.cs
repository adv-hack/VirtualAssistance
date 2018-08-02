using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SmsMessageModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSmsMessageFactory : LocalFactory<LocalSmsMessageModel, SmsMessageRecord, Int32>, ISmsMessageFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SmsMessageModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SmsMessageModel' /> instance.
        /// </returns>
        public LocalSmsMessageModel Create()
        {
            return new LocalSmsMessageModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SmsMessageModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SmsMessageModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSmsMessageModel> FetchAll()
        {
            IEnumerable<SmsMessageRecord> recordCollection = this.Provider.DataProvider.Document.SmsMessage.FetchAll();
            foreach (SmsMessageRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSmsMessageModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SmsMessageModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SmsMessageModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SmsMessageModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSmsMessageModel FetchById(Int32 id)
        {
            SmsMessageRecord record = this.Provider.DataProvider.Document.SmsMessage.FetchById(id);
            if (record == null)
                return null;
            return new LocalSmsMessageModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SmsMessage/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.SmsMessage.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SmsMessageModel' /> instances.
        /// </summary>
        /// <param name="smsMessageTypeId">
        ///     The value which identifies the <see cref='SmsMessageModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SmsMessageModel' /> instances that match the specified <paramref name='smsMessageTypeId' />.
        /// </returns>
        public IEnumerable<LocalSmsMessageModel> FetchAllBySmsMessageTypeId(Int32? smsMessageTypeId)
        {
            IEnumerable<SmsMessageRecord> recordCollection = this.Provider.DataProvider.Document.SmsMessage.FetchAllBySmtId(smsMessageTypeId);
            foreach (SmsMessageRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSmsMessageModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SmsMessageModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='SmsMessageModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SmsMessageModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalSmsMessageModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<SmsMessageRecord> recordCollection = this.Provider.DataProvider.Document.SmsMessage.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (SmsMessageRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSmsMessageModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Checks if smsmessage name exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the smsmessage.
        /// </param>
        /// <param name="smsmessageId">
        ///     Id of the smsmessage.
        /// </param>
        /// <returns>
        ///     Whether smsmessage's name exist in database.
        /// </returns>
        System.Boolean ISmsMessageFactory.CheckIfNameExist(System.String name, System.String smsmessageId)
        {
            return this.CheckIfNameExist(name, smsmessageId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SmsMessageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SmsMessageModel" /> instance.
        /// </returns>
        Consensus.Document.ISmsMessageModel ISmsMessageFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SmsMessageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SmsMessageModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ISmsMessageModel> ISmsMessageFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SmsMessageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SmsMessageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsMessageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.ISmsMessageModel ISmsMessageFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ISmsMessageFactory.GetTableName()
        {
            return this.GetTableName();
        }

        System.Collections.Generic.IEnumerable<Consensus.Document.ISmsMessageModel> ISmsMessageFactory.FetchAllBySmsMessageTypeId(System.Nullable<System.Int32> smsMessageTypeId)
        {
            return this.FetchAllBySmsMessageTypeId(smsMessageTypeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SmsMessageModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SmsMessageModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsMessageModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ISmsMessageModel> ISmsMessageFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        #endregion
    }
}
