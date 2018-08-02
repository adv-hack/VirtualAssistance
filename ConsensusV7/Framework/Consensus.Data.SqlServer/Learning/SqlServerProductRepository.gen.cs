using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProductRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerProductRepository : SqlServerRepository<ProductRecord, String>, IProductRepository
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
            get { return "Product"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ProductRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PROD_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Product"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ProductRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProductRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ProductRecord record)
        {
            record.Id = dataRecord["PROD_ID"].ConvertTo<String>();
            record.Lock = dataRecord["PROD_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["PROD_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PROD_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PROD_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PROD_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PROD_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PROD_RCV_FROM"].ConvertTo<String>();
            record.GroupId = dataRecord["PROD_GROUP_ID"].ConvertTo<String>();
            record.Ref = dataRecord["PROD_REF"].ConvertTo<String>();
            record.Name = dataRecord["PROD_NAME"].ConvertTo<String>();
            record.Descrip = dataRecord["PROD_DESCRIP"].ConvertTo<String>();
            record.Text1 = dataRecord["PROD_TEXT1"].ConvertTo<String>();
            record.Text2 = dataRecord["PROD_TEXT2"].ConvertTo<String>();
            record.Text3 = dataRecord["PROD_TEXT3"].ConvertTo<String>();
            record.Text4 = dataRecord["PROD_TEXT4"].ConvertTo<String>();
            record.Text5 = dataRecord["PROD_TEXT5"].ConvertTo<String>();
            record.SyProduct = dataRecord["PROD_SY_PRODUCT"].ConvertTo<Byte?>();
            record.Type = dataRecord["PROD_TYPE"].ConvertTo<String>();
            record.Category = dataRecord["PROD_CATEGORY"].ConvertTo<String>();
            record.Status = dataRecord["PROD_STATUS"].ConvertTo<String>();
            record.Group = dataRecord["PROD_GROUP"].ConvertTo<String>();
            record.Unit = dataRecord["PROD_UNIT"].ConvertTo<String>();
            record.Price = dataRecord["PROD_PRICE"].ConvertTo<Double?>();
            record.BlockPrice = dataRecord["PROD_BLOCK_PRICE"].ConvertTo<Double?>();
            record.SparePrice = dataRecord["PROD_SPARE_PRICE"].ConvertTo<Double?>();
            record.CostPrice = dataRecord["PROD_COST_PRICE"].ConvertTo<Double?>();
            record.CostCode = dataRecord["PROD_COST_CODE"].ConvertTo<String>();
            record.RevCode = dataRecord["PROD_REV_CODE"].ConvertTo<String>();
            record.DiscSched = dataRecord["PROD_DISC_SCHED"].ConvertTo<String>();
            record.VatCode = dataRecord["PROD_VAT_CODE"].ConvertTo<String>();
            record.MinAttend = dataRecord["PROD_MIN_ATTEND"].ConvertTo<Double?>();
            record.MaxAttend = dataRecord["PROD_MAX_ATTEND"].ConvertTo<Double?>();
            record.CourseLen = dataRecord["PROD_COURSE_LEN"].ConvertTo<Double?>();
            record.DiaryType = dataRecord["PROD_DIARY_TYPE"].ConvertTo<String>();
            record.NormCollege = dataRecord["PROD_NORM_COLLEGE"].ConvertTo<String>();
            record.NextCourse = dataRecord["PROD_NEXT_COURSE"].ConvertTo<String>();
            record.SpareFlag1 = dataRecord["PROD_SPARE_FLAG1"].ConvertTo<Byte?>();
            record.SpareFlag2 = dataRecord["PROD_SPARE_FLAG2"].ConvertTo<Byte?>();
            record.CertPrinted = dataRecord["PROD_CERT_PRINTED"].ConvertTo<Byte?>();
            record.TucRegion = dataRecord["PROD_TUC_REGION"].ConvertTo<String>();
            record.EntryDate = dataRecord["PROD_ENTRY_DATE"].ConvertTo<DateTime?>();
            record.ProjectNo = dataRecord["PROD_PROJECT_NO"].ConvertTo<String>();
            record.CommissionBy = dataRecord["PROD_COMMISSION_BY"].ConvertTo<String>();
            record.Key = dataRecord["PROD_KEY"].ConvertTo<String>();
            record.Code = dataRecord["PROD_CODE"].ConvertTo<String>();
            record.TypeLow = dataRecord["PROD_TYPE_LOW"].ConvertTo<String>();
            record.RefLow = dataRecord["PROD_REF_LOW"].ConvertTo<String>();
            record.QuesSet = dataRecord["PROD_QUES_SET"].ConvertTo<Byte?>();
            record.StartQno = dataRecord["PROD_START_QNO"].ConvertTo<Byte?>();
            record.SellHint = dataRecord["PROD_SELL_HINT"].ConvertTo<String>();
            record.Det = dataRecord["PROD_DET"].ConvertTo<String>();
            record.Ass = dataRecord["PROD_ASS"].ConvertTo<String>();
            record.RetailPrice = dataRecord["PROD_RETAIL_PRICE"].ConvertTo<Double?>();
            record.Margin = dataRecord["PROD_MARGIN"].ConvertTo<Double?>();
            record.SupplierName = dataRecord["PROD_SUPPLIER_NAME"].ConvertTo<String>();
            record.SupplierId = dataRecord["PROD_SUPPLIER_ID"].ConvertTo<String>();
            record.PicId = dataRecord["PROD_PIC_ID"].ConvertTo<String>();
            record.JoinLett = dataRecord["PROD_JOIN_LETT"].ConvertTo<String>();
            record.ConfirmLett = dataRecord["PROD_CONFIRM_LETT"].ConvertTo<String>();
            record.QuestLett = dataRecord["PROD_QUEST_LETT"].ConvertTo<String>();
            record.SurvLett = dataRecord["PROD_SURV_LETT"].ConvertTo<String>();
            record.NoCstNoSel = dataRecord["PROD_NO_CST_NO_SEL"].ConvertTo<Byte?>();
            record.ProvLett = dataRecord["PROD_PROV_LETT"].ConvertTo<String>();
            record.InvLett = dataRecord["PROD_INV_LETT"].ConvertTo<String>();
            record.DoNotInvoic = dataRecord["PROD_DO_NOT_INVOIC"].ConvertTo<Byte?>();
            record.TopLevel = dataRecord["PROD_TOP_LEVEL"].ConvertTo<Byte?>();
            record.AddId = dataRecord["PROD_ADD_ID"].ConvertTo<String>();
            record.RoomType = dataRecord["PROD_ROOM_TYPE"].ConvertTo<String>();
            record.RoomGrade = dataRecord["PROD_ROOM_GRADE"].ConvertTo<String>();
            record.State = dataRecord["PROD_STATE"].ConvertTo<Byte?>();
            record.Stocked = dataRecord["PROD_STOCKED"].ConvertTo<Byte?>();
            record.QtyAv = dataRecord["PROD_QTY_AV"].ConvertTo<Double?>();
            record.QtyAc = dataRecord["PROD_QTY_AC"].ConvertTo<Double?>();
            record.QtyBo = dataRecord["PROD_QTY_BO"].ConvertTo<Double?>();
            record.QtyOr = dataRecord["PROD_QTY_OR"].ConvertTo<Double?>();
            record.Coursemaster = dataRecord["PROD_COURSEMASTER"].ConvertTo<Byte?>();
            record.Currency = dataRecord["PROD_CURRENCY"].ConvertTo<String>();
            record.LastUsed = dataRecord["PROD_LAST_USED"].ConvertTo<DateTime?>();
            record.DailyDelRat = dataRecord["PROD_DAILY_DEL_RAT"].ConvertTo<Double?>();
            record.OvernightRat = dataRecord["PROD_OVERNIGHT_RAT"].ConvertTo<Double?>();
            record.SyndicateRat = dataRecord["PROD_SYNDICATE_RAT"].ConvertTo<Double?>();
            record.Equip1 = dataRecord["PROD_EQUIP1"].ConvertTo<Double?>();
            record.Equip2 = dataRecord["PROD_EQUIP2"].ConvertTo<Double?>();
            record.Equip3 = dataRecord["PROD_EQUIP3"].ConvertTo<Double?>();
            record.Equip4 = dataRecord["PROD_EQUIP4"].ConvertTo<Double?>();
            record.Equip5 = dataRecord["PROD_EQUIP5"].ConvertTo<Double?>();
            record.Equip6 = dataRecord["PROD_EQUIP6"].ConvertTo<Double?>();
            record.Equip7 = dataRecord["PROD_EQUIP7"].ConvertTo<Double?>();
            record.Equip8 = dataRecord["PROD_EQUIP8"].ConvertTo<Double?>();
            record.Equip9 = dataRecord["PROD_EQUIP9"].ConvertTo<Double?>();
            record.Equip10 = dataRecord["PROD_EQUIP10"].ConvertTo<Double?>();
            record.Equip11 = dataRecord["PROD_EQUIP11"].ConvertTo<Double?>();
            record.Equip12 = dataRecord["PROD_EQUIP12"].ConvertTo<Double?>();
            record.Equip13 = dataRecord["PROD_EQUIP13"].ConvertTo<Double?>();
            record.Equip14 = dataRecord["PROD_EQUIP14"].ConvertTo<Double?>();
            record.Equip15 = dataRecord["PROD_EQUIP15"].ConvertTo<Double?>();
            record.Generalised = dataRecord["PROD_GENERALISED"].ConvertTo<Byte?>();
            record.NetwType = dataRecord["PROD_NETW_TYPE"].ConvertTo<String>();
            record.RenType = dataRecord["PROD_REN_TYPE"].ConvertTo<String>();
            record.OldDesc = dataRecord["PROD_OLD_DESC"].ConvertTo<String>();
            record.Class = dataRecord["PROD_CLASS"].ConvertTo<String>();
            record.TiCode = dataRecord["PROD_TI_CODE"].ConvertTo<String>();
            record.DepReps = dataRecord["PROD_DEP_REPS"].ConvertTo<String>();
            record.LeadDept = dataRecord["PROD_LEAD_DEPT"].ConvertTo<Byte?>();
            record.Current = dataRecord["PROD_CURRENT"].ConvertTo<String>();
            record.Media = dataRecord["PROD_MEDIA"].ConvertTo<String>();
            record.MaxDisc = dataRecord["PROD_MAX_DISC"].ConvertTo<Double?>();
            record.Userchar1 = dataRecord["PROD_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["PROD_USERCHAR_2"].ConvertTo<String>();
            record.Usernum1 = dataRecord["PROD_USERNUM_1"].ConvertTo<Decimal?>();
            record.AvailDate = dataRecord["PROD_AVAIL_DATE"].ConvertTo<DateTime?>();
            record.CertFmt = dataRecord["PROD_CERT_FMT"].ConvertTo<String>();
            record.CertName = dataRecord["PROD_CERT_NAME"].ConvertTo<String>();
            record.LsePrinted = dataRecord["PROD_LSE_PRINTED"].ConvertTo<Byte?>();
            record.ReqFreqcy = dataRecord["PROD_REQ_FREQCY"].ConvertTo<Byte?>();
            record.AdmTxtId = dataRecord["PROD_ADM_TXT_ID"].ConvertTo<String>();
            record.TrnTxtId = dataRecord["PROD_TRN_TXT_ID"].ConvertTo<String>();
            record.EnqQstId = dataRecord["PROD_ENQ_QST_ID"].ConvertTo<String>();
            record.DelQstId = dataRecord["PROD_DEL_QST_ID"].ConvertTo<String>();
            record.ProvPack = dataRecord["PROD_PROV_PACK"].ConvertTo<String>();
            record.ConfPack = dataRecord["PROD_CONF_PACK"].ConvertTo<String>();
            record.JoiningPack = dataRecord["PROD_JOINING_PACK"].ConvertTo<String>();
            record.PostPack = dataRecord["PROD_POST_PACK"].ConvertTo<String>();
            record.ProvInv = dataRecord["PROD_PROV_INV"].ConvertTo<Byte?>();
            record.ConfInv = dataRecord["PROD_CONF_INV"].ConvertTo<Byte?>();
            record.JoinInv = dataRecord["PROD_JOIN_INV"].ConvertTo<Byte?>();
            record.PostInv = dataRecord["PROD_POST_INV"].ConvertTo<Byte?>();
            record.MstcType = dataRecord["PROD_MSTC_TYPE"].ConvertTo<String>();
            record.Overbook = dataRecord["PROD_OVERBOOK"].ConvertTo<Double?>();
            record.Commission = dataRecord["PROD_COMMISSION"].ConvertTo<Byte?>();
            record.PlanId = dataRecord["PROD_PLAN_ID"].ConvertTo<String>();
            record.PlanName = dataRecord["PROD_PLAN_NAME"].ConvertTo<String>();
            record.NoHours = dataRecord["PROD_NO_HOURS"].ConvertTo<Double?>();
            record.ExpiryMonths = dataRecord["PROD_EXPIRY_MONTHS"].ConvertTo<Double?>();
            record.Places = dataRecord["PROD_PLACES"].ConvertTo<Int32?>();
            record.PrePayType = dataRecord["PROD_PRE_PAY_TYPE"].ConvertTo<String>();
            record.Grades = dataRecord["PROD_GRADES"].ConvertTo<String>();
            record.ProleId = dataRecord["PROD_PROLE_ID"].ConvertTo<String>();
            record.ManProleId = dataRecord["PROD_MAN_PROLE_ID"].ConvertTo<String>();
            record.Level = dataRecord["PROD_LEVEL"].ConvertTo<String>();
            record.Serialised = dataRecord["PROD_SERIALISED"].ConvertTo<Byte?>();
            record.Url = dataRecord["PROD_URL"].ConvertTo<String>();
            record.ValToRevPc = dataRecord["PROD_VAL_TO_REV_PC"].ConvertTo<Double?>();
            record.BktId = dataRecord["PROD_BKT_ID"].ConvertTo<String>();
            record.BtId = dataRecord["PROD_BT_ID"].ConvertTo<String>();
            record.Name2 = dataRecord["PROD_NAME2"].ConvertTo<String>();
            record.GlCode1 = dataRecord["PROD_GL_CODE1"].ConvertTo<String>();
            record.GlCode2 = dataRecord["PROD_GL_CODE2"].ConvertTo<String>();
            record.Resourse = dataRecord["PROD_RESOURSE"].ConvertTo<Byte?>();
            record.LocId = dataRecord["PROD_LOC_ID"].ConvertTo<String>();
            record.Web = dataRecord["PROD_WEB"].ConvertTo<Byte?>();
            record.DescFile = dataRecord["PROD_DESC_FILE"].ConvertTo<String>();
            record.Userchar3 = dataRecord["PROD_USERCHAR_3"].ConvertTo<String>();
            record.Userint1 = dataRecord["PROD_USERINT_1"].ConvertTo<Int32?>();
            record.Userint2 = dataRecord["PROD_USERINT_2"].ConvertTo<Int32?>();
            record.Userint3 = dataRecord["PROD_USERINT_3"].ConvertTo<Int32?>();
            record.Userint4 = dataRecord["PROD_USERINT_4"].ConvertTo<Int32?>();
            record.Userdate1 = dataRecord["PROD_USERDATE_1"].ConvertTo<DateTime?>();
            record.Userint5 = dataRecord["PROD_USERINT_5"].ConvertTo<Int32?>();
            record.Usernum2 = dataRecord["PROD_USERNUM_2"].ConvertTo<Decimal?>();
            record.Userint6 = dataRecord["PROD_USERINT_6"].ConvertTo<Int32?>();
            record.Userchar4 = dataRecord["PROD_USERCHAR_4"].ConvertTo<String>();
            record.Userchar5 = dataRecord["PROD_USERCHAR_5"].ConvertTo<String>();
            record.Usernum3 = dataRecord["PROD_USERNUM_3"].ConvertTo<Decimal?>();
            record.Usernum4 = dataRecord["PROD_USERNUM_4"].ConvertTo<Decimal?>();
            record.Usernum5 = dataRecord["PROD_USERNUM_5"].ConvertTo<Decimal?>();
            record.Userint7 = dataRecord["PROD_USERINT_7"].ConvertTo<Int32?>();
            record.Userint8 = dataRecord["PROD_USERINT_8"].ConvertTo<Int32?>();
            record.Userint9 = dataRecord["PROD_USERINT_9"].ConvertTo<Int32?>();
            record.MembPrcGrp = dataRecord["PROD_MEMB_PRC_GRP"].ConvertTo<String>();
            record.ScoManifXml = dataRecord["PROD_SCO_MANIF_XML"].ConvertTo<String>();
            record.ProdQuantity = dataRecord["prod_quantity"].ConvertTo<Double?>();
            record.NonScorm = dataRecord["PROD_NON_SCORM"].ConvertTo<Byte?>();
            record.MsNew = dataRecord["PROD_MS_NEW"].ConvertTo<String>();
            record.MsRemind1 = dataRecord["PROD_MS_REMIND1"].ConvertTo<String>();
            record.MsRemind2 = dataRecord["PROD_MS_REMIND2"].ConvertTo<String>();
            record.MsRenew = dataRecord["PROD_MS_RENEW"].ConvertTo<String>();
            record.MsLapsed = dataRecord["PROD_MS_LAPSED"].ConvertTo<String>();
            record.MsCancel = dataRecord["PROD_MS_CANCEL"].ConvertTo<String>();
            record.MsGroup = dataRecord["PROD_MS_GROUP"].ConvertTo<Byte?>();
            record.RenewDays = dataRecord["PROD_RENEW_DAYS"].ConvertTo<Int32?>();
            record.SelcoSpId = dataRecord["PROD_SELCO_SP_ID"].ConvertTo<String>();
            record.MemInvType = dataRecord["PROD_MEM_INV_TYPE"].ConvertTo<Byte?>();
            record.AuthPnId = dataRecord["PROD_AUTH_PN_ID"].ConvertTo<String>();
            record.Isbn = dataRecord["PROD_ISBN"].ConvertTo<String>();
            record.PageCount = dataRecord["PROD_PAGE_COUNT"].ConvertTo<Int32?>();
            record.MsRemind3 = dataRecord["PROD_MS_REMIND3"].ConvertTo<String>();
            record.MsRm1Days = dataRecord["PROD_MS_RM1_DAYS"].ConvertTo<Int32?>();
            record.MsRm2Days = dataRecord["PROD_MS_RM2_DAYS"].ConvertTo<Int32?>();
            record.MsRm3Days = dataRecord["PROD_MS_RM3_DAYS"].ConvertTo<Int32?>();
            record.MsLapsDays = dataRecord["PROD_MS_LAPS_DAYS"].ConvertTo<Int32?>();
            record.Freq = dataRecord["PROD_FREQ"].ConvertTo<Int32?>();
            record.DescFileY = dataRecord["PROD_DESC_FILE_Y"].ConvertTo<String>();
            record.MsRenewed = dataRecord["PROD_MS_RENEWED"].ConvertTo<String>();
            record.RegBodyId1 = dataRecord["PROD_REG_BODY_ID_1"].ConvertTo<String>();
            record.RegBodyId2 = dataRecord["PROD_REG_BODY_ID_2"].ConvertTo<String>();
            record.Userchar6 = dataRecord["PROD_USERCHAR_6"].ConvertTo<String>();
            record.UDate1 = dataRecord["PROD_U_DATE_1"].ConvertTo<DateTime?>();
            record.UDate2 = dataRecord["PROD_U_DATE_2"].ConvertTo<DateTime?>();
            record.UDate3 = dataRecord["PROD_U_DATE_3"].ConvertTo<DateTime?>();
            record.UDate4 = dataRecord["PROD_U_DATE_4"].ConvertTo<DateTime?>();
            record.UDate5 = dataRecord["PROD_U_DATE_5"].ConvertTo<DateTime?>();
            record.UDate6 = dataRecord["PROD_U_DATE_6"].ConvertTo<DateTime?>();
            record.Usernum6 = dataRecord["PROD_USERNUM_6"].ConvertTo<Decimal?>();
            record.RoomBedType = dataRecord["PROD_ROOM_BED_TYPE"].ConvertTo<String>();
            record.LayStd = dataRecord["PROD_LAY_STD"].ConvertTo<Int32?>();
            record.LayTheater = dataRecord["PROD_LAY_THEATER"].ConvertTo<Int32?>();
            record.LayInformal = dataRecord["PROD_LAY_INFORMAL"].ConvertTo<Int32?>();
            record.LayClass = dataRecord["PROD_LAY_CLASS"].ConvertTo<Int32?>();
            record.LayOther = dataRecord["PROD_LAY_OTHER"].ConvertTo<Int32?>();
            record.MaxTheater = dataRecord["PROD_MAX_THEATER"].ConvertTo<Double?>();
            record.MaxInformal = dataRecord["PROD_MAX_INFORMAL"].ConvertTo<Double?>();
            record.MaxClass = dataRecord["PROD_MAX_CLASS"].ConvertTo<Double?>();
            record.MaxOther = dataRecord["PROD_MAX_OTHER"].ConvertTo<Double?>();
            record.PriceBand = dataRecord["PROD_PRICE_BAND"].ConvertTo<String>();
            record.SltyId = dataRecord["PROD_SLTY_ID"].ConvertTo<String>();
            record.Keywords = dataRecord["PROD_KEYWORDS"].ConvertTo<String>();
            record.LmsName = dataRecord["PROD_LMS_NAME"].ConvertTo<String>();
            record.ElSelfAprv = dataRecord["PROD_EL_SELF_APRV"].ConvertTo<Byte?>();
            record.CutPrd = dataRecord["PROD_CUT_PRD"].ConvertTo<Int32?>();
            record.RenewalMonth = dataRecord["PROD_RENEWAL_MONTH"].ConvertTo<String>();
            record.RenewalDay = dataRecord["PROD_RENEWAL_DAY"].ConvertTo<String>();
            record.FixedRenewal = dataRecord["PROD_FIXED_RENEWAL"].ConvertTo<Byte?>();
            record.ExclDay = dataRecord["PROD_EXCL_DAY"].ConvertTo<String>();
            record.ExclCalc = dataRecord["PROD_EXCL_CALC"].ConvertTo<Byte?>();
            record.SgNo = dataRecord["PROD_SG_NO"].ConvertTo<Int32?>();
            record.MsApp = dataRecord["PROD_MS_APP"].ConvertTo<String>();
            record.MsOff = dataRecord["PROD_MS_OFF"].ConvertTo<String>();
            record.Funded = dataRecord["PROD_FUNDED"].ConvertTo<Byte?>();
            record.FundedOrgId = dataRecord["PROD_FUNDED_ORG_ID"].ConvertTo<String>();
            record.QualDel = dataRecord["PROD_QUAL_DEL"].ConvertTo<Byte?>();
            record.BreakMustExist = dataRecord["PROD_BREAK_MUST_EXIST"].ConvertTo<Byte?>();
            record.OrgId = dataRecord["PROD_ORG_ID"].ConvertTo<String>();
            record.BdPrepBy = dataRecord["PROD_BD_PREP_BY"].ConvertTo<String>();
            record.BdPrepDate = dataRecord["PROD_BD_PREP_DATE"].ConvertTo<DateTime?>();
            record.BdStatus = dataRecord["PROD_BD_STATUS"].ConvertTo<String>();
            record.BdAppBy = dataRecord["PROD_BD_APP_BY"].ConvertTo<String>();
            record.BdAppDate = dataRecord["PROD_BD_APP_DATE"].ConvertTo<DateTime?>();
            record.BdTotEstCost = dataRecord["PROD_BD_TOT_EST_COST"].ConvertTo<Decimal?>();
            record.NoInvRenew = dataRecord["PROD_NO_INV_RENEW"].ConvertTo<Byte?>();
            record.CalcCommission = dataRecord["PROD_CALC_COMMISSION"].ConvertTo<Byte?>();
            record.Region = dataRecord["PROD_REGION"].ConvertTo<String>();
            record.StaticResourse = dataRecord["PROD_STATIC_RESOURSE"].ConvertTo<Byte?>();
            record.PooledResourse = dataRecord["PROD_POOLED_RESOURSE"].ConvertTo<Byte?>();
            record.ClashCheck = dataRecord["PROD_CLASH_CHECK"].ConvertTo<Byte?>();
            record.DefTraineeDays = dataRecord["PROD_DEF_TRAINEE_DAYS"].ConvertTo<Decimal?>();
            record.GrantEligible = dataRecord["PROD_GRANT_ELIGIBLE"].ConvertTo<Byte?>();
            record.GrantValueAvailable = dataRecord["PROD_GRANT_VALUE_AVAILABLE"].ConvertTo<Decimal?>();
            record.Breakeven1 = dataRecord["PROD_BREAKEVEN_1"].ConvertTo<Decimal?>();
            record.Breakeven2 = dataRecord["PROD_BREAKEVEN_2"].ConvertTo<Decimal?>();
            record.ExtCourseware = dataRecord["PROD_EXT_COURSEWARE"].ConvertTo<Byte?>();
            record.Contingency = dataRecord["PROD_CONTINGENCY"].ConvertTo<Int32?>();
            record.Cost = dataRecord["PROD_COST"].ConvertTo<Decimal?>();
            record.DeliveryDay = dataRecord["PROD_DELIVERY_DAY"].ConvertTo<Int32?>();
            record.ExtUrl = dataRecord["PROD_EXT_URL"].ConvertTo<String>();
            record.UseExtUrl = dataRecord["PROD_USE_EXT_URL"].ConvertTo<Byte?>();
            record.RefNo = dataRecord["PROD_REF_NO"].ConvertTo<Int32?>();
            record.Prefix = dataRecord["PROD_PREFIX"].ConvertTo<String>();
            record.NoneChargeable = dataRecord["PROD_NONE_CHARGEABLE"].ConvertTo<Byte>();
            record.RuleIncFamily = dataRecord["PROD_RULE_INC_FAMILY"].ConvertTo<Byte>();
            record.Donation = dataRecord["PROD_DONATION"].ConvertTo<Byte?>();
            record.Renew = dataRecord["PROD_RENEW"].ConvertTo<Byte?>();
            record.Renewable = dataRecord["PROD_RENEWABLE"].ConvertTo<Byte>();
            record.CourseNotesTextId = dataRecord["PROD_COURSE_NOTES_TEXT_ID"].ConvertTo<String>();
            record.DesigLetters = dataRecord["PROD_DESIG_LETTERS"].ConvertTo<String>();
            record.NonRenewMemb = dataRecord["PROD_NON_RENEW_MEMB"].ConvertTo<Byte>();
            record.AgeRestriction1 = dataRecord["PROD_AGE_RESTRICTION_1"].ConvertTo<Int32?>();
            record.AgeRestriction2 = dataRecord["PROD_AGE_RESTRICTION_2"].ConvertTo<Int32?>();
            record.RestrictType = dataRecord["PROD_RESTRICT_TYPE"].ConvertTo<String>();
            record.ExpiryDate = dataRecord["PROD_EXPIRY_DATE"].ConvertTo<DateTime?>();
            record.InvZeroVal = dataRecord["PROD_INV_ZERO_VAL"].ConvertTo<Int32>();
            record.CreditHours = dataRecord["PROD_CREDIT_HOURS"].ConvertTo<Decimal>();
            record.DdNoOfInstallments = dataRecord["PROD_DD_NO_OF_INSTALLMENTS"].ConvertTo<Int32?>();
            record.DdFrequency = dataRecord["PROD_DD_FREQUENCY"].ConvertTo<Int32?>();
            record.ExcludeTrainHistory = dataRecord["PROD_EXCLUDE_TRAIN_HISTORY"].ConvertTo<Byte>();
            record.StartDateType = dataRecord["PROD_START_DATE_TYPE"].ConvertTo<Byte>();
            record.StartDateFixed = dataRecord["PROD_START_DATE_FIXED"].ConvertTo<DateTime?>();
            record.StartDateOffset = dataRecord["PROD_START_DATE_OFFSET"].ConvertTo<Int32>();
            record.StartDateOffsetType = dataRecord["PROD_START_DATE_OFFSET_TYPE"].ConvertTo<String>();
            record.EndDateType = dataRecord["PROD_END_DATE_TYPE"].ConvertTo<Byte>();
            record.EndDateFixed = dataRecord["PROD_END_DATE_FIXED"].ConvertTo<DateTime?>();
            record.EndDateOffset = dataRecord["PROD_END_DATE_OFFSET"].ConvertTo<Int32>();
            record.EndDateOffsetType = dataRecord["PROD_END_DATE_OFFSET_TYPE"].ConvertTo<String>();
            record.DescEditable = dataRecord["PROD_DESC_EDITABLE"].ConvertTo<Byte>();
            record.StockType = dataRecord["PROD_STOCK_TYPE"].ConvertTo<String>();
            record.StockExpectedDate = dataRecord["PROD_STOCK_EXPECTED_DATE"].ConvertTo<String>();
            record.MemFirstBook = dataRecord["PROD_MEM_FIRST_BOOK"].ConvertTo<Byte>();
            record.MinScore = dataRecord["PROD_MIN_SCORE"].ConvertTo<Decimal?>();
            record.ScoreOutof = dataRecord["PROD_SCORE_OUTOF"].ConvertTo<Decimal?>();
            record.GradeWeb = dataRecord["PROD_GRADE_WEB"].ConvertTo<Byte?>();
            record.Predeliv = dataRecord["PROD_PREDELIV"].ConvertTo<Byte>();
            record.AuthorName = dataRecord["PROD_AUTHOR_NAME"].ConvertTo<String>();
            record.Topup = dataRecord["PROD_TOPUP"].ConvertTo<Byte?>();
            record.LimitPlType = dataRecord["PROD_LIMIT_PL_TYPE"].ConvertTo<String>();
            record.PrepayUnits = dataRecord["PROD_PREPAY_UNITS"].ConvertTo<Int32?>();
            record.DelivMethod = dataRecord["PROD_DELIV_METHOD"].ConvertTo<String>();
            record.Lockdown = dataRecord["PROD_LOCKDOWN"].ConvertTo<Byte?>();
            record.Promotion = dataRecord["PROD_PROMOTION"].ConvertTo<Byte?>();
            record.SearchGroup = dataRecord["PROD_SEARCH_GROUP"].ConvertTo<String>();
            record.LimitPlId = dataRecord["PROD_LIMIT_PL_ID"].ConvertTo<String>();
            record.DefElemSt = dataRecord["PROD_DEF_ELEM_ST"].ConvertTo<String>();
            record.NextNo = dataRecord["PROD_NEXT_NO"].ConvertTo<Int32?>();
            record.Suffix = dataRecord["PROD_SUFFIX"].ConvertTo<String>();
            record.NoMembDiscount = dataRecord["PROD_NO_MEMB_DISCOUNT"].ConvertTo<Byte>();
            record.QuestId = dataRecord["PROD_QUEST_ID"].ConvertTo<String>();
            record.ShortDesc = dataRecord["PROD_SHORT_DESC"].ConvertTo<String>();
            record.OneclickCheckout = dataRecord["PROD_ONECLICK_CHECKOUT"].ConvertTo<Byte>();
            record.BookerOnly = dataRecord["PROD_BOOKER_ONLY"].ConvertTo<Byte>();
            record.LayUshape = dataRecord["PROD_LAY_USHAPE"].ConvertTo<Int32?>();
            record.LayBroom = dataRecord["PROD_LAY_BROOM"].ConvertTo<Int32?>();
            record.LayBrout = dataRecord["PROD_LAY_BROUT"].ConvertTo<Int32?>();
            record.MaxUshape = dataRecord["PROD_MAX_USHAPE"].ConvertTo<Double?>();
            record.MaxBroom = dataRecord["PROD_MAX_BROOM"].ConvertTo<Double?>();
            record.MaxBrout = dataRecord["PROD_MAX_BROUT"].ConvertTo<Double?>();
            record.WpName = dataRecord["PROD_WP_NAME"].ConvertTo<String>();
            record.Dept = dataRecord["PROD_DEPT"].ConvertTo<String>();
            record.Sku = dataRecord["PROD_SKU"].ConvertTo<String>();
            record.JobCode = dataRecord["PROD_JOB_CODE"].ConvertTo<String>();
            record.JobAnalyCode = dataRecord["PROD_JOB_ANALY_CODE"].ConvertTo<String>();
            record.JobType = dataRecord["PROD_JOB_TYPE"].ConvertTo<String>();
            record.JobParent = dataRecord["PROD_JOB_PARENT"].ConvertTo<String>();
            record.PshId = dataRecord["PROD_PSH_ID"].ConvertTo<Int32?>();
            record.Image = dataRecord["PROD_IMAGE"].ConvertTo<String>();
            record.OnlineSche = dataRecord["PROD_ONLINE_SCHE"].ConvertTo<String>();
            record.QuotebookRatio = dataRecord["PROD_QUOTEBOOK_RATIO"].ConvertTo<Int32>();
            record.Coords = dataRecord["PROD_COORDS"].ConvertTo<String>();
            record.UrlName = dataRecord["PROD_URL_NAME"].ConvertTo<String>();
            record.ZeroPad = dataRecord["PROD_ZERO_PAD"].ConvertTo<Int32?>();
            record.TrainProv = dataRecord["PROD_TRAIN_PROV"].ConvertTo<Byte?>();
            record.ReorderLev = dataRecord["PROD_REORDER_LEV"].ConvertTo<Byte?>();
            record.Licensed = dataRecord["PROD_LICENSED"].ConvertTo<Byte>();
            record.DelCloseDays = dataRecord["PROD_DEL_CLOSE_DAYS"].ConvertTo<Int32>();
            record.TrnRulesTxt = dataRecord["PROD_TRN_RULES_TXT"].ConvertTo<String>();
            record.CertDefDeliver = dataRecord["PROD_CERT_DEF_DELIVER"].ConvertTo<Byte>();
            record.DefMethDel = dataRecord["PROD_DEF_METH_DEL"].ConvertTo<String>();
            record.CertTempLttId = dataRecord["PROD_CERT_TEMP_LTT_ID"].ConvertTo<String>();
            record.ReorderLead = dataRecord["PROD_REORDER_LEAD"].ConvertTo<Int32?>();
            record.NomMemDet = dataRecord["PROD_NOM_MEM_DET"].ConvertTo<String>();
            record.NomMemReq = dataRecord["PROD_NOM_MEM_REQ"].ConvertTo<Byte?>();
            record.NomMemProdId = dataRecord["PROD_NOM_MEM_PROD_ID"].ConvertTo<String>();
            record.PackSendProleId = dataRecord["PROD_PACK_SEND_PROLE_ID"].ConvertTo<String>();
            record.PackBccEmail = dataRecord["PROD_PACK_BCC_EMAIL"].ConvertTo<String>();
            record.PackMdnEmail = dataRecord["PROD_PACK_MDN_EMAIL"].ConvertTo<String>();
            record.PackDsnEmail = dataRecord["PROD_PACK_DSN_EMAIL"].ConvertTo<String>();
            record.PackDsnOptions = dataRecord["PROD_PACK_DSN_OPTIONS"].ConvertTo<String>();
            record.CodeImage = dataRecord["PROD_CODE_IMAGE"].ConvertTo<String>();
            record.GatewayAccId = dataRecord["PROD_GATEWAY_ACC_ID"].ConvertTo<String>();
            record.RoyaltyModel = dataRecord["PROD_ROYALTY_MODEL"].ConvertTo<String>();
            record.SessionsDescription = dataRecord["PROD_SESSIONS_DESCRIPTION"].ConvertTo<String>();
            record.SessionsHeader = dataRecord["PROD_SESSIONS_HEADER"].ConvertTo<String>();
            record.CutPrdTime = dataRecord["PROD_CUT_PRD_TIME"].ConvertTo<Byte?>();
            record.Giftaid = dataRecord["PROD_GIFTAID"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProductRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ProductRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PROD_ID", record.Id);
            this.MapParameterIn(command, "@PA_PROD_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PROD_GROUP_ID", record.GroupId);
            this.MapParameterIn(command, "@PA_PROD_REF", record.Ref);
            this.MapParameterIn(command, "@PA_PROD_NAME", record.Name);
            this.MapParameterIn(command, "@PA_PROD_DESCRIP", record.Descrip);
            this.MapParameterIn(command, "@PA_PROD_TEXT1", record.Text1);
            this.MapParameterIn(command, "@PA_PROD_TEXT2", record.Text2);
            this.MapParameterIn(command, "@PA_PROD_TEXT3", record.Text3);
            this.MapParameterIn(command, "@PA_PROD_TEXT4", record.Text4);
            this.MapParameterIn(command, "@PA_PROD_TEXT5", record.Text5);
            this.MapParameterIn(command, "@PA_PROD_SY_PRODUCT", record.SyProduct);
            this.MapParameterIn(command, "@PA_PROD_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_PROD_CATEGORY", record.Category);
            this.MapParameterIn(command, "@PA_PROD_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_PROD_GROUP", record.Group);
            this.MapParameterIn(command, "@PA_PROD_UNIT", record.Unit);
            this.MapParameterIn(command, "@PA_PROD_PRICE", record.Price == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Price);
            this.MapParameterIn(command, "@PA_PROD_BLOCK_PRICE", record.BlockPrice == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BlockPrice);
            this.MapParameterIn(command, "@PA_PROD_SPARE_PRICE", record.SparePrice == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SparePrice);
            this.MapParameterIn(command, "@PA_PROD_COST_PRICE", record.CostPrice == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CostPrice);
            this.MapParameterIn(command, "@PA_PROD_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_PROD_REV_CODE", record.RevCode);
            this.MapParameterIn(command, "@PA_PROD_DISC_SCHED", record.DiscSched);
            this.MapParameterIn(command, "@PA_PROD_VAT_CODE", record.VatCode);
            this.MapParameterIn(command, "@PA_PROD_MIN_ATTEND", record.MinAttend == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MinAttend);
            this.MapParameterIn(command, "@PA_PROD_MAX_ATTEND", record.MaxAttend == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxAttend);
            this.MapParameterIn(command, "@PA_PROD_COURSE_LEN", record.CourseLen == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CourseLen);
            this.MapParameterIn(command, "@PA_PROD_DIARY_TYPE", record.DiaryType);
            this.MapParameterIn(command, "@PA_PROD_NORM_COLLEGE", record.NormCollege);
            this.MapParameterIn(command, "@PA_PROD_NEXT_COURSE", record.NextCourse);
            this.MapParameterIn(command, "@PA_PROD_SPARE_FLAG1", record.SpareFlag1);
            this.MapParameterIn(command, "@PA_PROD_SPARE_FLAG2", record.SpareFlag2);
            this.MapParameterIn(command, "@PA_PROD_CERT_PRINTED", record.CertPrinted);
            this.MapParameterIn(command, "@PA_PROD_TUC_REGION", record.TucRegion);
            this.MapParameterIn(command, "@PA_PROD_ENTRY_DATE", record.EntryDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EntryDate);
            this.MapParameterIn(command, "@PA_PROD_PROJECT_NO", record.ProjectNo);
            this.MapParameterIn(command, "@PA_PROD_COMMISSION_BY", record.CommissionBy);
            this.MapParameterIn(command, "@PA_PROD_KEY", record.Key);
            this.MapParameterIn(command, "@PA_PROD_CODE", record.Code);
            this.MapParameterIn(command, "@PA_PROD_TYPE_LOW", record.TypeLow);
            this.MapParameterIn(command, "@PA_PROD_REF_LOW", record.RefLow);
            this.MapParameterIn(command, "@PA_PROD_QUES_SET", record.QuesSet);
            this.MapParameterIn(command, "@PA_PROD_START_QNO", record.StartQno);
            this.MapParameterIn(command, "@PA_PROD_SELL_HINT", record.SellHint);
            this.MapParameterIn(command, "@PA_PROD_DET", record.Det);
            this.MapParameterIn(command, "@PA_PROD_ASS", record.Ass);
            this.MapParameterIn(command, "@PA_PROD_RETAIL_PRICE", record.RetailPrice == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.RetailPrice);
            this.MapParameterIn(command, "@PA_PROD_MARGIN", record.Margin == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Margin);
            this.MapParameterIn(command, "@PA_PROD_SUPPLIER_NAME", record.SupplierName);
            this.MapParameterIn(command, "@PA_PROD_SUPPLIER_ID", record.SupplierId);
            this.MapParameterIn(command, "@PA_PROD_PIC_ID", record.PicId);
            this.MapParameterIn(command, "@PA_PROD_JOIN_LETT", record.JoinLett);
            this.MapParameterIn(command, "@PA_PROD_CONFIRM_LETT", record.ConfirmLett);
            this.MapParameterIn(command, "@PA_PROD_QUEST_LETT", record.QuestLett);
            this.MapParameterIn(command, "@PA_PROD_SURV_LETT", record.SurvLett);
            this.MapParameterIn(command, "@PA_PROD_NO_CST_NO_SEL", record.NoCstNoSel);
            this.MapParameterIn(command, "@PA_PROD_PROV_LETT", record.ProvLett);
            this.MapParameterIn(command, "@PA_PROD_INV_LETT", record.InvLett);
            this.MapParameterIn(command, "@PA_PROD_DO_NOT_INVOIC", record.DoNotInvoic);
            this.MapParameterIn(command, "@PA_PROD_TOP_LEVEL", record.TopLevel);
            this.MapParameterIn(command, "@PA_PROD_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_PROD_ROOM_TYPE", record.RoomType);
            this.MapParameterIn(command, "@PA_PROD_ROOM_GRADE", record.RoomGrade);
            this.MapParameterIn(command, "@PA_PROD_STATE", record.State);
            this.MapParameterIn(command, "@PA_PROD_STOCKED", record.Stocked);
            this.MapParameterIn(command, "@PA_PROD_QTY_AV", record.QtyAv == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.QtyAv);
            this.MapParameterIn(command, "@PA_PROD_QTY_AC", record.QtyAc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.QtyAc);
            this.MapParameterIn(command, "@PA_PROD_QTY_BO", record.QtyBo == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.QtyBo);
            this.MapParameterIn(command, "@PA_PROD_QTY_OR", record.QtyOr == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.QtyOr);
            this.MapParameterIn(command, "@PA_PROD_COURSEMASTER", record.Coursemaster);
            this.MapParameterIn(command, "@PA_PROD_CURRENCY", record.Currency);
            this.MapParameterIn(command, "@PA_PROD_LAST_USED", record.LastUsed == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LastUsed);
            this.MapParameterIn(command, "@PA_PROD_DAILY_DEL_RAT", record.DailyDelRat == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.DailyDelRat);
            this.MapParameterIn(command, "@PA_PROD_OVERNIGHT_RAT", record.OvernightRat == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.OvernightRat);
            this.MapParameterIn(command, "@PA_PROD_SYNDICATE_RAT", record.SyndicateRat == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SyndicateRat);
            this.MapParameterIn(command, "@PA_PROD_EQUIP1", record.Equip1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip1);
            this.MapParameterIn(command, "@PA_PROD_EQUIP2", record.Equip2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip2);
            this.MapParameterIn(command, "@PA_PROD_EQUIP3", record.Equip3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip3);
            this.MapParameterIn(command, "@PA_PROD_EQUIP4", record.Equip4 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip4);
            this.MapParameterIn(command, "@PA_PROD_EQUIP5", record.Equip5 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip5);
            this.MapParameterIn(command, "@PA_PROD_EQUIP6", record.Equip6 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip6);
            this.MapParameterIn(command, "@PA_PROD_EQUIP7", record.Equip7 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip7);
            this.MapParameterIn(command, "@PA_PROD_EQUIP8", record.Equip8 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip8);
            this.MapParameterIn(command, "@PA_PROD_EQUIP9", record.Equip9 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip9);
            this.MapParameterIn(command, "@PA_PROD_EQUIP10", record.Equip10 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip10);
            this.MapParameterIn(command, "@PA_PROD_EQUIP11", record.Equip11 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip11);
            this.MapParameterIn(command, "@PA_PROD_EQUIP12", record.Equip12 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip12);
            this.MapParameterIn(command, "@PA_PROD_EQUIP13", record.Equip13 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip13);
            this.MapParameterIn(command, "@PA_PROD_EQUIP14", record.Equip14 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip14);
            this.MapParameterIn(command, "@PA_PROD_EQUIP15", record.Equip15 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Equip15);
            this.MapParameterIn(command, "@PA_PROD_GENERALISED", record.Generalised);
            this.MapParameterIn(command, "@PA_PROD_NETW_TYPE", record.NetwType);
            this.MapParameterIn(command, "@PA_PROD_REN_TYPE", record.RenType);
            this.MapParameterIn(command, "@PA_PROD_OLD_DESC", record.OldDesc);
            this.MapParameterIn(command, "@PA_PROD_CLASS", record.Class);
            this.MapParameterIn(command, "@PA_PROD_TI_CODE", record.TiCode);
            this.MapParameterIn(command, "@PA_PROD_DEP_REPS", record.DepReps);
            this.MapParameterIn(command, "@PA_PROD_LEAD_DEPT", record.LeadDept);
            this.MapParameterIn(command, "@PA_PROD_CURRENT", record.Current);
            this.MapParameterIn(command, "@PA_PROD_MEDIA", record.Media);
            this.MapParameterIn(command, "@PA_PROD_MAX_DISC", record.MaxDisc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxDisc);
            this.MapParameterIn(command, "@PA_PROD_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_PROD_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_PROD_USERNUM_1", record.Usernum1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_PROD_AVAIL_DATE", record.AvailDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AvailDate);
            this.MapParameterIn(command, "@PA_PROD_CERT_FMT", record.CertFmt);
            this.MapParameterIn(command, "@PA_PROD_CERT_NAME", record.CertName);
            this.MapParameterIn(command, "@PA_PROD_LSE_PRINTED", record.LsePrinted);
            this.MapParameterIn(command, "@PA_PROD_REQ_FREQCY", record.ReqFreqcy);
            this.MapParameterIn(command, "@PA_PROD_ADM_TXT_ID", record.AdmTxtId);
            this.MapParameterIn(command, "@PA_PROD_TRN_TXT_ID", record.TrnTxtId);
            this.MapParameterIn(command, "@PA_PROD_ENQ_QST_ID", record.EnqQstId);
            this.MapParameterIn(command, "@PA_PROD_DEL_QST_ID", record.DelQstId);
            this.MapParameterIn(command, "@PA_PROD_PROV_PACK", record.ProvPack);
            this.MapParameterIn(command, "@PA_PROD_CONF_PACK", record.ConfPack);
            this.MapParameterIn(command, "@PA_PROD_JOINING_PACK", record.JoiningPack);
            this.MapParameterIn(command, "@PA_PROD_POST_PACK", record.PostPack);
            this.MapParameterIn(command, "@PA_PROD_PROV_INV", record.ProvInv);
            this.MapParameterIn(command, "@PA_PROD_CONF_INV", record.ConfInv);
            this.MapParameterIn(command, "@PA_PROD_JOIN_INV", record.JoinInv);
            this.MapParameterIn(command, "@PA_PROD_POST_INV", record.PostInv);
            this.MapParameterIn(command, "@PA_PROD_MSTC_TYPE", record.MstcType);
            this.MapParameterIn(command, "@PA_PROD_OVERBOOK", record.Overbook == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Overbook);
            this.MapParameterIn(command, "@PA_PROD_COMMISSION", record.Commission);
            this.MapParameterIn(command, "@PA_PROD_PLAN_ID", record.PlanId);
            this.MapParameterIn(command, "@PA_PROD_PLAN_NAME", record.PlanName);
            this.MapParameterIn(command, "@PA_PROD_NO_HOURS", record.NoHours == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.NoHours);
            this.MapParameterIn(command, "@PA_PROD_EXPIRY_MONTHS", record.ExpiryMonths == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ExpiryMonths);
            this.MapParameterIn(command, "@PA_PROD_PLACES", record.Places == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Places);
            this.MapParameterIn(command, "@PA_PROD_PRE_PAY_TYPE", record.PrePayType);
            this.MapParameterIn(command, "@PA_PROD_GRADES", record.Grades);
            this.MapParameterIn(command, "@PA_PROD_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_PROD_MAN_PROLE_ID", record.ManProleId);
            this.MapParameterIn(command, "@PA_PROD_LEVEL", record.Level);
            this.MapParameterIn(command, "@PA_PROD_SERIALISED", record.Serialised);
            this.MapParameterIn(command, "@PA_PROD_URL", record.Url);
            this.MapParameterIn(command, "@PA_PROD_VAL_TO_REV_PC", record.ValToRevPc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ValToRevPc);
            this.MapParameterIn(command, "@PA_PROD_BKT_ID", record.BktId);
            this.MapParameterIn(command, "@PA_PROD_BT_ID", record.BtId);
            this.MapParameterIn(command, "@PA_PROD_NAME2", record.Name2);
            this.MapParameterIn(command, "@PA_PROD_GL_CODE1", record.GlCode1);
            this.MapParameterIn(command, "@PA_PROD_GL_CODE2", record.GlCode2);
            this.MapParameterIn(command, "@PA_PROD_RESOURSE", record.Resourse);
            this.MapParameterIn(command, "@PA_PROD_LOC_ID", record.LocId);
            this.MapParameterIn(command, "@PA_PROD_WEB", record.Web);
            this.MapParameterIn(command, "@PA_PROD_DESC_FILE", record.DescFile);
            this.MapParameterIn(command, "@PA_PROD_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_PROD_USERINT_1", record.Userint1 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint1);
            this.MapParameterIn(command, "@PA_PROD_USERINT_2", record.Userint2 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint2);
            this.MapParameterIn(command, "@PA_PROD_USERINT_3", record.Userint3 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint3);
            this.MapParameterIn(command, "@PA_PROD_USERINT_4", record.Userint4 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint4);
            this.MapParameterIn(command, "@PA_PROD_USERDATE_1", record.Userdate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate1);
            this.MapParameterIn(command, "@PA_PROD_USERINT_5", record.Userint5 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint5);
            this.MapParameterIn(command, "@PA_PROD_USERNUM_2", record.Usernum2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_PROD_USERINT_6", record.Userint6 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint6);
            this.MapParameterIn(command, "@PA_PROD_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_PROD_USERCHAR_5", record.Userchar5);
            this.MapParameterIn(command, "@PA_PROD_USERNUM_3", record.Usernum3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_PROD_USERNUM_4", record.Usernum4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum4);
            this.MapParameterIn(command, "@PA_PROD_USERNUM_5", record.Usernum5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum5);
            this.MapParameterIn(command, "@PA_PROD_USERINT_7", record.Userint7 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint7);
            this.MapParameterIn(command, "@PA_PROD_USERINT_8", record.Userint8 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint8);
            this.MapParameterIn(command, "@PA_PROD_USERINT_9", record.Userint9 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint9);
            this.MapParameterIn(command, "@PA_PROD_MEMB_PRC_GRP", record.MembPrcGrp);
            this.MapParameterIn(command, "@PA_PROD_SCO_MANIF_XML", record.ScoManifXml);
            this.MapParameterIn(command, "@PA_prod_quantity", record.ProdQuantity == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ProdQuantity);
            this.MapParameterIn(command, "@PA_PROD_NON_SCORM", record.NonScorm);
            this.MapParameterIn(command, "@PA_PROD_MS_NEW", record.MsNew);
            this.MapParameterIn(command, "@PA_PROD_MS_REMIND1", record.MsRemind1);
            this.MapParameterIn(command, "@PA_PROD_MS_REMIND2", record.MsRemind2);
            this.MapParameterIn(command, "@PA_PROD_MS_RENEW", record.MsRenew);
            this.MapParameterIn(command, "@PA_PROD_MS_LAPSED", record.MsLapsed);
            this.MapParameterIn(command, "@PA_PROD_MS_CANCEL", record.MsCancel);
            this.MapParameterIn(command, "@PA_PROD_MS_GROUP", record.MsGroup);
            this.MapParameterIn(command, "@PA_PROD_RENEW_DAYS", record.RenewDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.RenewDays);
            this.MapParameterIn(command, "@PA_PROD_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_PROD_MEM_INV_TYPE", record.MemInvType);
            this.MapParameterIn(command, "@PA_PROD_AUTH_PN_ID", record.AuthPnId);
            this.MapParameterIn(command, "@PA_PROD_ISBN", record.Isbn);
            this.MapParameterIn(command, "@PA_PROD_PAGE_COUNT", record.PageCount == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PageCount);
            this.MapParameterIn(command, "@PA_PROD_MS_REMIND3", record.MsRemind3);
            this.MapParameterIn(command, "@PA_PROD_MS_RM1_DAYS", record.MsRm1Days == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.MsRm1Days);
            this.MapParameterIn(command, "@PA_PROD_MS_RM2_DAYS", record.MsRm2Days == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.MsRm2Days);
            this.MapParameterIn(command, "@PA_PROD_MS_RM3_DAYS", record.MsRm3Days == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.MsRm3Days);
            this.MapParameterIn(command, "@PA_PROD_MS_LAPS_DAYS", record.MsLapsDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.MsLapsDays);
            this.MapParameterIn(command, "@PA_PROD_FREQ", record.Freq == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Freq);
            this.MapParameterIn(command, "@PA_PROD_DESC_FILE_Y", record.DescFileY);
            this.MapParameterIn(command, "@PA_PROD_MS_RENEWED", record.MsRenewed);
            this.MapParameterIn(command, "@PA_PROD_REG_BODY_ID_1", record.RegBodyId1);
            this.MapParameterIn(command, "@PA_PROD_REG_BODY_ID_2", record.RegBodyId2);
            this.MapParameterIn(command, "@PA_PROD_USERCHAR_6", record.Userchar6);
            this.MapParameterIn(command, "@PA_PROD_U_DATE_1", record.UDate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate1);
            this.MapParameterIn(command, "@PA_PROD_U_DATE_2", record.UDate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate2);
            this.MapParameterIn(command, "@PA_PROD_U_DATE_3", record.UDate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate3);
            this.MapParameterIn(command, "@PA_PROD_U_DATE_4", record.UDate4 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate4);
            this.MapParameterIn(command, "@PA_PROD_U_DATE_5", record.UDate5 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate5);
            this.MapParameterIn(command, "@PA_PROD_U_DATE_6", record.UDate6 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate6);
            this.MapParameterIn(command, "@PA_PROD_USERNUM_6", record.Usernum6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum6);
            this.MapParameterIn(command, "@PA_PROD_ROOM_BED_TYPE", record.RoomBedType);
            this.MapParameterIn(command, "@PA_PROD_LAY_STD", record.LayStd == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LayStd);
            this.MapParameterIn(command, "@PA_PROD_LAY_THEATER", record.LayTheater == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LayTheater);
            this.MapParameterIn(command, "@PA_PROD_LAY_INFORMAL", record.LayInformal == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LayInformal);
            this.MapParameterIn(command, "@PA_PROD_LAY_CLASS", record.LayClass == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LayClass);
            this.MapParameterIn(command, "@PA_PROD_LAY_OTHER", record.LayOther == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LayOther);
            this.MapParameterIn(command, "@PA_PROD_MAX_THEATER", record.MaxTheater == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxTheater);
            this.MapParameterIn(command, "@PA_PROD_MAX_INFORMAL", record.MaxInformal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxInformal);
            this.MapParameterIn(command, "@PA_PROD_MAX_CLASS", record.MaxClass == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxClass);
            this.MapParameterIn(command, "@PA_PROD_MAX_OTHER", record.MaxOther == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxOther);
            this.MapParameterIn(command, "@PA_PROD_PRICE_BAND", record.PriceBand);
            this.MapParameterIn(command, "@PA_PROD_SLTY_ID", record.SltyId);
            this.MapParameterIn(command, "@PA_PROD_KEYWORDS", record.Keywords);
            this.MapParameterIn(command, "@PA_PROD_LMS_NAME", record.LmsName);
            this.MapParameterIn(command, "@PA_PROD_EL_SELF_APRV", record.ElSelfAprv);
            this.MapParameterIn(command, "@PA_PROD_CUT_PRD", record.CutPrd == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.CutPrd);
            this.MapParameterIn(command, "@PA_PROD_RENEWAL_MONTH", record.RenewalMonth);
            this.MapParameterIn(command, "@PA_PROD_RENEWAL_DAY", record.RenewalDay);
            this.MapParameterIn(command, "@PA_PROD_FIXED_RENEWAL", record.FixedRenewal);
            this.MapParameterIn(command, "@PA_PROD_EXCL_DAY", record.ExclDay);
            this.MapParameterIn(command, "@PA_PROD_EXCL_CALC", record.ExclCalc);
            this.MapParameterIn(command, "@PA_PROD_SG_NO", record.SgNo == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SgNo);
            this.MapParameterIn(command, "@PA_PROD_MS_APP", record.MsApp);
            this.MapParameterIn(command, "@PA_PROD_MS_OFF", record.MsOff);
            this.MapParameterIn(command, "@PA_PROD_FUNDED", record.Funded);
            this.MapParameterIn(command, "@PA_PROD_FUNDED_ORG_ID", record.FundedOrgId);
            this.MapParameterIn(command, "@PA_PROD_QUAL_DEL", record.QualDel);
            this.MapParameterIn(command, "@PA_PROD_BREAK_MUST_EXIST", record.BreakMustExist);
            this.MapParameterIn(command, "@PA_PROD_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_PROD_BD_PREP_BY", record.BdPrepBy);
            this.MapParameterIn(command, "@PA_PROD_BD_PREP_DATE", record.BdPrepDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.BdPrepDate);
            this.MapParameterIn(command, "@PA_PROD_BD_STATUS", record.BdStatus);
            this.MapParameterIn(command, "@PA_PROD_BD_APP_BY", record.BdAppBy);
            this.MapParameterIn(command, "@PA_PROD_BD_APP_DATE", record.BdAppDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.BdAppDate);
            this.MapParameterIn(command, "@PA_PROD_BD_TOT_EST_COST", record.BdTotEstCost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.BdTotEstCost);
            this.MapParameterIn(command, "@PA_PROD_NO_INV_RENEW", record.NoInvRenew);
            this.MapParameterIn(command, "@PA_PROD_CALC_COMMISSION", record.CalcCommission);
            this.MapParameterIn(command, "@PA_PROD_REGION", record.Region);
            this.MapParameterIn(command, "@PA_PROD_STATIC_RESOURSE", record.StaticResourse);
            this.MapParameterIn(command, "@PA_PROD_POOLED_RESOURSE", record.PooledResourse);
            this.MapParameterIn(command, "@PA_PROD_CLASH_CHECK", record.ClashCheck);
            this.MapParameterIn(command, "@PA_PROD_DEF_TRAINEE_DAYS", record.DefTraineeDays == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DefTraineeDays);
            this.MapParameterIn(command, "@PA_PROD_GRANT_ELIGIBLE", record.GrantEligible);
            this.MapParameterIn(command, "@PA_PROD_GRANT_VALUE_AVAILABLE", record.GrantValueAvailable == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.GrantValueAvailable);
            this.MapParameterIn(command, "@PA_PROD_BREAKEVEN_1", record.Breakeven1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Breakeven1);
            this.MapParameterIn(command, "@PA_PROD_BREAKEVEN_2", record.Breakeven2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Breakeven2);
            this.MapParameterIn(command, "@PA_PROD_EXT_COURSEWARE", record.ExtCourseware);
            this.MapParameterIn(command, "@PA_PROD_CONTINGENCY", record.Contingency == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Contingency);
            this.MapParameterIn(command, "@PA_PROD_COST", record.Cost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Cost);
            this.MapParameterIn(command, "@PA_PROD_DELIVERY_DAY", record.DeliveryDay == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DeliveryDay);
            this.MapParameterIn(command, "@PA_PROD_EXT_URL", record.ExtUrl);
            this.MapParameterIn(command, "@PA_PROD_USE_EXT_URL", record.UseExtUrl);
            this.MapParameterIn(command, "@PA_PROD_REF_NO", record.RefNo == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.RefNo);
            this.MapParameterIn(command, "@PA_PROD_PREFIX", record.Prefix);
            this.MapParameterIn(command, "@PA_PROD_NONE_CHARGEABLE", record.NoneChargeable);
            this.MapParameterIn(command, "@PA_PROD_RULE_INC_FAMILY", record.RuleIncFamily);
            this.MapParameterIn(command, "@PA_PROD_DONATION", record.Donation);
            this.MapParameterIn(command, "@PA_PROD_RENEW", record.Renew);
            this.MapParameterIn(command, "@PA_PROD_RENEWABLE", record.Renewable);
            this.MapParameterIn(command, "@PA_PROD_COURSE_NOTES_TEXT_ID", record.CourseNotesTextId);
            this.MapParameterIn(command, "@PA_PROD_DESIG_LETTERS", record.DesigLetters);
            this.MapParameterIn(command, "@PA_PROD_NON_RENEW_MEMB", record.NonRenewMemb);
            this.MapParameterIn(command, "@PA_PROD_AGE_RESTRICTION_1", record.AgeRestriction1 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.AgeRestriction1);
            this.MapParameterIn(command, "@PA_PROD_AGE_RESTRICTION_2", record.AgeRestriction2 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.AgeRestriction2);
            this.MapParameterIn(command, "@PA_PROD_RESTRICT_TYPE", record.RestrictType);
            this.MapParameterIn(command, "@PA_PROD_EXPIRY_DATE", record.ExpiryDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ExpiryDate);
            this.MapParameterIn(command, "@PA_PROD_INV_ZERO_VAL", record.InvZeroVal == Int32.MinValue ? 0 : record.InvZeroVal);
            this.MapParameterIn(command, "@PA_PROD_CREDIT_HOURS", record.CreditHours == Decimal.MinValue ? 0M : record.CreditHours);
            this.MapParameterIn(command, "@PA_PROD_DD_NO_OF_INSTALLMENTS", record.DdNoOfInstallments == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DdNoOfInstallments);
            this.MapParameterIn(command, "@PA_PROD_DD_FREQUENCY", record.DdFrequency == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DdFrequency);
            this.MapParameterIn(command, "@PA_PROD_EXCLUDE_TRAIN_HISTORY", record.ExcludeTrainHistory);
            this.MapParameterIn(command, "@PA_PROD_START_DATE_TYPE", record.StartDateType);
            this.MapParameterIn(command, "@PA_PROD_START_DATE_FIXED", record.StartDateFixed == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDateFixed);
            this.MapParameterIn(command, "@PA_PROD_START_DATE_OFFSET", record.StartDateOffset == Int32.MinValue ? 0 : record.StartDateOffset);
            this.MapParameterIn(command, "@PA_PROD_START_DATE_OFFSET_TYPE", record.StartDateOffsetType);
            this.MapParameterIn(command, "@PA_PROD_END_DATE_TYPE", record.EndDateType);
            this.MapParameterIn(command, "@PA_PROD_END_DATE_FIXED", record.EndDateFixed == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDateFixed);
            this.MapParameterIn(command, "@PA_PROD_END_DATE_OFFSET", record.EndDateOffset == Int32.MinValue ? 0 : record.EndDateOffset);
            this.MapParameterIn(command, "@PA_PROD_END_DATE_OFFSET_TYPE", record.EndDateOffsetType);
            this.MapParameterIn(command, "@PA_PROD_DESC_EDITABLE", record.DescEditable);
            this.MapParameterIn(command, "@PA_PROD_STOCK_TYPE", record.StockType);
            this.MapParameterIn(command, "@PA_PROD_STOCK_EXPECTED_DATE", record.StockExpectedDate);
            this.MapParameterIn(command, "@PA_PROD_MEM_FIRST_BOOK", record.MemFirstBook);
            this.MapParameterIn(command, "@PA_PROD_MIN_SCORE", record.MinScore == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.MinScore);
            this.MapParameterIn(command, "@PA_PROD_SCORE_OUTOF", record.ScoreOutof == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.ScoreOutof);
            this.MapParameterIn(command, "@PA_PROD_GRADE_WEB", record.GradeWeb);
            this.MapParameterIn(command, "@PA_PROD_PREDELIV", record.Predeliv);
            this.MapParameterIn(command, "@PA_PROD_AUTHOR_NAME", record.AuthorName);
            this.MapParameterIn(command, "@PA_PROD_TOPUP", record.Topup);
            this.MapParameterIn(command, "@PA_PROD_LIMIT_PL_TYPE", record.LimitPlType);
            this.MapParameterIn(command, "@PA_PROD_PREPAY_UNITS", record.PrepayUnits == Int32.MinValue ? ( useV6Logic ? new Int32?(1) : null ) : record.PrepayUnits);
            this.MapParameterIn(command, "@PA_PROD_DELIV_METHOD", record.DelivMethod);
            this.MapParameterIn(command, "@PA_PROD_LOCKDOWN", record.Lockdown);
            this.MapParameterIn(command, "@PA_PROD_PROMOTION", record.Promotion);
            this.MapParameterIn(command, "@PA_PROD_SEARCH_GROUP", record.SearchGroup);
            this.MapParameterIn(command, "@PA_PROD_LIMIT_PL_ID", record.LimitPlId);
            this.MapParameterIn(command, "@PA_PROD_DEF_ELEM_ST", record.DefElemSt);
            this.MapParameterIn(command, "@PA_PROD_NEXT_NO", record.NextNo == Int32.MinValue ? ( useV6Logic ? new Int32?(1) : null ) : record.NextNo);
            this.MapParameterIn(command, "@PA_PROD_SUFFIX", record.Suffix);
            this.MapParameterIn(command, "@PA_PROD_NO_MEMB_DISCOUNT", record.NoMembDiscount);
            this.MapParameterIn(command, "@PA_PROD_QUEST_ID", record.QuestId);
            this.MapParameterIn(command, "@PA_PROD_SHORT_DESC", record.ShortDesc);
            this.MapParameterIn(command, "@PA_PROD_ONECLICK_CHECKOUT", record.OneclickCheckout);
            this.MapParameterIn(command, "@PA_PROD_BOOKER_ONLY", record.BookerOnly);
            this.MapParameterIn(command, "@PA_PROD_LAY_USHAPE", record.LayUshape == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LayUshape);
            this.MapParameterIn(command, "@PA_PROD_LAY_BROOM", record.LayBroom == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LayBroom);
            this.MapParameterIn(command, "@PA_PROD_LAY_BROUT", record.LayBrout == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LayBrout);
            this.MapParameterIn(command, "@PA_PROD_MAX_USHAPE", record.MaxUshape == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxUshape);
            this.MapParameterIn(command, "@PA_PROD_MAX_BROOM", record.MaxBroom == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxBroom);
            this.MapParameterIn(command, "@PA_PROD_MAX_BROUT", record.MaxBrout == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxBrout);
            this.MapParameterIn(command, "@PA_PROD_WP_NAME", record.WpName);
            this.MapParameterIn(command, "@PA_PROD_DEPT", record.Dept);
            this.MapParameterIn(command, "@PA_PROD_SKU", record.Sku);
            this.MapParameterIn(command, "@PA_PROD_JOB_CODE", record.JobCode);
            this.MapParameterIn(command, "@PA_PROD_JOB_ANALY_CODE", record.JobAnalyCode);
            this.MapParameterIn(command, "@PA_PROD_JOB_TYPE", record.JobType);
            this.MapParameterIn(command, "@PA_PROD_JOB_PARENT", record.JobParent);
            this.MapParameterIn(command, "@PA_PROD_PSH_ID", record.PshId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PshId);
            this.MapParameterIn(command, "@PA_PROD_IMAGE", record.Image);
            this.MapParameterIn(command, "@PA_PROD_ONLINE_SCHE", record.OnlineSche);
            this.MapParameterIn(command, "@PA_PROD_QUOTEBOOK_RATIO", record.QuotebookRatio == Int32.MinValue ? 0 : record.QuotebookRatio);
            this.MapParameterIn(command, "@PA_PROD_COORDS", record.Coords);
            this.MapParameterIn(command, "@PA_PROD_URL_NAME", record.UrlName);
            this.MapParameterIn(command, "@PA_PROD_ZERO_PAD", record.ZeroPad == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ZeroPad);
            this.MapParameterIn(command, "@PA_PROD_TRAIN_PROV", record.TrainProv);
            this.MapParameterIn(command, "@PA_PROD_REORDER_LEV", record.ReorderLev);
            this.MapParameterIn(command, "@PA_PROD_LICENSED", record.Licensed);
            this.MapParameterIn(command, "@PA_PROD_DEL_CLOSE_DAYS", record.DelCloseDays == Int32.MinValue ? 0 : record.DelCloseDays);
            this.MapParameterIn(command, "@PA_PROD_TRN_RULES_TXT", record.TrnRulesTxt);
            this.MapParameterIn(command, "@PA_PROD_CERT_DEF_DELIVER", record.CertDefDeliver);
            this.MapParameterIn(command, "@PA_PROD_DEF_METH_DEL", record.DefMethDel);
            this.MapParameterIn(command, "@PA_PROD_CERT_TEMP_LTT_ID", record.CertTempLttId);
            this.MapParameterIn(command, "@PA_PROD_REORDER_LEAD", record.ReorderLead == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ReorderLead);
            this.MapParameterIn(command, "@PA_PROD_NOM_MEM_DET", record.NomMemDet);
            this.MapParameterIn(command, "@PA_PROD_NOM_MEM_REQ", record.NomMemReq);
            this.MapParameterIn(command, "@PA_PROD_NOM_MEM_PROD_ID", record.NomMemProdId);
            this.MapParameterIn(command, "@PA_PROD_PACK_SEND_PROLE_ID", record.PackSendProleId);
            this.MapParameterIn(command, "@PA_PROD_PACK_BCC_EMAIL", record.PackBccEmail);
            this.MapParameterIn(command, "@PA_PROD_PACK_MDN_EMAIL", record.PackMdnEmail);
            this.MapParameterIn(command, "@PA_PROD_PACK_DSN_EMAIL", record.PackDsnEmail);
            this.MapParameterIn(command, "@PA_PROD_PACK_DSN_OPTIONS", record.PackDsnOptions);
            this.MapParameterIn(command, "@PA_PROD_CODE_IMAGE", record.CodeImage);
            this.MapParameterIn(command, "@PA_PROD_GATEWAY_ACC_ID", record.GatewayAccId);
            this.MapParameterIn(command, "@PA_PROD_ROYALTY_MODEL", record.RoyaltyModel);
            this.MapParameterIn(command, "@PA_PROD_SESSIONS_DESCRIPTION", record.SessionsDescription);
            this.MapParameterIn(command, "@PA_PROD_SESSIONS_HEADER", record.SessionsHeader);
            this.MapParameterIn(command, "@PA_PROD_CUT_PRD_TIME", record.CutPrdTime);
            this.MapParameterIn(command, "@PA_PROD_GIFTAID", record.Giftaid);
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
        ///     The <see cref="ProductRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ProductRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PROD_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_PROD_LOCK", record.Lock);
            record.GroupId = this.MapParameterOut(command, "@PA_PROD_GROUP_ID", record.GroupId);
            record.Ref = this.MapParameterOut(command, "@PA_PROD_REF", record.Ref);
            record.Name = this.MapParameterOut(command, "@PA_PROD_NAME", record.Name);
            record.Descrip = this.MapParameterOut(command, "@PA_PROD_DESCRIP", record.Descrip);
            record.Text1 = this.MapParameterOut(command, "@PA_PROD_TEXT1", record.Text1);
            record.Text2 = this.MapParameterOut(command, "@PA_PROD_TEXT2", record.Text2);
            record.Text3 = this.MapParameterOut(command, "@PA_PROD_TEXT3", record.Text3);
            record.Text4 = this.MapParameterOut(command, "@PA_PROD_TEXT4", record.Text4);
            record.Text5 = this.MapParameterOut(command, "@PA_PROD_TEXT5", record.Text5);
            record.SyProduct = this.MapParameterOut(command, "@PA_PROD_SY_PRODUCT", record.SyProduct);
            record.Type = this.MapParameterOut(command, "@PA_PROD_TYPE", record.Type);
            record.Category = this.MapParameterOut(command, "@PA_PROD_CATEGORY", record.Category);
            record.Status = this.MapParameterOut(command, "@PA_PROD_STATUS", record.Status);
            record.Group = this.MapParameterOut(command, "@PA_PROD_GROUP", record.Group);
            record.Unit = this.MapParameterOut(command, "@PA_PROD_UNIT", record.Unit);
            record.Price = this.MapParameterOut(command, "@PA_PROD_PRICE", record.Price);
            record.BlockPrice = this.MapParameterOut(command, "@PA_PROD_BLOCK_PRICE", record.BlockPrice);
            record.SparePrice = this.MapParameterOut(command, "@PA_PROD_SPARE_PRICE", record.SparePrice);
            record.CostPrice = this.MapParameterOut(command, "@PA_PROD_COST_PRICE", record.CostPrice);
            record.CostCode = this.MapParameterOut(command, "@PA_PROD_COST_CODE", record.CostCode);
            record.RevCode = this.MapParameterOut(command, "@PA_PROD_REV_CODE", record.RevCode);
            record.DiscSched = this.MapParameterOut(command, "@PA_PROD_DISC_SCHED", record.DiscSched);
            record.VatCode = this.MapParameterOut(command, "@PA_PROD_VAT_CODE", record.VatCode);
            record.MinAttend = this.MapParameterOut(command, "@PA_PROD_MIN_ATTEND", record.MinAttend);
            record.MaxAttend = this.MapParameterOut(command, "@PA_PROD_MAX_ATTEND", record.MaxAttend);
            record.CourseLen = this.MapParameterOut(command, "@PA_PROD_COURSE_LEN", record.CourseLen);
            record.DiaryType = this.MapParameterOut(command, "@PA_PROD_DIARY_TYPE", record.DiaryType);
            record.NormCollege = this.MapParameterOut(command, "@PA_PROD_NORM_COLLEGE", record.NormCollege);
            record.NextCourse = this.MapParameterOut(command, "@PA_PROD_NEXT_COURSE", record.NextCourse);
            record.SpareFlag1 = this.MapParameterOut(command, "@PA_PROD_SPARE_FLAG1", record.SpareFlag1);
            record.SpareFlag2 = this.MapParameterOut(command, "@PA_PROD_SPARE_FLAG2", record.SpareFlag2);
            record.CertPrinted = this.MapParameterOut(command, "@PA_PROD_CERT_PRINTED", record.CertPrinted);
            record.TucRegion = this.MapParameterOut(command, "@PA_PROD_TUC_REGION", record.TucRegion);
            record.EntryDate = this.MapParameterOut(command, "@PA_PROD_ENTRY_DATE", record.EntryDate);
            record.ProjectNo = this.MapParameterOut(command, "@PA_PROD_PROJECT_NO", record.ProjectNo);
            record.CommissionBy = this.MapParameterOut(command, "@PA_PROD_COMMISSION_BY", record.CommissionBy);
            record.Key = this.MapParameterOut(command, "@PA_PROD_KEY", record.Key);
            record.Code = this.MapParameterOut(command, "@PA_PROD_CODE", record.Code);
            record.TypeLow = this.MapParameterOut(command, "@PA_PROD_TYPE_LOW", record.TypeLow);
            record.RefLow = this.MapParameterOut(command, "@PA_PROD_REF_LOW", record.RefLow);
            record.QuesSet = this.MapParameterOut(command, "@PA_PROD_QUES_SET", record.QuesSet);
            record.StartQno = this.MapParameterOut(command, "@PA_PROD_START_QNO", record.StartQno);
            record.SellHint = this.MapParameterOut(command, "@PA_PROD_SELL_HINT", record.SellHint);
            record.Det = this.MapParameterOut(command, "@PA_PROD_DET", record.Det);
            record.Ass = this.MapParameterOut(command, "@PA_PROD_ASS", record.Ass);
            record.RetailPrice = this.MapParameterOut(command, "@PA_PROD_RETAIL_PRICE", record.RetailPrice);
            record.Margin = this.MapParameterOut(command, "@PA_PROD_MARGIN", record.Margin);
            record.SupplierName = this.MapParameterOut(command, "@PA_PROD_SUPPLIER_NAME", record.SupplierName);
            record.SupplierId = this.MapParameterOut(command, "@PA_PROD_SUPPLIER_ID", record.SupplierId);
            record.PicId = this.MapParameterOut(command, "@PA_PROD_PIC_ID", record.PicId);
            record.JoinLett = this.MapParameterOut(command, "@PA_PROD_JOIN_LETT", record.JoinLett);
            record.ConfirmLett = this.MapParameterOut(command, "@PA_PROD_CONFIRM_LETT", record.ConfirmLett);
            record.QuestLett = this.MapParameterOut(command, "@PA_PROD_QUEST_LETT", record.QuestLett);
            record.SurvLett = this.MapParameterOut(command, "@PA_PROD_SURV_LETT", record.SurvLett);
            record.NoCstNoSel = this.MapParameterOut(command, "@PA_PROD_NO_CST_NO_SEL", record.NoCstNoSel);
            record.ProvLett = this.MapParameterOut(command, "@PA_PROD_PROV_LETT", record.ProvLett);
            record.InvLett = this.MapParameterOut(command, "@PA_PROD_INV_LETT", record.InvLett);
            record.DoNotInvoic = this.MapParameterOut(command, "@PA_PROD_DO_NOT_INVOIC", record.DoNotInvoic);
            record.TopLevel = this.MapParameterOut(command, "@PA_PROD_TOP_LEVEL", record.TopLevel);
            record.AddId = this.MapParameterOut(command, "@PA_PROD_ADD_ID", record.AddId);
            record.RoomType = this.MapParameterOut(command, "@PA_PROD_ROOM_TYPE", record.RoomType);
            record.RoomGrade = this.MapParameterOut(command, "@PA_PROD_ROOM_GRADE", record.RoomGrade);
            record.State = this.MapParameterOut(command, "@PA_PROD_STATE", record.State);
            record.Stocked = this.MapParameterOut(command, "@PA_PROD_STOCKED", record.Stocked);
            record.QtyAv = this.MapParameterOut(command, "@PA_PROD_QTY_AV", record.QtyAv);
            record.QtyAc = this.MapParameterOut(command, "@PA_PROD_QTY_AC", record.QtyAc);
            record.QtyBo = this.MapParameterOut(command, "@PA_PROD_QTY_BO", record.QtyBo);
            record.QtyOr = this.MapParameterOut(command, "@PA_PROD_QTY_OR", record.QtyOr);
            record.Coursemaster = this.MapParameterOut(command, "@PA_PROD_COURSEMASTER", record.Coursemaster);
            record.Currency = this.MapParameterOut(command, "@PA_PROD_CURRENCY", record.Currency);
            record.LastUsed = this.MapParameterOut(command, "@PA_PROD_LAST_USED", record.LastUsed);
            record.DailyDelRat = this.MapParameterOut(command, "@PA_PROD_DAILY_DEL_RAT", record.DailyDelRat);
            record.OvernightRat = this.MapParameterOut(command, "@PA_PROD_OVERNIGHT_RAT", record.OvernightRat);
            record.SyndicateRat = this.MapParameterOut(command, "@PA_PROD_SYNDICATE_RAT", record.SyndicateRat);
            record.Equip1 = this.MapParameterOut(command, "@PA_PROD_EQUIP1", record.Equip1);
            record.Equip2 = this.MapParameterOut(command, "@PA_PROD_EQUIP2", record.Equip2);
            record.Equip3 = this.MapParameterOut(command, "@PA_PROD_EQUIP3", record.Equip3);
            record.Equip4 = this.MapParameterOut(command, "@PA_PROD_EQUIP4", record.Equip4);
            record.Equip5 = this.MapParameterOut(command, "@PA_PROD_EQUIP5", record.Equip5);
            record.Equip6 = this.MapParameterOut(command, "@PA_PROD_EQUIP6", record.Equip6);
            record.Equip7 = this.MapParameterOut(command, "@PA_PROD_EQUIP7", record.Equip7);
            record.Equip8 = this.MapParameterOut(command, "@PA_PROD_EQUIP8", record.Equip8);
            record.Equip9 = this.MapParameterOut(command, "@PA_PROD_EQUIP9", record.Equip9);
            record.Equip10 = this.MapParameterOut(command, "@PA_PROD_EQUIP10", record.Equip10);
            record.Equip11 = this.MapParameterOut(command, "@PA_PROD_EQUIP11", record.Equip11);
            record.Equip12 = this.MapParameterOut(command, "@PA_PROD_EQUIP12", record.Equip12);
            record.Equip13 = this.MapParameterOut(command, "@PA_PROD_EQUIP13", record.Equip13);
            record.Equip14 = this.MapParameterOut(command, "@PA_PROD_EQUIP14", record.Equip14);
            record.Equip15 = this.MapParameterOut(command, "@PA_PROD_EQUIP15", record.Equip15);
            record.Generalised = this.MapParameterOut(command, "@PA_PROD_GENERALISED", record.Generalised);
            record.NetwType = this.MapParameterOut(command, "@PA_PROD_NETW_TYPE", record.NetwType);
            record.RenType = this.MapParameterOut(command, "@PA_PROD_REN_TYPE", record.RenType);
            record.OldDesc = this.MapParameterOut(command, "@PA_PROD_OLD_DESC", record.OldDesc);
            record.Class = this.MapParameterOut(command, "@PA_PROD_CLASS", record.Class);
            record.TiCode = this.MapParameterOut(command, "@PA_PROD_TI_CODE", record.TiCode);
            record.DepReps = this.MapParameterOut(command, "@PA_PROD_DEP_REPS", record.DepReps);
            record.LeadDept = this.MapParameterOut(command, "@PA_PROD_LEAD_DEPT", record.LeadDept);
            record.Current = this.MapParameterOut(command, "@PA_PROD_CURRENT", record.Current);
            record.Media = this.MapParameterOut(command, "@PA_PROD_MEDIA", record.Media);
            record.MaxDisc = this.MapParameterOut(command, "@PA_PROD_MAX_DISC", record.MaxDisc);
            record.Userchar1 = this.MapParameterOut(command, "@PA_PROD_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_PROD_USERCHAR_2", record.Userchar2);
            record.Usernum1 = this.MapParameterOut(command, "@PA_PROD_USERNUM_1", record.Usernum1);
            record.AvailDate = this.MapParameterOut(command, "@PA_PROD_AVAIL_DATE", record.AvailDate);
            record.CertFmt = this.MapParameterOut(command, "@PA_PROD_CERT_FMT", record.CertFmt);
            record.CertName = this.MapParameterOut(command, "@PA_PROD_CERT_NAME", record.CertName);
            record.LsePrinted = this.MapParameterOut(command, "@PA_PROD_LSE_PRINTED", record.LsePrinted);
            record.ReqFreqcy = this.MapParameterOut(command, "@PA_PROD_REQ_FREQCY", record.ReqFreqcy);
            record.AdmTxtId = this.MapParameterOut(command, "@PA_PROD_ADM_TXT_ID", record.AdmTxtId);
            record.TrnTxtId = this.MapParameterOut(command, "@PA_PROD_TRN_TXT_ID", record.TrnTxtId);
            record.EnqQstId = this.MapParameterOut(command, "@PA_PROD_ENQ_QST_ID", record.EnqQstId);
            record.DelQstId = this.MapParameterOut(command, "@PA_PROD_DEL_QST_ID", record.DelQstId);
            record.ProvPack = this.MapParameterOut(command, "@PA_PROD_PROV_PACK", record.ProvPack);
            record.ConfPack = this.MapParameterOut(command, "@PA_PROD_CONF_PACK", record.ConfPack);
            record.JoiningPack = this.MapParameterOut(command, "@PA_PROD_JOINING_PACK", record.JoiningPack);
            record.PostPack = this.MapParameterOut(command, "@PA_PROD_POST_PACK", record.PostPack);
            record.ProvInv = this.MapParameterOut(command, "@PA_PROD_PROV_INV", record.ProvInv);
            record.ConfInv = this.MapParameterOut(command, "@PA_PROD_CONF_INV", record.ConfInv);
            record.JoinInv = this.MapParameterOut(command, "@PA_PROD_JOIN_INV", record.JoinInv);
            record.PostInv = this.MapParameterOut(command, "@PA_PROD_POST_INV", record.PostInv);
            record.MstcType = this.MapParameterOut(command, "@PA_PROD_MSTC_TYPE", record.MstcType);
            record.Overbook = this.MapParameterOut(command, "@PA_PROD_OVERBOOK", record.Overbook);
            record.Commission = this.MapParameterOut(command, "@PA_PROD_COMMISSION", record.Commission);
            record.PlanId = this.MapParameterOut(command, "@PA_PROD_PLAN_ID", record.PlanId);
            record.PlanName = this.MapParameterOut(command, "@PA_PROD_PLAN_NAME", record.PlanName);
            record.NoHours = this.MapParameterOut(command, "@PA_PROD_NO_HOURS", record.NoHours);
            record.ExpiryMonths = this.MapParameterOut(command, "@PA_PROD_EXPIRY_MONTHS", record.ExpiryMonths);
            record.Places = this.MapParameterOut(command, "@PA_PROD_PLACES", record.Places);
            record.PrePayType = this.MapParameterOut(command, "@PA_PROD_PRE_PAY_TYPE", record.PrePayType);
            record.Grades = this.MapParameterOut(command, "@PA_PROD_GRADES", record.Grades);
            record.ProleId = this.MapParameterOut(command, "@PA_PROD_PROLE_ID", record.ProleId);
            record.ManProleId = this.MapParameterOut(command, "@PA_PROD_MAN_PROLE_ID", record.ManProleId);
            record.Level = this.MapParameterOut(command, "@PA_PROD_LEVEL", record.Level);
            record.Serialised = this.MapParameterOut(command, "@PA_PROD_SERIALISED", record.Serialised);
            record.Url = this.MapParameterOut(command, "@PA_PROD_URL", record.Url);
            record.ValToRevPc = this.MapParameterOut(command, "@PA_PROD_VAL_TO_REV_PC", record.ValToRevPc);
            record.BktId = this.MapParameterOut(command, "@PA_PROD_BKT_ID", record.BktId);
            record.BtId = this.MapParameterOut(command, "@PA_PROD_BT_ID", record.BtId);
            record.Name2 = this.MapParameterOut(command, "@PA_PROD_NAME2", record.Name2);
            record.GlCode1 = this.MapParameterOut(command, "@PA_PROD_GL_CODE1", record.GlCode1);
            record.GlCode2 = this.MapParameterOut(command, "@PA_PROD_GL_CODE2", record.GlCode2);
            record.Resourse = this.MapParameterOut(command, "@PA_PROD_RESOURSE", record.Resourse);
            record.LocId = this.MapParameterOut(command, "@PA_PROD_LOC_ID", record.LocId);
            record.Web = this.MapParameterOut(command, "@PA_PROD_WEB", record.Web);
            record.DescFile = this.MapParameterOut(command, "@PA_PROD_DESC_FILE", record.DescFile);
            record.Userchar3 = this.MapParameterOut(command, "@PA_PROD_USERCHAR_3", record.Userchar3);
            record.Userint1 = this.MapParameterOut(command, "@PA_PROD_USERINT_1", record.Userint1);
            record.Userint2 = this.MapParameterOut(command, "@PA_PROD_USERINT_2", record.Userint2);
            record.Userint3 = this.MapParameterOut(command, "@PA_PROD_USERINT_3", record.Userint3);
            record.Userint4 = this.MapParameterOut(command, "@PA_PROD_USERINT_4", record.Userint4);
            record.Userdate1 = this.MapParameterOut(command, "@PA_PROD_USERDATE_1", record.Userdate1);
            record.Userint5 = this.MapParameterOut(command, "@PA_PROD_USERINT_5", record.Userint5);
            record.Usernum2 = this.MapParameterOut(command, "@PA_PROD_USERNUM_2", record.Usernum2);
            record.Userint6 = this.MapParameterOut(command, "@PA_PROD_USERINT_6", record.Userint6);
            record.Userchar4 = this.MapParameterOut(command, "@PA_PROD_USERCHAR_4", record.Userchar4);
            record.Userchar5 = this.MapParameterOut(command, "@PA_PROD_USERCHAR_5", record.Userchar5);
            record.Usernum3 = this.MapParameterOut(command, "@PA_PROD_USERNUM_3", record.Usernum3);
            record.Usernum4 = this.MapParameterOut(command, "@PA_PROD_USERNUM_4", record.Usernum4);
            record.Usernum5 = this.MapParameterOut(command, "@PA_PROD_USERNUM_5", record.Usernum5);
            record.Userint7 = this.MapParameterOut(command, "@PA_PROD_USERINT_7", record.Userint7);
            record.Userint8 = this.MapParameterOut(command, "@PA_PROD_USERINT_8", record.Userint8);
            record.Userint9 = this.MapParameterOut(command, "@PA_PROD_USERINT_9", record.Userint9);
            record.MembPrcGrp = this.MapParameterOut(command, "@PA_PROD_MEMB_PRC_GRP", record.MembPrcGrp);
            record.ScoManifXml = this.MapParameterOut(command, "@PA_PROD_SCO_MANIF_XML", record.ScoManifXml);
            record.ProdQuantity = this.MapParameterOut(command, "@PA_prod_quantity", record.ProdQuantity);
            record.NonScorm = this.MapParameterOut(command, "@PA_PROD_NON_SCORM", record.NonScorm);
            record.MsNew = this.MapParameterOut(command, "@PA_PROD_MS_NEW", record.MsNew);
            record.MsRemind1 = this.MapParameterOut(command, "@PA_PROD_MS_REMIND1", record.MsRemind1);
            record.MsRemind2 = this.MapParameterOut(command, "@PA_PROD_MS_REMIND2", record.MsRemind2);
            record.MsRenew = this.MapParameterOut(command, "@PA_PROD_MS_RENEW", record.MsRenew);
            record.MsLapsed = this.MapParameterOut(command, "@PA_PROD_MS_LAPSED", record.MsLapsed);
            record.MsCancel = this.MapParameterOut(command, "@PA_PROD_MS_CANCEL", record.MsCancel);
            record.MsGroup = this.MapParameterOut(command, "@PA_PROD_MS_GROUP", record.MsGroup);
            record.RenewDays = this.MapParameterOut(command, "@PA_PROD_RENEW_DAYS", record.RenewDays);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_PROD_SELCO_SP_ID", record.SelcoSpId);
            record.MemInvType = this.MapParameterOut(command, "@PA_PROD_MEM_INV_TYPE", record.MemInvType);
            record.AuthPnId = this.MapParameterOut(command, "@PA_PROD_AUTH_PN_ID", record.AuthPnId);
            record.Isbn = this.MapParameterOut(command, "@PA_PROD_ISBN", record.Isbn);
            record.PageCount = this.MapParameterOut(command, "@PA_PROD_PAGE_COUNT", record.PageCount);
            record.MsRemind3 = this.MapParameterOut(command, "@PA_PROD_MS_REMIND3", record.MsRemind3);
            record.MsRm1Days = this.MapParameterOut(command, "@PA_PROD_MS_RM1_DAYS", record.MsRm1Days);
            record.MsRm2Days = this.MapParameterOut(command, "@PA_PROD_MS_RM2_DAYS", record.MsRm2Days);
            record.MsRm3Days = this.MapParameterOut(command, "@PA_PROD_MS_RM3_DAYS", record.MsRm3Days);
            record.MsLapsDays = this.MapParameterOut(command, "@PA_PROD_MS_LAPS_DAYS", record.MsLapsDays);
            record.Freq = this.MapParameterOut(command, "@PA_PROD_FREQ", record.Freq);
            record.DescFileY = this.MapParameterOut(command, "@PA_PROD_DESC_FILE_Y", record.DescFileY);
            record.MsRenewed = this.MapParameterOut(command, "@PA_PROD_MS_RENEWED", record.MsRenewed);
            record.RegBodyId1 = this.MapParameterOut(command, "@PA_PROD_REG_BODY_ID_1", record.RegBodyId1);
            record.RegBodyId2 = this.MapParameterOut(command, "@PA_PROD_REG_BODY_ID_2", record.RegBodyId2);
            record.Userchar6 = this.MapParameterOut(command, "@PA_PROD_USERCHAR_6", record.Userchar6);
            record.UDate1 = this.MapParameterOut(command, "@PA_PROD_U_DATE_1", record.UDate1);
            record.UDate2 = this.MapParameterOut(command, "@PA_PROD_U_DATE_2", record.UDate2);
            record.UDate3 = this.MapParameterOut(command, "@PA_PROD_U_DATE_3", record.UDate3);
            record.UDate4 = this.MapParameterOut(command, "@PA_PROD_U_DATE_4", record.UDate4);
            record.UDate5 = this.MapParameterOut(command, "@PA_PROD_U_DATE_5", record.UDate5);
            record.UDate6 = this.MapParameterOut(command, "@PA_PROD_U_DATE_6", record.UDate6);
            record.Usernum6 = this.MapParameterOut(command, "@PA_PROD_USERNUM_6", record.Usernum6);
            record.RoomBedType = this.MapParameterOut(command, "@PA_PROD_ROOM_BED_TYPE", record.RoomBedType);
            record.LayStd = this.MapParameterOut(command, "@PA_PROD_LAY_STD", record.LayStd);
            record.LayTheater = this.MapParameterOut(command, "@PA_PROD_LAY_THEATER", record.LayTheater);
            record.LayInformal = this.MapParameterOut(command, "@PA_PROD_LAY_INFORMAL", record.LayInformal);
            record.LayClass = this.MapParameterOut(command, "@PA_PROD_LAY_CLASS", record.LayClass);
            record.LayOther = this.MapParameterOut(command, "@PA_PROD_LAY_OTHER", record.LayOther);
            record.MaxTheater = this.MapParameterOut(command, "@PA_PROD_MAX_THEATER", record.MaxTheater);
            record.MaxInformal = this.MapParameterOut(command, "@PA_PROD_MAX_INFORMAL", record.MaxInformal);
            record.MaxClass = this.MapParameterOut(command, "@PA_PROD_MAX_CLASS", record.MaxClass);
            record.MaxOther = this.MapParameterOut(command, "@PA_PROD_MAX_OTHER", record.MaxOther);
            record.PriceBand = this.MapParameterOut(command, "@PA_PROD_PRICE_BAND", record.PriceBand);
            record.SltyId = this.MapParameterOut(command, "@PA_PROD_SLTY_ID", record.SltyId);
            record.Keywords = this.MapParameterOut(command, "@PA_PROD_KEYWORDS", record.Keywords);
            record.LmsName = this.MapParameterOut(command, "@PA_PROD_LMS_NAME", record.LmsName);
            record.ElSelfAprv = this.MapParameterOut(command, "@PA_PROD_EL_SELF_APRV", record.ElSelfAprv);
            record.CutPrd = this.MapParameterOut(command, "@PA_PROD_CUT_PRD", record.CutPrd);
            record.RenewalMonth = this.MapParameterOut(command, "@PA_PROD_RENEWAL_MONTH", record.RenewalMonth);
            record.RenewalDay = this.MapParameterOut(command, "@PA_PROD_RENEWAL_DAY", record.RenewalDay);
            record.FixedRenewal = this.MapParameterOut(command, "@PA_PROD_FIXED_RENEWAL", record.FixedRenewal);
            record.ExclDay = this.MapParameterOut(command, "@PA_PROD_EXCL_DAY", record.ExclDay);
            record.ExclCalc = this.MapParameterOut(command, "@PA_PROD_EXCL_CALC", record.ExclCalc);
            record.SgNo = this.MapParameterOut(command, "@PA_PROD_SG_NO", record.SgNo);
            record.MsApp = this.MapParameterOut(command, "@PA_PROD_MS_APP", record.MsApp);
            record.MsOff = this.MapParameterOut(command, "@PA_PROD_MS_OFF", record.MsOff);
            record.Funded = this.MapParameterOut(command, "@PA_PROD_FUNDED", record.Funded);
            record.FundedOrgId = this.MapParameterOut(command, "@PA_PROD_FUNDED_ORG_ID", record.FundedOrgId);
            record.QualDel = this.MapParameterOut(command, "@PA_PROD_QUAL_DEL", record.QualDel);
            record.BreakMustExist = this.MapParameterOut(command, "@PA_PROD_BREAK_MUST_EXIST", record.BreakMustExist);
            record.OrgId = this.MapParameterOut(command, "@PA_PROD_ORG_ID", record.OrgId);
            record.BdPrepBy = this.MapParameterOut(command, "@PA_PROD_BD_PREP_BY", record.BdPrepBy);
            record.BdPrepDate = this.MapParameterOut(command, "@PA_PROD_BD_PREP_DATE", record.BdPrepDate);
            record.BdStatus = this.MapParameterOut(command, "@PA_PROD_BD_STATUS", record.BdStatus);
            record.BdAppBy = this.MapParameterOut(command, "@PA_PROD_BD_APP_BY", record.BdAppBy);
            record.BdAppDate = this.MapParameterOut(command, "@PA_PROD_BD_APP_DATE", record.BdAppDate);
            record.BdTotEstCost = this.MapParameterOut(command, "@PA_PROD_BD_TOT_EST_COST", record.BdTotEstCost);
            record.NoInvRenew = this.MapParameterOut(command, "@PA_PROD_NO_INV_RENEW", record.NoInvRenew);
            record.CalcCommission = this.MapParameterOut(command, "@PA_PROD_CALC_COMMISSION", record.CalcCommission);
            record.Region = this.MapParameterOut(command, "@PA_PROD_REGION", record.Region);
            record.StaticResourse = this.MapParameterOut(command, "@PA_PROD_STATIC_RESOURSE", record.StaticResourse);
            record.PooledResourse = this.MapParameterOut(command, "@PA_PROD_POOLED_RESOURSE", record.PooledResourse);
            record.ClashCheck = this.MapParameterOut(command, "@PA_PROD_CLASH_CHECK", record.ClashCheck);
            record.DefTraineeDays = this.MapParameterOut(command, "@PA_PROD_DEF_TRAINEE_DAYS", record.DefTraineeDays);
            record.GrantEligible = this.MapParameterOut(command, "@PA_PROD_GRANT_ELIGIBLE", record.GrantEligible);
            record.GrantValueAvailable = this.MapParameterOut(command, "@PA_PROD_GRANT_VALUE_AVAILABLE", record.GrantValueAvailable);
            record.Breakeven1 = this.MapParameterOut(command, "@PA_PROD_BREAKEVEN_1", record.Breakeven1);
            record.Breakeven2 = this.MapParameterOut(command, "@PA_PROD_BREAKEVEN_2", record.Breakeven2);
            record.ExtCourseware = this.MapParameterOut(command, "@PA_PROD_EXT_COURSEWARE", record.ExtCourseware);
            record.Contingency = this.MapParameterOut(command, "@PA_PROD_CONTINGENCY", record.Contingency);
            record.Cost = this.MapParameterOut(command, "@PA_PROD_COST", record.Cost);
            record.DeliveryDay = this.MapParameterOut(command, "@PA_PROD_DELIVERY_DAY", record.DeliveryDay);
            record.ExtUrl = this.MapParameterOut(command, "@PA_PROD_EXT_URL", record.ExtUrl);
            record.UseExtUrl = this.MapParameterOut(command, "@PA_PROD_USE_EXT_URL", record.UseExtUrl);
            record.RefNo = this.MapParameterOut(command, "@PA_PROD_REF_NO", record.RefNo);
            record.Prefix = this.MapParameterOut(command, "@PA_PROD_PREFIX", record.Prefix);
            record.NoneChargeable = this.MapParameterOut(command, "@PA_PROD_NONE_CHARGEABLE", record.NoneChargeable);
            record.RuleIncFamily = this.MapParameterOut(command, "@PA_PROD_RULE_INC_FAMILY", record.RuleIncFamily);
            record.Donation = this.MapParameterOut(command, "@PA_PROD_DONATION", record.Donation);
            record.Renew = this.MapParameterOut(command, "@PA_PROD_RENEW", record.Renew);
            record.Renewable = this.MapParameterOut(command, "@PA_PROD_RENEWABLE", record.Renewable);
            record.CourseNotesTextId = this.MapParameterOut(command, "@PA_PROD_COURSE_NOTES_TEXT_ID", record.CourseNotesTextId);
            record.DesigLetters = this.MapParameterOut(command, "@PA_PROD_DESIG_LETTERS", record.DesigLetters);
            record.NonRenewMemb = this.MapParameterOut(command, "@PA_PROD_NON_RENEW_MEMB", record.NonRenewMemb);
            record.AgeRestriction1 = this.MapParameterOut(command, "@PA_PROD_AGE_RESTRICTION_1", record.AgeRestriction1);
            record.AgeRestriction2 = this.MapParameterOut(command, "@PA_PROD_AGE_RESTRICTION_2", record.AgeRestriction2);
            record.RestrictType = this.MapParameterOut(command, "@PA_PROD_RESTRICT_TYPE", record.RestrictType);
            record.ExpiryDate = this.MapParameterOut(command, "@PA_PROD_EXPIRY_DATE", record.ExpiryDate);
            record.InvZeroVal = this.MapParameterOut(command, "@PA_PROD_INV_ZERO_VAL", record.InvZeroVal);
            record.CreditHours = this.MapParameterOut(command, "@PA_PROD_CREDIT_HOURS", record.CreditHours);
            record.DdNoOfInstallments = this.MapParameterOut(command, "@PA_PROD_DD_NO_OF_INSTALLMENTS", record.DdNoOfInstallments);
            record.DdFrequency = this.MapParameterOut(command, "@PA_PROD_DD_FREQUENCY", record.DdFrequency);
            record.ExcludeTrainHistory = this.MapParameterOut(command, "@PA_PROD_EXCLUDE_TRAIN_HISTORY", record.ExcludeTrainHistory);
            record.StartDateType = this.MapParameterOut(command, "@PA_PROD_START_DATE_TYPE", record.StartDateType);
            record.StartDateFixed = this.MapParameterOut(command, "@PA_PROD_START_DATE_FIXED", record.StartDateFixed);
            record.StartDateOffset = this.MapParameterOut(command, "@PA_PROD_START_DATE_OFFSET", record.StartDateOffset);
            record.StartDateOffsetType = this.MapParameterOut(command, "@PA_PROD_START_DATE_OFFSET_TYPE", record.StartDateOffsetType);
            record.EndDateType = this.MapParameterOut(command, "@PA_PROD_END_DATE_TYPE", record.EndDateType);
            record.EndDateFixed = this.MapParameterOut(command, "@PA_PROD_END_DATE_FIXED", record.EndDateFixed);
            record.EndDateOffset = this.MapParameterOut(command, "@PA_PROD_END_DATE_OFFSET", record.EndDateOffset);
            record.EndDateOffsetType = this.MapParameterOut(command, "@PA_PROD_END_DATE_OFFSET_TYPE", record.EndDateOffsetType);
            record.DescEditable = this.MapParameterOut(command, "@PA_PROD_DESC_EDITABLE", record.DescEditable);
            record.StockType = this.MapParameterOut(command, "@PA_PROD_STOCK_TYPE", record.StockType);
            record.StockExpectedDate = this.MapParameterOut(command, "@PA_PROD_STOCK_EXPECTED_DATE", record.StockExpectedDate);
            record.MemFirstBook = this.MapParameterOut(command, "@PA_PROD_MEM_FIRST_BOOK", record.MemFirstBook);
            record.MinScore = this.MapParameterOut(command, "@PA_PROD_MIN_SCORE", record.MinScore);
            record.ScoreOutof = this.MapParameterOut(command, "@PA_PROD_SCORE_OUTOF", record.ScoreOutof);
            record.GradeWeb = this.MapParameterOut(command, "@PA_PROD_GRADE_WEB", record.GradeWeb);
            record.Predeliv = this.MapParameterOut(command, "@PA_PROD_PREDELIV", record.Predeliv);
            record.AuthorName = this.MapParameterOut(command, "@PA_PROD_AUTHOR_NAME", record.AuthorName);
            record.Topup = this.MapParameterOut(command, "@PA_PROD_TOPUP", record.Topup);
            record.LimitPlType = this.MapParameterOut(command, "@PA_PROD_LIMIT_PL_TYPE", record.LimitPlType);
            record.PrepayUnits = this.MapParameterOut(command, "@PA_PROD_PREPAY_UNITS", record.PrepayUnits);
            record.DelivMethod = this.MapParameterOut(command, "@PA_PROD_DELIV_METHOD", record.DelivMethod);
            record.Lockdown = this.MapParameterOut(command, "@PA_PROD_LOCKDOWN", record.Lockdown);
            record.Promotion = this.MapParameterOut(command, "@PA_PROD_PROMOTION", record.Promotion);
            record.SearchGroup = this.MapParameterOut(command, "@PA_PROD_SEARCH_GROUP", record.SearchGroup);
            record.LimitPlId = this.MapParameterOut(command, "@PA_PROD_LIMIT_PL_ID", record.LimitPlId);
            record.DefElemSt = this.MapParameterOut(command, "@PA_PROD_DEF_ELEM_ST", record.DefElemSt);
            record.NextNo = this.MapParameterOut(command, "@PA_PROD_NEXT_NO", record.NextNo);
            record.Suffix = this.MapParameterOut(command, "@PA_PROD_SUFFIX", record.Suffix);
            record.NoMembDiscount = this.MapParameterOut(command, "@PA_PROD_NO_MEMB_DISCOUNT", record.NoMembDiscount);
            record.QuestId = this.MapParameterOut(command, "@PA_PROD_QUEST_ID", record.QuestId);
            record.ShortDesc = this.MapParameterOut(command, "@PA_PROD_SHORT_DESC", record.ShortDesc);
            record.OneclickCheckout = this.MapParameterOut(command, "@PA_PROD_ONECLICK_CHECKOUT", record.OneclickCheckout);
            record.BookerOnly = this.MapParameterOut(command, "@PA_PROD_BOOKER_ONLY", record.BookerOnly);
            record.LayUshape = this.MapParameterOut(command, "@PA_PROD_LAY_USHAPE", record.LayUshape);
            record.LayBroom = this.MapParameterOut(command, "@PA_PROD_LAY_BROOM", record.LayBroom);
            record.LayBrout = this.MapParameterOut(command, "@PA_PROD_LAY_BROUT", record.LayBrout);
            record.MaxUshape = this.MapParameterOut(command, "@PA_PROD_MAX_USHAPE", record.MaxUshape);
            record.MaxBroom = this.MapParameterOut(command, "@PA_PROD_MAX_BROOM", record.MaxBroom);
            record.MaxBrout = this.MapParameterOut(command, "@PA_PROD_MAX_BROUT", record.MaxBrout);
            record.WpName = this.MapParameterOut(command, "@PA_PROD_WP_NAME", record.WpName);
            record.Dept = this.MapParameterOut(command, "@PA_PROD_DEPT", record.Dept);
            record.Sku = this.MapParameterOut(command, "@PA_PROD_SKU", record.Sku);
            record.JobCode = this.MapParameterOut(command, "@PA_PROD_JOB_CODE", record.JobCode);
            record.JobAnalyCode = this.MapParameterOut(command, "@PA_PROD_JOB_ANALY_CODE", record.JobAnalyCode);
            record.JobType = this.MapParameterOut(command, "@PA_PROD_JOB_TYPE", record.JobType);
            record.JobParent = this.MapParameterOut(command, "@PA_PROD_JOB_PARENT", record.JobParent);
            record.PshId = this.MapParameterOut(command, "@PA_PROD_PSH_ID", record.PshId);
            record.Image = this.MapParameterOut(command, "@PA_PROD_IMAGE", record.Image);
            record.OnlineSche = this.MapParameterOut(command, "@PA_PROD_ONLINE_SCHE", record.OnlineSche);
            record.QuotebookRatio = this.MapParameterOut(command, "@PA_PROD_QUOTEBOOK_RATIO", record.QuotebookRatio);
            record.Coords = this.MapParameterOut(command, "@PA_PROD_COORDS", record.Coords);
            record.UrlName = this.MapParameterOut(command, "@PA_PROD_URL_NAME", record.UrlName);
            record.ZeroPad = this.MapParameterOut(command, "@PA_PROD_ZERO_PAD", record.ZeroPad);
            record.TrainProv = this.MapParameterOut(command, "@PA_PROD_TRAIN_PROV", record.TrainProv);
            record.ReorderLev = this.MapParameterOut(command, "@PA_PROD_REORDER_LEV", record.ReorderLev);
            record.Licensed = this.MapParameterOut(command, "@PA_PROD_LICENSED", record.Licensed);
            record.DelCloseDays = this.MapParameterOut(command, "@PA_PROD_DEL_CLOSE_DAYS", record.DelCloseDays);
            record.TrnRulesTxt = this.MapParameterOut(command, "@PA_PROD_TRN_RULES_TXT", record.TrnRulesTxt);
            record.CertDefDeliver = this.MapParameterOut(command, "@PA_PROD_CERT_DEF_DELIVER", record.CertDefDeliver);
            record.DefMethDel = this.MapParameterOut(command, "@PA_PROD_DEF_METH_DEL", record.DefMethDel);
            record.CertTempLttId = this.MapParameterOut(command, "@PA_PROD_CERT_TEMP_LTT_ID", record.CertTempLttId);
            record.ReorderLead = this.MapParameterOut(command, "@PA_PROD_REORDER_LEAD", record.ReorderLead);
            record.NomMemDet = this.MapParameterOut(command, "@PA_PROD_NOM_MEM_DET", record.NomMemDet);
            record.NomMemReq = this.MapParameterOut(command, "@PA_PROD_NOM_MEM_REQ", record.NomMemReq);
            record.NomMemProdId = this.MapParameterOut(command, "@PA_PROD_NOM_MEM_PROD_ID", record.NomMemProdId);
            record.PackSendProleId = this.MapParameterOut(command, "@PA_PROD_PACK_SEND_PROLE_ID", record.PackSendProleId);
            record.PackBccEmail = this.MapParameterOut(command, "@PA_PROD_PACK_BCC_EMAIL", record.PackBccEmail);
            record.PackMdnEmail = this.MapParameterOut(command, "@PA_PROD_PACK_MDN_EMAIL", record.PackMdnEmail);
            record.PackDsnEmail = this.MapParameterOut(command, "@PA_PROD_PACK_DSN_EMAIL", record.PackDsnEmail);
            record.PackDsnOptions = this.MapParameterOut(command, "@PA_PROD_PACK_DSN_OPTIONS", record.PackDsnOptions);
            record.CodeImage = this.MapParameterOut(command, "@PA_PROD_CODE_IMAGE", record.CodeImage);
            record.GatewayAccId = this.MapParameterOut(command, "@PA_PROD_GATEWAY_ACC_ID", record.GatewayAccId);
            record.RoyaltyModel = this.MapParameterOut(command, "@PA_PROD_ROYALTY_MODEL", record.RoyaltyModel);
            record.SessionsDescription = this.MapParameterOut(command, "@PA_PROD_SESSIONS_DESCRIPTION", record.SessionsDescription);
            record.SessionsHeader = this.MapParameterOut(command, "@PA_PROD_SESSIONS_HEADER", record.SessionsHeader);
            record.CutPrdTime = this.MapParameterOut(command, "@PA_PROD_CUT_PRD_TIME", record.CutPrdTime);
            record.Giftaid = this.MapParameterOut(command, "@PA_PROD_GIFTAID", record.Giftaid);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="descrip">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='descrip' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByDescrip(String descrip)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Descrip");
            this.MapParameterIn(command, "@PA_PROD_DESCRIP", descrip);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="text1">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='text1' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByText1(String text1)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Text1");
            this.MapParameterIn(command, "@PA_PROD_TEXT1", text1);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="text2">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='text2' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByText2(String text2)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Text2");
            this.MapParameterIn(command, "@PA_PROD_TEXT2", text2);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="text3">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='text3' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByText3(String text3)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Text3");
            this.MapParameterIn(command, "@PA_PROD_TEXT3", text3);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_PROD_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="manProleId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='manProleId' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByManProleId(String manProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ManProleId");
            this.MapParameterIn(command, "@PA_PROD_MAN_PROLE_ID", manProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bktId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='bktId' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByBktId(String bktId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BktId");
            this.MapParameterIn(command, "@PA_PROD_BKT_ID", bktId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='locId' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByLocId(String locId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LocId");
            this.MapParameterIn(command, "@PA_PROD_LOC_ID", locId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_PROD_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="authPnId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='authPnId' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByAuthPnId(String authPnId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AuthPnId");
            this.MapParameterIn(command, "@PA_PROD_AUTH_PN_ID", authPnId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_PROD_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pshId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='pshId' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByPshId(Int32? pshId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PshId");
            this.MapParameterIn(command, "@PA_PROD_PSH_ID", pshId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trnRulesTxt">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='trnRulesTxt' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByTrnRulesTxt(String trnRulesTxt)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "TrnRulesTxt");
            this.MapParameterIn(command, "@PA_PROD_TRN_RULES_TXT", trnRulesTxt);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msNew">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='msNew' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByMsNew(String msNew)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MsNew");
            this.MapParameterIn(command, "@PA_PROD_MS_NEW", msNew);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRemind1">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='msRemind1' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByMsRemind1(String msRemind1)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MsRemind1");
            this.MapParameterIn(command, "@PA_PROD_MS_REMIND1", msRemind1);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRemind2">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='msRemind2' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByMsRemind2(String msRemind2)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MsRemind2");
            this.MapParameterIn(command, "@PA_PROD_MS_REMIND2", msRemind2);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRenew">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='msRenew' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByMsRenew(String msRenew)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MsRenew");
            this.MapParameterIn(command, "@PA_PROD_MS_RENEW", msRenew);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msLapsed">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='msLapsed' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByMsLapsed(String msLapsed)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MsLapsed");
            this.MapParameterIn(command, "@PA_PROD_MS_LAPSED", msLapsed);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msCancel">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='msCancel' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByMsCancel(String msCancel)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MsCancel");
            this.MapParameterIn(command, "@PA_PROD_MS_CANCEL", msCancel);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRemind3">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='msRemind3' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByMsRemind3(String msRemind3)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MsRemind3");
            this.MapParameterIn(command, "@PA_PROD_MS_REMIND3", msRemind3);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRenewed">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='msRenewed' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByMsRenewed(String msRenewed)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MsRenewed");
            this.MapParameterIn(command, "@PA_PROD_MS_RENEWED", msRenewed);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msApp">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='msApp' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByMsApp(String msApp)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MsApp");
            this.MapParameterIn(command, "@PA_PROD_MS_APP", msApp);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msOff">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ProductRecord" /> instances that match the specified <paramref name='msOff' />.
        /// </returns>
        public IEnumerable<ProductRecord> FetchAllByMsOff(String msOff)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MsOff");
            this.MapParameterIn(command, "@PA_PROD_MS_OFF", msOff);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IProductRepository.TableName
        {
            get { return this.TableName; }
        }

        void IProductRepository.Modify(Consensus.Learning.ProductRecord record)
        {
            this.Modify(record);
        }

        void IProductRepository.Create(Consensus.Learning.ProductRecord record)
        {
            this.Create(record);
        }

        /// <summary>
        ///     Retrieves a single <see cref="T:Consensus.Learning.ProductRecord" /> instance from the data store.
        /// </summary>
        /// <param name="reference">
        ///     The value which identifies the <see cref="T:Consensus.Learning.ProductRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The first <see cref="T:Consensus.Learning.ProductRecord" /> instance which matches the specified <paramref name="reference" />.
        /// </returns>
        Consensus.Learning.ProductRecord IProductRepository.FetchAllByReference(System.String reference)
        {
            return this.FetchAllByReference(reference);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="descrip">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="descrip" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByDescrip(System.String descrip)
        {
            return this.FetchAllByDescrip(descrip);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="text1">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="text1" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByText1(System.String text1)
        {
            return this.FetchAllByText1(text1);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="text2">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="text2" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByText2(System.String text2)
        {
            return this.FetchAllByText2(text2);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="text3">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="text3" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByText3(System.String text3)
        {
            return this.FetchAllByText3(text3);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="manProleId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="manProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByManProleId(System.String manProleId)
        {
            return this.FetchAllByManProleId(manProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bktId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="bktId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByBktId(System.String bktId)
        {
            return this.FetchAllByBktId(bktId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="locId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByLocId(System.String locId)
        {
            return this.FetchAllByLocId(locId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="authPnId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="authPnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByAuthPnId(System.String authPnId)
        {
            return this.FetchAllByAuthPnId(authPnId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByPshId(System.Nullable<System.Int32> pshId)
        {
            return this.FetchAllByPshId(pshId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trnRulesTxt">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="trnRulesTxt" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByTrnRulesTxt(System.String trnRulesTxt)
        {
            return this.FetchAllByTrnRulesTxt(trnRulesTxt);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msNew">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msNew" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByMsNew(System.String msNew)
        {
            return this.FetchAllByMsNew(msNew);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRemind1">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msRemind1" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByMsRemind1(System.String msRemind1)
        {
            return this.FetchAllByMsRemind1(msRemind1);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRemind2">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msRemind2" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByMsRemind2(System.String msRemind2)
        {
            return this.FetchAllByMsRemind2(msRemind2);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRenew">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msRenew" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByMsRenew(System.String msRenew)
        {
            return this.FetchAllByMsRenew(msRenew);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msLapsed">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msLapsed" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByMsLapsed(System.String msLapsed)
        {
            return this.FetchAllByMsLapsed(msLapsed);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msCancel">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msCancel" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByMsCancel(System.String msCancel)
        {
            return this.FetchAllByMsCancel(msCancel);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRemind3">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msRemind3" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByMsRemind3(System.String msRemind3)
        {
            return this.FetchAllByMsRemind3(msRemind3);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRenewed">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msRenewed" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByMsRenewed(System.String msRenewed)
        {
            return this.FetchAllByMsRenewed(msRenewed);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msApp">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msApp" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByMsApp(System.String msApp)
        {
            return this.FetchAllByMsApp(msApp);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msOff">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msOff" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> IProductRepository.FetchAllByMsOff(System.String msOff)
        {
            return this.FetchAllByMsOff(msOff);
        }

        #endregion
    }
}
