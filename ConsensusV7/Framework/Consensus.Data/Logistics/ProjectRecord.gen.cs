using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Logistics
{
    /// <summary>
    ///     Represents the "Project" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ProjectRecord : Record<String>, Cloneable<ProjectRecord>, IEquatable<ProjectRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PROJ_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PROJ_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PROJ_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PROJ_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PROJ_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PROJ_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PROJ_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "PROJ_MGR_ROLE_ID" field.
        /// </summary>
        private String _mgrRoleId;

        /// <summary>
        ///     the value of the "PROJ_PAY_TERMS" field.
        /// </summary>
        private String _payTerms;

        /// <summary>
        ///     the value of the "PROJ_CURR_SITU" field.
        /// </summary>
        private String _currSitu;

        /// <summary>
        ///     the value of the "PROJ_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "PROJ_VALUE" field.
        /// </summary>
        private Double? _value;

        /// <summary>
        ///     the value of the "PROJ_VAL_TO_DATE" field.
        /// </summary>
        private Double? _valToDate;

        /// <summary>
        ///     the value of the "PROJ_USERVAL_1" field.
        /// </summary>
        private Double? _userval1;

        /// <summary>
        ///     the value of the "PROJ_USERVAL_2" field.
        /// </summary>
        private Double? _userval2;

        /// <summary>
        ///     the value of the "PROJ_USERVAL_3" field.
        /// </summary>
        private Double? _userval3;

        /// <summary>
        ///     the value of the "PROJ_USERVAL_4" field.
        /// </summary>
        private Double? _userval4;

        /// <summary>
        ///     the value of the "PROJ_USERVAL_5" field.
        /// </summary>
        private Double? _userval5;

        /// <summary>
        ///     the value of the "PROJ_USERVAL_6" field.
        /// </summary>
        private Double? _userval6;

        /// <summary>
        ///     the value of the "PROJ_USERVAL_7" field.
        /// </summary>
        private Double? _userval7;

        /// <summary>
        ///     the value of the "PROJ_USERVAL_8" field.
        /// </summary>
        private Double? _userval8;

        /// <summary>
        ///     the value of the "PROJ_TIME_EST" field.
        /// </summary>
        private Double? _timeEst;

        /// <summary>
        ///     the value of the "PROJ_TIME_ACT" field.
        /// </summary>
        private Double? _timeAct;

        /// <summary>
        ///     the value of the "PROJ_USERTIME_1" field.
        /// </summary>
        private Double? _usertime1;

        /// <summary>
        ///     the value of the "PROJ_USERTIME_2" field.
        /// </summary>
        private Double? _usertime2;

        /// <summary>
        ///     the value of the "PROJ_USERTIME_3" field.
        /// </summary>
        private Double? _usertime3;

        /// <summary>
        ///     the value of the "PROJ_USERTIME_4" field.
        /// </summary>
        private Double? _usertime4;

        /// <summary>
        ///     the value of the "PROJ_USERTIME_5" field.
        /// </summary>
        private Double? _usertime5;

        /// <summary>
        ///     the value of the "PROJ_USERTIME_6" field.
        /// </summary>
        private Double? _usertime6;

        /// <summary>
        ///     the value of the "PROJ_USERTIME_7" field.
        /// </summary>
        private Double? _usertime7;

        /// <summary>
        ///     the value of the "PROJ_USERTIME_8" field.
        /// </summary>
        private Double? _usertime8;

        /// <summary>
        ///     the value of the "PROJ_CAT" field.
        /// </summary>
        private String _cat;

        /// <summary>
        ///     the value of the "PROJ_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "PROJ_QUOTE_ID" field.
        /// </summary>
        private String _quoteId;

        /// <summary>
        ///     the value of the "PROJ_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "PROJ_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PROJ_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "PROJ_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "PROJ_TRA_HOURS" field.
        /// </summary>
        private Double? _traHours;

        /// <summary>
        ///     the value of the "PROJ_HOU_CHARGE" field.
        /// </summary>
        private Double? _houCharge;

        /// <summary>
        ///     the value of the "PROJ_TRA_CHARGE" field.
        /// </summary>
        private Double? _traCharge;

        /// <summary>
        ///     the value of the "PROJ_TEMPLATE" field.
        /// </summary>
        private Byte? _template;

        /// <summary>
        ///     the value of the "PROJ_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "PROJ_INVOICED" field.
        /// </summary>
        private Byte? _invoiced;

        /// <summary>
        ///     the value of the "PROJ_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "PROJ_REV_CODE" field.
        /// </summary>
        private String _revCode;

        /// <summary>
        ///     the value of the "PROJ_OPP_ID" field.
        /// </summary>
        private String _oppId;

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "PROJ_CHARGABLE" field.
        /// </summary>
        private Byte? _chargable;

        /// <summary>
        ///     the value of the "PROJ_FOR_ATTN_OF" field.
        /// </summary>
        private String _forAttnOf;

        /// <summary>
        ///     the value of the "PROJ_PROJECT_DIR" field.
        /// </summary>
        private String _projectDir;

        /// <summary>
        ///     the value of the "PROJ_PROM_ID" field.
        /// </summary>
        private String _promId;

        /// <summary>
        ///     the value of the "PROJ_FEE_YEAR" field.
        /// </summary>
        private String _feeYear;

        /// <summary>
        ///     the value of the "PROJ_PRIORITY" field.
        /// </summary>
        private String _priority;

        /// <summary>
        ///     the value of the "PROJ_WORK_ORDER" field.
        /// </summary>
        private String _workOrder;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_01" field.
        /// </summary>
        private String _attribChar01;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_02" field.
        /// </summary>
        private String _attribChar02;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_03" field.
        /// </summary>
        private String _attribChar03;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_04" field.
        /// </summary>
        private String _attribChar04;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_05" field.
        /// </summary>
        private String _attribChar05;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_06" field.
        /// </summary>
        private String _attribChar06;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_TINT_01" field.
        /// </summary>
        private Byte? _attribTint01;

        /// <summary>
        ///     the value of the "PROJ_REF" field.
        /// </summary>
        private String _ref;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_07" field.
        /// </summary>
        private String _attribChar07;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_DATE_01" field.
        /// </summary>
        private DateTime? _attribDate01;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_DATE_02" field.
        /// </summary>
        private DateTime? _attribDate02;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_08" field.
        /// </summary>
        private String _attribChar08;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_09" field.
        /// </summary>
        private String _attribChar09;

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_10" field.
        /// </summary>
        private String _attribChar10;

        /// <summary>
        ///     the value of the "PROJ_BD_COMP_BY" field.
        /// </summary>
        private String _bdCompBy;

        /// <summary>
        ///     the value of the "PROJ_BD_COMP_DATE" field.
        /// </summary>
        private DateTime? _bdCompDate;

        /// <summary>
        ///     the value of the "PROJ_BD_TOT_ACT_COST" field.
        /// </summary>
        private Decimal? _bdTotActCost;

        /// <summary>
        ///     the value of the "PROJ_BD_STATUS" field.
        /// </summary>
        private String _bdStatus;

        /// <summary>
        ///     the value of the "PROJ_BD_PREP_BY" field.
        /// </summary>
        private String _bdPrepBy;

        /// <summary>
        ///     the value of the "PROJ_BD_PREP_DATE" field.
        /// </summary>
        private DateTime? _bdPrepDate;

        /// <summary>
        ///     the value of the "PROJ_BD_APP_BY" field.
        /// </summary>
        private String _bdAppBy;

        /// <summary>
        ///     the value of the "PROJ_BD_APP_DATE" field.
        /// </summary>
        private DateTime? _bdAppDate;

        /// <summary>
        ///     the value of the "PROJ_BD_TOT_EST_COST" field.
        /// </summary>
        private Decimal? _bdTotEstCost;

        /// <summary>
        ///     the value of the "PROJ_BD_PO_ID" field.
        /// </summary>
        private String _bdPoId;

        /// <summary>
        ///     the value of the "PROJ_MSPROJ_ID" field.
        /// </summary>
        private String _msprojId;

        /// <summary>
        ///     the value of the "PROJ_DROPDOWN_1" field.
        /// </summary>
        private String _dropdown1;

        /// <summary>
        ///     the value of the "PROJ_USERNUM_1" field.
        /// </summary>
        private Decimal? _usernum1;

        /// <summary>
        ///     the value of the "PROJ_USERNUM_2" field.
        /// </summary>
        private Decimal? _usernum2;

        /// <summary>
        ///     the value of the "PROJ_USERNUM_3" field.
        /// </summary>
        private Decimal? _usernum3;

        /// <summary>
        ///     the value of the "PROJ_USERNUM_4" field.
        /// </summary>
        private Decimal? _usernum4;

        /// <summary>
        ///     the value of the "PROJ_USERNUM_5" field.
        /// </summary>
        private Decimal? _usernum5;

        /// <summary>
        ///     the value of the "PROJ_USERNUM_6" field.
        /// </summary>
        private Decimal? _usernum6;

        /// <summary>
        ///     the value of the "PROJ_USERINT_1" field.
        /// </summary>
        private Byte? _userint1;

        /// <summary>
        ///     the value of the "PROJ_USERINT_2" field.
        /// </summary>
        private Byte? _userint2;

        /// <summary>
        ///     the value of the "PROJ_USERINT_3" field.
        /// </summary>
        private Byte? _userint3;

        /// <summary>
        ///     the value of the "PROJ_USERINT_4" field.
        /// </summary>
        private Byte? _userint4;

        /// <summary>
        ///     the value of the "PROJ_USERINT_5" field.
        /// </summary>
        private Byte? _userint5;

        /// <summary>
        ///     the value of the "PROJ_USERINT_6" field.
        /// </summary>
        private Byte? _userint6;

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_5" field.
        /// </summary>
        private String _userchar5;

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_6" field.
        /// </summary>
        private String _userchar6;

        /// <summary>
        ///     the value of the "PROJ_USERDATE_1" field.
        /// </summary>
        private DateTime? _userdate1;

        /// <summary>
        ///     the value of the "PROJ_USERDATE_2" field.
        /// </summary>
        private DateTime? _userdate2;

        /// <summary>
        ///     the value of the "PROJ_USERDATE_3" field.
        /// </summary>
        private DateTime? _userdate3;

        /// <summary>
        ///     the value of the "PROJ_USERDATE_4" field.
        /// </summary>
        private DateTime? _userdate4;

        /// <summary>
        ///     the value of the "PROJ_USERDATE_5" field.
        /// </summary>
        private DateTime? _userdate5;

        /// <summary>
        ///     the value of the "PROJ_USERDATE_6" field.
        /// </summary>
        private DateTime? _userdate6;

        /// <summary>
        ///     the value of the "PROJ_RANDS" field.
        /// </summary>
        private Byte _rands;

        /// <summary>
        ///     the value of the "PROJ_BOOK_ID" field.
        /// </summary>
        private String _bookId;

        /// <summary>
        ///     the value of the "PROJ_QUO_ID" field.
        /// </summary>
        private String _quoId;

        /// <summary>
        ///     the value of the "PROJ_WEB" field.
        /// </summary>
        private Byte _web;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PROJ_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_MGR_ROLE_ID" field.
        /// </summary>
        public String MgrRoleId
        {
            get { return _mgrRoleId; }
            set { _mgrRoleId = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_PAY_TERMS" field.
        /// </summary>
        public String PayTerms
        {
            get { return _payTerms; }
            set { _payTerms = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_CURR_SITU" field.
        /// </summary>
        public String CurrSitu
        {
            get { return _currSitu; }
            set { _currSitu = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_VALUE" field.
        /// </summary>
        public Double? Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_VAL_TO_DATE" field.
        /// </summary>
        public Double? ValToDate
        {
            get { return _valToDate; }
            set { _valToDate = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERVAL_1" field.
        /// </summary>
        public Double? Userval1
        {
            get { return _userval1; }
            set { _userval1 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERVAL_2" field.
        /// </summary>
        public Double? Userval2
        {
            get { return _userval2; }
            set { _userval2 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERVAL_3" field.
        /// </summary>
        public Double? Userval3
        {
            get { return _userval3; }
            set { _userval3 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERVAL_4" field.
        /// </summary>
        public Double? Userval4
        {
            get { return _userval4; }
            set { _userval4 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERVAL_5" field.
        /// </summary>
        public Double? Userval5
        {
            get { return _userval5; }
            set { _userval5 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERVAL_6" field.
        /// </summary>
        public Double? Userval6
        {
            get { return _userval6; }
            set { _userval6 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERVAL_7" field.
        /// </summary>
        public Double? Userval7
        {
            get { return _userval7; }
            set { _userval7 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERVAL_8" field.
        /// </summary>
        public Double? Userval8
        {
            get { return _userval8; }
            set { _userval8 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_TIME_EST" field.
        /// </summary>
        public Double? TimeEst
        {
            get { return _timeEst; }
            set { _timeEst = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_TIME_ACT" field.
        /// </summary>
        public Double? TimeAct
        {
            get { return _timeAct; }
            set { _timeAct = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERTIME_1" field.
        /// </summary>
        public Double? Usertime1
        {
            get { return _usertime1; }
            set { _usertime1 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERTIME_2" field.
        /// </summary>
        public Double? Usertime2
        {
            get { return _usertime2; }
            set { _usertime2 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERTIME_3" field.
        /// </summary>
        public Double? Usertime3
        {
            get { return _usertime3; }
            set { _usertime3 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERTIME_4" field.
        /// </summary>
        public Double? Usertime4
        {
            get { return _usertime4; }
            set { _usertime4 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERTIME_5" field.
        /// </summary>
        public Double? Usertime5
        {
            get { return _usertime5; }
            set { _usertime5 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERTIME_6" field.
        /// </summary>
        public Double? Usertime6
        {
            get { return _usertime6; }
            set { _usertime6 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERTIME_7" field.
        /// </summary>
        public Double? Usertime7
        {
            get { return _usertime7; }
            set { _usertime7 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERTIME_8" field.
        /// </summary>
        public Double? Usertime8
        {
            get { return _usertime8; }
            set { _usertime8 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_CAT" field.
        /// </summary>
        public String Cat
        {
            get { return _cat; }
            set { _cat = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_QUOTE_ID" field.
        /// </summary>
        public String QuoteId
        {
            get { return _quoteId; }
            set { _quoteId = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_TRA_HOURS" field.
        /// </summary>
        public Double? TraHours
        {
            get { return _traHours; }
            set { _traHours = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_HOU_CHARGE" field.
        /// </summary>
        public Double? HouCharge
        {
            get { return _houCharge; }
            set { _houCharge = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_TRA_CHARGE" field.
        /// </summary>
        public Double? TraCharge
        {
            get { return _traCharge; }
            set { _traCharge = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_TEMPLATE" field.
        /// </summary>
        public Byte? Template
        {
            get { return _template; }
            set { _template = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_INVOICED" field.
        /// </summary>
        public Byte? Invoiced
        {
            get { return _invoiced; }
            set { _invoiced = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return _revCode; }
            set { _revCode = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_OPP_ID" field.
        /// </summary>
        public String OppId
        {
            get { return _oppId; }
            set { _oppId = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_CHARGABLE" field.
        /// </summary>
        public Byte? Chargable
        {
            get { return _chargable; }
            set { _chargable = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_FOR_ATTN_OF" field.
        /// </summary>
        public String ForAttnOf
        {
            get { return _forAttnOf; }
            set { _forAttnOf = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_PROJECT_DIR" field.
        /// </summary>
        public String ProjectDir
        {
            get { return _projectDir; }
            set { _projectDir = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_PROM_ID" field.
        /// </summary>
        public String PromId
        {
            get { return _promId; }
            set { _promId = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_FEE_YEAR" field.
        /// </summary>
        public String FeeYear
        {
            get { return _feeYear; }
            set { _feeYear = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_PRIORITY" field.
        /// </summary>
        public String Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_WORK_ORDER" field.
        /// </summary>
        public String WorkOrder
        {
            get { return _workOrder; }
            set { _workOrder = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_01" field.
        /// </summary>
        public String AttribChar01
        {
            get { return _attribChar01; }
            set { _attribChar01 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_02" field.
        /// </summary>
        public String AttribChar02
        {
            get { return _attribChar02; }
            set { _attribChar02 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_03" field.
        /// </summary>
        public String AttribChar03
        {
            get { return _attribChar03; }
            set { _attribChar03 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_04" field.
        /// </summary>
        public String AttribChar04
        {
            get { return _attribChar04; }
            set { _attribChar04 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_05" field.
        /// </summary>
        public String AttribChar05
        {
            get { return _attribChar05; }
            set { _attribChar05 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_06" field.
        /// </summary>
        public String AttribChar06
        {
            get { return _attribChar06; }
            set { _attribChar06 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_TINT_01" field.
        /// </summary>
        public Byte? AttribTint01
        {
            get { return _attribTint01; }
            set { _attribTint01 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_REF" field.
        /// </summary>
        public String Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_07" field.
        /// </summary>
        public String AttribChar07
        {
            get { return _attribChar07; }
            set { _attribChar07 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_DATE_01" field.
        /// </summary>
        public DateTime? AttribDate01
        {
            get { return _attribDate01; }
            set { _attribDate01 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_DATE_02" field.
        /// </summary>
        public DateTime? AttribDate02
        {
            get { return _attribDate02; }
            set { _attribDate02 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_08" field.
        /// </summary>
        public String AttribChar08
        {
            get { return _attribChar08; }
            set { _attribChar08 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_09" field.
        /// </summary>
        public String AttribChar09
        {
            get { return _attribChar09; }
            set { _attribChar09 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_ATTRIB_CHAR_10" field.
        /// </summary>
        public String AttribChar10
        {
            get { return _attribChar10; }
            set { _attribChar10 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BD_COMP_BY" field.
        /// </summary>
        public String BdCompBy
        {
            get { return _bdCompBy; }
            set { _bdCompBy = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BD_COMP_DATE" field.
        /// </summary>
        public DateTime? BdCompDate
        {
            get { return _bdCompDate; }
            set { _bdCompDate = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BD_TOT_ACT_COST" field.
        /// </summary>
        public Decimal? BdTotActCost
        {
            get { return _bdTotActCost; }
            set { _bdTotActCost = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BD_STATUS" field.
        /// </summary>
        public String BdStatus
        {
            get { return _bdStatus; }
            set { _bdStatus = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BD_PREP_BY" field.
        /// </summary>
        public String BdPrepBy
        {
            get { return _bdPrepBy; }
            set { _bdPrepBy = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BD_PREP_DATE" field.
        /// </summary>
        public DateTime? BdPrepDate
        {
            get { return _bdPrepDate; }
            set { _bdPrepDate = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BD_APP_BY" field.
        /// </summary>
        public String BdAppBy
        {
            get { return _bdAppBy; }
            set { _bdAppBy = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BD_APP_DATE" field.
        /// </summary>
        public DateTime? BdAppDate
        {
            get { return _bdAppDate; }
            set { _bdAppDate = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BD_TOT_EST_COST" field.
        /// </summary>
        public Decimal? BdTotEstCost
        {
            get { return _bdTotEstCost; }
            set { _bdTotEstCost = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BD_PO_ID" field.
        /// </summary>
        public String BdPoId
        {
            get { return _bdPoId; }
            set { _bdPoId = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_MSPROJ_ID" field.
        /// </summary>
        public String MsprojId
        {
            get { return _msprojId; }
            set { _msprojId = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_DROPDOWN_1" field.
        /// </summary>
        public String Dropdown1
        {
            get { return _dropdown1; }
            set { _dropdown1 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERNUM_1" field.
        /// </summary>
        public Decimal? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERNUM_2" field.
        /// </summary>
        public Decimal? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERNUM_3" field.
        /// </summary>
        public Decimal? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERNUM_4" field.
        /// </summary>
        public Decimal? Usernum4
        {
            get { return _usernum4; }
            set { _usernum4 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERNUM_5" field.
        /// </summary>
        public Decimal? Usernum5
        {
            get { return _usernum5; }
            set { _usernum5 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERNUM_6" field.
        /// </summary>
        public Decimal? Usernum6
        {
            get { return _usernum6; }
            set { _usernum6 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERINT_1" field.
        /// </summary>
        public Byte? Userint1
        {
            get { return _userint1; }
            set { _userint1 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERINT_2" field.
        /// </summary>
        public Byte? Userint2
        {
            get { return _userint2; }
            set { _userint2 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERINT_3" field.
        /// </summary>
        public Byte? Userint3
        {
            get { return _userint3; }
            set { _userint3 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERINT_4" field.
        /// </summary>
        public Byte? Userint4
        {
            get { return _userint4; }
            set { _userint4 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERINT_5" field.
        /// </summary>
        public Byte? Userint5
        {
            get { return _userint5; }
            set { _userint5 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERINT_6" field.
        /// </summary>
        public Byte? Userint6
        {
            get { return _userint6; }
            set { _userint6 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return _userchar5; }
            set { _userchar5 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return _userchar6; }
            set { _userchar6 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERDATE_1" field.
        /// </summary>
        public DateTime? Userdate1
        {
            get { return _userdate1; }
            set { _userdate1 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERDATE_2" field.
        /// </summary>
        public DateTime? Userdate2
        {
            get { return _userdate2; }
            set { _userdate2 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERDATE_3" field.
        /// </summary>
        public DateTime? Userdate3
        {
            get { return _userdate3; }
            set { _userdate3 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERDATE_4" field.
        /// </summary>
        public DateTime? Userdate4
        {
            get { return _userdate4; }
            set { _userdate4 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERDATE_5" field.
        /// </summary>
        public DateTime? Userdate5
        {
            get { return _userdate5; }
            set { _userdate5 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_USERDATE_6" field.
        /// </summary>
        public DateTime? Userdate6
        {
            get { return _userdate6; }
            set { _userdate6 = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_RANDS" field.
        /// </summary>
        public Byte Rands
        {
            get { return _rands; }
            set { _rands = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_BOOK_ID" field.
        /// </summary>
        public String BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_QUO_ID" field.
        /// </summary>
        public String QuoId
        {
            get { return _quoId; }
            set { _quoId = value; }
        }

        /// <summary>
        ///     the value of the "PROJ_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return _web; }
            set { _web = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ProjectRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ProjectRecord" /> object instance.
        /// </returns>
        public ProjectRecord Clone()
        {
            ProjectRecord record = new ProjectRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Status = this.Status;
            record.MgrRoleId = this.MgrRoleId;
            record.PayTerms = this.PayTerms;
            record.CurrSitu = this.CurrSitu;
            record.Notes = this.Notes;
            record.Value = this.Value;
            record.ValToDate = this.ValToDate;
            record.Userval1 = this.Userval1;
            record.Userval2 = this.Userval2;
            record.Userval3 = this.Userval3;
            record.Userval4 = this.Userval4;
            record.Userval5 = this.Userval5;
            record.Userval6 = this.Userval6;
            record.Userval7 = this.Userval7;
            record.Userval8 = this.Userval8;
            record.TimeEst = this.TimeEst;
            record.TimeAct = this.TimeAct;
            record.Usertime1 = this.Usertime1;
            record.Usertime2 = this.Usertime2;
            record.Usertime3 = this.Usertime3;
            record.Usertime4 = this.Usertime4;
            record.Usertime5 = this.Usertime5;
            record.Usertime6 = this.Usertime6;
            record.Usertime7 = this.Usertime7;
            record.Usertime8 = this.Usertime8;
            record.Cat = this.Cat;
            record.OrgId = this.OrgId;
            record.QuoteId = this.QuoteId;
            record.Name = this.Name;
            record.Lock = this.Lock;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            record.TraHours = this.TraHours;
            record.HouCharge = this.HouCharge;
            record.TraCharge = this.TraCharge;
            record.Template = this.Template;
            record.SelcoSpId = this.SelcoSpId;
            record.Invoiced = this.Invoiced;
            record.CostCode = this.CostCode;
            record.RevCode = this.RevCode;
            record.OppId = this.OppId;
            record.Userchar1 = this.Userchar1;
            record.Chargable = this.Chargable;
            record.ForAttnOf = this.ForAttnOf;
            record.ProjectDir = this.ProjectDir;
            record.PromId = this.PromId;
            record.FeeYear = this.FeeYear;
            record.Priority = this.Priority;
            record.WorkOrder = this.WorkOrder;
            record.AttribChar01 = this.AttribChar01;
            record.AttribChar02 = this.AttribChar02;
            record.AttribChar03 = this.AttribChar03;
            record.AttribChar04 = this.AttribChar04;
            record.AttribChar05 = this.AttribChar05;
            record.AttribChar06 = this.AttribChar06;
            record.AttribTint01 = this.AttribTint01;
            record.Ref = this.Ref;
            record.AttribChar07 = this.AttribChar07;
            record.AttribDate01 = this.AttribDate01;
            record.AttribDate02 = this.AttribDate02;
            record.AttribChar08 = this.AttribChar08;
            record.AttribChar09 = this.AttribChar09;
            record.AttribChar10 = this.AttribChar10;
            record.BdCompBy = this.BdCompBy;
            record.BdCompDate = this.BdCompDate;
            record.BdTotActCost = this.BdTotActCost;
            record.BdStatus = this.BdStatus;
            record.BdPrepBy = this.BdPrepBy;
            record.BdPrepDate = this.BdPrepDate;
            record.BdAppBy = this.BdAppBy;
            record.BdAppDate = this.BdAppDate;
            record.BdTotEstCost = this.BdTotEstCost;
            record.BdPoId = this.BdPoId;
            record.MsprojId = this.MsprojId;
            record.Dropdown1 = this.Dropdown1;
            record.Usernum1 = this.Usernum1;
            record.Usernum2 = this.Usernum2;
            record.Usernum3 = this.Usernum3;
            record.Usernum4 = this.Usernum4;
            record.Usernum5 = this.Usernum5;
            record.Usernum6 = this.Usernum6;
            record.Userint1 = this.Userint1;
            record.Userint2 = this.Userint2;
            record.Userint3 = this.Userint3;
            record.Userint4 = this.Userint4;
            record.Userint5 = this.Userint5;
            record.Userint6 = this.Userint6;
            record.Userchar2 = this.Userchar2;
            record.Userchar3 = this.Userchar3;
            record.Userchar4 = this.Userchar4;
            record.Userchar5 = this.Userchar5;
            record.Userchar6 = this.Userchar6;
            record.Userdate1 = this.Userdate1;
            record.Userdate2 = this.Userdate2;
            record.Userdate3 = this.Userdate3;
            record.Userdate4 = this.Userdate4;
            record.Userdate5 = this.Userdate5;
            record.Userdate6 = this.Userdate6;
            record.Rands = this.Rands;
            record.BookId = this.BookId;
            record.QuoId = this.QuoId;
            record.Web = this.Web;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ProjectRecord" /> instance is equal to another <see cref="ProjectRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ProjectRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ProjectRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.MgrRoleId.TrimOrNullify() == that.MgrRoleId.TrimOrNullify());
            result = result && (this.PayTerms.TrimOrNullify() == that.PayTerms.TrimOrNullify());
            result = result && (this.CurrSitu.TrimOrNullify() == that.CurrSitu.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Value == that.Value);
            result = result && (this.ValToDate == that.ValToDate);
            result = result && (this.Userval1 == that.Userval1);
            result = result && (this.Userval2 == that.Userval2);
            result = result && (this.Userval3 == that.Userval3);
            result = result && (this.Userval4 == that.Userval4);
            result = result && (this.Userval5 == that.Userval5);
            result = result && (this.Userval6 == that.Userval6);
            result = result && (this.Userval7 == that.Userval7);
            result = result && (this.Userval8 == that.Userval8);
            result = result && (this.TimeEst == that.TimeEst);
            result = result && (this.TimeAct == that.TimeAct);
            result = result && (this.Usertime1 == that.Usertime1);
            result = result && (this.Usertime2 == that.Usertime2);
            result = result && (this.Usertime3 == that.Usertime3);
            result = result && (this.Usertime4 == that.Usertime4);
            result = result && (this.Usertime5 == that.Usertime5);
            result = result && (this.Usertime6 == that.Usertime6);
            result = result && (this.Usertime7 == that.Usertime7);
            result = result && (this.Usertime8 == that.Usertime8);
            result = result && (this.Cat.TrimOrNullify() == that.Cat.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.QuoteId.TrimOrNullify() == that.QuoteId.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.TraHours == that.TraHours);
            result = result && (this.HouCharge == that.HouCharge);
            result = result && (this.TraCharge == that.TraCharge);
            result = result && (this.Template == that.Template);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.Invoiced == that.Invoiced);
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.RevCode.TrimOrNullify() == that.RevCode.TrimOrNullify());
            result = result && (this.OppId.TrimOrNullify() == that.OppId.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Chargable == that.Chargable);
            result = result && (this.ForAttnOf.TrimOrNullify() == that.ForAttnOf.TrimOrNullify());
            result = result && (this.ProjectDir.TrimOrNullify() == that.ProjectDir.TrimOrNullify());
            result = result && (this.PromId.TrimOrNullify() == that.PromId.TrimOrNullify());
            result = result && (this.FeeYear.TrimOrNullify() == that.FeeYear.TrimOrNullify());
            result = result && (this.Priority.TrimOrNullify() == that.Priority.TrimOrNullify());
            result = result && (this.WorkOrder.TrimOrNullify() == that.WorkOrder.TrimOrNullify());
            result = result && (this.AttribChar01.TrimOrNullify() == that.AttribChar01.TrimOrNullify());
            result = result && (this.AttribChar02.TrimOrNullify() == that.AttribChar02.TrimOrNullify());
            result = result && (this.AttribChar03.TrimOrNullify() == that.AttribChar03.TrimOrNullify());
            result = result && (this.AttribChar04.TrimOrNullify() == that.AttribChar04.TrimOrNullify());
            result = result && (this.AttribChar05.TrimOrNullify() == that.AttribChar05.TrimOrNullify());
            result = result && (this.AttribChar06.TrimOrNullify() == that.AttribChar06.TrimOrNullify());
            result = result && (this.AttribTint01 == that.AttribTint01);
            result = result && (this.Ref.TrimOrNullify() == that.Ref.TrimOrNullify());
            result = result && (this.AttribChar07.TrimOrNullify() == that.AttribChar07.TrimOrNullify());
            result = result && (this.AttribDate01 == that.AttribDate01);
            result = result && (this.AttribDate02 == that.AttribDate02);
            result = result && (this.AttribChar08.TrimOrNullify() == that.AttribChar08.TrimOrNullify());
            result = result && (this.AttribChar09.TrimOrNullify() == that.AttribChar09.TrimOrNullify());
            result = result && (this.AttribChar10.TrimOrNullify() == that.AttribChar10.TrimOrNullify());
            result = result && (this.BdCompBy.TrimOrNullify() == that.BdCompBy.TrimOrNullify());
            result = result && (this.BdCompDate == that.BdCompDate);
            result = result && (this.BdTotActCost == that.BdTotActCost);
            result = result && (this.BdStatus.TrimOrNullify() == that.BdStatus.TrimOrNullify());
            result = result && (this.BdPrepBy.TrimOrNullify() == that.BdPrepBy.TrimOrNullify());
            result = result && (this.BdPrepDate == that.BdPrepDate);
            result = result && (this.BdAppBy.TrimOrNullify() == that.BdAppBy.TrimOrNullify());
            result = result && (this.BdAppDate == that.BdAppDate);
            result = result && (this.BdTotEstCost == that.BdTotEstCost);
            result = result && (this.BdPoId.TrimOrNullify() == that.BdPoId.TrimOrNullify());
            result = result && (this.MsprojId.TrimOrNullify() == that.MsprojId.TrimOrNullify());
            result = result && (this.Dropdown1.TrimOrNullify() == that.Dropdown1.TrimOrNullify());
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Usernum3 == that.Usernum3);
            result = result && (this.Usernum4 == that.Usernum4);
            result = result && (this.Usernum5 == that.Usernum5);
            result = result && (this.Usernum6 == that.Usernum6);
            result = result && (this.Userint1 == that.Userint1);
            result = result && (this.Userint2 == that.Userint2);
            result = result && (this.Userint3 == that.Userint3);
            result = result && (this.Userint4 == that.Userint4);
            result = result && (this.Userint5 == that.Userint5);
            result = result && (this.Userint6 == that.Userint6);
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.Userchar5.TrimOrNullify() == that.Userchar5.TrimOrNullify());
            result = result && (this.Userchar6.TrimOrNullify() == that.Userchar6.TrimOrNullify());
            result = result && (this.Userdate1 == that.Userdate1);
            result = result && (this.Userdate2 == that.Userdate2);
            result = result && (this.Userdate3 == that.Userdate3);
            result = result && (this.Userdate4 == that.Userdate4);
            result = result && (this.Userdate5 == that.Userdate5);
            result = result && (this.Userdate6 == that.Userdate6);
            result = result && (this.Rands == that.Rands);
            result = result && (this.BookId.TrimOrNullify() == that.BookId.TrimOrNullify());
            result = result && (this.QuoId.TrimOrNullify() == that.QuoId.TrimOrNullify());
            result = result && (this.Web == that.Web);
            return result;
        }

        #endregion
    }
}
