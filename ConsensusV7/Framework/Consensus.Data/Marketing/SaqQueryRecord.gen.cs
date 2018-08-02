using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents the "SAQ_QUERY" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SaqQueryRecord : Record<Int64>, Cloneable<SaqQueryRecord>, IEquatable<SaqQueryRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "QRY_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "QRY_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "QRY_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "QRY_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "QRY_QG_ID" field.
        /// </summary>
        private Int32? _qgId;

        /// <summary>
        ///     the value of the "QRY_QOFF_ID" field.
        /// </summary>
        private Int32? _qoffId;

        /// <summary>
        ///     the value of the "QRY_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "QRY_DESC" field.
        /// </summary>
        private String _desc;

        /// <summary>
        ///     the value of the "QRY_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "QRY_PM_ID" field.
        /// </summary>
        private String _pmId;

        /// <summary>
        ///     the value of the "QRY_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "QRY_CHANNEL" field.
        /// </summary>
        private String _channel;

        /// <summary>
        ///     the value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        private String _mgrProleId;

        /// <summary>
        ///     the value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        private String _appByProleId;

        /// <summary>
        ///     the value of the "QRY_TITLE_SLUG" field.
        /// </summary>
        private String _titleSlug;

        /// <summary>
        ///     the value of the "QRY_ORG_ONLY" field.
        /// </summary>
        private Byte _orgOnly;

        /// <summary>
        ///     the value of the "QRY_ORG_DEDUPE" field.
        /// </summary>
        private Byte _orgDedupe;

        /// <summary>
        ///     the value of the "QRY_PN_DEDUPE" field.
        /// </summary>
        private Byte _pnDedupe;

        /// <summary>
        ///     the value of the "QRY_SAVE_MAIL_SAMPLE" field.
        /// </summary>
        private Byte _saveMailSample;

        /// <summary>
        ///     the value of the "QRY_LOCKED" field.
        /// </summary>
        private Byte _locked;

        /// <summary>
        ///     the value of the "QRY_PEOPLE_PER_ORG" field.
        /// </summary>
        private Int32 _peoplePerOrg;

        /// <summary>
        ///     the value of the "QRY_PN_DONOTMAIL" field.
        /// </summary>
        private Byte _pnDonotmail;

        /// <summary>
        ///     the value of the "QRY_PN_DONOTMAIL2" field.
        /// </summary>
        private Byte _pnDonotmail2;

        /// <summary>
        ///     the value of the "QRY_PN_DONOTMAIL3" field.
        /// </summary>
        private Byte _pnDonotmail3;

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_FAX" field.
        /// </summary>
        private Byte _proleDoNotFax;

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_MAIL" field.
        /// </summary>
        private Byte _proleDoNotMail;

        /// <summary>
        ///     the value of the "QRY_PN_FLAG_3" field.
        /// </summary>
        private Byte _pnFlag3;

        /// <summary>
        ///     the value of the "QRY_PROLE_DIS_FLAG" field.
        /// </summary>
        private Byte _proleDisFlag;

        /// <summary>
        ///     the value of the "QRY_PROLE_USERNUM_1" field.
        /// </summary>
        private Byte _proleUsernum1;

        /// <summary>
        ///     the value of the "QRY_PN_FLAG_2" field.
        /// </summary>
        private Byte _pnFlag2;

        /// <summary>
        ///     the value of the "QRY_RESULTS_SIZE_OPT" field.
        /// </summary>
        private Byte _resultsSizeOpt;

        /// <summary>
        ///     the value of the "QRY_RESULTS_SIZE" field.
        /// </summary>
        private Int64 _resultsSize;

        /// <summary>
        ///     the value of the "QRY_SCHED_RUN_DATE" field.
        /// </summary>
        private DateTime? _schedRunDate;

        /// <summary>
        ///     the value of the "QRY_SCHED_RUN_TIME" field.
        /// </summary>
        private DateTime? _schedRunTime;

        /// <summary>
        ///     the value of the "QRY_CALCULATED_DATE" field.
        /// </summary>
        private DateTime? _calculatedDate;

        /// <summary>
        ///     the value of the "QRY_OUTPUT_DATE" field.
        /// </summary>
        private DateTime? _outputDate;

        /// <summary>
        ///     the value of the "QRY_TOTAL_RECORDS" field.
        /// </summary>
        private Int64 _totalRecords;

        /// <summary>
        ///     the value of the "QRY_SAMPLE" field.
        /// </summary>
        private Int64 _sample;

        /// <summary>
        ///     the value of the "QRY_SEEDS" field.
        /// </summary>
        private Int64 _seeds;

        /// <summary>
        ///     the value of the "QRY_IN_USE" field.
        /// </summary>
        private Byte _inUse;

        /// <summary>
        ///     the value of the "QRY_LAST_RESULT_FILE" field.
        /// </summary>
        private String _lastResultFile;

        /// <summary>
        ///     the value of the "QRY_APP_STATUS" field.
        /// </summary>
        private Byte _appStatus;

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SWAP" field.
        /// </summary>
        private Byte _proleDoNotSwap;

        /// <summary>
        ///     the value of the "QRY_PN_FLAG_1" field.
        /// </summary>
        private Byte _pnFlag1;

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        private Byte _proleDoNotEmail;

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SPARE" field.
        /// </summary>
        private Byte _proleDoNotSpare;

        /// <summary>
        ///     the value of the "QRY_ORG_DONOTMAIL" field.
        /// </summary>
        private Byte _orgDonotmail;

        /// <summary>
        ///     the value of the "QRY_ORG_USERNUM_1" field.
        /// </summary>
        private Byte _orgUsernum1;

        /// <summary>
        ///     the value of the "QRY_ORG_FLAG_1" field.
        /// </summary>
        private Byte _orgFlag1;

        /// <summary>
        ///     the value of the "QRY_ORG_DONOTFAX" field.
        /// </summary>
        private Byte _orgDonotfax;

        /// <summary>
        ///     the value of the "QRY_DP_SETTING" field.
        /// </summary>
        private Byte _dpSetting;

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SPARE1" field.
        /// </summary>
        private Byte? _proleDoNotSpare1;

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SPARE2" field.
        /// </summary>
        private Byte? _proleDoNotSpare2;

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SPARE3" field.
        /// </summary>
        private Byte? _proleDoNotSpare3;

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SPARE4" field.
        /// </summary>
        private Byte? _proleDoNotSpare4;

        /// <summary>
        ///     the value of the "QRY_PN_DO_NOT_SPARE1" field.
        /// </summary>
        private Byte? _pnDoNotSpare1;

        /// <summary>
        ///     the value of the "QRY_PN_DO_NOT_SPARE2" field.
        /// </summary>
        private Byte? _pnDoNotSpare2;

        /// <summary>
        ///     the value of the "QRY_PN_DO_NOT_SPARE3" field.
        /// </summary>
        private Byte? _pnDoNotSpare3;

        /// <summary>
        ///     the value of the "QRY_PN_DO_NOT_SPARE4" field.
        /// </summary>
        private Byte? _pnDoNotSpare4;

        /// <summary>
        ///     the value of the "QRY_ORG_DO_NOT_SPARE1" field.
        /// </summary>
        private Byte? _orgDoNotSpare1;

        /// <summary>
        ///     the value of the "QRY_ORG_DO_NOT_SPARE2" field.
        /// </summary>
        private Byte? _orgDoNotSpare2;

        /// <summary>
        ///     the value of the "QRY_ORG_DO_NOT_SPARE3" field.
        /// </summary>
        private Byte? _orgDoNotSpare3;

        /// <summary>
        ///     the value of the "QRY_ORG_DO_NOT_SPARE4" field.
        /// </summary>
        private Byte? _orgDoNotSpare4;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "QRY_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "QRY_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "QRY_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "QRY_QG_ID" field.
        /// </summary>
        public Int32? QgId
        {
            get { return _qgId; }
            set { _qgId = value; }
        }

        /// <summary>
        ///     the value of the "QRY_QOFF_ID" field.
        /// </summary>
        public Int32? QoffId
        {
            get { return _qoffId; }
            set { _qoffId = value; }
        }

        /// <summary>
        ///     the value of the "QRY_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "QRY_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        ///     the value of the "QRY_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PM_ID" field.
        /// </summary>
        public String PmId
        {
            get { return _pmId; }
            set { _pmId = value; }
        }

        /// <summary>
        ///     the value of the "QRY_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "QRY_CHANNEL" field.
        /// </summary>
        public String Channel
        {
            get { return _channel; }
            set { _channel = value; }
        }

        /// <summary>
        ///     the value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        public String MgrProleId
        {
            get { return _mgrProleId; }
            set { _mgrProleId = value; }
        }

        /// <summary>
        ///     the value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        public String AppByProleId
        {
            get { return _appByProleId; }
            set { _appByProleId = value; }
        }

        /// <summary>
        ///     the value of the "QRY_TITLE_SLUG" field.
        /// </summary>
        public String TitleSlug
        {
            get { return _titleSlug; }
            set { _titleSlug = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ORG_ONLY" field.
        /// </summary>
        public Byte OrgOnly
        {
            get { return _orgOnly; }
            set { _orgOnly = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ORG_DEDUPE" field.
        /// </summary>
        public Byte OrgDedupe
        {
            get { return _orgDedupe; }
            set { _orgDedupe = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_DEDUPE" field.
        /// </summary>
        public Byte PnDedupe
        {
            get { return _pnDedupe; }
            set { _pnDedupe = value; }
        }

        /// <summary>
        ///     the value of the "QRY_SAVE_MAIL_SAMPLE" field.
        /// </summary>
        public Byte SaveMailSample
        {
            get { return _saveMailSample; }
            set { _saveMailSample = value; }
        }

        /// <summary>
        ///     the value of the "QRY_LOCKED" field.
        /// </summary>
        public Byte Locked
        {
            get { return _locked; }
            set { _locked = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PEOPLE_PER_ORG" field.
        /// </summary>
        public Int32 PeoplePerOrg
        {
            get { return _peoplePerOrg; }
            set { _peoplePerOrg = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_DONOTMAIL" field.
        /// </summary>
        public Byte PnDonotmail
        {
            get { return _pnDonotmail; }
            set { _pnDonotmail = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_DONOTMAIL2" field.
        /// </summary>
        public Byte PnDonotmail2
        {
            get { return _pnDonotmail2; }
            set { _pnDonotmail2 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_DONOTMAIL3" field.
        /// </summary>
        public Byte PnDonotmail3
        {
            get { return _pnDonotmail3; }
            set { _pnDonotmail3 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_FAX" field.
        /// </summary>
        public Byte ProleDoNotFax
        {
            get { return _proleDoNotFax; }
            set { _proleDoNotFax = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_MAIL" field.
        /// </summary>
        public Byte ProleDoNotMail
        {
            get { return _proleDoNotMail; }
            set { _proleDoNotMail = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_FLAG_3" field.
        /// </summary>
        public Byte PnFlag3
        {
            get { return _pnFlag3; }
            set { _pnFlag3 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_DIS_FLAG" field.
        /// </summary>
        public Byte ProleDisFlag
        {
            get { return _proleDisFlag; }
            set { _proleDisFlag = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_USERNUM_1" field.
        /// </summary>
        public Byte ProleUsernum1
        {
            get { return _proleUsernum1; }
            set { _proleUsernum1 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_FLAG_2" field.
        /// </summary>
        public Byte PnFlag2
        {
            get { return _pnFlag2; }
            set { _pnFlag2 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_RESULTS_SIZE_OPT" field.
        /// </summary>
        public Byte ResultsSizeOpt
        {
            get { return _resultsSizeOpt; }
            set { _resultsSizeOpt = value; }
        }

        /// <summary>
        ///     the value of the "QRY_RESULTS_SIZE" field.
        /// </summary>
        public Int64 ResultsSize
        {
            get { return _resultsSize; }
            set { _resultsSize = value; }
        }

        /// <summary>
        ///     the value of the "QRY_SCHED_RUN_DATE" field.
        /// </summary>
        public DateTime? SchedRunDate
        {
            get { return _schedRunDate; }
            set { _schedRunDate = value; }
        }

        /// <summary>
        ///     the value of the "QRY_SCHED_RUN_TIME" field.
        /// </summary>
        public DateTime? SchedRunTime
        {
            get { return _schedRunTime; }
            set { _schedRunTime = value; }
        }

        /// <summary>
        ///     the value of the "QRY_CALCULATED_DATE" field.
        /// </summary>
        public DateTime? CalculatedDate
        {
            get { return _calculatedDate; }
            set { _calculatedDate = value; }
        }

        /// <summary>
        ///     the value of the "QRY_OUTPUT_DATE" field.
        /// </summary>
        public DateTime? OutputDate
        {
            get { return _outputDate; }
            set { _outputDate = value; }
        }

        /// <summary>
        ///     the value of the "QRY_TOTAL_RECORDS" field.
        /// </summary>
        public Int64 TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }

        /// <summary>
        ///     the value of the "QRY_SAMPLE" field.
        /// </summary>
        public Int64 Sample
        {
            get { return _sample; }
            set { _sample = value; }
        }

        /// <summary>
        ///     the value of the "QRY_SEEDS" field.
        /// </summary>
        public Int64 Seeds
        {
            get { return _seeds; }
            set { _seeds = value; }
        }

        /// <summary>
        ///     the value of the "QRY_IN_USE" field.
        /// </summary>
        public Byte InUse
        {
            get { return _inUse; }
            set { _inUse = value; }
        }

        /// <summary>
        ///     the value of the "QRY_LAST_RESULT_FILE" field.
        /// </summary>
        public String LastResultFile
        {
            get { return _lastResultFile; }
            set { _lastResultFile = value; }
        }

        /// <summary>
        ///     the value of the "QRY_APP_STATUS" field.
        /// </summary>
        public Byte AppStatus
        {
            get { return _appStatus; }
            set { _appStatus = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SWAP" field.
        /// </summary>
        public Byte ProleDoNotSwap
        {
            get { return _proleDoNotSwap; }
            set { _proleDoNotSwap = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_FLAG_1" field.
        /// </summary>
        public Byte PnFlag1
        {
            get { return _pnFlag1; }
            set { _pnFlag1 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        public Byte ProleDoNotEmail
        {
            get { return _proleDoNotEmail; }
            set { _proleDoNotEmail = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SPARE" field.
        /// </summary>
        public Byte ProleDoNotSpare
        {
            get { return _proleDoNotSpare; }
            set { _proleDoNotSpare = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ORG_DONOTMAIL" field.
        /// </summary>
        public Byte OrgDonotmail
        {
            get { return _orgDonotmail; }
            set { _orgDonotmail = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ORG_USERNUM_1" field.
        /// </summary>
        public Byte OrgUsernum1
        {
            get { return _orgUsernum1; }
            set { _orgUsernum1 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ORG_FLAG_1" field.
        /// </summary>
        public Byte OrgFlag1
        {
            get { return _orgFlag1; }
            set { _orgFlag1 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ORG_DONOTFAX" field.
        /// </summary>
        public Byte OrgDonotfax
        {
            get { return _orgDonotfax; }
            set { _orgDonotfax = value; }
        }

        /// <summary>
        ///     the value of the "QRY_DP_SETTING" field.
        /// </summary>
        public Byte DpSetting
        {
            get { return _dpSetting; }
            set { _dpSetting = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SPARE1" field.
        /// </summary>
        public Byte? ProleDoNotSpare1
        {
            get { return _proleDoNotSpare1; }
            set { _proleDoNotSpare1 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SPARE2" field.
        /// </summary>
        public Byte? ProleDoNotSpare2
        {
            get { return _proleDoNotSpare2; }
            set { _proleDoNotSpare2 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SPARE3" field.
        /// </summary>
        public Byte? ProleDoNotSpare3
        {
            get { return _proleDoNotSpare3; }
            set { _proleDoNotSpare3 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PROLE_DO_NOT_SPARE4" field.
        /// </summary>
        public Byte? ProleDoNotSpare4
        {
            get { return _proleDoNotSpare4; }
            set { _proleDoNotSpare4 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_DO_NOT_SPARE1" field.
        /// </summary>
        public Byte? PnDoNotSpare1
        {
            get { return _pnDoNotSpare1; }
            set { _pnDoNotSpare1 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_DO_NOT_SPARE2" field.
        /// </summary>
        public Byte? PnDoNotSpare2
        {
            get { return _pnDoNotSpare2; }
            set { _pnDoNotSpare2 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_DO_NOT_SPARE3" field.
        /// </summary>
        public Byte? PnDoNotSpare3
        {
            get { return _pnDoNotSpare3; }
            set { _pnDoNotSpare3 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_PN_DO_NOT_SPARE4" field.
        /// </summary>
        public Byte? PnDoNotSpare4
        {
            get { return _pnDoNotSpare4; }
            set { _pnDoNotSpare4 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ORG_DO_NOT_SPARE1" field.
        /// </summary>
        public Byte? OrgDoNotSpare1
        {
            get { return _orgDoNotSpare1; }
            set { _orgDoNotSpare1 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ORG_DO_NOT_SPARE2" field.
        /// </summary>
        public Byte? OrgDoNotSpare2
        {
            get { return _orgDoNotSpare2; }
            set { _orgDoNotSpare2 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ORG_DO_NOT_SPARE3" field.
        /// </summary>
        public Byte? OrgDoNotSpare3
        {
            get { return _orgDoNotSpare3; }
            set { _orgDoNotSpare3 = value; }
        }

        /// <summary>
        ///     the value of the "QRY_ORG_DO_NOT_SPARE4" field.
        /// </summary>
        public Byte? OrgDoNotSpare4
        {
            get { return _orgDoNotSpare4; }
            set { _orgDoNotSpare4 = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SaqQueryRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SaqQueryRecord" /> object instance.
        /// </returns>
        public SaqQueryRecord Clone()
        {
            SaqQueryRecord record = new SaqQueryRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.QgId = this.QgId;
            record.QoffId = this.QoffId;
            record.Name = this.Name;
            record.Desc = this.Desc;
            record.Status = this.Status;
            record.PmId = this.PmId;
            record.CourseId = this.CourseId;
            record.Channel = this.Channel;
            record.MgrProleId = this.MgrProleId;
            record.AppByProleId = this.AppByProleId;
            record.TitleSlug = this.TitleSlug;
            record.OrgOnly = this.OrgOnly;
            record.OrgDedupe = this.OrgDedupe;
            record.PnDedupe = this.PnDedupe;
            record.SaveMailSample = this.SaveMailSample;
            record.Locked = this.Locked;
            record.PeoplePerOrg = this.PeoplePerOrg;
            record.PnDonotmail = this.PnDonotmail;
            record.PnDonotmail2 = this.PnDonotmail2;
            record.PnDonotmail3 = this.PnDonotmail3;
            record.ProleDoNotFax = this.ProleDoNotFax;
            record.ProleDoNotMail = this.ProleDoNotMail;
            record.PnFlag3 = this.PnFlag3;
            record.ProleDisFlag = this.ProleDisFlag;
            record.ProleUsernum1 = this.ProleUsernum1;
            record.PnFlag2 = this.PnFlag2;
            record.ResultsSizeOpt = this.ResultsSizeOpt;
            record.ResultsSize = this.ResultsSize;
            record.SchedRunDate = this.SchedRunDate;
            record.SchedRunTime = this.SchedRunTime;
            record.CalculatedDate = this.CalculatedDate;
            record.OutputDate = this.OutputDate;
            record.TotalRecords = this.TotalRecords;
            record.Sample = this.Sample;
            record.Seeds = this.Seeds;
            record.InUse = this.InUse;
            record.LastResultFile = this.LastResultFile;
            record.AppStatus = this.AppStatus;
            record.ProleDoNotSwap = this.ProleDoNotSwap;
            record.PnFlag1 = this.PnFlag1;
            record.ProleDoNotEmail = this.ProleDoNotEmail;
            record.ProleDoNotSpare = this.ProleDoNotSpare;
            record.OrgDonotmail = this.OrgDonotmail;
            record.OrgUsernum1 = this.OrgUsernum1;
            record.OrgFlag1 = this.OrgFlag1;
            record.OrgDonotfax = this.OrgDonotfax;
            record.DpSetting = this.DpSetting;
            record.ProleDoNotSpare1 = this.ProleDoNotSpare1;
            record.ProleDoNotSpare2 = this.ProleDoNotSpare2;
            record.ProleDoNotSpare3 = this.ProleDoNotSpare3;
            record.ProleDoNotSpare4 = this.ProleDoNotSpare4;
            record.PnDoNotSpare1 = this.PnDoNotSpare1;
            record.PnDoNotSpare2 = this.PnDoNotSpare2;
            record.PnDoNotSpare3 = this.PnDoNotSpare3;
            record.PnDoNotSpare4 = this.PnDoNotSpare4;
            record.OrgDoNotSpare1 = this.OrgDoNotSpare1;
            record.OrgDoNotSpare2 = this.OrgDoNotSpare2;
            record.OrgDoNotSpare3 = this.OrgDoNotSpare3;
            record.OrgDoNotSpare4 = this.OrgDoNotSpare4;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SaqQueryRecord" /> instance is equal to another <see cref="SaqQueryRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SaqQueryRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SaqQueryRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.QgId == that.QgId);
            result = result && (this.QoffId == that.QoffId);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Desc.TrimOrNullify() == that.Desc.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.PmId.TrimOrNullify() == that.PmId.TrimOrNullify());
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.Channel.TrimOrNullify() == that.Channel.TrimOrNullify());
            result = result && (this.MgrProleId.TrimOrNullify() == that.MgrProleId.TrimOrNullify());
            result = result && (this.AppByProleId.TrimOrNullify() == that.AppByProleId.TrimOrNullify());
            result = result && (this.TitleSlug.TrimOrNullify() == that.TitleSlug.TrimOrNullify());
            result = result && (this.OrgOnly == that.OrgOnly);
            result = result && (this.OrgDedupe == that.OrgDedupe);
            result = result && (this.PnDedupe == that.PnDedupe);
            result = result && (this.SaveMailSample == that.SaveMailSample);
            result = result && (this.Locked == that.Locked);
            result = result && (this.PeoplePerOrg == that.PeoplePerOrg);
            result = result && (this.PnDonotmail == that.PnDonotmail);
            result = result && (this.PnDonotmail2 == that.PnDonotmail2);
            result = result && (this.PnDonotmail3 == that.PnDonotmail3);
            result = result && (this.ProleDoNotFax == that.ProleDoNotFax);
            result = result && (this.ProleDoNotMail == that.ProleDoNotMail);
            result = result && (this.PnFlag3 == that.PnFlag3);
            result = result && (this.ProleDisFlag == that.ProleDisFlag);
            result = result && (this.ProleUsernum1 == that.ProleUsernum1);
            result = result && (this.PnFlag2 == that.PnFlag2);
            result = result && (this.ResultsSizeOpt == that.ResultsSizeOpt);
            result = result && (this.ResultsSize == that.ResultsSize);
            result = result && (this.SchedRunDate == that.SchedRunDate);
            result = result && (this.SchedRunTime == that.SchedRunTime);
            result = result && (this.CalculatedDate == that.CalculatedDate);
            result = result && (this.OutputDate == that.OutputDate);
            result = result && (this.TotalRecords == that.TotalRecords);
            result = result && (this.Sample == that.Sample);
            result = result && (this.Seeds == that.Seeds);
            result = result && (this.InUse == that.InUse);
            result = result && (this.LastResultFile.TrimOrNullify() == that.LastResultFile.TrimOrNullify());
            result = result && (this.AppStatus == that.AppStatus);
            result = result && (this.ProleDoNotSwap == that.ProleDoNotSwap);
            result = result && (this.PnFlag1 == that.PnFlag1);
            result = result && (this.ProleDoNotEmail == that.ProleDoNotEmail);
            result = result && (this.ProleDoNotSpare == that.ProleDoNotSpare);
            result = result && (this.OrgDonotmail == that.OrgDonotmail);
            result = result && (this.OrgUsernum1 == that.OrgUsernum1);
            result = result && (this.OrgFlag1 == that.OrgFlag1);
            result = result && (this.OrgDonotfax == that.OrgDonotfax);
            result = result && (this.DpSetting == that.DpSetting);
            result = result && (this.ProleDoNotSpare1 == that.ProleDoNotSpare1);
            result = result && (this.ProleDoNotSpare2 == that.ProleDoNotSpare2);
            result = result && (this.ProleDoNotSpare3 == that.ProleDoNotSpare3);
            result = result && (this.ProleDoNotSpare4 == that.ProleDoNotSpare4);
            result = result && (this.PnDoNotSpare1 == that.PnDoNotSpare1);
            result = result && (this.PnDoNotSpare2 == that.PnDoNotSpare2);
            result = result && (this.PnDoNotSpare3 == that.PnDoNotSpare3);
            result = result && (this.PnDoNotSpare4 == that.PnDoNotSpare4);
            result = result && (this.OrgDoNotSpare1 == that.OrgDoNotSpare1);
            result = result && (this.OrgDoNotSpare2 == that.OrgDoNotSpare2);
            result = result && (this.OrgDoNotSpare3 == that.OrgDoNotSpare3);
            result = result && (this.OrgDoNotSpare4 == that.OrgDoNotSpare4);
            return result;
        }

        #endregion
    }
}
