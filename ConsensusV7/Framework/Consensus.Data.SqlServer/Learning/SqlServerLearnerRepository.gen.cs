using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="DelegateRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerLearnerRepository : SqlServerRepository<DelegateRecord, String>, ILearnerRepository
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
            get { return "Delegate"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="DelegateRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_DEL_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Delegate"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="DelegateRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="DelegateRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, DelegateRecord record)
        {
            record.Id = dataRecord["DEL_ID"].ConvertTo<String>();
            record.Lock = dataRecord["DEL_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["DEL_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["DEL_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["DEL_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["DEL_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["DEL_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["DEL_RCV_FROM"].ConvertTo<String>();
            record.LineNo = dataRecord["DEL_LINE_NO"].ConvertTo<Double?>();
            record.BookId = dataRecord["DEL_BOOK_ID"].ConvertTo<String>();
            record.ProductId = dataRecord["DEL_PRODUCT_ID"].ConvertTo<String>();
            record.OrgId = dataRecord["DEL_ORG_ID"].ConvertTo<String>();
            record.PersonId = dataRecord["DEL_PERSON_ID"].ConvertTo<String>();
            record.Quantity = dataRecord["DEL_QUANTITY"].ConvertTo<Double?>();
            record.ListPrice = dataRecord["DEL_LIST_PRICE"].ConvertTo<Double?>();
            record.Discount = dataRecord["DEL_DISCOUNT"].ConvertTo<Double?>();
            record.DisctdPrice = dataRecord["DEL_DISCTD_PRICE"].ConvertTo<Double?>();
            record.NetVal = dataRecord["DEL_NET_VAL"].ConvertTo<Decimal>();
            record.VatCode = dataRecord["DEL_VAT_CODE"].ConvertTo<String>();
            record.VatRate = dataRecord["DEL_VAT_RATE"].ConvertTo<Decimal>();
            record.VatAmt = dataRecord["DEL_VAT_AMT"].ConvertTo<Decimal>();
            record.TotPrice = dataRecord["DEL_TOT_PRICE"].ConvertTo<Decimal>();
            record.UnionId = dataRecord["DEL_UNION_ID"].ConvertTo<String>();
            record.TucRegion = dataRecord["DEL_TUC_REGION"].ConvertTo<String>();
            record.BookApproved = dataRecord["DEL_BOOK_APPROVED"].ConvertTo<Byte?>();
            record.BookApprBy = dataRecord["DEL_BOOK_APPR_BY"].ConvertTo<String>();
            record.BookApprDate = dataRecord["DEL_BOOK_APPR_DATE"].ConvertTo<DateTime?>();
            record.Pack = dataRecord["DEL_PACK"].ConvertTo<String>();
            record.Userint1 = dataRecord["DEL_USERINT_1"].ConvertTo<Byte?>();
            record.Userint2 = dataRecord["DEL_USERINT_2"].ConvertTo<Byte?>();
            record.Userint3 = dataRecord["DEL_USERINT_3"].ConvertTo<Byte?>();
            record.Userint4 = dataRecord["DEL_USERINT_4"].ConvertTo<Byte?>();
            record.Userint5 = dataRecord["DEL_USERINT_5"].ConvertTo<Byte?>();
            record.Userint6 = dataRecord["DEL_USERINT_6"].ConvertTo<Byte?>();
            record.Userint7 = dataRecord["DEL_USERINT_7"].ConvertTo<Byte?>();
            record.Userint8 = dataRecord["DEL_USERINT_8"].ConvertTo<Byte?>();
            record.Userint9 = dataRecord["DEL_USERINT_9"].ConvertTo<Byte?>();
            record.Userint10 = dataRecord["DEL_USERINT_10"].ConvertTo<Byte?>();
            record.ProleId = dataRecord["DEL_PROLE_ID"].ConvertTo<String>();
            record.NotesId = dataRecord["DEL_NOTES_ID"].ConvertTo<String>();
            record.WaitStatus = dataRecord["DEL_WAIT_STATUS"].ConvertTo<String>();
            record.Notes = dataRecord["DEL_NOTES"].ConvertTo<String>();
            record.TimeMvdCust = dataRecord["DEL_TIME_MVD_CUST"].ConvertTo<Byte?>();
            record.CancelDate = dataRecord["DEL_CANCEL_DATE"].ConvertTo<DateTime?>();
            record.CancelBy = dataRecord["DEL_CANCEL_BY"].ConvertTo<String>();
            record.RemindMethod = dataRecord["DEL_REMIND_METHOD"].ConvertTo<String>();
            record.RemindDate = dataRecord["DEL_REMIND_DATE"].ConvertTo<DateTime?>();
            record.RemindBy = dataRecord["DEL_REMIND_BY"].ConvertTo<String>();
            record.ConfirmMethod = dataRecord["DEL_CONFIRM_METHOD"].ConvertTo<String>();
            record.ConfirmDate = dataRecord["DEL_CONFIRM_DATE"].ConvertTo<DateTime?>();
            record.ConfirmBy = dataRecord["DEL_CONFIRM_BY"].ConvertTo<String>();
            record.DelivAddress = dataRecord["DEL_DELIV_ADDRESS"].ConvertTo<String>();
            record.DelId = dataRecord["DEL_DEL_ID"].ConvertTo<String>();
            record.Userchar1 = dataRecord["DEL_USERCHAR_1"].ConvertTo<String>();
            record.SubDelId = dataRecord["DEL_SUB_DEL_ID"].ConvertTo<String>();
            record.Pay = dataRecord["DEL_PAY"].ConvertTo<Byte?>();
            record.Pay2 = dataRecord["DEL_PAY2"].ConvertTo<Byte?>();
            record.TrnId = dataRecord["DEL_TRN_ID"].ConvertTo<String>();
            record.CourseId = dataRecord["DEL_COURSE_ID"].ConvertTo<String>();
            record.BudVal = dataRecord["DEL_BUD_VAL"].ConvertTo<Decimal?>();
            record.BudcId = dataRecord["DEL_BUDC_ID"].ConvertTo<String>();
            record.BudCostId = dataRecord["DEL_BUD_COST_ID"].ConvertTo<String>();
            record.WaitProdId = dataRecord["DEL_WAIT_PROD_ID"].ConvertTo<String>();
            record.WaitDate = dataRecord["DEL_WAIT_DATE"].ConvertTo<DateTime?>();
            record.Team = dataRecord["DEL_TEAM"].ConvertTo<String>();
            record.SpecReq = dataRecord["DEL_SPEC_REQ"].ConvertTo<String>();
            record.BatId = dataRecord["DEL_BAT_ID"].ConvertTo<String>();
            record.BadgeName = dataRecord["DEL_BADGE_NAME"].ConvertTo<String>();
            record.TotTktPnts = dataRecord["DEL_TOT_TKT_PNTS"].ConvertTo<Int32?>();
            record.TckDelId = dataRecord["DEL_TCK_DEL_ID"].ConvertTo<String>();
            record.CourseName = dataRecord["DEL_COURSE_NAME"].ConvertTo<String>();
            record.CourseStDate = dataRecord["DEL_COURSE_ST_DATE"].ConvertTo<DateTime?>();
            record.Pass = dataRecord["DEL_PASS"].ConvertTo<Byte?>();
            record.MepId = dataRecord["DEL_MEP_ID"].ConvertTo<String>();
            record.PriceCalc = dataRecord["DEL_PRICE_CALC"].ConvertTo<String>();
            record.DeposVal = dataRecord["DEL_DEPOS_VAL"].ConvertTo<Decimal?>();
            record.DeposValBc = dataRecord["DEL_DEPOS_VAL_BC"].ConvertTo<Decimal?>();
            record.DeposValBc2 = dataRecord["DEL_DEPOS_VAL_BC2"].ConvertTo<Decimal?>();
            record.AltPhone = dataRecord["DEL_ALT_PHONE"].ConvertTo<String>();
            record.Attrib01 = dataRecord["DEL_ATTRIB01"].ConvertTo<String>();
            record.Attrib02 = dataRecord["DEL_ATTRIB02"].ConvertTo<Byte?>();
            record.Attrib03 = dataRecord["DEL_ATTRIB03"].ConvertTo<Byte?>();
            record.Attrib04 = dataRecord["DEL_ATTRIB04"].ConvertTo<Byte?>();
            record.Attrib05 = dataRecord["DEL_ATTRIB05"].ConvertTo<String>();
            record.Attrib06 = dataRecord["DEL_ATTRIB06"].ConvertTo<String>();
            record.Attrib07 = dataRecord["DEL_ATTRIB07"].ConvertTo<Byte?>();
            record.Attrib08 = dataRecord["DEL_ATTRIB08"].ConvertTo<Byte?>();
            record.Attrib09 = dataRecord["DEL_ATTRIB09"].ConvertTo<String>();
            record.Attrib10 = dataRecord["DEL_ATTRIB10"].ConvertTo<String>();
            record.Attrib11 = dataRecord["DEL_ATTRIB11"].ConvertTo<String>();
            record.DeposUnpaid = dataRecord["DEL_DEPOS_UNPAID"].ConvertTo<Decimal?>();
            record.DeposUnpaidBc = dataRecord["DEL_DEPOS_UNPAID_BC"].ConvertTo<Decimal?>();
            record.DeposUnpaidBc2 = dataRecord["DEL_DEPOS_UNPAID_BC2"].ConvertTo<Decimal?>();
            record.StartDate = dataRecord["DEL_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["DEL_END_DATE"].ConvertTo<DateTime?>();
            record.DonotReprice = dataRecord["DEL_DONOT_REPRICE"].ConvertTo<Byte?>();
            record.DdPaymentStat = dataRecord["DEL_DD_PAYMENT_STAT"].ConvertTo<String>();
            record.CancReason = dataRecord["DEL_CANC_REASON"].ConvertTo<String>();
            record.DeposChgReason = dataRecord["DEL_DEPOS_CHG_REASON"].ConvertTo<String>();
            record.DocRecipient = dataRecord["DEL_DOC_RECIPIENT"].ConvertTo<String>();
            record.Attrib12 = dataRecord["DEL_ATTRIB12"].ConvertTo<Byte?>();
            record.Notes2 = dataRecord["DEL_NOTES2"].ConvertTo<String>();
            record.DocRecipientEmail = dataRecord["DEL_DOC_RECIPIENT_EMAIL"].ConvertTo<String>();
            record.EttId = dataRecord["DEL_ETT_ID"].ConvertTo<String>();
            record.TransferCount = dataRecord["DEL_TRANSFER_COUNT"].ConvertTo<Int32?>();
            record.SubstituteCount = dataRecord["DEL_SUBSTITUTE_COUNT"].ConvertTo<Int32?>();
            record.TransferDelId = dataRecord["DEL_TRANSFER_DEL_ID"].ConvertTo<String>();
            record.DietRequire = dataRecord["DEL_DIET_REQUIRE"].ConvertTo<String>();
            record.Attrib13 = dataRecord["DEL_ATTRIB13"].ConvertTo<String>();
            record.Surname = dataRecord["DEL_SURNAME"].ConvertTo<String>();
            record.Initial = dataRecord["DEL_INITIAL"].ConvertTo<String>();
            record.MemRef = dataRecord["DEL_MEM_REF"].ConvertTo<String>();
            record.AddPostcode = dataRecord["DEL_ADD_POSTCODE"].ConvertTo<String>();
            record.AddId = dataRecord["DEL_ADD_ID"].ConvertTo<String>();
            record.WaitPriority = dataRecord["DEL_WAIT_PRIORITY"].ConvertTo<String>();
            record.TbaGender = dataRecord["DEL_TBA_GENDER"].ConvertTo<String>();
            record.TbaNationality = dataRecord["DEL_TBA_NATIONALITY"].ConvertTo<String>();
            record.TbaEthnicity = dataRecord["DEL_TBA_ETHNICITY"].ConvertTo<String>();
            record.CancelRef = dataRecord["DEL_CANCEL_REF"].ConvertTo<String>();
            record.ShareDetails = dataRecord["DEL_SHARE_DETAILS"].ConvertTo<Byte?>();
            record.AuthStatus = dataRecord["DEL_AUTH_STATUS"].ConvertTo<Int32?>();
            record.MedicalDet = dataRecord["DEL_MEDICAL_DET"].ConvertTo<String>();
            record.DelivCountryId = dataRecord["DEL_DELIV_COUNTRY_ID"].ConvertTo<String>();
            record.DelivFao = dataRecord["DEL_DELIV_FAO"].ConvertTo<String>();
            record.DelivPhone = dataRecord["DEL_DELIV_PHONE"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["DEL_SELCO_SP_ID"].ConvertTo<String>();
            record.Userchar2 = dataRecord["DEL_USERCHAR_2"].ConvertTo<String>();
            record.ExclToken = dataRecord["DEL_EXCL_TOKEN"].ConvertTo<Byte>();
            record.FirstName = dataRecord["DEL_FIRST_NAME"].ConvertTo<String>();
            record.NiNumber = dataRecord["DEL_NI_NUMBER"].ConvertTo<String>();
            record.UniqueRef = dataRecord["DEL_UNIQUE_REF"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="DelegateRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, DelegateRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_DEL_ID", record.Id);
            this.MapParameterIn(command, "@PA_DEL_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_DEL_LINE_NO", record.LineNo == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.LineNo);
            this.MapParameterIn(command, "@PA_DEL_BOOK_ID", record.BookId);
            this.MapParameterIn(command, "@PA_DEL_PRODUCT_ID", record.ProductId);
            this.MapParameterIn(command, "@PA_DEL_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_DEL_PERSON_ID", record.PersonId);
            this.MapParameterIn(command, "@PA_DEL_QUANTITY", record.Quantity == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Quantity);
            this.MapParameterIn(command, "@PA_DEL_LIST_PRICE", record.ListPrice == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ListPrice);
            this.MapParameterIn(command, "@PA_DEL_DISCOUNT", record.Discount == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Discount);
            this.MapParameterIn(command, "@PA_DEL_DISCTD_PRICE", record.DisctdPrice == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.DisctdPrice);
            this.MapParameterIn(command, "@PA_DEL_NET_VAL", record.NetVal == Decimal.MinValue ? 0M : record.NetVal);
            this.MapParameterIn(command, "@PA_DEL_VAT_CODE", record.VatCode);
            this.MapParameterIn(command, "@PA_DEL_VAT_RATE", record.VatRate == Decimal.MinValue ? 0M : record.VatRate);
            this.MapParameterIn(command, "@PA_DEL_VAT_AMT", record.VatAmt == Decimal.MinValue ? 0M : record.VatAmt);
            this.MapParameterIn(command, "@PA_DEL_TOT_PRICE", record.TotPrice == Decimal.MinValue ? 0M : record.TotPrice);
            this.MapParameterIn(command, "@PA_DEL_UNION_ID", record.UnionId);
            this.MapParameterIn(command, "@PA_DEL_TUC_REGION", record.TucRegion);
            this.MapParameterIn(command, "@PA_DEL_BOOK_APPROVED", record.BookApproved);
            this.MapParameterIn(command, "@PA_DEL_BOOK_APPR_BY", record.BookApprBy);
            this.MapParameterIn(command, "@PA_DEL_BOOK_APPR_DATE", record.BookApprDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.BookApprDate);
            this.MapParameterIn(command, "@PA_DEL_PACK", record.Pack);
            this.MapParameterIn(command, "@PA_DEL_USERINT_1", record.Userint1);
            this.MapParameterIn(command, "@PA_DEL_USERINT_2", record.Userint2);
            this.MapParameterIn(command, "@PA_DEL_USERINT_3", record.Userint3);
            this.MapParameterIn(command, "@PA_DEL_USERINT_4", record.Userint4);
            this.MapParameterIn(command, "@PA_DEL_USERINT_5", record.Userint5);
            this.MapParameterIn(command, "@PA_DEL_USERINT_6", record.Userint6);
            this.MapParameterIn(command, "@PA_DEL_USERINT_7", record.Userint7);
            this.MapParameterIn(command, "@PA_DEL_USERINT_8", record.Userint8);
            this.MapParameterIn(command, "@PA_DEL_USERINT_9", record.Userint9);
            this.MapParameterIn(command, "@PA_DEL_USERINT_10", record.Userint10);
            this.MapParameterIn(command, "@PA_DEL_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_DEL_NOTES_ID", record.NotesId);
            this.MapParameterIn(command, "@PA_DEL_WAIT_STATUS", record.WaitStatus);
            this.MapParameterIn(command, "@PA_DEL_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_DEL_TIME_MVD_CUST", record.TimeMvdCust);
            this.MapParameterIn(command, "@PA_DEL_CANCEL_DATE", record.CancelDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CancelDate);
            this.MapParameterIn(command, "@PA_DEL_CANCEL_BY", record.CancelBy);
            this.MapParameterIn(command, "@PA_DEL_REMIND_METHOD", record.RemindMethod);
            this.MapParameterIn(command, "@PA_DEL_REMIND_DATE", record.RemindDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RemindDate);
            this.MapParameterIn(command, "@PA_DEL_REMIND_BY", record.RemindBy);
            this.MapParameterIn(command, "@PA_DEL_CONFIRM_METHOD", record.ConfirmMethod);
            this.MapParameterIn(command, "@PA_DEL_CONFIRM_DATE", record.ConfirmDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ConfirmDate);
            this.MapParameterIn(command, "@PA_DEL_CONFIRM_BY", record.ConfirmBy);
            this.MapParameterIn(command, "@PA_DEL_DELIV_ADDRESS", record.DelivAddress);
            this.MapParameterIn(command, "@PA_DEL_DEL_ID", record.DelId);
            this.MapParameterIn(command, "@PA_DEL_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_DEL_SUB_DEL_ID", record.SubDelId);
            this.MapParameterIn(command, "@PA_DEL_PAY", record.Pay);
            this.MapParameterIn(command, "@PA_DEL_PAY2", record.Pay2);
            this.MapParameterIn(command, "@PA_DEL_TRN_ID", record.TrnId);
            this.MapParameterIn(command, "@PA_DEL_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_DEL_BUD_VAL", record.BudVal == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.BudVal);
            this.MapParameterIn(command, "@PA_DEL_BUDC_ID", record.BudcId);
            this.MapParameterIn(command, "@PA_DEL_BUD_COST_ID", record.BudCostId);
            this.MapParameterIn(command, "@PA_DEL_WAIT_PROD_ID", record.WaitProdId);
            this.MapParameterIn(command, "@PA_DEL_WAIT_DATE", record.WaitDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.WaitDate);
            this.MapParameterIn(command, "@PA_DEL_TEAM", record.Team);
            this.MapParameterIn(command, "@PA_DEL_SPEC_REQ", record.SpecReq);
            this.MapParameterIn(command, "@PA_DEL_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_DEL_BADGE_NAME", record.BadgeName);
            this.MapParameterIn(command, "@PA_DEL_TOT_TKT_PNTS", record.TotTktPnts == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TotTktPnts);
            this.MapParameterIn(command, "@PA_DEL_TCK_DEL_ID", record.TckDelId);
            this.MapParameterIn(command, "@PA_DEL_COURSE_NAME", record.CourseName);
            this.MapParameterIn(command, "@PA_DEL_COURSE_ST_DATE", record.CourseStDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CourseStDate);
            this.MapParameterIn(command, "@PA_DEL_PASS", record.Pass);
            this.MapParameterIn(command, "@PA_DEL_MEP_ID", record.MepId);
            this.MapParameterIn(command, "@PA_DEL_PRICE_CALC", record.PriceCalc);
            this.MapParameterIn(command, "@PA_DEL_DEPOS_VAL", record.DeposVal == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DeposVal);
            this.MapParameterIn(command, "@PA_DEL_DEPOS_VAL_BC", record.DeposValBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DeposValBc);
            this.MapParameterIn(command, "@PA_DEL_DEPOS_VAL_BC2", record.DeposValBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DeposValBc2);
            this.MapParameterIn(command, "@PA_DEL_ALT_PHONE", record.AltPhone);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB01", record.Attrib01);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB02", record.Attrib02);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB03", record.Attrib03);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB04", record.Attrib04);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB05", record.Attrib05);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB06", record.Attrib06);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB07", record.Attrib07);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB08", record.Attrib08);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB09", record.Attrib09);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB10", record.Attrib10);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB11", record.Attrib11);
            this.MapParameterIn(command, "@PA_DEL_DEPOS_UNPAID", record.DeposUnpaid == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DeposUnpaid);
            this.MapParameterIn(command, "@PA_DEL_DEPOS_UNPAID_BC", record.DeposUnpaidBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DeposUnpaidBc);
            this.MapParameterIn(command, "@PA_DEL_DEPOS_UNPAID_BC2", record.DeposUnpaidBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DeposUnpaidBc2);
            this.MapParameterIn(command, "@PA_DEL_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_DEL_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_DEL_DONOT_REPRICE", record.DonotReprice);
            this.MapParameterIn(command, "@PA_DEL_DD_PAYMENT_STAT", record.DdPaymentStat);
            this.MapParameterIn(command, "@PA_DEL_CANC_REASON", record.CancReason);
            this.MapParameterIn(command, "@PA_DEL_DEPOS_CHG_REASON", record.DeposChgReason);
            this.MapParameterIn(command, "@PA_DEL_DOC_RECIPIENT", record.DocRecipient);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB12", record.Attrib12);
            this.MapParameterIn(command, "@PA_DEL_NOTES2", record.Notes2);
            this.MapParameterIn(command, "@PA_DEL_DOC_RECIPIENT_EMAIL", record.DocRecipientEmail);
            this.MapParameterIn(command, "@PA_DEL_ETT_ID", record.EttId);
            this.MapParameterIn(command, "@PA_DEL_TRANSFER_COUNT", record.TransferCount == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TransferCount);
            this.MapParameterIn(command, "@PA_DEL_SUBSTITUTE_COUNT", record.SubstituteCount == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SubstituteCount);
            this.MapParameterIn(command, "@PA_DEL_TRANSFER_DEL_ID", record.TransferDelId);
            this.MapParameterIn(command, "@PA_DEL_DIET_REQUIRE", record.DietRequire);
            this.MapParameterIn(command, "@PA_DEL_ATTRIB13", record.Attrib13);
            this.MapParameterIn(command, "@PA_DEL_SURNAME", record.Surname);
            this.MapParameterIn(command, "@PA_DEL_INITIAL", record.Initial);
            this.MapParameterIn(command, "@PA_DEL_MEM_REF", record.MemRef);
            this.MapParameterIn(command, "@PA_DEL_ADD_POSTCODE", record.AddPostcode);
            this.MapParameterIn(command, "@PA_DEL_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_DEL_WAIT_PRIORITY", record.WaitPriority);
            this.MapParameterIn(command, "@PA_DEL_TBA_GENDER", record.TbaGender);
            this.MapParameterIn(command, "@PA_DEL_TBA_NATIONALITY", record.TbaNationality);
            this.MapParameterIn(command, "@PA_DEL_TBA_ETHNICITY", record.TbaEthnicity);
            this.MapParameterIn(command, "@PA_DEL_CANCEL_REF", record.CancelRef);
            this.MapParameterIn(command, "@PA_DEL_SHARE_DETAILS", record.ShareDetails);
            this.MapParameterIn(command, "@PA_DEL_AUTH_STATUS", record.AuthStatus == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.AuthStatus);
            this.MapParameterIn(command, "@PA_DEL_MEDICAL_DET", record.MedicalDet);
            this.MapParameterIn(command, "@PA_DEL_DELIV_COUNTRY_ID", record.DelivCountryId);
            this.MapParameterIn(command, "@PA_DEL_DELIV_FAO", record.DelivFao);
            this.MapParameterIn(command, "@PA_DEL_DELIV_PHONE", record.DelivPhone);
            this.MapParameterIn(command, "@PA_DEL_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_DEL_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_DEL_EXCL_TOKEN", record.ExclToken);
            this.MapParameterIn(command, "@PA_DEL_FIRST_NAME", record.FirstName);
            this.MapParameterIn(command, "@PA_DEL_NI_NUMBER", record.NiNumber);
            this.MapParameterIn(command, "@PA_DEL_UNIQUE_REF", record.UniqueRef);
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
        ///     The <see cref="DelegateRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, DelegateRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_DEL_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_DEL_LOCK", record.Lock);
            record.LineNo = this.MapParameterOut(command, "@PA_DEL_LINE_NO", record.LineNo);
            record.BookId = this.MapParameterOut(command, "@PA_DEL_BOOK_ID", record.BookId);
            record.ProductId = this.MapParameterOut(command, "@PA_DEL_PRODUCT_ID", record.ProductId);
            record.OrgId = this.MapParameterOut(command, "@PA_DEL_ORG_ID", record.OrgId);
            record.PersonId = this.MapParameterOut(command, "@PA_DEL_PERSON_ID", record.PersonId);
            record.Quantity = this.MapParameterOut(command, "@PA_DEL_QUANTITY", record.Quantity);
            record.ListPrice = this.MapParameterOut(command, "@PA_DEL_LIST_PRICE", record.ListPrice);
            record.Discount = this.MapParameterOut(command, "@PA_DEL_DISCOUNT", record.Discount);
            record.DisctdPrice = this.MapParameterOut(command, "@PA_DEL_DISCTD_PRICE", record.DisctdPrice);
            record.NetVal = this.MapParameterOut(command, "@PA_DEL_NET_VAL", record.NetVal);
            record.VatCode = this.MapParameterOut(command, "@PA_DEL_VAT_CODE", record.VatCode);
            record.VatRate = this.MapParameterOut(command, "@PA_DEL_VAT_RATE", record.VatRate);
            record.VatAmt = this.MapParameterOut(command, "@PA_DEL_VAT_AMT", record.VatAmt);
            record.TotPrice = this.MapParameterOut(command, "@PA_DEL_TOT_PRICE", record.TotPrice);
            record.UnionId = this.MapParameterOut(command, "@PA_DEL_UNION_ID", record.UnionId);
            record.TucRegion = this.MapParameterOut(command, "@PA_DEL_TUC_REGION", record.TucRegion);
            record.BookApproved = this.MapParameterOut(command, "@PA_DEL_BOOK_APPROVED", record.BookApproved);
            record.BookApprBy = this.MapParameterOut(command, "@PA_DEL_BOOK_APPR_BY", record.BookApprBy);
            record.BookApprDate = this.MapParameterOut(command, "@PA_DEL_BOOK_APPR_DATE", record.BookApprDate);
            record.Pack = this.MapParameterOut(command, "@PA_DEL_PACK", record.Pack);
            record.Userint1 = this.MapParameterOut(command, "@PA_DEL_USERINT_1", record.Userint1);
            record.Userint2 = this.MapParameterOut(command, "@PA_DEL_USERINT_2", record.Userint2);
            record.Userint3 = this.MapParameterOut(command, "@PA_DEL_USERINT_3", record.Userint3);
            record.Userint4 = this.MapParameterOut(command, "@PA_DEL_USERINT_4", record.Userint4);
            record.Userint5 = this.MapParameterOut(command, "@PA_DEL_USERINT_5", record.Userint5);
            record.Userint6 = this.MapParameterOut(command, "@PA_DEL_USERINT_6", record.Userint6);
            record.Userint7 = this.MapParameterOut(command, "@PA_DEL_USERINT_7", record.Userint7);
            record.Userint8 = this.MapParameterOut(command, "@PA_DEL_USERINT_8", record.Userint8);
            record.Userint9 = this.MapParameterOut(command, "@PA_DEL_USERINT_9", record.Userint9);
            record.Userint10 = this.MapParameterOut(command, "@PA_DEL_USERINT_10", record.Userint10);
            record.ProleId = this.MapParameterOut(command, "@PA_DEL_PROLE_ID", record.ProleId);
            record.NotesId = this.MapParameterOut(command, "@PA_DEL_NOTES_ID", record.NotesId);
            record.WaitStatus = this.MapParameterOut(command, "@PA_DEL_WAIT_STATUS", record.WaitStatus);
            record.Notes = this.MapParameterOut(command, "@PA_DEL_NOTES", record.Notes);
            record.TimeMvdCust = this.MapParameterOut(command, "@PA_DEL_TIME_MVD_CUST", record.TimeMvdCust);
            record.CancelDate = this.MapParameterOut(command, "@PA_DEL_CANCEL_DATE", record.CancelDate);
            record.CancelBy = this.MapParameterOut(command, "@PA_DEL_CANCEL_BY", record.CancelBy);
            record.RemindMethod = this.MapParameterOut(command, "@PA_DEL_REMIND_METHOD", record.RemindMethod);
            record.RemindDate = this.MapParameterOut(command, "@PA_DEL_REMIND_DATE", record.RemindDate);
            record.RemindBy = this.MapParameterOut(command, "@PA_DEL_REMIND_BY", record.RemindBy);
            record.ConfirmMethod = this.MapParameterOut(command, "@PA_DEL_CONFIRM_METHOD", record.ConfirmMethod);
            record.ConfirmDate = this.MapParameterOut(command, "@PA_DEL_CONFIRM_DATE", record.ConfirmDate);
            record.ConfirmBy = this.MapParameterOut(command, "@PA_DEL_CONFIRM_BY", record.ConfirmBy);
            record.DelivAddress = this.MapParameterOut(command, "@PA_DEL_DELIV_ADDRESS", record.DelivAddress);
            record.DelId = this.MapParameterOut(command, "@PA_DEL_DEL_ID", record.DelId);
            record.Userchar1 = this.MapParameterOut(command, "@PA_DEL_USERCHAR_1", record.Userchar1);
            record.SubDelId = this.MapParameterOut(command, "@PA_DEL_SUB_DEL_ID", record.SubDelId);
            record.Pay = this.MapParameterOut(command, "@PA_DEL_PAY", record.Pay);
            record.Pay2 = this.MapParameterOut(command, "@PA_DEL_PAY2", record.Pay2);
            record.TrnId = this.MapParameterOut(command, "@PA_DEL_TRN_ID", record.TrnId);
            record.CourseId = this.MapParameterOut(command, "@PA_DEL_COURSE_ID", record.CourseId);
            record.BudVal = this.MapParameterOut(command, "@PA_DEL_BUD_VAL", record.BudVal);
            record.BudcId = this.MapParameterOut(command, "@PA_DEL_BUDC_ID", record.BudcId);
            record.BudCostId = this.MapParameterOut(command, "@PA_DEL_BUD_COST_ID", record.BudCostId);
            record.WaitProdId = this.MapParameterOut(command, "@PA_DEL_WAIT_PROD_ID", record.WaitProdId);
            record.WaitDate = this.MapParameterOut(command, "@PA_DEL_WAIT_DATE", record.WaitDate);
            record.Team = this.MapParameterOut(command, "@PA_DEL_TEAM", record.Team);
            record.SpecReq = this.MapParameterOut(command, "@PA_DEL_SPEC_REQ", record.SpecReq);
            record.BatId = this.MapParameterOut(command, "@PA_DEL_BAT_ID", record.BatId);
            record.BadgeName = this.MapParameterOut(command, "@PA_DEL_BADGE_NAME", record.BadgeName);
            record.TotTktPnts = this.MapParameterOut(command, "@PA_DEL_TOT_TKT_PNTS", record.TotTktPnts);
            record.TckDelId = this.MapParameterOut(command, "@PA_DEL_TCK_DEL_ID", record.TckDelId);
            record.CourseName = this.MapParameterOut(command, "@PA_DEL_COURSE_NAME", record.CourseName);
            record.CourseStDate = this.MapParameterOut(command, "@PA_DEL_COURSE_ST_DATE", record.CourseStDate);
            record.Pass = this.MapParameterOut(command, "@PA_DEL_PASS", record.Pass);
            record.MepId = this.MapParameterOut(command, "@PA_DEL_MEP_ID", record.MepId);
            record.PriceCalc = this.MapParameterOut(command, "@PA_DEL_PRICE_CALC", record.PriceCalc);
            record.DeposVal = this.MapParameterOut(command, "@PA_DEL_DEPOS_VAL", record.DeposVal);
            record.DeposValBc = this.MapParameterOut(command, "@PA_DEL_DEPOS_VAL_BC", record.DeposValBc);
            record.DeposValBc2 = this.MapParameterOut(command, "@PA_DEL_DEPOS_VAL_BC2", record.DeposValBc2);
            record.AltPhone = this.MapParameterOut(command, "@PA_DEL_ALT_PHONE", record.AltPhone);
            record.Attrib01 = this.MapParameterOut(command, "@PA_DEL_ATTRIB01", record.Attrib01);
            record.Attrib02 = this.MapParameterOut(command, "@PA_DEL_ATTRIB02", record.Attrib02);
            record.Attrib03 = this.MapParameterOut(command, "@PA_DEL_ATTRIB03", record.Attrib03);
            record.Attrib04 = this.MapParameterOut(command, "@PA_DEL_ATTRIB04", record.Attrib04);
            record.Attrib05 = this.MapParameterOut(command, "@PA_DEL_ATTRIB05", record.Attrib05);
            record.Attrib06 = this.MapParameterOut(command, "@PA_DEL_ATTRIB06", record.Attrib06);
            record.Attrib07 = this.MapParameterOut(command, "@PA_DEL_ATTRIB07", record.Attrib07);
            record.Attrib08 = this.MapParameterOut(command, "@PA_DEL_ATTRIB08", record.Attrib08);
            record.Attrib09 = this.MapParameterOut(command, "@PA_DEL_ATTRIB09", record.Attrib09);
            record.Attrib10 = this.MapParameterOut(command, "@PA_DEL_ATTRIB10", record.Attrib10);
            record.Attrib11 = this.MapParameterOut(command, "@PA_DEL_ATTRIB11", record.Attrib11);
            record.DeposUnpaid = this.MapParameterOut(command, "@PA_DEL_DEPOS_UNPAID", record.DeposUnpaid);
            record.DeposUnpaidBc = this.MapParameterOut(command, "@PA_DEL_DEPOS_UNPAID_BC", record.DeposUnpaidBc);
            record.DeposUnpaidBc2 = this.MapParameterOut(command, "@PA_DEL_DEPOS_UNPAID_BC2", record.DeposUnpaidBc2);
            record.StartDate = this.MapParameterOut(command, "@PA_DEL_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_DEL_END_DATE", record.EndDate);
            record.DonotReprice = this.MapParameterOut(command, "@PA_DEL_DONOT_REPRICE", record.DonotReprice);
            record.DdPaymentStat = this.MapParameterOut(command, "@PA_DEL_DD_PAYMENT_STAT", record.DdPaymentStat);
            record.CancReason = this.MapParameterOut(command, "@PA_DEL_CANC_REASON", record.CancReason);
            record.DeposChgReason = this.MapParameterOut(command, "@PA_DEL_DEPOS_CHG_REASON", record.DeposChgReason);
            record.DocRecipient = this.MapParameterOut(command, "@PA_DEL_DOC_RECIPIENT", record.DocRecipient);
            record.Attrib12 = this.MapParameterOut(command, "@PA_DEL_ATTRIB12", record.Attrib12);
            record.Notes2 = this.MapParameterOut(command, "@PA_DEL_NOTES2", record.Notes2);
            record.DocRecipientEmail = this.MapParameterOut(command, "@PA_DEL_DOC_RECIPIENT_EMAIL", record.DocRecipientEmail);
            record.EttId = this.MapParameterOut(command, "@PA_DEL_ETT_ID", record.EttId);
            record.TransferCount = this.MapParameterOut(command, "@PA_DEL_TRANSFER_COUNT", record.TransferCount);
            record.SubstituteCount = this.MapParameterOut(command, "@PA_DEL_SUBSTITUTE_COUNT", record.SubstituteCount);
            record.TransferDelId = this.MapParameterOut(command, "@PA_DEL_TRANSFER_DEL_ID", record.TransferDelId);
            record.DietRequire = this.MapParameterOut(command, "@PA_DEL_DIET_REQUIRE", record.DietRequire);
            record.Attrib13 = this.MapParameterOut(command, "@PA_DEL_ATTRIB13", record.Attrib13);
            record.Surname = this.MapParameterOut(command, "@PA_DEL_SURNAME", record.Surname);
            record.Initial = this.MapParameterOut(command, "@PA_DEL_INITIAL", record.Initial);
            record.MemRef = this.MapParameterOut(command, "@PA_DEL_MEM_REF", record.MemRef);
            record.AddPostcode = this.MapParameterOut(command, "@PA_DEL_ADD_POSTCODE", record.AddPostcode);
            record.AddId = this.MapParameterOut(command, "@PA_DEL_ADD_ID", record.AddId);
            record.WaitPriority = this.MapParameterOut(command, "@PA_DEL_WAIT_PRIORITY", record.WaitPriority);
            record.TbaGender = this.MapParameterOut(command, "@PA_DEL_TBA_GENDER", record.TbaGender);
            record.TbaNationality = this.MapParameterOut(command, "@PA_DEL_TBA_NATIONALITY", record.TbaNationality);
            record.TbaEthnicity = this.MapParameterOut(command, "@PA_DEL_TBA_ETHNICITY", record.TbaEthnicity);
            record.CancelRef = this.MapParameterOut(command, "@PA_DEL_CANCEL_REF", record.CancelRef);
            record.ShareDetails = this.MapParameterOut(command, "@PA_DEL_SHARE_DETAILS", record.ShareDetails);
            record.AuthStatus = this.MapParameterOut(command, "@PA_DEL_AUTH_STATUS", record.AuthStatus);
            record.MedicalDet = this.MapParameterOut(command, "@PA_DEL_MEDICAL_DET", record.MedicalDet);
            record.DelivCountryId = this.MapParameterOut(command, "@PA_DEL_DELIV_COUNTRY_ID", record.DelivCountryId);
            record.DelivFao = this.MapParameterOut(command, "@PA_DEL_DELIV_FAO", record.DelivFao);
            record.DelivPhone = this.MapParameterOut(command, "@PA_DEL_DELIV_PHONE", record.DelivPhone);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_DEL_SELCO_SP_ID", record.SelcoSpId);
            record.Userchar2 = this.MapParameterOut(command, "@PA_DEL_USERCHAR_2", record.Userchar2);
            record.ExclToken = this.MapParameterOut(command, "@PA_DEL_EXCL_TOKEN", record.ExclToken);
            record.FirstName = this.MapParameterOut(command, "@PA_DEL_FIRST_NAME", record.FirstName);
            record.NiNumber = this.MapParameterOut(command, "@PA_DEL_NI_NUMBER", record.NiNumber);
            record.UniqueRef = this.MapParameterOut(command, "@PA_DEL_UNIQUE_REF", record.UniqueRef);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="DelegateRecord" /> instances that match the specified <paramref name='bookId' />.
        /// </returns>
        public IEnumerable<DelegateRecord> FetchAllByBookId(String bookId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BookId");
            this.MapParameterIn(command, "@PA_DEL_BOOK_ID", bookId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="DelegateRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<DelegateRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_DEL_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="DelegateRecord" /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<DelegateRecord> FetchAllByPersonId(String personId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PersonId");
            this.MapParameterIn(command, "@PA_DEL_PERSON_ID", personId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="DelegateRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<DelegateRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_DEL_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="DelegateRecord" /> instances that match the specified <paramref name='mepId' />.
        /// </returns>
        public IEnumerable<DelegateRecord> FetchAllByMepId(String mepId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MepId");
            this.MapParameterIn(command, "@PA_DEL_MEP_ID", mepId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="DelegateRecord" /> instances that match the specified <paramref name='addId' />.
        /// </returns>
        public IEnumerable<DelegateRecord> FetchAllByAddId(String addId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AddId");
            this.MapParameterIn(command, "@PA_DEL_ADD_ID", addId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ILearnerRepository.TableName
        {
            get { return this.TableName; }
        }

        void ILearnerRepository.Create(Consensus.Learning.DelegateRecord record)
        {
            this.Create(record);
        }

        void ILearnerRepository.Modify(Consensus.Learning.DelegateRecord record)
        {
            this.Modify(record);
        }

        Consensus.Learning.DelegateRecord ILearnerRepository.DelegatesToConfirm(System.String bookId, System.String approver)
        {
            return this.DelegatesToConfirm(bookId, approver);
        }

        Consensus.Learning.DelegateRecord ILearnerRepository.CancelBooking(System.String bookId, System.String userLoginId)
        {
            return this.CancelBooking(bookId, userLoginId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances that match the specified <paramref name="bookId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.DelegateRecord> ILearnerRepository.FetchAllByBookId(System.String bookId)
        {
            return this.FetchAllByBookId(bookId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.DelegateRecord> ILearnerRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.DelegateRecord> ILearnerRepository.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.DelegateRecord> ILearnerRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mepId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances that match the specified <paramref name="mepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.DelegateRecord> ILearnerRepository.FetchAllByMepId(System.String mepId)
        {
            return this.FetchAllByMepId(mepId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.DelegateRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.DelegateRecord> ILearnerRepository.FetchAllByAddId(System.String addId)
        {
            return this.FetchAllByAddId(addId);
        }

        #endregion
    }
}
