using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Represents the "Complaint" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ComplaintRecord : Record<String>, Cloneable<ComplaintRecord>, IEquatable<ComplaintRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CMPL_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "CMPL_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "CMPL_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "CMPL_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "CMPL_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "CMPL_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "CMPL_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        private String _fromProleId;

        /// <summary>
        ///     the value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        private String _reProleId;

        /// <summary>
        ///     the value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        private String _mgrProleId;

        /// <summary>
        ///     the value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        private String _medtrProleId;

        /// <summary>
        ///     the value of the "CMPL_STATUS_1" field.
        /// </summary>
        private String _status1;

        /// <summary>
        ///     the value of the "CMPL_STATUS_2" field.
        /// </summary>
        private String _status2;

        /// <summary>
        ///     the value of the "CMPL_STATUS_3" field.
        /// </summary>
        private String _status3;

        /// <summary>
        ///     the value of the "CMPL_TYPE_1" field.
        /// </summary>
        private String _type1;

        /// <summary>
        ///     the value of the "CMPL_TYPE_2" field.
        /// </summary>
        private String _type2;

        /// <summary>
        ///     the value of the "CMPL_TYPE_3" field.
        /// </summary>
        private String _type3;

        /// <summary>
        ///     the value of the "CMPL_SCHEME" field.
        /// </summary>
        private String _scheme;

        /// <summary>
        ///     the value of the "CMPL_DATE_OF_COMPL" field.
        /// </summary>
        private DateTime? _dateOfCompl;

        /// <summary>
        ///     the value of the "CMPL_DATE_RCVD" field.
        /// </summary>
        private DateTime? _dateRcvd;

        /// <summary>
        ///     the value of the "CMPL_DATE_END" field.
        /// </summary>
        private DateTime? _dateEnd;

        /// <summary>
        ///     the value of the "CMPL_DATE_NEXT_ACT" field.
        /// </summary>
        private DateTime? _dateNextAct;

        /// <summary>
        ///     the value of the "CMPL_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "CMPL_01_VALUE" field.
        /// </summary>
        private String _value01;

        /// <summary>
        ///     the value of the "CMPL_02_VALUE" field.
        /// </summary>
        private String _value02;

        /// <summary>
        ///     the value of the "CMPL_03_VALUE" field.
        /// </summary>
        private String _value03;

        /// <summary>
        ///     the value of the "CMPL_04_VALUE" field.
        /// </summary>
        private String _value04;

        /// <summary>
        ///     the value of the "CMPL_05_VALUE" field.
        /// </summary>
        private String _value05;

        /// <summary>
        ///     the value of the "CMPL_06_VALUE" field.
        /// </summary>
        private String _value06;

        /// <summary>
        ///     the value of the "CMPL_07_VALUE" field.
        /// </summary>
        private String _value07;

        /// <summary>
        ///     the value of the "CMPL_08_VALUE" field.
        /// </summary>
        private String _value08;

        /// <summary>
        ///     the value of the "CMPL_09_VALUE" field.
        /// </summary>
        private String _value09;

        /// <summary>
        ///     the value of the "CMPL_10_VALUE" field.
        /// </summary>
        private String _value10;

        /// <summary>
        ///     the value of the "CMPL_PM_ID" field.
        /// </summary>
        private String _pmId;

        /// <summary>
        ///     the value of the "CMPL_OUR_PERSON" field.
        /// </summary>
        private Byte? _ourPerson;

        /// <summary>
        ///     the value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        private String _detailsId;

        /// <summary>
        ///     the value of the "CMPL_RESOL_ID" field.
        /// </summary>
        private String _resolId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CMPL_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        public String FromProleId
        {
            get { return _fromProleId; }
            set { _fromProleId = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        public String ReProleId
        {
            get { return _reProleId; }
            set { _reProleId = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        public String MgrProleId
        {
            get { return _mgrProleId; }
            set { _mgrProleId = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        public String MedtrProleId
        {
            get { return _medtrProleId; }
            set { _medtrProleId = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_STATUS_1" field.
        /// </summary>
        public String Status1
        {
            get { return _status1; }
            set { _status1 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_STATUS_2" field.
        /// </summary>
        public String Status2
        {
            get { return _status2; }
            set { _status2 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_STATUS_3" field.
        /// </summary>
        public String Status3
        {
            get { return _status3; }
            set { _status3 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_TYPE_1" field.
        /// </summary>
        public String Type1
        {
            get { return _type1; }
            set { _type1 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_TYPE_2" field.
        /// </summary>
        public String Type2
        {
            get { return _type2; }
            set { _type2 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_TYPE_3" field.
        /// </summary>
        public String Type3
        {
            get { return _type3; }
            set { _type3 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_SCHEME" field.
        /// </summary>
        public String Scheme
        {
            get { return _scheme; }
            set { _scheme = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_DATE_OF_COMPL" field.
        /// </summary>
        public DateTime? DateOfCompl
        {
            get { return _dateOfCompl; }
            set { _dateOfCompl = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_DATE_RCVD" field.
        /// </summary>
        public DateTime? DateRcvd
        {
            get { return _dateRcvd; }
            set { _dateRcvd = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_DATE_END" field.
        /// </summary>
        public DateTime? DateEnd
        {
            get { return _dateEnd; }
            set { _dateEnd = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_DATE_NEXT_ACT" field.
        /// </summary>
        public DateTime? DateNextAct
        {
            get { return _dateNextAct; }
            set { _dateNextAct = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_01_VALUE" field.
        /// </summary>
        public String Value01
        {
            get { return _value01; }
            set { _value01 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_02_VALUE" field.
        /// </summary>
        public String Value02
        {
            get { return _value02; }
            set { _value02 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_03_VALUE" field.
        /// </summary>
        public String Value03
        {
            get { return _value03; }
            set { _value03 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_04_VALUE" field.
        /// </summary>
        public String Value04
        {
            get { return _value04; }
            set { _value04 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_05_VALUE" field.
        /// </summary>
        public String Value05
        {
            get { return _value05; }
            set { _value05 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_06_VALUE" field.
        /// </summary>
        public String Value06
        {
            get { return _value06; }
            set { _value06 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_07_VALUE" field.
        /// </summary>
        public String Value07
        {
            get { return _value07; }
            set { _value07 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_08_VALUE" field.
        /// </summary>
        public String Value08
        {
            get { return _value08; }
            set { _value08 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_09_VALUE" field.
        /// </summary>
        public String Value09
        {
            get { return _value09; }
            set { _value09 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_10_VALUE" field.
        /// </summary>
        public String Value10
        {
            get { return _value10; }
            set { _value10 = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_PM_ID" field.
        /// </summary>
        public String PmId
        {
            get { return _pmId; }
            set { _pmId = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_OUR_PERSON" field.
        /// </summary>
        public Byte? OurPerson
        {
            get { return _ourPerson; }
            set { _ourPerson = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        public String DetailsId
        {
            get { return _detailsId; }
            set { _detailsId = value; }
        }

        /// <summary>
        ///     the value of the "CMPL_RESOL_ID" field.
        /// </summary>
        public String ResolId
        {
            get { return _resolId; }
            set { _resolId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ComplaintRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ComplaintRecord" /> object instance.
        /// </returns>
        public ComplaintRecord Clone()
        {
            ComplaintRecord record = new ComplaintRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.Title = this.Title;
            record.FromProleId = this.FromProleId;
            record.ReProleId = this.ReProleId;
            record.MgrProleId = this.MgrProleId;
            record.MedtrProleId = this.MedtrProleId;
            record.Status1 = this.Status1;
            record.Status2 = this.Status2;
            record.Status3 = this.Status3;
            record.Type1 = this.Type1;
            record.Type2 = this.Type2;
            record.Type3 = this.Type3;
            record.Scheme = this.Scheme;
            record.DateOfCompl = this.DateOfCompl;
            record.DateRcvd = this.DateRcvd;
            record.DateEnd = this.DateEnd;
            record.DateNextAct = this.DateNextAct;
            record.Notes = this.Notes;
            record.Value01 = this.Value01;
            record.Value02 = this.Value02;
            record.Value03 = this.Value03;
            record.Value04 = this.Value04;
            record.Value05 = this.Value05;
            record.Value06 = this.Value06;
            record.Value07 = this.Value07;
            record.Value08 = this.Value08;
            record.Value09 = this.Value09;
            record.Value10 = this.Value10;
            record.PmId = this.PmId;
            record.OurPerson = this.OurPerson;
            record.DetailsId = this.DetailsId;
            record.ResolId = this.ResolId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ComplaintRecord" /> instance is equal to another <see cref="ComplaintRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ComplaintRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ComplaintRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.FromProleId.TrimOrNullify() == that.FromProleId.TrimOrNullify());
            result = result && (this.ReProleId.TrimOrNullify() == that.ReProleId.TrimOrNullify());
            result = result && (this.MgrProleId.TrimOrNullify() == that.MgrProleId.TrimOrNullify());
            result = result && (this.MedtrProleId.TrimOrNullify() == that.MedtrProleId.TrimOrNullify());
            result = result && (this.Status1.TrimOrNullify() == that.Status1.TrimOrNullify());
            result = result && (this.Status2.TrimOrNullify() == that.Status2.TrimOrNullify());
            result = result && (this.Status3.TrimOrNullify() == that.Status3.TrimOrNullify());
            result = result && (this.Type1.TrimOrNullify() == that.Type1.TrimOrNullify());
            result = result && (this.Type2.TrimOrNullify() == that.Type2.TrimOrNullify());
            result = result && (this.Type3.TrimOrNullify() == that.Type3.TrimOrNullify());
            result = result && (this.Scheme.TrimOrNullify() == that.Scheme.TrimOrNullify());
            result = result && (this.DateOfCompl == that.DateOfCompl);
            result = result && (this.DateRcvd == that.DateRcvd);
            result = result && (this.DateEnd == that.DateEnd);
            result = result && (this.DateNextAct == that.DateNextAct);
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Value01.TrimOrNullify() == that.Value01.TrimOrNullify());
            result = result && (this.Value02.TrimOrNullify() == that.Value02.TrimOrNullify());
            result = result && (this.Value03.TrimOrNullify() == that.Value03.TrimOrNullify());
            result = result && (this.Value04.TrimOrNullify() == that.Value04.TrimOrNullify());
            result = result && (this.Value05.TrimOrNullify() == that.Value05.TrimOrNullify());
            result = result && (this.Value06.TrimOrNullify() == that.Value06.TrimOrNullify());
            result = result && (this.Value07.TrimOrNullify() == that.Value07.TrimOrNullify());
            result = result && (this.Value08.TrimOrNullify() == that.Value08.TrimOrNullify());
            result = result && (this.Value09.TrimOrNullify() == that.Value09.TrimOrNullify());
            result = result && (this.Value10.TrimOrNullify() == that.Value10.TrimOrNullify());
            result = result && (this.PmId.TrimOrNullify() == that.PmId.TrimOrNullify());
            result = result && (this.OurPerson == that.OurPerson);
            result = result && (this.DetailsId.TrimOrNullify() == that.DetailsId.TrimOrNullify());
            result = result && (this.ResolId.TrimOrNullify() == that.ResolId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
