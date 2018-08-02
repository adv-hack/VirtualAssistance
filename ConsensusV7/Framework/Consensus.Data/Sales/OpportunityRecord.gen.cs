using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Represents the "Opportunity" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class OpportunityRecord : Record<String>, Cloneable<OpportunityRecord>, IEquatable<OpportunityRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "OPP_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "OPP_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "OPP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "OPP_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "OPP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "OPP_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "OPP_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "OPP_QUO_ID" field.
        /// </summary>
        private String _quoId;

        /// <summary>
        ///     the value of the "OPP_PROM_ID" field.
        /// </summary>
        private String _promId;

        /// <summary>
        ///     the value of the "OPP_PROLE_ID_SALES" field.
        /// </summary>
        private String _proleIdSales;

        /// <summary>
        ///     the value of the "OPP_PROLE_ID_TAKEN" field.
        /// </summary>
        private String _proleIdTaken;

        /// <summary>
        ///     the value of the "OPP_SCH_ID" field.
        /// </summary>
        private String _schId;

        /// <summary>
        ///     the value of the "OPP_TEXT_ID" field.
        /// </summary>
        private String _textId;

        /// <summary>
        ///     the value of the "OPP_TEXT_ID_HIS" field.
        /// </summary>
        private String _textIdHis;

        /// <summary>
        ///     the value of the "OPP_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "OPP_STATUS_MKT" field.
        /// </summary>
        private String _statusMkt;

        /// <summary>
        ///     the value of the "OPP_PERIOD" field.
        /// </summary>
        private String _period;

        /// <summary>
        ///     the value of the "OPP_DATE_ENQ" field.
        /// </summary>
        private DateTime? _dateEnq;

        /// <summary>
        ///     the value of the "OPP_DATE_DEC" field.
        /// </summary>
        private DateTime? _dateDec;

        /// <summary>
        ///     the value of the "OPP_VAL_POT" field.
        /// </summary>
        private Double? _valPot;

        /// <summary>
        ///     the value of the "OPP_VAL_SOLD" field.
        /// </summary>
        private Double? _valSold;

        /// <summary>
        ///     the value of the "OPP_LOST_TO" field.
        /// </summary>
        private String _lostTo;

        /// <summary>
        ///     the value of the "OPP_LOST_REA" field.
        /// </summary>
        private String _lostRea;

        /// <summary>
        ///     the value of the "OPP_DATE_NEXT" field.
        /// </summary>
        private DateTime? _dateNext;

        /// <summary>
        ///     the value of the "OPP_QUO_REF" field.
        /// </summary>
        private String _quoRef;

        /// <summary>
        ///     the value of the "OPP_QUO_DATE" field.
        /// </summary>
        private DateTime? _quoDate;

        /// <summary>
        ///     the value of the "OPP_QUO_VAL" field.
        /// </summary>
        private Double? _quoVal;

        /// <summary>
        ///     the value of the "OPP_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "OPP_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "OPP_PROB_PURCH" field.
        /// </summary>
        private Byte? _probPurch;

        /// <summary>
        ///     the value of the "OPP_PROB_WIN" field.
        /// </summary>
        private Byte? _probWin;

        /// <summary>
        ///     the value of the "OPP_DATE_ROL_START" field.
        /// </summary>
        private DateTime? _dateRolStart;

        /// <summary>
        ///     the value of the "OPP_PERD_ROLL" field.
        /// </summary>
        private String _perdRoll;

        /// <summary>
        ///     the value of the "OPP_INC_ROLL" field.
        /// </summary>
        private Byte? _incRoll;

        /// <summary>
        ///     the value of the "OPP_INC_START" field.
        /// </summary>
        private DateTime? _incStart;

        /// <summary>
        ///     the value of the "OPP_INC_END" field.
        /// </summary>
        private DateTime? _incEnd;

        /// <summary>
        ///     the value of the "OPP_DATE_ROLL_END" field.
        /// </summary>
        private DateTime? _dateRollEnd;

        /// <summary>
        ///     the value of the "OPP_NOTE_ROLL" field.
        /// </summary>
        private String _noteRoll;

        /// <summary>
        ///     the value of the "OPP_ROLL_QTY" field.
        /// </summary>
        private Double? _rollQty;

        /// <summary>
        ///     the value of the "OPP_ROLL_COST" field.
        /// </summary>
        private Double? _rollCost;

        /// <summary>
        ///     the value of the "OPP_ROLL_RET" field.
        /// </summary>
        private Double? _rollRet;

        /// <summary>
        ///     the value of the "OPP_VAL_POT_BC" field.
        /// </summary>
        private Double? _valPotBc;

        /// <summary>
        ///     the value of the "OPP_VAL_SOLD_BC" field.
        /// </summary>
        private Double? _valSoldBc;

        /// <summary>
        ///     the value of the "OPP_QUO_VAL_BC" field.
        /// </summary>
        private Double? _quoValBc;

        /// <summary>
        ///     the value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        private String _prodInterest;

        /// <summary>
        ///     the value of the "OPP_SM_FORCST_DATE" field.
        /// </summary>
        private DateTime? _smForcstDate;

        /// <summary>
        ///     the value of the "OPP_SM_VALUE" field.
        /// </summary>
        private Double? _smValue;

        /// <summary>
        ///     the value of the "OPP_SM_VALUE_BC" field.
        /// </summary>
        private Double? _smValueBc;

        /// <summary>
        ///     the value of the "OPP_PROB_WIN_SM" field.
        /// </summary>
        private Byte? _probWinSm;

        /// <summary>
        ///     the value of the "OPP_CURRENCY_TYPE" field.
        /// </summary>
        private String _currencyType;

        /// <summary>
        ///     the value of the "OPP_EXEC_CODE" field.
        /// </summary>
        private String _execCode;

        /// <summary>
        ///     the value of the "OPP_TYPE_CHAN_DATE" field.
        /// </summary>
        private DateTime? _typeChanDate;

        /// <summary>
        ///     the value of the "OPP_PURCH_ORD_NO" field.
        /// </summary>
        private String _purchOrdNo;

        /// <summary>
        ///     the value of the "OPP_SUBSP_PER_FROM" field.
        /// </summary>
        private DateTime? _subspPerFrom;

        /// <summary>
        ///     the value of the "OPP_SUBSRIP_PER_TO" field.
        /// </summary>
        private DateTime? _subsripPerTo;

        /// <summary>
        ///     the value of the "OPP_BASIC_ACT_VAL" field.
        /// </summary>
        private Double? _basicActVal;

        /// <summary>
        ///     the value of the "OPP_MAT_ACT_VAL" field.
        /// </summary>
        private Double? _matActVal;

        /// <summary>
        ///     the value of the "OPP_TOT_ACT_VAL" field.
        /// </summary>
        private Double? _totActVal;

        /// <summary>
        ///     the value of the "OPP_BASIC_DISC_VAL" field.
        /// </summary>
        private Double? _basicDiscVal;

        /// <summary>
        ///     the value of the "OPP_MAT_DISC_VAL" field.
        /// </summary>
        private Double? _matDiscVal;

        /// <summary>
        ///     the value of the "OPP_TOT_DISC_VAL" field.
        /// </summary>
        private Double? _totDiscVal;

        /// <summary>
        ///     the value of the "OPP_BS_ACT_INV_VAL" field.
        /// </summary>
        private Double? _bsActInvVal;

        /// <summary>
        ///     the value of the "OPP_MT_ACT_INV_VAL" field.
        /// </summary>
        private Double? _mtActInvVal;

        /// <summary>
        ///     the value of the "OPP_TOT_AT_INV_VAL" field.
        /// </summary>
        private Double? _totAtInvVal;

        /// <summary>
        ///     the value of the "OPP_BASIC_ANN_VAL" field.
        /// </summary>
        private Double? _basicAnnVal;

        /// <summary>
        ///     the value of the "OPP_MAT_ANNUAL_VAL" field.
        /// </summary>
        private Double? _matAnnualVal;

        /// <summary>
        ///     the value of the "OPP_TOT_ANNUAL_VAL" field.
        /// </summary>
        private Double? _totAnnualVal;

        /// <summary>
        ///     the value of the "OPP_BSC_ACT_VAL_BC" field.
        /// </summary>
        private Double? _bscActValBc;

        /// <summary>
        ///     the value of the "OPP_MAT_ACT_VAL_BC" field.
        /// </summary>
        private Double? _matActValBc;

        /// <summary>
        ///     the value of the "OPP_TOT_ACT_VAL_BC" field.
        /// </summary>
        private Double? _totActValBc;

        /// <summary>
        ///     the value of the "OPP_BSC_DSC_VAL_BC" field.
        /// </summary>
        private Double? _bscDscValBc;

        /// <summary>
        ///     the value of the "OPP_MAT_DSC_VAL_BC" field.
        /// </summary>
        private Double? _matDscValBc;

        /// <summary>
        ///     the value of the "OPP_TOT_DSC_VAL_BC" field.
        /// </summary>
        private Double? _totDscValBc;

        /// <summary>
        ///     the value of the "OPP_BC_AT_IN_VL_BC" field.
        /// </summary>
        private Double? _bcAtInVlBc;

        /// <summary>
        ///     the value of the "OPP_MT_AT_IN_VL_BC" field.
        /// </summary>
        private Double? _mtAtInVlBc;

        /// <summary>
        ///     the value of the "OPP_TT_AT_IN_VL_BC" field.
        /// </summary>
        private Double? _ttAtInVlBc;

        /// <summary>
        ///     the value of the "OPP_BSC_ANN_VAL_BC" field.
        /// </summary>
        private Double? _bscAnnValBc;

        /// <summary>
        ///     the value of the "OPP_MAT_ANN_VAL_BC" field.
        /// </summary>
        private Double? _matAnnValBc;

        /// <summary>
        ///     the value of the "OPP_TOT_ANN_VAL_BC" field.
        /// </summary>
        private Double? _totAnnValBc;

        /// <summary>
        ///     the value of the "OPP_MEDIUM" field.
        /// </summary>
        private String _medium;

        /// <summary>
        ///     the value of the "OPP_FREQUENCY" field.
        /// </summary>
        private String _frequency;

        /// <summary>
        ///     the value of the "OPP_TAILOR_MADE_NO" field.
        /// </summary>
        private String _tailorMadeNo;

        /// <summary>
        ///     the value of the "OPP_DISPATCH_DATE" field.
        /// </summary>
        private DateTime? _dispatchDate;

        /// <summary>
        ///     the value of the "OPP_DISPTCH_METHOD" field.
        /// </summary>
        private String _disptchMethod;

        /// <summary>
        ///     the value of the "OPP_SERVPROD_TEXT" field.
        /// </summary>
        private String _servprodText;

        /// <summary>
        ///     the value of the "OPP_DATE_ON_PRINT" field.
        /// </summary>
        private DateTime? _dateOnPrint;

        /// <summary>
        ///     the value of the "OPP_PIC_ID" field.
        /// </summary>
        private String _picId;

        /// <summary>
        ///     the value of the "OPP_ORG_ID_USER" field.
        /// </summary>
        private String _orgIdUser;

        /// <summary>
        ///     the value of the "OPP_ACT_ID" field.
        /// </summary>
        private String _actId;

        /// <summary>
        ///     the value of the "OPP_USERNUM_1" field.
        /// </summary>
        private Decimal? _usernum1;

        /// <summary>
        ///     the value of the "OPP_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "OPP_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "OPP_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "OPP_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "OPP_COMPETITOR" field.
        /// </summary>
        private String _competitor;

        /// <summary>
        ///     the value of the "OPP_USE_ROLL_OUT" field.
        /// </summary>
        private Byte? _useRollOut;

        /// <summary>
        ///     the value of the "OPP_USERCHAR_5" field.
        /// </summary>
        private String _userchar5;

        /// <summary>
        ///     the value of the "OPP_NX_STAGE" field.
        /// </summary>
        private String _nxStage;

        /// <summary>
        ///     the value of the "OPP_STAGE_DT" field.
        /// </summary>
        private DateTime? _stageDt;

        /// <summary>
        ///     the value of the "OPP_CAME_FROM_ID" field.
        /// </summary>
        private String _cameFromId;

        /// <summary>
        ///     the value of the "OPP_PROJ_ID" field.
        /// </summary>
        private String _projId;

        /// <summary>
        ///     the value of the "OPP_OPP_ID" field.
        /// </summary>
        private String _oppId;

        /// <summary>
        ///     the value of the "OPP_CAME_FROM" field.
        /// </summary>
        private String _cameFrom;

        /// <summary>
        ///     the value of the "OPP_OPTIM_LOCK" field.
        /// </summary>
        private String _optimLock;

        /// <summary>
        ///     the value of the "OPP_ADD_PERIOD" field.
        /// </summary>
        private String _addPeriod;

        /// <summary>
        ///     the value of the "OPP_TERR_ID" field.
        /// </summary>
        private String _terrId;

        /// <summary>
        ///     the value of the "OPP_DESC" field.
        /// </summary>
        private String _desc;

        /// <summary>
        ///     the value of the "OPP_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "OPP_COMMIT" field.
        /// </summary>
        private Byte? _commit;

        /// <summary>
        ///     the value of the "OPP_CONT_TYPE" field.
        /// </summary>
        private String _contType;

        /// <summary>
        ///     the value of the "OPP_ORIG_FORCST_DT" field.
        /// </summary>
        private DateTime? _origForcstDt;

        /// <summary>
        ///     the value of the "OPP_LOST_EXP" field.
        /// </summary>
        private String _lostExp;

        /// <summary>
        ///     the value of the "OPP_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "OPP_SALES_TYPE" field.
        /// </summary>
        private String _salesType;

        /// <summary>
        ///     the value of the "OPP_USERCHAR_6" field.
        /// </summary>
        private String _userchar6;

        /// <summary>
        ///     the value of the "OPP_USERINT_1" field.
        /// </summary>
        private Byte? _userint1;

        /// <summary>
        ///     the value of the "OPP_USERINT_2" field.
        /// </summary>
        private Byte? _userint2;

        /// <summary>
        ///     the value of the "OPP_USERINT_3" field.
        /// </summary>
        private Byte? _userint3;

        /// <summary>
        ///     the value of the "OPP_USERINT_4" field.
        /// </summary>
        private Byte? _userint4;

        /// <summary>
        ///     the value of the "OPP_USERINT_5" field.
        /// </summary>
        private Byte? _userint5;

        /// <summary>
        ///     the value of the "OPP_USERINT_6" field.
        /// </summary>
        private Byte? _userint6;

        /// <summary>
        ///     the value of the "OPP_USERNUM_2" field.
        /// </summary>
        private Decimal? _usernum2;

        /// <summary>
        ///     the value of the "OPP_USERNUM_3" field.
        /// </summary>
        private Decimal? _usernum3;

        /// <summary>
        ///     the value of the "OPP_USERNUM_4" field.
        /// </summary>
        private Decimal? _usernum4;

        /// <summary>
        ///     the value of the "OPP_USERNUM_5" field.
        /// </summary>
        private Decimal? _usernum5;

        /// <summary>
        ///     the value of the "OPP_USERNUM_6" field.
        /// </summary>
        private Decimal? _usernum6;

        /// <summary>
        ///     the value of the "OPP_USERDATE_1" field.
        /// </summary>
        private DateTime? _userdate1;

        /// <summary>
        ///     the value of the "OPP_USERDATE_2" field.
        /// </summary>
        private DateTime? _userdate2;

        /// <summary>
        ///     the value of the "OPP_USERDATE_3" field.
        /// </summary>
        private DateTime? _userdate3;

        /// <summary>
        ///     the value of the "OPP_USERDATE_4" field.
        /// </summary>
        private DateTime? _userdate4;

        /// <summary>
        ///     the value of the "OPP_USERDATE_5" field.
        /// </summary>
        private DateTime? _userdate5;

        /// <summary>
        ///     the value of the "OPP_USERDATE_6" field.
        /// </summary>
        private DateTime? _userdate6;

        /// <summary>
        ///     the value of the "OPP_EXT_PROJ_ID" field.
        /// </summary>
        private String _extProjId;

        /// <summary>
        ///     the value of the "OPP_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "OPP_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "OPP_MEM_ID" field.
        /// </summary>
        private String _memId;

        /// <summary>
        ///     the value of the "OPP_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "OPP_SERVICE" field.
        /// </summary>
        private String _service;

        /// <summary>
        ///     the value of the "OPP_DROPDOWN_1" field.
        /// </summary>
        private String _dropdown1;

        /// <summary>
        ///     the value of the "OPP_DROPDOWN_2" field.
        /// </summary>
        private String _dropdown2;

        /// <summary>
        ///     the value of the "OPP_DROPDOWN_3" field.
        /// </summary>
        private String _dropdown3;

        /// <summary>
        ///     the value of the "OPP_DROPDOWN_4" field.
        /// </summary>
        private String _dropdown4;

        /// <summary>
        ///     the value of the "OPP_USERDATE_7" field.
        /// </summary>
        private DateTime? _userdate7;

        /// <summary>
        ///     the value of the "OPP_USERDATE_8" field.
        /// </summary>
        private DateTime? _userdate8;

        /// <summary>
        ///     the value of the "OPP_SCHN_ID" field.
        /// </summary>
        private String _schnId;

        /// <summary>
        ///     the value of the "OPP_REAS_DELAY" field.
        /// </summary>
        private String _reasDelay;

        /// <summary>
        ///     the value of the "OPP_RATIONALE" field.
        /// </summary>
        private String _rationale;

        /// <summary>
        ///     the value of the "OPP_ORIG_ENQUIRY_TYPE" field.
        /// </summary>
        private String _origEnquiryType;

        /// <summary>
        ///     the value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        private String _searchGroup;

        /// <summary>
        ///     the value of the "OPP_SY_TYPE" field.
        /// </summary>
        private Int32 _syType;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "OPP_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "OPP_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "OPP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "OPP_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "OPP_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "OPP_QUO_ID" field.
        /// </summary>
        public String QuoId
        {
            get { return _quoId; }
            set { _quoId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PROM_ID" field.
        /// </summary>
        public String PromId
        {
            get { return _promId; }
            set { _promId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PROLE_ID_SALES" field.
        /// </summary>
        public String ProleIdSales
        {
            get { return _proleIdSales; }
            set { _proleIdSales = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PROLE_ID_TAKEN" field.
        /// </summary>
        public String ProleIdTaken
        {
            get { return _proleIdTaken; }
            set { _proleIdTaken = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SCH_ID" field.
        /// </summary>
        public String SchId
        {
            get { return _schId; }
            set { _schId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TEXT_ID" field.
        /// </summary>
        public String TextId
        {
            get { return _textId; }
            set { _textId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TEXT_ID_HIS" field.
        /// </summary>
        public String TextIdHis
        {
            get { return _textIdHis; }
            set { _textIdHis = value; }
        }

        /// <summary>
        ///     the value of the "OPP_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "OPP_STATUS_MKT" field.
        /// </summary>
        public String StatusMkt
        {
            get { return _statusMkt; }
            set { _statusMkt = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PERIOD" field.
        /// </summary>
        public String Period
        {
            get { return _period; }
            set { _period = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DATE_ENQ" field.
        /// </summary>
        public DateTime? DateEnq
        {
            get { return _dateEnq; }
            set { _dateEnq = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DATE_DEC" field.
        /// </summary>
        public DateTime? DateDec
        {
            get { return _dateDec; }
            set { _dateDec = value; }
        }

        /// <summary>
        ///     the value of the "OPP_VAL_POT" field.
        /// </summary>
        public Double? ValPot
        {
            get { return _valPot; }
            set { _valPot = value; }
        }

        /// <summary>
        ///     the value of the "OPP_VAL_SOLD" field.
        /// </summary>
        public Double? ValSold
        {
            get { return _valSold; }
            set { _valSold = value; }
        }

        /// <summary>
        ///     the value of the "OPP_LOST_TO" field.
        /// </summary>
        public String LostTo
        {
            get { return _lostTo; }
            set { _lostTo = value; }
        }

        /// <summary>
        ///     the value of the "OPP_LOST_REA" field.
        /// </summary>
        public String LostRea
        {
            get { return _lostRea; }
            set { _lostRea = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DATE_NEXT" field.
        /// </summary>
        public DateTime? DateNext
        {
            get { return _dateNext; }
            set { _dateNext = value; }
        }

        /// <summary>
        ///     the value of the "OPP_QUO_REF" field.
        /// </summary>
        public String QuoRef
        {
            get { return _quoRef; }
            set { _quoRef = value; }
        }

        /// <summary>
        ///     the value of the "OPP_QUO_DATE" field.
        /// </summary>
        public DateTime? QuoDate
        {
            get { return _quoDate; }
            set { _quoDate = value; }
        }

        /// <summary>
        ///     the value of the "OPP_QUO_VAL" field.
        /// </summary>
        public Double? QuoVal
        {
            get { return _quoVal; }
            set { _quoVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "OPP_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PROB_PURCH" field.
        /// </summary>
        public Byte? ProbPurch
        {
            get { return _probPurch; }
            set { _probPurch = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PROB_WIN" field.
        /// </summary>
        public Byte? ProbWin
        {
            get { return _probWin; }
            set { _probWin = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DATE_ROL_START" field.
        /// </summary>
        public DateTime? DateRolStart
        {
            get { return _dateRolStart; }
            set { _dateRolStart = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PERD_ROLL" field.
        /// </summary>
        public String PerdRoll
        {
            get { return _perdRoll; }
            set { _perdRoll = value; }
        }

        /// <summary>
        ///     the value of the "OPP_INC_ROLL" field.
        /// </summary>
        public Byte? IncRoll
        {
            get { return _incRoll; }
            set { _incRoll = value; }
        }

        /// <summary>
        ///     the value of the "OPP_INC_START" field.
        /// </summary>
        public DateTime? IncStart
        {
            get { return _incStart; }
            set { _incStart = value; }
        }

        /// <summary>
        ///     the value of the "OPP_INC_END" field.
        /// </summary>
        public DateTime? IncEnd
        {
            get { return _incEnd; }
            set { _incEnd = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DATE_ROLL_END" field.
        /// </summary>
        public DateTime? DateRollEnd
        {
            get { return _dateRollEnd; }
            set { _dateRollEnd = value; }
        }

        /// <summary>
        ///     the value of the "OPP_NOTE_ROLL" field.
        /// </summary>
        public String NoteRoll
        {
            get { return _noteRoll; }
            set { _noteRoll = value; }
        }

        /// <summary>
        ///     the value of the "OPP_ROLL_QTY" field.
        /// </summary>
        public Double? RollQty
        {
            get { return _rollQty; }
            set { _rollQty = value; }
        }

        /// <summary>
        ///     the value of the "OPP_ROLL_COST" field.
        /// </summary>
        public Double? RollCost
        {
            get { return _rollCost; }
            set { _rollCost = value; }
        }

        /// <summary>
        ///     the value of the "OPP_ROLL_RET" field.
        /// </summary>
        public Double? RollRet
        {
            get { return _rollRet; }
            set { _rollRet = value; }
        }

        /// <summary>
        ///     the value of the "OPP_VAL_POT_BC" field.
        /// </summary>
        public Double? ValPotBc
        {
            get { return _valPotBc; }
            set { _valPotBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_VAL_SOLD_BC" field.
        /// </summary>
        public Double? ValSoldBc
        {
            get { return _valSoldBc; }
            set { _valSoldBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_QUO_VAL_BC" field.
        /// </summary>
        public Double? QuoValBc
        {
            get { return _quoValBc; }
            set { _quoValBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        public String ProdInterest
        {
            get { return _prodInterest; }
            set { _prodInterest = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SM_FORCST_DATE" field.
        /// </summary>
        public DateTime? SmForcstDate
        {
            get { return _smForcstDate; }
            set { _smForcstDate = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SM_VALUE" field.
        /// </summary>
        public Double? SmValue
        {
            get { return _smValue; }
            set { _smValue = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SM_VALUE_BC" field.
        /// </summary>
        public Double? SmValueBc
        {
            get { return _smValueBc; }
            set { _smValueBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PROB_WIN_SM" field.
        /// </summary>
        public Byte? ProbWinSm
        {
            get { return _probWinSm; }
            set { _probWinSm = value; }
        }

        /// <summary>
        ///     the value of the "OPP_CURRENCY_TYPE" field.
        /// </summary>
        public String CurrencyType
        {
            get { return _currencyType; }
            set { _currencyType = value; }
        }

        /// <summary>
        ///     the value of the "OPP_EXEC_CODE" field.
        /// </summary>
        public String ExecCode
        {
            get { return _execCode; }
            set { _execCode = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TYPE_CHAN_DATE" field.
        /// </summary>
        public DateTime? TypeChanDate
        {
            get { return _typeChanDate; }
            set { _typeChanDate = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PURCH_ORD_NO" field.
        /// </summary>
        public String PurchOrdNo
        {
            get { return _purchOrdNo; }
            set { _purchOrdNo = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SUBSP_PER_FROM" field.
        /// </summary>
        public DateTime? SubspPerFrom
        {
            get { return _subspPerFrom; }
            set { _subspPerFrom = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SUBSRIP_PER_TO" field.
        /// </summary>
        public DateTime? SubsripPerTo
        {
            get { return _subsripPerTo; }
            set { _subsripPerTo = value; }
        }

        /// <summary>
        ///     the value of the "OPP_BASIC_ACT_VAL" field.
        /// </summary>
        public Double? BasicActVal
        {
            get { return _basicActVal; }
            set { _basicActVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MAT_ACT_VAL" field.
        /// </summary>
        public Double? MatActVal
        {
            get { return _matActVal; }
            set { _matActVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TOT_ACT_VAL" field.
        /// </summary>
        public Double? TotActVal
        {
            get { return _totActVal; }
            set { _totActVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_BASIC_DISC_VAL" field.
        /// </summary>
        public Double? BasicDiscVal
        {
            get { return _basicDiscVal; }
            set { _basicDiscVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MAT_DISC_VAL" field.
        /// </summary>
        public Double? MatDiscVal
        {
            get { return _matDiscVal; }
            set { _matDiscVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TOT_DISC_VAL" field.
        /// </summary>
        public Double? TotDiscVal
        {
            get { return _totDiscVal; }
            set { _totDiscVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_BS_ACT_INV_VAL" field.
        /// </summary>
        public Double? BsActInvVal
        {
            get { return _bsActInvVal; }
            set { _bsActInvVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MT_ACT_INV_VAL" field.
        /// </summary>
        public Double? MtActInvVal
        {
            get { return _mtActInvVal; }
            set { _mtActInvVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TOT_AT_INV_VAL" field.
        /// </summary>
        public Double? TotAtInvVal
        {
            get { return _totAtInvVal; }
            set { _totAtInvVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_BASIC_ANN_VAL" field.
        /// </summary>
        public Double? BasicAnnVal
        {
            get { return _basicAnnVal; }
            set { _basicAnnVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MAT_ANNUAL_VAL" field.
        /// </summary>
        public Double? MatAnnualVal
        {
            get { return _matAnnualVal; }
            set { _matAnnualVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TOT_ANNUAL_VAL" field.
        /// </summary>
        public Double? TotAnnualVal
        {
            get { return _totAnnualVal; }
            set { _totAnnualVal = value; }
        }

        /// <summary>
        ///     the value of the "OPP_BSC_ACT_VAL_BC" field.
        /// </summary>
        public Double? BscActValBc
        {
            get { return _bscActValBc; }
            set { _bscActValBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MAT_ACT_VAL_BC" field.
        /// </summary>
        public Double? MatActValBc
        {
            get { return _matActValBc; }
            set { _matActValBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TOT_ACT_VAL_BC" field.
        /// </summary>
        public Double? TotActValBc
        {
            get { return _totActValBc; }
            set { _totActValBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_BSC_DSC_VAL_BC" field.
        /// </summary>
        public Double? BscDscValBc
        {
            get { return _bscDscValBc; }
            set { _bscDscValBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MAT_DSC_VAL_BC" field.
        /// </summary>
        public Double? MatDscValBc
        {
            get { return _matDscValBc; }
            set { _matDscValBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TOT_DSC_VAL_BC" field.
        /// </summary>
        public Double? TotDscValBc
        {
            get { return _totDscValBc; }
            set { _totDscValBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_BC_AT_IN_VL_BC" field.
        /// </summary>
        public Double? BcAtInVlBc
        {
            get { return _bcAtInVlBc; }
            set { _bcAtInVlBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MT_AT_IN_VL_BC" field.
        /// </summary>
        public Double? MtAtInVlBc
        {
            get { return _mtAtInVlBc; }
            set { _mtAtInVlBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TT_AT_IN_VL_BC" field.
        /// </summary>
        public Double? TtAtInVlBc
        {
            get { return _ttAtInVlBc; }
            set { _ttAtInVlBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_BSC_ANN_VAL_BC" field.
        /// </summary>
        public Double? BscAnnValBc
        {
            get { return _bscAnnValBc; }
            set { _bscAnnValBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MAT_ANN_VAL_BC" field.
        /// </summary>
        public Double? MatAnnValBc
        {
            get { return _matAnnValBc; }
            set { _matAnnValBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TOT_ANN_VAL_BC" field.
        /// </summary>
        public Double? TotAnnValBc
        {
            get { return _totAnnValBc; }
            set { _totAnnValBc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MEDIUM" field.
        /// </summary>
        public String Medium
        {
            get { return _medium; }
            set { _medium = value; }
        }

        /// <summary>
        ///     the value of the "OPP_FREQUENCY" field.
        /// </summary>
        public String Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TAILOR_MADE_NO" field.
        /// </summary>
        public String TailorMadeNo
        {
            get { return _tailorMadeNo; }
            set { _tailorMadeNo = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DISPATCH_DATE" field.
        /// </summary>
        public DateTime? DispatchDate
        {
            get { return _dispatchDate; }
            set { _dispatchDate = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DISPTCH_METHOD" field.
        /// </summary>
        public String DisptchMethod
        {
            get { return _disptchMethod; }
            set { _disptchMethod = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SERVPROD_TEXT" field.
        /// </summary>
        public String ServprodText
        {
            get { return _servprodText; }
            set { _servprodText = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DATE_ON_PRINT" field.
        /// </summary>
        public DateTime? DateOnPrint
        {
            get { return _dateOnPrint; }
            set { _dateOnPrint = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PIC_ID" field.
        /// </summary>
        public String PicId
        {
            get { return _picId; }
            set { _picId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_ORG_ID_USER" field.
        /// </summary>
        public String OrgIdUser
        {
            get { return _orgIdUser; }
            set { _orgIdUser = value; }
        }

        /// <summary>
        ///     the value of the "OPP_ACT_ID" field.
        /// </summary>
        public String ActId
        {
            get { return _actId; }
            set { _actId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERNUM_1" field.
        /// </summary>
        public Decimal? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_COMPETITOR" field.
        /// </summary>
        public String Competitor
        {
            get { return _competitor; }
            set { _competitor = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USE_ROLL_OUT" field.
        /// </summary>
        public Byte? UseRollOut
        {
            get { return _useRollOut; }
            set { _useRollOut = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return _userchar5; }
            set { _userchar5 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_NX_STAGE" field.
        /// </summary>
        public String NxStage
        {
            get { return _nxStage; }
            set { _nxStage = value; }
        }

        /// <summary>
        ///     the value of the "OPP_STAGE_DT" field.
        /// </summary>
        public DateTime? StageDt
        {
            get { return _stageDt; }
            set { _stageDt = value; }
        }

        /// <summary>
        ///     the value of the "OPP_CAME_FROM_ID" field.
        /// </summary>
        public String CameFromId
        {
            get { return _cameFromId; }
            set { _cameFromId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PROJ_ID" field.
        /// </summary>
        public String ProjId
        {
            get { return _projId; }
            set { _projId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_OPP_ID" field.
        /// </summary>
        public String OppId
        {
            get { return _oppId; }
            set { _oppId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_CAME_FROM" field.
        /// </summary>
        public String CameFrom
        {
            get { return _cameFrom; }
            set { _cameFrom = value; }
        }

        /// <summary>
        ///     the value of the "OPP_OPTIM_LOCK" field.
        /// </summary>
        public String OptimLock
        {
            get { return _optimLock; }
            set { _optimLock = value; }
        }

        /// <summary>
        ///     the value of the "OPP_ADD_PERIOD" field.
        /// </summary>
        public String AddPeriod
        {
            get { return _addPeriod; }
            set { _addPeriod = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TERR_ID" field.
        /// </summary>
        public String TerrId
        {
            get { return _terrId; }
            set { _terrId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        ///     the value of the "OPP_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "OPP_COMMIT" field.
        /// </summary>
        public Byte? Commit
        {
            get { return _commit; }
            set { _commit = value; }
        }

        /// <summary>
        ///     the value of the "OPP_CONT_TYPE" field.
        /// </summary>
        public String ContType
        {
            get { return _contType; }
            set { _contType = value; }
        }

        /// <summary>
        ///     the value of the "OPP_ORIG_FORCST_DT" field.
        /// </summary>
        public DateTime? OrigForcstDt
        {
            get { return _origForcstDt; }
            set { _origForcstDt = value; }
        }

        /// <summary>
        ///     the value of the "OPP_LOST_EXP" field.
        /// </summary>
        public String LostExp
        {
            get { return _lostExp; }
            set { _lostExp = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SALES_TYPE" field.
        /// </summary>
        public String SalesType
        {
            get { return _salesType; }
            set { _salesType = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return _userchar6; }
            set { _userchar6 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERINT_1" field.
        /// </summary>
        public Byte? Userint1
        {
            get { return _userint1; }
            set { _userint1 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERINT_2" field.
        /// </summary>
        public Byte? Userint2
        {
            get { return _userint2; }
            set { _userint2 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERINT_3" field.
        /// </summary>
        public Byte? Userint3
        {
            get { return _userint3; }
            set { _userint3 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERINT_4" field.
        /// </summary>
        public Byte? Userint4
        {
            get { return _userint4; }
            set { _userint4 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERINT_5" field.
        /// </summary>
        public Byte? Userint5
        {
            get { return _userint5; }
            set { _userint5 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERINT_6" field.
        /// </summary>
        public Byte? Userint6
        {
            get { return _userint6; }
            set { _userint6 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERNUM_2" field.
        /// </summary>
        public Decimal? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERNUM_3" field.
        /// </summary>
        public Decimal? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERNUM_4" field.
        /// </summary>
        public Decimal? Usernum4
        {
            get { return _usernum4; }
            set { _usernum4 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERNUM_5" field.
        /// </summary>
        public Decimal? Usernum5
        {
            get { return _usernum5; }
            set { _usernum5 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERNUM_6" field.
        /// </summary>
        public Decimal? Usernum6
        {
            get { return _usernum6; }
            set { _usernum6 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERDATE_1" field.
        /// </summary>
        public DateTime? Userdate1
        {
            get { return _userdate1; }
            set { _userdate1 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERDATE_2" field.
        /// </summary>
        public DateTime? Userdate2
        {
            get { return _userdate2; }
            set { _userdate2 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERDATE_3" field.
        /// </summary>
        public DateTime? Userdate3
        {
            get { return _userdate3; }
            set { _userdate3 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERDATE_4" field.
        /// </summary>
        public DateTime? Userdate4
        {
            get { return _userdate4; }
            set { _userdate4 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERDATE_5" field.
        /// </summary>
        public DateTime? Userdate5
        {
            get { return _userdate5; }
            set { _userdate5 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERDATE_6" field.
        /// </summary>
        public DateTime? Userdate6
        {
            get { return _userdate6; }
            set { _userdate6 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_EXT_PROJ_ID" field.
        /// </summary>
        public String ExtProjId
        {
            get { return _extProjId; }
            set { _extProjId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_MEM_ID" field.
        /// </summary>
        public String MemId
        {
            get { return _memId; }
            set { _memId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SERVICE" field.
        /// </summary>
        public String Service
        {
            get { return _service; }
            set { _service = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DROPDOWN_1" field.
        /// </summary>
        public String Dropdown1
        {
            get { return _dropdown1; }
            set { _dropdown1 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DROPDOWN_2" field.
        /// </summary>
        public String Dropdown2
        {
            get { return _dropdown2; }
            set { _dropdown2 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DROPDOWN_3" field.
        /// </summary>
        public String Dropdown3
        {
            get { return _dropdown3; }
            set { _dropdown3 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_DROPDOWN_4" field.
        /// </summary>
        public String Dropdown4
        {
            get { return _dropdown4; }
            set { _dropdown4 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERDATE_7" field.
        /// </summary>
        public DateTime? Userdate7
        {
            get { return _userdate7; }
            set { _userdate7 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_USERDATE_8" field.
        /// </summary>
        public DateTime? Userdate8
        {
            get { return _userdate8; }
            set { _userdate8 = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SCHN_ID" field.
        /// </summary>
        public String SchnId
        {
            get { return _schnId; }
            set { _schnId = value; }
        }

        /// <summary>
        ///     the value of the "OPP_REAS_DELAY" field.
        /// </summary>
        public String ReasDelay
        {
            get { return _reasDelay; }
            set { _reasDelay = value; }
        }

        /// <summary>
        ///     the value of the "OPP_RATIONALE" field.
        /// </summary>
        public String Rationale
        {
            get { return _rationale; }
            set { _rationale = value; }
        }

        /// <summary>
        ///     the value of the "OPP_ORIG_ENQUIRY_TYPE" field.
        /// </summary>
        public String OrigEnquiryType
        {
            get { return _origEnquiryType; }
            set { _origEnquiryType = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        public String SearchGroup
        {
            get { return _searchGroup; }
            set { _searchGroup = value; }
        }

        /// <summary>
        ///     the value of the "OPP_SY_TYPE" field.
        /// </summary>
        public Int32 SyType
        {
            get { return _syType; }
            set { _syType = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="OpportunityRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="OpportunityRecord" /> object instance.
        /// </returns>
        public OpportunityRecord Clone()
        {
            OpportunityRecord record = new OpportunityRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.QuoId = this.QuoId;
            record.PromId = this.PromId;
            record.ProleIdSales = this.ProleIdSales;
            record.ProleIdTaken = this.ProleIdTaken;
            record.SchId = this.SchId;
            record.TextId = this.TextId;
            record.TextIdHis = this.TextIdHis;
            record.Status = this.Status;
            record.StatusMkt = this.StatusMkt;
            record.Period = this.Period;
            record.DateEnq = this.DateEnq;
            record.DateDec = this.DateDec;
            record.ValPot = this.ValPot;
            record.ValSold = this.ValSold;
            record.LostTo = this.LostTo;
            record.LostRea = this.LostRea;
            record.DateNext = this.DateNext;
            record.QuoRef = this.QuoRef;
            record.QuoDate = this.QuoDate;
            record.QuoVal = this.QuoVal;
            record.Name = this.Name;
            record.Notes = this.Notes;
            record.ProbPurch = this.ProbPurch;
            record.ProbWin = this.ProbWin;
            record.DateRolStart = this.DateRolStart;
            record.PerdRoll = this.PerdRoll;
            record.IncRoll = this.IncRoll;
            record.IncStart = this.IncStart;
            record.IncEnd = this.IncEnd;
            record.DateRollEnd = this.DateRollEnd;
            record.NoteRoll = this.NoteRoll;
            record.RollQty = this.RollQty;
            record.RollCost = this.RollCost;
            record.RollRet = this.RollRet;
            record.ValPotBc = this.ValPotBc;
            record.ValSoldBc = this.ValSoldBc;
            record.QuoValBc = this.QuoValBc;
            record.ProdInterest = this.ProdInterest;
            record.SmForcstDate = this.SmForcstDate;
            record.SmValue = this.SmValue;
            record.SmValueBc = this.SmValueBc;
            record.ProbWinSm = this.ProbWinSm;
            record.CurrencyType = this.CurrencyType;
            record.ExecCode = this.ExecCode;
            record.TypeChanDate = this.TypeChanDate;
            record.PurchOrdNo = this.PurchOrdNo;
            record.SubspPerFrom = this.SubspPerFrom;
            record.SubsripPerTo = this.SubsripPerTo;
            record.BasicActVal = this.BasicActVal;
            record.MatActVal = this.MatActVal;
            record.TotActVal = this.TotActVal;
            record.BasicDiscVal = this.BasicDiscVal;
            record.MatDiscVal = this.MatDiscVal;
            record.TotDiscVal = this.TotDiscVal;
            record.BsActInvVal = this.BsActInvVal;
            record.MtActInvVal = this.MtActInvVal;
            record.TotAtInvVal = this.TotAtInvVal;
            record.BasicAnnVal = this.BasicAnnVal;
            record.MatAnnualVal = this.MatAnnualVal;
            record.TotAnnualVal = this.TotAnnualVal;
            record.BscActValBc = this.BscActValBc;
            record.MatActValBc = this.MatActValBc;
            record.TotActValBc = this.TotActValBc;
            record.BscDscValBc = this.BscDscValBc;
            record.MatDscValBc = this.MatDscValBc;
            record.TotDscValBc = this.TotDscValBc;
            record.BcAtInVlBc = this.BcAtInVlBc;
            record.MtAtInVlBc = this.MtAtInVlBc;
            record.TtAtInVlBc = this.TtAtInVlBc;
            record.BscAnnValBc = this.BscAnnValBc;
            record.MatAnnValBc = this.MatAnnValBc;
            record.TotAnnValBc = this.TotAnnValBc;
            record.Medium = this.Medium;
            record.Frequency = this.Frequency;
            record.TailorMadeNo = this.TailorMadeNo;
            record.DispatchDate = this.DispatchDate;
            record.DisptchMethod = this.DisptchMethod;
            record.ServprodText = this.ServprodText;
            record.DateOnPrint = this.DateOnPrint;
            record.PicId = this.PicId;
            record.OrgIdUser = this.OrgIdUser;
            record.ActId = this.ActId;
            record.Usernum1 = this.Usernum1;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Userchar3 = this.Userchar3;
            record.Userchar4 = this.Userchar4;
            record.Competitor = this.Competitor;
            record.UseRollOut = this.UseRollOut;
            record.Userchar5 = this.Userchar5;
            record.NxStage = this.NxStage;
            record.StageDt = this.StageDt;
            record.CameFromId = this.CameFromId;
            record.ProjId = this.ProjId;
            record.OppId = this.OppId;
            record.CameFrom = this.CameFrom;
            record.OptimLock = this.OptimLock;
            record.AddPeriod = this.AddPeriod;
            record.TerrId = this.TerrId;
            record.Desc = this.Desc;
            record.Type = this.Type;
            record.Commit = this.Commit;
            record.ContType = this.ContType;
            record.OrigForcstDt = this.OrigForcstDt;
            record.LostExp = this.LostExp;
            record.SelcoSpId = this.SelcoSpId;
            record.SalesType = this.SalesType;
            record.Userchar6 = this.Userchar6;
            record.Userint1 = this.Userint1;
            record.Userint2 = this.Userint2;
            record.Userint3 = this.Userint3;
            record.Userint4 = this.Userint4;
            record.Userint5 = this.Userint5;
            record.Userint6 = this.Userint6;
            record.Usernum2 = this.Usernum2;
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
            record.ExtProjId = this.ExtProjId;
            record.CourseId = this.CourseId;
            record.ProdId = this.ProdId;
            record.MemId = this.MemId;
            record.CostCode = this.CostCode;
            record.Service = this.Service;
            record.Dropdown1 = this.Dropdown1;
            record.Dropdown2 = this.Dropdown2;
            record.Dropdown3 = this.Dropdown3;
            record.Dropdown4 = this.Dropdown4;
            record.Userdate7 = this.Userdate7;
            record.Userdate8 = this.Userdate8;
            record.SchnId = this.SchnId;
            record.ReasDelay = this.ReasDelay;
            record.Rationale = this.Rationale;
            record.OrigEnquiryType = this.OrigEnquiryType;
            record.SearchGroup = this.SearchGroup;
            record.SyType = this.SyType;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="OpportunityRecord" /> instance is equal to another <see cref="OpportunityRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="OpportunityRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(OpportunityRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.QuoId.TrimOrNullify() == that.QuoId.TrimOrNullify());
            result = result && (this.PromId.TrimOrNullify() == that.PromId.TrimOrNullify());
            result = result && (this.ProleIdSales.TrimOrNullify() == that.ProleIdSales.TrimOrNullify());
            result = result && (this.ProleIdTaken.TrimOrNullify() == that.ProleIdTaken.TrimOrNullify());
            result = result && (this.SchId.TrimOrNullify() == that.SchId.TrimOrNullify());
            result = result && (this.TextId.TrimOrNullify() == that.TextId.TrimOrNullify());
            result = result && (this.TextIdHis.TrimOrNullify() == that.TextIdHis.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.StatusMkt.TrimOrNullify() == that.StatusMkt.TrimOrNullify());
            result = result && (this.Period.TrimOrNullify() == that.Period.TrimOrNullify());
            result = result && (this.DateEnq == that.DateEnq);
            result = result && (this.DateDec == that.DateDec);
            result = result && (this.ValPot == that.ValPot);
            result = result && (this.ValSold == that.ValSold);
            result = result && (this.LostTo.TrimOrNullify() == that.LostTo.TrimOrNullify());
            result = result && (this.LostRea.TrimOrNullify() == that.LostRea.TrimOrNullify());
            result = result && (this.DateNext == that.DateNext);
            result = result && (this.QuoRef.TrimOrNullify() == that.QuoRef.TrimOrNullify());
            result = result && (this.QuoDate == that.QuoDate);
            result = result && (this.QuoVal == that.QuoVal);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.ProbPurch == that.ProbPurch);
            result = result && (this.ProbWin == that.ProbWin);
            result = result && (this.DateRolStart == that.DateRolStart);
            result = result && (this.PerdRoll.TrimOrNullify() == that.PerdRoll.TrimOrNullify());
            result = result && (this.IncRoll == that.IncRoll);
            result = result && (this.IncStart == that.IncStart);
            result = result && (this.IncEnd == that.IncEnd);
            result = result && (this.DateRollEnd == that.DateRollEnd);
            result = result && (this.NoteRoll.TrimOrNullify() == that.NoteRoll.TrimOrNullify());
            result = result && (this.RollQty == that.RollQty);
            result = result && (this.RollCost == that.RollCost);
            result = result && (this.RollRet == that.RollRet);
            result = result && (this.ValPotBc == that.ValPotBc);
            result = result && (this.ValSoldBc == that.ValSoldBc);
            result = result && (this.QuoValBc == that.QuoValBc);
            result = result && (this.ProdInterest.TrimOrNullify() == that.ProdInterest.TrimOrNullify());
            result = result && (this.SmForcstDate == that.SmForcstDate);
            result = result && (this.SmValue == that.SmValue);
            result = result && (this.SmValueBc == that.SmValueBc);
            result = result && (this.ProbWinSm == that.ProbWinSm);
            result = result && (this.CurrencyType.TrimOrNullify() == that.CurrencyType.TrimOrNullify());
            result = result && (this.ExecCode.TrimOrNullify() == that.ExecCode.TrimOrNullify());
            result = result && (this.TypeChanDate == that.TypeChanDate);
            result = result && (this.PurchOrdNo.TrimOrNullify() == that.PurchOrdNo.TrimOrNullify());
            result = result && (this.SubspPerFrom == that.SubspPerFrom);
            result = result && (this.SubsripPerTo == that.SubsripPerTo);
            result = result && (this.BasicActVal == that.BasicActVal);
            result = result && (this.MatActVal == that.MatActVal);
            result = result && (this.TotActVal == that.TotActVal);
            result = result && (this.BasicDiscVal == that.BasicDiscVal);
            result = result && (this.MatDiscVal == that.MatDiscVal);
            result = result && (this.TotDiscVal == that.TotDiscVal);
            result = result && (this.BsActInvVal == that.BsActInvVal);
            result = result && (this.MtActInvVal == that.MtActInvVal);
            result = result && (this.TotAtInvVal == that.TotAtInvVal);
            result = result && (this.BasicAnnVal == that.BasicAnnVal);
            result = result && (this.MatAnnualVal == that.MatAnnualVal);
            result = result && (this.TotAnnualVal == that.TotAnnualVal);
            result = result && (this.BscActValBc == that.BscActValBc);
            result = result && (this.MatActValBc == that.MatActValBc);
            result = result && (this.TotActValBc == that.TotActValBc);
            result = result && (this.BscDscValBc == that.BscDscValBc);
            result = result && (this.MatDscValBc == that.MatDscValBc);
            result = result && (this.TotDscValBc == that.TotDscValBc);
            result = result && (this.BcAtInVlBc == that.BcAtInVlBc);
            result = result && (this.MtAtInVlBc == that.MtAtInVlBc);
            result = result && (this.TtAtInVlBc == that.TtAtInVlBc);
            result = result && (this.BscAnnValBc == that.BscAnnValBc);
            result = result && (this.MatAnnValBc == that.MatAnnValBc);
            result = result && (this.TotAnnValBc == that.TotAnnValBc);
            result = result && (this.Medium.TrimOrNullify() == that.Medium.TrimOrNullify());
            result = result && (this.Frequency.TrimOrNullify() == that.Frequency.TrimOrNullify());
            result = result && (this.TailorMadeNo.TrimOrNullify() == that.TailorMadeNo.TrimOrNullify());
            result = result && (this.DispatchDate == that.DispatchDate);
            result = result && (this.DisptchMethod.TrimOrNullify() == that.DisptchMethod.TrimOrNullify());
            result = result && (this.ServprodText.TrimOrNullify() == that.ServprodText.TrimOrNullify());
            result = result && (this.DateOnPrint == that.DateOnPrint);
            result = result && (this.PicId.TrimOrNullify() == that.PicId.TrimOrNullify());
            result = result && (this.OrgIdUser.TrimOrNullify() == that.OrgIdUser.TrimOrNullify());
            result = result && (this.ActId.TrimOrNullify() == that.ActId.TrimOrNullify());
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.Competitor.TrimOrNullify() == that.Competitor.TrimOrNullify());
            result = result && (this.UseRollOut == that.UseRollOut);
            result = result && (this.Userchar5.TrimOrNullify() == that.Userchar5.TrimOrNullify());
            result = result && (this.NxStage.TrimOrNullify() == that.NxStage.TrimOrNullify());
            result = result && (this.StageDt == that.StageDt);
            result = result && (this.CameFromId.TrimOrNullify() == that.CameFromId.TrimOrNullify());
            result = result && (this.ProjId.TrimOrNullify() == that.ProjId.TrimOrNullify());
            result = result && (this.OppId.TrimOrNullify() == that.OppId.TrimOrNullify());
            result = result && (this.CameFrom.TrimOrNullify() == that.CameFrom.TrimOrNullify());
            result = result && (this.OptimLock.TrimOrNullify() == that.OptimLock.TrimOrNullify());
            result = result && (this.AddPeriod.TrimOrNullify() == that.AddPeriod.TrimOrNullify());
            result = result && (this.TerrId.TrimOrNullify() == that.TerrId.TrimOrNullify());
            result = result && (this.Desc.TrimOrNullify() == that.Desc.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.Commit == that.Commit);
            result = result && (this.ContType.TrimOrNullify() == that.ContType.TrimOrNullify());
            result = result && (this.OrigForcstDt == that.OrigForcstDt);
            result = result && (this.LostExp.TrimOrNullify() == that.LostExp.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.SalesType.TrimOrNullify() == that.SalesType.TrimOrNullify());
            result = result && (this.Userchar6.TrimOrNullify() == that.Userchar6.TrimOrNullify());
            result = result && (this.Userint1 == that.Userint1);
            result = result && (this.Userint2 == that.Userint2);
            result = result && (this.Userint3 == that.Userint3);
            result = result && (this.Userint4 == that.Userint4);
            result = result && (this.Userint5 == that.Userint5);
            result = result && (this.Userint6 == that.Userint6);
            result = result && (this.Usernum2 == that.Usernum2);
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
            result = result && (this.ExtProjId.TrimOrNullify() == that.ExtProjId.TrimOrNullify());
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.MemId.TrimOrNullify() == that.MemId.TrimOrNullify());
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.Service.TrimOrNullify() == that.Service.TrimOrNullify());
            result = result && (this.Dropdown1.TrimOrNullify() == that.Dropdown1.TrimOrNullify());
            result = result && (this.Dropdown2.TrimOrNullify() == that.Dropdown2.TrimOrNullify());
            result = result && (this.Dropdown3.TrimOrNullify() == that.Dropdown3.TrimOrNullify());
            result = result && (this.Dropdown4.TrimOrNullify() == that.Dropdown4.TrimOrNullify());
            result = result && (this.Userdate7 == that.Userdate7);
            result = result && (this.Userdate8 == that.Userdate8);
            result = result && (this.SchnId.TrimOrNullify() == that.SchnId.TrimOrNullify());
            result = result && (this.ReasDelay.TrimOrNullify() == that.ReasDelay.TrimOrNullify());
            result = result && (this.Rationale.TrimOrNullify() == that.Rationale.TrimOrNullify());
            result = result && (this.OrigEnquiryType.TrimOrNullify() == that.OrigEnquiryType.TrimOrNullify());
            result = result && (this.SearchGroup.TrimOrNullify() == that.SearchGroup.TrimOrNullify());
            result = result && (this.SyType == that.SyType);
            return result;
        }

        #endregion
    }
}
