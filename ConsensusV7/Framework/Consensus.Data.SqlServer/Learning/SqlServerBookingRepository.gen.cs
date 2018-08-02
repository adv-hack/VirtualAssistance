using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BookingRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerBookingRepository : SqlServerRepository<BookingRecord, String>, IBookingRepository
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
            get { return "Booking"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="BookingRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_BOOK_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Booking"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="BookingRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BookingRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, BookingRecord record)
        {
            record.Id = dataRecord["BOOK_ID"].ConvertTo<String>();
            record.Lock = dataRecord["BOOK_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["BOOK_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["BOOK_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["BOOK_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["BOOK_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["BOOK_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["BOOK_RCV_FROM"].ConvertTo<String>();
            record.OrgId = dataRecord["BOOK_ORG_ID"].ConvertTo<String>();
            record.PersonId = dataRecord["BOOK_PERSON_ID"].ConvertTo<String>();
            record.CourseId = dataRecord["BOOK_COURSE_ID"].ConvertTo<String>();
            record.Salesman = dataRecord["BOOK_SALESMAN"].ConvertTo<String>();
            record.InvId = dataRecord["BOOK_INV_ID"].ConvertTo<String>();
            record.Status = dataRecord["BOOK_STATUS"].ConvertTo<String>();
            record.StatusDate = dataRecord["BOOK_STATUS_DATE"].ConvertTo<DateTime?>();
            record.OrderDate = dataRecord["BOOK_ORDER_DATE"].ConvertTo<DateTime?>();
            record.DlvryDate = dataRecord["BOOK_DLVRY_DATE"].ConvertTo<DateTime?>();
            record.DlvryRef = dataRecord["BOOK_DLVRY_REF"].ConvertTo<String>();
            record.Carrier = dataRecord["BOOK_CARRIER"].ConvertTo<String>();
            record.CustOrdNo = dataRecord["BOOK_CUST_ORD_NO"].ConvertTo<String>();
            record.OrderType = dataRecord["BOOK_ORDER_TYPE"].ConvertTo<String>();
            record.InvStatus = dataRecord["BOOK_INV_STATUS"].ConvertTo<String>();
            record.InvAdd = dataRecord["BOOK_INV_ADD"].ConvertTo<String>();
            record.DlvryAdd = dataRecord["BOOK_DLVRY_ADD"].ConvertTo<String>();
            record.Notes = dataRecord["BOOK_NOTES"].ConvertTo<String>();
            record.NetTotal = dataRecord["BOOK_NET_TOTAL"].ConvertTo<Decimal>();
            record.VatTotal = dataRecord["BOOK_VAT_TOTAL"].ConvertTo<Decimal>();
            record.GrossTotal = dataRecord["BOOK_GROSS_TOTAL"].ConvertTo<Decimal>();
            record.Places = dataRecord["BOOK_PLACES"].ConvertTo<Double?>();
            record.ProvLetter = dataRecord["BOOK_PROV_LETTER"].ConvertTo<DateTime?>();
            record.Confirmed = dataRecord["BOOK_CONFIRMED"].ConvertTo<DateTime?>();
            record.JoinPack = dataRecord["BOOK_JOIN_PACK"].ConvertTo<DateTime?>();
            record.PaidDate = dataRecord["BOOK_PAID_DATE"].ConvertTo<DateTime?>();
            record.UnionId = dataRecord["BOOK_UNION_ID"].ConvertTo<String>();
            record.TucRegion = dataRecord["BOOK_TUC_REGION"].ConvertTo<String>();
            record.Approved = dataRecord["BOOK_APPROVED"].ConvertTo<Byte?>();
            record.ApprovedBy = dataRecord["BOOK_APPROVED_BY"].ConvertTo<String>();
            record.ApproveDate = dataRecord["BOOK_APPROVE_DATE"].ConvertTo<DateTime?>();
            record.TimingFlag = dataRecord["BOOK_TIMING_FLAG"].ConvertTo<Byte?>();
            record.ArchFlag = dataRecord["BOOK_ARCH_FLAG"].ConvertTo<Byte?>();
            record.BookingMethd = dataRecord["BOOK_BOOKING_METHD"].ConvertTo<String>();
            record.PaymentMethd = dataRecord["BOOK_PAYMENT_METHD"].ConvertTo<String>();
            record.SourceCode = dataRecord["BOOK_SOURCE_CODE"].ConvertTo<String>();
            record.NetTotalAdj = dataRecord["BOOK_NET_TOTAL_ADJ"].ConvertTo<Decimal>();
            record.DatePaid = dataRecord["BOOK_DATE_PAID"].ConvertTo<DateTime?>();
            record.TimesMoved = dataRecord["BOOK_TIMES_MOVED"].ConvertTo<Byte?>();
            record.CorsMvdFrom = dataRecord["BOOK_CORS_MVD_FROM"].ConvertTo<String>();
            record.StudentPrice = dataRecord["BOOK_STUDENT_PRICE"].ConvertTo<Decimal>();
            record.AdjustVatcd = dataRecord["BOOK_ADJUST_VATCD"].ConvertTo<String>();
            record.AdjustDescrp = dataRecord["BOOK_ADJUST_DESCRP"].ConvertTo<String>();
            record.ConfSentDte = dataRecord["BOOK_CONF_SENT_DTE"].ConvertTo<DateTime?>();
            record.JoinSentDte = dataRecord["BOOK_JOIN_SENT_DTE"].ConvertTo<DateTime?>();
            record.TimeMvdCust = dataRecord["BOOK_TIME_MVD_CUST"].ConvertTo<Byte?>();
            record.CorsMvdCust = dataRecord["BOOK_CORS_MVD_CUST"].ConvertTo<String>();
            record.ProvSentDte = dataRecord["BOOK_PROV_SENT_DTE"].ConvertTo<DateTime?>();
            record.InvOrgId = dataRecord["BOOK_INV_ORG_ID"].ConvertTo<String>();
            record.InvExtNotes = dataRecord["BOOK_INV_EXT_NOTES"].ConvertTo<String>();
            record.Invoiced = dataRecord["BOOK_INVOICED"].ConvertTo<Byte?>();
            record.ForAttnOf = dataRecord["BOOK_FOR_ATTN_OF"].ConvertTo<String>();
            record.DoNotInvoic = dataRecord["BOOK_DO_NOT_INVOIC"].ConvertTo<Byte?>();
            record.MstcId = dataRecord["BOOK_MSTC_ID"].ConvertTo<String>();
            record.BatId = dataRecord["BOOK_BAT_ID"].ConvertTo<String>();
            record.BatId2 = dataRecord["BOOK_BAT_ID2"].ConvertTo<String>();
            record.BlockPriced = dataRecord["BOOK_BLOCK_PRICED"].ConvertTo<Byte?>();
            record.PlId = dataRecord["BOOK_PL_ID"].ConvertTo<String>();
            record.BlockPrice = dataRecord["BOOK_BLOCK_PRICE"].ConvertTo<Double?>();
            record.IncomCode = dataRecord["BOOK_INCOM_CODE"].ConvertTo<String>();
            record.ExpendCode = dataRecord["BOOK_EXPEND_CODE"].ConvertTo<String>();
            record.ProductGroup = dataRecord["BOOK_PRODUCT_GROUP"].ConvertTo<String>();
            record.Reason = dataRecord["BOOK_REASON"].ConvertTo<String>();
            record.Userchar1 = dataRecord["BOOK_USERCHAR_1"].ConvertTo<String>();
            record.CcardId = dataRecord["BOOK_CCARD_ID"].ConvertTo<String>();
            record.ProvPack = dataRecord["BOOK_PROV_PACK"].ConvertTo<String>();
            record.ConfPack = dataRecord["BOOK_CONF_PACK"].ConvertTo<String>();
            record.JoiningPack = dataRecord["BOOK_JOINING_PACK"].ConvertTo<String>();
            record.PostPack = dataRecord["BOOK_POST_PACK"].ConvertTo<String>();
            record.ProvToBook = dataRecord["BOOK_PROV_TO_BOOK"].ConvertTo<Byte?>();
            record.ProvToDel = dataRecord["BOOK_PROV_TO_DEL"].ConvertTo<Byte?>();
            record.ConfToBook = dataRecord["BOOK_CONF_TO_BOOK"].ConvertTo<Byte?>();
            record.ConfToDel = dataRecord["BOOK_CONF_TO_DEL"].ConvertTo<Byte?>();
            record.JoinToBook = dataRecord["BOOK_JOIN_TO_BOOK"].ConvertTo<Byte?>();
            record.JoinToDel = dataRecord["BOOK_JOIN_TO_DEL"].ConvertTo<Byte?>();
            record.PostToBook = dataRecord["BOOK_POST_TO_BOOK"].ConvertTo<Byte?>();
            record.PostToDel = dataRecord["BOOK_POST_TO_DEL"].ConvertTo<Byte?>();
            record.Paid = dataRecord["BOOK_PAID"].ConvertTo<Byte?>();
            record.ProvInv = dataRecord["BOOK_PROV_INV"].ConvertTo<Byte?>();
            record.ConfInv = dataRecord["BOOK_CONF_INV"].ConvertTo<Byte?>();
            record.JoinInv = dataRecord["BOOK_JOIN_INV"].ConvertTo<Byte?>();
            record.PostInv = dataRecord["BOOK_POST_INV"].ConvertTo<Byte?>();
            record.Period = dataRecord["BOOK_PERIOD"].ConvertTo<String>();
            record.Userchar2 = dataRecord["BOOK_USERCHAR_2"].ConvertTo<String>();
            record.CancelDate = dataRecord["BOOK_CANCEL_DATE"].ConvertTo<DateTime?>();
            record.CancelBy = dataRecord["BOOK_CANCEL_BY"].ConvertTo<String>();
            record.PpSentDte = dataRecord["BOOK_PP_SENT_DTE"].ConvertTo<DateTime?>();
            record.BuId = dataRecord["BOOK_BU_ID"].ConvertTo<String>();
            record.OppId = dataRecord["BOOK_OPP_ID"].ConvertTo<String>();
            record.CrystalInv = dataRecord["BOOK_CRYSTAL_INV"].ConvertTo<String>();
            record.QuoId = dataRecord["BOOK_QUO_ID"].ConvertTo<String>();
            record.DiscMethod = dataRecord["BOOK_DISC_METHOD"].ConvertTo<Byte?>();
            record.DelivAdd = dataRecord["BOOK_DELIV_ADD"].ConvertTo<String>();
            record.DocsMethod = dataRecord["BOOK_DOCS_METHOD"].ConvertTo<String>();
            record.DueDate = dataRecord["BOOK_DUE_DATE"].ConvertTo<DateTime?>();
            record.SalesMan = dataRecord["BOOK_SALES_MAN"].ConvertTo<String>();
            record.SopSentDte = dataRecord["BOOK_SOP_SENT_DTE"].ConvertTo<DateTime?>();
            record.SopStatus = dataRecord["BOOK_SOP_STATUS"].ConvertTo<String>();
            record.SopNotes = dataRecord["BOOK_SOP_NOTES"].ConvertTo<String>();
            record.SopInDte = dataRecord["BOOK_SOP_IN_DTE"].ConvertTo<DateTime?>();
            record.SopRef = dataRecord["BOOK_SOP_REF"].ConvertTo<String>();
            record.SopInvRef = dataRecord["BOOK_SOP_INV_REF"].ConvertTo<String>();
            record.DiscValue = dataRecord["BOOK_DISC_VALUE"].ConvertTo<Byte?>();
            record.PrintLog = dataRecord["BOOK_PRINT_LOG"].ConvertTo<String>();
            record.CancReason = dataRecord["BOOK_CANC_REASON"].ConvertTo<String>();
            record.SopRelDte = dataRecord["BOOK_SOP_REL_DTE"].ConvertTo<DateTime?>();
            record.SopInt1 = dataRecord["BOOK_SOP_INT_1"].ConvertTo<Int32?>();
            record.Userchar3 = dataRecord["BOOK_USERCHAR_3"].ConvertTo<String>();
            record.UserDate1 = dataRecord["BOOK_USER_DATE_1"].ConvertTo<DateTime?>();
            record.UserDate2 = dataRecord["BOOK_USER_DATE_2"].ConvertTo<DateTime?>();
            record.UserDate3 = dataRecord["BOOK_USER_DATE_3"].ConvertTo<DateTime?>();
            record.MultiLang = dataRecord["BOOK_MULTI_LANG"].ConvertTo<Byte?>();
            record.Approver1Id = dataRecord["BOOK_APPROVER1_ID"].ConvertTo<String>();
            record.Approver2Id = dataRecord["BOOK_APPROVER2_ID"].ConvertTo<String>();
            record.Approver3Id = dataRecord["BOOK_APPROVER3_ID"].ConvertTo<String>();
            record.NominatorId = dataRecord["BOOK_NOMINATOR_ID"].ConvertTo<String>();
            record.Approver1Doc = dataRecord["BOOK_APPROVER1_DOC"].ConvertTo<String>();
            record.Approver2Doc = dataRecord["BOOK_APPROVER2_DOC"].ConvertTo<String>();
            record.Approver3Doc = dataRecord["BOOK_APPROVER3_DOC"].ConvertTo<String>();
            record.NominatorDoc = dataRecord["BOOK_NOMINATOR_DOC"].ConvertTo<String>();
            record.EcustId = dataRecord["BOOK_ECUST_ID"].ConvertTo<String>();
            record.Ecust00 = dataRecord["BOOK_ECUST_00"].ConvertTo<String>();
            record.Ecust01 = dataRecord["BOOK_ECUST_01"].ConvertTo<String>();
            record.Ecust02 = dataRecord["BOOK_ECUST_02"].ConvertTo<String>();
            record.Ecust03 = dataRecord["BOOK_ECUST_03"].ConvertTo<String>();
            record.Ecust04 = dataRecord["BOOK_ECUST_04"].ConvertTo<String>();
            record.Ecust05 = dataRecord["BOOK_ECUST_05"].ConvertTo<String>();
            record.Ecust06 = dataRecord["BOOK_ECUST_06"].ConvertTo<String>();
            record.Ecust07 = dataRecord["BOOK_ECUST_07"].ConvertTo<String>();
            record.Ecust08 = dataRecord["BOOK_ECUST_08"].ConvertTo<String>();
            record.Ecust09 = dataRecord["BOOK_ECUST_09"].ConvertTo<String>();
            record.CurrencyType = dataRecord["BOOK_CURRENCY_TYPE"].ConvertTo<String>();
            record.CurrRateBc = dataRecord["BOOK_CURR_RATE_BC"].ConvertTo<Decimal>();
            record.CurrRateBc2 = dataRecord["BOOK_CURR_RATE_BC2"].ConvertTo<Decimal>();
            record.Approver4Id = dataRecord["BOOK_APPROVER4_ID"].ConvertTo<String>();
            record.Reject1Id = dataRecord["BOOK_REJECT1_ID"].ConvertTo<String>();
            record.Reject2Id = dataRecord["BOOK_REJECT2_ID"].ConvertTo<String>();
            record.Reject3Id = dataRecord["BOOK_REJECT3_ID"].ConvertTo<String>();
            record.Reject4Id = dataRecord["BOOK_REJECT4_ID"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["BOOK_SELCO_SP_ID"].ConvertTo<String>();
            record.AddId = dataRecord["BOOK_ADD_ID"].ConvertTo<String>();
            record.Apprej1Email = dataRecord["BOOK_APPREJ1_EMAIL"].ConvertTo<String>();
            record.Apprej2Email = dataRecord["BOOK_APPREJ2_EMAIL"].ConvertTo<String>();
            record.Apprej3Email = dataRecord["BOOK_APPREJ3_EMAIL"].ConvertTo<String>();
            record.Apprej4Email = dataRecord["BOOK_APPREJ4_EMAIL"].ConvertTo<String>();
            record.Apprej1Date = dataRecord["BOOK_APPREJ1_DATE"].ConvertTo<DateTime?>();
            record.Apprej2Date = dataRecord["BOOK_APPREJ2_DATE"].ConvertTo<DateTime?>();
            record.Apprej3Date = dataRecord["BOOK_APPREJ3_DATE"].ConvertTo<DateTime?>();
            record.Apprej4Date = dataRecord["BOOK_APPREJ4_DATE"].ConvertTo<DateTime?>();
            record.ProleId = dataRecord["BOOK_PROLE_ID"].ConvertTo<String>();
            record.VatcdOvrride = dataRecord["BOOK_VATCD_OVRRIDE"].ConvertTo<String>();
            record.OrgCustAc = dataRecord["BOOK_ORG_CUST_AC"].ConvertTo<String>();
            record.UserDate4 = dataRecord["BOOK_USER_DATE_4"].ConvertTo<DateTime?>();
            record.UserDate5 = dataRecord["BOOK_USER_DATE_5"].ConvertTo<DateTime?>();
            record.UserDate6 = dataRecord["BOOK_USER_DATE_6"].ConvertTo<DateTime?>();
            record.Userchar4 = dataRecord["BOOK_USERCHAR_4"].ConvertTo<String>();
            record.Userchar5 = dataRecord["BOOK_USERCHAR_5"].ConvertTo<String>();
            record.Userchar6 = dataRecord["BOOK_USERCHAR_6"].ConvertTo<String>();
            record.UserTint1 = dataRecord["BOOK_USER_TINT_1"].ConvertTo<Byte?>();
            record.UserTint2 = dataRecord["BOOK_USER_TINT_2"].ConvertTo<Byte?>();
            record.UserTint3 = dataRecord["BOOK_USER_TINT_3"].ConvertTo<Byte?>();
            record.UserTint4 = dataRecord["BOOK_USER_TINT_4"].ConvertTo<Byte?>();
            record.UserTint5 = dataRecord["BOOK_USER_TINT_5"].ConvertTo<Byte?>();
            record.UserTint6 = dataRecord["BOOK_USER_TINT_6"].ConvertTo<Byte?>();
            record.DelivFao = dataRecord["BOOK_DELIV_FAO"].ConvertTo<String>();
            record.DelivPhone = dataRecord["BOOK_DELIV_PHONE"].ConvertTo<String>();
            record.InvProleId = dataRecord["BOOK_INV_PROLE_ID"].ConvertTo<String>();
            record.InvType = dataRecord["BOOK_INV_TYPE"].ConvertTo<Byte?>();
            record.ChargeType = dataRecord["BOOK_CHARGE_TYPE"].ConvertTo<String>();
            record.DepositTot = dataRecord["BOOK_DEPOSIT_TOT"].ConvertTo<Decimal?>();
            record.DepositPaid = dataRecord["BOOK_DEPOSIT_PAID"].ConvertTo<Decimal?>();
            record.SchnId = dataRecord["BOOK_SCHN_ID"].ConvertTo<String>();
            record.SyType = dataRecord["BOOK_SY_TYPE"].ConvertTo<Byte?>();
            record.PrjoinSentDte = dataRecord["BOOK_PRJOIN_SENT_DTE"].ConvertTo<DateTime?>();
            record.PojoinSentDte = dataRecord["BOOK_POJOIN_SENT_DTE"].ConvertTo<DateTime?>();
            record.PrejoinPack = dataRecord["BOOK_PREJOIN_PACK"].ConvertTo<String>();
            record.PstjoinPack = dataRecord["BOOK_PSTJOIN_PACK"].ConvertTo<String>();
            record.PrejoinToBook = dataRecord["BOOK_PREJOIN_TO_BOOK"].ConvertTo<Byte?>();
            record.PrejoinToDel = dataRecord["BOOK_PREJOIN_TO_DEL"].ConvertTo<Byte?>();
            record.PstjoinToBook = dataRecord["BOOK_PSTJOIN_TO_BOOK"].ConvertTo<Byte?>();
            record.PstjoinToDel = dataRecord["BOOK_PSTJOIN_TO_DEL"].ConvertTo<Byte?>();
            record.NetTotalBc = dataRecord["BOOK_NET_TOTAL_BC"].ConvertTo<Decimal>();
            record.NetTotalBc2 = dataRecord["BOOK_NET_TOTAL_BC2"].ConvertTo<Decimal>();
            record.TermsAccBy = dataRecord["BOOK_TERMS_ACC_BY"].ConvertTo<String>();
            record.InvoiceRule = dataRecord["BOOK_INVOICE_RULE"].ConvertTo<Byte>();
            record.InvoiceRuleOffset = dataRecord["BOOK_INVOICE_RULE_OFFSET"].ConvertTo<Int16>();
            record.DoNotInvoiceReason = dataRecord["BOOK_DO_NOT_INVOICE_REASON"].ConvertTo<String>();
            record.InvoiceOffsetType = dataRecord["BOOK_INVOICE_OFFSET_TYPE"].ConvertTo<String>();
            record.InvoiceWhenStatus = dataRecord["BOOK_INVOICE_WHEN_STATUS"].ConvertTo<String>();
            record.InvoiceMustUseRule = dataRecord["BOOK_INVOICE_MUST_USE_RULE"].ConvertTo<Byte>();
            record.InvoiceConsolidate = dataRecord["BOOK_INVOICE_CONSOLIDATE"].ConvertTo<Byte>();
            record.InvoiceFormat = dataRecord["BOOK_INVOICE_FORMAT"].ConvertTo<Byte>();
            record.InvoiceFormat0Text = dataRecord["BOOK_INVOICE_FORMAT_0_TEXT"].ConvertTo<String>();
            record.InvoiceFormat1Text = dataRecord["BOOK_INVOICE_FORMAT_1_TEXT"].ConvertTo<String>();
            record.AccId = dataRecord["BOOK_ACC_ID"].ConvertTo<String>();
            record.ResvToDate = dataRecord["BOOK_RESV_TO_DATE"].ConvertTo<DateTime?>();
            record.AgtId = dataRecord["BOOK_AGT_ID"].ConvertTo<Int32?>();
            record.AgtOrgId = dataRecord["BOOK_AGT_ORG_ID"].ConvertTo<String>();
            record.AgtType = dataRecord["BOOK_AGT_TYPE"].ConvertTo<String>();
            record.AgtCommission = dataRecord["BOOK_AGT_COMMISSION"].ConvertTo<Decimal?>();
            record.InvoicePerDel = dataRecord["BOOK_INVOICE_PER_DEL"].ConvertTo<Byte>();
            record.Managed = dataRecord["BOOK_MANAGED"].ConvertTo<Byte?>();
            record.CancelRef = dataRecord["BOOK_CANCEL_REF"].ConvertTo<String>();
            record.InvoicePerPerson = dataRecord["BOOK_INVOICE_PER_PERSON"].ConvertTo<Byte>();
            record.Proforma = dataRecord["BOOK_PROFORMA"].ConvertTo<Byte?>();
            record.CartId = dataRecord["BOOK_CART_ID"].ConvertTo<Int32?>();
            record.PsId = dataRecord["BOOK_PS_ID"].ConvertTo<Int32?>();
            record.PromoCode = dataRecord["BOOK_PROMO_CODE"].ConvertTo<String>();
            record.CustBrInf = dataRecord["BOOK_CUST_BR_INF"].ConvertTo<String>();
            record.ConfSentOfflineDate = dataRecord["BOOK_CONF_SENT_OFFLINE_DATE"].ConvertTo<DateTime?>();
            record.Usernum1 = dataRecord["BOOK_USERNUM_1"].ConvertTo<Decimal?>();
            record.Usernum2 = dataRecord["BOOK_USERNUM_2"].ConvertTo<Decimal?>();
            record.Usernum3 = dataRecord["BOOK_USERNUM_3"].ConvertTo<Decimal?>();
            record.Usernum4 = dataRecord["BOOK_USERNUM_4"].ConvertTo<Decimal?>();
            record.Usernum5 = dataRecord["BOOK_USERNUM_5"].ConvertTo<Decimal?>();
            record.Usernum6 = dataRecord["BOOK_USERNUM_6"].ConvertTo<Decimal?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BookingRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, BookingRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_BOOK_ID", record.Id);
            this.MapParameterIn(command, "@PA_BOOK_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_BOOK_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_BOOK_PERSON_ID", record.PersonId);
            this.MapParameterIn(command, "@PA_BOOK_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_BOOK_SALESMAN", record.Salesman);
            this.MapParameterIn(command, "@PA_BOOK_INV_ID", record.InvId);
            this.MapParameterIn(command, "@PA_BOOK_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_BOOK_STATUS_DATE", record.StatusDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StatusDate);
            this.MapParameterIn(command, "@PA_BOOK_ORDER_DATE", record.OrderDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.OrderDate);
            this.MapParameterIn(command, "@PA_BOOK_DLVRY_DATE", record.DlvryDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DlvryDate);
            this.MapParameterIn(command, "@PA_BOOK_DLVRY_REF", record.DlvryRef);
            this.MapParameterIn(command, "@PA_BOOK_CARRIER", record.Carrier);
            this.MapParameterIn(command, "@PA_BOOK_CUST_ORD_NO", record.CustOrdNo);
            this.MapParameterIn(command, "@PA_BOOK_ORDER_TYPE", record.OrderType);
            this.MapParameterIn(command, "@PA_BOOK_INV_STATUS", record.InvStatus);
            this.MapParameterIn(command, "@PA_BOOK_INV_ADD", record.InvAdd);
            this.MapParameterIn(command, "@PA_BOOK_DLVRY_ADD", record.DlvryAdd);
            this.MapParameterIn(command, "@PA_BOOK_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_BOOK_NET_TOTAL", record.NetTotal == Decimal.MinValue ? 0M : record.NetTotal);
            this.MapParameterIn(command, "@PA_BOOK_VAT_TOTAL", record.VatTotal == Decimal.MinValue ? 0M : record.VatTotal);
            this.MapParameterIn(command, "@PA_BOOK_GROSS_TOTAL", record.GrossTotal == Decimal.MinValue ? 0M : record.GrossTotal);
            this.MapParameterIn(command, "@PA_BOOK_PLACES", record.Places == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Places);
            this.MapParameterIn(command, "@PA_BOOK_PROV_LETTER", record.ProvLetter == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ProvLetter);
            this.MapParameterIn(command, "@PA_BOOK_CONFIRMED", record.Confirmed == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Confirmed);
            this.MapParameterIn(command, "@PA_BOOK_JOIN_PACK", record.JoinPack == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.JoinPack);
            this.MapParameterIn(command, "@PA_BOOK_PAID_DATE", record.PaidDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PaidDate);
            this.MapParameterIn(command, "@PA_BOOK_UNION_ID", record.UnionId);
            this.MapParameterIn(command, "@PA_BOOK_TUC_REGION", record.TucRegion);
            this.MapParameterIn(command, "@PA_BOOK_APPROVED", record.Approved);
            this.MapParameterIn(command, "@PA_BOOK_APPROVED_BY", record.ApprovedBy);
            this.MapParameterIn(command, "@PA_BOOK_APPROVE_DATE", record.ApproveDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ApproveDate);
            this.MapParameterIn(command, "@PA_BOOK_TIMING_FLAG", record.TimingFlag);
            this.MapParameterIn(command, "@PA_BOOK_ARCH_FLAG", record.ArchFlag);
            this.MapParameterIn(command, "@PA_BOOK_BOOKING_METHD", record.BookingMethd);
            this.MapParameterIn(command, "@PA_BOOK_PAYMENT_METHD", record.PaymentMethd);
            this.MapParameterIn(command, "@PA_BOOK_SOURCE_CODE", record.SourceCode);
            this.MapParameterIn(command, "@PA_BOOK_NET_TOTAL_ADJ", record.NetTotalAdj == Decimal.MinValue ? 0M : record.NetTotalAdj);
            this.MapParameterIn(command, "@PA_BOOK_DATE_PAID", record.DatePaid == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DatePaid);
            this.MapParameterIn(command, "@PA_BOOK_TIMES_MOVED", record.TimesMoved);
            this.MapParameterIn(command, "@PA_BOOK_CORS_MVD_FROM", record.CorsMvdFrom);
            this.MapParameterIn(command, "@PA_BOOK_STUDENT_PRICE", record.StudentPrice == Decimal.MinValue ? 0M : record.StudentPrice);
            this.MapParameterIn(command, "@PA_BOOK_ADJUST_VATCD", record.AdjustVatcd);
            this.MapParameterIn(command, "@PA_BOOK_ADJUST_DESCRP", record.AdjustDescrp);
            this.MapParameterIn(command, "@PA_BOOK_CONF_SENT_DTE", record.ConfSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ConfSentDte);
            this.MapParameterIn(command, "@PA_BOOK_JOIN_SENT_DTE", record.JoinSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.JoinSentDte);
            this.MapParameterIn(command, "@PA_BOOK_TIME_MVD_CUST", record.TimeMvdCust);
            this.MapParameterIn(command, "@PA_BOOK_CORS_MVD_CUST", record.CorsMvdCust);
            this.MapParameterIn(command, "@PA_BOOK_PROV_SENT_DTE", record.ProvSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ProvSentDte);
            this.MapParameterIn(command, "@PA_BOOK_INV_ORG_ID", record.InvOrgId);
            this.MapParameterIn(command, "@PA_BOOK_INV_EXT_NOTES", record.InvExtNotes);
            this.MapParameterIn(command, "@PA_BOOK_INVOICED", record.Invoiced);
            this.MapParameterIn(command, "@PA_BOOK_FOR_ATTN_OF", record.ForAttnOf);
            this.MapParameterIn(command, "@PA_BOOK_DO_NOT_INVOIC", record.DoNotInvoic);
            this.MapParameterIn(command, "@PA_BOOK_MSTC_ID", record.MstcId);
            this.MapParameterIn(command, "@PA_BOOK_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_BOOK_BAT_ID2", record.BatId2);
            this.MapParameterIn(command, "@PA_BOOK_BLOCK_PRICED", record.BlockPriced);
            this.MapParameterIn(command, "@PA_BOOK_PL_ID", record.PlId);
            this.MapParameterIn(command, "@PA_BOOK_BLOCK_PRICE", record.BlockPrice == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BlockPrice);
            this.MapParameterIn(command, "@PA_BOOK_INCOM_CODE", record.IncomCode);
            this.MapParameterIn(command, "@PA_BOOK_EXPEND_CODE", record.ExpendCode);
            this.MapParameterIn(command, "@PA_BOOK_PRODUCT_GROUP", record.ProductGroup);
            this.MapParameterIn(command, "@PA_BOOK_REASON", record.Reason);
            this.MapParameterIn(command, "@PA_BOOK_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_BOOK_CCARD_ID", record.CcardId);
            this.MapParameterIn(command, "@PA_BOOK_PROV_PACK", record.ProvPack);
            this.MapParameterIn(command, "@PA_BOOK_CONF_PACK", record.ConfPack);
            this.MapParameterIn(command, "@PA_BOOK_JOINING_PACK", record.JoiningPack);
            this.MapParameterIn(command, "@PA_BOOK_POST_PACK", record.PostPack);
            this.MapParameterIn(command, "@PA_BOOK_PROV_TO_BOOK", record.ProvToBook);
            this.MapParameterIn(command, "@PA_BOOK_PROV_TO_DEL", record.ProvToDel);
            this.MapParameterIn(command, "@PA_BOOK_CONF_TO_BOOK", record.ConfToBook);
            this.MapParameterIn(command, "@PA_BOOK_CONF_TO_DEL", record.ConfToDel);
            this.MapParameterIn(command, "@PA_BOOK_JOIN_TO_BOOK", record.JoinToBook);
            this.MapParameterIn(command, "@PA_BOOK_JOIN_TO_DEL", record.JoinToDel);
            this.MapParameterIn(command, "@PA_BOOK_POST_TO_BOOK", record.PostToBook);
            this.MapParameterIn(command, "@PA_BOOK_POST_TO_DEL", record.PostToDel);
            this.MapParameterIn(command, "@PA_BOOK_PAID", record.Paid);
            this.MapParameterIn(command, "@PA_BOOK_PROV_INV", record.ProvInv);
            this.MapParameterIn(command, "@PA_BOOK_CONF_INV", record.ConfInv);
            this.MapParameterIn(command, "@PA_BOOK_JOIN_INV", record.JoinInv);
            this.MapParameterIn(command, "@PA_BOOK_POST_INV", record.PostInv);
            this.MapParameterIn(command, "@PA_BOOK_PERIOD", record.Period);
            this.MapParameterIn(command, "@PA_BOOK_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_BOOK_CANCEL_DATE", record.CancelDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CancelDate);
            this.MapParameterIn(command, "@PA_BOOK_CANCEL_BY", record.CancelBy);
            this.MapParameterIn(command, "@PA_BOOK_PP_SENT_DTE", record.PpSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PpSentDte);
            this.MapParameterIn(command, "@PA_BOOK_BU_ID", record.BuId);
            this.MapParameterIn(command, "@PA_BOOK_OPP_ID", record.OppId);
            this.MapParameterIn(command, "@PA_BOOK_CRYSTAL_INV", record.CrystalInv);
            this.MapParameterIn(command, "@PA_BOOK_QUO_ID", record.QuoId);
            this.MapParameterIn(command, "@PA_BOOK_DISC_METHOD", record.DiscMethod);
            this.MapParameterIn(command, "@PA_BOOK_DELIV_ADD", record.DelivAdd);
            this.MapParameterIn(command, "@PA_BOOK_DOCS_METHOD", record.DocsMethod);
            this.MapParameterIn(command, "@PA_BOOK_DUE_DATE", record.DueDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DueDate);
            this.MapParameterIn(command, "@PA_BOOK_SALES_MAN", record.SalesMan);
            this.MapParameterIn(command, "@PA_BOOK_SOP_SENT_DTE", record.SopSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SopSentDte);
            this.MapParameterIn(command, "@PA_BOOK_SOP_STATUS", record.SopStatus);
            this.MapParameterIn(command, "@PA_BOOK_SOP_NOTES", record.SopNotes);
            this.MapParameterIn(command, "@PA_BOOK_SOP_IN_DTE", record.SopInDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SopInDte);
            this.MapParameterIn(command, "@PA_BOOK_SOP_REF", record.SopRef);
            this.MapParameterIn(command, "@PA_BOOK_SOP_INV_REF", record.SopInvRef);
            this.MapParameterIn(command, "@PA_BOOK_DISC_VALUE", record.DiscValue);
            this.MapParameterIn(command, "@PA_BOOK_PRINT_LOG", record.PrintLog);
            this.MapParameterIn(command, "@PA_BOOK_CANC_REASON", record.CancReason);
            this.MapParameterIn(command, "@PA_BOOK_SOP_REL_DTE", record.SopRelDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SopRelDte);
            this.MapParameterIn(command, "@PA_BOOK_SOP_INT_1", record.SopInt1 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SopInt1);
            this.MapParameterIn(command, "@PA_BOOK_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_BOOK_USER_DATE_1", record.UserDate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UserDate1);
            this.MapParameterIn(command, "@PA_BOOK_USER_DATE_2", record.UserDate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UserDate2);
            this.MapParameterIn(command, "@PA_BOOK_USER_DATE_3", record.UserDate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UserDate3);
            this.MapParameterIn(command, "@PA_BOOK_MULTI_LANG", record.MultiLang);
            this.MapParameterIn(command, "@PA_BOOK_APPROVER1_ID", record.Approver1Id);
            this.MapParameterIn(command, "@PA_BOOK_APPROVER2_ID", record.Approver2Id);
            this.MapParameterIn(command, "@PA_BOOK_APPROVER3_ID", record.Approver3Id);
            this.MapParameterIn(command, "@PA_BOOK_NOMINATOR_ID", record.NominatorId);
            this.MapParameterIn(command, "@PA_BOOK_APPROVER1_DOC", record.Approver1Doc);
            this.MapParameterIn(command, "@PA_BOOK_APPROVER2_DOC", record.Approver2Doc);
            this.MapParameterIn(command, "@PA_BOOK_APPROVER3_DOC", record.Approver3Doc);
            this.MapParameterIn(command, "@PA_BOOK_NOMINATOR_DOC", record.NominatorDoc);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_ID", record.EcustId);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_00", record.Ecust00);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_01", record.Ecust01);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_02", record.Ecust02);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_03", record.Ecust03);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_04", record.Ecust04);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_05", record.Ecust05);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_06", record.Ecust06);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_07", record.Ecust07);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_08", record.Ecust08);
            this.MapParameterIn(command, "@PA_BOOK_ECUST_09", record.Ecust09);
            this.MapParameterIn(command, "@PA_BOOK_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_BOOK_CURR_RATE_BC", record.CurrRateBc == Decimal.MinValue ? 0M : record.CurrRateBc);
            this.MapParameterIn(command, "@PA_BOOK_CURR_RATE_BC2", record.CurrRateBc2 == Decimal.MinValue ? 0M : record.CurrRateBc2);
            this.MapParameterIn(command, "@PA_BOOK_APPROVER4_ID", record.Approver4Id);
            this.MapParameterIn(command, "@PA_BOOK_REJECT1_ID", record.Reject1Id);
            this.MapParameterIn(command, "@PA_BOOK_REJECT2_ID", record.Reject2Id);
            this.MapParameterIn(command, "@PA_BOOK_REJECT3_ID", record.Reject3Id);
            this.MapParameterIn(command, "@PA_BOOK_REJECT4_ID", record.Reject4Id);
            this.MapParameterIn(command, "@PA_BOOK_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_BOOK_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_BOOK_APPREJ1_EMAIL", record.Apprej1Email);
            this.MapParameterIn(command, "@PA_BOOK_APPREJ2_EMAIL", record.Apprej2Email);
            this.MapParameterIn(command, "@PA_BOOK_APPREJ3_EMAIL", record.Apprej3Email);
            this.MapParameterIn(command, "@PA_BOOK_APPREJ4_EMAIL", record.Apprej4Email);
            this.MapParameterIn(command, "@PA_BOOK_APPREJ1_DATE", record.Apprej1Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Apprej1Date);
            this.MapParameterIn(command, "@PA_BOOK_APPREJ2_DATE", record.Apprej2Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Apprej2Date);
            this.MapParameterIn(command, "@PA_BOOK_APPREJ3_DATE", record.Apprej3Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Apprej3Date);
            this.MapParameterIn(command, "@PA_BOOK_APPREJ4_DATE", record.Apprej4Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Apprej4Date);
            this.MapParameterIn(command, "@PA_BOOK_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_BOOK_VATCD_OVRRIDE", record.VatcdOvrride);
            this.MapParameterIn(command, "@PA_BOOK_ORG_CUST_AC", record.OrgCustAc);
            this.MapParameterIn(command, "@PA_BOOK_USER_DATE_4", record.UserDate4 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UserDate4);
            this.MapParameterIn(command, "@PA_BOOK_USER_DATE_5", record.UserDate5 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UserDate5);
            this.MapParameterIn(command, "@PA_BOOK_USER_DATE_6", record.UserDate6 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UserDate6);
            this.MapParameterIn(command, "@PA_BOOK_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_BOOK_USERCHAR_5", record.Userchar5);
            this.MapParameterIn(command, "@PA_BOOK_USERCHAR_6", record.Userchar6);
            this.MapParameterIn(command, "@PA_BOOK_USER_TINT_1", record.UserTint1);
            this.MapParameterIn(command, "@PA_BOOK_USER_TINT_2", record.UserTint2);
            this.MapParameterIn(command, "@PA_BOOK_USER_TINT_3", record.UserTint3);
            this.MapParameterIn(command, "@PA_BOOK_USER_TINT_4", record.UserTint4);
            this.MapParameterIn(command, "@PA_BOOK_USER_TINT_5", record.UserTint5);
            this.MapParameterIn(command, "@PA_BOOK_USER_TINT_6", record.UserTint6);
            this.MapParameterIn(command, "@PA_BOOK_DELIV_FAO", record.DelivFao);
            this.MapParameterIn(command, "@PA_BOOK_DELIV_PHONE", record.DelivPhone);
            this.MapParameterIn(command, "@PA_BOOK_INV_PROLE_ID", record.InvProleId);
            this.MapParameterIn(command, "@PA_BOOK_INV_TYPE", record.InvType);
            this.MapParameterIn(command, "@PA_BOOK_CHARGE_TYPE", record.ChargeType);
            this.MapParameterIn(command, "@PA_BOOK_DEPOSIT_TOT", record.DepositTot == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DepositTot);
            this.MapParameterIn(command, "@PA_BOOK_DEPOSIT_PAID", record.DepositPaid == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DepositPaid);
            this.MapParameterIn(command, "@PA_BOOK_SCHN_ID", record.SchnId);
            this.MapParameterIn(command, "@PA_BOOK_SY_TYPE", record.SyType);
            this.MapParameterIn(command, "@PA_BOOK_PRJOIN_SENT_DTE", record.PrjoinSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PrjoinSentDte);
            this.MapParameterIn(command, "@PA_BOOK_POJOIN_SENT_DTE", record.PojoinSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PojoinSentDte);
            this.MapParameterIn(command, "@PA_BOOK_PREJOIN_PACK", record.PrejoinPack);
            this.MapParameterIn(command, "@PA_BOOK_PSTJOIN_PACK", record.PstjoinPack);
            this.MapParameterIn(command, "@PA_BOOK_PREJOIN_TO_BOOK", record.PrejoinToBook);
            this.MapParameterIn(command, "@PA_BOOK_PREJOIN_TO_DEL", record.PrejoinToDel);
            this.MapParameterIn(command, "@PA_BOOK_PSTJOIN_TO_BOOK", record.PstjoinToBook);
            this.MapParameterIn(command, "@PA_BOOK_PSTJOIN_TO_DEL", record.PstjoinToDel);
            this.MapParameterIn(command, "@PA_BOOK_NET_TOTAL_BC", record.NetTotalBc == Decimal.MinValue ? 0M : record.NetTotalBc);
            this.MapParameterIn(command, "@PA_BOOK_NET_TOTAL_BC2", record.NetTotalBc2 == Decimal.MinValue ? 0M : record.NetTotalBc2);
            this.MapParameterIn(command, "@PA_BOOK_TERMS_ACC_BY", record.TermsAccBy);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_RULE", record.InvoiceRule);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_RULE_OFFSET", record.InvoiceRuleOffset == Int16.MinValue ? 0 : record.InvoiceRuleOffset);
            this.MapParameterIn(command, "@PA_BOOK_DO_NOT_INVOICE_REASON", record.DoNotInvoiceReason);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_OFFSET_TYPE", record.InvoiceOffsetType);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_WHEN_STATUS", record.InvoiceWhenStatus);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_MUST_USE_RULE", record.InvoiceMustUseRule);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_CONSOLIDATE", record.InvoiceConsolidate);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_FORMAT", record.InvoiceFormat);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_FORMAT_0_TEXT", record.InvoiceFormat0Text);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_FORMAT_1_TEXT", record.InvoiceFormat1Text);
            this.MapParameterIn(command, "@PA_BOOK_ACC_ID", record.AccId);
            this.MapParameterIn(command, "@PA_BOOK_RESV_TO_DATE", record.ResvToDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ResvToDate);
            this.MapParameterIn(command, "@PA_BOOK_AGT_ID", record.AgtId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.AgtId);
            this.MapParameterIn(command, "@PA_BOOK_AGT_ORG_ID", record.AgtOrgId);
            this.MapParameterIn(command, "@PA_BOOK_AGT_TYPE", record.AgtType);
            this.MapParameterIn(command, "@PA_BOOK_AGT_COMMISSION", record.AgtCommission == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.AgtCommission);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_PER_DEL", record.InvoicePerDel);
            this.MapParameterIn(command, "@PA_BOOK_MANAGED", record.Managed);
            this.MapParameterIn(command, "@PA_BOOK_CANCEL_REF", record.CancelRef);
            this.MapParameterIn(command, "@PA_BOOK_INVOICE_PER_PERSON", record.InvoicePerPerson);
            this.MapParameterIn(command, "@PA_BOOK_PROFORMA", record.Proforma);
            this.MapParameterIn(command, "@PA_BOOK_CART_ID", record.CartId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.CartId);
            this.MapParameterIn(command, "@PA_BOOK_PS_ID", record.PsId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PsId);
            this.MapParameterIn(command, "@PA_BOOK_PROMO_CODE", record.PromoCode);
            this.MapParameterIn(command, "@PA_BOOK_CUST_BR_INF", record.CustBrInf);
            this.MapParameterIn(command, "@PA_BOOK_CONF_SENT_OFFLINE_DATE", record.ConfSentOfflineDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ConfSentOfflineDate);
            this.MapParameterIn(command, "@PA_BOOK_USERNUM_1", record.Usernum1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_BOOK_USERNUM_2", record.Usernum2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_BOOK_USERNUM_3", record.Usernum3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_BOOK_USERNUM_4", record.Usernum4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum4);
            this.MapParameterIn(command, "@PA_BOOK_USERNUM_5", record.Usernum5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum5);
            this.MapParameterIn(command, "@PA_BOOK_USERNUM_6", record.Usernum6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum6);
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
        ///     The <see cref="BookingRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, BookingRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_BOOK_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_BOOK_LOCK", record.Lock);
            record.OrgId = this.MapParameterOut(command, "@PA_BOOK_ORG_ID", record.OrgId);
            record.PersonId = this.MapParameterOut(command, "@PA_BOOK_PERSON_ID", record.PersonId);
            record.CourseId = this.MapParameterOut(command, "@PA_BOOK_COURSE_ID", record.CourseId);
            record.Salesman = this.MapParameterOut(command, "@PA_BOOK_SALESMAN", record.Salesman);
            record.InvId = this.MapParameterOut(command, "@PA_BOOK_INV_ID", record.InvId);
            record.Status = this.MapParameterOut(command, "@PA_BOOK_STATUS", record.Status);
            record.StatusDate = this.MapParameterOut(command, "@PA_BOOK_STATUS_DATE", record.StatusDate);
            record.OrderDate = this.MapParameterOut(command, "@PA_BOOK_ORDER_DATE", record.OrderDate);
            record.DlvryDate = this.MapParameterOut(command, "@PA_BOOK_DLVRY_DATE", record.DlvryDate);
            record.DlvryRef = this.MapParameterOut(command, "@PA_BOOK_DLVRY_REF", record.DlvryRef);
            record.Carrier = this.MapParameterOut(command, "@PA_BOOK_CARRIER", record.Carrier);
            record.CustOrdNo = this.MapParameterOut(command, "@PA_BOOK_CUST_ORD_NO", record.CustOrdNo);
            record.OrderType = this.MapParameterOut(command, "@PA_BOOK_ORDER_TYPE", record.OrderType);
            record.InvStatus = this.MapParameterOut(command, "@PA_BOOK_INV_STATUS", record.InvStatus);
            record.InvAdd = this.MapParameterOut(command, "@PA_BOOK_INV_ADD", record.InvAdd);
            record.DlvryAdd = this.MapParameterOut(command, "@PA_BOOK_DLVRY_ADD", record.DlvryAdd);
            record.Notes = this.MapParameterOut(command, "@PA_BOOK_NOTES", record.Notes);
            record.NetTotal = this.MapParameterOut(command, "@PA_BOOK_NET_TOTAL", record.NetTotal);
            record.VatTotal = this.MapParameterOut(command, "@PA_BOOK_VAT_TOTAL", record.VatTotal);
            record.GrossTotal = this.MapParameterOut(command, "@PA_BOOK_GROSS_TOTAL", record.GrossTotal);
            record.Places = this.MapParameterOut(command, "@PA_BOOK_PLACES", record.Places);
            record.ProvLetter = this.MapParameterOut(command, "@PA_BOOK_PROV_LETTER", record.ProvLetter);
            record.Confirmed = this.MapParameterOut(command, "@PA_BOOK_CONFIRMED", record.Confirmed);
            record.JoinPack = this.MapParameterOut(command, "@PA_BOOK_JOIN_PACK", record.JoinPack);
            record.PaidDate = this.MapParameterOut(command, "@PA_BOOK_PAID_DATE", record.PaidDate);
            record.UnionId = this.MapParameterOut(command, "@PA_BOOK_UNION_ID", record.UnionId);
            record.TucRegion = this.MapParameterOut(command, "@PA_BOOK_TUC_REGION", record.TucRegion);
            record.Approved = this.MapParameterOut(command, "@PA_BOOK_APPROVED", record.Approved);
            record.ApprovedBy = this.MapParameterOut(command, "@PA_BOOK_APPROVED_BY", record.ApprovedBy);
            record.ApproveDate = this.MapParameterOut(command, "@PA_BOOK_APPROVE_DATE", record.ApproveDate);
            record.TimingFlag = this.MapParameterOut(command, "@PA_BOOK_TIMING_FLAG", record.TimingFlag);
            record.ArchFlag = this.MapParameterOut(command, "@PA_BOOK_ARCH_FLAG", record.ArchFlag);
            record.BookingMethd = this.MapParameterOut(command, "@PA_BOOK_BOOKING_METHD", record.BookingMethd);
            record.PaymentMethd = this.MapParameterOut(command, "@PA_BOOK_PAYMENT_METHD", record.PaymentMethd);
            record.SourceCode = this.MapParameterOut(command, "@PA_BOOK_SOURCE_CODE", record.SourceCode);
            record.NetTotalAdj = this.MapParameterOut(command, "@PA_BOOK_NET_TOTAL_ADJ", record.NetTotalAdj);
            record.DatePaid = this.MapParameterOut(command, "@PA_BOOK_DATE_PAID", record.DatePaid);
            record.TimesMoved = this.MapParameterOut(command, "@PA_BOOK_TIMES_MOVED", record.TimesMoved);
            record.CorsMvdFrom = this.MapParameterOut(command, "@PA_BOOK_CORS_MVD_FROM", record.CorsMvdFrom);
            record.StudentPrice = this.MapParameterOut(command, "@PA_BOOK_STUDENT_PRICE", record.StudentPrice);
            record.AdjustVatcd = this.MapParameterOut(command, "@PA_BOOK_ADJUST_VATCD", record.AdjustVatcd);
            record.AdjustDescrp = this.MapParameterOut(command, "@PA_BOOK_ADJUST_DESCRP", record.AdjustDescrp);
            record.ConfSentDte = this.MapParameterOut(command, "@PA_BOOK_CONF_SENT_DTE", record.ConfSentDte);
            record.JoinSentDte = this.MapParameterOut(command, "@PA_BOOK_JOIN_SENT_DTE", record.JoinSentDte);
            record.TimeMvdCust = this.MapParameterOut(command, "@PA_BOOK_TIME_MVD_CUST", record.TimeMvdCust);
            record.CorsMvdCust = this.MapParameterOut(command, "@PA_BOOK_CORS_MVD_CUST", record.CorsMvdCust);
            record.ProvSentDte = this.MapParameterOut(command, "@PA_BOOK_PROV_SENT_DTE", record.ProvSentDte);
            record.InvOrgId = this.MapParameterOut(command, "@PA_BOOK_INV_ORG_ID", record.InvOrgId);
            record.InvExtNotes = this.MapParameterOut(command, "@PA_BOOK_INV_EXT_NOTES", record.InvExtNotes);
            record.Invoiced = this.MapParameterOut(command, "@PA_BOOK_INVOICED", record.Invoiced);
            record.ForAttnOf = this.MapParameterOut(command, "@PA_BOOK_FOR_ATTN_OF", record.ForAttnOf);
            record.DoNotInvoic = this.MapParameterOut(command, "@PA_BOOK_DO_NOT_INVOIC", record.DoNotInvoic);
            record.MstcId = this.MapParameterOut(command, "@PA_BOOK_MSTC_ID", record.MstcId);
            record.BatId = this.MapParameterOut(command, "@PA_BOOK_BAT_ID", record.BatId);
            record.BatId2 = this.MapParameterOut(command, "@PA_BOOK_BAT_ID2", record.BatId2);
            record.BlockPriced = this.MapParameterOut(command, "@PA_BOOK_BLOCK_PRICED", record.BlockPriced);
            record.PlId = this.MapParameterOut(command, "@PA_BOOK_PL_ID", record.PlId);
            record.BlockPrice = this.MapParameterOut(command, "@PA_BOOK_BLOCK_PRICE", record.BlockPrice);
            record.IncomCode = this.MapParameterOut(command, "@PA_BOOK_INCOM_CODE", record.IncomCode);
            record.ExpendCode = this.MapParameterOut(command, "@PA_BOOK_EXPEND_CODE", record.ExpendCode);
            record.ProductGroup = this.MapParameterOut(command, "@PA_BOOK_PRODUCT_GROUP", record.ProductGroup);
            record.Reason = this.MapParameterOut(command, "@PA_BOOK_REASON", record.Reason);
            record.Userchar1 = this.MapParameterOut(command, "@PA_BOOK_USERCHAR_1", record.Userchar1);
            record.CcardId = this.MapParameterOut(command, "@PA_BOOK_CCARD_ID", record.CcardId);
            record.ProvPack = this.MapParameterOut(command, "@PA_BOOK_PROV_PACK", record.ProvPack);
            record.ConfPack = this.MapParameterOut(command, "@PA_BOOK_CONF_PACK", record.ConfPack);
            record.JoiningPack = this.MapParameterOut(command, "@PA_BOOK_JOINING_PACK", record.JoiningPack);
            record.PostPack = this.MapParameterOut(command, "@PA_BOOK_POST_PACK", record.PostPack);
            record.ProvToBook = this.MapParameterOut(command, "@PA_BOOK_PROV_TO_BOOK", record.ProvToBook);
            record.ProvToDel = this.MapParameterOut(command, "@PA_BOOK_PROV_TO_DEL", record.ProvToDel);
            record.ConfToBook = this.MapParameterOut(command, "@PA_BOOK_CONF_TO_BOOK", record.ConfToBook);
            record.ConfToDel = this.MapParameterOut(command, "@PA_BOOK_CONF_TO_DEL", record.ConfToDel);
            record.JoinToBook = this.MapParameterOut(command, "@PA_BOOK_JOIN_TO_BOOK", record.JoinToBook);
            record.JoinToDel = this.MapParameterOut(command, "@PA_BOOK_JOIN_TO_DEL", record.JoinToDel);
            record.PostToBook = this.MapParameterOut(command, "@PA_BOOK_POST_TO_BOOK", record.PostToBook);
            record.PostToDel = this.MapParameterOut(command, "@PA_BOOK_POST_TO_DEL", record.PostToDel);
            record.Paid = this.MapParameterOut(command, "@PA_BOOK_PAID", record.Paid);
            record.ProvInv = this.MapParameterOut(command, "@PA_BOOK_PROV_INV", record.ProvInv);
            record.ConfInv = this.MapParameterOut(command, "@PA_BOOK_CONF_INV", record.ConfInv);
            record.JoinInv = this.MapParameterOut(command, "@PA_BOOK_JOIN_INV", record.JoinInv);
            record.PostInv = this.MapParameterOut(command, "@PA_BOOK_POST_INV", record.PostInv);
            record.Period = this.MapParameterOut(command, "@PA_BOOK_PERIOD", record.Period);
            record.Userchar2 = this.MapParameterOut(command, "@PA_BOOK_USERCHAR_2", record.Userchar2);
            record.CancelDate = this.MapParameterOut(command, "@PA_BOOK_CANCEL_DATE", record.CancelDate);
            record.CancelBy = this.MapParameterOut(command, "@PA_BOOK_CANCEL_BY", record.CancelBy);
            record.PpSentDte = this.MapParameterOut(command, "@PA_BOOK_PP_SENT_DTE", record.PpSentDte);
            record.BuId = this.MapParameterOut(command, "@PA_BOOK_BU_ID", record.BuId);
            record.OppId = this.MapParameterOut(command, "@PA_BOOK_OPP_ID", record.OppId);
            record.CrystalInv = this.MapParameterOut(command, "@PA_BOOK_CRYSTAL_INV", record.CrystalInv);
            record.QuoId = this.MapParameterOut(command, "@PA_BOOK_QUO_ID", record.QuoId);
            record.DiscMethod = this.MapParameterOut(command, "@PA_BOOK_DISC_METHOD", record.DiscMethod);
            record.DelivAdd = this.MapParameterOut(command, "@PA_BOOK_DELIV_ADD", record.DelivAdd);
            record.DocsMethod = this.MapParameterOut(command, "@PA_BOOK_DOCS_METHOD", record.DocsMethod);
            record.DueDate = this.MapParameterOut(command, "@PA_BOOK_DUE_DATE", record.DueDate);
            record.SalesMan = this.MapParameterOut(command, "@PA_BOOK_SALES_MAN", record.SalesMan);
            record.SopSentDte = this.MapParameterOut(command, "@PA_BOOK_SOP_SENT_DTE", record.SopSentDte);
            record.SopStatus = this.MapParameterOut(command, "@PA_BOOK_SOP_STATUS", record.SopStatus);
            record.SopNotes = this.MapParameterOut(command, "@PA_BOOK_SOP_NOTES", record.SopNotes);
            record.SopInDte = this.MapParameterOut(command, "@PA_BOOK_SOP_IN_DTE", record.SopInDte);
            record.SopRef = this.MapParameterOut(command, "@PA_BOOK_SOP_REF", record.SopRef);
            record.SopInvRef = this.MapParameterOut(command, "@PA_BOOK_SOP_INV_REF", record.SopInvRef);
            record.DiscValue = this.MapParameterOut(command, "@PA_BOOK_DISC_VALUE", record.DiscValue);
            record.PrintLog = this.MapParameterOut(command, "@PA_BOOK_PRINT_LOG", record.PrintLog);
            record.CancReason = this.MapParameterOut(command, "@PA_BOOK_CANC_REASON", record.CancReason);
            record.SopRelDte = this.MapParameterOut(command, "@PA_BOOK_SOP_REL_DTE", record.SopRelDte);
            record.SopInt1 = this.MapParameterOut(command, "@PA_BOOK_SOP_INT_1", record.SopInt1);
            record.Userchar3 = this.MapParameterOut(command, "@PA_BOOK_USERCHAR_3", record.Userchar3);
            record.UserDate1 = this.MapParameterOut(command, "@PA_BOOK_USER_DATE_1", record.UserDate1);
            record.UserDate2 = this.MapParameterOut(command, "@PA_BOOK_USER_DATE_2", record.UserDate2);
            record.UserDate3 = this.MapParameterOut(command, "@PA_BOOK_USER_DATE_3", record.UserDate3);
            record.MultiLang = this.MapParameterOut(command, "@PA_BOOK_MULTI_LANG", record.MultiLang);
            record.Approver1Id = this.MapParameterOut(command, "@PA_BOOK_APPROVER1_ID", record.Approver1Id);
            record.Approver2Id = this.MapParameterOut(command, "@PA_BOOK_APPROVER2_ID", record.Approver2Id);
            record.Approver3Id = this.MapParameterOut(command, "@PA_BOOK_APPROVER3_ID", record.Approver3Id);
            record.NominatorId = this.MapParameterOut(command, "@PA_BOOK_NOMINATOR_ID", record.NominatorId);
            record.Approver1Doc = this.MapParameterOut(command, "@PA_BOOK_APPROVER1_DOC", record.Approver1Doc);
            record.Approver2Doc = this.MapParameterOut(command, "@PA_BOOK_APPROVER2_DOC", record.Approver2Doc);
            record.Approver3Doc = this.MapParameterOut(command, "@PA_BOOK_APPROVER3_DOC", record.Approver3Doc);
            record.NominatorDoc = this.MapParameterOut(command, "@PA_BOOK_NOMINATOR_DOC", record.NominatorDoc);
            record.EcustId = this.MapParameterOut(command, "@PA_BOOK_ECUST_ID", record.EcustId);
            record.Ecust00 = this.MapParameterOut(command, "@PA_BOOK_ECUST_00", record.Ecust00);
            record.Ecust01 = this.MapParameterOut(command, "@PA_BOOK_ECUST_01", record.Ecust01);
            record.Ecust02 = this.MapParameterOut(command, "@PA_BOOK_ECUST_02", record.Ecust02);
            record.Ecust03 = this.MapParameterOut(command, "@PA_BOOK_ECUST_03", record.Ecust03);
            record.Ecust04 = this.MapParameterOut(command, "@PA_BOOK_ECUST_04", record.Ecust04);
            record.Ecust05 = this.MapParameterOut(command, "@PA_BOOK_ECUST_05", record.Ecust05);
            record.Ecust06 = this.MapParameterOut(command, "@PA_BOOK_ECUST_06", record.Ecust06);
            record.Ecust07 = this.MapParameterOut(command, "@PA_BOOK_ECUST_07", record.Ecust07);
            record.Ecust08 = this.MapParameterOut(command, "@PA_BOOK_ECUST_08", record.Ecust08);
            record.Ecust09 = this.MapParameterOut(command, "@PA_BOOK_ECUST_09", record.Ecust09);
            record.CurrencyType = this.MapParameterOut(command, "@PA_BOOK_CURRENCY_TYPE", record.CurrencyType);
            record.CurrRateBc = this.MapParameterOut(command, "@PA_BOOK_CURR_RATE_BC", record.CurrRateBc);
            record.CurrRateBc2 = this.MapParameterOut(command, "@PA_BOOK_CURR_RATE_BC2", record.CurrRateBc2);
            record.Approver4Id = this.MapParameterOut(command, "@PA_BOOK_APPROVER4_ID", record.Approver4Id);
            record.Reject1Id = this.MapParameterOut(command, "@PA_BOOK_REJECT1_ID", record.Reject1Id);
            record.Reject2Id = this.MapParameterOut(command, "@PA_BOOK_REJECT2_ID", record.Reject2Id);
            record.Reject3Id = this.MapParameterOut(command, "@PA_BOOK_REJECT3_ID", record.Reject3Id);
            record.Reject4Id = this.MapParameterOut(command, "@PA_BOOK_REJECT4_ID", record.Reject4Id);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_BOOK_SELCO_SP_ID", record.SelcoSpId);
            record.AddId = this.MapParameterOut(command, "@PA_BOOK_ADD_ID", record.AddId);
            record.Apprej1Email = this.MapParameterOut(command, "@PA_BOOK_APPREJ1_EMAIL", record.Apprej1Email);
            record.Apprej2Email = this.MapParameterOut(command, "@PA_BOOK_APPREJ2_EMAIL", record.Apprej2Email);
            record.Apprej3Email = this.MapParameterOut(command, "@PA_BOOK_APPREJ3_EMAIL", record.Apprej3Email);
            record.Apprej4Email = this.MapParameterOut(command, "@PA_BOOK_APPREJ4_EMAIL", record.Apprej4Email);
            record.Apprej1Date = this.MapParameterOut(command, "@PA_BOOK_APPREJ1_DATE", record.Apprej1Date);
            record.Apprej2Date = this.MapParameterOut(command, "@PA_BOOK_APPREJ2_DATE", record.Apprej2Date);
            record.Apprej3Date = this.MapParameterOut(command, "@PA_BOOK_APPREJ3_DATE", record.Apprej3Date);
            record.Apprej4Date = this.MapParameterOut(command, "@PA_BOOK_APPREJ4_DATE", record.Apprej4Date);
            record.ProleId = this.MapParameterOut(command, "@PA_BOOK_PROLE_ID", record.ProleId);
            record.VatcdOvrride = this.MapParameterOut(command, "@PA_BOOK_VATCD_OVRRIDE", record.VatcdOvrride);
            record.OrgCustAc = this.MapParameterOut(command, "@PA_BOOK_ORG_CUST_AC", record.OrgCustAc);
            record.UserDate4 = this.MapParameterOut(command, "@PA_BOOK_USER_DATE_4", record.UserDate4);
            record.UserDate5 = this.MapParameterOut(command, "@PA_BOOK_USER_DATE_5", record.UserDate5);
            record.UserDate6 = this.MapParameterOut(command, "@PA_BOOK_USER_DATE_6", record.UserDate6);
            record.Userchar4 = this.MapParameterOut(command, "@PA_BOOK_USERCHAR_4", record.Userchar4);
            record.Userchar5 = this.MapParameterOut(command, "@PA_BOOK_USERCHAR_5", record.Userchar5);
            record.Userchar6 = this.MapParameterOut(command, "@PA_BOOK_USERCHAR_6", record.Userchar6);
            record.UserTint1 = this.MapParameterOut(command, "@PA_BOOK_USER_TINT_1", record.UserTint1);
            record.UserTint2 = this.MapParameterOut(command, "@PA_BOOK_USER_TINT_2", record.UserTint2);
            record.UserTint3 = this.MapParameterOut(command, "@PA_BOOK_USER_TINT_3", record.UserTint3);
            record.UserTint4 = this.MapParameterOut(command, "@PA_BOOK_USER_TINT_4", record.UserTint4);
            record.UserTint5 = this.MapParameterOut(command, "@PA_BOOK_USER_TINT_5", record.UserTint5);
            record.UserTint6 = this.MapParameterOut(command, "@PA_BOOK_USER_TINT_6", record.UserTint6);
            record.DelivFao = this.MapParameterOut(command, "@PA_BOOK_DELIV_FAO", record.DelivFao);
            record.DelivPhone = this.MapParameterOut(command, "@PA_BOOK_DELIV_PHONE", record.DelivPhone);
            record.InvProleId = this.MapParameterOut(command, "@PA_BOOK_INV_PROLE_ID", record.InvProleId);
            record.InvType = this.MapParameterOut(command, "@PA_BOOK_INV_TYPE", record.InvType);
            record.ChargeType = this.MapParameterOut(command, "@PA_BOOK_CHARGE_TYPE", record.ChargeType);
            record.DepositTot = this.MapParameterOut(command, "@PA_BOOK_DEPOSIT_TOT", record.DepositTot);
            record.DepositPaid = this.MapParameterOut(command, "@PA_BOOK_DEPOSIT_PAID", record.DepositPaid);
            record.SchnId = this.MapParameterOut(command, "@PA_BOOK_SCHN_ID", record.SchnId);
            record.SyType = this.MapParameterOut(command, "@PA_BOOK_SY_TYPE", record.SyType);
            record.PrjoinSentDte = this.MapParameterOut(command, "@PA_BOOK_PRJOIN_SENT_DTE", record.PrjoinSentDte);
            record.PojoinSentDte = this.MapParameterOut(command, "@PA_BOOK_POJOIN_SENT_DTE", record.PojoinSentDte);
            record.PrejoinPack = this.MapParameterOut(command, "@PA_BOOK_PREJOIN_PACK", record.PrejoinPack);
            record.PstjoinPack = this.MapParameterOut(command, "@PA_BOOK_PSTJOIN_PACK", record.PstjoinPack);
            record.PrejoinToBook = this.MapParameterOut(command, "@PA_BOOK_PREJOIN_TO_BOOK", record.PrejoinToBook);
            record.PrejoinToDel = this.MapParameterOut(command, "@PA_BOOK_PREJOIN_TO_DEL", record.PrejoinToDel);
            record.PstjoinToBook = this.MapParameterOut(command, "@PA_BOOK_PSTJOIN_TO_BOOK", record.PstjoinToBook);
            record.PstjoinToDel = this.MapParameterOut(command, "@PA_BOOK_PSTJOIN_TO_DEL", record.PstjoinToDel);
            record.NetTotalBc = this.MapParameterOut(command, "@PA_BOOK_NET_TOTAL_BC", record.NetTotalBc);
            record.NetTotalBc2 = this.MapParameterOut(command, "@PA_BOOK_NET_TOTAL_BC2", record.NetTotalBc2);
            record.TermsAccBy = this.MapParameterOut(command, "@PA_BOOK_TERMS_ACC_BY", record.TermsAccBy);
            record.InvoiceRule = this.MapParameterOut(command, "@PA_BOOK_INVOICE_RULE", record.InvoiceRule);
            record.InvoiceRuleOffset = this.MapParameterOut(command, "@PA_BOOK_INVOICE_RULE_OFFSET", record.InvoiceRuleOffset);
            record.DoNotInvoiceReason = this.MapParameterOut(command, "@PA_BOOK_DO_NOT_INVOICE_REASON", record.DoNotInvoiceReason);
            record.InvoiceOffsetType = this.MapParameterOut(command, "@PA_BOOK_INVOICE_OFFSET_TYPE", record.InvoiceOffsetType);
            record.InvoiceWhenStatus = this.MapParameterOut(command, "@PA_BOOK_INVOICE_WHEN_STATUS", record.InvoiceWhenStatus);
            record.InvoiceMustUseRule = this.MapParameterOut(command, "@PA_BOOK_INVOICE_MUST_USE_RULE", record.InvoiceMustUseRule);
            record.InvoiceConsolidate = this.MapParameterOut(command, "@PA_BOOK_INVOICE_CONSOLIDATE", record.InvoiceConsolidate);
            record.InvoiceFormat = this.MapParameterOut(command, "@PA_BOOK_INVOICE_FORMAT", record.InvoiceFormat);
            record.InvoiceFormat0Text = this.MapParameterOut(command, "@PA_BOOK_INVOICE_FORMAT_0_TEXT", record.InvoiceFormat0Text);
            record.InvoiceFormat1Text = this.MapParameterOut(command, "@PA_BOOK_INVOICE_FORMAT_1_TEXT", record.InvoiceFormat1Text);
            record.AccId = this.MapParameterOut(command, "@PA_BOOK_ACC_ID", record.AccId);
            record.ResvToDate = this.MapParameterOut(command, "@PA_BOOK_RESV_TO_DATE", record.ResvToDate);
            record.AgtId = this.MapParameterOut(command, "@PA_BOOK_AGT_ID", record.AgtId);
            record.AgtOrgId = this.MapParameterOut(command, "@PA_BOOK_AGT_ORG_ID", record.AgtOrgId);
            record.AgtType = this.MapParameterOut(command, "@PA_BOOK_AGT_TYPE", record.AgtType);
            record.AgtCommission = this.MapParameterOut(command, "@PA_BOOK_AGT_COMMISSION", record.AgtCommission);
            record.InvoicePerDel = this.MapParameterOut(command, "@PA_BOOK_INVOICE_PER_DEL", record.InvoicePerDel);
            record.Managed = this.MapParameterOut(command, "@PA_BOOK_MANAGED", record.Managed);
            record.CancelRef = this.MapParameterOut(command, "@PA_BOOK_CANCEL_REF", record.CancelRef);
            record.InvoicePerPerson = this.MapParameterOut(command, "@PA_BOOK_INVOICE_PER_PERSON", record.InvoicePerPerson);
            record.Proforma = this.MapParameterOut(command, "@PA_BOOK_PROFORMA", record.Proforma);
            record.CartId = this.MapParameterOut(command, "@PA_BOOK_CART_ID", record.CartId);
            record.PsId = this.MapParameterOut(command, "@PA_BOOK_PS_ID", record.PsId);
            record.PromoCode = this.MapParameterOut(command, "@PA_BOOK_PROMO_CODE", record.PromoCode);
            record.CustBrInf = this.MapParameterOut(command, "@PA_BOOK_CUST_BR_INF", record.CustBrInf);
            record.ConfSentOfflineDate = this.MapParameterOut(command, "@PA_BOOK_CONF_SENT_OFFLINE_DATE", record.ConfSentOfflineDate);
            record.Usernum1 = this.MapParameterOut(command, "@PA_BOOK_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_BOOK_USERNUM_2", record.Usernum2);
            record.Usernum3 = this.MapParameterOut(command, "@PA_BOOK_USERNUM_3", record.Usernum3);
            record.Usernum4 = this.MapParameterOut(command, "@PA_BOOK_USERNUM_4", record.Usernum4);
            record.Usernum5 = this.MapParameterOut(command, "@PA_BOOK_USERNUM_5", record.Usernum5);
            record.Usernum6 = this.MapParameterOut(command, "@PA_BOOK_USERNUM_6", record.Usernum6);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_BOOK_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByPersonId(String personId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PersonId");
            this.MapParameterIn(command, "@PA_BOOK_PERSON_ID", personId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invAdd">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='invAdd' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByInvAdd(String invAdd)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvAdd");
            this.MapParameterIn(command, "@PA_BOOK_INV_ADD", invAdd);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notes">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='notes' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByNotes(String notes)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Notes");
            this.MapParameterIn(command, "@PA_BOOK_NOTES", notes);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sourceCode">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='sourceCode' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllBySourceCode(String sourceCode)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SourceCode");
            this.MapParameterIn(command, "@PA_BOOK_SOURCE_CODE", sourceCode);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invOrgId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='invOrgId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByInvOrgId(String invOrgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvOrgId");
            this.MapParameterIn(command, "@PA_BOOK_INV_ORG_ID", invOrgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invExtNotes">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='invExtNotes' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByInvExtNotes(String invExtNotes)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvExtNotes");
            this.MapParameterIn(command, "@PA_BOOK_INV_EXT_NOTES", invExtNotes);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='plId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByPlId(String plId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PlId");
            this.MapParameterIn(command, "@PA_BOOK_PL_ID", plId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='oppId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByOppId(String oppId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OppId");
            this.MapParameterIn(command, "@PA_BOOK_OPP_ID", oppId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="delivAdd">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='delivAdd' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByDelivAdd(String delivAdd)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "DelivAdd");
            this.MapParameterIn(command, "@PA_BOOK_DELIV_ADD", delivAdd);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_BOOK_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='addId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByAddId(String addId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AddId");
            this.MapParameterIn(command, "@PA_BOOK_ADD_ID", addId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_BOOK_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invProleId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='invProleId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByInvProleId(String invProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvProleId");
            this.MapParameterIn(command, "@PA_BOOK_INV_PROLE_ID", invProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="schnId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='schnId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllBySchnId(String schnId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SchnId");
            this.MapParameterIn(command, "@PA_BOOK_SCHN_ID", schnId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BookingRecord" /> instances that match the specified <paramref name='accId' />.
        /// </returns>
        public IEnumerable<BookingRecord> FetchAllByAccId(String accId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AccId");
            this.MapParameterIn(command, "@PA_BOOK_ACC_ID", accId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IBookingRepository.TableName
        {
            get { return this.TableName; }
        }

        void IBookingRepository.Create(Consensus.Learning.BookingRecord record)
        {
            this.Create(record);
        }

        void IBookingRepository.Modify(Consensus.Learning.BookingRecord record)
        {
            this.Modify(record);
        }

        Consensus.Learning.BookingRecord IBookingRepository.GetConfirmedEvents(System.String bookId)
        {
            return this.GetConfirmedEvents(bookId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.BookingGenerateGrpId(System.String bookId)
        {
            return this.BookingGenerateGrpId(bookId);
        }

        /// <summary>
        ///     Get Booking Lines if available to Create Invoice.
        /// </summary>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.GetBookingLines(System.String bookId, System.String UserLoginId)
        {
            return this.GetBookingLines(bookId, UserLoginId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invAdd">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="invAdd" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByInvAdd(System.String invAdd)
        {
            return this.FetchAllByInvAdd(invAdd);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notes">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="notes" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByNotes(System.String notes)
        {
            return this.FetchAllByNotes(notes);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sourceCode">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="sourceCode" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllBySourceCode(System.String sourceCode)
        {
            return this.FetchAllBySourceCode(sourceCode);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invOrgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="invOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByInvOrgId(System.String invOrgId)
        {
            return this.FetchAllByInvOrgId(invOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invExtNotes">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="invExtNotes" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByInvExtNotes(System.String invExtNotes)
        {
            return this.FetchAllByInvExtNotes(invExtNotes);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="plId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByPlId(System.String plId)
        {
            return this.FetchAllByPlId(plId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="oppId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByOppId(System.String oppId)
        {
            return this.FetchAllByOppId(oppId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="delivAdd">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="delivAdd" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByDelivAdd(System.String delivAdd)
        {
            return this.FetchAllByDelivAdd(delivAdd);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByAddId(System.String addId)
        {
            return this.FetchAllByAddId(addId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invProleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="invProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByInvProleId(System.String invProleId)
        {
            return this.FetchAllByInvProleId(invProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="schnId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="schnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllBySchnId(System.String schnId)
        {
            return this.FetchAllBySchnId(schnId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BookingRecord" /> instances that match the specified <paramref name="accId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BookingRecord> IBookingRepository.FetchAllByAccId(System.String accId)
        {
            return this.FetchAllByAccId(accId);
        }

        #endregion
    }
}
