using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PromotionRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPromotionRepository : SqlServerRepository<PromotionRecord, String>, IPromotionRepository
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
            get { return "Promotion"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PromotionRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Promotion"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PromotionRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PromotionRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PromotionRecord record)
        {
            record.Id = dataRecord["PM_ID"].ConvertTo<String>();
            record.CmpId = dataRecord["PM_CMP_ID"].ConvertTo<String>();
            record.Name = dataRecord["PM_NAME"].ConvertTo<String>();
            record.StartDate = dataRecord["PM_START_DATE"].ConvertTo<DateTime?>();
            record.Channel = dataRecord["PM_CHANNEL"].ConvertTo<String>();
            record.TextId = dataRecord["PM_TEXT_ID"].ConvertTo<String>();
            record.DmNumber = dataRecord["PM_DM_NUMBER"].ConvertTo<Double?>();
            record.Replies = dataRecord["PM_REPLIES"].ConvertTo<Double?>();
            record.Orders = dataRecord["PM_ORDERS"].ConvertTo<Double?>();
            record.OrderVal = dataRecord["PM_ORDER_VAL"].ConvertTo<Double?>();
            record.BudgetCost = dataRecord["PM_BUDGET_COST"].ConvertTo<Double?>();
            record.ActualCost = dataRecord["PM_ACTUAL_COST"].ConvertTo<Double?>();
            record.Updated = dataRecord["PM_UPDATED"].ConvertTo<DateTime?>();
            record.Current = dataRecord["PM_CURRENT"].ConvertTo<Byte?>();
            record.AddDate = dataRecord["PM_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PM_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PM_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PM_MOD_BY"].ConvertTo<String>();
            record.ModBySys = dataRecord["PM_MOD_BY_SYS"].ConvertTo<String>();
            record.Lock = dataRecord["PM_LOCK"].ConvertTo<String>();
            record.OrderValueBc = dataRecord["PM_ORDER_VALUE_BC"].ConvertTo<Double?>();
            record.BudgetCostBc = dataRecord["PM_BUDGET_COST_BC"].ConvertTo<Double?>();
            record.ActualCostBc = dataRecord["PM_ACTUAL_COST_BC"].ConvertTo<Double?>();
            record.CurrencyType = dataRecord["PM_CURRENCY_TYPE"].ConvertTo<String>();
            record.MediaName = dataRecord["PM_MEDIA_NAME"].ConvertTo<String>();
            record.SchemeId = dataRecord["PM_SCHEME_ID"].ConvertTo<String>();
            record.RcvDate = dataRecord["PM_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PM_RCV_FROM"].ConvertTo<String>();
            record.Telesales = dataRecord["PM_TELESALES"].ConvertTo<Int32?>();
            record.Booking = dataRecord["PM_BOOKING"].ConvertTo<Int32?>();
            record.BookValue = dataRecord["PM_BOOK_VALUE"].ConvertTo<Double?>();
            record.OppTot = dataRecord["PM_OPP_TOT"].ConvertTo<Int32?>();
            record.Quotes = dataRecord["PM_QUOTES"].ConvertTo<Int32?>();
            record.QuoValue = dataRecord["PM_QUO_VALUE"].ConvertTo<Double?>();
            record.Sales = dataRecord["PM_SALES"].ConvertTo<Int32?>();
            record.SaleValue = dataRecord["PM_SALE_VALUE"].ConvertTo<Double?>();
            record.Usernum1 = dataRecord["PM_USERNUM_1"].ConvertTo<Double?>();
            record.Usernum2 = dataRecord["PM_USERNUM_2"].ConvertTo<Double?>();
            record.Code = dataRecord["PM_CODE"].ConvertTo<String>();
            record.PackId = dataRecord["PM_PACK_ID"].ConvertTo<String>();
            record.OutDate = dataRecord["PM_OUT_DATE"].ConvertTo<DateTime?>();
            record.Footer = dataRecord["PM_FOOTER"].ConvertTo<String>();
            record.Unsubscribe = dataRecord["PM_UNSUBSCRIBE"].ConvertTo<String>();
            record.Header = dataRecord["PM_HEADER"].ConvertTo<String>();
            record.Body = dataRecord["PM_BODY"].ConvertTo<String>();
            record.Approve = dataRecord["PM_APPROVE"].ConvertTo<String>();
            record.Reply = dataRecord["PM_REPLY"].ConvertTo<String>();
            record.Time = dataRecord["PM_TIME"].ConvertTo<DateTime?>();
            record.EStatus = dataRecord["PM_E_STATUS"].ConvertTo<Byte?>();
            record.JobTitle = dataRecord["PM_JOB_TITLE"].ConvertTo<String>();
            record.Type = dataRecord["PM_TYPE"].ConvertTo<String>();
            record.EType = dataRecord["PM_E_TYPE"].ConvertTo<String>();
            record.ProleId = dataRecord["PM_PROLE_ID"].ConvertTo<String>();
            record.AppProleId = dataRecord["PM_APP_PROLE_ID"].ConvertTo<String>();
            record.RunTime = dataRecord["PM_RUN_TIME"].ConvertTo<DateTime?>();
            record.FinishTime = dataRecord["PM_FINISH_TIME"].ConvertTo<DateTime?>();
            record.GoodMail = dataRecord["PM_GOOD_MAIL"].ConvertTo<Int32?>();
            record.BadMail = dataRecord["PM_BAD_MAIL"].ConvertTo<Int32?>();
            record.SmtpHost = dataRecord["PM_SMTP_HOST"].ConvertTo<String>();
            record.EmailDesc = dataRecord["PM_EMAIL_DESC"].ConvertTo<String>();
            record.ActualVarCost = dataRecord["PM_ACTUAL_VAR_COST"].ConvertTo<Double?>();
            record.ActualFixCost = dataRecord["PM_ACTUAL_FIX_COST"].ConvertTo<Double?>();
            record.BudgetVarCost = dataRecord["PM_BUDGET_VAR_COST"].ConvertTo<Double?>();
            record.BudgetFixCost = dataRecord["PM_BUDGET_FIX_COST"].ConvertTo<Double?>();
            record.TargetOpp = dataRecord["PM_TARGET_OPP"].ConvertTo<Int32?>();
            record.TargetReplies = dataRecord["PM_TARGET_REPLIES"].ConvertTo<Int32?>();
            record.TargetOppVal = dataRecord["PM_TARGET_OPP_VAL"].ConvertTo<Double?>();
            record.TargetBookVal = dataRecord["PM_TARGET_BOOK_VAL"].ConvertTo<Double?>();
            record.TargetComplaints = dataRecord["PM_TARGET_COMPLAINTS"].ConvertTo<Int32?>();
            record.TargetInfoReq = dataRecord["PM_TARGET_INFO_REQ"].ConvertTo<Int32?>();
            record.TargetHelpcalls = dataRecord["PM_TARGET_HELPCALLS"].ConvertTo<Int32?>();
            record.TargetMemberships = dataRecord["PM_TARGET_MEMBERSHIPS"].ConvertTo<Int32?>();
            record.TargetMembershipsVal = dataRecord["PM_TARGET_MEMBERSHIPS_VAL"].ConvertTo<Double?>();
            record.TargetSubscriptions = dataRecord["PM_TARGET_SUBSCRIPTIONS"].ConvertTo<Int32?>();
            record.TargetSubscriptionsVal = dataRecord["PM_TARGET_SUBSCRIPTIONS_VAL"].ConvertTo<Double?>();
            record.ActualComplaints = dataRecord["PM_ACTUAL_COMPLAINTS"].ConvertTo<Int32?>();
            record.ActualInfoReq = dataRecord["PM_ACTUAL_INFO_REQ"].ConvertTo<Int32?>();
            record.ActualHelpcalls = dataRecord["PM_ACTUAL_HELPCALLS"].ConvertTo<Int32?>();
            record.ActualMemberships = dataRecord["PM_ACTUAL_MEMBERSHIPS"].ConvertTo<Int32?>();
            record.ActualMembershipsVal = dataRecord["PM_ACTUAL_MEMBERSHIPS_VAL"].ConvertTo<Double?>();
            record.ActualSubscriptions = dataRecord["PM_ACTUAL_SUBSCRIPTIONS"].ConvertTo<Int32?>();
            record.ActualSubscriptionsVal = dataRecord["PM_ACTUAL_SUBSCRIPTIONS_VAL"].ConvertTo<Double?>();
            record.Web = dataRecord["PM_WEB"].ConvertTo<Byte>();
            record.EmailCampaign = dataRecord["PM_EMAIL_CAMPAIGN"].ConvertTo<Byte>();
            record.CampaignType = dataRecord["PM_CAMPAIGN_TYPE"].ConvertTo<Int32>();
            record.SendContacts = dataRecord["PM_SEND_CONTACTS"].ConvertTo<Byte>();
            record.ContactsSent = dataRecord["PM_CONTACTS_SENT"].ConvertTo<DateTime?>();
            record.EmailsSent = dataRecord["PM_EMAILS_SENT"].ConvertTo<Int32>();
            record.EmailsOpened = dataRecord["PM_EMAILS_OPENED"].ConvertTo<Int32>();
            record.LinksClicked = dataRecord["PM_LINKS_CLICKED"].ConvertTo<Int32>();
            record.LzClicked = dataRecord["PM_LZ_CLICKED"].ConvertTo<Int32>();
            record.SurveysCompleted = dataRecord["PM_SURVEYS_COMPLETED"].ConvertTo<Int32>();
            record.GlobalUnsubscribes = dataRecord["PM_GLOBAL_UNSUBSCRIBES"].ConvertTo<Int32>();
            record.ListUnsubscribes = dataRecord["PM_LIST_UNSUBSCRIBES"].ConvertTo<Int32>();
            record.DocsDownloads = dataRecord["PM_DOCS_DOWNLOADS"].ConvertTo<Int32>();
            record.BounceBacks = dataRecord["PM_BOUNCE_BACKS"].ConvertTo<Int32>();
            record.EmailsSentTarget = dataRecord["PM_EMAILS_SENT_TARGET"].ConvertTo<Int32>();
            record.EmailsOpenedTarget = dataRecord["PM_EMAILS_OPENED_TARGET"].ConvertTo<Int32>();
            record.LinksClickedTarget = dataRecord["PM_LINKS_CLICKED_TARGET"].ConvertTo<Int32>();
            record.LzClickedTarget = dataRecord["PM_LZ_CLICKED_TARGET"].ConvertTo<Int32>();
            record.SurveysCompletedTarget = dataRecord["PM_SURVEYS_COMPLETED_TARGET"].ConvertTo<Int32>();
            record.GlobalUnsubscribesTarget = dataRecord["PM_GLOBAL_UNSUBSCRIBES_TARGET"].ConvertTo<Int32>();
            record.ListUnsubscribesTarget = dataRecord["PM_LIST_UNSUBSCRIBES_TARGET"].ConvertTo<Int32>();
            record.DocsDownloadsTarget = dataRecord["PM_DOCS_DOWNLOADS_TARGET"].ConvertTo<Int32>();
            record.BounceBacksTarget = dataRecord["PM_BOUNCE_BACKS_TARGET"].ConvertTo<Int32>();
            record.Qcode = dataRecord["PM_QCODE"].ConvertTo<String>();
            record.Fqcode = dataRecord["PM_FQCODE"].ConvertTo<String>();
            record.FollowOnPmId = dataRecord["PM_FOLLOW_ON_PM_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PromotionRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PromotionRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PM_ID", record.Id);
            this.MapParameterIn(command, "@PA_PM_CMP_ID", record.CmpId);
            this.MapParameterIn(command, "@PA_PM_NAME", record.Name);
            this.MapParameterIn(command, "@PA_PM_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_PM_CHANNEL", record.Channel);
            this.MapParameterIn(command, "@PA_PM_TEXT_ID", record.TextId);
            this.MapParameterIn(command, "@PA_PM_DM_NUMBER", record.DmNumber == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.DmNumber);
            this.MapParameterIn(command, "@PA_PM_REPLIES", record.Replies == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Replies);
            this.MapParameterIn(command, "@PA_PM_ORDERS", record.Orders == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Orders);
            this.MapParameterIn(command, "@PA_PM_ORDER_VAL", record.OrderVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.OrderVal);
            this.MapParameterIn(command, "@PA_PM_BUDGET_COST", record.BudgetCost == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BudgetCost);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_COST", record.ActualCost == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualCost);
            this.MapParameterIn(command, "@PA_PM_UPDATED", record.Updated == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Updated);
            this.MapParameterIn(command, "@PA_PM_CURRENT", record.Current);
            this.MapParameterIn(command, "@PA_PM_MOD_BY_SYS", record.ModBySys);
            this.MapParameterIn(command, "@PA_PM_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PM_ORDER_VALUE_BC", record.OrderValueBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.OrderValueBc);
            this.MapParameterIn(command, "@PA_PM_BUDGET_COST_BC", record.BudgetCostBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BudgetCostBc);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_COST_BC", record.ActualCostBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualCostBc);
            this.MapParameterIn(command, "@PA_PM_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_PM_MEDIA_NAME", record.MediaName);
            this.MapParameterIn(command, "@PA_PM_SCHEME_ID", record.SchemeId);
            this.MapParameterIn(command, "@PA_PM_TELESALES", record.Telesales == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Telesales);
            this.MapParameterIn(command, "@PA_PM_BOOKING", record.Booking == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Booking);
            this.MapParameterIn(command, "@PA_PM_BOOK_VALUE", record.BookValue == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BookValue);
            this.MapParameterIn(command, "@PA_PM_OPP_TOT", record.OppTot == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.OppTot);
            this.MapParameterIn(command, "@PA_PM_QUOTES", record.Quotes == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Quotes);
            this.MapParameterIn(command, "@PA_PM_QUO_VALUE", record.QuoValue == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.QuoValue);
            this.MapParameterIn(command, "@PA_PM_SALES", record.Sales == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Sales);
            this.MapParameterIn(command, "@PA_PM_SALE_VALUE", record.SaleValue == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SaleValue);
            this.MapParameterIn(command, "@PA_PM_USERNUM_1", record.Usernum1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_PM_USERNUM_2", record.Usernum2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_PM_CODE", record.Code);
            this.MapParameterIn(command, "@PA_PM_PACK_ID", record.PackId);
            this.MapParameterIn(command, "@PA_PM_OUT_DATE", record.OutDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.OutDate);
            this.MapParameterIn(command, "@PA_PM_FOOTER", record.Footer);
            this.MapParameterIn(command, "@PA_PM_UNSUBSCRIBE", record.Unsubscribe);
            this.MapParameterIn(command, "@PA_PM_HEADER", record.Header);
            this.MapParameterIn(command, "@PA_PM_BODY", record.Body);
            this.MapParameterIn(command, "@PA_PM_APPROVE", record.Approve);
            this.MapParameterIn(command, "@PA_PM_REPLY", record.Reply);
            this.MapParameterIn(command, "@PA_PM_TIME", record.Time == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Time);
            this.MapParameterIn(command, "@PA_PM_E_STATUS", record.EStatus);
            this.MapParameterIn(command, "@PA_PM_JOB_TITLE", record.JobTitle);
            this.MapParameterIn(command, "@PA_PM_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_PM_E_TYPE", record.EType);
            this.MapParameterIn(command, "@PA_PM_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_PM_APP_PROLE_ID", record.AppProleId);
            this.MapParameterIn(command, "@PA_PM_RUN_TIME", record.RunTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RunTime);
            this.MapParameterIn(command, "@PA_PM_FINISH_TIME", record.FinishTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.FinishTime);
            this.MapParameterIn(command, "@PA_PM_GOOD_MAIL", record.GoodMail == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.GoodMail);
            this.MapParameterIn(command, "@PA_PM_BAD_MAIL", record.BadMail == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.BadMail);
            this.MapParameterIn(command, "@PA_PM_SMTP_HOST", record.SmtpHost);
            this.MapParameterIn(command, "@PA_PM_EMAIL_DESC", record.EmailDesc);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_VAR_COST", record.ActualVarCost == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualVarCost);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_FIX_COST", record.ActualFixCost == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualFixCost);
            this.MapParameterIn(command, "@PA_PM_BUDGET_VAR_COST", record.BudgetVarCost == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BudgetVarCost);
            this.MapParameterIn(command, "@PA_PM_BUDGET_FIX_COST", record.BudgetFixCost == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BudgetFixCost);
            this.MapParameterIn(command, "@PA_PM_TARGET_OPP", record.TargetOpp == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetOpp);
            this.MapParameterIn(command, "@PA_PM_TARGET_REPLIES", record.TargetReplies == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetReplies);
            this.MapParameterIn(command, "@PA_PM_TARGET_OPP_VAL", record.TargetOppVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TargetOppVal);
            this.MapParameterIn(command, "@PA_PM_TARGET_BOOK_VAL", record.TargetBookVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TargetBookVal);
            this.MapParameterIn(command, "@PA_PM_TARGET_COMPLAINTS", record.TargetComplaints == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetComplaints);
            this.MapParameterIn(command, "@PA_PM_TARGET_INFO_REQ", record.TargetInfoReq == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetInfoReq);
            this.MapParameterIn(command, "@PA_PM_TARGET_HELPCALLS", record.TargetHelpcalls == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetHelpcalls);
            this.MapParameterIn(command, "@PA_PM_TARGET_MEMBERSHIPS", record.TargetMemberships == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetMemberships);
            this.MapParameterIn(command, "@PA_PM_TARGET_MEMBERSHIPS_VAL", record.TargetMembershipsVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TargetMembershipsVal);
            this.MapParameterIn(command, "@PA_PM_TARGET_SUBSCRIPTIONS", record.TargetSubscriptions == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TargetSubscriptions);
            this.MapParameterIn(command, "@PA_PM_TARGET_SUBSCRIPTIONS_VAL", record.TargetSubscriptionsVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TargetSubscriptionsVal);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_COMPLAINTS", record.ActualComplaints == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ActualComplaints);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_INFO_REQ", record.ActualInfoReq == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ActualInfoReq);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_HELPCALLS", record.ActualHelpcalls == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ActualHelpcalls);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_MEMBERSHIPS", record.ActualMemberships == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ActualMemberships);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_MEMBERSHIPS_VAL", record.ActualMembershipsVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualMembershipsVal);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_SUBSCRIPTIONS", record.ActualSubscriptions == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ActualSubscriptions);
            this.MapParameterIn(command, "@PA_PM_ACTUAL_SUBSCRIPTIONS_VAL", record.ActualSubscriptionsVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ActualSubscriptionsVal);
            this.MapParameterIn(command, "@PA_PM_WEB", record.Web);
            this.MapParameterIn(command, "@PA_PM_EMAIL_CAMPAIGN", record.EmailCampaign);
            this.MapParameterIn(command, "@PA_PM_CAMPAIGN_TYPE", record.CampaignType == Int32.MinValue ? 0 : record.CampaignType);
            this.MapParameterIn(command, "@PA_PM_SEND_CONTACTS", record.SendContacts);
            this.MapParameterIn(command, "@PA_PM_CONTACTS_SENT", record.ContactsSent == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ContactsSent);
            this.MapParameterIn(command, "@PA_PM_EMAILS_SENT", record.EmailsSent == Int32.MinValue ? 0 : record.EmailsSent);
            this.MapParameterIn(command, "@PA_PM_EMAILS_OPENED", record.EmailsOpened == Int32.MinValue ? 0 : record.EmailsOpened);
            this.MapParameterIn(command, "@PA_PM_LINKS_CLICKED", record.LinksClicked == Int32.MinValue ? 0 : record.LinksClicked);
            this.MapParameterIn(command, "@PA_PM_LZ_CLICKED", record.LzClicked == Int32.MinValue ? 0 : record.LzClicked);
            this.MapParameterIn(command, "@PA_PM_SURVEYS_COMPLETED", record.SurveysCompleted == Int32.MinValue ? 0 : record.SurveysCompleted);
            this.MapParameterIn(command, "@PA_PM_GLOBAL_UNSUBSCRIBES", record.GlobalUnsubscribes == Int32.MinValue ? 0 : record.GlobalUnsubscribes);
            this.MapParameterIn(command, "@PA_PM_LIST_UNSUBSCRIBES", record.ListUnsubscribes == Int32.MinValue ? 0 : record.ListUnsubscribes);
            this.MapParameterIn(command, "@PA_PM_DOCS_DOWNLOADS", record.DocsDownloads == Int32.MinValue ? 0 : record.DocsDownloads);
            this.MapParameterIn(command, "@PA_PM_BOUNCE_BACKS", record.BounceBacks == Int32.MinValue ? 0 : record.BounceBacks);
            this.MapParameterIn(command, "@PA_PM_EMAILS_SENT_TARGET", record.EmailsSentTarget == Int32.MinValue ? 0 : record.EmailsSentTarget);
            this.MapParameterIn(command, "@PA_PM_EMAILS_OPENED_TARGET", record.EmailsOpenedTarget == Int32.MinValue ? 0 : record.EmailsOpenedTarget);
            this.MapParameterIn(command, "@PA_PM_LINKS_CLICKED_TARGET", record.LinksClickedTarget == Int32.MinValue ? 0 : record.LinksClickedTarget);
            this.MapParameterIn(command, "@PA_PM_LZ_CLICKED_TARGET", record.LzClickedTarget == Int32.MinValue ? 0 : record.LzClickedTarget);
            this.MapParameterIn(command, "@PA_PM_SURVEYS_COMPLETED_TARGET", record.SurveysCompletedTarget == Int32.MinValue ? 0 : record.SurveysCompletedTarget);
            this.MapParameterIn(command, "@PA_PM_GLOBAL_UNSUBSCRIBES_TARGET", record.GlobalUnsubscribesTarget == Int32.MinValue ? 0 : record.GlobalUnsubscribesTarget);
            this.MapParameterIn(command, "@PA_PM_LIST_UNSUBSCRIBES_TARGET", record.ListUnsubscribesTarget == Int32.MinValue ? 0 : record.ListUnsubscribesTarget);
            this.MapParameterIn(command, "@PA_PM_DOCS_DOWNLOADS_TARGET", record.DocsDownloadsTarget == Int32.MinValue ? 0 : record.DocsDownloadsTarget);
            this.MapParameterIn(command, "@PA_PM_BOUNCE_BACKS_TARGET", record.BounceBacksTarget == Int32.MinValue ? 0 : record.BounceBacksTarget);
            this.MapParameterIn(command, "@PA_PM_QCODE", record.Qcode);
            this.MapParameterIn(command, "@PA_PM_FQCODE", record.Fqcode);
            this.MapParameterIn(command, "@PA_PM_FOLLOW_ON_PM_ID", record.FollowOnPmId);
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
        ///     The <see cref="PromotionRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PromotionRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PM_ID", record.Id);
            record.CmpId = this.MapParameterOut(command, "@PA_PM_CMP_ID", record.CmpId);
            record.Name = this.MapParameterOut(command, "@PA_PM_NAME", record.Name);
            record.StartDate = this.MapParameterOut(command, "@PA_PM_START_DATE", record.StartDate);
            record.Channel = this.MapParameterOut(command, "@PA_PM_CHANNEL", record.Channel);
            record.TextId = this.MapParameterOut(command, "@PA_PM_TEXT_ID", record.TextId);
            record.DmNumber = this.MapParameterOut(command, "@PA_PM_DM_NUMBER", record.DmNumber);
            record.Replies = this.MapParameterOut(command, "@PA_PM_REPLIES", record.Replies);
            record.Orders = this.MapParameterOut(command, "@PA_PM_ORDERS", record.Orders);
            record.OrderVal = this.MapParameterOut(command, "@PA_PM_ORDER_VAL", record.OrderVal);
            record.BudgetCost = this.MapParameterOut(command, "@PA_PM_BUDGET_COST", record.BudgetCost);
            record.ActualCost = this.MapParameterOut(command, "@PA_PM_ACTUAL_COST", record.ActualCost);
            record.Updated = this.MapParameterOut(command, "@PA_PM_UPDATED", record.Updated);
            record.Current = this.MapParameterOut(command, "@PA_PM_CURRENT", record.Current);
            record.ModBySys = this.MapParameterOut(command, "@PA_PM_MOD_BY_SYS", record.ModBySys);
            record.Lock = this.MapParameterOut(command, "@PA_PM_LOCK", record.Lock);
            record.OrderValueBc = this.MapParameterOut(command, "@PA_PM_ORDER_VALUE_BC", record.OrderValueBc);
            record.BudgetCostBc = this.MapParameterOut(command, "@PA_PM_BUDGET_COST_BC", record.BudgetCostBc);
            record.ActualCostBc = this.MapParameterOut(command, "@PA_PM_ACTUAL_COST_BC", record.ActualCostBc);
            record.CurrencyType = this.MapParameterOut(command, "@PA_PM_CURRENCY_TYPE", record.CurrencyType);
            record.MediaName = this.MapParameterOut(command, "@PA_PM_MEDIA_NAME", record.MediaName);
            record.SchemeId = this.MapParameterOut(command, "@PA_PM_SCHEME_ID", record.SchemeId);
            record.Telesales = this.MapParameterOut(command, "@PA_PM_TELESALES", record.Telesales);
            record.Booking = this.MapParameterOut(command, "@PA_PM_BOOKING", record.Booking);
            record.BookValue = this.MapParameterOut(command, "@PA_PM_BOOK_VALUE", record.BookValue);
            record.OppTot = this.MapParameterOut(command, "@PA_PM_OPP_TOT", record.OppTot);
            record.Quotes = this.MapParameterOut(command, "@PA_PM_QUOTES", record.Quotes);
            record.QuoValue = this.MapParameterOut(command, "@PA_PM_QUO_VALUE", record.QuoValue);
            record.Sales = this.MapParameterOut(command, "@PA_PM_SALES", record.Sales);
            record.SaleValue = this.MapParameterOut(command, "@PA_PM_SALE_VALUE", record.SaleValue);
            record.Usernum1 = this.MapParameterOut(command, "@PA_PM_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_PM_USERNUM_2", record.Usernum2);
            record.Code = this.MapParameterOut(command, "@PA_PM_CODE", record.Code);
            record.PackId = this.MapParameterOut(command, "@PA_PM_PACK_ID", record.PackId);
            record.OutDate = this.MapParameterOut(command, "@PA_PM_OUT_DATE", record.OutDate);
            record.Footer = this.MapParameterOut(command, "@PA_PM_FOOTER", record.Footer);
            record.Unsubscribe = this.MapParameterOut(command, "@PA_PM_UNSUBSCRIBE", record.Unsubscribe);
            record.Header = this.MapParameterOut(command, "@PA_PM_HEADER", record.Header);
            record.Body = this.MapParameterOut(command, "@PA_PM_BODY", record.Body);
            record.Approve = this.MapParameterOut(command, "@PA_PM_APPROVE", record.Approve);
            record.Reply = this.MapParameterOut(command, "@PA_PM_REPLY", record.Reply);
            record.Time = this.MapParameterOut(command, "@PA_PM_TIME", record.Time);
            record.EStatus = this.MapParameterOut(command, "@PA_PM_E_STATUS", record.EStatus);
            record.JobTitle = this.MapParameterOut(command, "@PA_PM_JOB_TITLE", record.JobTitle);
            record.Type = this.MapParameterOut(command, "@PA_PM_TYPE", record.Type);
            record.EType = this.MapParameterOut(command, "@PA_PM_E_TYPE", record.EType);
            record.ProleId = this.MapParameterOut(command, "@PA_PM_PROLE_ID", record.ProleId);
            record.AppProleId = this.MapParameterOut(command, "@PA_PM_APP_PROLE_ID", record.AppProleId);
            record.RunTime = this.MapParameterOut(command, "@PA_PM_RUN_TIME", record.RunTime);
            record.FinishTime = this.MapParameterOut(command, "@PA_PM_FINISH_TIME", record.FinishTime);
            record.GoodMail = this.MapParameterOut(command, "@PA_PM_GOOD_MAIL", record.GoodMail);
            record.BadMail = this.MapParameterOut(command, "@PA_PM_BAD_MAIL", record.BadMail);
            record.SmtpHost = this.MapParameterOut(command, "@PA_PM_SMTP_HOST", record.SmtpHost);
            record.EmailDesc = this.MapParameterOut(command, "@PA_PM_EMAIL_DESC", record.EmailDesc);
            record.ActualVarCost = this.MapParameterOut(command, "@PA_PM_ACTUAL_VAR_COST", record.ActualVarCost);
            record.ActualFixCost = this.MapParameterOut(command, "@PA_PM_ACTUAL_FIX_COST", record.ActualFixCost);
            record.BudgetVarCost = this.MapParameterOut(command, "@PA_PM_BUDGET_VAR_COST", record.BudgetVarCost);
            record.BudgetFixCost = this.MapParameterOut(command, "@PA_PM_BUDGET_FIX_COST", record.BudgetFixCost);
            record.TargetOpp = this.MapParameterOut(command, "@PA_PM_TARGET_OPP", record.TargetOpp);
            record.TargetReplies = this.MapParameterOut(command, "@PA_PM_TARGET_REPLIES", record.TargetReplies);
            record.TargetOppVal = this.MapParameterOut(command, "@PA_PM_TARGET_OPP_VAL", record.TargetOppVal);
            record.TargetBookVal = this.MapParameterOut(command, "@PA_PM_TARGET_BOOK_VAL", record.TargetBookVal);
            record.TargetComplaints = this.MapParameterOut(command, "@PA_PM_TARGET_COMPLAINTS", record.TargetComplaints);
            record.TargetInfoReq = this.MapParameterOut(command, "@PA_PM_TARGET_INFO_REQ", record.TargetInfoReq);
            record.TargetHelpcalls = this.MapParameterOut(command, "@PA_PM_TARGET_HELPCALLS", record.TargetHelpcalls);
            record.TargetMemberships = this.MapParameterOut(command, "@PA_PM_TARGET_MEMBERSHIPS", record.TargetMemberships);
            record.TargetMembershipsVal = this.MapParameterOut(command, "@PA_PM_TARGET_MEMBERSHIPS_VAL", record.TargetMembershipsVal);
            record.TargetSubscriptions = this.MapParameterOut(command, "@PA_PM_TARGET_SUBSCRIPTIONS", record.TargetSubscriptions);
            record.TargetSubscriptionsVal = this.MapParameterOut(command, "@PA_PM_TARGET_SUBSCRIPTIONS_VAL", record.TargetSubscriptionsVal);
            record.ActualComplaints = this.MapParameterOut(command, "@PA_PM_ACTUAL_COMPLAINTS", record.ActualComplaints);
            record.ActualInfoReq = this.MapParameterOut(command, "@PA_PM_ACTUAL_INFO_REQ", record.ActualInfoReq);
            record.ActualHelpcalls = this.MapParameterOut(command, "@PA_PM_ACTUAL_HELPCALLS", record.ActualHelpcalls);
            record.ActualMemberships = this.MapParameterOut(command, "@PA_PM_ACTUAL_MEMBERSHIPS", record.ActualMemberships);
            record.ActualMembershipsVal = this.MapParameterOut(command, "@PA_PM_ACTUAL_MEMBERSHIPS_VAL", record.ActualMembershipsVal);
            record.ActualSubscriptions = this.MapParameterOut(command, "@PA_PM_ACTUAL_SUBSCRIPTIONS", record.ActualSubscriptions);
            record.ActualSubscriptionsVal = this.MapParameterOut(command, "@PA_PM_ACTUAL_SUBSCRIPTIONS_VAL", record.ActualSubscriptionsVal);
            record.Web = this.MapParameterOut(command, "@PA_PM_WEB", record.Web);
            record.EmailCampaign = this.MapParameterOut(command, "@PA_PM_EMAIL_CAMPAIGN", record.EmailCampaign);
            record.CampaignType = this.MapParameterOut(command, "@PA_PM_CAMPAIGN_TYPE", record.CampaignType);
            record.SendContacts = this.MapParameterOut(command, "@PA_PM_SEND_CONTACTS", record.SendContacts);
            record.ContactsSent = this.MapParameterOut(command, "@PA_PM_CONTACTS_SENT", record.ContactsSent);
            record.EmailsSent = this.MapParameterOut(command, "@PA_PM_EMAILS_SENT", record.EmailsSent);
            record.EmailsOpened = this.MapParameterOut(command, "@PA_PM_EMAILS_OPENED", record.EmailsOpened);
            record.LinksClicked = this.MapParameterOut(command, "@PA_PM_LINKS_CLICKED", record.LinksClicked);
            record.LzClicked = this.MapParameterOut(command, "@PA_PM_LZ_CLICKED", record.LzClicked);
            record.SurveysCompleted = this.MapParameterOut(command, "@PA_PM_SURVEYS_COMPLETED", record.SurveysCompleted);
            record.GlobalUnsubscribes = this.MapParameterOut(command, "@PA_PM_GLOBAL_UNSUBSCRIBES", record.GlobalUnsubscribes);
            record.ListUnsubscribes = this.MapParameterOut(command, "@PA_PM_LIST_UNSUBSCRIBES", record.ListUnsubscribes);
            record.DocsDownloads = this.MapParameterOut(command, "@PA_PM_DOCS_DOWNLOADS", record.DocsDownloads);
            record.BounceBacks = this.MapParameterOut(command, "@PA_PM_BOUNCE_BACKS", record.BounceBacks);
            record.EmailsSentTarget = this.MapParameterOut(command, "@PA_PM_EMAILS_SENT_TARGET", record.EmailsSentTarget);
            record.EmailsOpenedTarget = this.MapParameterOut(command, "@PA_PM_EMAILS_OPENED_TARGET", record.EmailsOpenedTarget);
            record.LinksClickedTarget = this.MapParameterOut(command, "@PA_PM_LINKS_CLICKED_TARGET", record.LinksClickedTarget);
            record.LzClickedTarget = this.MapParameterOut(command, "@PA_PM_LZ_CLICKED_TARGET", record.LzClickedTarget);
            record.SurveysCompletedTarget = this.MapParameterOut(command, "@PA_PM_SURVEYS_COMPLETED_TARGET", record.SurveysCompletedTarget);
            record.GlobalUnsubscribesTarget = this.MapParameterOut(command, "@PA_PM_GLOBAL_UNSUBSCRIBES_TARGET", record.GlobalUnsubscribesTarget);
            record.ListUnsubscribesTarget = this.MapParameterOut(command, "@PA_PM_LIST_UNSUBSCRIBES_TARGET", record.ListUnsubscribesTarget);
            record.DocsDownloadsTarget = this.MapParameterOut(command, "@PA_PM_DOCS_DOWNLOADS_TARGET", record.DocsDownloadsTarget);
            record.BounceBacksTarget = this.MapParameterOut(command, "@PA_PM_BOUNCE_BACKS_TARGET", record.BounceBacksTarget);
            record.Qcode = this.MapParameterOut(command, "@PA_PM_QCODE", record.Qcode);
            record.Fqcode = this.MapParameterOut(command, "@PA_PM_FQCODE", record.Fqcode);
            record.FollowOnPmId = this.MapParameterOut(command, "@PA_PM_FOLLOW_ON_PM_ID", record.FollowOnPmId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PromotionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cmpId">
        ///     The value which identifies the <see cref='PromotionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PromotionRecord" /> instances that match the specified <paramref name='cmpId' />.
        /// </returns>
        public IEnumerable<PromotionRecord> FetchAllByCmpId(String cmpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CmpId");
            this.MapParameterIn(command, "@PA_PM_CMP_ID", cmpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PromotionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='PromotionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PromotionRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<PromotionRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_PM_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PromotionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appProleId">
        ///     The value which identifies the <see cref='PromotionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PromotionRecord" /> instances that match the specified <paramref name='appProleId' />.
        /// </returns>
        public IEnumerable<PromotionRecord> FetchAllByAppProleId(String appProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AppProleId");
            this.MapParameterIn(command, "@PA_PM_APP_PROLE_ID", appProleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPromotionRepository.TableName
        {
            get { return this.TableName; }
        }

        void IPromotionRepository.Create(Consensus.Marketing.PromotionRecord record)
        {
            this.Create(record);
        }

        void IPromotionRepository.Modify(Consensus.Marketing.PromotionRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cmpId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances that match the specified <paramref name="cmpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionRecord> IPromotionRepository.FetchAllByCmpId(System.String cmpId)
        {
            return this.FetchAllByCmpId(cmpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionRecord> IPromotionRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appProleId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.PromotionRecord" /> instances that match the specified <paramref name="appProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.PromotionRecord> IPromotionRepository.FetchAllByAppProleId(System.String appProleId)
        {
            return this.FetchAllByAppProleId(appProleId);
        }

        #endregion
    }
}
