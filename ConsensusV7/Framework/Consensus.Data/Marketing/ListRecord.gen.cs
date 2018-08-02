using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents the "List" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ListRecord : Record<String>, Cloneable<ListRecord>, IEquatable<ListRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "LIST_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "LIST_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "LIST_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "LIST_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "LIST_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "LIST_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "LIST_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "LIST_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "LIST_SUPPLIER_ID" field.
        /// </summary>
        private String _supplierId;

        /// <summary>
        ///     the value of the "LIST_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "LIST_DATE" field.
        /// </summary>
        private DateTime? _date;

        /// <summary>
        ///     the value of the "LIST_USER_ID" field.
        /// </summary>
        private String _userId;

        /// <summary>
        ///     the value of the "LIST_ENTRIES" field.
        /// </summary>
        private Double? _entries;

        /// <summary>
        ///     the value of the "LIST_DUPLICATES" field.
        /// </summary>
        private Double? _duplicates;

        /// <summary>
        ///     the value of the "LIST_NEW_ORG" field.
        /// </summary>
        private Double? _newOrg;

        /// <summary>
        ///     the value of the "LIST_NEW_PERSON" field.
        /// </summary>
        private Double? _newPerson;

        /// <summary>
        ///     the value of the "LIST_PRICE" field.
        /// </summary>
        private Double? _price;

        /// <summary>
        ///     the value of the "LIST_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "LIST_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "LIST_NEW_ADDRESSES" field.
        /// </summary>
        private Double? _newAddresses;

        /// <summary>
        ///     the value of the "LIST_LIMIT" field.
        /// </summary>
        private Double? _limit;

        /// <summary>
        ///     the value of the "LIST_UNTIL" field.
        /// </summary>
        private DateTime? _until;

        /// <summary>
        ///     the value of the "LIST_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "LIST_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "LIST_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "LIST_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "LIST_USERCHAR_5" field.
        /// </summary>
        private String _userchar5;

        /// <summary>
        ///     the value of the "LIST_USERCHAR_6" field.
        /// </summary>
        private String _userchar6;

        /// <summary>
        ///     the value of the "LIST_COURSE_ID" field.
        /// </summary>
        private String _courseId;

        /// <summary>
        ///     the value of the "LIST_PROCESS" field.
        /// </summary>
        private String _process;

        /// <summary>
        ///     the value of the "LIST_COUNTRY" field.
        /// </summary>
        private String _country;

        /// <summary>
        ///     the value of the "LIST_IMP_STATUS" field.
        /// </summary>
        private Byte? _impStatus;

        /// <summary>
        ///     the value of the "LIST_JOB_LU" field.
        /// </summary>
        private Byte? _jobLu;

        /// <summary>
        ///     the value of the "LIST_LINES" field.
        /// </summary>
        private Int32? _lines;

        /// <summary>
        ///     the value of the "LIST_COUNTRY_LU" field.
        /// </summary>
        private Byte? _countryLu;

        /// <summary>
        ///     the value of the "LIST_INCOMPLETE" field.
        /// </summary>
        private Int32? _incomplete;

        /// <summary>
        ///     the value of the "LIST_INVALID_IND" field.
        /// </summary>
        private Int32? _invalidInd;

        /// <summary>
        ///     the value of the "LIST_INVALID_CO" field.
        /// </summary>
        private Int32? _invalidCo;

        /// <summary>
        ///     the value of the "LIST_DELIMIT" field.
        /// </summary>
        private Byte? _delimit;

        /// <summary>
        ///     the value of the "LIST_HEADER" field.
        /// </summary>
        private Byte? _header;

        /// <summary>
        ///     the value of the "LIST_ETT_ID" field.
        /// </summary>
        private String _ettId;

        /// <summary>
        ///     the value of the "LIST_WEB_ENABLED" field.
        /// </summary>
        private Byte _webEnabled;

        /// <summary>
        ///     the value of the "LIST_NOTES_HTML" field.
        /// </summary>
        private String _notesHtml;

        /// <summary>
        ///     the value of the "LIST_IS_DYNAMIC" field.
        /// </summary>
        private Boolean _isDynamic;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "LIST_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "LIST_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "LIST_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "LIST_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "LIST_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "LIST_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "LIST_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "LIST_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "LIST_SUPPLIER_ID" field.
        /// </summary>
        public String SupplierId
        {
            get { return _supplierId; }
            set { _supplierId = value; }
        }

        /// <summary>
        ///     the value of the "LIST_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "LIST_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        ///     the value of the "LIST_USER_ID" field.
        /// </summary>
        public String UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        /// <summary>
        ///     the value of the "LIST_ENTRIES" field.
        /// </summary>
        public Double? Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }

        /// <summary>
        ///     the value of the "LIST_DUPLICATES" field.
        /// </summary>
        public Double? Duplicates
        {
            get { return _duplicates; }
            set { _duplicates = value; }
        }

        /// <summary>
        ///     the value of the "LIST_NEW_ORG" field.
        /// </summary>
        public Double? NewOrg
        {
            get { return _newOrg; }
            set { _newOrg = value; }
        }

        /// <summary>
        ///     the value of the "LIST_NEW_PERSON" field.
        /// </summary>
        public Double? NewPerson
        {
            get { return _newPerson; }
            set { _newPerson = value; }
        }

        /// <summary>
        ///     the value of the "LIST_PRICE" field.
        /// </summary>
        public Double? Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        ///     the value of the "LIST_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "LIST_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "LIST_NEW_ADDRESSES" field.
        /// </summary>
        public Double? NewAddresses
        {
            get { return _newAddresses; }
            set { _newAddresses = value; }
        }

        /// <summary>
        ///     the value of the "LIST_LIMIT" field.
        /// </summary>
        public Double? Limit
        {
            get { return _limit; }
            set { _limit = value; }
        }

        /// <summary>
        ///     the value of the "LIST_UNTIL" field.
        /// </summary>
        public DateTime? Until
        {
            get { return _until; }
            set { _until = value; }
        }

        /// <summary>
        ///     the value of the "LIST_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "LIST_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "LIST_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "LIST_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "LIST_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return _userchar5; }
            set { _userchar5 = value; }
        }

        /// <summary>
        ///     the value of the "LIST_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return _userchar6; }
            set { _userchar6 = value; }
        }

        /// <summary>
        ///     the value of the "LIST_COURSE_ID" field.
        /// </summary>
        public String CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

        /// <summary>
        ///     the value of the "LIST_PROCESS" field.
        /// </summary>
        public String Process
        {
            get { return _process; }
            set { _process = value; }
        }

        /// <summary>
        ///     the value of the "LIST_COUNTRY" field.
        /// </summary>
        public String Country
        {
            get { return _country; }
            set { _country = value; }
        }

        /// <summary>
        ///     the value of the "LIST_IMP_STATUS" field.
        /// </summary>
        public Byte? ImpStatus
        {
            get { return _impStatus; }
            set { _impStatus = value; }
        }

        /// <summary>
        ///     the value of the "LIST_JOB_LU" field.
        /// </summary>
        public Byte? JobLu
        {
            get { return _jobLu; }
            set { _jobLu = value; }
        }

        /// <summary>
        ///     the value of the "LIST_LINES" field.
        /// </summary>
        public Int32? Lines
        {
            get { return _lines; }
            set { _lines = value; }
        }

        /// <summary>
        ///     the value of the "LIST_COUNTRY_LU" field.
        /// </summary>
        public Byte? CountryLu
        {
            get { return _countryLu; }
            set { _countryLu = value; }
        }

        /// <summary>
        ///     the value of the "LIST_INCOMPLETE" field.
        /// </summary>
        public Int32? Incomplete
        {
            get { return _incomplete; }
            set { _incomplete = value; }
        }

        /// <summary>
        ///     the value of the "LIST_INVALID_IND" field.
        /// </summary>
        public Int32? InvalidInd
        {
            get { return _invalidInd; }
            set { _invalidInd = value; }
        }

        /// <summary>
        ///     the value of the "LIST_INVALID_CO" field.
        /// </summary>
        public Int32? InvalidCo
        {
            get { return _invalidCo; }
            set { _invalidCo = value; }
        }

        /// <summary>
        ///     the value of the "LIST_DELIMIT" field.
        /// </summary>
        public Byte? Delimit
        {
            get { return _delimit; }
            set { _delimit = value; }
        }

        /// <summary>
        ///     the value of the "LIST_HEADER" field.
        /// </summary>
        public Byte? Header
        {
            get { return _header; }
            set { _header = value; }
        }

        /// <summary>
        ///     the value of the "LIST_ETT_ID" field.
        /// </summary>
        public String EttId
        {
            get { return _ettId; }
            set { _ettId = value; }
        }

        /// <summary>
        ///     the value of the "LIST_WEB_ENABLED" field.
        /// </summary>
        public Byte WebEnabled
        {
            get { return _webEnabled; }
            set { _webEnabled = value; }
        }

        /// <summary>
        ///     the value of the "LIST_NOTES_HTML" field.
        /// </summary>
        public String NotesHtml
        {
            get { return _notesHtml; }
            set { _notesHtml = value; }
        }

        /// <summary>
        ///     the value of the "LIST_IS_DYNAMIC" field.
        /// </summary>
        public Boolean IsDynamic
        {
            get { return _isDynamic; }
            set { _isDynamic = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ListRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ListRecord" /> object instance.
        /// </returns>
        public ListRecord Clone()
        {
            ListRecord record = new ListRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Title = this.Title;
            record.SupplierId = this.SupplierId;
            record.ProleId = this.ProleId;
            record.Date = this.Date;
            record.UserId = this.UserId;
            record.Entries = this.Entries;
            record.Duplicates = this.Duplicates;
            record.NewOrg = this.NewOrg;
            record.NewPerson = this.NewPerson;
            record.Price = this.Price;
            record.Status = this.Status;
            record.Notes = this.Notes;
            record.NewAddresses = this.NewAddresses;
            record.Limit = this.Limit;
            record.Until = this.Until;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Userchar3 = this.Userchar3;
            record.Userchar4 = this.Userchar4;
            record.Userchar5 = this.Userchar5;
            record.Userchar6 = this.Userchar6;
            record.CourseId = this.CourseId;
            record.Process = this.Process;
            record.Country = this.Country;
            record.ImpStatus = this.ImpStatus;
            record.JobLu = this.JobLu;
            record.Lines = this.Lines;
            record.CountryLu = this.CountryLu;
            record.Incomplete = this.Incomplete;
            record.InvalidInd = this.InvalidInd;
            record.InvalidCo = this.InvalidCo;
            record.Delimit = this.Delimit;
            record.Header = this.Header;
            record.EttId = this.EttId;
            record.WebEnabled = this.WebEnabled;
            record.NotesHtml = this.NotesHtml;
            record.IsDynamic = this.IsDynamic;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ListRecord" /> instance is equal to another <see cref="ListRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ListRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ListRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.SupplierId.TrimOrNullify() == that.SupplierId.TrimOrNullify());
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.Date == that.Date);
            result = result && (this.UserId.TrimOrNullify() == that.UserId.TrimOrNullify());
            result = result && (this.Entries == that.Entries);
            result = result && (this.Duplicates == that.Duplicates);
            result = result && (this.NewOrg == that.NewOrg);
            result = result && (this.NewPerson == that.NewPerson);
            result = result && (this.Price == that.Price);
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.NewAddresses == that.NewAddresses);
            result = result && (this.Limit == that.Limit);
            result = result && (this.Until == that.Until);
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.Userchar5.TrimOrNullify() == that.Userchar5.TrimOrNullify());
            result = result && (this.Userchar6.TrimOrNullify() == that.Userchar6.TrimOrNullify());
            result = result && (this.CourseId.TrimOrNullify() == that.CourseId.TrimOrNullify());
            result = result && (this.Process.TrimOrNullify() == that.Process.TrimOrNullify());
            result = result && (this.Country.TrimOrNullify() == that.Country.TrimOrNullify());
            result = result && (this.ImpStatus == that.ImpStatus);
            result = result && (this.JobLu == that.JobLu);
            result = result && (this.Lines == that.Lines);
            result = result && (this.CountryLu == that.CountryLu);
            result = result && (this.Incomplete == that.Incomplete);
            result = result && (this.InvalidInd == that.InvalidInd);
            result = result && (this.InvalidCo == that.InvalidCo);
            result = result && (this.Delimit == that.Delimit);
            result = result && (this.Header == that.Header);
            result = result && (this.EttId.TrimOrNullify() == that.EttId.TrimOrNullify());
            result = result && (this.WebEnabled == that.WebEnabled);
            result = result && (this.NotesHtml.TrimOrNullify() == that.NotesHtml.TrimOrNullify());
            result = result && (this.IsDynamic == that.IsDynamic);
            return result;
        }

        #endregion
    }
}
