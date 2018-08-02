using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CampaignRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCampaignRepository : SqlServerRepository<CampaignRecord, String>, ICampaignRepository
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
            get { return "Campaign"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CampaignRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CMP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Campaign"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CampaignRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CampaignRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CampaignRecord record)
        {
            record.Id = dataRecord["CMP_ID"].ConvertTo<String>();
            record.Name = dataRecord["CMP_NAME"].ConvertTo<String>();
            record.StartDate = dataRecord["CMP_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["CMP_END_DATE"].ConvertTo<DateTime?>();
            record.Region = dataRecord["CMP_REGION"].ConvertTo<String>();
            record.ObjTextId = dataRecord["CMP_OBJ_TEXT_ID"].ConvertTo<String>();
            record.SelTextId = dataRecord["CMP_SEL_TEXT_ID"].ConvertTo<String>();
            record.RvwTextId = dataRecord["CMP_RVW_TEXT_ID"].ConvertTo<String>();
            record.BudgetCosts = dataRecord["CMP_BUDGET_COSTS"].ConvertTo<Double?>();
            record.ActualCosts = dataRecord["CMP_ACTUAL_COSTS"].ConvertTo<Double?>();
            record.Replies = dataRecord["CMP_REPLIES"].ConvertTo<Double?>();
            record.Orders = dataRecord["CMP_ORDERS"].ConvertTo<Double?>();
            record.OrderValue = dataRecord["CMP_ORDER_VALUE"].ConvertTo<Double?>();
            record.Updated = dataRecord["CMP_UPDATED"].ConvertTo<DateTime?>();
            record.ModDate = dataRecord["CMP_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["CMP_MOD_BY"].ConvertTo<String>();
            record.ModBySys = dataRecord["CMP_MOD_BY_SYS"].ConvertTo<String>();
            record.AddDate = dataRecord["CMP_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["CMP_ADD_BY"].ConvertTo<String>();
            record.Lock = dataRecord["CMP_LOCK"].ConvertTo<String>();
            record.BudgetCostBc = dataRecord["CMP_BUDGET_COST_BC"].ConvertTo<Double?>();
            record.ActualCostBc = dataRecord["CMP_ACTUAL_COST_BC"].ConvertTo<Double?>();
            record.OrderValueBc = dataRecord["CMP_ORDER_VALUE_BC"].ConvertTo<Double?>();
            record.CurrencyType = dataRecord["CMP_CURRENCY_TYPE"].ConvertTo<String>();
            record.RcvDate = dataRecord["CMP_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["CMP_RCV_FROM"].ConvertTo<String>();
            record.Mailings = dataRecord["CMP_MAILINGS"].ConvertTo<Int32?>();
            record.Telesales = dataRecord["CMP_TELESALES"].ConvertTo<Int32?>();
            record.Bookings = dataRecord["CMP_BOOKINGS"].ConvertTo<Int32?>();
            record.BookValue = dataRecord["CMP_BOOK_VALUE"].ConvertTo<Double?>();
            record.Quotes = dataRecord["CMP_QUOTES"].ConvertTo<Int32?>();
            record.QuoValue = dataRecord["CMP_QUO_VALUE"].ConvertTo<Double?>();
            record.Sales = dataRecord["CMP_SALES"].ConvertTo<Int32?>();
            record.SaleValue = dataRecord["CMP_SALE_VALUE"].ConvertTo<Double?>();
            record.CalcAct = dataRecord["CMP_CALC_ACT"].ConvertTo<Double?>();
            record.CalcEst = dataRecord["CMP_CALC_EST"].ConvertTo<Double?>();
            record.OppTot = dataRecord["CMP_OPP_TOT"].ConvertTo<Int32?>();
            record.ProjId = dataRecord["CMP_PROJ_ID"].ConvertTo<String>();
            record.BudgetCostBc2 = dataRecord["CMP_BUDGET_COST_BC2"].ConvertTo<Decimal?>();
            record.ActualCostBc2 = dataRecord["CMP_ACTUAL_COST_BC2"].ConvertTo<Decimal?>();
            record.OrderValueBc2 = dataRecord["CMP_ORDER_VALUE_BC2"].ConvertTo<Decimal?>();
            record.SelcoSpId = dataRecord["CMP_SELCO_SP_ID"].ConvertTo<String>();
            record.TargetOpp = dataRecord["CMP_TARGET_OPP"].ConvertTo<Int32?>();
            record.TargetReplies = dataRecord["CMP_TARGET_REPLIES"].ConvertTo<Int32?>();
            record.TargetOppVal = dataRecord["CMP_TARGET_OPP_VAL"].ConvertTo<Double?>();
            record.TargetBookVal = dataRecord["CMP_TARGET_BOOK_VAL"].ConvertTo<Double?>();
            record.ProleId = dataRecord["CMP_PROLE_ID"].ConvertTo<String>();
            record.AppProleId = dataRecord["CMP_APP_PROLE_ID"].ConvertTo<String>();
            record.EmailsSent = dataRecord["CMP_EMAILS_SENT"].ConvertTo<Int32>();
            record.EmailsOpened = dataRecord["CMP_EMAILS_OPENED"].ConvertTo<Int32>();
            record.LinksClicked = dataRecord["CMP_LINKS_CLICKED"].ConvertTo<Int32>();
            record.LzClicked = dataRecord["CMP_LZ_CLICKED"].ConvertTo<Int32>();
            record.SurveysCompleted = dataRecord["CMP_SURVEYS_COMPLETED"].ConvertTo<Int32>();
            record.GlobalUnsubscribes = dataRecord["CMP_GLOBAL_UNSUBSCRIBES"].ConvertTo<Int32>();
            record.ListUnsubscribes = dataRecord["CMP_LIST_UNSUBSCRIBES"].ConvertTo<Int32>();
            record.DocsDownloads = dataRecord["CMP_DOCS_DOWNLOADS"].ConvertTo<Int32>();
            record.BounceBacks = dataRecord["CMP_BOUNCE_BACKS"].ConvertTo<Int32>();
            record.EmailsSentTarget = dataRecord["CMP_EMAILS_SENT_TARGET"].ConvertTo<Int32>();
            record.EmailsOpenedTarget = dataRecord["CMP_EMAILS_OPENED_TARGET"].ConvertTo<Int32>();
            record.LinksClickedTarget = dataRecord["CMP_LINKS_CLICKED_TARGET"].ConvertTo<Int32>();
            record.LzClickedTarget = dataRecord["CMP_LZ_CLICKED_TARGET"].ConvertTo<Int32>();
            record.SurveysCompletedTarget = dataRecord["CMP_SURVEYS_COMPLETED_TARGET"].ConvertTo<Int32>();
            record.GlobalUnsubscribesTarget = dataRecord["CMP_GLOBAL_UNSUBSCRIBES_TARGET"].ConvertTo<Int32>();
            record.ListUnsubscribesTarget = dataRecord["CMP_LIST_UNSUBSCRIBES_TARGET"].ConvertTo<Int32>();
            record.DocsDownloadsTarget = dataRecord["CMP_DOCS_DOWNLOADS_TARGET"].ConvertTo<Int32>();
            record.BounceBacksTarget = dataRecord["CMP_BOUNCE_BACKS_TARGET"].ConvertTo<Int32>();
            record.Qcode = dataRecord["CMP_QCODE"].ConvertTo<String>();
            record.Current = dataRecord["CMP_CURRENT"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CampaignRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CampaignRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CMP_ID", record.Id);
            this.MapParameterIn(command, "@PA_CMP_NAME", record.Name);
            this.MapParameterIn(command, "@PA_CMP_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_CMP_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_CMP_REGION", record.Region);
            this.MapParameterIn(command, "@PA_CMP_OBJ_TEXT_ID", record.ObjTextId);
            this.MapParameterIn(command, "@PA_CMP_SEL_TEXT_ID", record.SelTextId);
            this.MapParameterIn(command, "@PA_CMP_RVW_TEXT_ID", record.RvwTextId);
            this.MapParameterIn(command, "@PA_CMP_BUDGET_COSTS", record.BudgetCosts == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BudgetCosts);
            this.MapParameterIn(command, "@PA_CMP_ACTUAL_COSTS", record.ActualCosts == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualCosts);
            this.MapParameterIn(command, "@PA_CMP_REPLIES", record.Replies == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Replies);
            this.MapParameterIn(command, "@PA_CMP_ORDERS", record.Orders == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Orders);
            this.MapParameterIn(command, "@PA_CMP_ORDER_VALUE", record.OrderValue == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.OrderValue);
            this.MapParameterIn(command, "@PA_CMP_UPDATED", record.Updated == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Updated);
            this.MapParameterIn(command, "@PA_CMP_MOD_BY_SYS", record.ModBySys);
            this.MapParameterIn(command, "@PA_CMP_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_CMP_BUDGET_COST_BC", record.BudgetCostBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BudgetCostBc);
            this.MapParameterIn(command, "@PA_CMP_ACTUAL_COST_BC", record.ActualCostBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualCostBc);
            this.MapParameterIn(command, "@PA_CMP_ORDER_VALUE_BC", record.OrderValueBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.OrderValueBc);
            this.MapParameterIn(command, "@PA_CMP_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_CMP_MAILINGS", record.Mailings == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Mailings);
            this.MapParameterIn(command, "@PA_CMP_TELESALES", record.Telesales == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Telesales);
            this.MapParameterIn(command, "@PA_CMP_BOOKINGS", record.Bookings == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Bookings);
            this.MapParameterIn(command, "@PA_CMP_BOOK_VALUE", record.BookValue == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BookValue);
            this.MapParameterIn(command, "@PA_CMP_QUOTES", record.Quotes == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Quotes);
            this.MapParameterIn(command, "@PA_CMP_QUO_VALUE", record.QuoValue == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.QuoValue);
            this.MapParameterIn(command, "@PA_CMP_SALES", record.Sales == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Sales);
            this.MapParameterIn(command, "@PA_CMP_SALE_VALUE", record.SaleValue == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SaleValue);
            this.MapParameterIn(command, "@PA_CMP_CALC_ACT", record.CalcAct == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CalcAct);
            this.MapParameterIn(command, "@PA_CMP_CALC_EST", record.CalcEst == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CalcEst);
            this.MapParameterIn(command, "@PA_CMP_OPP_TOT", record.OppTot == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.OppTot);
            this.MapParameterIn(command, "@PA_CMP_PROJ_ID", record.ProjId);
            this.MapParameterIn(command, "@PA_CMP_BUDGET_COST_BC2", record.BudgetCostBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.BudgetCostBc2);
            this.MapParameterIn(command, "@PA_CMP_ACTUAL_COST_BC2", record.ActualCostBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.ActualCostBc2);
            this.MapParameterIn(command, "@PA_CMP_ORDER_VALUE_BC2", record.OrderValueBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.OrderValueBc2);
            this.MapParameterIn(command, "@PA_CMP_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_CMP_TARGET_OPP", record.TargetOpp == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetOpp);
            this.MapParameterIn(command, "@PA_CMP_TARGET_REPLIES", record.TargetReplies == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetReplies);
            this.MapParameterIn(command, "@PA_CMP_TARGET_OPP_VAL", record.TargetOppVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TargetOppVal);
            this.MapParameterIn(command, "@PA_CMP_TARGET_BOOK_VAL", record.TargetBookVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TargetBookVal);
            this.MapParameterIn(command, "@PA_CMP_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_CMP_APP_PROLE_ID", record.AppProleId);
            this.MapParameterIn(command, "@PA_CMP_EMAILS_SENT", record.EmailsSent == Int32.MinValue ? 0 : record.EmailsSent);
            this.MapParameterIn(command, "@PA_CMP_EMAILS_OPENED", record.EmailsOpened == Int32.MinValue ? 0 : record.EmailsOpened);
            this.MapParameterIn(command, "@PA_CMP_LINKS_CLICKED", record.LinksClicked == Int32.MinValue ? 0 : record.LinksClicked);
            this.MapParameterIn(command, "@PA_CMP_LZ_CLICKED", record.LzClicked == Int32.MinValue ? 0 : record.LzClicked);
            this.MapParameterIn(command, "@PA_CMP_SURVEYS_COMPLETED", record.SurveysCompleted == Int32.MinValue ? 0 : record.SurveysCompleted);
            this.MapParameterIn(command, "@PA_CMP_GLOBAL_UNSUBSCRIBES", record.GlobalUnsubscribes == Int32.MinValue ? 0 : record.GlobalUnsubscribes);
            this.MapParameterIn(command, "@PA_CMP_LIST_UNSUBSCRIBES", record.ListUnsubscribes == Int32.MinValue ? 0 : record.ListUnsubscribes);
            this.MapParameterIn(command, "@PA_CMP_DOCS_DOWNLOADS", record.DocsDownloads == Int32.MinValue ? 0 : record.DocsDownloads);
            this.MapParameterIn(command, "@PA_CMP_BOUNCE_BACKS", record.BounceBacks == Int32.MinValue ? 0 : record.BounceBacks);
            this.MapParameterIn(command, "@PA_CMP_EMAILS_SENT_TARGET", record.EmailsSentTarget == Int32.MinValue ? 0 : record.EmailsSentTarget);
            this.MapParameterIn(command, "@PA_CMP_EMAILS_OPENED_TARGET", record.EmailsOpenedTarget == Int32.MinValue ? 0 : record.EmailsOpenedTarget);
            this.MapParameterIn(command, "@PA_CMP_LINKS_CLICKED_TARGET", record.LinksClickedTarget == Int32.MinValue ? 0 : record.LinksClickedTarget);
            this.MapParameterIn(command, "@PA_CMP_LZ_CLICKED_TARGET", record.LzClickedTarget == Int32.MinValue ? 0 : record.LzClickedTarget);
            this.MapParameterIn(command, "@PA_CMP_SURVEYS_COMPLETED_TARGET", record.SurveysCompletedTarget == Int32.MinValue ? 0 : record.SurveysCompletedTarget);
            this.MapParameterIn(command, "@PA_CMP_GLOBAL_UNSUBSCRIBES_TARGET", record.GlobalUnsubscribesTarget == Int32.MinValue ? 0 : record.GlobalUnsubscribesTarget);
            this.MapParameterIn(command, "@PA_CMP_LIST_UNSUBSCRIBES_TARGET", record.ListUnsubscribesTarget == Int32.MinValue ? 0 : record.ListUnsubscribesTarget);
            this.MapParameterIn(command, "@PA_CMP_DOCS_DOWNLOADS_TARGET", record.DocsDownloadsTarget == Int32.MinValue ? 0 : record.DocsDownloadsTarget);
            this.MapParameterIn(command, "@PA_CMP_BOUNCE_BACKS_TARGET", record.BounceBacksTarget == Int32.MinValue ? 0 : record.BounceBacksTarget);
            this.MapParameterIn(command, "@PA_CMP_QCODE", record.Qcode);
            this.MapParameterIn(command, "@PA_CMP_CURRENT", record.Current);
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
        ///     The <see cref="CampaignRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CampaignRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CMP_ID", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_CMP_NAME", record.Name);
            record.StartDate = this.MapParameterOut(command, "@PA_CMP_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_CMP_END_DATE", record.EndDate);
            record.Region = this.MapParameterOut(command, "@PA_CMP_REGION", record.Region);
            record.ObjTextId = this.MapParameterOut(command, "@PA_CMP_OBJ_TEXT_ID", record.ObjTextId);
            record.SelTextId = this.MapParameterOut(command, "@PA_CMP_SEL_TEXT_ID", record.SelTextId);
            record.RvwTextId = this.MapParameterOut(command, "@PA_CMP_RVW_TEXT_ID", record.RvwTextId);
            record.BudgetCosts = this.MapParameterOut(command, "@PA_CMP_BUDGET_COSTS", record.BudgetCosts);
            record.ActualCosts = this.MapParameterOut(command, "@PA_CMP_ACTUAL_COSTS", record.ActualCosts);
            record.Replies = this.MapParameterOut(command, "@PA_CMP_REPLIES", record.Replies);
            record.Orders = this.MapParameterOut(command, "@PA_CMP_ORDERS", record.Orders);
            record.OrderValue = this.MapParameterOut(command, "@PA_CMP_ORDER_VALUE", record.OrderValue);
            record.Updated = this.MapParameterOut(command, "@PA_CMP_UPDATED", record.Updated);
            record.ModBySys = this.MapParameterOut(command, "@PA_CMP_MOD_BY_SYS", record.ModBySys);
            record.Lock = this.MapParameterOut(command, "@PA_CMP_LOCK", record.Lock);
            record.BudgetCostBc = this.MapParameterOut(command, "@PA_CMP_BUDGET_COST_BC", record.BudgetCostBc);
            record.ActualCostBc = this.MapParameterOut(command, "@PA_CMP_ACTUAL_COST_BC", record.ActualCostBc);
            record.OrderValueBc = this.MapParameterOut(command, "@PA_CMP_ORDER_VALUE_BC", record.OrderValueBc);
            record.CurrencyType = this.MapParameterOut(command, "@PA_CMP_CURRENCY_TYPE", record.CurrencyType);
            record.Mailings = this.MapParameterOut(command, "@PA_CMP_MAILINGS", record.Mailings);
            record.Telesales = this.MapParameterOut(command, "@PA_CMP_TELESALES", record.Telesales);
            record.Bookings = this.MapParameterOut(command, "@PA_CMP_BOOKINGS", record.Bookings);
            record.BookValue = this.MapParameterOut(command, "@PA_CMP_BOOK_VALUE", record.BookValue);
            record.Quotes = this.MapParameterOut(command, "@PA_CMP_QUOTES", record.Quotes);
            record.QuoValue = this.MapParameterOut(command, "@PA_CMP_QUO_VALUE", record.QuoValue);
            record.Sales = this.MapParameterOut(command, "@PA_CMP_SALES", record.Sales);
            record.SaleValue = this.MapParameterOut(command, "@PA_CMP_SALE_VALUE", record.SaleValue);
            record.CalcAct = this.MapParameterOut(command, "@PA_CMP_CALC_ACT", record.CalcAct);
            record.CalcEst = this.MapParameterOut(command, "@PA_CMP_CALC_EST", record.CalcEst);
            record.OppTot = this.MapParameterOut(command, "@PA_CMP_OPP_TOT", record.OppTot);
            record.ProjId = this.MapParameterOut(command, "@PA_CMP_PROJ_ID", record.ProjId);
            record.BudgetCostBc2 = this.MapParameterOut(command, "@PA_CMP_BUDGET_COST_BC2", record.BudgetCostBc2);
            record.ActualCostBc2 = this.MapParameterOut(command, "@PA_CMP_ACTUAL_COST_BC2", record.ActualCostBc2);
            record.OrderValueBc2 = this.MapParameterOut(command, "@PA_CMP_ORDER_VALUE_BC2", record.OrderValueBc2);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_CMP_SELCO_SP_ID", record.SelcoSpId);
            record.TargetOpp = this.MapParameterOut(command, "@PA_CMP_TARGET_OPP", record.TargetOpp);
            record.TargetReplies = this.MapParameterOut(command, "@PA_CMP_TARGET_REPLIES", record.TargetReplies);
            record.TargetOppVal = this.MapParameterOut(command, "@PA_CMP_TARGET_OPP_VAL", record.TargetOppVal);
            record.TargetBookVal = this.MapParameterOut(command, "@PA_CMP_TARGET_BOOK_VAL", record.TargetBookVal);
            record.ProleId = this.MapParameterOut(command, "@PA_CMP_PROLE_ID", record.ProleId);
            record.AppProleId = this.MapParameterOut(command, "@PA_CMP_APP_PROLE_ID", record.AppProleId);
            record.EmailsSent = this.MapParameterOut(command, "@PA_CMP_EMAILS_SENT", record.EmailsSent);
            record.EmailsOpened = this.MapParameterOut(command, "@PA_CMP_EMAILS_OPENED", record.EmailsOpened);
            record.LinksClicked = this.MapParameterOut(command, "@PA_CMP_LINKS_CLICKED", record.LinksClicked);
            record.LzClicked = this.MapParameterOut(command, "@PA_CMP_LZ_CLICKED", record.LzClicked);
            record.SurveysCompleted = this.MapParameterOut(command, "@PA_CMP_SURVEYS_COMPLETED", record.SurveysCompleted);
            record.GlobalUnsubscribes = this.MapParameterOut(command, "@PA_CMP_GLOBAL_UNSUBSCRIBES", record.GlobalUnsubscribes);
            record.ListUnsubscribes = this.MapParameterOut(command, "@PA_CMP_LIST_UNSUBSCRIBES", record.ListUnsubscribes);
            record.DocsDownloads = this.MapParameterOut(command, "@PA_CMP_DOCS_DOWNLOADS", record.DocsDownloads);
            record.BounceBacks = this.MapParameterOut(command, "@PA_CMP_BOUNCE_BACKS", record.BounceBacks);
            record.EmailsSentTarget = this.MapParameterOut(command, "@PA_CMP_EMAILS_SENT_TARGET", record.EmailsSentTarget);
            record.EmailsOpenedTarget = this.MapParameterOut(command, "@PA_CMP_EMAILS_OPENED_TARGET", record.EmailsOpenedTarget);
            record.LinksClickedTarget = this.MapParameterOut(command, "@PA_CMP_LINKS_CLICKED_TARGET", record.LinksClickedTarget);
            record.LzClickedTarget = this.MapParameterOut(command, "@PA_CMP_LZ_CLICKED_TARGET", record.LzClickedTarget);
            record.SurveysCompletedTarget = this.MapParameterOut(command, "@PA_CMP_SURVEYS_COMPLETED_TARGET", record.SurveysCompletedTarget);
            record.GlobalUnsubscribesTarget = this.MapParameterOut(command, "@PA_CMP_GLOBAL_UNSUBSCRIBES_TARGET", record.GlobalUnsubscribesTarget);
            record.ListUnsubscribesTarget = this.MapParameterOut(command, "@PA_CMP_LIST_UNSUBSCRIBES_TARGET", record.ListUnsubscribesTarget);
            record.DocsDownloadsTarget = this.MapParameterOut(command, "@PA_CMP_DOCS_DOWNLOADS_TARGET", record.DocsDownloadsTarget);
            record.BounceBacksTarget = this.MapParameterOut(command, "@PA_CMP_BOUNCE_BACKS_TARGET", record.BounceBacksTarget);
            record.Qcode = this.MapParameterOut(command, "@PA_CMP_QCODE", record.Qcode);
            record.Current = this.MapParameterOut(command, "@PA_CMP_CURRENT", record.Current);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="projId">
        ///     The value which identifies the <see cref='CampaignModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CampaignRecord" /> instances that match the specified <paramref name='projId' />.
        /// </returns>
        public IEnumerable<CampaignRecord> FetchAllByProjId(String projId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProjId");
            this.MapParameterIn(command, "@PA_CMP_PROJ_ID", projId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='CampaignModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CampaignRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<CampaignRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_CMP_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='CampaignModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CampaignRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<CampaignRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_CMP_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appProleId">
        ///     The value which identifies the <see cref='CampaignModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CampaignRecord" /> instances that match the specified <paramref name='appProleId' />.
        /// </returns>
        public IEnumerable<CampaignRecord> FetchAllByAppProleId(String appProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AppProleId");
            this.MapParameterIn(command, "@PA_CMP_APP_PROLE_ID", appProleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICampaignRepository.TableName
        {
            get { return this.TableName; }
        }

        void ICampaignRepository.Create(Consensus.Marketing.CampaignRecord record)
        {
            this.Create(record);
        }

        void ICampaignRepository.Modify(Consensus.Marketing.CampaignRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="projId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances that match the specified <paramref name="projId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.CampaignRecord> ICampaignRepository.FetchAllByProjId(System.String projId)
        {
            return this.FetchAllByProjId(projId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.CampaignRecord> ICampaignRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.CampaignRecord> ICampaignRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appProleId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.CampaignRecord" /> instances that match the specified <paramref name="appProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.CampaignRecord> ICampaignRepository.FetchAllByAppProleId(System.String appProleId)
        {
            return this.FetchAllByAppProleId(appProleId);
        }

        #endregion
    }
}
