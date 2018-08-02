using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "Sys_Params" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SysParamsRecord : Record<String>, Cloneable<SysParamsRecord>, IEquatable<SysParamsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "SP_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "SP_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "SP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "SP_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "SP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "SP_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "SP_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "SP_SEC_PN_ID" field.
        /// </summary>
        private String _secPnId;

        /// <summary>
        ///     the value of the "SP_REO_ORG_ID" field.
        /// </summary>
        private String _reoOrgId;

        /// <summary>
        ///     the value of the "SP_VATREG" field.
        /// </summary>
        private String _vatreg;

        /// <summary>
        ///     the value of the "SP_TIPS_CODE_PREFX" field.
        /// </summary>
        private String _tipsCodePrefx;

        /// <summary>
        ///     the value of the "SP_INV_NO_PREFIX" field.
        /// </summary>
        private String _invNoPrefix;

        /// <summary>
        ///     the value of the "SP_NEXT_INV_NO" field.
        /// </summary>
        private Int32? _nextInvNo;

        /// <summary>
        ///     the value of the "SP_NEXT_CREDIT_NTE" field.
        /// </summary>
        private Int64? _nextCreditNte;

        /// <summary>
        ///     the value of the "SP_HEADED_PAPER" field.
        /// </summary>
        private Byte? _headedPaper;

        /// <summary>
        ///     the value of the "SP_HEADING1" field.
        /// </summary>
        private String _heading1;

        /// <summary>
        ///     the value of the "SP_HEADING" field.
        /// </summary>
        private String _heading;

        /// <summary>
        ///     the value of the "SP_FOOTER" field.
        /// </summary>
        private String _footer;

        /// <summary>
        ///     the value of the "SP_FOOTER_REO_LABL" field.
        /// </summary>
        private String _footerReoLabl;

        /// <summary>
        ///     the value of the "SP_FOOTER_PHONE" field.
        /// </summary>
        private String _footerPhone;

        /// <summary>
        ///     the value of the "SP_FOOTER_GEN_SEC" field.
        /// </summary>
        private String _footerGenSec;

        /// <summary>
        ///     the value of the "SP_PIC_ID" field.
        /// </summary>
        private String _picId;

        /// <summary>
        ///     the value of the "SP_GENERAL_TEXT_ID" field.
        /// </summary>
        private String _generalTextId;

        /// <summary>
        ///     the value of the "SP_GEN_CORS_TXT_ID" field.
        /// </summary>
        private String _genCorsTxtId;

        /// <summary>
        ///     the value of the "SP_AUTH_SPECL_INST" field.
        /// </summary>
        private String _authSpeclInst;

        /// <summary>
        ///     the value of the "SP_DB_ID" field.
        /// </summary>
        private String _dbId;

        /// <summary>
        ///     the value of the "SP_MAIN" field.
        /// </summary>
        private Byte? _main;

        /// <summary>
        ///     the value of the "SP_REMOTE" field.
        /// </summary>
        private String _remote;

        /// <summary>
        ///     the value of the "SP_NXT_SALE_LEG_NO" field.
        /// </summary>
        private Double? _nxtSaleLegNo;

        /// <summary>
        ///     the value of the "SP_QUO_STATUS" field.
        /// </summary>
        private Byte? _quoStatus;

        /// <summary>
        ///     the value of the "SP_QUO_SOURCE" field.
        /// </summary>
        private Byte? _quoSource;

        /// <summary>
        ///     the value of the "SP_FORMAT_ACT_NOTE" field.
        /// </summary>
        private Byte? _formatActNote;

        /// <summary>
        ///     the value of the "SP_ORG_SRCH_FILTER" field.
        /// </summary>
        private Byte? _orgSrchFilter;

        /// <summary>
        ///     the value of the "SP_MID" field.
        /// </summary>
        private Byte? _mid;

        /// <summary>
        ///     the value of the "SP_USE_MATCH_FIELD" field.
        /// </summary>
        private Byte? _useMatchField;

        /// <summary>
        ///     the value of the "SP_OFFR_PRE_QUT_PN" field.
        /// </summary>
        private Byte? _offrPreQutPn;

        /// <summary>
        ///     the value of the "SP_CURRENT_RELEASE" field.
        /// </summary>
        private Int32? _currentRelease;

        /// <summary>
        ///     the value of the "SP_LOWEST_RELEASE" field.
        /// </summary>
        private Int32? _lowestRelease;

        /// <summary>
        ///     the value of the "SP_MAN_AUTO_ALLOC" field.
        /// </summary>
        private Byte? _manAutoAlloc;

        /// <summary>
        ///     the value of the "SP_ADD_MAN1_TO_ACT" field.
        /// </summary>
        private Byte? _addMan1ToAct;

        /// <summary>
        ///     the value of the "SP_ADD_MAN2_TO_ACT" field.
        /// </summary>
        private Byte? _addMan2ToAct;

        /// <summary>
        ///     the value of the "SP_ADD_DIST_TO_ACT" field.
        /// </summary>
        private Byte? _addDistToAct;

        /// <summary>
        ///     the value of the "SP_PERD_ROLL" field.
        /// </summary>
        private String _perdRoll;

        /// <summary>
        ///     the value of the "SP_FT_CAN_CHG_THRS" field.
        /// </summary>
        private Int32? _ftCanChgThrs;

        /// <summary>
        ///     the value of the "SP_SD_CAN_CHG_THRS" field.
        /// </summary>
        private Int32? _sdCanChgThrs;

        /// <summary>
        ///     the value of the "SP_CANC_CHRG_PRCNT" field.
        /// </summary>
        private Double? _cancChrgPrcnt;

        /// <summary>
        ///     the value of the "SP_FT_TRAN_CHG_THR" field.
        /// </summary>
        private Int32? _ftTranChgThr;

        /// <summary>
        ///     the value of the "SP_TRAN_CHGE_PRCNT" field.
        /// </summary>
        private Double? _tranChgePrcnt;

        /// <summary>
        ///     the value of the "SP_EXT_MV_CHG_PRCN" field.
        /// </summary>
        private Double? _extMvChgPrcn;

        /// <summary>
        ///     the value of the "SP_JOIN_LETT" field.
        /// </summary>
        private String _joinLett;

        /// <summary>
        ///     the value of the "SP_CONFIRM_LETT" field.
        /// </summary>
        private String _confirmLett;

        /// <summary>
        ///     the value of the "SP_PROV_LETT" field.
        /// </summary>
        private String _provLett;

        /// <summary>
        ///     the value of the "SP_QUEST_LETT" field.
        /// </summary>
        private String _questLett;

        /// <summary>
        ///     the value of the "SP_SURV_LETT" field.
        /// </summary>
        private String _survLett;

        /// <summary>
        ///     the value of the "SP_INV_LETT" field.
        /// </summary>
        private String _invLett;

        /// <summary>
        ///     the value of the "SP_UPDATE_STRG" field.
        /// </summary>
        private Byte? _updateStrg;

        /// <summary>
        ///     the value of the "SP_JOB_TYPE" field.
        /// </summary>
        private Byte? _jobType;

        /// <summary>
        ///     the value of the "SP_PREVENT_EDIT" field.
        /// </summary>
        private Byte? _preventEdit;

        /// <summary>
        ///     the value of the "SP_SUBS_LETTER" field.
        /// </summary>
        private Byte? _subsLetter;

        /// <summary>
        ///     the value of the "SP_REMOTE_USED" field.
        /// </summary>
        private Byte? _remoteUsed;

        /// <summary>
        ///     the value of the "SP_MERGE_LOCK" field.
        /// </summary>
        private String _mergeLock;

        /// <summary>
        ///     the value of the "SP_INV_RESTRICT" field.
        /// </summary>
        private Byte? _invRestrict;

        /// <summary>
        ///     the value of the "SP_CURR_PERD" field.
        /// </summary>
        private String _currPerd;

        /// <summary>
        ///     the value of the "SP_DEFAULT_ORG_ID" field.
        /// </summary>
        private String _defaultOrgId;

        /// <summary>
        ///     the value of the "SP_OPP_ACT_MAND" field.
        /// </summary>
        private Byte? _oppActMand;

        /// <summary>
        ///     the value of the "SP_SMTP_SERVER" field.
        /// </summary>
        private String _smtpServer;

        /// <summary>
        ///     the value of the "SP_ADMIN_EMAIL" field.
        /// </summary>
        private String _adminEmail;

        /// <summary>
        ///     the value of the "SP_USE_AKA_FIELD" field.
        /// </summary>
        private Byte? _useAkaField;

        /// <summary>
        ///     the value of the "SP_EXPORT_NUM" field.
        /// </summary>
        private Int32? _exportNum;

        /// <summary>
        ///     the value of the "SP_IMPORT_NUM" field.
        /// </summary>
        private Int32? _importNum;

        /// <summary>
        ///     the value of the "SP_EXPORT_DATE" field.
        /// </summary>
        private DateTime? _exportDate;

        /// <summary>
        ///     the value of the "SP_BASE_CURR" field.
        /// </summary>
        private String _baseCurr;

        /// <summary>
        ///     the value of the "SP_REG" field.
        /// </summary>
        private String _reg;

        /// <summary>
        ///     the value of the "SP_FILE_STORE_PATH" field.
        /// </summary>
        private String _fileStorePath;

        /// <summary>
        ///     the value of the "SP_PIC_STORE_PATH" field.
        /// </summary>
        private String _picStorePath;

        /// <summary>
        ///     the value of the "SP_NET_PATH" field.
        /// </summary>
        private String _netPath;

        /// <summary>
        ///     the value of the "SP_BU_SECURITY" field.
        /// </summary>
        private Byte? _buSecurity;

        /// <summary>
        ///     the value of the "SP_ENQ_QST_ID" field.
        /// </summary>
        private String _enqQstId;

        /// <summary>
        ///     the value of the "SP_DEL_QST_ID" field.
        /// </summary>
        private String _delQstId;

        /// <summary>
        ///     the value of the "SP_BASE_CURR2" field.
        /// </summary>
        private String _baseCurr2;

        /// <summary>
        ///     the value of the "SP_PROV_PACK" field.
        /// </summary>
        private String _provPack;

        /// <summary>
        ///     the value of the "SP_CONF_PACK" field.
        /// </summary>
        private String _confPack;

        /// <summary>
        ///     the value of the "SP_JOINING_PACK" field.
        /// </summary>
        private String _joiningPack;

        /// <summary>
        ///     the value of the "SP_POST_PACK" field.
        /// </summary>
        private String _postPack;

        /// <summary>
        ///     the value of the "SP_PROV_INV" field.
        /// </summary>
        private Byte? _provInv;

        /// <summary>
        ///     the value of the "SP_CONF_INV" field.
        /// </summary>
        private Byte? _confInv;

        /// <summary>
        ///     the value of the "SP_JOIN_INV" field.
        /// </summary>
        private Byte? _joinInv;

        /// <summary>
        ///     the value of the "SP_POST_INV" field.
        /// </summary>
        private Byte? _postInv;

        /// <summary>
        ///     the value of the "SP_PROV_NO_PLACE" field.
        /// </summary>
        private Byte? _provNoPlace;

        /// <summary>
        ///     the value of the "SP_TRAINER_EMAIL" field.
        /// </summary>
        private String _trainerEmail;

        /// <summary>
        ///     the value of the "SP_CB_DAYS" field.
        /// </summary>
        private String _cbDays;

        /// <summary>
        ///     the value of the "SP_PAYMENT_DAYS" field.
        /// </summary>
        private Int32? _paymentDays;

        /// <summary>
        ///     the value of the "SP_PAYMENT_TYPE" field.
        /// </summary>
        private Byte? _paymentType;

        /// <summary>
        ///     the value of the "SP_PAY_TERMS_1" field.
        /// </summary>
        private String _payTerms1;

        /// <summary>
        ///     the value of the "SP_PAY_TERMS_2" field.
        /// </summary>
        private String _payTerms2;

        /// <summary>
        ///     the value of the "SP_PAY_TERMS_3" field.
        /// </summary>
        private String _payTerms3;

        /// <summary>
        ///     the value of the "SP_PAY_TERMS_4" field.
        /// </summary>
        private String _payTerms4;

        /// <summary>
        ///     the value of the "SP_UPGRADE_PATH" field.
        /// </summary>
        private String _upgradePath;

        /// <summary>
        ///     the value of the "SP_TC_LETT" field.
        /// </summary>
        private String _tcLett;

        /// <summary>
        ///     the value of the "SP_PRINTER1" field.
        /// </summary>
        private String _printer1;

        /// <summary>
        ///     the value of the "SP_PRINTER2" field.
        /// </summary>
        private String _printer2;

        /// <summary>
        ///     the value of the "SP_INITIALS" field.
        /// </summary>
        private String _initials;

        /// <summary>
        ///     the value of the "SP_CRYSTAL_INV" field.
        /// </summary>
        private String _crystalInv;

        /// <summary>
        ///     the value of the "SP_FLAG" field.
        /// </summary>
        private String _flag;

        /// <summary>
        ///     the value of the "SP_BOOK_OTH_NODES" field.
        /// </summary>
        private Byte? _bookOthNodes;

        /// <summary>
        ///     the value of the "SP_USER_NUMB_1" field.
        /// </summary>
        private Double? _userNumb1;

        /// <summary>
        ///     the value of the "SP_VAT_METHOD" field.
        /// </summary>
        private Byte? _vatMethod;

        /// <summary>
        ///     the value of the "SP_NO_LOGON" field.
        /// </summary>
        private Byte? _noLogon;

        /// <summary>
        ///     the value of the "SP_Q_RESULTS" field.
        /// </summary>
        private Byte? _qResults;

        /// <summary>
        ///     the value of the "SP_FILE_PROD_EXT" field.
        /// </summary>
        private Byte? _fileProdExt;

        /// <summary>
        ///     the value of the "SP_REG2" field.
        /// </summary>
        private String _reg2;

        /// <summary>
        ///     the value of the "SP_REG3" field.
        /// </summary>
        private String _reg3;

        /// <summary>
        ///     the value of the "SP_ELEM_FLAGS" field.
        /// </summary>
        private Byte? _elemFlags;

        /// <summary>
        ///     the value of the "SP_SELL_COMP_NAME" field.
        /// </summary>
        private String _sellCompName;

        /// <summary>
        ///     the value of the "SP_BOOK_APPROVAL" field.
        /// </summary>
        private Byte? _bookApproval;

        /// <summary>
        ///     the value of the "SP_BKT_ID" field.
        /// </summary>
        private String _bktId;

        /// <summary>
        ///     the value of the "SP_ATTACHMENTS_URL" field.
        /// </summary>
        private String _attachmentsUrl;

        /// <summary>
        ///     the value of the "SP_PERIODS" field.
        /// </summary>
        private Int32 _periods;

        /// <summary>
        ///     the value of the "SP_BAT_SEL_PROC" field.
        /// </summary>
        private String _batSelProc;

        /// <summary>
        ///     the value of the "SP_BAT_OUT_PROC" field.
        /// </summary>
        private String _batOutProc;

        /// <summary>
        ///     the value of the "SP_BAT_OUT_DIR" field.
        /// </summary>
        private String _batOutDir;

        /// <summary>
        ///     the value of the "SP_DEF_INV_LT_ID" field.
        /// </summary>
        private String _defInvLtId;

        /// <summary>
        ///     the value of the "SP_MEM_INV_LT_ID" field.
        /// </summary>
        private String _memInvLtId;

        /// <summary>
        ///     the value of the "SP_PROJ_INV_LT_ID" field.
        /// </summary>
        private String _projInvLtId;

        /// <summary>
        ///     the value of the "SP_NO_SALESTEAM" field.
        /// </summary>
        private Byte? _noSalesteam;

        /// <summary>
        ///     the value of the "SP_CRYSTAL_URL" field.
        /// </summary>
        private String _crystalUrl;

        /// <summary>
        ///     the value of the "SP_CRYSTAL_ODBC" field.
        /// </summary>
        private String _crystalOdbc;

        /// <summary>
        ///     the value of the "SP_CRYSTAL_STD_REPS" field.
        /// </summary>
        private String _crystalStdReps;

        /// <summary>
        ///     the value of the "SP_CRYSTAL_CUST_REPS" field.
        /// </summary>
        private String _crystalCustReps;

        /// <summary>
        ///     the value of the "SP_CRYSTAL_USER_REPS" field.
        /// </summary>
        private String _crystalUserReps;

        /// <summary>
        ///     the value of the "SP_INV_NO_SUFFIX" field.
        /// </summary>
        private String _invNoSuffix;

        /// <summary>
        ///     the value of the "SP_NEXT_PROFORM_NO" field.
        /// </summary>
        private Int64? _nextProformNo;

        /// <summary>
        ///     the value of the "SP_ONLY_MEM_PRICE" field.
        /// </summary>
        private Int32? _onlyMemPrice;

        /// <summary>
        ///     the value of the "SP_MEMBER_ONLY_PRC" field.
        /// </summary>
        private Byte? _memberOnlyPrc;

        /// <summary>
        ///     the value of the "SP_GL_SALES_CTRL" field.
        /// </summary>
        private String _glSalesCtrl;

        /// <summary>
        ///     the value of the "SP_GL_VAT_CTRL" field.
        /// </summary>
        private String _glVatCtrl;

        /// <summary>
        ///     the value of the "SP_GL_BANK" field.
        /// </summary>
        private String _glBank;

        /// <summary>
        ///     the value of the "SP_GL_BANK_CHARGE" field.
        /// </summary>
        private String _glBankCharge;

        /// <summary>
        ///     the value of the "SP_GL_WRITEOFF" field.
        /// </summary>
        private String _glWriteoff;

        /// <summary>
        ///     the value of the "SP_GL_SL_ADJ" field.
        /// </summary>
        private String _glSlAdj;

        /// <summary>
        ///     the value of the "SP_GL_1" field.
        /// </summary>
        private String _gl1;

        /// <summary>
        ///     the value of the "SP_GL_2" field.
        /// </summary>
        private String _gl2;

        /// <summary>
        ///     the value of the "SP_GL_3" field.
        /// </summary>
        private String _gl3;

        /// <summary>
        ///     the value of the "SP_GL_4" field.
        /// </summary>
        private String _gl4;

        /// <summary>
        ///     the value of the "SP_ACCT_DESC" field.
        /// </summary>
        private String _acctDesc;

        /// <summary>
        ///     the value of the "SP_MEAL_REPORT_NUM" field.
        /// </summary>
        private Int32? _mealReportNum;

        /// <summary>
        ///     the value of the "SP_BOOK_PREF" field.
        /// </summary>
        private Byte? _bookPref;

        /// <summary>
        ///     the value of the "SP_DPM_BCC" field.
        /// </summary>
        private Byte? _dpmBcc;

        /// <summary>
        ///     the value of the "SP_ADD_LINE_5" field.
        /// </summary>
        private Byte? _addLine5;

        /// <summary>
        ///     the value of the "SP_SOURCE_CODE" field.
        /// </summary>
        private Byte? _sourceCode;

        /// <summary>
        ///     the value of the "SP_REG_LOOKUP" field.
        /// </summary>
        private Byte? _regLookup;

        /// <summary>
        ///     the value of the "SP_DEFAULT_TEXT_1" field.
        /// </summary>
        private String _defaultText1;

        /// <summary>
        ///     the value of the "SP_WSPOSTCODE_PATH" field.
        /// </summary>
        private String _wspostcodePath;

        /// <summary>
        ///     the value of the "SP_DEFAULT_INT_1" field.
        /// </summary>
        private Int32? _defaultInt1;

        /// <summary>
        ///     the value of the "SP_DEFAULT_USAGE_DESC" field.
        /// </summary>
        private String _defaultUsageDesc;

        /// <summary>
        ///     the value of the "SP_AUTHORISE_PAY_METHOD" field.
        /// </summary>
        private Byte? _authorisePayMethod;

        /// <summary>
        ///     the value of the "SP_AUTHORISE_PAY_METHOD_PARAMS" field.
        /// </summary>
        private String _authorisePayMethodParams;

        /// <summary>
        ///     the value of the "SP_GL_BANK_CC" field.
        /// </summary>
        private String _glBankCc;

        /// <summary>
        ///     the value of the "SP_GL_BANK_DC" field.
        /// </summary>
        private String _glBankDc;

        /// <summary>
        ///     the value of the "SP_AUTHENTICATION_METHOD" field.
        /// </summary>
        private Byte? _authenticationMethod;

        /// <summary>
        ///     the value of the "SP_EC4_PROV_NO_PLACE" field.
        /// </summary>
        private Byte? _ec4ProvNoPlace;

        /// <summary>
        ///     the value of the "SP_ALT_INV_CALC" field.
        /// </summary>
        private Byte? _altInvCalc;

        /// <summary>
        ///     the value of the "SP_CRYSTAL_TEMPLATE_REPS" field.
        /// </summary>
        private String _crystalTemplateReps;

        /// <summary>
        ///     the value of the "SP_DEPOSIT" field.
        /// </summary>
        private Decimal? _deposit;

        /// <summary>
        ///     the value of the "SP_INVOICE_RULE" field.
        /// </summary>
        private Byte _invoiceRule;

        /// <summary>
        ///     the value of the "SP_INVOICE_RULE_OFFSET" field.
        /// </summary>
        private Int16 _invoiceRuleOffset;

        /// <summary>
        ///     the value of the "SP_INVOICE_CONSOLIDATE" field.
        /// </summary>
        private Byte _invoiceConsolidate;

        /// <summary>
        ///     the value of the "SP_INVOICE_WHEN_STATUS" field.
        /// </summary>
        private String _invoiceWhenStatus;

        /// <summary>
        ///     the value of the "SP_INVOICE_FORMAT" field.
        /// </summary>
        private Byte _invoiceFormat;

        /// <summary>
        ///     the value of the "SP_INVOICE_MUST_USE_RULE" field.
        /// </summary>
        private Byte _invoiceMustUseRule;

        /// <summary>
        ///     the value of the "SP_INVOICE_FORMAT_0_TEXT" field.
        /// </summary>
        private String _invoiceFormat0Text;

        /// <summary>
        ///     the value of the "SP_INVOICE_FORMAT_1_TEXT" field.
        /// </summary>
        private String _invoiceFormat1Text;

        /// <summary>
        ///     the value of the "SP_INVOICE_OFFSET_TYPE" field.
        /// </summary>
        private String _invoiceOffsetType;

        /// <summary>
        ///     the value of the "SP_SHOW_ACCOUNT_BALANCE" field.
        /// </summary>
        private Byte _showAccountBalance;

        /// <summary>
        ///     the value of the "SP_INVOICE_DO_NOT_PRINT" field.
        /// </summary>
        private Byte _invoiceDoNotPrint;

        /// <summary>
        ///     the value of the "SP_TRANSFER_STATUS" field.
        /// </summary>
        private Byte? _transferStatus;

        /// <summary>
        ///     the value of the "SP_SUBSTITUTE_STATUS" field.
        /// </summary>
        private Byte? _substituteStatus;

        /// <summary>
        ///     the value of the "SP_HOME_ADD" field.
        /// </summary>
        private Byte? _homeAdd;

        /// <summary>
        ///     the value of the "SP_AUTO_TRANSFER" field.
        /// </summary>
        private Byte? _autoTransfer;

        /// <summary>
        ///     the value of the "SP_USE_CERT_RULES" field.
        /// </summary>
        private Byte? _useCertRules;

        /// <summary>
        ///     the value of the "SP_FINANCE_CC" field.
        /// </summary>
        private String _financeCc;

        /// <summary>
        ///     the value of the "SP_NO_EV_ATT_PRINT" field.
        /// </summary>
        private Byte? _noEvAttPrint;

        /// <summary>
        ///     the value of the "SP_CRYSTAL_URL_2" field.
        /// </summary>
        private String _crystalUrl2;

        /// <summary>
        ///     the value of the "SP_MAIN_ROLE_DEFAULT" field.
        /// </summary>
        private Byte? _mainRoleDefault;

        /// <summary>
        ///     the value of the "SP_SHOW_MEM_ALL_ROLES" field.
        /// </summary>
        private Byte? _showMemAllRoles;

        /// <summary>
        ///     the value of the "SP_NEAREST_VENUE" field.
        /// </summary>
        private Byte? _nearestVenue;

        /// <summary>
        ///     the value of the "SP_NOT_CREDIT_TRAN" field.
        /// </summary>
        private Byte? _notCreditTran;

        /// <summary>
        ///     the value of the "SP_NOT_CREDIT_SUB" field.
        /// </summary>
        private Byte? _notCreditSub;

        /// <summary>
        ///     the value of the "SP_GET_UNLINKED_ACCOM" field.
        /// </summary>
        private Byte? _getUnlinkedAccom;

        /// <summary>
        ///     the value of the "SP_DEFAULTS" field.
        /// </summary>
        private String _defaults;

        /// <summary>
        ///     the value of the "SP_CHGPWD_DAYS" field.
        /// </summary>
        private Int32? _chgpwdDays;

        /// <summary>
        ///     the value of the "SP_PWDREM_DAYS" field.
        /// </summary>
        private Int32? _pwdremDays;

        /// <summary>
        ///     the value of the "SP_DEF_INV_PACK_ID" field.
        /// </summary>
        private String _defInvPackId;

        /// <summary>
        ///     the value of the "SP_NEXT_PPINVNO" field.
        /// </summary>
        private Int32? _nextPpinvno;

        /// <summary>
        ///     the value of the "SP_NEXT_PPCREDITNO" field.
        /// </summary>
        private Int32? _nextPpcreditno;

        /// <summary>
        ///     the value of the "SP_INV_NO_PREFIX_PP" field.
        /// </summary>
        private String _invNoPrefixPp;

        /// <summary>
        ///     the value of the "SP_INV_NO_SUFFIX_PP" field.
        /// </summary>
        private String _invNoSuffixPp;

        /// <summary>
        ///     the value of the "SP_PRINCIPAL_ROLE_DEFAULT" field.
        /// </summary>
        private Byte? _principalRoleDefault;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "SP_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "SP_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "SP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "SP_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "SP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "SP_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "SP_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "SP_SEC_PN_ID" field.
        /// </summary>
        public String SecPnId
        {
            get { return _secPnId; }
            set { _secPnId = value; }
        }

        /// <summary>
        ///     the value of the "SP_REO_ORG_ID" field.
        /// </summary>
        public String ReoOrgId
        {
            get { return _reoOrgId; }
            set { _reoOrgId = value; }
        }

        /// <summary>
        ///     the value of the "SP_VATREG" field.
        /// </summary>
        public String Vatreg
        {
            get { return _vatreg; }
            set { _vatreg = value; }
        }

        /// <summary>
        ///     the value of the "SP_TIPS_CODE_PREFX" field.
        /// </summary>
        public String TipsCodePrefx
        {
            get { return _tipsCodePrefx; }
            set { _tipsCodePrefx = value; }
        }

        /// <summary>
        ///     the value of the "SP_INV_NO_PREFIX" field.
        /// </summary>
        public String InvNoPrefix
        {
            get { return _invNoPrefix; }
            set { _invNoPrefix = value; }
        }

        /// <summary>
        ///     the value of the "SP_NEXT_INV_NO" field.
        /// </summary>
        public Int32? NextInvNo
        {
            get { return _nextInvNo; }
            set { _nextInvNo = value; }
        }

        /// <summary>
        ///     the value of the "SP_NEXT_CREDIT_NTE" field.
        /// </summary>
        public Int64? NextCreditNte
        {
            get { return _nextCreditNte; }
            set { _nextCreditNte = value; }
        }

        /// <summary>
        ///     the value of the "SP_HEADED_PAPER" field.
        /// </summary>
        public Byte? HeadedPaper
        {
            get { return _headedPaper; }
            set { _headedPaper = value; }
        }

        /// <summary>
        ///     the value of the "SP_HEADING1" field.
        /// </summary>
        public String Heading1
        {
            get { return _heading1; }
            set { _heading1 = value; }
        }

        /// <summary>
        ///     the value of the "SP_HEADING" field.
        /// </summary>
        public String Heading
        {
            get { return _heading; }
            set { _heading = value; }
        }

        /// <summary>
        ///     the value of the "SP_FOOTER" field.
        /// </summary>
        public String Footer
        {
            get { return _footer; }
            set { _footer = value; }
        }

        /// <summary>
        ///     the value of the "SP_FOOTER_REO_LABL" field.
        /// </summary>
        public String FooterReoLabl
        {
            get { return _footerReoLabl; }
            set { _footerReoLabl = value; }
        }

        /// <summary>
        ///     the value of the "SP_FOOTER_PHONE" field.
        /// </summary>
        public String FooterPhone
        {
            get { return _footerPhone; }
            set { _footerPhone = value; }
        }

        /// <summary>
        ///     the value of the "SP_FOOTER_GEN_SEC" field.
        /// </summary>
        public String FooterGenSec
        {
            get { return _footerGenSec; }
            set { _footerGenSec = value; }
        }

        /// <summary>
        ///     the value of the "SP_PIC_ID" field.
        /// </summary>
        public String PicId
        {
            get { return _picId; }
            set { _picId = value; }
        }

        /// <summary>
        ///     the value of the "SP_GENERAL_TEXT_ID" field.
        /// </summary>
        public String GeneralTextId
        {
            get { return _generalTextId; }
            set { _generalTextId = value; }
        }

        /// <summary>
        ///     the value of the "SP_GEN_CORS_TXT_ID" field.
        /// </summary>
        public String GenCorsTxtId
        {
            get { return _genCorsTxtId; }
            set { _genCorsTxtId = value; }
        }

        /// <summary>
        ///     the value of the "SP_AUTH_SPECL_INST" field.
        /// </summary>
        public String AuthSpeclInst
        {
            get { return _authSpeclInst; }
            set { _authSpeclInst = value; }
        }

        /// <summary>
        ///     the value of the "SP_DB_ID" field.
        /// </summary>
        public String DbId
        {
            get { return _dbId; }
            set { _dbId = value; }
        }

        /// <summary>
        ///     the value of the "SP_MAIN" field.
        /// </summary>
        public Byte? Main
        {
            get { return _main; }
            set { _main = value; }
        }

        /// <summary>
        ///     the value of the "SP_REMOTE" field.
        /// </summary>
        public String Remote
        {
            get { return _remote; }
            set { _remote = value; }
        }

        /// <summary>
        ///     the value of the "SP_NXT_SALE_LEG_NO" field.
        /// </summary>
        public Double? NxtSaleLegNo
        {
            get { return _nxtSaleLegNo; }
            set { _nxtSaleLegNo = value; }
        }

        /// <summary>
        ///     the value of the "SP_QUO_STATUS" field.
        /// </summary>
        public Byte? QuoStatus
        {
            get { return _quoStatus; }
            set { _quoStatus = value; }
        }

        /// <summary>
        ///     the value of the "SP_QUO_SOURCE" field.
        /// </summary>
        public Byte? QuoSource
        {
            get { return _quoSource; }
            set { _quoSource = value; }
        }

        /// <summary>
        ///     the value of the "SP_FORMAT_ACT_NOTE" field.
        /// </summary>
        public Byte? FormatActNote
        {
            get { return _formatActNote; }
            set { _formatActNote = value; }
        }

        /// <summary>
        ///     the value of the "SP_ORG_SRCH_FILTER" field.
        /// </summary>
        public Byte? OrgSrchFilter
        {
            get { return _orgSrchFilter; }
            set { _orgSrchFilter = value; }
        }

        /// <summary>
        ///     the value of the "SP_MID" field.
        /// </summary>
        public Byte? Mid
        {
            get { return _mid; }
            set { _mid = value; }
        }

        /// <summary>
        ///     the value of the "SP_USE_MATCH_FIELD" field.
        /// </summary>
        public Byte? UseMatchField
        {
            get { return _useMatchField; }
            set { _useMatchField = value; }
        }

        /// <summary>
        ///     the value of the "SP_OFFR_PRE_QUT_PN" field.
        /// </summary>
        public Byte? OffrPreQutPn
        {
            get { return _offrPreQutPn; }
            set { _offrPreQutPn = value; }
        }

        /// <summary>
        ///     the value of the "SP_CURRENT_RELEASE" field.
        /// </summary>
        public Int32? CurrentRelease
        {
            get { return _currentRelease; }
            set { _currentRelease = value; }
        }

        /// <summary>
        ///     the value of the "SP_LOWEST_RELEASE" field.
        /// </summary>
        public Int32? LowestRelease
        {
            get { return _lowestRelease; }
            set { _lowestRelease = value; }
        }

        /// <summary>
        ///     the value of the "SP_MAN_AUTO_ALLOC" field.
        /// </summary>
        public Byte? ManAutoAlloc
        {
            get { return _manAutoAlloc; }
            set { _manAutoAlloc = value; }
        }

        /// <summary>
        ///     the value of the "SP_ADD_MAN1_TO_ACT" field.
        /// </summary>
        public Byte? AddMan1ToAct
        {
            get { return _addMan1ToAct; }
            set { _addMan1ToAct = value; }
        }

        /// <summary>
        ///     the value of the "SP_ADD_MAN2_TO_ACT" field.
        /// </summary>
        public Byte? AddMan2ToAct
        {
            get { return _addMan2ToAct; }
            set { _addMan2ToAct = value; }
        }

        /// <summary>
        ///     the value of the "SP_ADD_DIST_TO_ACT" field.
        /// </summary>
        public Byte? AddDistToAct
        {
            get { return _addDistToAct; }
            set { _addDistToAct = value; }
        }

        /// <summary>
        ///     the value of the "SP_PERD_ROLL" field.
        /// </summary>
        public String PerdRoll
        {
            get { return _perdRoll; }
            set { _perdRoll = value; }
        }

        /// <summary>
        ///     the value of the "SP_FT_CAN_CHG_THRS" field.
        /// </summary>
        public Int32? FtCanChgThrs
        {
            get { return _ftCanChgThrs; }
            set { _ftCanChgThrs = value; }
        }

        /// <summary>
        ///     the value of the "SP_SD_CAN_CHG_THRS" field.
        /// </summary>
        public Int32? SdCanChgThrs
        {
            get { return _sdCanChgThrs; }
            set { _sdCanChgThrs = value; }
        }

        /// <summary>
        ///     the value of the "SP_CANC_CHRG_PRCNT" field.
        /// </summary>
        public Double? CancChrgPrcnt
        {
            get { return _cancChrgPrcnt; }
            set { _cancChrgPrcnt = value; }
        }

        /// <summary>
        ///     the value of the "SP_FT_TRAN_CHG_THR" field.
        /// </summary>
        public Int32? FtTranChgThr
        {
            get { return _ftTranChgThr; }
            set { _ftTranChgThr = value; }
        }

        /// <summary>
        ///     the value of the "SP_TRAN_CHGE_PRCNT" field.
        /// </summary>
        public Double? TranChgePrcnt
        {
            get { return _tranChgePrcnt; }
            set { _tranChgePrcnt = value; }
        }

        /// <summary>
        ///     the value of the "SP_EXT_MV_CHG_PRCN" field.
        /// </summary>
        public Double? ExtMvChgPrcn
        {
            get { return _extMvChgPrcn; }
            set { _extMvChgPrcn = value; }
        }

        /// <summary>
        ///     the value of the "SP_JOIN_LETT" field.
        /// </summary>
        public String JoinLett
        {
            get { return _joinLett; }
            set { _joinLett = value; }
        }

        /// <summary>
        ///     the value of the "SP_CONFIRM_LETT" field.
        /// </summary>
        public String ConfirmLett
        {
            get { return _confirmLett; }
            set { _confirmLett = value; }
        }

        /// <summary>
        ///     the value of the "SP_PROV_LETT" field.
        /// </summary>
        public String ProvLett
        {
            get { return _provLett; }
            set { _provLett = value; }
        }

        /// <summary>
        ///     the value of the "SP_QUEST_LETT" field.
        /// </summary>
        public String QuestLett
        {
            get { return _questLett; }
            set { _questLett = value; }
        }

        /// <summary>
        ///     the value of the "SP_SURV_LETT" field.
        /// </summary>
        public String SurvLett
        {
            get { return _survLett; }
            set { _survLett = value; }
        }

        /// <summary>
        ///     the value of the "SP_INV_LETT" field.
        /// </summary>
        public String InvLett
        {
            get { return _invLett; }
            set { _invLett = value; }
        }

        /// <summary>
        ///     the value of the "SP_UPDATE_STRG" field.
        /// </summary>
        public Byte? UpdateStrg
        {
            get { return _updateStrg; }
            set { _updateStrg = value; }
        }

        /// <summary>
        ///     the value of the "SP_JOB_TYPE" field.
        /// </summary>
        public Byte? JobType
        {
            get { return _jobType; }
            set { _jobType = value; }
        }

        /// <summary>
        ///     the value of the "SP_PREVENT_EDIT" field.
        /// </summary>
        public Byte? PreventEdit
        {
            get { return _preventEdit; }
            set { _preventEdit = value; }
        }

        /// <summary>
        ///     the value of the "SP_SUBS_LETTER" field.
        /// </summary>
        public Byte? SubsLetter
        {
            get { return _subsLetter; }
            set { _subsLetter = value; }
        }

        /// <summary>
        ///     the value of the "SP_REMOTE_USED" field.
        /// </summary>
        public Byte? RemoteUsed
        {
            get { return _remoteUsed; }
            set { _remoteUsed = value; }
        }

        /// <summary>
        ///     the value of the "SP_MERGE_LOCK" field.
        /// </summary>
        public String MergeLock
        {
            get { return _mergeLock; }
            set { _mergeLock = value; }
        }

        /// <summary>
        ///     the value of the "SP_INV_RESTRICT" field.
        /// </summary>
        public Byte? InvRestrict
        {
            get { return _invRestrict; }
            set { _invRestrict = value; }
        }

        /// <summary>
        ///     the value of the "SP_CURR_PERD" field.
        /// </summary>
        public String CurrPerd
        {
            get { return _currPerd; }
            set { _currPerd = value; }
        }

        /// <summary>
        ///     the value of the "SP_DEFAULT_ORG_ID" field.
        /// </summary>
        public String DefaultOrgId
        {
            get { return _defaultOrgId; }
            set { _defaultOrgId = value; }
        }

        /// <summary>
        ///     the value of the "SP_OPP_ACT_MAND" field.
        /// </summary>
        public Byte? OppActMand
        {
            get { return _oppActMand; }
            set { _oppActMand = value; }
        }

        /// <summary>
        ///     the value of the "SP_SMTP_SERVER" field.
        /// </summary>
        public String SmtpServer
        {
            get { return _smtpServer; }
            set { _smtpServer = value; }
        }

        /// <summary>
        ///     the value of the "SP_ADMIN_EMAIL" field.
        /// </summary>
        public String AdminEmail
        {
            get { return _adminEmail; }
            set { _adminEmail = value; }
        }

        /// <summary>
        ///     the value of the "SP_USE_AKA_FIELD" field.
        /// </summary>
        public Byte? UseAkaField
        {
            get { return _useAkaField; }
            set { _useAkaField = value; }
        }

        /// <summary>
        ///     the value of the "SP_EXPORT_NUM" field.
        /// </summary>
        public Int32? ExportNum
        {
            get { return _exportNum; }
            set { _exportNum = value; }
        }

        /// <summary>
        ///     the value of the "SP_IMPORT_NUM" field.
        /// </summary>
        public Int32? ImportNum
        {
            get { return _importNum; }
            set { _importNum = value; }
        }

        /// <summary>
        ///     the value of the "SP_EXPORT_DATE" field.
        /// </summary>
        public DateTime? ExportDate
        {
            get { return _exportDate; }
            set { _exportDate = value; }
        }

        /// <summary>
        ///     the value of the "SP_BASE_CURR" field.
        /// </summary>
        public String BaseCurr
        {
            get { return _baseCurr; }
            set { _baseCurr = value; }
        }

        /// <summary>
        ///     the value of the "SP_REG" field.
        /// </summary>
        public String Reg
        {
            get { return _reg; }
            set { _reg = value; }
        }

        /// <summary>
        ///     the value of the "SP_FILE_STORE_PATH" field.
        /// </summary>
        public String FileStorePath
        {
            get { return _fileStorePath; }
            set { _fileStorePath = value; }
        }

        /// <summary>
        ///     the value of the "SP_PIC_STORE_PATH" field.
        /// </summary>
        public String PicStorePath
        {
            get { return _picStorePath; }
            set { _picStorePath = value; }
        }

        /// <summary>
        ///     the value of the "SP_NET_PATH" field.
        /// </summary>
        public String NetPath
        {
            get { return _netPath; }
            set { _netPath = value; }
        }

        /// <summary>
        ///     the value of the "SP_BU_SECURITY" field.
        /// </summary>
        public Byte? BuSecurity
        {
            get { return _buSecurity; }
            set { _buSecurity = value; }
        }

        /// <summary>
        ///     the value of the "SP_ENQ_QST_ID" field.
        /// </summary>
        public String EnqQstId
        {
            get { return _enqQstId; }
            set { _enqQstId = value; }
        }

        /// <summary>
        ///     the value of the "SP_DEL_QST_ID" field.
        /// </summary>
        public String DelQstId
        {
            get { return _delQstId; }
            set { _delQstId = value; }
        }

        /// <summary>
        ///     the value of the "SP_BASE_CURR2" field.
        /// </summary>
        public String BaseCurr2
        {
            get { return _baseCurr2; }
            set { _baseCurr2 = value; }
        }

        /// <summary>
        ///     the value of the "SP_PROV_PACK" field.
        /// </summary>
        public String ProvPack
        {
            get { return _provPack; }
            set { _provPack = value; }
        }

        /// <summary>
        ///     the value of the "SP_CONF_PACK" field.
        /// </summary>
        public String ConfPack
        {
            get { return _confPack; }
            set { _confPack = value; }
        }

        /// <summary>
        ///     the value of the "SP_JOINING_PACK" field.
        /// </summary>
        public String JoiningPack
        {
            get { return _joiningPack; }
            set { _joiningPack = value; }
        }

        /// <summary>
        ///     the value of the "SP_POST_PACK" field.
        /// </summary>
        public String PostPack
        {
            get { return _postPack; }
            set { _postPack = value; }
        }

        /// <summary>
        ///     the value of the "SP_PROV_INV" field.
        /// </summary>
        public Byte? ProvInv
        {
            get { return _provInv; }
            set { _provInv = value; }
        }

        /// <summary>
        ///     the value of the "SP_CONF_INV" field.
        /// </summary>
        public Byte? ConfInv
        {
            get { return _confInv; }
            set { _confInv = value; }
        }

        /// <summary>
        ///     the value of the "SP_JOIN_INV" field.
        /// </summary>
        public Byte? JoinInv
        {
            get { return _joinInv; }
            set { _joinInv = value; }
        }

        /// <summary>
        ///     the value of the "SP_POST_INV" field.
        /// </summary>
        public Byte? PostInv
        {
            get { return _postInv; }
            set { _postInv = value; }
        }

        /// <summary>
        ///     the value of the "SP_PROV_NO_PLACE" field.
        /// </summary>
        public Byte? ProvNoPlace
        {
            get { return _provNoPlace; }
            set { _provNoPlace = value; }
        }

        /// <summary>
        ///     the value of the "SP_TRAINER_EMAIL" field.
        /// </summary>
        public String TrainerEmail
        {
            get { return _trainerEmail; }
            set { _trainerEmail = value; }
        }

        /// <summary>
        ///     the value of the "SP_CB_DAYS" field.
        /// </summary>
        public String CbDays
        {
            get { return _cbDays; }
            set { _cbDays = value; }
        }

        /// <summary>
        ///     the value of the "SP_PAYMENT_DAYS" field.
        /// </summary>
        public Int32? PaymentDays
        {
            get { return _paymentDays; }
            set { _paymentDays = value; }
        }

        /// <summary>
        ///     the value of the "SP_PAYMENT_TYPE" field.
        /// </summary>
        public Byte? PaymentType
        {
            get { return _paymentType; }
            set { _paymentType = value; }
        }

        /// <summary>
        ///     the value of the "SP_PAY_TERMS_1" field.
        /// </summary>
        public String PayTerms1
        {
            get { return _payTerms1; }
            set { _payTerms1 = value; }
        }

        /// <summary>
        ///     the value of the "SP_PAY_TERMS_2" field.
        /// </summary>
        public String PayTerms2
        {
            get { return _payTerms2; }
            set { _payTerms2 = value; }
        }

        /// <summary>
        ///     the value of the "SP_PAY_TERMS_3" field.
        /// </summary>
        public String PayTerms3
        {
            get { return _payTerms3; }
            set { _payTerms3 = value; }
        }

        /// <summary>
        ///     the value of the "SP_PAY_TERMS_4" field.
        /// </summary>
        public String PayTerms4
        {
            get { return _payTerms4; }
            set { _payTerms4 = value; }
        }

        /// <summary>
        ///     the value of the "SP_UPGRADE_PATH" field.
        /// </summary>
        public String UpgradePath
        {
            get { return _upgradePath; }
            set { _upgradePath = value; }
        }

        /// <summary>
        ///     the value of the "SP_TC_LETT" field.
        /// </summary>
        public String TcLett
        {
            get { return _tcLett; }
            set { _tcLett = value; }
        }

        /// <summary>
        ///     the value of the "SP_PRINTER1" field.
        /// </summary>
        public String Printer1
        {
            get { return _printer1; }
            set { _printer1 = value; }
        }

        /// <summary>
        ///     the value of the "SP_PRINTER2" field.
        /// </summary>
        public String Printer2
        {
            get { return _printer2; }
            set { _printer2 = value; }
        }

        /// <summary>
        ///     the value of the "SP_INITIALS" field.
        /// </summary>
        public String Initials
        {
            get { return _initials; }
            set { _initials = value; }
        }

        /// <summary>
        ///     the value of the "SP_CRYSTAL_INV" field.
        /// </summary>
        public String CrystalInv
        {
            get { return _crystalInv; }
            set { _crystalInv = value; }
        }

        /// <summary>
        ///     the value of the "SP_FLAG" field.
        /// </summary>
        public String Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        /// <summary>
        ///     the value of the "SP_BOOK_OTH_NODES" field.
        /// </summary>
        public Byte? BookOthNodes
        {
            get { return _bookOthNodes; }
            set { _bookOthNodes = value; }
        }

        /// <summary>
        ///     the value of the "SP_USER_NUMB_1" field.
        /// </summary>
        public Double? UserNumb1
        {
            get { return _userNumb1; }
            set { _userNumb1 = value; }
        }

        /// <summary>
        ///     the value of the "SP_VAT_METHOD" field.
        /// </summary>
        public Byte? VatMethod
        {
            get { return _vatMethod; }
            set { _vatMethod = value; }
        }

        /// <summary>
        ///     the value of the "SP_NO_LOGON" field.
        /// </summary>
        public Byte? NoLogon
        {
            get { return _noLogon; }
            set { _noLogon = value; }
        }

        /// <summary>
        ///     the value of the "SP_Q_RESULTS" field.
        /// </summary>
        public Byte? QResults
        {
            get { return _qResults; }
            set { _qResults = value; }
        }

        /// <summary>
        ///     the value of the "SP_FILE_PROD_EXT" field.
        /// </summary>
        public Byte? FileProdExt
        {
            get { return _fileProdExt; }
            set { _fileProdExt = value; }
        }

        /// <summary>
        ///     the value of the "SP_REG2" field.
        /// </summary>
        public String Reg2
        {
            get { return _reg2; }
            set { _reg2 = value; }
        }

        /// <summary>
        ///     the value of the "SP_REG3" field.
        /// </summary>
        public String Reg3
        {
            get { return _reg3; }
            set { _reg3 = value; }
        }

        /// <summary>
        ///     the value of the "SP_ELEM_FLAGS" field.
        /// </summary>
        public Byte? ElemFlags
        {
            get { return _elemFlags; }
            set { _elemFlags = value; }
        }

        /// <summary>
        ///     the value of the "SP_SELL_COMP_NAME" field.
        /// </summary>
        public String SellCompName
        {
            get { return _sellCompName; }
            set { _sellCompName = value; }
        }

        /// <summary>
        ///     the value of the "SP_BOOK_APPROVAL" field.
        /// </summary>
        public Byte? BookApproval
        {
            get { return _bookApproval; }
            set { _bookApproval = value; }
        }

        /// <summary>
        ///     the value of the "SP_BKT_ID" field.
        /// </summary>
        public String BktId
        {
            get { return _bktId; }
            set { _bktId = value; }
        }

        /// <summary>
        ///     the value of the "SP_ATTACHMENTS_URL" field.
        /// </summary>
        public String AttachmentsUrl
        {
            get { return _attachmentsUrl; }
            set { _attachmentsUrl = value; }
        }

        /// <summary>
        ///     the value of the "SP_PERIODS" field.
        /// </summary>
        public Int32 Periods
        {
            get { return _periods; }
            set { _periods = value; }
        }

        /// <summary>
        ///     the value of the "SP_BAT_SEL_PROC" field.
        /// </summary>
        public String BatSelProc
        {
            get { return _batSelProc; }
            set { _batSelProc = value; }
        }

        /// <summary>
        ///     the value of the "SP_BAT_OUT_PROC" field.
        /// </summary>
        public String BatOutProc
        {
            get { return _batOutProc; }
            set { _batOutProc = value; }
        }

        /// <summary>
        ///     the value of the "SP_BAT_OUT_DIR" field.
        /// </summary>
        public String BatOutDir
        {
            get { return _batOutDir; }
            set { _batOutDir = value; }
        }

        /// <summary>
        ///     the value of the "SP_DEF_INV_LT_ID" field.
        /// </summary>
        public String DefInvLtId
        {
            get { return _defInvLtId; }
            set { _defInvLtId = value; }
        }

        /// <summary>
        ///     the value of the "SP_MEM_INV_LT_ID" field.
        /// </summary>
        public String MemInvLtId
        {
            get { return _memInvLtId; }
            set { _memInvLtId = value; }
        }

        /// <summary>
        ///     the value of the "SP_PROJ_INV_LT_ID" field.
        /// </summary>
        public String ProjInvLtId
        {
            get { return _projInvLtId; }
            set { _projInvLtId = value; }
        }

        /// <summary>
        ///     the value of the "SP_NO_SALESTEAM" field.
        /// </summary>
        public Byte? NoSalesteam
        {
            get { return _noSalesteam; }
            set { _noSalesteam = value; }
        }

        /// <summary>
        ///     the value of the "SP_CRYSTAL_URL" field.
        /// </summary>
        public String CrystalUrl
        {
            get { return _crystalUrl; }
            set { _crystalUrl = value; }
        }

        /// <summary>
        ///     the value of the "SP_CRYSTAL_ODBC" field.
        /// </summary>
        public String CrystalOdbc
        {
            get { return _crystalOdbc; }
            set { _crystalOdbc = value; }
        }

        /// <summary>
        ///     the value of the "SP_CRYSTAL_STD_REPS" field.
        /// </summary>
        public String CrystalStdReps
        {
            get { return _crystalStdReps; }
            set { _crystalStdReps = value; }
        }

        /// <summary>
        ///     the value of the "SP_CRYSTAL_CUST_REPS" field.
        /// </summary>
        public String CrystalCustReps
        {
            get { return _crystalCustReps; }
            set { _crystalCustReps = value; }
        }

        /// <summary>
        ///     the value of the "SP_CRYSTAL_USER_REPS" field.
        /// </summary>
        public String CrystalUserReps
        {
            get { return _crystalUserReps; }
            set { _crystalUserReps = value; }
        }

        /// <summary>
        ///     the value of the "SP_INV_NO_SUFFIX" field.
        /// </summary>
        public String InvNoSuffix
        {
            get { return _invNoSuffix; }
            set { _invNoSuffix = value; }
        }

        /// <summary>
        ///     the value of the "SP_NEXT_PROFORM_NO" field.
        /// </summary>
        public Int64? NextProformNo
        {
            get { return _nextProformNo; }
            set { _nextProformNo = value; }
        }

        /// <summary>
        ///     the value of the "SP_ONLY_MEM_PRICE" field.
        /// </summary>
        public Int32? OnlyMemPrice
        {
            get { return _onlyMemPrice; }
            set { _onlyMemPrice = value; }
        }

        /// <summary>
        ///     the value of the "SP_MEMBER_ONLY_PRC" field.
        /// </summary>
        public Byte? MemberOnlyPrc
        {
            get { return _memberOnlyPrc; }
            set { _memberOnlyPrc = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_SALES_CTRL" field.
        /// </summary>
        public String GlSalesCtrl
        {
            get { return _glSalesCtrl; }
            set { _glSalesCtrl = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_VAT_CTRL" field.
        /// </summary>
        public String GlVatCtrl
        {
            get { return _glVatCtrl; }
            set { _glVatCtrl = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_BANK" field.
        /// </summary>
        public String GlBank
        {
            get { return _glBank; }
            set { _glBank = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_BANK_CHARGE" field.
        /// </summary>
        public String GlBankCharge
        {
            get { return _glBankCharge; }
            set { _glBankCharge = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_WRITEOFF" field.
        /// </summary>
        public String GlWriteoff
        {
            get { return _glWriteoff; }
            set { _glWriteoff = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_SL_ADJ" field.
        /// </summary>
        public String GlSlAdj
        {
            get { return _glSlAdj; }
            set { _glSlAdj = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_1" field.
        /// </summary>
        public String Gl1
        {
            get { return _gl1; }
            set { _gl1 = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_2" field.
        /// </summary>
        public String Gl2
        {
            get { return _gl2; }
            set { _gl2 = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_3" field.
        /// </summary>
        public String Gl3
        {
            get { return _gl3; }
            set { _gl3 = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_4" field.
        /// </summary>
        public String Gl4
        {
            get { return _gl4; }
            set { _gl4 = value; }
        }

        /// <summary>
        ///     the value of the "SP_ACCT_DESC" field.
        /// </summary>
        public String AcctDesc
        {
            get { return _acctDesc; }
            set { _acctDesc = value; }
        }

        /// <summary>
        ///     the value of the "SP_MEAL_REPORT_NUM" field.
        /// </summary>
        public Int32? MealReportNum
        {
            get { return _mealReportNum; }
            set { _mealReportNum = value; }
        }

        /// <summary>
        ///     the value of the "SP_BOOK_PREF" field.
        /// </summary>
        public Byte? BookPref
        {
            get { return _bookPref; }
            set { _bookPref = value; }
        }

        /// <summary>
        ///     the value of the "SP_DPM_BCC" field.
        /// </summary>
        public Byte? DpmBcc
        {
            get { return _dpmBcc; }
            set { _dpmBcc = value; }
        }

        /// <summary>
        ///     the value of the "SP_ADD_LINE_5" field.
        /// </summary>
        public Byte? AddLine5
        {
            get { return _addLine5; }
            set { _addLine5 = value; }
        }

        /// <summary>
        ///     the value of the "SP_SOURCE_CODE" field.
        /// </summary>
        public Byte? SourceCode
        {
            get { return _sourceCode; }
            set { _sourceCode = value; }
        }

        /// <summary>
        ///     the value of the "SP_REG_LOOKUP" field.
        /// </summary>
        public Byte? RegLookup
        {
            get { return _regLookup; }
            set { _regLookup = value; }
        }

        /// <summary>
        ///     the value of the "SP_DEFAULT_TEXT_1" field.
        /// </summary>
        public String DefaultText1
        {
            get { return _defaultText1; }
            set { _defaultText1 = value; }
        }

        /// <summary>
        ///     the value of the "SP_WSPOSTCODE_PATH" field.
        /// </summary>
        public String WspostcodePath
        {
            get { return _wspostcodePath; }
            set { _wspostcodePath = value; }
        }

        /// <summary>
        ///     the value of the "SP_DEFAULT_INT_1" field.
        /// </summary>
        public Int32? DefaultInt1
        {
            get { return _defaultInt1; }
            set { _defaultInt1 = value; }
        }

        /// <summary>
        ///     the value of the "SP_DEFAULT_USAGE_DESC" field.
        /// </summary>
        public String DefaultUsageDesc
        {
            get { return _defaultUsageDesc; }
            set { _defaultUsageDesc = value; }
        }

        /// <summary>
        ///     the value of the "SP_AUTHORISE_PAY_METHOD" field.
        /// </summary>
        public Byte? AuthorisePayMethod
        {
            get { return _authorisePayMethod; }
            set { _authorisePayMethod = value; }
        }

        /// <summary>
        ///     the value of the "SP_AUTHORISE_PAY_METHOD_PARAMS" field.
        /// </summary>
        public String AuthorisePayMethodParams
        {
            get { return _authorisePayMethodParams; }
            set { _authorisePayMethodParams = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_BANK_CC" field.
        /// </summary>
        public String GlBankCc
        {
            get { return _glBankCc; }
            set { _glBankCc = value; }
        }

        /// <summary>
        ///     the value of the "SP_GL_BANK_DC" field.
        /// </summary>
        public String GlBankDc
        {
            get { return _glBankDc; }
            set { _glBankDc = value; }
        }

        /// <summary>
        ///     the value of the "SP_AUTHENTICATION_METHOD" field.
        /// </summary>
        public Byte? AuthenticationMethod
        {
            get { return _authenticationMethod; }
            set { _authenticationMethod = value; }
        }

        /// <summary>
        ///     the value of the "SP_EC4_PROV_NO_PLACE" field.
        /// </summary>
        public Byte? Ec4ProvNoPlace
        {
            get { return _ec4ProvNoPlace; }
            set { _ec4ProvNoPlace = value; }
        }

        /// <summary>
        ///     the value of the "SP_ALT_INV_CALC" field.
        /// </summary>
        public Byte? AltInvCalc
        {
            get { return _altInvCalc; }
            set { _altInvCalc = value; }
        }

        /// <summary>
        ///     the value of the "SP_CRYSTAL_TEMPLATE_REPS" field.
        /// </summary>
        public String CrystalTemplateReps
        {
            get { return _crystalTemplateReps; }
            set { _crystalTemplateReps = value; }
        }

        /// <summary>
        ///     the value of the "SP_DEPOSIT" field.
        /// </summary>
        public Decimal? Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }
        }

        /// <summary>
        ///     the value of the "SP_INVOICE_RULE" field.
        /// </summary>
        public Byte InvoiceRule
        {
            get { return _invoiceRule; }
            set { _invoiceRule = value; }
        }

        /// <summary>
        ///     the value of the "SP_INVOICE_RULE_OFFSET" field.
        /// </summary>
        public Int16 InvoiceRuleOffset
        {
            get { return _invoiceRuleOffset; }
            set { _invoiceRuleOffset = value; }
        }

        /// <summary>
        ///     the value of the "SP_INVOICE_CONSOLIDATE" field.
        /// </summary>
        public Byte InvoiceConsolidate
        {
            get { return _invoiceConsolidate; }
            set { _invoiceConsolidate = value; }
        }

        /// <summary>
        ///     the value of the "SP_INVOICE_WHEN_STATUS" field.
        /// </summary>
        public String InvoiceWhenStatus
        {
            get { return _invoiceWhenStatus; }
            set { _invoiceWhenStatus = value; }
        }

        /// <summary>
        ///     the value of the "SP_INVOICE_FORMAT" field.
        /// </summary>
        public Byte InvoiceFormat
        {
            get { return _invoiceFormat; }
            set { _invoiceFormat = value; }
        }

        /// <summary>
        ///     the value of the "SP_INVOICE_MUST_USE_RULE" field.
        /// </summary>
        public Byte InvoiceMustUseRule
        {
            get { return _invoiceMustUseRule; }
            set { _invoiceMustUseRule = value; }
        }

        /// <summary>
        ///     the value of the "SP_INVOICE_FORMAT_0_TEXT" field.
        /// </summary>
        public String InvoiceFormat0Text
        {
            get { return _invoiceFormat0Text; }
            set { _invoiceFormat0Text = value; }
        }

        /// <summary>
        ///     the value of the "SP_INVOICE_FORMAT_1_TEXT" field.
        /// </summary>
        public String InvoiceFormat1Text
        {
            get { return _invoiceFormat1Text; }
            set { _invoiceFormat1Text = value; }
        }

        /// <summary>
        ///     the value of the "SP_INVOICE_OFFSET_TYPE" field.
        /// </summary>
        public String InvoiceOffsetType
        {
            get { return _invoiceOffsetType; }
            set { _invoiceOffsetType = value; }
        }

        /// <summary>
        ///     the value of the "SP_SHOW_ACCOUNT_BALANCE" field.
        /// </summary>
        public Byte ShowAccountBalance
        {
            get { return _showAccountBalance; }
            set { _showAccountBalance = value; }
        }

        /// <summary>
        ///     the value of the "SP_INVOICE_DO_NOT_PRINT" field.
        /// </summary>
        public Byte InvoiceDoNotPrint
        {
            get { return _invoiceDoNotPrint; }
            set { _invoiceDoNotPrint = value; }
        }

        /// <summary>
        ///     the value of the "SP_TRANSFER_STATUS" field.
        /// </summary>
        public Byte? TransferStatus
        {
            get { return _transferStatus; }
            set { _transferStatus = value; }
        }

        /// <summary>
        ///     the value of the "SP_SUBSTITUTE_STATUS" field.
        /// </summary>
        public Byte? SubstituteStatus
        {
            get { return _substituteStatus; }
            set { _substituteStatus = value; }
        }

        /// <summary>
        ///     the value of the "SP_HOME_ADD" field.
        /// </summary>
        public Byte? HomeAdd
        {
            get { return _homeAdd; }
            set { _homeAdd = value; }
        }

        /// <summary>
        ///     the value of the "SP_AUTO_TRANSFER" field.
        /// </summary>
        public Byte? AutoTransfer
        {
            get { return _autoTransfer; }
            set { _autoTransfer = value; }
        }

        /// <summary>
        ///     the value of the "SP_USE_CERT_RULES" field.
        /// </summary>
        public Byte? UseCertRules
        {
            get { return _useCertRules; }
            set { _useCertRules = value; }
        }

        /// <summary>
        ///     the value of the "SP_FINANCE_CC" field.
        /// </summary>
        public String FinanceCc
        {
            get { return _financeCc; }
            set { _financeCc = value; }
        }

        /// <summary>
        ///     the value of the "SP_NO_EV_ATT_PRINT" field.
        /// </summary>
        public Byte? NoEvAttPrint
        {
            get { return _noEvAttPrint; }
            set { _noEvAttPrint = value; }
        }

        /// <summary>
        ///     the value of the "SP_CRYSTAL_URL_2" field.
        /// </summary>
        public String CrystalUrl2
        {
            get { return _crystalUrl2; }
            set { _crystalUrl2 = value; }
        }

        /// <summary>
        ///     the value of the "SP_MAIN_ROLE_DEFAULT" field.
        /// </summary>
        public Byte? MainRoleDefault
        {
            get { return _mainRoleDefault; }
            set { _mainRoleDefault = value; }
        }

        /// <summary>
        ///     the value of the "SP_SHOW_MEM_ALL_ROLES" field.
        /// </summary>
        public Byte? ShowMemAllRoles
        {
            get { return _showMemAllRoles; }
            set { _showMemAllRoles = value; }
        }

        /// <summary>
        ///     the value of the "SP_NEAREST_VENUE" field.
        /// </summary>
        public Byte? NearestVenue
        {
            get { return _nearestVenue; }
            set { _nearestVenue = value; }
        }

        /// <summary>
        ///     the value of the "SP_NOT_CREDIT_TRAN" field.
        /// </summary>
        public Byte? NotCreditTran
        {
            get { return _notCreditTran; }
            set { _notCreditTran = value; }
        }

        /// <summary>
        ///     the value of the "SP_NOT_CREDIT_SUB" field.
        /// </summary>
        public Byte? NotCreditSub
        {
            get { return _notCreditSub; }
            set { _notCreditSub = value; }
        }

        /// <summary>
        ///     the value of the "SP_GET_UNLINKED_ACCOM" field.
        /// </summary>
        public Byte? GetUnlinkedAccom
        {
            get { return _getUnlinkedAccom; }
            set { _getUnlinkedAccom = value; }
        }

        /// <summary>
        ///     the value of the "SP_DEFAULTS" field.
        /// </summary>
        public String Defaults
        {
            get { return _defaults; }
            set { _defaults = value; }
        }

        /// <summary>
        ///     the value of the "SP_CHGPWD_DAYS" field.
        /// </summary>
        public Int32? ChgpwdDays
        {
            get { return _chgpwdDays; }
            set { _chgpwdDays = value; }
        }

        /// <summary>
        ///     the value of the "SP_PWDREM_DAYS" field.
        /// </summary>
        public Int32? PwdremDays
        {
            get { return _pwdremDays; }
            set { _pwdremDays = value; }
        }

        /// <summary>
        ///     the value of the "SP_DEF_INV_PACK_ID" field.
        /// </summary>
        public String DefInvPackId
        {
            get { return _defInvPackId; }
            set { _defInvPackId = value; }
        }

        /// <summary>
        ///     the value of the "SP_NEXT_PPINVNO" field.
        /// </summary>
        public Int32? NextPpinvno
        {
            get { return _nextPpinvno; }
            set { _nextPpinvno = value; }
        }

        /// <summary>
        ///     the value of the "SP_NEXT_PPCREDITNO" field.
        /// </summary>
        public Int32? NextPpcreditno
        {
            get { return _nextPpcreditno; }
            set { _nextPpcreditno = value; }
        }

        /// <summary>
        ///     the value of the "SP_INV_NO_PREFIX_PP" field.
        /// </summary>
        public String InvNoPrefixPp
        {
            get { return _invNoPrefixPp; }
            set { _invNoPrefixPp = value; }
        }

        /// <summary>
        ///     the value of the "SP_INV_NO_SUFFIX_PP" field.
        /// </summary>
        public String InvNoSuffixPp
        {
            get { return _invNoSuffixPp; }
            set { _invNoSuffixPp = value; }
        }

        /// <summary>
        ///     the value of the "SP_PRINCIPAL_ROLE_DEFAULT" field.
        /// </summary>
        public Byte? PrincipalRoleDefault
        {
            get { return _principalRoleDefault; }
            set { _principalRoleDefault = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SysParamsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SysParamsRecord" /> object instance.
        /// </returns>
        public SysParamsRecord Clone()
        {
            SysParamsRecord record = new SysParamsRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.SecPnId = this.SecPnId;
            record.ReoOrgId = this.ReoOrgId;
            record.Vatreg = this.Vatreg;
            record.TipsCodePrefx = this.TipsCodePrefx;
            record.InvNoPrefix = this.InvNoPrefix;
            record.NextInvNo = this.NextInvNo;
            record.NextCreditNte = this.NextCreditNte;
            record.HeadedPaper = this.HeadedPaper;
            record.Heading1 = this.Heading1;
            record.Heading = this.Heading;
            record.Footer = this.Footer;
            record.FooterReoLabl = this.FooterReoLabl;
            record.FooterPhone = this.FooterPhone;
            record.FooterGenSec = this.FooterGenSec;
            record.PicId = this.PicId;
            record.GeneralTextId = this.GeneralTextId;
            record.GenCorsTxtId = this.GenCorsTxtId;
            record.AuthSpeclInst = this.AuthSpeclInst;
            record.DbId = this.DbId;
            record.Main = this.Main;
            record.Remote = this.Remote;
            record.NxtSaleLegNo = this.NxtSaleLegNo;
            record.QuoStatus = this.QuoStatus;
            record.QuoSource = this.QuoSource;
            record.FormatActNote = this.FormatActNote;
            record.OrgSrchFilter = this.OrgSrchFilter;
            record.Mid = this.Mid;
            record.UseMatchField = this.UseMatchField;
            record.OffrPreQutPn = this.OffrPreQutPn;
            record.CurrentRelease = this.CurrentRelease;
            record.LowestRelease = this.LowestRelease;
            record.ManAutoAlloc = this.ManAutoAlloc;
            record.AddMan1ToAct = this.AddMan1ToAct;
            record.AddMan2ToAct = this.AddMan2ToAct;
            record.AddDistToAct = this.AddDistToAct;
            record.PerdRoll = this.PerdRoll;
            record.FtCanChgThrs = this.FtCanChgThrs;
            record.SdCanChgThrs = this.SdCanChgThrs;
            record.CancChrgPrcnt = this.CancChrgPrcnt;
            record.FtTranChgThr = this.FtTranChgThr;
            record.TranChgePrcnt = this.TranChgePrcnt;
            record.ExtMvChgPrcn = this.ExtMvChgPrcn;
            record.JoinLett = this.JoinLett;
            record.ConfirmLett = this.ConfirmLett;
            record.ProvLett = this.ProvLett;
            record.QuestLett = this.QuestLett;
            record.SurvLett = this.SurvLett;
            record.InvLett = this.InvLett;
            record.UpdateStrg = this.UpdateStrg;
            record.JobType = this.JobType;
            record.PreventEdit = this.PreventEdit;
            record.SubsLetter = this.SubsLetter;
            record.RemoteUsed = this.RemoteUsed;
            record.MergeLock = this.MergeLock;
            record.InvRestrict = this.InvRestrict;
            record.CurrPerd = this.CurrPerd;
            record.DefaultOrgId = this.DefaultOrgId;
            record.OppActMand = this.OppActMand;
            record.SmtpServer = this.SmtpServer;
            record.AdminEmail = this.AdminEmail;
            record.UseAkaField = this.UseAkaField;
            record.ExportNum = this.ExportNum;
            record.ImportNum = this.ImportNum;
            record.ExportDate = this.ExportDate;
            record.BaseCurr = this.BaseCurr;
            record.Reg = this.Reg;
            record.FileStorePath = this.FileStorePath;
            record.PicStorePath = this.PicStorePath;
            record.NetPath = this.NetPath;
            record.BuSecurity = this.BuSecurity;
            record.EnqQstId = this.EnqQstId;
            record.DelQstId = this.DelQstId;
            record.BaseCurr2 = this.BaseCurr2;
            record.ProvPack = this.ProvPack;
            record.ConfPack = this.ConfPack;
            record.JoiningPack = this.JoiningPack;
            record.PostPack = this.PostPack;
            record.ProvInv = this.ProvInv;
            record.ConfInv = this.ConfInv;
            record.JoinInv = this.JoinInv;
            record.PostInv = this.PostInv;
            record.ProvNoPlace = this.ProvNoPlace;
            record.TrainerEmail = this.TrainerEmail;
            record.CbDays = this.CbDays;
            record.PaymentDays = this.PaymentDays;
            record.PaymentType = this.PaymentType;
            record.PayTerms1 = this.PayTerms1;
            record.PayTerms2 = this.PayTerms2;
            record.PayTerms3 = this.PayTerms3;
            record.PayTerms4 = this.PayTerms4;
            record.UpgradePath = this.UpgradePath;
            record.TcLett = this.TcLett;
            record.Printer1 = this.Printer1;
            record.Printer2 = this.Printer2;
            record.Initials = this.Initials;
            record.CrystalInv = this.CrystalInv;
            record.Flag = this.Flag;
            record.BookOthNodes = this.BookOthNodes;
            record.UserNumb1 = this.UserNumb1;
            record.VatMethod = this.VatMethod;
            record.NoLogon = this.NoLogon;
            record.QResults = this.QResults;
            record.FileProdExt = this.FileProdExt;
            record.Reg2 = this.Reg2;
            record.Reg3 = this.Reg3;
            record.ElemFlags = this.ElemFlags;
            record.SellCompName = this.SellCompName;
            record.BookApproval = this.BookApproval;
            record.BktId = this.BktId;
            record.AttachmentsUrl = this.AttachmentsUrl;
            record.Periods = this.Periods;
            record.BatSelProc = this.BatSelProc;
            record.BatOutProc = this.BatOutProc;
            record.BatOutDir = this.BatOutDir;
            record.DefInvLtId = this.DefInvLtId;
            record.MemInvLtId = this.MemInvLtId;
            record.ProjInvLtId = this.ProjInvLtId;
            record.NoSalesteam = this.NoSalesteam;
            record.CrystalUrl = this.CrystalUrl;
            record.CrystalOdbc = this.CrystalOdbc;
            record.CrystalStdReps = this.CrystalStdReps;
            record.CrystalCustReps = this.CrystalCustReps;
            record.CrystalUserReps = this.CrystalUserReps;
            record.InvNoSuffix = this.InvNoSuffix;
            record.NextProformNo = this.NextProformNo;
            record.OnlyMemPrice = this.OnlyMemPrice;
            record.MemberOnlyPrc = this.MemberOnlyPrc;
            record.GlSalesCtrl = this.GlSalesCtrl;
            record.GlVatCtrl = this.GlVatCtrl;
            record.GlBank = this.GlBank;
            record.GlBankCharge = this.GlBankCharge;
            record.GlWriteoff = this.GlWriteoff;
            record.GlSlAdj = this.GlSlAdj;
            record.Gl1 = this.Gl1;
            record.Gl2 = this.Gl2;
            record.Gl3 = this.Gl3;
            record.Gl4 = this.Gl4;
            record.AcctDesc = this.AcctDesc;
            record.MealReportNum = this.MealReportNum;
            record.BookPref = this.BookPref;
            record.DpmBcc = this.DpmBcc;
            record.AddLine5 = this.AddLine5;
            record.SourceCode = this.SourceCode;
            record.RegLookup = this.RegLookup;
            record.DefaultText1 = this.DefaultText1;
            record.WspostcodePath = this.WspostcodePath;
            record.DefaultInt1 = this.DefaultInt1;
            record.DefaultUsageDesc = this.DefaultUsageDesc;
            record.AuthorisePayMethod = this.AuthorisePayMethod;
            record.AuthorisePayMethodParams = this.AuthorisePayMethodParams;
            record.GlBankCc = this.GlBankCc;
            record.GlBankDc = this.GlBankDc;
            record.AuthenticationMethod = this.AuthenticationMethod;
            record.Ec4ProvNoPlace = this.Ec4ProvNoPlace;
            record.AltInvCalc = this.AltInvCalc;
            record.CrystalTemplateReps = this.CrystalTemplateReps;
            record.Deposit = this.Deposit;
            record.InvoiceRule = this.InvoiceRule;
            record.InvoiceRuleOffset = this.InvoiceRuleOffset;
            record.InvoiceConsolidate = this.InvoiceConsolidate;
            record.InvoiceWhenStatus = this.InvoiceWhenStatus;
            record.InvoiceFormat = this.InvoiceFormat;
            record.InvoiceMustUseRule = this.InvoiceMustUseRule;
            record.InvoiceFormat0Text = this.InvoiceFormat0Text;
            record.InvoiceFormat1Text = this.InvoiceFormat1Text;
            record.InvoiceOffsetType = this.InvoiceOffsetType;
            record.ShowAccountBalance = this.ShowAccountBalance;
            record.InvoiceDoNotPrint = this.InvoiceDoNotPrint;
            record.TransferStatus = this.TransferStatus;
            record.SubstituteStatus = this.SubstituteStatus;
            record.HomeAdd = this.HomeAdd;
            record.AutoTransfer = this.AutoTransfer;
            record.UseCertRules = this.UseCertRules;
            record.FinanceCc = this.FinanceCc;
            record.NoEvAttPrint = this.NoEvAttPrint;
            record.CrystalUrl2 = this.CrystalUrl2;
            record.MainRoleDefault = this.MainRoleDefault;
            record.ShowMemAllRoles = this.ShowMemAllRoles;
            record.NearestVenue = this.NearestVenue;
            record.NotCreditTran = this.NotCreditTran;
            record.NotCreditSub = this.NotCreditSub;
            record.GetUnlinkedAccom = this.GetUnlinkedAccom;
            record.Defaults = this.Defaults;
            record.ChgpwdDays = this.ChgpwdDays;
            record.PwdremDays = this.PwdremDays;
            record.DefInvPackId = this.DefInvPackId;
            record.NextPpinvno = this.NextPpinvno;
            record.NextPpcreditno = this.NextPpcreditno;
            record.InvNoPrefixPp = this.InvNoPrefixPp;
            record.InvNoSuffixPp = this.InvNoSuffixPp;
            record.PrincipalRoleDefault = this.PrincipalRoleDefault;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SysParamsRecord" /> instance is equal to another <see cref="SysParamsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SysParamsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SysParamsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.SecPnId.TrimOrNullify() == that.SecPnId.TrimOrNullify());
            result = result && (this.ReoOrgId.TrimOrNullify() == that.ReoOrgId.TrimOrNullify());
            result = result && (this.Vatreg.TrimOrNullify() == that.Vatreg.TrimOrNullify());
            result = result && (this.TipsCodePrefx.TrimOrNullify() == that.TipsCodePrefx.TrimOrNullify());
            result = result && (this.InvNoPrefix.TrimOrNullify() == that.InvNoPrefix.TrimOrNullify());
            result = result && (this.NextInvNo == that.NextInvNo);
            result = result && (this.NextCreditNte == that.NextCreditNte);
            result = result && (this.HeadedPaper == that.HeadedPaper);
            result = result && (this.Heading1.TrimOrNullify() == that.Heading1.TrimOrNullify());
            result = result && (this.Heading.TrimOrNullify() == that.Heading.TrimOrNullify());
            result = result && (this.Footer.TrimOrNullify() == that.Footer.TrimOrNullify());
            result = result && (this.FooterReoLabl.TrimOrNullify() == that.FooterReoLabl.TrimOrNullify());
            result = result && (this.FooterPhone.TrimOrNullify() == that.FooterPhone.TrimOrNullify());
            result = result && (this.FooterGenSec.TrimOrNullify() == that.FooterGenSec.TrimOrNullify());
            result = result && (this.PicId.TrimOrNullify() == that.PicId.TrimOrNullify());
            result = result && (this.GeneralTextId.TrimOrNullify() == that.GeneralTextId.TrimOrNullify());
            result = result && (this.GenCorsTxtId.TrimOrNullify() == that.GenCorsTxtId.TrimOrNullify());
            result = result && (this.AuthSpeclInst.TrimOrNullify() == that.AuthSpeclInst.TrimOrNullify());
            result = result && (this.DbId.TrimOrNullify() == that.DbId.TrimOrNullify());
            result = result && (this.Main == that.Main);
            result = result && (this.Remote.TrimOrNullify() == that.Remote.TrimOrNullify());
            result = result && (this.NxtSaleLegNo == that.NxtSaleLegNo);
            result = result && (this.QuoStatus == that.QuoStatus);
            result = result && (this.QuoSource == that.QuoSource);
            result = result && (this.FormatActNote == that.FormatActNote);
            result = result && (this.OrgSrchFilter == that.OrgSrchFilter);
            result = result && (this.Mid == that.Mid);
            result = result && (this.UseMatchField == that.UseMatchField);
            result = result && (this.OffrPreQutPn == that.OffrPreQutPn);
            result = result && (this.CurrentRelease == that.CurrentRelease);
            result = result && (this.LowestRelease == that.LowestRelease);
            result = result && (this.ManAutoAlloc == that.ManAutoAlloc);
            result = result && (this.AddMan1ToAct == that.AddMan1ToAct);
            result = result && (this.AddMan2ToAct == that.AddMan2ToAct);
            result = result && (this.AddDistToAct == that.AddDistToAct);
            result = result && (this.PerdRoll.TrimOrNullify() == that.PerdRoll.TrimOrNullify());
            result = result && (this.FtCanChgThrs == that.FtCanChgThrs);
            result = result && (this.SdCanChgThrs == that.SdCanChgThrs);
            result = result && (this.CancChrgPrcnt == that.CancChrgPrcnt);
            result = result && (this.FtTranChgThr == that.FtTranChgThr);
            result = result && (this.TranChgePrcnt == that.TranChgePrcnt);
            result = result && (this.ExtMvChgPrcn == that.ExtMvChgPrcn);
            result = result && (this.JoinLett.TrimOrNullify() == that.JoinLett.TrimOrNullify());
            result = result && (this.ConfirmLett.TrimOrNullify() == that.ConfirmLett.TrimOrNullify());
            result = result && (this.ProvLett.TrimOrNullify() == that.ProvLett.TrimOrNullify());
            result = result && (this.QuestLett.TrimOrNullify() == that.QuestLett.TrimOrNullify());
            result = result && (this.SurvLett.TrimOrNullify() == that.SurvLett.TrimOrNullify());
            result = result && (this.InvLett.TrimOrNullify() == that.InvLett.TrimOrNullify());
            result = result && (this.UpdateStrg == that.UpdateStrg);
            result = result && (this.JobType == that.JobType);
            result = result && (this.PreventEdit == that.PreventEdit);
            result = result && (this.SubsLetter == that.SubsLetter);
            result = result && (this.RemoteUsed == that.RemoteUsed);
            result = result && (this.MergeLock.TrimOrNullify() == that.MergeLock.TrimOrNullify());
            result = result && (this.InvRestrict == that.InvRestrict);
            result = result && (this.CurrPerd.TrimOrNullify() == that.CurrPerd.TrimOrNullify());
            result = result && (this.DefaultOrgId.TrimOrNullify() == that.DefaultOrgId.TrimOrNullify());
            result = result && (this.OppActMand == that.OppActMand);
            result = result && (this.SmtpServer.TrimOrNullify() == that.SmtpServer.TrimOrNullify());
            result = result && (this.AdminEmail.TrimOrNullify() == that.AdminEmail.TrimOrNullify());
            result = result && (this.UseAkaField == that.UseAkaField);
            result = result && (this.ExportNum == that.ExportNum);
            result = result && (this.ImportNum == that.ImportNum);
            result = result && (this.ExportDate == that.ExportDate);
            result = result && (this.BaseCurr.TrimOrNullify() == that.BaseCurr.TrimOrNullify());
            result = result && (this.Reg.TrimOrNullify() == that.Reg.TrimOrNullify());
            result = result && (this.FileStorePath.TrimOrNullify() == that.FileStorePath.TrimOrNullify());
            result = result && (this.PicStorePath.TrimOrNullify() == that.PicStorePath.TrimOrNullify());
            result = result && (this.NetPath.TrimOrNullify() == that.NetPath.TrimOrNullify());
            result = result && (this.BuSecurity == that.BuSecurity);
            result = result && (this.EnqQstId.TrimOrNullify() == that.EnqQstId.TrimOrNullify());
            result = result && (this.DelQstId.TrimOrNullify() == that.DelQstId.TrimOrNullify());
            result = result && (this.BaseCurr2.TrimOrNullify() == that.BaseCurr2.TrimOrNullify());
            result = result && (this.ProvPack.TrimOrNullify() == that.ProvPack.TrimOrNullify());
            result = result && (this.ConfPack.TrimOrNullify() == that.ConfPack.TrimOrNullify());
            result = result && (this.JoiningPack.TrimOrNullify() == that.JoiningPack.TrimOrNullify());
            result = result && (this.PostPack.TrimOrNullify() == that.PostPack.TrimOrNullify());
            result = result && (this.ProvInv == that.ProvInv);
            result = result && (this.ConfInv == that.ConfInv);
            result = result && (this.JoinInv == that.JoinInv);
            result = result && (this.PostInv == that.PostInv);
            result = result && (this.ProvNoPlace == that.ProvNoPlace);
            result = result && (this.TrainerEmail.TrimOrNullify() == that.TrainerEmail.TrimOrNullify());
            result = result && (this.CbDays.TrimOrNullify() == that.CbDays.TrimOrNullify());
            result = result && (this.PaymentDays == that.PaymentDays);
            result = result && (this.PaymentType == that.PaymentType);
            result = result && (this.PayTerms1.TrimOrNullify() == that.PayTerms1.TrimOrNullify());
            result = result && (this.PayTerms2.TrimOrNullify() == that.PayTerms2.TrimOrNullify());
            result = result && (this.PayTerms3.TrimOrNullify() == that.PayTerms3.TrimOrNullify());
            result = result && (this.PayTerms4.TrimOrNullify() == that.PayTerms4.TrimOrNullify());
            result = result && (this.UpgradePath.TrimOrNullify() == that.UpgradePath.TrimOrNullify());
            result = result && (this.TcLett.TrimOrNullify() == that.TcLett.TrimOrNullify());
            result = result && (this.Printer1.TrimOrNullify() == that.Printer1.TrimOrNullify());
            result = result && (this.Printer2.TrimOrNullify() == that.Printer2.TrimOrNullify());
            result = result && (this.Initials.TrimOrNullify() == that.Initials.TrimOrNullify());
            result = result && (this.CrystalInv.TrimOrNullify() == that.CrystalInv.TrimOrNullify());
            result = result && (this.Flag.TrimOrNullify() == that.Flag.TrimOrNullify());
            result = result && (this.BookOthNodes == that.BookOthNodes);
            result = result && (this.UserNumb1 == that.UserNumb1);
            result = result && (this.VatMethod == that.VatMethod);
            result = result && (this.NoLogon == that.NoLogon);
            result = result && (this.QResults == that.QResults);
            result = result && (this.FileProdExt == that.FileProdExt);
            result = result && (this.Reg2.TrimOrNullify() == that.Reg2.TrimOrNullify());
            result = result && (this.Reg3.TrimOrNullify() == that.Reg3.TrimOrNullify());
            result = result && (this.ElemFlags == that.ElemFlags);
            result = result && (this.SellCompName.TrimOrNullify() == that.SellCompName.TrimOrNullify());
            result = result && (this.BookApproval == that.BookApproval);
            result = result && (this.BktId.TrimOrNullify() == that.BktId.TrimOrNullify());
            result = result && (this.AttachmentsUrl.TrimOrNullify() == that.AttachmentsUrl.TrimOrNullify());
            result = result && (this.Periods == that.Periods);
            result = result && (this.BatSelProc.TrimOrNullify() == that.BatSelProc.TrimOrNullify());
            result = result && (this.BatOutProc.TrimOrNullify() == that.BatOutProc.TrimOrNullify());
            result = result && (this.BatOutDir.TrimOrNullify() == that.BatOutDir.TrimOrNullify());
            result = result && (this.DefInvLtId.TrimOrNullify() == that.DefInvLtId.TrimOrNullify());
            result = result && (this.MemInvLtId.TrimOrNullify() == that.MemInvLtId.TrimOrNullify());
            result = result && (this.ProjInvLtId.TrimOrNullify() == that.ProjInvLtId.TrimOrNullify());
            result = result && (this.NoSalesteam == that.NoSalesteam);
            result = result && (this.CrystalUrl.TrimOrNullify() == that.CrystalUrl.TrimOrNullify());
            result = result && (this.CrystalOdbc.TrimOrNullify() == that.CrystalOdbc.TrimOrNullify());
            result = result && (this.CrystalStdReps.TrimOrNullify() == that.CrystalStdReps.TrimOrNullify());
            result = result && (this.CrystalCustReps.TrimOrNullify() == that.CrystalCustReps.TrimOrNullify());
            result = result && (this.CrystalUserReps.TrimOrNullify() == that.CrystalUserReps.TrimOrNullify());
            result = result && (this.InvNoSuffix.TrimOrNullify() == that.InvNoSuffix.TrimOrNullify());
            result = result && (this.NextProformNo == that.NextProformNo);
            result = result && (this.OnlyMemPrice == that.OnlyMemPrice);
            result = result && (this.MemberOnlyPrc == that.MemberOnlyPrc);
            result = result && (this.GlSalesCtrl.TrimOrNullify() == that.GlSalesCtrl.TrimOrNullify());
            result = result && (this.GlVatCtrl.TrimOrNullify() == that.GlVatCtrl.TrimOrNullify());
            result = result && (this.GlBank.TrimOrNullify() == that.GlBank.TrimOrNullify());
            result = result && (this.GlBankCharge.TrimOrNullify() == that.GlBankCharge.TrimOrNullify());
            result = result && (this.GlWriteoff.TrimOrNullify() == that.GlWriteoff.TrimOrNullify());
            result = result && (this.GlSlAdj.TrimOrNullify() == that.GlSlAdj.TrimOrNullify());
            result = result && (this.Gl1.TrimOrNullify() == that.Gl1.TrimOrNullify());
            result = result && (this.Gl2.TrimOrNullify() == that.Gl2.TrimOrNullify());
            result = result && (this.Gl3.TrimOrNullify() == that.Gl3.TrimOrNullify());
            result = result && (this.Gl4.TrimOrNullify() == that.Gl4.TrimOrNullify());
            result = result && (this.AcctDesc.TrimOrNullify() == that.AcctDesc.TrimOrNullify());
            result = result && (this.MealReportNum == that.MealReportNum);
            result = result && (this.BookPref == that.BookPref);
            result = result && (this.DpmBcc == that.DpmBcc);
            result = result && (this.AddLine5 == that.AddLine5);
            result = result && (this.SourceCode == that.SourceCode);
            result = result && (this.RegLookup == that.RegLookup);
            result = result && (this.DefaultText1.TrimOrNullify() == that.DefaultText1.TrimOrNullify());
            result = result && (this.WspostcodePath.TrimOrNullify() == that.WspostcodePath.TrimOrNullify());
            result = result && (this.DefaultInt1 == that.DefaultInt1);
            result = result && (this.DefaultUsageDesc.TrimOrNullify() == that.DefaultUsageDesc.TrimOrNullify());
            result = result && (this.AuthorisePayMethod == that.AuthorisePayMethod);
            result = result && (this.AuthorisePayMethodParams.TrimOrNullify() == that.AuthorisePayMethodParams.TrimOrNullify());
            result = result && (this.GlBankCc.TrimOrNullify() == that.GlBankCc.TrimOrNullify());
            result = result && (this.GlBankDc.TrimOrNullify() == that.GlBankDc.TrimOrNullify());
            result = result && (this.AuthenticationMethod == that.AuthenticationMethod);
            result = result && (this.Ec4ProvNoPlace == that.Ec4ProvNoPlace);
            result = result && (this.AltInvCalc == that.AltInvCalc);
            result = result && (this.CrystalTemplateReps.TrimOrNullify() == that.CrystalTemplateReps.TrimOrNullify());
            result = result && (this.Deposit == that.Deposit);
            result = result && (this.InvoiceRule == that.InvoiceRule);
            result = result && (this.InvoiceRuleOffset == that.InvoiceRuleOffset);
            result = result && (this.InvoiceConsolidate == that.InvoiceConsolidate);
            result = result && (this.InvoiceWhenStatus.TrimOrNullify() == that.InvoiceWhenStatus.TrimOrNullify());
            result = result && (this.InvoiceFormat == that.InvoiceFormat);
            result = result && (this.InvoiceMustUseRule == that.InvoiceMustUseRule);
            result = result && (this.InvoiceFormat0Text.TrimOrNullify() == that.InvoiceFormat0Text.TrimOrNullify());
            result = result && (this.InvoiceFormat1Text.TrimOrNullify() == that.InvoiceFormat1Text.TrimOrNullify());
            result = result && (this.InvoiceOffsetType.TrimOrNullify() == that.InvoiceOffsetType.TrimOrNullify());
            result = result && (this.ShowAccountBalance == that.ShowAccountBalance);
            result = result && (this.InvoiceDoNotPrint == that.InvoiceDoNotPrint);
            result = result && (this.TransferStatus == that.TransferStatus);
            result = result && (this.SubstituteStatus == that.SubstituteStatus);
            result = result && (this.HomeAdd == that.HomeAdd);
            result = result && (this.AutoTransfer == that.AutoTransfer);
            result = result && (this.UseCertRules == that.UseCertRules);
            result = result && (this.FinanceCc.TrimOrNullify() == that.FinanceCc.TrimOrNullify());
            result = result && (this.NoEvAttPrint == that.NoEvAttPrint);
            result = result && (this.CrystalUrl2.TrimOrNullify() == that.CrystalUrl2.TrimOrNullify());
            result = result && (this.MainRoleDefault == that.MainRoleDefault);
            result = result && (this.ShowMemAllRoles == that.ShowMemAllRoles);
            result = result && (this.NearestVenue == that.NearestVenue);
            result = result && (this.NotCreditTran == that.NotCreditTran);
            result = result && (this.NotCreditSub == that.NotCreditSub);
            result = result && (this.GetUnlinkedAccom == that.GetUnlinkedAccom);
            result = result && (this.Defaults.TrimOrNullify() == that.Defaults.TrimOrNullify());
            result = result && (this.ChgpwdDays == that.ChgpwdDays);
            result = result && (this.PwdremDays == that.PwdremDays);
            result = result && (this.DefInvPackId.TrimOrNullify() == that.DefInvPackId.TrimOrNullify());
            result = result && (this.NextPpinvno == that.NextPpinvno);
            result = result && (this.NextPpcreditno == that.NextPpcreditno);
            result = result && (this.InvNoPrefixPp.TrimOrNullify() == that.InvNoPrefixPp.TrimOrNullify());
            result = result && (this.InvNoSuffixPp.TrimOrNullify() == that.InvNoSuffixPp.TrimOrNullify());
            result = result && (this.PrincipalRoleDefault == that.PrincipalRoleDefault);
            return result;
        }

        #endregion
    }
}
