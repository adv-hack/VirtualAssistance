using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MemberPeriodRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerMemberPeriodRepository : SqlServerRepository<MemberPeriodRecord, String>, IMemberPeriodRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Membership"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "MemberPeriod"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="MemberPeriodRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_MEP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Member_period"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="MemberPeriodRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="MemberPeriodRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, MemberPeriodRecord record)
        {
            record.Id = dataRecord["MEP_ID"].ConvertTo<String>();
            record.AddBy = dataRecord["MEP_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["MEP_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["MEP_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["MEP_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["MEP_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["MEP_RCV_DATE"].ConvertTo<DateTime?>();
            record.MemId = dataRecord["MEP_MEM_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["MEP_PROD_ID"].ConvertTo<String>();
            record.MemGrade = dataRecord["MEP_MEM_GRADE"].ConvertTo<String>();
            record.Year = dataRecord["MEP_YEAR"].ConvertTo<String>();
            record.Start = dataRecord["MEP_START"].ConvertTo<DateTime?>();
            record.End = dataRecord["MEP_END"].ConvertTo<DateTime?>();
            record.RenewDate1 = dataRecord["MEP_RENEW_DATE1"].ConvertTo<DateTime?>();
            record.RenewDate2 = dataRecord["MEP_RENEW_DATE2"].ConvertTo<DateTime?>();
            record.RenewDate3 = dataRecord["MEP_RENEW_DATE3"].ConvertTo<DateTime?>();
            record.Qty1 = dataRecord["MEP_QTY_1"].ConvertTo<Int32?>();
            record.Qty2 = dataRecord["MEP_QTY_2"].ConvertTo<Int32?>();
            record.Qty3 = dataRecord["MEP_QTY_3"].ConvertTo<Int32?>();
            record.Qty4 = dataRecord["MEP_QTY_4"].ConvertTo<Int32?>();
            record.Qty5 = dataRecord["MEP_QTY_5"].ConvertTo<Int32?>();
            record.Fee = dataRecord["MEP_FEE"].ConvertTo<Decimal>();
            record.FeeBc = dataRecord["MEP_FEE_BC"].ConvertTo<Decimal>();
            record.FeeBc2 = dataRecord["MEP_FEE_BC2"].ConvertTo<Decimal>();
            record.Currency = dataRecord["MEP_CURRENCY"].ConvertTo<String>();
            record.FeeExtra = dataRecord["MEP_FEE_EXTRA"].ConvertTo<Decimal>();
            record.FeeExtraBc = dataRecord["MEP_FEE_EXTRA_BC"].ConvertTo<Decimal>();
            record.FeeExtraBc2 = dataRecord["MEP_FEE_EXTRA_BC2"].ConvertTo<Decimal>();
            record.PayMethod = dataRecord["MEP_PAY_METHOD"].ConvertTo<String>();
            record.PayStatus = dataRecord["MEP_PAY_STATUS"].ConvertTo<String>();
            record.PoRef = dataRecord["MEP_PO_REF"].ConvertTo<String>();
            record.CcardType = dataRecord["MEP_CCARD_TYPE"].ConvertTo<String>();
            record.NameOnCard = dataRecord["MEP_NAME_ON_CARD"].ConvertTo<String>();
            record.CcardNumber = dataRecord["MEP_CCARD_NUMBER"].ConvertTo<String>();
            record.CcardStart = dataRecord["MEP_CCARD_START"].ConvertTo<String>();
            record.CcardExpy = dataRecord["MEP_CCARD_EXPY"].ConvertTo<String>();
            record.BankAccCode = dataRecord["MEP_BANK_ACC_CODE"].ConvertTo<String>();
            record.SortCode = dataRecord["MEP_SORT_CODE"].ConvertTo<String>();
            record.CcardIssue = dataRecord["MEP_CCARD_ISSUE"].ConvertTo<String>();
            record.Security = dataRecord["MEP_SECURITY"].ConvertTo<String>();
            record.CcardAuthcode = dataRecord["MEP_CCARD_AUTHCODE"].ConvertTo<String>();
            record.DocsMethod = dataRecord["MEP_DOCS_METHOD"].ConvertTo<String>();
            record.InvOrgId = dataRecord["MEP_INV_ORG_ID"].ConvertTo<String>();
            record.InvProleId = dataRecord["MEP_INV_PROLE_ID"].ConvertTo<String>();
            record.InvAddId = dataRecord["MEP_INV_ADD_ID"].ConvertTo<String>();
            record.PriceListId = dataRecord["MEP_PRICE_LIST_ID"].ConvertTo<String>();
            record.Current = dataRecord["MEP_CURRENT"].ConvertTo<Byte?>();
            record.PmId = dataRecord["MEP_PM_ID"].ConvertTo<String>();
            record.SubOnly = dataRecord["MEP_SUB_ONLY"].ConvertTo<Int32?>();
            record.RenewedDate = dataRecord["MEP_RENEWED_DATE"].ConvertTo<DateTime?>();
            record.LapsedDate = dataRecord["MEP_LAPSED_DATE"].ConvertTo<DateTime?>();
            record.RenewDate0 = dataRecord["MEP_RENEW_DATE_0"].ConvertTo<DateTime?>();
            record.Status = dataRecord["MEP_STATUS"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["MEP_SELCO_SP_ID"].ConvertTo<String>();
            record.RenewalDate = dataRecord["MEP_RENEWAL_DATE"].ConvertTo<DateTime?>();
            record.RenewStart = dataRecord["MEP_RENEW_START"].ConvertTo<DateTime?>();
            record.CreateBatId = dataRecord["MEP_CREATE_BAT_ID"].ConvertTo<String>();
            record.RenewBatId = dataRecord["MEP_RENEW_BAT_ID"].ConvertTo<String>();
            record.OldMepId = dataRecord["MEP_OLD_MEP_ID"].ConvertTo<String>();
            record.IncHierarchy = dataRecord["MEP_INC_HIERARCHY"].ConvertTo<Int32?>();
            record.NoCopies1 = dataRecord["MEP_NO_COPIES_1"].ConvertTo<Int32?>();
            record.NoCopies2 = dataRecord["MEP_NO_COPIES_2"].ConvertTo<Int32?>();
            record.NoCopies3 = dataRecord["MEP_NO_COPIES_3"].ConvertTo<Int32?>();
            record.CustOrderNo = dataRecord["MEP_CUST_ORDER_NO"].ConvertTo<String>();
            record.Userchar1 = dataRecord["MEP_USERCHAR_1"].ConvertTo<String>();
            record.CancelReason = dataRecord["MEP_CANCEL_REASON"].ConvertTo<String>();
            record.MembRate = dataRecord["MEP_MEMB_RATE"].ConvertTo<Byte?>();
            record.MemType = dataRecord["MEP_MEM_TYPE"].ConvertTo<String>();
            record.ForAttnOf = dataRecord["MEP_FOR_ATTN_OF"].ConvertTo<String>();
            record.OrgCustAc = dataRecord["MEP_ORG_CUST_AC"].ConvertTo<String>();
            record.Remind1BatId = dataRecord["MEP_REMIND1_BAT_ID"].ConvertTo<String>();
            record.Remind2BatId = dataRecord["MEP_REMIND2_BAT_ID"].ConvertTo<String>();
            record.Remind3BatId = dataRecord["MEP_REMIND3_BAT_ID"].ConvertTo<String>();
            record.Remind4BatId = dataRecord["MEP_REMIND4_BAT_ID"].ConvertTo<String>();
            record.Remind1Date = dataRecord["MEP_REMIND1_DATE"].ConvertTo<DateTime?>();
            record.Remind2Date = dataRecord["MEP_REMIND2_DATE"].ConvertTo<DateTime?>();
            record.Remind3Date = dataRecord["MEP_REMIND3_DATE"].ConvertTo<DateTime?>();
            record.Remind4Date = dataRecord["MEP_REMIND4_DATE"].ConvertTo<DateTime?>();
            record.PrevStatus = dataRecord["MEP_PREV_STATUS"].ConvertTo<String>();
            record.ContPayment = dataRecord["MEP_CONT_PAYMENT"].ConvertTo<Byte?>();
            record.NetFee = dataRecord["MEP_NET_FEE"].ConvertTo<Decimal>();
            record.NetFeeBc = dataRecord["MEP_NET_FEE_BC"].ConvertTo<Decimal>();
            record.NetFeeBc2 = dataRecord["MEP_NET_FEE_BC2"].ConvertTo<Decimal>();
            record.VatAmt = dataRecord["MEP_VAT_AMT"].ConvertTo<Decimal>();
            record.VatAmtBc = dataRecord["MEP_VAT_AMT_BC"].ConvertTo<Decimal>();
            record.VatAmtBc2 = dataRecord["MEP_VAT_AMT_BC2"].ConvertTo<Decimal>();
            record.Notes = dataRecord["MEP_NOTES"].ConvertTo<String>();
            record.CurrentDate = dataRecord["MEP_CURRENT_DATE"].ConvertTo<DateTime?>();
            record.LapseDate = dataRecord["MEP_LAPSE_DATE"].ConvertTo<DateTime?>();
            record.BatchInvoice = dataRecord["MEP_BATCH_INVOICE"].ConvertTo<Byte?>();
            record.BasketFl = dataRecord["MEP_BASKET_FL"].ConvertTo<Byte>();
            record.IndemInsurDate = dataRecord["MEP_INDEM_INSUR_DATE"].ConvertTo<DateTime?>();
            record.ExpBatId = dataRecord["MEP_EXP_BAT_ID"].ConvertTo<String>();
            record.RollbackDate = dataRecord["MEP_ROLLBACK_DATE"].ConvertTo<DateTime?>();
            record.StatusInt = dataRecord["MEP_STATUS_INT"].ConvertTo<Int32>();
            record.ShortDated = dataRecord["MEP_SHORT_DATED"].ConvertTo<Int32?>();
            record.CartId = dataRecord["MEP_CART_ID"].ConvertTo<Int32?>();
            record.PclnId = dataRecord["MEP_PCLN_ID"].ConvertTo<Int32?>();
            record.CurrRateBc = dataRecord["MEP_CURR_RATE_BC"].ConvertTo<Decimal?>();
            record.CurrRateBc2 = dataRecord["MEP_CURR_RATE_BC2"].ConvertTo<Decimal?>();
            record.AppMethod = dataRecord["MEP_APP_METHOD"].ConvertTo<String>();
            record.OppId = dataRecord["MEP_OPP_ID"].ConvertTo<String>();
            record.DoNotInvoic = dataRecord["MEP_DO_NOT_INVOIC"].ConvertTo<Byte?>();
            record.PoExpirationDate = dataRecord["MEP_PO_EXPIRATION_DATE"].ConvertTo<DateTime?>();
            record.AccId = dataRecord["MEP_ACC_ID"].ConvertTo<String>();
            record.MembershipName = dataRecord["MEP_MEMBERSHIP_NAME"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="MemberPeriodRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, MemberPeriodRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_MEP_ID", record.Id);
            this.MapParameterIn(command, "@PA_MEP_MEM_ID", record.MemId);
            this.MapParameterIn(command, "@PA_MEP_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_MEP_MEM_GRADE", record.MemGrade);
            this.MapParameterIn(command, "@PA_MEP_YEAR", record.Year);
            this.MapParameterIn(command, "@PA_MEP_START", record.Start == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Start);
            this.MapParameterIn(command, "@PA_MEP_END", record.End == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.End);
            this.MapParameterIn(command, "@PA_MEP_RENEW_DATE1", record.RenewDate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RenewDate1);
            this.MapParameterIn(command, "@PA_MEP_RENEW_DATE2", record.RenewDate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RenewDate2);
            this.MapParameterIn(command, "@PA_MEP_RENEW_DATE3", record.RenewDate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RenewDate3);
            this.MapParameterIn(command, "@PA_MEP_QTY_1", record.Qty1 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Qty1);
            this.MapParameterIn(command, "@PA_MEP_QTY_2", record.Qty2 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Qty2);
            this.MapParameterIn(command, "@PA_MEP_QTY_3", record.Qty3 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Qty3);
            this.MapParameterIn(command, "@PA_MEP_QTY_4", record.Qty4 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Qty4);
            this.MapParameterIn(command, "@PA_MEP_QTY_5", record.Qty5 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Qty5);
            this.MapParameterIn(command, "@PA_MEP_FEE", record.Fee == Decimal.MinValue ? 0M : record.Fee);
            this.MapParameterIn(command, "@PA_MEP_FEE_BC", record.FeeBc == Decimal.MinValue ? 0M : record.FeeBc);
            this.MapParameterIn(command, "@PA_MEP_FEE_BC2", record.FeeBc2 == Decimal.MinValue ? 0M : record.FeeBc2);
            this.MapParameterIn(command, "@PA_MEP_CURRENCY", record.Currency);
            this.MapParameterIn(command, "@PA_MEP_FEE_EXTRA", record.FeeExtra == Decimal.MinValue ? 0M : record.FeeExtra);
            this.MapParameterIn(command, "@PA_MEP_FEE_EXTRA_BC", record.FeeExtraBc == Decimal.MinValue ? 0M : record.FeeExtraBc);
            this.MapParameterIn(command, "@PA_MEP_FEE_EXTRA_BC2", record.FeeExtraBc2 == Decimal.MinValue ? 0M : record.FeeExtraBc2);
            this.MapParameterIn(command, "@PA_MEP_PAY_METHOD", record.PayMethod);
            this.MapParameterIn(command, "@PA_MEP_PAY_STATUS", record.PayStatus);
            this.MapParameterIn(command, "@PA_MEP_PO_REF", record.PoRef);
            this.MapParameterIn(command, "@PA_MEP_CCARD_TYPE", record.CcardType);
            this.MapParameterIn(command, "@PA_MEP_NAME_ON_CARD", record.NameOnCard);
            this.MapParameterIn(command, "@PA_MEP_CCARD_NUMBER", record.CcardNumber);
            this.MapParameterIn(command, "@PA_MEP_CCARD_START", record.CcardStart);
            this.MapParameterIn(command, "@PA_MEP_CCARD_EXPY", record.CcardExpy);
            this.MapParameterIn(command, "@PA_MEP_BANK_ACC_CODE", record.BankAccCode);
            this.MapParameterIn(command, "@PA_MEP_SORT_CODE", record.SortCode);
            this.MapParameterIn(command, "@PA_MEP_CCARD_ISSUE", record.CcardIssue);
            this.MapParameterIn(command, "@PA_MEP_SECURITY", record.Security);
            this.MapParameterIn(command, "@PA_MEP_CCARD_AUTHCODE", record.CcardAuthcode);
            this.MapParameterIn(command, "@PA_MEP_DOCS_METHOD", record.DocsMethod);
            this.MapParameterIn(command, "@PA_MEP_INV_ORG_ID", record.InvOrgId);
            this.MapParameterIn(command, "@PA_MEP_INV_PROLE_ID", record.InvProleId);
            this.MapParameterIn(command, "@PA_MEP_INV_ADD_ID", record.InvAddId);
            this.MapParameterIn(command, "@PA_MEP_PRICE_LIST_ID", record.PriceListId);
            this.MapParameterIn(command, "@PA_MEP_CURRENT", record.Current);
            this.MapParameterIn(command, "@PA_MEP_PM_ID", record.PmId);
            this.MapParameterIn(command, "@PA_MEP_SUB_ONLY", record.SubOnly == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SubOnly);
            this.MapParameterIn(command, "@PA_MEP_RENEWED_DATE", record.RenewedDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RenewedDate);
            this.MapParameterIn(command, "@PA_MEP_LAPSED_DATE", record.LapsedDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LapsedDate);
            this.MapParameterIn(command, "@PA_MEP_RENEW_DATE_0", record.RenewDate0 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RenewDate0);
            this.MapParameterIn(command, "@PA_MEP_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_MEP_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_MEP_RENEWAL_DATE", record.RenewalDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RenewalDate);
            this.MapParameterIn(command, "@PA_MEP_RENEW_START", record.RenewStart == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RenewStart);
            this.MapParameterIn(command, "@PA_MEP_CREATE_BAT_ID", record.CreateBatId);
            this.MapParameterIn(command, "@PA_MEP_RENEW_BAT_ID", record.RenewBatId);
            this.MapParameterIn(command, "@PA_MEP_OLD_MEP_ID", record.OldMepId);
            this.MapParameterIn(command, "@PA_MEP_INC_HIERARCHY", record.IncHierarchy == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.IncHierarchy);
            this.MapParameterIn(command, "@PA_MEP_NO_COPIES_1", record.NoCopies1 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NoCopies1);
            this.MapParameterIn(command, "@PA_MEP_NO_COPIES_2", record.NoCopies2 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NoCopies2);
            this.MapParameterIn(command, "@PA_MEP_NO_COPIES_3", record.NoCopies3 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NoCopies3);
            this.MapParameterIn(command, "@PA_MEP_CUST_ORDER_NO", record.CustOrderNo);
            this.MapParameterIn(command, "@PA_MEP_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_MEP_CANCEL_REASON", record.CancelReason);
            this.MapParameterIn(command, "@PA_MEP_MEMB_RATE", record.MembRate);
            this.MapParameterIn(command, "@PA_MEP_MEM_TYPE", record.MemType);
            this.MapParameterIn(command, "@PA_MEP_FOR_ATTN_OF", record.ForAttnOf);
            this.MapParameterIn(command, "@PA_MEP_ORG_CUST_AC", record.OrgCustAc);
            this.MapParameterIn(command, "@PA_MEP_REMIND1_BAT_ID", record.Remind1BatId);
            this.MapParameterIn(command, "@PA_MEP_REMIND2_BAT_ID", record.Remind2BatId);
            this.MapParameterIn(command, "@PA_MEP_REMIND3_BAT_ID", record.Remind3BatId);
            this.MapParameterIn(command, "@PA_MEP_REMIND4_BAT_ID", record.Remind4BatId);
            this.MapParameterIn(command, "@PA_MEP_REMIND1_DATE", record.Remind1Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Remind1Date);
            this.MapParameterIn(command, "@PA_MEP_REMIND2_DATE", record.Remind2Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Remind2Date);
            this.MapParameterIn(command, "@PA_MEP_REMIND3_DATE", record.Remind3Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Remind3Date);
            this.MapParameterIn(command, "@PA_MEP_REMIND4_DATE", record.Remind4Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Remind4Date);
            this.MapParameterIn(command, "@PA_MEP_PREV_STATUS", record.PrevStatus);
            this.MapParameterIn(command, "@PA_MEP_CONT_PAYMENT", record.ContPayment);
            this.MapParameterIn(command, "@PA_MEP_NET_FEE", record.NetFee == Decimal.MinValue ? 0M : record.NetFee);
            this.MapParameterIn(command, "@PA_MEP_NET_FEE_BC", record.NetFeeBc == Decimal.MinValue ? 0M : record.NetFeeBc);
            this.MapParameterIn(command, "@PA_MEP_NET_FEE_BC2", record.NetFeeBc2 == Decimal.MinValue ? 0M : record.NetFeeBc2);
            this.MapParameterIn(command, "@PA_MEP_VAT_AMT", record.VatAmt == Decimal.MinValue ? 0M : record.VatAmt);
            this.MapParameterIn(command, "@PA_MEP_VAT_AMT_BC", record.VatAmtBc == Decimal.MinValue ? 0M : record.VatAmtBc);
            this.MapParameterIn(command, "@PA_MEP_VAT_AMT_BC2", record.VatAmtBc2 == Decimal.MinValue ? 0M : record.VatAmtBc2);
            this.MapParameterIn(command, "@PA_MEP_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_MEP_CURRENT_DATE", record.CurrentDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CurrentDate);
            this.MapParameterIn(command, "@PA_MEP_LAPSE_DATE", record.LapseDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LapseDate);
            this.MapParameterIn(command, "@PA_MEP_BATCH_INVOICE", record.BatchInvoice);
            this.MapParameterIn(command, "@PA_MEP_BASKET_FL", record.BasketFl);
            this.MapParameterIn(command, "@PA_MEP_INDEM_INSUR_DATE", record.IndemInsurDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.IndemInsurDate);
            this.MapParameterIn(command, "@PA_MEP_EXP_BAT_ID", record.ExpBatId);
            this.MapParameterIn(command, "@PA_MEP_ROLLBACK_DATE", record.RollbackDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RollbackDate);
            this.MapParameterIn(command, "@PA_MEP_STATUS_INT", record.StatusInt == Int32.MinValue ? 0 : record.StatusInt);
            this.MapParameterIn(command, "@PA_MEP_SHORT_DATED", record.ShortDated == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ShortDated);
            this.MapParameterIn(command, "@PA_MEP_CART_ID", record.CartId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.CartId);
            this.MapParameterIn(command, "@PA_MEP_PCLN_ID", record.PclnId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PclnId);
            this.MapParameterIn(command, "@PA_MEP_CURR_RATE_BC", record.CurrRateBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CurrRateBc);
            this.MapParameterIn(command, "@PA_MEP_CURR_RATE_BC2", record.CurrRateBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CurrRateBc2);
            this.MapParameterIn(command, "@PA_MEP_APP_METHOD", record.AppMethod);
            this.MapParameterIn(command, "@PA_MEP_OPP_ID", record.OppId);
            this.MapParameterIn(command, "@PA_MEP_DO_NOT_INVOIC", record.DoNotInvoic);
            this.MapParameterIn(command, "@PA_MEP_PO_EXPIRATION_DATE", record.PoExpirationDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PoExpirationDate);
            this.MapParameterIn(command, "@PA_MEP_ACC_ID", record.AccId);
            this.MapParameterIn(command, "@PA_MEP_MEMBERSHIP_NAME", record.MembershipName);
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
        ///     The <see cref="MemberPeriodRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, MemberPeriodRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_MEP_ID", record.Id);
            record.MemId = this.MapParameterOut(command, "@PA_MEP_MEM_ID", record.MemId);
            record.ProdId = this.MapParameterOut(command, "@PA_MEP_PROD_ID", record.ProdId);
            record.MemGrade = this.MapParameterOut(command, "@PA_MEP_MEM_GRADE", record.MemGrade);
            record.Year = this.MapParameterOut(command, "@PA_MEP_YEAR", record.Year);
            record.Start = this.MapParameterOut(command, "@PA_MEP_START", record.Start);
            record.End = this.MapParameterOut(command, "@PA_MEP_END", record.End);
            record.RenewDate1 = this.MapParameterOut(command, "@PA_MEP_RENEW_DATE1", record.RenewDate1);
            record.RenewDate2 = this.MapParameterOut(command, "@PA_MEP_RENEW_DATE2", record.RenewDate2);
            record.RenewDate3 = this.MapParameterOut(command, "@PA_MEP_RENEW_DATE3", record.RenewDate3);
            record.Qty1 = this.MapParameterOut(command, "@PA_MEP_QTY_1", record.Qty1);
            record.Qty2 = this.MapParameterOut(command, "@PA_MEP_QTY_2", record.Qty2);
            record.Qty3 = this.MapParameterOut(command, "@PA_MEP_QTY_3", record.Qty3);
            record.Qty4 = this.MapParameterOut(command, "@PA_MEP_QTY_4", record.Qty4);
            record.Qty5 = this.MapParameterOut(command, "@PA_MEP_QTY_5", record.Qty5);
            record.Fee = this.MapParameterOut(command, "@PA_MEP_FEE", record.Fee);
            record.FeeBc = this.MapParameterOut(command, "@PA_MEP_FEE_BC", record.FeeBc);
            record.FeeBc2 = this.MapParameterOut(command, "@PA_MEP_FEE_BC2", record.FeeBc2);
            record.Currency = this.MapParameterOut(command, "@PA_MEP_CURRENCY", record.Currency);
            record.FeeExtra = this.MapParameterOut(command, "@PA_MEP_FEE_EXTRA", record.FeeExtra);
            record.FeeExtraBc = this.MapParameterOut(command, "@PA_MEP_FEE_EXTRA_BC", record.FeeExtraBc);
            record.FeeExtraBc2 = this.MapParameterOut(command, "@PA_MEP_FEE_EXTRA_BC2", record.FeeExtraBc2);
            record.PayMethod = this.MapParameterOut(command, "@PA_MEP_PAY_METHOD", record.PayMethod);
            record.PayStatus = this.MapParameterOut(command, "@PA_MEP_PAY_STATUS", record.PayStatus);
            record.PoRef = this.MapParameterOut(command, "@PA_MEP_PO_REF", record.PoRef);
            record.CcardType = this.MapParameterOut(command, "@PA_MEP_CCARD_TYPE", record.CcardType);
            record.NameOnCard = this.MapParameterOut(command, "@PA_MEP_NAME_ON_CARD", record.NameOnCard);
            record.CcardNumber = this.MapParameterOut(command, "@PA_MEP_CCARD_NUMBER", record.CcardNumber);
            record.CcardStart = this.MapParameterOut(command, "@PA_MEP_CCARD_START", record.CcardStart);
            record.CcardExpy = this.MapParameterOut(command, "@PA_MEP_CCARD_EXPY", record.CcardExpy);
            record.BankAccCode = this.MapParameterOut(command, "@PA_MEP_BANK_ACC_CODE", record.BankAccCode);
            record.SortCode = this.MapParameterOut(command, "@PA_MEP_SORT_CODE", record.SortCode);
            record.CcardIssue = this.MapParameterOut(command, "@PA_MEP_CCARD_ISSUE", record.CcardIssue);
            record.Security = this.MapParameterOut(command, "@PA_MEP_SECURITY", record.Security);
            record.CcardAuthcode = this.MapParameterOut(command, "@PA_MEP_CCARD_AUTHCODE", record.CcardAuthcode);
            record.DocsMethod = this.MapParameterOut(command, "@PA_MEP_DOCS_METHOD", record.DocsMethod);
            record.InvOrgId = this.MapParameterOut(command, "@PA_MEP_INV_ORG_ID", record.InvOrgId);
            record.InvProleId = this.MapParameterOut(command, "@PA_MEP_INV_PROLE_ID", record.InvProleId);
            record.InvAddId = this.MapParameterOut(command, "@PA_MEP_INV_ADD_ID", record.InvAddId);
            record.PriceListId = this.MapParameterOut(command, "@PA_MEP_PRICE_LIST_ID", record.PriceListId);
            record.Current = this.MapParameterOut(command, "@PA_MEP_CURRENT", record.Current);
            record.PmId = this.MapParameterOut(command, "@PA_MEP_PM_ID", record.PmId);
            record.SubOnly = this.MapParameterOut(command, "@PA_MEP_SUB_ONLY", record.SubOnly);
            record.RenewedDate = this.MapParameterOut(command, "@PA_MEP_RENEWED_DATE", record.RenewedDate);
            record.LapsedDate = this.MapParameterOut(command, "@PA_MEP_LAPSED_DATE", record.LapsedDate);
            record.RenewDate0 = this.MapParameterOut(command, "@PA_MEP_RENEW_DATE_0", record.RenewDate0);
            record.Status = this.MapParameterOut(command, "@PA_MEP_STATUS", record.Status);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_MEP_SELCO_SP_ID", record.SelcoSpId);
            record.RenewalDate = this.MapParameterOut(command, "@PA_MEP_RENEWAL_DATE", record.RenewalDate);
            record.RenewStart = this.MapParameterOut(command, "@PA_MEP_RENEW_START", record.RenewStart);
            record.CreateBatId = this.MapParameterOut(command, "@PA_MEP_CREATE_BAT_ID", record.CreateBatId);
            record.RenewBatId = this.MapParameterOut(command, "@PA_MEP_RENEW_BAT_ID", record.RenewBatId);
            record.OldMepId = this.MapParameterOut(command, "@PA_MEP_OLD_MEP_ID", record.OldMepId);
            record.IncHierarchy = this.MapParameterOut(command, "@PA_MEP_INC_HIERARCHY", record.IncHierarchy);
            record.NoCopies1 = this.MapParameterOut(command, "@PA_MEP_NO_COPIES_1", record.NoCopies1);
            record.NoCopies2 = this.MapParameterOut(command, "@PA_MEP_NO_COPIES_2", record.NoCopies2);
            record.NoCopies3 = this.MapParameterOut(command, "@PA_MEP_NO_COPIES_3", record.NoCopies3);
            record.CustOrderNo = this.MapParameterOut(command, "@PA_MEP_CUST_ORDER_NO", record.CustOrderNo);
            record.Userchar1 = this.MapParameterOut(command, "@PA_MEP_USERCHAR_1", record.Userchar1);
            record.CancelReason = this.MapParameterOut(command, "@PA_MEP_CANCEL_REASON", record.CancelReason);
            record.MembRate = this.MapParameterOut(command, "@PA_MEP_MEMB_RATE", record.MembRate);
            record.MemType = this.MapParameterOut(command, "@PA_MEP_MEM_TYPE", record.MemType);
            record.ForAttnOf = this.MapParameterOut(command, "@PA_MEP_FOR_ATTN_OF", record.ForAttnOf);
            record.OrgCustAc = this.MapParameterOut(command, "@PA_MEP_ORG_CUST_AC", record.OrgCustAc);
            record.Remind1BatId = this.MapParameterOut(command, "@PA_MEP_REMIND1_BAT_ID", record.Remind1BatId);
            record.Remind2BatId = this.MapParameterOut(command, "@PA_MEP_REMIND2_BAT_ID", record.Remind2BatId);
            record.Remind3BatId = this.MapParameterOut(command, "@PA_MEP_REMIND3_BAT_ID", record.Remind3BatId);
            record.Remind4BatId = this.MapParameterOut(command, "@PA_MEP_REMIND4_BAT_ID", record.Remind4BatId);
            record.Remind1Date = this.MapParameterOut(command, "@PA_MEP_REMIND1_DATE", record.Remind1Date);
            record.Remind2Date = this.MapParameterOut(command, "@PA_MEP_REMIND2_DATE", record.Remind2Date);
            record.Remind3Date = this.MapParameterOut(command, "@PA_MEP_REMIND3_DATE", record.Remind3Date);
            record.Remind4Date = this.MapParameterOut(command, "@PA_MEP_REMIND4_DATE", record.Remind4Date);
            record.PrevStatus = this.MapParameterOut(command, "@PA_MEP_PREV_STATUS", record.PrevStatus);
            record.ContPayment = this.MapParameterOut(command, "@PA_MEP_CONT_PAYMENT", record.ContPayment);
            record.NetFee = this.MapParameterOut(command, "@PA_MEP_NET_FEE", record.NetFee);
            record.NetFeeBc = this.MapParameterOut(command, "@PA_MEP_NET_FEE_BC", record.NetFeeBc);
            record.NetFeeBc2 = this.MapParameterOut(command, "@PA_MEP_NET_FEE_BC2", record.NetFeeBc2);
            record.VatAmt = this.MapParameterOut(command, "@PA_MEP_VAT_AMT", record.VatAmt);
            record.VatAmtBc = this.MapParameterOut(command, "@PA_MEP_VAT_AMT_BC", record.VatAmtBc);
            record.VatAmtBc2 = this.MapParameterOut(command, "@PA_MEP_VAT_AMT_BC2", record.VatAmtBc2);
            record.Notes = this.MapParameterOut(command, "@PA_MEP_NOTES", record.Notes);
            record.CurrentDate = this.MapParameterOut(command, "@PA_MEP_CURRENT_DATE", record.CurrentDate);
            record.LapseDate = this.MapParameterOut(command, "@PA_MEP_LAPSE_DATE", record.LapseDate);
            record.BatchInvoice = this.MapParameterOut(command, "@PA_MEP_BATCH_INVOICE", record.BatchInvoice);
            record.BasketFl = this.MapParameterOut(command, "@PA_MEP_BASKET_FL", record.BasketFl);
            record.IndemInsurDate = this.MapParameterOut(command, "@PA_MEP_INDEM_INSUR_DATE", record.IndemInsurDate);
            record.ExpBatId = this.MapParameterOut(command, "@PA_MEP_EXP_BAT_ID", record.ExpBatId);
            record.RollbackDate = this.MapParameterOut(command, "@PA_MEP_ROLLBACK_DATE", record.RollbackDate);
            record.StatusInt = this.MapParameterOut(command, "@PA_MEP_STATUS_INT", record.StatusInt);
            record.ShortDated = this.MapParameterOut(command, "@PA_MEP_SHORT_DATED", record.ShortDated);
            record.CartId = this.MapParameterOut(command, "@PA_MEP_CART_ID", record.CartId);
            record.PclnId = this.MapParameterOut(command, "@PA_MEP_PCLN_ID", record.PclnId);
            record.CurrRateBc = this.MapParameterOut(command, "@PA_MEP_CURR_RATE_BC", record.CurrRateBc);
            record.CurrRateBc2 = this.MapParameterOut(command, "@PA_MEP_CURR_RATE_BC2", record.CurrRateBc2);
            record.AppMethod = this.MapParameterOut(command, "@PA_MEP_APP_METHOD", record.AppMethod);
            record.OppId = this.MapParameterOut(command, "@PA_MEP_OPP_ID", record.OppId);
            record.DoNotInvoic = this.MapParameterOut(command, "@PA_MEP_DO_NOT_INVOIC", record.DoNotInvoic);
            record.PoExpirationDate = this.MapParameterOut(command, "@PA_MEP_PO_EXPIRATION_DATE", record.PoExpirationDate);
            record.AccId = this.MapParameterOut(command, "@PA_MEP_ACC_ID", record.AccId);
            record.MembershipName = this.MapParameterOut(command, "@PA_MEP_MEMBERSHIP_NAME", record.MembershipName);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="memId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberPeriodRecord" /> instances that match the specified <paramref name='memId' />.
        /// </returns>
        public IEnumerable<MemberPeriodRecord> FetchAllByMemId(String memId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MemId");
            this.MapParameterIn(command, "@PA_MEP_MEM_ID", memId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberPeriodRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<MemberPeriodRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_MEP_PROD_ID", prodId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invOrgId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberPeriodRecord" /> instances that match the specified <paramref name='invOrgId' />.
        /// </returns>
        public IEnumerable<MemberPeriodRecord> FetchAllByInvOrgId(String invOrgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvOrgId");
            this.MapParameterIn(command, "@PA_MEP_INV_ORG_ID", invOrgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invProleId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberPeriodRecord" /> instances that match the specified <paramref name='invProleId' />.
        /// </returns>
        public IEnumerable<MemberPeriodRecord> FetchAllByInvProleId(String invProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvProleId");
            this.MapParameterIn(command, "@PA_MEP_INV_PROLE_ID", invProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invAddId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberPeriodRecord" /> instances that match the specified <paramref name='invAddId' />.
        /// </returns>
        public IEnumerable<MemberPeriodRecord> FetchAllByInvAddId(String invAddId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvAddId");
            this.MapParameterIn(command, "@PA_MEP_INV_ADD_ID", invAddId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberPeriodRecord" /> instances that match the specified <paramref name='pmId' />.
        /// </returns>
        public IEnumerable<MemberPeriodRecord> FetchAllByPmId(String pmId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PmId");
            this.MapParameterIn(command, "@PA_MEP_PM_ID", pmId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberPeriodRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<MemberPeriodRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_MEP_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberPeriodRecord" /> instances that match the specified <paramref name='accId' />.
        /// </returns>
        public IEnumerable<MemberPeriodRecord> FetchAllByAccId(String accId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AccId");
            this.MapParameterIn(command, "@PA_MEP_ACC_ID", accId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IMemberPeriodRepository.TableName
        {
            get { return this.TableName; }
        }

        void IMemberPeriodRepository.Create(Consensus.Membership.MemberPeriodRecord record)
        {
            this.Create(record);
        }

        void IMemberPeriodRepository.Modify(Consensus.Membership.MemberPeriodRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="memId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="memId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> IMemberPeriodRepository.FetchAllByMemId(System.String memId)
        {
            return this.FetchAllByMemId(memId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> IMemberPeriodRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invOrgId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="invOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> IMemberPeriodRepository.FetchAllByInvOrgId(System.String invOrgId)
        {
            return this.FetchAllByInvOrgId(invOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invProleId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="invProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> IMemberPeriodRepository.FetchAllByInvProleId(System.String invProleId)
        {
            return this.FetchAllByInvProleId(invProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invAddId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="invAddId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> IMemberPeriodRepository.FetchAllByInvAddId(System.String invAddId)
        {
            return this.FetchAllByInvAddId(invAddId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="pmId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> IMemberPeriodRepository.FetchAllByPmId(System.String pmId)
        {
            return this.FetchAllByPmId(pmId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> IMemberPeriodRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberPeriodRecord" /> instances that match the specified <paramref name="accId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberPeriodRecord> IMemberPeriodRepository.FetchAllByAccId(System.String accId)
        {
            return this.FetchAllByAccId(accId);
        }

        #endregion
    }
}
