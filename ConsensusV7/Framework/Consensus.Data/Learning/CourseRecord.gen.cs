using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "Course" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class CourseRecord : Record<String>, Cloneable<CourseRecord>, IEquatable<CourseRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "COURSE_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "COURSE_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "COURSE_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "COURSE_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "COURSE_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "COURSE_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "COURSE_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "COURSE_PERSON_ID" field.
        /// </summary>
        private String _personId;

        /// <summary>
        ///     the value of the "COURSE_PRODUCT_ID" field.
        /// </summary>
        private String _productId;

        /// <summary>
        ///     the value of the "COURSE_LOC_ID" field.
        /// </summary>
        private String _locId;

        /// <summary>
        ///     the value of the "COURSE_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "COURSE_REF" field.
        /// </summary>
        private String _ref;

        /// <summary>
        ///     the value of the "COURSE_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "COURSE_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "COURSE_SECTOR" field.
        /// </summary>
        private String _sector;

        /// <summary>
        ///     the value of the "COURSE_ON_SITE" field.
        /// </summary>
        private Byte? _onSite;

        /// <summary>
        ///     the value of the "COURSE_BLOCK_PRICD" field.
        /// </summary>
        private Byte? _blockPricd;

        /// <summary>
        ///     the value of the "COURSE_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "COURSE_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "COURSE_START_TIME" field.
        /// </summary>
        private DateTime? _startTime;

        /// <summary>
        ///     the value of the "COURSE_END_TIME" field.
        /// </summary>
        private DateTime? _endTime;

        /// <summary>
        ///     the value of the "COURSE_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "COURSE_DIARY_TYPE" field.
        /// </summary>
        private String _diaryType;

        /// <summary>
        ///     the value of the "COURSE_LENGTH" field.
        /// </summary>
        private Double? _length;

        /// <summary>
        ///     the value of the "COURSE_MIN_PLACES" field.
        /// </summary>
        private Double? _minPlaces;

        /// <summary>
        ///     the value of the "COURSE_MAX_PLACES" field.
        /// </summary>
        private Double? _maxPlaces;

        /// <summary>
        ///     the value of the "COURSE_FREE_PLACES" field.
        /// </summary>
        private Double? _freePlaces;

        /// <summary>
        ///     the value of the "COURSE_CONF_PLACES" field.
        /// </summary>
        private Double? _confPlaces;

        /// <summary>
        ///     the value of the "COURSE_PROVIS_BKGS" field.
        /// </summary>
        private Double? _provisBkgs;

        /// <summary>
        ///     the value of the "COURSE_RESV_PLACES" field.
        /// </summary>
        private Double? _resvPlaces;

        /// <summary>
        ///     the value of the "COURSE_WAITING" field.
        /// </summary>
        private Double? _waiting;

        /// <summary>
        ///     the value of the "COURSE_CANCELS" field.
        /// </summary>
        private Double? _cancels;

        /// <summary>
        ///     the value of the "COURSE_BLOCK_THRES" field.
        /// </summary>
        private Double? _blockThres;

        /// <summary>
        ///     the value of the "COURSE_BLOCK_PRICE" field.
        /// </summary>
        private Double? _blockPrice;

        /// <summary>
        ///     the value of the "COURSE_STUDT_PRICE" field.
        /// </summary>
        private Double? _studtPrice;

        /// <summary>
        ///     the value of the "COURSE_EST_PUR_PRC" field.
        /// </summary>
        private Double? _estPurPrc;

        /// <summary>
        ///     the value of the "COURSE_NO_HOURS" field.
        /// </summary>
        private Double? _noHours;

        /// <summary>
        ///     the value of the "COURSE_VAT_CODE" field.
        /// </summary>
        private String _vatCode;

        /// <summary>
        ///     the value of the "COURSE_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "COURSE_REV_CODE" field.
        /// </summary>
        private String _revCode;

        /// <summary>
        ///     the value of the "COURSE_JN_INF_ORDE" field.
        /// </summary>
        private String _jnInfOrde;

        /// <summary>
        ///     the value of the "COURSE_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "COURSE_TUC_REGION" field.
        /// </summary>
        private String _tucRegion;

        /// <summary>
        ///     the value of the "COURSE_BUDGET" field.
        /// </summary>
        private Double? _budget;

        /// <summary>
        ///     the value of the "COURSE_ACTUAL" field.
        /// </summary>
        private Double? _actual;

        /// <summary>
        ///     the value of the "COURSE_PAY_FAG" field.
        /// </summary>
        private Byte? _payFag;

        /// <summary>
        ///     the value of the "COURSE_PAY_DATE" field.
        /// </summary>
        private DateTime? _payDate;

        /// <summary>
        ///     the value of the "COURSE_PAY_CHEQ_NO" field.
        /// </summary>
        private String _payCheqNo;

        /// <summary>
        ///     the value of the "COURSE_COLL_INV_NO" field.
        /// </summary>
        private String _collInvNo;

        /// <summary>
        ///     the value of the "COURSE_INCL_OUTLIN" field.
        /// </summary>
        private Byte? _inclOutlin;

        /// <summary>
        ///     the value of the "COURSE_INCL_MAP" field.
        /// </summary>
        private Byte? _inclMap;

        /// <summary>
        ///     the value of the "COURSE_INC_SPC_INS" field.
        /// </summary>
        private Byte? _incSpcIns;

        /// <summary>
        ///     the value of the "COURSE_INCL_BK_FRM" field.
        /// </summary>
        private Byte? _inclBkFrm;

        /// <summary>
        ///     the value of the "COURSE_INC_PST_QST" field.
        /// </summary>
        private Byte? _incPstQst;

        /// <summary>
        ///     the value of the "COURSE_INC_PRE_SRV" field.
        /// </summary>
        private Byte? _incPreSrv;

        /// <summary>
        ///     the value of the "COURSE_BUD_PERIOD" field.
        /// </summary>
        private String _budPeriod;

        /// <summary>
        ///     the value of the "COURSE_BUD_FORECST" field.
        /// </summary>
        private Double? _budForecst;

        /// <summary>
        ///     the value of the "COURSE_SOURCE_CODE" field.
        /// </summary>
        private String _sourceCode;

        /// <summary>
        ///     the value of the "COURSE_PERSON_ID_2" field.
        /// </summary>
        private String _personId2;

        /// <summary>
        ///     the value of the "COURSE_CLASS" field.
        /// </summary>
        private String _class;

        /// <summary>
        ///     the value of the "COURSE_HOST_NAME" field.
        /// </summary>
        private String _hostName;

        /// <summary>
        ///     the value of the "COURSE_VENU_ACTUAL" field.
        /// </summary>
        private Double? _venuActual;

        /// <summary>
        ///     the value of the "COURSE_VENU_BUDGET" field.
        /// </summary>
        private Double? _venuBudget;

        /// <summary>
        ///     the value of the "COURSE_CATER_ACTUL" field.
        /// </summary>
        private Double? _caterActul;

        /// <summary>
        ///     the value of the "COURSE_CATER_BDGET" field.
        /// </summary>
        private Double? _caterBdget;

        /// <summary>
        ///     the value of the "COURSE_HOTEL_ACTUL" field.
        /// </summary>
        private Double? _hotelActul;

        /// <summary>
        ///     the value of the "COURSE_HOTEL_BDGET" field.
        /// </summary>
        private Double? _hotelBdget;

        /// <summary>
        ///     the value of the "COURSE_EQUIP_ACTUL" field.
        /// </summary>
        private Double? _equipActul;

        /// <summary>
        ///     the value of the "COURSE_EQUIP_BDGET" field.
        /// </summary>
        private Double? _equipBdget;

        /// <summary>
        ///     the value of the "COURSE_TRAV_ACTUAL" field.
        /// </summary>
        private Double? _travActual;

        /// <summary>
        ///     the value of the "COURSE_TRAV_BUDGET" field.
        /// </summary>
        private Double? _travBudget;

        /// <summary>
        ///     the value of the "COURSE_EXP_ACTUAL" field.
        /// </summary>
        private Double? _expActual;

        /// <summary>
        ///     the value of the "COURSE_EXP_BUDGET" field.
        /// </summary>
        private Double? _expBudget;

        /// <summary>
        ///     the value of the "COURSE_OTHR_ACTUAL" field.
        /// </summary>
        private Double? _othrActual;

        /// <summary>
        ///     the value of the "COURSE_OTHR_BUDGET" field.
        /// </summary>
        private Double? _othrBudget;

        /// <summary>
        ///     the value of the "COURSE_QUEST_LETT" field.
        /// </summary>
        private String _questLett;

        /// <summary>
        ///     the value of the "COURSE_SURV_LETT" field.
        /// </summary>
        private String _survLett;

        /// <summary>
        ///     the value of the "COURSE_BOOK_ACTUAL" field.
        /// </summary>
        private Double? _bookActual;

        /// <summary>
        ///     the value of the "COURSE_ACTUAL_TOT" field.
        /// </summary>
        private Double? _actualTot;

        /// <summary>
        ///     the value of the "COURSE_INCL_JOIN" field.
        /// </summary>
        private Byte? _inclJoin;

        /// <summary>
        ///     the value of the "COURSE_INC_CONFIRM" field.
        /// </summary>
        private Byte? _incConfirm;

        /// <summary>
        ///     the value of the "COURSE_JOIN_LETT" field.
        /// </summary>
        private String _joinLett;

        /// <summary>
        ///     the value of the "COURSE_CONFRM_LETT" field.
        /// </summary>
        private String _confrmLett;

        /// <summary>
        ///     the value of the "COURSE_PROV_LETT" field.
        /// </summary>
        private String _provLett;

        /// <summary>
        ///     the value of the "COURSE_INV_LETT" field.
        /// </summary>
        private String _invLett;

        /// <summary>
        ///     the value of the "COURSE_DO_NOT_INVC" field.
        /// </summary>
        private Byte? _doNotInvc;

        /// <summary>
        ///     the value of the "COURSE_CANCEL_DATE" field.
        /// </summary>
        private DateTime? _cancelDate;

        /// <summary>
        ///     the value of the "COURSE_CANCEL_BY" field.
        /// </summary>
        private String _cancelBy;

        /// <summary>
        ///     the value of the "COURSE_INC_CSH_INV" field.
        /// </summary>
        private Byte? _incCshInv;

        /// <summary>
        ///     the value of the "COURSE_INC_PRO_FRM" field.
        /// </summary>
        private Byte? _incProFrm;

        /// <summary>
        ///     the value of the "COURSE_INC_RECEIPT" field.
        /// </summary>
        private Byte? _incReceipt;

        /// <summary>
        ///     the value of the "COURSE_CMC" field.
        /// </summary>
        private Byte? _cmc;

        /// <summary>
        ///     the value of the "COURSE_PL_ID" field.
        /// </summary>
        private String _plId;

        /// <summary>
        ///     the value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        private String _supplierId;

        /// <summary>
        ///     the value of the "COURSE_BREAK_EVEN" field.
        /// </summary>
        private Double? _breakEven;

        /// <summary>
        ///     the value of the "COURSE_CHANGE_HIST" field.
        /// </summary>
        private String _changeHist;

        /// <summary>
        ///     the value of the "COURSE_BIP" field.
        /// </summary>
        private Byte? _bip;

        /// <summary>
        ///     the value of the "COURSE_QUEST_ID" field.
        /// </summary>
        private String _questId;

        /// <summary>
        ///     the value of the "COURSE_POST_ID" field.
        /// </summary>
        private String _postId;

        /// <summary>
        ///     the value of the "COURSE_ORDER_NO" field.
        /// </summary>
        private String _orderNo;

        /// <summary>
        ///     the value of the "COURSE_PROV_PACK" field.
        /// </summary>
        private String _provPack;

        /// <summary>
        ///     the value of the "COURSE_CONF_PACK" field.
        /// </summary>
        private String _confPack;

        /// <summary>
        ///     the value of the "COURSE_JOINING_PACK" field.
        /// </summary>
        private String _joiningPack;

        /// <summary>
        ///     the value of the "COURSE_POST_PACK" field.
        /// </summary>
        private String _postPack;

        /// <summary>
        ///     the value of the "COURSE_PROV_INV" field.
        /// </summary>
        private Byte? _provInv;

        /// <summary>
        ///     the value of the "COURSE_CONF_INV" field.
        /// </summary>
        private Byte? _confInv;

        /// <summary>
        ///     the value of the "COURSE_JOIN_INV" field.
        /// </summary>
        private Byte? _joinInv;

        /// <summary>
        ///     the value of the "COURSE_POST_INV" field.
        /// </summary>
        private Byte? _postInv;

        /// <summary>
        ///     the value of the "COURSE_PERIOD" field.
        /// </summary>
        private String _period;

        /// <summary>
        ///     the value of the "COURSE_SEARCH_NAME" field.
        /// </summary>
        private String _searchName;

        /// <summary>
        ///     the value of the "COURSE_EVR_ID" field.
        /// </summary>
        private String _evrId;

        /// <summary>
        ///     the value of the "COURSE_OPP_ID" field.
        /// </summary>
        private String _oppId;

        /// <summary>
        ///     the value of the "COURSE_SESS_COUNT" field.
        /// </summary>
        private Int32? _sessCount;

        /// <summary>
        ///     the value of the "COURSE_PRIVATE" field.
        /// </summary>
        private Byte? _private;

        /// <summary>
        ///     the value of the "COURSE_PLAN_ID" field.
        /// </summary>
        private String _planId;

        /// <summary>
        ///     the value of the "COURSE_PLAN_NAME" field.
        /// </summary>
        private String _planName;

        /// <summary>
        ///     the value of the "COURSE_WEB" field.
        /// </summary>
        private Byte? _web;

        /// <summary>
        ///     the value of the "COURSE_GRADES" field.
        /// </summary>
        private String _grades;

        /// <summary>
        ///     the value of the "COURSE_DESC_TXT_ID" field.
        /// </summary>
        private String _descTxtId;

        /// <summary>
        ///     the value of the "COURSE_TARG_TXT_ID" field.
        /// </summary>
        private String _targTxtId;

        /// <summary>
        ///     the value of the "COURSE_SETUP_TIME" field.
        /// </summary>
        private DateTime? _setupTime;

        /// <summary>
        ///     the value of the "COURSE_DATE_DEC" field.
        /// </summary>
        private DateTime? _dateDec;

        /// <summary>
        ///     the value of the "COURSE_NUM_INVITE" field.
        /// </summary>
        private Int32? _numInvite;

        /// <summary>
        ///     the value of the "COURSE_PERSON_ID_3" field.
        /// </summary>
        private String _personId3;

        /// <summary>
        ///     the value of the "COURSE_PERSON_ID_4" field.
        /// </summary>
        private String _personId4;

        /// <summary>
        ///     the value of the "COURSE_BU_ID" field.
        /// </summary>
        private String _buId;

        /// <summary>
        ///     the value of the "COURSE_USERNUM_1" field.
        /// </summary>
        private Decimal? _usernum1;

        /// <summary>
        ///     the value of the "COURSE_USERNUM_2" field.
        /// </summary>
        private Decimal? _usernum2;

        /// <summary>
        ///     the value of the "COURSE_URL" field.
        /// </summary>
        private String _url;

        /// <summary>
        ///     the value of the "COURSE_PROJ_ID" field.
        /// </summary>
        private String _projId;

        /// <summary>
        ///     the value of the "COURSE_CODE" field.
        /// </summary>
        private String _code;

        /// <summary>
        ///     the value of the "COURSE_BT_ID" field.
        /// </summary>
        private String _btId;

        /// <summary>
        ///     the value of the "COURSE_COMMENTS" field.
        /// </summary>
        private String _comments;

        /// <summary>
        ///     the value of the "COURSE_3RD_PARTY" field.
        /// </summary>
        private Byte? _thirdParty;

        /// <summary>
        ///     the value of the "COURSE_U_DATE_1" field.
        /// </summary>
        private DateTime? _uDate1;

        /// <summary>
        ///     the value of the "COURSE_U_DATE_2" field.
        /// </summary>
        private DateTime? _uDate2;

        /// <summary>
        ///     the value of the "COURSE_U_DATE_3" field.
        /// </summary>
        private DateTime? _uDate3;

        /// <summary>
        ///     the value of the "COURSE_U_DATE_4" field.
        /// </summary>
        private DateTime? _uDate4;

        /// <summary>
        ///     the value of the "COURSE_USERNUM_3" field.
        /// </summary>
        private Decimal? _usernum3;

        /// <summary>
        ///     the value of the "COURSE_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "COURSE_NAME2" field.
        /// </summary>
        private String _name2;

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        private String _supRoleId;

        /// <summary>
        ///     the value of the "COURSE_CURRENCY" field.
        /// </summary>
        private String _currency;

        /// <summary>
        ///     the value of the "COURSE_PRICE_A" field.
        /// </summary>
        private Double? _priceA;

        /// <summary>
        ///     the value of the "COURSE_PRICE_B" field.
        /// </summary>
        private Double? _priceB;

        /// <summary>
        ///     the value of the "COURSE_PRICE_C" field.
        /// </summary>
        private Double? _priceC;

        /// <summary>
        ///     the value of the "COURSE_PRICE_D" field.
        /// </summary>
        private Double? _priceD;

        /// <summary>
        ///     the value of the "COURSE_PRICE_E" field.
        /// </summary>
        private Double? _priceE;

        /// <summary>
        ///     the value of the "COURSE_CHARGABLE" field.
        /// </summary>
        private Byte? _chargable;

        /// <summary>
        ///     the value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "COURSE_USERNUM_4" field.
        /// </summary>
        private Decimal? _usernum4;

        /// <summary>
        ///     the value of the "COURSE_USERNUM_5" field.
        /// </summary>
        private Decimal? _usernum5;

        /// <summary>
        ///     the value of the "COURSE_USERNUM_6" field.
        /// </summary>
        private Decimal? _usernum6;

        /// <summary>
        ///     the value of the "COURSE_USERNUM_7" field.
        /// </summary>
        private Byte? _usernum7;

        /// <summary>
        ///     the value of the "COURSE_INVOICED" field.
        /// </summary>
        private Byte? _invoiced;

        /// <summary>
        ///     the value of the "COURSE_BKT_ID" field.
        /// </summary>
        private String _bktId;

        /// <summary>
        ///     the value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        private String _contprolId;

        /// <summary>
        ///     the value of the "COURSE_BUD_REV" field.
        /// </summary>
        private Double? _budRev;

        /// <summary>
        ///     the value of the "COURSE_BUD_FORCAST" field.
        /// </summary>
        private Double? _budForcast;

        /// <summary>
        ///     the value of the "COURSE_U_DATE_5" field.
        /// </summary>
        private DateTime? _uDate5;

        /// <summary>
        ///     the value of the "COURSE_U_DATE_6" field.
        /// </summary>
        private DateTime? _uDate6;

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_5" field.
        /// </summary>
        private String _userchar5;

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_6" field.
        /// </summary>
        private String _userchar6;

        /// <summary>
        ///     the value of the "COURSE_U_TINT_1" field.
        /// </summary>
        private Byte? _uTint1;

        /// <summary>
        ///     the value of the "COURSE_U_TINT_2" field.
        /// </summary>
        private Byte? _uTint2;

        /// <summary>
        ///     the value of the "COURSE_U_TINT_3" field.
        /// </summary>
        private Byte? _uTint3;

        /// <summary>
        ///     the value of the "COURSE_U_TINT_4" field.
        /// </summary>
        private Byte? _uTint4;

        /// <summary>
        ///     the value of the "COURSE_U_TINT_5" field.
        /// </summary>
        private Byte? _uTint5;

        /// <summary>
        ///     the value of the "COURSE_U_TINT_6" field.
        /// </summary>
        private Byte? _uTint6;

        /// <summary>
        ///     the value of the "COURSE_SY_TYPE" field.
        /// </summary>
        private Int32? _syType;

        /// <summary>
        ///     the value of the "COURSE_PREJOIN_PACK" field.
        /// </summary>
        private String _prejoinPack;

        /// <summary>
        ///     the value of the "COURSE_PSTJOIN_PACK" field.
        /// </summary>
        private String _pstjoinPack;

        /// <summary>
        ///     the value of the "COURSE_BOOK_ACT_BC2" field.
        /// </summary>
        private Decimal? _bookActBc2;

        /// <summary>
        ///     the value of the "COURSE_ACT_TOT_BC2" field.
        /// </summary>
        private Decimal? _actTotBc2;

        /// <summary>
        ///     the value of the "COURSE_PROV_SENT_DTE" field.
        /// </summary>
        private DateTime? _provSentDte;

        /// <summary>
        ///     the value of the "COURSE_CONF_SENT_DTE" field.
        /// </summary>
        private DateTime? _confSentDte;

        /// <summary>
        ///     the value of the "COURSE_JOIN_SENT_DTE" field.
        /// </summary>
        private DateTime? _joinSentDte;

        /// <summary>
        ///     the value of the "COURSE_PP_SENT_DTE" field.
        /// </summary>
        private DateTime? _ppSentDte;

        /// <summary>
        ///     the value of the "COURSE_PRJOIN_SENT_DTE" field.
        /// </summary>
        private DateTime? _prjoinSentDte;

        /// <summary>
        ///     the value of the "COURSE_POJOIN_SENT_DTE" field.
        /// </summary>
        private DateTime? _pojoinSentDte;

        /// <summary>
        ///     the value of the "COURSE_CUT_PRD" field.
        /// </summary>
        private Int32? _cutPrd;

        /// <summary>
        ///     the value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        private String _supStatus;

        /// <summary>
        ///     the value of the "COURSE_OVERBOOK" field.
        /// </summary>
        private Byte? _overbook;

        /// <summary>
        ///     the value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        private String _provOrgId;

        /// <summary>
        ///     the value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        private String _provProleId;

        /// <summary>
        ///     the value of the "COURSE_ALLOC_STATUS" field.
        /// </summary>
        private Byte? _allocStatus;

        /// <summary>
        ///     the value of the "COURSE_EST_HOURS" field.
        /// </summary>
        private Decimal? _estHours;

        /// <summary>
        ///     the value of the "COURSE_FLOAT" field.
        /// </summary>
        private Byte? _float;

        /// <summary>
        ///     the value of the "COURSE_ACT_HOURS" field.
        /// </summary>
        private Decimal? _actHours;

        /// <summary>
        ///     the value of the "COURSE_NOTES2" field.
        /// </summary>
        private String _notes2;

        /// <summary>
        ///     the value of the "COURSE_NOTES3" field.
        /// </summary>
        private String _notes3;

        /// <summary>
        ///     the value of the "COURSE_FUNDED" field.
        /// </summary>
        private Byte? _funded;

        /// <summary>
        ///     the value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        private String _fundedOrgId;

        /// <summary>
        ///     the value of the "COURSE_QUAL_DEL" field.
        /// </summary>
        private Byte? _qualDel;

        /// <summary>
        ///     the value of the "COURSE_COH_ONLY" field.
        /// </summary>
        private Byte? _cohOnly;

        /// <summary>
        ///     the value of the "COURSE_ANALYSIS_1" field.
        /// </summary>
        private String _analysis1;

        /// <summary>
        ///     the value of the "COURSE_ANALYSIS_2" field.
        /// </summary>
        private String _analysis2;

        /// <summary>
        ///     the value of the "COURSE_RESERVATIONS" field.
        /// </summary>
        private Int32 _reservations;

        /// <summary>
        ///     the value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        private String _defElemSt;

        /// <summary>
        ///     the value of the "COURSE_LAPSED" field.
        /// </summary>
        private Int32 _lapsed;

        /// <summary>
        ///     the value of the "COURSE_INT_NOTES" field.
        /// </summary>
        private String _intNotes;

        /// <summary>
        ///     the value of the "COURSE_BD_COMP_BY" field.
        /// </summary>
        private String _bdCompBy;

        /// <summary>
        ///     the value of the "COURSE_BD_COMP_DATE" field.
        /// </summary>
        private DateTime? _bdCompDate;

        /// <summary>
        ///     the value of the "COURSE_BD_TOT_ACT_COST" field.
        /// </summary>
        private Decimal? _bdTotActCost;

        /// <summary>
        ///     the value of the "COURSE_BD_STATUS" field.
        /// </summary>
        private String _bdStatus;

        /// <summary>
        ///     the value of the "COURSE_SUBS" field.
        /// </summary>
        private Int32 _subs;

        /// <summary>
        ///     the value of the "COURSE_TRANSFERS" field.
        /// </summary>
        private Int32 _transfers;

        /// <summary>
        ///     the value of the "COURSE_HAS_TRAINER" field.
        /// </summary>
        private Byte _hasTrainer;

        /// <summary>
        ///     the value of the "COURSE_BD_PREP_BY" field.
        /// </summary>
        private String _bdPrepBy;

        /// <summary>
        ///     the value of the "COURSE_BD_PREP_DATE" field.
        /// </summary>
        private DateTime? _bdPrepDate;

        /// <summary>
        ///     the value of the "COURSE_BD_APP_BY" field.
        /// </summary>
        private String _bdAppBy;

        /// <summary>
        ///     the value of the "COURSE_BD_APP_DATE" field.
        /// </summary>
        private DateTime? _bdAppDate;

        /// <summary>
        ///     the value of the "COURSE_BD_TOT_EST_COST" field.
        /// </summary>
        private Decimal? _bdTotEstCost;

        /// <summary>
        ///     the value of the "COURSE_CALC_COMMISSION" field.
        /// </summary>
        private Byte? _calcCommission;

        /// <summary>
        ///     the value of the "COURSE_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "COURSE_CANCEL_PACK" field.
        /// </summary>
        private String _cancelPack;

        /// <summary>
        ///     the value of the "COURSE_CANP_SENT_DTE" field.
        /// </summary>
        private DateTime? _canpSentDte;

        /// <summary>
        ///     the value of the "COURSE_CANCELLATION_DATE" field.
        /// </summary>
        private DateTime? _cancellationDate;

        /// <summary>
        ///     the value of the "COURSE_REASON" field.
        /// </summary>
        private String _reason;

        /// <summary>
        ///     the value of the "COURSE_UNRECOVERABLE_CANC_LOSS" field.
        /// </summary>
        private Decimal? _unrecoverableCancLoss;

        /// <summary>
        ///     the value of the "COURSE_DEFAULT_TRAINEE_DAYS" field.
        /// </summary>
        private Decimal? _defaultTraineeDays;

        /// <summary>
        ///     the value of the "COURSE_GRANT_ELIGABLE" field.
        /// </summary>
        private Byte? _grantEligable;

        /// <summary>
        ///     the value of the "COURSE_GRANT_VALUE_AVAILABLE" field.
        /// </summary>
        private Decimal? _grantValueAvailable;

        /// <summary>
        ///     the value of the "COURSE_BREAKEVEN_VALUE1" field.
        /// </summary>
        private Decimal? _breakevenValue1;

        /// <summary>
        ///     the value of the "COURSE_BREAKEVEN_VALUE2" field.
        /// </summary>
        private Decimal? _breakevenValue2;

        /// <summary>
        ///     the value of the "COURSE_EXT_COURSEWARE" field.
        /// </summary>
        private Byte? _extCourseware;

        /// <summary>
        ///     the value of the "COURSE_CONTINGENCY" field.
        /// </summary>
        private Int32? _contingency;

        /// <summary>
        ///     the value of the "COURSE_COST" field.
        /// </summary>
        private Decimal? _cost;

        /// <summary>
        ///     the value of the "COURSE_DELIVERY_DAYS" field.
        /// </summary>
        private Int32? _deliveryDays;

        /// <summary>
        ///     the value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        private String _mtrProleId;

        /// <summary>
        ///     the value of the "COURSE_MA_PROLE_ID" field.
        /// </summary>
        private String _maProleId;

        /// <summary>
        ///     the value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        private String _acadyCode;

        /// <summary>
        ///     the value of the "COURSE_NO_AUTO_UPDATE" field.
        /// </summary>
        private Byte? _noAutoUpdate;

        /// <summary>
        ///     the value of the "COURSE_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "COURSE_USERMULTI_1" field.
        /// </summary>
        private String _usermulti1;

        /// <summary>
        ///     the value of the "COURSE_CLONE" field.
        /// </summary>
        private Byte _eventClone;

        /// <summary>
        ///     the value of the "COURSE_OUT_OF_HOURS" field.
        /// </summary>
        private Byte? _outOfHours;

        /// <summary>
        ///     the value of the "COURSE_STOP_TRAIN_COMPLETION" field.
        /// </summary>
        private Byte? _stopTrainCompletion;

        /// <summary>
        ///     the value of the "COURSE_BD_ORIG_COST" field.
        /// </summary>
        private Decimal? _bdOrigCost;

        /// <summary>
        ///     the value of the "COURSE_ORDER" field.
        /// </summary>
        private Byte _order;

        /// <summary>
        ///     the value of the "COURSE_ELEM_ID" field.
        /// </summary>
        private String _elemId;

        /// <summary>
        ///     the value of the "COURSE_CODE_LOOKUP1" field.
        /// </summary>
        private String _codeLookup1;

        /// <summary>
        ///     the value of the "COURSE_PSH_ID" field.
        /// </summary>
        private Int32? _pshId;

        /// <summary>
        ///     the value of the "COURSE_BLOCK_TYPE" field.
        /// </summary>
        private Byte? _blockType;

        /// <summary>
        ///     the value of the "COURSE_ATT_MOD_BY" field.
        /// </summary>
        private String _attModBy;

        /// <summary>
        ///     the value of the "COURSE_ATT_MOD_DATE" field.
        /// </summary>
        private DateTime? _attModDate;

        /// <summary>
        ///     the value of the "COURSE_AVAIL" field.
        /// </summary>
        private String _avail;

        /// <summary>
        ///     the value of the "COURSE_FIRST_LIC_EVENT" field.
        /// </summary>
        private Byte? _firstLicEvent;

        /// <summary>
        ///     the value of the "COURSE_TRNP_ID" field.
        /// </summary>
        private Int32? _trnpId;

        /// <summary>
        ///     the value of the "COURSE_LICENSED" field.
        /// </summary>
        private Byte _licensed;

        /// <summary>
        ///     the value of the "COURSE_RESULT_REC_DATE" field.
        /// </summary>
        private DateTime? _resultRecDate;

        /// <summary>
        ///     the value of the "COURSE_PAPERS_REC_DATE" field.
        /// </summary>
        private DateTime? _papersRecDate;

        /// <summary>
        ///     the value of the "COURSE_CERT_ISSUE_DATE" field.
        /// </summary>
        private DateTime? _certIssueDate;

        /// <summary>
        ///     the value of the "COURSE_DEL_IMP_DATE" field.
        /// </summary>
        private DateTime? _delImpDate;

        /// <summary>
        ///     the value of the "COURSE_ITEMS_RECEIVED_DATE" field.
        /// </summary>
        private DateTime? _itemsReceivedDate;

        /// <summary>
        ///     the value of the "COURSE_DELIV_METHD" field.
        /// </summary>
        private String _delivMethd;

        /// <summary>
        ///     the value of the "COURSE_PACK_SEND_PROLE_ID" field.
        /// </summary>
        private String _packSendProleId;

        /// <summary>
        ///     the value of the "COURSE_PACK_BCC_EMAIL" field.
        /// </summary>
        private String _packBccEmail;

        /// <summary>
        ///     the value of the "COURSE_PACK_MDN_EMAIL" field.
        /// </summary>
        private String _packMdnEmail;

        /// <summary>
        ///     the value of the "COURSE_PACK_DSN_EMAIL" field.
        /// </summary>
        private String _packDsnEmail;

        /// <summary>
        ///     the value of the "COURSE_PACK_DSN_OPTIONS" field.
        /// </summary>
        private String _packDsnOptions;

        /// <summary>
        ///     the value of the "COURSE_CODE_IMAGE" field.
        /// </summary>
        private String _codeImage;

        /// <summary>
        ///     the value of the "COURSE_CLIENT_REF" field.
        /// </summary>
        private String _clientRef;

        /// <summary>
        ///     the value of the "COURSE_SESSIONS_DESCRIPTION" field.
        /// </summary>
        private String _sessionsDescription;

        /// <summary>
        ///     the value of the "COURSE_SESSIONS_HEADER" field.
        /// </summary>
        private String _sessionsHeader;

        /// <summary>
        ///     the value of the "COURSE_CUT_PRD_TIME" field.
        /// </summary>
        private Byte? _cutPrdTime;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "COURSE_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PRODUCT_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_LOC_ID" field.
        /// </summary>
        public String LocId
        {
            get { return _locId; }
            set { _locId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_REF" field.
        /// </summary>
        public String Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SECTOR" field.
        /// </summary>
        public String Sector
        {
            get { return _sector; }
            set { _sector = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ON_SITE" field.
        /// </summary>
        public Byte? OnSite
        {
            get { return _onSite; }
            set { _onSite = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BLOCK_PRICD" field.
        /// </summary>
        public Byte? BlockPricd
        {
            get { return _blockPricd; }
            set { _blockPricd = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_START_TIME" field.
        /// </summary>
        public DateTime? StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_END_TIME" field.
        /// </summary>
        public DateTime? EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_DIARY_TYPE" field.
        /// </summary>
        public String DiaryType
        {
            get { return _diaryType; }
            set { _diaryType = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_LENGTH" field.
        /// </summary>
        public Double? Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_MIN_PLACES" field.
        /// </summary>
        public Double? MinPlaces
        {
            get { return _minPlaces; }
            set { _minPlaces = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_MAX_PLACES" field.
        /// </summary>
        public Double? MaxPlaces
        {
            get { return _maxPlaces; }
            set { _maxPlaces = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_FREE_PLACES" field.
        /// </summary>
        public Double? FreePlaces
        {
            get { return _freePlaces; }
            set { _freePlaces = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CONF_PLACES" field.
        /// </summary>
        public Double? ConfPlaces
        {
            get { return _confPlaces; }
            set { _confPlaces = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PROVIS_BKGS" field.
        /// </summary>
        public Double? ProvisBkgs
        {
            get { return _provisBkgs; }
            set { _provisBkgs = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_RESV_PLACES" field.
        /// </summary>
        public Double? ResvPlaces
        {
            get { return _resvPlaces; }
            set { _resvPlaces = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_WAITING" field.
        /// </summary>
        public Double? Waiting
        {
            get { return _waiting; }
            set { _waiting = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CANCELS" field.
        /// </summary>
        public Double? Cancels
        {
            get { return _cancels; }
            set { _cancels = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BLOCK_THRES" field.
        /// </summary>
        public Double? BlockThres
        {
            get { return _blockThres; }
            set { _blockThres = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BLOCK_PRICE" field.
        /// </summary>
        public Double? BlockPrice
        {
            get { return _blockPrice; }
            set { _blockPrice = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_STUDT_PRICE" field.
        /// </summary>
        public Double? StudtPrice
        {
            get { return _studtPrice; }
            set { _studtPrice = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_EST_PUR_PRC" field.
        /// </summary>
        public Double? EstPurPrc
        {
            get { return _estPurPrc; }
            set { _estPurPrc = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_NO_HOURS" field.
        /// </summary>
        public Double? NoHours
        {
            get { return _noHours; }
            set { _noHours = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_VAT_CODE" field.
        /// </summary>
        public String VatCode
        {
            get { return _vatCode; }
            set { _vatCode = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return _revCode; }
            set { _revCode = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_JN_INF_ORDE" field.
        /// </summary>
        public String JnInfOrde
        {
            get { return _jnInfOrde; }
            set { _jnInfOrde = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_TUC_REGION" field.
        /// </summary>
        public String TucRegion
        {
            get { return _tucRegion; }
            set { _tucRegion = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BUDGET" field.
        /// </summary>
        public Double? Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ACTUAL" field.
        /// </summary>
        public Double? Actual
        {
            get { return _actual; }
            set { _actual = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PAY_FAG" field.
        /// </summary>
        public Byte? PayFag
        {
            get { return _payFag; }
            set { _payFag = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PAY_DATE" field.
        /// </summary>
        public DateTime? PayDate
        {
            get { return _payDate; }
            set { _payDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PAY_CHEQ_NO" field.
        /// </summary>
        public String PayCheqNo
        {
            get { return _payCheqNo; }
            set { _payCheqNo = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_COLL_INV_NO" field.
        /// </summary>
        public String CollInvNo
        {
            get { return _collInvNo; }
            set { _collInvNo = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INCL_OUTLIN" field.
        /// </summary>
        public Byte? InclOutlin
        {
            get { return _inclOutlin; }
            set { _inclOutlin = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INCL_MAP" field.
        /// </summary>
        public Byte? InclMap
        {
            get { return _inclMap; }
            set { _inclMap = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INC_SPC_INS" field.
        /// </summary>
        public Byte? IncSpcIns
        {
            get { return _incSpcIns; }
            set { _incSpcIns = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INCL_BK_FRM" field.
        /// </summary>
        public Byte? InclBkFrm
        {
            get { return _inclBkFrm; }
            set { _inclBkFrm = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INC_PST_QST" field.
        /// </summary>
        public Byte? IncPstQst
        {
            get { return _incPstQst; }
            set { _incPstQst = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INC_PRE_SRV" field.
        /// </summary>
        public Byte? IncPreSrv
        {
            get { return _incPreSrv; }
            set { _incPreSrv = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BUD_PERIOD" field.
        /// </summary>
        public String BudPeriod
        {
            get { return _budPeriod; }
            set { _budPeriod = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BUD_FORECST" field.
        /// </summary>
        public Double? BudForecst
        {
            get { return _budForecst; }
            set { _budForecst = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SOURCE_CODE" field.
        /// </summary>
        public String SourceCode
        {
            get { return _sourceCode; }
            set { _sourceCode = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PERSON_ID_2" field.
        /// </summary>
        public String PersonId2
        {
            get { return _personId2; }
            set { _personId2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CLASS" field.
        /// </summary>
        public String Class
        {
            get { return _class; }
            set { _class = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_HOST_NAME" field.
        /// </summary>
        public String HostName
        {
            get { return _hostName; }
            set { _hostName = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_VENU_ACTUAL" field.
        /// </summary>
        public Double? VenuActual
        {
            get { return _venuActual; }
            set { _venuActual = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_VENU_BUDGET" field.
        /// </summary>
        public Double? VenuBudget
        {
            get { return _venuBudget; }
            set { _venuBudget = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CATER_ACTUL" field.
        /// </summary>
        public Double? CaterActul
        {
            get { return _caterActul; }
            set { _caterActul = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CATER_BDGET" field.
        /// </summary>
        public Double? CaterBdget
        {
            get { return _caterBdget; }
            set { _caterBdget = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_HOTEL_ACTUL" field.
        /// </summary>
        public Double? HotelActul
        {
            get { return _hotelActul; }
            set { _hotelActul = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_HOTEL_BDGET" field.
        /// </summary>
        public Double? HotelBdget
        {
            get { return _hotelBdget; }
            set { _hotelBdget = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_EQUIP_ACTUL" field.
        /// </summary>
        public Double? EquipActul
        {
            get { return _equipActul; }
            set { _equipActul = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_EQUIP_BDGET" field.
        /// </summary>
        public Double? EquipBdget
        {
            get { return _equipBdget; }
            set { _equipBdget = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_TRAV_ACTUAL" field.
        /// </summary>
        public Double? TravActual
        {
            get { return _travActual; }
            set { _travActual = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_TRAV_BUDGET" field.
        /// </summary>
        public Double? TravBudget
        {
            get { return _travBudget; }
            set { _travBudget = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_EXP_ACTUAL" field.
        /// </summary>
        public Double? ExpActual
        {
            get { return _expActual; }
            set { _expActual = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_EXP_BUDGET" field.
        /// </summary>
        public Double? ExpBudget
        {
            get { return _expBudget; }
            set { _expBudget = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_OTHR_ACTUAL" field.
        /// </summary>
        public Double? OthrActual
        {
            get { return _othrActual; }
            set { _othrActual = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_OTHR_BUDGET" field.
        /// </summary>
        public Double? OthrBudget
        {
            get { return _othrBudget; }
            set { _othrBudget = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_QUEST_LETT" field.
        /// </summary>
        public String QuestLett
        {
            get { return _questLett; }
            set { _questLett = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SURV_LETT" field.
        /// </summary>
        public String SurvLett
        {
            get { return _survLett; }
            set { _survLett = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BOOK_ACTUAL" field.
        /// </summary>
        public Double? BookActual
        {
            get { return _bookActual; }
            set { _bookActual = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ACTUAL_TOT" field.
        /// </summary>
        public Double? ActualTot
        {
            get { return _actualTot; }
            set { _actualTot = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INCL_JOIN" field.
        /// </summary>
        public Byte? InclJoin
        {
            get { return _inclJoin; }
            set { _inclJoin = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INC_CONFIRM" field.
        /// </summary>
        public Byte? IncConfirm
        {
            get { return _incConfirm; }
            set { _incConfirm = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_JOIN_LETT" field.
        /// </summary>
        public String JoinLett
        {
            get { return _joinLett; }
            set { _joinLett = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CONFRM_LETT" field.
        /// </summary>
        public String ConfrmLett
        {
            get { return _confrmLett; }
            set { _confrmLett = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PROV_LETT" field.
        /// </summary>
        public String ProvLett
        {
            get { return _provLett; }
            set { _provLett = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INV_LETT" field.
        /// </summary>
        public String InvLett
        {
            get { return _invLett; }
            set { _invLett = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_DO_NOT_INVC" field.
        /// </summary>
        public Byte? DoNotInvc
        {
            get { return _doNotInvc; }
            set { _doNotInvc = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CANCEL_DATE" field.
        /// </summary>
        public DateTime? CancelDate
        {
            get { return _cancelDate; }
            set { _cancelDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CANCEL_BY" field.
        /// </summary>
        public String CancelBy
        {
            get { return _cancelBy; }
            set { _cancelBy = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INC_CSH_INV" field.
        /// </summary>
        public Byte? IncCshInv
        {
            get { return _incCshInv; }
            set { _incCshInv = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INC_PRO_FRM" field.
        /// </summary>
        public Byte? IncProFrm
        {
            get { return _incProFrm; }
            set { _incProFrm = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INC_RECEIPT" field.
        /// </summary>
        public Byte? IncReceipt
        {
            get { return _incReceipt; }
            set { _incReceipt = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CMC" field.
        /// </summary>
        public Byte? Cmc
        {
            get { return _cmc; }
            set { _cmc = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PL_ID" field.
        /// </summary>
        public String PlId
        {
            get { return _plId; }
            set { _plId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        public String SupplierId
        {
            get { return _supplierId; }
            set { _supplierId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BREAK_EVEN" field.
        /// </summary>
        public Double? BreakEven
        {
            get { return _breakEven; }
            set { _breakEven = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CHANGE_HIST" field.
        /// </summary>
        public String ChangeHist
        {
            get { return _changeHist; }
            set { _changeHist = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BIP" field.
        /// </summary>
        public Byte? Bip
        {
            get { return _bip; }
            set { _bip = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_QUEST_ID" field.
        /// </summary>
        public String QuestId
        {
            get { return _questId; }
            set { _questId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_POST_ID" field.
        /// </summary>
        public String PostId
        {
            get { return _postId; }
            set { _postId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ORDER_NO" field.
        /// </summary>
        public String OrderNo
        {
            get { return _orderNo; }
            set { _orderNo = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PROV_PACK" field.
        /// </summary>
        public String ProvPack
        {
            get { return _provPack; }
            set { _provPack = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CONF_PACK" field.
        /// </summary>
        public String ConfPack
        {
            get { return _confPack; }
            set { _confPack = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_JOINING_PACK" field.
        /// </summary>
        public String JoiningPack
        {
            get { return _joiningPack; }
            set { _joiningPack = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_POST_PACK" field.
        /// </summary>
        public String PostPack
        {
            get { return _postPack; }
            set { _postPack = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PROV_INV" field.
        /// </summary>
        public Byte? ProvInv
        {
            get { return _provInv; }
            set { _provInv = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CONF_INV" field.
        /// </summary>
        public Byte? ConfInv
        {
            get { return _confInv; }
            set { _confInv = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_JOIN_INV" field.
        /// </summary>
        public Byte? JoinInv
        {
            get { return _joinInv; }
            set { _joinInv = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_POST_INV" field.
        /// </summary>
        public Byte? PostInv
        {
            get { return _postInv; }
            set { _postInv = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PERIOD" field.
        /// </summary>
        public String Period
        {
            get { return _period; }
            set { _period = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SEARCH_NAME" field.
        /// </summary>
        public String SearchName
        {
            get { return _searchName; }
            set { _searchName = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_EVR_ID" field.
        /// </summary>
        public String EvrId
        {
            get { return _evrId; }
            set { _evrId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_OPP_ID" field.
        /// </summary>
        public String OppId
        {
            get { return _oppId; }
            set { _oppId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SESS_COUNT" field.
        /// </summary>
        public Int32? SessCount
        {
            get { return _sessCount; }
            set { _sessCount = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PRIVATE" field.
        /// </summary>
        public Byte? Private
        {
            get { return _private; }
            set { _private = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PLAN_ID" field.
        /// </summary>
        public String PlanId
        {
            get { return _planId; }
            set { _planId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PLAN_NAME" field.
        /// </summary>
        public String PlanName
        {
            get { return _planName; }
            set { _planName = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_WEB" field.
        /// </summary>
        public Byte? Web
        {
            get { return _web; }
            set { _web = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_GRADES" field.
        /// </summary>
        public String Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_DESC_TXT_ID" field.
        /// </summary>
        public String DescTxtId
        {
            get { return _descTxtId; }
            set { _descTxtId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_TARG_TXT_ID" field.
        /// </summary>
        public String TargTxtId
        {
            get { return _targTxtId; }
            set { _targTxtId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SETUP_TIME" field.
        /// </summary>
        public DateTime? SetupTime
        {
            get { return _setupTime; }
            set { _setupTime = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_DATE_DEC" field.
        /// </summary>
        public DateTime? DateDec
        {
            get { return _dateDec; }
            set { _dateDec = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_NUM_INVITE" field.
        /// </summary>
        public Int32? NumInvite
        {
            get { return _numInvite; }
            set { _numInvite = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PERSON_ID_3" field.
        /// </summary>
        public String PersonId3
        {
            get { return _personId3; }
            set { _personId3 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PERSON_ID_4" field.
        /// </summary>
        public String PersonId4
        {
            get { return _personId4; }
            set { _personId4 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BU_ID" field.
        /// </summary>
        public String BuId
        {
            get { return _buId; }
            set { _buId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERNUM_1" field.
        /// </summary>
        public Decimal? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERNUM_2" field.
        /// </summary>
        public Decimal? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PROJ_ID" field.
        /// </summary>
        public String ProjId
        {
            get { return _projId; }
            set { _projId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CODE" field.
        /// </summary>
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BT_ID" field.
        /// </summary>
        public String BtId
        {
            get { return _btId; }
            set { _btId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_COMMENTS" field.
        /// </summary>
        public String Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_3RD_PARTY" field.
        /// </summary>
        public Byte? ThirdParty
        {
            get { return _thirdParty; }
            set { _thirdParty = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_DATE_1" field.
        /// </summary>
        public DateTime? UDate1
        {
            get { return _uDate1; }
            set { _uDate1 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_DATE_2" field.
        /// </summary>
        public DateTime? UDate2
        {
            get { return _uDate2; }
            set { _uDate2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_DATE_3" field.
        /// </summary>
        public DateTime? UDate3
        {
            get { return _uDate3; }
            set { _uDate3 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_DATE_4" field.
        /// </summary>
        public DateTime? UDate4
        {
            get { return _uDate4; }
            set { _uDate4 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERNUM_3" field.
        /// </summary>
        public Decimal? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_NAME2" field.
        /// </summary>
        public String Name2
        {
            get { return _name2; }
            set { _name2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        public String SupRoleId
        {
            get { return _supRoleId; }
            set { _supRoleId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PRICE_A" field.
        /// </summary>
        public Double? PriceA
        {
            get { return _priceA; }
            set { _priceA = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PRICE_B" field.
        /// </summary>
        public Double? PriceB
        {
            get { return _priceB; }
            set { _priceB = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PRICE_C" field.
        /// </summary>
        public Double? PriceC
        {
            get { return _priceC; }
            set { _priceC = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PRICE_D" field.
        /// </summary>
        public Double? PriceD
        {
            get { return _priceD; }
            set { _priceD = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PRICE_E" field.
        /// </summary>
        public Double? PriceE
        {
            get { return _priceE; }
            set { _priceE = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CHARGABLE" field.
        /// </summary>
        public Byte? Chargable
        {
            get { return _chargable; }
            set { _chargable = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERNUM_4" field.
        /// </summary>
        public Decimal? Usernum4
        {
            get { return _usernum4; }
            set { _usernum4 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERNUM_5" field.
        /// </summary>
        public Decimal? Usernum5
        {
            get { return _usernum5; }
            set { _usernum5 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERNUM_6" field.
        /// </summary>
        public Decimal? Usernum6
        {
            get { return _usernum6; }
            set { _usernum6 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERNUM_7" field.
        /// </summary>
        public Byte? Usernum7
        {
            get { return _usernum7; }
            set { _usernum7 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INVOICED" field.
        /// </summary>
        public Byte? Invoiced
        {
            get { return _invoiced; }
            set { _invoiced = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BKT_ID" field.
        /// </summary>
        public String BktId
        {
            get { return _bktId; }
            set { _bktId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        public String ContprolId
        {
            get { return _contprolId; }
            set { _contprolId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BUD_REV" field.
        /// </summary>
        public Double? BudRev
        {
            get { return _budRev; }
            set { _budRev = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BUD_FORCAST" field.
        /// </summary>
        public Double? BudForcast
        {
            get { return _budForcast; }
            set { _budForcast = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_DATE_5" field.
        /// </summary>
        public DateTime? UDate5
        {
            get { return _uDate5; }
            set { _uDate5 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_DATE_6" field.
        /// </summary>
        public DateTime? UDate6
        {
            get { return _uDate6; }
            set { _uDate6 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return _userchar5; }
            set { _userchar5 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return _userchar6; }
            set { _userchar6 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_TINT_1" field.
        /// </summary>
        public Byte? UTint1
        {
            get { return _uTint1; }
            set { _uTint1 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_TINT_2" field.
        /// </summary>
        public Byte? UTint2
        {
            get { return _uTint2; }
            set { _uTint2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_TINT_3" field.
        /// </summary>
        public Byte? UTint3
        {
            get { return _uTint3; }
            set { _uTint3 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_TINT_4" field.
        /// </summary>
        public Byte? UTint4
        {
            get { return _uTint4; }
            set { _uTint4 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_TINT_5" field.
        /// </summary>
        public Byte? UTint5
        {
            get { return _uTint5; }
            set { _uTint5 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_U_TINT_6" field.
        /// </summary>
        public Byte? UTint6
        {
            get { return _uTint6; }
            set { _uTint6 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SY_TYPE" field.
        /// </summary>
        public Int32? SyType
        {
            get { return _syType; }
            set { _syType = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PREJOIN_PACK" field.
        /// </summary>
        public String PrejoinPack
        {
            get { return _prejoinPack; }
            set { _prejoinPack = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PSTJOIN_PACK" field.
        /// </summary>
        public String PstjoinPack
        {
            get { return _pstjoinPack; }
            set { _pstjoinPack = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BOOK_ACT_BC2" field.
        /// </summary>
        public Decimal? BookActBc2
        {
            get { return _bookActBc2; }
            set { _bookActBc2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ACT_TOT_BC2" field.
        /// </summary>
        public Decimal? ActTotBc2
        {
            get { return _actTotBc2; }
            set { _actTotBc2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PROV_SENT_DTE" field.
        /// </summary>
        public DateTime? ProvSentDte
        {
            get { return _provSentDte; }
            set { _provSentDte = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CONF_SENT_DTE" field.
        /// </summary>
        public DateTime? ConfSentDte
        {
            get { return _confSentDte; }
            set { _confSentDte = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_JOIN_SENT_DTE" field.
        /// </summary>
        public DateTime? JoinSentDte
        {
            get { return _joinSentDte; }
            set { _joinSentDte = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PP_SENT_DTE" field.
        /// </summary>
        public DateTime? PpSentDte
        {
            get { return _ppSentDte; }
            set { _ppSentDte = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PRJOIN_SENT_DTE" field.
        /// </summary>
        public DateTime? PrjoinSentDte
        {
            get { return _prjoinSentDte; }
            set { _prjoinSentDte = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_POJOIN_SENT_DTE" field.
        /// </summary>
        public DateTime? PojoinSentDte
        {
            get { return _pojoinSentDte; }
            set { _pojoinSentDte = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CUT_PRD" field.
        /// </summary>
        public Int32? CutPrd
        {
            get { return _cutPrd; }
            set { _cutPrd = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        public String SupStatus
        {
            get { return _supStatus; }
            set { _supStatus = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_OVERBOOK" field.
        /// </summary>
        public Byte? Overbook
        {
            get { return _overbook; }
            set { _overbook = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        public String ProvOrgId
        {
            get { return _provOrgId; }
            set { _provOrgId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        public String ProvProleId
        {
            get { return _provProleId; }
            set { _provProleId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ALLOC_STATUS" field.
        /// </summary>
        public Byte? AllocStatus
        {
            get { return _allocStatus; }
            set { _allocStatus = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_EST_HOURS" field.
        /// </summary>
        public Decimal? EstHours
        {
            get { return _estHours; }
            set { _estHours = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_FLOAT" field.
        /// </summary>
        public Byte? Float
        {
            get { return _float; }
            set { _float = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ACT_HOURS" field.
        /// </summary>
        public Decimal? ActHours
        {
            get { return _actHours; }
            set { _actHours = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_NOTES2" field.
        /// </summary>
        public String Notes2
        {
            get { return _notes2; }
            set { _notes2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_NOTES3" field.
        /// </summary>
        public String Notes3
        {
            get { return _notes3; }
            set { _notes3 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_FUNDED" field.
        /// </summary>
        public Byte? Funded
        {
            get { return _funded; }
            set { _funded = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        public String FundedOrgId
        {
            get { return _fundedOrgId; }
            set { _fundedOrgId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_QUAL_DEL" field.
        /// </summary>
        public Byte? QualDel
        {
            get { return _qualDel; }
            set { _qualDel = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_COH_ONLY" field.
        /// </summary>
        public Byte? CohOnly
        {
            get { return _cohOnly; }
            set { _cohOnly = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ANALYSIS_1" field.
        /// </summary>
        public String Analysis1
        {
            get { return _analysis1; }
            set { _analysis1 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ANALYSIS_2" field.
        /// </summary>
        public String Analysis2
        {
            get { return _analysis2; }
            set { _analysis2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_RESERVATIONS" field.
        /// </summary>
        public Int32 Reservations
        {
            get { return _reservations; }
            set { _reservations = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        public String DefElemSt
        {
            get { return _defElemSt; }
            set { _defElemSt = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_LAPSED" field.
        /// </summary>
        public Int32 Lapsed
        {
            get { return _lapsed; }
            set { _lapsed = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_INT_NOTES" field.
        /// </summary>
        public String IntNotes
        {
            get { return _intNotes; }
            set { _intNotes = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BD_COMP_BY" field.
        /// </summary>
        public String BdCompBy
        {
            get { return _bdCompBy; }
            set { _bdCompBy = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BD_COMP_DATE" field.
        /// </summary>
        public DateTime? BdCompDate
        {
            get { return _bdCompDate; }
            set { _bdCompDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BD_TOT_ACT_COST" field.
        /// </summary>
        public Decimal? BdTotActCost
        {
            get { return _bdTotActCost; }
            set { _bdTotActCost = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BD_STATUS" field.
        /// </summary>
        public String BdStatus
        {
            get { return _bdStatus; }
            set { _bdStatus = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SUBS" field.
        /// </summary>
        public Int32 Subs
        {
            get { return _subs; }
            set { _subs = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_TRANSFERS" field.
        /// </summary>
        public Int32 Transfers
        {
            get { return _transfers; }
            set { _transfers = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_HAS_TRAINER" field.
        /// </summary>
        public Byte HasTrainer
        {
            get { return _hasTrainer; }
            set { _hasTrainer = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BD_PREP_BY" field.
        /// </summary>
        public String BdPrepBy
        {
            get { return _bdPrepBy; }
            set { _bdPrepBy = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BD_PREP_DATE" field.
        /// </summary>
        public DateTime? BdPrepDate
        {
            get { return _bdPrepDate; }
            set { _bdPrepDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BD_APP_BY" field.
        /// </summary>
        public String BdAppBy
        {
            get { return _bdAppBy; }
            set { _bdAppBy = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BD_APP_DATE" field.
        /// </summary>
        public DateTime? BdAppDate
        {
            get { return _bdAppDate; }
            set { _bdAppDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BD_TOT_EST_COST" field.
        /// </summary>
        public Decimal? BdTotEstCost
        {
            get { return _bdTotEstCost; }
            set { _bdTotEstCost = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CALC_COMMISSION" field.
        /// </summary>
        public Byte? CalcCommission
        {
            get { return _calcCommission; }
            set { _calcCommission = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CANCEL_PACK" field.
        /// </summary>
        public String CancelPack
        {
            get { return _cancelPack; }
            set { _cancelPack = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CANP_SENT_DTE" field.
        /// </summary>
        public DateTime? CanpSentDte
        {
            get { return _canpSentDte; }
            set { _canpSentDte = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CANCELLATION_DATE" field.
        /// </summary>
        public DateTime? CancellationDate
        {
            get { return _cancellationDate; }
            set { _cancellationDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_REASON" field.
        /// </summary>
        public String Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_UNRECOVERABLE_CANC_LOSS" field.
        /// </summary>
        public Decimal? UnrecoverableCancLoss
        {
            get { return _unrecoverableCancLoss; }
            set { _unrecoverableCancLoss = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_DEFAULT_TRAINEE_DAYS" field.
        /// </summary>
        public Decimal? DefaultTraineeDays
        {
            get { return _defaultTraineeDays; }
            set { _defaultTraineeDays = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_GRANT_ELIGABLE" field.
        /// </summary>
        public Byte? GrantEligable
        {
            get { return _grantEligable; }
            set { _grantEligable = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_GRANT_VALUE_AVAILABLE" field.
        /// </summary>
        public Decimal? GrantValueAvailable
        {
            get { return _grantValueAvailable; }
            set { _grantValueAvailable = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BREAKEVEN_VALUE1" field.
        /// </summary>
        public Decimal? BreakevenValue1
        {
            get { return _breakevenValue1; }
            set { _breakevenValue1 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BREAKEVEN_VALUE2" field.
        /// </summary>
        public Decimal? BreakevenValue2
        {
            get { return _breakevenValue2; }
            set { _breakevenValue2 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_EXT_COURSEWARE" field.
        /// </summary>
        public Byte? ExtCourseware
        {
            get { return _extCourseware; }
            set { _extCourseware = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CONTINGENCY" field.
        /// </summary>
        public Int32? Contingency
        {
            get { return _contingency; }
            set { _contingency = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_COST" field.
        /// </summary>
        public Decimal? Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_DELIVERY_DAYS" field.
        /// </summary>
        public Int32? DeliveryDays
        {
            get { return _deliveryDays; }
            set { _deliveryDays = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        public String MtrProleId
        {
            get { return _mtrProleId; }
            set { _mtrProleId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_MA_PROLE_ID" field.
        /// </summary>
        public String MaProleId
        {
            get { return _maProleId; }
            set { _maProleId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        public String AcadyCode
        {
            get { return _acadyCode; }
            set { _acadyCode = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_NO_AUTO_UPDATE" field.
        /// </summary>
        public Byte? NoAutoUpdate
        {
            get { return _noAutoUpdate; }
            set { _noAutoUpdate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_USERMULTI_1" field.
        /// </summary>
        public String Usermulti1
        {
            get { return _usermulti1; }
            set { _usermulti1 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CLONE" field.
        /// </summary>
        public Byte EventClone
        {
            get { return _eventClone; }
            set { _eventClone = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_OUT_OF_HOURS" field.
        /// </summary>
        public Byte? OutOfHours
        {
            get { return _outOfHours; }
            set { _outOfHours = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_STOP_TRAIN_COMPLETION" field.
        /// </summary>
        public Byte? StopTrainCompletion
        {
            get { return _stopTrainCompletion; }
            set { _stopTrainCompletion = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BD_ORIG_COST" field.
        /// </summary>
        public Decimal? BdOrigCost
        {
            get { return _bdOrigCost; }
            set { _bdOrigCost = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ORDER" field.
        /// </summary>
        public Byte Order
        {
            get { return _order; }
            set { _order = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ELEM_ID" field.
        /// </summary>
        public String ElemId
        {
            get { return _elemId; }
            set { _elemId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CODE_LOOKUP1" field.
        /// </summary>
        public String CodeLookup1
        {
            get { return _codeLookup1; }
            set { _codeLookup1 = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PSH_ID" field.
        /// </summary>
        public Int32? PshId
        {
            get { return _pshId; }
            set { _pshId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_BLOCK_TYPE" field.
        /// </summary>
        public Byte? BlockType
        {
            get { return _blockType; }
            set { _blockType = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ATT_MOD_BY" field.
        /// </summary>
        public String AttModBy
        {
            get { return _attModBy; }
            set { _attModBy = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ATT_MOD_DATE" field.
        /// </summary>
        public DateTime? AttModDate
        {
            get { return _attModDate; }
            set { _attModDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_AVAIL" field.
        /// </summary>
        public String Avail
        {
            get { return _avail; }
            set { _avail = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_FIRST_LIC_EVENT" field.
        /// </summary>
        public Byte? FirstLicEvent
        {
            get { return _firstLicEvent; }
            set { _firstLicEvent = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_TRNP_ID" field.
        /// </summary>
        public Int32? TrnpId
        {
            get { return _trnpId; }
            set { _trnpId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_LICENSED" field.
        /// </summary>
        public Byte Licensed
        {
            get { return _licensed; }
            set { _licensed = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_RESULT_REC_DATE" field.
        /// </summary>
        public DateTime? ResultRecDate
        {
            get { return _resultRecDate; }
            set { _resultRecDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PAPERS_REC_DATE" field.
        /// </summary>
        public DateTime? PapersRecDate
        {
            get { return _papersRecDate; }
            set { _papersRecDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CERT_ISSUE_DATE" field.
        /// </summary>
        public DateTime? CertIssueDate
        {
            get { return _certIssueDate; }
            set { _certIssueDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_DEL_IMP_DATE" field.
        /// </summary>
        public DateTime? DelImpDate
        {
            get { return _delImpDate; }
            set { _delImpDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_ITEMS_RECEIVED_DATE" field.
        /// </summary>
        public DateTime? ItemsReceivedDate
        {
            get { return _itemsReceivedDate; }
            set { _itemsReceivedDate = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_DELIV_METHD" field.
        /// </summary>
        public String DelivMethd
        {
            get { return _delivMethd; }
            set { _delivMethd = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PACK_SEND_PROLE_ID" field.
        /// </summary>
        public String PackSendProleId
        {
            get { return _packSendProleId; }
            set { _packSendProleId = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PACK_BCC_EMAIL" field.
        /// </summary>
        public String PackBccEmail
        {
            get { return _packBccEmail; }
            set { _packBccEmail = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PACK_MDN_EMAIL" field.
        /// </summary>
        public String PackMdnEmail
        {
            get { return _packMdnEmail; }
            set { _packMdnEmail = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PACK_DSN_EMAIL" field.
        /// </summary>
        public String PackDsnEmail
        {
            get { return _packDsnEmail; }
            set { _packDsnEmail = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_PACK_DSN_OPTIONS" field.
        /// </summary>
        public String PackDsnOptions
        {
            get { return _packDsnOptions; }
            set { _packDsnOptions = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CODE_IMAGE" field.
        /// </summary>
        public String CodeImage
        {
            get { return _codeImage; }
            set { _codeImage = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CLIENT_REF" field.
        /// </summary>
        public String ClientRef
        {
            get { return _clientRef; }
            set { _clientRef = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SESSIONS_DESCRIPTION" field.
        /// </summary>
        public String SessionsDescription
        {
            get { return _sessionsDescription; }
            set { _sessionsDescription = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_SESSIONS_HEADER" field.
        /// </summary>
        public String SessionsHeader
        {
            get { return _sessionsHeader; }
            set { _sessionsHeader = value; }
        }

        /// <summary>
        ///     the value of the "COURSE_CUT_PRD_TIME" field.
        /// </summary>
        public Byte? CutPrdTime
        {
            get { return _cutPrdTime; }
            set { _cutPrdTime = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="CourseRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="CourseRecord" /> object instance.
        /// </returns>
        public CourseRecord Clone()
        {
            CourseRecord record = new CourseRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.PersonId = this.PersonId;
            record.ProductId = this.ProductId;
            record.LocId = this.LocId;
            record.OrgId = this.OrgId;
            record.Ref = this.Ref;
            record.Name = this.Name;
            record.Type = this.Type;
            record.Sector = this.Sector;
            record.OnSite = this.OnSite;
            record.BlockPricd = this.BlockPricd;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            record.StartTime = this.StartTime;
            record.EndTime = this.EndTime;
            record.Status = this.Status;
            record.DiaryType = this.DiaryType;
            record.Length = this.Length;
            record.MinPlaces = this.MinPlaces;
            record.MaxPlaces = this.MaxPlaces;
            record.FreePlaces = this.FreePlaces;
            record.ConfPlaces = this.ConfPlaces;
            record.ProvisBkgs = this.ProvisBkgs;
            record.ResvPlaces = this.ResvPlaces;
            record.Waiting = this.Waiting;
            record.Cancels = this.Cancels;
            record.BlockThres = this.BlockThres;
            record.BlockPrice = this.BlockPrice;
            record.StudtPrice = this.StudtPrice;
            record.EstPurPrc = this.EstPurPrc;
            record.NoHours = this.NoHours;
            record.VatCode = this.VatCode;
            record.CostCode = this.CostCode;
            record.RevCode = this.RevCode;
            record.JnInfOrde = this.JnInfOrde;
            record.Notes = this.Notes;
            record.TucRegion = this.TucRegion;
            record.Budget = this.Budget;
            record.Actual = this.Actual;
            record.PayFag = this.PayFag;
            record.PayDate = this.PayDate;
            record.PayCheqNo = this.PayCheqNo;
            record.CollInvNo = this.CollInvNo;
            record.InclOutlin = this.InclOutlin;
            record.InclMap = this.InclMap;
            record.IncSpcIns = this.IncSpcIns;
            record.InclBkFrm = this.InclBkFrm;
            record.IncPstQst = this.IncPstQst;
            record.IncPreSrv = this.IncPreSrv;
            record.BudPeriod = this.BudPeriod;
            record.BudForecst = this.BudForecst;
            record.SourceCode = this.SourceCode;
            record.PersonId2 = this.PersonId2;
            record.Class = this.Class;
            record.HostName = this.HostName;
            record.VenuActual = this.VenuActual;
            record.VenuBudget = this.VenuBudget;
            record.CaterActul = this.CaterActul;
            record.CaterBdget = this.CaterBdget;
            record.HotelActul = this.HotelActul;
            record.HotelBdget = this.HotelBdget;
            record.EquipActul = this.EquipActul;
            record.EquipBdget = this.EquipBdget;
            record.TravActual = this.TravActual;
            record.TravBudget = this.TravBudget;
            record.ExpActual = this.ExpActual;
            record.ExpBudget = this.ExpBudget;
            record.OthrActual = this.OthrActual;
            record.OthrBudget = this.OthrBudget;
            record.QuestLett = this.QuestLett;
            record.SurvLett = this.SurvLett;
            record.BookActual = this.BookActual;
            record.ActualTot = this.ActualTot;
            record.InclJoin = this.InclJoin;
            record.IncConfirm = this.IncConfirm;
            record.JoinLett = this.JoinLett;
            record.ConfrmLett = this.ConfrmLett;
            record.ProvLett = this.ProvLett;
            record.InvLett = this.InvLett;
            record.DoNotInvc = this.DoNotInvc;
            record.CancelDate = this.CancelDate;
            record.CancelBy = this.CancelBy;
            record.IncCshInv = this.IncCshInv;
            record.IncProFrm = this.IncProFrm;
            record.IncReceipt = this.IncReceipt;
            record.Cmc = this.Cmc;
            record.PlId = this.PlId;
            record.SupplierId = this.SupplierId;
            record.BreakEven = this.BreakEven;
            record.ChangeHist = this.ChangeHist;
            record.Bip = this.Bip;
            record.QuestId = this.QuestId;
            record.PostId = this.PostId;
            record.OrderNo = this.OrderNo;
            record.ProvPack = this.ProvPack;
            record.ConfPack = this.ConfPack;
            record.JoiningPack = this.JoiningPack;
            record.PostPack = this.PostPack;
            record.ProvInv = this.ProvInv;
            record.ConfInv = this.ConfInv;
            record.JoinInv = this.JoinInv;
            record.PostInv = this.PostInv;
            record.Period = this.Period;
            record.SearchName = this.SearchName;
            record.EvrId = this.EvrId;
            record.OppId = this.OppId;
            record.SessCount = this.SessCount;
            record.Private = this.Private;
            record.PlanId = this.PlanId;
            record.PlanName = this.PlanName;
            record.Web = this.Web;
            record.Grades = this.Grades;
            record.DescTxtId = this.DescTxtId;
            record.TargTxtId = this.TargTxtId;
            record.SetupTime = this.SetupTime;
            record.DateDec = this.DateDec;
            record.NumInvite = this.NumInvite;
            record.PersonId3 = this.PersonId3;
            record.PersonId4 = this.PersonId4;
            record.BuId = this.BuId;
            record.Usernum1 = this.Usernum1;
            record.Usernum2 = this.Usernum2;
            record.Url = this.Url;
            record.ProjId = this.ProjId;
            record.Code = this.Code;
            record.BtId = this.BtId;
            record.Comments = this.Comments;
            record.ThirdParty = this.ThirdParty;
            record.UDate1 = this.UDate1;
            record.UDate2 = this.UDate2;
            record.UDate3 = this.UDate3;
            record.UDate4 = this.UDate4;
            record.Usernum3 = this.Usernum3;
            record.AddId = this.AddId;
            record.Name2 = this.Name2;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Userchar3 = this.Userchar3;
            record.Userchar4 = this.Userchar4;
            record.SupRoleId = this.SupRoleId;
            record.Currency = this.Currency;
            record.PriceA = this.PriceA;
            record.PriceB = this.PriceB;
            record.PriceC = this.PriceC;
            record.PriceD = this.PriceD;
            record.PriceE = this.PriceE;
            record.Chargable = this.Chargable;
            record.SelcoSpId = this.SelcoSpId;
            record.Usernum4 = this.Usernum4;
            record.Usernum5 = this.Usernum5;
            record.Usernum6 = this.Usernum6;
            record.Usernum7 = this.Usernum7;
            record.Invoiced = this.Invoiced;
            record.BktId = this.BktId;
            record.ContprolId = this.ContprolId;
            record.BudRev = this.BudRev;
            record.BudForcast = this.BudForcast;
            record.UDate5 = this.UDate5;
            record.UDate6 = this.UDate6;
            record.Userchar5 = this.Userchar5;
            record.Userchar6 = this.Userchar6;
            record.UTint1 = this.UTint1;
            record.UTint2 = this.UTint2;
            record.UTint3 = this.UTint3;
            record.UTint4 = this.UTint4;
            record.UTint5 = this.UTint5;
            record.UTint6 = this.UTint6;
            record.SyType = this.SyType;
            record.PrejoinPack = this.PrejoinPack;
            record.PstjoinPack = this.PstjoinPack;
            record.BookActBc2 = this.BookActBc2;
            record.ActTotBc2 = this.ActTotBc2;
            record.ProvSentDte = this.ProvSentDte;
            record.ConfSentDte = this.ConfSentDte;
            record.JoinSentDte = this.JoinSentDte;
            record.PpSentDte = this.PpSentDte;
            record.PrjoinSentDte = this.PrjoinSentDte;
            record.PojoinSentDte = this.PojoinSentDte;
            record.CutPrd = this.CutPrd;
            record.SupStatus = this.SupStatus;
            record.Overbook = this.Overbook;
            record.ProvOrgId = this.ProvOrgId;
            record.ProvProleId = this.ProvProleId;
            record.AllocStatus = this.AllocStatus;
            record.EstHours = this.EstHours;
            record.Float = this.Float;
            record.ActHours = this.ActHours;
            record.Notes2 = this.Notes2;
            record.Notes3 = this.Notes3;
            record.Funded = this.Funded;
            record.FundedOrgId = this.FundedOrgId;
            record.QualDel = this.QualDel;
            record.CohOnly = this.CohOnly;
            record.Analysis1 = this.Analysis1;
            record.Analysis2 = this.Analysis2;
            record.Reservations = this.Reservations;
            record.DefElemSt = this.DefElemSt;
            record.Lapsed = this.Lapsed;
            record.IntNotes = this.IntNotes;
            record.BdCompBy = this.BdCompBy;
            record.BdCompDate = this.BdCompDate;
            record.BdTotActCost = this.BdTotActCost;
            record.BdStatus = this.BdStatus;
            record.Subs = this.Subs;
            record.Transfers = this.Transfers;
            record.HasTrainer = this.HasTrainer;
            record.BdPrepBy = this.BdPrepBy;
            record.BdPrepDate = this.BdPrepDate;
            record.BdAppBy = this.BdAppBy;
            record.BdAppDate = this.BdAppDate;
            record.BdTotEstCost = this.BdTotEstCost;
            record.CalcCommission = this.CalcCommission;
            record.BatId = this.BatId;
            record.CancelPack = this.CancelPack;
            record.CanpSentDte = this.CanpSentDte;
            record.CancellationDate = this.CancellationDate;
            record.Reason = this.Reason;
            record.UnrecoverableCancLoss = this.UnrecoverableCancLoss;
            record.DefaultTraineeDays = this.DefaultTraineeDays;
            record.GrantEligable = this.GrantEligable;
            record.GrantValueAvailable = this.GrantValueAvailable;
            record.BreakevenValue1 = this.BreakevenValue1;
            record.BreakevenValue2 = this.BreakevenValue2;
            record.ExtCourseware = this.ExtCourseware;
            record.Contingency = this.Contingency;
            record.Cost = this.Cost;
            record.DeliveryDays = this.DeliveryDays;
            record.MtrProleId = this.MtrProleId;
            record.MaProleId = this.MaProleId;
            record.AcadyCode = this.AcadyCode;
            record.NoAutoUpdate = this.NoAutoUpdate;
            record.CourseId = this.CourseId;
            record.Usermulti1 = this.Usermulti1;
            record.EventClone = this.EventClone;
            record.OutOfHours = this.OutOfHours;
            record.StopTrainCompletion = this.StopTrainCompletion;
            record.BdOrigCost = this.BdOrigCost;
            record.Order = this.Order;
            record.ElemId = this.ElemId;
            record.CodeLookup1 = this.CodeLookup1;
            record.PshId = this.PshId;
            record.BlockType = this.BlockType;
            record.AttModBy = this.AttModBy;
            record.AttModDate = this.AttModDate;
            record.Avail = this.Avail;
            record.FirstLicEvent = this.FirstLicEvent;
            record.TrnpId = this.TrnpId;
            record.Licensed = this.Licensed;
            record.ResultRecDate = this.ResultRecDate;
            record.PapersRecDate = this.PapersRecDate;
            record.CertIssueDate = this.CertIssueDate;
            record.DelImpDate = this.DelImpDate;
            record.ItemsReceivedDate = this.ItemsReceivedDate;
            record.DelivMethd = this.DelivMethd;
            record.PackSendProleId = this.PackSendProleId;
            record.PackBccEmail = this.PackBccEmail;
            record.PackMdnEmail = this.PackMdnEmail;
            record.PackDsnEmail = this.PackDsnEmail;
            record.PackDsnOptions = this.PackDsnOptions;
            record.CodeImage = this.CodeImage;
            record.ClientRef = this.ClientRef;
            record.SessionsDescription = this.SessionsDescription;
            record.SessionsHeader = this.SessionsHeader;
            record.CutPrdTime = this.CutPrdTime;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="CourseRecord" /> instance is equal to another <see cref="CourseRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="CourseRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(CourseRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.PersonId.TrimOrNullify() == that.PersonId.TrimOrNullify());
            result = result && (this.ProductId.TrimOrNullify() == that.ProductId.TrimOrNullify());
            result = result && (this.LocId.TrimOrNullify() == that.LocId.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.Ref.TrimOrNullify() == that.Ref.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Sector.TrimOrNullify() == that.Sector.TrimOrNullify());
            result = result && (this.OnSite == that.OnSite);
            result = result && (this.BlockPricd == that.BlockPricd);
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.StartTime == that.StartTime);
            result = result && (this.EndTime == that.EndTime);
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.DiaryType.TrimOrNullify() == that.DiaryType.TrimOrNullify());
            result = result && (this.Length == that.Length);
            result = result && (this.MinPlaces == that.MinPlaces);
            result = result && (this.MaxPlaces == that.MaxPlaces);
            result = result && (this.FreePlaces == that.FreePlaces);
            result = result && (this.ConfPlaces == that.ConfPlaces);
            result = result && (this.ProvisBkgs == that.ProvisBkgs);
            result = result && (this.ResvPlaces == that.ResvPlaces);
            result = result && (this.Waiting == that.Waiting);
            result = result && (this.Cancels == that.Cancels);
            result = result && (this.BlockThres == that.BlockThres);
            result = result && (this.BlockPrice == that.BlockPrice);
            result = result && (this.StudtPrice == that.StudtPrice);
            result = result && (this.EstPurPrc == that.EstPurPrc);
            result = result && (this.NoHours == that.NoHours);
            result = result && (this.VatCode.TrimOrNullify() == that.VatCode.TrimOrNullify());
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.RevCode.TrimOrNullify() == that.RevCode.TrimOrNullify());
            result = result && (this.JnInfOrde.TrimOrNullify() == that.JnInfOrde.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.TucRegion.TrimOrNullify() == that.TucRegion.TrimOrNullify());
            result = result && (this.Budget == that.Budget);
            result = result && (this.Actual == that.Actual);
            result = result && (this.PayFag == that.PayFag);
            result = result && (this.PayDate == that.PayDate);
            result = result && (this.PayCheqNo.TrimOrNullify() == that.PayCheqNo.TrimOrNullify());
            result = result && (this.CollInvNo.TrimOrNullify() == that.CollInvNo.TrimOrNullify());
            result = result && (this.InclOutlin == that.InclOutlin);
            result = result && (this.InclMap == that.InclMap);
            result = result && (this.IncSpcIns == that.IncSpcIns);
            result = result && (this.InclBkFrm == that.InclBkFrm);
            result = result && (this.IncPstQst == that.IncPstQst);
            result = result && (this.IncPreSrv == that.IncPreSrv);
            result = result && (this.BudPeriod.TrimOrNullify() == that.BudPeriod.TrimOrNullify());
            result = result && (this.BudForecst == that.BudForecst);
            result = result && (this.SourceCode.TrimOrNullify() == that.SourceCode.TrimOrNullify());
            result = result && (this.PersonId2.TrimOrNullify() == that.PersonId2.TrimOrNullify());
            result = result && (this.Class.TrimOrNullify() == that.Class.TrimOrNullify());
            result = result && (this.HostName.TrimOrNullify() == that.HostName.TrimOrNullify());
            result = result && (this.VenuActual == that.VenuActual);
            result = result && (this.VenuBudget == that.VenuBudget);
            result = result && (this.CaterActul == that.CaterActul);
            result = result && (this.CaterBdget == that.CaterBdget);
            result = result && (this.HotelActul == that.HotelActul);
            result = result && (this.HotelBdget == that.HotelBdget);
            result = result && (this.EquipActul == that.EquipActul);
            result = result && (this.EquipBdget == that.EquipBdget);
            result = result && (this.TravActual == that.TravActual);
            result = result && (this.TravBudget == that.TravBudget);
            result = result && (this.ExpActual == that.ExpActual);
            result = result && (this.ExpBudget == that.ExpBudget);
            result = result && (this.OthrActual == that.OthrActual);
            result = result && (this.OthrBudget == that.OthrBudget);
            result = result && (this.QuestLett.TrimOrNullify() == that.QuestLett.TrimOrNullify());
            result = result && (this.SurvLett.TrimOrNullify() == that.SurvLett.TrimOrNullify());
            result = result && (this.BookActual == that.BookActual);
            result = result && (this.ActualTot == that.ActualTot);
            result = result && (this.InclJoin == that.InclJoin);
            result = result && (this.IncConfirm == that.IncConfirm);
            result = result && (this.JoinLett.TrimOrNullify() == that.JoinLett.TrimOrNullify());
            result = result && (this.ConfrmLett.TrimOrNullify() == that.ConfrmLett.TrimOrNullify());
            result = result && (this.ProvLett.TrimOrNullify() == that.ProvLett.TrimOrNullify());
            result = result && (this.InvLett.TrimOrNullify() == that.InvLett.TrimOrNullify());
            result = result && (this.DoNotInvc == that.DoNotInvc);
            result = result && (this.CancelDate == that.CancelDate);
            result = result && (this.CancelBy.TrimOrNullify() == that.CancelBy.TrimOrNullify());
            result = result && (this.IncCshInv == that.IncCshInv);
            result = result && (this.IncProFrm == that.IncProFrm);
            result = result && (this.IncReceipt == that.IncReceipt);
            result = result && (this.Cmc == that.Cmc);
            result = result && (this.PlId.TrimOrNullify() == that.PlId.TrimOrNullify());
            result = result && (this.SupplierId.TrimOrNullify() == that.SupplierId.TrimOrNullify());
            result = result && (this.BreakEven == that.BreakEven);
            result = result && (this.ChangeHist.TrimOrNullify() == that.ChangeHist.TrimOrNullify());
            result = result && (this.Bip == that.Bip);
            result = result && (this.QuestId.TrimOrNullify() == that.QuestId.TrimOrNullify());
            result = result && (this.PostId.TrimOrNullify() == that.PostId.TrimOrNullify());
            result = result && (this.OrderNo.TrimOrNullify() == that.OrderNo.TrimOrNullify());
            result = result && (this.ProvPack.TrimOrNullify() == that.ProvPack.TrimOrNullify());
            result = result && (this.ConfPack.TrimOrNullify() == that.ConfPack.TrimOrNullify());
            result = result && (this.JoiningPack.TrimOrNullify() == that.JoiningPack.TrimOrNullify());
            result = result && (this.PostPack.TrimOrNullify() == that.PostPack.TrimOrNullify());
            result = result && (this.ProvInv == that.ProvInv);
            result = result && (this.ConfInv == that.ConfInv);
            result = result && (this.JoinInv == that.JoinInv);
            result = result && (this.PostInv == that.PostInv);
            result = result && (this.Period.TrimOrNullify() == that.Period.TrimOrNullify());
            result = result && (this.SearchName.TrimOrNullify() == that.SearchName.TrimOrNullify());
            result = result && (this.EvrId.TrimOrNullify() == that.EvrId.TrimOrNullify());
            result = result && (this.OppId.TrimOrNullify() == that.OppId.TrimOrNullify());
            result = result && (this.SessCount == that.SessCount);
            result = result && (this.Private == that.Private);
            result = result && (this.PlanId.TrimOrNullify() == that.PlanId.TrimOrNullify());
            result = result && (this.PlanName.TrimOrNullify() == that.PlanName.TrimOrNullify());
            result = result && (this.Web == that.Web);
            result = result && (this.Grades.TrimOrNullify() == that.Grades.TrimOrNullify());
            result = result && (this.DescTxtId.TrimOrNullify() == that.DescTxtId.TrimOrNullify());
            result = result && (this.TargTxtId.TrimOrNullify() == that.TargTxtId.TrimOrNullify());
            result = result && (this.SetupTime == that.SetupTime);
            result = result && (this.DateDec == that.DateDec);
            result = result && (this.NumInvite == that.NumInvite);
            result = result && (this.PersonId3.TrimOrNullify() == that.PersonId3.TrimOrNullify());
            result = result && (this.PersonId4.TrimOrNullify() == that.PersonId4.TrimOrNullify());
            result = result && (this.BuId.TrimOrNullify() == that.BuId.TrimOrNullify());
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            result = result && (this.ProjId.TrimOrNullify() == that.ProjId.TrimOrNullify());
            result = result && (this.Code.TrimOrNullify() == that.Code.TrimOrNullify());
            result = result && (this.BtId.TrimOrNullify() == that.BtId.TrimOrNullify());
            result = result && (this.Comments.TrimOrNullify() == that.Comments.TrimOrNullify());
            result = result && (this.ThirdParty == that.ThirdParty);
            result = result && (this.UDate1 == that.UDate1);
            result = result && (this.UDate2 == that.UDate2);
            result = result && (this.UDate3 == that.UDate3);
            result = result && (this.UDate4 == that.UDate4);
            result = result && (this.Usernum3 == that.Usernum3);
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.Name2.TrimOrNullify() == that.Name2.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.SupRoleId.TrimOrNullify() == that.SupRoleId.TrimOrNullify());
            result = result && (this.Currency.TrimOrNullify() == that.Currency.TrimOrNullify());
            result = result && (this.PriceA == that.PriceA);
            result = result && (this.PriceB == that.PriceB);
            result = result && (this.PriceC == that.PriceC);
            result = result && (this.PriceD == that.PriceD);
            result = result && (this.PriceE == that.PriceE);
            result = result && (this.Chargable == that.Chargable);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.Usernum4 == that.Usernum4);
            result = result && (this.Usernum5 == that.Usernum5);
            result = result && (this.Usernum6 == that.Usernum6);
            result = result && (this.Usernum7 == that.Usernum7);
            result = result && (this.Invoiced == that.Invoiced);
            result = result && (this.BktId.TrimOrNullify() == that.BktId.TrimOrNullify());
            result = result && (this.ContprolId.TrimOrNullify() == that.ContprolId.TrimOrNullify());
            result = result && (this.BudRev == that.BudRev);
            result = result && (this.BudForcast == that.BudForcast);
            result = result && (this.UDate5 == that.UDate5);
            result = result && (this.UDate6 == that.UDate6);
            result = result && (this.Userchar5.TrimOrNullify() == that.Userchar5.TrimOrNullify());
            result = result && (this.Userchar6.TrimOrNullify() == that.Userchar6.TrimOrNullify());
            result = result && (this.UTint1 == that.UTint1);
            result = result && (this.UTint2 == that.UTint2);
            result = result && (this.UTint3 == that.UTint3);
            result = result && (this.UTint4 == that.UTint4);
            result = result && (this.UTint5 == that.UTint5);
            result = result && (this.UTint6 == that.UTint6);
            result = result && (this.SyType == that.SyType);
            result = result && (this.PrejoinPack.TrimOrNullify() == that.PrejoinPack.TrimOrNullify());
            result = result && (this.PstjoinPack.TrimOrNullify() == that.PstjoinPack.TrimOrNullify());
            result = result && (this.BookActBc2 == that.BookActBc2);
            result = result && (this.ActTotBc2 == that.ActTotBc2);
            result = result && (this.ProvSentDte == that.ProvSentDte);
            result = result && (this.ConfSentDte == that.ConfSentDte);
            result = result && (this.JoinSentDte == that.JoinSentDte);
            result = result && (this.PpSentDte == that.PpSentDte);
            result = result && (this.PrjoinSentDte == that.PrjoinSentDte);
            result = result && (this.PojoinSentDte == that.PojoinSentDte);
            result = result && (this.CutPrd == that.CutPrd);
            result = result && (this.SupStatus.TrimOrNullify() == that.SupStatus.TrimOrNullify());
            result = result && (this.Overbook == that.Overbook);
            result = result && (this.ProvOrgId.TrimOrNullify() == that.ProvOrgId.TrimOrNullify());
            result = result && (this.ProvProleId.TrimOrNullify() == that.ProvProleId.TrimOrNullify());
            result = result && (this.AllocStatus == that.AllocStatus);
            result = result && (this.EstHours == that.EstHours);
            result = result && (this.Float == that.Float);
            result = result && (this.ActHours == that.ActHours);
            result = result && (this.Notes2.TrimOrNullify() == that.Notes2.TrimOrNullify());
            result = result && (this.Notes3.TrimOrNullify() == that.Notes3.TrimOrNullify());
            result = result && (this.Funded == that.Funded);
            result = result && (this.FundedOrgId.TrimOrNullify() == that.FundedOrgId.TrimOrNullify());
            result = result && (this.QualDel == that.QualDel);
            result = result && (this.CohOnly == that.CohOnly);
            result = result && (this.Analysis1.TrimOrNullify() == that.Analysis1.TrimOrNullify());
            result = result && (this.Analysis2.TrimOrNullify() == that.Analysis2.TrimOrNullify());
            result = result && (this.Reservations == that.Reservations);
            result = result && (this.DefElemSt.TrimOrNullify() == that.DefElemSt.TrimOrNullify());
            result = result && (this.Lapsed == that.Lapsed);
            result = result && (this.IntNotes.TrimOrNullify() == that.IntNotes.TrimOrNullify());
            result = result && (this.BdCompBy.TrimOrNullify() == that.BdCompBy.TrimOrNullify());
            result = result && (this.BdCompDate == that.BdCompDate);
            result = result && (this.BdTotActCost == that.BdTotActCost);
            result = result && (this.BdStatus.TrimOrNullify() == that.BdStatus.TrimOrNullify());
            result = result && (this.Subs == that.Subs);
            result = result && (this.Transfers == that.Transfers);
            result = result && (this.HasTrainer == that.HasTrainer);
            result = result && (this.BdPrepBy.TrimOrNullify() == that.BdPrepBy.TrimOrNullify());
            result = result && (this.BdPrepDate == that.BdPrepDate);
            result = result && (this.BdAppBy.TrimOrNullify() == that.BdAppBy.TrimOrNullify());
            result = result && (this.BdAppDate == that.BdAppDate);
            result = result && (this.BdTotEstCost == that.BdTotEstCost);
            result = result && (this.CalcCommission == that.CalcCommission);
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.CancelPack.TrimOrNullify() == that.CancelPack.TrimOrNullify());
            result = result && (this.CanpSentDte == that.CanpSentDte);
            result = result && (this.CancellationDate == that.CancellationDate);
            result = result && (this.Reason.TrimOrNullify() == that.Reason.TrimOrNullify());
            result = result && (this.UnrecoverableCancLoss == that.UnrecoverableCancLoss);
            result = result && (this.DefaultTraineeDays == that.DefaultTraineeDays);
            result = result && (this.GrantEligable == that.GrantEligable);
            result = result && (this.GrantValueAvailable == that.GrantValueAvailable);
            result = result && (this.BreakevenValue1 == that.BreakevenValue1);
            result = result && (this.BreakevenValue2 == that.BreakevenValue2);
            result = result && (this.ExtCourseware == that.ExtCourseware);
            result = result && (this.Contingency == that.Contingency);
            result = result && (this.Cost == that.Cost);
            result = result && (this.DeliveryDays == that.DeliveryDays);
            result = result && (this.MtrProleId.TrimOrNullify() == that.MtrProleId.TrimOrNullify());
            result = result && (this.MaProleId.TrimOrNullify() == that.MaProleId.TrimOrNullify());
            result = result && (this.AcadyCode.TrimOrNullify() == that.AcadyCode.TrimOrNullify());
            result = result && (this.NoAutoUpdate == that.NoAutoUpdate);
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.Usermulti1.TrimOrNullify() == that.Usermulti1.TrimOrNullify());
            result = result && (this.EventClone == that.EventClone);
            result = result && (this.OutOfHours == that.OutOfHours);
            result = result && (this.StopTrainCompletion == that.StopTrainCompletion);
            result = result && (this.BdOrigCost == that.BdOrigCost);
            result = result && (this.Order == that.Order);
            result = result && (this.ElemId.TrimOrNullify() == that.ElemId.TrimOrNullify());
            result = result && (this.CodeLookup1.TrimOrNullify() == that.CodeLookup1.TrimOrNullify());
            result = result && (this.PshId == that.PshId);
            result = result && (this.BlockType == that.BlockType);
            result = result && (this.AttModBy.TrimOrNullify() == that.AttModBy.TrimOrNullify());
            result = result && (this.AttModDate == that.AttModDate);
            result = result && (this.Avail.TrimOrNullify() == that.Avail.TrimOrNullify());
            result = result && (this.FirstLicEvent == that.FirstLicEvent);
            result = result && (this.TrnpId == that.TrnpId);
            result = result && (this.Licensed == that.Licensed);
            result = result && (this.ResultRecDate == that.ResultRecDate);
            result = result && (this.PapersRecDate == that.PapersRecDate);
            result = result && (this.CertIssueDate == that.CertIssueDate);
            result = result && (this.DelImpDate == that.DelImpDate);
            result = result && (this.ItemsReceivedDate == that.ItemsReceivedDate);
            result = result && (this.DelivMethd.TrimOrNullify() == that.DelivMethd.TrimOrNullify());
            result = result && (this.PackSendProleId.TrimOrNullify() == that.PackSendProleId.TrimOrNullify());
            result = result && (this.PackBccEmail.TrimOrNullify() == that.PackBccEmail.TrimOrNullify());
            result = result && (this.PackMdnEmail.TrimOrNullify() == that.PackMdnEmail.TrimOrNullify());
            result = result && (this.PackDsnEmail.TrimOrNullify() == that.PackDsnEmail.TrimOrNullify());
            result = result && (this.PackDsnOptions.TrimOrNullify() == that.PackDsnOptions.TrimOrNullify());
            result = result && (this.CodeImage.TrimOrNullify() == that.CodeImage.TrimOrNullify());
            result = result && (this.ClientRef.TrimOrNullify() == that.ClientRef.TrimOrNullify());
            result = result && (this.SessionsDescription.TrimOrNullify() == that.SessionsDescription.TrimOrNullify());
            result = result && (this.SessionsHeader.TrimOrNullify() == that.SessionsHeader.TrimOrNullify());
            result = result && (this.CutPrdTime == that.CutPrdTime);
            return result;
        }

        #endregion
    }
}
