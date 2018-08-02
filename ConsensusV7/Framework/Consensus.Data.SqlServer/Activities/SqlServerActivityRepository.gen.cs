using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ActivityRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerActivityRepository : SqlServerRepository<ActivityRecord, String>, IActivityRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Activities"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Activity"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ActivityRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ACT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Activity"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ActivityRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ActivityRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ActivityRecord record)
        {
            record.Id = dataRecord["ACT_ID"].ConvertTo<String>();
            record.Lock = dataRecord["ACT_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["ACT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ACT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ACT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ACT_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ACT_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["ACT_RCV_FROM"].ConvertTo<String>();
            record.Type = dataRecord["ACT_TYPE"].ConvertTo<String>();
            record.DoneIt = dataRecord["ACT_DONE_IT"].ConvertTo<Byte?>();
            record.KeyNote = dataRecord["ACT_KEY_NOTE"].ConvertTo<String>();
            record.ActionDate = dataRecord["ACT_ACTION_DATE"].ConvertTo<DateTime?>();
            record.Time = dataRecord["ACT_TIME"].ConvertTo<DateTime?>();
            record.NextDate = dataRecord["ACT_NEXT_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["ACT_END_DATE"].ConvertTo<DateTime?>();
            record.EndTime = dataRecord["ACT_END_TIME"].ConvertTo<DateTime?>();
            record.LocId = dataRecord["ACT_LOC_ID"].ConvertTo<String>();
            record.Result = dataRecord["ACT_RESULT"].ConvertTo<String>();
            record.PrevActiv = dataRecord["ACT_PREV_ACTIV"].ConvertTo<String>();
            record.PromotionId = dataRecord["ACT_PROMOTION_ID"].ConvertTo<String>();
            record.BookId = dataRecord["ACT_BOOK_ID"].ConvertTo<String>();
            record.CourseId = dataRecord["ACT_COURSE_ID"].ConvertTo<String>();
            record.TrainerId = dataRecord["ACT_TRAINER_ID"].ConvertTo<String>();
            record.TextId = dataRecord["ACT_TEXT_ID"].ConvertTo<String>();
            record.Note = dataRecord["ACT_NOTE"].ConvertTo<String>();
            record.DoneItDate = dataRecord["ACT_DONE_IT_DATE"].ConvertTo<DateTime?>();
            record.SourceCode = dataRecord["ACT_SOURCE_CODE"].ConvertTo<String>();
            record.LastNo = dataRecord["ACT_LAST_NO"].ConvertTo<String>();
            record.Hierarchy = dataRecord["ACT_HIERARCHY"].ConvertTo<String>();
            record.Level = dataRecord["ACT_LEVEL"].ConvertTo<String>();
            record.InitiatedBy = dataRecord["ACT_INITIATED_BY"].ConvertTo<Double?>();
            record.ManIssues = dataRecord["ACT_MAN_ISSUES"].ConvertTo<String>();
            record.VisitObj = dataRecord["ACT_VISIT_OBJ"].ConvertTo<String>();
            record.Cb1 = dataRecord["ACT_CB_1"].ConvertTo<Double?>();
            record.Cb2 = dataRecord["ACT_CB_2"].ConvertTo<Double?>();
            record.Cb3 = dataRecord["ACT_CB_3"].ConvertTo<Double?>();
            record.Cb4 = dataRecord["ACT_CB_4"].ConvertTo<Double?>();
            record.Cb5 = dataRecord["ACT_CB_5"].ConvertTo<Double?>();
            record.Cb6 = dataRecord["ACT_CB_6"].ConvertTo<Double?>();
            record.Cb7 = dataRecord["ACT_CB_7"].ConvertTo<Double?>();
            record.Cb8 = dataRecord["ACT_CB_8"].ConvertTo<Double?>();
            record.Cb9 = dataRecord["ACT_CB_9"].ConvertTo<Double?>();
            record.Cb10 = dataRecord["ACT_CB_10"].ConvertTo<Double?>();
            record.OppId = dataRecord["ACT_OPP_ID"].ConvertTo<String>();
            record.HelpType = dataRecord["ACT_HELP_TYPE"].ConvertTo<String>();
            record.ProductCode = dataRecord["ACT_PRODUCT_CODE"].ConvertTo<String>();
            record.ProductGroup = dataRecord["ACT_PRODUCT_GROUP"].ConvertTo<String>();
            record.PicId = dataRecord["ACT_PIC_ID"].ConvertTo<String>();
            record.ClosCat = dataRecord["ACT_CLOS_CAT"].ConvertTo<String>();
            record.ClosData = dataRecord["ACT_CLOS_DATA"].ConvertTo<String>();
            record.Source = dataRecord["ACT_SOURCE"].ConvertTo<String>();
            record.Subject = dataRecord["ACT_SUBJECT"].ConvertTo<String>();
            record.SubText = dataRecord["ACT_SUB_TEXT"].ConvertTo<String>();
            record.ServiceType = dataRecord["ACT_SERVICE_TYPE"].ConvertTo<String>();
            record.ProblemCat = dataRecord["ACT_PROBLEM_CAT"].ConvertTo<String>();
            record.InId = dataRecord["ACT_IN_ID"].ConvertTo<String>();
            record.Invoiced = dataRecord["ACT_INVOICED"].ConvertTo<Byte?>();
            record.SupContRef = dataRecord["ACT_SUP_CONT_REF"].ConvertTo<String>();
            record.ChargeType = dataRecord["ACT_CHARGE_TYPE"].ConvertTo<String>();
            record.Minutes = dataRecord["ACT_MINUTES"].ConvertTo<Int32?>();
            record.Value = dataRecord["ACT_VALUE"].ConvertTo<Double?>();
            record.ValueBc = dataRecord["ACT_VALUE_BC"].ConvertTo<Double?>();
            record.CurrencyType = dataRecord["ACT_CURRENCY_TYPE"].ConvertTo<String>();
            record.SchemeId = dataRecord["ACT_SCHEME_ID"].ConvertTo<String>();
            record.NxtStage = dataRecord["ACT_NXT_STAGE"].ConvertTo<String>();
            record.NxtStgeDate = dataRecord["ACT_NXT_STGE_DATE"].ConvertTo<DateTime?>();
            record.Alarmdate = dataRecord["ACT_ALARMDATE"].ConvertTo<DateTime?>();
            record.Alarmtime = dataRecord["ACT_ALARMTIME"].ConvertTo<DateTime?>();
            record.SyllabusId = dataRecord["ACT_SYLLABUS_ID"].ConvertTo<String>();
            record.SessionName = dataRecord["ACT_SESSION_NAME"].ConvertTo<String>();
            record.ResourceId = dataRecord["ACT_RESOURCE_ID"].ConvertTo<String>();
            record.Real = dataRecord["ACT_REAL"].ConvertTo<Byte?>();
            record.Element = dataRecord["ACT_ELEMENT"].ConvertTo<Byte?>();
            record.Mandatory = dataRecord["ACT_MANDATORY"].ConvertTo<Byte?>();
            record.InvoicePrint = dataRecord["ACT_INVOICE_PRINT"].ConvertTo<Byte?>();
            record.MaxPlaces = dataRecord["ACT_MAX_PLACES"].ConvertTo<Double?>();
            record.MinPlaces = dataRecord["ACT_MIN_PLACES"].ConvertTo<Double?>();
            record.FreePlaces = dataRecord["ACT_FREE_PLACES"].ConvertTo<Double?>();
            record.Price = dataRecord["ACT_PRICE"].ConvertTo<Double?>();
            record.BlockPrice = dataRecord["ACT_BLOCK_PRICE"].ConvertTo<Double?>();
            record.PriceBc = dataRecord["ACT_PRICE_BC"].ConvertTo<Double?>();
            record.BlockPriceBc = dataRecord["ACT_BLOCK_PRICE_BC"].ConvertTo<Double?>();
            record.Vatcd = dataRecord["ACT_VATCD"].ConvertTo<String>();
            record.RevCode = dataRecord["ACT_REV_CODE"].ConvertTo<String>();
            record.CostCode = dataRecord["ACT_COST_CODE"].ConvertTo<String>();
            record.DoNotInvoice = dataRecord["ACT_DO_NOT_INVOICE"].ConvertTo<Byte?>();
            record.FromBomType = dataRecord["ACT_FROM_BOM_TYPE"].ConvertTo<String>();
            record.RoomGrade = dataRecord["ACT_ROOM_GRADE"].ConvertTo<String>();
            record.TaskName = dataRecord["ACT_TASK_NAME"].ConvertTo<String>();
            record.TaskStatus = dataRecord["ACT_TASK_STATUS"].ConvertTo<String>();
            record.EstHours = dataRecord["ACT_EST_HOURS"].ConvertTo<Double?>();
            record.ActualHours = dataRecord["ACT_ACTUAL_HOURS"].ConvertTo<Double?>();
            record.Usernum1 = dataRecord["ACT_USERNUM_1"].ConvertTo<Double?>();
            record.Usernum2 = dataRecord["ACT_USERNUM_2"].ConvertTo<Double?>();
            record.Usernum3 = dataRecord["ACT_USERNUM_3"].ConvertTo<Double?>();
            record.ReviewDate = dataRecord["ACT_REVIEW_DATE"].ConvertTo<DateTime?>();
            record.ReviewTime = dataRecord["ACT_REVIEW_TIME"].ConvertTo<DateTime?>();
            record.ProjId = dataRecord["ACT_PROJ_ID"].ConvertTo<String>();
            record.FilePath = dataRecord["ACT_FILE_PATH"].ConvertTo<String>();
            record.Bip = dataRecord["ACT_BIP"].ConvertTo<Double?>();
            record.PartNote = dataRecord["ACT_PART_NOTE"].ConvertTo<String>();
            record.Period = dataRecord["ACT_PERIOD"].ConvertTo<String>();
            record.Overbook = dataRecord["ACT_OVERBOOK"].ConvertTo<Double?>();
            record.SessionName2 = dataRecord["ACT_SESSION_NAME2"].ConvertTo<String>();
            record.OrgId = dataRecord["ACT_ORG_ID"].ConvertTo<String>();
            record.Address = dataRecord["ACT_ADDRESS"].ConvertTo<String>();
            record.PqId = dataRecord["ACT_PQ_ID"].ConvertTo<String>();
            record.PqStatus = dataRecord["ACT_PQ_STATUS"].ConvertTo<String>();
            record.PqStatusText = dataRecord["ACT_PQ_STATUS_TEXT"].ConvertTo<String>();
            record.PqSendType = dataRecord["ACT_PQ_SEND_TYPE"].ConvertTo<String>();
            record.PqSentDate = dataRecord["ACT_PQ_SENT_DATE"].ConvertTo<DateTime?>();
            record.PqKeep = dataRecord["ACT_PQ_KEEP"].ConvertTo<Byte?>();
            record.MepId = dataRecord["ACT_MEP_ID"].ConvertTo<String>();
            record.TypeSub = dataRecord["ACT_TYPE_SUB"].ConvertTo<String>();
            record.AutoAllocate = dataRecord["ACT_AUTO_ALLOCATE"].ConvertTo<Byte?>();
            record.WfId = dataRecord["ACT_WF_ID"].ConvertTo<String>();
            record.EvrIncTot = dataRecord["ACT_EVR_INC_TOT"].ConvertTo<Byte?>();
            record.EvrIncQuo = dataRecord["ACT_EVR_INC_QUO"].ConvertTo<Byte?>();
            record.AddId = dataRecord["ACT_ADD_ID"].ConvertTo<String>();
            record.Attendees = dataRecord["ACT_ATTENDEES"].ConvertTo<String>();
            record.CenId = dataRecord["ACT_CEN_ID"].ConvertTo<String>();
            record.RoomLayout = dataRecord["ACT_ROOM_LAYOUT"].ConvertTo<Int32?>();
            record.NoteHtml = dataRecord["ACT_NOTE_HTML"].ConvertTo<String>();
            record.Layout = dataRecord["ACT_LAYOUT"].ConvertTo<Byte?>();
            record.PlacesToSet = dataRecord["ACT_PLACES_TO_SET"].ConvertTo<Int32?>();
            record.ProdId = dataRecord["ACT_PROD_ID"].ConvertTo<String>();
            record.StaffNeeded = dataRecord["ACT_STAFF_NEEDED"].ConvertTo<Byte?>();
            record.TimePrep = dataRecord["ACT_TIME_PREP"].ConvertTo<Double?>();
            record.TimeClean = dataRecord["ACT_TIME_CLEAN"].ConvertTo<Double?>();
            record.TrnId = dataRecord["ACT_TRN_ID"].ConvertTo<String>();
            record.Priority = dataRecord["ACT_PRIORITY"].ConvertTo<String>();
            record.Float = dataRecord["ACT_FLOAT"].ConvertTo<Byte?>();
            record.AllocStatus = dataRecord["ACT_ALLOC_STATUS"].ConvertTo<Byte?>();
            record.DeptId = dataRecord["ACT_DEPT_ID"].ConvertTo<String>();
            record.RoomBooking = dataRecord["ACT_ROOM_BOOKING"].ConvertTo<Byte?>();
            record.ContprolId = dataRecord["ACT_CONTPROL_ID"].ConvertTo<String>();
            record.ResType = dataRecord["ACT_RES_TYPE"].ConvertTo<String>();
            record.Duration = dataRecord["ACT_DURATION"].ConvertTo<Double>();
            record.PdId = dataRecord["ACT_PD_ID"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["ACT_SELCO_SP_ID"].ConvertTo<String>();
            record.IncInBudget = dataRecord["ACT_INC_IN_BUDGET"].ConvertTo<Byte>();
            record.VerCat = dataRecord["ACT_VER_CAT"].ConvertTo<String>();
            record.PdpempId = dataRecord["ACT_PDPEMP_ID"].ConvertTo<Int32?>();
            record.AppBy = dataRecord["ACT_APP_BY"].ConvertTo<String>();
            record.AppDate = dataRecord["ACT_APP_DATE"].ConvertTo<DateTime?>();
            record.NextReview = dataRecord["ACT_NEXT_REVIEW"].ConvertTo<DateTime?>();
            record.InvId = dataRecord["ACT_INV_ID"].ConvertTo<String>();
            record.Code = dataRecord["ACT_CODE"].ConvertTo<String>();
            record.SessionType = dataRecord["ACT_SESSION_TYPE"].ConvertTo<String>();
            record.TeachHrs = dataRecord["ACT_TEACH_HRS"].ConvertTo<Decimal?>();
            record.StudWks = dataRecord["ACT_STUD_WKS"].ConvertTo<Decimal?>();
            record.NotinuseStart = dataRecord["ACT_NOTINUSE_START"].ConvertTo<DateTime?>();
            record.NotinuseEnd = dataRecord["ACT_NOTINUSE_END"].ConvertTo<DateTime?>();
            record.ConfSessionOrder = dataRecord["ACT_CONF_SESSION_ORDER"].ConvertTo<Int32?>();
            record.AddedBy = dataRecord["ACT_ADDED_BY"].ConvertTo<Byte>();
            record.OutlookUid = dataRecord["ACT_OUTLOOK_UID"].ConvertTo<String>();
            record.UniqueRef = dataRecord["ACT_UNIQUE_REF"].ConvertTo<String>();
            record.NoSlots = dataRecord["ACT_NO_SLOTS"].ConvertTo<Int32?>();
            record.Cancelled = dataRecord["ACT_CANCELLED"].ConvertTo<Byte>();
            record.Delete = dataRecord["ACT_DELETE"].ConvertTo<Byte>();
            record.BomId = dataRecord["ACT_BOM_ID"].ConvertTo<String>();
            record.Status = dataRecord["ACT_STATUS"].ConvertTo<String>();
            record.Outcome = dataRecord["ACT_OUTCOME"].ConvertTo<String>();
            record.QuestId = dataRecord["ACT_QUEST_ID"].ConvertTo<String>();
            record.BuildVersion = dataRecord["ACT_BUILD_VERSION"].ConvertTo<String>();
            record.LockedDate = dataRecord["ACT_LOCKED_DATE"].ConvertTo<DateTime?>();
            record.Timeout = dataRecord["ACT_TIMEOUT"].ConvertTo<DateTime?>();
            record.CgCode = dataRecord["ACT_CG_CODE"].ConvertTo<String>();
            record.ProvPack = dataRecord["ACT_PROV_PACK"].ConvertTo<String>();
            record.ConfPack = dataRecord["ACT_CONF_PACK"].ConvertTo<String>();
            record.JoiningPack = dataRecord["ACT_JOINING_PACK"].ConvertTo<String>();
            record.PostPack = dataRecord["ACT_POST_PACK"].ConvertTo<String>();
            record.PrejoinPack = dataRecord["ACT_PREJOIN_PACK"].ConvertTo<String>();
            record.PstjoinPack = dataRecord["ACT_PSTJOIN_PACK"].ConvertTo<String>();
            record.ProvSentDte = dataRecord["ACT_PROV_SENT_DTE"].ConvertTo<DateTime?>();
            record.ConfSentDte = dataRecord["ACT_CONF_SENT_DTE"].ConvertTo<DateTime?>();
            record.JoinSentDte = dataRecord["ACT_JOIN_SENT_DTE"].ConvertTo<DateTime?>();
            record.PpSentDte = dataRecord["ACT_PP_SENT_DTE"].ConvertTo<DateTime?>();
            record.PrjoinSentDte = dataRecord["ACT_PRJOIN_SENT_DTE"].ConvertTo<DateTime?>();
            record.PojoinSentDte = dataRecord["ACT_POJOIN_SENT_DTE"].ConvertTo<DateTime?>();
            record.Dropdown1 = dataRecord["ACT_DROPDOWN_1"].ConvertTo<String>();
            record.Dropdown2 = dataRecord["ACT_DROPDOWN_2"].ConvertTo<String>();
            record.RevenueSplit = dataRecord["ACT_REVENUE_SPLIT"].ConvertTo<Double>();
            record.HoursSplit = dataRecord["ACT_HOURS_SPLIT"].ConvertTo<Double>();
            record.Arrived = dataRecord["ACT_ARRIVED"].ConvertTo<Byte?>();
            record.ExpOccupancy = dataRecord["ACT_EXP_OCCUPANCY"].ConvertTo<Int32?>();
            record.Reserve = dataRecord["ACT_RESERVE"].ConvertTo<Byte?>();
            record.VisitOutcome = dataRecord["ACT_VISIT_OUTCOME"].ConvertTo<String>();
            record.TrnpId = dataRecord["ACT_TRNP_ID"].ConvertTo<Int32?>();
            record.ShowAttLog = dataRecord["ACT_SHOW_ATT_LOG"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ActivityRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ActivityRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ACT_ID", record.Id);
            this.MapParameterIn(command, "@PA_ACT_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_ACT_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_ACT_DONE_IT", record.DoneIt);
            this.MapParameterIn(command, "@PA_ACT_KEY_NOTE", record.KeyNote);
            this.MapParameterIn(command, "@PA_ACT_ACTION_DATE", record.ActionDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ActionDate);
            this.MapParameterIn(command, "@PA_ACT_TIME", record.Time == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Time);
            this.MapParameterIn(command, "@PA_ACT_NEXT_DATE", record.NextDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NextDate);
            this.MapParameterIn(command, "@PA_ACT_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_ACT_END_TIME", record.EndTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndTime);
            this.MapParameterIn(command, "@PA_ACT_LOC_ID", record.LocId);
            this.MapParameterIn(command, "@PA_ACT_RESULT", record.Result);
            this.MapParameterIn(command, "@PA_ACT_PREV_ACTIV", record.PrevActiv);
            this.MapParameterIn(command, "@PA_ACT_PROMOTION_ID", record.PromotionId);
            this.MapParameterIn(command, "@PA_ACT_BOOK_ID", record.BookId);
            this.MapParameterIn(command, "@PA_ACT_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_ACT_TRAINER_ID", record.TrainerId);
            this.MapParameterIn(command, "@PA_ACT_TEXT_ID", record.TextId);
            this.MapParameterIn(command, "@PA_ACT_NOTE", record.Note);
            this.MapParameterIn(command, "@PA_ACT_DONE_IT_DATE", record.DoneItDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DoneItDate);
            this.MapParameterIn(command, "@PA_ACT_SOURCE_CODE", record.SourceCode);
            this.MapParameterIn(command, "@PA_ACT_LAST_NO", record.LastNo);
            this.MapParameterIn(command, "@PA_ACT_HIERARCHY", record.Hierarchy);
            this.MapParameterIn(command, "@PA_ACT_LEVEL", record.Level);
            this.MapParameterIn(command, "@PA_ACT_INITIATED_BY", record.InitiatedBy == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.InitiatedBy);
            this.MapParameterIn(command, "@PA_ACT_MAN_ISSUES", record.ManIssues);
            this.MapParameterIn(command, "@PA_ACT_VISIT_OBJ", record.VisitObj);
            this.MapParameterIn(command, "@PA_ACT_CB_1", record.Cb1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cb1);
            this.MapParameterIn(command, "@PA_ACT_CB_2", record.Cb2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cb2);
            this.MapParameterIn(command, "@PA_ACT_CB_3", record.Cb3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cb3);
            this.MapParameterIn(command, "@PA_ACT_CB_4", record.Cb4 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cb4);
            this.MapParameterIn(command, "@PA_ACT_CB_5", record.Cb5 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cb5);
            this.MapParameterIn(command, "@PA_ACT_CB_6", record.Cb6 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cb6);
            this.MapParameterIn(command, "@PA_ACT_CB_7", record.Cb7 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cb7);
            this.MapParameterIn(command, "@PA_ACT_CB_8", record.Cb8 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cb8);
            this.MapParameterIn(command, "@PA_ACT_CB_9", record.Cb9 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cb9);
            this.MapParameterIn(command, "@PA_ACT_CB_10", record.Cb10 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cb10);
            this.MapParameterIn(command, "@PA_ACT_OPP_ID", record.OppId);
            this.MapParameterIn(command, "@PA_ACT_HELP_TYPE", record.HelpType);
            this.MapParameterIn(command, "@PA_ACT_PRODUCT_CODE", record.ProductCode);
            this.MapParameterIn(command, "@PA_ACT_PRODUCT_GROUP", record.ProductGroup);
            this.MapParameterIn(command, "@PA_ACT_PIC_ID", record.PicId);
            this.MapParameterIn(command, "@PA_ACT_CLOS_CAT", record.ClosCat);
            this.MapParameterIn(command, "@PA_ACT_CLOS_DATA", record.ClosData);
            this.MapParameterIn(command, "@PA_ACT_SOURCE", record.Source);
            this.MapParameterIn(command, "@PA_ACT_SUBJECT", record.Subject);
            this.MapParameterIn(command, "@PA_ACT_SUB_TEXT", record.SubText);
            this.MapParameterIn(command, "@PA_ACT_SERVICE_TYPE", record.ServiceType);
            this.MapParameterIn(command, "@PA_ACT_PROBLEM_CAT", record.ProblemCat);
            this.MapParameterIn(command, "@PA_ACT_IN_ID", record.InId);
            this.MapParameterIn(command, "@PA_ACT_INVOICED", record.Invoiced);
            this.MapParameterIn(command, "@PA_ACT_SUP_CONT_REF", record.SupContRef);
            this.MapParameterIn(command, "@PA_ACT_CHARGE_TYPE", record.ChargeType);
            this.MapParameterIn(command, "@PA_ACT_MINUTES", record.Minutes == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Minutes);
            this.MapParameterIn(command, "@PA_ACT_VALUE", record.Value == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Value);
            this.MapParameterIn(command, "@PA_ACT_VALUE_BC", record.ValueBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ValueBc);
            this.MapParameterIn(command, "@PA_ACT_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_ACT_SCHEME_ID", record.SchemeId);
            this.MapParameterIn(command, "@PA_ACT_NXT_STAGE", record.NxtStage);
            this.MapParameterIn(command, "@PA_ACT_NXT_STGE_DATE", record.NxtStgeDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NxtStgeDate);
            this.MapParameterIn(command, "@PA_ACT_ALARMDATE", record.Alarmdate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Alarmdate);
            this.MapParameterIn(command, "@PA_ACT_ALARMTIME", record.Alarmtime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Alarmtime);
            this.MapParameterIn(command, "@PA_ACT_SYLLABUS_ID", record.SyllabusId);
            this.MapParameterIn(command, "@PA_ACT_SESSION_NAME", record.SessionName);
            this.MapParameterIn(command, "@PA_ACT_RESOURCE_ID", record.ResourceId);
            this.MapParameterIn(command, "@PA_ACT_REAL", record.Real);
            this.MapParameterIn(command, "@PA_ACT_ELEMENT", record.Element);
            this.MapParameterIn(command, "@PA_ACT_MANDATORY", record.Mandatory);
            this.MapParameterIn(command, "@PA_ACT_INVOICE_PRINT", record.InvoicePrint);
            this.MapParameterIn(command, "@PA_ACT_MAX_PLACES", record.MaxPlaces == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxPlaces);
            this.MapParameterIn(command, "@PA_ACT_MIN_PLACES", record.MinPlaces == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MinPlaces);
            this.MapParameterIn(command, "@PA_ACT_FREE_PLACES", record.FreePlaces == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.FreePlaces);
            this.MapParameterIn(command, "@PA_ACT_PRICE", record.Price == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Price);
            this.MapParameterIn(command, "@PA_ACT_BLOCK_PRICE", record.BlockPrice == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BlockPrice);
            this.MapParameterIn(command, "@PA_ACT_PRICE_BC", record.PriceBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.PriceBc);
            this.MapParameterIn(command, "@PA_ACT_BLOCK_PRICE_BC", record.BlockPriceBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BlockPriceBc);
            this.MapParameterIn(command, "@PA_ACT_VATCD", record.Vatcd);
            this.MapParameterIn(command, "@PA_ACT_REV_CODE", record.RevCode);
            this.MapParameterIn(command, "@PA_ACT_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_ACT_DO_NOT_INVOICE", record.DoNotInvoice);
            this.MapParameterIn(command, "@PA_ACT_FROM_BOM_TYPE", record.FromBomType);
            this.MapParameterIn(command, "@PA_ACT_ROOM_GRADE", record.RoomGrade);
            this.MapParameterIn(command, "@PA_ACT_TASK_NAME", record.TaskName);
            this.MapParameterIn(command, "@PA_ACT_TASK_STATUS", record.TaskStatus);
            this.MapParameterIn(command, "@PA_ACT_EST_HOURS", record.EstHours == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.EstHours);
            this.MapParameterIn(command, "@PA_ACT_ACTUAL_HOURS", record.ActualHours == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualHours);
            this.MapParameterIn(command, "@PA_ACT_USERNUM_1", record.Usernum1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_ACT_USERNUM_2", record.Usernum2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_ACT_USERNUM_3", record.Usernum3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_ACT_REVIEW_DATE", record.ReviewDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ReviewDate);
            this.MapParameterIn(command, "@PA_ACT_REVIEW_TIME", record.ReviewTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ReviewTime);
            this.MapParameterIn(command, "@PA_ACT_PROJ_ID", record.ProjId);
            this.MapParameterIn(command, "@PA_ACT_FILE_PATH", record.FilePath);
            this.MapParameterIn(command, "@PA_ACT_BIP", record.Bip == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Bip);
            this.MapParameterIn(command, "@PA_ACT_PART_NOTE", record.PartNote);
            this.MapParameterIn(command, "@PA_ACT_PERIOD", record.Period);
            this.MapParameterIn(command, "@PA_ACT_OVERBOOK", record.Overbook == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Overbook);
            this.MapParameterIn(command, "@PA_ACT_SESSION_NAME2", record.SessionName2);
            this.MapParameterIn(command, "@PA_ACT_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_ACT_ADDRESS", record.Address);
            this.MapParameterIn(command, "@PA_ACT_PQ_ID", record.PqId);
            this.MapParameterIn(command, "@PA_ACT_PQ_STATUS", record.PqStatus);
            this.MapParameterIn(command, "@PA_ACT_PQ_STATUS_TEXT", record.PqStatusText);
            this.MapParameterIn(command, "@PA_ACT_PQ_SEND_TYPE", record.PqSendType);
            this.MapParameterIn(command, "@PA_ACT_PQ_SENT_DATE", record.PqSentDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PqSentDate);
            this.MapParameterIn(command, "@PA_ACT_PQ_KEEP", record.PqKeep);
            this.MapParameterIn(command, "@PA_ACT_MEP_ID", record.MepId);
            this.MapParameterIn(command, "@PA_ACT_TYPE_SUB", record.TypeSub);
            this.MapParameterIn(command, "@PA_ACT_AUTO_ALLOCATE", record.AutoAllocate);
            this.MapParameterIn(command, "@PA_ACT_WF_ID", record.WfId);
            this.MapParameterIn(command, "@PA_ACT_EVR_INC_TOT", record.EvrIncTot);
            this.MapParameterIn(command, "@PA_ACT_EVR_INC_QUO", record.EvrIncQuo);
            this.MapParameterIn(command, "@PA_ACT_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_ACT_ATTENDEES", record.Attendees);
            this.MapParameterIn(command, "@PA_ACT_CEN_ID", record.CenId);
            this.MapParameterIn(command, "@PA_ACT_ROOM_LAYOUT", record.RoomLayout == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.RoomLayout);
            this.MapParameterIn(command, "@PA_ACT_NOTE_HTML", record.NoteHtml);
            this.MapParameterIn(command, "@PA_ACT_LAYOUT", record.Layout);
            this.MapParameterIn(command, "@PA_ACT_PLACES_TO_SET", record.PlacesToSet == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PlacesToSet);
            this.MapParameterIn(command, "@PA_ACT_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_ACT_STAFF_NEEDED", record.StaffNeeded);
            this.MapParameterIn(command, "@PA_ACT_TIME_PREP", record.TimePrep == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TimePrep);
            this.MapParameterIn(command, "@PA_ACT_TIME_CLEAN", record.TimeClean == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TimeClean);
            this.MapParameterIn(command, "@PA_ACT_TRN_ID", record.TrnId);
            this.MapParameterIn(command, "@PA_ACT_PRIORITY", record.Priority);
            this.MapParameterIn(command, "@PA_ACT_FLOAT", record.Float);
            this.MapParameterIn(command, "@PA_ACT_ALLOC_STATUS", record.AllocStatus);
            this.MapParameterIn(command, "@PA_ACT_DEPT_ID", record.DeptId);
            this.MapParameterIn(command, "@PA_ACT_ROOM_BOOKING", record.RoomBooking);
            this.MapParameterIn(command, "@PA_ACT_CONTPROL_ID", record.ContprolId);
            this.MapParameterIn(command, "@PA_ACT_RES_TYPE", record.ResType);
            this.MapParameterIn(command, "@PA_ACT_DURATION", record.Duration == Double.MinValue ? 0 : record.Duration);
            this.MapParameterIn(command, "@PA_ACT_PD_ID", record.PdId);
            this.MapParameterIn(command, "@PA_ACT_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_ACT_INC_IN_BUDGET", record.IncInBudget);
            this.MapParameterIn(command, "@PA_ACT_VER_CAT", record.VerCat);
            this.MapParameterIn(command, "@PA_ACT_PDPEMP_ID", record.PdpempId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PdpempId);
            this.MapParameterIn(command, "@PA_ACT_APP_BY", record.AppBy);
            this.MapParameterIn(command, "@PA_ACT_APP_DATE", record.AppDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AppDate);
            this.MapParameterIn(command, "@PA_ACT_NEXT_REVIEW", record.NextReview == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NextReview);
            this.MapParameterIn(command, "@PA_ACT_INV_ID", record.InvId);
            this.MapParameterIn(command, "@PA_ACT_CODE", record.Code);
            this.MapParameterIn(command, "@PA_ACT_SESSION_TYPE", record.SessionType);
            this.MapParameterIn(command, "@PA_ACT_TEACH_HRS", record.TeachHrs == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.TeachHrs);
            this.MapParameterIn(command, "@PA_ACT_STUD_WKS", record.StudWks == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.StudWks);
            this.MapParameterIn(command, "@PA_ACT_NOTINUSE_START", record.NotinuseStart == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NotinuseStart);
            this.MapParameterIn(command, "@PA_ACT_NOTINUSE_END", record.NotinuseEnd == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NotinuseEnd);
            this.MapParameterIn(command, "@PA_ACT_CONF_SESSION_ORDER", record.ConfSessionOrder == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ConfSessionOrder);
            this.MapParameterIn(command, "@PA_ACT_ADDED_BY", record.AddedBy);
            this.MapParameterIn(command, "@PA_ACT_OUTLOOK_UID", record.OutlookUid);
            this.MapParameterIn(command, "@PA_ACT_UNIQUE_REF", record.UniqueRef);
            this.MapParameterIn(command, "@PA_ACT_NO_SLOTS", record.NoSlots == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NoSlots);
            this.MapParameterIn(command, "@PA_ACT_CANCELLED", record.Cancelled);
            this.MapParameterIn(command, "@PA_ACT_DELETE", record.Delete);
            this.MapParameterIn(command, "@PA_ACT_BOM_ID", record.BomId);
            this.MapParameterIn(command, "@PA_ACT_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_ACT_OUTCOME", record.Outcome);
            this.MapParameterIn(command, "@PA_ACT_QUEST_ID", record.QuestId);
            this.MapParameterIn(command, "@PA_ACT_BUILD_VERSION", record.BuildVersion);
            this.MapParameterIn(command, "@PA_ACT_LOCKED_DATE", record.LockedDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LockedDate);
            this.MapParameterIn(command, "@PA_ACT_TIMEOUT", record.Timeout == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Timeout);
            this.MapParameterIn(command, "@PA_ACT_CG_CODE", record.CgCode);
            this.MapParameterIn(command, "@PA_ACT_PROV_PACK", record.ProvPack);
            this.MapParameterIn(command, "@PA_ACT_CONF_PACK", record.ConfPack);
            this.MapParameterIn(command, "@PA_ACT_JOINING_PACK", record.JoiningPack);
            this.MapParameterIn(command, "@PA_ACT_POST_PACK", record.PostPack);
            this.MapParameterIn(command, "@PA_ACT_PREJOIN_PACK", record.PrejoinPack);
            this.MapParameterIn(command, "@PA_ACT_PSTJOIN_PACK", record.PstjoinPack);
            this.MapParameterIn(command, "@PA_ACT_PROV_SENT_DTE", record.ProvSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ProvSentDte);
            this.MapParameterIn(command, "@PA_ACT_CONF_SENT_DTE", record.ConfSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ConfSentDte);
            this.MapParameterIn(command, "@PA_ACT_JOIN_SENT_DTE", record.JoinSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.JoinSentDte);
            this.MapParameterIn(command, "@PA_ACT_PP_SENT_DTE", record.PpSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PpSentDte);
            this.MapParameterIn(command, "@PA_ACT_PRJOIN_SENT_DTE", record.PrjoinSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PrjoinSentDte);
            this.MapParameterIn(command, "@PA_ACT_POJOIN_SENT_DTE", record.PojoinSentDte == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PojoinSentDte);
            this.MapParameterIn(command, "@PA_ACT_DROPDOWN_1", record.Dropdown1);
            this.MapParameterIn(command, "@PA_ACT_DROPDOWN_2", record.Dropdown2);
            this.MapParameterIn(command, "@PA_ACT_REVENUE_SPLIT", record.RevenueSplit == Double.MinValue ? 0 : record.RevenueSplit);
            this.MapParameterIn(command, "@PA_ACT_HOURS_SPLIT", record.HoursSplit == Double.MinValue ? 0 : record.HoursSplit);
            this.MapParameterIn(command, "@PA_ACT_ARRIVED", record.Arrived);
            this.MapParameterIn(command, "@PA_ACT_EXP_OCCUPANCY", record.ExpOccupancy == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ExpOccupancy);
            this.MapParameterIn(command, "@PA_ACT_RESERVE", record.Reserve);
            this.MapParameterIn(command, "@PA_ACT_VISIT_OUTCOME", record.VisitOutcome);
            this.MapParameterIn(command, "@PA_ACT_TRNP_ID", record.TrnpId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TrnpId);
            this.MapParameterIn(command, "@PA_ACT_SHOW_ATT_LOG", record.ShowAttLog);
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
        ///     The <see cref="ActivityRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ActivityRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ACT_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_ACT_LOCK", record.Lock);
            record.Type = this.MapParameterOut(command, "@PA_ACT_TYPE", record.Type);
            record.DoneIt = this.MapParameterOut(command, "@PA_ACT_DONE_IT", record.DoneIt);
            record.KeyNote = this.MapParameterOut(command, "@PA_ACT_KEY_NOTE", record.KeyNote);
            record.ActionDate = this.MapParameterOut(command, "@PA_ACT_ACTION_DATE", record.ActionDate);
            record.Time = this.MapParameterOut(command, "@PA_ACT_TIME", record.Time);
            record.NextDate = this.MapParameterOut(command, "@PA_ACT_NEXT_DATE", record.NextDate);
            record.EndDate = this.MapParameterOut(command, "@PA_ACT_END_DATE", record.EndDate);
            record.EndTime = this.MapParameterOut(command, "@PA_ACT_END_TIME", record.EndTime);
            record.LocId = this.MapParameterOut(command, "@PA_ACT_LOC_ID", record.LocId);
            record.Result = this.MapParameterOut(command, "@PA_ACT_RESULT", record.Result);
            record.PrevActiv = this.MapParameterOut(command, "@PA_ACT_PREV_ACTIV", record.PrevActiv);
            record.PromotionId = this.MapParameterOut(command, "@PA_ACT_PROMOTION_ID", record.PromotionId);
            record.BookId = this.MapParameterOut(command, "@PA_ACT_BOOK_ID", record.BookId);
            record.CourseId = this.MapParameterOut(command, "@PA_ACT_COURSE_ID", record.CourseId);
            record.TrainerId = this.MapParameterOut(command, "@PA_ACT_TRAINER_ID", record.TrainerId);
            record.TextId = this.MapParameterOut(command, "@PA_ACT_TEXT_ID", record.TextId);
            record.Note = this.MapParameterOut(command, "@PA_ACT_NOTE", record.Note);
            record.DoneItDate = this.MapParameterOut(command, "@PA_ACT_DONE_IT_DATE", record.DoneItDate);
            record.SourceCode = this.MapParameterOut(command, "@PA_ACT_SOURCE_CODE", record.SourceCode);
            record.LastNo = this.MapParameterOut(command, "@PA_ACT_LAST_NO", record.LastNo);
            record.Hierarchy = this.MapParameterOut(command, "@PA_ACT_HIERARCHY", record.Hierarchy);
            record.Level = this.MapParameterOut(command, "@PA_ACT_LEVEL", record.Level);
            record.InitiatedBy = this.MapParameterOut(command, "@PA_ACT_INITIATED_BY", record.InitiatedBy);
            record.ManIssues = this.MapParameterOut(command, "@PA_ACT_MAN_ISSUES", record.ManIssues);
            record.VisitObj = this.MapParameterOut(command, "@PA_ACT_VISIT_OBJ", record.VisitObj);
            record.Cb1 = this.MapParameterOut(command, "@PA_ACT_CB_1", record.Cb1);
            record.Cb2 = this.MapParameterOut(command, "@PA_ACT_CB_2", record.Cb2);
            record.Cb3 = this.MapParameterOut(command, "@PA_ACT_CB_3", record.Cb3);
            record.Cb4 = this.MapParameterOut(command, "@PA_ACT_CB_4", record.Cb4);
            record.Cb5 = this.MapParameterOut(command, "@PA_ACT_CB_5", record.Cb5);
            record.Cb6 = this.MapParameterOut(command, "@PA_ACT_CB_6", record.Cb6);
            record.Cb7 = this.MapParameterOut(command, "@PA_ACT_CB_7", record.Cb7);
            record.Cb8 = this.MapParameterOut(command, "@PA_ACT_CB_8", record.Cb8);
            record.Cb9 = this.MapParameterOut(command, "@PA_ACT_CB_9", record.Cb9);
            record.Cb10 = this.MapParameterOut(command, "@PA_ACT_CB_10", record.Cb10);
            record.OppId = this.MapParameterOut(command, "@PA_ACT_OPP_ID", record.OppId);
            record.HelpType = this.MapParameterOut(command, "@PA_ACT_HELP_TYPE", record.HelpType);
            record.ProductCode = this.MapParameterOut(command, "@PA_ACT_PRODUCT_CODE", record.ProductCode);
            record.ProductGroup = this.MapParameterOut(command, "@PA_ACT_PRODUCT_GROUP", record.ProductGroup);
            record.PicId = this.MapParameterOut(command, "@PA_ACT_PIC_ID", record.PicId);
            record.ClosCat = this.MapParameterOut(command, "@PA_ACT_CLOS_CAT", record.ClosCat);
            record.ClosData = this.MapParameterOut(command, "@PA_ACT_CLOS_DATA", record.ClosData);
            record.Source = this.MapParameterOut(command, "@PA_ACT_SOURCE", record.Source);
            record.Subject = this.MapParameterOut(command, "@PA_ACT_SUBJECT", record.Subject);
            record.SubText = this.MapParameterOut(command, "@PA_ACT_SUB_TEXT", record.SubText);
            record.ServiceType = this.MapParameterOut(command, "@PA_ACT_SERVICE_TYPE", record.ServiceType);
            record.ProblemCat = this.MapParameterOut(command, "@PA_ACT_PROBLEM_CAT", record.ProblemCat);
            record.InId = this.MapParameterOut(command, "@PA_ACT_IN_ID", record.InId);
            record.Invoiced = this.MapParameterOut(command, "@PA_ACT_INVOICED", record.Invoiced);
            record.SupContRef = this.MapParameterOut(command, "@PA_ACT_SUP_CONT_REF", record.SupContRef);
            record.ChargeType = this.MapParameterOut(command, "@PA_ACT_CHARGE_TYPE", record.ChargeType);
            record.Minutes = this.MapParameterOut(command, "@PA_ACT_MINUTES", record.Minutes);
            record.Value = this.MapParameterOut(command, "@PA_ACT_VALUE", record.Value);
            record.ValueBc = this.MapParameterOut(command, "@PA_ACT_VALUE_BC", record.ValueBc);
            record.CurrencyType = this.MapParameterOut(command, "@PA_ACT_CURRENCY_TYPE", record.CurrencyType);
            record.SchemeId = this.MapParameterOut(command, "@PA_ACT_SCHEME_ID", record.SchemeId);
            record.NxtStage = this.MapParameterOut(command, "@PA_ACT_NXT_STAGE", record.NxtStage);
            record.NxtStgeDate = this.MapParameterOut(command, "@PA_ACT_NXT_STGE_DATE", record.NxtStgeDate);
            record.Alarmdate = this.MapParameterOut(command, "@PA_ACT_ALARMDATE", record.Alarmdate);
            record.Alarmtime = this.MapParameterOut(command, "@PA_ACT_ALARMTIME", record.Alarmtime);
            record.SyllabusId = this.MapParameterOut(command, "@PA_ACT_SYLLABUS_ID", record.SyllabusId);
            record.SessionName = this.MapParameterOut(command, "@PA_ACT_SESSION_NAME", record.SessionName);
            record.ResourceId = this.MapParameterOut(command, "@PA_ACT_RESOURCE_ID", record.ResourceId);
            record.Real = this.MapParameterOut(command, "@PA_ACT_REAL", record.Real);
            record.Element = this.MapParameterOut(command, "@PA_ACT_ELEMENT", record.Element);
            record.Mandatory = this.MapParameterOut(command, "@PA_ACT_MANDATORY", record.Mandatory);
            record.InvoicePrint = this.MapParameterOut(command, "@PA_ACT_INVOICE_PRINT", record.InvoicePrint);
            record.MaxPlaces = this.MapParameterOut(command, "@PA_ACT_MAX_PLACES", record.MaxPlaces);
            record.MinPlaces = this.MapParameterOut(command, "@PA_ACT_MIN_PLACES", record.MinPlaces);
            record.FreePlaces = this.MapParameterOut(command, "@PA_ACT_FREE_PLACES", record.FreePlaces);
            record.Price = this.MapParameterOut(command, "@PA_ACT_PRICE", record.Price);
            record.BlockPrice = this.MapParameterOut(command, "@PA_ACT_BLOCK_PRICE", record.BlockPrice);
            record.PriceBc = this.MapParameterOut(command, "@PA_ACT_PRICE_BC", record.PriceBc);
            record.BlockPriceBc = this.MapParameterOut(command, "@PA_ACT_BLOCK_PRICE_BC", record.BlockPriceBc);
            record.Vatcd = this.MapParameterOut(command, "@PA_ACT_VATCD", record.Vatcd);
            record.RevCode = this.MapParameterOut(command, "@PA_ACT_REV_CODE", record.RevCode);
            record.CostCode = this.MapParameterOut(command, "@PA_ACT_COST_CODE", record.CostCode);
            record.DoNotInvoice = this.MapParameterOut(command, "@PA_ACT_DO_NOT_INVOICE", record.DoNotInvoice);
            record.FromBomType = this.MapParameterOut(command, "@PA_ACT_FROM_BOM_TYPE", record.FromBomType);
            record.RoomGrade = this.MapParameterOut(command, "@PA_ACT_ROOM_GRADE", record.RoomGrade);
            record.TaskName = this.MapParameterOut(command, "@PA_ACT_TASK_NAME", record.TaskName);
            record.TaskStatus = this.MapParameterOut(command, "@PA_ACT_TASK_STATUS", record.TaskStatus);
            record.EstHours = this.MapParameterOut(command, "@PA_ACT_EST_HOURS", record.EstHours);
            record.ActualHours = this.MapParameterOut(command, "@PA_ACT_ACTUAL_HOURS", record.ActualHours);
            record.Usernum1 = this.MapParameterOut(command, "@PA_ACT_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_ACT_USERNUM_2", record.Usernum2);
            record.Usernum3 = this.MapParameterOut(command, "@PA_ACT_USERNUM_3", record.Usernum3);
            record.ReviewDate = this.MapParameterOut(command, "@PA_ACT_REVIEW_DATE", record.ReviewDate);
            record.ReviewTime = this.MapParameterOut(command, "@PA_ACT_REVIEW_TIME", record.ReviewTime);
            record.ProjId = this.MapParameterOut(command, "@PA_ACT_PROJ_ID", record.ProjId);
            record.FilePath = this.MapParameterOut(command, "@PA_ACT_FILE_PATH", record.FilePath);
            record.Bip = this.MapParameterOut(command, "@PA_ACT_BIP", record.Bip);
            record.PartNote = this.MapParameterOut(command, "@PA_ACT_PART_NOTE", record.PartNote);
            record.Period = this.MapParameterOut(command, "@PA_ACT_PERIOD", record.Period);
            record.Overbook = this.MapParameterOut(command, "@PA_ACT_OVERBOOK", record.Overbook);
            record.SessionName2 = this.MapParameterOut(command, "@PA_ACT_SESSION_NAME2", record.SessionName2);
            record.OrgId = this.MapParameterOut(command, "@PA_ACT_ORG_ID", record.OrgId);
            record.Address = this.MapParameterOut(command, "@PA_ACT_ADDRESS", record.Address);
            record.PqId = this.MapParameterOut(command, "@PA_ACT_PQ_ID", record.PqId);
            record.PqStatus = this.MapParameterOut(command, "@PA_ACT_PQ_STATUS", record.PqStatus);
            record.PqStatusText = this.MapParameterOut(command, "@PA_ACT_PQ_STATUS_TEXT", record.PqStatusText);
            record.PqSendType = this.MapParameterOut(command, "@PA_ACT_PQ_SEND_TYPE", record.PqSendType);
            record.PqSentDate = this.MapParameterOut(command, "@PA_ACT_PQ_SENT_DATE", record.PqSentDate);
            record.PqKeep = this.MapParameterOut(command, "@PA_ACT_PQ_KEEP", record.PqKeep);
            record.MepId = this.MapParameterOut(command, "@PA_ACT_MEP_ID", record.MepId);
            record.TypeSub = this.MapParameterOut(command, "@PA_ACT_TYPE_SUB", record.TypeSub);
            record.AutoAllocate = this.MapParameterOut(command, "@PA_ACT_AUTO_ALLOCATE", record.AutoAllocate);
            record.WfId = this.MapParameterOut(command, "@PA_ACT_WF_ID", record.WfId);
            record.EvrIncTot = this.MapParameterOut(command, "@PA_ACT_EVR_INC_TOT", record.EvrIncTot);
            record.EvrIncQuo = this.MapParameterOut(command, "@PA_ACT_EVR_INC_QUO", record.EvrIncQuo);
            record.AddId = this.MapParameterOut(command, "@PA_ACT_ADD_ID", record.AddId);
            record.Attendees = this.MapParameterOut(command, "@PA_ACT_ATTENDEES", record.Attendees);
            record.CenId = this.MapParameterOut(command, "@PA_ACT_CEN_ID", record.CenId);
            record.RoomLayout = this.MapParameterOut(command, "@PA_ACT_ROOM_LAYOUT", record.RoomLayout);
            record.NoteHtml = this.MapParameterOut(command, "@PA_ACT_NOTE_HTML", record.NoteHtml);
            record.Layout = this.MapParameterOut(command, "@PA_ACT_LAYOUT", record.Layout);
            record.PlacesToSet = this.MapParameterOut(command, "@PA_ACT_PLACES_TO_SET", record.PlacesToSet);
            record.ProdId = this.MapParameterOut(command, "@PA_ACT_PROD_ID", record.ProdId);
            record.StaffNeeded = this.MapParameterOut(command, "@PA_ACT_STAFF_NEEDED", record.StaffNeeded);
            record.TimePrep = this.MapParameterOut(command, "@PA_ACT_TIME_PREP", record.TimePrep);
            record.TimeClean = this.MapParameterOut(command, "@PA_ACT_TIME_CLEAN", record.TimeClean);
            record.TrnId = this.MapParameterOut(command, "@PA_ACT_TRN_ID", record.TrnId);
            record.Priority = this.MapParameterOut(command, "@PA_ACT_PRIORITY", record.Priority);
            record.Float = this.MapParameterOut(command, "@PA_ACT_FLOAT", record.Float);
            record.AllocStatus = this.MapParameterOut(command, "@PA_ACT_ALLOC_STATUS", record.AllocStatus);
            record.DeptId = this.MapParameterOut(command, "@PA_ACT_DEPT_ID", record.DeptId);
            record.RoomBooking = this.MapParameterOut(command, "@PA_ACT_ROOM_BOOKING", record.RoomBooking);
            record.ContprolId = this.MapParameterOut(command, "@PA_ACT_CONTPROL_ID", record.ContprolId);
            record.ResType = this.MapParameterOut(command, "@PA_ACT_RES_TYPE", record.ResType);
            record.Duration = this.MapParameterOut(command, "@PA_ACT_DURATION", record.Duration);
            record.PdId = this.MapParameterOut(command, "@PA_ACT_PD_ID", record.PdId);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_ACT_SELCO_SP_ID", record.SelcoSpId);
            record.IncInBudget = this.MapParameterOut(command, "@PA_ACT_INC_IN_BUDGET", record.IncInBudget);
            record.VerCat = this.MapParameterOut(command, "@PA_ACT_VER_CAT", record.VerCat);
            record.PdpempId = this.MapParameterOut(command, "@PA_ACT_PDPEMP_ID", record.PdpempId);
            record.AppBy = this.MapParameterOut(command, "@PA_ACT_APP_BY", record.AppBy);
            record.AppDate = this.MapParameterOut(command, "@PA_ACT_APP_DATE", record.AppDate);
            record.NextReview = this.MapParameterOut(command, "@PA_ACT_NEXT_REVIEW", record.NextReview);
            record.InvId = this.MapParameterOut(command, "@PA_ACT_INV_ID", record.InvId);
            record.Code = this.MapParameterOut(command, "@PA_ACT_CODE", record.Code);
            record.SessionType = this.MapParameterOut(command, "@PA_ACT_SESSION_TYPE", record.SessionType);
            record.TeachHrs = this.MapParameterOut(command, "@PA_ACT_TEACH_HRS", record.TeachHrs);
            record.StudWks = this.MapParameterOut(command, "@PA_ACT_STUD_WKS", record.StudWks);
            record.NotinuseStart = this.MapParameterOut(command, "@PA_ACT_NOTINUSE_START", record.NotinuseStart);
            record.NotinuseEnd = this.MapParameterOut(command, "@PA_ACT_NOTINUSE_END", record.NotinuseEnd);
            record.ConfSessionOrder = this.MapParameterOut(command, "@PA_ACT_CONF_SESSION_ORDER", record.ConfSessionOrder);
            record.AddedBy = this.MapParameterOut(command, "@PA_ACT_ADDED_BY", record.AddedBy);
            record.OutlookUid = this.MapParameterOut(command, "@PA_ACT_OUTLOOK_UID", record.OutlookUid);
            record.UniqueRef = this.MapParameterOut(command, "@PA_ACT_UNIQUE_REF", record.UniqueRef);
            record.NoSlots = this.MapParameterOut(command, "@PA_ACT_NO_SLOTS", record.NoSlots);
            record.Cancelled = this.MapParameterOut(command, "@PA_ACT_CANCELLED", record.Cancelled);
            record.Delete = this.MapParameterOut(command, "@PA_ACT_DELETE", record.Delete);
            record.BomId = this.MapParameterOut(command, "@PA_ACT_BOM_ID", record.BomId);
            record.Status = this.MapParameterOut(command, "@PA_ACT_STATUS", record.Status);
            record.Outcome = this.MapParameterOut(command, "@PA_ACT_OUTCOME", record.Outcome);
            record.QuestId = this.MapParameterOut(command, "@PA_ACT_QUEST_ID", record.QuestId);
            record.BuildVersion = this.MapParameterOut(command, "@PA_ACT_BUILD_VERSION", record.BuildVersion);
            record.LockedDate = this.MapParameterOut(command, "@PA_ACT_LOCKED_DATE", record.LockedDate);
            record.Timeout = this.MapParameterOut(command, "@PA_ACT_TIMEOUT", record.Timeout);
            record.CgCode = this.MapParameterOut(command, "@PA_ACT_CG_CODE", record.CgCode);
            record.ProvPack = this.MapParameterOut(command, "@PA_ACT_PROV_PACK", record.ProvPack);
            record.ConfPack = this.MapParameterOut(command, "@PA_ACT_CONF_PACK", record.ConfPack);
            record.JoiningPack = this.MapParameterOut(command, "@PA_ACT_JOINING_PACK", record.JoiningPack);
            record.PostPack = this.MapParameterOut(command, "@PA_ACT_POST_PACK", record.PostPack);
            record.PrejoinPack = this.MapParameterOut(command, "@PA_ACT_PREJOIN_PACK", record.PrejoinPack);
            record.PstjoinPack = this.MapParameterOut(command, "@PA_ACT_PSTJOIN_PACK", record.PstjoinPack);
            record.ProvSentDte = this.MapParameterOut(command, "@PA_ACT_PROV_SENT_DTE", record.ProvSentDte);
            record.ConfSentDte = this.MapParameterOut(command, "@PA_ACT_CONF_SENT_DTE", record.ConfSentDte);
            record.JoinSentDte = this.MapParameterOut(command, "@PA_ACT_JOIN_SENT_DTE", record.JoinSentDte);
            record.PpSentDte = this.MapParameterOut(command, "@PA_ACT_PP_SENT_DTE", record.PpSentDte);
            record.PrjoinSentDte = this.MapParameterOut(command, "@PA_ACT_PRJOIN_SENT_DTE", record.PrjoinSentDte);
            record.PojoinSentDte = this.MapParameterOut(command, "@PA_ACT_POJOIN_SENT_DTE", record.PojoinSentDte);
            record.Dropdown1 = this.MapParameterOut(command, "@PA_ACT_DROPDOWN_1", record.Dropdown1);
            record.Dropdown2 = this.MapParameterOut(command, "@PA_ACT_DROPDOWN_2", record.Dropdown2);
            record.RevenueSplit = this.MapParameterOut(command, "@PA_ACT_REVENUE_SPLIT", record.RevenueSplit);
            record.HoursSplit = this.MapParameterOut(command, "@PA_ACT_HOURS_SPLIT", record.HoursSplit);
            record.Arrived = this.MapParameterOut(command, "@PA_ACT_ARRIVED", record.Arrived);
            record.ExpOccupancy = this.MapParameterOut(command, "@PA_ACT_EXP_OCCUPANCY", record.ExpOccupancy);
            record.Reserve = this.MapParameterOut(command, "@PA_ACT_RESERVE", record.Reserve);
            record.VisitOutcome = this.MapParameterOut(command, "@PA_ACT_VISIT_OUTCOME", record.VisitOutcome);
            record.TrnpId = this.MapParameterOut(command, "@PA_ACT_TRNP_ID", record.TrnpId);
            record.ShowAttLog = this.MapParameterOut(command, "@PA_ACT_SHOW_ATT_LOG", record.ShowAttLog);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locId">
        ///     The value which identifies the <see cref='ActivityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityRecord" /> instances that match the specified <paramref name='locId' />.
        /// </returns>
        public IEnumerable<ActivityRecord> FetchAllByLocId(String locId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LocId");
            this.MapParameterIn(command, "@PA_ACT_LOC_ID", locId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syllabusId">
        ///     The value which identifies the <see cref='ActivityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityRecord" /> instances that match the specified <paramref name='syllabusId' />.
        /// </returns>
        public IEnumerable<ActivityRecord> FetchAllBySyllabusId(String syllabusId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SyllabusId");
            this.MapParameterIn(command, "@PA_ACT_SYLLABUS_ID", syllabusId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='ActivityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<ActivityRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_ACT_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bomId">
        ///     The value which identifies the <see cref='ActivityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityRecord" /> instances that match the specified <paramref name='bomId' />.
        /// </returns>
        public IEnumerable<ActivityRecord> FetchAllByBomId(String bomId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BomId");
            this.MapParameterIn(command, "@PA_ACT_BOM_ID", bomId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref='ActivityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityRecord" /> instances that match the specified <paramref name='oppId' />.
        /// </returns>
        public IEnumerable<ActivityRecord> FetchAllByOppId(String oppId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OppId");
            this.MapParameterIn(command, "@PA_ACT_OPP_ID", oppId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='ActivityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<ActivityRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_ACT_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IActivityRepository.TableName
        {
            get { return this.TableName; }
        }

        void IActivityRepository.Create(Consensus.Activities.ActivityRecord record)
        {
            this.Create(record);
        }

        void IActivityRepository.Modify(Consensus.Activities.ActivityRecord record)
        {
            this.Modify(record);
        }

        void IActivityRepository.RemoveById(Consensus.Activities.ActivityRecord record)
        {
            this.RemoveById(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="locId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> IActivityRepository.FetchAllByLocId(System.String locId)
        {
            return this.FetchAllByLocId(locId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syllabusId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="syllabusId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> IActivityRepository.FetchAllBySyllabusId(System.String syllabusId)
        {
            return this.FetchAllBySyllabusId(syllabusId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> IActivityRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bomId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="bomId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> IActivityRepository.FetchAllByBomId(System.String bomId)
        {
            return this.FetchAllByBomId(bomId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="oppId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> IActivityRepository.FetchAllByOppId(System.String oppId)
        {
            return this.FetchAllByOppId(oppId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:ActivityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityRecord> IActivityRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        #endregion
    }
}
