using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ElementRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerElementRepository : SqlServerRepository<ElementRecord, String>, IElementRepository
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
            get { return "Element"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ElementRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ELEM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Element"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ElementRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ElementRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ElementRecord record)
        {
            record.Id = dataRecord["ELEM_ID"].ConvertTo<String>();
            record.Lock = dataRecord["ELEM_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["ELEM_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ELEM_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ELEM_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ELEM_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ELEM_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["ELEM_RCV_FROM"].ConvertTo<String>();
            record.DelId = dataRecord["ELEM_DEL_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["ELEM_PROD_ID"].ConvertTo<String>();
            record.ActId = dataRecord["ELEM_ACT_ID"].ConvertTo<String>();
            record.CourseId = dataRecord["ELEM_COURSE_ID"].ConvertTo<String>();
            record.BookId = dataRecord["ELEM_BOOK_ID"].ConvertTo<String>();
            record.WhoPays = dataRecord["ELEM_WHO_PAYS"].ConvertTo<String>();
            record.CertNo = dataRecord["ELEM_CERT_NO"].ConvertTo<String>();
            record.Attended = dataRecord["ELEM_ATTENDED"].ConvertTo<Byte?>();
            record.UserDate1 = dataRecord["ELEM_USER_DATE_1"].ConvertTo<DateTime?>();
            record.UserDate2 = dataRecord["ELEM_USER_DATE_2"].ConvertTo<DateTime?>();
            record.UserDate3 = dataRecord["ELEM_USER_DATE_3"].ConvertTo<DateTime?>();
            record.Userint1 = dataRecord["ELEM_USERINT_1"].ConvertTo<Byte?>();
            record.Userint2 = dataRecord["ELEM_USERINT_2"].ConvertTo<Byte?>();
            record.Usernum1 = dataRecord["ELEM_USERNUM_1"].ConvertTo<Double?>();
            record.Usernum2 = dataRecord["ELEM_USERNUM_2"].ConvertTo<Double?>();
            record.Usernum3 = dataRecord["ELEM_USERNUM_3"].ConvertTo<Double?>();
            record.CurrencyType = dataRecord["ELEM_CURRENCY_TYPE"].ConvertTo<String>();
            record.Price = dataRecord["ELEM_PRICE"].ConvertTo<Decimal>();
            record.BlockPrice = dataRecord["ELEM_BLOCK_PRICE"].ConvertTo<Decimal>();
            record.PriceBc = dataRecord["ELEM_PRICE_BC"].ConvertTo<Decimal>();
            record.BlockPrceBc = dataRecord["ELEM_BLOCK_PRCE_BC"].ConvertTo<Decimal>();
            record.Vatcd = dataRecord["ELEM_VATCD"].ConvertTo<String>();
            record.CostCode = dataRecord["ELEM_COST_CODE"].ConvertTo<String>();
            record.DoNotInvce = dataRecord["ELEM_DO_NOT_INVCE"].ConvertTo<Byte?>();
            record.Invoiced = dataRecord["ELEM_INVOICED"].ConvertTo<Byte?>();
            record.InvoicedDate = dataRecord["ELEM_INVOICED_DATE"].ConvertTo<DateTime?>();
            record.Description = dataRecord["ELEM_DESCRIPTION"].ConvertTo<String>();
            record.RevCode = dataRecord["ELEM_REV_CODE"].ConvertTo<String>();
            record.InvoicePrint = dataRecord["ELEM_INVOICE_PRINT"].ConvertTo<Byte?>();
            record.Cancelled = dataRecord["ELEM_CANCELLED"].ConvertTo<Byte?>();
            record.Notes = dataRecord["ELEM_NOTES"].ConvertTo<String>();
            record.Credited = dataRecord["ELEM_CREDITED"].ConvertTo<Byte?>();
            record.NonAtdRsn = dataRecord["ELEM_NON_ATD_RSN"].ConvertTo<String>();
            record.CertIseDat = dataRecord["ELEM_CERT_ISE_DAT"].ConvertTo<DateTime?>();
            record.CertPrnDat = dataRecord["ELEM_CERT_PRN_DAT"].ConvertTo<DateTime?>();
            record.LcseNo = dataRecord["ELEM_LCSE_NO"].ConvertTo<String>();
            record.LcseIseDat = dataRecord["ELEM_LCSE_ISE_DAT"].ConvertTo<DateTime?>();
            record.LcsePrnDat = dataRecord["ELEM_LCSE_PRN_DAT"].ConvertTo<DateTime?>();
            record.ReqDate = dataRecord["ELEM_REQ_DATE"].ConvertTo<DateTime?>();
            record.Pass = dataRecord["ELEM_PASS"].ConvertTo<Byte?>();
            record.Score = dataRecord["ELEM_SCORE"].ConvertTo<Decimal?>();
            record.Chosen = dataRecord["ELEM_CHOSEN"].ConvertTo<Byte?>();
            record.Type = dataRecord["ELEM_TYPE"].ConvertTo<Byte?>();
            record.Status = dataRecord["ELEM_STATUS"].ConvertTo<Byte?>();
            record.Grade = dataRecord["ELEM_GRADE"].ConvertTo<String>();
            record.PriceBc2 = dataRecord["ELEM_PRICE_BC2"].ConvertTo<Decimal>();
            record.BlkPriceBc2 = dataRecord["ELEM_BLK_PRICE_BC2"].ConvertTo<Decimal>();
            record.PaymentMethd = dataRecord["ELEM_PAYMENT_METHD"].ConvertTo<String>();
            record.Qty = dataRecord["ELEM_QTY"].ConvertTo<Double?>();
            record.UntPrice = dataRecord["ELEM_UNT_PRICE"].ConvertTo<Decimal>();
            record.UntPriceBc = dataRecord["ELEM_UNT_PRICE_BC"].ConvertTo<Decimal>();
            record.UntPriceBc2 = dataRecord["ELEM_UNT_PRICE_BC2"].ConvertTo<Decimal>();
            record.ShowSales = dataRecord["ELEM_SHOW_SALES"].ConvertTo<Byte?>();
            record.MstcId = dataRecord["ELEM_MSTC_ID"].ConvertTo<String>();
            record.LstPrice = dataRecord["ELEM_LST_PRICE"].ConvertTo<Decimal>();
            record.LstPriceBc = dataRecord["ELEM_LST_PRICE_BC"].ConvertTo<Decimal>();
            record.LstPriceBc2 = dataRecord["ELEM_LST_PRICE_BC2"].ConvertTo<Decimal>();
            record.DelType = dataRecord["ELEM_DEL_TYPE"].ConvertTo<Byte?>();
            record.DelAttribs = dataRecord["ELEM_DEL_ATTRIBS"].ConvertTo<String>();
            record.PlId = dataRecord["ELEM_PL_ID"].ConvertTo<String>();
            record.DelQty = dataRecord["ELEM_DEL_QTY"].ConvertTo<Double?>();
            record.Block = dataRecord["ELEM_BLOCK"].ConvertTo<Byte?>();
            record.Result = dataRecord["ELEM_RESULT"].ConvertTo<String>();
            record.History = dataRecord["ELEM_HISTORY"].ConvertTo<String>();
            record.RetailPrice = dataRecord["ELEM_RETAIL_PRICE"].ConvertTo<Decimal>();
            record.CostPrice = dataRecord["ELEM_COST_PRICE"].ConvertTo<Decimal>();
            record.RetPriceBc = dataRecord["ELEM_RET_PRICE_BC"].ConvertTo<Decimal>();
            record.CstPriceBc = dataRecord["ELEM_CST_PRICE_BC"].ConvertTo<Decimal>();
            record.RetPriceBc2 = dataRecord["ELEM_RET_PRICE_BC2"].ConvertTo<Decimal>();
            record.CstPriceBc2 = dataRecord["ELEM_CST_PRICE_BC2"].ConvertTo<Decimal>();
            record.ValToRev = dataRecord["ELEM_VAL_TO_REV"].ConvertTo<Decimal>();
            record.DelTypeDesc = dataRecord["ELEM_DEL_TYPE_DESC"].ConvertTo<String>();
            record.Description2 = dataRecord["ELEM_DESCRIPTION2"].ConvertTo<String>();
            record.LmspId = dataRecord["ELEM_LMSP_ID"].ConvertTo<String>();
            record.ScoStartDte = dataRecord["ELEM_SCO_START_DTE"].ConvertTo<DateTime?>();
            record.FailRsn = dataRecord["ELEM_FAIL_RSN"].ConvertTo<String>();
            record.MainSession = dataRecord["ELEM_MAIN_SESSION"].ConvertTo<Byte?>();
            record.SellMstcId = dataRecord["ELEM_SELL_MSTC_ID"].ConvertTo<String>();
            record.PrepayUnits = dataRecord["ELEM_PREPAY_UNITS"].ConvertTo<Double?>();
            record.StartDate = dataRecord["ELEM_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["ELEM_END_DATE"].ConvertTo<DateTime?>();
            record.RegNo = dataRecord["ELEM_REG_NO"].ConvertTo<String>();
            record.SxrefId = dataRecord["ELEM_SXREF_ID"].ConvertTo<String>();
            record.RoomType = dataRecord["ELEM_ROOM_TYPE"].ConvertTo<String>();
            record.RoomBedType = dataRecord["ELEM_ROOM_BED_TYPE"].ConvertTo<String>();
            record.Qty2 = dataRecord["ELEM_QTY_2"].ConvertTo<Double?>();
            record.QualId = dataRecord["ELEM_QUAL_ID"].ConvertTo<String>();
            record.TicketPnts = dataRecord["ELEM_TICKET_PNTS"].ConvertTo<Int32?>();
            record.DiscReason = dataRecord["ELEM_DISC_REASON"].ConvertTo<String>();
            record.StartTime = dataRecord["ELEM_START_TIME"].ConvertTo<DateTime?>();
            record.EndTime = dataRecord["ELEM_END_TIME"].ConvertTo<DateTime?>();
            record.SstId = dataRecord["ELEM_SST_ID"].ConvertTo<String>();
            record.SubQty1 = dataRecord["ELEM_SUB_QTY_1"].ConvertTo<Double?>();
            record.SubQty2 = dataRecord["ELEM_SUB_QTY_2"].ConvertTo<Double?>();
            record.SubQty3 = dataRecord["ELEM_SUB_QTY_3"].ConvertTo<Double?>();
            record.SubQty4 = dataRecord["ELEM_SUB_QTY_4"].ConvertTo<Double?>();
            record.SubQty5 = dataRecord["ELEM_SUB_QTY_5"].ConvertTo<Double?>();
            record.SubQty6 = dataRecord["ELEM_SUB_QTY_6"].ConvertTo<Double?>();
            record.SubQty7 = dataRecord["ELEM_SUB_QTY_7"].ConvertTo<Double?>();
            record.SubQty8 = dataRecord["ELEM_SUB_QTY_8"].ConvertTo<Double?>();
            record.SubQty9 = dataRecord["ELEM_SUB_QTY_9"].ConvertTo<Double?>();
            record.UntPrc1 = dataRecord["ELEM_UNT_PRC_1"].ConvertTo<Double?>();
            record.UntPrc2 = dataRecord["ELEM_UNT_PRC_2"].ConvertTo<Double?>();
            record.UntPrc3 = dataRecord["ELEM_UNT_PRC_3"].ConvertTo<Double?>();
            record.UntPrc4 = dataRecord["ELEM_UNT_PRC_4"].ConvertTo<Double?>();
            record.UntPrc5 = dataRecord["ELEM_UNT_PRC_5"].ConvertTo<Double?>();
            record.UntPrc6 = dataRecord["ELEM_UNT_PRC_6"].ConvertTo<Double?>();
            record.UntPrc7 = dataRecord["ELEM_UNT_PRC_7"].ConvertTo<Double?>();
            record.UntPrc8 = dataRecord["ELEM_UNT_PRC_8"].ConvertTo<Double?>();
            record.UntPrc9 = dataRecord["ELEM_UNT_PRC_9"].ConvertTo<Double?>();
            record.UntType = dataRecord["ELEM_UNT_TYPE"].ConvertTo<String>();
            record.VatAmt = dataRecord["ELEM_VAT_AMT"].ConvertTo<Decimal>();
            record.PriceCalc = dataRecord["ELEM_PRICE_CALC"].ConvertTo<String>();
            record.DiscAmt = dataRecord["ELEM_DISC_AMT"].ConvertTo<Decimal>();
            record.LmspSuspendData = dataRecord["ELEM_LMSP_SUSPEND_DATA"].ConvertTo<String>();
            record.LmspScore = dataRecord["ELEM_LMSP_SCORE"].ConvertTo<Byte?>();
            record.LmspLessonStatus = dataRecord["ELEM_LMSP_LESSON_STATUS"].ConvertTo<String>();
            record.LmspComments = dataRecord["ELEM_LMSP_COMMENTS"].ConvertTo<String>();
            record.ChgPrcBy = dataRecord["ELEM_CHG_PRC_BY"].ConvertTo<String>();
            record.ChgPrcDate = dataRecord["ELEM_CHG_PRC_DATE"].ConvertTo<DateTime?>();
            record.CertPrintStatus = dataRecord["ELEM_CERT_PRINT_STATUS"].ConvertTo<Byte?>();
            record.CrId = dataRecord["ELEM_CR_ID"].ConvertTo<String>();
            record.CertPrnDate = dataRecord["ELEM_CERT_PRN_DATE"].ConvertTo<DateTime?>();
            record.CertPrintAnyway = dataRecord["ELEM_CERT_PRINT_ANYWAY"].ConvertTo<Byte?>();
            record.SelcoSpId = dataRecord["ELEM_SELCO_SP_ID"].ConvertTo<String>();
            record.ChkInTime = dataRecord["ELEM_CHK_IN_TIME"].ConvertTo<DateTime?>();
            record.ExpChkOutTime = dataRecord["ELEM_EXP_CHK_OUT_TIME"].ConvertTo<DateTime?>();
            record.ActChkOutTime = dataRecord["ELEM_ACT_CHK_OUT_TIME"].ConvertTo<DateTime?>();
            record.PrsId = dataRecord["ELEM_PRS_ID"].ConvertTo<String>();
            record.TeachHrs = dataRecord["ELEM_TEACH_HRS"].ConvertTo<Decimal?>();
            record.StudWks = dataRecord["ELEM_STUD_WKS"].ConvertTo<Decimal?>();
            record.CommissionDone = dataRecord["ELEM_COMMISSION_DONE"].ConvertTo<Byte>();
            record.CommissionElemId = dataRecord["ELEM_COMMISSION_ELEM_ID"].ConvertTo<String>();
            record.AgtId = dataRecord["ELEM_AGT_ID"].ConvertTo<Int32?>();
            record.EventCancel = dataRecord["ELEM_EVENT_CANCEL"].ConvertTo<Byte>();
            record.Proforma = dataRecord["ELEM_PROFORMA"].ConvertTo<Byte?>();
            record.BatId = dataRecord["ELEM_BAT_ID"].ConvertTo<String>();
            record.SopNo = dataRecord["ELEM_SOP_NO"].ConvertTo<Byte?>();
            record.ErrorDesc = dataRecord["ELEM_ERROR_DESC"].ConvertTo<String>();
            record.GrpId = dataRecord["ELEM_GRP_ID"].ConvertTo<Int32?>();
            record.AuthStatus = dataRecord["ELEM_AUTH_STATUS"].ConvertTo<Byte?>();
            record.ElemId = dataRecord["ELEM_ELEM_ID"].ConvertTo<String>();
            record.BktId = dataRecord["ELEM_BKT_ID"].ConvertTo<String>();
            record.UnitPriceDisc = dataRecord["ELEM_UNIT_PRICE_DISC"].ConvertTo<Decimal?>();
            record.UnitPriceDiscBc = dataRecord["ELEM_UNIT_PRICE_DISC_BC"].ConvertTo<Decimal?>();
            record.UnitPriceDiscBc2 = dataRecord["ELEM_UNIT_PRICE_DISC_BC2"].ConvertTo<Decimal?>();
            record.UnitDiscount = dataRecord["ELEM_UNIT_DISCOUNT"].ConvertTo<Decimal?>();
            record.UnitDiscountBc = dataRecord["ELEM_UNIT_DISCOUNT_BC"].ConvertTo<Decimal?>();
            record.UnitDiscountBc2 = dataRecord["ELEM_UNIT_DISCOUNT_BC2"].ConvertTo<Decimal?>();
            record.PriceDisc = dataRecord["ELEM_PRICE_DISC"].ConvertTo<Decimal?>();
            record.PriceDiscBc = dataRecord["ELEM_PRICE_DISC_BC"].ConvertTo<Decimal?>();
            record.PriceDiscBc2 = dataRecord["ELEM_PRICE_DISC_BC2"].ConvertTo<Decimal?>();
            record.Discount = dataRecord["ELEM_DISCOUNT"].ConvertTo<Decimal?>();
            record.DiscountBc = dataRecord["ELEM_DISCOUNT_BC"].ConvertTo<Decimal?>();
            record.DiscountBc2 = dataRecord["ELEM_DISCOUNT_BC2"].ConvertTo<Decimal?>();
            record.ExtStatus = dataRecord["ELEM_EXT_STATUS"].ConvertTo<String>();
            record.CurrRateBc = dataRecord["ELEM_CURR_RATE_BC"].ConvertTo<Decimal?>();
            record.CurrRateBc2 = dataRecord["ELEM_CURR_RATE_BC2"].ConvertTo<Decimal?>();
            record.SentDate = dataRecord["ELEM_SENT_DATE"].ConvertTo<DateTime?>();
            record.DelivDate = dataRecord["ELEM_DELIV_DATE"].ConvertTo<DateTime?>();
            record.RetDate = dataRecord["ELEM_RET_DATE"].ConvertTo<DateTime?>();
            record.DeliverToDel = dataRecord["ELEM_DELIVER_TO_DEL"].ConvertTo<Byte>();
            record.BomId = dataRecord["ELEM_BOM_ID"].ConvertTo<String>();
            record.DiscId = dataRecord["ELEM_DISC_ID"].ConvertTo<Int32?>();
            record.ExclDiscamt = dataRecord["ELEM_EXCL_DISCAMT"].ConvertTo<Byte?>();
            record.DiscAppliedDate = dataRecord["ELEM_DISC_APPLIED_DATE"].ConvertTo<DateTime?>();
            record.BookGroup = dataRecord["ELEM_BOOK_GROUP"].ConvertTo<String>();
            record.Recommended = dataRecord["ELEM_RECOMMENDED"].ConvertTo<Byte>();
            record.Mandatory = dataRecord["ELEM_MANDATORY"].ConvertTo<Byte>();
            record.StElemId = dataRecord["ELEM_ST_ELEM_ID"].ConvertTo<String>();
            record.UniqueRef = dataRecord["ELEM_UNIQUE_REF"].ConvertTo<String>();
            record.PartnerSysRef = dataRecord["ELEM_PARTNER_SYS_REF"].ConvertTo<String>();
            record.QuoDetId = dataRecord["ELEM_QUO_DET_ID"].ConvertTo<String>();
            record.CertExpyDate = dataRecord["ELEM_CERT_EXPY_DATE"].ConvertTo<DateTime?>();
            record.AuthProleId = dataRecord["ELEM_AUTH_PROLE_ID"].ConvertTo<String>();
            record.AuthAssoType = dataRecord["ELEM_AUTH_ASSO_TYPE"].ConvertTo<Byte?>();
            record.AuthCode = dataRecord["ELEM_AUTH_CODE"].ConvertTo<String>();
            record.AuthReqDate = dataRecord["ELEM_AUTH_REQ_DATE"].ConvertTo<DateTime?>();
            record.LastAuthProleId = dataRecord["ELEM_LAST_AUTH_PROLE_ID"].ConvertTo<String>();
            record.AuthLastComments = dataRecord["ELEM_AUTH_LAST_COMMENTS"].ConvertTo<String>();
            record.PshId = dataRecord["ELEM_PSH_ID"].ConvertTo<Int32?>();
            record.BlockDel = dataRecord["ELEM_BLOCK_DEL"].ConvertTo<Byte?>();
            record.PrsType = dataRecord["ELEM_PRS_TYPE"].ConvertTo<Byte>();
            record.CancelDate = dataRecord["ELEM_CANCEL_DATE"].ConvertTo<DateTime?>();
            record.Score1 = dataRecord["ELEM_SCORE_1"].ConvertTo<Decimal>();
            record.Score2 = dataRecord["ELEM_SCORE_2"].ConvertTo<Decimal>();
            record.Score3 = dataRecord["ELEM_SCORE_3"].ConvertTo<Decimal>();
            record.Score4 = dataRecord["ELEM_SCORE_4"].ConvertTo<Decimal>();
            record.Score5 = dataRecord["ELEM_SCORE_5"].ConvertTo<Decimal>();
            record.Score6 = dataRecord["ELEM_SCORE_6"].ConvertTo<Decimal>();
            record.PdpeId = dataRecord["ELEM_PDPE_ID"].ConvertTo<String>();
            record.ScoEndDte = dataRecord["ELEM_SCO_END_DTE"].ConvertTo<DateTime?>();
            record.LmspTotalTime = dataRecord["ELEM_LMSP_TOTAL_TIME"].ConvertTo<String>();
            record.LmspLessonLocation = dataRecord["ELEM_LMSP_LESSON_LOCATION"].ConvertTo<String>();
            record.LmspCompletes = dataRecord["ELEM_LMSP_COMPLETES"].ConvertTo<Int32>();
            record.GiftAid = dataRecord["ELEM_GIFT_AID"].ConvertTo<Byte>();
            record.Claimed = dataRecord["ELEM_CLAIMED"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ElementRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ElementRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ELEM_ID", record.Id);
            this.MapParameterIn(command, "@PA_ELEM_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_ELEM_DEL_ID", record.DelId);
            this.MapParameterIn(command, "@PA_ELEM_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_ELEM_ACT_ID", record.ActId);
            this.MapParameterIn(command, "@PA_ELEM_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_ELEM_BOOK_ID", record.BookId);
            this.MapParameterIn(command, "@PA_ELEM_WHO_PAYS", record.WhoPays);
            this.MapParameterIn(command, "@PA_ELEM_CERT_NO", record.CertNo);
            this.MapParameterIn(command, "@PA_ELEM_ATTENDED", record.Attended);
            this.MapParameterIn(command, "@PA_ELEM_USER_DATE_1", record.UserDate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UserDate1);
            this.MapParameterIn(command, "@PA_ELEM_USER_DATE_2", record.UserDate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UserDate2);
            this.MapParameterIn(command, "@PA_ELEM_USER_DATE_3", record.UserDate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UserDate3);
            this.MapParameterIn(command, "@PA_ELEM_USERINT_1", record.Userint1);
            this.MapParameterIn(command, "@PA_ELEM_USERINT_2", record.Userint2);
            this.MapParameterIn(command, "@PA_ELEM_USERNUM_1", record.Usernum1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_ELEM_USERNUM_2", record.Usernum2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_ELEM_USERNUM_3", record.Usernum3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_ELEM_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_ELEM_PRICE", record.Price == Decimal.MinValue ? 0M : record.Price);
            this.MapParameterIn(command, "@PA_ELEM_BLOCK_PRICE", record.BlockPrice == Decimal.MinValue ? 0M : record.BlockPrice);
            this.MapParameterIn(command, "@PA_ELEM_PRICE_BC", record.PriceBc == Decimal.MinValue ? 0M : record.PriceBc);
            this.MapParameterIn(command, "@PA_ELEM_BLOCK_PRCE_BC", record.BlockPrceBc == Decimal.MinValue ? 0M : record.BlockPrceBc);
            this.MapParameterIn(command, "@PA_ELEM_VATCD", record.Vatcd);
            this.MapParameterIn(command, "@PA_ELEM_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_ELEM_DO_NOT_INVCE", record.DoNotInvce);
            this.MapParameterIn(command, "@PA_ELEM_INVOICED", record.Invoiced);
            this.MapParameterIn(command, "@PA_ELEM_INVOICED_DATE", record.InvoicedDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.InvoicedDate);
            this.MapParameterIn(command, "@PA_ELEM_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_ELEM_REV_CODE", record.RevCode);
            this.MapParameterIn(command, "@PA_ELEM_INVOICE_PRINT", record.InvoicePrint);
            this.MapParameterIn(command, "@PA_ELEM_CANCELLED", record.Cancelled);
            this.MapParameterIn(command, "@PA_ELEM_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_ELEM_CREDITED", record.Credited);
            this.MapParameterIn(command, "@PA_ELEM_NON_ATD_RSN", record.NonAtdRsn);
            this.MapParameterIn(command, "@PA_ELEM_CERT_ISE_DAT", record.CertIseDat == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CertIseDat);
            this.MapParameterIn(command, "@PA_ELEM_CERT_PRN_DAT", record.CertPrnDat == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CertPrnDat);
            this.MapParameterIn(command, "@PA_ELEM_LCSE_NO", record.LcseNo);
            this.MapParameterIn(command, "@PA_ELEM_LCSE_ISE_DAT", record.LcseIseDat == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LcseIseDat);
            this.MapParameterIn(command, "@PA_ELEM_LCSE_PRN_DAT", record.LcsePrnDat == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LcsePrnDat);
            this.MapParameterIn(command, "@PA_ELEM_REQ_DATE", record.ReqDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ReqDate);
            this.MapParameterIn(command, "@PA_ELEM_PASS", record.Pass);
            this.MapParameterIn(command, "@PA_ELEM_SCORE", record.Score == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Score);
            this.MapParameterIn(command, "@PA_ELEM_CHOSEN", record.Chosen);
            this.MapParameterIn(command, "@PA_ELEM_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_ELEM_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_ELEM_GRADE", record.Grade);
            this.MapParameterIn(command, "@PA_ELEM_PRICE_BC2", record.PriceBc2 == Decimal.MinValue ? 0M : record.PriceBc2);
            this.MapParameterIn(command, "@PA_ELEM_BLK_PRICE_BC2", record.BlkPriceBc2 == Decimal.MinValue ? 0M : record.BlkPriceBc2);
            this.MapParameterIn(command, "@PA_ELEM_PAYMENT_METHD", record.PaymentMethd);
            this.MapParameterIn(command, "@PA_ELEM_QTY", record.Qty == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Qty);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRICE", record.UntPrice == Decimal.MinValue ? 0M : record.UntPrice);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRICE_BC", record.UntPriceBc == Decimal.MinValue ? 0M : record.UntPriceBc);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRICE_BC2", record.UntPriceBc2 == Decimal.MinValue ? 0M : record.UntPriceBc2);
            this.MapParameterIn(command, "@PA_ELEM_SHOW_SALES", record.ShowSales);
            this.MapParameterIn(command, "@PA_ELEM_MSTC_ID", record.MstcId);
            this.MapParameterIn(command, "@PA_ELEM_LST_PRICE", record.LstPrice == Decimal.MinValue ? 0M : record.LstPrice);
            this.MapParameterIn(command, "@PA_ELEM_LST_PRICE_BC", record.LstPriceBc == Decimal.MinValue ? 0M : record.LstPriceBc);
            this.MapParameterIn(command, "@PA_ELEM_LST_PRICE_BC2", record.LstPriceBc2 == Decimal.MinValue ? 0M : record.LstPriceBc2);
            this.MapParameterIn(command, "@PA_ELEM_DEL_TYPE", record.DelType);
            this.MapParameterIn(command, "@PA_ELEM_DEL_ATTRIBS", record.DelAttribs);
            this.MapParameterIn(command, "@PA_ELEM_PL_ID", record.PlId);
            this.MapParameterIn(command, "@PA_ELEM_DEL_QTY", record.DelQty == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.DelQty);
            this.MapParameterIn(command, "@PA_ELEM_BLOCK", record.Block);
            this.MapParameterIn(command, "@PA_ELEM_RESULT", record.Result);
            this.MapParameterIn(command, "@PA_ELEM_HISTORY", record.History);
            this.MapParameterIn(command, "@PA_ELEM_RETAIL_PRICE", record.RetailPrice == Decimal.MinValue ? 0M : record.RetailPrice);
            this.MapParameterIn(command, "@PA_ELEM_COST_PRICE", record.CostPrice == Decimal.MinValue ? 0M : record.CostPrice);
            this.MapParameterIn(command, "@PA_ELEM_RET_PRICE_BC", record.RetPriceBc == Decimal.MinValue ? 0M : record.RetPriceBc);
            this.MapParameterIn(command, "@PA_ELEM_CST_PRICE_BC", record.CstPriceBc == Decimal.MinValue ? 0M : record.CstPriceBc);
            this.MapParameterIn(command, "@PA_ELEM_RET_PRICE_BC2", record.RetPriceBc2 == Decimal.MinValue ? 0M : record.RetPriceBc2);
            this.MapParameterIn(command, "@PA_ELEM_CST_PRICE_BC2", record.CstPriceBc2 == Decimal.MinValue ? 0M : record.CstPriceBc2);
            this.MapParameterIn(command, "@PA_ELEM_VAL_TO_REV", record.ValToRev == Decimal.MinValue ? 0M : record.ValToRev);
            this.MapParameterIn(command, "@PA_ELEM_DEL_TYPE_DESC", record.DelTypeDesc);
            this.MapParameterIn(command, "@PA_ELEM_DESCRIPTION2", record.Description2);
            this.MapParameterIn(command, "@PA_ELEM_LMSP_ID", record.LmspId);
            this.MapParameterIn(command, "@PA_ELEM_SCO_START_DTE", record.ScoStartDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ScoStartDte);
            this.MapParameterIn(command, "@PA_ELEM_FAIL_RSN", record.FailRsn);
            this.MapParameterIn(command, "@PA_ELEM_MAIN_SESSION", record.MainSession);
            this.MapParameterIn(command, "@PA_ELEM_SELL_MSTC_ID", record.SellMstcId);
            this.MapParameterIn(command, "@PA_ELEM_PREPAY_UNITS", record.PrepayUnits == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.PrepayUnits);
            this.MapParameterIn(command, "@PA_ELEM_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_ELEM_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_ELEM_REG_NO", record.RegNo);
            this.MapParameterIn(command, "@PA_ELEM_SXREF_ID", record.SxrefId);
            this.MapParameterIn(command, "@PA_ELEM_ROOM_TYPE", record.RoomType);
            this.MapParameterIn(command, "@PA_ELEM_ROOM_BED_TYPE", record.RoomBedType);
            this.MapParameterIn(command, "@PA_ELEM_QTY_2", record.Qty2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Qty2);
            this.MapParameterIn(command, "@PA_ELEM_QUAL_ID", record.QualId);
            this.MapParameterIn(command, "@PA_ELEM_TICKET_PNTS", record.TicketPnts == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TicketPnts);
            this.MapParameterIn(command, "@PA_ELEM_DISC_REASON", record.DiscReason);
            this.MapParameterIn(command, "@PA_ELEM_START_TIME", record.StartTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartTime);
            this.MapParameterIn(command, "@PA_ELEM_END_TIME", record.EndTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndTime);
            this.MapParameterIn(command, "@PA_ELEM_SST_ID", record.SstId);
            this.MapParameterIn(command, "@PA_ELEM_SUB_QTY_1", record.SubQty1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubQty1);
            this.MapParameterIn(command, "@PA_ELEM_SUB_QTY_2", record.SubQty2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubQty2);
            this.MapParameterIn(command, "@PA_ELEM_SUB_QTY_3", record.SubQty3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubQty3);
            this.MapParameterIn(command, "@PA_ELEM_SUB_QTY_4", record.SubQty4 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubQty4);
            this.MapParameterIn(command, "@PA_ELEM_SUB_QTY_5", record.SubQty5 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubQty5);
            this.MapParameterIn(command, "@PA_ELEM_SUB_QTY_6", record.SubQty6 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubQty6);
            this.MapParameterIn(command, "@PA_ELEM_SUB_QTY_7", record.SubQty7 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubQty7);
            this.MapParameterIn(command, "@PA_ELEM_SUB_QTY_8", record.SubQty8 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubQty8);
            this.MapParameterIn(command, "@PA_ELEM_SUB_QTY_9", record.SubQty9 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubQty9);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRC_1", record.UntPrc1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UntPrc1);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRC_2", record.UntPrc2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UntPrc2);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRC_3", record.UntPrc3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UntPrc3);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRC_4", record.UntPrc4 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UntPrc4);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRC_5", record.UntPrc5 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UntPrc5);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRC_6", record.UntPrc6 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UntPrc6);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRC_7", record.UntPrc7 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UntPrc7);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRC_8", record.UntPrc8 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UntPrc8);
            this.MapParameterIn(command, "@PA_ELEM_UNT_PRC_9", record.UntPrc9 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UntPrc9);
            this.MapParameterIn(command, "@PA_ELEM_UNT_TYPE", record.UntType);
            this.MapParameterIn(command, "@PA_ELEM_VAT_AMT", record.VatAmt == Decimal.MinValue ? 0M : record.VatAmt);
            this.MapParameterIn(command, "@PA_ELEM_PRICE_CALC", record.PriceCalc);
            this.MapParameterIn(command, "@PA_ELEM_DISC_AMT", record.DiscAmt == Decimal.MinValue ? 0M : record.DiscAmt);
            this.MapParameterIn(command, "@PA_ELEM_LMSP_SUSPEND_DATA", record.LmspSuspendData);
            this.MapParameterIn(command, "@PA_ELEM_LMSP_SCORE", record.LmspScore);
            this.MapParameterIn(command, "@PA_ELEM_LMSP_LESSON_STATUS", record.LmspLessonStatus);
            this.MapParameterIn(command, "@PA_ELEM_LMSP_COMMENTS", record.LmspComments);
            this.MapParameterIn(command, "@PA_ELEM_CHG_PRC_BY", record.ChgPrcBy);
            this.MapParameterIn(command, "@PA_ELEM_CHG_PRC_DATE", record.ChgPrcDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ChgPrcDate);
            this.MapParameterIn(command, "@PA_ELEM_CERT_PRINT_STATUS", record.CertPrintStatus);
            this.MapParameterIn(command, "@PA_ELEM_CR_ID", record.CrId);
            this.MapParameterIn(command, "@PA_ELEM_CERT_PRN_DATE", record.CertPrnDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CertPrnDate);
            this.MapParameterIn(command, "@PA_ELEM_CERT_PRINT_ANYWAY", record.CertPrintAnyway);
            this.MapParameterIn(command, "@PA_ELEM_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_ELEM_CHK_IN_TIME", record.ChkInTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ChkInTime);
            this.MapParameterIn(command, "@PA_ELEM_EXP_CHK_OUT_TIME", record.ExpChkOutTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ExpChkOutTime);
            this.MapParameterIn(command, "@PA_ELEM_ACT_CHK_OUT_TIME", record.ActChkOutTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ActChkOutTime);
            this.MapParameterIn(command, "@PA_ELEM_PRS_ID", record.PrsId);
            this.MapParameterIn(command, "@PA_ELEM_TEACH_HRS", record.TeachHrs == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.TeachHrs);
            this.MapParameterIn(command, "@PA_ELEM_STUD_WKS", record.StudWks == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.StudWks);
            this.MapParameterIn(command, "@PA_ELEM_COMMISSION_DONE", record.CommissionDone);
            this.MapParameterIn(command, "@PA_ELEM_COMMISSION_ELEM_ID", record.CommissionElemId);
            this.MapParameterIn(command, "@PA_ELEM_AGT_ID", record.AgtId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.AgtId);
            this.MapParameterIn(command, "@PA_ELEM_EVENT_CANCEL", record.EventCancel);
            this.MapParameterIn(command, "@PA_ELEM_PROFORMA", record.Proforma);
            this.MapParameterIn(command, "@PA_ELEM_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_ELEM_SOP_NO", record.SopNo);
            this.MapParameterIn(command, "@PA_ELEM_ERROR_DESC", record.ErrorDesc);
            this.MapParameterIn(command, "@PA_ELEM_GRP_ID", record.GrpId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.GrpId);
            this.MapParameterIn(command, "@PA_ELEM_AUTH_STATUS", record.AuthStatus);
            this.MapParameterIn(command, "@PA_ELEM_ELEM_ID", record.ElemId);
            this.MapParameterIn(command, "@PA_ELEM_BKT_ID", record.BktId);
            this.MapParameterIn(command, "@PA_ELEM_UNIT_PRICE_DISC", record.UnitPriceDisc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UnitPriceDisc);
            this.MapParameterIn(command, "@PA_ELEM_UNIT_PRICE_DISC_BC", record.UnitPriceDiscBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UnitPriceDiscBc);
            this.MapParameterIn(command, "@PA_ELEM_UNIT_PRICE_DISC_BC2", record.UnitPriceDiscBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UnitPriceDiscBc2);
            this.MapParameterIn(command, "@PA_ELEM_UNIT_DISCOUNT", record.UnitDiscount == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UnitDiscount);
            this.MapParameterIn(command, "@PA_ELEM_UNIT_DISCOUNT_BC", record.UnitDiscountBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UnitDiscountBc);
            this.MapParameterIn(command, "@PA_ELEM_UNIT_DISCOUNT_BC2", record.UnitDiscountBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UnitDiscountBc2);
            this.MapParameterIn(command, "@PA_ELEM_PRICE_DISC", record.PriceDisc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.PriceDisc);
            this.MapParameterIn(command, "@PA_ELEM_PRICE_DISC_BC", record.PriceDiscBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.PriceDiscBc);
            this.MapParameterIn(command, "@PA_ELEM_PRICE_DISC_BC2", record.PriceDiscBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.PriceDiscBc2);
            this.MapParameterIn(command, "@PA_ELEM_DISCOUNT", record.Discount == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Discount);
            this.MapParameterIn(command, "@PA_ELEM_DISCOUNT_BC", record.DiscountBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DiscountBc);
            this.MapParameterIn(command, "@PA_ELEM_DISCOUNT_BC2", record.DiscountBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DiscountBc2);
            this.MapParameterIn(command, "@PA_ELEM_EXT_STATUS", record.ExtStatus);
            this.MapParameterIn(command, "@PA_ELEM_CURR_RATE_BC", record.CurrRateBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CurrRateBc);
            this.MapParameterIn(command, "@PA_ELEM_CURR_RATE_BC2", record.CurrRateBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CurrRateBc2);
            this.MapParameterIn(command, "@PA_ELEM_SENT_DATE", record.SentDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SentDate);
            this.MapParameterIn(command, "@PA_ELEM_DELIV_DATE", record.DelivDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DelivDate);
            this.MapParameterIn(command, "@PA_ELEM_RET_DATE", record.RetDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RetDate);
            this.MapParameterIn(command, "@PA_ELEM_DELIVER_TO_DEL", record.DeliverToDel);
            this.MapParameterIn(command, "@PA_ELEM_BOM_ID", record.BomId);
            this.MapParameterIn(command, "@PA_ELEM_DISC_ID", record.DiscId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DiscId);
            this.MapParameterIn(command, "@PA_ELEM_EXCL_DISCAMT", record.ExclDiscamt);
            this.MapParameterIn(command, "@PA_ELEM_DISC_APPLIED_DATE", record.DiscAppliedDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DiscAppliedDate);
            this.MapParameterIn(command, "@PA_ELEM_BOOK_GROUP", record.BookGroup);
            this.MapParameterIn(command, "@PA_ELEM_RECOMMENDED", record.Recommended);
            this.MapParameterIn(command, "@PA_ELEM_MANDATORY", record.Mandatory);
            this.MapParameterIn(command, "@PA_ELEM_ST_ELEM_ID", record.StElemId);
            this.MapParameterIn(command, "@PA_ELEM_UNIQUE_REF", record.UniqueRef);
            this.MapParameterIn(command, "@PA_ELEM_PARTNER_SYS_REF", record.PartnerSysRef);
            this.MapParameterIn(command, "@PA_ELEM_QUO_DET_ID", record.QuoDetId);
            this.MapParameterIn(command, "@PA_ELEM_CERT_EXPY_DATE", record.CertExpyDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CertExpyDate);
            this.MapParameterIn(command, "@PA_ELEM_AUTH_PROLE_ID", record.AuthProleId);
            this.MapParameterIn(command, "@PA_ELEM_AUTH_ASSO_TYPE", record.AuthAssoType);
            this.MapParameterIn(command, "@PA_ELEM_AUTH_CODE", record.AuthCode);
            this.MapParameterIn(command, "@PA_ELEM_AUTH_REQ_DATE", record.AuthReqDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AuthReqDate);
            this.MapParameterIn(command, "@PA_ELEM_LAST_AUTH_PROLE_ID", record.LastAuthProleId);
            this.MapParameterIn(command, "@PA_ELEM_AUTH_LAST_COMMENTS", record.AuthLastComments);
            this.MapParameterIn(command, "@PA_ELEM_PSH_ID", record.PshId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PshId);
            this.MapParameterIn(command, "@PA_ELEM_BLOCK_DEL", record.BlockDel);
            this.MapParameterIn(command, "@PA_ELEM_PRS_TYPE", record.PrsType);
            this.MapParameterIn(command, "@PA_ELEM_CANCEL_DATE", record.CancelDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CancelDate);
            this.MapParameterIn(command, "@PA_ELEM_SCORE_1", record.Score1 == Decimal.MinValue ? 0M : record.Score1);
            this.MapParameterIn(command, "@PA_ELEM_SCORE_2", record.Score2 == Decimal.MinValue ? 0M : record.Score2);
            this.MapParameterIn(command, "@PA_ELEM_SCORE_3", record.Score3 == Decimal.MinValue ? 0M : record.Score3);
            this.MapParameterIn(command, "@PA_ELEM_SCORE_4", record.Score4 == Decimal.MinValue ? 0M : record.Score4);
            this.MapParameterIn(command, "@PA_ELEM_SCORE_5", record.Score5 == Decimal.MinValue ? 0M : record.Score5);
            this.MapParameterIn(command, "@PA_ELEM_SCORE_6", record.Score6 == Decimal.MinValue ? 0M : record.Score6);
            this.MapParameterIn(command, "@PA_ELEM_PDPE_ID", record.PdpeId);
            this.MapParameterIn(command, "@PA_ELEM_SCO_END_DTE", record.ScoEndDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ScoEndDte);
            this.MapParameterIn(command, "@PA_ELEM_LMSP_TOTAL_TIME", record.LmspTotalTime);
            this.MapParameterIn(command, "@PA_ELEM_LMSP_LESSON_LOCATION", record.LmspLessonLocation);
            this.MapParameterIn(command, "@PA_ELEM_LMSP_COMPLETES", record.LmspCompletes == Int32.MinValue ? 0 : record.LmspCompletes);
            this.MapParameterIn(command, "@PA_ELEM_GIFT_AID", record.GiftAid);
            this.MapParameterIn(command, "@PA_ELEM_CLAIMED", record.Claimed);
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
        ///     The <see cref="ElementRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ElementRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ELEM_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_ELEM_LOCK", record.Lock);
            record.DelId = this.MapParameterOut(command, "@PA_ELEM_DEL_ID", record.DelId);
            record.ProdId = this.MapParameterOut(command, "@PA_ELEM_PROD_ID", record.ProdId);
            record.ActId = this.MapParameterOut(command, "@PA_ELEM_ACT_ID", record.ActId);
            record.CourseId = this.MapParameterOut(command, "@PA_ELEM_COURSE_ID", record.CourseId);
            record.BookId = this.MapParameterOut(command, "@PA_ELEM_BOOK_ID", record.BookId);
            record.WhoPays = this.MapParameterOut(command, "@PA_ELEM_WHO_PAYS", record.WhoPays);
            record.CertNo = this.MapParameterOut(command, "@PA_ELEM_CERT_NO", record.CertNo);
            record.Attended = this.MapParameterOut(command, "@PA_ELEM_ATTENDED", record.Attended);
            record.UserDate1 = this.MapParameterOut(command, "@PA_ELEM_USER_DATE_1", record.UserDate1);
            record.UserDate2 = this.MapParameterOut(command, "@PA_ELEM_USER_DATE_2", record.UserDate2);
            record.UserDate3 = this.MapParameterOut(command, "@PA_ELEM_USER_DATE_3", record.UserDate3);
            record.Userint1 = this.MapParameterOut(command, "@PA_ELEM_USERINT_1", record.Userint1);
            record.Userint2 = this.MapParameterOut(command, "@PA_ELEM_USERINT_2", record.Userint2);
            record.Usernum1 = this.MapParameterOut(command, "@PA_ELEM_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_ELEM_USERNUM_2", record.Usernum2);
            record.Usernum3 = this.MapParameterOut(command, "@PA_ELEM_USERNUM_3", record.Usernum3);
            record.CurrencyType = this.MapParameterOut(command, "@PA_ELEM_CURRENCY_TYPE", record.CurrencyType);
            record.Price = this.MapParameterOut(command, "@PA_ELEM_PRICE", record.Price);
            record.BlockPrice = this.MapParameterOut(command, "@PA_ELEM_BLOCK_PRICE", record.BlockPrice);
            record.PriceBc = this.MapParameterOut(command, "@PA_ELEM_PRICE_BC", record.PriceBc);
            record.BlockPrceBc = this.MapParameterOut(command, "@PA_ELEM_BLOCK_PRCE_BC", record.BlockPrceBc);
            record.Vatcd = this.MapParameterOut(command, "@PA_ELEM_VATCD", record.Vatcd);
            record.CostCode = this.MapParameterOut(command, "@PA_ELEM_COST_CODE", record.CostCode);
            record.DoNotInvce = this.MapParameterOut(command, "@PA_ELEM_DO_NOT_INVCE", record.DoNotInvce);
            record.Invoiced = this.MapParameterOut(command, "@PA_ELEM_INVOICED", record.Invoiced);
            record.InvoicedDate = this.MapParameterOut(command, "@PA_ELEM_INVOICED_DATE", record.InvoicedDate);
            record.Description = this.MapParameterOut(command, "@PA_ELEM_DESCRIPTION", record.Description);
            record.RevCode = this.MapParameterOut(command, "@PA_ELEM_REV_CODE", record.RevCode);
            record.InvoicePrint = this.MapParameterOut(command, "@PA_ELEM_INVOICE_PRINT", record.InvoicePrint);
            record.Cancelled = this.MapParameterOut(command, "@PA_ELEM_CANCELLED", record.Cancelled);
            record.Notes = this.MapParameterOut(command, "@PA_ELEM_NOTES", record.Notes);
            record.Credited = this.MapParameterOut(command, "@PA_ELEM_CREDITED", record.Credited);
            record.NonAtdRsn = this.MapParameterOut(command, "@PA_ELEM_NON_ATD_RSN", record.NonAtdRsn);
            record.CertIseDat = this.MapParameterOut(command, "@PA_ELEM_CERT_ISE_DAT", record.CertIseDat);
            record.CertPrnDat = this.MapParameterOut(command, "@PA_ELEM_CERT_PRN_DAT", record.CertPrnDat);
            record.LcseNo = this.MapParameterOut(command, "@PA_ELEM_LCSE_NO", record.LcseNo);
            record.LcseIseDat = this.MapParameterOut(command, "@PA_ELEM_LCSE_ISE_DAT", record.LcseIseDat);
            record.LcsePrnDat = this.MapParameterOut(command, "@PA_ELEM_LCSE_PRN_DAT", record.LcsePrnDat);
            record.ReqDate = this.MapParameterOut(command, "@PA_ELEM_REQ_DATE", record.ReqDate);
            record.Pass = this.MapParameterOut(command, "@PA_ELEM_PASS", record.Pass);
            record.Score = this.MapParameterOut(command, "@PA_ELEM_SCORE", record.Score);
            record.Chosen = this.MapParameterOut(command, "@PA_ELEM_CHOSEN", record.Chosen);
            record.Type = this.MapParameterOut(command, "@PA_ELEM_TYPE", record.Type);
            record.Status = this.MapParameterOut(command, "@PA_ELEM_STATUS", record.Status);
            record.Grade = this.MapParameterOut(command, "@PA_ELEM_GRADE", record.Grade);
            record.PriceBc2 = this.MapParameterOut(command, "@PA_ELEM_PRICE_BC2", record.PriceBc2);
            record.BlkPriceBc2 = this.MapParameterOut(command, "@PA_ELEM_BLK_PRICE_BC2", record.BlkPriceBc2);
            record.PaymentMethd = this.MapParameterOut(command, "@PA_ELEM_PAYMENT_METHD", record.PaymentMethd);
            record.Qty = this.MapParameterOut(command, "@PA_ELEM_QTY", record.Qty);
            record.UntPrice = this.MapParameterOut(command, "@PA_ELEM_UNT_PRICE", record.UntPrice);
            record.UntPriceBc = this.MapParameterOut(command, "@PA_ELEM_UNT_PRICE_BC", record.UntPriceBc);
            record.UntPriceBc2 = this.MapParameterOut(command, "@PA_ELEM_UNT_PRICE_BC2", record.UntPriceBc2);
            record.ShowSales = this.MapParameterOut(command, "@PA_ELEM_SHOW_SALES", record.ShowSales);
            record.MstcId = this.MapParameterOut(command, "@PA_ELEM_MSTC_ID", record.MstcId);
            record.LstPrice = this.MapParameterOut(command, "@PA_ELEM_LST_PRICE", record.LstPrice);
            record.LstPriceBc = this.MapParameterOut(command, "@PA_ELEM_LST_PRICE_BC", record.LstPriceBc);
            record.LstPriceBc2 = this.MapParameterOut(command, "@PA_ELEM_LST_PRICE_BC2", record.LstPriceBc2);
            record.DelType = this.MapParameterOut(command, "@PA_ELEM_DEL_TYPE", record.DelType);
            record.DelAttribs = this.MapParameterOut(command, "@PA_ELEM_DEL_ATTRIBS", record.DelAttribs);
            record.PlId = this.MapParameterOut(command, "@PA_ELEM_PL_ID", record.PlId);
            record.DelQty = this.MapParameterOut(command, "@PA_ELEM_DEL_QTY", record.DelQty);
            record.Block = this.MapParameterOut(command, "@PA_ELEM_BLOCK", record.Block);
            record.Result = this.MapParameterOut(command, "@PA_ELEM_RESULT", record.Result);
            record.History = this.MapParameterOut(command, "@PA_ELEM_HISTORY", record.History);
            record.RetailPrice = this.MapParameterOut(command, "@PA_ELEM_RETAIL_PRICE", record.RetailPrice);
            record.CostPrice = this.MapParameterOut(command, "@PA_ELEM_COST_PRICE", record.CostPrice);
            record.RetPriceBc = this.MapParameterOut(command, "@PA_ELEM_RET_PRICE_BC", record.RetPriceBc);
            record.CstPriceBc = this.MapParameterOut(command, "@PA_ELEM_CST_PRICE_BC", record.CstPriceBc);
            record.RetPriceBc2 = this.MapParameterOut(command, "@PA_ELEM_RET_PRICE_BC2", record.RetPriceBc2);
            record.CstPriceBc2 = this.MapParameterOut(command, "@PA_ELEM_CST_PRICE_BC2", record.CstPriceBc2);
            record.ValToRev = this.MapParameterOut(command, "@PA_ELEM_VAL_TO_REV", record.ValToRev);
            record.DelTypeDesc = this.MapParameterOut(command, "@PA_ELEM_DEL_TYPE_DESC", record.DelTypeDesc);
            record.Description2 = this.MapParameterOut(command, "@PA_ELEM_DESCRIPTION2", record.Description2);
            record.LmspId = this.MapParameterOut(command, "@PA_ELEM_LMSP_ID", record.LmspId);
            record.ScoStartDte = this.MapParameterOut(command, "@PA_ELEM_SCO_START_DTE", record.ScoStartDte);
            record.FailRsn = this.MapParameterOut(command, "@PA_ELEM_FAIL_RSN", record.FailRsn);
            record.MainSession = this.MapParameterOut(command, "@PA_ELEM_MAIN_SESSION", record.MainSession);
            record.SellMstcId = this.MapParameterOut(command, "@PA_ELEM_SELL_MSTC_ID", record.SellMstcId);
            record.PrepayUnits = this.MapParameterOut(command, "@PA_ELEM_PREPAY_UNITS", record.PrepayUnits);
            record.StartDate = this.MapParameterOut(command, "@PA_ELEM_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_ELEM_END_DATE", record.EndDate);
            record.RegNo = this.MapParameterOut(command, "@PA_ELEM_REG_NO", record.RegNo);
            record.SxrefId = this.MapParameterOut(command, "@PA_ELEM_SXREF_ID", record.SxrefId);
            record.RoomType = this.MapParameterOut(command, "@PA_ELEM_ROOM_TYPE", record.RoomType);
            record.RoomBedType = this.MapParameterOut(command, "@PA_ELEM_ROOM_BED_TYPE", record.RoomBedType);
            record.Qty2 = this.MapParameterOut(command, "@PA_ELEM_QTY_2", record.Qty2);
            record.QualId = this.MapParameterOut(command, "@PA_ELEM_QUAL_ID", record.QualId);
            record.TicketPnts = this.MapParameterOut(command, "@PA_ELEM_TICKET_PNTS", record.TicketPnts);
            record.DiscReason = this.MapParameterOut(command, "@PA_ELEM_DISC_REASON", record.DiscReason);
            record.StartTime = this.MapParameterOut(command, "@PA_ELEM_START_TIME", record.StartTime);
            record.EndTime = this.MapParameterOut(command, "@PA_ELEM_END_TIME", record.EndTime);
            record.SstId = this.MapParameterOut(command, "@PA_ELEM_SST_ID", record.SstId);
            record.SubQty1 = this.MapParameterOut(command, "@PA_ELEM_SUB_QTY_1", record.SubQty1);
            record.SubQty2 = this.MapParameterOut(command, "@PA_ELEM_SUB_QTY_2", record.SubQty2);
            record.SubQty3 = this.MapParameterOut(command, "@PA_ELEM_SUB_QTY_3", record.SubQty3);
            record.SubQty4 = this.MapParameterOut(command, "@PA_ELEM_SUB_QTY_4", record.SubQty4);
            record.SubQty5 = this.MapParameterOut(command, "@PA_ELEM_SUB_QTY_5", record.SubQty5);
            record.SubQty6 = this.MapParameterOut(command, "@PA_ELEM_SUB_QTY_6", record.SubQty6);
            record.SubQty7 = this.MapParameterOut(command, "@PA_ELEM_SUB_QTY_7", record.SubQty7);
            record.SubQty8 = this.MapParameterOut(command, "@PA_ELEM_SUB_QTY_8", record.SubQty8);
            record.SubQty9 = this.MapParameterOut(command, "@PA_ELEM_SUB_QTY_9", record.SubQty9);
            record.UntPrc1 = this.MapParameterOut(command, "@PA_ELEM_UNT_PRC_1", record.UntPrc1);
            record.UntPrc2 = this.MapParameterOut(command, "@PA_ELEM_UNT_PRC_2", record.UntPrc2);
            record.UntPrc3 = this.MapParameterOut(command, "@PA_ELEM_UNT_PRC_3", record.UntPrc3);
            record.UntPrc4 = this.MapParameterOut(command, "@PA_ELEM_UNT_PRC_4", record.UntPrc4);
            record.UntPrc5 = this.MapParameterOut(command, "@PA_ELEM_UNT_PRC_5", record.UntPrc5);
            record.UntPrc6 = this.MapParameterOut(command, "@PA_ELEM_UNT_PRC_6", record.UntPrc6);
            record.UntPrc7 = this.MapParameterOut(command, "@PA_ELEM_UNT_PRC_7", record.UntPrc7);
            record.UntPrc8 = this.MapParameterOut(command, "@PA_ELEM_UNT_PRC_8", record.UntPrc8);
            record.UntPrc9 = this.MapParameterOut(command, "@PA_ELEM_UNT_PRC_9", record.UntPrc9);
            record.UntType = this.MapParameterOut(command, "@PA_ELEM_UNT_TYPE", record.UntType);
            record.VatAmt = this.MapParameterOut(command, "@PA_ELEM_VAT_AMT", record.VatAmt);
            record.PriceCalc = this.MapParameterOut(command, "@PA_ELEM_PRICE_CALC", record.PriceCalc);
            record.DiscAmt = this.MapParameterOut(command, "@PA_ELEM_DISC_AMT", record.DiscAmt);
            record.LmspSuspendData = this.MapParameterOut(command, "@PA_ELEM_LMSP_SUSPEND_DATA", record.LmspSuspendData);
            record.LmspScore = this.MapParameterOut(command, "@PA_ELEM_LMSP_SCORE", record.LmspScore);
            record.LmspLessonStatus = this.MapParameterOut(command, "@PA_ELEM_LMSP_LESSON_STATUS", record.LmspLessonStatus);
            record.LmspComments = this.MapParameterOut(command, "@PA_ELEM_LMSP_COMMENTS", record.LmspComments);
            record.ChgPrcBy = this.MapParameterOut(command, "@PA_ELEM_CHG_PRC_BY", record.ChgPrcBy);
            record.ChgPrcDate = this.MapParameterOut(command, "@PA_ELEM_CHG_PRC_DATE", record.ChgPrcDate);
            record.CertPrintStatus = this.MapParameterOut(command, "@PA_ELEM_CERT_PRINT_STATUS", record.CertPrintStatus);
            record.CrId = this.MapParameterOut(command, "@PA_ELEM_CR_ID", record.CrId);
            record.CertPrnDate = this.MapParameterOut(command, "@PA_ELEM_CERT_PRN_DATE", record.CertPrnDate);
            record.CertPrintAnyway = this.MapParameterOut(command, "@PA_ELEM_CERT_PRINT_ANYWAY", record.CertPrintAnyway);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_ELEM_SELCO_SP_ID", record.SelcoSpId);
            record.ChkInTime = this.MapParameterOut(command, "@PA_ELEM_CHK_IN_TIME", record.ChkInTime);
            record.ExpChkOutTime = this.MapParameterOut(command, "@PA_ELEM_EXP_CHK_OUT_TIME", record.ExpChkOutTime);
            record.ActChkOutTime = this.MapParameterOut(command, "@PA_ELEM_ACT_CHK_OUT_TIME", record.ActChkOutTime);
            record.PrsId = this.MapParameterOut(command, "@PA_ELEM_PRS_ID", record.PrsId);
            record.TeachHrs = this.MapParameterOut(command, "@PA_ELEM_TEACH_HRS", record.TeachHrs);
            record.StudWks = this.MapParameterOut(command, "@PA_ELEM_STUD_WKS", record.StudWks);
            record.CommissionDone = this.MapParameterOut(command, "@PA_ELEM_COMMISSION_DONE", record.CommissionDone);
            record.CommissionElemId = this.MapParameterOut(command, "@PA_ELEM_COMMISSION_ELEM_ID", record.CommissionElemId);
            record.AgtId = this.MapParameterOut(command, "@PA_ELEM_AGT_ID", record.AgtId);
            record.EventCancel = this.MapParameterOut(command, "@PA_ELEM_EVENT_CANCEL", record.EventCancel);
            record.Proforma = this.MapParameterOut(command, "@PA_ELEM_PROFORMA", record.Proforma);
            record.BatId = this.MapParameterOut(command, "@PA_ELEM_BAT_ID", record.BatId);
            record.SopNo = this.MapParameterOut(command, "@PA_ELEM_SOP_NO", record.SopNo);
            record.ErrorDesc = this.MapParameterOut(command, "@PA_ELEM_ERROR_DESC", record.ErrorDesc);
            record.GrpId = this.MapParameterOut(command, "@PA_ELEM_GRP_ID", record.GrpId);
            record.AuthStatus = this.MapParameterOut(command, "@PA_ELEM_AUTH_STATUS", record.AuthStatus);
            record.ElemId = this.MapParameterOut(command, "@PA_ELEM_ELEM_ID", record.ElemId);
            record.BktId = this.MapParameterOut(command, "@PA_ELEM_BKT_ID", record.BktId);
            record.UnitPriceDisc = this.MapParameterOut(command, "@PA_ELEM_UNIT_PRICE_DISC", record.UnitPriceDisc);
            record.UnitPriceDiscBc = this.MapParameterOut(command, "@PA_ELEM_UNIT_PRICE_DISC_BC", record.UnitPriceDiscBc);
            record.UnitPriceDiscBc2 = this.MapParameterOut(command, "@PA_ELEM_UNIT_PRICE_DISC_BC2", record.UnitPriceDiscBc2);
            record.UnitDiscount = this.MapParameterOut(command, "@PA_ELEM_UNIT_DISCOUNT", record.UnitDiscount);
            record.UnitDiscountBc = this.MapParameterOut(command, "@PA_ELEM_UNIT_DISCOUNT_BC", record.UnitDiscountBc);
            record.UnitDiscountBc2 = this.MapParameterOut(command, "@PA_ELEM_UNIT_DISCOUNT_BC2", record.UnitDiscountBc2);
            record.PriceDisc = this.MapParameterOut(command, "@PA_ELEM_PRICE_DISC", record.PriceDisc);
            record.PriceDiscBc = this.MapParameterOut(command, "@PA_ELEM_PRICE_DISC_BC", record.PriceDiscBc);
            record.PriceDiscBc2 = this.MapParameterOut(command, "@PA_ELEM_PRICE_DISC_BC2", record.PriceDiscBc2);
            record.Discount = this.MapParameterOut(command, "@PA_ELEM_DISCOUNT", record.Discount);
            record.DiscountBc = this.MapParameterOut(command, "@PA_ELEM_DISCOUNT_BC", record.DiscountBc);
            record.DiscountBc2 = this.MapParameterOut(command, "@PA_ELEM_DISCOUNT_BC2", record.DiscountBc2);
            record.ExtStatus = this.MapParameterOut(command, "@PA_ELEM_EXT_STATUS", record.ExtStatus);
            record.CurrRateBc = this.MapParameterOut(command, "@PA_ELEM_CURR_RATE_BC", record.CurrRateBc);
            record.CurrRateBc2 = this.MapParameterOut(command, "@PA_ELEM_CURR_RATE_BC2", record.CurrRateBc2);
            record.SentDate = this.MapParameterOut(command, "@PA_ELEM_SENT_DATE", record.SentDate);
            record.DelivDate = this.MapParameterOut(command, "@PA_ELEM_DELIV_DATE", record.DelivDate);
            record.RetDate = this.MapParameterOut(command, "@PA_ELEM_RET_DATE", record.RetDate);
            record.DeliverToDel = this.MapParameterOut(command, "@PA_ELEM_DELIVER_TO_DEL", record.DeliverToDel);
            record.BomId = this.MapParameterOut(command, "@PA_ELEM_BOM_ID", record.BomId);
            record.DiscId = this.MapParameterOut(command, "@PA_ELEM_DISC_ID", record.DiscId);
            record.ExclDiscamt = this.MapParameterOut(command, "@PA_ELEM_EXCL_DISCAMT", record.ExclDiscamt);
            record.DiscAppliedDate = this.MapParameterOut(command, "@PA_ELEM_DISC_APPLIED_DATE", record.DiscAppliedDate);
            record.BookGroup = this.MapParameterOut(command, "@PA_ELEM_BOOK_GROUP", record.BookGroup);
            record.Recommended = this.MapParameterOut(command, "@PA_ELEM_RECOMMENDED", record.Recommended);
            record.Mandatory = this.MapParameterOut(command, "@PA_ELEM_MANDATORY", record.Mandatory);
            record.StElemId = this.MapParameterOut(command, "@PA_ELEM_ST_ELEM_ID", record.StElemId);
            record.UniqueRef = this.MapParameterOut(command, "@PA_ELEM_UNIQUE_REF", record.UniqueRef);
            record.PartnerSysRef = this.MapParameterOut(command, "@PA_ELEM_PARTNER_SYS_REF", record.PartnerSysRef);
            record.QuoDetId = this.MapParameterOut(command, "@PA_ELEM_QUO_DET_ID", record.QuoDetId);
            record.CertExpyDate = this.MapParameterOut(command, "@PA_ELEM_CERT_EXPY_DATE", record.CertExpyDate);
            record.AuthProleId = this.MapParameterOut(command, "@PA_ELEM_AUTH_PROLE_ID", record.AuthProleId);
            record.AuthAssoType = this.MapParameterOut(command, "@PA_ELEM_AUTH_ASSO_TYPE", record.AuthAssoType);
            record.AuthCode = this.MapParameterOut(command, "@PA_ELEM_AUTH_CODE", record.AuthCode);
            record.AuthReqDate = this.MapParameterOut(command, "@PA_ELEM_AUTH_REQ_DATE", record.AuthReqDate);
            record.LastAuthProleId = this.MapParameterOut(command, "@PA_ELEM_LAST_AUTH_PROLE_ID", record.LastAuthProleId);
            record.AuthLastComments = this.MapParameterOut(command, "@PA_ELEM_AUTH_LAST_COMMENTS", record.AuthLastComments);
            record.PshId = this.MapParameterOut(command, "@PA_ELEM_PSH_ID", record.PshId);
            record.BlockDel = this.MapParameterOut(command, "@PA_ELEM_BLOCK_DEL", record.BlockDel);
            record.PrsType = this.MapParameterOut(command, "@PA_ELEM_PRS_TYPE", record.PrsType);
            record.CancelDate = this.MapParameterOut(command, "@PA_ELEM_CANCEL_DATE", record.CancelDate);
            record.Score1 = this.MapParameterOut(command, "@PA_ELEM_SCORE_1", record.Score1);
            record.Score2 = this.MapParameterOut(command, "@PA_ELEM_SCORE_2", record.Score2);
            record.Score3 = this.MapParameterOut(command, "@PA_ELEM_SCORE_3", record.Score3);
            record.Score4 = this.MapParameterOut(command, "@PA_ELEM_SCORE_4", record.Score4);
            record.Score5 = this.MapParameterOut(command, "@PA_ELEM_SCORE_5", record.Score5);
            record.Score6 = this.MapParameterOut(command, "@PA_ELEM_SCORE_6", record.Score6);
            record.PdpeId = this.MapParameterOut(command, "@PA_ELEM_PDPE_ID", record.PdpeId);
            record.ScoEndDte = this.MapParameterOut(command, "@PA_ELEM_SCO_END_DTE", record.ScoEndDte);
            record.LmspTotalTime = this.MapParameterOut(command, "@PA_ELEM_LMSP_TOTAL_TIME", record.LmspTotalTime);
            record.LmspLessonLocation = this.MapParameterOut(command, "@PA_ELEM_LMSP_LESSON_LOCATION", record.LmspLessonLocation);
            record.LmspCompletes = this.MapParameterOut(command, "@PA_ELEM_LMSP_COMPLETES", record.LmspCompletes);
            record.GiftAid = this.MapParameterOut(command, "@PA_ELEM_GIFT_AID", record.GiftAid);
            record.Claimed = this.MapParameterOut(command, "@PA_ELEM_CLAIMED", record.Claimed);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="delId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='delId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllByDelId(String delId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "DelId");
            this.MapParameterIn(command, "@PA_ELEM_DEL_ID", delId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_ELEM_PROD_ID", prodId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='actId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllByActId(String actId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ActId");
            this.MapParameterIn(command, "@PA_ELEM_ACT_ID", actId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='courseId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllByCourseId(String courseId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CourseId");
            this.MapParameterIn(command, "@PA_ELEM_COURSE_ID", courseId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='bookId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllByBookId(String bookId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BookId");
            this.MapParameterIn(command, "@PA_ELEM_BOOK_ID", bookId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='plId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllByPlId(String plId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PlId");
            this.MapParameterIn(command, "@PA_ELEM_PL_ID", plId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sxrefId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='sxrefId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllBySxrefId(String sxrefId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SxrefId");
            this.MapParameterIn(command, "@PA_ELEM_SXREF_ID", sxrefId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_ELEM_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prsId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='prsId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllByPrsId(String prsId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PrsId");
            this.MapParameterIn(command, "@PA_ELEM_PRS_ID", prsId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="elemId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='elemId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllByElemId(String elemId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ElemId");
            this.MapParameterIn(command, "@PA_ELEM_ELEM_ID", elemId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bktId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='bktId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllByBktId(String bktId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BktId");
            this.MapParameterIn(command, "@PA_ELEM_BKT_ID", bktId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pshId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ElementRecord" /> instances that match the specified <paramref name='pshId' />.
        /// </returns>
        public IEnumerable<ElementRecord> FetchAllByPshId(Int32? pshId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PshId");
            this.MapParameterIn(command, "@PA_ELEM_PSH_ID", pshId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IElementRepository.TableName
        {
            get { return this.TableName; }
        }

        void IElementRepository.Create(Consensus.Learning.ElementRecord record)
        {
            this.Create(record);
        }

        void IElementRepository.Modify(Consensus.Learning.ElementRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="delId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="delId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllByDelId(System.String delId)
        {
            return this.FetchAllByDelId(delId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="actId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllByActId(System.String actId)
        {
            return this.FetchAllByActId(actId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllByCourseId(System.String courseId)
        {
            return this.FetchAllByCourseId(courseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="bookId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllByBookId(System.String bookId)
        {
            return this.FetchAllByBookId(bookId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="plId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllByPlId(System.String plId)
        {
            return this.FetchAllByPlId(plId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sxrefId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="sxrefId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllBySxrefId(System.String sxrefId)
        {
            return this.FetchAllBySxrefId(sxrefId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prsId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="prsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllByPrsId(System.String prsId)
        {
            return this.FetchAllByPrsId(prsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="elemId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="elemId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllByElemId(System.String elemId)
        {
            return this.FetchAllByElemId(elemId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bktId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ElementRecord" /> instances that match the specified <paramref name="bktId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllByBktId(System.String bktId)
        {
            return this.FetchAllByBktId(bktId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.ElementRecord> IElementRepository.FetchAllByPshId(System.Nullable<System.Int32> pshId)
        {
            return this.FetchAllByPshId(pshId);
        }

        #endregion
    }
}
