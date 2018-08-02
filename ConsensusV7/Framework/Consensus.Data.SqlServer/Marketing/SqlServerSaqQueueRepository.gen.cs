using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SaqQueryQueueRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSaqQueueRepository : SqlServerRepository<SaqQueryQueueRecord, Int64>, ISaqQueueRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Marketing"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "SaqQueryQueue"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SaqQueryQueueRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_QQ_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SAQ_QUERY_QUEUE"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SaqQueryQueueRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqQueryQueueRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SaqQueryQueueRecord record)
        {
            record.Id = dataRecord["QQ_ID"].ConvertTo<Int64>();
            record.AddBy = dataRecord["QQ_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["QQ_ADD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["QQ_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["QQ_MOD_DATE"].ConvertTo<DateTime>();
            record.ProleId = dataRecord["QQ_PROLE_ID"].ConvertTo<String>();
            record.Priority = dataRecord["QQ_PRIORITY"].ConvertTo<Byte>();
            record.Processed = dataRecord["QQ_PROCESSED"].ConvertTo<Byte>();
            record.QryId = dataRecord["QQ_QRY_ID"].ConvertTo<Int64>();
            record.OutputOption = dataRecord["QQ_OUTPUT_OPTION"].ConvertTo<Byte?>();
            record.ProcessOption = dataRecord["QQ_PROCESS_OPTION"].ConvertTo<Byte?>();
            record.EmailWhenDone = dataRecord["QQ_EMAIL_WHEN_DONE"].ConvertTo<Byte>();
            record.RedoResultsIfExist = dataRecord["QQ_REDO_RESULTS_IF_EXIST"].ConvertTo<Byte>();
            record.EmailAddress = dataRecord["QQ_EMAIL_ADDRESS"].ConvertTo<String>();
            record.ActType = dataRecord["QQ_ACT_TYPE"].ConvertTo<String>();
            record.ActDate = dataRecord["QQ_ACT_DATE"].ConvertTo<DateTime?>();
            record.ActProleId = dataRecord["QQ_ACT_PROLE_ID"].ConvertTo<String>();
            record.ActNote = dataRecord["QQ_ACT_NOTE"].ConvertTo<String>();
            record.ListId = dataRecord["QQ_LIST_ID"].ConvertTo<String>();
            record.ProfKey = dataRecord["QQ_PROF_KEY"].ConvertTo<String>();
            record.ProfValue = dataRecord["QQ_PROF_VALUE"].ConvertTo<String>();
            record.ProfValue2 = dataRecord["QQ_PROF_VALUE2"].ConvertTo<String>();
            record.ProfValue3 = dataRecord["QQ_PROF_VALUE3"].ConvertTo<String>();
            record.FileType = dataRecord["QQ_FILE_TYPE"].ConvertTo<String>();
            record.PmId = dataRecord["QQ_PM_ID"].ConvertTo<String>();
            record.DateSelected = dataRecord["QQ_DATE_SELECTED"].ConvertTo<DateTime?>();
            record.Status = dataRecord["QQ_STATUS"].ConvertTo<String>();
            record.Error = dataRecord["QQ_ERROR"].ConvertTo<String>();
            record.ProfKeyOrg = dataRecord["QQ_PROF_KEY_ORG"].ConvertTo<String>();
            record.ProfValueOrg = dataRecord["QQ_PROF_VALUE_ORG"].ConvertTo<String>();
            record.ProfValue2Org = dataRecord["QQ_PROF_VALUE2_ORG"].ConvertTo<String>();
            record.ResultsType = dataRecord["QQ_RESULTS_TYPE"].ConvertTo<String>();
            record.ActArgId = dataRecord["QQ_ACT_ARG_ID"].ConvertTo<String>();
            record.ActQuestId = dataRecord["QQ_ACT_QUEST_ID"].ConvertTo<String>();
            record.ActPromotionId = dataRecord["QQ_ACT_PROMOTION_ID"].ConvertTo<String>();
            record.BppLitId = dataRecord["QQ_BPP_LIT_ID"].ConvertTo<String>();
            record.PackId = dataRecord["QQ_PACK_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqQueryQueueRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SaqQueryQueueRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_QQ_ID", record.Id == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_QQ_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_QQ_PRIORITY", record.Priority);
            this.MapParameterIn(command, "@PA_QQ_PROCESSED", record.Processed);
            this.MapParameterIn(command, "@PA_QQ_QRY_ID", record.QryId == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.QryId);
            this.MapParameterIn(command, "@PA_QQ_OUTPUT_OPTION", record.OutputOption);
            this.MapParameterIn(command, "@PA_QQ_PROCESS_OPTION", record.ProcessOption);
            this.MapParameterIn(command, "@PA_QQ_EMAIL_WHEN_DONE", record.EmailWhenDone);
            this.MapParameterIn(command, "@PA_QQ_REDO_RESULTS_IF_EXIST", record.RedoResultsIfExist);
            this.MapParameterIn(command, "@PA_QQ_EMAIL_ADDRESS", record.EmailAddress);
            this.MapParameterIn(command, "@PA_QQ_ACT_TYPE", record.ActType);
            this.MapParameterIn(command, "@PA_QQ_ACT_DATE", record.ActDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ActDate);
            this.MapParameterIn(command, "@PA_QQ_ACT_PROLE_ID", record.ActProleId);
            this.MapParameterIn(command, "@PA_QQ_ACT_NOTE", record.ActNote);
            this.MapParameterIn(command, "@PA_QQ_LIST_ID", record.ListId);
            this.MapParameterIn(command, "@PA_QQ_PROF_KEY", record.ProfKey);
            this.MapParameterIn(command, "@PA_QQ_PROF_VALUE", record.ProfValue);
            this.MapParameterIn(command, "@PA_QQ_PROF_VALUE2", record.ProfValue2);
            this.MapParameterIn(command, "@PA_QQ_PROF_VALUE3", record.ProfValue3);
            this.MapParameterIn(command, "@PA_QQ_FILE_TYPE", record.FileType);
            this.MapParameterIn(command, "@PA_QQ_PM_ID", record.PmId);
            this.MapParameterIn(command, "@PA_QQ_DATE_SELECTED", record.DateSelected == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateSelected);
            this.MapParameterIn(command, "@PA_QQ_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_QQ_ERROR", record.Error);
            this.MapParameterIn(command, "@PA_QQ_PROF_KEY_ORG", record.ProfKeyOrg);
            this.MapParameterIn(command, "@PA_QQ_PROF_VALUE_ORG", record.ProfValueOrg);
            this.MapParameterIn(command, "@PA_QQ_PROF_VALUE2_ORG", record.ProfValue2Org);
            this.MapParameterIn(command, "@PA_QQ_RESULTS_TYPE", record.ResultsType);
            this.MapParameterIn(command, "@PA_QQ_ACT_ARG_ID", record.ActArgId);
            this.MapParameterIn(command, "@PA_QQ_ACT_QUEST_ID", record.ActQuestId);
            this.MapParameterIn(command, "@PA_QQ_ACT_PROMOTION_ID", record.ActPromotionId);
            this.MapParameterIn(command, "@PA_QQ_BPP_LIT_ID", record.BppLitId);
            this.MapParameterIn(command, "@PA_QQ_PACK_ID", record.PackId);
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
        ///     The <see cref="SaqQueryQueueRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SaqQueryQueueRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_QQ_ID", record.Id);
            record.ProleId = this.MapParameterOut(command, "@PA_QQ_PROLE_ID", record.ProleId);
            record.Priority = this.MapParameterOut(command, "@PA_QQ_PRIORITY", record.Priority);
            record.Processed = this.MapParameterOut(command, "@PA_QQ_PROCESSED", record.Processed);
            record.QryId = this.MapParameterOut(command, "@PA_QQ_QRY_ID", record.QryId);
            record.OutputOption = this.MapParameterOut(command, "@PA_QQ_OUTPUT_OPTION", record.OutputOption);
            record.ProcessOption = this.MapParameterOut(command, "@PA_QQ_PROCESS_OPTION", record.ProcessOption);
            record.EmailWhenDone = this.MapParameterOut(command, "@PA_QQ_EMAIL_WHEN_DONE", record.EmailWhenDone);
            record.RedoResultsIfExist = this.MapParameterOut(command, "@PA_QQ_REDO_RESULTS_IF_EXIST", record.RedoResultsIfExist);
            record.EmailAddress = this.MapParameterOut(command, "@PA_QQ_EMAIL_ADDRESS", record.EmailAddress);
            record.ActType = this.MapParameterOut(command, "@PA_QQ_ACT_TYPE", record.ActType);
            record.ActDate = this.MapParameterOut(command, "@PA_QQ_ACT_DATE", record.ActDate);
            record.ActProleId = this.MapParameterOut(command, "@PA_QQ_ACT_PROLE_ID", record.ActProleId);
            record.ActNote = this.MapParameterOut(command, "@PA_QQ_ACT_NOTE", record.ActNote);
            record.ListId = this.MapParameterOut(command, "@PA_QQ_LIST_ID", record.ListId);
            record.ProfKey = this.MapParameterOut(command, "@PA_QQ_PROF_KEY", record.ProfKey);
            record.ProfValue = this.MapParameterOut(command, "@PA_QQ_PROF_VALUE", record.ProfValue);
            record.ProfValue2 = this.MapParameterOut(command, "@PA_QQ_PROF_VALUE2", record.ProfValue2);
            record.ProfValue3 = this.MapParameterOut(command, "@PA_QQ_PROF_VALUE3", record.ProfValue3);
            record.FileType = this.MapParameterOut(command, "@PA_QQ_FILE_TYPE", record.FileType);
            record.PmId = this.MapParameterOut(command, "@PA_QQ_PM_ID", record.PmId);
            record.DateSelected = this.MapParameterOut(command, "@PA_QQ_DATE_SELECTED", record.DateSelected);
            record.Status = this.MapParameterOut(command, "@PA_QQ_STATUS", record.Status);
            record.Error = this.MapParameterOut(command, "@PA_QQ_ERROR", record.Error);
            record.ProfKeyOrg = this.MapParameterOut(command, "@PA_QQ_PROF_KEY_ORG", record.ProfKeyOrg);
            record.ProfValueOrg = this.MapParameterOut(command, "@PA_QQ_PROF_VALUE_ORG", record.ProfValueOrg);
            record.ProfValue2Org = this.MapParameterOut(command, "@PA_QQ_PROF_VALUE2_ORG", record.ProfValue2Org);
            record.ResultsType = this.MapParameterOut(command, "@PA_QQ_RESULTS_TYPE", record.ResultsType);
            record.ActArgId = this.MapParameterOut(command, "@PA_QQ_ACT_ARG_ID", record.ActArgId);
            record.ActQuestId = this.MapParameterOut(command, "@PA_QQ_ACT_QUEST_ID", record.ActQuestId);
            record.ActPromotionId = this.MapParameterOut(command, "@PA_QQ_ACT_PROMOTION_ID", record.ActPromotionId);
            record.BppLitId = this.MapParameterOut(command, "@PA_QQ_BPP_LIT_ID", record.BppLitId);
            record.PackId = this.MapParameterOut(command, "@PA_QQ_PACK_ID", record.PackId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="qryId">
        ///     The value which identifies the <see cref='SaqQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryQueueRecord" /> instances that match the specified <paramref name='qryId' />.
        /// </returns>
        public IEnumerable<SaqQueryQueueRecord> FetchAllByQryId(Int64 qryId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "QryId");
            this.MapParameterIn(command, "@PA_QQ_QRY_ID", qryId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="listId">
        ///     The value which identifies the <see cref='SaqQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryQueueRecord" /> instances that match the specified <paramref name='listId' />.
        /// </returns>
        public IEnumerable<SaqQueryQueueRecord> FetchAllByListId(String listId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ListId");
            this.MapParameterIn(command, "@PA_QQ_LIST_ID", listId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="profKey">
        ///     The value which identifies the <see cref='SaqQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryQueueRecord" /> instances that match the specified <paramref name='profKey' />.
        /// </returns>
        public IEnumerable<SaqQueryQueueRecord> FetchAllByProfKey(String profKey)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProfKey");
            this.MapParameterIn(command, "@PA_QQ_PROF_KEY", profKey);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="profKeyOrg">
        ///     The value which identifies the <see cref='SaqQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryQueueRecord" /> instances that match the specified <paramref name='profKeyOrg' />.
        /// </returns>
        public IEnumerable<SaqQueryQueueRecord> FetchAllByProfKeyOrg(String profKeyOrg)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProfKeyOrg");
            this.MapParameterIn(command, "@PA_QQ_PROF_KEY_ORG", profKeyOrg);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref='SaqQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryQueueRecord" /> instances that match the specified <paramref name='packId' />.
        /// </returns>
        public IEnumerable<SaqQueryQueueRecord> FetchAllByPackId(String packId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PackId");
            this.MapParameterIn(command, "@PA_QQ_PACK_ID", packId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISaqQueueRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="qryId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="qryId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> ISaqQueueRepository.FetchAllByQryId(System.Int64 qryId)
        {
            return this.FetchAllByQryId(qryId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="listId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="listId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> ISaqQueueRepository.FetchAllByListId(System.String listId)
        {
            return this.FetchAllByListId(listId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="profKey">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="profKey" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> ISaqQueueRepository.FetchAllByProfKey(System.String profKey)
        {
            return this.FetchAllByProfKey(profKey);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="profKeyOrg">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="profKeyOrg" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> ISaqQueueRepository.FetchAllByProfKeyOrg(System.String profKeyOrg)
        {
            return this.FetchAllByProfKeyOrg(profKeyOrg);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> ISaqQueueRepository.FetchAllByPackId(System.String packId)
        {
            return this.FetchAllByPackId(packId);
        }

        #endregion
    }
}
