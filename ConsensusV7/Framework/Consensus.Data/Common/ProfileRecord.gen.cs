using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "Profile" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ProfileRecord : Record<String>, Cloneable<ProfileRecord>, IEquatable<ProfileRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PROF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PROF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PROF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PROF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PROF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PROF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PROF_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "PROF_PERSON_ID" field.
        /// </summary>
        private String _personId;

        /// <summary>
        ///     the value of the "PROF_ROLE_ID" field.
        /// </summary>
        private String _roleId;

        /// <summary>
        ///     the value of the "PROF_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "PROF_KEY" field.
        /// </summary>
        private String _key;

        /// <summary>
        ///     the value of the "PROF_VALUE" field.
        /// </summary>
        private String _value;

        /// <summary>
        ///     the value of the "PROF_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "PROF_DATE" field.
        /// </summary>
        private DateTime? _date;

        /// <summary>
        ///     the value of the "PROF_MR_TOP" field.
        /// </summary>
        private String _mrTop;

        /// <summary>
        ///     the value of the "PROF_MR_ID" field.
        /// </summary>
        private String _mrId;

        /// <summary>
        ///     the value of the "PROF_MR_QUEST_PAR" field.
        /// </summary>
        private String _mrQuestPar;

        /// <summary>
        ///     the value of the "PROF_MR_QUEST_KEY" field.
        /// </summary>
        private Int32? _mrQuestKey;

        /// <summary>
        ///     the value of the "PROF_MR_ANSW_TYPE" field.
        /// </summary>
        private Byte? _mrAnswType;

        /// <summary>
        ///     the value of the "PROF_MR_NUM" field.
        /// </summary>
        private Double? _mrNum;

        /// <summary>
        ///     the value of the "PROF_MR_ALPHA" field.
        /// </summary>
        private String _mrAlpha;

        /// <summary>
        ///     the value of the "PROF_MR_CHK1" field.
        /// </summary>
        private Byte? _mrChk1;

        /// <summary>
        ///     the value of the "PROF_MR_CHK2" field.
        /// </summary>
        private Byte? _mrChk2;

        /// <summary>
        ///     the value of the "PROF_MR_CHK3" field.
        /// </summary>
        private Byte? _mrChk3;

        /// <summary>
        ///     the value of the "PROF_MR_CHK4" field.
        /// </summary>
        private Byte? _mrChk4;

        /// <summary>
        ///     the value of the "PROF_MR_CHK5" field.
        /// </summary>
        private Byte? _mrChk5;

        /// <summary>
        ///     the value of the "PROF_MR_OPT" field.
        /// </summary>
        private Byte? _mrOpt;

        /// <summary>
        ///     the value of the "PROF_MR_CHILD" field.
        /// </summary>
        private String _mrChild;

        /// <summary>
        ///     the value of the "PROF_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PROF_OPP_ID" field.
        /// </summary>
        private String _oppId;

        /// <summary>
        ///     the value of the "PROF_MR_LINK_TYPE" field.
        /// </summary>
        private Byte? _mrLinkType;

        /// <summary>
        ///     the value of the "PROF_VALUE3" field.
        /// </summary>
        private String _value3;

        /// <summary>
        ///     the value of the "PROF_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "PROF_USERNUM_1" field.
        /// </summary>
        private Double? _usernum1;

        /// <summary>
        ///     the value of the "PROF_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "PROF_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "PROF_SELECT_DTE" field.
        /// </summary>
        private DateTime? _selectDte;

        /// <summary>
        ///     the value of the "PROF_MAIL_DATE" field.
        /// </summary>
        private DateTime? _mailDate;

        /// <summary>
        ///     the value of the "PROF_DTE_PASSED" field.
        /// </summary>
        private DateTime? _dtePassed;

        /// <summary>
        ///     the value of the "PROF_PHONE_DTE" field.
        /// </summary>
        private DateTime? _phoneDte;

        /// <summary>
        ///     the value of the "PROF_USERDATE_1" field.
        /// </summary>
        private DateTime? _userdate1;

        /// <summary>
        ///     the value of the "PROF_USERDATE_2" field.
        /// </summary>
        private DateTime? _userdate2;

        /// <summary>
        ///     the value of the "PROF_USERDATE_3" field.
        /// </summary>
        private DateTime? _userdate3;

        /// <summary>
        ///     the value of the "PROF_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "PROF_USERNUM_2" field.
        /// </summary>
        private Double? _usernum2;

        /// <summary>
        ///     the value of the "PROF_USERNUM_3" field.
        /// </summary>
        private Double? _usernum3;

        /// <summary>
        ///     the value of the "PROF_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "PROF_SPOUSE_NAM" field.
        /// </summary>
        private String _spouseNam;

        /// <summary>
        ///     the value of the "PROF_DIET1" field.
        /// </summary>
        private String _diet1;

        /// <summary>
        ///     the value of the "PROF_DIET2" field.
        /// </summary>
        private String _diet2;

        /// <summary>
        ///     the value of the "PROF_ACCPT_DTE" field.
        /// </summary>
        private DateTime? _accptDte;

        /// <summary>
        ///     the value of the "PROF_PGP_ID" field.
        /// </summary>
        private String _pgpId;

        /// <summary>
        ///     the value of the "PROF_VALUE2" field.
        /// </summary>
        private String _value2;

        /// <summary>
        ///     the value of the "PROF_LINK_ID" field.
        /// </summary>
        private String _linkId;

        /// <summary>
        ///     the value of the "PROF_LINK_TYPE" field.
        /// </summary>
        private Byte? _linkType;

        /// <summary>
        ///     the value of the "PROF_PROJ_ID" field.
        /// </summary>
        private String _projId;

        /// <summary>
        ///     the value of the "PROF_COST" field.
        /// </summary>
        private Decimal? _cost;

        /// <summary>
        ///     the value of the "PROF_QUAL_ID" field.
        /// </summary>
        private String _qualId;

        /// <summary>
        ///     the value of the "PROF_LOC_ID" field.
        /// </summary>
        private String _locId;

        /// <summary>
        ///     the value of the "PROF_ATTRIB_TINT_01" field.
        /// </summary>
        private Byte? _attribTint01;

        /// <summary>
        ///     the value of the "PROF_PDS_ID" field.
        /// </summary>
        private String _pdsId;

        /// <summary>
        ///     the value of the "PROF_TRAIN_ID" field.
        /// </summary>
        private String _trainId;

        /// <summary>
        ///     the value of the "PROF_MEM_ID" field.
        /// </summary>
        private String _memId;

        /// <summary>
        ///     the value of the "PROF_DEL_ID" field.
        /// </summary>
        private String _delId;

        /// <summary>
        ///     the value of the "PROF_CERT_ID" field.
        /// </summary>
        private String _certId;

        /// <summary>
        ///     the value of the "PROF_VOL_ID" field.
        /// </summary>
        private String _volId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PROF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PROF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PROF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PROF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PROF_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_ROLE_ID" field.
        /// </summary>
        public String RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_KEY" field.
        /// </summary>
        public String Key
        {
            get { return _key; }
            set { _key = value; }
        }

        /// <summary>
        ///     the value of the "PROF_VALUE" field.
        /// </summary>
        public String Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        ///     the value of the "PROF_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "PROF_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_TOP" field.
        /// </summary>
        public String MrTop
        {
            get { return _mrTop; }
            set { _mrTop = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_ID" field.
        /// </summary>
        public String MrId
        {
            get { return _mrId; }
            set { _mrId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_QUEST_PAR" field.
        /// </summary>
        public String MrQuestPar
        {
            get { return _mrQuestPar; }
            set { _mrQuestPar = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_QUEST_KEY" field.
        /// </summary>
        public Int32? MrQuestKey
        {
            get { return _mrQuestKey; }
            set { _mrQuestKey = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_ANSW_TYPE" field.
        /// </summary>
        public Byte? MrAnswType
        {
            get { return _mrAnswType; }
            set { _mrAnswType = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_NUM" field.
        /// </summary>
        public Double? MrNum
        {
            get { return _mrNum; }
            set { _mrNum = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_ALPHA" field.
        /// </summary>
        public String MrAlpha
        {
            get { return _mrAlpha; }
            set { _mrAlpha = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_CHK1" field.
        /// </summary>
        public Byte? MrChk1
        {
            get { return _mrChk1; }
            set { _mrChk1 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_CHK2" field.
        /// </summary>
        public Byte? MrChk2
        {
            get { return _mrChk2; }
            set { _mrChk2 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_CHK3" field.
        /// </summary>
        public Byte? MrChk3
        {
            get { return _mrChk3; }
            set { _mrChk3 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_CHK4" field.
        /// </summary>
        public Byte? MrChk4
        {
            get { return _mrChk4; }
            set { _mrChk4 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_CHK5" field.
        /// </summary>
        public Byte? MrChk5
        {
            get { return _mrChk5; }
            set { _mrChk5 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_OPT" field.
        /// </summary>
        public Byte? MrOpt
        {
            get { return _mrOpt; }
            set { _mrOpt = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_CHILD" field.
        /// </summary>
        public String MrChild
        {
            get { return _mrChild; }
            set { _mrChild = value; }
        }

        /// <summary>
        ///     the value of the "PROF_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PROF_OPP_ID" field.
        /// </summary>
        public String OppId
        {
            get { return _oppId; }
            set { _oppId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MR_LINK_TYPE" field.
        /// </summary>
        public Byte? MrLinkType
        {
            get { return _mrLinkType; }
            set { _mrLinkType = value; }
        }

        /// <summary>
        ///     the value of the "PROF_VALUE3" field.
        /// </summary>
        public String Value3
        {
            get { return _value3; }
            set { _value3 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_USERNUM_1" field.
        /// </summary>
        public Double? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_SELECT_DTE" field.
        /// </summary>
        public DateTime? SelectDte
        {
            get { return _selectDte; }
            set { _selectDte = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MAIL_DATE" field.
        /// </summary>
        public DateTime? MailDate
        {
            get { return _mailDate; }
            set { _mailDate = value; }
        }

        /// <summary>
        ///     the value of the "PROF_DTE_PASSED" field.
        /// </summary>
        public DateTime? DtePassed
        {
            get { return _dtePassed; }
            set { _dtePassed = value; }
        }

        /// <summary>
        ///     the value of the "PROF_PHONE_DTE" field.
        /// </summary>
        public DateTime? PhoneDte
        {
            get { return _phoneDte; }
            set { _phoneDte = value; }
        }

        /// <summary>
        ///     the value of the "PROF_USERDATE_1" field.
        /// </summary>
        public DateTime? Userdate1
        {
            get { return _userdate1; }
            set { _userdate1 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_USERDATE_2" field.
        /// </summary>
        public DateTime? Userdate2
        {
            get { return _userdate2; }
            set { _userdate2 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_USERDATE_3" field.
        /// </summary>
        public DateTime? Userdate3
        {
            get { return _userdate3; }
            set { _userdate3 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_USERNUM_2" field.
        /// </summary>
        public Double? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_USERNUM_3" field.
        /// </summary>
        public Double? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "PROF_SPOUSE_NAM" field.
        /// </summary>
        public String SpouseNam
        {
            get { return _spouseNam; }
            set { _spouseNam = value; }
        }

        /// <summary>
        ///     the value of the "PROF_DIET1" field.
        /// </summary>
        public String Diet1
        {
            get { return _diet1; }
            set { _diet1 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_DIET2" field.
        /// </summary>
        public String Diet2
        {
            get { return _diet2; }
            set { _diet2 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_ACCPT_DTE" field.
        /// </summary>
        public DateTime? AccptDte
        {
            get { return _accptDte; }
            set { _accptDte = value; }
        }

        /// <summary>
        ///     the value of the "PROF_PGP_ID" field.
        /// </summary>
        public String PgpId
        {
            get { return _pgpId; }
            set { _pgpId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_VALUE2" field.
        /// </summary>
        public String Value2
        {
            get { return _value2; }
            set { _value2 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_LINK_ID" field.
        /// </summary>
        public String LinkId
        {
            get { return _linkId; }
            set { _linkId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_LINK_TYPE" field.
        /// </summary>
        public Byte? LinkType
        {
            get { return _linkType; }
            set { _linkType = value; }
        }

        /// <summary>
        ///     the value of the "PROF_PROJ_ID" field.
        /// </summary>
        public String ProjId
        {
            get { return _projId; }
            set { _projId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_COST" field.
        /// </summary>
        public Decimal? Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        ///     the value of the "PROF_QUAL_ID" field.
        /// </summary>
        public String QualId
        {
            get { return _qualId; }
            set { _qualId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_LOC_ID" field.
        /// </summary>
        public String LocId
        {
            get { return _locId; }
            set { _locId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_ATTRIB_TINT_01" field.
        /// </summary>
        public Byte? AttribTint01
        {
            get { return _attribTint01; }
            set { _attribTint01 = value; }
        }

        /// <summary>
        ///     the value of the "PROF_PDS_ID" field.
        /// </summary>
        public String PdsId
        {
            get { return _pdsId; }
            set { _pdsId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_TRAIN_ID" field.
        /// </summary>
        public String TrainId
        {
            get { return _trainId; }
            set { _trainId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_MEM_ID" field.
        /// </summary>
        public String MemId
        {
            get { return _memId; }
            set { _memId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_DEL_ID" field.
        /// </summary>
        public String DelId
        {
            get { return _delId; }
            set { _delId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_CERT_ID" field.
        /// </summary>
        public String CertId
        {
            get { return _certId; }
            set { _certId = value; }
        }

        /// <summary>
        ///     the value of the "PROF_VOL_ID" field.
        /// </summary>
        public String VolId
        {
            get { return _volId; }
            set { _volId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ProfileRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ProfileRecord" /> object instance.
        /// </returns>
        public ProfileRecord Clone()
        {
            ProfileRecord record = new ProfileRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.OrgId = this.OrgId;
            record.PersonId = this.PersonId;
            record.RoleId = this.RoleId;
            record.ProdId = this.ProdId;
            record.Key = this.Key;
            record.Value = this.Value;
            record.Notes = this.Notes;
            record.Date = this.Date;
            record.MrTop = this.MrTop;
            record.MrId = this.MrId;
            record.MrQuestPar = this.MrQuestPar;
            record.MrQuestKey = this.MrQuestKey;
            record.MrAnswType = this.MrAnswType;
            record.MrNum = this.MrNum;
            record.MrAlpha = this.MrAlpha;
            record.MrChk1 = this.MrChk1;
            record.MrChk2 = this.MrChk2;
            record.MrChk3 = this.MrChk3;
            record.MrChk4 = this.MrChk4;
            record.MrChk5 = this.MrChk5;
            record.MrOpt = this.MrOpt;
            record.MrChild = this.MrChild;
            record.Lock = this.Lock;
            record.OppId = this.OppId;
            record.MrLinkType = this.MrLinkType;
            record.Value3 = this.Value3;
            record.Userchar1 = this.Userchar1;
            record.Usernum1 = this.Usernum1;
            record.Userchar2 = this.Userchar2;
            record.CourseId = this.CourseId;
            record.SelectDte = this.SelectDte;
            record.MailDate = this.MailDate;
            record.DtePassed = this.DtePassed;
            record.PhoneDte = this.PhoneDte;
            record.Userdate1 = this.Userdate1;
            record.Userdate2 = this.Userdate2;
            record.Userdate3 = this.Userdate3;
            record.Userchar3 = this.Userchar3;
            record.Usernum2 = this.Usernum2;
            record.Usernum3 = this.Usernum3;
            record.Status = this.Status;
            record.SpouseNam = this.SpouseNam;
            record.Diet1 = this.Diet1;
            record.Diet2 = this.Diet2;
            record.AccptDte = this.AccptDte;
            record.PgpId = this.PgpId;
            record.Value2 = this.Value2;
            record.LinkId = this.LinkId;
            record.LinkType = this.LinkType;
            record.ProjId = this.ProjId;
            record.Cost = this.Cost;
            record.QualId = this.QualId;
            record.LocId = this.LocId;
            record.AttribTint01 = this.AttribTint01;
            record.PdsId = this.PdsId;
            record.TrainId = this.TrainId;
            record.MemId = this.MemId;
            record.DelId = this.DelId;
            record.CertId = this.CertId;
            record.VolId = this.VolId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ProfileRecord" /> instance is equal to another <see cref="ProfileRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ProfileRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ProfileRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.PersonId.TrimOrNullify() == that.PersonId.TrimOrNullify());
            result = result && (this.RoleId.TrimOrNullify() == that.RoleId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.Key.TrimOrNullify() == that.Key.TrimOrNullify());
            result = result && (this.Value.TrimOrNullify() == that.Value.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Date == that.Date);
            result = result && (this.MrTop.TrimOrNullify() == that.MrTop.TrimOrNullify());
            result = result && (this.MrId.TrimOrNullify() == that.MrId.TrimOrNullify());
            result = result && (this.MrQuestPar.TrimOrNullify() == that.MrQuestPar.TrimOrNullify());
            result = result && (this.MrQuestKey == that.MrQuestKey);
            result = result && (this.MrAnswType == that.MrAnswType);
            result = result && (this.MrNum == that.MrNum);
            result = result && (this.MrAlpha.TrimOrNullify() == that.MrAlpha.TrimOrNullify());
            result = result && (this.MrChk1 == that.MrChk1);
            result = result && (this.MrChk2 == that.MrChk2);
            result = result && (this.MrChk3 == that.MrChk3);
            result = result && (this.MrChk4 == that.MrChk4);
            result = result && (this.MrChk5 == that.MrChk5);
            result = result && (this.MrOpt == that.MrOpt);
            result = result && (this.MrChild.TrimOrNullify() == that.MrChild.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.OppId.TrimOrNullify() == that.OppId.TrimOrNullify());
            result = result && (this.MrLinkType == that.MrLinkType);
            result = result && (this.Value3.TrimOrNullify() == that.Value3.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.SelectDte == that.SelectDte);
            result = result && (this.MailDate == that.MailDate);
            result = result && (this.DtePassed == that.DtePassed);
            result = result && (this.PhoneDte == that.PhoneDte);
            result = result && (this.Userdate1 == that.Userdate1);
            result = result && (this.Userdate2 == that.Userdate2);
            result = result && (this.Userdate3 == that.Userdate3);
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Usernum3 == that.Usernum3);
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.SpouseNam.TrimOrNullify() == that.SpouseNam.TrimOrNullify());
            result = result && (this.Diet1.TrimOrNullify() == that.Diet1.TrimOrNullify());
            result = result && (this.Diet2.TrimOrNullify() == that.Diet2.TrimOrNullify());
            result = result && (this.AccptDte == that.AccptDte);
            result = result && (this.PgpId.TrimOrNullify() == that.PgpId.TrimOrNullify());
            result = result && (this.Value2.TrimOrNullify() == that.Value2.TrimOrNullify());
            result = result && (this.LinkId.TrimOrNullify() == that.LinkId.TrimOrNullify());
            result = result && (this.LinkType == that.LinkType);
            result = result && (this.ProjId.TrimOrNullify() == that.ProjId.TrimOrNullify());
            result = result && (this.Cost == that.Cost);
            result = result && (this.QualId.TrimOrNullify() == that.QualId.TrimOrNullify());
            result = result && (this.LocId.TrimOrNullify() == that.LocId.TrimOrNullify());
            result = result && (this.AttribTint01 == that.AttribTint01);
            result = result && (this.PdsId.TrimOrNullify() == that.PdsId.TrimOrNullify());
            result = result && (this.TrainId.TrimOrNullify() == that.TrainId.TrimOrNullify());
            result = result && (this.MemId.TrimOrNullify() == that.MemId.TrimOrNullify());
            result = result && (this.DelId.TrimOrNullify() == that.DelId.TrimOrNullify());
            result = result && (this.CertId.TrimOrNullify() == that.CertId.TrimOrNullify());
            result = result && (this.VolId.TrimOrNullify() == that.VolId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
