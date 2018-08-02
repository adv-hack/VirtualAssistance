using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PrintReqRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPrintRequestRepository : SqlServerRepository<PrintReqRecord, String>, IPrintRequestRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Document"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "PrintReq"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PrintReqRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PR_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Print_Req"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PrintReqRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PrintReqRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PrintReqRecord record)
        {
            record.Id = dataRecord["PR_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["PR_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PR_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PR_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PR_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PR_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PR_RCV_FROM"].ConvertTo<String>();
            record.Id1 = dataRecord["PR_ID_1"].ConvertTo<String>();
            record.Id2 = dataRecord["PR_ID_2"].ConvertTo<String>();
            record.Id3 = dataRecord["PR_ID_3"].ConvertTo<String>();
            record.Type = dataRecord["PR_TYPE"].ConvertTo<String>();
            record.Status = dataRecord["PR_STATUS"].ConvertTo<Int32?>();
            record.ReqDate = dataRecord["PR_REQ_DATE"].ConvertTo<DateTime?>();
            record.DoneDate = dataRecord["PR_DONE_DATE"].ConvertTo<DateTime?>();
            record.ReqBy = dataRecord["PR_REQ_BY"].ConvertTo<String>();
            record.PqId = dataRecord["PR_PQ_ID"].ConvertTo<String>();
            record.ActPqStatus = dataRecord["PR_ACT_PQ_STATUS"].ConvertTo<String>();
            record.PqSendType = dataRecord["PR_PQ_SEND_TYPE"].ConvertTo<String>();
            record.PackId = dataRecord["PR_PACK_ID"].ConvertTo<String>();
            record.WfId = dataRecord["PR_WF_ID"].ConvertTo<String>();
            record.BatId = dataRecord["PR_BAT_ID"].ConvertTo<String>();
            record.LtId = dataRecord["PR_LT_ID"].ConvertTo<String>();
            record.SendToBooker = dataRecord["PR_SEND_TO_BOOKER"].ConvertTo<Byte?>();
            record.SendToDelegate = dataRecord["PR_SEND_TO_DELEGATE"].ConvertTo<Byte?>();
            record.SendFromProleId = dataRecord["PR_SEND_FROM_PROLE_ID"].ConvertTo<String>();
            record.SendToProleId = dataRecord["PR_SEND_TO_PROLE_ID"].ConvertTo<String>();
            record.EmailSubject = dataRecord["PR_EMAIL_SUBJECT"].ConvertTo<String>();
            record.EmailCcAddress = dataRecord["PR_EMAIL_CC_ADDRESS"].ConvertTo<String>();
            record.Reissue = dataRecord["PR_REISSUE"].ConvertTo<Byte?>();
            record.Id4 = dataRecord["PR_ID_4"].ConvertTo<String>();
            record.WfaId = dataRecord["PR_WFA_ID"].ConvertTo<String>();
            record.UseHomeAddress = dataRecord["PR_USE_HOME_ADDRESS"].ConvertTo<Byte?>();
            record.EmailSendFromPerson = dataRecord["PR_EMAIL_SEND_FROM_PERSON"].ConvertTo<Byte?>();
            record.SmsId = dataRecord["PR_SMS_ID"].ConvertTo<Int32?>();
            record.PrId = dataRecord["PR_PR_ID"].ConvertTo<String>();
            record.Id5 = dataRecord["PR_ID_5"].ConvertTo<String>();
            record.WfxrefRecId = dataRecord["PR_WFXREF_REC_ID"].ConvertTo<String>();
            record.ArgId = dataRecord["PR_ARG_ID"].ConvertTo<String>();
            record.BccEmail = dataRecord["PR_BCC_EMAIL"].ConvertTo<String>();
            record.MdnEmail = dataRecord["PR_MDN_EMAIL"].ConvertTo<String>();
            record.DsnEmail = dataRecord["PR_DSN_EMAIL"].ConvertTo<String>();
            record.DsnOptions = dataRecord["PR_DSN_OPTIONS"].ConvertTo<String>();
            record.IcmId = dataRecord["PR_ICM_ID"].ConvertTo<Int32?>();
            record.Name = dataRecord["PR_NAME"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PrintReqRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PrintReqRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PR_ID", record.Id);
            this.MapParameterIn(command, "@PA_PR_ID_1", record.Id1);
            this.MapParameterIn(command, "@PA_PR_ID_2", record.Id2);
            this.MapParameterIn(command, "@PA_PR_ID_3", record.Id3);
            this.MapParameterIn(command, "@PA_PR_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_PR_STATUS", record.Status == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Status);
            this.MapParameterIn(command, "@PA_PR_REQ_DATE", record.ReqDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ReqDate);
            this.MapParameterIn(command, "@PA_PR_DONE_DATE", record.DoneDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DoneDate);
            this.MapParameterIn(command, "@PA_PR_REQ_BY", record.ReqBy);
            this.MapParameterIn(command, "@PA_PR_PQ_ID", record.PqId);
            this.MapParameterIn(command, "@PA_PR_ACT_PQ_STATUS", record.ActPqStatus);
            this.MapParameterIn(command, "@PA_PR_PQ_SEND_TYPE", record.PqSendType);
            this.MapParameterIn(command, "@PA_PR_PACK_ID", record.PackId);
            this.MapParameterIn(command, "@PA_PR_WF_ID", record.WfId);
            this.MapParameterIn(command, "@PA_PR_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_PR_LT_ID", record.LtId);
            this.MapParameterIn(command, "@PA_PR_SEND_TO_BOOKER", record.SendToBooker);
            this.MapParameterIn(command, "@PA_PR_SEND_TO_DELEGATE", record.SendToDelegate);
            this.MapParameterIn(command, "@PA_PR_SEND_FROM_PROLE_ID", record.SendFromProleId);
            this.MapParameterIn(command, "@PA_PR_SEND_TO_PROLE_ID", record.SendToProleId);
            this.MapParameterIn(command, "@PA_PR_EMAIL_SUBJECT", record.EmailSubject);
            this.MapParameterIn(command, "@PA_PR_EMAIL_CC_ADDRESS", record.EmailCcAddress);
            this.MapParameterIn(command, "@PA_PR_REISSUE", record.Reissue);
            this.MapParameterIn(command, "@PA_PR_ID_4", record.Id4);
            this.MapParameterIn(command, "@PA_PR_WFA_ID", record.WfaId);
            this.MapParameterIn(command, "@PA_PR_USE_HOME_ADDRESS", record.UseHomeAddress);
            this.MapParameterIn(command, "@PA_PR_EMAIL_SEND_FROM_PERSON", record.EmailSendFromPerson);
            this.MapParameterIn(command, "@PA_PR_SMS_ID", record.SmsId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SmsId);
            this.MapParameterIn(command, "@PA_PR_PR_ID", record.PrId);
            this.MapParameterIn(command, "@PA_PR_ID_5", record.Id5);
            this.MapParameterIn(command, "@PA_PR_WFXREF_REC_ID", record.WfxrefRecId);
            this.MapParameterIn(command, "@PA_PR_ARG_ID", record.ArgId);
            this.MapParameterIn(command, "@PA_PR_BCC_EMAIL", record.BccEmail);
            this.MapParameterIn(command, "@PA_PR_MDN_EMAIL", record.MdnEmail);
            this.MapParameterIn(command, "@PA_PR_DSN_EMAIL", record.DsnEmail);
            this.MapParameterIn(command, "@PA_PR_DSN_OPTIONS", record.DsnOptions);
            this.MapParameterIn(command, "@PA_PR_ICM_ID", record.IcmId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.IcmId);
            this.MapParameterIn(command, "@PA_PR_NAME", record.Name);
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
        ///     The <see cref="PrintReqRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PrintReqRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PR_ID", record.Id);
            record.Id1 = this.MapParameterOut(command, "@PA_PR_ID_1", record.Id1);
            record.Id2 = this.MapParameterOut(command, "@PA_PR_ID_2", record.Id2);
            record.Id3 = this.MapParameterOut(command, "@PA_PR_ID_3", record.Id3);
            record.Type = this.MapParameterOut(command, "@PA_PR_TYPE", record.Type);
            record.Status = this.MapParameterOut(command, "@PA_PR_STATUS", record.Status);
            record.ReqDate = this.MapParameterOut(command, "@PA_PR_REQ_DATE", record.ReqDate);
            record.DoneDate = this.MapParameterOut(command, "@PA_PR_DONE_DATE", record.DoneDate);
            record.ReqBy = this.MapParameterOut(command, "@PA_PR_REQ_BY", record.ReqBy);
            record.PqId = this.MapParameterOut(command, "@PA_PR_PQ_ID", record.PqId);
            record.ActPqStatus = this.MapParameterOut(command, "@PA_PR_ACT_PQ_STATUS", record.ActPqStatus);
            record.PqSendType = this.MapParameterOut(command, "@PA_PR_PQ_SEND_TYPE", record.PqSendType);
            record.PackId = this.MapParameterOut(command, "@PA_PR_PACK_ID", record.PackId);
            record.WfId = this.MapParameterOut(command, "@PA_PR_WF_ID", record.WfId);
            record.BatId = this.MapParameterOut(command, "@PA_PR_BAT_ID", record.BatId);
            record.LtId = this.MapParameterOut(command, "@PA_PR_LT_ID", record.LtId);
            record.SendToBooker = this.MapParameterOut(command, "@PA_PR_SEND_TO_BOOKER", record.SendToBooker);
            record.SendToDelegate = this.MapParameterOut(command, "@PA_PR_SEND_TO_DELEGATE", record.SendToDelegate);
            record.SendFromProleId = this.MapParameterOut(command, "@PA_PR_SEND_FROM_PROLE_ID", record.SendFromProleId);
            record.SendToProleId = this.MapParameterOut(command, "@PA_PR_SEND_TO_PROLE_ID", record.SendToProleId);
            record.EmailSubject = this.MapParameterOut(command, "@PA_PR_EMAIL_SUBJECT", record.EmailSubject);
            record.EmailCcAddress = this.MapParameterOut(command, "@PA_PR_EMAIL_CC_ADDRESS", record.EmailCcAddress);
            record.Reissue = this.MapParameterOut(command, "@PA_PR_REISSUE", record.Reissue);
            record.Id4 = this.MapParameterOut(command, "@PA_PR_ID_4", record.Id4);
            record.WfaId = this.MapParameterOut(command, "@PA_PR_WFA_ID", record.WfaId);
            record.UseHomeAddress = this.MapParameterOut(command, "@PA_PR_USE_HOME_ADDRESS", record.UseHomeAddress);
            record.EmailSendFromPerson = this.MapParameterOut(command, "@PA_PR_EMAIL_SEND_FROM_PERSON", record.EmailSendFromPerson);
            record.SmsId = this.MapParameterOut(command, "@PA_PR_SMS_ID", record.SmsId);
            record.PrId = this.MapParameterOut(command, "@PA_PR_PR_ID", record.PrId);
            record.Id5 = this.MapParameterOut(command, "@PA_PR_ID_5", record.Id5);
            record.WfxrefRecId = this.MapParameterOut(command, "@PA_PR_WFXREF_REC_ID", record.WfxrefRecId);
            record.ArgId = this.MapParameterOut(command, "@PA_PR_ARG_ID", record.ArgId);
            record.BccEmail = this.MapParameterOut(command, "@PA_PR_BCC_EMAIL", record.BccEmail);
            record.MdnEmail = this.MapParameterOut(command, "@PA_PR_MDN_EMAIL", record.MdnEmail);
            record.DsnEmail = this.MapParameterOut(command, "@PA_PR_DSN_EMAIL", record.DsnEmail);
            record.DsnOptions = this.MapParameterOut(command, "@PA_PR_DSN_OPTIONS", record.DsnOptions);
            record.IcmId = this.MapParameterOut(command, "@PA_PR_ICM_ID", record.IcmId);
            record.Name = this.MapParameterOut(command, "@PA_PR_NAME", record.Name);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pqId">
        ///     The value which identifies the <see cref='PrintRequestModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PrintReqRecord" /> instances that match the specified <paramref name='pqId' />.
        /// </returns>
        public IEnumerable<PrintReqRecord> FetchAllByPqId(String pqId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PqId");
            this.MapParameterIn(command, "@PA_PR_PQ_ID", pqId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref='PrintRequestModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PrintReqRecord" /> instances that match the specified <paramref name='packId' />.
        /// </returns>
        public IEnumerable<PrintReqRecord> FetchAllByPackId(String packId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PackId");
            this.MapParameterIn(command, "@PA_PR_PACK_ID", packId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="batId">
        ///     The value which identifies the <see cref='PrintRequestModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PrintReqRecord" /> instances that match the specified <paramref name='batId' />.
        /// </returns>
        public IEnumerable<PrintReqRecord> FetchAllByBatId(String batId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BatId");
            this.MapParameterIn(command, "@PA_PR_BAT_ID", batId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendFromProleId">
        ///     The value which identifies the <see cref='PrintRequestModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PrintReqRecord" /> instances that match the specified <paramref name='sendFromProleId' />.
        /// </returns>
        public IEnumerable<PrintReqRecord> FetchAllBySendFromProleId(String sendFromProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SendFromProleId");
            this.MapParameterIn(command, "@PA_PR_SEND_FROM_PROLE_ID", sendFromProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendToProleId">
        ///     The value which identifies the <see cref='PrintRequestModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PrintReqRecord" /> instances that match the specified <paramref name='sendToProleId' />.
        /// </returns>
        public IEnumerable<PrintReqRecord> FetchAllBySendToProleId(String sendToProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SendToProleId");
            this.MapParameterIn(command, "@PA_PR_SEND_TO_PROLE_ID", sendToProleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPrintRequestRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pqId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances that match the specified <paramref name="pqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintReqRecord> IPrintRequestRepository.FetchAllByPqId(System.String pqId)
        {
            return this.FetchAllByPqId(pqId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintReqRecord> IPrintRequestRepository.FetchAllByPackId(System.String packId)
        {
            return this.FetchAllByPackId(packId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="batId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances that match the specified <paramref name="batId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintReqRecord> IPrintRequestRepository.FetchAllByBatId(System.String batId)
        {
            return this.FetchAllByBatId(batId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendFromProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances that match the specified <paramref name="sendFromProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintReqRecord> IPrintRequestRepository.FetchAllBySendFromProleId(System.String sendFromProleId)
        {
            return this.FetchAllBySendFromProleId(sendFromProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendToProleId">
        ///     The value which identifies the <see cref="!:PrintRequestModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintReqRecord" /> instances that match the specified <paramref name="sendToProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintReqRecord> IPrintRequestRepository.FetchAllBySendToProleId(System.String sendToProleId)
        {
            return this.FetchAllBySendToProleId(sendToProleId);
        }

        #endregion
    }
}
