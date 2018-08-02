using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Person_Role" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PersonRoleRecord : Record<String>, Cloneable<PersonRoleRecord>, IEquatable<PersonRoleRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PROLE_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PROLE_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PROLE_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PROLE_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PROLE_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PROLE_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PROLE_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PROLE_PERSON_ID" field.
        /// </summary>
        private String _personId;

        /// <summary>
        ///     the value of the "PROLE_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "PROLE_POS_TITLE" field.
        /// </summary>
        private String _posTitle;

        /// <summary>
        ///     the value of the "PROLE_DEPT" field.
        /// </summary>
        private String _dept;

        /// <summary>
        ///     the value of the "PROLE_POS_TYPE" field.
        /// </summary>
        private String _posType;

        /// <summary>
        ///     the value of the "PROLE_POS_LEVEL" field.
        /// </summary>
        private String _posLevel;

        /// <summary>
        ///     the value of the "PROLE_PHONE" field.
        /// </summary>
        private String _phone;

        /// <summary>
        ///     the value of the "PROLE_FAX" field.
        /// </summary>
        private String _fax;

        /// <summary>
        ///     the value of the "PROLE_MOBILE" field.
        /// </summary>
        private String _mobile;

        /// <summary>
        ///     the value of the "PROLE_EMAIL1" field.
        /// </summary>
        private String _email1;

        /// <summary>
        ///     the value of the "PROLE_REPORTS_TO" field.
        /// </summary>
        private String _reportsTo;

        /// <summary>
        ///     the value of the "PROLE_SECRETARY" field.
        /// </summary>
        private String _secretary;

        /// <summary>
        ///     the value of the "PROLE_PRINCIP_ROLE" field.
        /// </summary>
        private Byte? _principRole;

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_MAIL" field.
        /// </summary>
        private Byte? _doNotMail;

        /// <summary>
        ///     the value of the "PROLE_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "PROLE_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "PROLE_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        private String _unionRolNo;

        /// <summary>
        ///     the value of the "PROLE_BRANCH_NAME" field.
        /// </summary>
        private String _branchName;

        /// <summary>
        ///     the value of the "PROLE_FIRST_COURSE" field.
        /// </summary>
        private DateTime? _firstCourse;

        /// <summary>
        ///     the value of the "PROLE_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "PROLE_ALT_PHONE" field.
        /// </summary>
        private String _altPhone;

        /// <summary>
        ///     the value of the "PROLE_ALT_FAX" field.
        /// </summary>
        private String _altFax;

        /// <summary>
        ///     the value of the "PROLE_BUDGET" field.
        /// </summary>
        private Double? _budget;

        /// <summary>
        ///     the value of the "PROLE_NL_COPIES" field.
        /// </summary>
        private Double? _nlCopies;

        /// <summary>
        ///     the value of the "PROLE_USER_TYPE" field.
        /// </summary>
        private String _userType;

        /// <summary>
        ///     the value of the "PROLE_USER_TYPE_1" field.
        /// </summary>
        private String _userType1;

        /// <summary>
        ///     the value of the "PROLE_USER_TYPE_2" field.
        /// </summary>
        private String _userType2;

        /// <summary>
        ///     the value of the "PROLE_USER_TYPE_3" field.
        /// </summary>
        private String _userType3;

        /// <summary>
        ///     the value of the "PROLE_EXEC_CODE" field.
        /// </summary>
        private String _execCode;

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "PROLE_USERNUM_1" field.
        /// </summary>
        private Decimal? _usernum1;

        /// <summary>
        ///     the value of the "PROLE_USERNUM_2" field.
        /// </summary>
        private Decimal? _usernum2;

        /// <summary>
        ///     the value of the "PROLE_EMAIL" field.
        /// </summary>
        private String _email;

        /// <summary>
        ///     the value of the "PROLE_ORG_NAME" field.
        /// </summary>
        private String _orgName;

        /// <summary>
        ///     the value of the "PROLE_PN_NAME" field.
        /// </summary>
        private String _pnName;

        /// <summary>
        ///     the value of the "PROLE_CONTACT_MGR" field.
        /// </summary>
        private String _contactMgr;

        /// <summary>
        ///     the value of the "PROLE_SOURCE" field.
        /// </summary>
        private String _source;

        /// <summary>
        ///     the value of the "PROLE_MAIL_LIMIT" field.
        /// </summary>
        private Byte? _mailLimit;

        /// <summary>
        ///     the value of the "PROLE_UNTIL" field.
        /// </summary>
        private DateTime? _until;

        /// <summary>
        ///     the value of the "PROLE_MAIL_NOLIMIT" field.
        /// </summary>
        private Byte? _mailNolimit;

        /// <summary>
        ///     the value of the "PROLE_EXT_ID_1" field.
        /// </summary>
        private String _extId1;

        /// <summary>
        ///     the value of the "PROLE_EXT_ID_2" field.
        /// </summary>
        private String _extId2;

        /// <summary>
        ///     the value of the "PROLE_EXT_ID_3" field.
        /// </summary>
        private String _extId3;

        /// <summary>
        ///     the value of the "PROLE_SECRET_PHONE" field.
        /// </summary>
        private String _secretPhone;

        /// <summary>
        ///     the value of the "PROLE_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "PROLE_LBST_DATE" field.
        /// </summary>
        private DateTime? _lbstDate;

        /// <summary>
        ///     the value of the "PROLE_POST_SPEC" field.
        /// </summary>
        private String _postSpec;

        /// <summary>
        ///     the value of the "PROLE_SCALE_POINT" field.
        /// </summary>
        private Int32? _scalePoint;

        /// <summary>
        ///     the value of the "PROLE_GRADE_BAND" field.
        /// </summary>
        private String _gradeBand;

        /// <summary>
        ///     the value of the "PROLE_DIS_FLAG" field.
        /// </summary>
        private Byte? _disFlag;

        /// <summary>
        ///     the value of the "PROLE_WEB_PROF" field.
        /// </summary>
        private String _webProf;

        /// <summary>
        ///     the value of the "PROLE_WEB_PASS" field.
        /// </summary>
        private String _webPass;

        /// <summary>
        ///     the value of the "PROLE_CUSTOMER_ACC" field.
        /// </summary>
        private String _customerAcc;

        /// <summary>
        ///     the value of the "PROLE_CJT_ID" field.
        /// </summary>
        private String _cjtId;

        /// <summary>
        ///     the value of the "PROLE_PAYROLL" field.
        /// </summary>
        private String _payroll;

        /// <summary>
        ///     the value of the "PROLE_STAFF_NO" field.
        /// </summary>
        private String _staffNo;

        /// <summary>
        ///     the value of the "PROLE_COST_CENTRE" field.
        /// </summary>
        private String _costCentre;

        /// <summary>
        ///     the value of the "PROLE_KEY_CONTACT" field.
        /// </summary>
        private Byte? _keyContact;

        /// <summary>
        ///     the value of the "PROLE_MEM_C_TOT" field.
        /// </summary>
        private Double? _memCTot;

        /// <summary>
        ///     the value of the "PROLE_MEM_R_TOT" field.
        /// </summary>
        private Double? _memRTot;

        /// <summary>
        ///     the value of the "PROLE_MEM_L_TOT" field.
        /// </summary>
        private Double? _memLTot;

        /// <summary>
        ///     the value of the "PROLE_CONTACT_MGR2" field.
        /// </summary>
        private String _contactMgr2;

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_5" field.
        /// </summary>
        private String _userchar5;

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_6" field.
        /// </summary>
        private String _userchar6;

        /// <summary>
        ///     the value of the "PROLE_USERINT_1" field.
        /// </summary>
        private Byte? _userint1;

        /// <summary>
        ///     the value of the "PROLE_USERINT_2" field.
        /// </summary>
        private Byte? _userint2;

        /// <summary>
        ///     the value of the "PROLE_USERINT_3" field.
        /// </summary>
        private Byte? _userint3;

        /// <summary>
        ///     the value of the "PROLE_USERINT_4" field.
        /// </summary>
        private Byte? _userint4;

        /// <summary>
        ///     the value of the "PROLE_USERINT_5" field.
        /// </summary>
        private Byte? _userint5;

        /// <summary>
        ///     the value of the "PROLE_USERINT_6" field.
        /// </summary>
        private Byte? _userint6;

        /// <summary>
        ///     the value of the "PROLE_USERNUM_3" field.
        /// </summary>
        private Decimal? _usernum3;

        /// <summary>
        ///     the value of the "PROLE_USERNUM_4" field.
        /// </summary>
        private Decimal? _usernum4;

        /// <summary>
        ///     the value of the "PROLE_USERNUM_5" field.
        /// </summary>
        private Decimal? _usernum5;

        /// <summary>
        ///     the value of the "PROLE_USERNUM_6" field.
        /// </summary>
        private Decimal? _usernum6;

        /// <summary>
        ///     the value of the "PROLE_USERDATE_1" field.
        /// </summary>
        private DateTime? _userdate1;

        /// <summary>
        ///     the value of the "PROLE_USERDATE_2" field.
        /// </summary>
        private DateTime? _userdate2;

        /// <summary>
        ///     the value of the "PROLE_USERDATE_3" field.
        /// </summary>
        private DateTime? _userdate3;

        /// <summary>
        ///     the value of the "PROLE_USERDATE_4" field.
        /// </summary>
        private DateTime? _userdate4;

        /// <summary>
        ///     the value of the "PROLE_USERDATE_5" field.
        /// </summary>
        private DateTime? _userdate5;

        /// <summary>
        ///     the value of the "PROLE_USERDATE_6" field.
        /// </summary>
        private DateTime? _userdate6;

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_FAX" field.
        /// </summary>
        private Byte? _doNotFax;

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        private Byte? _doNotEmail;

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SWAP" field.
        /// </summary>
        private Byte? _doNotSwap;

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SPARE" field.
        /// </summary>
        private Byte? _doNotSpare;

        /// <summary>
        ///     the value of the "PROLE_PRIVATE_ADD" field.
        /// </summary>
        private Byte? _privateAdd;

        /// <summary>
        ///     the value of the "PROLE_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "PROLE_MAIN_WORKADD" field.
        /// </summary>
        private Byte? _mainWorkadd;

        /// <summary>
        ///     the value of the "PROLE_MAIN_PRIVADD" field.
        /// </summary>
        private Byte? _mainPrivadd;

        /// <summary>
        ///     the value of the "PROLE_WORK_ADD" field.
        /// </summary>
        private Byte? _workAdd;

        /// <summary>
        ///     the value of the "PROLE_LM_PHONE" field.
        /// </summary>
        private String _lmPhone;

        /// <summary>
        ///     the value of the "PROLE_LM_EMAIL" field.
        /// </summary>
        private String _lmEmail;

        /// <summary>
        ///     the value of the "PROLE_SERVICE" field.
        /// </summary>
        private String _service;

        /// <summary>
        ///     the value of the "PROLE_PAY_LOCATION" field.
        /// </summary>
        private String _payLocation;

        /// <summary>
        ///     the value of the "PROLE_BA" field.
        /// </summary>
        private String _ba;

        /// <summary>
        ///     the value of the "PROLE_BA1" field.
        /// </summary>
        private String _ba1;

        /// <summary>
        ///     the value of the "PROLE_TRN_ADMIN" field.
        /// </summary>
        private Byte? _trnAdmin;

        /// <summary>
        ///     the value of the "PROLE_ATTRIB_NUM_01" field.
        /// </summary>
        private Int32? _attribNum01;

        /// <summary>
        ///     the value of the "PROLE_ATTRIB_CHAR_01" field.
        /// </summary>
        private String _attribChar01;

        /// <summary>
        ///     the value of the "PROLE_ATTRIB_TINT_01" field.
        /// </summary>
        private Byte? _attribTint01;

        /// <summary>
        ///     the value of the "PROLE_WTE" field.
        /// </summary>
        private Decimal? _wte;

        /// <summary>
        ///     the value of the "PROLE_PHONE_STD" field.
        /// </summary>
        private String _phoneStd;

        /// <summary>
        ///     the value of the "PROLE_FAX_STD" field.
        /// </summary>
        private String _faxStd;

        /// <summary>
        ///     the value of the "PROLE_ALT_PHONE_STD" field.
        /// </summary>
        private String _altPhoneStd;

        /// <summary>
        ///     the value of the "PROLE_ALT_FAX_STD" field.
        /// </summary>
        private String _altFaxStd;

        /// <summary>
        ///     the value of the "PROLE_SECRET_PHONE_STD" field.
        /// </summary>
        private String _secretPhoneStd;

        /// <summary>
        ///     the value of the "PROLE_LM_PHONE_STD" field.
        /// </summary>
        private String _lmPhoneStd;

        /// <summary>
        ///     the value of the "PROLE_DELIV_POINT1" field.
        /// </summary>
        private String _delivPoint1;

        /// <summary>
        ///     the value of the "PROLE_DELIV_POINT2" field.
        /// </summary>
        private String _delivPoint2;

        /// <summary>
        ///     the value of the "PROLE_SHOW_ADDRESS" field.
        /// </summary>
        private Byte _showAddress;

        /// <summary>
        ///     the value of the "PROLE_SHOW_PHONE" field.
        /// </summary>
        private Byte _showPhone;

        /// <summary>
        ///     the value of the "PROLE_SHOW_EMAIL" field.
        /// </summary>
        private Byte _showEmail;

        /// <summary>
        ///     the value of the "PROLE_MEM_A_TOT" field.
        /// </summary>
        private Double? _memATot;

        /// <summary>
        ///     the value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "PROLE_CJT_ACHIEVED" field.
        /// </summary>
        private Byte? _cjtAchieved;

        /// <summary>
        ///     the value of the "PROLE_MEM_REF" field.
        /// </summary>
        private String _memRef;

        /// <summary>
        ///     the value of the "PROLE_HOUR_RTE" field.
        /// </summary>
        private Decimal _hourRte;

        /// <summary>
        ///     the value of the "PROLE_BUDH_ID" field.
        /// </summary>
        private String _budhId;

        /// <summary>
        ///     the value of the "PROLE_OS_ID" field.
        /// </summary>
        private Int32? _osId;

        /// <summary>
        ///     the value of the "PROLE_JOB_LVL" field.
        /// </summary>
        private String _jobLvl;

        /// <summary>
        ///     the value of the "PROLE_REPORTS_TO_1" field.
        /// </summary>
        private String _reportsTo1;

        /// <summary>
        ///     the value of the "PROLE_OSU_ID" field.
        /// </summary>
        private Int32? _osuId;

        /// <summary>
        ///     the value of the "PROLE_AJT_ID" field.
        /// </summary>
        private Int32? _ajtId;

        /// <summary>
        ///     the value of the "PROLE_UNIQUE_REF" field.
        /// </summary>
        private String _uniqueRef;

        /// <summary>
        ///     the value of the "PROLE_SEND_TO_WHICH_EMAIL" field.
        /// </summary>
        private Byte _sendToWhichEmail;

        /// <summary>
        ///     the value of the "PROLE_REPTO_LINEAGE" field.
        /// </summary>
        private String _reptoLineage;

        /// <summary>
        ///     the value of the "PROLE_REPTO_DEPTH" field.
        /// </summary>
        private Int32? _reptoDepth;

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_1" field.
        /// </summary>
        private Byte _membCheck1;

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_2" field.
        /// </summary>
        private Byte _membCheck2;

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_3" field.
        /// </summary>
        private Byte _membCheck3;

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_4" field.
        /// </summary>
        private Byte _membCheck4;

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_5" field.
        /// </summary>
        private Byte _membCheck5;

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_6" field.
        /// </summary>
        private Byte _membCheck6;

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_7" field.
        /// </summary>
        private Byte _membCheck7;

        /// <summary>
        ///     the value of the "PROLE_USERINT_7" field.
        /// </summary>
        private Byte? _userint7;

        /// <summary>
        ///     the value of the "PROLE_USERINT_8" field.
        /// </summary>
        private Byte? _userint8;

        /// <summary>
        ///     the value of the "PROLE_USERINT_9" field.
        /// </summary>
        private Byte? _userint9;

        /// <summary>
        ///     the value of the "PROLE_USERINT_10" field.
        /// </summary>
        private Byte? _userint10;

        /// <summary>
        ///     the value of the "PROLE_USERINT_11" field.
        /// </summary>
        private Byte? _userint11;

        /// <summary>
        ///     the value of the "PROLE_OVERSEAS" field.
        /// </summary>
        private Byte? _overseas;

        /// <summary>
        ///     the value of the "PROLE_SEND_TO_WHICH_MOBILE" field.
        /// </summary>
        private Byte _sendToWhichMobile;

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SPARE1" field.
        /// </summary>
        private Byte? _doNotSpare1;

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SPARE2" field.
        /// </summary>
        private Byte? _doNotSpare2;

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SPARE3" field.
        /// </summary>
        private Byte? _doNotSpare3;

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SPARE4" field.
        /// </summary>
        private Byte? _doNotSpare4;

        /// <summary>
        ///     the value of the "PROLE_AREA" field.
        /// </summary>
        private String _area;

        /// <summary>
        ///     the value of the "PROLE_REGION" field.
        /// </summary>
        private String _region;

        /// <summary>
        ///     the value of the "PROLE_PROFILE_DESCRIPTION" field.
        /// </summary>
        private String _profileDescription;

        /// <summary>
        ///     the value of the "PROLE_DEFAULT_PR_ID" field.
        /// </summary>
        private Int32? _defaultPrId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PROLE_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_POS_TITLE" field.
        /// </summary>
        public String PosTitle
        {
            get { return _posTitle; }
            set { _posTitle = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DEPT" field.
        /// </summary>
        public String Dept
        {
            get { return _dept; }
            set { _dept = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_POS_TYPE" field.
        /// </summary>
        public String PosType
        {
            get { return _posType; }
            set { _posType = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_POS_LEVEL" field.
        /// </summary>
        public String PosLevel
        {
            get { return _posLevel; }
            set { _posLevel = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_PHONE" field.
        /// </summary>
        public String Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_FAX" field.
        /// </summary>
        public String Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MOBILE" field.
        /// </summary>
        public String Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_EMAIL1" field.
        /// </summary>
        public String Email1
        {
            get { return _email1; }
            set { _email1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_REPORTS_TO" field.
        /// </summary>
        public String ReportsTo
        {
            get { return _reportsTo; }
            set { _reportsTo = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SECRETARY" field.
        /// </summary>
        public String Secretary
        {
            get { return _secretary; }
            set { _secretary = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_PRINCIP_ROLE" field.
        /// </summary>
        public Byte? PrincipRole
        {
            get { return _principRole; }
            set { _principRole = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_MAIL" field.
        /// </summary>
        public Byte? DoNotMail
        {
            get { return _doNotMail; }
            set { _doNotMail = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        public String UnionRolNo
        {
            get { return _unionRolNo; }
            set { _unionRolNo = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_BRANCH_NAME" field.
        /// </summary>
        public String BranchName
        {
            get { return _branchName; }
            set { _branchName = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_FIRST_COURSE" field.
        /// </summary>
        public DateTime? FirstCourse
        {
            get { return _firstCourse; }
            set { _firstCourse = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ALT_PHONE" field.
        /// </summary>
        public String AltPhone
        {
            get { return _altPhone; }
            set { _altPhone = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ALT_FAX" field.
        /// </summary>
        public String AltFax
        {
            get { return _altFax; }
            set { _altFax = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_BUDGET" field.
        /// </summary>
        public Double? Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_NL_COPIES" field.
        /// </summary>
        public Double? NlCopies
        {
            get { return _nlCopies; }
            set { _nlCopies = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USER_TYPE" field.
        /// </summary>
        public String UserType
        {
            get { return _userType; }
            set { _userType = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USER_TYPE_1" field.
        /// </summary>
        public String UserType1
        {
            get { return _userType1; }
            set { _userType1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USER_TYPE_2" field.
        /// </summary>
        public String UserType2
        {
            get { return _userType2; }
            set { _userType2 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USER_TYPE_3" field.
        /// </summary>
        public String UserType3
        {
            get { return _userType3; }
            set { _userType3 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_EXEC_CODE" field.
        /// </summary>
        public String ExecCode
        {
            get { return _execCode; }
            set { _execCode = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERNUM_1" field.
        /// </summary>
        public Decimal? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERNUM_2" field.
        /// </summary>
        public Decimal? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_EMAIL" field.
        /// </summary>
        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ORG_NAME" field.
        /// </summary>
        public String OrgName
        {
            get { return _orgName; }
            set { _orgName = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_PN_NAME" field.
        /// </summary>
        public String PnName
        {
            get { return _pnName; }
            set { _pnName = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_CONTACT_MGR" field.
        /// </summary>
        public String ContactMgr
        {
            get { return _contactMgr; }
            set { _contactMgr = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SOURCE" field.
        /// </summary>
        public String Source
        {
            get { return _source; }
            set { _source = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MAIL_LIMIT" field.
        /// </summary>
        public Byte? MailLimit
        {
            get { return _mailLimit; }
            set { _mailLimit = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_UNTIL" field.
        /// </summary>
        public DateTime? Until
        {
            get { return _until; }
            set { _until = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MAIL_NOLIMIT" field.
        /// </summary>
        public Byte? MailNolimit
        {
            get { return _mailNolimit; }
            set { _mailNolimit = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_EXT_ID_1" field.
        /// </summary>
        public String ExtId1
        {
            get { return _extId1; }
            set { _extId1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_EXT_ID_2" field.
        /// </summary>
        public String ExtId2
        {
            get { return _extId2; }
            set { _extId2 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_EXT_ID_3" field.
        /// </summary>
        public String ExtId3
        {
            get { return _extId3; }
            set { _extId3 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SECRET_PHONE" field.
        /// </summary>
        public String SecretPhone
        {
            get { return _secretPhone; }
            set { _secretPhone = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_LBST_DATE" field.
        /// </summary>
        public DateTime? LbstDate
        {
            get { return _lbstDate; }
            set { _lbstDate = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_POST_SPEC" field.
        /// </summary>
        public String PostSpec
        {
            get { return _postSpec; }
            set { _postSpec = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SCALE_POINT" field.
        /// </summary>
        public Int32? ScalePoint
        {
            get { return _scalePoint; }
            set { _scalePoint = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_GRADE_BAND" field.
        /// </summary>
        public String GradeBand
        {
            get { return _gradeBand; }
            set { _gradeBand = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DIS_FLAG" field.
        /// </summary>
        public Byte? DisFlag
        {
            get { return _disFlag; }
            set { _disFlag = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_WEB_PROF" field.
        /// </summary>
        public String WebProf
        {
            get { return _webProf; }
            set { _webProf = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_WEB_PASS" field.
        /// </summary>
        public String WebPass
        {
            get { return _webPass; }
            set { _webPass = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_CUSTOMER_ACC" field.
        /// </summary>
        public String CustomerAcc
        {
            get { return _customerAcc; }
            set { _customerAcc = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_CJT_ID" field.
        /// </summary>
        public String CjtId
        {
            get { return _cjtId; }
            set { _cjtId = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_PAYROLL" field.
        /// </summary>
        public String Payroll
        {
            get { return _payroll; }
            set { _payroll = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_STAFF_NO" field.
        /// </summary>
        public String StaffNo
        {
            get { return _staffNo; }
            set { _staffNo = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_COST_CENTRE" field.
        /// </summary>
        public String CostCentre
        {
            get { return _costCentre; }
            set { _costCentre = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_KEY_CONTACT" field.
        /// </summary>
        public Byte? KeyContact
        {
            get { return _keyContact; }
            set { _keyContact = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEM_C_TOT" field.
        /// </summary>
        public Double? MemCTot
        {
            get { return _memCTot; }
            set { _memCTot = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEM_R_TOT" field.
        /// </summary>
        public Double? MemRTot
        {
            get { return _memRTot; }
            set { _memRTot = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEM_L_TOT" field.
        /// </summary>
        public Double? MemLTot
        {
            get { return _memLTot; }
            set { _memLTot = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_CONTACT_MGR2" field.
        /// </summary>
        public String ContactMgr2
        {
            get { return _contactMgr2; }
            set { _contactMgr2 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return _userchar5; }
            set { _userchar5 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return _userchar6; }
            set { _userchar6 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_1" field.
        /// </summary>
        public Byte? Userint1
        {
            get { return _userint1; }
            set { _userint1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_2" field.
        /// </summary>
        public Byte? Userint2
        {
            get { return _userint2; }
            set { _userint2 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_3" field.
        /// </summary>
        public Byte? Userint3
        {
            get { return _userint3; }
            set { _userint3 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_4" field.
        /// </summary>
        public Byte? Userint4
        {
            get { return _userint4; }
            set { _userint4 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_5" field.
        /// </summary>
        public Byte? Userint5
        {
            get { return _userint5; }
            set { _userint5 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_6" field.
        /// </summary>
        public Byte? Userint6
        {
            get { return _userint6; }
            set { _userint6 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERNUM_3" field.
        /// </summary>
        public Decimal? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERNUM_4" field.
        /// </summary>
        public Decimal? Usernum4
        {
            get { return _usernum4; }
            set { _usernum4 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERNUM_5" field.
        /// </summary>
        public Decimal? Usernum5
        {
            get { return _usernum5; }
            set { _usernum5 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERNUM_6" field.
        /// </summary>
        public Decimal? Usernum6
        {
            get { return _usernum6; }
            set { _usernum6 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERDATE_1" field.
        /// </summary>
        public DateTime? Userdate1
        {
            get { return _userdate1; }
            set { _userdate1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERDATE_2" field.
        /// </summary>
        public DateTime? Userdate2
        {
            get { return _userdate2; }
            set { _userdate2 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERDATE_3" field.
        /// </summary>
        public DateTime? Userdate3
        {
            get { return _userdate3; }
            set { _userdate3 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERDATE_4" field.
        /// </summary>
        public DateTime? Userdate4
        {
            get { return _userdate4; }
            set { _userdate4 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERDATE_5" field.
        /// </summary>
        public DateTime? Userdate5
        {
            get { return _userdate5; }
            set { _userdate5 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERDATE_6" field.
        /// </summary>
        public DateTime? Userdate6
        {
            get { return _userdate6; }
            set { _userdate6 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_FAX" field.
        /// </summary>
        public Byte? DoNotFax
        {
            get { return _doNotFax; }
            set { _doNotFax = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        public Byte? DoNotEmail
        {
            get { return _doNotEmail; }
            set { _doNotEmail = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SWAP" field.
        /// </summary>
        public Byte? DoNotSwap
        {
            get { return _doNotSwap; }
            set { _doNotSwap = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SPARE" field.
        /// </summary>
        public Byte? DoNotSpare
        {
            get { return _doNotSpare; }
            set { _doNotSpare = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_PRIVATE_ADD" field.
        /// </summary>
        public Byte? PrivateAdd
        {
            get { return _privateAdd; }
            set { _privateAdd = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MAIN_WORKADD" field.
        /// </summary>
        public Byte? MainWorkadd
        {
            get { return _mainWorkadd; }
            set { _mainWorkadd = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MAIN_PRIVADD" field.
        /// </summary>
        public Byte? MainPrivadd
        {
            get { return _mainPrivadd; }
            set { _mainPrivadd = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_WORK_ADD" field.
        /// </summary>
        public Byte? WorkAdd
        {
            get { return _workAdd; }
            set { _workAdd = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_LM_PHONE" field.
        /// </summary>
        public String LmPhone
        {
            get { return _lmPhone; }
            set { _lmPhone = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_LM_EMAIL" field.
        /// </summary>
        public String LmEmail
        {
            get { return _lmEmail; }
            set { _lmEmail = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SERVICE" field.
        /// </summary>
        public String Service
        {
            get { return _service; }
            set { _service = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_PAY_LOCATION" field.
        /// </summary>
        public String PayLocation
        {
            get { return _payLocation; }
            set { _payLocation = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_BA" field.
        /// </summary>
        public String Ba
        {
            get { return _ba; }
            set { _ba = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_BA1" field.
        /// </summary>
        public String Ba1
        {
            get { return _ba1; }
            set { _ba1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_TRN_ADMIN" field.
        /// </summary>
        public Byte? TrnAdmin
        {
            get { return _trnAdmin; }
            set { _trnAdmin = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ATTRIB_NUM_01" field.
        /// </summary>
        public Int32? AttribNum01
        {
            get { return _attribNum01; }
            set { _attribNum01 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ATTRIB_CHAR_01" field.
        /// </summary>
        public String AttribChar01
        {
            get { return _attribChar01; }
            set { _attribChar01 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ATTRIB_TINT_01" field.
        /// </summary>
        public Byte? AttribTint01
        {
            get { return _attribTint01; }
            set { _attribTint01 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_WTE" field.
        /// </summary>
        public Decimal? Wte
        {
            get { return _wte; }
            set { _wte = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_PHONE_STD" field.
        /// </summary>
        public String PhoneStd
        {
            get { return _phoneStd; }
            set { _phoneStd = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_FAX_STD" field.
        /// </summary>
        public String FaxStd
        {
            get { return _faxStd; }
            set { _faxStd = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ALT_PHONE_STD" field.
        /// </summary>
        public String AltPhoneStd
        {
            get { return _altPhoneStd; }
            set { _altPhoneStd = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_ALT_FAX_STD" field.
        /// </summary>
        public String AltFaxStd
        {
            get { return _altFaxStd; }
            set { _altFaxStd = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SECRET_PHONE_STD" field.
        /// </summary>
        public String SecretPhoneStd
        {
            get { return _secretPhoneStd; }
            set { _secretPhoneStd = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_LM_PHONE_STD" field.
        /// </summary>
        public String LmPhoneStd
        {
            get { return _lmPhoneStd; }
            set { _lmPhoneStd = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DELIV_POINT1" field.
        /// </summary>
        public String DelivPoint1
        {
            get { return _delivPoint1; }
            set { _delivPoint1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DELIV_POINT2" field.
        /// </summary>
        public String DelivPoint2
        {
            get { return _delivPoint2; }
            set { _delivPoint2 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SHOW_ADDRESS" field.
        /// </summary>
        public Byte ShowAddress
        {
            get { return _showAddress; }
            set { _showAddress = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SHOW_PHONE" field.
        /// </summary>
        public Byte ShowPhone
        {
            get { return _showPhone; }
            set { _showPhone = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SHOW_EMAIL" field.
        /// </summary>
        public Byte ShowEmail
        {
            get { return _showEmail; }
            set { _showEmail = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEM_A_TOT" field.
        /// </summary>
        public Double? MemATot
        {
            get { return _memATot; }
            set { _memATot = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_CJT_ACHIEVED" field.
        /// </summary>
        public Byte? CjtAchieved
        {
            get { return _cjtAchieved; }
            set { _cjtAchieved = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEM_REF" field.
        /// </summary>
        public String MemRef
        {
            get { return _memRef; }
            set { _memRef = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_HOUR_RTE" field.
        /// </summary>
        public Decimal HourRte
        {
            get { return _hourRte; }
            set { _hourRte = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_BUDH_ID" field.
        /// </summary>
        public String BudhId
        {
            get { return _budhId; }
            set { _budhId = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_OS_ID" field.
        /// </summary>
        public Int32? OsId
        {
            get { return _osId; }
            set { _osId = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_JOB_LVL" field.
        /// </summary>
        public String JobLvl
        {
            get { return _jobLvl; }
            set { _jobLvl = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_REPORTS_TO_1" field.
        /// </summary>
        public String ReportsTo1
        {
            get { return _reportsTo1; }
            set { _reportsTo1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_OSU_ID" field.
        /// </summary>
        public Int32? OsuId
        {
            get { return _osuId; }
            set { _osuId = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_AJT_ID" field.
        /// </summary>
        public Int32? AjtId
        {
            get { return _ajtId; }
            set { _ajtId = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_UNIQUE_REF" field.
        /// </summary>
        public String UniqueRef
        {
            get { return _uniqueRef; }
            set { _uniqueRef = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SEND_TO_WHICH_EMAIL" field.
        /// </summary>
        public Byte SendToWhichEmail
        {
            get { return _sendToWhichEmail; }
            set { _sendToWhichEmail = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_REPTO_LINEAGE" field.
        /// </summary>
        public String ReptoLineage
        {
            get { return _reptoLineage; }
            set { _reptoLineage = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_REPTO_DEPTH" field.
        /// </summary>
        public Int32? ReptoDepth
        {
            get { return _reptoDepth; }
            set { _reptoDepth = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_1" field.
        /// </summary>
        public Byte MembCheck1
        {
            get { return _membCheck1; }
            set { _membCheck1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_2" field.
        /// </summary>
        public Byte MembCheck2
        {
            get { return _membCheck2; }
            set { _membCheck2 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_3" field.
        /// </summary>
        public Byte MembCheck3
        {
            get { return _membCheck3; }
            set { _membCheck3 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_4" field.
        /// </summary>
        public Byte MembCheck4
        {
            get { return _membCheck4; }
            set { _membCheck4 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_5" field.
        /// </summary>
        public Byte MembCheck5
        {
            get { return _membCheck5; }
            set { _membCheck5 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_6" field.
        /// </summary>
        public Byte MembCheck6
        {
            get { return _membCheck6; }
            set { _membCheck6 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_MEMB_CHECK_7" field.
        /// </summary>
        public Byte MembCheck7
        {
            get { return _membCheck7; }
            set { _membCheck7 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_7" field.
        /// </summary>
        public Byte? Userint7
        {
            get { return _userint7; }
            set { _userint7 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_8" field.
        /// </summary>
        public Byte? Userint8
        {
            get { return _userint8; }
            set { _userint8 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_9" field.
        /// </summary>
        public Byte? Userint9
        {
            get { return _userint9; }
            set { _userint9 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_10" field.
        /// </summary>
        public Byte? Userint10
        {
            get { return _userint10; }
            set { _userint10 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_USERINT_11" field.
        /// </summary>
        public Byte? Userint11
        {
            get { return _userint11; }
            set { _userint11 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_OVERSEAS" field.
        /// </summary>
        public Byte? Overseas
        {
            get { return _overseas; }
            set { _overseas = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_SEND_TO_WHICH_MOBILE" field.
        /// </summary>
        public Byte SendToWhichMobile
        {
            get { return _sendToWhichMobile; }
            set { _sendToWhichMobile = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SPARE1" field.
        /// </summary>
        public Byte? DoNotSpare1
        {
            get { return _doNotSpare1; }
            set { _doNotSpare1 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SPARE2" field.
        /// </summary>
        public Byte? DoNotSpare2
        {
            get { return _doNotSpare2; }
            set { _doNotSpare2 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SPARE3" field.
        /// </summary>
        public Byte? DoNotSpare3
        {
            get { return _doNotSpare3; }
            set { _doNotSpare3 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DO_NOT_SPARE4" field.
        /// </summary>
        public Byte? DoNotSpare4
        {
            get { return _doNotSpare4; }
            set { _doNotSpare4 = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_AREA" field.
        /// </summary>
        public String Area
        {
            get { return _area; }
            set { _area = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_REGION" field.
        /// </summary>
        public String Region
        {
            get { return _region; }
            set { _region = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_PROFILE_DESCRIPTION" field.
        /// </summary>
        public String ProfileDescription
        {
            get { return _profileDescription; }
            set { _profileDescription = value; }
        }

        /// <summary>
        ///     the value of the "PROLE_DEFAULT_PR_ID" field.
        /// </summary>
        public Int32? DefaultPrId
        {
            get { return _defaultPrId; }
            set { _defaultPrId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PersonRoleRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PersonRoleRecord" /> object instance.
        /// </returns>
        public PersonRoleRecord Clone()
        {
            PersonRoleRecord record = new PersonRoleRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.PersonId = this.PersonId;
            record.OrgId = this.OrgId;
            record.PosTitle = this.PosTitle;
            record.Dept = this.Dept;
            record.PosType = this.PosType;
            record.PosLevel = this.PosLevel;
            record.Phone = this.Phone;
            record.Fax = this.Fax;
            record.Mobile = this.Mobile;
            record.Email1 = this.Email1;
            record.ReportsTo = this.ReportsTo;
            record.Secretary = this.Secretary;
            record.PrincipRole = this.PrincipRole;
            record.DoNotMail = this.DoNotMail;
            record.AddId = this.AddId;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            record.UnionRolNo = this.UnionRolNo;
            record.BranchName = this.BranchName;
            record.FirstCourse = this.FirstCourse;
            record.Type = this.Type;
            record.AltPhone = this.AltPhone;
            record.AltFax = this.AltFax;
            record.Budget = this.Budget;
            record.NlCopies = this.NlCopies;
            record.UserType = this.UserType;
            record.UserType1 = this.UserType1;
            record.UserType2 = this.UserType2;
            record.UserType3 = this.UserType3;
            record.ExecCode = this.ExecCode;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Userchar3 = this.Userchar3;
            record.Userchar4 = this.Userchar4;
            record.Usernum1 = this.Usernum1;
            record.Usernum2 = this.Usernum2;
            record.Email = this.Email;
            record.OrgName = this.OrgName;
            record.PnName = this.PnName;
            record.ContactMgr = this.ContactMgr;
            record.Source = this.Source;
            record.MailLimit = this.MailLimit;
            record.Until = this.Until;
            record.MailNolimit = this.MailNolimit;
            record.ExtId1 = this.ExtId1;
            record.ExtId2 = this.ExtId2;
            record.ExtId3 = this.ExtId3;
            record.SecretPhone = this.SecretPhone;
            record.Notes = this.Notes;
            record.LbstDate = this.LbstDate;
            record.PostSpec = this.PostSpec;
            record.ScalePoint = this.ScalePoint;
            record.GradeBand = this.GradeBand;
            record.DisFlag = this.DisFlag;
            record.WebProf = this.WebProf;
            record.WebPass = this.WebPass;
            record.CustomerAcc = this.CustomerAcc;
            record.CjtId = this.CjtId;
            record.Payroll = this.Payroll;
            record.StaffNo = this.StaffNo;
            record.CostCentre = this.CostCentre;
            record.KeyContact = this.KeyContact;
            record.MemCTot = this.MemCTot;
            record.MemRTot = this.MemRTot;
            record.MemLTot = this.MemLTot;
            record.ContactMgr2 = this.ContactMgr2;
            record.Userchar5 = this.Userchar5;
            record.Userchar6 = this.Userchar6;
            record.Userint1 = this.Userint1;
            record.Userint2 = this.Userint2;
            record.Userint3 = this.Userint3;
            record.Userint4 = this.Userint4;
            record.Userint5 = this.Userint5;
            record.Userint6 = this.Userint6;
            record.Usernum3 = this.Usernum3;
            record.Usernum4 = this.Usernum4;
            record.Usernum5 = this.Usernum5;
            record.Usernum6 = this.Usernum6;
            record.Userdate1 = this.Userdate1;
            record.Userdate2 = this.Userdate2;
            record.Userdate3 = this.Userdate3;
            record.Userdate4 = this.Userdate4;
            record.Userdate5 = this.Userdate5;
            record.Userdate6 = this.Userdate6;
            record.DoNotFax = this.DoNotFax;
            record.DoNotEmail = this.DoNotEmail;
            record.DoNotSwap = this.DoNotSwap;
            record.DoNotSpare = this.DoNotSpare;
            record.PrivateAdd = this.PrivateAdd;
            record.CostCode = this.CostCode;
            record.MainWorkadd = this.MainWorkadd;
            record.MainPrivadd = this.MainPrivadd;
            record.WorkAdd = this.WorkAdd;
            record.LmPhone = this.LmPhone;
            record.LmEmail = this.LmEmail;
            record.Service = this.Service;
            record.PayLocation = this.PayLocation;
            record.Ba = this.Ba;
            record.Ba1 = this.Ba1;
            record.TrnAdmin = this.TrnAdmin;
            record.AttribNum01 = this.AttribNum01;
            record.AttribChar01 = this.AttribChar01;
            record.AttribTint01 = this.AttribTint01;
            record.Wte = this.Wte;
            record.PhoneStd = this.PhoneStd;
            record.FaxStd = this.FaxStd;
            record.AltPhoneStd = this.AltPhoneStd;
            record.AltFaxStd = this.AltFaxStd;
            record.SecretPhoneStd = this.SecretPhoneStd;
            record.LmPhoneStd = this.LmPhoneStd;
            record.DelivPoint1 = this.DelivPoint1;
            record.DelivPoint2 = this.DelivPoint2;
            record.ShowAddress = this.ShowAddress;
            record.ShowPhone = this.ShowPhone;
            record.ShowEmail = this.ShowEmail;
            record.MemATot = this.MemATot;
            record.SelcoSpId = this.SelcoSpId;
            record.CjtAchieved = this.CjtAchieved;
            record.MemRef = this.MemRef;
            record.HourRte = this.HourRte;
            record.BudhId = this.BudhId;
            record.OsId = this.OsId;
            record.JobLvl = this.JobLvl;
            record.ReportsTo1 = this.ReportsTo1;
            record.OsuId = this.OsuId;
            record.AjtId = this.AjtId;
            record.UniqueRef = this.UniqueRef;
            record.SendToWhichEmail = this.SendToWhichEmail;
            record.ReptoLineage = this.ReptoLineage;
            record.ReptoDepth = this.ReptoDepth;
            record.MembCheck1 = this.MembCheck1;
            record.MembCheck2 = this.MembCheck2;
            record.MembCheck3 = this.MembCheck3;
            record.MembCheck4 = this.MembCheck4;
            record.MembCheck5 = this.MembCheck5;
            record.MembCheck6 = this.MembCheck6;
            record.MembCheck7 = this.MembCheck7;
            record.Userint7 = this.Userint7;
            record.Userint8 = this.Userint8;
            record.Userint9 = this.Userint9;
            record.Userint10 = this.Userint10;
            record.Userint11 = this.Userint11;
            record.Overseas = this.Overseas;
            record.SendToWhichMobile = this.SendToWhichMobile;
            record.DoNotSpare1 = this.DoNotSpare1;
            record.DoNotSpare2 = this.DoNotSpare2;
            record.DoNotSpare3 = this.DoNotSpare3;
            record.DoNotSpare4 = this.DoNotSpare4;
            record.Area = this.Area;
            record.Region = this.Region;
            record.ProfileDescription = this.ProfileDescription;
            record.DefaultPrId = this.DefaultPrId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PersonRoleRecord" /> instance is equal to another <see cref="PersonRoleRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PersonRoleRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PersonRoleRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.PersonId.TrimOrNullify() == that.PersonId.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.PosTitle.TrimOrNullify() == that.PosTitle.TrimOrNullify());
            result = result && (this.Dept.TrimOrNullify() == that.Dept.TrimOrNullify());
            result = result && (this.PosType.TrimOrNullify() == that.PosType.TrimOrNullify());
            result = result && (this.PosLevel.TrimOrNullify() == that.PosLevel.TrimOrNullify());
            result = result && (this.Phone.TrimOrNullify() == that.Phone.TrimOrNullify());
            result = result && (this.Fax.TrimOrNullify() == that.Fax.TrimOrNullify());
            result = result && (this.Mobile.TrimOrNullify() == that.Mobile.TrimOrNullify());
            result = result && (this.Email1.TrimOrNullify() == that.Email1.TrimOrNullify());
            result = result && (this.ReportsTo.TrimOrNullify() == that.ReportsTo.TrimOrNullify());
            result = result && (this.Secretary.TrimOrNullify() == that.Secretary.TrimOrNullify());
            result = result && (this.PrincipRole == that.PrincipRole);
            result = result && (this.DoNotMail == that.DoNotMail);
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.UnionRolNo.TrimOrNullify() == that.UnionRolNo.TrimOrNullify());
            result = result && (this.BranchName.TrimOrNullify() == that.BranchName.TrimOrNullify());
            result = result && (this.FirstCourse == that.FirstCourse);
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.AltPhone.TrimOrNullify() == that.AltPhone.TrimOrNullify());
            result = result && (this.AltFax.TrimOrNullify() == that.AltFax.TrimOrNullify());
            result = result && (this.Budget == that.Budget);
            result = result && (this.NlCopies == that.NlCopies);
            result = result && (this.UserType.TrimOrNullify() == that.UserType.TrimOrNullify());
            result = result && (this.UserType1.TrimOrNullify() == that.UserType1.TrimOrNullify());
            result = result && (this.UserType2.TrimOrNullify() == that.UserType2.TrimOrNullify());
            result = result && (this.UserType3.TrimOrNullify() == that.UserType3.TrimOrNullify());
            result = result && (this.ExecCode.TrimOrNullify() == that.ExecCode.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Email.TrimOrNullify() == that.Email.TrimOrNullify());
            result = result && (this.OrgName.TrimOrNullify() == that.OrgName.TrimOrNullify());
            result = result && (this.PnName.TrimOrNullify() == that.PnName.TrimOrNullify());
            result = result && (this.ContactMgr.TrimOrNullify() == that.ContactMgr.TrimOrNullify());
            result = result && (this.Source.TrimOrNullify() == that.Source.TrimOrNullify());
            result = result && (this.MailLimit == that.MailLimit);
            result = result && (this.Until == that.Until);
            result = result && (this.MailNolimit == that.MailNolimit);
            result = result && (this.ExtId1.TrimOrNullify() == that.ExtId1.TrimOrNullify());
            result = result && (this.ExtId2.TrimOrNullify() == that.ExtId2.TrimOrNullify());
            result = result && (this.ExtId3.TrimOrNullify() == that.ExtId3.TrimOrNullify());
            result = result && (this.SecretPhone.TrimOrNullify() == that.SecretPhone.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.LbstDate == that.LbstDate);
            result = result && (this.PostSpec.TrimOrNullify() == that.PostSpec.TrimOrNullify());
            result = result && (this.ScalePoint == that.ScalePoint);
            result = result && (this.GradeBand.TrimOrNullify() == that.GradeBand.TrimOrNullify());
            result = result && (this.DisFlag == that.DisFlag);
            result = result && (this.WebProf.TrimOrNullify() == that.WebProf.TrimOrNullify());
            result = result && (this.WebPass.TrimOrNullify() == that.WebPass.TrimOrNullify());
            result = result && (this.CustomerAcc.TrimOrNullify() == that.CustomerAcc.TrimOrNullify());
            result = result && (this.CjtId.TrimOrNullify() == that.CjtId.TrimOrNullify());
            result = result && (this.Payroll.TrimOrNullify() == that.Payroll.TrimOrNullify());
            result = result && (this.StaffNo.TrimOrNullify() == that.StaffNo.TrimOrNullify());
            result = result && (this.CostCentre.TrimOrNullify() == that.CostCentre.TrimOrNullify());
            result = result && (this.KeyContact == that.KeyContact);
            result = result && (this.MemCTot == that.MemCTot);
            result = result && (this.MemRTot == that.MemRTot);
            result = result && (this.MemLTot == that.MemLTot);
            result = result && (this.ContactMgr2.TrimOrNullify() == that.ContactMgr2.TrimOrNullify());
            result = result && (this.Userchar5.TrimOrNullify() == that.Userchar5.TrimOrNullify());
            result = result && (this.Userchar6.TrimOrNullify() == that.Userchar6.TrimOrNullify());
            result = result && (this.Userint1 == that.Userint1);
            result = result && (this.Userint2 == that.Userint2);
            result = result && (this.Userint3 == that.Userint3);
            result = result && (this.Userint4 == that.Userint4);
            result = result && (this.Userint5 == that.Userint5);
            result = result && (this.Userint6 == that.Userint6);
            result = result && (this.Usernum3 == that.Usernum3);
            result = result && (this.Usernum4 == that.Usernum4);
            result = result && (this.Usernum5 == that.Usernum5);
            result = result && (this.Usernum6 == that.Usernum6);
            result = result && (this.Userdate1 == that.Userdate1);
            result = result && (this.Userdate2 == that.Userdate2);
            result = result && (this.Userdate3 == that.Userdate3);
            result = result && (this.Userdate4 == that.Userdate4);
            result = result && (this.Userdate5 == that.Userdate5);
            result = result && (this.Userdate6 == that.Userdate6);
            result = result && (this.DoNotFax == that.DoNotFax);
            result = result && (this.DoNotEmail == that.DoNotEmail);
            result = result && (this.DoNotSwap == that.DoNotSwap);
            result = result && (this.DoNotSpare == that.DoNotSpare);
            result = result && (this.PrivateAdd == that.PrivateAdd);
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.MainWorkadd == that.MainWorkadd);
            result = result && (this.MainPrivadd == that.MainPrivadd);
            result = result && (this.WorkAdd == that.WorkAdd);
            result = result && (this.LmPhone.TrimOrNullify() == that.LmPhone.TrimOrNullify());
            result = result && (this.LmEmail.TrimOrNullify() == that.LmEmail.TrimOrNullify());
            result = result && (this.Service.TrimOrNullify() == that.Service.TrimOrNullify());
            result = result && (this.PayLocation.TrimOrNullify() == that.PayLocation.TrimOrNullify());
            result = result && (this.Ba.TrimOrNullify() == that.Ba.TrimOrNullify());
            result = result && (this.Ba1.TrimOrNullify() == that.Ba1.TrimOrNullify());
            result = result && (this.TrnAdmin == that.TrnAdmin);
            result = result && (this.AttribNum01 == that.AttribNum01);
            result = result && (this.AttribChar01.TrimOrNullify() == that.AttribChar01.TrimOrNullify());
            result = result && (this.AttribTint01 == that.AttribTint01);
            result = result && (this.Wte == that.Wte);
            result = result && (this.PhoneStd.TrimOrNullify() == that.PhoneStd.TrimOrNullify());
            result = result && (this.FaxStd.TrimOrNullify() == that.FaxStd.TrimOrNullify());
            result = result && (this.AltPhoneStd.TrimOrNullify() == that.AltPhoneStd.TrimOrNullify());
            result = result && (this.AltFaxStd.TrimOrNullify() == that.AltFaxStd.TrimOrNullify());
            result = result && (this.SecretPhoneStd.TrimOrNullify() == that.SecretPhoneStd.TrimOrNullify());
            result = result && (this.LmPhoneStd.TrimOrNullify() == that.LmPhoneStd.TrimOrNullify());
            result = result && (this.DelivPoint1.TrimOrNullify() == that.DelivPoint1.TrimOrNullify());
            result = result && (this.DelivPoint2.TrimOrNullify() == that.DelivPoint2.TrimOrNullify());
            result = result && (this.ShowAddress == that.ShowAddress);
            result = result && (this.ShowPhone == that.ShowPhone);
            result = result && (this.ShowEmail == that.ShowEmail);
            result = result && (this.MemATot == that.MemATot);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.CjtAchieved == that.CjtAchieved);
            result = result && (this.MemRef.TrimOrNullify() == that.MemRef.TrimOrNullify());
            result = result && (this.HourRte == that.HourRte);
            result = result && (this.BudhId.TrimOrNullify() == that.BudhId.TrimOrNullify());
            result = result && (this.OsId == that.OsId);
            result = result && (this.JobLvl.TrimOrNullify() == that.JobLvl.TrimOrNullify());
            result = result && (this.ReportsTo1.TrimOrNullify() == that.ReportsTo1.TrimOrNullify());
            result = result && (this.OsuId == that.OsuId);
            result = result && (this.AjtId == that.AjtId);
            result = result && (this.UniqueRef.TrimOrNullify() == that.UniqueRef.TrimOrNullify());
            result = result && (this.SendToWhichEmail == that.SendToWhichEmail);
            result = result && (this.ReptoLineage.TrimOrNullify() == that.ReptoLineage.TrimOrNullify());
            result = result && (this.ReptoDepth == that.ReptoDepth);
            result = result && (this.MembCheck1 == that.MembCheck1);
            result = result && (this.MembCheck2 == that.MembCheck2);
            result = result && (this.MembCheck3 == that.MembCheck3);
            result = result && (this.MembCheck4 == that.MembCheck4);
            result = result && (this.MembCheck5 == that.MembCheck5);
            result = result && (this.MembCheck6 == that.MembCheck6);
            result = result && (this.MembCheck7 == that.MembCheck7);
            result = result && (this.Userint7 == that.Userint7);
            result = result && (this.Userint8 == that.Userint8);
            result = result && (this.Userint9 == that.Userint9);
            result = result && (this.Userint10 == that.Userint10);
            result = result && (this.Userint11 == that.Userint11);
            result = result && (this.Overseas == that.Overseas);
            result = result && (this.SendToWhichMobile == that.SendToWhichMobile);
            result = result && (this.DoNotSpare1 == that.DoNotSpare1);
            result = result && (this.DoNotSpare2 == that.DoNotSpare2);
            result = result && (this.DoNotSpare3 == that.DoNotSpare3);
            result = result && (this.DoNotSpare4 == that.DoNotSpare4);
            result = result && (this.Area.TrimOrNullify() == that.Area.TrimOrNullify());
            result = result && (this.Region.TrimOrNullify() == that.Region.TrimOrNullify());
            result = result && (this.ProfileDescription.TrimOrNullify() == that.ProfileDescription.TrimOrNullify());
            result = result && (this.DefaultPrId == that.DefaultPrId);
            return result;
        }

        #endregion
    }
}
