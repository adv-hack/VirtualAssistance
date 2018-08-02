using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "TRAIN_PROD_XREF" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class TrainProdXrefRecord : Record<String>, Cloneable<TrainProdXrefRecord>, IEquatable<TrainProdXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "TPXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "TPXREF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "TPXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "TPXREF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "TPXREF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "TPXREF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        private String _trainId;

        /// <summary>
        ///     the value of the "TPXREF_LOC_ID" field.
        /// </summary>
        private String _locId;

        /// <summary>
        ///     the value of the "TPXREF_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "TPXREF_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "TPXREF_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "TPXREF_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "TPXREF_GRADE" field.
        /// </summary>
        private String _grade;

        /// <summary>
        ///     the value of the "TPXREF_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "TPXREF_COST" field.
        /// </summary>
        private Decimal? _cost;

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_5" field.
        /// </summary>
        private String _userchar5;

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_6" field.
        /// </summary>
        private String _userchar6;

        /// <summary>
        ///     the value of the "TPXREF_USERINT_1" field.
        /// </summary>
        private Byte? _userint1;

        /// <summary>
        ///     the value of the "TPXREF_USERINT_2" field.
        /// </summary>
        private Byte? _userint2;

        /// <summary>
        ///     the value of the "TPXREF_USERINT_3" field.
        /// </summary>
        private Byte? _userint3;

        /// <summary>
        ///     the value of the "TPXREF_USERINT_4" field.
        /// </summary>
        private Byte? _userint4;

        /// <summary>
        ///     the value of the "TPXREF_USERINT_5" field.
        /// </summary>
        private Byte? _userint5;

        /// <summary>
        ///     the value of the "TPXREF_USERINT_6" field.
        /// </summary>
        private Byte? _userint6;

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_1" field.
        /// </summary>
        private Decimal? _usernum1;

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_2" field.
        /// </summary>
        private Decimal? _usernum2;

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_3" field.
        /// </summary>
        private Decimal? _usernum3;

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_4" field.
        /// </summary>
        private Decimal? _usernum4;

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_5" field.
        /// </summary>
        private Decimal? _usernum5;

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_6" field.
        /// </summary>
        private Decimal? _usernum6;

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_1" field.
        /// </summary>
        private DateTime? _userdate1;

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_2" field.
        /// </summary>
        private DateTime? _userdate2;

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_3" field.
        /// </summary>
        private DateTime? _userdate3;

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_4" field.
        /// </summary>
        private DateTime? _userdate4;

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_5" field.
        /// </summary>
        private DateTime? _userdate5;

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_6" field.
        /// </summary>
        private DateTime? _userdate6;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "TPXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        public String TrainId
        {
            get { return _trainId; }
            set { _trainId = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_LOC_ID" field.
        /// </summary>
        public String LocId
        {
            get { return _locId; }
            set { _locId = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_GRADE" field.
        /// </summary>
        public String Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_COST" field.
        /// </summary>
        public Decimal? Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return _userchar5; }
            set { _userchar5 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return _userchar6; }
            set { _userchar6 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERINT_1" field.
        /// </summary>
        public Byte? Userint1
        {
            get { return _userint1; }
            set { _userint1 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERINT_2" field.
        /// </summary>
        public Byte? Userint2
        {
            get { return _userint2; }
            set { _userint2 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERINT_3" field.
        /// </summary>
        public Byte? Userint3
        {
            get { return _userint3; }
            set { _userint3 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERINT_4" field.
        /// </summary>
        public Byte? Userint4
        {
            get { return _userint4; }
            set { _userint4 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERINT_5" field.
        /// </summary>
        public Byte? Userint5
        {
            get { return _userint5; }
            set { _userint5 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERINT_6" field.
        /// </summary>
        public Byte? Userint6
        {
            get { return _userint6; }
            set { _userint6 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_1" field.
        /// </summary>
        public Decimal? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_2" field.
        /// </summary>
        public Decimal? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_3" field.
        /// </summary>
        public Decimal? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_4" field.
        /// </summary>
        public Decimal? Usernum4
        {
            get { return _usernum4; }
            set { _usernum4 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_5" field.
        /// </summary>
        public Decimal? Usernum5
        {
            get { return _usernum5; }
            set { _usernum5 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERNUM_6" field.
        /// </summary>
        public Decimal? Usernum6
        {
            get { return _usernum6; }
            set { _usernum6 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_1" field.
        /// </summary>
        public DateTime? Userdate1
        {
            get { return _userdate1; }
            set { _userdate1 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_2" field.
        /// </summary>
        public DateTime? Userdate2
        {
            get { return _userdate2; }
            set { _userdate2 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_3" field.
        /// </summary>
        public DateTime? Userdate3
        {
            get { return _userdate3; }
            set { _userdate3 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_4" field.
        /// </summary>
        public DateTime? Userdate4
        {
            get { return _userdate4; }
            set { _userdate4 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_5" field.
        /// </summary>
        public DateTime? Userdate5
        {
            get { return _userdate5; }
            set { _userdate5 = value; }
        }

        /// <summary>
        ///     the value of the "TPXREF_USERDATE_6" field.
        /// </summary>
        public DateTime? Userdate6
        {
            get { return _userdate6; }
            set { _userdate6 = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="TrainProdXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="TrainProdXrefRecord" /> object instance.
        /// </returns>
        public TrainProdXrefRecord Clone()
        {
            TrainProdXrefRecord record = new TrainProdXrefRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.TrainId = this.TrainId;
            record.LocId = this.LocId;
            record.ProdId = this.ProdId;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            record.Status = this.Status;
            record.Grade = this.Grade;
            record.Notes = this.Notes;
            record.Cost = this.Cost;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Userchar3 = this.Userchar3;
            record.Userchar4 = this.Userchar4;
            record.Userchar5 = this.Userchar5;
            record.Userchar6 = this.Userchar6;
            record.Userint1 = this.Userint1;
            record.Userint2 = this.Userint2;
            record.Userint3 = this.Userint3;
            record.Userint4 = this.Userint4;
            record.Userint5 = this.Userint5;
            record.Userint6 = this.Userint6;
            record.Usernum1 = this.Usernum1;
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
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="TrainProdXrefRecord" /> instance is equal to another <see cref="TrainProdXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="TrainProdXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(TrainProdXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.TrainId.TrimOrNullify() == that.TrainId.TrimOrNullify());
            result = result && (this.LocId.TrimOrNullify() == that.LocId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Grade.TrimOrNullify() == that.Grade.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Cost == that.Cost);
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.Userchar5.TrimOrNullify() == that.Userchar5.TrimOrNullify());
            result = result && (this.Userchar6.TrimOrNullify() == that.Userchar6.TrimOrNullify());
            result = result && (this.Userint1 == that.Userint1);
            result = result && (this.Userint2 == that.Userint2);
            result = result && (this.Userint3 == that.Userint3);
            result = result && (this.Userint4 == that.Userint4);
            result = result && (this.Userint5 == that.Userint5);
            result = result && (this.Userint6 == that.Userint6);
            result = result && (this.Usernum1 == that.Usernum1);
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
            return result;
        }

        #endregion
    }
}
