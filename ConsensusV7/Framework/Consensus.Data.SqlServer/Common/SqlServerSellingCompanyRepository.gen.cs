using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SysParamsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSellingCompanyRepository : SqlServerRepository<SysParamsRecord, String>, ISellingCompanyRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Common"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "SysParams"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SysParamsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Sys_Params"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SysParamsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SysParamsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SysParamsRecord record)
        {
            record.Id = dataRecord["SP_ID"].ConvertTo<String>();
            record.Lock = dataRecord["SP_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["SP_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["SP_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["SP_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["SP_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["SP_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["SP_RCV_FROM"].ConvertTo<String>();
            record.SecPnId = dataRecord["SP_SEC_PN_ID"].ConvertTo<String>();
            record.ReoOrgId = dataRecord["SP_REO_ORG_ID"].ConvertTo<String>();
            record.Vatreg = dataRecord["SP_VATREG"].ConvertTo<String>();
            record.TipsCodePrefx = dataRecord["SP_TIPS_CODE_PREFX"].ConvertTo<String>();
            record.InvNoPrefix = dataRecord["SP_INV_NO_PREFIX"].ConvertTo<String>();
            record.NextInvNo = dataRecord["SP_NEXT_INV_NO"].ConvertTo<Int32?>();
            record.NextCreditNte = dataRecord["SP_NEXT_CREDIT_NTE"].ConvertTo<Int64?>();
            record.HeadedPaper = dataRecord["SP_HEADED_PAPER"].ConvertTo<Byte?>();
            record.Heading1 = dataRecord["SP_HEADING1"].ConvertTo<String>();
            record.Heading = dataRecord["SP_HEADING"].ConvertTo<String>();
            record.Footer = dataRecord["SP_FOOTER"].ConvertTo<String>();
            record.FooterReoLabl = dataRecord["SP_FOOTER_REO_LABL"].ConvertTo<String>();
            record.FooterPhone = dataRecord["SP_FOOTER_PHONE"].ConvertTo<String>();
            record.FooterGenSec = dataRecord["SP_FOOTER_GEN_SEC"].ConvertTo<String>();
            record.PicId = dataRecord["SP_PIC_ID"].ConvertTo<String>();
            record.GeneralTextId = dataRecord["SP_GENERAL_TEXT_ID"].ConvertTo<String>();
            record.GenCorsTxtId = dataRecord["SP_GEN_CORS_TXT_ID"].ConvertTo<String>();
            record.AuthSpeclInst = dataRecord["SP_AUTH_SPECL_INST"].ConvertTo<String>();
            record.DbId = dataRecord["SP_DB_ID"].ConvertTo<String>();
            record.Main = dataRecord["SP_MAIN"].ConvertTo<Byte?>();
            record.Remote = dataRecord["SP_REMOTE"].ConvertTo<String>();
            record.NxtSaleLegNo = dataRecord["SP_NXT_SALE_LEG_NO"].ConvertTo<Double?>();
            record.QuoStatus = dataRecord["SP_QUO_STATUS"].ConvertTo<Byte?>();
            record.QuoSource = dataRecord["SP_QUO_SOURCE"].ConvertTo<Byte?>();
            record.FormatActNote = dataRecord["SP_FORMAT_ACT_NOTE"].ConvertTo<Byte?>();
            record.OrgSrchFilter = dataRecord["SP_ORG_SRCH_FILTER"].ConvertTo<Byte?>();
            record.Mid = dataRecord["SP_MID"].ConvertTo<Byte?>();
            record.UseMatchField = dataRecord["SP_USE_MATCH_FIELD"].ConvertTo<Byte?>();
            record.OffrPreQutPn = dataRecord["SP_OFFR_PRE_QUT_PN"].ConvertTo<Byte?>();
            record.CurrentRelease = dataRecord["SP_CURRENT_RELEASE"].ConvertTo<Int32?>();
            record.LowestRelease = dataRecord["SP_LOWEST_RELEASE"].ConvertTo<Int32?>();
            record.ManAutoAlloc = dataRecord["SP_MAN_AUTO_ALLOC"].ConvertTo<Byte?>();
            record.AddMan1ToAct = dataRecord["SP_ADD_MAN1_TO_ACT"].ConvertTo<Byte?>();
            record.AddMan2ToAct = dataRecord["SP_ADD_MAN2_TO_ACT"].ConvertTo<Byte?>();
            record.AddDistToAct = dataRecord["SP_ADD_DIST_TO_ACT"].ConvertTo<Byte?>();
            record.PerdRoll = dataRecord["SP_PERD_ROLL"].ConvertTo<String>();
            record.FtCanChgThrs = dataRecord["SP_FT_CAN_CHG_THRS"].ConvertTo<Int32?>();
            record.SdCanChgThrs = dataRecord["SP_SD_CAN_CHG_THRS"].ConvertTo<Int32?>();
            record.CancChrgPrcnt = dataRecord["SP_CANC_CHRG_PRCNT"].ConvertTo<Double?>();
            record.FtTranChgThr = dataRecord["SP_FT_TRAN_CHG_THR"].ConvertTo<Int32?>();
            record.TranChgePrcnt = dataRecord["SP_TRAN_CHGE_PRCNT"].ConvertTo<Double?>();
            record.ExtMvChgPrcn = dataRecord["SP_EXT_MV_CHG_PRCN"].ConvertTo<Double?>();
            record.JoinLett = dataRecord["SP_JOIN_LETT"].ConvertTo<String>();
            record.ConfirmLett = dataRecord["SP_CONFIRM_LETT"].ConvertTo<String>();
            record.ProvLett = dataRecord["SP_PROV_LETT"].ConvertTo<String>();
            record.QuestLett = dataRecord["SP_QUEST_LETT"].ConvertTo<String>();
            record.SurvLett = dataRecord["SP_SURV_LETT"].ConvertTo<String>();
            record.InvLett = dataRecord["SP_INV_LETT"].ConvertTo<String>();
            record.UpdateStrg = dataRecord["SP_UPDATE_STRG"].ConvertTo<Byte?>();
            record.JobType = dataRecord["SP_JOB_TYPE"].ConvertTo<Byte?>();
            record.PreventEdit = dataRecord["SP_PREVENT_EDIT"].ConvertTo<Byte?>();
            record.SubsLetter = dataRecord["SP_SUBS_LETTER"].ConvertTo<Byte?>();
            record.RemoteUsed = dataRecord["SP_REMOTE_USED"].ConvertTo<Byte?>();
            record.MergeLock = dataRecord["SP_MERGE_LOCK"].ConvertTo<String>();
            record.InvRestrict = dataRecord["SP_INV_RESTRICT"].ConvertTo<Byte?>();
            record.CurrPerd = dataRecord["SP_CURR_PERD"].ConvertTo<String>();
            record.DefaultOrgId = dataRecord["SP_DEFAULT_ORG_ID"].ConvertTo<String>();
            record.OppActMand = dataRecord["SP_OPP_ACT_MAND"].ConvertTo<Byte?>();
            record.SmtpServer = dataRecord["SP_SMTP_SERVER"].ConvertTo<String>();
            record.AdminEmail = dataRecord["SP_ADMIN_EMAIL"].ConvertTo<String>();
            record.UseAkaField = dataRecord["SP_USE_AKA_FIELD"].ConvertTo<Byte?>();
            record.ExportNum = dataRecord["SP_EXPORT_NUM"].ConvertTo<Int32?>();
            record.ImportNum = dataRecord["SP_IMPORT_NUM"].ConvertTo<Int32?>();
            record.ExportDate = dataRecord["SP_EXPORT_DATE"].ConvertTo<DateTime?>();
            record.BaseCurr = dataRecord["SP_BASE_CURR"].ConvertTo<String>();
            record.Reg = dataRecord["SP_REG"].ConvertTo<String>();
            record.FileStorePath = dataRecord["SP_FILE_STORE_PATH"].ConvertTo<String>();
            record.PicStorePath = dataRecord["SP_PIC_STORE_PATH"].ConvertTo<String>();
            record.NetPath = dataRecord["SP_NET_PATH"].ConvertTo<String>();
            record.BuSecurity = dataRecord["SP_BU_SECURITY"].ConvertTo<Byte?>();
            record.EnqQstId = dataRecord["SP_ENQ_QST_ID"].ConvertTo<String>();
            record.DelQstId = dataRecord["SP_DEL_QST_ID"].ConvertTo<String>();
            record.BaseCurr2 = dataRecord["SP_BASE_CURR2"].ConvertTo<String>();
            record.ProvPack = dataRecord["SP_PROV_PACK"].ConvertTo<String>();
            record.ConfPack = dataRecord["SP_CONF_PACK"].ConvertTo<String>();
            record.JoiningPack = dataRecord["SP_JOINING_PACK"].ConvertTo<String>();
            record.PostPack = dataRecord["SP_POST_PACK"].ConvertTo<String>();
            record.ProvInv = dataRecord["SP_PROV_INV"].ConvertTo<Byte?>();
            record.ConfInv = dataRecord["SP_CONF_INV"].ConvertTo<Byte?>();
            record.JoinInv = dataRecord["SP_JOIN_INV"].ConvertTo<Byte?>();
            record.PostInv = dataRecord["SP_POST_INV"].ConvertTo<Byte?>();
            record.ProvNoPlace = dataRecord["SP_PROV_NO_PLACE"].ConvertTo<Byte?>();
            record.TrainerEmail = dataRecord["SP_TRAINER_EMAIL"].ConvertTo<String>();
            record.CbDays = dataRecord["SP_CB_DAYS"].ConvertTo<String>();
            record.PaymentDays = dataRecord["SP_PAYMENT_DAYS"].ConvertTo<Int32?>();
            record.PaymentType = dataRecord["SP_PAYMENT_TYPE"].ConvertTo<Byte?>();
            record.PayTerms1 = dataRecord["SP_PAY_TERMS_1"].ConvertTo<String>();
            record.PayTerms2 = dataRecord["SP_PAY_TERMS_2"].ConvertTo<String>();
            record.PayTerms3 = dataRecord["SP_PAY_TERMS_3"].ConvertTo<String>();
            record.PayTerms4 = dataRecord["SP_PAY_TERMS_4"].ConvertTo<String>();
            record.UpgradePath = dataRecord["SP_UPGRADE_PATH"].ConvertTo<String>();
            record.TcLett = dataRecord["SP_TC_LETT"].ConvertTo<String>();
            record.Printer1 = dataRecord["SP_PRINTER1"].ConvertTo<String>();
            record.Printer2 = dataRecord["SP_PRINTER2"].ConvertTo<String>();
            record.Initials = dataRecord["SP_INITIALS"].ConvertTo<String>();
            record.CrystalInv = dataRecord["SP_CRYSTAL_INV"].ConvertTo<String>();
            record.Flag = dataRecord["SP_FLAG"].ConvertTo<String>();
            record.BookOthNodes = dataRecord["SP_BOOK_OTH_NODES"].ConvertTo<Byte?>();
            record.UserNumb1 = dataRecord["SP_USER_NUMB_1"].ConvertTo<Double?>();
            record.VatMethod = dataRecord["SP_VAT_METHOD"].ConvertTo<Byte?>();
            record.NoLogon = dataRecord["SP_NO_LOGON"].ConvertTo<Byte?>();
            record.QResults = dataRecord["SP_Q_RESULTS"].ConvertTo<Byte?>();
            record.FileProdExt = dataRecord["SP_FILE_PROD_EXT"].ConvertTo<Byte?>();
            record.Reg2 = dataRecord["SP_REG2"].ConvertTo<String>();
            record.Reg3 = dataRecord["SP_REG3"].ConvertTo<String>();
            record.ElemFlags = dataRecord["SP_ELEM_FLAGS"].ConvertTo<Byte?>();
            record.SellCompName = dataRecord["SP_SELL_COMP_NAME"].ConvertTo<String>();
            record.BookApproval = dataRecord["SP_BOOK_APPROVAL"].ConvertTo<Byte?>();
            record.BktId = dataRecord["SP_BKT_ID"].ConvertTo<String>();
            record.AttachmentsUrl = dataRecord["SP_ATTACHMENTS_URL"].ConvertTo<String>();
            record.Periods = dataRecord["SP_PERIODS"].ConvertTo<Int32>();
            record.BatSelProc = dataRecord["SP_BAT_SEL_PROC"].ConvertTo<String>();
            record.BatOutProc = dataRecord["SP_BAT_OUT_PROC"].ConvertTo<String>();
            record.BatOutDir = dataRecord["SP_BAT_OUT_DIR"].ConvertTo<String>();
            record.DefInvLtId = dataRecord["SP_DEF_INV_LT_ID"].ConvertTo<String>();
            record.MemInvLtId = dataRecord["SP_MEM_INV_LT_ID"].ConvertTo<String>();
            record.ProjInvLtId = dataRecord["SP_PROJ_INV_LT_ID"].ConvertTo<String>();
            record.NoSalesteam = dataRecord["SP_NO_SALESTEAM"].ConvertTo<Byte?>();
            record.CrystalUrl = dataRecord["SP_CRYSTAL_URL"].ConvertTo<String>();
            record.CrystalOdbc = dataRecord["SP_CRYSTAL_ODBC"].ConvertTo<String>();
            record.CrystalStdReps = dataRecord["SP_CRYSTAL_STD_REPS"].ConvertTo<String>();
            record.CrystalCustReps = dataRecord["SP_CRYSTAL_CUST_REPS"].ConvertTo<String>();
            record.CrystalUserReps = dataRecord["SP_CRYSTAL_USER_REPS"].ConvertTo<String>();
            record.InvNoSuffix = dataRecord["SP_INV_NO_SUFFIX"].ConvertTo<String>();
            record.NextProformNo = dataRecord["SP_NEXT_PROFORM_NO"].ConvertTo<Int64?>();
            record.OnlyMemPrice = dataRecord["SP_ONLY_MEM_PRICE"].ConvertTo<Int32?>();
            record.MemberOnlyPrc = dataRecord["SP_MEMBER_ONLY_PRC"].ConvertTo<Byte?>();
            record.GlSalesCtrl = dataRecord["SP_GL_SALES_CTRL"].ConvertTo<String>();
            record.GlVatCtrl = dataRecord["SP_GL_VAT_CTRL"].ConvertTo<String>();
            record.GlBank = dataRecord["SP_GL_BANK"].ConvertTo<String>();
            record.GlBankCharge = dataRecord["SP_GL_BANK_CHARGE"].ConvertTo<String>();
            record.GlWriteoff = dataRecord["SP_GL_WRITEOFF"].ConvertTo<String>();
            record.GlSlAdj = dataRecord["SP_GL_SL_ADJ"].ConvertTo<String>();
            record.Gl1 = dataRecord["SP_GL_1"].ConvertTo<String>();
            record.Gl2 = dataRecord["SP_GL_2"].ConvertTo<String>();
            record.Gl3 = dataRecord["SP_GL_3"].ConvertTo<String>();
            record.Gl4 = dataRecord["SP_GL_4"].ConvertTo<String>();
            record.AcctDesc = dataRecord["SP_ACCT_DESC"].ConvertTo<String>();
            record.MealReportNum = dataRecord["SP_MEAL_REPORT_NUM"].ConvertTo<Int32?>();
            record.BookPref = dataRecord["SP_BOOK_PREF"].ConvertTo<Byte?>();
            record.DpmBcc = dataRecord["SP_DPM_BCC"].ConvertTo<Byte?>();
            record.AddLine5 = dataRecord["SP_ADD_LINE_5"].ConvertTo<Byte?>();
            record.SourceCode = dataRecord["SP_SOURCE_CODE"].ConvertTo<Byte?>();
            record.RegLookup = dataRecord["SP_REG_LOOKUP"].ConvertTo<Byte?>();
            record.DefaultText1 = dataRecord["SP_DEFAULT_TEXT_1"].ConvertTo<String>();
            record.WspostcodePath = dataRecord["SP_WSPOSTCODE_PATH"].ConvertTo<String>();
            record.DefaultInt1 = dataRecord["SP_DEFAULT_INT_1"].ConvertTo<Int32?>();
            record.DefaultUsageDesc = dataRecord["SP_DEFAULT_USAGE_DESC"].ConvertTo<String>();
            record.AuthorisePayMethod = dataRecord["SP_AUTHORISE_PAY_METHOD"].ConvertTo<Byte?>();
            record.AuthorisePayMethodParams = dataRecord["SP_AUTHORISE_PAY_METHOD_PARAMS"].ConvertTo<String>();
            record.GlBankCc = dataRecord["SP_GL_BANK_CC"].ConvertTo<String>();
            record.GlBankDc = dataRecord["SP_GL_BANK_DC"].ConvertTo<String>();
            record.AuthenticationMethod = dataRecord["SP_AUTHENTICATION_METHOD"].ConvertTo<Byte?>();
            record.Ec4ProvNoPlace = dataRecord["SP_EC4_PROV_NO_PLACE"].ConvertTo<Byte?>();
            record.AltInvCalc = dataRecord["SP_ALT_INV_CALC"].ConvertTo<Byte?>();
            record.CrystalTemplateReps = dataRecord["SP_CRYSTAL_TEMPLATE_REPS"].ConvertTo<String>();
            record.Deposit = dataRecord["SP_DEPOSIT"].ConvertTo<Decimal?>();
            record.InvoiceRule = dataRecord["SP_INVOICE_RULE"].ConvertTo<Byte>();
            record.InvoiceRuleOffset = dataRecord["SP_INVOICE_RULE_OFFSET"].ConvertTo<Int16>();
            record.InvoiceConsolidate = dataRecord["SP_INVOICE_CONSOLIDATE"].ConvertTo<Byte>();
            record.InvoiceWhenStatus = dataRecord["SP_INVOICE_WHEN_STATUS"].ConvertTo<String>();
            record.InvoiceFormat = dataRecord["SP_INVOICE_FORMAT"].ConvertTo<Byte>();
            record.InvoiceMustUseRule = dataRecord["SP_INVOICE_MUST_USE_RULE"].ConvertTo<Byte>();
            record.InvoiceFormat0Text = dataRecord["SP_INVOICE_FORMAT_0_TEXT"].ConvertTo<String>();
            record.InvoiceFormat1Text = dataRecord["SP_INVOICE_FORMAT_1_TEXT"].ConvertTo<String>();
            record.InvoiceOffsetType = dataRecord["SP_INVOICE_OFFSET_TYPE"].ConvertTo<String>();
            record.ShowAccountBalance = dataRecord["SP_SHOW_ACCOUNT_BALANCE"].ConvertTo<Byte>();
            record.InvoiceDoNotPrint = dataRecord["SP_INVOICE_DO_NOT_PRINT"].ConvertTo<Byte>();
            record.TransferStatus = dataRecord["SP_TRANSFER_STATUS"].ConvertTo<Byte?>();
            record.SubstituteStatus = dataRecord["SP_SUBSTITUTE_STATUS"].ConvertTo<Byte?>();
            record.HomeAdd = dataRecord["SP_HOME_ADD"].ConvertTo<Byte?>();
            record.AutoTransfer = dataRecord["SP_AUTO_TRANSFER"].ConvertTo<Byte?>();
            record.UseCertRules = dataRecord["SP_USE_CERT_RULES"].ConvertTo<Byte?>();
            record.FinanceCc = dataRecord["SP_FINANCE_CC"].ConvertTo<String>();
            record.NoEvAttPrint = dataRecord["SP_NO_EV_ATT_PRINT"].ConvertTo<Byte?>();
            record.CrystalUrl2 = dataRecord["SP_CRYSTAL_URL_2"].ConvertTo<String>();
            record.MainRoleDefault = dataRecord["SP_MAIN_ROLE_DEFAULT"].ConvertTo<Byte?>();
            record.ShowMemAllRoles = dataRecord["SP_SHOW_MEM_ALL_ROLES"].ConvertTo<Byte?>();
            record.NearestVenue = dataRecord["SP_NEAREST_VENUE"].ConvertTo<Byte?>();
            record.NotCreditTran = dataRecord["SP_NOT_CREDIT_TRAN"].ConvertTo<Byte?>();
            record.NotCreditSub = dataRecord["SP_NOT_CREDIT_SUB"].ConvertTo<Byte?>();
            record.GetUnlinkedAccom = dataRecord["SP_GET_UNLINKED_ACCOM"].ConvertTo<Byte?>();
            record.Defaults = dataRecord["SP_DEFAULTS"].ConvertTo<String>();
            record.ChgpwdDays = dataRecord["SP_CHGPWD_DAYS"].ConvertTo<Int32?>();
            record.PwdremDays = dataRecord["SP_PWDREM_DAYS"].ConvertTo<Int32?>();
            record.DefInvPackId = dataRecord["SP_DEF_INV_PACK_ID"].ConvertTo<String>();
            record.NextPpinvno = dataRecord["SP_NEXT_PPINVNO"].ConvertTo<Int32?>();
            record.NextPpcreditno = dataRecord["SP_NEXT_PPCREDITNO"].ConvertTo<Int32?>();
            record.InvNoPrefixPp = dataRecord["SP_INV_NO_PREFIX_PP"].ConvertTo<String>();
            record.InvNoSuffixPp = dataRecord["SP_INV_NO_SUFFIX_PP"].ConvertTo<String>();
            record.PrincipalRoleDefault = dataRecord["SP_PRINCIPAL_ROLE_DEFAULT"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SysParamsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SysParamsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SP_ID", record.Id);
            this.MapParameterIn(command, "@PA_SP_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_SP_SEC_PN_ID", record.SecPnId);
            this.MapParameterIn(command, "@PA_SP_REO_ORG_ID", record.ReoOrgId);
            this.MapParameterIn(command, "@PA_SP_VATREG", record.Vatreg);
            this.MapParameterIn(command, "@PA_SP_TIPS_CODE_PREFX", record.TipsCodePrefx);
            this.MapParameterIn(command, "@PA_SP_INV_NO_PREFIX", record.InvNoPrefix);
            this.MapParameterIn(command, "@PA_SP_NEXT_INV_NO", record.NextInvNo == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NextInvNo);
            this.MapParameterIn(command, "@PA_SP_NEXT_CREDIT_NTE", record.NextCreditNte == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.NextCreditNte);
            this.MapParameterIn(command, "@PA_SP_HEADED_PAPER", record.HeadedPaper);
            this.MapParameterIn(command, "@PA_SP_HEADING1", record.Heading1);
            this.MapParameterIn(command, "@PA_SP_HEADING", record.Heading);
            this.MapParameterIn(command, "@PA_SP_FOOTER", record.Footer);
            this.MapParameterIn(command, "@PA_SP_FOOTER_REO_LABL", record.FooterReoLabl);
            this.MapParameterIn(command, "@PA_SP_FOOTER_PHONE", record.FooterPhone);
            this.MapParameterIn(command, "@PA_SP_FOOTER_GEN_SEC", record.FooterGenSec);
            this.MapParameterIn(command, "@PA_SP_PIC_ID", record.PicId);
            this.MapParameterIn(command, "@PA_SP_GENERAL_TEXT_ID", record.GeneralTextId);
            this.MapParameterIn(command, "@PA_SP_GEN_CORS_TXT_ID", record.GenCorsTxtId);
            this.MapParameterIn(command, "@PA_SP_AUTH_SPECL_INST", record.AuthSpeclInst);
            this.MapParameterIn(command, "@PA_SP_DB_ID", record.DbId);
            this.MapParameterIn(command, "@PA_SP_MAIN", record.Main);
            this.MapParameterIn(command, "@PA_SP_REMOTE", record.Remote);
            this.MapParameterIn(command, "@PA_SP_NXT_SALE_LEG_NO", record.NxtSaleLegNo == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.NxtSaleLegNo);
            this.MapParameterIn(command, "@PA_SP_QUO_STATUS", record.QuoStatus);
            this.MapParameterIn(command, "@PA_SP_QUO_SOURCE", record.QuoSource);
            this.MapParameterIn(command, "@PA_SP_FORMAT_ACT_NOTE", record.FormatActNote);
            this.MapParameterIn(command, "@PA_SP_ORG_SRCH_FILTER", record.OrgSrchFilter);
            this.MapParameterIn(command, "@PA_SP_MID", record.Mid);
            this.MapParameterIn(command, "@PA_SP_USE_MATCH_FIELD", record.UseMatchField);
            this.MapParameterIn(command, "@PA_SP_OFFR_PRE_QUT_PN", record.OffrPreQutPn);
            this.MapParameterIn(command, "@PA_SP_CURRENT_RELEASE", record.CurrentRelease == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.CurrentRelease);
            this.MapParameterIn(command, "@PA_SP_LOWEST_RELEASE", record.LowestRelease == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LowestRelease);
            this.MapParameterIn(command, "@PA_SP_MAN_AUTO_ALLOC", record.ManAutoAlloc);
            this.MapParameterIn(command, "@PA_SP_ADD_MAN1_TO_ACT", record.AddMan1ToAct);
            this.MapParameterIn(command, "@PA_SP_ADD_MAN2_TO_ACT", record.AddMan2ToAct);
            this.MapParameterIn(command, "@PA_SP_ADD_DIST_TO_ACT", record.AddDistToAct);
            this.MapParameterIn(command, "@PA_SP_PERD_ROLL", record.PerdRoll);
            this.MapParameterIn(command, "@PA_SP_FT_CAN_CHG_THRS", record.FtCanChgThrs == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.FtCanChgThrs);
            this.MapParameterIn(command, "@PA_SP_SD_CAN_CHG_THRS", record.SdCanChgThrs == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SdCanChgThrs);
            this.MapParameterIn(command, "@PA_SP_CANC_CHRG_PRCNT", record.CancChrgPrcnt == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CancChrgPrcnt);
            this.MapParameterIn(command, "@PA_SP_FT_TRAN_CHG_THR", record.FtTranChgThr == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.FtTranChgThr);
            this.MapParameterIn(command, "@PA_SP_TRAN_CHGE_PRCNT", record.TranChgePrcnt == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TranChgePrcnt);
            this.MapParameterIn(command, "@PA_SP_EXT_MV_CHG_PRCN", record.ExtMvChgPrcn == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ExtMvChgPrcn);
            this.MapParameterIn(command, "@PA_SP_JOIN_LETT", record.JoinLett);
            this.MapParameterIn(command, "@PA_SP_CONFIRM_LETT", record.ConfirmLett);
            this.MapParameterIn(command, "@PA_SP_PROV_LETT", record.ProvLett);
            this.MapParameterIn(command, "@PA_SP_QUEST_LETT", record.QuestLett);
            this.MapParameterIn(command, "@PA_SP_SURV_LETT", record.SurvLett);
            this.MapParameterIn(command, "@PA_SP_INV_LETT", record.InvLett);
            this.MapParameterIn(command, "@PA_SP_UPDATE_STRG", record.UpdateStrg);
            this.MapParameterIn(command, "@PA_SP_JOB_TYPE", record.JobType);
            this.MapParameterIn(command, "@PA_SP_PREVENT_EDIT", record.PreventEdit);
            this.MapParameterIn(command, "@PA_SP_SUBS_LETTER", record.SubsLetter);
            this.MapParameterIn(command, "@PA_SP_REMOTE_USED", record.RemoteUsed);
            this.MapParameterIn(command, "@PA_SP_MERGE_LOCK", record.MergeLock);
            this.MapParameterIn(command, "@PA_SP_INV_RESTRICT", record.InvRestrict);
            this.MapParameterIn(command, "@PA_SP_CURR_PERD", record.CurrPerd);
            this.MapParameterIn(command, "@PA_SP_DEFAULT_ORG_ID", record.DefaultOrgId);
            this.MapParameterIn(command, "@PA_SP_OPP_ACT_MAND", record.OppActMand);
            this.MapParameterIn(command, "@PA_SP_SMTP_SERVER", record.SmtpServer);
            this.MapParameterIn(command, "@PA_SP_ADMIN_EMAIL", record.AdminEmail);
            this.MapParameterIn(command, "@PA_SP_USE_AKA_FIELD", record.UseAkaField);
            this.MapParameterIn(command, "@PA_SP_EXPORT_NUM", record.ExportNum == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ExportNum);
            this.MapParameterIn(command, "@PA_SP_IMPORT_NUM", record.ImportNum == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ImportNum);
            this.MapParameterIn(command, "@PA_SP_EXPORT_DATE", record.ExportDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ExportDate);
            this.MapParameterIn(command, "@PA_SP_BASE_CURR", record.BaseCurr);
            this.MapParameterIn(command, "@PA_SP_REG", record.Reg);
            this.MapParameterIn(command, "@PA_SP_FILE_STORE_PATH", record.FileStorePath);
            this.MapParameterIn(command, "@PA_SP_PIC_STORE_PATH", record.PicStorePath);
            this.MapParameterIn(command, "@PA_SP_NET_PATH", record.NetPath);
            this.MapParameterIn(command, "@PA_SP_BU_SECURITY", record.BuSecurity);
            this.MapParameterIn(command, "@PA_SP_ENQ_QST_ID", record.EnqQstId);
            this.MapParameterIn(command, "@PA_SP_DEL_QST_ID", record.DelQstId);
            this.MapParameterIn(command, "@PA_SP_BASE_CURR2", record.BaseCurr2);
            this.MapParameterIn(command, "@PA_SP_PROV_PACK", record.ProvPack);
            this.MapParameterIn(command, "@PA_SP_CONF_PACK", record.ConfPack);
            this.MapParameterIn(command, "@PA_SP_JOINING_PACK", record.JoiningPack);
            this.MapParameterIn(command, "@PA_SP_POST_PACK", record.PostPack);
            this.MapParameterIn(command, "@PA_SP_PROV_INV", record.ProvInv);
            this.MapParameterIn(command, "@PA_SP_CONF_INV", record.ConfInv);
            this.MapParameterIn(command, "@PA_SP_JOIN_INV", record.JoinInv);
            this.MapParameterIn(command, "@PA_SP_POST_INV", record.PostInv);
            this.MapParameterIn(command, "@PA_SP_PROV_NO_PLACE", record.ProvNoPlace);
            this.MapParameterIn(command, "@PA_SP_TRAINER_EMAIL", record.TrainerEmail);
            this.MapParameterIn(command, "@PA_SP_CB_DAYS", record.CbDays);
            this.MapParameterIn(command, "@PA_SP_PAYMENT_DAYS", record.PaymentDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PaymentDays);
            this.MapParameterIn(command, "@PA_SP_PAYMENT_TYPE", record.PaymentType);
            this.MapParameterIn(command, "@PA_SP_PAY_TERMS_1", record.PayTerms1);
            this.MapParameterIn(command, "@PA_SP_PAY_TERMS_2", record.PayTerms2);
            this.MapParameterIn(command, "@PA_SP_PAY_TERMS_3", record.PayTerms3);
            this.MapParameterIn(command, "@PA_SP_PAY_TERMS_4", record.PayTerms4);
            this.MapParameterIn(command, "@PA_SP_UPGRADE_PATH", record.UpgradePath);
            this.MapParameterIn(command, "@PA_SP_TC_LETT", record.TcLett);
            this.MapParameterIn(command, "@PA_SP_PRINTER1", record.Printer1);
            this.MapParameterIn(command, "@PA_SP_PRINTER2", record.Printer2);
            this.MapParameterIn(command, "@PA_SP_INITIALS", record.Initials);
            this.MapParameterIn(command, "@PA_SP_CRYSTAL_INV", record.CrystalInv);
            this.MapParameterIn(command, "@PA_SP_FLAG", record.Flag);
            this.MapParameterIn(command, "@PA_SP_BOOK_OTH_NODES", record.BookOthNodes);
            this.MapParameterIn(command, "@PA_SP_USER_NUMB_1", record.UserNumb1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.UserNumb1);
            this.MapParameterIn(command, "@PA_SP_VAT_METHOD", record.VatMethod);
            this.MapParameterIn(command, "@PA_SP_NO_LOGON", record.NoLogon);
            this.MapParameterIn(command, "@PA_SP_Q_RESULTS", record.QResults);
            this.MapParameterIn(command, "@PA_SP_FILE_PROD_EXT", record.FileProdExt);
            this.MapParameterIn(command, "@PA_SP_REG2", record.Reg2);
            this.MapParameterIn(command, "@PA_SP_REG3", record.Reg3);
            this.MapParameterIn(command, "@PA_SP_ELEM_FLAGS", record.ElemFlags);
            this.MapParameterIn(command, "@PA_SP_SELL_COMP_NAME", record.SellCompName);
            this.MapParameterIn(command, "@PA_SP_BOOK_APPROVAL", record.BookApproval);
            this.MapParameterIn(command, "@PA_SP_BKT_ID", record.BktId);
            this.MapParameterIn(command, "@PA_SP_ATTACHMENTS_URL", record.AttachmentsUrl);
            this.MapParameterIn(command, "@PA_SP_PERIODS", record.Periods == Int32.MinValue ? 0 : record.Periods);
            this.MapParameterIn(command, "@PA_SP_BAT_SEL_PROC", record.BatSelProc);
            this.MapParameterIn(command, "@PA_SP_BAT_OUT_PROC", record.BatOutProc);
            this.MapParameterIn(command, "@PA_SP_BAT_OUT_DIR", record.BatOutDir);
            this.MapParameterIn(command, "@PA_SP_DEF_INV_LT_ID", record.DefInvLtId);
            this.MapParameterIn(command, "@PA_SP_MEM_INV_LT_ID", record.MemInvLtId);
            this.MapParameterIn(command, "@PA_SP_PROJ_INV_LT_ID", record.ProjInvLtId);
            this.MapParameterIn(command, "@PA_SP_NO_SALESTEAM", record.NoSalesteam);
            this.MapParameterIn(command, "@PA_SP_CRYSTAL_URL", record.CrystalUrl);
            this.MapParameterIn(command, "@PA_SP_CRYSTAL_ODBC", record.CrystalOdbc);
            this.MapParameterIn(command, "@PA_SP_CRYSTAL_STD_REPS", record.CrystalStdReps);
            this.MapParameterIn(command, "@PA_SP_CRYSTAL_CUST_REPS", record.CrystalCustReps);
            this.MapParameterIn(command, "@PA_SP_CRYSTAL_USER_REPS", record.CrystalUserReps);
            this.MapParameterIn(command, "@PA_SP_INV_NO_SUFFIX", record.InvNoSuffix);
            this.MapParameterIn(command, "@PA_SP_NEXT_PROFORM_NO", record.NextProformNo == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.NextProformNo);
            this.MapParameterIn(command, "@PA_SP_ONLY_MEM_PRICE", record.OnlyMemPrice == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.OnlyMemPrice);
            this.MapParameterIn(command, "@PA_SP_MEMBER_ONLY_PRC", record.MemberOnlyPrc);
            this.MapParameterIn(command, "@PA_SP_GL_SALES_CTRL", record.GlSalesCtrl);
            this.MapParameterIn(command, "@PA_SP_GL_VAT_CTRL", record.GlVatCtrl);
            this.MapParameterIn(command, "@PA_SP_GL_BANK", record.GlBank);
            this.MapParameterIn(command, "@PA_SP_GL_BANK_CHARGE", record.GlBankCharge);
            this.MapParameterIn(command, "@PA_SP_GL_WRITEOFF", record.GlWriteoff);
            this.MapParameterIn(command, "@PA_SP_GL_SL_ADJ", record.GlSlAdj);
            this.MapParameterIn(command, "@PA_SP_GL_1", record.Gl1);
            this.MapParameterIn(command, "@PA_SP_GL_2", record.Gl2);
            this.MapParameterIn(command, "@PA_SP_GL_3", record.Gl3);
            this.MapParameterIn(command, "@PA_SP_GL_4", record.Gl4);
            this.MapParameterIn(command, "@PA_SP_ACCT_DESC", record.AcctDesc);
            this.MapParameterIn(command, "@PA_SP_MEAL_REPORT_NUM", record.MealReportNum == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.MealReportNum);
            this.MapParameterIn(command, "@PA_SP_BOOK_PREF", record.BookPref);
            this.MapParameterIn(command, "@PA_SP_DPM_BCC", record.DpmBcc);
            this.MapParameterIn(command, "@PA_SP_ADD_LINE_5", record.AddLine5);
            this.MapParameterIn(command, "@PA_SP_SOURCE_CODE", record.SourceCode);
            this.MapParameterIn(command, "@PA_SP_REG_LOOKUP", record.RegLookup);
            this.MapParameterIn(command, "@PA_SP_DEFAULT_TEXT_1", record.DefaultText1);
            this.MapParameterIn(command, "@PA_SP_WSPOSTCODE_PATH", record.WspostcodePath);
            this.MapParameterIn(command, "@PA_SP_DEFAULT_INT_1", record.DefaultInt1 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DefaultInt1);
            this.MapParameterIn(command, "@PA_SP_DEFAULT_USAGE_DESC", record.DefaultUsageDesc);
            this.MapParameterIn(command, "@PA_SP_AUTHORISE_PAY_METHOD", record.AuthorisePayMethod);
            this.MapParameterIn(command, "@PA_SP_AUTHORISE_PAY_METHOD_PARAMS", record.AuthorisePayMethodParams);
            this.MapParameterIn(command, "@PA_SP_GL_BANK_CC", record.GlBankCc);
            this.MapParameterIn(command, "@PA_SP_GL_BANK_DC", record.GlBankDc);
            this.MapParameterIn(command, "@PA_SP_AUTHENTICATION_METHOD", record.AuthenticationMethod);
            this.MapParameterIn(command, "@PA_SP_EC4_PROV_NO_PLACE", record.Ec4ProvNoPlace);
            this.MapParameterIn(command, "@PA_SP_ALT_INV_CALC", record.AltInvCalc);
            this.MapParameterIn(command, "@PA_SP_CRYSTAL_TEMPLATE_REPS", record.CrystalTemplateReps);
            this.MapParameterIn(command, "@PA_SP_DEPOSIT", record.Deposit == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Deposit);
            this.MapParameterIn(command, "@PA_SP_INVOICE_RULE", record.InvoiceRule);
            this.MapParameterIn(command, "@PA_SP_INVOICE_RULE_OFFSET", record.InvoiceRuleOffset == Int16.MinValue ? 0 : record.InvoiceRuleOffset);
            this.MapParameterIn(command, "@PA_SP_INVOICE_CONSOLIDATE", record.InvoiceConsolidate);
            this.MapParameterIn(command, "@PA_SP_INVOICE_WHEN_STATUS", record.InvoiceWhenStatus);
            this.MapParameterIn(command, "@PA_SP_INVOICE_FORMAT", record.InvoiceFormat);
            this.MapParameterIn(command, "@PA_SP_INVOICE_MUST_USE_RULE", record.InvoiceMustUseRule);
            this.MapParameterIn(command, "@PA_SP_INVOICE_FORMAT_0_TEXT", record.InvoiceFormat0Text);
            this.MapParameterIn(command, "@PA_SP_INVOICE_FORMAT_1_TEXT", record.InvoiceFormat1Text);
            this.MapParameterIn(command, "@PA_SP_INVOICE_OFFSET_TYPE", record.InvoiceOffsetType);
            this.MapParameterIn(command, "@PA_SP_SHOW_ACCOUNT_BALANCE", record.ShowAccountBalance);
            this.MapParameterIn(command, "@PA_SP_INVOICE_DO_NOT_PRINT", record.InvoiceDoNotPrint);
            this.MapParameterIn(command, "@PA_SP_TRANSFER_STATUS", record.TransferStatus);
            this.MapParameterIn(command, "@PA_SP_SUBSTITUTE_STATUS", record.SubstituteStatus);
            this.MapParameterIn(command, "@PA_SP_HOME_ADD", record.HomeAdd);
            this.MapParameterIn(command, "@PA_SP_AUTO_TRANSFER", record.AutoTransfer);
            this.MapParameterIn(command, "@PA_SP_USE_CERT_RULES", record.UseCertRules);
            this.MapParameterIn(command, "@PA_SP_FINANCE_CC", record.FinanceCc);
            this.MapParameterIn(command, "@PA_SP_NO_EV_ATT_PRINT", record.NoEvAttPrint);
            this.MapParameterIn(command, "@PA_SP_CRYSTAL_URL_2", record.CrystalUrl2);
            this.MapParameterIn(command, "@PA_SP_MAIN_ROLE_DEFAULT", record.MainRoleDefault);
            this.MapParameterIn(command, "@PA_SP_SHOW_MEM_ALL_ROLES", record.ShowMemAllRoles);
            this.MapParameterIn(command, "@PA_SP_NEAREST_VENUE", record.NearestVenue);
            this.MapParameterIn(command, "@PA_SP_NOT_CREDIT_TRAN", record.NotCreditTran);
            this.MapParameterIn(command, "@PA_SP_NOT_CREDIT_SUB", record.NotCreditSub);
            this.MapParameterIn(command, "@PA_SP_GET_UNLINKED_ACCOM", record.GetUnlinkedAccom);
            this.MapParameterIn(command, "@PA_SP_DEFAULTS", record.Defaults);
            this.MapParameterIn(command, "@PA_SP_CHGPWD_DAYS", record.ChgpwdDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ChgpwdDays);
            this.MapParameterIn(command, "@PA_SP_PWDREM_DAYS", record.PwdremDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PwdremDays);
            this.MapParameterIn(command, "@PA_SP_DEF_INV_PACK_ID", record.DefInvPackId);
            this.MapParameterIn(command, "@PA_SP_NEXT_PPINVNO", record.NextPpinvno == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NextPpinvno);
            this.MapParameterIn(command, "@PA_SP_NEXT_PPCREDITNO", record.NextPpcreditno == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NextPpcreditno);
            this.MapParameterIn(command, "@PA_SP_INV_NO_PREFIX_PP", record.InvNoPrefixPp);
            this.MapParameterIn(command, "@PA_SP_INV_NO_SUFFIX_PP", record.InvNoSuffixPp);
            this.MapParameterIn(command, "@PA_SP_PRINCIPAL_ROLE_DEFAULT", record.PrincipalRoleDefault);
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
        ///     The <see cref="SysParamsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SysParamsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SP_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_SP_LOCK", record.Lock);
            record.SecPnId = this.MapParameterOut(command, "@PA_SP_SEC_PN_ID", record.SecPnId);
            record.ReoOrgId = this.MapParameterOut(command, "@PA_SP_REO_ORG_ID", record.ReoOrgId);
            record.Vatreg = this.MapParameterOut(command, "@PA_SP_VATREG", record.Vatreg);
            record.TipsCodePrefx = this.MapParameterOut(command, "@PA_SP_TIPS_CODE_PREFX", record.TipsCodePrefx);
            record.InvNoPrefix = this.MapParameterOut(command, "@PA_SP_INV_NO_PREFIX", record.InvNoPrefix);
            record.NextInvNo = this.MapParameterOut(command, "@PA_SP_NEXT_INV_NO", record.NextInvNo);
            record.NextCreditNte = this.MapParameterOut(command, "@PA_SP_NEXT_CREDIT_NTE", record.NextCreditNte);
            record.HeadedPaper = this.MapParameterOut(command, "@PA_SP_HEADED_PAPER", record.HeadedPaper);
            record.Heading1 = this.MapParameterOut(command, "@PA_SP_HEADING1", record.Heading1);
            record.Heading = this.MapParameterOut(command, "@PA_SP_HEADING", record.Heading);
            record.Footer = this.MapParameterOut(command, "@PA_SP_FOOTER", record.Footer);
            record.FooterReoLabl = this.MapParameterOut(command, "@PA_SP_FOOTER_REO_LABL", record.FooterReoLabl);
            record.FooterPhone = this.MapParameterOut(command, "@PA_SP_FOOTER_PHONE", record.FooterPhone);
            record.FooterGenSec = this.MapParameterOut(command, "@PA_SP_FOOTER_GEN_SEC", record.FooterGenSec);
            record.PicId = this.MapParameterOut(command, "@PA_SP_PIC_ID", record.PicId);
            record.GeneralTextId = this.MapParameterOut(command, "@PA_SP_GENERAL_TEXT_ID", record.GeneralTextId);
            record.GenCorsTxtId = this.MapParameterOut(command, "@PA_SP_GEN_CORS_TXT_ID", record.GenCorsTxtId);
            record.AuthSpeclInst = this.MapParameterOut(command, "@PA_SP_AUTH_SPECL_INST", record.AuthSpeclInst);
            record.DbId = this.MapParameterOut(command, "@PA_SP_DB_ID", record.DbId);
            record.Main = this.MapParameterOut(command, "@PA_SP_MAIN", record.Main);
            record.Remote = this.MapParameterOut(command, "@PA_SP_REMOTE", record.Remote);
            record.NxtSaleLegNo = this.MapParameterOut(command, "@PA_SP_NXT_SALE_LEG_NO", record.NxtSaleLegNo);
            record.QuoStatus = this.MapParameterOut(command, "@PA_SP_QUO_STATUS", record.QuoStatus);
            record.QuoSource = this.MapParameterOut(command, "@PA_SP_QUO_SOURCE", record.QuoSource);
            record.FormatActNote = this.MapParameterOut(command, "@PA_SP_FORMAT_ACT_NOTE", record.FormatActNote);
            record.OrgSrchFilter = this.MapParameterOut(command, "@PA_SP_ORG_SRCH_FILTER", record.OrgSrchFilter);
            record.Mid = this.MapParameterOut(command, "@PA_SP_MID", record.Mid);
            record.UseMatchField = this.MapParameterOut(command, "@PA_SP_USE_MATCH_FIELD", record.UseMatchField);
            record.OffrPreQutPn = this.MapParameterOut(command, "@PA_SP_OFFR_PRE_QUT_PN", record.OffrPreQutPn);
            record.CurrentRelease = this.MapParameterOut(command, "@PA_SP_CURRENT_RELEASE", record.CurrentRelease);
            record.LowestRelease = this.MapParameterOut(command, "@PA_SP_LOWEST_RELEASE", record.LowestRelease);
            record.ManAutoAlloc = this.MapParameterOut(command, "@PA_SP_MAN_AUTO_ALLOC", record.ManAutoAlloc);
            record.AddMan1ToAct = this.MapParameterOut(command, "@PA_SP_ADD_MAN1_TO_ACT", record.AddMan1ToAct);
            record.AddMan2ToAct = this.MapParameterOut(command, "@PA_SP_ADD_MAN2_TO_ACT", record.AddMan2ToAct);
            record.AddDistToAct = this.MapParameterOut(command, "@PA_SP_ADD_DIST_TO_ACT", record.AddDistToAct);
            record.PerdRoll = this.MapParameterOut(command, "@PA_SP_PERD_ROLL", record.PerdRoll);
            record.FtCanChgThrs = this.MapParameterOut(command, "@PA_SP_FT_CAN_CHG_THRS", record.FtCanChgThrs);
            record.SdCanChgThrs = this.MapParameterOut(command, "@PA_SP_SD_CAN_CHG_THRS", record.SdCanChgThrs);
            record.CancChrgPrcnt = this.MapParameterOut(command, "@PA_SP_CANC_CHRG_PRCNT", record.CancChrgPrcnt);
            record.FtTranChgThr = this.MapParameterOut(command, "@PA_SP_FT_TRAN_CHG_THR", record.FtTranChgThr);
            record.TranChgePrcnt = this.MapParameterOut(command, "@PA_SP_TRAN_CHGE_PRCNT", record.TranChgePrcnt);
            record.ExtMvChgPrcn = this.MapParameterOut(command, "@PA_SP_EXT_MV_CHG_PRCN", record.ExtMvChgPrcn);
            record.JoinLett = this.MapParameterOut(command, "@PA_SP_JOIN_LETT", record.JoinLett);
            record.ConfirmLett = this.MapParameterOut(command, "@PA_SP_CONFIRM_LETT", record.ConfirmLett);
            record.ProvLett = this.MapParameterOut(command, "@PA_SP_PROV_LETT", record.ProvLett);
            record.QuestLett = this.MapParameterOut(command, "@PA_SP_QUEST_LETT", record.QuestLett);
            record.SurvLett = this.MapParameterOut(command, "@PA_SP_SURV_LETT", record.SurvLett);
            record.InvLett = this.MapParameterOut(command, "@PA_SP_INV_LETT", record.InvLett);
            record.UpdateStrg = this.MapParameterOut(command, "@PA_SP_UPDATE_STRG", record.UpdateStrg);
            record.JobType = this.MapParameterOut(command, "@PA_SP_JOB_TYPE", record.JobType);
            record.PreventEdit = this.MapParameterOut(command, "@PA_SP_PREVENT_EDIT", record.PreventEdit);
            record.SubsLetter = this.MapParameterOut(command, "@PA_SP_SUBS_LETTER", record.SubsLetter);
            record.RemoteUsed = this.MapParameterOut(command, "@PA_SP_REMOTE_USED", record.RemoteUsed);
            record.MergeLock = this.MapParameterOut(command, "@PA_SP_MERGE_LOCK", record.MergeLock);
            record.InvRestrict = this.MapParameterOut(command, "@PA_SP_INV_RESTRICT", record.InvRestrict);
            record.CurrPerd = this.MapParameterOut(command, "@PA_SP_CURR_PERD", record.CurrPerd);
            record.DefaultOrgId = this.MapParameterOut(command, "@PA_SP_DEFAULT_ORG_ID", record.DefaultOrgId);
            record.OppActMand = this.MapParameterOut(command, "@PA_SP_OPP_ACT_MAND", record.OppActMand);
            record.SmtpServer = this.MapParameterOut(command, "@PA_SP_SMTP_SERVER", record.SmtpServer);
            record.AdminEmail = this.MapParameterOut(command, "@PA_SP_ADMIN_EMAIL", record.AdminEmail);
            record.UseAkaField = this.MapParameterOut(command, "@PA_SP_USE_AKA_FIELD", record.UseAkaField);
            record.ExportNum = this.MapParameterOut(command, "@PA_SP_EXPORT_NUM", record.ExportNum);
            record.ImportNum = this.MapParameterOut(command, "@PA_SP_IMPORT_NUM", record.ImportNum);
            record.ExportDate = this.MapParameterOut(command, "@PA_SP_EXPORT_DATE", record.ExportDate);
            record.BaseCurr = this.MapParameterOut(command, "@PA_SP_BASE_CURR", record.BaseCurr);
            record.Reg = this.MapParameterOut(command, "@PA_SP_REG", record.Reg);
            record.FileStorePath = this.MapParameterOut(command, "@PA_SP_FILE_STORE_PATH", record.FileStorePath);
            record.PicStorePath = this.MapParameterOut(command, "@PA_SP_PIC_STORE_PATH", record.PicStorePath);
            record.NetPath = this.MapParameterOut(command, "@PA_SP_NET_PATH", record.NetPath);
            record.BuSecurity = this.MapParameterOut(command, "@PA_SP_BU_SECURITY", record.BuSecurity);
            record.EnqQstId = this.MapParameterOut(command, "@PA_SP_ENQ_QST_ID", record.EnqQstId);
            record.DelQstId = this.MapParameterOut(command, "@PA_SP_DEL_QST_ID", record.DelQstId);
            record.BaseCurr2 = this.MapParameterOut(command, "@PA_SP_BASE_CURR2", record.BaseCurr2);
            record.ProvPack = this.MapParameterOut(command, "@PA_SP_PROV_PACK", record.ProvPack);
            record.ConfPack = this.MapParameterOut(command, "@PA_SP_CONF_PACK", record.ConfPack);
            record.JoiningPack = this.MapParameterOut(command, "@PA_SP_JOINING_PACK", record.JoiningPack);
            record.PostPack = this.MapParameterOut(command, "@PA_SP_POST_PACK", record.PostPack);
            record.ProvInv = this.MapParameterOut(command, "@PA_SP_PROV_INV", record.ProvInv);
            record.ConfInv = this.MapParameterOut(command, "@PA_SP_CONF_INV", record.ConfInv);
            record.JoinInv = this.MapParameterOut(command, "@PA_SP_JOIN_INV", record.JoinInv);
            record.PostInv = this.MapParameterOut(command, "@PA_SP_POST_INV", record.PostInv);
            record.ProvNoPlace = this.MapParameterOut(command, "@PA_SP_PROV_NO_PLACE", record.ProvNoPlace);
            record.TrainerEmail = this.MapParameterOut(command, "@PA_SP_TRAINER_EMAIL", record.TrainerEmail);
            record.CbDays = this.MapParameterOut(command, "@PA_SP_CB_DAYS", record.CbDays);
            record.PaymentDays = this.MapParameterOut(command, "@PA_SP_PAYMENT_DAYS", record.PaymentDays);
            record.PaymentType = this.MapParameterOut(command, "@PA_SP_PAYMENT_TYPE", record.PaymentType);
            record.PayTerms1 = this.MapParameterOut(command, "@PA_SP_PAY_TERMS_1", record.PayTerms1);
            record.PayTerms2 = this.MapParameterOut(command, "@PA_SP_PAY_TERMS_2", record.PayTerms2);
            record.PayTerms3 = this.MapParameterOut(command, "@PA_SP_PAY_TERMS_3", record.PayTerms3);
            record.PayTerms4 = this.MapParameterOut(command, "@PA_SP_PAY_TERMS_4", record.PayTerms4);
            record.UpgradePath = this.MapParameterOut(command, "@PA_SP_UPGRADE_PATH", record.UpgradePath);
            record.TcLett = this.MapParameterOut(command, "@PA_SP_TC_LETT", record.TcLett);
            record.Printer1 = this.MapParameterOut(command, "@PA_SP_PRINTER1", record.Printer1);
            record.Printer2 = this.MapParameterOut(command, "@PA_SP_PRINTER2", record.Printer2);
            record.Initials = this.MapParameterOut(command, "@PA_SP_INITIALS", record.Initials);
            record.CrystalInv = this.MapParameterOut(command, "@PA_SP_CRYSTAL_INV", record.CrystalInv);
            record.Flag = this.MapParameterOut(command, "@PA_SP_FLAG", record.Flag);
            record.BookOthNodes = this.MapParameterOut(command, "@PA_SP_BOOK_OTH_NODES", record.BookOthNodes);
            record.UserNumb1 = this.MapParameterOut(command, "@PA_SP_USER_NUMB_1", record.UserNumb1);
            record.VatMethod = this.MapParameterOut(command, "@PA_SP_VAT_METHOD", record.VatMethod);
            record.NoLogon = this.MapParameterOut(command, "@PA_SP_NO_LOGON", record.NoLogon);
            record.QResults = this.MapParameterOut(command, "@PA_SP_Q_RESULTS", record.QResults);
            record.FileProdExt = this.MapParameterOut(command, "@PA_SP_FILE_PROD_EXT", record.FileProdExt);
            record.Reg2 = this.MapParameterOut(command, "@PA_SP_REG2", record.Reg2);
            record.Reg3 = this.MapParameterOut(command, "@PA_SP_REG3", record.Reg3);
            record.ElemFlags = this.MapParameterOut(command, "@PA_SP_ELEM_FLAGS", record.ElemFlags);
            record.SellCompName = this.MapParameterOut(command, "@PA_SP_SELL_COMP_NAME", record.SellCompName);
            record.BookApproval = this.MapParameterOut(command, "@PA_SP_BOOK_APPROVAL", record.BookApproval);
            record.BktId = this.MapParameterOut(command, "@PA_SP_BKT_ID", record.BktId);
            record.AttachmentsUrl = this.MapParameterOut(command, "@PA_SP_ATTACHMENTS_URL", record.AttachmentsUrl);
            record.Periods = this.MapParameterOut(command, "@PA_SP_PERIODS", record.Periods);
            record.BatSelProc = this.MapParameterOut(command, "@PA_SP_BAT_SEL_PROC", record.BatSelProc);
            record.BatOutProc = this.MapParameterOut(command, "@PA_SP_BAT_OUT_PROC", record.BatOutProc);
            record.BatOutDir = this.MapParameterOut(command, "@PA_SP_BAT_OUT_DIR", record.BatOutDir);
            record.DefInvLtId = this.MapParameterOut(command, "@PA_SP_DEF_INV_LT_ID", record.DefInvLtId);
            record.MemInvLtId = this.MapParameterOut(command, "@PA_SP_MEM_INV_LT_ID", record.MemInvLtId);
            record.ProjInvLtId = this.MapParameterOut(command, "@PA_SP_PROJ_INV_LT_ID", record.ProjInvLtId);
            record.NoSalesteam = this.MapParameterOut(command, "@PA_SP_NO_SALESTEAM", record.NoSalesteam);
            record.CrystalUrl = this.MapParameterOut(command, "@PA_SP_CRYSTAL_URL", record.CrystalUrl);
            record.CrystalOdbc = this.MapParameterOut(command, "@PA_SP_CRYSTAL_ODBC", record.CrystalOdbc);
            record.CrystalStdReps = this.MapParameterOut(command, "@PA_SP_CRYSTAL_STD_REPS", record.CrystalStdReps);
            record.CrystalCustReps = this.MapParameterOut(command, "@PA_SP_CRYSTAL_CUST_REPS", record.CrystalCustReps);
            record.CrystalUserReps = this.MapParameterOut(command, "@PA_SP_CRYSTAL_USER_REPS", record.CrystalUserReps);
            record.InvNoSuffix = this.MapParameterOut(command, "@PA_SP_INV_NO_SUFFIX", record.InvNoSuffix);
            record.NextProformNo = this.MapParameterOut(command, "@PA_SP_NEXT_PROFORM_NO", record.NextProformNo);
            record.OnlyMemPrice = this.MapParameterOut(command, "@PA_SP_ONLY_MEM_PRICE", record.OnlyMemPrice);
            record.MemberOnlyPrc = this.MapParameterOut(command, "@PA_SP_MEMBER_ONLY_PRC", record.MemberOnlyPrc);
            record.GlSalesCtrl = this.MapParameterOut(command, "@PA_SP_GL_SALES_CTRL", record.GlSalesCtrl);
            record.GlVatCtrl = this.MapParameterOut(command, "@PA_SP_GL_VAT_CTRL", record.GlVatCtrl);
            record.GlBank = this.MapParameterOut(command, "@PA_SP_GL_BANK", record.GlBank);
            record.GlBankCharge = this.MapParameterOut(command, "@PA_SP_GL_BANK_CHARGE", record.GlBankCharge);
            record.GlWriteoff = this.MapParameterOut(command, "@PA_SP_GL_WRITEOFF", record.GlWriteoff);
            record.GlSlAdj = this.MapParameterOut(command, "@PA_SP_GL_SL_ADJ", record.GlSlAdj);
            record.Gl1 = this.MapParameterOut(command, "@PA_SP_GL_1", record.Gl1);
            record.Gl2 = this.MapParameterOut(command, "@PA_SP_GL_2", record.Gl2);
            record.Gl3 = this.MapParameterOut(command, "@PA_SP_GL_3", record.Gl3);
            record.Gl4 = this.MapParameterOut(command, "@PA_SP_GL_4", record.Gl4);
            record.AcctDesc = this.MapParameterOut(command, "@PA_SP_ACCT_DESC", record.AcctDesc);
            record.MealReportNum = this.MapParameterOut(command, "@PA_SP_MEAL_REPORT_NUM", record.MealReportNum);
            record.BookPref = this.MapParameterOut(command, "@PA_SP_BOOK_PREF", record.BookPref);
            record.DpmBcc = this.MapParameterOut(command, "@PA_SP_DPM_BCC", record.DpmBcc);
            record.AddLine5 = this.MapParameterOut(command, "@PA_SP_ADD_LINE_5", record.AddLine5);
            record.SourceCode = this.MapParameterOut(command, "@PA_SP_SOURCE_CODE", record.SourceCode);
            record.RegLookup = this.MapParameterOut(command, "@PA_SP_REG_LOOKUP", record.RegLookup);
            record.DefaultText1 = this.MapParameterOut(command, "@PA_SP_DEFAULT_TEXT_1", record.DefaultText1);
            record.WspostcodePath = this.MapParameterOut(command, "@PA_SP_WSPOSTCODE_PATH", record.WspostcodePath);
            record.DefaultInt1 = this.MapParameterOut(command, "@PA_SP_DEFAULT_INT_1", record.DefaultInt1);
            record.DefaultUsageDesc = this.MapParameterOut(command, "@PA_SP_DEFAULT_USAGE_DESC", record.DefaultUsageDesc);
            record.AuthorisePayMethod = this.MapParameterOut(command, "@PA_SP_AUTHORISE_PAY_METHOD", record.AuthorisePayMethod);
            record.AuthorisePayMethodParams = this.MapParameterOut(command, "@PA_SP_AUTHORISE_PAY_METHOD_PARAMS", record.AuthorisePayMethodParams);
            record.GlBankCc = this.MapParameterOut(command, "@PA_SP_GL_BANK_CC", record.GlBankCc);
            record.GlBankDc = this.MapParameterOut(command, "@PA_SP_GL_BANK_DC", record.GlBankDc);
            record.AuthenticationMethod = this.MapParameterOut(command, "@PA_SP_AUTHENTICATION_METHOD", record.AuthenticationMethod);
            record.Ec4ProvNoPlace = this.MapParameterOut(command, "@PA_SP_EC4_PROV_NO_PLACE", record.Ec4ProvNoPlace);
            record.AltInvCalc = this.MapParameterOut(command, "@PA_SP_ALT_INV_CALC", record.AltInvCalc);
            record.CrystalTemplateReps = this.MapParameterOut(command, "@PA_SP_CRYSTAL_TEMPLATE_REPS", record.CrystalTemplateReps);
            record.Deposit = this.MapParameterOut(command, "@PA_SP_DEPOSIT", record.Deposit);
            record.InvoiceRule = this.MapParameterOut(command, "@PA_SP_INVOICE_RULE", record.InvoiceRule);
            record.InvoiceRuleOffset = this.MapParameterOut(command, "@PA_SP_INVOICE_RULE_OFFSET", record.InvoiceRuleOffset);
            record.InvoiceConsolidate = this.MapParameterOut(command, "@PA_SP_INVOICE_CONSOLIDATE", record.InvoiceConsolidate);
            record.InvoiceWhenStatus = this.MapParameterOut(command, "@PA_SP_INVOICE_WHEN_STATUS", record.InvoiceWhenStatus);
            record.InvoiceFormat = this.MapParameterOut(command, "@PA_SP_INVOICE_FORMAT", record.InvoiceFormat);
            record.InvoiceMustUseRule = this.MapParameterOut(command, "@PA_SP_INVOICE_MUST_USE_RULE", record.InvoiceMustUseRule);
            record.InvoiceFormat0Text = this.MapParameterOut(command, "@PA_SP_INVOICE_FORMAT_0_TEXT", record.InvoiceFormat0Text);
            record.InvoiceFormat1Text = this.MapParameterOut(command, "@PA_SP_INVOICE_FORMAT_1_TEXT", record.InvoiceFormat1Text);
            record.InvoiceOffsetType = this.MapParameterOut(command, "@PA_SP_INVOICE_OFFSET_TYPE", record.InvoiceOffsetType);
            record.ShowAccountBalance = this.MapParameterOut(command, "@PA_SP_SHOW_ACCOUNT_BALANCE", record.ShowAccountBalance);
            record.InvoiceDoNotPrint = this.MapParameterOut(command, "@PA_SP_INVOICE_DO_NOT_PRINT", record.InvoiceDoNotPrint);
            record.TransferStatus = this.MapParameterOut(command, "@PA_SP_TRANSFER_STATUS", record.TransferStatus);
            record.SubstituteStatus = this.MapParameterOut(command, "@PA_SP_SUBSTITUTE_STATUS", record.SubstituteStatus);
            record.HomeAdd = this.MapParameterOut(command, "@PA_SP_HOME_ADD", record.HomeAdd);
            record.AutoTransfer = this.MapParameterOut(command, "@PA_SP_AUTO_TRANSFER", record.AutoTransfer);
            record.UseCertRules = this.MapParameterOut(command, "@PA_SP_USE_CERT_RULES", record.UseCertRules);
            record.FinanceCc = this.MapParameterOut(command, "@PA_SP_FINANCE_CC", record.FinanceCc);
            record.NoEvAttPrint = this.MapParameterOut(command, "@PA_SP_NO_EV_ATT_PRINT", record.NoEvAttPrint);
            record.CrystalUrl2 = this.MapParameterOut(command, "@PA_SP_CRYSTAL_URL_2", record.CrystalUrl2);
            record.MainRoleDefault = this.MapParameterOut(command, "@PA_SP_MAIN_ROLE_DEFAULT", record.MainRoleDefault);
            record.ShowMemAllRoles = this.MapParameterOut(command, "@PA_SP_SHOW_MEM_ALL_ROLES", record.ShowMemAllRoles);
            record.NearestVenue = this.MapParameterOut(command, "@PA_SP_NEAREST_VENUE", record.NearestVenue);
            record.NotCreditTran = this.MapParameterOut(command, "@PA_SP_NOT_CREDIT_TRAN", record.NotCreditTran);
            record.NotCreditSub = this.MapParameterOut(command, "@PA_SP_NOT_CREDIT_SUB", record.NotCreditSub);
            record.GetUnlinkedAccom = this.MapParameterOut(command, "@PA_SP_GET_UNLINKED_ACCOM", record.GetUnlinkedAccom);
            record.Defaults = this.MapParameterOut(command, "@PA_SP_DEFAULTS", record.Defaults);
            record.ChgpwdDays = this.MapParameterOut(command, "@PA_SP_CHGPWD_DAYS", record.ChgpwdDays);
            record.PwdremDays = this.MapParameterOut(command, "@PA_SP_PWDREM_DAYS", record.PwdremDays);
            record.DefInvPackId = this.MapParameterOut(command, "@PA_SP_DEF_INV_PACK_ID", record.DefInvPackId);
            record.NextPpinvno = this.MapParameterOut(command, "@PA_SP_NEXT_PPINVNO", record.NextPpinvno);
            record.NextPpcreditno = this.MapParameterOut(command, "@PA_SP_NEXT_PPCREDITNO", record.NextPpcreditno);
            record.InvNoPrefixPp = this.MapParameterOut(command, "@PA_SP_INV_NO_PREFIX_PP", record.InvNoPrefixPp);
            record.InvNoSuffixPp = this.MapParameterOut(command, "@PA_SP_INV_NO_SUFFIX_PP", record.InvNoSuffixPp);
            record.PrincipalRoleDefault = this.MapParameterOut(command, "@PA_SP_PRINCIPAL_ROLE_DEFAULT", record.PrincipalRoleDefault);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISellingCompanyRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
