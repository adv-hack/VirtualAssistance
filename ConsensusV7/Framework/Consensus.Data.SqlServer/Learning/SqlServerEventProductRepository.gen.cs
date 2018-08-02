using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="EventProductRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerEventProductRepository : SqlServerRepository<EventProductRecord, Int32>, IEventProductRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Learning"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "EventProduct"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="EventProductRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_EP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "EVENT_PRODUCT"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="EventProductRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="EventProductRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, EventProductRecord record)
        {
            record.Id = dataRecord["EP_ID"].ConvertTo<Int32>();
            record.AddBy = dataRecord["EP_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["EP_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["EP_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["EP_MOD_DATE"].ConvertTo<DateTime?>();
            record.EventId = dataRecord["EP_COURSE_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["EP_PROD_ID"].ConvertTo<String>();
            record.Notes = dataRecord["EP_NOTES"].ConvertTo<String>();
            record.Qty = dataRecord["EP_QTY"].ConvertTo<Int32?>();
            record.DelegateQty = dataRecord["EP_DELEGATE_QTY"].ConvertTo<Int32?>();
            record.BomId = dataRecord["EP_BOM_ID"].ConvertTo<String>();
            record.Predeliv = dataRecord["EP_PREDELIV"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="EventProductRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, EventProductRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_EP_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_EP_COURSE_ID", record.EventId);
            this.MapParameterIn(command, "@PA_EP_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_EP_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_EP_QTY", record.Qty == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Qty);
            this.MapParameterIn(command, "@PA_EP_DELEGATE_QTY", record.DelegateQty == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DelegateQty);
            this.MapParameterIn(command, "@PA_EP_BOM_ID", record.BomId);
            this.MapParameterIn(command, "@PA_EP_PREDELIV", record.Predeliv);
            this.MapParameterIn(command, "@_AUDIT_USER_ID", UserId);
            this.MapParameterIn(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="EventProductRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, EventProductRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_EP_ID", record.Id);
            record.EventId = this.MapParameterOut(command, "@PA_EP_COURSE_ID", record.EventId);
            record.ProdId = this.MapParameterOut(command, "@PA_EP_PROD_ID", record.ProdId);
            record.Notes = this.MapParameterOut(command, "@PA_EP_NOTES", record.Notes);
            record.Qty = this.MapParameterOut(command, "@PA_EP_QTY", record.Qty);
            record.DelegateQty = this.MapParameterOut(command, "@PA_EP_DELEGATE_QTY", record.DelegateQty);
            record.BomId = this.MapParameterOut(command, "@PA_EP_BOM_ID", record.BomId);
            record.Predeliv = this.MapParameterOut(command, "@PA_EP_PREDELIV", record.Predeliv);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="EventProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref='EventProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="EventProductRecord" /> instances that match the specified <paramref name='eventId' />.
        /// </returns>
        public IEnumerable<EventProductRecord> FetchAllByEventId(String eventId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "EventId");
            this.MapParameterIn(command, "@PA_EP_COURSE_ID", eventId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="EventProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='EventProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="EventProductRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<EventProductRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_EP_PROD_ID", prodId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="EventProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notes">
        ///     The value which identifies the <see cref='EventProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="EventProductRecord" /> instances that match the specified <paramref name='notes' />.
        /// </returns>
        public IEnumerable<EventProductRecord> FetchAllByNotes(String notes)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Notes");
            this.MapParameterIn(command, "@PA_EP_NOTES", notes);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IEventProductRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.EventProductRecord> IEventProductRepository.FetchAllByEventId(System.String eventId)
        {
            return this.FetchAllByEventId(eventId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.EventProductRecord> IEventProductRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notes">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances that match the specified <paramref name="notes" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.EventProductRecord> IEventProductRepository.FetchAllByNotes(System.String notes)
        {
            return this.FetchAllByNotes(notes);
        }

        #endregion
    }
}
