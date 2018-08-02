using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Represents the "Batch" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class BatchRecord : Record<String>, Cloneable<BatchRecord>, IEquatable<BatchRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "BAT_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "BAT_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "BAT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "BAT_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "BAT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "BAT_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "BAT_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "BAT_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "BAT_PROC" field.
        /// </summary>
        private String _proc;

        /// <summary>
        ///     the value of the "BAT_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "BAT_PATH" field.
        /// </summary>
        private String _path;

        /// <summary>
        ///     the value of the "BAT_SELECT" field.
        /// </summary>
        private String _select;

        /// <summary>
        ///     the value of the "BAT_COUNT" field.
        /// </summary>
        private Int32? _count;

        /// <summary>
        ///     the value of the "BAT_START_D_T" field.
        /// </summary>
        private DateTime? _startDT;

        /// <summary>
        ///     the value of the "BAT_RUN_D_T" field.
        /// </summary>
        private DateTime? _runDT;

        /// <summary>
        ///     the value of the "BAT_RUN_BY" field.
        /// </summary>
        private String _runBy;

        /// <summary>
        ///     the value of the "BAT_NOTE" field.
        /// </summary>
        private String _note;

        /// <summary>
        ///     the value of the "BAT_CRT_NEXT_BATCH" field.
        /// </summary>
        private Byte? _crtNextBatch;

        /// <summary>
        ///     the value of the "BAT_DELAY_NXT_BTCH" field.
        /// </summary>
        private Double? _delayNxtBtch;

        /// <summary>
        ///     the value of the "BAT_RUN_DATE" field.
        /// </summary>
        private DateTime? _runDate;

        /// <summary>
        ///     the value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "BAT_PROC1" field.
        /// </summary>
        private String _proc1;

        /// <summary>
        ///     the value of the "BAT_LAST_DATE" field.
        /// </summary>
        private DateTime? _lastDate;

        /// <summary>
        ///     the value of the "BAT_ERROR_NOTE" field.
        /// </summary>
        private String _errorNote;

        /// <summary>
        ///     the value of the "BAT_EXT_FLAG" field.
        /// </summary>
        private Byte? _extFlag;

        /// <summary>
        ///     the value of the "BAT_DD_STATUS" field.
        /// </summary>
        private Byte? _ddStatus;

        /// <summary>
        ///     the value of the "BAT_REC_ID" field.
        /// </summary>
        private String _recId;

        /// <summary>
        ///     the value of the "BAT_OPT_1" field.
        /// </summary>
        private Byte? _opt1;

        /// <summary>
        ///     the value of the "BAT_OPT_2" field.
        /// </summary>
        private Byte? _opt2;

        /// <summary>
        ///     the value of the "BAT_OPT_3" field.
        /// </summary>
        private Byte? _opt3;

        /// <summary>
        ///     the value of the "BAT_OPT_4" field.
        /// </summary>
        private Byte? _opt4;

        /// <summary>
        ///     the value of the "BAT_EXT_FILE_1" field.
        /// </summary>
        private String _extFile1;

        /// <summary>
        ///     the value of the "BAT_USER_TINT_1" field.
        /// </summary>
        private Byte? _userTint1;

        /// <summary>
        ///     the value of the "BAT_FROM_DATE" field.
        /// </summary>
        private DateTime? _fromDate;

        /// <summary>
        ///     the value of the "BAT_TO_DATE" field.
        /// </summary>
        private DateTime? _toDate;

        /// <summary>
        ///     the value of the "BAT_EXT_DATE" field.
        /// </summary>
        private DateTime? _extDate;

        /// <summary>
        ///     the value of the "BAT_EXT_REF" field.
        /// </summary>
        private String _extRef;

        /// <summary>
        ///     the value of the "BAT_RERUN" field.
        /// </summary>
        private Byte _rerun;

        /// <summary>
        ///     the value of the "BAT_EC_ID" field.
        /// </summary>
        private Int32? _ecId;

        /// <summary>
        ///     the value of the "BAT_ARG_ID" field.
        /// </summary>
        private String _argId;

        /// <summary>
        ///     the value of the "BAT_DI_ID" field.
        /// </summary>
        private Int32? _diId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "BAT_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "BAT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "BAT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "BAT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "BAT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "BAT_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "BAT_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "BAT_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "BAT_PROC" field.
        /// </summary>
        public String Proc
        {
            get { return _proc; }
            set { _proc = value; }
        }

        /// <summary>
        ///     the value of the "BAT_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "BAT_PATH" field.
        /// </summary>
        public String Path
        {
            get { return _path; }
            set { _path = value; }
        }

        /// <summary>
        ///     the value of the "BAT_SELECT" field.
        /// </summary>
        public String Select
        {
            get { return _select; }
            set { _select = value; }
        }

        /// <summary>
        ///     the value of the "BAT_COUNT" field.
        /// </summary>
        public Int32? Count
        {
            get { return _count; }
            set { _count = value; }
        }

        /// <summary>
        ///     the value of the "BAT_START_D_T" field.
        /// </summary>
        public DateTime? StartDT
        {
            get { return _startDT; }
            set { _startDT = value; }
        }

        /// <summary>
        ///     the value of the "BAT_RUN_D_T" field.
        /// </summary>
        public DateTime? RunDT
        {
            get { return _runDT; }
            set { _runDT = value; }
        }

        /// <summary>
        ///     the value of the "BAT_RUN_BY" field.
        /// </summary>
        public String RunBy
        {
            get { return _runBy; }
            set { _runBy = value; }
        }

        /// <summary>
        ///     the value of the "BAT_NOTE" field.
        /// </summary>
        public String Note
        {
            get { return _note; }
            set { _note = value; }
        }

        /// <summary>
        ///     the value of the "BAT_CRT_NEXT_BATCH" field.
        /// </summary>
        public Byte? CrtNextBatch
        {
            get { return _crtNextBatch; }
            set { _crtNextBatch = value; }
        }

        /// <summary>
        ///     the value of the "BAT_DELAY_NXT_BTCH" field.
        /// </summary>
        public Double? DelayNxtBtch
        {
            get { return _delayNxtBtch; }
            set { _delayNxtBtch = value; }
        }

        /// <summary>
        ///     the value of the "BAT_RUN_DATE" field.
        /// </summary>
        public DateTime? RunDate
        {
            get { return _runDate; }
            set { _runDate = value; }
        }

        /// <summary>
        ///     the value of the "BAT_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "BAT_PROC1" field.
        /// </summary>
        public String Proc1
        {
            get { return _proc1; }
            set { _proc1 = value; }
        }

        /// <summary>
        ///     the value of the "BAT_LAST_DATE" field.
        /// </summary>
        public DateTime? LastDate
        {
            get { return _lastDate; }
            set { _lastDate = value; }
        }

        /// <summary>
        ///     the value of the "BAT_ERROR_NOTE" field.
        /// </summary>
        public String ErrorNote
        {
            get { return _errorNote; }
            set { _errorNote = value; }
        }

        /// <summary>
        ///     the value of the "BAT_EXT_FLAG" field.
        /// </summary>
        public Byte? ExtFlag
        {
            get { return _extFlag; }
            set { _extFlag = value; }
        }

        /// <summary>
        ///     the value of the "BAT_DD_STATUS" field.
        /// </summary>
        public Byte? DdStatus
        {
            get { return _ddStatus; }
            set { _ddStatus = value; }
        }

        /// <summary>
        ///     the value of the "BAT_REC_ID" field.
        /// </summary>
        public String RecId
        {
            get { return _recId; }
            set { _recId = value; }
        }

        /// <summary>
        ///     the value of the "BAT_OPT_1" field.
        /// </summary>
        public Byte? Opt1
        {
            get { return _opt1; }
            set { _opt1 = value; }
        }

        /// <summary>
        ///     the value of the "BAT_OPT_2" field.
        /// </summary>
        public Byte? Opt2
        {
            get { return _opt2; }
            set { _opt2 = value; }
        }

        /// <summary>
        ///     the value of the "BAT_OPT_3" field.
        /// </summary>
        public Byte? Opt3
        {
            get { return _opt3; }
            set { _opt3 = value; }
        }

        /// <summary>
        ///     the value of the "BAT_OPT_4" field.
        /// </summary>
        public Byte? Opt4
        {
            get { return _opt4; }
            set { _opt4 = value; }
        }

        /// <summary>
        ///     the value of the "BAT_EXT_FILE_1" field.
        /// </summary>
        public String ExtFile1
        {
            get { return _extFile1; }
            set { _extFile1 = value; }
        }

        /// <summary>
        ///     the value of the "BAT_USER_TINT_1" field.
        /// </summary>
        public Byte? UserTint1
        {
            get { return _userTint1; }
            set { _userTint1 = value; }
        }

        /// <summary>
        ///     the value of the "BAT_FROM_DATE" field.
        /// </summary>
        public DateTime? FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }

        /// <summary>
        ///     the value of the "BAT_TO_DATE" field.
        /// </summary>
        public DateTime? ToDate
        {
            get { return _toDate; }
            set { _toDate = value; }
        }

        /// <summary>
        ///     the value of the "BAT_EXT_DATE" field.
        /// </summary>
        public DateTime? ExtDate
        {
            get { return _extDate; }
            set { _extDate = value; }
        }

        /// <summary>
        ///     the value of the "BAT_EXT_REF" field.
        /// </summary>
        public String ExtRef
        {
            get { return _extRef; }
            set { _extRef = value; }
        }

        /// <summary>
        ///     the value of the "BAT_RERUN" field.
        /// </summary>
        public Byte Rerun
        {
            get { return _rerun; }
            set { _rerun = value; }
        }

        /// <summary>
        ///     the value of the "BAT_EC_ID" field.
        /// </summary>
        public Int32? EcId
        {
            get { return _ecId; }
            set { _ecId = value; }
        }

        /// <summary>
        ///     the value of the "BAT_ARG_ID" field.
        /// </summary>
        public String ArgId
        {
            get { return _argId; }
            set { _argId = value; }
        }

        /// <summary>
        ///     the value of the "BAT_DI_ID" field.
        /// </summary>
        public Int32? DiId
        {
            get { return _diId; }
            set { _diId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="BatchRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="BatchRecord" /> object instance.
        /// </returns>
        public BatchRecord Clone()
        {
            BatchRecord record = new BatchRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Type = this.Type;
            record.Proc = this.Proc;
            record.Status = this.Status;
            record.Path = this.Path;
            record.Select = this.Select;
            record.Count = this.Count;
            record.StartDT = this.StartDT;
            record.RunDT = this.RunDT;
            record.RunBy = this.RunBy;
            record.Note = this.Note;
            record.CrtNextBatch = this.CrtNextBatch;
            record.DelayNxtBtch = this.DelayNxtBtch;
            record.RunDate = this.RunDate;
            record.SelcoSpId = this.SelcoSpId;
            record.Proc1 = this.Proc1;
            record.LastDate = this.LastDate;
            record.ErrorNote = this.ErrorNote;
            record.ExtFlag = this.ExtFlag;
            record.DdStatus = this.DdStatus;
            record.RecId = this.RecId;
            record.Opt1 = this.Opt1;
            record.Opt2 = this.Opt2;
            record.Opt3 = this.Opt3;
            record.Opt4 = this.Opt4;
            record.ExtFile1 = this.ExtFile1;
            record.UserTint1 = this.UserTint1;
            record.FromDate = this.FromDate;
            record.ToDate = this.ToDate;
            record.ExtDate = this.ExtDate;
            record.ExtRef = this.ExtRef;
            record.Rerun = this.Rerun;
            record.EcId = this.EcId;
            record.ArgId = this.ArgId;
            record.DiId = this.DiId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="BatchRecord" /> instance is equal to another <see cref="BatchRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="BatchRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(BatchRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Proc.TrimOrNullify() == that.Proc.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Path.TrimOrNullify() == that.Path.TrimOrNullify());
            result = result && (this.Select.TrimOrNullify() == that.Select.TrimOrNullify());
            result = result && (this.Count == that.Count);
            result = result && (this.StartDT == that.StartDT);
            result = result && (this.RunDT == that.RunDT);
            result = result && (this.RunBy.TrimOrNullify() == that.RunBy.TrimOrNullify());
            result = result && (this.Note.TrimOrNullify() == that.Note.TrimOrNullify());
            result = result && (this.CrtNextBatch == that.CrtNextBatch);
            result = result && (this.DelayNxtBtch == that.DelayNxtBtch);
            result = result && (this.RunDate == that.RunDate);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.Proc1.TrimOrNullify() == that.Proc1.TrimOrNullify());
            result = result && (this.LastDate == that.LastDate);
            result = result && (this.ErrorNote.TrimOrNullify() == that.ErrorNote.TrimOrNullify());
            result = result && (this.ExtFlag == that.ExtFlag);
            result = result && (this.DdStatus == that.DdStatus);
            result = result && (this.RecId.TrimOrNullify() == that.RecId.TrimOrNullify());
            result = result && (this.Opt1 == that.Opt1);
            result = result && (this.Opt2 == that.Opt2);
            result = result && (this.Opt3 == that.Opt3);
            result = result && (this.Opt4 == that.Opt4);
            result = result && (this.ExtFile1.TrimOrNullify() == that.ExtFile1.TrimOrNullify());
            result = result && (this.UserTint1 == that.UserTint1);
            result = result && (this.FromDate == that.FromDate);
            result = result && (this.ToDate == that.ToDate);
            result = result && (this.ExtDate == that.ExtDate);
            result = result && (this.ExtRef.TrimOrNullify() == that.ExtRef.TrimOrNullify());
            result = result && (this.Rerun == that.Rerun);
            result = result && (this.EcId == that.EcId);
            result = result && (this.ArgId.TrimOrNullify() == that.ArgId.TrimOrNullify());
            result = result && (this.DiId == that.DiId);
            return result;
        }

        #endregion
    }
}
