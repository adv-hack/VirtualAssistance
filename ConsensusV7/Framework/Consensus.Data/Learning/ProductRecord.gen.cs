using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "Product" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ProductRecord : Record<String>, Cloneable<ProductRecord>, IEquatable<ProductRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PROD_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PROD_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PROD_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PROD_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PROD_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PROD_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PROD_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PROD_GROUP_ID" field.
        /// </summary>
        private String _groupId;

        /// <summary>
        ///     the value of the "PROD_REF" field.
        /// </summary>
        private String _ref;

        /// <summary>
        ///     the value of the "PROD_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "PROD_DESCRIP" field.
        /// </summary>
        private String _descrip;

        /// <summary>
        ///     the value of the "PROD_TEXT1" field.
        /// </summary>
        private String _text1;

        /// <summary>
        ///     the value of the "PROD_TEXT2" field.
        /// </summary>
        private String _text2;

        /// <summary>
        ///     the value of the "PROD_TEXT3" field.
        /// </summary>
        private String _text3;

        /// <summary>
        ///     the value of the "PROD_TEXT4" field.
        /// </summary>
        private String _text4;

        /// <summary>
        ///     the value of the "PROD_TEXT5" field.
        /// </summary>
        private String _text5;

        /// <summary>
        ///     the value of the "PROD_SY_PRODUCT" field.
        /// </summary>
        private Byte? _syProduct;

        /// <summary>
        ///     the value of the "PROD_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "PROD_CATEGORY" field.
        /// </summary>
        private String _category;

        /// <summary>
        ///     the value of the "PROD_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "PROD_GROUP" field.
        /// </summary>
        private String _group;

        /// <summary>
        ///     the value of the "PROD_UNIT" field.
        /// </summary>
        private String _unit;

        /// <summary>
        ///     the value of the "PROD_PRICE" field.
        /// </summary>
        private Double? _price;

        /// <summary>
        ///     the value of the "PROD_BLOCK_PRICE" field.
        /// </summary>
        private Double? _blockPrice;

        /// <summary>
        ///     the value of the "PROD_SPARE_PRICE" field.
        /// </summary>
        private Double? _sparePrice;

        /// <summary>
        ///     the value of the "PROD_COST_PRICE" field.
        /// </summary>
        private Double? _costPrice;

        /// <summary>
        ///     the value of the "PROD_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "PROD_REV_CODE" field.
        /// </summary>
        private String _revCode;

        /// <summary>
        ///     the value of the "PROD_DISC_SCHED" field.
        /// </summary>
        private String _discSched;

        /// <summary>
        ///     the value of the "PROD_VAT_CODE" field.
        /// </summary>
        private String _vatCode;

        /// <summary>
        ///     the value of the "PROD_MIN_ATTEND" field.
        /// </summary>
        private Double? _minAttend;

        /// <summary>
        ///     the value of the "PROD_MAX_ATTEND" field.
        /// </summary>
        private Double? _maxAttend;

        /// <summary>
        ///     the value of the "PROD_COURSE_LEN" field.
        /// </summary>
        private Double? _courseLen;

        /// <summary>
        ///     the value of the "PROD_DIARY_TYPE" field.
        /// </summary>
        private String _diaryType;

        /// <summary>
        ///     the value of the "PROD_NORM_COLLEGE" field.
        /// </summary>
        private String _normCollege;

        /// <summary>
        ///     the value of the "PROD_NEXT_COURSE" field.
        /// </summary>
        private String _nextCourse;

        /// <summary>
        ///     the value of the "PROD_SPARE_FLAG1" field.
        /// </summary>
        private Byte? _spareFlag1;

        /// <summary>
        ///     the value of the "PROD_SPARE_FLAG2" field.
        /// </summary>
        private Byte? _spareFlag2;

        /// <summary>
        ///     the value of the "PROD_CERT_PRINTED" field.
        /// </summary>
        private Byte? _certPrinted;

        /// <summary>
        ///     the value of the "PROD_TUC_REGION" field.
        /// </summary>
        private String _tucRegion;

        /// <summary>
        ///     the value of the "PROD_ENTRY_DATE" field.
        /// </summary>
        private DateTime? _entryDate;

        /// <summary>
        ///     the value of the "PROD_PROJECT_NO" field.
        /// </summary>
        private String _projectNo;

        /// <summary>
        ///     the value of the "PROD_COMMISSION_BY" field.
        /// </summary>
        private String _commissionBy;

        /// <summary>
        ///     the value of the "PROD_KEY" field.
        /// </summary>
        private String _key;

        /// <summary>
        ///     the value of the "PROD_CODE" field.
        /// </summary>
        private String _code;

        /// <summary>
        ///     the value of the "PROD_TYPE_LOW" field.
        /// </summary>
        private String _typeLow;

        /// <summary>
        ///     the value of the "PROD_REF_LOW" field.
        /// </summary>
        private String _refLow;

        /// <summary>
        ///     the value of the "PROD_QUES_SET" field.
        /// </summary>
        private Byte? _quesSet;

        /// <summary>
        ///     the value of the "PROD_START_QNO" field.
        /// </summary>
        private Byte? _startQno;

        /// <summary>
        ///     the value of the "PROD_SELL_HINT" field.
        /// </summary>
        private String _sellHint;

        /// <summary>
        ///     the value of the "PROD_DET" field.
        /// </summary>
        private String _det;

        /// <summary>
        ///     the value of the "PROD_ASS" field.
        /// </summary>
        private String _ass;

        /// <summary>
        ///     the value of the "PROD_RETAIL_PRICE" field.
        /// </summary>
        private Double? _retailPrice;

        /// <summary>
        ///     the value of the "PROD_MARGIN" field.
        /// </summary>
        private Double? _margin;

        /// <summary>
        ///     the value of the "PROD_SUPPLIER_NAME" field.
        /// </summary>
        private String _supplierName;

        /// <summary>
        ///     the value of the "PROD_SUPPLIER_ID" field.
        /// </summary>
        private String _supplierId;

        /// <summary>
        ///     the value of the "PROD_PIC_ID" field.
        /// </summary>
        private String _picId;

        /// <summary>
        ///     the value of the "PROD_JOIN_LETT" field.
        /// </summary>
        private String _joinLett;

        /// <summary>
        ///     the value of the "PROD_CONFIRM_LETT" field.
        /// </summary>
        private String _confirmLett;

        /// <summary>
        ///     the value of the "PROD_QUEST_LETT" field.
        /// </summary>
        private String _questLett;

        /// <summary>
        ///     the value of the "PROD_SURV_LETT" field.
        /// </summary>
        private String _survLett;

        /// <summary>
        ///     the value of the "PROD_NO_CST_NO_SEL" field.
        /// </summary>
        private Byte? _noCstNoSel;

        /// <summary>
        ///     the value of the "PROD_PROV_LETT" field.
        /// </summary>
        private String _provLett;

        /// <summary>
        ///     the value of the "PROD_INV_LETT" field.
        /// </summary>
        private String _invLett;

        /// <summary>
        ///     the value of the "PROD_DO_NOT_INVOIC" field.
        /// </summary>
        private Byte? _doNotInvoic;

        /// <summary>
        ///     the value of the "PROD_TOP_LEVEL" field.
        /// </summary>
        private Byte? _topLevel;

        /// <summary>
        ///     the value of the "PROD_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "PROD_ROOM_TYPE" field.
        /// </summary>
        private String _roomType;

        /// <summary>
        ///     the value of the "PROD_ROOM_GRADE" field.
        /// </summary>
        private String _roomGrade;

        /// <summary>
        ///     the value of the "PROD_STATE" field.
        /// </summary>
        private Byte? _state;

        /// <summary>
        ///     the value of the "PROD_STOCKED" field.
        /// </summary>
        private Byte? _stocked;

        /// <summary>
        ///     the value of the "PROD_QTY_AV" field.
        /// </summary>
        private Double? _qtyAv;

        /// <summary>
        ///     the value of the "PROD_QTY_AC" field.
        /// </summary>
        private Double? _qtyAc;

        /// <summary>
        ///     the value of the "PROD_QTY_BO" field.
        /// </summary>
        private Double? _qtyBo;

        /// <summary>
        ///     the value of the "PROD_QTY_OR" field.
        /// </summary>
        private Double? _qtyOr;

        /// <summary>
        ///     the value of the "PROD_COURSEMASTER" field.
        /// </summary>
        private Byte? _coursemaster;

        /// <summary>
        ///     the value of the "PROD_CURRENCY" field.
        /// </summary>
        private String _currency;

        /// <summary>
        ///     the value of the "PROD_LAST_USED" field.
        /// </summary>
        private DateTime? _lastUsed;

        /// <summary>
        ///     the value of the "PROD_DAILY_DEL_RAT" field.
        /// </summary>
        private Double? _dailyDelRat;

        /// <summary>
        ///     the value of the "PROD_OVERNIGHT_RAT" field.
        /// </summary>
        private Double? _overnightRat;

        /// <summary>
        ///     the value of the "PROD_SYNDICATE_RAT" field.
        /// </summary>
        private Double? _syndicateRat;

        /// <summary>
        ///     the value of the "PROD_EQUIP1" field.
        /// </summary>
        private Double? _equip1;

        /// <summary>
        ///     the value of the "PROD_EQUIP2" field.
        /// </summary>
        private Double? _equip2;

        /// <summary>
        ///     the value of the "PROD_EQUIP3" field.
        /// </summary>
        private Double? _equip3;

        /// <summary>
        ///     the value of the "PROD_EQUIP4" field.
        /// </summary>
        private Double? _equip4;

        /// <summary>
        ///     the value of the "PROD_EQUIP5" field.
        /// </summary>
        private Double? _equip5;

        /// <summary>
        ///     the value of the "PROD_EQUIP6" field.
        /// </summary>
        private Double? _equip6;

        /// <summary>
        ///     the value of the "PROD_EQUIP7" field.
        /// </summary>
        private Double? _equip7;

        /// <summary>
        ///     the value of the "PROD_EQUIP8" field.
        /// </summary>
        private Double? _equip8;

        /// <summary>
        ///     the value of the "PROD_EQUIP9" field.
        /// </summary>
        private Double? _equip9;

        /// <summary>
        ///     the value of the "PROD_EQUIP10" field.
        /// </summary>
        private Double? _equip10;

        /// <summary>
        ///     the value of the "PROD_EQUIP11" field.
        /// </summary>
        private Double? _equip11;

        /// <summary>
        ///     the value of the "PROD_EQUIP12" field.
        /// </summary>
        private Double? _equip12;

        /// <summary>
        ///     the value of the "PROD_EQUIP13" field.
        /// </summary>
        private Double? _equip13;

        /// <summary>
        ///     the value of the "PROD_EQUIP14" field.
        /// </summary>
        private Double? _equip14;

        /// <summary>
        ///     the value of the "PROD_EQUIP15" field.
        /// </summary>
        private Double? _equip15;

        /// <summary>
        ///     the value of the "PROD_GENERALISED" field.
        /// </summary>
        private Byte? _generalised;

        /// <summary>
        ///     the value of the "PROD_NETW_TYPE" field.
        /// </summary>
        private String _netwType;

        /// <summary>
        ///     the value of the "PROD_REN_TYPE" field.
        /// </summary>
        private String _renType;

        /// <summary>
        ///     the value of the "PROD_OLD_DESC" field.
        /// </summary>
        private String _oldDesc;

        /// <summary>
        ///     the value of the "PROD_CLASS" field.
        /// </summary>
        private String _class;

        /// <summary>
        ///     the value of the "PROD_TI_CODE" field.
        /// </summary>
        private String _tiCode;

        /// <summary>
        ///     the value of the "PROD_DEP_REPS" field.
        /// </summary>
        private String _depReps;

        /// <summary>
        ///     the value of the "PROD_LEAD_DEPT" field.
        /// </summary>
        private Byte? _leadDept;

        /// <summary>
        ///     the value of the "PROD_CURRENT" field.
        /// </summary>
        private String _current;

        /// <summary>
        ///     the value of the "PROD_MEDIA" field.
        /// </summary>
        private String _media;

        /// <summary>
        ///     the value of the "PROD_MAX_DISC" field.
        /// </summary>
        private Double? _maxDisc;

        /// <summary>
        ///     the value of the "PROD_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "PROD_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "PROD_USERNUM_1" field.
        /// </summary>
        private Decimal? _usernum1;

        /// <summary>
        ///     the value of the "PROD_AVAIL_DATE" field.
        /// </summary>
        private DateTime? _availDate;

        /// <summary>
        ///     the value of the "PROD_CERT_FMT" field.
        /// </summary>
        private String _certFmt;

        /// <summary>
        ///     the value of the "PROD_CERT_NAME" field.
        /// </summary>
        private String _certName;

        /// <summary>
        ///     the value of the "PROD_LSE_PRINTED" field.
        /// </summary>
        private Byte? _lsePrinted;

        /// <summary>
        ///     the value of the "PROD_REQ_FREQCY" field.
        /// </summary>
        private Byte? _reqFreqcy;

        /// <summary>
        ///     the value of the "PROD_ADM_TXT_ID" field.
        /// </summary>
        private String _admTxtId;

        /// <summary>
        ///     the value of the "PROD_TRN_TXT_ID" field.
        /// </summary>
        private String _trnTxtId;

        /// <summary>
        ///     the value of the "PROD_ENQ_QST_ID" field.
        /// </summary>
        private String _enqQstId;

        /// <summary>
        ///     the value of the "PROD_DEL_QST_ID" field.
        /// </summary>
        private String _delQstId;

        /// <summary>
        ///     the value of the "PROD_PROV_PACK" field.
        /// </summary>
        private String _provPack;

        /// <summary>
        ///     the value of the "PROD_CONF_PACK" field.
        /// </summary>
        private String _confPack;

        /// <summary>
        ///     the value of the "PROD_JOINING_PACK" field.
        /// </summary>
        private String _joiningPack;

        /// <summary>
        ///     the value of the "PROD_POST_PACK" field.
        /// </summary>
        private String _postPack;

        /// <summary>
        ///     the value of the "PROD_PROV_INV" field.
        /// </summary>
        private Byte? _provInv;

        /// <summary>
        ///     the value of the "PROD_CONF_INV" field.
        /// </summary>
        private Byte? _confInv;

        /// <summary>
        ///     the value of the "PROD_JOIN_INV" field.
        /// </summary>
        private Byte? _joinInv;

        /// <summary>
        ///     the value of the "PROD_POST_INV" field.
        /// </summary>
        private Byte? _postInv;

        /// <summary>
        ///     the value of the "PROD_MSTC_TYPE" field.
        /// </summary>
        private String _mstcType;

        /// <summary>
        ///     the value of the "PROD_OVERBOOK" field.
        /// </summary>
        private Double? _overbook;

        /// <summary>
        ///     the value of the "PROD_COMMISSION" field.
        /// </summary>
        private Byte? _commission;

        /// <summary>
        ///     the value of the "PROD_PLAN_ID" field.
        /// </summary>
        private String _planId;

        /// <summary>
        ///     the value of the "PROD_PLAN_NAME" field.
        /// </summary>
        private String _planName;

        /// <summary>
        ///     the value of the "PROD_NO_HOURS" field.
        /// </summary>
        private Double? _noHours;

        /// <summary>
        ///     the value of the "PROD_EXPIRY_MONTHS" field.
        /// </summary>
        private Double? _expiryMonths;

        /// <summary>
        ///     the value of the "PROD_PLACES" field.
        /// </summary>
        private Int32? _places;

        /// <summary>
        ///     the value of the "PROD_PRE_PAY_TYPE" field.
        /// </summary>
        private String _prePayType;

        /// <summary>
        ///     the value of the "PROD_GRADES" field.
        /// </summary>
        private String _grades;

        /// <summary>
        ///     the value of the "PROD_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        private String _manProleId;

        /// <summary>
        ///     the value of the "PROD_LEVEL" field.
        /// </summary>
        private String _level;

        /// <summary>
        ///     the value of the "PROD_SERIALISED" field.
        /// </summary>
        private Byte? _serialised;

        /// <summary>
        ///     the value of the "PROD_URL" field.
        /// </summary>
        private String _url;

        /// <summary>
        ///     the value of the "PROD_VAL_TO_REV_PC" field.
        /// </summary>
        private Double? _valToRevPc;

        /// <summary>
        ///     the value of the "PROD_BKT_ID" field.
        /// </summary>
        private String _bktId;

        /// <summary>
        ///     the value of the "PROD_BT_ID" field.
        /// </summary>
        private String _btId;

        /// <summary>
        ///     the value of the "PROD_NAME2" field.
        /// </summary>
        private String _name2;

        /// <summary>
        ///     the value of the "PROD_GL_CODE1" field.
        /// </summary>
        private String _glCode1;

        /// <summary>
        ///     the value of the "PROD_GL_CODE2" field.
        /// </summary>
        private String _glCode2;

        /// <summary>
        ///     the value of the "PROD_RESOURSE" field.
        /// </summary>
        private Byte? _resourse;

        /// <summary>
        ///     the value of the "PROD_LOC_ID" field.
        /// </summary>
        private String _locId;

        /// <summary>
        ///     the value of the "PROD_WEB" field.
        /// </summary>
        private Byte? _web;

        /// <summary>
        ///     the value of the "PROD_DESC_FILE" field.
        /// </summary>
        private String _descFile;

        /// <summary>
        ///     the value of the "PROD_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "PROD_USERINT_1" field.
        /// </summary>
        private Int32? _userint1;

        /// <summary>
        ///     the value of the "PROD_USERINT_2" field.
        /// </summary>
        private Int32? _userint2;

        /// <summary>
        ///     the value of the "PROD_USERINT_3" field.
        /// </summary>
        private Int32? _userint3;

        /// <summary>
        ///     the value of the "PROD_USERINT_4" field.
        /// </summary>
        private Int32? _userint4;

        /// <summary>
        ///     the value of the "PROD_USERDATE_1" field.
        /// </summary>
        private DateTime? _userdate1;

        /// <summary>
        ///     the value of the "PROD_USERINT_5" field.
        /// </summary>
        private Int32? _userint5;

        /// <summary>
        ///     the value of the "PROD_USERNUM_2" field.
        /// </summary>
        private Decimal? _usernum2;

        /// <summary>
        ///     the value of the "PROD_USERINT_6" field.
        /// </summary>
        private Int32? _userint6;

        /// <summary>
        ///     the value of the "PROD_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "PROD_USERCHAR_5" field.
        /// </summary>
        private String _userchar5;

        /// <summary>
        ///     the value of the "PROD_USERNUM_3" field.
        /// </summary>
        private Decimal? _usernum3;

        /// <summary>
        ///     the value of the "PROD_USERNUM_4" field.
        /// </summary>
        private Decimal? _usernum4;

        /// <summary>
        ///     the value of the "PROD_USERNUM_5" field.
        /// </summary>
        private Decimal? _usernum5;

        /// <summary>
        ///     the value of the "PROD_USERINT_7" field.
        /// </summary>
        private Int32? _userint7;

        /// <summary>
        ///     the value of the "PROD_USERINT_8" field.
        /// </summary>
        private Int32? _userint8;

        /// <summary>
        ///     the value of the "PROD_USERINT_9" field.
        /// </summary>
        private Int32? _userint9;

        /// <summary>
        ///     the value of the "PROD_MEMB_PRC_GRP" field.
        /// </summary>
        private String _membPrcGrp;

        /// <summary>
        ///     the value of the "PROD_SCO_MANIF_XML" field.
        /// </summary>
        private String _scoManifXml;

        /// <summary>
        ///     the value of the "prod_quantity" field.
        /// </summary>
        private Double? _prodQuantity;

        /// <summary>
        ///     the value of the "PROD_NON_SCORM" field.
        /// </summary>
        private Byte? _nonScorm;

        /// <summary>
        ///     the value of the "PROD_MS_NEW" field.
        /// </summary>
        private String _msNew;

        /// <summary>
        ///     the value of the "PROD_MS_REMIND1" field.
        /// </summary>
        private String _msRemind1;

        /// <summary>
        ///     the value of the "PROD_MS_REMIND2" field.
        /// </summary>
        private String _msRemind2;

        /// <summary>
        ///     the value of the "PROD_MS_RENEW" field.
        /// </summary>
        private String _msRenew;

        /// <summary>
        ///     the value of the "PROD_MS_LAPSED" field.
        /// </summary>
        private String _msLapsed;

        /// <summary>
        ///     the value of the "PROD_MS_CANCEL" field.
        /// </summary>
        private String _msCancel;

        /// <summary>
        ///     the value of the "PROD_MS_GROUP" field.
        /// </summary>
        private Byte? _msGroup;

        /// <summary>
        ///     the value of the "PROD_RENEW_DAYS" field.
        /// </summary>
        private Int32? _renewDays;

        /// <summary>
        ///     the value of the "PROD_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "PROD_MEM_INV_TYPE" field.
        /// </summary>
        private Byte? _memInvType;

        /// <summary>
        ///     the value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        private String _authPnId;

        /// <summary>
        ///     the value of the "PROD_ISBN" field.
        /// </summary>
        private String _isbn;

        /// <summary>
        ///     the value of the "PROD_PAGE_COUNT" field.
        /// </summary>
        private Int32? _pageCount;

        /// <summary>
        ///     the value of the "PROD_MS_REMIND3" field.
        /// </summary>
        private String _msRemind3;

        /// <summary>
        ///     the value of the "PROD_MS_RM1_DAYS" field.
        /// </summary>
        private Int32? _msRm1Days;

        /// <summary>
        ///     the value of the "PROD_MS_RM2_DAYS" field.
        /// </summary>
        private Int32? _msRm2Days;

        /// <summary>
        ///     the value of the "PROD_MS_RM3_DAYS" field.
        /// </summary>
        private Int32? _msRm3Days;

        /// <summary>
        ///     the value of the "PROD_MS_LAPS_DAYS" field.
        /// </summary>
        private Int32? _msLapsDays;

        /// <summary>
        ///     the value of the "PROD_FREQ" field.
        /// </summary>
        private Int32? _freq;

        /// <summary>
        ///     the value of the "PROD_DESC_FILE_Y" field.
        /// </summary>
        private String _descFileY;

        /// <summary>
        ///     the value of the "PROD_MS_RENEWED" field.
        /// </summary>
        private String _msRenewed;

        /// <summary>
        ///     the value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        private String _regBodyId1;

        /// <summary>
        ///     the value of the "PROD_REG_BODY_ID_2" field.
        /// </summary>
        private String _regBodyId2;

        /// <summary>
        ///     the value of the "PROD_USERCHAR_6" field.
        /// </summary>
        private String _userchar6;

        /// <summary>
        ///     the value of the "PROD_U_DATE_1" field.
        /// </summary>
        private DateTime? _uDate1;

        /// <summary>
        ///     the value of the "PROD_U_DATE_2" field.
        /// </summary>
        private DateTime? _uDate2;

        /// <summary>
        ///     the value of the "PROD_U_DATE_3" field.
        /// </summary>
        private DateTime? _uDate3;

        /// <summary>
        ///     the value of the "PROD_U_DATE_4" field.
        /// </summary>
        private DateTime? _uDate4;

        /// <summary>
        ///     the value of the "PROD_U_DATE_5" field.
        /// </summary>
        private DateTime? _uDate5;

        /// <summary>
        ///     the value of the "PROD_U_DATE_6" field.
        /// </summary>
        private DateTime? _uDate6;

        /// <summary>
        ///     the value of the "PROD_USERNUM_6" field.
        /// </summary>
        private Decimal? _usernum6;

        /// <summary>
        ///     the value of the "PROD_ROOM_BED_TYPE" field.
        /// </summary>
        private String _roomBedType;

        /// <summary>
        ///     the value of the "PROD_LAY_STD" field.
        /// </summary>
        private Int32? _layStd;

        /// <summary>
        ///     the value of the "PROD_LAY_THEATER" field.
        /// </summary>
        private Int32? _layTheater;

        /// <summary>
        ///     the value of the "PROD_LAY_INFORMAL" field.
        /// </summary>
        private Int32? _layInformal;

        /// <summary>
        ///     the value of the "PROD_LAY_CLASS" field.
        /// </summary>
        private Int32? _layClass;

        /// <summary>
        ///     the value of the "PROD_LAY_OTHER" field.
        /// </summary>
        private Int32? _layOther;

        /// <summary>
        ///     the value of the "PROD_MAX_THEATER" field.
        /// </summary>
        private Double? _maxTheater;

        /// <summary>
        ///     the value of the "PROD_MAX_INFORMAL" field.
        /// </summary>
        private Double? _maxInformal;

        /// <summary>
        ///     the value of the "PROD_MAX_CLASS" field.
        /// </summary>
        private Double? _maxClass;

        /// <summary>
        ///     the value of the "PROD_MAX_OTHER" field.
        /// </summary>
        private Double? _maxOther;

        /// <summary>
        ///     the value of the "PROD_PRICE_BAND" field.
        /// </summary>
        private String _priceBand;

        /// <summary>
        ///     the value of the "PROD_SLTY_ID" field.
        /// </summary>
        private String _sltyId;

        /// <summary>
        ///     the value of the "PROD_KEYWORDS" field.
        /// </summary>
        private String _keywords;

        /// <summary>
        ///     the value of the "PROD_LMS_NAME" field.
        /// </summary>
        private String _lmsName;

        /// <summary>
        ///     the value of the "PROD_EL_SELF_APRV" field.
        /// </summary>
        private Byte? _elSelfAprv;

        /// <summary>
        ///     the value of the "PROD_CUT_PRD" field.
        /// </summary>
        private Int32? _cutPrd;

        /// <summary>
        ///     the value of the "PROD_RENEWAL_MONTH" field.
        /// </summary>
        private String _renewalMonth;

        /// <summary>
        ///     the value of the "PROD_RENEWAL_DAY" field.
        /// </summary>
        private String _renewalDay;

        /// <summary>
        ///     the value of the "PROD_FIXED_RENEWAL" field.
        /// </summary>
        private Byte? _fixedRenewal;

        /// <summary>
        ///     the value of the "PROD_EXCL_DAY" field.
        /// </summary>
        private String _exclDay;

        /// <summary>
        ///     the value of the "PROD_EXCL_CALC" field.
        /// </summary>
        private Byte? _exclCalc;

        /// <summary>
        ///     the value of the "PROD_SG_NO" field.
        /// </summary>
        private Int32? _sgNo;

        /// <summary>
        ///     the value of the "PROD_MS_APP" field.
        /// </summary>
        private String _msApp;

        /// <summary>
        ///     the value of the "PROD_MS_OFF" field.
        /// </summary>
        private String _msOff;

        /// <summary>
        ///     the value of the "PROD_FUNDED" field.
        /// </summary>
        private Byte? _funded;

        /// <summary>
        ///     the value of the "PROD_FUNDED_ORG_ID" field.
        /// </summary>
        private String _fundedOrgId;

        /// <summary>
        ///     the value of the "PROD_QUAL_DEL" field.
        /// </summary>
        private Byte? _qualDel;

        /// <summary>
        ///     the value of the "PROD_BREAK_MUST_EXIST" field.
        /// </summary>
        private Byte? _breakMustExist;

        /// <summary>
        ///     the value of the "PROD_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "PROD_BD_PREP_BY" field.
        /// </summary>
        private String _bdPrepBy;

        /// <summary>
        ///     the value of the "PROD_BD_PREP_DATE" field.
        /// </summary>
        private DateTime? _bdPrepDate;

        /// <summary>
        ///     the value of the "PROD_BD_STATUS" field.
        /// </summary>
        private String _bdStatus;

        /// <summary>
        ///     the value of the "PROD_BD_APP_BY" field.
        /// </summary>
        private String _bdAppBy;

        /// <summary>
        ///     the value of the "PROD_BD_APP_DATE" field.
        /// </summary>
        private DateTime? _bdAppDate;

        /// <summary>
        ///     the value of the "PROD_BD_TOT_EST_COST" field.
        /// </summary>
        private Decimal? _bdTotEstCost;

        /// <summary>
        ///     the value of the "PROD_NO_INV_RENEW" field.
        /// </summary>
        private Byte? _noInvRenew;

        /// <summary>
        ///     the value of the "PROD_CALC_COMMISSION" field.
        /// </summary>
        private Byte? _calcCommission;

        /// <summary>
        ///     the value of the "PROD_REGION" field.
        /// </summary>
        private String _region;

        /// <summary>
        ///     the value of the "PROD_STATIC_RESOURSE" field.
        /// </summary>
        private Byte? _staticResourse;

        /// <summary>
        ///     the value of the "PROD_POOLED_RESOURSE" field.
        /// </summary>
        private Byte? _pooledResourse;

        /// <summary>
        ///     the value of the "PROD_CLASH_CHECK" field.
        /// </summary>
        private Byte? _clashCheck;

        /// <summary>
        ///     the value of the "PROD_DEF_TRAINEE_DAYS" field.
        /// </summary>
        private Decimal? _defTraineeDays;

        /// <summary>
        ///     the value of the "PROD_GRANT_ELIGIBLE" field.
        /// </summary>
        private Byte? _grantEligible;

        /// <summary>
        ///     the value of the "PROD_GRANT_VALUE_AVAILABLE" field.
        /// </summary>
        private Decimal? _grantValueAvailable;

        /// <summary>
        ///     the value of the "PROD_BREAKEVEN_1" field.
        /// </summary>
        private Decimal? _breakeven1;

        /// <summary>
        ///     the value of the "PROD_BREAKEVEN_2" field.
        /// </summary>
        private Decimal? _breakeven2;

        /// <summary>
        ///     the value of the "PROD_EXT_COURSEWARE" field.
        /// </summary>
        private Byte? _extCourseware;

        /// <summary>
        ///     the value of the "PROD_CONTINGENCY" field.
        /// </summary>
        private Int32? _contingency;

        /// <summary>
        ///     the value of the "PROD_COST" field.
        /// </summary>
        private Decimal? _cost;

        /// <summary>
        ///     the value of the "PROD_DELIVERY_DAY" field.
        /// </summary>
        private Int32? _deliveryDay;

        /// <summary>
        ///     the value of the "PROD_EXT_URL" field.
        /// </summary>
        private String _extUrl;

        /// <summary>
        ///     the value of the "PROD_USE_EXT_URL" field.
        /// </summary>
        private Byte? _useExtUrl;

        /// <summary>
        ///     the value of the "PROD_REF_NO" field.
        /// </summary>
        private Int32? _refNo;

        /// <summary>
        ///     the value of the "PROD_PREFIX" field.
        /// </summary>
        private String _prefix;

        /// <summary>
        ///     the value of the "PROD_NONE_CHARGEABLE" field.
        /// </summary>
        private Byte _noneChargeable;

        /// <summary>
        ///     the value of the "PROD_RULE_INC_FAMILY" field.
        /// </summary>
        private Byte _ruleIncFamily;

        /// <summary>
        ///     the value of the "PROD_DONATION" field.
        /// </summary>
        private Byte? _donation;

        /// <summary>
        ///     the value of the "PROD_RENEW" field.
        /// </summary>
        private Byte? _renew;

        /// <summary>
        ///     the value of the "PROD_RENEWABLE" field.
        /// </summary>
        private Byte _renewable;

        /// <summary>
        ///     the value of the "PROD_COURSE_NOTES_TEXT_ID" field.
        /// </summary>
        private String _courseNotesTextId;

        /// <summary>
        ///     the value of the "PROD_DESIG_LETTERS" field.
        /// </summary>
        private String _desigLetters;

        /// <summary>
        ///     the value of the "PROD_NON_RENEW_MEMB" field.
        /// </summary>
        private Byte _nonRenewMemb;

        /// <summary>
        ///     the value of the "PROD_AGE_RESTRICTION_1" field.
        /// </summary>
        private Int32? _ageRestriction1;

        /// <summary>
        ///     the value of the "PROD_AGE_RESTRICTION_2" field.
        /// </summary>
        private Int32? _ageRestriction2;

        /// <summary>
        ///     the value of the "PROD_RESTRICT_TYPE" field.
        /// </summary>
        private String _restrictType;

        /// <summary>
        ///     the value of the "PROD_EXPIRY_DATE" field.
        /// </summary>
        private DateTime? _expiryDate;

        /// <summary>
        ///     the value of the "PROD_INV_ZERO_VAL" field.
        /// </summary>
        private Int32 _invZeroVal;

        /// <summary>
        ///     the value of the "PROD_CREDIT_HOURS" field.
        /// </summary>
        private Decimal _creditHours;

        /// <summary>
        ///     the value of the "PROD_DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        private Int32? _ddNoOfInstallments;

        /// <summary>
        ///     the value of the "PROD_DD_FREQUENCY" field.
        /// </summary>
        private Int32? _ddFrequency;

        /// <summary>
        ///     the value of the "PROD_EXCLUDE_TRAIN_HISTORY" field.
        /// </summary>
        private Byte _excludeTrainHistory;

        /// <summary>
        ///     the value of the "PROD_START_DATE_TYPE" field.
        /// </summary>
        private Byte _startDateType;

        /// <summary>
        ///     the value of the "PROD_START_DATE_FIXED" field.
        /// </summary>
        private DateTime? _startDateFixed;

        /// <summary>
        ///     the value of the "PROD_START_DATE_OFFSET" field.
        /// </summary>
        private Int32 _startDateOffset;

        /// <summary>
        ///     the value of the "PROD_START_DATE_OFFSET_TYPE" field.
        /// </summary>
        private String _startDateOffsetType;

        /// <summary>
        ///     the value of the "PROD_END_DATE_TYPE" field.
        /// </summary>
        private Byte _endDateType;

        /// <summary>
        ///     the value of the "PROD_END_DATE_FIXED" field.
        /// </summary>
        private DateTime? _endDateFixed;

        /// <summary>
        ///     the value of the "PROD_END_DATE_OFFSET" field.
        /// </summary>
        private Int32 _endDateOffset;

        /// <summary>
        ///     the value of the "PROD_END_DATE_OFFSET_TYPE" field.
        /// </summary>
        private String _endDateOffsetType;

        /// <summary>
        ///     the value of the "PROD_DESC_EDITABLE" field.
        /// </summary>
        private Byte _descEditable;

        /// <summary>
        ///     the value of the "PROD_STOCK_TYPE" field.
        /// </summary>
        private String _stockType;

        /// <summary>
        ///     the value of the "PROD_STOCK_EXPECTED_DATE" field.
        /// </summary>
        private String _stockExpectedDate;

        /// <summary>
        ///     the value of the "PROD_MEM_FIRST_BOOK" field.
        /// </summary>
        private Byte _memFirstBook;

        /// <summary>
        ///     the value of the "PROD_MIN_SCORE" field.
        /// </summary>
        private Decimal? _minScore;

        /// <summary>
        ///     the value of the "PROD_SCORE_OUTOF" field.
        /// </summary>
        private Decimal? _scoreOutof;

        /// <summary>
        ///     the value of the "PROD_GRADE_WEB" field.
        /// </summary>
        private Byte? _gradeWeb;

        /// <summary>
        ///     the value of the "PROD_PREDELIV" field.
        /// </summary>
        private Byte _predeliv;

        /// <summary>
        ///     the value of the "PROD_AUTHOR_NAME" field.
        /// </summary>
        private String _authorName;

        /// <summary>
        ///     the value of the "PROD_TOPUP" field.
        /// </summary>
        private Byte? _topup;

        /// <summary>
        ///     the value of the "PROD_LIMIT_PL_TYPE" field.
        /// </summary>
        private String _limitPlType;

        /// <summary>
        ///     the value of the "PROD_PREPAY_UNITS" field.
        /// </summary>
        private Int32? _prepayUnits;

        /// <summary>
        ///     the value of the "PROD_DELIV_METHOD" field.
        /// </summary>
        private String _delivMethod;

        /// <summary>
        ///     the value of the "PROD_LOCKDOWN" field.
        /// </summary>
        private Byte? _lockdown;

        /// <summary>
        ///     the value of the "PROD_PROMOTION" field.
        /// </summary>
        private Byte? _promotion;

        /// <summary>
        ///     the value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        private String _searchGroup;

        /// <summary>
        ///     the value of the "PROD_LIMIT_PL_ID" field.
        /// </summary>
        private String _limitPlId;

        /// <summary>
        ///     the value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        private String _defElemSt;

        /// <summary>
        ///     the value of the "PROD_NEXT_NO" field.
        /// </summary>
        private Int32? _nextNo;

        /// <summary>
        ///     the value of the "PROD_SUFFIX" field.
        /// </summary>
        private String _suffix;

        /// <summary>
        ///     the value of the "PROD_NO_MEMB_DISCOUNT" field.
        /// </summary>
        private Byte _noMembDiscount;

        /// <summary>
        ///     the value of the "PROD_QUEST_ID" field.
        /// </summary>
        private String _questId;

        /// <summary>
        ///     the value of the "PROD_SHORT_DESC" field.
        /// </summary>
        private String _shortDesc;

        /// <summary>
        ///     the value of the "PROD_ONECLICK_CHECKOUT" field.
        /// </summary>
        private Byte _oneclickCheckout;

        /// <summary>
        ///     the value of the "PROD_BOOKER_ONLY" field.
        /// </summary>
        private Byte _bookerOnly;

        /// <summary>
        ///     the value of the "PROD_LAY_USHAPE" field.
        /// </summary>
        private Int32? _layUshape;

        /// <summary>
        ///     the value of the "PROD_LAY_BROOM" field.
        /// </summary>
        private Int32? _layBroom;

        /// <summary>
        ///     the value of the "PROD_LAY_BROUT" field.
        /// </summary>
        private Int32? _layBrout;

        /// <summary>
        ///     the value of the "PROD_MAX_USHAPE" field.
        /// </summary>
        private Double? _maxUshape;

        /// <summary>
        ///     the value of the "PROD_MAX_BROOM" field.
        /// </summary>
        private Double? _maxBroom;

        /// <summary>
        ///     the value of the "PROD_MAX_BROUT" field.
        /// </summary>
        private Double? _maxBrout;

        /// <summary>
        ///     the value of the "PROD_WP_NAME" field.
        /// </summary>
        private String _wpName;

        /// <summary>
        ///     the value of the "PROD_DEPT" field.
        /// </summary>
        private String _dept;

        /// <summary>
        ///     the value of the "PROD_SKU" field.
        /// </summary>
        private String _sku;

        /// <summary>
        ///     the value of the "PROD_JOB_CODE" field.
        /// </summary>
        private String _jobCode;

        /// <summary>
        ///     the value of the "PROD_JOB_ANALY_CODE" field.
        /// </summary>
        private String _jobAnalyCode;

        /// <summary>
        ///     the value of the "PROD_JOB_TYPE" field.
        /// </summary>
        private String _jobType;

        /// <summary>
        ///     the value of the "PROD_JOB_PARENT" field.
        /// </summary>
        private String _jobParent;

        /// <summary>
        ///     the value of the "PROD_PSH_ID" field.
        /// </summary>
        private Int32? _pshId;

        /// <summary>
        ///     the value of the "PROD_IMAGE" field.
        /// </summary>
        private String _image;

        /// <summary>
        ///     the value of the "PROD_ONLINE_SCHE" field.
        /// </summary>
        private String _onlineSche;

        /// <summary>
        ///     the value of the "PROD_QUOTEBOOK_RATIO" field.
        /// </summary>
        private Int32 _quotebookRatio;

        /// <summary>
        ///     the value of the "PROD_COORDS" field.
        /// </summary>
        private String _coords;

        /// <summary>
        ///     the value of the "PROD_URL_NAME" field.
        /// </summary>
        private String _urlName;

        /// <summary>
        ///     the value of the "PROD_ZERO_PAD" field.
        /// </summary>
        private Int32? _zeroPad;

        /// <summary>
        ///     the value of the "PROD_TRAIN_PROV" field.
        /// </summary>
        private Byte? _trainProv;

        /// <summary>
        ///     the value of the "PROD_REORDER_LEV" field.
        /// </summary>
        private Byte? _reorderLev;

        /// <summary>
        ///     the value of the "PROD_LICENSED" field.
        /// </summary>
        private Byte _licensed;

        /// <summary>
        ///     the value of the "PROD_DEL_CLOSE_DAYS" field.
        /// </summary>
        private Int32 _delCloseDays;

        /// <summary>
        ///     the value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        private String _trnRulesTxt;

        /// <summary>
        ///     the value of the "PROD_CERT_DEF_DELIVER" field.
        /// </summary>
        private Byte _certDefDeliver;

        /// <summary>
        ///     the value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        private String _defMethDel;

        /// <summary>
        ///     the value of the "PROD_CERT_TEMP_LTT_ID" field.
        /// </summary>
        private String _certTempLttId;

        /// <summary>
        ///     the value of the "PROD_REORDER_LEAD" field.
        /// </summary>
        private Int32? _reorderLead;

        /// <summary>
        ///     the value of the "PROD_NOM_MEM_DET" field.
        /// </summary>
        private String _nomMemDet;

        /// <summary>
        ///     the value of the "PROD_NOM_MEM_REQ" field.
        /// </summary>
        private Byte? _nomMemReq;

        /// <summary>
        ///     the value of the "PROD_NOM_MEM_PROD_ID" field.
        /// </summary>
        private String _nomMemProdId;

        /// <summary>
        ///     the value of the "PROD_PACK_SEND_PROLE_ID" field.
        /// </summary>
        private String _packSendProleId;

        /// <summary>
        ///     the value of the "PROD_PACK_BCC_EMAIL" field.
        /// </summary>
        private String _packBccEmail;

        /// <summary>
        ///     the value of the "PROD_PACK_MDN_EMAIL" field.
        /// </summary>
        private String _packMdnEmail;

        /// <summary>
        ///     the value of the "PROD_PACK_DSN_EMAIL" field.
        /// </summary>
        private String _packDsnEmail;

        /// <summary>
        ///     the value of the "PROD_PACK_DSN_OPTIONS" field.
        /// </summary>
        private String _packDsnOptions;

        /// <summary>
        ///     the value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        private String _codeImage;

        /// <summary>
        ///     the value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        private String _gatewayAccId;

        /// <summary>
        ///     the value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        private String _royaltyModel;

        /// <summary>
        ///     the value of the "PROD_SESSIONS_DESCRIPTION" field.
        /// </summary>
        private String _sessionsDescription;

        /// <summary>
        ///     the value of the "PROD_SESSIONS_HEADER" field.
        /// </summary>
        private String _sessionsHeader;

        /// <summary>
        ///     the value of the "PROD_CUT_PRD_TIME" field.
        /// </summary>
        private Byte? _cutPrdTime;

        /// <summary>
        ///     the value of the "PROD_GIFTAID" field.
        /// </summary>
        private Byte? _giftaid;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PROD_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GROUP_ID" field.
        /// </summary>
        public String GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REF" field.
        /// </summary>
        public String Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DESCRIP" field.
        /// </summary>
        public String Descrip
        {
            get { return _descrip; }
            set { _descrip = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TEXT1" field.
        /// </summary>
        public String Text1
        {
            get { return _text1; }
            set { _text1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TEXT2" field.
        /// </summary>
        public String Text2
        {
            get { return _text2; }
            set { _text2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TEXT3" field.
        /// </summary>
        public String Text3
        {
            get { return _text3; }
            set { _text3 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TEXT4" field.
        /// </summary>
        public String Text4
        {
            get { return _text4; }
            set { _text4 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TEXT5" field.
        /// </summary>
        public String Text5
        {
            get { return _text5; }
            set { _text5 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SY_PRODUCT" field.
        /// </summary>
        public Byte? SyProduct
        {
            get { return _syProduct; }
            set { _syProduct = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CATEGORY" field.
        /// </summary>
        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        ///     the value of the "PROD_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GROUP" field.
        /// </summary>
        public String Group
        {
            get { return _group; }
            set { _group = value; }
        }

        /// <summary>
        ///     the value of the "PROD_UNIT" field.
        /// </summary>
        public String Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PRICE" field.
        /// </summary>
        public Double? Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BLOCK_PRICE" field.
        /// </summary>
        public Double? BlockPrice
        {
            get { return _blockPrice; }
            set { _blockPrice = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SPARE_PRICE" field.
        /// </summary>
        public Double? SparePrice
        {
            get { return _sparePrice; }
            set { _sparePrice = value; }
        }

        /// <summary>
        ///     the value of the "PROD_COST_PRICE" field.
        /// </summary>
        public Double? CostPrice
        {
            get { return _costPrice; }
            set { _costPrice = value; }
        }

        /// <summary>
        ///     the value of the "PROD_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return _revCode; }
            set { _revCode = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DISC_SCHED" field.
        /// </summary>
        public String DiscSched
        {
            get { return _discSched; }
            set { _discSched = value; }
        }

        /// <summary>
        ///     the value of the "PROD_VAT_CODE" field.
        /// </summary>
        public String VatCode
        {
            get { return _vatCode; }
            set { _vatCode = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MIN_ATTEND" field.
        /// </summary>
        public Double? MinAttend
        {
            get { return _minAttend; }
            set { _minAttend = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MAX_ATTEND" field.
        /// </summary>
        public Double? MaxAttend
        {
            get { return _maxAttend; }
            set { _maxAttend = value; }
        }

        /// <summary>
        ///     the value of the "PROD_COURSE_LEN" field.
        /// </summary>
        public Double? CourseLen
        {
            get { return _courseLen; }
            set { _courseLen = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DIARY_TYPE" field.
        /// </summary>
        public String DiaryType
        {
            get { return _diaryType; }
            set { _diaryType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NORM_COLLEGE" field.
        /// </summary>
        public String NormCollege
        {
            get { return _normCollege; }
            set { _normCollege = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NEXT_COURSE" field.
        /// </summary>
        public String NextCourse
        {
            get { return _nextCourse; }
            set { _nextCourse = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SPARE_FLAG1" field.
        /// </summary>
        public Byte? SpareFlag1
        {
            get { return _spareFlag1; }
            set { _spareFlag1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SPARE_FLAG2" field.
        /// </summary>
        public Byte? SpareFlag2
        {
            get { return _spareFlag2; }
            set { _spareFlag2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CERT_PRINTED" field.
        /// </summary>
        public Byte? CertPrinted
        {
            get { return _certPrinted; }
            set { _certPrinted = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TUC_REGION" field.
        /// </summary>
        public String TucRegion
        {
            get { return _tucRegion; }
            set { _tucRegion = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ENTRY_DATE" field.
        /// </summary>
        public DateTime? EntryDate
        {
            get { return _entryDate; }
            set { _entryDate = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PROJECT_NO" field.
        /// </summary>
        public String ProjectNo
        {
            get { return _projectNo; }
            set { _projectNo = value; }
        }

        /// <summary>
        ///     the value of the "PROD_COMMISSION_BY" field.
        /// </summary>
        public String CommissionBy
        {
            get { return _commissionBy; }
            set { _commissionBy = value; }
        }

        /// <summary>
        ///     the value of the "PROD_KEY" field.
        /// </summary>
        public String Key
        {
            get { return _key; }
            set { _key = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CODE" field.
        /// </summary>
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TYPE_LOW" field.
        /// </summary>
        public String TypeLow
        {
            get { return _typeLow; }
            set { _typeLow = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REF_LOW" field.
        /// </summary>
        public String RefLow
        {
            get { return _refLow; }
            set { _refLow = value; }
        }

        /// <summary>
        ///     the value of the "PROD_QUES_SET" field.
        /// </summary>
        public Byte? QuesSet
        {
            get { return _quesSet; }
            set { _quesSet = value; }
        }

        /// <summary>
        ///     the value of the "PROD_START_QNO" field.
        /// </summary>
        public Byte? StartQno
        {
            get { return _startQno; }
            set { _startQno = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SELL_HINT" field.
        /// </summary>
        public String SellHint
        {
            get { return _sellHint; }
            set { _sellHint = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DET" field.
        /// </summary>
        public String Det
        {
            get { return _det; }
            set { _det = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ASS" field.
        /// </summary>
        public String Ass
        {
            get { return _ass; }
            set { _ass = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RETAIL_PRICE" field.
        /// </summary>
        public Double? RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MARGIN" field.
        /// </summary>
        public Double? Margin
        {
            get { return _margin; }
            set { _margin = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SUPPLIER_NAME" field.
        /// </summary>
        public String SupplierName
        {
            get { return _supplierName; }
            set { _supplierName = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SUPPLIER_ID" field.
        /// </summary>
        public String SupplierId
        {
            get { return _supplierId; }
            set { _supplierId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PIC_ID" field.
        /// </summary>
        public String PicId
        {
            get { return _picId; }
            set { _picId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_JOIN_LETT" field.
        /// </summary>
        public String JoinLett
        {
            get { return _joinLett; }
            set { _joinLett = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CONFIRM_LETT" field.
        /// </summary>
        public String ConfirmLett
        {
            get { return _confirmLett; }
            set { _confirmLett = value; }
        }

        /// <summary>
        ///     the value of the "PROD_QUEST_LETT" field.
        /// </summary>
        public String QuestLett
        {
            get { return _questLett; }
            set { _questLett = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SURV_LETT" field.
        /// </summary>
        public String SurvLett
        {
            get { return _survLett; }
            set { _survLett = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NO_CST_NO_SEL" field.
        /// </summary>
        public Byte? NoCstNoSel
        {
            get { return _noCstNoSel; }
            set { _noCstNoSel = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PROV_LETT" field.
        /// </summary>
        public String ProvLett
        {
            get { return _provLett; }
            set { _provLett = value; }
        }

        /// <summary>
        ///     the value of the "PROD_INV_LETT" field.
        /// </summary>
        public String InvLett
        {
            get { return _invLett; }
            set { _invLett = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DO_NOT_INVOIC" field.
        /// </summary>
        public Byte? DoNotInvoic
        {
            get { return _doNotInvoic; }
            set { _doNotInvoic = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TOP_LEVEL" field.
        /// </summary>
        public Byte? TopLevel
        {
            get { return _topLevel; }
            set { _topLevel = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ROOM_TYPE" field.
        /// </summary>
        public String RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ROOM_GRADE" field.
        /// </summary>
        public String RoomGrade
        {
            get { return _roomGrade; }
            set { _roomGrade = value; }
        }

        /// <summary>
        ///     the value of the "PROD_STATE" field.
        /// </summary>
        public Byte? State
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        ///     the value of the "PROD_STOCKED" field.
        /// </summary>
        public Byte? Stocked
        {
            get { return _stocked; }
            set { _stocked = value; }
        }

        /// <summary>
        ///     the value of the "PROD_QTY_AV" field.
        /// </summary>
        public Double? QtyAv
        {
            get { return _qtyAv; }
            set { _qtyAv = value; }
        }

        /// <summary>
        ///     the value of the "PROD_QTY_AC" field.
        /// </summary>
        public Double? QtyAc
        {
            get { return _qtyAc; }
            set { _qtyAc = value; }
        }

        /// <summary>
        ///     the value of the "PROD_QTY_BO" field.
        /// </summary>
        public Double? QtyBo
        {
            get { return _qtyBo; }
            set { _qtyBo = value; }
        }

        /// <summary>
        ///     the value of the "PROD_QTY_OR" field.
        /// </summary>
        public Double? QtyOr
        {
            get { return _qtyOr; }
            set { _qtyOr = value; }
        }

        /// <summary>
        ///     the value of the "PROD_COURSEMASTER" field.
        /// </summary>
        public Byte? Coursemaster
        {
            get { return _coursemaster; }
            set { _coursemaster = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LAST_USED" field.
        /// </summary>
        public DateTime? LastUsed
        {
            get { return _lastUsed; }
            set { _lastUsed = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DAILY_DEL_RAT" field.
        /// </summary>
        public Double? DailyDelRat
        {
            get { return _dailyDelRat; }
            set { _dailyDelRat = value; }
        }

        /// <summary>
        ///     the value of the "PROD_OVERNIGHT_RAT" field.
        /// </summary>
        public Double? OvernightRat
        {
            get { return _overnightRat; }
            set { _overnightRat = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SYNDICATE_RAT" field.
        /// </summary>
        public Double? SyndicateRat
        {
            get { return _syndicateRat; }
            set { _syndicateRat = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP1" field.
        /// </summary>
        public Double? Equip1
        {
            get { return _equip1; }
            set { _equip1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP2" field.
        /// </summary>
        public Double? Equip2
        {
            get { return _equip2; }
            set { _equip2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP3" field.
        /// </summary>
        public Double? Equip3
        {
            get { return _equip3; }
            set { _equip3 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP4" field.
        /// </summary>
        public Double? Equip4
        {
            get { return _equip4; }
            set { _equip4 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP5" field.
        /// </summary>
        public Double? Equip5
        {
            get { return _equip5; }
            set { _equip5 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP6" field.
        /// </summary>
        public Double? Equip6
        {
            get { return _equip6; }
            set { _equip6 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP7" field.
        /// </summary>
        public Double? Equip7
        {
            get { return _equip7; }
            set { _equip7 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP8" field.
        /// </summary>
        public Double? Equip8
        {
            get { return _equip8; }
            set { _equip8 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP9" field.
        /// </summary>
        public Double? Equip9
        {
            get { return _equip9; }
            set { _equip9 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP10" field.
        /// </summary>
        public Double? Equip10
        {
            get { return _equip10; }
            set { _equip10 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP11" field.
        /// </summary>
        public Double? Equip11
        {
            get { return _equip11; }
            set { _equip11 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP12" field.
        /// </summary>
        public Double? Equip12
        {
            get { return _equip12; }
            set { _equip12 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP13" field.
        /// </summary>
        public Double? Equip13
        {
            get { return _equip13; }
            set { _equip13 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP14" field.
        /// </summary>
        public Double? Equip14
        {
            get { return _equip14; }
            set { _equip14 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EQUIP15" field.
        /// </summary>
        public Double? Equip15
        {
            get { return _equip15; }
            set { _equip15 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GENERALISED" field.
        /// </summary>
        public Byte? Generalised
        {
            get { return _generalised; }
            set { _generalised = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NETW_TYPE" field.
        /// </summary>
        public String NetwType
        {
            get { return _netwType; }
            set { _netwType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REN_TYPE" field.
        /// </summary>
        public String RenType
        {
            get { return _renType; }
            set { _renType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_OLD_DESC" field.
        /// </summary>
        public String OldDesc
        {
            get { return _oldDesc; }
            set { _oldDesc = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CLASS" field.
        /// </summary>
        public String Class
        {
            get { return _class; }
            set { _class = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TI_CODE" field.
        /// </summary>
        public String TiCode
        {
            get { return _tiCode; }
            set { _tiCode = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DEP_REPS" field.
        /// </summary>
        public String DepReps
        {
            get { return _depReps; }
            set { _depReps = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LEAD_DEPT" field.
        /// </summary>
        public Byte? LeadDept
        {
            get { return _leadDept; }
            set { _leadDept = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CURRENT" field.
        /// </summary>
        public String Current
        {
            get { return _current; }
            set { _current = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MEDIA" field.
        /// </summary>
        public String Media
        {
            get { return _media; }
            set { _media = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MAX_DISC" field.
        /// </summary>
        public Double? MaxDisc
        {
            get { return _maxDisc; }
            set { _maxDisc = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERNUM_1" field.
        /// </summary>
        public Decimal? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_AVAIL_DATE" field.
        /// </summary>
        public DateTime? AvailDate
        {
            get { return _availDate; }
            set { _availDate = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CERT_FMT" field.
        /// </summary>
        public String CertFmt
        {
            get { return _certFmt; }
            set { _certFmt = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CERT_NAME" field.
        /// </summary>
        public String CertName
        {
            get { return _certName; }
            set { _certName = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LSE_PRINTED" field.
        /// </summary>
        public Byte? LsePrinted
        {
            get { return _lsePrinted; }
            set { _lsePrinted = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REQ_FREQCY" field.
        /// </summary>
        public Byte? ReqFreqcy
        {
            get { return _reqFreqcy; }
            set { _reqFreqcy = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ADM_TXT_ID" field.
        /// </summary>
        public String AdmTxtId
        {
            get { return _admTxtId; }
            set { _admTxtId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TRN_TXT_ID" field.
        /// </summary>
        public String TrnTxtId
        {
            get { return _trnTxtId; }
            set { _trnTxtId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ENQ_QST_ID" field.
        /// </summary>
        public String EnqQstId
        {
            get { return _enqQstId; }
            set { _enqQstId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DEL_QST_ID" field.
        /// </summary>
        public String DelQstId
        {
            get { return _delQstId; }
            set { _delQstId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PROV_PACK" field.
        /// </summary>
        public String ProvPack
        {
            get { return _provPack; }
            set { _provPack = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CONF_PACK" field.
        /// </summary>
        public String ConfPack
        {
            get { return _confPack; }
            set { _confPack = value; }
        }

        /// <summary>
        ///     the value of the "PROD_JOINING_PACK" field.
        /// </summary>
        public String JoiningPack
        {
            get { return _joiningPack; }
            set { _joiningPack = value; }
        }

        /// <summary>
        ///     the value of the "PROD_POST_PACK" field.
        /// </summary>
        public String PostPack
        {
            get { return _postPack; }
            set { _postPack = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PROV_INV" field.
        /// </summary>
        public Byte? ProvInv
        {
            get { return _provInv; }
            set { _provInv = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CONF_INV" field.
        /// </summary>
        public Byte? ConfInv
        {
            get { return _confInv; }
            set { _confInv = value; }
        }

        /// <summary>
        ///     the value of the "PROD_JOIN_INV" field.
        /// </summary>
        public Byte? JoinInv
        {
            get { return _joinInv; }
            set { _joinInv = value; }
        }

        /// <summary>
        ///     the value of the "PROD_POST_INV" field.
        /// </summary>
        public Byte? PostInv
        {
            get { return _postInv; }
            set { _postInv = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MSTC_TYPE" field.
        /// </summary>
        public String MstcType
        {
            get { return _mstcType; }
            set { _mstcType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_OVERBOOK" field.
        /// </summary>
        public Double? Overbook
        {
            get { return _overbook; }
            set { _overbook = value; }
        }

        /// <summary>
        ///     the value of the "PROD_COMMISSION" field.
        /// </summary>
        public Byte? Commission
        {
            get { return _commission; }
            set { _commission = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PLAN_ID" field.
        /// </summary>
        public String PlanId
        {
            get { return _planId; }
            set { _planId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PLAN_NAME" field.
        /// </summary>
        public String PlanName
        {
            get { return _planName; }
            set { _planName = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NO_HOURS" field.
        /// </summary>
        public Double? NoHours
        {
            get { return _noHours; }
            set { _noHours = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EXPIRY_MONTHS" field.
        /// </summary>
        public Double? ExpiryMonths
        {
            get { return _expiryMonths; }
            set { _expiryMonths = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PLACES" field.
        /// </summary>
        public Int32? Places
        {
            get { return _places; }
            set { _places = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PRE_PAY_TYPE" field.
        /// </summary>
        public String PrePayType
        {
            get { return _prePayType; }
            set { _prePayType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GRADES" field.
        /// </summary>
        public String Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        public String ManProleId
        {
            get { return _manProleId; }
            set { _manProleId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LEVEL" field.
        /// </summary>
        public String Level
        {
            get { return _level; }
            set { _level = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SERIALISED" field.
        /// </summary>
        public Byte? Serialised
        {
            get { return _serialised; }
            set { _serialised = value; }
        }

        /// <summary>
        ///     the value of the "PROD_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        ///     the value of the "PROD_VAL_TO_REV_PC" field.
        /// </summary>
        public Double? ValToRevPc
        {
            get { return _valToRevPc; }
            set { _valToRevPc = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BKT_ID" field.
        /// </summary>
        public String BktId
        {
            get { return _bktId; }
            set { _bktId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BT_ID" field.
        /// </summary>
        public String BtId
        {
            get { return _btId; }
            set { _btId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NAME2" field.
        /// </summary>
        public String Name2
        {
            get { return _name2; }
            set { _name2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GL_CODE1" field.
        /// </summary>
        public String GlCode1
        {
            get { return _glCode1; }
            set { _glCode1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GL_CODE2" field.
        /// </summary>
        public String GlCode2
        {
            get { return _glCode2; }
            set { _glCode2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RESOURSE" field.
        /// </summary>
        public Byte? Resourse
        {
            get { return _resourse; }
            set { _resourse = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LOC_ID" field.
        /// </summary>
        public String LocId
        {
            get { return _locId; }
            set { _locId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_WEB" field.
        /// </summary>
        public Byte? Web
        {
            get { return _web; }
            set { _web = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DESC_FILE" field.
        /// </summary>
        public String DescFile
        {
            get { return _descFile; }
            set { _descFile = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERINT_1" field.
        /// </summary>
        public Int32? Userint1
        {
            get { return _userint1; }
            set { _userint1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERINT_2" field.
        /// </summary>
        public Int32? Userint2
        {
            get { return _userint2; }
            set { _userint2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERINT_3" field.
        /// </summary>
        public Int32? Userint3
        {
            get { return _userint3; }
            set { _userint3 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERINT_4" field.
        /// </summary>
        public Int32? Userint4
        {
            get { return _userint4; }
            set { _userint4 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERDATE_1" field.
        /// </summary>
        public DateTime? Userdate1
        {
            get { return _userdate1; }
            set { _userdate1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERINT_5" field.
        /// </summary>
        public Int32? Userint5
        {
            get { return _userint5; }
            set { _userint5 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERNUM_2" field.
        /// </summary>
        public Decimal? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERINT_6" field.
        /// </summary>
        public Int32? Userint6
        {
            get { return _userint6; }
            set { _userint6 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return _userchar5; }
            set { _userchar5 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERNUM_3" field.
        /// </summary>
        public Decimal? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERNUM_4" field.
        /// </summary>
        public Decimal? Usernum4
        {
            get { return _usernum4; }
            set { _usernum4 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERNUM_5" field.
        /// </summary>
        public Decimal? Usernum5
        {
            get { return _usernum5; }
            set { _usernum5 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERINT_7" field.
        /// </summary>
        public Int32? Userint7
        {
            get { return _userint7; }
            set { _userint7 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERINT_8" field.
        /// </summary>
        public Int32? Userint8
        {
            get { return _userint8; }
            set { _userint8 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERINT_9" field.
        /// </summary>
        public Int32? Userint9
        {
            get { return _userint9; }
            set { _userint9 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MEMB_PRC_GRP" field.
        /// </summary>
        public String MembPrcGrp
        {
            get { return _membPrcGrp; }
            set { _membPrcGrp = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SCO_MANIF_XML" field.
        /// </summary>
        public String ScoManifXml
        {
            get { return _scoManifXml; }
            set { _scoManifXml = value; }
        }

        /// <summary>
        ///     the value of the "prod_quantity" field.
        /// </summary>
        public Double? ProdQuantity
        {
            get { return _prodQuantity; }
            set { _prodQuantity = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NON_SCORM" field.
        /// </summary>
        public Byte? NonScorm
        {
            get { return _nonScorm; }
            set { _nonScorm = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_NEW" field.
        /// </summary>
        public String MsNew
        {
            get { return _msNew; }
            set { _msNew = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_REMIND1" field.
        /// </summary>
        public String MsRemind1
        {
            get { return _msRemind1; }
            set { _msRemind1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_REMIND2" field.
        /// </summary>
        public String MsRemind2
        {
            get { return _msRemind2; }
            set { _msRemind2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_RENEW" field.
        /// </summary>
        public String MsRenew
        {
            get { return _msRenew; }
            set { _msRenew = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_LAPSED" field.
        /// </summary>
        public String MsLapsed
        {
            get { return _msLapsed; }
            set { _msLapsed = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_CANCEL" field.
        /// </summary>
        public String MsCancel
        {
            get { return _msCancel; }
            set { _msCancel = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_GROUP" field.
        /// </summary>
        public Byte? MsGroup
        {
            get { return _msGroup; }
            set { _msGroup = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RENEW_DAYS" field.
        /// </summary>
        public Int32? RenewDays
        {
            get { return _renewDays; }
            set { _renewDays = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MEM_INV_TYPE" field.
        /// </summary>
        public Byte? MemInvType
        {
            get { return _memInvType; }
            set { _memInvType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        public String AuthPnId
        {
            get { return _authPnId; }
            set { _authPnId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ISBN" field.
        /// </summary>
        public String Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PAGE_COUNT" field.
        /// </summary>
        public Int32? PageCount
        {
            get { return _pageCount; }
            set { _pageCount = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_REMIND3" field.
        /// </summary>
        public String MsRemind3
        {
            get { return _msRemind3; }
            set { _msRemind3 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_RM1_DAYS" field.
        /// </summary>
        public Int32? MsRm1Days
        {
            get { return _msRm1Days; }
            set { _msRm1Days = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_RM2_DAYS" field.
        /// </summary>
        public Int32? MsRm2Days
        {
            get { return _msRm2Days; }
            set { _msRm2Days = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_RM3_DAYS" field.
        /// </summary>
        public Int32? MsRm3Days
        {
            get { return _msRm3Days; }
            set { _msRm3Days = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_LAPS_DAYS" field.
        /// </summary>
        public Int32? MsLapsDays
        {
            get { return _msLapsDays; }
            set { _msLapsDays = value; }
        }

        /// <summary>
        ///     the value of the "PROD_FREQ" field.
        /// </summary>
        public Int32? Freq
        {
            get { return _freq; }
            set { _freq = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DESC_FILE_Y" field.
        /// </summary>
        public String DescFileY
        {
            get { return _descFileY; }
            set { _descFileY = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_RENEWED" field.
        /// </summary>
        public String MsRenewed
        {
            get { return _msRenewed; }
            set { _msRenewed = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        public String RegBodyId1
        {
            get { return _regBodyId1; }
            set { _regBodyId1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REG_BODY_ID_2" field.
        /// </summary>
        public String RegBodyId2
        {
            get { return _regBodyId2; }
            set { _regBodyId2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return _userchar6; }
            set { _userchar6 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_U_DATE_1" field.
        /// </summary>
        public DateTime? UDate1
        {
            get { return _uDate1; }
            set { _uDate1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_U_DATE_2" field.
        /// </summary>
        public DateTime? UDate2
        {
            get { return _uDate2; }
            set { _uDate2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_U_DATE_3" field.
        /// </summary>
        public DateTime? UDate3
        {
            get { return _uDate3; }
            set { _uDate3 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_U_DATE_4" field.
        /// </summary>
        public DateTime? UDate4
        {
            get { return _uDate4; }
            set { _uDate4 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_U_DATE_5" field.
        /// </summary>
        public DateTime? UDate5
        {
            get { return _uDate5; }
            set { _uDate5 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_U_DATE_6" field.
        /// </summary>
        public DateTime? UDate6
        {
            get { return _uDate6; }
            set { _uDate6 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USERNUM_6" field.
        /// </summary>
        public Decimal? Usernum6
        {
            get { return _usernum6; }
            set { _usernum6 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ROOM_BED_TYPE" field.
        /// </summary>
        public String RoomBedType
        {
            get { return _roomBedType; }
            set { _roomBedType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LAY_STD" field.
        /// </summary>
        public Int32? LayStd
        {
            get { return _layStd; }
            set { _layStd = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LAY_THEATER" field.
        /// </summary>
        public Int32? LayTheater
        {
            get { return _layTheater; }
            set { _layTheater = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LAY_INFORMAL" field.
        /// </summary>
        public Int32? LayInformal
        {
            get { return _layInformal; }
            set { _layInformal = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LAY_CLASS" field.
        /// </summary>
        public Int32? LayClass
        {
            get { return _layClass; }
            set { _layClass = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LAY_OTHER" field.
        /// </summary>
        public Int32? LayOther
        {
            get { return _layOther; }
            set { _layOther = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MAX_THEATER" field.
        /// </summary>
        public Double? MaxTheater
        {
            get { return _maxTheater; }
            set { _maxTheater = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MAX_INFORMAL" field.
        /// </summary>
        public Double? MaxInformal
        {
            get { return _maxInformal; }
            set { _maxInformal = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MAX_CLASS" field.
        /// </summary>
        public Double? MaxClass
        {
            get { return _maxClass; }
            set { _maxClass = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MAX_OTHER" field.
        /// </summary>
        public Double? MaxOther
        {
            get { return _maxOther; }
            set { _maxOther = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PRICE_BAND" field.
        /// </summary>
        public String PriceBand
        {
            get { return _priceBand; }
            set { _priceBand = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SLTY_ID" field.
        /// </summary>
        public String SltyId
        {
            get { return _sltyId; }
            set { _sltyId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_KEYWORDS" field.
        /// </summary>
        public String Keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LMS_NAME" field.
        /// </summary>
        public String LmsName
        {
            get { return _lmsName; }
            set { _lmsName = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EL_SELF_APRV" field.
        /// </summary>
        public Byte? ElSelfAprv
        {
            get { return _elSelfAprv; }
            set { _elSelfAprv = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CUT_PRD" field.
        /// </summary>
        public Int32? CutPrd
        {
            get { return _cutPrd; }
            set { _cutPrd = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RENEWAL_MONTH" field.
        /// </summary>
        public String RenewalMonth
        {
            get { return _renewalMonth; }
            set { _renewalMonth = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RENEWAL_DAY" field.
        /// </summary>
        public String RenewalDay
        {
            get { return _renewalDay; }
            set { _renewalDay = value; }
        }

        /// <summary>
        ///     the value of the "PROD_FIXED_RENEWAL" field.
        /// </summary>
        public Byte? FixedRenewal
        {
            get { return _fixedRenewal; }
            set { _fixedRenewal = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EXCL_DAY" field.
        /// </summary>
        public String ExclDay
        {
            get { return _exclDay; }
            set { _exclDay = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EXCL_CALC" field.
        /// </summary>
        public Byte? ExclCalc
        {
            get { return _exclCalc; }
            set { _exclCalc = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SG_NO" field.
        /// </summary>
        public Int32? SgNo
        {
            get { return _sgNo; }
            set { _sgNo = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_APP" field.
        /// </summary>
        public String MsApp
        {
            get { return _msApp; }
            set { _msApp = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MS_OFF" field.
        /// </summary>
        public String MsOff
        {
            get { return _msOff; }
            set { _msOff = value; }
        }

        /// <summary>
        ///     the value of the "PROD_FUNDED" field.
        /// </summary>
        public Byte? Funded
        {
            get { return _funded; }
            set { _funded = value; }
        }

        /// <summary>
        ///     the value of the "PROD_FUNDED_ORG_ID" field.
        /// </summary>
        public String FundedOrgId
        {
            get { return _fundedOrgId; }
            set { _fundedOrgId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_QUAL_DEL" field.
        /// </summary>
        public Byte? QualDel
        {
            get { return _qualDel; }
            set { _qualDel = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BREAK_MUST_EXIST" field.
        /// </summary>
        public Byte? BreakMustExist
        {
            get { return _breakMustExist; }
            set { _breakMustExist = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BD_PREP_BY" field.
        /// </summary>
        public String BdPrepBy
        {
            get { return _bdPrepBy; }
            set { _bdPrepBy = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BD_PREP_DATE" field.
        /// </summary>
        public DateTime? BdPrepDate
        {
            get { return _bdPrepDate; }
            set { _bdPrepDate = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BD_STATUS" field.
        /// </summary>
        public String BdStatus
        {
            get { return _bdStatus; }
            set { _bdStatus = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BD_APP_BY" field.
        /// </summary>
        public String BdAppBy
        {
            get { return _bdAppBy; }
            set { _bdAppBy = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BD_APP_DATE" field.
        /// </summary>
        public DateTime? BdAppDate
        {
            get { return _bdAppDate; }
            set { _bdAppDate = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BD_TOT_EST_COST" field.
        /// </summary>
        public Decimal? BdTotEstCost
        {
            get { return _bdTotEstCost; }
            set { _bdTotEstCost = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NO_INV_RENEW" field.
        /// </summary>
        public Byte? NoInvRenew
        {
            get { return _noInvRenew; }
            set { _noInvRenew = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CALC_COMMISSION" field.
        /// </summary>
        public Byte? CalcCommission
        {
            get { return _calcCommission; }
            set { _calcCommission = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REGION" field.
        /// </summary>
        public String Region
        {
            get { return _region; }
            set { _region = value; }
        }

        /// <summary>
        ///     the value of the "PROD_STATIC_RESOURSE" field.
        /// </summary>
        public Byte? StaticResourse
        {
            get { return _staticResourse; }
            set { _staticResourse = value; }
        }

        /// <summary>
        ///     the value of the "PROD_POOLED_RESOURSE" field.
        /// </summary>
        public Byte? PooledResourse
        {
            get { return _pooledResourse; }
            set { _pooledResourse = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CLASH_CHECK" field.
        /// </summary>
        public Byte? ClashCheck
        {
            get { return _clashCheck; }
            set { _clashCheck = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DEF_TRAINEE_DAYS" field.
        /// </summary>
        public Decimal? DefTraineeDays
        {
            get { return _defTraineeDays; }
            set { _defTraineeDays = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GRANT_ELIGIBLE" field.
        /// </summary>
        public Byte? GrantEligible
        {
            get { return _grantEligible; }
            set { _grantEligible = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GRANT_VALUE_AVAILABLE" field.
        /// </summary>
        public Decimal? GrantValueAvailable
        {
            get { return _grantValueAvailable; }
            set { _grantValueAvailable = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BREAKEVEN_1" field.
        /// </summary>
        public Decimal? Breakeven1
        {
            get { return _breakeven1; }
            set { _breakeven1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BREAKEVEN_2" field.
        /// </summary>
        public Decimal? Breakeven2
        {
            get { return _breakeven2; }
            set { _breakeven2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EXT_COURSEWARE" field.
        /// </summary>
        public Byte? ExtCourseware
        {
            get { return _extCourseware; }
            set { _extCourseware = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CONTINGENCY" field.
        /// </summary>
        public Int32? Contingency
        {
            get { return _contingency; }
            set { _contingency = value; }
        }

        /// <summary>
        ///     the value of the "PROD_COST" field.
        /// </summary>
        public Decimal? Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DELIVERY_DAY" field.
        /// </summary>
        public Int32? DeliveryDay
        {
            get { return _deliveryDay; }
            set { _deliveryDay = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EXT_URL" field.
        /// </summary>
        public String ExtUrl
        {
            get { return _extUrl; }
            set { _extUrl = value; }
        }

        /// <summary>
        ///     the value of the "PROD_USE_EXT_URL" field.
        /// </summary>
        public Byte? UseExtUrl
        {
            get { return _useExtUrl; }
            set { _useExtUrl = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REF_NO" field.
        /// </summary>
        public Int32? RefNo
        {
            get { return _refNo; }
            set { _refNo = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PREFIX" field.
        /// </summary>
        public String Prefix
        {
            get { return _prefix; }
            set { _prefix = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NONE_CHARGEABLE" field.
        /// </summary>
        public Byte NoneChargeable
        {
            get { return _noneChargeable; }
            set { _noneChargeable = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RULE_INC_FAMILY" field.
        /// </summary>
        public Byte RuleIncFamily
        {
            get { return _ruleIncFamily; }
            set { _ruleIncFamily = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DONATION" field.
        /// </summary>
        public Byte? Donation
        {
            get { return _donation; }
            set { _donation = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RENEW" field.
        /// </summary>
        public Byte? Renew
        {
            get { return _renew; }
            set { _renew = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RENEWABLE" field.
        /// </summary>
        public Byte Renewable
        {
            get { return _renewable; }
            set { _renewable = value; }
        }

        /// <summary>
        ///     the value of the "PROD_COURSE_NOTES_TEXT_ID" field.
        /// </summary>
        public String CourseNotesTextId
        {
            get { return _courseNotesTextId; }
            set { _courseNotesTextId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DESIG_LETTERS" field.
        /// </summary>
        public String DesigLetters
        {
            get { return _desigLetters; }
            set { _desigLetters = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NON_RENEW_MEMB" field.
        /// </summary>
        public Byte NonRenewMemb
        {
            get { return _nonRenewMemb; }
            set { _nonRenewMemb = value; }
        }

        /// <summary>
        ///     the value of the "PROD_AGE_RESTRICTION_1" field.
        /// </summary>
        public Int32? AgeRestriction1
        {
            get { return _ageRestriction1; }
            set { _ageRestriction1 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_AGE_RESTRICTION_2" field.
        /// </summary>
        public Int32? AgeRestriction2
        {
            get { return _ageRestriction2; }
            set { _ageRestriction2 = value; }
        }

        /// <summary>
        ///     the value of the "PROD_RESTRICT_TYPE" field.
        /// </summary>
        public String RestrictType
        {
            get { return _restrictType; }
            set { _restrictType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EXPIRY_DATE" field.
        /// </summary>
        public DateTime? ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }

        /// <summary>
        ///     the value of the "PROD_INV_ZERO_VAL" field.
        /// </summary>
        public Int32 InvZeroVal
        {
            get { return _invZeroVal; }
            set { _invZeroVal = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CREDIT_HOURS" field.
        /// </summary>
        public Decimal CreditHours
        {
            get { return _creditHours; }
            set { _creditHours = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        public Int32? DdNoOfInstallments
        {
            get { return _ddNoOfInstallments; }
            set { _ddNoOfInstallments = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DD_FREQUENCY" field.
        /// </summary>
        public Int32? DdFrequency
        {
            get { return _ddFrequency; }
            set { _ddFrequency = value; }
        }

        /// <summary>
        ///     the value of the "PROD_EXCLUDE_TRAIN_HISTORY" field.
        /// </summary>
        public Byte ExcludeTrainHistory
        {
            get { return _excludeTrainHistory; }
            set { _excludeTrainHistory = value; }
        }

        /// <summary>
        ///     the value of the "PROD_START_DATE_TYPE" field.
        /// </summary>
        public Byte StartDateType
        {
            get { return _startDateType; }
            set { _startDateType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_START_DATE_FIXED" field.
        /// </summary>
        public DateTime? StartDateFixed
        {
            get { return _startDateFixed; }
            set { _startDateFixed = value; }
        }

        /// <summary>
        ///     the value of the "PROD_START_DATE_OFFSET" field.
        /// </summary>
        public Int32 StartDateOffset
        {
            get { return _startDateOffset; }
            set { _startDateOffset = value; }
        }

        /// <summary>
        ///     the value of the "PROD_START_DATE_OFFSET_TYPE" field.
        /// </summary>
        public String StartDateOffsetType
        {
            get { return _startDateOffsetType; }
            set { _startDateOffsetType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_END_DATE_TYPE" field.
        /// </summary>
        public Byte EndDateType
        {
            get { return _endDateType; }
            set { _endDateType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_END_DATE_FIXED" field.
        /// </summary>
        public DateTime? EndDateFixed
        {
            get { return _endDateFixed; }
            set { _endDateFixed = value; }
        }

        /// <summary>
        ///     the value of the "PROD_END_DATE_OFFSET" field.
        /// </summary>
        public Int32 EndDateOffset
        {
            get { return _endDateOffset; }
            set { _endDateOffset = value; }
        }

        /// <summary>
        ///     the value of the "PROD_END_DATE_OFFSET_TYPE" field.
        /// </summary>
        public String EndDateOffsetType
        {
            get { return _endDateOffsetType; }
            set { _endDateOffsetType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DESC_EDITABLE" field.
        /// </summary>
        public Byte DescEditable
        {
            get { return _descEditable; }
            set { _descEditable = value; }
        }

        /// <summary>
        ///     the value of the "PROD_STOCK_TYPE" field.
        /// </summary>
        public String StockType
        {
            get { return _stockType; }
            set { _stockType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_STOCK_EXPECTED_DATE" field.
        /// </summary>
        public String StockExpectedDate
        {
            get { return _stockExpectedDate; }
            set { _stockExpectedDate = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MEM_FIRST_BOOK" field.
        /// </summary>
        public Byte MemFirstBook
        {
            get { return _memFirstBook; }
            set { _memFirstBook = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MIN_SCORE" field.
        /// </summary>
        public Decimal? MinScore
        {
            get { return _minScore; }
            set { _minScore = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SCORE_OUTOF" field.
        /// </summary>
        public Decimal? ScoreOutof
        {
            get { return _scoreOutof; }
            set { _scoreOutof = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GRADE_WEB" field.
        /// </summary>
        public Byte? GradeWeb
        {
            get { return _gradeWeb; }
            set { _gradeWeb = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PREDELIV" field.
        /// </summary>
        public Byte Predeliv
        {
            get { return _predeliv; }
            set { _predeliv = value; }
        }

        /// <summary>
        ///     the value of the "PROD_AUTHOR_NAME" field.
        /// </summary>
        public String AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TOPUP" field.
        /// </summary>
        public Byte? Topup
        {
            get { return _topup; }
            set { _topup = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LIMIT_PL_TYPE" field.
        /// </summary>
        public String LimitPlType
        {
            get { return _limitPlType; }
            set { _limitPlType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PREPAY_UNITS" field.
        /// </summary>
        public Int32? PrepayUnits
        {
            get { return _prepayUnits; }
            set { _prepayUnits = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DELIV_METHOD" field.
        /// </summary>
        public String DelivMethod
        {
            get { return _delivMethod; }
            set { _delivMethod = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LOCKDOWN" field.
        /// </summary>
        public Byte? Lockdown
        {
            get { return _lockdown; }
            set { _lockdown = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PROMOTION" field.
        /// </summary>
        public Byte? Promotion
        {
            get { return _promotion; }
            set { _promotion = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        public String SearchGroup
        {
            get { return _searchGroup; }
            set { _searchGroup = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LIMIT_PL_ID" field.
        /// </summary>
        public String LimitPlId
        {
            get { return _limitPlId; }
            set { _limitPlId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        public String DefElemSt
        {
            get { return _defElemSt; }
            set { _defElemSt = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NEXT_NO" field.
        /// </summary>
        public Int32? NextNo
        {
            get { return _nextNo; }
            set { _nextNo = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SUFFIX" field.
        /// </summary>
        public String Suffix
        {
            get { return _suffix; }
            set { _suffix = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NO_MEMB_DISCOUNT" field.
        /// </summary>
        public Byte NoMembDiscount
        {
            get { return _noMembDiscount; }
            set { _noMembDiscount = value; }
        }

        /// <summary>
        ///     the value of the "PROD_QUEST_ID" field.
        /// </summary>
        public String QuestId
        {
            get { return _questId; }
            set { _questId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SHORT_DESC" field.
        /// </summary>
        public String ShortDesc
        {
            get { return _shortDesc; }
            set { _shortDesc = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ONECLICK_CHECKOUT" field.
        /// </summary>
        public Byte OneclickCheckout
        {
            get { return _oneclickCheckout; }
            set { _oneclickCheckout = value; }
        }

        /// <summary>
        ///     the value of the "PROD_BOOKER_ONLY" field.
        /// </summary>
        public Byte BookerOnly
        {
            get { return _bookerOnly; }
            set { _bookerOnly = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LAY_USHAPE" field.
        /// </summary>
        public Int32? LayUshape
        {
            get { return _layUshape; }
            set { _layUshape = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LAY_BROOM" field.
        /// </summary>
        public Int32? LayBroom
        {
            get { return _layBroom; }
            set { _layBroom = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LAY_BROUT" field.
        /// </summary>
        public Int32? LayBrout
        {
            get { return _layBrout; }
            set { _layBrout = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MAX_USHAPE" field.
        /// </summary>
        public Double? MaxUshape
        {
            get { return _maxUshape; }
            set { _maxUshape = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MAX_BROOM" field.
        /// </summary>
        public Double? MaxBroom
        {
            get { return _maxBroom; }
            set { _maxBroom = value; }
        }

        /// <summary>
        ///     the value of the "PROD_MAX_BROUT" field.
        /// </summary>
        public Double? MaxBrout
        {
            get { return _maxBrout; }
            set { _maxBrout = value; }
        }

        /// <summary>
        ///     the value of the "PROD_WP_NAME" field.
        /// </summary>
        public String WpName
        {
            get { return _wpName; }
            set { _wpName = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DEPT" field.
        /// </summary>
        public String Dept
        {
            get { return _dept; }
            set { _dept = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SKU" field.
        /// </summary>
        public String Sku
        {
            get { return _sku; }
            set { _sku = value; }
        }

        /// <summary>
        ///     the value of the "PROD_JOB_CODE" field.
        /// </summary>
        public String JobCode
        {
            get { return _jobCode; }
            set { _jobCode = value; }
        }

        /// <summary>
        ///     the value of the "PROD_JOB_ANALY_CODE" field.
        /// </summary>
        public String JobAnalyCode
        {
            get { return _jobAnalyCode; }
            set { _jobAnalyCode = value; }
        }

        /// <summary>
        ///     the value of the "PROD_JOB_TYPE" field.
        /// </summary>
        public String JobType
        {
            get { return _jobType; }
            set { _jobType = value; }
        }

        /// <summary>
        ///     the value of the "PROD_JOB_PARENT" field.
        /// </summary>
        public String JobParent
        {
            get { return _jobParent; }
            set { _jobParent = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PSH_ID" field.
        /// </summary>
        public Int32? PshId
        {
            get { return _pshId; }
            set { _pshId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_IMAGE" field.
        /// </summary>
        public String Image
        {
            get { return _image; }
            set { _image = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ONLINE_SCHE" field.
        /// </summary>
        public String OnlineSche
        {
            get { return _onlineSche; }
            set { _onlineSche = value; }
        }

        /// <summary>
        ///     the value of the "PROD_QUOTEBOOK_RATIO" field.
        /// </summary>
        public Int32 QuotebookRatio
        {
            get { return _quotebookRatio; }
            set { _quotebookRatio = value; }
        }

        /// <summary>
        ///     the value of the "PROD_COORDS" field.
        /// </summary>
        public String Coords
        {
            get { return _coords; }
            set { _coords = value; }
        }

        /// <summary>
        ///     the value of the "PROD_URL_NAME" field.
        /// </summary>
        public String UrlName
        {
            get { return _urlName; }
            set { _urlName = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ZERO_PAD" field.
        /// </summary>
        public Int32? ZeroPad
        {
            get { return _zeroPad; }
            set { _zeroPad = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TRAIN_PROV" field.
        /// </summary>
        public Byte? TrainProv
        {
            get { return _trainProv; }
            set { _trainProv = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REORDER_LEV" field.
        /// </summary>
        public Byte? ReorderLev
        {
            get { return _reorderLev; }
            set { _reorderLev = value; }
        }

        /// <summary>
        ///     the value of the "PROD_LICENSED" field.
        /// </summary>
        public Byte Licensed
        {
            get { return _licensed; }
            set { _licensed = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DEL_CLOSE_DAYS" field.
        /// </summary>
        public Int32 DelCloseDays
        {
            get { return _delCloseDays; }
            set { _delCloseDays = value; }
        }

        /// <summary>
        ///     the value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        public String TrnRulesTxt
        {
            get { return _trnRulesTxt; }
            set { _trnRulesTxt = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CERT_DEF_DELIVER" field.
        /// </summary>
        public Byte CertDefDeliver
        {
            get { return _certDefDeliver; }
            set { _certDefDeliver = value; }
        }

        /// <summary>
        ///     the value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        public String DefMethDel
        {
            get { return _defMethDel; }
            set { _defMethDel = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CERT_TEMP_LTT_ID" field.
        /// </summary>
        public String CertTempLttId
        {
            get { return _certTempLttId; }
            set { _certTempLttId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_REORDER_LEAD" field.
        /// </summary>
        public Int32? ReorderLead
        {
            get { return _reorderLead; }
            set { _reorderLead = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NOM_MEM_DET" field.
        /// </summary>
        public String NomMemDet
        {
            get { return _nomMemDet; }
            set { _nomMemDet = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NOM_MEM_REQ" field.
        /// </summary>
        public Byte? NomMemReq
        {
            get { return _nomMemReq; }
            set { _nomMemReq = value; }
        }

        /// <summary>
        ///     the value of the "PROD_NOM_MEM_PROD_ID" field.
        /// </summary>
        public String NomMemProdId
        {
            get { return _nomMemProdId; }
            set { _nomMemProdId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PACK_SEND_PROLE_ID" field.
        /// </summary>
        public String PackSendProleId
        {
            get { return _packSendProleId; }
            set { _packSendProleId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PACK_BCC_EMAIL" field.
        /// </summary>
        public String PackBccEmail
        {
            get { return _packBccEmail; }
            set { _packBccEmail = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PACK_MDN_EMAIL" field.
        /// </summary>
        public String PackMdnEmail
        {
            get { return _packMdnEmail; }
            set { _packMdnEmail = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PACK_DSN_EMAIL" field.
        /// </summary>
        public String PackDsnEmail
        {
            get { return _packDsnEmail; }
            set { _packDsnEmail = value; }
        }

        /// <summary>
        ///     the value of the "PROD_PACK_DSN_OPTIONS" field.
        /// </summary>
        public String PackDsnOptions
        {
            get { return _packDsnOptions; }
            set { _packDsnOptions = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        public String CodeImage
        {
            get { return _codeImage; }
            set { _codeImage = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        public String GatewayAccId
        {
            get { return _gatewayAccId; }
            set { _gatewayAccId = value; }
        }

        /// <summary>
        ///     the value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        public String RoyaltyModel
        {
            get { return _royaltyModel; }
            set { _royaltyModel = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SESSIONS_DESCRIPTION" field.
        /// </summary>
        public String SessionsDescription
        {
            get { return _sessionsDescription; }
            set { _sessionsDescription = value; }
        }

        /// <summary>
        ///     the value of the "PROD_SESSIONS_HEADER" field.
        /// </summary>
        public String SessionsHeader
        {
            get { return _sessionsHeader; }
            set { _sessionsHeader = value; }
        }

        /// <summary>
        ///     the value of the "PROD_CUT_PRD_TIME" field.
        /// </summary>
        public Byte? CutPrdTime
        {
            get { return _cutPrdTime; }
            set { _cutPrdTime = value; }
        }

        /// <summary>
        ///     the value of the "PROD_GIFTAID" field.
        /// </summary>
        public Byte? Giftaid
        {
            get { return _giftaid; }
            set { _giftaid = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ProductRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ProductRecord" /> object instance.
        /// </returns>
        public ProductRecord Clone()
        {
            ProductRecord record = new ProductRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.GroupId = this.GroupId;
            record.Ref = this.Ref;
            record.Name = this.Name;
            record.Descrip = this.Descrip;
            record.Text1 = this.Text1;
            record.Text2 = this.Text2;
            record.Text3 = this.Text3;
            record.Text4 = this.Text4;
            record.Text5 = this.Text5;
            record.SyProduct = this.SyProduct;
            record.Type = this.Type;
            record.Category = this.Category;
            record.Status = this.Status;
            record.Group = this.Group;
            record.Unit = this.Unit;
            record.Price = this.Price;
            record.BlockPrice = this.BlockPrice;
            record.SparePrice = this.SparePrice;
            record.CostPrice = this.CostPrice;
            record.CostCode = this.CostCode;
            record.RevCode = this.RevCode;
            record.DiscSched = this.DiscSched;
            record.VatCode = this.VatCode;
            record.MinAttend = this.MinAttend;
            record.MaxAttend = this.MaxAttend;
            record.CourseLen = this.CourseLen;
            record.DiaryType = this.DiaryType;
            record.NormCollege = this.NormCollege;
            record.NextCourse = this.NextCourse;
            record.SpareFlag1 = this.SpareFlag1;
            record.SpareFlag2 = this.SpareFlag2;
            record.CertPrinted = this.CertPrinted;
            record.TucRegion = this.TucRegion;
            record.EntryDate = this.EntryDate;
            record.ProjectNo = this.ProjectNo;
            record.CommissionBy = this.CommissionBy;
            record.Key = this.Key;
            record.Code = this.Code;
            record.TypeLow = this.TypeLow;
            record.RefLow = this.RefLow;
            record.QuesSet = this.QuesSet;
            record.StartQno = this.StartQno;
            record.SellHint = this.SellHint;
            record.Det = this.Det;
            record.Ass = this.Ass;
            record.RetailPrice = this.RetailPrice;
            record.Margin = this.Margin;
            record.SupplierName = this.SupplierName;
            record.SupplierId = this.SupplierId;
            record.PicId = this.PicId;
            record.JoinLett = this.JoinLett;
            record.ConfirmLett = this.ConfirmLett;
            record.QuestLett = this.QuestLett;
            record.SurvLett = this.SurvLett;
            record.NoCstNoSel = this.NoCstNoSel;
            record.ProvLett = this.ProvLett;
            record.InvLett = this.InvLett;
            record.DoNotInvoic = this.DoNotInvoic;
            record.TopLevel = this.TopLevel;
            record.AddId = this.AddId;
            record.RoomType = this.RoomType;
            record.RoomGrade = this.RoomGrade;
            record.State = this.State;
            record.Stocked = this.Stocked;
            record.QtyAv = this.QtyAv;
            record.QtyAc = this.QtyAc;
            record.QtyBo = this.QtyBo;
            record.QtyOr = this.QtyOr;
            record.Coursemaster = this.Coursemaster;
            record.Currency = this.Currency;
            record.LastUsed = this.LastUsed;
            record.DailyDelRat = this.DailyDelRat;
            record.OvernightRat = this.OvernightRat;
            record.SyndicateRat = this.SyndicateRat;
            record.Equip1 = this.Equip1;
            record.Equip2 = this.Equip2;
            record.Equip3 = this.Equip3;
            record.Equip4 = this.Equip4;
            record.Equip5 = this.Equip5;
            record.Equip6 = this.Equip6;
            record.Equip7 = this.Equip7;
            record.Equip8 = this.Equip8;
            record.Equip9 = this.Equip9;
            record.Equip10 = this.Equip10;
            record.Equip11 = this.Equip11;
            record.Equip12 = this.Equip12;
            record.Equip13 = this.Equip13;
            record.Equip14 = this.Equip14;
            record.Equip15 = this.Equip15;
            record.Generalised = this.Generalised;
            record.NetwType = this.NetwType;
            record.RenType = this.RenType;
            record.OldDesc = this.OldDesc;
            record.Class = this.Class;
            record.TiCode = this.TiCode;
            record.DepReps = this.DepReps;
            record.LeadDept = this.LeadDept;
            record.Current = this.Current;
            record.Media = this.Media;
            record.MaxDisc = this.MaxDisc;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Usernum1 = this.Usernum1;
            record.AvailDate = this.AvailDate;
            record.CertFmt = this.CertFmt;
            record.CertName = this.CertName;
            record.LsePrinted = this.LsePrinted;
            record.ReqFreqcy = this.ReqFreqcy;
            record.AdmTxtId = this.AdmTxtId;
            record.TrnTxtId = this.TrnTxtId;
            record.EnqQstId = this.EnqQstId;
            record.DelQstId = this.DelQstId;
            record.ProvPack = this.ProvPack;
            record.ConfPack = this.ConfPack;
            record.JoiningPack = this.JoiningPack;
            record.PostPack = this.PostPack;
            record.ProvInv = this.ProvInv;
            record.ConfInv = this.ConfInv;
            record.JoinInv = this.JoinInv;
            record.PostInv = this.PostInv;
            record.MstcType = this.MstcType;
            record.Overbook = this.Overbook;
            record.Commission = this.Commission;
            record.PlanId = this.PlanId;
            record.PlanName = this.PlanName;
            record.NoHours = this.NoHours;
            record.ExpiryMonths = this.ExpiryMonths;
            record.Places = this.Places;
            record.PrePayType = this.PrePayType;
            record.Grades = this.Grades;
            record.ProleId = this.ProleId;
            record.ManProleId = this.ManProleId;
            record.Level = this.Level;
            record.Serialised = this.Serialised;
            record.Url = this.Url;
            record.ValToRevPc = this.ValToRevPc;
            record.BktId = this.BktId;
            record.BtId = this.BtId;
            record.Name2 = this.Name2;
            record.GlCode1 = this.GlCode1;
            record.GlCode2 = this.GlCode2;
            record.Resourse = this.Resourse;
            record.LocId = this.LocId;
            record.Web = this.Web;
            record.DescFile = this.DescFile;
            record.Userchar3 = this.Userchar3;
            record.Userint1 = this.Userint1;
            record.Userint2 = this.Userint2;
            record.Userint3 = this.Userint3;
            record.Userint4 = this.Userint4;
            record.Userdate1 = this.Userdate1;
            record.Userint5 = this.Userint5;
            record.Usernum2 = this.Usernum2;
            record.Userint6 = this.Userint6;
            record.Userchar4 = this.Userchar4;
            record.Userchar5 = this.Userchar5;
            record.Usernum3 = this.Usernum3;
            record.Usernum4 = this.Usernum4;
            record.Usernum5 = this.Usernum5;
            record.Userint7 = this.Userint7;
            record.Userint8 = this.Userint8;
            record.Userint9 = this.Userint9;
            record.MembPrcGrp = this.MembPrcGrp;
            record.ScoManifXml = this.ScoManifXml;
            record.ProdQuantity = this.ProdQuantity;
            record.NonScorm = this.NonScorm;
            record.MsNew = this.MsNew;
            record.MsRemind1 = this.MsRemind1;
            record.MsRemind2 = this.MsRemind2;
            record.MsRenew = this.MsRenew;
            record.MsLapsed = this.MsLapsed;
            record.MsCancel = this.MsCancel;
            record.MsGroup = this.MsGroup;
            record.RenewDays = this.RenewDays;
            record.SelcoSpId = this.SelcoSpId;
            record.MemInvType = this.MemInvType;
            record.AuthPnId = this.AuthPnId;
            record.Isbn = this.Isbn;
            record.PageCount = this.PageCount;
            record.MsRemind3 = this.MsRemind3;
            record.MsRm1Days = this.MsRm1Days;
            record.MsRm2Days = this.MsRm2Days;
            record.MsRm3Days = this.MsRm3Days;
            record.MsLapsDays = this.MsLapsDays;
            record.Freq = this.Freq;
            record.DescFileY = this.DescFileY;
            record.MsRenewed = this.MsRenewed;
            record.RegBodyId1 = this.RegBodyId1;
            record.RegBodyId2 = this.RegBodyId2;
            record.Userchar6 = this.Userchar6;
            record.UDate1 = this.UDate1;
            record.UDate2 = this.UDate2;
            record.UDate3 = this.UDate3;
            record.UDate4 = this.UDate4;
            record.UDate5 = this.UDate5;
            record.UDate6 = this.UDate6;
            record.Usernum6 = this.Usernum6;
            record.RoomBedType = this.RoomBedType;
            record.LayStd = this.LayStd;
            record.LayTheater = this.LayTheater;
            record.LayInformal = this.LayInformal;
            record.LayClass = this.LayClass;
            record.LayOther = this.LayOther;
            record.MaxTheater = this.MaxTheater;
            record.MaxInformal = this.MaxInformal;
            record.MaxClass = this.MaxClass;
            record.MaxOther = this.MaxOther;
            record.PriceBand = this.PriceBand;
            record.SltyId = this.SltyId;
            record.Keywords = this.Keywords;
            record.LmsName = this.LmsName;
            record.ElSelfAprv = this.ElSelfAprv;
            record.CutPrd = this.CutPrd;
            record.RenewalMonth = this.RenewalMonth;
            record.RenewalDay = this.RenewalDay;
            record.FixedRenewal = this.FixedRenewal;
            record.ExclDay = this.ExclDay;
            record.ExclCalc = this.ExclCalc;
            record.SgNo = this.SgNo;
            record.MsApp = this.MsApp;
            record.MsOff = this.MsOff;
            record.Funded = this.Funded;
            record.FundedOrgId = this.FundedOrgId;
            record.QualDel = this.QualDel;
            record.BreakMustExist = this.BreakMustExist;
            record.OrgId = this.OrgId;
            record.BdPrepBy = this.BdPrepBy;
            record.BdPrepDate = this.BdPrepDate;
            record.BdStatus = this.BdStatus;
            record.BdAppBy = this.BdAppBy;
            record.BdAppDate = this.BdAppDate;
            record.BdTotEstCost = this.BdTotEstCost;
            record.NoInvRenew = this.NoInvRenew;
            record.CalcCommission = this.CalcCommission;
            record.Region = this.Region;
            record.StaticResourse = this.StaticResourse;
            record.PooledResourse = this.PooledResourse;
            record.ClashCheck = this.ClashCheck;
            record.DefTraineeDays = this.DefTraineeDays;
            record.GrantEligible = this.GrantEligible;
            record.GrantValueAvailable = this.GrantValueAvailable;
            record.Breakeven1 = this.Breakeven1;
            record.Breakeven2 = this.Breakeven2;
            record.ExtCourseware = this.ExtCourseware;
            record.Contingency = this.Contingency;
            record.Cost = this.Cost;
            record.DeliveryDay = this.DeliveryDay;
            record.ExtUrl = this.ExtUrl;
            record.UseExtUrl = this.UseExtUrl;
            record.RefNo = this.RefNo;
            record.Prefix = this.Prefix;
            record.NoneChargeable = this.NoneChargeable;
            record.RuleIncFamily = this.RuleIncFamily;
            record.Donation = this.Donation;
            record.Renew = this.Renew;
            record.Renewable = this.Renewable;
            record.CourseNotesTextId = this.CourseNotesTextId;
            record.DesigLetters = this.DesigLetters;
            record.NonRenewMemb = this.NonRenewMemb;
            record.AgeRestriction1 = this.AgeRestriction1;
            record.AgeRestriction2 = this.AgeRestriction2;
            record.RestrictType = this.RestrictType;
            record.ExpiryDate = this.ExpiryDate;
            record.InvZeroVal = this.InvZeroVal;
            record.CreditHours = this.CreditHours;
            record.DdNoOfInstallments = this.DdNoOfInstallments;
            record.DdFrequency = this.DdFrequency;
            record.ExcludeTrainHistory = this.ExcludeTrainHistory;
            record.StartDateType = this.StartDateType;
            record.StartDateFixed = this.StartDateFixed;
            record.StartDateOffset = this.StartDateOffset;
            record.StartDateOffsetType = this.StartDateOffsetType;
            record.EndDateType = this.EndDateType;
            record.EndDateFixed = this.EndDateFixed;
            record.EndDateOffset = this.EndDateOffset;
            record.EndDateOffsetType = this.EndDateOffsetType;
            record.DescEditable = this.DescEditable;
            record.StockType = this.StockType;
            record.StockExpectedDate = this.StockExpectedDate;
            record.MemFirstBook = this.MemFirstBook;
            record.MinScore = this.MinScore;
            record.ScoreOutof = this.ScoreOutof;
            record.GradeWeb = this.GradeWeb;
            record.Predeliv = this.Predeliv;
            record.AuthorName = this.AuthorName;
            record.Topup = this.Topup;
            record.LimitPlType = this.LimitPlType;
            record.PrepayUnits = this.PrepayUnits;
            record.DelivMethod = this.DelivMethod;
            record.Lockdown = this.Lockdown;
            record.Promotion = this.Promotion;
            record.SearchGroup = this.SearchGroup;
            record.LimitPlId = this.LimitPlId;
            record.DefElemSt = this.DefElemSt;
            record.NextNo = this.NextNo;
            record.Suffix = this.Suffix;
            record.NoMembDiscount = this.NoMembDiscount;
            record.QuestId = this.QuestId;
            record.ShortDesc = this.ShortDesc;
            record.OneclickCheckout = this.OneclickCheckout;
            record.BookerOnly = this.BookerOnly;
            record.LayUshape = this.LayUshape;
            record.LayBroom = this.LayBroom;
            record.LayBrout = this.LayBrout;
            record.MaxUshape = this.MaxUshape;
            record.MaxBroom = this.MaxBroom;
            record.MaxBrout = this.MaxBrout;
            record.WpName = this.WpName;
            record.Dept = this.Dept;
            record.Sku = this.Sku;
            record.JobCode = this.JobCode;
            record.JobAnalyCode = this.JobAnalyCode;
            record.JobType = this.JobType;
            record.JobParent = this.JobParent;
            record.PshId = this.PshId;
            record.Image = this.Image;
            record.OnlineSche = this.OnlineSche;
            record.QuotebookRatio = this.QuotebookRatio;
            record.Coords = this.Coords;
            record.UrlName = this.UrlName;
            record.ZeroPad = this.ZeroPad;
            record.TrainProv = this.TrainProv;
            record.ReorderLev = this.ReorderLev;
            record.Licensed = this.Licensed;
            record.DelCloseDays = this.DelCloseDays;
            record.TrnRulesTxt = this.TrnRulesTxt;
            record.CertDefDeliver = this.CertDefDeliver;
            record.DefMethDel = this.DefMethDel;
            record.CertTempLttId = this.CertTempLttId;
            record.ReorderLead = this.ReorderLead;
            record.NomMemDet = this.NomMemDet;
            record.NomMemReq = this.NomMemReq;
            record.NomMemProdId = this.NomMemProdId;
            record.PackSendProleId = this.PackSendProleId;
            record.PackBccEmail = this.PackBccEmail;
            record.PackMdnEmail = this.PackMdnEmail;
            record.PackDsnEmail = this.PackDsnEmail;
            record.PackDsnOptions = this.PackDsnOptions;
            record.CodeImage = this.CodeImage;
            record.GatewayAccId = this.GatewayAccId;
            record.RoyaltyModel = this.RoyaltyModel;
            record.SessionsDescription = this.SessionsDescription;
            record.SessionsHeader = this.SessionsHeader;
            record.CutPrdTime = this.CutPrdTime;
            record.Giftaid = this.Giftaid;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ProductRecord" /> instance is equal to another <see cref="ProductRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ProductRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ProductRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.GroupId.TrimOrNullify() == that.GroupId.TrimOrNullify());
            result = result && (this.Ref.TrimOrNullify() == that.Ref.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Descrip.TrimOrNullify() == that.Descrip.TrimOrNullify());
            result = result && (this.Text1.TrimOrNullify() == that.Text1.TrimOrNullify());
            result = result && (this.Text2.TrimOrNullify() == that.Text2.TrimOrNullify());
            result = result && (this.Text3.TrimOrNullify() == that.Text3.TrimOrNullify());
            result = result && (this.Text4.TrimOrNullify() == that.Text4.TrimOrNullify());
            result = result && (this.Text5.TrimOrNullify() == that.Text5.TrimOrNullify());
            result = result && (this.SyProduct == that.SyProduct);
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Category.TrimOrNullify() == that.Category.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Group.TrimOrNullify() == that.Group.TrimOrNullify());
            result = result && (this.Unit.TrimOrNullify() == that.Unit.TrimOrNullify());
            result = result && (this.Price == that.Price);
            result = result && (this.BlockPrice == that.BlockPrice);
            result = result && (this.SparePrice == that.SparePrice);
            result = result && (this.CostPrice == that.CostPrice);
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.RevCode.TrimOrNullify() == that.RevCode.TrimOrNullify());
            result = result && (this.DiscSched.TrimOrNullify() == that.DiscSched.TrimOrNullify());
            result = result && (this.VatCode.TrimOrNullify() == that.VatCode.TrimOrNullify());
            result = result && (this.MinAttend == that.MinAttend);
            result = result && (this.MaxAttend == that.MaxAttend);
            result = result && (this.CourseLen == that.CourseLen);
            result = result && (this.DiaryType.TrimOrNullify() == that.DiaryType.TrimOrNullify());
            result = result && (this.NormCollege.TrimOrNullify() == that.NormCollege.TrimOrNullify());
            result = result && (this.NextCourse.TrimOrNullify() == that.NextCourse.TrimOrNullify());
            result = result && (this.SpareFlag1 == that.SpareFlag1);
            result = result && (this.SpareFlag2 == that.SpareFlag2);
            result = result && (this.CertPrinted == that.CertPrinted);
            result = result && (this.TucRegion.TrimOrNullify() == that.TucRegion.TrimOrNullify());
            result = result && (this.EntryDate == that.EntryDate);
            result = result && (this.ProjectNo.TrimOrNullify() == that.ProjectNo.TrimOrNullify());
            result = result && (this.CommissionBy.TrimOrNullify() == that.CommissionBy.TrimOrNullify());
            result = result && (this.Key.TrimOrNullify() == that.Key.TrimOrNullify());
            result = result && (this.Code.TrimOrNullify() == that.Code.TrimOrNullify());
            result = result && (this.TypeLow.TrimOrNullify() == that.TypeLow.TrimOrNullify());
            result = result && (this.RefLow.TrimOrNullify() == that.RefLow.TrimOrNullify());
            result = result && (this.QuesSet == that.QuesSet);
            result = result && (this.StartQno == that.StartQno);
            result = result && (this.SellHint.TrimOrNullify() == that.SellHint.TrimOrNullify());
            result = result && (this.Det.TrimOrNullify() == that.Det.TrimOrNullify());
            result = result && (this.Ass.TrimOrNullify() == that.Ass.TrimOrNullify());
            result = result && (this.RetailPrice == that.RetailPrice);
            result = result && (this.Margin == that.Margin);
            result = result && (this.SupplierName.TrimOrNullify() == that.SupplierName.TrimOrNullify());
            result = result && (this.SupplierId.TrimOrNullify() == that.SupplierId.TrimOrNullify());
            result = result && (this.PicId.TrimOrNullify() == that.PicId.TrimOrNullify());
            result = result && (this.JoinLett.TrimOrNullify() == that.JoinLett.TrimOrNullify());
            result = result && (this.ConfirmLett.TrimOrNullify() == that.ConfirmLett.TrimOrNullify());
            result = result && (this.QuestLett.TrimOrNullify() == that.QuestLett.TrimOrNullify());
            result = result && (this.SurvLett.TrimOrNullify() == that.SurvLett.TrimOrNullify());
            result = result && (this.NoCstNoSel == that.NoCstNoSel);
            result = result && (this.ProvLett.TrimOrNullify() == that.ProvLett.TrimOrNullify());
            result = result && (this.InvLett.TrimOrNullify() == that.InvLett.TrimOrNullify());
            result = result && (this.DoNotInvoic == that.DoNotInvoic);
            result = result && (this.TopLevel == that.TopLevel);
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.RoomType.TrimOrNullify() == that.RoomType.TrimOrNullify());
            result = result && (this.RoomGrade.TrimOrNullify() == that.RoomGrade.TrimOrNullify());
            result = result && (this.State == that.State);
            result = result && (this.Stocked == that.Stocked);
            result = result && (this.QtyAv == that.QtyAv);
            result = result && (this.QtyAc == that.QtyAc);
            result = result && (this.QtyBo == that.QtyBo);
            result = result && (this.QtyOr == that.QtyOr);
            result = result && (this.Coursemaster == that.Coursemaster);
            result = result && (this.Currency.TrimOrNullify() == that.Currency.TrimOrNullify());
            result = result && (this.LastUsed == that.LastUsed);
            result = result && (this.DailyDelRat == that.DailyDelRat);
            result = result && (this.OvernightRat == that.OvernightRat);
            result = result && (this.SyndicateRat == that.SyndicateRat);
            result = result && (this.Equip1 == that.Equip1);
            result = result && (this.Equip2 == that.Equip2);
            result = result && (this.Equip3 == that.Equip3);
            result = result && (this.Equip4 == that.Equip4);
            result = result && (this.Equip5 == that.Equip5);
            result = result && (this.Equip6 == that.Equip6);
            result = result && (this.Equip7 == that.Equip7);
            result = result && (this.Equip8 == that.Equip8);
            result = result && (this.Equip9 == that.Equip9);
            result = result && (this.Equip10 == that.Equip10);
            result = result && (this.Equip11 == that.Equip11);
            result = result && (this.Equip12 == that.Equip12);
            result = result && (this.Equip13 == that.Equip13);
            result = result && (this.Equip14 == that.Equip14);
            result = result && (this.Equip15 == that.Equip15);
            result = result && (this.Generalised == that.Generalised);
            result = result && (this.NetwType.TrimOrNullify() == that.NetwType.TrimOrNullify());
            result = result && (this.RenType.TrimOrNullify() == that.RenType.TrimOrNullify());
            result = result && (this.OldDesc.TrimOrNullify() == that.OldDesc.TrimOrNullify());
            result = result && (this.Class.TrimOrNullify() == that.Class.TrimOrNullify());
            result = result && (this.TiCode.TrimOrNullify() == that.TiCode.TrimOrNullify());
            result = result && (this.DepReps.TrimOrNullify() == that.DepReps.TrimOrNullify());
            result = result && (this.LeadDept == that.LeadDept);
            result = result && (this.Current.TrimOrNullify() == that.Current.TrimOrNullify());
            result = result && (this.Media.TrimOrNullify() == that.Media.TrimOrNullify());
            result = result && (this.MaxDisc == that.MaxDisc);
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.AvailDate == that.AvailDate);
            result = result && (this.CertFmt.TrimOrNullify() == that.CertFmt.TrimOrNullify());
            result = result && (this.CertName.TrimOrNullify() == that.CertName.TrimOrNullify());
            result = result && (this.LsePrinted == that.LsePrinted);
            result = result && (this.ReqFreqcy == that.ReqFreqcy);
            result = result && (this.AdmTxtId.TrimOrNullify() == that.AdmTxtId.TrimOrNullify());
            result = result && (this.TrnTxtId.TrimOrNullify() == that.TrnTxtId.TrimOrNullify());
            result = result && (this.EnqQstId.TrimOrNullify() == that.EnqQstId.TrimOrNullify());
            result = result && (this.DelQstId.TrimOrNullify() == that.DelQstId.TrimOrNullify());
            result = result && (this.ProvPack.TrimOrNullify() == that.ProvPack.TrimOrNullify());
            result = result && (this.ConfPack.TrimOrNullify() == that.ConfPack.TrimOrNullify());
            result = result && (this.JoiningPack.TrimOrNullify() == that.JoiningPack.TrimOrNullify());
            result = result && (this.PostPack.TrimOrNullify() == that.PostPack.TrimOrNullify());
            result = result && (this.ProvInv == that.ProvInv);
            result = result && (this.ConfInv == that.ConfInv);
            result = result && (this.JoinInv == that.JoinInv);
            result = result && (this.PostInv == that.PostInv);
            result = result && (this.MstcType.TrimOrNullify() == that.MstcType.TrimOrNullify());
            result = result && (this.Overbook == that.Overbook);
            result = result && (this.Commission == that.Commission);
            result = result && (this.PlanId.TrimOrNullify() == that.PlanId.TrimOrNullify());
            result = result && (this.PlanName.TrimOrNullify() == that.PlanName.TrimOrNullify());
            result = result && (this.NoHours == that.NoHours);
            result = result && (this.ExpiryMonths == that.ExpiryMonths);
            result = result && (this.Places == that.Places);
            result = result && (this.PrePayType.TrimOrNullify() == that.PrePayType.TrimOrNullify());
            result = result && (this.Grades.TrimOrNullify() == that.Grades.TrimOrNullify());
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.ManProleId.TrimOrNullify() == that.ManProleId.TrimOrNullify());
            result = result && (this.Level.TrimOrNullify() == that.Level.TrimOrNullify());
            result = result && (this.Serialised == that.Serialised);
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            result = result && (this.ValToRevPc == that.ValToRevPc);
            result = result && (this.BktId.TrimOrNullify() == that.BktId.TrimOrNullify());
            result = result && (this.BtId.TrimOrNullify() == that.BtId.TrimOrNullify());
            result = result && (this.Name2.TrimOrNullify() == that.Name2.TrimOrNullify());
            result = result && (this.GlCode1.TrimOrNullify() == that.GlCode1.TrimOrNullify());
            result = result && (this.GlCode2.TrimOrNullify() == that.GlCode2.TrimOrNullify());
            result = result && (this.Resourse == that.Resourse);
            result = result && (this.LocId.TrimOrNullify() == that.LocId.TrimOrNullify());
            result = result && (this.Web == that.Web);
            result = result && (this.DescFile.TrimOrNullify() == that.DescFile.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Userint1 == that.Userint1);
            result = result && (this.Userint2 == that.Userint2);
            result = result && (this.Userint3 == that.Userint3);
            result = result && (this.Userint4 == that.Userint4);
            result = result && (this.Userdate1 == that.Userdate1);
            result = result && (this.Userint5 == that.Userint5);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Userint6 == that.Userint6);
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.Userchar5.TrimOrNullify() == that.Userchar5.TrimOrNullify());
            result = result && (this.Usernum3 == that.Usernum3);
            result = result && (this.Usernum4 == that.Usernum4);
            result = result && (this.Usernum5 == that.Usernum5);
            result = result && (this.Userint7 == that.Userint7);
            result = result && (this.Userint8 == that.Userint8);
            result = result && (this.Userint9 == that.Userint9);
            result = result && (this.MembPrcGrp.TrimOrNullify() == that.MembPrcGrp.TrimOrNullify());
            result = result && (this.ScoManifXml.TrimOrNullify() == that.ScoManifXml.TrimOrNullify());
            result = result && (this.ProdQuantity == that.ProdQuantity);
            result = result && (this.NonScorm == that.NonScorm);
            result = result && (this.MsNew.TrimOrNullify() == that.MsNew.TrimOrNullify());
            result = result && (this.MsRemind1.TrimOrNullify() == that.MsRemind1.TrimOrNullify());
            result = result && (this.MsRemind2.TrimOrNullify() == that.MsRemind2.TrimOrNullify());
            result = result && (this.MsRenew.TrimOrNullify() == that.MsRenew.TrimOrNullify());
            result = result && (this.MsLapsed.TrimOrNullify() == that.MsLapsed.TrimOrNullify());
            result = result && (this.MsCancel.TrimOrNullify() == that.MsCancel.TrimOrNullify());
            result = result && (this.MsGroup == that.MsGroup);
            result = result && (this.RenewDays == that.RenewDays);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.MemInvType == that.MemInvType);
            result = result && (this.AuthPnId.TrimOrNullify() == that.AuthPnId.TrimOrNullify());
            result = result && (this.Isbn.TrimOrNullify() == that.Isbn.TrimOrNullify());
            result = result && (this.PageCount == that.PageCount);
            result = result && (this.MsRemind3.TrimOrNullify() == that.MsRemind3.TrimOrNullify());
            result = result && (this.MsRm1Days == that.MsRm1Days);
            result = result && (this.MsRm2Days == that.MsRm2Days);
            result = result && (this.MsRm3Days == that.MsRm3Days);
            result = result && (this.MsLapsDays == that.MsLapsDays);
            result = result && (this.Freq == that.Freq);
            result = result && (this.DescFileY.TrimOrNullify() == that.DescFileY.TrimOrNullify());
            result = result && (this.MsRenewed.TrimOrNullify() == that.MsRenewed.TrimOrNullify());
            result = result && (this.RegBodyId1.TrimOrNullify() == that.RegBodyId1.TrimOrNullify());
            result = result && (this.RegBodyId2.TrimOrNullify() == that.RegBodyId2.TrimOrNullify());
            result = result && (this.Userchar6.TrimOrNullify() == that.Userchar6.TrimOrNullify());
            result = result && (this.UDate1 == that.UDate1);
            result = result && (this.UDate2 == that.UDate2);
            result = result && (this.UDate3 == that.UDate3);
            result = result && (this.UDate4 == that.UDate4);
            result = result && (this.UDate5 == that.UDate5);
            result = result && (this.UDate6 == that.UDate6);
            result = result && (this.Usernum6 == that.Usernum6);
            result = result && (this.RoomBedType.TrimOrNullify() == that.RoomBedType.TrimOrNullify());
            result = result && (this.LayStd == that.LayStd);
            result = result && (this.LayTheater == that.LayTheater);
            result = result && (this.LayInformal == that.LayInformal);
            result = result && (this.LayClass == that.LayClass);
            result = result && (this.LayOther == that.LayOther);
            result = result && (this.MaxTheater == that.MaxTheater);
            result = result && (this.MaxInformal == that.MaxInformal);
            result = result && (this.MaxClass == that.MaxClass);
            result = result && (this.MaxOther == that.MaxOther);
            result = result && (this.PriceBand.TrimOrNullify() == that.PriceBand.TrimOrNullify());
            result = result && (this.SltyId.TrimOrNullify() == that.SltyId.TrimOrNullify());
            result = result && (this.Keywords.TrimOrNullify() == that.Keywords.TrimOrNullify());
            result = result && (this.LmsName.TrimOrNullify() == that.LmsName.TrimOrNullify());
            result = result && (this.ElSelfAprv == that.ElSelfAprv);
            result = result && (this.CutPrd == that.CutPrd);
            result = result && (this.RenewalMonth.TrimOrNullify() == that.RenewalMonth.TrimOrNullify());
            result = result && (this.RenewalDay.TrimOrNullify() == that.RenewalDay.TrimOrNullify());
            result = result && (this.FixedRenewal == that.FixedRenewal);
            result = result && (this.ExclDay.TrimOrNullify() == that.ExclDay.TrimOrNullify());
            result = result && (this.ExclCalc == that.ExclCalc);
            result = result && (this.SgNo == that.SgNo);
            result = result && (this.MsApp.TrimOrNullify() == that.MsApp.TrimOrNullify());
            result = result && (this.MsOff.TrimOrNullify() == that.MsOff.TrimOrNullify());
            result = result && (this.Funded == that.Funded);
            result = result && (this.FundedOrgId.TrimOrNullify() == that.FundedOrgId.TrimOrNullify());
            result = result && (this.QualDel == that.QualDel);
            result = result && (this.BreakMustExist == that.BreakMustExist);
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.BdPrepBy.TrimOrNullify() == that.BdPrepBy.TrimOrNullify());
            result = result && (this.BdPrepDate == that.BdPrepDate);
            result = result && (this.BdStatus.TrimOrNullify() == that.BdStatus.TrimOrNullify());
            result = result && (this.BdAppBy.TrimOrNullify() == that.BdAppBy.TrimOrNullify());
            result = result && (this.BdAppDate == that.BdAppDate);
            result = result && (this.BdTotEstCost == that.BdTotEstCost);
            result = result && (this.NoInvRenew == that.NoInvRenew);
            result = result && (this.CalcCommission == that.CalcCommission);
            result = result && (this.Region.TrimOrNullify() == that.Region.TrimOrNullify());
            result = result && (this.StaticResourse == that.StaticResourse);
            result = result && (this.PooledResourse == that.PooledResourse);
            result = result && (this.ClashCheck == that.ClashCheck);
            result = result && (this.DefTraineeDays == that.DefTraineeDays);
            result = result && (this.GrantEligible == that.GrantEligible);
            result = result && (this.GrantValueAvailable == that.GrantValueAvailable);
            result = result && (this.Breakeven1 == that.Breakeven1);
            result = result && (this.Breakeven2 == that.Breakeven2);
            result = result && (this.ExtCourseware == that.ExtCourseware);
            result = result && (this.Contingency == that.Contingency);
            result = result && (this.Cost == that.Cost);
            result = result && (this.DeliveryDay == that.DeliveryDay);
            result = result && (this.ExtUrl.TrimOrNullify() == that.ExtUrl.TrimOrNullify());
            result = result && (this.UseExtUrl == that.UseExtUrl);
            result = result && (this.RefNo == that.RefNo);
            result = result && (this.Prefix.TrimOrNullify() == that.Prefix.TrimOrNullify());
            result = result && (this.NoneChargeable == that.NoneChargeable);
            result = result && (this.RuleIncFamily == that.RuleIncFamily);
            result = result && (this.Donation == that.Donation);
            result = result && (this.Renew == that.Renew);
            result = result && (this.Renewable == that.Renewable);
            result = result && (this.CourseNotesTextId.TrimOrNullify() == that.CourseNotesTextId.TrimOrNullify());
            result = result && (this.DesigLetters.TrimOrNullify() == that.DesigLetters.TrimOrNullify());
            result = result && (this.NonRenewMemb == that.NonRenewMemb);
            result = result && (this.AgeRestriction1 == that.AgeRestriction1);
            result = result && (this.AgeRestriction2 == that.AgeRestriction2);
            result = result && (this.RestrictType.TrimOrNullify() == that.RestrictType.TrimOrNullify());
            result = result && (this.ExpiryDate == that.ExpiryDate);
            result = result && (this.InvZeroVal == that.InvZeroVal);
            result = result && (this.CreditHours == that.CreditHours);
            result = result && (this.DdNoOfInstallments == that.DdNoOfInstallments);
            result = result && (this.DdFrequency == that.DdFrequency);
            result = result && (this.ExcludeTrainHistory == that.ExcludeTrainHistory);
            result = result && (this.StartDateType == that.StartDateType);
            result = result && (this.StartDateFixed == that.StartDateFixed);
            result = result && (this.StartDateOffset == that.StartDateOffset);
            result = result && (this.StartDateOffsetType.TrimOrNullify() == that.StartDateOffsetType.TrimOrNullify());
            result = result && (this.EndDateType == that.EndDateType);
            result = result && (this.EndDateFixed == that.EndDateFixed);
            result = result && (this.EndDateOffset == that.EndDateOffset);
            result = result && (this.EndDateOffsetType.TrimOrNullify() == that.EndDateOffsetType.TrimOrNullify());
            result = result && (this.DescEditable == that.DescEditable);
            result = result && (this.StockType.TrimOrNullify() == that.StockType.TrimOrNullify());
            result = result && (this.StockExpectedDate.TrimOrNullify() == that.StockExpectedDate.TrimOrNullify());
            result = result && (this.MemFirstBook == that.MemFirstBook);
            result = result && (this.MinScore == that.MinScore);
            result = result && (this.ScoreOutof == that.ScoreOutof);
            result = result && (this.GradeWeb == that.GradeWeb);
            result = result && (this.Predeliv == that.Predeliv);
            result = result && (this.AuthorName.TrimOrNullify() == that.AuthorName.TrimOrNullify());
            result = result && (this.Topup == that.Topup);
            result = result && (this.LimitPlType.TrimOrNullify() == that.LimitPlType.TrimOrNullify());
            result = result && (this.PrepayUnits == that.PrepayUnits);
            result = result && (this.DelivMethod.TrimOrNullify() == that.DelivMethod.TrimOrNullify());
            result = result && (this.Lockdown == that.Lockdown);
            result = result && (this.Promotion == that.Promotion);
            result = result && (this.SearchGroup.TrimOrNullify() == that.SearchGroup.TrimOrNullify());
            result = result && (this.LimitPlId.TrimOrNullify() == that.LimitPlId.TrimOrNullify());
            result = result && (this.DefElemSt.TrimOrNullify() == that.DefElemSt.TrimOrNullify());
            result = result && (this.NextNo == that.NextNo);
            result = result && (this.Suffix.TrimOrNullify() == that.Suffix.TrimOrNullify());
            result = result && (this.NoMembDiscount == that.NoMembDiscount);
            result = result && (this.QuestId.TrimOrNullify() == that.QuestId.TrimOrNullify());
            result = result && (this.ShortDesc.TrimOrNullify() == that.ShortDesc.TrimOrNullify());
            result = result && (this.OneclickCheckout == that.OneclickCheckout);
            result = result && (this.BookerOnly == that.BookerOnly);
            result = result && (this.LayUshape == that.LayUshape);
            result = result && (this.LayBroom == that.LayBroom);
            result = result && (this.LayBrout == that.LayBrout);
            result = result && (this.MaxUshape == that.MaxUshape);
            result = result && (this.MaxBroom == that.MaxBroom);
            result = result && (this.MaxBrout == that.MaxBrout);
            result = result && (this.WpName.TrimOrNullify() == that.WpName.TrimOrNullify());
            result = result && (this.Dept.TrimOrNullify() == that.Dept.TrimOrNullify());
            result = result && (this.Sku.TrimOrNullify() == that.Sku.TrimOrNullify());
            result = result && (this.JobCode.TrimOrNullify() == that.JobCode.TrimOrNullify());
            result = result && (this.JobAnalyCode.TrimOrNullify() == that.JobAnalyCode.TrimOrNullify());
            result = result && (this.JobType.TrimOrNullify() == that.JobType.TrimOrNullify());
            result = result && (this.JobParent.TrimOrNullify() == that.JobParent.TrimOrNullify());
            result = result && (this.PshId == that.PshId);
            result = result && (this.Image.TrimOrNullify() == that.Image.TrimOrNullify());
            result = result && (this.OnlineSche.TrimOrNullify() == that.OnlineSche.TrimOrNullify());
            result = result && (this.QuotebookRatio == that.QuotebookRatio);
            result = result && (this.Coords.TrimOrNullify() == that.Coords.TrimOrNullify());
            result = result && (this.UrlName.TrimOrNullify() == that.UrlName.TrimOrNullify());
            result = result && (this.ZeroPad == that.ZeroPad);
            result = result && (this.TrainProv == that.TrainProv);
            result = result && (this.ReorderLev == that.ReorderLev);
            result = result && (this.Licensed == that.Licensed);
            result = result && (this.DelCloseDays == that.DelCloseDays);
            result = result && (this.TrnRulesTxt.TrimOrNullify() == that.TrnRulesTxt.TrimOrNullify());
            result = result && (this.CertDefDeliver == that.CertDefDeliver);
            result = result && (this.DefMethDel.TrimOrNullify() == that.DefMethDel.TrimOrNullify());
            result = result && (this.CertTempLttId.TrimOrNullify() == that.CertTempLttId.TrimOrNullify());
            result = result && (this.ReorderLead == that.ReorderLead);
            result = result && (this.NomMemDet.TrimOrNullify() == that.NomMemDet.TrimOrNullify());
            result = result && (this.NomMemReq == that.NomMemReq);
            result = result && (this.NomMemProdId.TrimOrNullify() == that.NomMemProdId.TrimOrNullify());
            result = result && (this.PackSendProleId.TrimOrNullify() == that.PackSendProleId.TrimOrNullify());
            result = result && (this.PackBccEmail.TrimOrNullify() == that.PackBccEmail.TrimOrNullify());
            result = result && (this.PackMdnEmail.TrimOrNullify() == that.PackMdnEmail.TrimOrNullify());
            result = result && (this.PackDsnEmail.TrimOrNullify() == that.PackDsnEmail.TrimOrNullify());
            result = result && (this.PackDsnOptions.TrimOrNullify() == that.PackDsnOptions.TrimOrNullify());
            result = result && (this.CodeImage.TrimOrNullify() == that.CodeImage.TrimOrNullify());
            result = result && (this.GatewayAccId.TrimOrNullify() == that.GatewayAccId.TrimOrNullify());
            result = result && (this.RoyaltyModel.TrimOrNullify() == that.RoyaltyModel.TrimOrNullify());
            result = result && (this.SessionsDescription.TrimOrNullify() == that.SessionsDescription.TrimOrNullify());
            result = result && (this.SessionsHeader.TrimOrNullify() == that.SessionsHeader.TrimOrNullify());
            result = result && (this.CutPrdTime == that.CutPrdTime);
            result = result && (this.Giftaid == that.Giftaid);
            return result;
        }

        #endregion
    }
}
