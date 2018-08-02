using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PromotionMasterRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPromotionMasterRepository : SqlServerRepository<PromotionMasterRecord, String>, IPromotionMasterRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Marketing"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "PromotionMaster"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PromotionMasterRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PM_MST_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Promotion_Master"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PromotionMasterRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PromotionMasterRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PromotionMasterRecord record)
        {
            record.Id = dataRecord["PM_MST_ID"].ConvertTo<String>();
            record.Name = dataRecord["PM_MST_NAME"].ConvertTo<String>();
            record.StartDate = dataRecord["PM_MST_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["PM_MST_END_DATE"].ConvertTo<DateTime?>();
            record.Region = dataRecord["PM_MST_REGION"].ConvertTo<String>();
            record.ObjTextId = dataRecord["PM_MST_OBJ_TEXT_ID"].ConvertTo<String>();
            record.SelTextId = dataRecord["PM_MST_SEL_TEXT_ID"].ConvertTo<String>();
            record.RvwTextId = dataRecord["PM_MST_RVW_TEXT_ID"].ConvertTo<String>();
            record.BudgetCost = dataRecord["PM_MST_BUDGET_COST"].ConvertTo<Double?>();
            record.ActualCost = dataRecord["PM_MST_ACTUAL_COST"].ConvertTo<Double?>();
            record.Replies = dataRecord["PM_MST_REPLIES"].ConvertTo<Double?>();
            record.Orders = dataRecord["PM_MST_ORDERS"].ConvertTo<Double?>();
            record.OrderValue = dataRecord["PM_MST_ORDER_VALUE"].ConvertTo<Double?>();
            record.Updated = dataRecord["PM_MST_UPDATED"].ConvertTo<DateTime?>();
            record.ModDate = dataRecord["PM_MST_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PM_MST_MOD_BY"].ConvertTo<String>();
            record.ModBySys = dataRecord["PM_MST_MOD_BY_SYS"].ConvertTo<String>();
            record.AddDate = dataRecord["PM_MST_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PM_MST_ADD_BY"].ConvertTo<String>();
            record.Lock = dataRecord["PM_MST_LOCK"].ConvertTo<String>();
            record.BdgtCstBc = dataRecord["PM_MST_BDGT_CST_BC"].ConvertTo<Double?>();
            record.ActlCstBc = dataRecord["PM_MST_ACTL_CST_BC"].ConvertTo<Double?>();
            record.OrdrValBc = dataRecord["PM_MST_ORDR_VAL_BC"].ConvertTo<Double?>();
            record.CurrType = dataRecord["PM_MST_CURR_TYPE"].ConvertTo<String>();
            record.CmpId = dataRecord["PM_MST_CMP_ID"].ConvertTo<String>();
            record.RcvDate = dataRecord["PM_MST_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PM_MST_RCV_FROM"].ConvertTo<String>();
            record.Mailings = dataRecord["PM_MST_MAILINGS"].ConvertTo<Int32?>();
            record.Telesales = dataRecord["PM_MST_TELESALES"].ConvertTo<Int32?>();
            record.Bookings = dataRecord["PM_MST_BOOKINGS"].ConvertTo<Int32?>();
            record.OppTot = dataRecord["PM_MST_OPP_TOT"].ConvertTo<Int32?>();
            record.Quotes = dataRecord["PM_MST_QUOTES"].ConvertTo<Int32?>();
            record.QuoVal = dataRecord["PM_MST_QUO_VAL"].ConvertTo<Double?>();
            record.Sales = dataRecord["PM_MST_SALES"].ConvertTo<Int32?>();
            record.SaleVal = dataRecord["PM_MST_SALE_VAL"].ConvertTo<Double?>();
            record.CalcAct = dataRecord["PM_MST_CALC_ACT"].ConvertTo<Double?>();
            record.CalcEst = dataRecord["PM_MST_CALC_EST"].ConvertTo<Double?>();
            record.BookVal = dataRecord["PM_MST_BOOK_VAL"].ConvertTo<Double?>();
            record.CourseId = dataRecord["PM_MST_COURSE_ID"].ConvertTo<String>();
            record.Code = dataRecord["PM_MST_CODE"].ConvertTo<String>();
            record.Type = dataRecord["PM_MST_TYPE"].ConvertTo<Byte?>();
            record.TargetOpp = dataRecord["PM_MST_TARGET_OPP"].ConvertTo<Int32?>();
            record.TargetReplies = dataRecord["PM_MST_TARGET_REPLIES"].ConvertTo<Int32?>();
            record.TargetOppVal = dataRecord["PM_MST_TARGET_OPP_VAL"].ConvertTo<Double?>();
            record.TargetBookVal = dataRecord["PM_MST_TARGET_BOOK_VAL"].ConvertTo<Double?>();
            record.ProleId = dataRecord["PM_MST_PROLE_ID"].ConvertTo<String>();
            record.AppProleId = dataRecord["PM_MST_APP_PROLE_ID"].ConvertTo<String>();
            record.EmailsSent = dataRecord["PM_MST_EMAILS_SENT"].ConvertTo<Int32>();
            record.EmailsOpened = dataRecord["PM_MST_EMAILS_OPENED"].ConvertTo<Int32>();
            record.LinksClicked = dataRecord["PM_MST_LINKS_CLICKED"].ConvertTo<Int32>();
            record.LzClicked = dataRecord["PM_MST_LZ_CLICKED"].ConvertTo<Int32>();
            record.SurveysCompleted = dataRecord["PM_MST_SURVEYS_COMPLETED"].ConvertTo<Int32>();
            record.GlobalUnsubscribes = dataRecord["PM_MST_GLOBAL_UNSUBSCRIBES"].ConvertTo<Int32>();
            record.ListUnsubscribes = dataRecord["PM_MST_LIST_UNSUBSCRIBES"].ConvertTo<Int32>();
            record.DocsDownloads = dataRecord["PM_MST_DOCS_DOWNLOADS"].ConvertTo<Int32>();
            record.BounceBacks = dataRecord["PM_MST_BOUNCE_BACKS"].ConvertTo<Int32>();
            record.EmailsSentTarget = dataRecord["PM_MST_EMAILS_SENT_TARGET"].ConvertTo<Int32>();
            record.EmailsOpenedTarget = dataRecord["PM_MST_EMAILS_OPENED_TARGET"].ConvertTo<Int32>();
            record.LinksClickedTarget = dataRecord["PM_MST_LINKS_CLICKED_TARGET"].ConvertTo<Int32>();
            record.LzClickedTarget = dataRecord["PM_MST_LZ_CLICKED_TARGET"].ConvertTo<Int32>();
            record.SurveysCompletedTarget = dataRecord["PM_MST_SURVEYS_COMPLETED_TARGET"].ConvertTo<Int32>();
            record.GlobalUnsubscribesTarget = dataRecord["PM_MST_GLOBAL_UNSUBSCRIBES_TARGET"].ConvertTo<Int32>();
            record.ListUnsubscribesTarget = dataRecord["PM_MST_LIST_UNSUBSCRIBES_TARGET"].ConvertTo<Int32>();
            record.DocsDownloadsTarget = dataRecord["PM_MST_DOCS_DOWNLOADS_TARGET"].ConvertTo<Int32>();
            record.BounceBacksTarget = dataRecord["PM_MST_BOUNCE_BACKS_TARGET"].ConvertTo<Int32>();
            record.Qcode = dataRecord["PM_MST_QCODE"].ConvertTo<String>();
            record.Fqcode = dataRecord["PM_MST_FQCODE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PromotionMasterRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PromotionMasterRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PM_MST_ID", record.Id);
            this.MapParameterIn(command, "@PA_PM_MST_NAME", record.Name);
            this.MapParameterIn(command, "@PA_PM_MST_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_PM_MST_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_PM_MST_REGION", record.Region);
            this.MapParameterIn(command, "@PA_PM_MST_OBJ_TEXT_ID", record.ObjTextId);
            this.MapParameterIn(command, "@PA_PM_MST_SEL_TEXT_ID", record.SelTextId);
            this.MapParameterIn(command, "@PA_PM_MST_RVW_TEXT_ID", record.RvwTextId);
            this.MapParameterIn(command, "@PA_PM_MST_BUDGET_COST", record.BudgetCost == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BudgetCost);
            this.MapParameterIn(command, "@PA_PM_MST_ACTUAL_COST", record.ActualCost == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualCost);
            this.MapParameterIn(command, "@PA_PM_MST_REPLIES", record.Replies == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Replies);
            this.MapParameterIn(command, "@PA_PM_MST_ORDERS", record.Orders == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Orders);
            this.MapParameterIn(command, "@PA_PM_MST_ORDER_VALUE", record.OrderValue == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.OrderValue);
            this.MapParameterIn(command, "@PA_PM_MST_UPDATED", record.Updated == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Updated);
            this.MapParameterIn(command, "@PA_PM_MST_MOD_BY_SYS", record.ModBySys);
            this.MapParameterIn(command, "@PA_PM_MST_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PM_MST_BDGT_CST_BC", record.BdgtCstBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BdgtCstBc);
            this.MapParameterIn(command, "@PA_PM_MST_ACTL_CST_BC", record.ActlCstBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActlCstBc);
            this.MapParameterIn(command, "@PA_PM_MST_ORDR_VAL_BC", record.OrdrValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.OrdrValBc);
            this.MapParameterIn(command, "@PA_PM_MST_CURR_TYPE", record.CurrType);
            this.MapParameterIn(command, "@PA_PM_MST_CMP_ID", record.CmpId);
            this.MapParameterIn(command, "@PA_PM_MST_MAILINGS", record.Mailings == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Mailings);
            this.MapParameterIn(command, "@PA_PM_MST_TELESALES", record.Telesales == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Telesales);
            this.MapParameterIn(command, "@PA_PM_MST_BOOKINGS", record.Bookings == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Bookings);
            this.MapParameterIn(command, "@PA_PM_MST_OPP_TOT", record.OppTot == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.OppTot);
            this.MapParameterIn(command, "@PA_PM_MST_QUOTES", record.Quotes == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Quotes);
            this.MapParameterIn(command, "@PA_PM_MST_QUO_VAL", record.QuoVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.QuoVal);
            this.MapParameterIn(command, "@PA_PM_MST_SALES", record.Sales == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Sales);
            this.MapParameterIn(command, "@PA_PM_MST_SALE_VAL", record.SaleVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SaleVal);
            this.MapParameterIn(command, "@PA_PM_MST_CALC_ACT", record.CalcAct == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CalcAct);
            this.MapParameterIn(command, "@PA_PM_MST_CALC_EST", record.CalcEst == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CalcEst);
            this.MapParameterIn(command, "@PA_PM_MST_BOOK_VAL", record.BookVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BookVal);
            this.MapParameterIn(command, "@PA_PM_MST_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_PM_MST_CODE", record.Code);
            this.MapParameterIn(command, "@PA_PM_MST_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_PM_MST_TARGET_OPP", record.TargetOpp == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetOpp);
            this.MapParameterIn(command, "@PA_PM_MST_TARGET_REPLIES", record.TargetReplies == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetReplies);
            this.MapParameterIn(command, "@PA_PM_MST_TARGET_OPP_VAL", record.TargetOppVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TargetOppVal);
            this.MapParameterIn(command, "@PA_PM_MST_TARGET_BOOK_VAL", record.TargetBookVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TargetBookVal);
            this.MapParameterIn(command, "@PA_PM_MST_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_PM_MST_APP_PROLE_ID", record.AppProleId);
            this.MapParameterIn(command, "@PA_PM_MST_EMAILS_SENT", record.EmailsSent == Int32.MinValue ? 0 : record.EmailsSent);
            this.MapParameterIn(command, "@PA_PM_MST_EMAILS_OPENED", record.EmailsOpened == Int32.MinValue ? 0 : record.EmailsOpened);
            this.MapParameterIn(command, "@PA_PM_MST_LINKS_CLICKED", record.LinksClicked == Int32.MinValue ? 0 : record.LinksClicked);
            this.MapParameterIn(command, "@PA_PM_MST_LZ_CLICKED", record.LzClicked == Int32.MinValue ? 0 : record.LzClicked);
            this.MapParameterIn(command, "@PA_PM_MST_SURVEYS_COMPLETED", record.SurveysCompleted == Int32.MinValue ? 0 : record.SurveysCompleted);
            this.MapParameterIn(command, "@PA_PM_MST_GLOBAL_UNSUBSCRIBES", record.GlobalUnsubscribes == Int32.MinValue ? 0 : record.GlobalUnsubscribes);
            this.MapParameterIn(command, "@PA_PM_MST_LIST_UNSUBSCRIBES", record.ListUnsubscribes == Int32.MinValue ? 0 : record.ListUnsubscribes);
            this.MapParameterIn(command, "@PA_PM_MST_DOCS_DOWNLOADS", record.DocsDownloads == Int32.MinValue ? 0 : record.DocsDownloads);
            this.MapParameterIn(command, "@PA_PM_MST_BOUNCE_BACKS", record.BounceBacks == Int32.MinValue ? 0 : record.BounceBacks);
            this.MapParameterIn(command, "@PA_PM_MST_EMAILS_SENT_TARGET", record.EmailsSentTarget == Int32.MinValue ? 0 : record.EmailsSentTarget);
            this.MapParameterIn(command, "@PA_PM_MST_EMAILS_OPENED_TARGET", record.EmailsOpenedTarget == Int32.MinValue ? 0 : record.EmailsOpenedTarget);
            this.MapParameterIn(command, "@PA_PM_MST_LINKS_CLICKED_TARGET", record.LinksClickedTarget == Int32.MinValue ? 0 : record.LinksClickedTarget);
            this.MapParameterIn(command, "@PA_PM_MST_LZ_CLICKED_TARGET", record.LzClickedTarget == Int32.MinValue ? 0 : record.LzClickedTarget);
            this.MapParameterIn(command, "@PA_PM_MST_SURVEYS_COMPLETED_TARGET", record.SurveysCompletedTarget == Int32.MinValue ? 0 : record.SurveysCompletedTarget);
            this.MapParameterIn(command, "@PA_PM_MST_GLOBAL_UNSUBSCRIBES_TARGET", record.GlobalUnsubscribesTarget == Int32.MinValue ? 0 : record.GlobalUnsubscribesTarget);
            this.MapParameterIn(command, "@PA_PM_MST_LIST_UNSUBSCRIBES_TARGET", record.ListUnsubscribesTarget == Int32.MinValue ? 0 : record.ListUnsubscribesTarget);
            this.MapParameterIn(command, "@PA_PM_MST_DOCS_DOWNLOADS_TARGET", record.DocsDownloadsTarget == Int32.MinValue ? 0 : record.DocsDownloadsTarget);
            this.MapParameterIn(command, "@PA_PM_MST_BOUNCE_BACKS_TARGET", record.BounceBacksTarget == Int32.MinValue ? 0 : record.BounceBacksTarget);
            this.MapParameterIn(command, "@PA_PM_MST_QCODE", record.Qcode);
            this.MapParameterIn(command, "@PA_PM_MST_FQCODE", record.Fqcode);
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
        ///     The <see cref="PromotionMasterRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PromotionMasterRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PM_MST_ID", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_PM_MST_NAME", record.Name);
            record.StartDate = this.MapParameterOut(command, "@PA_PM_MST_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_PM_MST_END_DATE", record.EndDate);
            record.Region = this.MapParameterOut(command, "@PA_PM_MST_REGION", record.Region);
            record.ObjTextId = this.MapParameterOut(command, "@PA_PM_MST_OBJ_TEXT_ID", record.ObjTextId);
            record.SelTextId = this.MapParameterOut(command, "@PA_PM_MST_SEL_TEXT_ID", record.SelTextId);
            record.RvwTextId = this.MapParameterOut(command, "@PA_PM_MST_RVW_TEXT_ID", record.RvwTextId);
            record.BudgetCost = this.MapParameterOut(command, "@PA_PM_MST_BUDGET_COST", record.BudgetCost);
            record.ActualCost = this.MapParameterOut(command, "@PA_PM_MST_ACTUAL_COST", record.ActualCost);
            record.Replies = this.MapParameterOut(command, "@PA_PM_MST_REPLIES", record.Replies);
            record.Orders = this.MapParameterOut(command, "@PA_PM_MST_ORDERS", record.Orders);
            record.OrderValue = this.MapParameterOut(command, "@PA_PM_MST_ORDER_VALUE", record.OrderValue);
            record.Updated = this.MapParameterOut(command, "@PA_PM_MST_UPDATED", record.Updated);
            record.ModBySys = this.MapParameterOut(command, "@PA_PM_MST_MOD_BY_SYS", record.ModBySys);
            record.Lock = this.MapParameterOut(command, "@PA_PM_MST_LOCK", record.Lock);
            record.BdgtCstBc = this.MapParameterOut(command, "@PA_PM_MST_BDGT_CST_BC", record.BdgtCstBc);
            record.ActlCstBc = this.MapParameterOut(command, "@PA_PM_MST_ACTL_CST_BC", record.ActlCstBc);
            record.OrdrValBc = this.MapParameterOut(command, "@PA_PM_MST_ORDR_VAL_BC", record.OrdrValBc);
            record.CurrType = this.MapParameterOut(command, "@PA_PM_MST_CURR_TYPE", record.CurrType);
            record.CmpId = this.MapParameterOut(command, "@PA_PM_MST_CMP_ID", record.CmpId);
            record.Mailings = this.MapParameterOut(command, "@PA_PM_MST_MAILINGS", record.Mailings);
            record.Telesales = this.MapParameterOut(command, "@PA_PM_MST_TELESALES", record.Telesales);
            record.Bookings = this.MapParameterOut(command, "@PA_PM_MST_BOOKINGS", record.Bookings);
            record.OppTot = this.MapParameterOut(command, "@PA_PM_MST_OPP_TOT", record.OppTot);
            record.Quotes = this.MapParameterOut(command, "@PA_PM_MST_QUOTES", record.Quotes);
            record.QuoVal = this.MapParameterOut(command, "@PA_PM_MST_QUO_VAL", record.QuoVal);
            record.Sales = this.MapParameterOut(command, "@PA_PM_MST_SALES", record.Sales);
            record.SaleVal = this.MapParameterOut(command, "@PA_PM_MST_SALE_VAL", record.SaleVal);
            record.CalcAct = this.MapParameterOut(command, "@PA_PM_MST_CALC_ACT", record.CalcAct);
            record.CalcEst = this.MapParameterOut(command, "@PA_PM_MST_CALC_EST", record.CalcEst);
            record.BookVal = this.MapParameterOut(command, "@PA_PM_MST_BOOK_VAL", record.BookVal);
            record.CourseId = this.MapParameterOut(command, "@PA_PM_MST_COURSE_ID", record.CourseId);
            record.Code = this.MapParameterOut(command, "@PA_PM_MST_CODE", record.Code);
            record.Type = this.MapParameterOut(command, "@PA_PM_MST_TYPE", record.Type);
            record.TargetOpp = this.MapParameterOut(command, "@PA_PM_MST_TARGET_OPP", record.TargetOpp);
            record.TargetReplies = this.MapParameterOut(command, "@PA_PM_MST_TARGET_REPLIES", record.TargetReplies);
            record.TargetOppVal = this.MapParameterOut(command, "@PA_PM_MST_TARGET_OPP_VAL", record.TargetOppVal);
            record.TargetBookVal = this.MapParameterOut(command, "@PA_PM_MST_TARGET_BOOK_VAL", record.TargetBookVal);
            record.ProleId = this.MapParameterOut(command, "@PA_PM_MST_PROLE_ID", record.ProleId);
            record.AppProleId = this.MapParameterOut(command, "@PA_PM_MST_APP_PROLE_ID", record.AppProleId);
            record.EmailsSent = this.MapParameterOut(command, "@PA_PM_MST_EMAILS_SENT", record.EmailsSent);
            record.EmailsOpened = this.MapParameterOut(command, "@PA_PM_MST_EMAILS_OPENED", record.EmailsOpened);
            record.LinksClicked = this.MapParameterOut(command, "@PA_PM_MST_LINKS_CLICKED", record.LinksClicked);
            record.LzClicked = this.MapParameterOut(command, "@PA_PM_MST_LZ_CLICKED", record.LzClicked);
            record.SurveysCompleted = this.MapParameterOut(command, "@PA_PM_MST_SURVEYS_COMPLETED", record.SurveysCompleted);
            record.GlobalUnsubscribes = this.MapParameterOut(command, "@PA_PM_MST_GLOBAL_UNSUBSCRIBES", record.GlobalUnsubscribes);
            record.ListUnsubscribes = this.MapParameterOut(command, "@PA_PM_MST_LIST_UNSUBSCRIBES", record.ListUnsubscribes);
            record.DocsDownloads = this.MapParameterOut(command, "@PA_PM_MST_DOCS_DOWNLOADS", record.DocsDownloads);
            record.BounceBacks = this.MapParameterOut(command, "@PA_PM_MST_BOUNCE_BACKS", record.BounceBacks);
            record.EmailsSentTarget = this.MapParameterOut(command, "@PA_PM_MST_EMAILS_SENT_TARGET", record.EmailsSentTarget);
            record.EmailsOpenedTarget = this.MapParameterOut(command, "@PA_PM_MST_EMAILS_OPENED_TARGET", record.EmailsOpenedTarget);
            record.LinksClickedTarget = this.MapParameterOut(command, "@PA_PM_MST_LINKS_CLICKED_TARGET", record.LinksClickedTarget);
            record.LzClickedTarget = this.MapParameterOut(command, "@PA_PM_MST_LZ_CLICKED_TARGET", record.LzClickedTarget);
            record.SurveysCompletedTarget = this.MapParameterOut(command, "@PA_PM_MST_SURVEYS_COMPLETED_TARGET", record.SurveysCompletedTarget);
            record.GlobalUnsubscribesTarget = this.MapParameterOut(command, "@PA_PM_MST_GLOBAL_UNSUBSCRIBES_TARGET", record.GlobalUnsubscribesTarget);
            record.ListUnsubscribesTarget = this.MapParameterOut(command, "@PA_PM_MST_LIST_UNSUBSCRIBES_TARGET", record.ListUnsubscribesTarget);
            record.DocsDownloadsTarget = this.MapParameterOut(command, "@PA_PM_MST_DOCS_DOWNLOADS_TARGET", record.DocsDownloadsTarget);
            record.BounceBacksTarget = this.MapParameterOut(command, "@PA_PM_MST_BOUNCE_BACKS_TARGET", record.BounceBacksTarget);
            record.Qcode = this.MapParameterOut(command, "@PA_PM_MST_QCODE", record.Qcode);
            record.Fqcode = this.MapParameterOut(command, "@PA_PM_MST_FQCODE", record.Fqcode);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cmpId">
        ///     The value which identifies the <see cref='PromotionMasterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PromotionMasterRecord" /> instances that match the specified <paramref name='cmpId' />.
        /// </returns>
        public IEnumerable<PromotionMasterRecord> FetchAllByCmpId(String cmpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CmpId");
            this.MapParameterIn(command, "@PA_PM_MST_CMP_ID", cmpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref='PromotionMasterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PromotionMasterRecord" /> instances that match the specified <paramref name='courseId' />.
        /// </returns>
        public IEnumerable<PromotionMasterRecord> FetchAllByCourseId(String courseId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CourseId");
            this.MapParameterIn(command, "@PA_PM_MST_COURSE_ID", courseId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='PromotionMasterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PromotionMasterRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<PromotionMasterRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_PM_MST_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appProleId">
        ///     The value which identifies the <see cref='PromotionMasterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PromotionMasterRecord" /> instances that match the specified <paramref name='appProleId' />.
        /// </returns>
        public IEnumerable<PromotionMasterRecord> FetchAllByAppProleId(String appProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AppProleId");
            this.MapParameterIn(command, "@PA_PM_MST_APP_PROLE_ID", appProleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPromotionMasterRepository.TableName
        {
            get { return this.TableName; }
        }

        void IPromotionMasterRepository.Create(Consensus.Marketing.PromotionMasterRecord record)
        {
            this.Create(record);
        }

        void IPromotionMasterRepository.Modify(Consensus.Marketing.PromotionMasterRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cmpId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances that match the specified <paramref name="cmpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionMasterRecord> IPromotionMasterRepository.FetchAllByCmpId(System.String cmpId)
        {
            return this.FetchAllByCmpId(cmpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionMasterRecord> IPromotionMasterRepository.FetchAllByCourseId(System.String courseId)
        {
            return this.FetchAllByCourseId(courseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionMasterRecord> IPromotionMasterRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appProleId">
        ///     The value which identifies the <see cref="!:PromotionMasterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> instances that match the specified <paramref name="appProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionMasterRecord> IPromotionMasterRepository.FetchAllByAppProleId(System.String appProleId)
        {
            return this.FetchAllByAppProleId(appProleId);
        }

        #endregion
    }
}
