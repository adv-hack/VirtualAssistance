using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MemberLocationRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerMemberLocationRepository : SqlServerRepository<MemberLocationRecord, String>, IMemberLocationRepository
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
            get { return "MemberLocation"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="MemberLocationRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_MEL_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Member_location"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="MemberLocationRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="MemberLocationRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, MemberLocationRecord record)
        {
            record.Id = dataRecord["MEL_ID"].ConvertTo<String>();
            record.AddBy = dataRecord["MEL_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["MEL_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["MEL_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["MEL_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["MEL_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["MEL_RCV_DATE"].ConvertTo<DateTime?>();
            record.MemId = dataRecord["MEL_MEM_ID"].ConvertTo<String>();
            record.MepId = dataRecord["MEL_MEP_ID"].ConvertTo<String>();
            record.Start = dataRecord["MEL_START"].ConvertTo<DateTime?>();
            record.End = dataRecord["MEL_END"].ConvertTo<DateTime?>();
            record.Status = dataRecord["MEL_STATUS"].ConvertTo<Int32?>();
            record.Type = dataRecord["MEL_TYPE"].ConvertTo<Int32?>();
            record.Fee = dataRecord["MEL_FEE"].ConvertTo<Decimal>();
            record.FeeBc = dataRecord["MEL_FEE_BC"].ConvertTo<Decimal>();
            record.FeeBc2 = dataRecord["MEL_FEE_BC2"].ConvertTo<Decimal>();
            record.Currency = dataRecord["MEL_CURRENCY"].ConvertTo<String>();
            record.OrgId = dataRecord["MEL_ORG_ID"].ConvertTo<String>();
            record.ProleId = dataRecord["MEL_PROLE_ID"].ConvertTo<String>();
            record.MailAddId = dataRecord["MEL_MAIL_ADD_ID"].ConvertTo<String>();
            record.MailInvId = dataRecord["MEL_MAIL_INV_ID"].ConvertTo<String>();
            record.MailToHome = dataRecord["MEL_MAIL_TO_HOME"].ConvertTo<Byte?>();
            record.RenewLoc = dataRecord["MEL_RENEW_LOC"].ConvertTo<Byte?>();
            record.Principal = dataRecord["MEL_PRINCIPAL"].ConvertTo<Byte?>();
            record.Overseas = dataRecord["MEL_OVERSEAS"].ConvertTo<Byte?>();
            record.Vatcd = dataRecord["MEL_VATCD"].ConvertTo<String>();
            record.Ref = dataRecord["MEL_REF"].ConvertTo<String>();
            record.VatRate = dataRecord["MEL_VAT_RATE"].ConvertTo<Decimal>();
            record.VatAmt = dataRecord["MEL_VAT_AMT"].ConvertTo<Decimal>();
            record.VatAmtBc = dataRecord["MEL_VAT_AMT_BC"].ConvertTo<Decimal>();
            record.VatAmtBc2 = dataRecord["MEL_VAT_AMT_BC2"].ConvertTo<Decimal>();
            record.InvlnId = dataRecord["MEL_INVLN_ID"].ConvertTo<String>();
            record.NoCopies = dataRecord["MEL_NO_COPIES"].ConvertTo<Int32?>();
            record.Invoiced = dataRecord["MEL_INVOICED"].ConvertTo<Byte?>();
            record.Username = dataRecord["MEL_USERNAME"].ConvertTo<String>();
            record.Password = dataRecord["MEL_PASSWORD"].ConvertTo<String>();
            record.SyType = dataRecord["MEL_SY_TYPE"].ConvertTo<Byte>();
            record.ProdId = dataRecord["MEL_PROD_ID"].ConvertTo<String>();
            record.Current = dataRecord["MEL_CURRENT"].ConvertTo<Byte>();
            record.GrossFee = dataRecord["MEL_GROSS_FEE"].ConvertTo<Decimal>();
            record.GrossFeeBc = dataRecord["MEL_GROSS_FEE_BC"].ConvertTo<Decimal>();
            record.GrossFeeBc2 = dataRecord["MEL_GROSS_FEE_BC2"].ConvertTo<Decimal>();
            record.DiscReason = dataRecord["MEL_DISC_REASON"].ConvertTo<String>();
            record.PhoneOverride = dataRecord["MEL_PHONE_OVERRIDE"].ConvertTo<String>();
            record.FaxOverride = dataRecord["MEL_FAX_OVERRIDE"].ConvertTo<String>();
            record.PhoneStdOverride = dataRecord["MEL_PHONE_STD_OVERRIDE"].ConvertTo<String>();
            record.FaxStdOverride = dataRecord["MEL_FAX_STD_OVERRIDE"].ConvertTo<String>();
            record.EmailOverride = dataRecord["MEL_EMAIL_OVERRIDE"].ConvertTo<String>();
            record.Url = dataRecord["MEL_URL"].ConvertTo<String>();
            record.FeeNotProRata = dataRecord["MEL_FEE_NOT_PRO_RATA"].ConvertTo<Decimal>();
            record.WebEnabled = dataRecord["MEL_WEB_ENABLED"].ConvertTo<Byte?>();
            record.FeeExempt = dataRecord["MEL_FEE_EXEMPT"].ConvertTo<Byte>();
            record.CurrentDate = dataRecord["MEL_CURRENT_DATE"].ConvertTo<DateTime?>();
            record.CancelDate = dataRecord["MEL_CANCEL_DATE"].ConvertTo<DateTime?>();
            record.PlId = dataRecord["MEL_PL_ID"].ConvertTo<String>();
            record.DiscId = dataRecord["MEL_DISC_ID"].ConvertTo<Int32?>();
            record.Discount = dataRecord["MEL_DISCOUNT"].ConvertTo<Decimal?>();
            record.DiscountBc = dataRecord["MEL_DISCOUNT_BC"].ConvertTo<Decimal?>();
            record.DiscountBc2 = dataRecord["MEL_DISCOUNT_BC2"].ConvertTo<Decimal?>();
            record.DiscAppliedDate = dataRecord["MEL_DISC_APPLIED_DATE"].ConvertTo<DateTime?>();
            record.FeeCalculated = dataRecord["MEL_FEE_CALCULATED"].ConvertTo<Byte?>();
            record.ListPrice = dataRecord["MEL_LIST_PRICE"].ConvertTo<Decimal?>();
            record.ListPriceBc = dataRecord["MEL_LIST_PRICE_BC"].ConvertTo<Decimal?>();
            record.ListPriceBc2 = dataRecord["MEL_LIST_PRICE_BC2"].ConvertTo<Decimal?>();
            record.DespatchDate = dataRecord["MEL_DESPATCH_DATE"].ConvertTo<DateTime?>();
            record.PoNumber = dataRecord["MEL_PO_NUMBER"].ConvertTo<String>();
            record.Qty = dataRecord["MEL_QTY"].ConvertTo<Int32?>();
            record.DoNotRenew = dataRecord["MEL_DO_NOT_RENEW"].ConvertTo<Byte?>();
            record.CancelReason = dataRecord["MEL_CANCEL_REASON"].ConvertTo<String>();
            record.UntPrice = dataRecord["MEL_UNT_PRICE"].ConvertTo<Decimal?>();
            record.UntPriceBc = dataRecord["MEL_UNT_PRICE_BC"].ConvertTo<Decimal?>();
            record.UntPriceBc2 = dataRecord["MEL_UNT_PRICE_BC2"].ConvertTo<Decimal?>();
            record.DiscRenewal = dataRecord["MEL_DISC_RENEWAL"].ConvertTo<DateTime?>();
            record.PriceModified = dataRecord["MEL_PRICE_MODIFIED"].ConvertTo<Byte>();
            record.DiscPercent = dataRecord["MEL_DISC_PERCENT"].ConvertTo<Decimal?>();
            record.RevCode = dataRecord["MEL_REV_CODE"].ConvertTo<String>();
            record.CostCode = dataRecord["MEL_COST_CODE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="MemberLocationRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, MemberLocationRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_MEL_ID", record.Id);
            this.MapParameterIn(command, "@PA_MEL_MEM_ID", record.MemId);
            this.MapParameterIn(command, "@PA_MEL_MEP_ID", record.MepId);
            this.MapParameterIn(command, "@PA_MEL_START", record.Start == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Start);
            this.MapParameterIn(command, "@PA_MEL_END", record.End == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.End);
            this.MapParameterIn(command, "@PA_MEL_STATUS", record.Status == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Status);
            this.MapParameterIn(command, "@PA_MEL_TYPE", record.Type == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Type);
            this.MapParameterIn(command, "@PA_MEL_FEE", record.Fee == Decimal.MinValue ? 0M : record.Fee);
            this.MapParameterIn(command, "@PA_MEL_FEE_BC", record.FeeBc == Decimal.MinValue ? 0M : record.FeeBc);
            this.MapParameterIn(command, "@PA_MEL_FEE_BC2", record.FeeBc2 == Decimal.MinValue ? 0M : record.FeeBc2);
            this.MapParameterIn(command, "@PA_MEL_CURRENCY", record.Currency);
            this.MapParameterIn(command, "@PA_MEL_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_MEL_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_MEL_MAIL_ADD_ID", record.MailAddId);
            this.MapParameterIn(command, "@PA_MEL_MAIL_INV_ID", record.MailInvId);
            this.MapParameterIn(command, "@PA_MEL_MAIL_TO_HOME", record.MailToHome);
            this.MapParameterIn(command, "@PA_MEL_RENEW_LOC", record.RenewLoc);
            this.MapParameterIn(command, "@PA_MEL_PRINCIPAL", record.Principal);
            this.MapParameterIn(command, "@PA_MEL_OVERSEAS", record.Overseas);
            this.MapParameterIn(command, "@PA_MEL_VATCD", record.Vatcd);
            this.MapParameterIn(command, "@PA_MEL_REF", record.Ref);
            this.MapParameterIn(command, "@PA_MEL_VAT_RATE", record.VatRate == Decimal.MinValue ? 0M : record.VatRate);
            this.MapParameterIn(command, "@PA_MEL_VAT_AMT", record.VatAmt == Decimal.MinValue ? 0M : record.VatAmt);
            this.MapParameterIn(command, "@PA_MEL_VAT_AMT_BC", record.VatAmtBc == Decimal.MinValue ? 0M : record.VatAmtBc);
            this.MapParameterIn(command, "@PA_MEL_VAT_AMT_BC2", record.VatAmtBc2 == Decimal.MinValue ? 0M : record.VatAmtBc2);
            this.MapParameterIn(command, "@PA_MEL_INVLN_ID", record.InvlnId);
            this.MapParameterIn(command, "@PA_MEL_NO_COPIES", record.NoCopies == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NoCopies);
            this.MapParameterIn(command, "@PA_MEL_INVOICED", record.Invoiced);
            this.MapParameterIn(command, "@PA_MEL_USERNAME", record.Username);
            this.MapParameterIn(command, "@PA_MEL_PASSWORD", record.Password);
            this.MapParameterIn(command, "@PA_MEL_SY_TYPE", record.SyType);
            this.MapParameterIn(command, "@PA_MEL_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_MEL_CURRENT", record.Current);
            this.MapParameterIn(command, "@PA_MEL_GROSS_FEE", record.GrossFee == Decimal.MinValue ? 0M : record.GrossFee);
            this.MapParameterIn(command, "@PA_MEL_GROSS_FEE_BC", record.GrossFeeBc == Decimal.MinValue ? 0M : record.GrossFeeBc);
            this.MapParameterIn(command, "@PA_MEL_GROSS_FEE_BC2", record.GrossFeeBc2 == Decimal.MinValue ? 0M : record.GrossFeeBc2);
            this.MapParameterIn(command, "@PA_MEL_DISC_REASON", record.DiscReason);
            this.MapParameterIn(command, "@PA_MEL_PHONE_OVERRIDE", record.PhoneOverride);
            this.MapParameterIn(command, "@PA_MEL_FAX_OVERRIDE", record.FaxOverride);
            this.MapParameterIn(command, "@PA_MEL_PHONE_STD_OVERRIDE", record.PhoneStdOverride);
            this.MapParameterIn(command, "@PA_MEL_FAX_STD_OVERRIDE", record.FaxStdOverride);
            this.MapParameterIn(command, "@PA_MEL_EMAIL_OVERRIDE", record.EmailOverride);
            this.MapParameterIn(command, "@PA_MEL_URL", record.Url);
            this.MapParameterIn(command, "@PA_MEL_FEE_NOT_PRO_RATA", record.FeeNotProRata == Decimal.MinValue ? 0M : record.FeeNotProRata);
            this.MapParameterIn(command, "@PA_MEL_WEB_ENABLED", record.WebEnabled);
            this.MapParameterIn(command, "@PA_MEL_FEE_EXEMPT", record.FeeExempt);
            this.MapParameterIn(command, "@PA_MEL_CURRENT_DATE", record.CurrentDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CurrentDate);
            this.MapParameterIn(command, "@PA_MEL_CANCEL_DATE", record.CancelDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CancelDate);
            this.MapParameterIn(command, "@PA_MEL_PL_ID", record.PlId);
            this.MapParameterIn(command, "@PA_MEL_DISC_ID", record.DiscId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DiscId);
            this.MapParameterIn(command, "@PA_MEL_DISCOUNT", record.Discount == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0.00M) : null ) : record.Discount);
            this.MapParameterIn(command, "@PA_MEL_DISCOUNT_BC", record.DiscountBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0.00M) : null ) : record.DiscountBc);
            this.MapParameterIn(command, "@PA_MEL_DISCOUNT_BC2", record.DiscountBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0.00M) : null ) : record.DiscountBc2);
            this.MapParameterIn(command, "@PA_MEL_DISC_APPLIED_DATE", record.DiscAppliedDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DiscAppliedDate);
            this.MapParameterIn(command, "@PA_MEL_FEE_CALCULATED", record.FeeCalculated);
            this.MapParameterIn(command, "@PA_MEL_LIST_PRICE", record.ListPrice == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.ListPrice);
            this.MapParameterIn(command, "@PA_MEL_LIST_PRICE_BC", record.ListPriceBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.ListPriceBc);
            this.MapParameterIn(command, "@PA_MEL_LIST_PRICE_BC2", record.ListPriceBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.ListPriceBc2);
            this.MapParameterIn(command, "@PA_MEL_DESPATCH_DATE", record.DespatchDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DespatchDate);
            this.MapParameterIn(command, "@PA_MEL_PO_NUMBER", record.PoNumber);
            this.MapParameterIn(command, "@PA_MEL_QTY", record.Qty == Int32.MinValue ? ( useV6Logic ? new Int32?(1) : null ) : record.Qty);
            this.MapParameterIn(command, "@PA_MEL_DO_NOT_RENEW", record.DoNotRenew);
            this.MapParameterIn(command, "@PA_MEL_CANCEL_REASON", record.CancelReason);
            this.MapParameterIn(command, "@PA_MEL_UNT_PRICE", record.UntPrice == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UntPrice);
            this.MapParameterIn(command, "@PA_MEL_UNT_PRICE_BC", record.UntPriceBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UntPriceBc);
            this.MapParameterIn(command, "@PA_MEL_UNT_PRICE_BC2", record.UntPriceBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UntPriceBc2);
            this.MapParameterIn(command, "@PA_MEL_DISC_RENEWAL", record.DiscRenewal == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DiscRenewal);
            this.MapParameterIn(command, "@PA_MEL_PRICE_MODIFIED", record.PriceModified);
            this.MapParameterIn(command, "@PA_MEL_DISC_PERCENT", record.DiscPercent == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DiscPercent);
            this.MapParameterIn(command, "@PA_MEL_REV_CODE", record.RevCode);
            this.MapParameterIn(command, "@PA_MEL_COST_CODE", record.CostCode);
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
        ///     The <see cref="MemberLocationRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, MemberLocationRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_MEL_ID", record.Id);
            record.MemId = this.MapParameterOut(command, "@PA_MEL_MEM_ID", record.MemId);
            record.MepId = this.MapParameterOut(command, "@PA_MEL_MEP_ID", record.MepId);
            record.Start = this.MapParameterOut(command, "@PA_MEL_START", record.Start);
            record.End = this.MapParameterOut(command, "@PA_MEL_END", record.End);
            record.Status = this.MapParameterOut(command, "@PA_MEL_STATUS", record.Status);
            record.Type = this.MapParameterOut(command, "@PA_MEL_TYPE", record.Type);
            record.Fee = this.MapParameterOut(command, "@PA_MEL_FEE", record.Fee);
            record.FeeBc = this.MapParameterOut(command, "@PA_MEL_FEE_BC", record.FeeBc);
            record.FeeBc2 = this.MapParameterOut(command, "@PA_MEL_FEE_BC2", record.FeeBc2);
            record.Currency = this.MapParameterOut(command, "@PA_MEL_CURRENCY", record.Currency);
            record.OrgId = this.MapParameterOut(command, "@PA_MEL_ORG_ID", record.OrgId);
            record.ProleId = this.MapParameterOut(command, "@PA_MEL_PROLE_ID", record.ProleId);
            record.MailAddId = this.MapParameterOut(command, "@PA_MEL_MAIL_ADD_ID", record.MailAddId);
            record.MailInvId = this.MapParameterOut(command, "@PA_MEL_MAIL_INV_ID", record.MailInvId);
            record.MailToHome = this.MapParameterOut(command, "@PA_MEL_MAIL_TO_HOME", record.MailToHome);
            record.RenewLoc = this.MapParameterOut(command, "@PA_MEL_RENEW_LOC", record.RenewLoc);
            record.Principal = this.MapParameterOut(command, "@PA_MEL_PRINCIPAL", record.Principal);
            record.Overseas = this.MapParameterOut(command, "@PA_MEL_OVERSEAS", record.Overseas);
            record.Vatcd = this.MapParameterOut(command, "@PA_MEL_VATCD", record.Vatcd);
            record.Ref = this.MapParameterOut(command, "@PA_MEL_REF", record.Ref);
            record.VatRate = this.MapParameterOut(command, "@PA_MEL_VAT_RATE", record.VatRate);
            record.VatAmt = this.MapParameterOut(command, "@PA_MEL_VAT_AMT", record.VatAmt);
            record.VatAmtBc = this.MapParameterOut(command, "@PA_MEL_VAT_AMT_BC", record.VatAmtBc);
            record.VatAmtBc2 = this.MapParameterOut(command, "@PA_MEL_VAT_AMT_BC2", record.VatAmtBc2);
            record.InvlnId = this.MapParameterOut(command, "@PA_MEL_INVLN_ID", record.InvlnId);
            record.NoCopies = this.MapParameterOut(command, "@PA_MEL_NO_COPIES", record.NoCopies);
            record.Invoiced = this.MapParameterOut(command, "@PA_MEL_INVOICED", record.Invoiced);
            record.Username = this.MapParameterOut(command, "@PA_MEL_USERNAME", record.Username);
            record.Password = this.MapParameterOut(command, "@PA_MEL_PASSWORD", record.Password);
            record.SyType = this.MapParameterOut(command, "@PA_MEL_SY_TYPE", record.SyType);
            record.ProdId = this.MapParameterOut(command, "@PA_MEL_PROD_ID", record.ProdId);
            record.Current = this.MapParameterOut(command, "@PA_MEL_CURRENT", record.Current);
            record.GrossFee = this.MapParameterOut(command, "@PA_MEL_GROSS_FEE", record.GrossFee);
            record.GrossFeeBc = this.MapParameterOut(command, "@PA_MEL_GROSS_FEE_BC", record.GrossFeeBc);
            record.GrossFeeBc2 = this.MapParameterOut(command, "@PA_MEL_GROSS_FEE_BC2", record.GrossFeeBc2);
            record.DiscReason = this.MapParameterOut(command, "@PA_MEL_DISC_REASON", record.DiscReason);
            record.PhoneOverride = this.MapParameterOut(command, "@PA_MEL_PHONE_OVERRIDE", record.PhoneOverride);
            record.FaxOverride = this.MapParameterOut(command, "@PA_MEL_FAX_OVERRIDE", record.FaxOverride);
            record.PhoneStdOverride = this.MapParameterOut(command, "@PA_MEL_PHONE_STD_OVERRIDE", record.PhoneStdOverride);
            record.FaxStdOverride = this.MapParameterOut(command, "@PA_MEL_FAX_STD_OVERRIDE", record.FaxStdOverride);
            record.EmailOverride = this.MapParameterOut(command, "@PA_MEL_EMAIL_OVERRIDE", record.EmailOverride);
            record.Url = this.MapParameterOut(command, "@PA_MEL_URL", record.Url);
            record.FeeNotProRata = this.MapParameterOut(command, "@PA_MEL_FEE_NOT_PRO_RATA", record.FeeNotProRata);
            record.WebEnabled = this.MapParameterOut(command, "@PA_MEL_WEB_ENABLED", record.WebEnabled);
            record.FeeExempt = this.MapParameterOut(command, "@PA_MEL_FEE_EXEMPT", record.FeeExempt);
            record.CurrentDate = this.MapParameterOut(command, "@PA_MEL_CURRENT_DATE", record.CurrentDate);
            record.CancelDate = this.MapParameterOut(command, "@PA_MEL_CANCEL_DATE", record.CancelDate);
            record.PlId = this.MapParameterOut(command, "@PA_MEL_PL_ID", record.PlId);
            record.DiscId = this.MapParameterOut(command, "@PA_MEL_DISC_ID", record.DiscId);
            record.Discount = this.MapParameterOut(command, "@PA_MEL_DISCOUNT", record.Discount);
            record.DiscountBc = this.MapParameterOut(command, "@PA_MEL_DISCOUNT_BC", record.DiscountBc);
            record.DiscountBc2 = this.MapParameterOut(command, "@PA_MEL_DISCOUNT_BC2", record.DiscountBc2);
            record.DiscAppliedDate = this.MapParameterOut(command, "@PA_MEL_DISC_APPLIED_DATE", record.DiscAppliedDate);
            record.FeeCalculated = this.MapParameterOut(command, "@PA_MEL_FEE_CALCULATED", record.FeeCalculated);
            record.ListPrice = this.MapParameterOut(command, "@PA_MEL_LIST_PRICE", record.ListPrice);
            record.ListPriceBc = this.MapParameterOut(command, "@PA_MEL_LIST_PRICE_BC", record.ListPriceBc);
            record.ListPriceBc2 = this.MapParameterOut(command, "@PA_MEL_LIST_PRICE_BC2", record.ListPriceBc2);
            record.DespatchDate = this.MapParameterOut(command, "@PA_MEL_DESPATCH_DATE", record.DespatchDate);
            record.PoNumber = this.MapParameterOut(command, "@PA_MEL_PO_NUMBER", record.PoNumber);
            record.Qty = this.MapParameterOut(command, "@PA_MEL_QTY", record.Qty);
            record.DoNotRenew = this.MapParameterOut(command, "@PA_MEL_DO_NOT_RENEW", record.DoNotRenew);
            record.CancelReason = this.MapParameterOut(command, "@PA_MEL_CANCEL_REASON", record.CancelReason);
            record.UntPrice = this.MapParameterOut(command, "@PA_MEL_UNT_PRICE", record.UntPrice);
            record.UntPriceBc = this.MapParameterOut(command, "@PA_MEL_UNT_PRICE_BC", record.UntPriceBc);
            record.UntPriceBc2 = this.MapParameterOut(command, "@PA_MEL_UNT_PRICE_BC2", record.UntPriceBc2);
            record.DiscRenewal = this.MapParameterOut(command, "@PA_MEL_DISC_RENEWAL", record.DiscRenewal);
            record.PriceModified = this.MapParameterOut(command, "@PA_MEL_PRICE_MODIFIED", record.PriceModified);
            record.DiscPercent = this.MapParameterOut(command, "@PA_MEL_DISC_PERCENT", record.DiscPercent);
            record.RevCode = this.MapParameterOut(command, "@PA_MEL_REV_CODE", record.RevCode);
            record.CostCode = this.MapParameterOut(command, "@PA_MEL_COST_CODE", record.CostCode);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="memId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberLocationRecord" /> instances that match the specified <paramref name='memId' />.
        /// </returns>
        public IEnumerable<MemberLocationRecord> FetchAllByMemId(String memId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MemId");
            this.MapParameterIn(command, "@PA_MEL_MEM_ID", memId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberLocationRecord" /> instances that match the specified <paramref name='mepId' />.
        /// </returns>
        public IEnumerable<MemberLocationRecord> FetchAllByMepId(String mepId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MepId");
            this.MapParameterIn(command, "@PA_MEL_MEP_ID", mepId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberLocationRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<MemberLocationRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_MEL_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberLocationRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<MemberLocationRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_MEL_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mailAddId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberLocationRecord" /> instances that match the specified <paramref name='mailAddId' />.
        /// </returns>
        public IEnumerable<MemberLocationRecord> FetchAllByMailAddId(String mailAddId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MailAddId");
            this.MapParameterIn(command, "@PA_MEL_MAIL_ADD_ID", mailAddId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mailInvId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberLocationRecord" /> instances that match the specified <paramref name='mailInvId' />.
        /// </returns>
        public IEnumerable<MemberLocationRecord> FetchAllByMailInvId(String mailInvId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MailInvId");
            this.MapParameterIn(command, "@PA_MEL_MAIL_INV_ID", mailInvId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invlnId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberLocationRecord" /> instances that match the specified <paramref name='invlnId' />.
        /// </returns>
        public IEnumerable<MemberLocationRecord> FetchAllByInvlnId(String invlnId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvlnId");
            this.MapParameterIn(command, "@PA_MEL_INVLN_ID", invlnId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberLocationRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<MemberLocationRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_MEL_PROD_ID", prodId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberLocationRecord" /> instances that match the specified <paramref name='plId' />.
        /// </returns>
        public IEnumerable<MemberLocationRecord> FetchAllByPlId(String plId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PlId");
            this.MapParameterIn(command, "@PA_MEL_PL_ID", plId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IMemberLocationRepository.TableName
        {
            get { return this.TableName; }
        }

        void IMemberLocationRepository.Create(Consensus.Membership.MemberLocationRecord record)
        {
            this.Create(record);
        }

        void IMemberLocationRepository.CreateDiscount(Consensus.Membership.MemberLocationRecord record, System.Decimal feeamount)
        {
            this.CreateDiscount(record, feeamount);
        }

        void IMemberLocationRepository.Modify(Consensus.Membership.MemberLocationRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="memId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="memId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> IMemberLocationRepository.FetchAllByMemId(System.String memId)
        {
            return this.FetchAllByMemId(memId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="mepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> IMemberLocationRepository.FetchAllByMepId(System.String mepId)
        {
            return this.FetchAllByMepId(mepId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> IMemberLocationRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> IMemberLocationRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mailAddId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="mailAddId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> IMemberLocationRepository.FetchAllByMailAddId(System.String mailAddId)
        {
            return this.FetchAllByMailAddId(mailAddId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mailInvId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="mailInvId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> IMemberLocationRepository.FetchAllByMailInvId(System.String mailInvId)
        {
            return this.FetchAllByMailInvId(mailInvId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invlnId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="invlnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> IMemberLocationRepository.FetchAllByInvlnId(System.String invlnId)
        {
            return this.FetchAllByInvlnId(invlnId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> IMemberLocationRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberLocationRecord" /> instances that match the specified <paramref name="plId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberLocationRecord> IMemberLocationRepository.FetchAllByPlId(System.String plId)
        {
            return this.FetchAllByPlId(plId);
        }

        #endregion
    }
}
