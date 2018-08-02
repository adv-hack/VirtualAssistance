using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AccountRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerAccountRepository : SqlServerRepository<AccountRecord, String>, IAccountRepository
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
            get { return "Account"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="AccountRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ACC_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Account"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="AccountRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AccountRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, AccountRecord record)
        {
            record.Id = dataRecord["ACC_ID"].ConvertTo<String>();
            record.Lock = dataRecord["ACC_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["ACC_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ACC_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ACC_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ACC_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ACC_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["ACC_RCV_FROM"].ConvertTo<String>();
            record.System = dataRecord["ACC_SYSTEM"].ConvertTo<String>();
            record.SystemRef = dataRecord["ACC_SYSTEM_REF"].ConvertTo<String>();
            record.OrgId = dataRecord["ACC_ORG_ID"].ConvertTo<String>();
            record.Principal = dataRecord["ACC_PRINCIPAL"].ConvertTo<Byte?>();
            record.ProleId = dataRecord["ACC_PROLE_ID"].ConvertTo<String>();
            record.ContactId = dataRecord["ACC_CONTACT_ID"].ConvertTo<String>();
            record.AddId = dataRecord["ACC_ADD_ID"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["ACC_SELCO_SP_ID"].ConvertTo<String>();
            record.NoAddChange = dataRecord["ACC_NO_ADD_CHANGE"].ConvertTo<Byte?>();
            record.PaymentDays = dataRecord["ACC_PAYMENT_DAYS"].ConvertTo<Int32?>();
            record.Status = dataRecord["ACC_STATUS"].ConvertTo<String>();
            record.PaymentType = dataRecord["ACC_PAYMENT_TYPE"].ConvertTo<Byte?>();
            record.PayTerms1 = dataRecord["ACC_PAY_TERMS_1"].ConvertTo<String>();
            record.PayTerms2 = dataRecord["ACC_PAY_TERMS_2"].ConvertTo<String>();
            record.PayTerms3 = dataRecord["ACC_PAY_TERMS_3"].ConvertTo<String>();
            record.PayTerms4 = dataRecord["ACC_PAY_TERMS_4"].ConvertTo<String>();
            record.Credit = dataRecord["ACC_CREDIT"].ConvertTo<Decimal>();
            record.SpecialTerms = dataRecord["ACC_SPECIAL_TERMS"].ConvertTo<String>();
            record.Vatcd = dataRecord["ACC_VATCD"].ConvertTo<String>();
            record.InvForAttnOf = dataRecord["ACC_INV_FOR_ATTN_OF"].ConvertTo<String>();
            record.InvoiceRule = dataRecord["ACC_INVOICE_RULE"].ConvertTo<Byte>();
            record.InvoiceRuleOffset = dataRecord["ACC_INVOICE_RULE_OFFSET"].ConvertTo<Int16>();
            record.InvoiceConsolidate = dataRecord["ACC_INVOICE_CONSOLIDATE"].ConvertTo<Byte>();
            record.InvoiceWhenStatus = dataRecord["ACC_INVOICE_WHEN_STATUS"].ConvertTo<String>();
            record.InvoiceFormat = dataRecord["ACC_INVOICE_FORMAT"].ConvertTo<Byte>();
            record.InvoiceMustUseRule = dataRecord["ACC_INVOICE_MUST_USE_RULE"].ConvertTo<Byte>();
            record.InvoiceFormat0Text = dataRecord["ACC_INVOICE_FORMAT_0_TEXT"].ConvertTo<String>();
            record.InvoiceFormat1Text = dataRecord["ACC_INVOICE_FORMAT_1_TEXT"].ConvertTo<String>();
            record.InvoiceOffsetType = dataRecord["ACC_INVOICE_OFFSET_TYPE"].ConvertTo<String>();
            record.InvAddTo = dataRecord["ACC_INV_ADD_TO"].ConvertTo<Byte?>();
            record.NatAccount = dataRecord["ACC_NAT_ACCOUNT"].ConvertTo<Byte?>();
            record.BankName = dataRecord["ACC_BANK_NAME"].ConvertTo<String>();
            record.BankSortCode = dataRecord["ACC_BANK_SORT_CODE"].ConvertTo<String>();
            record.BankNo = dataRecord["ACC_BANK_NO"].ConvertTo<String>();
            record.BankAddId = dataRecord["ACC_BANK_ADD_ID"].ConvertTo<String>();
            record.PaymentMethd = dataRecord["ACC_PAYMENT_METHD"].ConvertTo<String>();
            record.DocType = dataRecord["ACC_DOC_TYPE"].ConvertTo<String>();
            record.CoutOffDays = dataRecord["ACC_COUT_OFF_DAYS"].ConvertTo<Int32?>();
            record.Type = dataRecord["ACC_TYPE"].ConvertTo<String>();
            record.Title = dataRecord["ACC_TITLE"].ConvertTo<String>();
            record.StatusDate = dataRecord["ACC_STATUS_DATE"].ConvertTo<DateTime?>();
            record.BatId = dataRecord["ACC_BAT_ID"].ConvertTo<String>();
            record.ReqCredit = dataRecord["ACC_REQ_CREDIT"].ConvertTo<Decimal?>();
            record.DocsMethod = dataRecord["ACC_DOCS_METHOD"].ConvertTo<String>();
            record.DoNotChase = dataRecord["ACC_DO_NOT_CHASE"].ConvertTo<Byte>();
            record.InvPackId = dataRecord["ACC_INV_PACK_ID"].ConvertTo<String>();
            record.ReqPaymentType = dataRecord["ACC_REQ_PAYMENT_TYPE"].ConvertTo<Byte>();
            record.ReqPaymentDays = dataRecord["ACC_REQ_PAYMENT_DAYS"].ConvertTo<Int32>();
            record.DefaultInvStatus = dataRecord["ACC_DEFAULT_INV_STATUS"].ConvertTo<Byte?>();
            record.CurrencyType = dataRecord["ACC_CURRENCY_TYPE"].ConvertTo<String>();
            record.VatRegNum = dataRecord["ACC_VAT_REG_NUM"].ConvertTo<String>();
            record.MemPaymentDays = dataRecord["ACC_MEM_PAYMENT_DAYS"].ConvertTo<Int32?>();
            record.PoReq = dataRecord["ACC_PO_REQ"].ConvertTo<Byte?>();
            record.RunDate = dataRecord["ACC_RUN_DATE"].ConvertTo<DateTime?>();
            record.PshId = dataRecord["ACC_PSH_ID"].ConvertTo<Int32?>();
            record.Default = dataRecord["ACC_DEFAULT"].ConvertTo<Byte?>();
            record.RuleType = dataRecord["ACC_RULE_TYPE"].ConvertTo<Byte?>();
            record.NatAccountDate = dataRecord["ACC_NAT_ACCOUNT_DATE"].ConvertTo<DateTime?>();
            record.CourseLen = dataRecord["ACC_COURSE_LEN"].ConvertTo<Double?>();
            record.RenewDays = dataRecord["ACC_RENEW_DAYS"].ConvertTo<Int32?>();
            record.FixedRenewal = dataRecord["ACC_FIXED_RENEWAL"].ConvertTo<Byte?>();
            record.RenewalMonth = dataRecord["ACC_RENEWAL_MONTH"].ConvertTo<String>();
            record.RenewalDay = dataRecord["ACC_RENEWAL_DAY"].ConvertTo<String>();
            record.Renew = dataRecord["ACC_RENEW"].ConvertTo<Byte>();
            record.ExclDay = dataRecord["ACC_EXCL_DAY"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AccountRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, AccountRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ACC_ID", record.Id);
            this.MapParameterIn(command, "@PA_ACC_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_ACC_SYSTEM", record.System);
            this.MapParameterIn(command, "@PA_ACC_SYSTEM_REF", record.SystemRef);
            this.MapParameterIn(command, "@PA_ACC_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_ACC_PRINCIPAL", record.Principal);
            this.MapParameterIn(command, "@PA_ACC_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_ACC_CONTACT_ID", record.ContactId);
            this.MapParameterIn(command, "@PA_ACC_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_ACC_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_ACC_NO_ADD_CHANGE", record.NoAddChange);
            this.MapParameterIn(command, "@PA_ACC_PAYMENT_DAYS", record.PaymentDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PaymentDays);
            this.MapParameterIn(command, "@PA_ACC_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_ACC_PAYMENT_TYPE", record.PaymentType);
            this.MapParameterIn(command, "@PA_ACC_PAY_TERMS_1", record.PayTerms1);
            this.MapParameterIn(command, "@PA_ACC_PAY_TERMS_2", record.PayTerms2);
            this.MapParameterIn(command, "@PA_ACC_PAY_TERMS_3", record.PayTerms3);
            this.MapParameterIn(command, "@PA_ACC_PAY_TERMS_4", record.PayTerms4);
            this.MapParameterIn(command, "@PA_ACC_CREDIT", record.Credit == Decimal.MinValue ? 0M : record.Credit);
            this.MapParameterIn(command, "@PA_ACC_SPECIAL_TERMS", record.SpecialTerms);
            this.MapParameterIn(command, "@PA_ACC_VATCD", record.Vatcd);
            this.MapParameterIn(command, "@PA_ACC_INV_FOR_ATTN_OF", record.InvForAttnOf);
            this.MapParameterIn(command, "@PA_ACC_INVOICE_RULE", record.InvoiceRule);
            this.MapParameterIn(command, "@PA_ACC_INVOICE_RULE_OFFSET", record.InvoiceRuleOffset == Int16.MinValue ? 0 : record.InvoiceRuleOffset);
            this.MapParameterIn(command, "@PA_ACC_INVOICE_CONSOLIDATE", record.InvoiceConsolidate);
            this.MapParameterIn(command, "@PA_ACC_INVOICE_WHEN_STATUS", record.InvoiceWhenStatus);
            this.MapParameterIn(command, "@PA_ACC_INVOICE_FORMAT", record.InvoiceFormat);
            this.MapParameterIn(command, "@PA_ACC_INVOICE_MUST_USE_RULE", record.InvoiceMustUseRule);
            this.MapParameterIn(command, "@PA_ACC_INVOICE_FORMAT_0_TEXT", record.InvoiceFormat0Text);
            this.MapParameterIn(command, "@PA_ACC_INVOICE_FORMAT_1_TEXT", record.InvoiceFormat1Text);
            this.MapParameterIn(command, "@PA_ACC_INVOICE_OFFSET_TYPE", record.InvoiceOffsetType);
            this.MapParameterIn(command, "@PA_ACC_INV_ADD_TO", record.InvAddTo);
            this.MapParameterIn(command, "@PA_ACC_NAT_ACCOUNT", record.NatAccount);
            this.MapParameterIn(command, "@PA_ACC_BANK_NAME", record.BankName);
            this.MapParameterIn(command, "@PA_ACC_BANK_SORT_CODE", record.BankSortCode);
            this.MapParameterIn(command, "@PA_ACC_BANK_NO", record.BankNo);
            this.MapParameterIn(command, "@PA_ACC_BANK_ADD_ID", record.BankAddId);
            this.MapParameterIn(command, "@PA_ACC_PAYMENT_METHD", record.PaymentMethd);
            this.MapParameterIn(command, "@PA_ACC_DOC_TYPE", record.DocType);
            this.MapParameterIn(command, "@PA_ACC_COUT_OFF_DAYS", record.CoutOffDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.CoutOffDays);
            this.MapParameterIn(command, "@PA_ACC_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_ACC_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_ACC_STATUS_DATE", record.StatusDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StatusDate);
            this.MapParameterIn(command, "@PA_ACC_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_ACC_REQ_CREDIT", record.ReqCredit == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.ReqCredit);
            this.MapParameterIn(command, "@PA_ACC_DOCS_METHOD", record.DocsMethod);
            this.MapParameterIn(command, "@PA_ACC_DO_NOT_CHASE", record.DoNotChase);
            this.MapParameterIn(command, "@PA_ACC_INV_PACK_ID", record.InvPackId);
            this.MapParameterIn(command, "@PA_ACC_REQ_PAYMENT_TYPE", record.ReqPaymentType);
            this.MapParameterIn(command, "@PA_ACC_REQ_PAYMENT_DAYS", record.ReqPaymentDays == Int32.MinValue ? 0 : record.ReqPaymentDays);
            this.MapParameterIn(command, "@PA_ACC_DEFAULT_INV_STATUS", record.DefaultInvStatus);
            this.MapParameterIn(command, "@PA_ACC_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_ACC_VAT_REG_NUM", record.VatRegNum);
            this.MapParameterIn(command, "@PA_ACC_MEM_PAYMENT_DAYS", record.MemPaymentDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.MemPaymentDays);
            this.MapParameterIn(command, "@PA_ACC_PO_REQ", record.PoReq);
            this.MapParameterIn(command, "@PA_ACC_RUN_DATE", record.RunDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RunDate);
            this.MapParameterIn(command, "@PA_ACC_PSH_ID", record.PshId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PshId);
            this.MapParameterIn(command, "@PA_ACC_DEFAULT", record.Default);
            this.MapParameterIn(command, "@PA_ACC_RULE_TYPE", record.RuleType);
            this.MapParameterIn(command, "@PA_ACC_NAT_ACCOUNT_DATE", record.NatAccountDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NatAccountDate);
            this.MapParameterIn(command, "@PA_ACC_COURSE_LEN", record.CourseLen == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CourseLen);
            this.MapParameterIn(command, "@PA_ACC_RENEW_DAYS", record.RenewDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.RenewDays);
            this.MapParameterIn(command, "@PA_ACC_FIXED_RENEWAL", record.FixedRenewal);
            this.MapParameterIn(command, "@PA_ACC_RENEWAL_MONTH", record.RenewalMonth);
            this.MapParameterIn(command, "@PA_ACC_RENEWAL_DAY", record.RenewalDay);
            this.MapParameterIn(command, "@PA_ACC_RENEW", record.Renew);
            this.MapParameterIn(command, "@PA_ACC_EXCL_DAY", record.ExclDay);
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
        ///     The <see cref="AccountRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, AccountRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ACC_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_ACC_LOCK", record.Lock);
            record.System = this.MapParameterOut(command, "@PA_ACC_SYSTEM", record.System);
            record.SystemRef = this.MapParameterOut(command, "@PA_ACC_SYSTEM_REF", record.SystemRef);
            record.OrgId = this.MapParameterOut(command, "@PA_ACC_ORG_ID", record.OrgId);
            record.Principal = this.MapParameterOut(command, "@PA_ACC_PRINCIPAL", record.Principal);
            record.ProleId = this.MapParameterOut(command, "@PA_ACC_PROLE_ID", record.ProleId);
            record.ContactId = this.MapParameterOut(command, "@PA_ACC_CONTACT_ID", record.ContactId);
            record.AddId = this.MapParameterOut(command, "@PA_ACC_ADD_ID", record.AddId);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_ACC_SELCO_SP_ID", record.SelcoSpId);
            record.NoAddChange = this.MapParameterOut(command, "@PA_ACC_NO_ADD_CHANGE", record.NoAddChange);
            record.PaymentDays = this.MapParameterOut(command, "@PA_ACC_PAYMENT_DAYS", record.PaymentDays);
            record.Status = this.MapParameterOut(command, "@PA_ACC_STATUS", record.Status);
            record.PaymentType = this.MapParameterOut(command, "@PA_ACC_PAYMENT_TYPE", record.PaymentType);
            record.PayTerms1 = this.MapParameterOut(command, "@PA_ACC_PAY_TERMS_1", record.PayTerms1);
            record.PayTerms2 = this.MapParameterOut(command, "@PA_ACC_PAY_TERMS_2", record.PayTerms2);
            record.PayTerms3 = this.MapParameterOut(command, "@PA_ACC_PAY_TERMS_3", record.PayTerms3);
            record.PayTerms4 = this.MapParameterOut(command, "@PA_ACC_PAY_TERMS_4", record.PayTerms4);
            record.Credit = this.MapParameterOut(command, "@PA_ACC_CREDIT", record.Credit);
            record.SpecialTerms = this.MapParameterOut(command, "@PA_ACC_SPECIAL_TERMS", record.SpecialTerms);
            record.Vatcd = this.MapParameterOut(command, "@PA_ACC_VATCD", record.Vatcd);
            record.InvForAttnOf = this.MapParameterOut(command, "@PA_ACC_INV_FOR_ATTN_OF", record.InvForAttnOf);
            record.InvoiceRule = this.MapParameterOut(command, "@PA_ACC_INVOICE_RULE", record.InvoiceRule);
            record.InvoiceRuleOffset = this.MapParameterOut(command, "@PA_ACC_INVOICE_RULE_OFFSET", record.InvoiceRuleOffset);
            record.InvoiceConsolidate = this.MapParameterOut(command, "@PA_ACC_INVOICE_CONSOLIDATE", record.InvoiceConsolidate);
            record.InvoiceWhenStatus = this.MapParameterOut(command, "@PA_ACC_INVOICE_WHEN_STATUS", record.InvoiceWhenStatus);
            record.InvoiceFormat = this.MapParameterOut(command, "@PA_ACC_INVOICE_FORMAT", record.InvoiceFormat);
            record.InvoiceMustUseRule = this.MapParameterOut(command, "@PA_ACC_INVOICE_MUST_USE_RULE", record.InvoiceMustUseRule);
            record.InvoiceFormat0Text = this.MapParameterOut(command, "@PA_ACC_INVOICE_FORMAT_0_TEXT", record.InvoiceFormat0Text);
            record.InvoiceFormat1Text = this.MapParameterOut(command, "@PA_ACC_INVOICE_FORMAT_1_TEXT", record.InvoiceFormat1Text);
            record.InvoiceOffsetType = this.MapParameterOut(command, "@PA_ACC_INVOICE_OFFSET_TYPE", record.InvoiceOffsetType);
            record.InvAddTo = this.MapParameterOut(command, "@PA_ACC_INV_ADD_TO", record.InvAddTo);
            record.NatAccount = this.MapParameterOut(command, "@PA_ACC_NAT_ACCOUNT", record.NatAccount);
            record.BankName = this.MapParameterOut(command, "@PA_ACC_BANK_NAME", record.BankName);
            record.BankSortCode = this.MapParameterOut(command, "@PA_ACC_BANK_SORT_CODE", record.BankSortCode);
            record.BankNo = this.MapParameterOut(command, "@PA_ACC_BANK_NO", record.BankNo);
            record.BankAddId = this.MapParameterOut(command, "@PA_ACC_BANK_ADD_ID", record.BankAddId);
            record.PaymentMethd = this.MapParameterOut(command, "@PA_ACC_PAYMENT_METHD", record.PaymentMethd);
            record.DocType = this.MapParameterOut(command, "@PA_ACC_DOC_TYPE", record.DocType);
            record.CoutOffDays = this.MapParameterOut(command, "@PA_ACC_COUT_OFF_DAYS", record.CoutOffDays);
            record.Type = this.MapParameterOut(command, "@PA_ACC_TYPE", record.Type);
            record.Title = this.MapParameterOut(command, "@PA_ACC_TITLE", record.Title);
            record.StatusDate = this.MapParameterOut(command, "@PA_ACC_STATUS_DATE", record.StatusDate);
            record.BatId = this.MapParameterOut(command, "@PA_ACC_BAT_ID", record.BatId);
            record.ReqCredit = this.MapParameterOut(command, "@PA_ACC_REQ_CREDIT", record.ReqCredit);
            record.DocsMethod = this.MapParameterOut(command, "@PA_ACC_DOCS_METHOD", record.DocsMethod);
            record.DoNotChase = this.MapParameterOut(command, "@PA_ACC_DO_NOT_CHASE", record.DoNotChase);
            record.InvPackId = this.MapParameterOut(command, "@PA_ACC_INV_PACK_ID", record.InvPackId);
            record.ReqPaymentType = this.MapParameterOut(command, "@PA_ACC_REQ_PAYMENT_TYPE", record.ReqPaymentType);
            record.ReqPaymentDays = this.MapParameterOut(command, "@PA_ACC_REQ_PAYMENT_DAYS", record.ReqPaymentDays);
            record.DefaultInvStatus = this.MapParameterOut(command, "@PA_ACC_DEFAULT_INV_STATUS", record.DefaultInvStatus);
            record.CurrencyType = this.MapParameterOut(command, "@PA_ACC_CURRENCY_TYPE", record.CurrencyType);
            record.VatRegNum = this.MapParameterOut(command, "@PA_ACC_VAT_REG_NUM", record.VatRegNum);
            record.MemPaymentDays = this.MapParameterOut(command, "@PA_ACC_MEM_PAYMENT_DAYS", record.MemPaymentDays);
            record.PoReq = this.MapParameterOut(command, "@PA_ACC_PO_REQ", record.PoReq);
            record.RunDate = this.MapParameterOut(command, "@PA_ACC_RUN_DATE", record.RunDate);
            record.PshId = this.MapParameterOut(command, "@PA_ACC_PSH_ID", record.PshId);
            record.Default = this.MapParameterOut(command, "@PA_ACC_DEFAULT", record.Default);
            record.RuleType = this.MapParameterOut(command, "@PA_ACC_RULE_TYPE", record.RuleType);
            record.NatAccountDate = this.MapParameterOut(command, "@PA_ACC_NAT_ACCOUNT_DATE", record.NatAccountDate);
            record.CourseLen = this.MapParameterOut(command, "@PA_ACC_COURSE_LEN", record.CourseLen);
            record.RenewDays = this.MapParameterOut(command, "@PA_ACC_RENEW_DAYS", record.RenewDays);
            record.FixedRenewal = this.MapParameterOut(command, "@PA_ACC_FIXED_RENEWAL", record.FixedRenewal);
            record.RenewalMonth = this.MapParameterOut(command, "@PA_ACC_RENEWAL_MONTH", record.RenewalMonth);
            record.RenewalDay = this.MapParameterOut(command, "@PA_ACC_RENEWAL_DAY", record.RenewalDay);
            record.Renew = this.MapParameterOut(command, "@PA_ACC_RENEW", record.Renew);
            record.ExclDay = this.MapParameterOut(command, "@PA_ACC_EXCL_DAY", record.ExclDay);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='AccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AccountRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<AccountRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_ACC_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='AccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AccountRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<AccountRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_ACC_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref='AccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AccountRecord" /> instances that match the specified <paramref name='addId' />.
        /// </returns>
        public IEnumerable<AccountRecord> FetchAllByAddId(String addId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AddId");
            this.MapParameterIn(command, "@PA_ACC_ADD_ID", addId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='AccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AccountRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<AccountRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_ACC_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invPackId">
        ///     The value which identifies the <see cref='AccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AccountRecord" /> instances that match the specified <paramref name='invPackId' />.
        /// </returns>
        public IEnumerable<AccountRecord> FetchAllByInvPackId(String invPackId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvPackId");
            this.MapParameterIn(command, "@PA_ACC_INV_PACK_ID", invPackId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IAccountRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instance that matches the specified <paramref name="roleId" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> IAccountRepository.FetchByXrefRoleIdandOrgId(System.String roleId, System.String orgId, System.String spId)
        {
            return this.FetchByXrefRoleIdandOrgId(roleId, orgId, spId);
        }

        void IAccountRepository.Create(Consensus.Finance.AccountRecord record)
        {
            this.Create(record);
        }

        void IAccountRepository.Modify(Consensus.Finance.AccountRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> IAccountRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> IAccountRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> IAccountRepository.FetchAllByAddId(System.String addId)
        {
            return this.FetchAllByAddId(addId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> IAccountRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invPackId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountRecord" /> instances that match the specified <paramref name="invPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountRecord> IAccountRepository.FetchAllByInvPackId(System.String invPackId)
        {
            return this.FetchAllByInvPackId(invPackId);
        }

        #endregion
    }
}
