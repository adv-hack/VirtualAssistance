using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Organisation" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class OrganisationRecord : Record<String>, Cloneable<OrganisationRecord>, IEquatable<OrganisationRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ORG_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "ORG_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ORG_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ORG_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ORG_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ORG_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ORG_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ORG_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "ORG_SHORTNAME" field.
        /// </summary>
        private String _shortname;

        /// <summary>
        ///     the value of the "ORG_HIERARCHY" field.
        /// </summary>
        private String _hierarchy;

        /// <summary>
        ///     the value of the "ORG_PHONE" field.
        /// </summary>
        private String _phone;

        /// <summary>
        ///     the value of the "ORG_FAX" field.
        /// </summary>
        private String _fax;

        /// <summary>
        ///     the value of the "ORG_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "ORG_HIERARCHY_LEVL" field.
        /// </summary>
        private Byte? _hierarchyLevl;

        /// <summary>
        ///     the value of the "ORG_HIERARCHY_LAST" field.
        /// </summary>
        private Double? _hierarchyLast;

        /// <summary>
        ///     the value of the "ORG_NO_EMPLOYEE" field.
        /// </summary>
        private Double? _noEmployee;

        /// <summary>
        ///     the value of the "ORG_NO_TUCMEMBER" field.
        /// </summary>
        private Double? _noTucmember;

        /// <summary>
        ///     the value of the "ORG_TUC_PERCENT" field.
        /// </summary>
        private Double? _tucPercent;

        /// <summary>
        ///     the value of the "ORG_DAILY_HRS" field.
        /// </summary>
        private Double? _dailyHrs;

        /// <summary>
        ///     the value of the "ORG_BLOCKRATE_NO" field.
        /// </summary>
        private Double? _blockrateNo;

        /// <summary>
        ///     the value of the "ORG_TUC_REGION" field.
        /// </summary>
        private String _tucRegion;

        /// <summary>
        ///     the value of the "ORG_MAJOR_UNION" field.
        /// </summary>
        private Byte? _majorUnion;

        /// <summary>
        ///     the value of the "ORG_STUDENT_AUTH" field.
        /// </summary>
        private Byte? _studentAuth;

        /// <summary>
        ///     the value of the "ORG_UNION_REPORT" field.
        /// </summary>
        private Byte? _unionReport;

        /// <summary>
        ///     the value of the "ORG_BLOCKRATE_FLAG" field.
        /// </summary>
        private Byte? _blockrateFlag;

        /// <summary>
        ///     the value of the "ORG_DONOTMAIL" field.
        /// </summary>
        private Byte? _donotmail;

        /// <summary>
        ///     the value of the "ORG_DISTRIBUTOR" field.
        /// </summary>
        private Byte? _distributor;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_5" field.
        /// </summary>
        private String _userchar5;

        /// <summary>
        ///     the value of the "ORG_INDUSTRY" field.
        /// </summary>
        private String _industry;

        /// <summary>
        ///     the value of the "ORG_AREA" field.
        /// </summary>
        private String _area;

        /// <summary>
        ///     the value of the "ORG_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "ORG_SPECIAL_DEAL" field.
        /// </summary>
        private String _specialDeal;

        /// <summary>
        ///     the value of the "ORG_ORGCHART" field.
        /// </summary>
        private String _orgchart;

        /// <summary>
        ///     the value of the "ORG_SOURCE" field.
        /// </summary>
        private String _source;

        /// <summary>
        ///     the value of the "ORG_VAT_REF" field.
        /// </summary>
        private String _vatRef;

        /// <summary>
        ///     the value of the "ORG_DISCOUNT" field.
        /// </summary>
        private String _discount;

        /// <summary>
        ///     the value of the "ORG_SOUNDEX_KEY" field.
        /// </summary>
        private String _soundexKey;

        /// <summary>
        ///     the value of the "ORG_NORM_START" field.
        /// </summary>
        private DateTime? _normStart;

        /// <summary>
        ///     the value of the "ORG_NORM_FINISH" field.
        /// </summary>
        private DateTime? _normFinish;

        /// <summary>
        ///     the value of the "ORG_SALES_REVENUE" field.
        /// </summary>
        private Int32? _salesRevenue;

        /// <summary>
        ///     the value of the "ORG_TURNOVER" field.
        /// </summary>
        private Decimal? _turnover;

        /// <summary>
        ///     the value of the "ORG_SALES_POT" field.
        /// </summary>
        private Int32? _salesPot;

        /// <summary>
        ///     the value of the "ORG_EMPLOYEES" field.
        /// </summary>
        private Int32? _employees;

        /// <summary>
        ///     the value of the "ORG_ATTRACTIVE" field.
        /// </summary>
        private String _attractive;

        /// <summary>
        ///     the value of the "ORG_POTENTIAL" field.
        /// </summary>
        private String _potential;

        /// <summary>
        ///     the value of the "ORG_SALES_REV_BC" field.
        /// </summary>
        private Double? _salesRevBc;

        /// <summary>
        ///     the value of the "ORG_TURNOVER_BC" field.
        /// </summary>
        private Int32? _turnoverBc;

        /// <summary>
        ///     the value of the "ORG_SALES_POT_BC" field.
        /// </summary>
        private Int32? _salesPotBc;

        /// <summary>
        ///     the value of the "ORG_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "ORG_CUSTOMER_ACC" field.
        /// </summary>
        private String _customerAcc;

        /// <summary>
        ///     the value of the "ORG_GROUP_ACC" field.
        /// </summary>
        private String _groupAcc;

        /// <summary>
        ///     the value of the "ORG_DEPOSIT_ACC" field.
        /// </summary>
        private String _depositAcc;

        /// <summary>
        ///     the value of the "ORG_EXEC_CODE" field.
        /// </summary>
        private String _execCode;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "ORG_USERNUM_1" field.
        /// </summary>
        private Decimal? _usernum1;

        /// <summary>
        ///     the value of the "ORG_USERNUM_2" field.
        /// </summary>
        private Decimal? _usernum2;

        /// <summary>
        ///     the value of the "ORG_USERNUM_3" field.
        /// </summary>
        private Decimal? _usernum3;

        /// <summary>
        ///     the value of the "ORG_USERNUM_4" field.
        /// </summary>
        private Decimal? _usernum4;

        /// <summary>
        ///     the value of the "ORG_ACCMGR1_ID" field.
        /// </summary>
        private String _accmgr1Id;

        /// <summary>
        ///     the value of the "ORG_ACCMGR2_ID" field.
        /// </summary>
        private String _accmgr2Id;

        /// <summary>
        ///     the value of the "ORG_STRATEGIC_ACC" field.
        /// </summary>
        private Byte? _strategicAcc;

        /// <summary>
        ///     the value of the "ORG_PIC_ID" field.
        /// </summary>
        private String _picId;

        /// <summary>
        ///     the value of the "ORG_PARENT" field.
        /// </summary>
        private String _parent;

        /// <summary>
        ///     the value of the "ORG_LIST_ID" field.
        /// </summary>
        private String _listId;

        /// <summary>
        ///     the value of the "ORG_SPECIAL_TERMS" field.
        /// </summary>
        private String _specialTerms;

        /// <summary>
        ///     the value of the "ORG_AKA" field.
        /// </summary>
        private String _aka;

        /// <summary>
        ///     the value of the "ORG_HOLD1" field.
        /// </summary>
        private Byte? _hold1;

        /// <summary>
        ///     the value of the "ORG_HOLD2" field.
        /// </summary>
        private Byte? _hold2;

        /// <summary>
        ///     the value of the "ORG_URL" field.
        /// </summary>
        private String _url;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_6" field.
        /// </summary>
        private String _userchar6;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_7" field.
        /// </summary>
        private String _userchar7;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_8" field.
        /// </summary>
        private String _userchar8;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_9" field.
        /// </summary>
        private String _userchar9;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_10" field.
        /// </summary>
        private String _userchar10;

        /// <summary>
        ///     the value of the "ORG_COMMENTS" field.
        /// </summary>
        private String _comments;

        /// <summary>
        ///     the value of the "ORG_RANK" field.
        /// </summary>
        private String _rank;

        /// <summary>
        ///     the value of the "ORG_MATCH_KEY" field.
        /// </summary>
        private String _matchKey;

        /// <summary>
        ///     the value of the "ORG_TERR1_ID" field.
        /// </summary>
        private String _terr1Id;

        /// <summary>
        ///     the value of the "ORG_TERR2_ID" field.
        /// </summary>
        private String _terr2Id;

        /// <summary>
        ///     the value of the "ORG_TERR3_ID" field.
        /// </summary>
        private String _terr3Id;

        /// <summary>
        ///     the value of the "ORG_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "ORG_USERDATE_1" field.
        /// </summary>
        private DateTime? _userdate1;

        /// <summary>
        ///     the value of the "ORG_USERDATE_2" field.
        /// </summary>
        private DateTime? _userdate2;

        /// <summary>
        ///     the value of the "ORG_CURRENCY" field.
        /// </summary>
        private String _currency;

        /// <summary>
        ///     the value of the "ORG_PAYMENT_DAYS" field.
        /// </summary>
        private Int32? _paymentDays;

        /// <summary>
        ///     the value of the "ORG_PAYMENT_TYPE" field.
        /// </summary>
        private Byte? _paymentType;

        /// <summary>
        ///     the value of the "ORG_PAY_TERMS_1" field.
        /// </summary>
        private String _payTerms1;

        /// <summary>
        ///     the value of the "ORG_PAY_TERMS_2" field.
        /// </summary>
        private String _payTerms2;

        /// <summary>
        ///     the value of the "ORG_PAY_TERMS_3" field.
        /// </summary>
        private String _payTerms3;

        /// <summary>
        ///     the value of the "ORG_PAY_TERMS_4" field.
        /// </summary>
        private String _payTerms4;

        /// <summary>
        ///     the value of the "ORG_CREDIT_CURR" field.
        /// </summary>
        private String _creditCurr;

        /// <summary>
        ///     the value of the "ORG_CREDIT" field.
        /// </summary>
        private Double? _credit;

        /// <summary>
        ///     the value of the "ORG_CREDIT_BC" field.
        /// </summary>
        private Double? _creditBc;

        /// <summary>
        ///     the value of the "ORG_CREDIT_BC2" field.
        /// </summary>
        private Double? _creditBc2;

        /// <summary>
        ///     the value of the "ORG_EXIST_CLIENT" field.
        /// </summary>
        private Byte? _existClient;

        /// <summary>
        ///     the value of the "ORG_SIC1" field.
        /// </summary>
        private String _sic1;

        /// <summary>
        ///     the value of the "ORG_SIC2" field.
        /// </summary>
        private String _sic2;

        /// <summary>
        ///     the value of the "ORG_SIC3" field.
        /// </summary>
        private String _sic3;

        /// <summary>
        ///     the value of the "ORG_SIC4" field.
        /// </summary>
        private String _sic4;

        /// <summary>
        ///     the value of the "ORG_DUNS" field.
        /// </summary>
        private String _duns;

        /// <summary>
        ///     the value of the "ORG_STD_CODE" field.
        /// </summary>
        private String _stdCode;

        /// <summary>
        ///     the value of the "ORG_SECURITY" field.
        /// </summary>
        private String _security;

        /// <summary>
        ///     the value of the "ORG_FLAG_1" field.
        /// </summary>
        private Byte? _flag1;

        /// <summary>
        ///     the value of the "ORG_ACC_STATUS" field.
        /// </summary>
        private String _accStatus;

        /// <summary>
        ///     the value of the "ORG_ALT_NAME_1" field.
        /// </summary>
        private String _altName1;

        /// <summary>
        ///     the value of the "ORG_ALT_NAME_2" field.
        /// </summary>
        private String _altName2;

        /// <summary>
        ///     the value of the "ORG_BKT_ID" field.
        /// </summary>
        private String _bktId;

        /// <summary>
        ///     the value of the "ORG_PL_ID" field.
        /// </summary>
        private String _plId;

        /// <summary>
        ///     the value of the "ORG_VAT_CODE" field.
        /// </summary>
        private String _vatCode;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_11" field.
        /// </summary>
        private String _userchar11;

        /// <summary>
        ///     the value of the "ORG_EMAIL" field.
        /// </summary>
        private String _email;

        /// <summary>
        ///     the value of the "ORG_SOURCE_PM_ID" field.
        /// </summary>
        private String _sourcePmId;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_12" field.
        /// </summary>
        private String _userchar12;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_13" field.
        /// </summary>
        private String _userchar13;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_14" field.
        /// </summary>
        private String _userchar14;

        /// <summary>
        ///     the value of the "ORG_USERCHAR_15" field.
        /// </summary>
        private String _userchar15;

        /// <summary>
        ///     the value of the "ORG_USERDATE_3" field.
        /// </summary>
        private DateTime? _userdate3;

        /// <summary>
        ///     the value of the "ORG_USERDATE_4" field.
        /// </summary>
        private DateTime? _userdate4;

        /// <summary>
        ///     the value of the "ORG_USERDATE_5" field.
        /// </summary>
        private DateTime? _userdate5;

        /// <summary>
        ///     the value of the "ORG_USERNUM_5" field.
        /// </summary>
        private Decimal? _usernum5;

        /// <summary>
        ///     the value of the "ORG_USERNUM_6" field.
        /// </summary>
        private Decimal? _usernum6;

        /// <summary>
        ///     the value of the "ORG_USERNUM_7" field.
        /// </summary>
        private Single? _usernum7;

        /// <summary>
        ///     the value of the "ORG_USERNUM_8" field.
        /// </summary>
        private Single? _usernum8;

        /// <summary>
        ///     the value of the "ORG_USERINT_1" field.
        /// </summary>
        private Int32? _userint1;

        /// <summary>
        ///     the value of the "ORG_USERINT_2" field.
        /// </summary>
        private Int32? _userint2;

        /// <summary>
        ///     the value of the "ORG_USERINT_3" field.
        /// </summary>
        private Int32? _userint3;

        /// <summary>
        ///     the value of the "ORG_USERINT_4" field.
        /// </summary>
        private Int32? _userint4;

        /// <summary>
        ///     the value of the "ORG_USERINT_5" field.
        /// </summary>
        private Int32? _userint5;

        /// <summary>
        ///     the value of the "ORG_MEM_C_TOT" field.
        /// </summary>
        private Double? _memCTot;

        /// <summary>
        ///     the value of the "ORG_MEM_R_TOT" field.
        /// </summary>
        private Double? _memRTot;

        /// <summary>
        ///     the value of the "ORG_MEM_L_TOT" field.
        /// </summary>
        private Double? _memLTot;

        /// <summary>
        ///     the value of the "ORG_DONOTFAX" field.
        /// </summary>
        private Byte? _donotfax;

        /// <summary>
        ///     the value of the "ORG_VATCD" field.
        /// </summary>
        private String _vatcd;

        /// <summary>
        ///     the value of the "ORG_CUST_STATUS" field.
        /// </summary>
        private String _custStatus;

        /// <summary>
        ///     the value of the "ORG_DISABLED" field.
        /// </summary>
        private Byte? _disabled;

        /// <summary>
        ///     the value of the "ORG_USERINT_6" field.
        /// </summary>
        private Byte? _userint6;

        /// <summary>
        ///     the value of the "ORG_USERDATE_6" field.
        /// </summary>
        private DateTime? _userdate6;

        /// <summary>
        ///     the value of the "ORG_OUR_ORG" field.
        /// </summary>
        private Byte? _ourOrg;

        /// <summary>
        ///     the value of the "ORG_EXT_KEY" field.
        /// </summary>
        private String _extKey;

        /// <summary>
        ///     the value of the "ORG_ATTRIB_CHAR_01" field.
        /// </summary>
        private String _attribChar01;

        /// <summary>
        ///     the value of the "ORG_ATTRIB_CHAR_02" field.
        /// </summary>
        private String _attribChar02;

        /// <summary>
        ///     the value of the "ORG_ATTRIB_CHAR_03" field.
        /// </summary>
        private String _attribChar03;

        /// <summary>
        ///     the value of the "ORG_ATTRIB_CHAR_04" field.
        /// </summary>
        private String _attribChar04;

        /// <summary>
        ///     the value of the "ORG_ATTRIB_CHAR_05" field.
        /// </summary>
        private String _attribChar05;

        /// <summary>
        ///     the value of the "ORG_ATTRIB_DATE_01" field.
        /// </summary>
        private DateTime? _attribDate01;

        /// <summary>
        ///     the value of the "ORG_TYPE_SUB" field.
        /// </summary>
        private String _typeSub;

        /// <summary>
        ///     the value of the "ORG_PHONE_STD" field.
        /// </summary>
        private String _phoneStd;

        /// <summary>
        ///     the value of the "ORG_FAX_STD" field.
        /// </summary>
        private String _faxStd;

        /// <summary>
        ///     the value of the "ORG_IMM_DUNS" field.
        /// </summary>
        private String _immDuns;

        /// <summary>
        ///     the value of the "ORG_IMM_NAME" field.
        /// </summary>
        private String _immName;

        /// <summary>
        ///     the value of the "ORG_HQ_DUNS" field.
        /// </summary>
        private String _hqDuns;

        /// <summary>
        ///     the value of the "ORG_HQ_NAME" field.
        /// </summary>
        private String _hqName;

        /// <summary>
        ///     the value of the "ORG_ULTUK_DUNS" field.
        /// </summary>
        private String _ultukDuns;

        /// <summary>
        ///     the value of the "ORG_ULTUK_NAME" field.
        /// </summary>
        private String _ultukName;

        /// <summary>
        ///     the value of the "ORG_ULT_DUNS" field.
        /// </summary>
        private String _ultDuns;

        /// <summary>
        ///     the value of the "ORG_ULT_NAME" field.
        /// </summary>
        private String _ultName;

        /// <summary>
        ///     the value of the "ORG_MEM_A_TOT" field.
        /// </summary>
        private Double? _memATot;

        /// <summary>
        ///     the value of the "ORG_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "ORG_AREA2" field.
        /// </summary>
        private String _area2;

        /// <summary>
        ///     the value of the "ORG_REGION2" field.
        /// </summary>
        private String _region2;

        /// <summary>
        ///     the value of the "ORG_SECTYPE_ID" field.
        /// </summary>
        private Int32? _sectypeId;

        /// <summary>
        ///     the value of the "org_sub_region" field.
        /// </summary>
        private String _orgSubRegion;

        /// <summary>
        ///     the value of the "ORG_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "ORG_OS_ID" field.
        /// </summary>
        private Int32? _osId;

        /// <summary>
        ///     the value of the "ORG_CONFIRMATION" field.
        /// </summary>
        private Byte? _confirmation;

        /// <summary>
        ///     the value of the "ORG_JI" field.
        /// </summary>
        private Byte? _ji;

        /// <summary>
        ///     the value of the "ORG_UNIQUE_REF" field.
        /// </summary>
        private String _uniqueRef;

        /// <summary>
        ///     the value of the "ORG_REF" field.
        /// </summary>
        private String _ref;

        /// <summary>
        ///     the value of the "ORG_REF_PASSWORD" field.
        /// </summary>
        private String _refPassword;

        /// <summary>
        ///     the value of the "ORG_VALID_DOMAIN_SUFFIX" field.
        /// </summary>
        private String _validDomainSuffix;

        /// <summary>
        ///     the value of the "ORG_SUPP_BKT_ID" field.
        /// </summary>
        private String _suppBktId;

        /// <summary>
        ///     the value of the "ORG_DO_NOT_SPARE1" field.
        /// </summary>
        private Byte? _doNotSpare1;

        /// <summary>
        ///     the value of the "ORG_DO_NOT_SPARE2" field.
        /// </summary>
        private Byte? _doNotSpare2;

        /// <summary>
        ///     the value of the "ORG_DO_NOT_SPARE3" field.
        /// </summary>
        private Byte? _doNotSpare3;

        /// <summary>
        ///     the value of the "ORG_DO_NOT_SPARE4" field.
        /// </summary>
        private Byte? _doNotSpare4;

        /// <summary>
        ///     the value of the "ORG_VAT_REG_NUM" field.
        /// </summary>
        private String _vatRegNum;

        /// <summary>
        ///     the value of the "ORG_REPORT_PASSWORD" field.
        /// </summary>
        private String _reportPassword;

        /// <summary>
        ///     the value of the "ORG_REPORT_PATH" field.
        /// </summary>
        private String _reportPath;

        /// <summary>
        ///     the value of the "ORG_REPORT_USERNAME" field.
        /// </summary>
        private String _reportUsername;

        /// <summary>
        ///     the value of the "ORG_INV_AUTH_PASSWORD" field.
        /// </summary>
        private String _invAuthPassword;

        /// <summary>
        ///     the value of the "ORG_WEB_ENABLED" field.
        /// </summary>
        private Byte _webEnabled;

        /// <summary>
        ///     the value of the "ORG_PERSON_COUNT" field.
        /// </summary>
        private Int32 _personCount;

        /// <summary>
        ///     the value of the "ORG_SPEND" field.
        /// </summary>
        private Decimal? _spend;

        /// <summary>
        ///     the value of the "ORG_ON_HOLD" field.
        /// </summary>
        private Byte _onHold;

        /// <summary>
        ///     the value of the "ORG_PSH_ID" field.
        /// </summary>
        private Int32? _pshId;

        /// <summary>
        ///     the value of the "ORG_PORTAL_CONFIRMATION" field.
        /// </summary>
        private String _portalConfirmation;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ORG_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ORG_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ORG_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ORG_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ORG_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ORG_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SHORTNAME" field.
        /// </summary>
        public String Shortname
        {
            get { return _shortname; }
            set { _shortname = value; }
        }

        /// <summary>
        ///     the value of the "ORG_HIERARCHY" field.
        /// </summary>
        public String Hierarchy
        {
            get { return _hierarchy; }
            set { _hierarchy = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PHONE" field.
        /// </summary>
        public String Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        /// <summary>
        ///     the value of the "ORG_FAX" field.
        /// </summary>
        public String Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        /// <summary>
        ///     the value of the "ORG_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "ORG_HIERARCHY_LEVL" field.
        /// </summary>
        public Byte? HierarchyLevl
        {
            get { return _hierarchyLevl; }
            set { _hierarchyLevl = value; }
        }

        /// <summary>
        ///     the value of the "ORG_HIERARCHY_LAST" field.
        /// </summary>
        public Double? HierarchyLast
        {
            get { return _hierarchyLast; }
            set { _hierarchyLast = value; }
        }

        /// <summary>
        ///     the value of the "ORG_NO_EMPLOYEE" field.
        /// </summary>
        public Double? NoEmployee
        {
            get { return _noEmployee; }
            set { _noEmployee = value; }
        }

        /// <summary>
        ///     the value of the "ORG_NO_TUCMEMBER" field.
        /// </summary>
        public Double? NoTucmember
        {
            get { return _noTucmember; }
            set { _noTucmember = value; }
        }

        /// <summary>
        ///     the value of the "ORG_TUC_PERCENT" field.
        /// </summary>
        public Double? TucPercent
        {
            get { return _tucPercent; }
            set { _tucPercent = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DAILY_HRS" field.
        /// </summary>
        public Double? DailyHrs
        {
            get { return _dailyHrs; }
            set { _dailyHrs = value; }
        }

        /// <summary>
        ///     the value of the "ORG_BLOCKRATE_NO" field.
        /// </summary>
        public Double? BlockrateNo
        {
            get { return _blockrateNo; }
            set { _blockrateNo = value; }
        }

        /// <summary>
        ///     the value of the "ORG_TUC_REGION" field.
        /// </summary>
        public String TucRegion
        {
            get { return _tucRegion; }
            set { _tucRegion = value; }
        }

        /// <summary>
        ///     the value of the "ORG_MAJOR_UNION" field.
        /// </summary>
        public Byte? MajorUnion
        {
            get { return _majorUnion; }
            set { _majorUnion = value; }
        }

        /// <summary>
        ///     the value of the "ORG_STUDENT_AUTH" field.
        /// </summary>
        public Byte? StudentAuth
        {
            get { return _studentAuth; }
            set { _studentAuth = value; }
        }

        /// <summary>
        ///     the value of the "ORG_UNION_REPORT" field.
        /// </summary>
        public Byte? UnionReport
        {
            get { return _unionReport; }
            set { _unionReport = value; }
        }

        /// <summary>
        ///     the value of the "ORG_BLOCKRATE_FLAG" field.
        /// </summary>
        public Byte? BlockrateFlag
        {
            get { return _blockrateFlag; }
            set { _blockrateFlag = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DONOTMAIL" field.
        /// </summary>
        public Byte? Donotmail
        {
            get { return _donotmail; }
            set { _donotmail = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DISTRIBUTOR" field.
        /// </summary>
        public Byte? Distributor
        {
            get { return _distributor; }
            set { _distributor = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return _userchar5; }
            set { _userchar5 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_INDUSTRY" field.
        /// </summary>
        public String Industry
        {
            get { return _industry; }
            set { _industry = value; }
        }

        /// <summary>
        ///     the value of the "ORG_AREA" field.
        /// </summary>
        public String Area
        {
            get { return _area; }
            set { _area = value; }
        }

        /// <summary>
        ///     the value of the "ORG_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SPECIAL_DEAL" field.
        /// </summary>
        public String SpecialDeal
        {
            get { return _specialDeal; }
            set { _specialDeal = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ORGCHART" field.
        /// </summary>
        public String Orgchart
        {
            get { return _orgchart; }
            set { _orgchart = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SOURCE" field.
        /// </summary>
        public String Source
        {
            get { return _source; }
            set { _source = value; }
        }

        /// <summary>
        ///     the value of the "ORG_VAT_REF" field.
        /// </summary>
        public String VatRef
        {
            get { return _vatRef; }
            set { _vatRef = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DISCOUNT" field.
        /// </summary>
        public String Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SOUNDEX_KEY" field.
        /// </summary>
        public String SoundexKey
        {
            get { return _soundexKey; }
            set { _soundexKey = value; }
        }

        /// <summary>
        ///     the value of the "ORG_NORM_START" field.
        /// </summary>
        public DateTime? NormStart
        {
            get { return _normStart; }
            set { _normStart = value; }
        }

        /// <summary>
        ///     the value of the "ORG_NORM_FINISH" field.
        /// </summary>
        public DateTime? NormFinish
        {
            get { return _normFinish; }
            set { _normFinish = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SALES_REVENUE" field.
        /// </summary>
        public Int32? SalesRevenue
        {
            get { return _salesRevenue; }
            set { _salesRevenue = value; }
        }

        /// <summary>
        ///     the value of the "ORG_TURNOVER" field.
        /// </summary>
        public Decimal? Turnover
        {
            get { return _turnover; }
            set { _turnover = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SALES_POT" field.
        /// </summary>
        public Int32? SalesPot
        {
            get { return _salesPot; }
            set { _salesPot = value; }
        }

        /// <summary>
        ///     the value of the "ORG_EMPLOYEES" field.
        /// </summary>
        public Int32? Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ATTRACTIVE" field.
        /// </summary>
        public String Attractive
        {
            get { return _attractive; }
            set { _attractive = value; }
        }

        /// <summary>
        ///     the value of the "ORG_POTENTIAL" field.
        /// </summary>
        public String Potential
        {
            get { return _potential; }
            set { _potential = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SALES_REV_BC" field.
        /// </summary>
        public Double? SalesRevBc
        {
            get { return _salesRevBc; }
            set { _salesRevBc = value; }
        }

        /// <summary>
        ///     the value of the "ORG_TURNOVER_BC" field.
        /// </summary>
        public Int32? TurnoverBc
        {
            get { return _turnoverBc; }
            set { _turnoverBc = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SALES_POT_BC" field.
        /// </summary>
        public Int32? SalesPotBc
        {
            get { return _salesPotBc; }
            set { _salesPotBc = value; }
        }

        /// <summary>
        ///     the value of the "ORG_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "ORG_CUSTOMER_ACC" field.
        /// </summary>
        public String CustomerAcc
        {
            get { return _customerAcc; }
            set { _customerAcc = value; }
        }

        /// <summary>
        ///     the value of the "ORG_GROUP_ACC" field.
        /// </summary>
        public String GroupAcc
        {
            get { return _groupAcc; }
            set { _groupAcc = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DEPOSIT_ACC" field.
        /// </summary>
        public String DepositAcc
        {
            get { return _depositAcc; }
            set { _depositAcc = value; }
        }

        /// <summary>
        ///     the value of the "ORG_EXEC_CODE" field.
        /// </summary>
        public String ExecCode
        {
            get { return _execCode; }
            set { _execCode = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERNUM_1" field.
        /// </summary>
        public Decimal? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERNUM_2" field.
        /// </summary>
        public Decimal? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERNUM_3" field.
        /// </summary>
        public Decimal? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERNUM_4" field.
        /// </summary>
        public Decimal? Usernum4
        {
            get { return _usernum4; }
            set { _usernum4 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ACCMGR1_ID" field.
        /// </summary>
        public String Accmgr1Id
        {
            get { return _accmgr1Id; }
            set { _accmgr1Id = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ACCMGR2_ID" field.
        /// </summary>
        public String Accmgr2Id
        {
            get { return _accmgr2Id; }
            set { _accmgr2Id = value; }
        }

        /// <summary>
        ///     the value of the "ORG_STRATEGIC_ACC" field.
        /// </summary>
        public Byte? StrategicAcc
        {
            get { return _strategicAcc; }
            set { _strategicAcc = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PIC_ID" field.
        /// </summary>
        public String PicId
        {
            get { return _picId; }
            set { _picId = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PARENT" field.
        /// </summary>
        public String Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        /// <summary>
        ///     the value of the "ORG_LIST_ID" field.
        /// </summary>
        public String ListId
        {
            get { return _listId; }
            set { _listId = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SPECIAL_TERMS" field.
        /// </summary>
        public String SpecialTerms
        {
            get { return _specialTerms; }
            set { _specialTerms = value; }
        }

        /// <summary>
        ///     the value of the "ORG_AKA" field.
        /// </summary>
        public String Aka
        {
            get { return _aka; }
            set { _aka = value; }
        }

        /// <summary>
        ///     the value of the "ORG_HOLD1" field.
        /// </summary>
        public Byte? Hold1
        {
            get { return _hold1; }
            set { _hold1 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_HOLD2" field.
        /// </summary>
        public Byte? Hold2
        {
            get { return _hold2; }
            set { _hold2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return _userchar6; }
            set { _userchar6 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_7" field.
        /// </summary>
        public String Userchar7
        {
            get { return _userchar7; }
            set { _userchar7 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_8" field.
        /// </summary>
        public String Userchar8
        {
            get { return _userchar8; }
            set { _userchar8 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_9" field.
        /// </summary>
        public String Userchar9
        {
            get { return _userchar9; }
            set { _userchar9 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_10" field.
        /// </summary>
        public String Userchar10
        {
            get { return _userchar10; }
            set { _userchar10 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_COMMENTS" field.
        /// </summary>
        public String Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        /// <summary>
        ///     the value of the "ORG_RANK" field.
        /// </summary>
        public String Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        /// <summary>
        ///     the value of the "ORG_MATCH_KEY" field.
        /// </summary>
        public String MatchKey
        {
            get { return _matchKey; }
            set { _matchKey = value; }
        }

        /// <summary>
        ///     the value of the "ORG_TERR1_ID" field.
        /// </summary>
        public String Terr1Id
        {
            get { return _terr1Id; }
            set { _terr1Id = value; }
        }

        /// <summary>
        ///     the value of the "ORG_TERR2_ID" field.
        /// </summary>
        public String Terr2Id
        {
            get { return _terr2Id; }
            set { _terr2Id = value; }
        }

        /// <summary>
        ///     the value of the "ORG_TERR3_ID" field.
        /// </summary>
        public String Terr3Id
        {
            get { return _terr3Id; }
            set { _terr3Id = value; }
        }

        /// <summary>
        ///     the value of the "ORG_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERDATE_1" field.
        /// </summary>
        public DateTime? Userdate1
        {
            get { return _userdate1; }
            set { _userdate1 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERDATE_2" field.
        /// </summary>
        public DateTime? Userdate2
        {
            get { return _userdate2; }
            set { _userdate2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PAYMENT_DAYS" field.
        /// </summary>
        public Int32? PaymentDays
        {
            get { return _paymentDays; }
            set { _paymentDays = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PAYMENT_TYPE" field.
        /// </summary>
        public Byte? PaymentType
        {
            get { return _paymentType; }
            set { _paymentType = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PAY_TERMS_1" field.
        /// </summary>
        public String PayTerms1
        {
            get { return _payTerms1; }
            set { _payTerms1 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PAY_TERMS_2" field.
        /// </summary>
        public String PayTerms2
        {
            get { return _payTerms2; }
            set { _payTerms2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PAY_TERMS_3" field.
        /// </summary>
        public String PayTerms3
        {
            get { return _payTerms3; }
            set { _payTerms3 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PAY_TERMS_4" field.
        /// </summary>
        public String PayTerms4
        {
            get { return _payTerms4; }
            set { _payTerms4 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_CREDIT_CURR" field.
        /// </summary>
        public String CreditCurr
        {
            get { return _creditCurr; }
            set { _creditCurr = value; }
        }

        /// <summary>
        ///     the value of the "ORG_CREDIT" field.
        /// </summary>
        public Double? Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }

        /// <summary>
        ///     the value of the "ORG_CREDIT_BC" field.
        /// </summary>
        public Double? CreditBc
        {
            get { return _creditBc; }
            set { _creditBc = value; }
        }

        /// <summary>
        ///     the value of the "ORG_CREDIT_BC2" field.
        /// </summary>
        public Double? CreditBc2
        {
            get { return _creditBc2; }
            set { _creditBc2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_EXIST_CLIENT" field.
        /// </summary>
        public Byte? ExistClient
        {
            get { return _existClient; }
            set { _existClient = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SIC1" field.
        /// </summary>
        public String Sic1
        {
            get { return _sic1; }
            set { _sic1 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SIC2" field.
        /// </summary>
        public String Sic2
        {
            get { return _sic2; }
            set { _sic2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SIC3" field.
        /// </summary>
        public String Sic3
        {
            get { return _sic3; }
            set { _sic3 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SIC4" field.
        /// </summary>
        public String Sic4
        {
            get { return _sic4; }
            set { _sic4 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DUNS" field.
        /// </summary>
        public String Duns
        {
            get { return _duns; }
            set { _duns = value; }
        }

        /// <summary>
        ///     the value of the "ORG_STD_CODE" field.
        /// </summary>
        public String StdCode
        {
            get { return _stdCode; }
            set { _stdCode = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SECURITY" field.
        /// </summary>
        public String Security
        {
            get { return _security; }
            set { _security = value; }
        }

        /// <summary>
        ///     the value of the "ORG_FLAG_1" field.
        /// </summary>
        public Byte? Flag1
        {
            get { return _flag1; }
            set { _flag1 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ACC_STATUS" field.
        /// </summary>
        public String AccStatus
        {
            get { return _accStatus; }
            set { _accStatus = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ALT_NAME_1" field.
        /// </summary>
        public String AltName1
        {
            get { return _altName1; }
            set { _altName1 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ALT_NAME_2" field.
        /// </summary>
        public String AltName2
        {
            get { return _altName2; }
            set { _altName2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_BKT_ID" field.
        /// </summary>
        public String BktId
        {
            get { return _bktId; }
            set { _bktId = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PL_ID" field.
        /// </summary>
        public String PlId
        {
            get { return _plId; }
            set { _plId = value; }
        }

        /// <summary>
        ///     the value of the "ORG_VAT_CODE" field.
        /// </summary>
        public String VatCode
        {
            get { return _vatCode; }
            set { _vatCode = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_11" field.
        /// </summary>
        public String Userchar11
        {
            get { return _userchar11; }
            set { _userchar11 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_EMAIL" field.
        /// </summary>
        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SOURCE_PM_ID" field.
        /// </summary>
        public String SourcePmId
        {
            get { return _sourcePmId; }
            set { _sourcePmId = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_12" field.
        /// </summary>
        public String Userchar12
        {
            get { return _userchar12; }
            set { _userchar12 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_13" field.
        /// </summary>
        public String Userchar13
        {
            get { return _userchar13; }
            set { _userchar13 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_14" field.
        /// </summary>
        public String Userchar14
        {
            get { return _userchar14; }
            set { _userchar14 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERCHAR_15" field.
        /// </summary>
        public String Userchar15
        {
            get { return _userchar15; }
            set { _userchar15 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERDATE_3" field.
        /// </summary>
        public DateTime? Userdate3
        {
            get { return _userdate3; }
            set { _userdate3 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERDATE_4" field.
        /// </summary>
        public DateTime? Userdate4
        {
            get { return _userdate4; }
            set { _userdate4 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERDATE_5" field.
        /// </summary>
        public DateTime? Userdate5
        {
            get { return _userdate5; }
            set { _userdate5 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERNUM_5" field.
        /// </summary>
        public Decimal? Usernum5
        {
            get { return _usernum5; }
            set { _usernum5 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERNUM_6" field.
        /// </summary>
        public Decimal? Usernum6
        {
            get { return _usernum6; }
            set { _usernum6 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERNUM_7" field.
        /// </summary>
        public Single? Usernum7
        {
            get { return _usernum7; }
            set { _usernum7 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERNUM_8" field.
        /// </summary>
        public Single? Usernum8
        {
            get { return _usernum8; }
            set { _usernum8 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERINT_1" field.
        /// </summary>
        public Int32? Userint1
        {
            get { return _userint1; }
            set { _userint1 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERINT_2" field.
        /// </summary>
        public Int32? Userint2
        {
            get { return _userint2; }
            set { _userint2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERINT_3" field.
        /// </summary>
        public Int32? Userint3
        {
            get { return _userint3; }
            set { _userint3 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERINT_4" field.
        /// </summary>
        public Int32? Userint4
        {
            get { return _userint4; }
            set { _userint4 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERINT_5" field.
        /// </summary>
        public Int32? Userint5
        {
            get { return _userint5; }
            set { _userint5 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_MEM_C_TOT" field.
        /// </summary>
        public Double? MemCTot
        {
            get { return _memCTot; }
            set { _memCTot = value; }
        }

        /// <summary>
        ///     the value of the "ORG_MEM_R_TOT" field.
        /// </summary>
        public Double? MemRTot
        {
            get { return _memRTot; }
            set { _memRTot = value; }
        }

        /// <summary>
        ///     the value of the "ORG_MEM_L_TOT" field.
        /// </summary>
        public Double? MemLTot
        {
            get { return _memLTot; }
            set { _memLTot = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DONOTFAX" field.
        /// </summary>
        public Byte? Donotfax
        {
            get { return _donotfax; }
            set { _donotfax = value; }
        }

        /// <summary>
        ///     the value of the "ORG_VATCD" field.
        /// </summary>
        public String Vatcd
        {
            get { return _vatcd; }
            set { _vatcd = value; }
        }

        /// <summary>
        ///     the value of the "ORG_CUST_STATUS" field.
        /// </summary>
        public String CustStatus
        {
            get { return _custStatus; }
            set { _custStatus = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DISABLED" field.
        /// </summary>
        public Byte? Disabled
        {
            get { return _disabled; }
            set { _disabled = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERINT_6" field.
        /// </summary>
        public Byte? Userint6
        {
            get { return _userint6; }
            set { _userint6 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_USERDATE_6" field.
        /// </summary>
        public DateTime? Userdate6
        {
            get { return _userdate6; }
            set { _userdate6 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_OUR_ORG" field.
        /// </summary>
        public Byte? OurOrg
        {
            get { return _ourOrg; }
            set { _ourOrg = value; }
        }

        /// <summary>
        ///     the value of the "ORG_EXT_KEY" field.
        /// </summary>
        public String ExtKey
        {
            get { return _extKey; }
            set { _extKey = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ATTRIB_CHAR_01" field.
        /// </summary>
        public String AttribChar01
        {
            get { return _attribChar01; }
            set { _attribChar01 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ATTRIB_CHAR_02" field.
        /// </summary>
        public String AttribChar02
        {
            get { return _attribChar02; }
            set { _attribChar02 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ATTRIB_CHAR_03" field.
        /// </summary>
        public String AttribChar03
        {
            get { return _attribChar03; }
            set { _attribChar03 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ATTRIB_CHAR_04" field.
        /// </summary>
        public String AttribChar04
        {
            get { return _attribChar04; }
            set { _attribChar04 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ATTRIB_CHAR_05" field.
        /// </summary>
        public String AttribChar05
        {
            get { return _attribChar05; }
            set { _attribChar05 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ATTRIB_DATE_01" field.
        /// </summary>
        public DateTime? AttribDate01
        {
            get { return _attribDate01; }
            set { _attribDate01 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_TYPE_SUB" field.
        /// </summary>
        public String TypeSub
        {
            get { return _typeSub; }
            set { _typeSub = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PHONE_STD" field.
        /// </summary>
        public String PhoneStd
        {
            get { return _phoneStd; }
            set { _phoneStd = value; }
        }

        /// <summary>
        ///     the value of the "ORG_FAX_STD" field.
        /// </summary>
        public String FaxStd
        {
            get { return _faxStd; }
            set { _faxStd = value; }
        }

        /// <summary>
        ///     the value of the "ORG_IMM_DUNS" field.
        /// </summary>
        public String ImmDuns
        {
            get { return _immDuns; }
            set { _immDuns = value; }
        }

        /// <summary>
        ///     the value of the "ORG_IMM_NAME" field.
        /// </summary>
        public String ImmName
        {
            get { return _immName; }
            set { _immName = value; }
        }

        /// <summary>
        ///     the value of the "ORG_HQ_DUNS" field.
        /// </summary>
        public String HqDuns
        {
            get { return _hqDuns; }
            set { _hqDuns = value; }
        }

        /// <summary>
        ///     the value of the "ORG_HQ_NAME" field.
        /// </summary>
        public String HqName
        {
            get { return _hqName; }
            set { _hqName = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ULTUK_DUNS" field.
        /// </summary>
        public String UltukDuns
        {
            get { return _ultukDuns; }
            set { _ultukDuns = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ULTUK_NAME" field.
        /// </summary>
        public String UltukName
        {
            get { return _ultukName; }
            set { _ultukName = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ULT_DUNS" field.
        /// </summary>
        public String UltDuns
        {
            get { return _ultDuns; }
            set { _ultDuns = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ULT_NAME" field.
        /// </summary>
        public String UltName
        {
            get { return _ultName; }
            set { _ultName = value; }
        }

        /// <summary>
        ///     the value of the "ORG_MEM_A_TOT" field.
        /// </summary>
        public Double? MemATot
        {
            get { return _memATot; }
            set { _memATot = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "ORG_AREA2" field.
        /// </summary>
        public String Area2
        {
            get { return _area2; }
            set { _area2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_REGION2" field.
        /// </summary>
        public String Region2
        {
            get { return _region2; }
            set { _region2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SECTYPE_ID" field.
        /// </summary>
        public Int32? SectypeId
        {
            get { return _sectypeId; }
            set { _sectypeId = value; }
        }

        /// <summary>
        ///     the value of the "org_sub_region" field.
        /// </summary>
        public String OrgSubRegion
        {
            get { return _orgSubRegion; }
            set { _orgSubRegion = value; }
        }

        /// <summary>
        ///     the value of the "ORG_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "ORG_OS_ID" field.
        /// </summary>
        public Int32? OsId
        {
            get { return _osId; }
            set { _osId = value; }
        }

        /// <summary>
        ///     the value of the "ORG_CONFIRMATION" field.
        /// </summary>
        public Byte? Confirmation
        {
            get { return _confirmation; }
            set { _confirmation = value; }
        }

        /// <summary>
        ///     the value of the "ORG_JI" field.
        /// </summary>
        public Byte? Ji
        {
            get { return _ji; }
            set { _ji = value; }
        }

        /// <summary>
        ///     the value of the "ORG_UNIQUE_REF" field.
        /// </summary>
        public String UniqueRef
        {
            get { return _uniqueRef; }
            set { _uniqueRef = value; }
        }

        /// <summary>
        ///     the value of the "ORG_REF" field.
        /// </summary>
        public String Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        /// <summary>
        ///     the value of the "ORG_REF_PASSWORD" field.
        /// </summary>
        public String RefPassword
        {
            get { return _refPassword; }
            set { _refPassword = value; }
        }

        /// <summary>
        ///     the value of the "ORG_VALID_DOMAIN_SUFFIX" field.
        /// </summary>
        public String ValidDomainSuffix
        {
            get { return _validDomainSuffix; }
            set { _validDomainSuffix = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SUPP_BKT_ID" field.
        /// </summary>
        public String SuppBktId
        {
            get { return _suppBktId; }
            set { _suppBktId = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DO_NOT_SPARE1" field.
        /// </summary>
        public Byte? DoNotSpare1
        {
            get { return _doNotSpare1; }
            set { _doNotSpare1 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DO_NOT_SPARE2" field.
        /// </summary>
        public Byte? DoNotSpare2
        {
            get { return _doNotSpare2; }
            set { _doNotSpare2 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DO_NOT_SPARE3" field.
        /// </summary>
        public Byte? DoNotSpare3
        {
            get { return _doNotSpare3; }
            set { _doNotSpare3 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_DO_NOT_SPARE4" field.
        /// </summary>
        public Byte? DoNotSpare4
        {
            get { return _doNotSpare4; }
            set { _doNotSpare4 = value; }
        }

        /// <summary>
        ///     the value of the "ORG_VAT_REG_NUM" field.
        /// </summary>
        public String VatRegNum
        {
            get { return _vatRegNum; }
            set { _vatRegNum = value; }
        }

        /// <summary>
        ///     the value of the "ORG_REPORT_PASSWORD" field.
        /// </summary>
        public String ReportPassword
        {
            get { return _reportPassword; }
            set { _reportPassword = value; }
        }

        /// <summary>
        ///     the value of the "ORG_REPORT_PATH" field.
        /// </summary>
        public String ReportPath
        {
            get { return _reportPath; }
            set { _reportPath = value; }
        }

        /// <summary>
        ///     the value of the "ORG_REPORT_USERNAME" field.
        /// </summary>
        public String ReportUsername
        {
            get { return _reportUsername; }
            set { _reportUsername = value; }
        }

        /// <summary>
        ///     the value of the "ORG_INV_AUTH_PASSWORD" field.
        /// </summary>
        public String InvAuthPassword
        {
            get { return _invAuthPassword; }
            set { _invAuthPassword = value; }
        }

        /// <summary>
        ///     the value of the "ORG_WEB_ENABLED" field.
        /// </summary>
        public Byte WebEnabled
        {
            get { return _webEnabled; }
            set { _webEnabled = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PERSON_COUNT" field.
        /// </summary>
        public Int32 PersonCount
        {
            get { return _personCount; }
            set { _personCount = value; }
        }

        /// <summary>
        ///     the value of the "ORG_SPEND" field.
        /// </summary>
        public Decimal? Spend
        {
            get { return _spend; }
            set { _spend = value; }
        }

        /// <summary>
        ///     the value of the "ORG_ON_HOLD" field.
        /// </summary>
        public Byte OnHold
        {
            get { return _onHold; }
            set { _onHold = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PSH_ID" field.
        /// </summary>
        public Int32? PshId
        {
            get { return _pshId; }
            set { _pshId = value; }
        }

        /// <summary>
        ///     the value of the "ORG_PORTAL_CONFIRMATION" field.
        /// </summary>
        public String PortalConfirmation
        {
            get { return _portalConfirmation; }
            set { _portalConfirmation = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="OrganisationRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="OrganisationRecord" /> object instance.
        /// </returns>
        public OrganisationRecord Clone()
        {
            OrganisationRecord record = new OrganisationRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Name = this.Name;
            record.Shortname = this.Shortname;
            record.Hierarchy = this.Hierarchy;
            record.Phone = this.Phone;
            record.Fax = this.Fax;
            record.Type = this.Type;
            record.HierarchyLevl = this.HierarchyLevl;
            record.HierarchyLast = this.HierarchyLast;
            record.NoEmployee = this.NoEmployee;
            record.NoTucmember = this.NoTucmember;
            record.TucPercent = this.TucPercent;
            record.DailyHrs = this.DailyHrs;
            record.BlockrateNo = this.BlockrateNo;
            record.TucRegion = this.TucRegion;
            record.MajorUnion = this.MajorUnion;
            record.StudentAuth = this.StudentAuth;
            record.UnionReport = this.UnionReport;
            record.BlockrateFlag = this.BlockrateFlag;
            record.Donotmail = this.Donotmail;
            record.Distributor = this.Distributor;
            record.Userchar5 = this.Userchar5;
            record.Industry = this.Industry;
            record.Area = this.Area;
            record.Notes = this.Notes;
            record.SpecialDeal = this.SpecialDeal;
            record.Orgchart = this.Orgchart;
            record.Source = this.Source;
            record.VatRef = this.VatRef;
            record.Discount = this.Discount;
            record.SoundexKey = this.SoundexKey;
            record.NormStart = this.NormStart;
            record.NormFinish = this.NormFinish;
            record.SalesRevenue = this.SalesRevenue;
            record.Turnover = this.Turnover;
            record.SalesPot = this.SalesPot;
            record.Employees = this.Employees;
            record.Attractive = this.Attractive;
            record.Potential = this.Potential;
            record.SalesRevBc = this.SalesRevBc;
            record.TurnoverBc = this.TurnoverBc;
            record.SalesPotBc = this.SalesPotBc;
            record.CurrencyType = this.CurrencyType;
            record.CustomerAcc = this.CustomerAcc;
            record.GroupAcc = this.GroupAcc;
            record.DepositAcc = this.DepositAcc;
            record.ExecCode = this.ExecCode;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Userchar3 = this.Userchar3;
            record.Userchar4 = this.Userchar4;
            record.Usernum1 = this.Usernum1;
            record.Usernum2 = this.Usernum2;
            record.Usernum3 = this.Usernum3;
            record.Usernum4 = this.Usernum4;
            record.Accmgr1Id = this.Accmgr1Id;
            record.Accmgr2Id = this.Accmgr2Id;
            record.StrategicAcc = this.StrategicAcc;
            record.PicId = this.PicId;
            record.Parent = this.Parent;
            record.ListId = this.ListId;
            record.SpecialTerms = this.SpecialTerms;
            record.Aka = this.Aka;
            record.Hold1 = this.Hold1;
            record.Hold2 = this.Hold2;
            record.Url = this.Url;
            record.Userchar6 = this.Userchar6;
            record.Userchar7 = this.Userchar7;
            record.Userchar8 = this.Userchar8;
            record.Userchar9 = this.Userchar9;
            record.Userchar10 = this.Userchar10;
            record.Comments = this.Comments;
            record.Rank = this.Rank;
            record.MatchKey = this.MatchKey;
            record.Terr1Id = this.Terr1Id;
            record.Terr2Id = this.Terr2Id;
            record.Terr3Id = this.Terr3Id;
            record.BatId = this.BatId;
            record.Userdate1 = this.Userdate1;
            record.Userdate2 = this.Userdate2;
            record.Currency = this.Currency;
            record.PaymentDays = this.PaymentDays;
            record.PaymentType = this.PaymentType;
            record.PayTerms1 = this.PayTerms1;
            record.PayTerms2 = this.PayTerms2;
            record.PayTerms3 = this.PayTerms3;
            record.PayTerms4 = this.PayTerms4;
            record.CreditCurr = this.CreditCurr;
            record.Credit = this.Credit;
            record.CreditBc = this.CreditBc;
            record.CreditBc2 = this.CreditBc2;
            record.ExistClient = this.ExistClient;
            record.Sic1 = this.Sic1;
            record.Sic2 = this.Sic2;
            record.Sic3 = this.Sic3;
            record.Sic4 = this.Sic4;
            record.Duns = this.Duns;
            record.StdCode = this.StdCode;
            record.Security = this.Security;
            record.Flag1 = this.Flag1;
            record.AccStatus = this.AccStatus;
            record.AltName1 = this.AltName1;
            record.AltName2 = this.AltName2;
            record.BktId = this.BktId;
            record.PlId = this.PlId;
            record.VatCode = this.VatCode;
            record.Userchar11 = this.Userchar11;
            record.Email = this.Email;
            record.SourcePmId = this.SourcePmId;
            record.Userchar12 = this.Userchar12;
            record.Userchar13 = this.Userchar13;
            record.Userchar14 = this.Userchar14;
            record.Userchar15 = this.Userchar15;
            record.Userdate3 = this.Userdate3;
            record.Userdate4 = this.Userdate4;
            record.Userdate5 = this.Userdate5;
            record.Usernum5 = this.Usernum5;
            record.Usernum6 = this.Usernum6;
            record.Usernum7 = this.Usernum7;
            record.Usernum8 = this.Usernum8;
            record.Userint1 = this.Userint1;
            record.Userint2 = this.Userint2;
            record.Userint3 = this.Userint3;
            record.Userint4 = this.Userint4;
            record.Userint5 = this.Userint5;
            record.MemCTot = this.MemCTot;
            record.MemRTot = this.MemRTot;
            record.MemLTot = this.MemLTot;
            record.Donotfax = this.Donotfax;
            record.Vatcd = this.Vatcd;
            record.CustStatus = this.CustStatus;
            record.Disabled = this.Disabled;
            record.Userint6 = this.Userint6;
            record.Userdate6 = this.Userdate6;
            record.OurOrg = this.OurOrg;
            record.ExtKey = this.ExtKey;
            record.AttribChar01 = this.AttribChar01;
            record.AttribChar02 = this.AttribChar02;
            record.AttribChar03 = this.AttribChar03;
            record.AttribChar04 = this.AttribChar04;
            record.AttribChar05 = this.AttribChar05;
            record.AttribDate01 = this.AttribDate01;
            record.TypeSub = this.TypeSub;
            record.PhoneStd = this.PhoneStd;
            record.FaxStd = this.FaxStd;
            record.ImmDuns = this.ImmDuns;
            record.ImmName = this.ImmName;
            record.HqDuns = this.HqDuns;
            record.HqName = this.HqName;
            record.UltukDuns = this.UltukDuns;
            record.UltukName = this.UltukName;
            record.UltDuns = this.UltDuns;
            record.UltName = this.UltName;
            record.MemATot = this.MemATot;
            record.SelcoSpId = this.SelcoSpId;
            record.Area2 = this.Area2;
            record.Region2 = this.Region2;
            record.SectypeId = this.SectypeId;
            record.OrgSubRegion = this.OrgSubRegion;
            record.Status = this.Status;
            record.OsId = this.OsId;
            record.Confirmation = this.Confirmation;
            record.Ji = this.Ji;
            record.UniqueRef = this.UniqueRef;
            record.Ref = this.Ref;
            record.RefPassword = this.RefPassword;
            record.ValidDomainSuffix = this.ValidDomainSuffix;
            record.SuppBktId = this.SuppBktId;
            record.DoNotSpare1 = this.DoNotSpare1;
            record.DoNotSpare2 = this.DoNotSpare2;
            record.DoNotSpare3 = this.DoNotSpare3;
            record.DoNotSpare4 = this.DoNotSpare4;
            record.VatRegNum = this.VatRegNum;
            record.ReportPassword = this.ReportPassword;
            record.ReportPath = this.ReportPath;
            record.ReportUsername = this.ReportUsername;
            record.InvAuthPassword = this.InvAuthPassword;
            record.WebEnabled = this.WebEnabled;
            record.PersonCount = this.PersonCount;
            record.Spend = this.Spend;
            record.OnHold = this.OnHold;
            record.PshId = this.PshId;
            record.PortalConfirmation = this.PortalConfirmation;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="OrganisationRecord" /> instance is equal to another <see cref="OrganisationRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="OrganisationRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(OrganisationRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Shortname.TrimOrNullify() == that.Shortname.TrimOrNullify());
            result = result && (this.Hierarchy.TrimOrNullify() == that.Hierarchy.TrimOrNullify());
            result = result && (this.Phone.TrimOrNullify() == that.Phone.TrimOrNullify());
            result = result && (this.Fax.TrimOrNullify() == that.Fax.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.HierarchyLevl == that.HierarchyLevl);
            result = result && (this.HierarchyLast == that.HierarchyLast);
            result = result && (this.NoEmployee == that.NoEmployee);
            result = result && (this.NoTucmember == that.NoTucmember);
            result = result && (this.TucPercent == that.TucPercent);
            result = result && (this.DailyHrs == that.DailyHrs);
            result = result && (this.BlockrateNo == that.BlockrateNo);
            result = result && (this.TucRegion.TrimOrNullify() == that.TucRegion.TrimOrNullify());
            result = result && (this.MajorUnion == that.MajorUnion);
            result = result && (this.StudentAuth == that.StudentAuth);
            result = result && (this.UnionReport == that.UnionReport);
            result = result && (this.BlockrateFlag == that.BlockrateFlag);
            result = result && (this.Donotmail == that.Donotmail);
            result = result && (this.Distributor == that.Distributor);
            result = result && (this.Userchar5.TrimOrNullify() == that.Userchar5.TrimOrNullify());
            result = result && (this.Industry.TrimOrNullify() == that.Industry.TrimOrNullify());
            result = result && (this.Area.TrimOrNullify() == that.Area.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.SpecialDeal.TrimOrNullify() == that.SpecialDeal.TrimOrNullify());
            result = result && (this.Orgchart.TrimOrNullify() == that.Orgchart.TrimOrNullify());
            result = result && (this.Source.TrimOrNullify() == that.Source.TrimOrNullify());
            result = result && (this.VatRef.TrimOrNullify() == that.VatRef.TrimOrNullify());
            result = result && (this.Discount.TrimOrNullify() == that.Discount.TrimOrNullify());
            result = result && (this.SoundexKey.TrimOrNullify() == that.SoundexKey.TrimOrNullify());
            result = result && (this.NormStart == that.NormStart);
            result = result && (this.NormFinish == that.NormFinish);
            result = result && (this.SalesRevenue == that.SalesRevenue);
            result = result && (this.Turnover == that.Turnover);
            result = result && (this.SalesPot == that.SalesPot);
            result = result && (this.Employees == that.Employees);
            result = result && (this.Attractive.TrimOrNullify() == that.Attractive.TrimOrNullify());
            result = result && (this.Potential.TrimOrNullify() == that.Potential.TrimOrNullify());
            result = result && (this.SalesRevBc == that.SalesRevBc);
            result = result && (this.TurnoverBc == that.TurnoverBc);
            result = result && (this.SalesPotBc == that.SalesPotBc);
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.CustomerAcc.TrimOrNullify() == that.CustomerAcc.TrimOrNullify());
            result = result && (this.GroupAcc.TrimOrNullify() == that.GroupAcc.TrimOrNullify());
            result = result && (this.DepositAcc.TrimOrNullify() == that.DepositAcc.TrimOrNullify());
            result = result && (this.ExecCode.TrimOrNullify() == that.ExecCode.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Usernum3 == that.Usernum3);
            result = result && (this.Usernum4 == that.Usernum4);
            result = result && (this.Accmgr1Id.TrimOrNullify() == that.Accmgr1Id.TrimOrNullify());
            result = result && (this.Accmgr2Id.TrimOrNullify() == that.Accmgr2Id.TrimOrNullify());
            result = result && (this.StrategicAcc == that.StrategicAcc);
            result = result && (this.PicId.TrimOrNullify() == that.PicId.TrimOrNullify());
            result = result && (this.Parent.TrimOrNullify() == that.Parent.TrimOrNullify());
            result = result && (this.ListId.TrimOrNullify() == that.ListId.TrimOrNullify());
            result = result && (this.SpecialTerms.TrimOrNullify() == that.SpecialTerms.TrimOrNullify());
            result = result && (this.Aka.TrimOrNullify() == that.Aka.TrimOrNullify());
            result = result && (this.Hold1 == that.Hold1);
            result = result && (this.Hold2 == that.Hold2);
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            result = result && (this.Userchar6.TrimOrNullify() == that.Userchar6.TrimOrNullify());
            result = result && (this.Userchar7.TrimOrNullify() == that.Userchar7.TrimOrNullify());
            result = result && (this.Userchar8.TrimOrNullify() == that.Userchar8.TrimOrNullify());
            result = result && (this.Userchar9.TrimOrNullify() == that.Userchar9.TrimOrNullify());
            result = result && (this.Userchar10.TrimOrNullify() == that.Userchar10.TrimOrNullify());
            result = result && (this.Comments.TrimOrNullify() == that.Comments.TrimOrNullify());
            result = result && (this.Rank.TrimOrNullify() == that.Rank.TrimOrNullify());
            result = result && (this.MatchKey.TrimOrNullify() == that.MatchKey.TrimOrNullify());
            result = result && (this.Terr1Id.TrimOrNullify() == that.Terr1Id.TrimOrNullify());
            result = result && (this.Terr2Id.TrimOrNullify() == that.Terr2Id.TrimOrNullify());
            result = result && (this.Terr3Id.TrimOrNullify() == that.Terr3Id.TrimOrNullify());
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.Userdate1 == that.Userdate1);
            result = result && (this.Userdate2 == that.Userdate2);
            result = result && (this.Currency.TrimOrNullify() == that.Currency.TrimOrNullify());
            result = result && (this.PaymentDays == that.PaymentDays);
            result = result && (this.PaymentType == that.PaymentType);
            result = result && (this.PayTerms1.TrimOrNullify() == that.PayTerms1.TrimOrNullify());
            result = result && (this.PayTerms2.TrimOrNullify() == that.PayTerms2.TrimOrNullify());
            result = result && (this.PayTerms3.TrimOrNullify() == that.PayTerms3.TrimOrNullify());
            result = result && (this.PayTerms4.TrimOrNullify() == that.PayTerms4.TrimOrNullify());
            result = result && (this.CreditCurr.TrimOrNullify() == that.CreditCurr.TrimOrNullify());
            result = result && (this.Credit == that.Credit);
            result = result && (this.CreditBc == that.CreditBc);
            result = result && (this.CreditBc2 == that.CreditBc2);
            result = result && (this.ExistClient == that.ExistClient);
            result = result && (this.Sic1.TrimOrNullify() == that.Sic1.TrimOrNullify());
            result = result && (this.Sic2.TrimOrNullify() == that.Sic2.TrimOrNullify());
            result = result && (this.Sic3.TrimOrNullify() == that.Sic3.TrimOrNullify());
            result = result && (this.Sic4.TrimOrNullify() == that.Sic4.TrimOrNullify());
            result = result && (this.Duns.TrimOrNullify() == that.Duns.TrimOrNullify());
            result = result && (this.StdCode.TrimOrNullify() == that.StdCode.TrimOrNullify());
            result = result && (this.Security.TrimOrNullify() == that.Security.TrimOrNullify());
            result = result && (this.Flag1 == that.Flag1);
            result = result && (this.AccStatus.TrimOrNullify() == that.AccStatus.TrimOrNullify());
            result = result && (this.AltName1.TrimOrNullify() == that.AltName1.TrimOrNullify());
            result = result && (this.AltName2.TrimOrNullify() == that.AltName2.TrimOrNullify());
            result = result && (this.BktId.TrimOrNullify() == that.BktId.TrimOrNullify());
            result = result && (this.PlId.TrimOrNullify() == that.PlId.TrimOrNullify());
            result = result && (this.VatCode.TrimOrNullify() == that.VatCode.TrimOrNullify());
            result = result && (this.Userchar11.TrimOrNullify() == that.Userchar11.TrimOrNullify());
            result = result && (this.Email.TrimOrNullify() == that.Email.TrimOrNullify());
            result = result && (this.SourcePmId.TrimOrNullify() == that.SourcePmId.TrimOrNullify());
            result = result && (this.Userchar12.TrimOrNullify() == that.Userchar12.TrimOrNullify());
            result = result && (this.Userchar13.TrimOrNullify() == that.Userchar13.TrimOrNullify());
            result = result && (this.Userchar14.TrimOrNullify() == that.Userchar14.TrimOrNullify());
            result = result && (this.Userchar15.TrimOrNullify() == that.Userchar15.TrimOrNullify());
            result = result && (this.Userdate3 == that.Userdate3);
            result = result && (this.Userdate4 == that.Userdate4);
            result = result && (this.Userdate5 == that.Userdate5);
            result = result && (this.Usernum5 == that.Usernum5);
            result = result && (this.Usernum6 == that.Usernum6);
            result = result && (this.Usernum7 == that.Usernum7);
            result = result && (this.Usernum8 == that.Usernum8);
            result = result && (this.Userint1 == that.Userint1);
            result = result && (this.Userint2 == that.Userint2);
            result = result && (this.Userint3 == that.Userint3);
            result = result && (this.Userint4 == that.Userint4);
            result = result && (this.Userint5 == that.Userint5);
            result = result && (this.MemCTot == that.MemCTot);
            result = result && (this.MemRTot == that.MemRTot);
            result = result && (this.MemLTot == that.MemLTot);
            result = result && (this.Donotfax == that.Donotfax);
            result = result && (this.Vatcd.TrimOrNullify() == that.Vatcd.TrimOrNullify());
            result = result && (this.CustStatus.TrimOrNullify() == that.CustStatus.TrimOrNullify());
            result = result && (this.Disabled == that.Disabled);
            result = result && (this.Userint6 == that.Userint6);
            result = result && (this.Userdate6 == that.Userdate6);
            result = result && (this.OurOrg == that.OurOrg);
            result = result && (this.ExtKey.TrimOrNullify() == that.ExtKey.TrimOrNullify());
            result = result && (this.AttribChar01.TrimOrNullify() == that.AttribChar01.TrimOrNullify());
            result = result && (this.AttribChar02.TrimOrNullify() == that.AttribChar02.TrimOrNullify());
            result = result && (this.AttribChar03.TrimOrNullify() == that.AttribChar03.TrimOrNullify());
            result = result && (this.AttribChar04.TrimOrNullify() == that.AttribChar04.TrimOrNullify());
            result = result && (this.AttribChar05.TrimOrNullify() == that.AttribChar05.TrimOrNullify());
            result = result && (this.AttribDate01 == that.AttribDate01);
            result = result && (this.TypeSub.TrimOrNullify() == that.TypeSub.TrimOrNullify());
            result = result && (this.PhoneStd.TrimOrNullify() == that.PhoneStd.TrimOrNullify());
            result = result && (this.FaxStd.TrimOrNullify() == that.FaxStd.TrimOrNullify());
            result = result && (this.ImmDuns.TrimOrNullify() == that.ImmDuns.TrimOrNullify());
            result = result && (this.ImmName.TrimOrNullify() == that.ImmName.TrimOrNullify());
            result = result && (this.HqDuns.TrimOrNullify() == that.HqDuns.TrimOrNullify());
            result = result && (this.HqName.TrimOrNullify() == that.HqName.TrimOrNullify());
            result = result && (this.UltukDuns.TrimOrNullify() == that.UltukDuns.TrimOrNullify());
            result = result && (this.UltukName.TrimOrNullify() == that.UltukName.TrimOrNullify());
            result = result && (this.UltDuns.TrimOrNullify() == that.UltDuns.TrimOrNullify());
            result = result && (this.UltName.TrimOrNullify() == that.UltName.TrimOrNullify());
            result = result && (this.MemATot == that.MemATot);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.Area2.TrimOrNullify() == that.Area2.TrimOrNullify());
            result = result && (this.Region2.TrimOrNullify() == that.Region2.TrimOrNullify());
            result = result && (this.SectypeId == that.SectypeId);
            result = result && (this.OrgSubRegion.TrimOrNullify() == that.OrgSubRegion.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.OsId == that.OsId);
            result = result && (this.Confirmation == that.Confirmation);
            result = result && (this.Ji == that.Ji);
            result = result && (this.UniqueRef.TrimOrNullify() == that.UniqueRef.TrimOrNullify());
            result = result && (this.Ref.TrimOrNullify() == that.Ref.TrimOrNullify());
            result = result && (this.RefPassword.TrimOrNullify() == that.RefPassword.TrimOrNullify());
            result = result && (this.ValidDomainSuffix.TrimOrNullify() == that.ValidDomainSuffix.TrimOrNullify());
            result = result && (this.SuppBktId.TrimOrNullify() == that.SuppBktId.TrimOrNullify());
            result = result && (this.DoNotSpare1 == that.DoNotSpare1);
            result = result && (this.DoNotSpare2 == that.DoNotSpare2);
            result = result && (this.DoNotSpare3 == that.DoNotSpare3);
            result = result && (this.DoNotSpare4 == that.DoNotSpare4);
            result = result && (this.VatRegNum.TrimOrNullify() == that.VatRegNum.TrimOrNullify());
            result = result && (this.ReportPassword.TrimOrNullify() == that.ReportPassword.TrimOrNullify());
            result = result && (this.ReportPath.TrimOrNullify() == that.ReportPath.TrimOrNullify());
            result = result && (this.ReportUsername.TrimOrNullify() == that.ReportUsername.TrimOrNullify());
            result = result && (this.InvAuthPassword.TrimOrNullify() == that.InvAuthPassword.TrimOrNullify());
            result = result && (this.WebEnabled == that.WebEnabled);
            result = result && (this.PersonCount == that.PersonCount);
            result = result && (this.Spend == that.Spend);
            result = result && (this.OnHold == that.OnHold);
            result = result && (this.PshId == that.PshId);
            result = result && (this.PortalConfirmation.TrimOrNullify() == that.PortalConfirmation.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
