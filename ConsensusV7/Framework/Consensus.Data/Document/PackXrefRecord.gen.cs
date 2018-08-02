using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "Pack_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PackXrefRecord : Record<String>, Cloneable<PackXrefRecord>, IEquatable<PackXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PACKXREF_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PACKXREF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PACKXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PACKXREF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PACKXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PACKXREF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PACKXREF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        private String _packId;

        /// <summary>
        ///     the value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        private String _litId;

        /// <summary>
        ///     the value of the "PACKXREF_SEQ" field.
        /// </summary>
        private Int32? _seq;

        /// <summary>
        ///     the value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        private Int32? _smsId;

        /// <summary>
        ///     the value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        private Int32? _icmId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PACKXREF_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        public String PackId
        {
            get { return _packId; }
            set { _packId = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        public String LitId
        {
            get { return _litId; }
            set { _litId = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_SEQ" field.
        /// </summary>
        public Int32? Seq
        {
            get { return _seq; }
            set { _seq = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        public Int32? SmsId
        {
            get { return _smsId; }
            set { _smsId = value; }
        }

        /// <summary>
        ///     the value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        public Int32? IcmId
        {
            get { return _icmId; }
            set { _icmId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PackXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PackXrefRecord" /> object instance.
        /// </returns>
        public PackXrefRecord Clone()
        {
            PackXrefRecord record = new PackXrefRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.PackId = this.PackId;
            record.LitId = this.LitId;
            record.Seq = this.Seq;
            record.SmsId = this.SmsId;
            record.IcmId = this.IcmId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PackXrefRecord" /> instance is equal to another <see cref="PackXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PackXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PackXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.PackId.TrimOrNullify() == that.PackId.TrimOrNullify());
            result = result && (this.LitId.TrimOrNullify() == that.LitId.TrimOrNullify());
            result = result && (this.Seq == that.Seq);
            result = result && (this.SmsId == that.SmsId);
            result = result && (this.IcmId == that.IcmId);
            return result;
        }

        #endregion
    }
}
