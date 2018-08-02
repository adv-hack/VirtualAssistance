using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PaymentRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPaymentRepository : SqlServerRepository<PaymentRecord, String>, IPaymentRepository
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
            get { return "Payment"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PaymentRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PAY_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Payment"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PaymentRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PaymentRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PaymentRecord record)
        {
            record.Id = dataRecord["PAY_ID"].ConvertTo<String>();
            record.Lock = dataRecord["PAY_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["PAY_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PAY_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PAY_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PAY_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PAY_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PAY_RCV_FROM"].ConvertTo<String>();
            record.CcardType = dataRecord["PAY_CCARD_TYPE"].ConvertTo<String>();
            record.Name = dataRecord["PAY_NAME"].ConvertTo<String>();
            record.Number = dataRecord["PAY_NUMBER"].ConvertTo<String>();
            record.ExpyDte = dataRecord["PAY_EXPY_DTE"].ConvertTo<DateTime?>();
            record.AppvlRef = dataRecord["PAY_APPVL_REF"].ConvertTo<String>();
            record.IssueNo = dataRecord["PAY_ISSUE_NO"].ConvertTo<String>();
            record.CurrType = dataRecord["PAY_CURR_TYPE"].ConvertTo<String>();
            record.Recvd = dataRecord["PAY_RECVD"].ConvertTo<Decimal>();
            record.RecvdBc = dataRecord["PAY_RECVD_BC"].ConvertTo<Decimal>();
            record.Date = dataRecord["PAY_DATE"].ConvertTo<DateTime?>();
            record.Type = dataRecord["PAY_TYPE"].ConvertTo<String>();
            record.CustomerAcc = dataRecord["PAY_CUSTOMER_ACC"].ConvertTo<String>();
            record.UnusedVal = dataRecord["PAY_UNUSED_VAL"].ConvertTo<Decimal>();
            record.UnusedValBc = dataRecord["PAY_UNUSED_VAL_BC"].ConvertTo<Decimal>();
            record.GlCode = dataRecord["PAY_GL_CODE"].ConvertTo<String>();
            record.Period = dataRecord["PAY_PERIOD"].ConvertTo<String>();
            record.OrderId = dataRecord["PAY_ORDER_ID"].ConvertTo<String>();
            record.Hidden = dataRecord["PAY_HIDDEN"].ConvertTo<Byte?>();
            record.ChequeNo = dataRecord["PAY_CHEQUE_NO"].ConvertTo<String>();
            record.SortCode = dataRecord["PAY_SORT_CODE"].ConvertTo<String>();
            record.Status = dataRecord["PAY_STATUS"].ConvertTo<String>();
            record.Notes = dataRecord["PAY_NOTES"].ConvertTo<String>();
            record.ValidDate = dataRecord["PAY_VALID_DATE"].ConvertTo<DateTime?>();
            record.CurrRateBc = dataRecord["PAY_CURR_RATE_BC"].ConvertTo<Decimal>();
            record.CurrRateBc2 = dataRecord["PAY_CURR_RATE_BC2"].ConvertTo<Decimal>();
            record.SelcoSpId = dataRecord["PAY_SELCO_SP_ID"].ConvertTo<String>();
            record.MepId = dataRecord["PAY_MEP_ID"].ConvertTo<String>();
            record.OrgId = dataRecord["PAY_ORG_ID"].ConvertTo<String>();
            record.PnId = dataRecord["PAY_PN_ID"].ConvertTo<String>();
            record.Ref = dataRecord["PAY_REF"].ConvertTo<String>();
            record.BookId = dataRecord["PAY_BOOK_ID"].ConvertTo<String>();
            record.CardSecId = dataRecord["PAY_CARD_SEC_ID"].ConvertTo<String>();
            record.StartMonth = dataRecord["PAY_START_MONTH"].ConvertTo<String>();
            record.StartYear = dataRecord["PAY_START_YEAR"].ConvertTo<String>();
            record.ExpyMonth = dataRecord["PAY_EXPY_MONTH"].ConvertTo<String>();
            record.ExpyYear = dataRecord["PAY_EXPY_YEAR"].ConvertTo<String>();
            record.RefundPayId = dataRecord["PAY_REFUND_PAY_ID"].ConvertTo<String>();
            record.RefundPayRef = dataRecord["PAY_REFUND_PAY_REF"].ConvertTo<String>();
            record.TxnType = dataRecord["PAY_TXN_TYPE"].ConvertTo<Int32?>();
            record.BankingRef = dataRecord["PAY_BANKING_REF"].ConvertTo<String>();
            record.BatId = dataRecord["PAY_BAT_ID"].ConvertTo<String>();
            record.BankChg = dataRecord["PAY_BANK_CHG"].ConvertTo<Decimal>();
            record.BankChgBc = dataRecord["PAY_BANK_CHG_BC"].ConvertTo<Decimal>();
            record.BankChgBc2 = dataRecord["PAY_BANK_CHG_BC2"].ConvertTo<Decimal>();
            record.MepCrtBatId = dataRecord["PAY_MEP_CRT_BAT_ID"].ConvertTo<String>();
            record.RecvdBc2 = dataRecord["PAY_RECVD_BC2"].ConvertTo<Decimal>();
            record.UnusedValBc2 = dataRecord["PAY_UNUSED_VAL_BC2"].ConvertTo<Decimal>();
            record.CostCode = dataRecord["PAY_COST_CODE"].ConvertTo<String>();
            record.Purpose = dataRecord["PAY_PURPOSE"].ConvertTo<Byte?>();
            record.SchnId = dataRecord["PAY_SCHN_ID"].ConvertTo<String>();
            record.AddId = dataRecord["PAY_ADD_ID"].ConvertTo<String>();
            record.ReverseRes = dataRecord["PAY_REVERSE_RES"].ConvertTo<String>();
            record.BankSortCode = dataRecord["PAY_BANK_SORT_CODE"].ConvertTo<String>();
            record.BankAccount = dataRecord["PAY_BANK_ACCOUNT"].ConvertTo<String>();
            record.AccId = dataRecord["PAY_ACC_ID"].ConvertTo<String>();
            record.AccTranRet = dataRecord["PAY_ACC_TRAN_RET"].ConvertTo<Double?>();
            record.ExpBatId = dataRecord["PAY_EXP_BAT_ID"].ConvertTo<String>();
            record.Moto = dataRecord["PAY_MOTO"].ConvertTo<Byte>();
            record.LtId = dataRecord["PAY_LT_ID"].ConvertTo<String>();
            record.MstcId = dataRecord["PAY_MSTC_ID"].ConvertTo<String>();
            record.OriginalCustomerAcc = dataRecord["PAY_ORIGINAL_CUSTOMER_ACC"].ConvertTo<String>();
            record.Token = dataRecord["PAY_TOKEN"].ConvertTo<String>();
            record.VoucherType = dataRecord["PAY_VOUCHER_TYPE"].ConvertTo<String>();
            record.GatewayAccId = dataRecord["PAY_GATEWAY_ACC_ID"].ConvertTo<String>();
            record.CardholderProleId = dataRecord["PAY_CARDHOLDER_PROLE_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PaymentRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PaymentRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PAY_ID", record.Id);
            this.MapParameterIn(command, "@PA_PAY_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PAY_CCARD_TYPE", record.CcardType);
            this.MapParameterIn(command, "@PA_PAY_NAME", record.Name);
            this.MapParameterIn(command, "@PA_PAY_NUMBER", record.Number);
            this.MapParameterIn(command, "@PA_PAY_EXPY_DTE", record.ExpyDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ExpyDte);
            this.MapParameterIn(command, "@PA_PAY_APPVL_REF", record.AppvlRef);
            this.MapParameterIn(command, "@PA_PAY_ISSUE_NO", record.IssueNo);
            this.MapParameterIn(command, "@PA_PAY_CURR_TYPE", record.CurrType);
            this.MapParameterIn(command, "@PA_PAY_RECVD", record.Recvd == Decimal.MinValue ? 0M : record.Recvd);
            this.MapParameterIn(command, "@PA_PAY_RECVD_BC", record.RecvdBc == Decimal.MinValue ? 0M : record.RecvdBc);
            this.MapParameterIn(command, "@PA_PAY_DATE", record.Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date);
            this.MapParameterIn(command, "@PA_PAY_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_PAY_CUSTOMER_ACC", record.CustomerAcc);
            this.MapParameterIn(command, "@PA_PAY_UNUSED_VAL", record.UnusedVal == Decimal.MinValue ? 0M : record.UnusedVal);
            this.MapParameterIn(command, "@PA_PAY_UNUSED_VAL_BC", record.UnusedValBc == Decimal.MinValue ? 0M : record.UnusedValBc);
            this.MapParameterIn(command, "@PA_PAY_GL_CODE", record.GlCode);
            this.MapParameterIn(command, "@PA_PAY_PERIOD", record.Period);
            this.MapParameterIn(command, "@PA_PAY_ORDER_ID", record.OrderId);
            this.MapParameterIn(command, "@PA_PAY_HIDDEN", record.Hidden);
            this.MapParameterIn(command, "@PA_PAY_CHEQUE_NO", record.ChequeNo);
            this.MapParameterIn(command, "@PA_PAY_SORT_CODE", record.SortCode);
            this.MapParameterIn(command, "@PA_PAY_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_PAY_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_PAY_VALID_DATE", record.ValidDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ValidDate);
            this.MapParameterIn(command, "@PA_PAY_CURR_RATE_BC", record.CurrRateBc == Decimal.MinValue ? 0M : record.CurrRateBc);
            this.MapParameterIn(command, "@PA_PAY_CURR_RATE_BC2", record.CurrRateBc2 == Decimal.MinValue ? 0M : record.CurrRateBc2);
            this.MapParameterIn(command, "@PA_PAY_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_PAY_MEP_ID", record.MepId);
            this.MapParameterIn(command, "@PA_PAY_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_PAY_PN_ID", record.PnId);
            this.MapParameterIn(command, "@PA_PAY_REF", record.Ref);
            this.MapParameterIn(command, "@PA_PAY_BOOK_ID", record.BookId);
            this.MapParameterIn(command, "@PA_PAY_CARD_SEC_ID", record.CardSecId);
            this.MapParameterIn(command, "@PA_PAY_START_MONTH", record.StartMonth);
            this.MapParameterIn(command, "@PA_PAY_START_YEAR", record.StartYear);
            this.MapParameterIn(command, "@PA_PAY_EXPY_MONTH", record.ExpyMonth);
            this.MapParameterIn(command, "@PA_PAY_EXPY_YEAR", record.ExpyYear);
            this.MapParameterIn(command, "@PA_PAY_REFUND_PAY_ID", record.RefundPayId);
            this.MapParameterIn(command, "@PA_PAY_REFUND_PAY_REF", record.RefundPayRef);
            this.MapParameterIn(command, "@PA_PAY_TXN_TYPE", record.TxnType == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TxnType);
            this.MapParameterIn(command, "@PA_PAY_BANKING_REF", record.BankingRef);
            this.MapParameterIn(command, "@PA_PAY_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_PAY_BANK_CHG", record.BankChg == Decimal.MinValue ? 0M : record.BankChg);
            this.MapParameterIn(command, "@PA_PAY_BANK_CHG_BC", record.BankChgBc == Decimal.MinValue ? 0M : record.BankChgBc);
            this.MapParameterIn(command, "@PA_PAY_BANK_CHG_BC2", record.BankChgBc2 == Decimal.MinValue ? 0M : record.BankChgBc2);
            this.MapParameterIn(command, "@PA_PAY_MEP_CRT_BAT_ID", record.MepCrtBatId);
            this.MapParameterIn(command, "@PA_PAY_RECVD_BC2", record.RecvdBc2 == Decimal.MinValue ? 0M : record.RecvdBc2);
            this.MapParameterIn(command, "@PA_PAY_UNUSED_VAL_BC2", record.UnusedValBc2 == Decimal.MinValue ? 0M : record.UnusedValBc2);
            this.MapParameterIn(command, "@PA_PAY_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_PAY_PURPOSE", record.Purpose);
            this.MapParameterIn(command, "@PA_PAY_SCHN_ID", record.SchnId);
            this.MapParameterIn(command, "@PA_PAY_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_PAY_REVERSE_RES", record.ReverseRes);
            this.MapParameterIn(command, "@PA_PAY_BANK_SORT_CODE", record.BankSortCode);
            this.MapParameterIn(command, "@PA_PAY_BANK_ACCOUNT", record.BankAccount);
            this.MapParameterIn(command, "@PA_PAY_ACC_ID", record.AccId);
            this.MapParameterIn(command, "@PA_PAY_ACC_TRAN_RET", record.AccTranRet == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.AccTranRet);
            this.MapParameterIn(command, "@PA_PAY_EXP_BAT_ID", record.ExpBatId);
            this.MapParameterIn(command, "@PA_PAY_MOTO", record.Moto);
            this.MapParameterIn(command, "@PA_PAY_LT_ID", record.LtId);
            this.MapParameterIn(command, "@PA_PAY_MSTC_ID", record.MstcId);
            this.MapParameterIn(command, "@PA_PAY_ORIGINAL_CUSTOMER_ACC", record.OriginalCustomerAcc);
            this.MapParameterIn(command, "@PA_PAY_TOKEN", record.Token);
            this.MapParameterIn(command, "@PA_PAY_VOUCHER_TYPE", record.VoucherType);
            this.MapParameterIn(command, "@PA_PAY_GATEWAY_ACC_ID", record.GatewayAccId);
            this.MapParameterIn(command, "@PA_PAY_CARDHOLDER_PROLE_ID", record.CardholderProleId);
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
        ///     The <see cref="PaymentRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PaymentRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PAY_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_PAY_LOCK", record.Lock);
            record.CcardType = this.MapParameterOut(command, "@PA_PAY_CCARD_TYPE", record.CcardType);
            record.Name = this.MapParameterOut(command, "@PA_PAY_NAME", record.Name);
            record.Number = this.MapParameterOut(command, "@PA_PAY_NUMBER", record.Number);
            record.ExpyDte = this.MapParameterOut(command, "@PA_PAY_EXPY_DTE", record.ExpyDte);
            record.AppvlRef = this.MapParameterOut(command, "@PA_PAY_APPVL_REF", record.AppvlRef);
            record.IssueNo = this.MapParameterOut(command, "@PA_PAY_ISSUE_NO", record.IssueNo);
            record.CurrType = this.MapParameterOut(command, "@PA_PAY_CURR_TYPE", record.CurrType);
            record.Recvd = this.MapParameterOut(command, "@PA_PAY_RECVD", record.Recvd);
            record.RecvdBc = this.MapParameterOut(command, "@PA_PAY_RECVD_BC", record.RecvdBc);
            record.Date = this.MapParameterOut(command, "@PA_PAY_DATE", record.Date);
            record.Type = this.MapParameterOut(command, "@PA_PAY_TYPE", record.Type);
            record.CustomerAcc = this.MapParameterOut(command, "@PA_PAY_CUSTOMER_ACC", record.CustomerAcc);
            record.UnusedVal = this.MapParameterOut(command, "@PA_PAY_UNUSED_VAL", record.UnusedVal);
            record.UnusedValBc = this.MapParameterOut(command, "@PA_PAY_UNUSED_VAL_BC", record.UnusedValBc);
            record.GlCode = this.MapParameterOut(command, "@PA_PAY_GL_CODE", record.GlCode);
            record.Period = this.MapParameterOut(command, "@PA_PAY_PERIOD", record.Period);
            record.OrderId = this.MapParameterOut(command, "@PA_PAY_ORDER_ID", record.OrderId);
            record.Hidden = this.MapParameterOut(command, "@PA_PAY_HIDDEN", record.Hidden);
            record.ChequeNo = this.MapParameterOut(command, "@PA_PAY_CHEQUE_NO", record.ChequeNo);
            record.SortCode = this.MapParameterOut(command, "@PA_PAY_SORT_CODE", record.SortCode);
            record.Status = this.MapParameterOut(command, "@PA_PAY_STATUS", record.Status);
            record.Notes = this.MapParameterOut(command, "@PA_PAY_NOTES", record.Notes);
            record.ValidDate = this.MapParameterOut(command, "@PA_PAY_VALID_DATE", record.ValidDate);
            record.CurrRateBc = this.MapParameterOut(command, "@PA_PAY_CURR_RATE_BC", record.CurrRateBc);
            record.CurrRateBc2 = this.MapParameterOut(command, "@PA_PAY_CURR_RATE_BC2", record.CurrRateBc2);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_PAY_SELCO_SP_ID", record.SelcoSpId);
            record.MepId = this.MapParameterOut(command, "@PA_PAY_MEP_ID", record.MepId);
            record.OrgId = this.MapParameterOut(command, "@PA_PAY_ORG_ID", record.OrgId);
            record.PnId = this.MapParameterOut(command, "@PA_PAY_PN_ID", record.PnId);
            record.Ref = this.MapParameterOut(command, "@PA_PAY_REF", record.Ref);
            record.BookId = this.MapParameterOut(command, "@PA_PAY_BOOK_ID", record.BookId);
            record.CardSecId = this.MapParameterOut(command, "@PA_PAY_CARD_SEC_ID", record.CardSecId);
            record.StartMonth = this.MapParameterOut(command, "@PA_PAY_START_MONTH", record.StartMonth);
            record.StartYear = this.MapParameterOut(command, "@PA_PAY_START_YEAR", record.StartYear);
            record.ExpyMonth = this.MapParameterOut(command, "@PA_PAY_EXPY_MONTH", record.ExpyMonth);
            record.ExpyYear = this.MapParameterOut(command, "@PA_PAY_EXPY_YEAR", record.ExpyYear);
            record.RefundPayId = this.MapParameterOut(command, "@PA_PAY_REFUND_PAY_ID", record.RefundPayId);
            record.RefundPayRef = this.MapParameterOut(command, "@PA_PAY_REFUND_PAY_REF", record.RefundPayRef);
            record.TxnType = this.MapParameterOut(command, "@PA_PAY_TXN_TYPE", record.TxnType);
            record.BankingRef = this.MapParameterOut(command, "@PA_PAY_BANKING_REF", record.BankingRef);
            record.BatId = this.MapParameterOut(command, "@PA_PAY_BAT_ID", record.BatId);
            record.BankChg = this.MapParameterOut(command, "@PA_PAY_BANK_CHG", record.BankChg);
            record.BankChgBc = this.MapParameterOut(command, "@PA_PAY_BANK_CHG_BC", record.BankChgBc);
            record.BankChgBc2 = this.MapParameterOut(command, "@PA_PAY_BANK_CHG_BC2", record.BankChgBc2);
            record.MepCrtBatId = this.MapParameterOut(command, "@PA_PAY_MEP_CRT_BAT_ID", record.MepCrtBatId);
            record.RecvdBc2 = this.MapParameterOut(command, "@PA_PAY_RECVD_BC2", record.RecvdBc2);
            record.UnusedValBc2 = this.MapParameterOut(command, "@PA_PAY_UNUSED_VAL_BC2", record.UnusedValBc2);
            record.CostCode = this.MapParameterOut(command, "@PA_PAY_COST_CODE", record.CostCode);
            record.Purpose = this.MapParameterOut(command, "@PA_PAY_PURPOSE", record.Purpose);
            record.SchnId = this.MapParameterOut(command, "@PA_PAY_SCHN_ID", record.SchnId);
            record.AddId = this.MapParameterOut(command, "@PA_PAY_ADD_ID", record.AddId);
            record.ReverseRes = this.MapParameterOut(command, "@PA_PAY_REVERSE_RES", record.ReverseRes);
            record.BankSortCode = this.MapParameterOut(command, "@PA_PAY_BANK_SORT_CODE", record.BankSortCode);
            record.BankAccount = this.MapParameterOut(command, "@PA_PAY_BANK_ACCOUNT", record.BankAccount);
            record.AccId = this.MapParameterOut(command, "@PA_PAY_ACC_ID", record.AccId);
            record.AccTranRet = this.MapParameterOut(command, "@PA_PAY_ACC_TRAN_RET", record.AccTranRet);
            record.ExpBatId = this.MapParameterOut(command, "@PA_PAY_EXP_BAT_ID", record.ExpBatId);
            record.Moto = this.MapParameterOut(command, "@PA_PAY_MOTO", record.Moto);
            record.LtId = this.MapParameterOut(command, "@PA_PAY_LT_ID", record.LtId);
            record.MstcId = this.MapParameterOut(command, "@PA_PAY_MSTC_ID", record.MstcId);
            record.OriginalCustomerAcc = this.MapParameterOut(command, "@PA_PAY_ORIGINAL_CUSTOMER_ACC", record.OriginalCustomerAcc);
            record.Token = this.MapParameterOut(command, "@PA_PAY_TOKEN", record.Token);
            record.VoucherType = this.MapParameterOut(command, "@PA_PAY_VOUCHER_TYPE", record.VoucherType);
            record.GatewayAccId = this.MapParameterOut(command, "@PA_PAY_GATEWAY_ACC_ID", record.GatewayAccId);
            record.CardholderProleId = this.MapParameterOut(command, "@PA_PAY_CARDHOLDER_PROLE_ID", record.CardholderProleId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='PaymentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PaymentRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<PaymentRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_PAY_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref='PaymentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PaymentRecord" /> instances that match the specified <paramref name='mepId' />.
        /// </returns>
        public IEnumerable<PaymentRecord> FetchAllByMepId(String mepId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MepId");
            this.MapParameterIn(command, "@PA_PAY_MEP_ID", mepId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='PaymentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PaymentRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<PaymentRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_PAY_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref='PaymentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PaymentRecord" /> instances that match the specified <paramref name='pnId' />.
        /// </returns>
        public IEnumerable<PaymentRecord> FetchAllByPnId(String pnId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PnId");
            this.MapParameterIn(command, "@PA_PAY_PN_ID", pnId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref='PaymentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PaymentRecord" /> instances that match the specified <paramref name='bookId' />.
        /// </returns>
        public IEnumerable<PaymentRecord> FetchAllByBookId(String bookId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BookId");
            this.MapParameterIn(command, "@PA_PAY_BOOK_ID", bookId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="refundPayId">
        ///     The value which identifies the <see cref='PaymentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PaymentRecord" /> instances that match the specified <paramref name='refundPayId' />.
        /// </returns>
        public IEnumerable<PaymentRecord> FetchAllByRefundPayId(String refundPayId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "RefundPayId");
            this.MapParameterIn(command, "@PA_PAY_REFUND_PAY_ID", refundPayId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref='PaymentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PaymentRecord" /> instances that match the specified <paramref name='addId' />.
        /// </returns>
        public IEnumerable<PaymentRecord> FetchAllByAddId(String addId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AddId");
            this.MapParameterIn(command, "@PA_PAY_ADD_ID", addId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref='PaymentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PaymentRecord" /> instances that match the specified <paramref name='accId' />.
        /// </returns>
        public IEnumerable<PaymentRecord> FetchAllByAccId(String accId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AccId");
            this.MapParameterIn(command, "@PA_PAY_ACC_ID", accId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ltId">
        ///     The value which identifies the <see cref='PaymentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PaymentRecord" /> instances that match the specified <paramref name='ltId' />.
        /// </returns>
        public IEnumerable<PaymentRecord> FetchAllByLtId(String ltId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LtId");
            this.MapParameterIn(command, "@PA_PAY_LT_ID", ltId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cardholderProleId">
        ///     The value which identifies the <see cref='PaymentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PaymentRecord" /> instances that match the specified <paramref name='cardholderProleId' />.
        /// </returns>
        public IEnumerable<PaymentRecord> FetchAllByCardholderProleId(String cardholderProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CardholderProleId");
            this.MapParameterIn(command, "@PA_PAY_CARDHOLDER_PROLE_ID", cardholderProleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPaymentRepository.TableName
        {
            get { return this.TableName; }
        }

        void IPaymentRepository.Create(Consensus.Finance.PaymentRecord record)
        {
            this.Create(record);
        }

        void IPaymentRepository.CreateAndAllocate(Consensus.Finance.PaymentRecord record, System.String invoiceId)
        {
            this.CreateAndAllocate(record, invoiceId);
        }

        void IPaymentRepository.Modify(Consensus.Finance.PaymentRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> IPaymentRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="mepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> IPaymentRepository.FetchAllByMepId(System.String mepId)
        {
            return this.FetchAllByMepId(mepId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> IPaymentRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="pnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> IPaymentRepository.FetchAllByPnId(System.String pnId)
        {
            return this.FetchAllByPnId(pnId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="bookId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> IPaymentRepository.FetchAllByBookId(System.String bookId)
        {
            return this.FetchAllByBookId(bookId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="refundPayId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="refundPayId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> IPaymentRepository.FetchAllByRefundPayId(System.String refundPayId)
        {
            return this.FetchAllByRefundPayId(refundPayId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> IPaymentRepository.FetchAllByAddId(System.String addId)
        {
            return this.FetchAllByAddId(addId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="accId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> IPaymentRepository.FetchAllByAccId(System.String accId)
        {
            return this.FetchAllByAccId(accId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ltId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="ltId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> IPaymentRepository.FetchAllByLtId(System.String ltId)
        {
            return this.FetchAllByLtId(ltId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cardholderProleId">
        ///     The value which identifies the <see cref="!:PaymentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PaymentRecord" /> instances that match the specified <paramref name="cardholderProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PaymentRecord> IPaymentRepository.FetchAllByCardholderProleId(System.String cardholderProleId)
        {
            return this.FetchAllByCardholderProleId(cardholderProleId);
        }

        #endregion
    }
}
