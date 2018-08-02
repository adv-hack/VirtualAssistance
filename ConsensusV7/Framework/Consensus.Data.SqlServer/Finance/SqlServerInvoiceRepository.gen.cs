using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="InvheaderRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerInvoiceRepository : SqlServerRepository<InvheaderRecord, String>, IInvoiceRepository
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
            get { return "Invheader"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="InvheaderRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_INV_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "InvHeader"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="InvheaderRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="InvheaderRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, InvheaderRecord record)
        {
            record.Id = dataRecord["INV_ID"].ConvertTo<String>();
            record.Lock = dataRecord["INV_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["INV_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["INV_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["INV_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["INV_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["INV_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["INV_RCV_FROM"].ConvertTo<String>();
            record.BookId = dataRecord["INV_BOOK_ID"].ConvertTo<String>();
            record.OrgId = dataRecord["INV_ORG_ID"].ConvertTo<String>();
            record.PersonId = dataRecord["INV_PERSON_ID"].ConvertTo<String>();
            record.SalesmanId = dataRecord["INV_SALESMAN_ID"].ConvertTo<String>();
            record.DelvryRef = dataRecord["INV_DELVRY_REF"].ConvertTo<String>();
            record.Carrier = dataRecord["INV_CARRIER"].ConvertTo<String>();
            record.DelvryDate = dataRecord["INV_DELVRY_DATE"].ConvertTo<DateTime?>();
            record.OrderDate = dataRecord["INV_ORDER_DATE"].ConvertTo<DateTime?>();
            record.CustOrderNo = dataRecord["INV_CUST_ORDER_NO"].ConvertTo<String>();
            record.DelvryAdd = dataRecord["INV_DELVRY_ADD"].ConvertTo<String>();
            record.Ref = dataRecord["INV_REF"].ConvertTo<String>();
            record.Date = dataRecord["INV_DATE"].ConvertTo<DateTime?>();
            record.Status = dataRecord["INV_STATUS"].ConvertTo<Byte?>();
            record.Add = dataRecord["INV_ADD"].ConvertTo<String>();
            record.CreditNteRef = dataRecord["INV_CREDIT_NTE_REF"].ConvertTo<String>();
            record.CreditNteDte = dataRecord["INV_CREDIT_NTE_DTE"].ConvertTo<DateTime?>();
            record.CreditNteSta = dataRecord["INV_CREDIT_NTE_STA"].ConvertTo<Byte?>();
            record.Notes = dataRecord["INV_NOTES"].ConvertTo<String>();
            record.NetTotal = dataRecord["INV_NET_TOTAL"].ConvertTo<Decimal>();
            record.VatTotal = dataRecord["INV_VAT_TOTAL"].ConvertTo<Decimal>();
            record.GrossTotal = dataRecord["INV_GROSS_TOTAL"].ConvertTo<Decimal>();
            record.NetTotalBc = dataRecord["INV_NET_TOTAL_BC"].ConvertTo<Decimal>();
            record.VatTotalBc = dataRecord["INV_VAT_TOTAL_BC"].ConvertTo<Decimal>();
            record.GrossTotalBc = dataRecord["INV_GROSS_TOTAL_BC"].ConvertTo<Decimal>();
            record.CurrencyType = dataRecord["INV_CURRENCY_TYPE"].ConvertTo<String>();
            record.Type = dataRecord["INV_TYPE"].ConvertTo<String>();
            record.AccountType = dataRecord["INV_ACCOUNT_TYPE"].ConvertTo<String>();
            record.InRespectOf = dataRecord["INV_IN_RESPECT_OF"].ConvertTo<String>();
            record.Footer = dataRecord["INV_FOOTER"].ConvertTo<String>();
            record.CreditPercent = dataRecord["INV_CREDIT_PERCENT"].ConvertTo<Double?>();
            record.CourseId = dataRecord["INV_COURSE_ID"].ConvertTo<String>();
            record.CourseName = dataRecord["INV_COURSE_NAME"].ConvertTo<String>();
            record.CorsStrtDte = dataRecord["INV_CORS_STRT_DTE"].ConvertTo<DateTime?>();
            record.CourseEndDte = dataRecord["INV_COURSE_END_DTE"].ConvertTo<DateTime?>();
            record.CorsCostCode = dataRecord["INV_CORS_COST_CODE"].ConvertTo<String>();
            record.BookRef = dataRecord["INV_BOOK_REF"].ConvertTo<String>();
            record.Booker = dataRecord["INV_BOOKER"].ConvertTo<String>();
            record.BookOrgName = dataRecord["INV_BOOK_ORG_NAME"].ConvertTo<String>();
            record.AddMailstring = dataRecord["INV_ADD_MAILSTRING"].ConvertTo<String>();
            record.BkOrgCustAc = dataRecord["INV_BK_ORG_CUST_AC"].ConvertTo<String>();
            record.VenueOrgName = dataRecord["INV_VENUE_ORG_NAME"].ConvertTo<String>();
            record.Penalty = dataRecord["INV_PENALTY"].ConvertTo<Byte?>();
            record.BookOrgRegi = dataRecord["INV_BOOK_ORG_REGI"].ConvertTo<String>();
            record.PrintBooker = dataRecord["INV_PRINT_BOOKER"].ConvertTo<Byte?>();
            record.InvOrgName = dataRecord["INV_INV_ORG_NAME"].ConvertTo<String>();
            record.ExtraNotes = dataRecord["INV_EXTRA_NOTES"].ConvertTo<String>();
            record.BatId = dataRecord["INV_BAT_ID"].ConvertTo<String>();
            record.SalesId = dataRecord["INV_SALES_ID"].ConvertTo<String>();
            record.Text = dataRecord["INV_TEXT"].ConvertTo<String>();
            record.PayDate = dataRecord["INV_PAY_DATE"].ConvertTo<DateTime?>();
            record.PayStatus = dataRecord["INV_PAY_STATUS"].ConvertTo<String>();
            record.ProjId = dataRecord["INV_PROJ_ID"].ConvertTo<String>();
            record.CcardId = dataRecord["INV_CCARD_ID"].ConvertTo<String>();
            record.Recvd = dataRecord["INV_RECVD"].ConvertTo<Double?>();
            record.RecvdBc = dataRecord["INV_RECVD_BC"].ConvertTo<Double?>();
            record.Period = dataRecord["INV_PERIOD"].ConvertTo<String>();
            record.DueDate = dataRecord["INV_DUE_DATE"].ConvertTo<DateTime?>();
            record.UnpaidVal = dataRecord["INV_UNPAID_VAL"].ConvertTo<Decimal>();
            record.UnpaidValBc = dataRecord["INV_UNPAID_VAL_BC"].ConvertTo<Decimal>();
            record.NotesId = dataRecord["INV_NOTES_ID"].ConvertTo<String>();
            record.CrystalRpt = dataRecord["INV_CRYSTAL_RPT"].ConvertTo<String>();
            record.AppBy = dataRecord["INV_APP_BY"].ConvertTo<String>();
            record.AppDate = dataRecord["INV_APP_DATE"].ConvertTo<DateTime?>();
            record.ForAttnOf = dataRecord["INV_FOR_ATTN_OF"].ConvertTo<String>();
            record.Printed = dataRecord["INV_PRINTED"].ConvertTo<Byte?>();
            record.CurrRateBc = dataRecord["INV_CURR_RATE_BC"].ConvertTo<Decimal>();
            record.CurrRateBc2 = dataRecord["INV_CURR_RATE_BC2"].ConvertTo<Decimal>();
            record.SelcoSpId = dataRecord["INV_SELCO_SP_ID"].ConvertTo<String>();
            record.MepId = dataRecord["INV_MEP_ID"].ConvertTo<String>();
            record.LtId = dataRecord["INV_LT_ID"].ConvertTo<String>();
            record.Userchar1 = dataRecord["INV_USERCHAR_1"].ConvertTo<String>();
            record.AccStatus = dataRecord["INV_ACC_STATUS"].ConvertTo<String>();
            record.AccRef = dataRecord["INV_ACC_REF"].ConvertTo<String>();
            record.AccNotes = dataRecord["INV_ACC_NOTES"].ConvertTo<String>();
            record.AccModBy = dataRecord["INV_ACC_MOD_BY"].ConvertTo<String>();
            record.AccModDate = dataRecord["INV_ACC_MOD_DATE"].ConvertTo<DateTime?>();
            record.NetTotalBc2 = dataRecord["INV_NET_TOTAL_BC2"].ConvertTo<Decimal>();
            record.VatTotalBc2 = dataRecord["INV_VAT_TOTAL_BC2"].ConvertTo<Decimal>();
            record.GrossTotalBc2 = dataRecord["INV_GROSS_TOTAL_BC2"].ConvertTo<Decimal>();
            record.UnpaidTotalBc2 = dataRecord["INV_UNPAID_TOTAL_BC2"].ConvertTo<Decimal>();
            record.PrintBatId = dataRecord["INV_PRINT_BAT_ID"].ConvertTo<String>();
            record.PersonPhone = dataRecord["INV_PERSON_PHONE"].ConvertTo<String>();
            record.AccId = dataRecord["INV_ACC_ID"].ConvertTo<String>();
            record.BatError = dataRecord["INV_BAT_ERROR"].ConvertTo<Byte>();
            record.SalesProleId = dataRecord["INV_SALES_PROLE_ID"].ConvertTo<String>();
            record.ProleId = dataRecord["INV_PROLE_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="InvheaderRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, InvheaderRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_INV_ID", record.Id);
            this.MapParameterIn(command, "@PA_INV_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_INV_BOOK_ID", record.BookId);
            this.MapParameterIn(command, "@PA_INV_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_INV_PERSON_ID", record.PersonId);
            this.MapParameterIn(command, "@PA_INV_SALESMAN_ID", record.SalesmanId);
            this.MapParameterIn(command, "@PA_INV_DELVRY_REF", record.DelvryRef);
            this.MapParameterIn(command, "@PA_INV_CARRIER", record.Carrier);
            this.MapParameterIn(command, "@PA_INV_DELVRY_DATE", record.DelvryDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DelvryDate);
            this.MapParameterIn(command, "@PA_INV_ORDER_DATE", record.OrderDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.OrderDate);
            this.MapParameterIn(command, "@PA_INV_CUST_ORDER_NO", record.CustOrderNo);
            this.MapParameterIn(command, "@PA_INV_DELVRY_ADD", record.DelvryAdd);
            this.MapParameterIn(command, "@PA_INV_REF", record.Ref);
            this.MapParameterIn(command, "@PA_INV_DATE", record.Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date);
            this.MapParameterIn(command, "@PA_INV_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_INV_ADD", record.Add);
            this.MapParameterIn(command, "@PA_INV_CREDIT_NTE_REF", record.CreditNteRef);
            this.MapParameterIn(command, "@PA_INV_CREDIT_NTE_DTE", record.CreditNteDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CreditNteDte);
            this.MapParameterIn(command, "@PA_INV_CREDIT_NTE_STA", record.CreditNteSta);
            this.MapParameterIn(command, "@PA_INV_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_INV_NET_TOTAL", record.NetTotal == Decimal.MinValue ? 0M : record.NetTotal);
            this.MapParameterIn(command, "@PA_INV_VAT_TOTAL", record.VatTotal == Decimal.MinValue ? 0M : record.VatTotal);
            this.MapParameterIn(command, "@PA_INV_GROSS_TOTAL", record.GrossTotal == Decimal.MinValue ? 0M : record.GrossTotal);
            this.MapParameterIn(command, "@PA_INV_NET_TOTAL_BC", record.NetTotalBc == Decimal.MinValue ? 0M : record.NetTotalBc);
            this.MapParameterIn(command, "@PA_INV_VAT_TOTAL_BC", record.VatTotalBc == Decimal.MinValue ? 0M : record.VatTotalBc);
            this.MapParameterIn(command, "@PA_INV_GROSS_TOTAL_BC", record.GrossTotalBc == Decimal.MinValue ? 0M : record.GrossTotalBc);
            this.MapParameterIn(command, "@PA_INV_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_INV_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_INV_ACCOUNT_TYPE", record.AccountType);
            this.MapParameterIn(command, "@PA_INV_IN_RESPECT_OF", record.InRespectOf);
            this.MapParameterIn(command, "@PA_INV_FOOTER", record.Footer);
            this.MapParameterIn(command, "@PA_INV_CREDIT_PERCENT", record.CreditPercent == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CreditPercent);
            this.MapParameterIn(command, "@PA_INV_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_INV_COURSE_NAME", record.CourseName);
            this.MapParameterIn(command, "@PA_INV_CORS_STRT_DTE", record.CorsStrtDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CorsStrtDte);
            this.MapParameterIn(command, "@PA_INV_COURSE_END_DTE", record.CourseEndDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CourseEndDte);
            this.MapParameterIn(command, "@PA_INV_CORS_COST_CODE", record.CorsCostCode);
            this.MapParameterIn(command, "@PA_INV_BOOK_REF", record.BookRef);
            this.MapParameterIn(command, "@PA_INV_BOOKER", record.Booker);
            this.MapParameterIn(command, "@PA_INV_BOOK_ORG_NAME", record.BookOrgName);
            this.MapParameterIn(command, "@PA_INV_ADD_MAILSTRING", record.AddMailstring);
            this.MapParameterIn(command, "@PA_INV_BK_ORG_CUST_AC", record.BkOrgCustAc);
            this.MapParameterIn(command, "@PA_INV_VENUE_ORG_NAME", record.VenueOrgName);
            this.MapParameterIn(command, "@PA_INV_PENALTY", record.Penalty);
            this.MapParameterIn(command, "@PA_INV_BOOK_ORG_REGI", record.BookOrgRegi);
            this.MapParameterIn(command, "@PA_INV_PRINT_BOOKER", record.PrintBooker);
            this.MapParameterIn(command, "@PA_INV_INV_ORG_NAME", record.InvOrgName);
            this.MapParameterIn(command, "@PA_INV_EXTRA_NOTES", record.ExtraNotes);
            this.MapParameterIn(command, "@PA_INV_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_INV_SALES_ID", record.SalesId);
            this.MapParameterIn(command, "@PA_INV_TEXT", record.Text);
            this.MapParameterIn(command, "@PA_INV_PAY_DATE", record.PayDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PayDate);
            this.MapParameterIn(command, "@PA_INV_PAY_STATUS", record.PayStatus);
            this.MapParameterIn(command, "@PA_INV_PROJ_ID", record.ProjId);
            this.MapParameterIn(command, "@PA_INV_CCARD_ID", record.CcardId);
            this.MapParameterIn(command, "@PA_INV_RECVD", record.Recvd == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Recvd);
            this.MapParameterIn(command, "@PA_INV_RECVD_BC", record.RecvdBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.RecvdBc);
            this.MapParameterIn(command, "@PA_INV_PERIOD", record.Period);
            this.MapParameterIn(command, "@PA_INV_DUE_DATE", record.DueDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DueDate);
            this.MapParameterIn(command, "@PA_INV_UNPAID_VAL", record.UnpaidVal == Decimal.MinValue ? 0M : record.UnpaidVal);
            this.MapParameterIn(command, "@PA_INV_UNPAID_VAL_BC", record.UnpaidValBc == Decimal.MinValue ? 0M : record.UnpaidValBc);
            this.MapParameterIn(command, "@PA_INV_NOTES_ID", record.NotesId);
            this.MapParameterIn(command, "@PA_INV_CRYSTAL_RPT", record.CrystalRpt);
            this.MapParameterIn(command, "@PA_INV_APP_BY", record.AppBy);
            this.MapParameterIn(command, "@PA_INV_APP_DATE", record.AppDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AppDate);
            this.MapParameterIn(command, "@PA_INV_FOR_ATTN_OF", record.ForAttnOf);
            this.MapParameterIn(command, "@PA_INV_PRINTED", record.Printed);
            this.MapParameterIn(command, "@PA_INV_CURR_RATE_BC", record.CurrRateBc == Decimal.MinValue ? 0M : record.CurrRateBc);
            this.MapParameterIn(command, "@PA_INV_CURR_RATE_BC2", record.CurrRateBc2 == Decimal.MinValue ? 0M : record.CurrRateBc2);
            this.MapParameterIn(command, "@PA_INV_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_INV_MEP_ID", record.MepId);
            this.MapParameterIn(command, "@PA_INV_LT_ID", record.LtId);
            this.MapParameterIn(command, "@PA_INV_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_INV_ACC_STATUS", record.AccStatus);
            this.MapParameterIn(command, "@PA_INV_ACC_REF", record.AccRef);
            this.MapParameterIn(command, "@PA_INV_ACC_NOTES", record.AccNotes);
            this.MapParameterIn(command, "@PA_INV_ACC_MOD_BY", record.AccModBy);
            this.MapParameterIn(command, "@PA_INV_ACC_MOD_DATE", record.AccModDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AccModDate);
            this.MapParameterIn(command, "@PA_INV_NET_TOTAL_BC2", record.NetTotalBc2 == Decimal.MinValue ? 0M : record.NetTotalBc2);
            this.MapParameterIn(command, "@PA_INV_VAT_TOTAL_BC2", record.VatTotalBc2 == Decimal.MinValue ? 0M : record.VatTotalBc2);
            this.MapParameterIn(command, "@PA_INV_GROSS_TOTAL_BC2", record.GrossTotalBc2 == Decimal.MinValue ? 0M : record.GrossTotalBc2);
            this.MapParameterIn(command, "@PA_INV_UNPAID_TOTAL_BC2", record.UnpaidTotalBc2 == Decimal.MinValue ? 0M : record.UnpaidTotalBc2);
            this.MapParameterIn(command, "@PA_INV_PRINT_BAT_ID", record.PrintBatId);
            this.MapParameterIn(command, "@PA_INV_PERSON_PHONE", record.PersonPhone);
            this.MapParameterIn(command, "@PA_INV_ACC_ID", record.AccId);
            this.MapParameterIn(command, "@PA_INV_BAT_ERROR", record.BatError);
            this.MapParameterIn(command, "@PA_INV_SALES_PROLE_ID", record.SalesProleId);
            this.MapParameterIn(command, "@PA_INV_PROLE_ID", record.ProleId);
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
        ///     The <see cref="InvheaderRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, InvheaderRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_INV_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_INV_LOCK", record.Lock);
            record.BookId = this.MapParameterOut(command, "@PA_INV_BOOK_ID", record.BookId);
            record.OrgId = this.MapParameterOut(command, "@PA_INV_ORG_ID", record.OrgId);
            record.PersonId = this.MapParameterOut(command, "@PA_INV_PERSON_ID", record.PersonId);
            record.SalesmanId = this.MapParameterOut(command, "@PA_INV_SALESMAN_ID", record.SalesmanId);
            record.DelvryRef = this.MapParameterOut(command, "@PA_INV_DELVRY_REF", record.DelvryRef);
            record.Carrier = this.MapParameterOut(command, "@PA_INV_CARRIER", record.Carrier);
            record.DelvryDate = this.MapParameterOut(command, "@PA_INV_DELVRY_DATE", record.DelvryDate);
            record.OrderDate = this.MapParameterOut(command, "@PA_INV_ORDER_DATE", record.OrderDate);
            record.CustOrderNo = this.MapParameterOut(command, "@PA_INV_CUST_ORDER_NO", record.CustOrderNo);
            record.DelvryAdd = this.MapParameterOut(command, "@PA_INV_DELVRY_ADD", record.DelvryAdd);
            record.Ref = this.MapParameterOut(command, "@PA_INV_REF", record.Ref);
            record.Date = this.MapParameterOut(command, "@PA_INV_DATE", record.Date);
            record.Status = this.MapParameterOut(command, "@PA_INV_STATUS", record.Status);
            record.Add = this.MapParameterOut(command, "@PA_INV_ADD", record.Add);
            record.CreditNteRef = this.MapParameterOut(command, "@PA_INV_CREDIT_NTE_REF", record.CreditNteRef);
            record.CreditNteDte = this.MapParameterOut(command, "@PA_INV_CREDIT_NTE_DTE", record.CreditNteDte);
            record.CreditNteSta = this.MapParameterOut(command, "@PA_INV_CREDIT_NTE_STA", record.CreditNteSta);
            record.Notes = this.MapParameterOut(command, "@PA_INV_NOTES", record.Notes);
            record.NetTotal = this.MapParameterOut(command, "@PA_INV_NET_TOTAL", record.NetTotal);
            record.VatTotal = this.MapParameterOut(command, "@PA_INV_VAT_TOTAL", record.VatTotal);
            record.GrossTotal = this.MapParameterOut(command, "@PA_INV_GROSS_TOTAL", record.GrossTotal);
            record.NetTotalBc = this.MapParameterOut(command, "@PA_INV_NET_TOTAL_BC", record.NetTotalBc);
            record.VatTotalBc = this.MapParameterOut(command, "@PA_INV_VAT_TOTAL_BC", record.VatTotalBc);
            record.GrossTotalBc = this.MapParameterOut(command, "@PA_INV_GROSS_TOTAL_BC", record.GrossTotalBc);
            record.CurrencyType = this.MapParameterOut(command, "@PA_INV_CURRENCY_TYPE", record.CurrencyType);
            record.Type = this.MapParameterOut(command, "@PA_INV_TYPE", record.Type);
            record.AccountType = this.MapParameterOut(command, "@PA_INV_ACCOUNT_TYPE", record.AccountType);
            record.InRespectOf = this.MapParameterOut(command, "@PA_INV_IN_RESPECT_OF", record.InRespectOf);
            record.Footer = this.MapParameterOut(command, "@PA_INV_FOOTER", record.Footer);
            record.CreditPercent = this.MapParameterOut(command, "@PA_INV_CREDIT_PERCENT", record.CreditPercent);
            record.CourseId = this.MapParameterOut(command, "@PA_INV_COURSE_ID", record.CourseId);
            record.CourseName = this.MapParameterOut(command, "@PA_INV_COURSE_NAME", record.CourseName);
            record.CorsStrtDte = this.MapParameterOut(command, "@PA_INV_CORS_STRT_DTE", record.CorsStrtDte);
            record.CourseEndDte = this.MapParameterOut(command, "@PA_INV_COURSE_END_DTE", record.CourseEndDte);
            record.CorsCostCode = this.MapParameterOut(command, "@PA_INV_CORS_COST_CODE", record.CorsCostCode);
            record.BookRef = this.MapParameterOut(command, "@PA_INV_BOOK_REF", record.BookRef);
            record.Booker = this.MapParameterOut(command, "@PA_INV_BOOKER", record.Booker);
            record.BookOrgName = this.MapParameterOut(command, "@PA_INV_BOOK_ORG_NAME", record.BookOrgName);
            record.AddMailstring = this.MapParameterOut(command, "@PA_INV_ADD_MAILSTRING", record.AddMailstring);
            record.BkOrgCustAc = this.MapParameterOut(command, "@PA_INV_BK_ORG_CUST_AC", record.BkOrgCustAc);
            record.VenueOrgName = this.MapParameterOut(command, "@PA_INV_VENUE_ORG_NAME", record.VenueOrgName);
            record.Penalty = this.MapParameterOut(command, "@PA_INV_PENALTY", record.Penalty);
            record.BookOrgRegi = this.MapParameterOut(command, "@PA_INV_BOOK_ORG_REGI", record.BookOrgRegi);
            record.PrintBooker = this.MapParameterOut(command, "@PA_INV_PRINT_BOOKER", record.PrintBooker);
            record.InvOrgName = this.MapParameterOut(command, "@PA_INV_INV_ORG_NAME", record.InvOrgName);
            record.ExtraNotes = this.MapParameterOut(command, "@PA_INV_EXTRA_NOTES", record.ExtraNotes);
            record.BatId = this.MapParameterOut(command, "@PA_INV_BAT_ID", record.BatId);
            record.SalesId = this.MapParameterOut(command, "@PA_INV_SALES_ID", record.SalesId);
            record.Text = this.MapParameterOut(command, "@PA_INV_TEXT", record.Text);
            record.PayDate = this.MapParameterOut(command, "@PA_INV_PAY_DATE", record.PayDate);
            record.PayStatus = this.MapParameterOut(command, "@PA_INV_PAY_STATUS", record.PayStatus);
            record.ProjId = this.MapParameterOut(command, "@PA_INV_PROJ_ID", record.ProjId);
            record.CcardId = this.MapParameterOut(command, "@PA_INV_CCARD_ID", record.CcardId);
            record.Recvd = this.MapParameterOut(command, "@PA_INV_RECVD", record.Recvd);
            record.RecvdBc = this.MapParameterOut(command, "@PA_INV_RECVD_BC", record.RecvdBc);
            record.Period = this.MapParameterOut(command, "@PA_INV_PERIOD", record.Period);
            record.DueDate = this.MapParameterOut(command, "@PA_INV_DUE_DATE", record.DueDate);
            record.UnpaidVal = this.MapParameterOut(command, "@PA_INV_UNPAID_VAL", record.UnpaidVal);
            record.UnpaidValBc = this.MapParameterOut(command, "@PA_INV_UNPAID_VAL_BC", record.UnpaidValBc);
            record.NotesId = this.MapParameterOut(command, "@PA_INV_NOTES_ID", record.NotesId);
            record.CrystalRpt = this.MapParameterOut(command, "@PA_INV_CRYSTAL_RPT", record.CrystalRpt);
            record.AppBy = this.MapParameterOut(command, "@PA_INV_APP_BY", record.AppBy);
            record.AppDate = this.MapParameterOut(command, "@PA_INV_APP_DATE", record.AppDate);
            record.ForAttnOf = this.MapParameterOut(command, "@PA_INV_FOR_ATTN_OF", record.ForAttnOf);
            record.Printed = this.MapParameterOut(command, "@PA_INV_PRINTED", record.Printed);
            record.CurrRateBc = this.MapParameterOut(command, "@PA_INV_CURR_RATE_BC", record.CurrRateBc);
            record.CurrRateBc2 = this.MapParameterOut(command, "@PA_INV_CURR_RATE_BC2", record.CurrRateBc2);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_INV_SELCO_SP_ID", record.SelcoSpId);
            record.MepId = this.MapParameterOut(command, "@PA_INV_MEP_ID", record.MepId);
            record.LtId = this.MapParameterOut(command, "@PA_INV_LT_ID", record.LtId);
            record.Userchar1 = this.MapParameterOut(command, "@PA_INV_USERCHAR_1", record.Userchar1);
            record.AccStatus = this.MapParameterOut(command, "@PA_INV_ACC_STATUS", record.AccStatus);
            record.AccRef = this.MapParameterOut(command, "@PA_INV_ACC_REF", record.AccRef);
            record.AccNotes = this.MapParameterOut(command, "@PA_INV_ACC_NOTES", record.AccNotes);
            record.AccModBy = this.MapParameterOut(command, "@PA_INV_ACC_MOD_BY", record.AccModBy);
            record.AccModDate = this.MapParameterOut(command, "@PA_INV_ACC_MOD_DATE", record.AccModDate);
            record.NetTotalBc2 = this.MapParameterOut(command, "@PA_INV_NET_TOTAL_BC2", record.NetTotalBc2);
            record.VatTotalBc2 = this.MapParameterOut(command, "@PA_INV_VAT_TOTAL_BC2", record.VatTotalBc2);
            record.GrossTotalBc2 = this.MapParameterOut(command, "@PA_INV_GROSS_TOTAL_BC2", record.GrossTotalBc2);
            record.UnpaidTotalBc2 = this.MapParameterOut(command, "@PA_INV_UNPAID_TOTAL_BC2", record.UnpaidTotalBc2);
            record.PrintBatId = this.MapParameterOut(command, "@PA_INV_PRINT_BAT_ID", record.PrintBatId);
            record.PersonPhone = this.MapParameterOut(command, "@PA_INV_PERSON_PHONE", record.PersonPhone);
            record.AccId = this.MapParameterOut(command, "@PA_INV_ACC_ID", record.AccId);
            record.BatError = this.MapParameterOut(command, "@PA_INV_BAT_ERROR", record.BatError);
            record.SalesProleId = this.MapParameterOut(command, "@PA_INV_SALES_PROLE_ID", record.SalesProleId);
            record.ProleId = this.MapParameterOut(command, "@PA_INV_PROLE_ID", record.ProleId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_INV_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllByPersonId(String personId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PersonId");
            this.MapParameterIn(command, "@PA_INV_PERSON_ID", personId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="salesmanId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='salesmanId' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllBySalesmanId(String salesmanId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SalesmanId");
            this.MapParameterIn(command, "@PA_INV_SALESMAN_ID", salesmanId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="add">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='add' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllByAdd(String add)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Add");
            this.MapParameterIn(command, "@PA_INV_ADD", add);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="creditNteRef">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='creditNteRef' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllByCreditNteRef(String creditNteRef)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CreditNteRef");
            this.MapParameterIn(command, "@PA_INV_CREDIT_NTE_REF", creditNteRef);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_INV_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='mepId' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllByMepId(String mepId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MepId");
            this.MapParameterIn(command, "@PA_INV_MEP_ID", mepId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ltId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='ltId' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllByLtId(String ltId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LtId");
            this.MapParameterIn(command, "@PA_INV_LT_ID", ltId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='accId' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllByAccId(String accId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AccId");
            this.MapParameterIn(command, "@PA_INV_ACC_ID", accId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="salesProleId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='salesProleId' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllBySalesProleId(String salesProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SalesProleId");
            this.MapParameterIn(command, "@PA_INV_SALES_PROLE_ID", salesProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvheaderRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<InvheaderRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_INV_PROLE_ID", proleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IInvoiceRepository.TableName
        {
            get { return this.TableName; }
        }

        void IInvoiceRepository.Create(Consensus.Finance.InvheaderRecord record)
        {
            this.Create(record);
        }

        void IInvoiceRepository.Modify(Consensus.Finance.InvheaderRecord record)
        {
            this.Modify(record);
        }

        void IInvoiceRepository.RollbackInvoice(Consensus.Finance.InvheaderRecord record)
        {
            this.RollbackInvoice(record);
        }

        void IInvoiceRepository.CreateInvoice(System.String Id, System.String userLoginId, System.String sellingCompany, System.Int32 booking)
        {
            this.CreateInvoice(Id, userLoginId, sellingCompany, booking);
        }

        void IInvoiceRepository.CreditInvoice(Consensus.Finance.InvheaderRecord record, System.String invId, System.String userloginId)
        {
            this.CreditInvoice(record, invId, userloginId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="salesmanId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="salesmanId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllBySalesmanId(System.String salesmanId)
        {
            return this.FetchAllBySalesmanId(salesmanId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="add">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="add" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllByAdd(System.String add)
        {
            return this.FetchAllByAdd(add);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="creditNteRef">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="creditNteRef" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllByCreditNteRef(System.String creditNteRef)
        {
            return this.FetchAllByCreditNteRef(creditNteRef);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="mepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllByMepId(System.String mepId)
        {
            return this.FetchAllByMepId(mepId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ltId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="ltId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllByLtId(System.String ltId)
        {
            return this.FetchAllByLtId(ltId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="accId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllByAccId(System.String accId)
        {
            return this.FetchAllByAccId(accId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="salesProleId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="salesProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllBySalesProleId(System.String salesProleId)
        {
            return this.FetchAllBySalesProleId(salesProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvheaderRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvheaderRecord> IInvoiceRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        #endregion
    }
}
