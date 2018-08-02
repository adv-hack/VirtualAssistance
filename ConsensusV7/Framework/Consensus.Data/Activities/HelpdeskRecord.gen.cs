using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Represents the "Helpdesk" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class HelpdeskRecord : Record<String>, Cloneable<HelpdeskRecord>, IEquatable<HelpdeskRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "HD_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "HD_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "HD_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "HD_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "HD_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "HD_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "HD_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "HD_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "HD_ORG_NAME" field.
        /// </summary>
        private String _orgName;

        /// <summary>
        ///     the value of the "HD_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "HD_PN_NAME" field.
        /// </summary>
        private String _pnName;

        /// <summary>
        ///     the value of the "HD_SERIAL_NO" field.
        /// </summary>
        private String _serialNo;

        /// <summary>
        ///     the value of the "HD_IN_ID" field.
        /// </summary>
        private String _inId;

        /// <summary>
        ///     the value of the "HD_PROD_CODE" field.
        /// </summary>
        private String _prodCode;

        /// <summary>
        ///     the value of the "HD_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "HD_WARR_DATE" field.
        /// </summary>
        private DateTime? _warrDate;

        /// <summary>
        ///     the value of the "HD_CONTR_REF" field.
        /// </summary>
        private String _contrRef;

        /// <summary>
        ///     the value of the "HD_CONT_TYPE" field.
        /// </summary>
        private String _contType;

        /// <summary>
        ///     the value of the "HD_CONT_DATE" field.
        /// </summary>
        private DateTime? _contDate;

        /// <summary>
        ///     the value of the "HD_GIVEN_TO" field.
        /// </summary>
        private String _givenTo;

        /// <summary>
        ///     the value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        private String _givenToId;

        /// <summary>
        ///     the value of the "HD_FIXED_DATE" field.
        /// </summary>
        private DateTime? _fixedDate;

        /// <summary>
        ///     the value of the "HD_FIXED_TIME" field.
        /// </summary>
        private Double? _fixedTime;

        /// <summary>
        ///     the value of the "HD_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "HD_DETAILS_ID" field.
        /// </summary>
        private String _detailsId;

        /// <summary>
        ///     the value of the "HD_FIX_ID" field.
        /// </summary>
        private String _fixId;

        /// <summary>
        ///     the value of the "HD_CATEGORY" field.
        /// </summary>
        private String _category;

        /// <summary>
        ///     the value of the "HD_FIX_CAT" field.
        /// </summary>
        private String _fixCat;

        /// <summary>
        ///     the value of the "HD_CALL_DATE" field.
        /// </summary>
        private DateTime? _callDate;

        /// <summary>
        ///     the value of the "HD_CALL_TIME" field.
        /// </summary>
        private DateTime? _callTime;

        /// <summary>
        ///     the value of the "HD_CALLER_PHONE" field.
        /// </summary>
        private String _callerPhone;

        /// <summary>
        ///     the value of the "HD_FAULT_TYPE" field.
        /// </summary>
        private String _faultType;

        /// <summary>
        ///     the value of the "HD_PROD_NAME" field.
        /// </summary>
        private String _prodName;

        /// <summary>
        ///     the value of the "HD_SEVERITY" field.
        /// </summary>
        private String _severity;

        /// <summary>
        ///     the value of the "HD_PROJ_REF" field.
        /// </summary>
        private String _projRef;

        /// <summary>
        ///     the value of the "HD_PROJ_ID" field.
        /// </summary>
        private String _projId;

        /// <summary>
        ///     the value of the "HD_ACT_ID" field.
        /// </summary>
        private String _actId;

        /// <summary>
        ///     the value of the "HD_HISTORY_TXT" field.
        /// </summary>
        private String _historyTxt;

        /// <summary>
        ///     the value of the "HD_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "HD_CUST_REF" field.
        /// </summary>
        private String _custRef;

        /// <summary>
        ///     the value of the "HD_CUST_ACPT" field.
        /// </summary>
        private String _custAcpt;

        /// <summary>
        ///     the value of the "HD_RPT_DATE" field.
        /// </summary>
        private DateTime? _rptDate;

        /// <summary>
        ///     the value of the "HD_TRG_RSP_DATE" field.
        /// </summary>
        private DateTime? _trgRspDate;

        /// <summary>
        ///     the value of the "HD_ACT_RSP_DATE" field.
        /// </summary>
        private DateTime? _actRspDate;

        /// <summary>
        ///     the value of the "HD_TRG_TPFIX_D" field.
        /// </summary>
        private DateTime? _trgTpfixD;

        /// <summary>
        ///     the value of the "HD_ACT_TPFIX_D" field.
        /// </summary>
        private DateTime? _actTpfixD;

        /// <summary>
        ///     the value of the "HD_TRG_ACTFIX_D" field.
        /// </summary>
        private DateTime? _trgActfixD;

        /// <summary>
        ///     the value of the "HD_SUC_ID" field.
        /// </summary>
        private String _sucId;

        /// <summary>
        ///     the value of the "HD_ACC_DATE" field.
        /// </summary>
        private DateTime? _accDate;

        /// <summary>
        ///     the value of the "HD_RESOLVED_VER" field.
        /// </summary>
        private String _resolvedVer;

        /// <summary>
        ///     the value of the "HD_EST_TIME" field.
        /// </summary>
        private Double? _estTime;

        /// <summary>
        ///     the value of the "HD_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "HD_WIP_ID" field.
        /// </summary>
        private String _wipId;

        /// <summary>
        ///     the value of the "HD_RES_DATE" field.
        /// </summary>
        private DateTime? _resDate;

        /// <summary>
        ///     the value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "HD_GROUP" field.
        /// </summary>
        private String _group;

        /// <summary>
        ///     the value of the "HD_ASSIGNED" field.
        /// </summary>
        private Byte? _assigned;

        /// <summary>
        ///     the value of the "HD_READ" field.
        /// </summary>
        private Byte? _read;

        /// <summary>
        ///     the value of the "HD_RESOLUTION_ID" field.
        /// </summary>
        private String _resolutionId;

        /// <summary>
        ///     the value of the "HD_VERSION" field.
        /// </summary>
        private String _version;

        /// <summary>
        ///     the value of the "HD_PM_ID" field.
        /// </summary>
        private String _pmId;

        /// <summary>
        ///     the value of the "HD_BUILD_VERSION" field.
        /// </summary>
        private String _buildVersion;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "HD_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "HD_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "HD_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "HD_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "HD_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "HD_ORG_NAME" field.
        /// </summary>
        public String OrgName
        {
            get { return _orgName; }
            set { _orgName = value; }
        }

        /// <summary>
        ///     the value of the "HD_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "HD_PN_NAME" field.
        /// </summary>
        public String PnName
        {
            get { return _pnName; }
            set { _pnName = value; }
        }

        /// <summary>
        ///     the value of the "HD_SERIAL_NO" field.
        /// </summary>
        public String SerialNo
        {
            get { return _serialNo; }
            set { _serialNo = value; }
        }

        /// <summary>
        ///     the value of the "HD_IN_ID" field.
        /// </summary>
        public String InId
        {
            get { return _inId; }
            set { _inId = value; }
        }

        /// <summary>
        ///     the value of the "HD_PROD_CODE" field.
        /// </summary>
        public String ProdCode
        {
            get { return _prodCode; }
            set { _prodCode = value; }
        }

        /// <summary>
        ///     the value of the "HD_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "HD_WARR_DATE" field.
        /// </summary>
        public DateTime? WarrDate
        {
            get { return _warrDate; }
            set { _warrDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_CONTR_REF" field.
        /// </summary>
        public String ContrRef
        {
            get { return _contrRef; }
            set { _contrRef = value; }
        }

        /// <summary>
        ///     the value of the "HD_CONT_TYPE" field.
        /// </summary>
        public String ContType
        {
            get { return _contType; }
            set { _contType = value; }
        }

        /// <summary>
        ///     the value of the "HD_CONT_DATE" field.
        /// </summary>
        public DateTime? ContDate
        {
            get { return _contDate; }
            set { _contDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_GIVEN_TO" field.
        /// </summary>
        public String GivenTo
        {
            get { return _givenTo; }
            set { _givenTo = value; }
        }

        /// <summary>
        ///     the value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        public String GivenToId
        {
            get { return _givenToId; }
            set { _givenToId = value; }
        }

        /// <summary>
        ///     the value of the "HD_FIXED_DATE" field.
        /// </summary>
        public DateTime? FixedDate
        {
            get { return _fixedDate; }
            set { _fixedDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_FIXED_TIME" field.
        /// </summary>
        public Double? FixedTime
        {
            get { return _fixedTime; }
            set { _fixedTime = value; }
        }

        /// <summary>
        ///     the value of the "HD_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "HD_DETAILS_ID" field.
        /// </summary>
        public String DetailsId
        {
            get { return _detailsId; }
            set { _detailsId = value; }
        }

        /// <summary>
        ///     the value of the "HD_FIX_ID" field.
        /// </summary>
        public String FixId
        {
            get { return _fixId; }
            set { _fixId = value; }
        }

        /// <summary>
        ///     the value of the "HD_CATEGORY" field.
        /// </summary>
        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        ///     the value of the "HD_FIX_CAT" field.
        /// </summary>
        public String FixCat
        {
            get { return _fixCat; }
            set { _fixCat = value; }
        }

        /// <summary>
        ///     the value of the "HD_CALL_DATE" field.
        /// </summary>
        public DateTime? CallDate
        {
            get { return _callDate; }
            set { _callDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_CALL_TIME" field.
        /// </summary>
        public DateTime? CallTime
        {
            get { return _callTime; }
            set { _callTime = value; }
        }

        /// <summary>
        ///     the value of the "HD_CALLER_PHONE" field.
        /// </summary>
        public String CallerPhone
        {
            get { return _callerPhone; }
            set { _callerPhone = value; }
        }

        /// <summary>
        ///     the value of the "HD_FAULT_TYPE" field.
        /// </summary>
        public String FaultType
        {
            get { return _faultType; }
            set { _faultType = value; }
        }

        /// <summary>
        ///     the value of the "HD_PROD_NAME" field.
        /// </summary>
        public String ProdName
        {
            get { return _prodName; }
            set { _prodName = value; }
        }

        /// <summary>
        ///     the value of the "HD_SEVERITY" field.
        /// </summary>
        public String Severity
        {
            get { return _severity; }
            set { _severity = value; }
        }

        /// <summary>
        ///     the value of the "HD_PROJ_REF" field.
        /// </summary>
        public String ProjRef
        {
            get { return _projRef; }
            set { _projRef = value; }
        }

        /// <summary>
        ///     the value of the "HD_PROJ_ID" field.
        /// </summary>
        public String ProjId
        {
            get { return _projId; }
            set { _projId = value; }
        }

        /// <summary>
        ///     the value of the "HD_ACT_ID" field.
        /// </summary>
        public String ActId
        {
            get { return _actId; }
            set { _actId = value; }
        }

        /// <summary>
        ///     the value of the "HD_HISTORY_TXT" field.
        /// </summary>
        public String HistoryTxt
        {
            get { return _historyTxt; }
            set { _historyTxt = value; }
        }

        /// <summary>
        ///     the value of the "HD_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "HD_CUST_REF" field.
        /// </summary>
        public String CustRef
        {
            get { return _custRef; }
            set { _custRef = value; }
        }

        /// <summary>
        ///     the value of the "HD_CUST_ACPT" field.
        /// </summary>
        public String CustAcpt
        {
            get { return _custAcpt; }
            set { _custAcpt = value; }
        }

        /// <summary>
        ///     the value of the "HD_RPT_DATE" field.
        /// </summary>
        public DateTime? RptDate
        {
            get { return _rptDate; }
            set { _rptDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_TRG_RSP_DATE" field.
        /// </summary>
        public DateTime? TrgRspDate
        {
            get { return _trgRspDate; }
            set { _trgRspDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_ACT_RSP_DATE" field.
        /// </summary>
        public DateTime? ActRspDate
        {
            get { return _actRspDate; }
            set { _actRspDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_TRG_TPFIX_D" field.
        /// </summary>
        public DateTime? TrgTpfixD
        {
            get { return _trgTpfixD; }
            set { _trgTpfixD = value; }
        }

        /// <summary>
        ///     the value of the "HD_ACT_TPFIX_D" field.
        /// </summary>
        public DateTime? ActTpfixD
        {
            get { return _actTpfixD; }
            set { _actTpfixD = value; }
        }

        /// <summary>
        ///     the value of the "HD_TRG_ACTFIX_D" field.
        /// </summary>
        public DateTime? TrgActfixD
        {
            get { return _trgActfixD; }
            set { _trgActfixD = value; }
        }

        /// <summary>
        ///     the value of the "HD_SUC_ID" field.
        /// </summary>
        public String SucId
        {
            get { return _sucId; }
            set { _sucId = value; }
        }

        /// <summary>
        ///     the value of the "HD_ACC_DATE" field.
        /// </summary>
        public DateTime? AccDate
        {
            get { return _accDate; }
            set { _accDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_RESOLVED_VER" field.
        /// </summary>
        public String ResolvedVer
        {
            get { return _resolvedVer; }
            set { _resolvedVer = value; }
        }

        /// <summary>
        ///     the value of the "HD_EST_TIME" field.
        /// </summary>
        public Double? EstTime
        {
            get { return _estTime; }
            set { _estTime = value; }
        }

        /// <summary>
        ///     the value of the "HD_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "HD_WIP_ID" field.
        /// </summary>
        public String WipId
        {
            get { return _wipId; }
            set { _wipId = value; }
        }

        /// <summary>
        ///     the value of the "HD_RES_DATE" field.
        /// </summary>
        public DateTime? ResDate
        {
            get { return _resDate; }
            set { _resDate = value; }
        }

        /// <summary>
        ///     the value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "HD_GROUP" field.
        /// </summary>
        public String Group
        {
            get { return _group; }
            set { _group = value; }
        }

        /// <summary>
        ///     the value of the "HD_ASSIGNED" field.
        /// </summary>
        public Byte? Assigned
        {
            get { return _assigned; }
            set { _assigned = value; }
        }

        /// <summary>
        ///     the value of the "HD_READ" field.
        /// </summary>
        public Byte? Read
        {
            get { return _read; }
            set { _read = value; }
        }

        /// <summary>
        ///     the value of the "HD_RESOLUTION_ID" field.
        /// </summary>
        public String ResolutionId
        {
            get { return _resolutionId; }
            set { _resolutionId = value; }
        }

        /// <summary>
        ///     the value of the "HD_VERSION" field.
        /// </summary>
        public String Version
        {
            get { return _version; }
            set { _version = value; }
        }

        /// <summary>
        ///     the value of the "HD_PM_ID" field.
        /// </summary>
        public String PmId
        {
            get { return _pmId; }
            set { _pmId = value; }
        }

        /// <summary>
        ///     the value of the "HD_BUILD_VERSION" field.
        /// </summary>
        public String BuildVersion
        {
            get { return _buildVersion; }
            set { _buildVersion = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="HelpdeskRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="HelpdeskRecord" /> object instance.
        /// </returns>
        public HelpdeskRecord Clone()
        {
            HelpdeskRecord record = new HelpdeskRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.OrgId = this.OrgId;
            record.OrgName = this.OrgName;
            record.ProleId = this.ProleId;
            record.PnName = this.PnName;
            record.SerialNo = this.SerialNo;
            record.InId = this.InId;
            record.ProdCode = this.ProdCode;
            record.ProdId = this.ProdId;
            record.WarrDate = this.WarrDate;
            record.ContrRef = this.ContrRef;
            record.ContType = this.ContType;
            record.ContDate = this.ContDate;
            record.GivenTo = this.GivenTo;
            record.GivenToId = this.GivenToId;
            record.FixedDate = this.FixedDate;
            record.FixedTime = this.FixedTime;
            record.Status = this.Status;
            record.DetailsId = this.DetailsId;
            record.FixId = this.FixId;
            record.Category = this.Category;
            record.FixCat = this.FixCat;
            record.CallDate = this.CallDate;
            record.CallTime = this.CallTime;
            record.CallerPhone = this.CallerPhone;
            record.FaultType = this.FaultType;
            record.ProdName = this.ProdName;
            record.Severity = this.Severity;
            record.ProjRef = this.ProjRef;
            record.ProjId = this.ProjId;
            record.ActId = this.ActId;
            record.HistoryTxt = this.HistoryTxt;
            record.Title = this.Title;
            record.CustRef = this.CustRef;
            record.CustAcpt = this.CustAcpt;
            record.RptDate = this.RptDate;
            record.TrgRspDate = this.TrgRspDate;
            record.ActRspDate = this.ActRspDate;
            record.TrgTpfixD = this.TrgTpfixD;
            record.ActTpfixD = this.ActTpfixD;
            record.TrgActfixD = this.TrgActfixD;
            record.SucId = this.SucId;
            record.AccDate = this.AccDate;
            record.ResolvedVer = this.ResolvedVer;
            record.EstTime = this.EstTime;
            record.Type = this.Type;
            record.WipId = this.WipId;
            record.ResDate = this.ResDate;
            record.SelcoSpId = this.SelcoSpId;
            record.Group = this.Group;
            record.Assigned = this.Assigned;
            record.Read = this.Read;
            record.ResolutionId = this.ResolutionId;
            record.Version = this.Version;
            record.PmId = this.PmId;
            record.BuildVersion = this.BuildVersion;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="HelpdeskRecord" /> instance is equal to another <see cref="HelpdeskRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="HelpdeskRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(HelpdeskRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.OrgName.TrimOrNullify() == that.OrgName.TrimOrNullify());
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.PnName.TrimOrNullify() == that.PnName.TrimOrNullify());
            result = result && (this.SerialNo.TrimOrNullify() == that.SerialNo.TrimOrNullify());
            result = result && (this.InId.TrimOrNullify() == that.InId.TrimOrNullify());
            result = result && (this.ProdCode.TrimOrNullify() == that.ProdCode.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.WarrDate == that.WarrDate);
            result = result && (this.ContrRef.TrimOrNullify() == that.ContrRef.TrimOrNullify());
            result = result && (this.ContType.TrimOrNullify() == that.ContType.TrimOrNullify());
            result = result && (this.ContDate == that.ContDate);
            result = result && (this.GivenTo.TrimOrNullify() == that.GivenTo.TrimOrNullify());
            result = result && (this.GivenToId.TrimOrNullify() == that.GivenToId.TrimOrNullify());
            result = result && (this.FixedDate == that.FixedDate);
            result = result && (this.FixedTime == that.FixedTime);
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.DetailsId.TrimOrNullify() == that.DetailsId.TrimOrNullify());
            result = result && (this.FixId.TrimOrNullify() == that.FixId.TrimOrNullify());
            result = result && (this.Category.TrimOrNullify() == that.Category.TrimOrNullify());
            result = result && (this.FixCat.TrimOrNullify() == that.FixCat.TrimOrNullify());
            result = result && (this.CallDate == that.CallDate);
            result = result && (this.CallTime == that.CallTime);
            result = result && (this.CallerPhone.TrimOrNullify() == that.CallerPhone.TrimOrNullify());
            result = result && (this.FaultType.TrimOrNullify() == that.FaultType.TrimOrNullify());
            result = result && (this.ProdName.TrimOrNullify() == that.ProdName.TrimOrNullify());
            result = result && (this.Severity.TrimOrNullify() == that.Severity.TrimOrNullify());
            result = result && (this.ProjRef.TrimOrNullify() == that.ProjRef.TrimOrNullify());
            result = result && (this.ProjId.TrimOrNullify() == that.ProjId.TrimOrNullify());
            result = result && (this.ActId.TrimOrNullify() == that.ActId.TrimOrNullify());
            result = result && (this.HistoryTxt.TrimOrNullify() == that.HistoryTxt.TrimOrNullify());
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.CustRef.TrimOrNullify() == that.CustRef.TrimOrNullify());
            result = result && (this.CustAcpt.TrimOrNullify() == that.CustAcpt.TrimOrNullify());
            result = result && (this.RptDate == that.RptDate);
            result = result && (this.TrgRspDate == that.TrgRspDate);
            result = result && (this.ActRspDate == that.ActRspDate);
            result = result && (this.TrgTpfixD == that.TrgTpfixD);
            result = result && (this.ActTpfixD == that.ActTpfixD);
            result = result && (this.TrgActfixD == that.TrgActfixD);
            result = result && (this.SucId.TrimOrNullify() == that.SucId.TrimOrNullify());
            result = result && (this.AccDate == that.AccDate);
            result = result && (this.ResolvedVer.TrimOrNullify() == that.ResolvedVer.TrimOrNullify());
            result = result && (this.EstTime == that.EstTime);
            result = result && (this.Type == that.Type);
            result = result && (this.WipId.TrimOrNullify() == that.WipId.TrimOrNullify());
            result = result && (this.ResDate == that.ResDate);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.Group.TrimOrNullify() == that.Group.TrimOrNullify());
            result = result && (this.Assigned == that.Assigned);
            result = result && (this.Read == that.Read);
            result = result && (this.ResolutionId.TrimOrNullify() == that.ResolutionId.TrimOrNullify());
            result = result && (this.Version.TrimOrNullify() == that.Version.TrimOrNullify());
            result = result && (this.PmId.TrimOrNullify() == that.PmId.TrimOrNullify());
            result = result && (this.BuildVersion.TrimOrNullify() == that.BuildVersion.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
