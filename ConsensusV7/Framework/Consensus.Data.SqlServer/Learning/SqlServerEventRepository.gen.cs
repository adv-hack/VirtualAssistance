using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CourseRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerEventRepository : SqlServerRepository<CourseRecord, String>, IEventRepository
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
            get { return "Course"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CourseRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_COURSE_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Course"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CourseRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CourseRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CourseRecord record)
        {
            record.Id = dataRecord["COURSE_ID"].ConvertTo<String>();
            record.Lock = dataRecord["COURSE_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["COURSE_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["COURSE_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["COURSE_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["COURSE_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["COURSE_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["COURSE_RCV_FROM"].ConvertTo<String>();
            record.PersonId = dataRecord["COURSE_PERSON_ID"].ConvertTo<String>();
            record.ProductId = dataRecord["COURSE_PRODUCT_ID"].ConvertTo<String>();
            record.LocId = dataRecord["COURSE_LOC_ID"].ConvertTo<String>();
            record.OrgId = dataRecord["COURSE_ORG_ID"].ConvertTo<String>();
            record.Ref = dataRecord["COURSE_REF"].ConvertTo<String>();
            record.Name = dataRecord["COURSE_NAME"].ConvertTo<String>();
            record.Type = dataRecord["COURSE_TYPE"].ConvertTo<String>();
            record.Sector = dataRecord["COURSE_SECTOR"].ConvertTo<String>();
            record.OnSite = dataRecord["COURSE_ON_SITE"].ConvertTo<Byte?>();
            record.BlockPricd = dataRecord["COURSE_BLOCK_PRICD"].ConvertTo<Byte?>();
            record.StartDate = dataRecord["COURSE_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["COURSE_END_DATE"].ConvertTo<DateTime?>();
            record.StartTime = dataRecord["COURSE_START_TIME"].ConvertTo<DateTime?>();
            record.EndTime = dataRecord["COURSE_END_TIME"].ConvertTo<DateTime?>();
            record.Status = dataRecord["COURSE_STATUS"].ConvertTo<String>();
            record.DiaryType = dataRecord["COURSE_DIARY_TYPE"].ConvertTo<String>();
            record.Length = dataRecord["COURSE_LENGTH"].ConvertTo<Double?>();
            record.MinPlaces = dataRecord["COURSE_MIN_PLACES"].ConvertTo<Double?>();
            record.MaxPlaces = dataRecord["COURSE_MAX_PLACES"].ConvertTo<Double?>();
            record.FreePlaces = dataRecord["COURSE_FREE_PLACES"].ConvertTo<Double?>();
            record.ConfPlaces = dataRecord["COURSE_CONF_PLACES"].ConvertTo<Double?>();
            record.ProvisBkgs = dataRecord["COURSE_PROVIS_BKGS"].ConvertTo<Double?>();
            record.ResvPlaces = dataRecord["COURSE_RESV_PLACES"].ConvertTo<Double?>();
            record.Waiting = dataRecord["COURSE_WAITING"].ConvertTo<Double?>();
            record.Cancels = dataRecord["COURSE_CANCELS"].ConvertTo<Double?>();
            record.BlockThres = dataRecord["COURSE_BLOCK_THRES"].ConvertTo<Double?>();
            record.BlockPrice = dataRecord["COURSE_BLOCK_PRICE"].ConvertTo<Double?>();
            record.StudtPrice = dataRecord["COURSE_STUDT_PRICE"].ConvertTo<Double?>();
            record.EstPurPrc = dataRecord["COURSE_EST_PUR_PRC"].ConvertTo<Double?>();
            record.NoHours = dataRecord["COURSE_NO_HOURS"].ConvertTo<Double?>();
            record.VatCode = dataRecord["COURSE_VAT_CODE"].ConvertTo<String>();
            record.CostCode = dataRecord["COURSE_COST_CODE"].ConvertTo<String>();
            record.RevCode = dataRecord["COURSE_REV_CODE"].ConvertTo<String>();
            record.JnInfOrde = dataRecord["COURSE_JN_INF_ORDE"].ConvertTo<String>();
            record.Notes = dataRecord["COURSE_NOTES"].ConvertTo<String>();
            record.TucRegion = dataRecord["COURSE_TUC_REGION"].ConvertTo<String>();
            record.Budget = dataRecord["COURSE_BUDGET"].ConvertTo<Double?>();
            record.Actual = dataRecord["COURSE_ACTUAL"].ConvertTo<Double?>();
            record.PayFag = dataRecord["COURSE_PAY_FAG"].ConvertTo<Byte?>();
            record.PayDate = dataRecord["COURSE_PAY_DATE"].ConvertTo<DateTime?>();
            record.PayCheqNo = dataRecord["COURSE_PAY_CHEQ_NO"].ConvertTo<String>();
            record.CollInvNo = dataRecord["COURSE_COLL_INV_NO"].ConvertTo<String>();
            record.InclOutlin = dataRecord["COURSE_INCL_OUTLIN"].ConvertTo<Byte?>();
            record.InclMap = dataRecord["COURSE_INCL_MAP"].ConvertTo<Byte?>();
            record.IncSpcIns = dataRecord["COURSE_INC_SPC_INS"].ConvertTo<Byte?>();
            record.InclBkFrm = dataRecord["COURSE_INCL_BK_FRM"].ConvertTo<Byte?>();
            record.IncPstQst = dataRecord["COURSE_INC_PST_QST"].ConvertTo<Byte?>();
            record.IncPreSrv = dataRecord["COURSE_INC_PRE_SRV"].ConvertTo<Byte?>();
            record.BudPeriod = dataRecord["COURSE_BUD_PERIOD"].ConvertTo<String>();
            record.BudForecst = dataRecord["COURSE_BUD_FORECST"].ConvertTo<Double?>();
            record.SourceCode = dataRecord["COURSE_SOURCE_CODE"].ConvertTo<String>();
            record.PersonId2 = dataRecord["COURSE_PERSON_ID_2"].ConvertTo<String>();
            record.Class = dataRecord["COURSE_CLASS"].ConvertTo<String>();
            record.HostName = dataRecord["COURSE_HOST_NAME"].ConvertTo<String>();
            record.VenuActual = dataRecord["COURSE_VENU_ACTUAL"].ConvertTo<Double?>();
            record.VenuBudget = dataRecord["COURSE_VENU_BUDGET"].ConvertTo<Double?>();
            record.CaterActul = dataRecord["COURSE_CATER_ACTUL"].ConvertTo<Double?>();
            record.CaterBdget = dataRecord["COURSE_CATER_BDGET"].ConvertTo<Double?>();
            record.HotelActul = dataRecord["COURSE_HOTEL_ACTUL"].ConvertTo<Double?>();
            record.HotelBdget = dataRecord["COURSE_HOTEL_BDGET"].ConvertTo<Double?>();
            record.EquipActul = dataRecord["COURSE_EQUIP_ACTUL"].ConvertTo<Double?>();
            record.EquipBdget = dataRecord["COURSE_EQUIP_BDGET"].ConvertTo<Double?>();
            record.TravActual = dataRecord["COURSE_TRAV_ACTUAL"].ConvertTo<Double?>();
            record.TravBudget = dataRecord["COURSE_TRAV_BUDGET"].ConvertTo<Double?>();
            record.ExpActual = dataRecord["COURSE_EXP_ACTUAL"].ConvertTo<Double?>();
            record.ExpBudget = dataRecord["COURSE_EXP_BUDGET"].ConvertTo<Double?>();
            record.OthrActual = dataRecord["COURSE_OTHR_ACTUAL"].ConvertTo<Double?>();
            record.OthrBudget = dataRecord["COURSE_OTHR_BUDGET"].ConvertTo<Double?>();
            record.QuestLett = dataRecord["COURSE_QUEST_LETT"].ConvertTo<String>();
            record.SurvLett = dataRecord["COURSE_SURV_LETT"].ConvertTo<String>();
            record.BookActual = dataRecord["COURSE_BOOK_ACTUAL"].ConvertTo<Double?>();
            record.ActualTot = dataRecord["COURSE_ACTUAL_TOT"].ConvertTo<Double?>();
            record.InclJoin = dataRecord["COURSE_INCL_JOIN"].ConvertTo<Byte?>();
            record.IncConfirm = dataRecord["COURSE_INC_CONFIRM"].ConvertTo<Byte?>();
            record.JoinLett = dataRecord["COURSE_JOIN_LETT"].ConvertTo<String>();
            record.ConfrmLett = dataRecord["COURSE_CONFRM_LETT"].ConvertTo<String>();
            record.ProvLett = dataRecord["COURSE_PROV_LETT"].ConvertTo<String>();
            record.InvLett = dataRecord["COURSE_INV_LETT"].ConvertTo<String>();
            record.DoNotInvc = dataRecord["COURSE_DO_NOT_INVC"].ConvertTo<Byte?>();
            record.CancelDate = dataRecord["COURSE_CANCEL_DATE"].ConvertTo<DateTime?>();
            record.CancelBy = dataRecord["COURSE_CANCEL_BY"].ConvertTo<String>();
            record.IncCshInv = dataRecord["COURSE_INC_CSH_INV"].ConvertTo<Byte?>();
            record.IncProFrm = dataRecord["COURSE_INC_PRO_FRM"].ConvertTo<Byte?>();
            record.IncReceipt = dataRecord["COURSE_INC_RECEIPT"].ConvertTo<Byte?>();
            record.Cmc = dataRecord["COURSE_CMC"].ConvertTo<Byte?>();
            record.PlId = dataRecord["COURSE_PL_ID"].ConvertTo<String>();
            record.SupplierId = dataRecord["COURSE_SUPPLIER_ID"].ConvertTo<String>();
            record.BreakEven = dataRecord["COURSE_BREAK_EVEN"].ConvertTo<Double?>();
            record.ChangeHist = dataRecord["COURSE_CHANGE_HIST"].ConvertTo<String>();
            record.Bip = dataRecord["COURSE_BIP"].ConvertTo<Byte?>();
            record.QuestId = dataRecord["COURSE_QUEST_ID"].ConvertTo<String>();
            record.PostId = dataRecord["COURSE_POST_ID"].ConvertTo<String>();
            record.OrderNo = dataRecord["COURSE_ORDER_NO"].ConvertTo<String>();
            record.ProvPack = dataRecord["COURSE_PROV_PACK"].ConvertTo<String>();
            record.ConfPack = dataRecord["COURSE_CONF_PACK"].ConvertTo<String>();
            record.JoiningPack = dataRecord["COURSE_JOINING_PACK"].ConvertTo<String>();
            record.PostPack = dataRecord["COURSE_POST_PACK"].ConvertTo<String>();
            record.ProvInv = dataRecord["COURSE_PROV_INV"].ConvertTo<Byte?>();
            record.ConfInv = dataRecord["COURSE_CONF_INV"].ConvertTo<Byte?>();
            record.JoinInv = dataRecord["COURSE_JOIN_INV"].ConvertTo<Byte?>();
            record.PostInv = dataRecord["COURSE_POST_INV"].ConvertTo<Byte?>();
            record.Period = dataRecord["COURSE_PERIOD"].ConvertTo<String>();
            record.SearchName = dataRecord["COURSE_SEARCH_NAME"].ConvertTo<String>();
            record.EvrId = dataRecord["COURSE_EVR_ID"].ConvertTo<String>();
            record.OppId = dataRecord["COURSE_OPP_ID"].ConvertTo<String>();
            record.SessCount = dataRecord["COURSE_SESS_COUNT"].ConvertTo<Int32?>();
            record.Private = dataRecord["COURSE_PRIVATE"].ConvertTo<Byte?>();
            record.PlanId = dataRecord["COURSE_PLAN_ID"].ConvertTo<String>();
            record.PlanName = dataRecord["COURSE_PLAN_NAME"].ConvertTo<String>();
            record.Web = dataRecord["COURSE_WEB"].ConvertTo<Byte?>();
            record.Grades = dataRecord["COURSE_GRADES"].ConvertTo<String>();
            record.DescTxtId = dataRecord["COURSE_DESC_TXT_ID"].ConvertTo<String>();
            record.TargTxtId = dataRecord["COURSE_TARG_TXT_ID"].ConvertTo<String>();
            record.SetupTime = dataRecord["COURSE_SETUP_TIME"].ConvertTo<DateTime?>();
            record.DateDec = dataRecord["COURSE_DATE_DEC"].ConvertTo<DateTime?>();
            record.NumInvite = dataRecord["COURSE_NUM_INVITE"].ConvertTo<Int32?>();
            record.PersonId3 = dataRecord["COURSE_PERSON_ID_3"].ConvertTo<String>();
            record.PersonId4 = dataRecord["COURSE_PERSON_ID_4"].ConvertTo<String>();
            record.BuId = dataRecord["COURSE_BU_ID"].ConvertTo<String>();
            record.Usernum1 = dataRecord["COURSE_USERNUM_1"].ConvertTo<Decimal?>();
            record.Usernum2 = dataRecord["COURSE_USERNUM_2"].ConvertTo<Decimal?>();
            record.Url = dataRecord["COURSE_URL"].ConvertTo<String>();
            record.ProjId = dataRecord["COURSE_PROJ_ID"].ConvertTo<String>();
            record.Code = dataRecord["COURSE_CODE"].ConvertTo<String>();
            record.BtId = dataRecord["COURSE_BT_ID"].ConvertTo<String>();
            record.Comments = dataRecord["COURSE_COMMENTS"].ConvertTo<String>();
            record.ThirdParty = dataRecord["COURSE_3RD_PARTY"].ConvertTo<Byte?>();
            record.UDate1 = dataRecord["COURSE_U_DATE_1"].ConvertTo<DateTime?>();
            record.UDate2 = dataRecord["COURSE_U_DATE_2"].ConvertTo<DateTime?>();
            record.UDate3 = dataRecord["COURSE_U_DATE_3"].ConvertTo<DateTime?>();
            record.UDate4 = dataRecord["COURSE_U_DATE_4"].ConvertTo<DateTime?>();
            record.Usernum3 = dataRecord["COURSE_USERNUM_3"].ConvertTo<Decimal?>();
            record.AddId = dataRecord["COURSE_ADD_ID"].ConvertTo<String>();
            record.Name2 = dataRecord["COURSE_NAME2"].ConvertTo<String>();
            record.Userchar1 = dataRecord["COURSE_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["COURSE_USERCHAR_2"].ConvertTo<String>();
            record.Userchar3 = dataRecord["COURSE_USERCHAR_3"].ConvertTo<String>();
            record.Userchar4 = dataRecord["COURSE_USERCHAR_4"].ConvertTo<String>();
            record.SupRoleId = dataRecord["COURSE_SUP_ROLE_ID"].ConvertTo<String>();
            record.Currency = dataRecord["COURSE_CURRENCY"].ConvertTo<String>();
            record.PriceA = dataRecord["COURSE_PRICE_A"].ConvertTo<Double?>();
            record.PriceB = dataRecord["COURSE_PRICE_B"].ConvertTo<Double?>();
            record.PriceC = dataRecord["COURSE_PRICE_C"].ConvertTo<Double?>();
            record.PriceD = dataRecord["COURSE_PRICE_D"].ConvertTo<Double?>();
            record.PriceE = dataRecord["COURSE_PRICE_E"].ConvertTo<Double?>();
            record.Chargable = dataRecord["COURSE_CHARGABLE"].ConvertTo<Byte?>();
            record.SelcoSpId = dataRecord["COURSE_SELCO_SP_ID"].ConvertTo<String>();
            record.Usernum4 = dataRecord["COURSE_USERNUM_4"].ConvertTo<Decimal?>();
            record.Usernum5 = dataRecord["COURSE_USERNUM_5"].ConvertTo<Decimal?>();
            record.Usernum6 = dataRecord["COURSE_USERNUM_6"].ConvertTo<Decimal?>();
            record.Usernum7 = dataRecord["COURSE_USERNUM_7"].ConvertTo<Byte?>();
            record.Invoiced = dataRecord["COURSE_INVOICED"].ConvertTo<Byte?>();
            record.BktId = dataRecord["COURSE_BKT_ID"].ConvertTo<String>();
            record.ContprolId = dataRecord["COURSE_CONTPROL_ID"].ConvertTo<String>();
            record.BudRev = dataRecord["COURSE_BUD_REV"].ConvertTo<Double?>();
            record.BudForcast = dataRecord["COURSE_BUD_FORCAST"].ConvertTo<Double?>();
            record.UDate5 = dataRecord["COURSE_U_DATE_5"].ConvertTo<DateTime?>();
            record.UDate6 = dataRecord["COURSE_U_DATE_6"].ConvertTo<DateTime?>();
            record.Userchar5 = dataRecord["COURSE_USERCHAR_5"].ConvertTo<String>();
            record.Userchar6 = dataRecord["COURSE_USERCHAR_6"].ConvertTo<String>();
            record.UTint1 = dataRecord["COURSE_U_TINT_1"].ConvertTo<Byte?>();
            record.UTint2 = dataRecord["COURSE_U_TINT_2"].ConvertTo<Byte?>();
            record.UTint3 = dataRecord["COURSE_U_TINT_3"].ConvertTo<Byte?>();
            record.UTint4 = dataRecord["COURSE_U_TINT_4"].ConvertTo<Byte?>();
            record.UTint5 = dataRecord["COURSE_U_TINT_5"].ConvertTo<Byte?>();
            record.UTint6 = dataRecord["COURSE_U_TINT_6"].ConvertTo<Byte?>();
            record.SyType = dataRecord["COURSE_SY_TYPE"].ConvertTo<Int32?>();
            record.PrejoinPack = dataRecord["COURSE_PREJOIN_PACK"].ConvertTo<String>();
            record.PstjoinPack = dataRecord["COURSE_PSTJOIN_PACK"].ConvertTo<String>();
            record.BookActBc2 = dataRecord["COURSE_BOOK_ACT_BC2"].ConvertTo<Decimal?>();
            record.ActTotBc2 = dataRecord["COURSE_ACT_TOT_BC2"].ConvertTo<Decimal?>();
            record.ProvSentDte = dataRecord["COURSE_PROV_SENT_DTE"].ConvertTo<DateTime?>();
            record.ConfSentDte = dataRecord["COURSE_CONF_SENT_DTE"].ConvertTo<DateTime?>();
            record.JoinSentDte = dataRecord["COURSE_JOIN_SENT_DTE"].ConvertTo<DateTime?>();
            record.PpSentDte = dataRecord["COURSE_PP_SENT_DTE"].ConvertTo<DateTime?>();
            record.PrjoinSentDte = dataRecord["COURSE_PRJOIN_SENT_DTE"].ConvertTo<DateTime?>();
            record.PojoinSentDte = dataRecord["COURSE_POJOIN_SENT_DTE"].ConvertTo<DateTime?>();
            record.CutPrd = dataRecord["COURSE_CUT_PRD"].ConvertTo<Int32?>();
            record.SupStatus = dataRecord["COURSE_SUP_STATUS"].ConvertTo<String>();
            record.Overbook = dataRecord["COURSE_OVERBOOK"].ConvertTo<Byte?>();
            record.ProvOrgId = dataRecord["COURSE_PROV_ORG_ID"].ConvertTo<String>();
            record.ProvProleId = dataRecord["COURSE_PROV_PROLE_ID"].ConvertTo<String>();
            record.AllocStatus = dataRecord["COURSE_ALLOC_STATUS"].ConvertTo<Byte?>();
            record.EstHours = dataRecord["COURSE_EST_HOURS"].ConvertTo<Decimal?>();
            record.Float = dataRecord["COURSE_FLOAT"].ConvertTo<Byte?>();
            record.ActHours = dataRecord["COURSE_ACT_HOURS"].ConvertTo<Decimal?>();
            record.Notes2 = dataRecord["COURSE_NOTES2"].ConvertTo<String>();
            record.Notes3 = dataRecord["COURSE_NOTES3"].ConvertTo<String>();
            record.Funded = dataRecord["COURSE_FUNDED"].ConvertTo<Byte?>();
            record.FundedOrgId = dataRecord["COURSE_FUNDED_ORG_ID"].ConvertTo<String>();
            record.QualDel = dataRecord["COURSE_QUAL_DEL"].ConvertTo<Byte?>();
            record.CohOnly = dataRecord["COURSE_COH_ONLY"].ConvertTo<Byte?>();
            record.Analysis1 = dataRecord["COURSE_ANALYSIS_1"].ConvertTo<String>();
            record.Analysis2 = dataRecord["COURSE_ANALYSIS_2"].ConvertTo<String>();
            record.Reservations = dataRecord["COURSE_RESERVATIONS"].ConvertTo<Int32>();
            record.DefElemSt = dataRecord["COURSE_DEF_ELEM_ST"].ConvertTo<String>();
            record.Lapsed = dataRecord["COURSE_LAPSED"].ConvertTo<Int32>();
            record.IntNotes = dataRecord["COURSE_INT_NOTES"].ConvertTo<String>();
            record.BdCompBy = dataRecord["COURSE_BD_COMP_BY"].ConvertTo<String>();
            record.BdCompDate = dataRecord["COURSE_BD_COMP_DATE"].ConvertTo<DateTime?>();
            record.BdTotActCost = dataRecord["COURSE_BD_TOT_ACT_COST"].ConvertTo<Decimal?>();
            record.BdStatus = dataRecord["COURSE_BD_STATUS"].ConvertTo<String>();
            record.Subs = dataRecord["COURSE_SUBS"].ConvertTo<Int32>();
            record.Transfers = dataRecord["COURSE_TRANSFERS"].ConvertTo<Int32>();
            record.HasTrainer = dataRecord["COURSE_HAS_TRAINER"].ConvertTo<Byte>();
            record.BdPrepBy = dataRecord["COURSE_BD_PREP_BY"].ConvertTo<String>();
            record.BdPrepDate = dataRecord["COURSE_BD_PREP_DATE"].ConvertTo<DateTime?>();
            record.BdAppBy = dataRecord["COURSE_BD_APP_BY"].ConvertTo<String>();
            record.BdAppDate = dataRecord["COURSE_BD_APP_DATE"].ConvertTo<DateTime?>();
            record.BdTotEstCost = dataRecord["COURSE_BD_TOT_EST_COST"].ConvertTo<Decimal?>();
            record.CalcCommission = dataRecord["COURSE_CALC_COMMISSION"].ConvertTo<Byte?>();
            record.BatId = dataRecord["COURSE_BAT_ID"].ConvertTo<String>();
            record.CancelPack = dataRecord["COURSE_CANCEL_PACK"].ConvertTo<String>();
            record.CanpSentDte = dataRecord["COURSE_CANP_SENT_DTE"].ConvertTo<DateTime?>();
            record.CancellationDate = dataRecord["COURSE_CANCELLATION_DATE"].ConvertTo<DateTime?>();
            record.Reason = dataRecord["COURSE_REASON"].ConvertTo<String>();
            record.UnrecoverableCancLoss = dataRecord["COURSE_UNRECOVERABLE_CANC_LOSS"].ConvertTo<Decimal?>();
            record.DefaultTraineeDays = dataRecord["COURSE_DEFAULT_TRAINEE_DAYS"].ConvertTo<Decimal?>();
            record.GrantEligable = dataRecord["COURSE_GRANT_ELIGABLE"].ConvertTo<Byte?>();
            record.GrantValueAvailable = dataRecord["COURSE_GRANT_VALUE_AVAILABLE"].ConvertTo<Decimal?>();
            record.BreakevenValue1 = dataRecord["COURSE_BREAKEVEN_VALUE1"].ConvertTo<Decimal?>();
            record.BreakevenValue2 = dataRecord["COURSE_BREAKEVEN_VALUE2"].ConvertTo<Decimal?>();
            record.ExtCourseware = dataRecord["COURSE_EXT_COURSEWARE"].ConvertTo<Byte?>();
            record.Contingency = dataRecord["COURSE_CONTINGENCY"].ConvertTo<Int32?>();
            record.Cost = dataRecord["COURSE_COST"].ConvertTo<Decimal?>();
            record.DeliveryDays = dataRecord["COURSE_DELIVERY_DAYS"].ConvertTo<Int32?>();
            record.MtrProleId = dataRecord["COURSE_MTR_PROLE_ID"].ConvertTo<String>();
            record.MaProleId = dataRecord["COURSE_MA_PROLE_ID"].ConvertTo<String>();
            record.AcadyCode = dataRecord["COURSE_ACADY_CODE"].ConvertTo<String>();
            record.NoAutoUpdate = dataRecord["COURSE_NO_AUTO_UPDATE"].ConvertTo<Byte?>();
            record.CourseId = dataRecord["COURSE_COURSE_ID"].ConvertTo<String>();
            record.Usermulti1 = dataRecord["COURSE_USERMULTI_1"].ConvertTo<String>();
            record.EventClone = dataRecord["COURSE_CLONE"].ConvertTo<Byte>();
            record.OutOfHours = dataRecord["COURSE_OUT_OF_HOURS"].ConvertTo<Byte?>();
            record.StopTrainCompletion = dataRecord["COURSE_STOP_TRAIN_COMPLETION"].ConvertTo<Byte?>();
            record.BdOrigCost = dataRecord["COURSE_BD_ORIG_COST"].ConvertTo<Decimal?>();
            record.Order = dataRecord["COURSE_ORDER"].ConvertTo<Byte>();
            record.ElemId = dataRecord["COURSE_ELEM_ID"].ConvertTo<String>();
            record.CodeLookup1 = dataRecord["COURSE_CODE_LOOKUP1"].ConvertTo<String>();
            record.PshId = dataRecord["COURSE_PSH_ID"].ConvertTo<Int32?>();
            record.BlockType = dataRecord["COURSE_BLOCK_TYPE"].ConvertTo<Byte?>();
            record.AttModBy = dataRecord["COURSE_ATT_MOD_BY"].ConvertTo<String>();
            record.AttModDate = dataRecord["COURSE_ATT_MOD_DATE"].ConvertTo<DateTime?>();
            record.Avail = dataRecord["COURSE_AVAIL"].ConvertTo<String>();
            record.FirstLicEvent = dataRecord["COURSE_FIRST_LIC_EVENT"].ConvertTo<Byte?>();
            record.TrnpId = dataRecord["COURSE_TRNP_ID"].ConvertTo<Int32?>();
            record.Licensed = dataRecord["COURSE_LICENSED"].ConvertTo<Byte>();
            record.ResultRecDate = dataRecord["COURSE_RESULT_REC_DATE"].ConvertTo<DateTime?>();
            record.PapersRecDate = dataRecord["COURSE_PAPERS_REC_DATE"].ConvertTo<DateTime?>();
            record.CertIssueDate = dataRecord["COURSE_CERT_ISSUE_DATE"].ConvertTo<DateTime?>();
            record.DelImpDate = dataRecord["COURSE_DEL_IMP_DATE"].ConvertTo<DateTime?>();
            record.ItemsReceivedDate = dataRecord["COURSE_ITEMS_RECEIVED_DATE"].ConvertTo<DateTime?>();
            record.DelivMethd = dataRecord["COURSE_DELIV_METHD"].ConvertTo<String>();
            record.PackSendProleId = dataRecord["COURSE_PACK_SEND_PROLE_ID"].ConvertTo<String>();
            record.PackBccEmail = dataRecord["COURSE_PACK_BCC_EMAIL"].ConvertTo<String>();
            record.PackMdnEmail = dataRecord["COURSE_PACK_MDN_EMAIL"].ConvertTo<String>();
            record.PackDsnEmail = dataRecord["COURSE_PACK_DSN_EMAIL"].ConvertTo<String>();
            record.PackDsnOptions = dataRecord["COURSE_PACK_DSN_OPTIONS"].ConvertTo<String>();
            record.CodeImage = dataRecord["COURSE_CODE_IMAGE"].ConvertTo<String>();
            record.ClientRef = dataRecord["COURSE_CLIENT_REF"].ConvertTo<String>();
            record.SessionsDescription = dataRecord["COURSE_SESSIONS_DESCRIPTION"].ConvertTo<String>();
            record.SessionsHeader = dataRecord["COURSE_SESSIONS_HEADER"].ConvertTo<String>();
            record.CutPrdTime = dataRecord["COURSE_CUT_PRD_TIME"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CourseRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CourseRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_COURSE_ID", record.Id);
            this.MapParameterIn(command, "@PA_COURSE_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_COURSE_PERSON_ID", record.PersonId);
            this.MapParameterIn(command, "@PA_COURSE_PRODUCT_ID", record.ProductId);
            this.MapParameterIn(command, "@PA_COURSE_LOC_ID", record.LocId);
            this.MapParameterIn(command, "@PA_COURSE_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_COURSE_REF", record.Ref);
            this.MapParameterIn(command, "@PA_COURSE_NAME", record.Name);
            this.MapParameterIn(command, "@PA_COURSE_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_COURSE_SECTOR", record.Sector);
            this.MapParameterIn(command, "@PA_COURSE_ON_SITE", record.OnSite);
            this.MapParameterIn(command, "@PA_COURSE_BLOCK_PRICD", record.BlockPricd);
            this.MapParameterIn(command, "@PA_COURSE_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_COURSE_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_COURSE_START_TIME", record.StartTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartTime);
            this.MapParameterIn(command, "@PA_COURSE_END_TIME", record.EndTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndTime);
            this.MapParameterIn(command, "@PA_COURSE_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_COURSE_DIARY_TYPE", record.DiaryType);
            this.MapParameterIn(command, "@PA_COURSE_LENGTH", record.Length == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Length);
            this.MapParameterIn(command, "@PA_COURSE_MIN_PLACES", record.MinPlaces == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MinPlaces);
            this.MapParameterIn(command, "@PA_COURSE_MAX_PLACES", record.MaxPlaces == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxPlaces);
            this.MapParameterIn(command, "@PA_COURSE_FREE_PLACES", record.FreePlaces == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.FreePlaces);
            this.MapParameterIn(command, "@PA_COURSE_CONF_PLACES", record.ConfPlaces == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ConfPlaces);
            this.MapParameterIn(command, "@PA_COURSE_PROVIS_BKGS", record.ProvisBkgs == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ProvisBkgs);
            this.MapParameterIn(command, "@PA_COURSE_RESV_PLACES", record.ResvPlaces == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ResvPlaces);
            this.MapParameterIn(command, "@PA_COURSE_WAITING", record.Waiting == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Waiting);
            this.MapParameterIn(command, "@PA_COURSE_CANCELS", record.Cancels == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cancels);
            this.MapParameterIn(command, "@PA_COURSE_BLOCK_THRES", record.BlockThres == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BlockThres);
            this.MapParameterIn(command, "@PA_COURSE_BLOCK_PRICE", record.BlockPrice == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BlockPrice);
            this.MapParameterIn(command, "@PA_COURSE_STUDT_PRICE", record.StudtPrice == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.StudtPrice);
            this.MapParameterIn(command, "@PA_COURSE_EST_PUR_PRC", record.EstPurPrc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.EstPurPrc);
            this.MapParameterIn(command, "@PA_COURSE_NO_HOURS", record.NoHours == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.NoHours);
            this.MapParameterIn(command, "@PA_COURSE_VAT_CODE", record.VatCode);
            this.MapParameterIn(command, "@PA_COURSE_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_COURSE_REV_CODE", record.RevCode);
            this.MapParameterIn(command, "@PA_COURSE_JN_INF_ORDE", record.JnInfOrde);
            this.MapParameterIn(command, "@PA_COURSE_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_COURSE_TUC_REGION", record.TucRegion);
            this.MapParameterIn(command, "@PA_COURSE_BUDGET", record.Budget == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Budget);
            this.MapParameterIn(command, "@PA_COURSE_ACTUAL", record.Actual == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Actual);
            this.MapParameterIn(command, "@PA_COURSE_PAY_FAG", record.PayFag);
            this.MapParameterIn(command, "@PA_COURSE_PAY_DATE", record.PayDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PayDate);
            this.MapParameterIn(command, "@PA_COURSE_PAY_CHEQ_NO", record.PayCheqNo);
            this.MapParameterIn(command, "@PA_COURSE_COLL_INV_NO", record.CollInvNo);
            this.MapParameterIn(command, "@PA_COURSE_INCL_OUTLIN", record.InclOutlin);
            this.MapParameterIn(command, "@PA_COURSE_INCL_MAP", record.InclMap);
            this.MapParameterIn(command, "@PA_COURSE_INC_SPC_INS", record.IncSpcIns);
            this.MapParameterIn(command, "@PA_COURSE_INCL_BK_FRM", record.InclBkFrm);
            this.MapParameterIn(command, "@PA_COURSE_INC_PST_QST", record.IncPstQst);
            this.MapParameterIn(command, "@PA_COURSE_INC_PRE_SRV", record.IncPreSrv);
            this.MapParameterIn(command, "@PA_COURSE_BUD_PERIOD", record.BudPeriod);
            this.MapParameterIn(command, "@PA_COURSE_BUD_FORECST", record.BudForecst == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BudForecst);
            this.MapParameterIn(command, "@PA_COURSE_SOURCE_CODE", record.SourceCode);
            this.MapParameterIn(command, "@PA_COURSE_PERSON_ID_2", record.PersonId2);
            this.MapParameterIn(command, "@PA_COURSE_CLASS", record.Class);
            this.MapParameterIn(command, "@PA_COURSE_HOST_NAME", record.HostName);
            this.MapParameterIn(command, "@PA_COURSE_VENU_ACTUAL", record.VenuActual == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.VenuActual);
            this.MapParameterIn(command, "@PA_COURSE_VENU_BUDGET", record.VenuBudget == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.VenuBudget);
            this.MapParameterIn(command, "@PA_COURSE_CATER_ACTUL", record.CaterActul == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CaterActul);
            this.MapParameterIn(command, "@PA_COURSE_CATER_BDGET", record.CaterBdget == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CaterBdget);
            this.MapParameterIn(command, "@PA_COURSE_HOTEL_ACTUL", record.HotelActul == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.HotelActul);
            this.MapParameterIn(command, "@PA_COURSE_HOTEL_BDGET", record.HotelBdget == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.HotelBdget);
            this.MapParameterIn(command, "@PA_COURSE_EQUIP_ACTUL", record.EquipActul == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.EquipActul);
            this.MapParameterIn(command, "@PA_COURSE_EQUIP_BDGET", record.EquipBdget == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.EquipBdget);
            this.MapParameterIn(command, "@PA_COURSE_TRAV_ACTUAL", record.TravActual == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TravActual);
            this.MapParameterIn(command, "@PA_COURSE_TRAV_BUDGET", record.TravBudget == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TravBudget);
            this.MapParameterIn(command, "@PA_COURSE_EXP_ACTUAL", record.ExpActual == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ExpActual);
            this.MapParameterIn(command, "@PA_COURSE_EXP_BUDGET", record.ExpBudget == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ExpBudget);
            this.MapParameterIn(command, "@PA_COURSE_OTHR_ACTUAL", record.OthrActual == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.OthrActual);
            this.MapParameterIn(command, "@PA_COURSE_OTHR_BUDGET", record.OthrBudget == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.OthrBudget);
            this.MapParameterIn(command, "@PA_COURSE_QUEST_LETT", record.QuestLett);
            this.MapParameterIn(command, "@PA_COURSE_SURV_LETT", record.SurvLett);
            this.MapParameterIn(command, "@PA_COURSE_BOOK_ACTUAL", record.BookActual == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BookActual);
            this.MapParameterIn(command, "@PA_COURSE_ACTUAL_TOT", record.ActualTot == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualTot);
            this.MapParameterIn(command, "@PA_COURSE_INCL_JOIN", record.InclJoin);
            this.MapParameterIn(command, "@PA_COURSE_INC_CONFIRM", record.IncConfirm);
            this.MapParameterIn(command, "@PA_COURSE_JOIN_LETT", record.JoinLett);
            this.MapParameterIn(command, "@PA_COURSE_CONFRM_LETT", record.ConfrmLett);
            this.MapParameterIn(command, "@PA_COURSE_PROV_LETT", record.ProvLett);
            this.MapParameterIn(command, "@PA_COURSE_INV_LETT", record.InvLett);
            this.MapParameterIn(command, "@PA_COURSE_DO_NOT_INVC", record.DoNotInvc);
            this.MapParameterIn(command, "@PA_COURSE_CANCEL_DATE", record.CancelDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CancelDate);
            this.MapParameterIn(command, "@PA_COURSE_CANCEL_BY", record.CancelBy);
            this.MapParameterIn(command, "@PA_COURSE_INC_CSH_INV", record.IncCshInv);
            this.MapParameterIn(command, "@PA_COURSE_INC_PRO_FRM", record.IncProFrm);
            this.MapParameterIn(command, "@PA_COURSE_INC_RECEIPT", record.IncReceipt);
            this.MapParameterIn(command, "@PA_COURSE_CMC", record.Cmc);
            this.MapParameterIn(command, "@PA_COURSE_PL_ID", record.PlId);
            this.MapParameterIn(command, "@PA_COURSE_SUPPLIER_ID", record.SupplierId);
            this.MapParameterIn(command, "@PA_COURSE_BREAK_EVEN", record.BreakEven == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BreakEven);
            this.MapParameterIn(command, "@PA_COURSE_CHANGE_HIST", record.ChangeHist);
            this.MapParameterIn(command, "@PA_COURSE_BIP", record.Bip);
            this.MapParameterIn(command, "@PA_COURSE_QUEST_ID", record.QuestId);
            this.MapParameterIn(command, "@PA_COURSE_POST_ID", record.PostId);
            this.MapParameterIn(command, "@PA_COURSE_ORDER_NO", record.OrderNo);
            this.MapParameterIn(command, "@PA_COURSE_PROV_PACK", record.ProvPack);
            this.MapParameterIn(command, "@PA_COURSE_CONF_PACK", record.ConfPack);
            this.MapParameterIn(command, "@PA_COURSE_JOINING_PACK", record.JoiningPack);
            this.MapParameterIn(command, "@PA_COURSE_POST_PACK", record.PostPack);
            this.MapParameterIn(command, "@PA_COURSE_PROV_INV", record.ProvInv);
            this.MapParameterIn(command, "@PA_COURSE_CONF_INV", record.ConfInv);
            this.MapParameterIn(command, "@PA_COURSE_JOIN_INV", record.JoinInv);
            this.MapParameterIn(command, "@PA_COURSE_POST_INV", record.PostInv);
            this.MapParameterIn(command, "@PA_COURSE_PERIOD", record.Period);
            this.MapParameterIn(command, "@PA_COURSE_SEARCH_NAME", record.SearchName);
            this.MapParameterIn(command, "@PA_COURSE_EVR_ID", record.EvrId);
            this.MapParameterIn(command, "@PA_COURSE_OPP_ID", record.OppId);
            this.MapParameterIn(command, "@PA_COURSE_SESS_COUNT", record.SessCount == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SessCount);
            this.MapParameterIn(command, "@PA_COURSE_PRIVATE", record.Private);
            this.MapParameterIn(command, "@PA_COURSE_PLAN_ID", record.PlanId);
            this.MapParameterIn(command, "@PA_COURSE_PLAN_NAME", record.PlanName);
            this.MapParameterIn(command, "@PA_COURSE_WEB", record.Web);
            this.MapParameterIn(command, "@PA_COURSE_GRADES", record.Grades);
            this.MapParameterIn(command, "@PA_COURSE_DESC_TXT_ID", record.DescTxtId);
            this.MapParameterIn(command, "@PA_COURSE_TARG_TXT_ID", record.TargTxtId);
            this.MapParameterIn(command, "@PA_COURSE_SETUP_TIME", record.SetupTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SetupTime);
            this.MapParameterIn(command, "@PA_COURSE_DATE_DEC", record.DateDec == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateDec);
            this.MapParameterIn(command, "@PA_COURSE_NUM_INVITE", record.NumInvite == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NumInvite);
            this.MapParameterIn(command, "@PA_COURSE_PERSON_ID_3", record.PersonId3);
            this.MapParameterIn(command, "@PA_COURSE_PERSON_ID_4", record.PersonId4);
            this.MapParameterIn(command, "@PA_COURSE_BU_ID", record.BuId);
            this.MapParameterIn(command, "@PA_COURSE_USERNUM_1", record.Usernum1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_COURSE_USERNUM_2", record.Usernum2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_COURSE_URL", record.Url);
            this.MapParameterIn(command, "@PA_COURSE_PROJ_ID", record.ProjId);
            this.MapParameterIn(command, "@PA_COURSE_CODE", record.Code);
            this.MapParameterIn(command, "@PA_COURSE_BT_ID", record.BtId);
            this.MapParameterIn(command, "@PA_COURSE_COMMENTS", record.Comments);
            this.MapParameterIn(command, "@PA_COURSE_3RD_PARTY", record.ThirdParty);
            this.MapParameterIn(command, "@PA_COURSE_U_DATE_1", record.UDate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate1);
            this.MapParameterIn(command, "@PA_COURSE_U_DATE_2", record.UDate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate2);
            this.MapParameterIn(command, "@PA_COURSE_U_DATE_3", record.UDate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate3);
            this.MapParameterIn(command, "@PA_COURSE_U_DATE_4", record.UDate4 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate4);
            this.MapParameterIn(command, "@PA_COURSE_USERNUM_3", record.Usernum3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_COURSE_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_COURSE_NAME2", record.Name2);
            this.MapParameterIn(command, "@PA_COURSE_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_COURSE_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_COURSE_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_COURSE_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_COURSE_SUP_ROLE_ID", record.SupRoleId);
            this.MapParameterIn(command, "@PA_COURSE_CURRENCY", record.Currency);
            this.MapParameterIn(command, "@PA_COURSE_PRICE_A", record.PriceA == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.PriceA);
            this.MapParameterIn(command, "@PA_COURSE_PRICE_B", record.PriceB == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.PriceB);
            this.MapParameterIn(command, "@PA_COURSE_PRICE_C", record.PriceC == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.PriceC);
            this.MapParameterIn(command, "@PA_COURSE_PRICE_D", record.PriceD == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.PriceD);
            this.MapParameterIn(command, "@PA_COURSE_PRICE_E", record.PriceE == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.PriceE);
            this.MapParameterIn(command, "@PA_COURSE_CHARGABLE", record.Chargable);
            this.MapParameterIn(command, "@PA_COURSE_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_COURSE_USERNUM_4", record.Usernum4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum4);
            this.MapParameterIn(command, "@PA_COURSE_USERNUM_5", record.Usernum5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum5);
            this.MapParameterIn(command, "@PA_COURSE_USERNUM_6", record.Usernum6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum6);
            this.MapParameterIn(command, "@PA_COURSE_USERNUM_7", record.Usernum7);
            this.MapParameterIn(command, "@PA_COURSE_INVOICED", record.Invoiced);
            this.MapParameterIn(command, "@PA_COURSE_BKT_ID", record.BktId);
            this.MapParameterIn(command, "@PA_COURSE_CONTPROL_ID", record.ContprolId);
            this.MapParameterIn(command, "@PA_COURSE_BUD_REV", record.BudRev == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BudRev);
            this.MapParameterIn(command, "@PA_COURSE_BUD_FORCAST", record.BudForcast == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BudForcast);
            this.MapParameterIn(command, "@PA_COURSE_U_DATE_5", record.UDate5 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate5);
            this.MapParameterIn(command, "@PA_COURSE_U_DATE_6", record.UDate6 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.UDate6);
            this.MapParameterIn(command, "@PA_COURSE_USERCHAR_5", record.Userchar5);
            this.MapParameterIn(command, "@PA_COURSE_USERCHAR_6", record.Userchar6);
            this.MapParameterIn(command, "@PA_COURSE_U_TINT_1", record.UTint1);
            this.MapParameterIn(command, "@PA_COURSE_U_TINT_2", record.UTint2);
            this.MapParameterIn(command, "@PA_COURSE_U_TINT_3", record.UTint3);
            this.MapParameterIn(command, "@PA_COURSE_U_TINT_4", record.UTint4);
            this.MapParameterIn(command, "@PA_COURSE_U_TINT_5", record.UTint5);
            this.MapParameterIn(command, "@PA_COURSE_U_TINT_6", record.UTint6);
            this.MapParameterIn(command, "@PA_COURSE_SY_TYPE", record.SyType == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SyType);
            this.MapParameterIn(command, "@PA_COURSE_PREJOIN_PACK", record.PrejoinPack);
            this.MapParameterIn(command, "@PA_COURSE_PSTJOIN_PACK", record.PstjoinPack);
            this.MapParameterIn(command, "@PA_COURSE_BOOK_ACT_BC2", record.BookActBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.BookActBc2);
            this.MapParameterIn(command, "@PA_COURSE_ACT_TOT_BC2", record.ActTotBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.ActTotBc2);
            this.MapParameterIn(command, "@PA_COURSE_PROV_SENT_DTE", record.ProvSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ProvSentDte);
            this.MapParameterIn(command, "@PA_COURSE_CONF_SENT_DTE", record.ConfSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ConfSentDte);
            this.MapParameterIn(command, "@PA_COURSE_JOIN_SENT_DTE", record.JoinSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.JoinSentDte);
            this.MapParameterIn(command, "@PA_COURSE_PP_SENT_DTE", record.PpSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PpSentDte);
            this.MapParameterIn(command, "@PA_COURSE_PRJOIN_SENT_DTE", record.PrjoinSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PrjoinSentDte);
            this.MapParameterIn(command, "@PA_COURSE_POJOIN_SENT_DTE", record.PojoinSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PojoinSentDte);
            this.MapParameterIn(command, "@PA_COURSE_CUT_PRD", record.CutPrd == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.CutPrd);
            this.MapParameterIn(command, "@PA_COURSE_SUP_STATUS", record.SupStatus);
            this.MapParameterIn(command, "@PA_COURSE_OVERBOOK", record.Overbook);
            this.MapParameterIn(command, "@PA_COURSE_PROV_ORG_ID", record.ProvOrgId);
            this.MapParameterIn(command, "@PA_COURSE_PROV_PROLE_ID", record.ProvProleId);
            this.MapParameterIn(command, "@PA_COURSE_ALLOC_STATUS", record.AllocStatus);
            this.MapParameterIn(command, "@PA_COURSE_EST_HOURS", record.EstHours == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.EstHours);
            this.MapParameterIn(command, "@PA_COURSE_FLOAT", record.Float);
            this.MapParameterIn(command, "@PA_COURSE_ACT_HOURS", record.ActHours == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.ActHours);
            this.MapParameterIn(command, "@PA_COURSE_NOTES2", record.Notes2);
            this.MapParameterIn(command, "@PA_COURSE_NOTES3", record.Notes3);
            this.MapParameterIn(command, "@PA_COURSE_FUNDED", record.Funded);
            this.MapParameterIn(command, "@PA_COURSE_FUNDED_ORG_ID", record.FundedOrgId);
            this.MapParameterIn(command, "@PA_COURSE_QUAL_DEL", record.QualDel);
            this.MapParameterIn(command, "@PA_COURSE_COH_ONLY", record.CohOnly);
            this.MapParameterIn(command, "@PA_COURSE_ANALYSIS_1", record.Analysis1);
            this.MapParameterIn(command, "@PA_COURSE_ANALYSIS_2", record.Analysis2);
            this.MapParameterIn(command, "@PA_COURSE_RESERVATIONS", record.Reservations == Int32.MinValue ? 0 : record.Reservations);
            this.MapParameterIn(command, "@PA_COURSE_DEF_ELEM_ST", record.DefElemSt);
            this.MapParameterIn(command, "@PA_COURSE_LAPSED", record.Lapsed == Int32.MinValue ? 0 : record.Lapsed);
            this.MapParameterIn(command, "@PA_COURSE_INT_NOTES", record.IntNotes);
            this.MapParameterIn(command, "@PA_COURSE_BD_COMP_BY", record.BdCompBy);
            this.MapParameterIn(command, "@PA_COURSE_BD_COMP_DATE", record.BdCompDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.BdCompDate);
            this.MapParameterIn(command, "@PA_COURSE_BD_TOT_ACT_COST", record.BdTotActCost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.BdTotActCost);
            this.MapParameterIn(command, "@PA_COURSE_BD_STATUS", record.BdStatus);
            this.MapParameterIn(command, "@PA_COURSE_SUBS", record.Subs == Int32.MinValue ? 0 : record.Subs);
            this.MapParameterIn(command, "@PA_COURSE_TRANSFERS", record.Transfers == Int32.MinValue ? 0 : record.Transfers);
            this.MapParameterIn(command, "@PA_COURSE_HAS_TRAINER", record.HasTrainer);
            this.MapParameterIn(command, "@PA_COURSE_BD_PREP_BY", record.BdPrepBy);
            this.MapParameterIn(command, "@PA_COURSE_BD_PREP_DATE", record.BdPrepDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.BdPrepDate);
            this.MapParameterIn(command, "@PA_COURSE_BD_APP_BY", record.BdAppBy);
            this.MapParameterIn(command, "@PA_COURSE_BD_APP_DATE", record.BdAppDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.BdAppDate);
            this.MapParameterIn(command, "@PA_COURSE_BD_TOT_EST_COST", record.BdTotEstCost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.BdTotEstCost);
            this.MapParameterIn(command, "@PA_COURSE_CALC_COMMISSION", record.CalcCommission);
            this.MapParameterIn(command, "@PA_COURSE_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_COURSE_CANCEL_PACK", record.CancelPack);
            this.MapParameterIn(command, "@PA_COURSE_CANP_SENT_DTE", record.CanpSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CanpSentDte);
            this.MapParameterIn(command, "@PA_COURSE_CANCELLATION_DATE", record.CancellationDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CancellationDate);
            this.MapParameterIn(command, "@PA_COURSE_REASON", record.Reason);
            this.MapParameterIn(command, "@PA_COURSE_UNRECOVERABLE_CANC_LOSS", record.UnrecoverableCancLoss == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UnrecoverableCancLoss);
            this.MapParameterIn(command, "@PA_COURSE_DEFAULT_TRAINEE_DAYS", record.DefaultTraineeDays == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DefaultTraineeDays);
            this.MapParameterIn(command, "@PA_COURSE_GRANT_ELIGABLE", record.GrantEligable);
            this.MapParameterIn(command, "@PA_COURSE_GRANT_VALUE_AVAILABLE", record.GrantValueAvailable == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.GrantValueAvailable);
            this.MapParameterIn(command, "@PA_COURSE_BREAKEVEN_VALUE1", record.BreakevenValue1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.BreakevenValue1);
            this.MapParameterIn(command, "@PA_COURSE_BREAKEVEN_VALUE2", record.BreakevenValue2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.BreakevenValue2);
            this.MapParameterIn(command, "@PA_COURSE_EXT_COURSEWARE", record.ExtCourseware);
            this.MapParameterIn(command, "@PA_COURSE_CONTINGENCY", record.Contingency == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Contingency);
            this.MapParameterIn(command, "@PA_COURSE_COST", record.Cost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Cost);
            this.MapParameterIn(command, "@PA_COURSE_DELIVERY_DAYS", record.DeliveryDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DeliveryDays);
            this.MapParameterIn(command, "@PA_COURSE_MTR_PROLE_ID", record.MtrProleId);
            this.MapParameterIn(command, "@PA_COURSE_MA_PROLE_ID", record.MaProleId);
            this.MapParameterIn(command, "@PA_COURSE_ACADY_CODE", record.AcadyCode);
            this.MapParameterIn(command, "@PA_COURSE_NO_AUTO_UPDATE", record.NoAutoUpdate);
            this.MapParameterIn(command, "@PA_COURSE_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_COURSE_USERMULTI_1", record.Usermulti1);
            this.MapParameterIn(command, "@PA_COURSE_CLONE", record.EventClone);
            this.MapParameterIn(command, "@PA_COURSE_OUT_OF_HOURS", record.OutOfHours);
            this.MapParameterIn(command, "@PA_COURSE_STOP_TRAIN_COMPLETION", record.StopTrainCompletion);
            this.MapParameterIn(command, "@PA_COURSE_BD_ORIG_COST", record.BdOrigCost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0.00M) : null ) : record.BdOrigCost);
            this.MapParameterIn(command, "@PA_COURSE_ORDER", record.Order);
            this.MapParameterIn(command, "@PA_COURSE_ELEM_ID", record.ElemId);
            this.MapParameterIn(command, "@PA_COURSE_CODE_LOOKUP1", record.CodeLookup1);
            this.MapParameterIn(command, "@PA_COURSE_PSH_ID", record.PshId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PshId);
            this.MapParameterIn(command, "@PA_COURSE_BLOCK_TYPE", record.BlockType);
            this.MapParameterIn(command, "@PA_COURSE_ATT_MOD_BY", record.AttModBy);
            this.MapParameterIn(command, "@PA_COURSE_ATT_MOD_DATE", record.AttModDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AttModDate);
            this.MapParameterIn(command, "@PA_COURSE_AVAIL", record.Avail);
            this.MapParameterIn(command, "@PA_COURSE_FIRST_LIC_EVENT", record.FirstLicEvent);
            this.MapParameterIn(command, "@PA_COURSE_TRNP_ID", record.TrnpId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TrnpId);
            this.MapParameterIn(command, "@PA_COURSE_LICENSED", record.Licensed);
            this.MapParameterIn(command, "@PA_COURSE_RESULT_REC_DATE", record.ResultRecDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ResultRecDate);
            this.MapParameterIn(command, "@PA_COURSE_PAPERS_REC_DATE", record.PapersRecDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PapersRecDate);
            this.MapParameterIn(command, "@PA_COURSE_CERT_ISSUE_DATE", record.CertIssueDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CertIssueDate);
            this.MapParameterIn(command, "@PA_COURSE_DEL_IMP_DATE", record.DelImpDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DelImpDate);
            this.MapParameterIn(command, "@PA_COURSE_ITEMS_RECEIVED_DATE", record.ItemsReceivedDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ItemsReceivedDate);
            this.MapParameterIn(command, "@PA_COURSE_DELIV_METHD", record.DelivMethd);
            this.MapParameterIn(command, "@PA_COURSE_PACK_SEND_PROLE_ID", record.PackSendProleId);
            this.MapParameterIn(command, "@PA_COURSE_PACK_BCC_EMAIL", record.PackBccEmail);
            this.MapParameterIn(command, "@PA_COURSE_PACK_MDN_EMAIL", record.PackMdnEmail);
            this.MapParameterIn(command, "@PA_COURSE_PACK_DSN_EMAIL", record.PackDsnEmail);
            this.MapParameterIn(command, "@PA_COURSE_PACK_DSN_OPTIONS", record.PackDsnOptions);
            this.MapParameterIn(command, "@PA_COURSE_CODE_IMAGE", record.CodeImage);
            this.MapParameterIn(command, "@PA_COURSE_CLIENT_REF", record.ClientRef);
            this.MapParameterIn(command, "@PA_COURSE_SESSIONS_DESCRIPTION", record.SessionsDescription);
            this.MapParameterIn(command, "@PA_COURSE_SESSIONS_HEADER", record.SessionsHeader);
            this.MapParameterIn(command, "@PA_COURSE_CUT_PRD_TIME", record.CutPrdTime);
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
        ///     The <see cref="CourseRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CourseRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_COURSE_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_COURSE_LOCK", record.Lock);
            record.PersonId = this.MapParameterOut(command, "@PA_COURSE_PERSON_ID", record.PersonId);
            record.ProductId = this.MapParameterOut(command, "@PA_COURSE_PRODUCT_ID", record.ProductId);
            record.LocId = this.MapParameterOut(command, "@PA_COURSE_LOC_ID", record.LocId);
            record.OrgId = this.MapParameterOut(command, "@PA_COURSE_ORG_ID", record.OrgId);
            record.Ref = this.MapParameterOut(command, "@PA_COURSE_REF", record.Ref);
            record.Name = this.MapParameterOut(command, "@PA_COURSE_NAME", record.Name);
            record.Type = this.MapParameterOut(command, "@PA_COURSE_TYPE", record.Type);
            record.Sector = this.MapParameterOut(command, "@PA_COURSE_SECTOR", record.Sector);
            record.OnSite = this.MapParameterOut(command, "@PA_COURSE_ON_SITE", record.OnSite);
            record.BlockPricd = this.MapParameterOut(command, "@PA_COURSE_BLOCK_PRICD", record.BlockPricd);
            record.StartDate = this.MapParameterOut(command, "@PA_COURSE_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_COURSE_END_DATE", record.EndDate);
            record.StartTime = this.MapParameterOut(command, "@PA_COURSE_START_TIME", record.StartTime);
            record.EndTime = this.MapParameterOut(command, "@PA_COURSE_END_TIME", record.EndTime);
            record.Status = this.MapParameterOut(command, "@PA_COURSE_STATUS", record.Status);
            record.DiaryType = this.MapParameterOut(command, "@PA_COURSE_DIARY_TYPE", record.DiaryType);
            record.Length = this.MapParameterOut(command, "@PA_COURSE_LENGTH", record.Length);
            record.MinPlaces = this.MapParameterOut(command, "@PA_COURSE_MIN_PLACES", record.MinPlaces);
            record.MaxPlaces = this.MapParameterOut(command, "@PA_COURSE_MAX_PLACES", record.MaxPlaces);
            record.FreePlaces = this.MapParameterOut(command, "@PA_COURSE_FREE_PLACES", record.FreePlaces);
            record.ConfPlaces = this.MapParameterOut(command, "@PA_COURSE_CONF_PLACES", record.ConfPlaces);
            record.ProvisBkgs = this.MapParameterOut(command, "@PA_COURSE_PROVIS_BKGS", record.ProvisBkgs);
            record.ResvPlaces = this.MapParameterOut(command, "@PA_COURSE_RESV_PLACES", record.ResvPlaces);
            record.Waiting = this.MapParameterOut(command, "@PA_COURSE_WAITING", record.Waiting);
            record.Cancels = this.MapParameterOut(command, "@PA_COURSE_CANCELS", record.Cancels);
            record.BlockThres = this.MapParameterOut(command, "@PA_COURSE_BLOCK_THRES", record.BlockThres);
            record.BlockPrice = this.MapParameterOut(command, "@PA_COURSE_BLOCK_PRICE", record.BlockPrice);
            record.StudtPrice = this.MapParameterOut(command, "@PA_COURSE_STUDT_PRICE", record.StudtPrice);
            record.EstPurPrc = this.MapParameterOut(command, "@PA_COURSE_EST_PUR_PRC", record.EstPurPrc);
            record.NoHours = this.MapParameterOut(command, "@PA_COURSE_NO_HOURS", record.NoHours);
            record.VatCode = this.MapParameterOut(command, "@PA_COURSE_VAT_CODE", record.VatCode);
            record.CostCode = this.MapParameterOut(command, "@PA_COURSE_COST_CODE", record.CostCode);
            record.RevCode = this.MapParameterOut(command, "@PA_COURSE_REV_CODE", record.RevCode);
            record.JnInfOrde = this.MapParameterOut(command, "@PA_COURSE_JN_INF_ORDE", record.JnInfOrde);
            record.Notes = this.MapParameterOut(command, "@PA_COURSE_NOTES", record.Notes);
            record.TucRegion = this.MapParameterOut(command, "@PA_COURSE_TUC_REGION", record.TucRegion);
            record.Budget = this.MapParameterOut(command, "@PA_COURSE_BUDGET", record.Budget);
            record.Actual = this.MapParameterOut(command, "@PA_COURSE_ACTUAL", record.Actual);
            record.PayFag = this.MapParameterOut(command, "@PA_COURSE_PAY_FAG", record.PayFag);
            record.PayDate = this.MapParameterOut(command, "@PA_COURSE_PAY_DATE", record.PayDate);
            record.PayCheqNo = this.MapParameterOut(command, "@PA_COURSE_PAY_CHEQ_NO", record.PayCheqNo);
            record.CollInvNo = this.MapParameterOut(command, "@PA_COURSE_COLL_INV_NO", record.CollInvNo);
            record.InclOutlin = this.MapParameterOut(command, "@PA_COURSE_INCL_OUTLIN", record.InclOutlin);
            record.InclMap = this.MapParameterOut(command, "@PA_COURSE_INCL_MAP", record.InclMap);
            record.IncSpcIns = this.MapParameterOut(command, "@PA_COURSE_INC_SPC_INS", record.IncSpcIns);
            record.InclBkFrm = this.MapParameterOut(command, "@PA_COURSE_INCL_BK_FRM", record.InclBkFrm);
            record.IncPstQst = this.MapParameterOut(command, "@PA_COURSE_INC_PST_QST", record.IncPstQst);
            record.IncPreSrv = this.MapParameterOut(command, "@PA_COURSE_INC_PRE_SRV", record.IncPreSrv);
            record.BudPeriod = this.MapParameterOut(command, "@PA_COURSE_BUD_PERIOD", record.BudPeriod);
            record.BudForecst = this.MapParameterOut(command, "@PA_COURSE_BUD_FORECST", record.BudForecst);
            record.SourceCode = this.MapParameterOut(command, "@PA_COURSE_SOURCE_CODE", record.SourceCode);
            record.PersonId2 = this.MapParameterOut(command, "@PA_COURSE_PERSON_ID_2", record.PersonId2);
            record.Class = this.MapParameterOut(command, "@PA_COURSE_CLASS", record.Class);
            record.HostName = this.MapParameterOut(command, "@PA_COURSE_HOST_NAME", record.HostName);
            record.VenuActual = this.MapParameterOut(command, "@PA_COURSE_VENU_ACTUAL", record.VenuActual);
            record.VenuBudget = this.MapParameterOut(command, "@PA_COURSE_VENU_BUDGET", record.VenuBudget);
            record.CaterActul = this.MapParameterOut(command, "@PA_COURSE_CATER_ACTUL", record.CaterActul);
            record.CaterBdget = this.MapParameterOut(command, "@PA_COURSE_CATER_BDGET", record.CaterBdget);
            record.HotelActul = this.MapParameterOut(command, "@PA_COURSE_HOTEL_ACTUL", record.HotelActul);
            record.HotelBdget = this.MapParameterOut(command, "@PA_COURSE_HOTEL_BDGET", record.HotelBdget);
            record.EquipActul = this.MapParameterOut(command, "@PA_COURSE_EQUIP_ACTUL", record.EquipActul);
            record.EquipBdget = this.MapParameterOut(command, "@PA_COURSE_EQUIP_BDGET", record.EquipBdget);
            record.TravActual = this.MapParameterOut(command, "@PA_COURSE_TRAV_ACTUAL", record.TravActual);
            record.TravBudget = this.MapParameterOut(command, "@PA_COURSE_TRAV_BUDGET", record.TravBudget);
            record.ExpActual = this.MapParameterOut(command, "@PA_COURSE_EXP_ACTUAL", record.ExpActual);
            record.ExpBudget = this.MapParameterOut(command, "@PA_COURSE_EXP_BUDGET", record.ExpBudget);
            record.OthrActual = this.MapParameterOut(command, "@PA_COURSE_OTHR_ACTUAL", record.OthrActual);
            record.OthrBudget = this.MapParameterOut(command, "@PA_COURSE_OTHR_BUDGET", record.OthrBudget);
            record.QuestLett = this.MapParameterOut(command, "@PA_COURSE_QUEST_LETT", record.QuestLett);
            record.SurvLett = this.MapParameterOut(command, "@PA_COURSE_SURV_LETT", record.SurvLett);
            record.BookActual = this.MapParameterOut(command, "@PA_COURSE_BOOK_ACTUAL", record.BookActual);
            record.ActualTot = this.MapParameterOut(command, "@PA_COURSE_ACTUAL_TOT", record.ActualTot);
            record.InclJoin = this.MapParameterOut(command, "@PA_COURSE_INCL_JOIN", record.InclJoin);
            record.IncConfirm = this.MapParameterOut(command, "@PA_COURSE_INC_CONFIRM", record.IncConfirm);
            record.JoinLett = this.MapParameterOut(command, "@PA_COURSE_JOIN_LETT", record.JoinLett);
            record.ConfrmLett = this.MapParameterOut(command, "@PA_COURSE_CONFRM_LETT", record.ConfrmLett);
            record.ProvLett = this.MapParameterOut(command, "@PA_COURSE_PROV_LETT", record.ProvLett);
            record.InvLett = this.MapParameterOut(command, "@PA_COURSE_INV_LETT", record.InvLett);
            record.DoNotInvc = this.MapParameterOut(command, "@PA_COURSE_DO_NOT_INVC", record.DoNotInvc);
            record.CancelDate = this.MapParameterOut(command, "@PA_COURSE_CANCEL_DATE", record.CancelDate);
            record.CancelBy = this.MapParameterOut(command, "@PA_COURSE_CANCEL_BY", record.CancelBy);
            record.IncCshInv = this.MapParameterOut(command, "@PA_COURSE_INC_CSH_INV", record.IncCshInv);
            record.IncProFrm = this.MapParameterOut(command, "@PA_COURSE_INC_PRO_FRM", record.IncProFrm);
            record.IncReceipt = this.MapParameterOut(command, "@PA_COURSE_INC_RECEIPT", record.IncReceipt);
            record.Cmc = this.MapParameterOut(command, "@PA_COURSE_CMC", record.Cmc);
            record.PlId = this.MapParameterOut(command, "@PA_COURSE_PL_ID", record.PlId);
            record.SupplierId = this.MapParameterOut(command, "@PA_COURSE_SUPPLIER_ID", record.SupplierId);
            record.BreakEven = this.MapParameterOut(command, "@PA_COURSE_BREAK_EVEN", record.BreakEven);
            record.ChangeHist = this.MapParameterOut(command, "@PA_COURSE_CHANGE_HIST", record.ChangeHist);
            record.Bip = this.MapParameterOut(command, "@PA_COURSE_BIP", record.Bip);
            record.QuestId = this.MapParameterOut(command, "@PA_COURSE_QUEST_ID", record.QuestId);
            record.PostId = this.MapParameterOut(command, "@PA_COURSE_POST_ID", record.PostId);
            record.OrderNo = this.MapParameterOut(command, "@PA_COURSE_ORDER_NO", record.OrderNo);
            record.ProvPack = this.MapParameterOut(command, "@PA_COURSE_PROV_PACK", record.ProvPack);
            record.ConfPack = this.MapParameterOut(command, "@PA_COURSE_CONF_PACK", record.ConfPack);
            record.JoiningPack = this.MapParameterOut(command, "@PA_COURSE_JOINING_PACK", record.JoiningPack);
            record.PostPack = this.MapParameterOut(command, "@PA_COURSE_POST_PACK", record.PostPack);
            record.ProvInv = this.MapParameterOut(command, "@PA_COURSE_PROV_INV", record.ProvInv);
            record.ConfInv = this.MapParameterOut(command, "@PA_COURSE_CONF_INV", record.ConfInv);
            record.JoinInv = this.MapParameterOut(command, "@PA_COURSE_JOIN_INV", record.JoinInv);
            record.PostInv = this.MapParameterOut(command, "@PA_COURSE_POST_INV", record.PostInv);
            record.Period = this.MapParameterOut(command, "@PA_COURSE_PERIOD", record.Period);
            record.SearchName = this.MapParameterOut(command, "@PA_COURSE_SEARCH_NAME", record.SearchName);
            record.EvrId = this.MapParameterOut(command, "@PA_COURSE_EVR_ID", record.EvrId);
            record.OppId = this.MapParameterOut(command, "@PA_COURSE_OPP_ID", record.OppId);
            record.SessCount = this.MapParameterOut(command, "@PA_COURSE_SESS_COUNT", record.SessCount);
            record.Private = this.MapParameterOut(command, "@PA_COURSE_PRIVATE", record.Private);
            record.PlanId = this.MapParameterOut(command, "@PA_COURSE_PLAN_ID", record.PlanId);
            record.PlanName = this.MapParameterOut(command, "@PA_COURSE_PLAN_NAME", record.PlanName);
            record.Web = this.MapParameterOut(command, "@PA_COURSE_WEB", record.Web);
            record.Grades = this.MapParameterOut(command, "@PA_COURSE_GRADES", record.Grades);
            record.DescTxtId = this.MapParameterOut(command, "@PA_COURSE_DESC_TXT_ID", record.DescTxtId);
            record.TargTxtId = this.MapParameterOut(command, "@PA_COURSE_TARG_TXT_ID", record.TargTxtId);
            record.SetupTime = this.MapParameterOut(command, "@PA_COURSE_SETUP_TIME", record.SetupTime);
            record.DateDec = this.MapParameterOut(command, "@PA_COURSE_DATE_DEC", record.DateDec);
            record.NumInvite = this.MapParameterOut(command, "@PA_COURSE_NUM_INVITE", record.NumInvite);
            record.PersonId3 = this.MapParameterOut(command, "@PA_COURSE_PERSON_ID_3", record.PersonId3);
            record.PersonId4 = this.MapParameterOut(command, "@PA_COURSE_PERSON_ID_4", record.PersonId4);
            record.BuId = this.MapParameterOut(command, "@PA_COURSE_BU_ID", record.BuId);
            record.Usernum1 = this.MapParameterOut(command, "@PA_COURSE_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_COURSE_USERNUM_2", record.Usernum2);
            record.Url = this.MapParameterOut(command, "@PA_COURSE_URL", record.Url);
            record.ProjId = this.MapParameterOut(command, "@PA_COURSE_PROJ_ID", record.ProjId);
            record.Code = this.MapParameterOut(command, "@PA_COURSE_CODE", record.Code);
            record.BtId = this.MapParameterOut(command, "@PA_COURSE_BT_ID", record.BtId);
            record.Comments = this.MapParameterOut(command, "@PA_COURSE_COMMENTS", record.Comments);
            record.ThirdParty = this.MapParameterOut(command, "@PA_COURSE_3RD_PARTY", record.ThirdParty);
            record.UDate1 = this.MapParameterOut(command, "@PA_COURSE_U_DATE_1", record.UDate1);
            record.UDate2 = this.MapParameterOut(command, "@PA_COURSE_U_DATE_2", record.UDate2);
            record.UDate3 = this.MapParameterOut(command, "@PA_COURSE_U_DATE_3", record.UDate3);
            record.UDate4 = this.MapParameterOut(command, "@PA_COURSE_U_DATE_4", record.UDate4);
            record.Usernum3 = this.MapParameterOut(command, "@PA_COURSE_USERNUM_3", record.Usernum3);
            record.AddId = this.MapParameterOut(command, "@PA_COURSE_ADD_ID", record.AddId);
            record.Name2 = this.MapParameterOut(command, "@PA_COURSE_NAME2", record.Name2);
            record.Userchar1 = this.MapParameterOut(command, "@PA_COURSE_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_COURSE_USERCHAR_2", record.Userchar2);
            record.Userchar3 = this.MapParameterOut(command, "@PA_COURSE_USERCHAR_3", record.Userchar3);
            record.Userchar4 = this.MapParameterOut(command, "@PA_COURSE_USERCHAR_4", record.Userchar4);
            record.SupRoleId = this.MapParameterOut(command, "@PA_COURSE_SUP_ROLE_ID", record.SupRoleId);
            record.Currency = this.MapParameterOut(command, "@PA_COURSE_CURRENCY", record.Currency);
            record.PriceA = this.MapParameterOut(command, "@PA_COURSE_PRICE_A", record.PriceA);
            record.PriceB = this.MapParameterOut(command, "@PA_COURSE_PRICE_B", record.PriceB);
            record.PriceC = this.MapParameterOut(command, "@PA_COURSE_PRICE_C", record.PriceC);
            record.PriceD = this.MapParameterOut(command, "@PA_COURSE_PRICE_D", record.PriceD);
            record.PriceE = this.MapParameterOut(command, "@PA_COURSE_PRICE_E", record.PriceE);
            record.Chargable = this.MapParameterOut(command, "@PA_COURSE_CHARGABLE", record.Chargable);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_COURSE_SELCO_SP_ID", record.SelcoSpId);
            record.Usernum4 = this.MapParameterOut(command, "@PA_COURSE_USERNUM_4", record.Usernum4);
            record.Usernum5 = this.MapParameterOut(command, "@PA_COURSE_USERNUM_5", record.Usernum5);
            record.Usernum6 = this.MapParameterOut(command, "@PA_COURSE_USERNUM_6", record.Usernum6);
            record.Usernum7 = this.MapParameterOut(command, "@PA_COURSE_USERNUM_7", record.Usernum7);
            record.Invoiced = this.MapParameterOut(command, "@PA_COURSE_INVOICED", record.Invoiced);
            record.BktId = this.MapParameterOut(command, "@PA_COURSE_BKT_ID", record.BktId);
            record.ContprolId = this.MapParameterOut(command, "@PA_COURSE_CONTPROL_ID", record.ContprolId);
            record.BudRev = this.MapParameterOut(command, "@PA_COURSE_BUD_REV", record.BudRev);
            record.BudForcast = this.MapParameterOut(command, "@PA_COURSE_BUD_FORCAST", record.BudForcast);
            record.UDate5 = this.MapParameterOut(command, "@PA_COURSE_U_DATE_5", record.UDate5);
            record.UDate6 = this.MapParameterOut(command, "@PA_COURSE_U_DATE_6", record.UDate6);
            record.Userchar5 = this.MapParameterOut(command, "@PA_COURSE_USERCHAR_5", record.Userchar5);
            record.Userchar6 = this.MapParameterOut(command, "@PA_COURSE_USERCHAR_6", record.Userchar6);
            record.UTint1 = this.MapParameterOut(command, "@PA_COURSE_U_TINT_1", record.UTint1);
            record.UTint2 = this.MapParameterOut(command, "@PA_COURSE_U_TINT_2", record.UTint2);
            record.UTint3 = this.MapParameterOut(command, "@PA_COURSE_U_TINT_3", record.UTint3);
            record.UTint4 = this.MapParameterOut(command, "@PA_COURSE_U_TINT_4", record.UTint4);
            record.UTint5 = this.MapParameterOut(command, "@PA_COURSE_U_TINT_5", record.UTint5);
            record.UTint6 = this.MapParameterOut(command, "@PA_COURSE_U_TINT_6", record.UTint6);
            record.SyType = this.MapParameterOut(command, "@PA_COURSE_SY_TYPE", record.SyType);
            record.PrejoinPack = this.MapParameterOut(command, "@PA_COURSE_PREJOIN_PACK", record.PrejoinPack);
            record.PstjoinPack = this.MapParameterOut(command, "@PA_COURSE_PSTJOIN_PACK", record.PstjoinPack);
            record.BookActBc2 = this.MapParameterOut(command, "@PA_COURSE_BOOK_ACT_BC2", record.BookActBc2);
            record.ActTotBc2 = this.MapParameterOut(command, "@PA_COURSE_ACT_TOT_BC2", record.ActTotBc2);
            record.ProvSentDte = this.MapParameterOut(command, "@PA_COURSE_PROV_SENT_DTE", record.ProvSentDte);
            record.ConfSentDte = this.MapParameterOut(command, "@PA_COURSE_CONF_SENT_DTE", record.ConfSentDte);
            record.JoinSentDte = this.MapParameterOut(command, "@PA_COURSE_JOIN_SENT_DTE", record.JoinSentDte);
            record.PpSentDte = this.MapParameterOut(command, "@PA_COURSE_PP_SENT_DTE", record.PpSentDte);
            record.PrjoinSentDte = this.MapParameterOut(command, "@PA_COURSE_PRJOIN_SENT_DTE", record.PrjoinSentDte);
            record.PojoinSentDte = this.MapParameterOut(command, "@PA_COURSE_POJOIN_SENT_DTE", record.PojoinSentDte);
            record.CutPrd = this.MapParameterOut(command, "@PA_COURSE_CUT_PRD", record.CutPrd);
            record.SupStatus = this.MapParameterOut(command, "@PA_COURSE_SUP_STATUS", record.SupStatus);
            record.Overbook = this.MapParameterOut(command, "@PA_COURSE_OVERBOOK", record.Overbook);
            record.ProvOrgId = this.MapParameterOut(command, "@PA_COURSE_PROV_ORG_ID", record.ProvOrgId);
            record.ProvProleId = this.MapParameterOut(command, "@PA_COURSE_PROV_PROLE_ID", record.ProvProleId);
            record.AllocStatus = this.MapParameterOut(command, "@PA_COURSE_ALLOC_STATUS", record.AllocStatus);
            record.EstHours = this.MapParameterOut(command, "@PA_COURSE_EST_HOURS", record.EstHours);
            record.Float = this.MapParameterOut(command, "@PA_COURSE_FLOAT", record.Float);
            record.ActHours = this.MapParameterOut(command, "@PA_COURSE_ACT_HOURS", record.ActHours);
            record.Notes2 = this.MapParameterOut(command, "@PA_COURSE_NOTES2", record.Notes2);
            record.Notes3 = this.MapParameterOut(command, "@PA_COURSE_NOTES3", record.Notes3);
            record.Funded = this.MapParameterOut(command, "@PA_COURSE_FUNDED", record.Funded);
            record.FundedOrgId = this.MapParameterOut(command, "@PA_COURSE_FUNDED_ORG_ID", record.FundedOrgId);
            record.QualDel = this.MapParameterOut(command, "@PA_COURSE_QUAL_DEL", record.QualDel);
            record.CohOnly = this.MapParameterOut(command, "@PA_COURSE_COH_ONLY", record.CohOnly);
            record.Analysis1 = this.MapParameterOut(command, "@PA_COURSE_ANALYSIS_1", record.Analysis1);
            record.Analysis2 = this.MapParameterOut(command, "@PA_COURSE_ANALYSIS_2", record.Analysis2);
            record.Reservations = this.MapParameterOut(command, "@PA_COURSE_RESERVATIONS", record.Reservations);
            record.DefElemSt = this.MapParameterOut(command, "@PA_COURSE_DEF_ELEM_ST", record.DefElemSt);
            record.Lapsed = this.MapParameterOut(command, "@PA_COURSE_LAPSED", record.Lapsed);
            record.IntNotes = this.MapParameterOut(command, "@PA_COURSE_INT_NOTES", record.IntNotes);
            record.BdCompBy = this.MapParameterOut(command, "@PA_COURSE_BD_COMP_BY", record.BdCompBy);
            record.BdCompDate = this.MapParameterOut(command, "@PA_COURSE_BD_COMP_DATE", record.BdCompDate);
            record.BdTotActCost = this.MapParameterOut(command, "@PA_COURSE_BD_TOT_ACT_COST", record.BdTotActCost);
            record.BdStatus = this.MapParameterOut(command, "@PA_COURSE_BD_STATUS", record.BdStatus);
            record.Subs = this.MapParameterOut(command, "@PA_COURSE_SUBS", record.Subs);
            record.Transfers = this.MapParameterOut(command, "@PA_COURSE_TRANSFERS", record.Transfers);
            record.HasTrainer = this.MapParameterOut(command, "@PA_COURSE_HAS_TRAINER", record.HasTrainer);
            record.BdPrepBy = this.MapParameterOut(command, "@PA_COURSE_BD_PREP_BY", record.BdPrepBy);
            record.BdPrepDate = this.MapParameterOut(command, "@PA_COURSE_BD_PREP_DATE", record.BdPrepDate);
            record.BdAppBy = this.MapParameterOut(command, "@PA_COURSE_BD_APP_BY", record.BdAppBy);
            record.BdAppDate = this.MapParameterOut(command, "@PA_COURSE_BD_APP_DATE", record.BdAppDate);
            record.BdTotEstCost = this.MapParameterOut(command, "@PA_COURSE_BD_TOT_EST_COST", record.BdTotEstCost);
            record.CalcCommission = this.MapParameterOut(command, "@PA_COURSE_CALC_COMMISSION", record.CalcCommission);
            record.BatId = this.MapParameterOut(command, "@PA_COURSE_BAT_ID", record.BatId);
            record.CancelPack = this.MapParameterOut(command, "@PA_COURSE_CANCEL_PACK", record.CancelPack);
            record.CanpSentDte = this.MapParameterOut(command, "@PA_COURSE_CANP_SENT_DTE", record.CanpSentDte);
            record.CancellationDate = this.MapParameterOut(command, "@PA_COURSE_CANCELLATION_DATE", record.CancellationDate);
            record.Reason = this.MapParameterOut(command, "@PA_COURSE_REASON", record.Reason);
            record.UnrecoverableCancLoss = this.MapParameterOut(command, "@PA_COURSE_UNRECOVERABLE_CANC_LOSS", record.UnrecoverableCancLoss);
            record.DefaultTraineeDays = this.MapParameterOut(command, "@PA_COURSE_DEFAULT_TRAINEE_DAYS", record.DefaultTraineeDays);
            record.GrantEligable = this.MapParameterOut(command, "@PA_COURSE_GRANT_ELIGABLE", record.GrantEligable);
            record.GrantValueAvailable = this.MapParameterOut(command, "@PA_COURSE_GRANT_VALUE_AVAILABLE", record.GrantValueAvailable);
            record.BreakevenValue1 = this.MapParameterOut(command, "@PA_COURSE_BREAKEVEN_VALUE1", record.BreakevenValue1);
            record.BreakevenValue2 = this.MapParameterOut(command, "@PA_COURSE_BREAKEVEN_VALUE2", record.BreakevenValue2);
            record.ExtCourseware = this.MapParameterOut(command, "@PA_COURSE_EXT_COURSEWARE", record.ExtCourseware);
            record.Contingency = this.MapParameterOut(command, "@PA_COURSE_CONTINGENCY", record.Contingency);
            record.Cost = this.MapParameterOut(command, "@PA_COURSE_COST", record.Cost);
            record.DeliveryDays = this.MapParameterOut(command, "@PA_COURSE_DELIVERY_DAYS", record.DeliveryDays);
            record.MtrProleId = this.MapParameterOut(command, "@PA_COURSE_MTR_PROLE_ID", record.MtrProleId);
            record.MaProleId = this.MapParameterOut(command, "@PA_COURSE_MA_PROLE_ID", record.MaProleId);
            record.AcadyCode = this.MapParameterOut(command, "@PA_COURSE_ACADY_CODE", record.AcadyCode);
            record.NoAutoUpdate = this.MapParameterOut(command, "@PA_COURSE_NO_AUTO_UPDATE", record.NoAutoUpdate);
            record.CourseId = this.MapParameterOut(command, "@PA_COURSE_COURSE_ID", record.CourseId);
            record.Usermulti1 = this.MapParameterOut(command, "@PA_COURSE_USERMULTI_1", record.Usermulti1);
            record.EventClone = this.MapParameterOut(command, "@PA_COURSE_CLONE", record.EventClone);
            record.OutOfHours = this.MapParameterOut(command, "@PA_COURSE_OUT_OF_HOURS", record.OutOfHours);
            record.StopTrainCompletion = this.MapParameterOut(command, "@PA_COURSE_STOP_TRAIN_COMPLETION", record.StopTrainCompletion);
            record.BdOrigCost = this.MapParameterOut(command, "@PA_COURSE_BD_ORIG_COST", record.BdOrigCost);
            record.Order = this.MapParameterOut(command, "@PA_COURSE_ORDER", record.Order);
            record.ElemId = this.MapParameterOut(command, "@PA_COURSE_ELEM_ID", record.ElemId);
            record.CodeLookup1 = this.MapParameterOut(command, "@PA_COURSE_CODE_LOOKUP1", record.CodeLookup1);
            record.PshId = this.MapParameterOut(command, "@PA_COURSE_PSH_ID", record.PshId);
            record.BlockType = this.MapParameterOut(command, "@PA_COURSE_BLOCK_TYPE", record.BlockType);
            record.AttModBy = this.MapParameterOut(command, "@PA_COURSE_ATT_MOD_BY", record.AttModBy);
            record.AttModDate = this.MapParameterOut(command, "@PA_COURSE_ATT_MOD_DATE", record.AttModDate);
            record.Avail = this.MapParameterOut(command, "@PA_COURSE_AVAIL", record.Avail);
            record.FirstLicEvent = this.MapParameterOut(command, "@PA_COURSE_FIRST_LIC_EVENT", record.FirstLicEvent);
            record.TrnpId = this.MapParameterOut(command, "@PA_COURSE_TRNP_ID", record.TrnpId);
            record.Licensed = this.MapParameterOut(command, "@PA_COURSE_LICENSED", record.Licensed);
            record.ResultRecDate = this.MapParameterOut(command, "@PA_COURSE_RESULT_REC_DATE", record.ResultRecDate);
            record.PapersRecDate = this.MapParameterOut(command, "@PA_COURSE_PAPERS_REC_DATE", record.PapersRecDate);
            record.CertIssueDate = this.MapParameterOut(command, "@PA_COURSE_CERT_ISSUE_DATE", record.CertIssueDate);
            record.DelImpDate = this.MapParameterOut(command, "@PA_COURSE_DEL_IMP_DATE", record.DelImpDate);
            record.ItemsReceivedDate = this.MapParameterOut(command, "@PA_COURSE_ITEMS_RECEIVED_DATE", record.ItemsReceivedDate);
            record.DelivMethd = this.MapParameterOut(command, "@PA_COURSE_DELIV_METHD", record.DelivMethd);
            record.PackSendProleId = this.MapParameterOut(command, "@PA_COURSE_PACK_SEND_PROLE_ID", record.PackSendProleId);
            record.PackBccEmail = this.MapParameterOut(command, "@PA_COURSE_PACK_BCC_EMAIL", record.PackBccEmail);
            record.PackMdnEmail = this.MapParameterOut(command, "@PA_COURSE_PACK_MDN_EMAIL", record.PackMdnEmail);
            record.PackDsnEmail = this.MapParameterOut(command, "@PA_COURSE_PACK_DSN_EMAIL", record.PackDsnEmail);
            record.PackDsnOptions = this.MapParameterOut(command, "@PA_COURSE_PACK_DSN_OPTIONS", record.PackDsnOptions);
            record.CodeImage = this.MapParameterOut(command, "@PA_COURSE_CODE_IMAGE", record.CodeImage);
            record.ClientRef = this.MapParameterOut(command, "@PA_COURSE_CLIENT_REF", record.ClientRef);
            record.SessionsDescription = this.MapParameterOut(command, "@PA_COURSE_SESSIONS_DESCRIPTION", record.SessionsDescription);
            record.SessionsHeader = this.MapParameterOut(command, "@PA_COURSE_SESSIONS_HEADER", record.SessionsHeader);
            record.CutPrdTime = this.MapParameterOut(command, "@PA_COURSE_CUT_PRD_TIME", record.CutPrdTime);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByPersonId(String personId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PersonId");
            this.MapParameterIn(command, "@PA_COURSE_PERSON_ID", personId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByProductId(String productId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProductId");
            this.MapParameterIn(command, "@PA_COURSE_PRODUCT_ID", productId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='locId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByLocId(String locId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LocId");
            this.MapParameterIn(command, "@PA_COURSE_LOC_ID", locId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_COURSE_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notes">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='notes' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByNotes(String notes)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Notes");
            this.MapParameterIn(command, "@PA_COURSE_NOTES", notes);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="supplierId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='supplierId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllBySupplierId(String supplierId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SupplierId");
            this.MapParameterIn(command, "@PA_COURSE_SUPPLIER_ID", supplierId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='oppId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByOppId(String oppId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OppId");
            this.MapParameterIn(command, "@PA_COURSE_OPP_ID", oppId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='addId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByAddId(String addId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AddId");
            this.MapParameterIn(command, "@PA_COURSE_ADD_ID", addId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="supRoleId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='supRoleId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllBySupRoleId(String supRoleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SupRoleId");
            this.MapParameterIn(command, "@PA_COURSE_SUP_ROLE_ID", supRoleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_COURSE_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bktId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='bktId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByBktId(String bktId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BktId");
            this.MapParameterIn(command, "@PA_COURSE_BKT_ID", bktId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="contprolId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='contprolId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByContprolId(String contprolId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ContprolId");
            this.MapParameterIn(command, "@PA_COURSE_CONTPROL_ID", contprolId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="provOrgId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='provOrgId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByProvOrgId(String provOrgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProvOrgId");
            this.MapParameterIn(command, "@PA_COURSE_PROV_ORG_ID", provOrgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="provProleId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='provProleId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByProvProleId(String provProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProvProleId");
            this.MapParameterIn(command, "@PA_COURSE_PROV_PROLE_ID", provProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fundedOrgId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='fundedOrgId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByFundedOrgId(String fundedOrgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "FundedOrgId");
            this.MapParameterIn(command, "@PA_COURSE_FUNDED_ORG_ID", fundedOrgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="intNotes">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='intNotes' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByIntNotes(String intNotes)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "IntNotes");
            this.MapParameterIn(command, "@PA_COURSE_INT_NOTES", intNotes);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mtrProleId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='mtrProleId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByMtrProleId(String mtrProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MtrProleId");
            this.MapParameterIn(command, "@PA_COURSE_MTR_PROLE_ID", mtrProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pshId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseRecord" /> instances that match the specified <paramref name='pshId' />.
        /// </returns>
        public IEnumerable<CourseRecord> FetchAllByPshId(Int32? pshId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PshId");
            this.MapParameterIn(command, "@PA_COURSE_PSH_ID", pshId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IEventRepository.TableName
        {
            get { return this.TableName; }
        }

        void IEventRepository.Modify(Consensus.Learning.CourseRecord record)
        {
            this.Modify(record);
        }

        void IEventRepository.Create(Consensus.Learning.CourseRecord record)
        {
            this.Create(record);
        }

        /// <summary>
        ///     Retrieves a single <see cref="T:Consensus.Learning.CourseRecord" /> instance from the data store.
        /// </summary>
        /// <param name="courseParentId">
        ///     The value which identifies the <see cref="T:Consensus.Learning.CourseRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Learning.CourseRecord" /> instance which matches the specified <paramref name="courseParentId" />.
        /// </returns>
        Consensus.Learning.CourseRecord IEventRepository.FetchByCourseParentId(System.String courseParentId)
        {
            return this.FetchByCourseParentId(courseParentId);
        }

        void IEventRepository.CalculateCourseNumbers(System.String courseId)
        {
            this.CalculateCourseNumbers(courseId);
        }

        void IEventRepository.CalculateCourseStartEnd(System.String courseId)
        {
            this.CalculateCourseStartEnd(courseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="locId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByLocId(System.String locId)
        {
            return this.FetchAllByLocId(locId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notes">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="notes" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByNotes(System.String notes)
        {
            return this.FetchAllByNotes(notes);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="supplierId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="supplierId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllBySupplierId(System.String supplierId)
        {
            return this.FetchAllBySupplierId(supplierId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="oppId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByOppId(System.String oppId)
        {
            return this.FetchAllByOppId(oppId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByAddId(System.String addId)
        {
            return this.FetchAllByAddId(addId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="supRoleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="supRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllBySupRoleId(System.String supRoleId)
        {
            return this.FetchAllBySupRoleId(supRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bktId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="bktId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByBktId(System.String bktId)
        {
            return this.FetchAllByBktId(bktId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="contprolId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="contprolId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByContprolId(System.String contprolId)
        {
            return this.FetchAllByContprolId(contprolId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="provOrgId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="provOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByProvOrgId(System.String provOrgId)
        {
            return this.FetchAllByProvOrgId(provOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="provProleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="provProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByProvProleId(System.String provProleId)
        {
            return this.FetchAllByProvProleId(provProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fundedOrgId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="fundedOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByFundedOrgId(System.String fundedOrgId)
        {
            return this.FetchAllByFundedOrgId(fundedOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="intNotes">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="intNotes" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByIntNotes(System.String intNotes)
        {
            return this.FetchAllByIntNotes(intNotes);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mtrProleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseRecord" /> instances that match the specified <paramref name="mtrProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByMtrProleId(System.String mtrProleId)
        {
            return this.FetchAllByMtrProleId(mtrProleId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseRecord> IEventRepository.FetchAllByPshId(System.Nullable<System.Int32> pshId)
        {
            return this.FetchAllByPshId(pshId);
        }

        #endregion
    }
}
