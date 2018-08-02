using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PrintRequestModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPrintRequestFactory : LocalFactory<LocalPrintRequestModel, PrintReqRecord, String>, IPrintRequestFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PrintRequestModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PrintRequestModel' /> instance.
        /// </returns>
        public LocalPrintRequestModel Create()
        {
            return new LocalPrintRequestModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PrintRequestModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PrintRequestModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPrintRequestModel> FetchAll()
        {
            IEnumerable<PrintReqRecord> recordCollection = this.Provider.DataProvider.Document.PrintRequest.FetchAll();
            foreach (PrintReqRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrintRequestModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PrintRequestModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PrintRequestModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrintRequestModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPrintRequestModel FetchById(String id)
        {
            PrintReqRecord record = this.Provider.DataProvider.Document.PrintRequest.FetchById(id);
            if (record == null)
                return null;
            return new LocalPrintRequestModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PrintRequest/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.PrintRequest.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PrintRequestModel' /> instances.
        /// </summary>
        /// <param name="queueId">
        ///     The value which identifies the <see cref='PrintRequestModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrintRequestModel' /> instances that match the specified <paramref name='queueId' />.
        /// </returns>
        public IEnumerable<LocalPrintRequestModel> FetchAllByQueueId(String queueId)
        {
            IEnumerable<PrintReqRecord> recordCollection = this.Provider.DataProvider.Document.PrintRequest.FetchAllByPqId(queueId);
            foreach (PrintReqRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrintRequestModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PrintRequestModel' /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref='PrintRequestModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrintRequestModel' /> instances that match the specified <paramref name='packId' />.
        /// </returns>
        public IEnumerable<LocalPrintRequestModel> FetchAllByPackId(String packId)
        {
            IEnumerable<PrintReqRecord> recordCollection = this.Provider.DataProvider.Document.PrintRequest.FetchAllByPackId(packId);
            foreach (PrintReqRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrintRequestModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PrintRequestModel' /> instances.
        /// </summary>
        /// <param name="batchId">
        ///     The value which identifies the <see cref='PrintRequestModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrintRequestModel' /> instances that match the specified <paramref name='batchId' />.
        /// </returns>
        public IEnumerable<LocalPrintRequestModel> FetchAllByBatchId(String batchId)
        {
            IEnumerable<PrintReqRecord> recordCollection = this.Provider.DataProvider.Document.PrintRequest.FetchAllByBatId(batchId);
            foreach (PrintReqRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrintRequestModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PrintRequestModel' /> instances.
        /// </summary>
        /// <param name="sendFromProleId">
        ///     The value which identifies the <see cref='PrintRequestModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrintRequestModel' /> instances that match the specified <paramref name='sendFromProleId' />.
        /// </returns>
        public IEnumerable<LocalPrintRequestModel> FetchAllBySendFromProleId(String sendFromProleId)
        {
            IEnumerable<PrintReqRecord> recordCollection = this.Provider.DataProvider.Document.PrintRequest.FetchAllBySendFromProleId(sendFromProleId);
            foreach (PrintReqRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrintRequestModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PrintRequestModel' /> instances.
        /// </summary>
        /// <param name="sendToProleId">
        ///     The value which identifies the <see cref='PrintRequestModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrintRequestModel' /> instances that match the specified <paramref name='sendToProleId' />.
        /// </returns>
        public IEnumerable<LocalPrintRequestModel> FetchAllBySendToProleId(String sendToProleId)
        {
            IEnumerable<PrintReqRecord> recordCollection = this.Provider.DataProvider.Document.PrintRequest.FetchAllBySendToProleId(sendToProleId);
            foreach (PrintReqRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrintRequestModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PrintRequestModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PrintRequestModel" /> instance.
        /// </returns>
        Consensus.Document.IPrintRequestModel IPrintRequestFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PrintRequestModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PrintRequestModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> IPrintRequestFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PrintRequestModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PrintRequestModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IPrintRequestModel IPrintRequestFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPrintRequestFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="queueId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="queueId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> IPrintRequestFactory.FetchAllByQueueId(System.String queueId)
        {
            return this.FetchAllByQueueId(queueId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> IPrintRequestFactory.FetchAllByPackId(System.String packId)
        {
            return this.FetchAllByPackId(packId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="batchId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="batchId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> IPrintRequestFactory.FetchAllByBatchId(System.String batchId)
        {
            return this.FetchAllByBatchId(batchId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="sendFromProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="sendFromProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> IPrintRequestFactory.FetchAllBySendFromProleId(System.String sendFromProleId)
        {
            return this.FetchAllBySendFromProleId(sendFromProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrintRequestModel" /> instances.
        /// </summary>
        /// <param name="sendToProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrintRequestModel" /> instances that match the specified <paramref name="sendToProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPrintRequestModel> IPrintRequestFactory.FetchAllBySendToProleId(System.String sendToProleId)
        {
            return this.FetchAllBySendToProleId(sendToProleId);
        }

        #endregion
    }
}
