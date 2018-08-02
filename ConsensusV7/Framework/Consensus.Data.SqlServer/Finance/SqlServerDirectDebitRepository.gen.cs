using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="DirectdebitRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerDirectDebitRepository : SqlServerRepository<DirectdebitRecord, String>, IDirectDebitRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Finance"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Directdebit"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="DirectdebitRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_DD_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "DirectDebit"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="DirectdebitRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="DirectdebitRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, DirectdebitRecord record)
        {
            record.Id = dataRecord["DD_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["DD_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["DD_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["DD_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["DD_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["DD_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["DD_RCV_FROM"].ConvertTo<String>();
            record.TableNum = dataRecord["DD_TABLE_NUM"].ConvertTo<Double?>();
            record.RecId = dataRecord["DD_REC_ID"].ConvertTo<String>();
            record.Type = dataRecord["DD_TYPE"].ConvertTo<Int32?>();
            record.Oin = dataRecord["DD_OIN"].ConvertTo<String>();
            record.RecDate = dataRecord["DD_REC_DATE"].ConvertTo<DateTime?>();
            record.RecMethod = dataRecord["DD_REC_METHOD"].ConvertTo<Int32?>();
            record.ToBankDate = dataRecord["DD_TO_BANK_DATE"].ConvertTo<DateTime?>();
            record.EffectiveDate = dataRecord["DD_EFFECTIVE_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["DD_END_DATE"].ConvertTo<DateTime?>();
            record.Status = dataRecord["DD_STATUS"].ConvertTo<Int32?>();
            record.Frequency = dataRecord["DD_FREQUENCY"].ConvertTo<Int32?>();
            record.DayOfMonth = dataRecord["DD_DAY_OF_MONTH"].ConvertTo<Int32?>();
            record.Variable = dataRecord["DD_VARIABLE"].ConvertTo<Int32?>();
            record.MaxValue = dataRecord["DD_MAX_VALUE"].ConvertTo<Decimal?>();
            record.CurrencyType = dataRecord["DD_CURRENCY_TYPE"].ConvertTo<String>();
            record.BankName = dataRecord["DD_BANK_NAME"].ConvertTo<String>();
            record.BankAdd1 = dataRecord["DD_BANK_ADD_1"].ConvertTo<String>();
            record.BankAdd2 = dataRecord["DD_BANK_ADD_2"].ConvertTo<String>();
            record.BankAdd3 = dataRecord["DD_BANK_ADD_3"].ConvertTo<String>();
            record.BankAdd4 = dataRecord["DD_BANK_ADD_4"].ConvertTo<String>();
            record.BankPostcode = dataRecord["DD_BANK_POSTCODE"].ConvertTo<String>();
            record.CoreRef = dataRecord["DD_CORE_REF"].ConvertTo<String>();
            record.BankAccName = dataRecord["DD_BANK_ACC_NAME"].ConvertTo<String>();
            record.BankAccCode = dataRecord["DD_BANK_ACC_CODE"].ConvertTo<String>();
            record.SortCode = dataRecord["DD_SORT_CODE"].ConvertTo<String>();
            record.CcardType = dataRecord["DD_CCARD_TYPE"].ConvertTo<String>();
            record.NameOnCard = dataRecord["DD_NAME_ON_CARD"].ConvertTo<String>();
            record.CcardNumber = dataRecord["DD_CCARD_NUMBER"].ConvertTo<String>();
            record.CcardIssue = dataRecord["DD_CCARD_ISSUE"].ConvertTo<String>();
            record.CcardSecId = dataRecord["DD_CCARD_SEC_ID"].ConvertTo<String>();
            record.CcardStartMth = dataRecord["DD_CCARD_START_MTH"].ConvertTo<String>();
            record.CcardStartYr = dataRecord["DD_CCARD_START_YR"].ConvertTo<String>();
            record.CcardExpyMth = dataRecord["DD_CCARD_EXPY_MTH"].ConvertTo<String>();
            record.CcardExpyYr = dataRecord["DD_CCARD_EXPY_YR"].ConvertTo<String>();
            record.Notes = dataRecord["DD_NOTES"].ConvertTo<String>();
            record.BankOrgId = dataRecord["DD_BANK_ORG_ID"].ConvertTo<String>();
            record.BankAddId = dataRecord["DD_BANK_ADD_ID"].ConvertTo<String>();
            record.RecordStatus = dataRecord["DD_RECORD_STATUS"].ConvertTo<Byte>();
            record.BatId = dataRecord["DD_BAT_ID"].ConvertTo<String>();
            record.Total = dataRecord["DD_TOTAL"].ConvertTo<Decimal?>();
            record.StatusNotes = dataRecord["DD_STATUS_NOTES"].ConvertTo<String>();
            record.StatusLastDate = dataRecord["DD_STATUS_LAST_DATE"].ConvertTo<DateTime?>();
            record.StatusPrevious = dataRecord["DD_STATUS_PREVIOUS"].ConvertTo<Byte?>();
            record.NoOfInstallments = dataRecord["DD_NO_OF_INSTALLMENTS"].ConvertTo<Int32?>();
            record.DueDate = dataRecord["DD_DUE_DATE"].ConvertTo<DateTime?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="DirectdebitRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, DirectdebitRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_DD_ID", record.Id);
            this.MapParameterIn(command, "@PA_DD_TABLE_NUM", record.TableNum == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TableNum);
            this.MapParameterIn(command, "@PA_DD_REC_ID", record.RecId);
            this.MapParameterIn(command, "@PA_DD_TYPE", record.Type == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Type);
            this.MapParameterIn(command, "@PA_DD_OIN", record.Oin);
            this.MapParameterIn(command, "@PA_DD_REC_DATE", record.RecDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RecDate);
            this.MapParameterIn(command, "@PA_DD_REC_METHOD", record.RecMethod == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.RecMethod);
            this.MapParameterIn(command, "@PA_DD_TO_BANK_DATE", record.ToBankDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ToBankDate);
            this.MapParameterIn(command, "@PA_DD_EFFECTIVE_DATE", record.EffectiveDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EffectiveDate);
            this.MapParameterIn(command, "@PA_DD_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_DD_STATUS", record.Status == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Status);
            this.MapParameterIn(command, "@PA_DD_FREQUENCY", record.Frequency == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Frequency);
            this.MapParameterIn(command, "@PA_DD_DAY_OF_MONTH", record.DayOfMonth == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DayOfMonth);
            this.MapParameterIn(command, "@PA_DD_VARIABLE", record.Variable == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Variable);
            this.MapParameterIn(command, "@PA_DD_MAX_VALUE", record.MaxValue == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.MaxValue);
            this.MapParameterIn(command, "@PA_DD_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_DD_BANK_NAME", record.BankName);
            this.MapParameterIn(command, "@PA_DD_BANK_ADD_1", record.BankAdd1);
            this.MapParameterIn(command, "@PA_DD_BANK_ADD_2", record.BankAdd2);
            this.MapParameterIn(command, "@PA_DD_BANK_ADD_3", record.BankAdd3);
            this.MapParameterIn(command, "@PA_DD_BANK_ADD_4", record.BankAdd4);
            this.MapParameterIn(command, "@PA_DD_BANK_POSTCODE", record.BankPostcode);
            this.MapParameterIn(command, "@PA_DD_CORE_REF", record.CoreRef);
            this.MapParameterIn(command, "@PA_DD_BANK_ACC_NAME", record.BankAccName);
            this.MapParameterIn(command, "@PA_DD_BANK_ACC_CODE", record.BankAccCode);
            this.MapParameterIn(command, "@PA_DD_SORT_CODE", record.SortCode);
            this.MapParameterIn(command, "@PA_DD_CCARD_TYPE", record.CcardType);
            this.MapParameterIn(command, "@PA_DD_NAME_ON_CARD", record.NameOnCard);
            this.MapParameterIn(command, "@PA_DD_CCARD_NUMBER", record.CcardNumber);
            this.MapParameterIn(command, "@PA_DD_CCARD_ISSUE", record.CcardIssue);
            this.MapParameterIn(command, "@PA_DD_CCARD_SEC_ID", record.CcardSecId);
            this.MapParameterIn(command, "@PA_DD_CCARD_START_MTH", record.CcardStartMth);
            this.MapParameterIn(command, "@PA_DD_CCARD_START_YR", record.CcardStartYr);
            this.MapParameterIn(command, "@PA_DD_CCARD_EXPY_MTH", record.CcardExpyMth);
            this.MapParameterIn(command, "@PA_DD_CCARD_EXPY_YR", record.CcardExpyYr);
            this.MapParameterIn(command, "@PA_DD_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_DD_BANK_ORG_ID", record.BankOrgId);
            this.MapParameterIn(command, "@PA_DD_BANK_ADD_ID", record.BankAddId);
            this.MapParameterIn(command, "@PA_DD_RECORD_STATUS", record.RecordStatus);
            this.MapParameterIn(command, "@PA_DD_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_DD_TOTAL", record.Total == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Total);
            this.MapParameterIn(command, "@PA_DD_STATUS_NOTES", record.StatusNotes);
            this.MapParameterIn(command, "@PA_DD_STATUS_LAST_DATE", record.StatusLastDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StatusLastDate);
            this.MapParameterIn(command, "@PA_DD_STATUS_PREVIOUS", record.StatusPrevious);
            this.MapParameterIn(command, "@PA_DD_NO_OF_INSTALLMENTS", record.NoOfInstallments == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NoOfInstallments);
            this.MapParameterIn(command, "@PA_DD_DUE_DATE", record.DueDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DueDate);
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
        ///     The <see cref="DirectdebitRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, DirectdebitRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_DD_ID", record.Id);
            record.TableNum = this.MapParameterOut(command, "@PA_DD_TABLE_NUM", record.TableNum);
            record.RecId = this.MapParameterOut(command, "@PA_DD_REC_ID", record.RecId);
            record.Type = this.MapParameterOut(command, "@PA_DD_TYPE", record.Type);
            record.Oin = this.MapParameterOut(command, "@PA_DD_OIN", record.Oin);
            record.RecDate = this.MapParameterOut(command, "@PA_DD_REC_DATE", record.RecDate);
            record.RecMethod = this.MapParameterOut(command, "@PA_DD_REC_METHOD", record.RecMethod);
            record.ToBankDate = this.MapParameterOut(command, "@PA_DD_TO_BANK_DATE", record.ToBankDate);
            record.EffectiveDate = this.MapParameterOut(command, "@PA_DD_EFFECTIVE_DATE", record.EffectiveDate);
            record.EndDate = this.MapParameterOut(command, "@PA_DD_END_DATE", record.EndDate);
            record.Status = this.MapParameterOut(command, "@PA_DD_STATUS", record.Status);
            record.Frequency = this.MapParameterOut(command, "@PA_DD_FREQUENCY", record.Frequency);
            record.DayOfMonth = this.MapParameterOut(command, "@PA_DD_DAY_OF_MONTH", record.DayOfMonth);
            record.Variable = this.MapParameterOut(command, "@PA_DD_VARIABLE", record.Variable);
            record.MaxValue = this.MapParameterOut(command, "@PA_DD_MAX_VALUE", record.MaxValue);
            record.CurrencyType = this.MapParameterOut(command, "@PA_DD_CURRENCY_TYPE", record.CurrencyType);
            record.BankName = this.MapParameterOut(command, "@PA_DD_BANK_NAME", record.BankName);
            record.BankAdd1 = this.MapParameterOut(command, "@PA_DD_BANK_ADD_1", record.BankAdd1);
            record.BankAdd2 = this.MapParameterOut(command, "@PA_DD_BANK_ADD_2", record.BankAdd2);
            record.BankAdd3 = this.MapParameterOut(command, "@PA_DD_BANK_ADD_3", record.BankAdd3);
            record.BankAdd4 = this.MapParameterOut(command, "@PA_DD_BANK_ADD_4", record.BankAdd4);
            record.BankPostcode = this.MapParameterOut(command, "@PA_DD_BANK_POSTCODE", record.BankPostcode);
            record.CoreRef = this.MapParameterOut(command, "@PA_DD_CORE_REF", record.CoreRef);
            record.BankAccName = this.MapParameterOut(command, "@PA_DD_BANK_ACC_NAME", record.BankAccName);
            record.BankAccCode = this.MapParameterOut(command, "@PA_DD_BANK_ACC_CODE", record.BankAccCode);
            record.SortCode = this.MapParameterOut(command, "@PA_DD_SORT_CODE", record.SortCode);
            record.CcardType = this.MapParameterOut(command, "@PA_DD_CCARD_TYPE", record.CcardType);
            record.NameOnCard = this.MapParameterOut(command, "@PA_DD_NAME_ON_CARD", record.NameOnCard);
            record.CcardNumber = this.MapParameterOut(command, "@PA_DD_CCARD_NUMBER", record.CcardNumber);
            record.CcardIssue = this.MapParameterOut(command, "@PA_DD_CCARD_ISSUE", record.CcardIssue);
            record.CcardSecId = this.MapParameterOut(command, "@PA_DD_CCARD_SEC_ID", record.CcardSecId);
            record.CcardStartMth = this.MapParameterOut(command, "@PA_DD_CCARD_START_MTH", record.CcardStartMth);
            record.CcardStartYr = this.MapParameterOut(command, "@PA_DD_CCARD_START_YR", record.CcardStartYr);
            record.CcardExpyMth = this.MapParameterOut(command, "@PA_DD_CCARD_EXPY_MTH", record.CcardExpyMth);
            record.CcardExpyYr = this.MapParameterOut(command, "@PA_DD_CCARD_EXPY_YR", record.CcardExpyYr);
            record.Notes = this.MapParameterOut(command, "@PA_DD_NOTES", record.Notes);
            record.BankOrgId = this.MapParameterOut(command, "@PA_DD_BANK_ORG_ID", record.BankOrgId);
            record.BankAddId = this.MapParameterOut(command, "@PA_DD_BANK_ADD_ID", record.BankAddId);
            record.RecordStatus = this.MapParameterOut(command, "@PA_DD_RECORD_STATUS", record.RecordStatus);
            record.BatId = this.MapParameterOut(command, "@PA_DD_BAT_ID", record.BatId);
            record.Total = this.MapParameterOut(command, "@PA_DD_TOTAL", record.Total);
            record.StatusNotes = this.MapParameterOut(command, "@PA_DD_STATUS_NOTES", record.StatusNotes);
            record.StatusLastDate = this.MapParameterOut(command, "@PA_DD_STATUS_LAST_DATE", record.StatusLastDate);
            record.StatusPrevious = this.MapParameterOut(command, "@PA_DD_STATUS_PREVIOUS", record.StatusPrevious);
            record.NoOfInstallments = this.MapParameterOut(command, "@PA_DD_NO_OF_INSTALLMENTS", record.NoOfInstallments);
            record.DueDate = this.MapParameterOut(command, "@PA_DD_DUE_DATE", record.DueDate);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="DirectdebitRecord" /> instances from the data store.
        /// </summary>
        /// <param name="recId">
        ///     The value which identifies the <see cref='DirectDebitModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="DirectdebitRecord" /> instances that match the specified <paramref name='recId' />.
        /// </returns>
        public IEnumerable<DirectdebitRecord> FetchAllByRecId(String recId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "RecId");
            this.MapParameterIn(command, "@PA_DD_REC_ID", recId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IDirectDebitRepository.TableName
        {
            get { return this.TableName; }
        }

        void IDirectDebitRepository.Create(Consensus.Finance.DirectdebitRecord record)
        {
            this.Create(record);
        }

        void IDirectDebitRepository.Modify(Consensus.Finance.DirectdebitRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.DirectdebitRecord" /> instances from the data store.
        /// </summary>
        /// <param name="recId">
        ///     The value which identifies the <see cref="!:DirectDebitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.DirectdebitRecord" /> instances that match the specified <paramref name="recId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.DirectdebitRecord> IDirectDebitRepository.FetchAllByRecId(System.String recId)
        {
            return this.FetchAllByRecId(recId);
        }

        #endregion
    }
}
