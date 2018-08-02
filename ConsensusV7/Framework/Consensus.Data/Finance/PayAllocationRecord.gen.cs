using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "Pay_Allocation" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PayAllocationRecord : Record<String>, Cloneable<PayAllocationRecord>, IEquatable<PayAllocationRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PA_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PA_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PA_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PA_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PA_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PA_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PA_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PA_DATE" field.
        /// </summary>
        private DateTime? _date;

        /// <summary>
        ///     the value of the "PA_INV_ID" field.
        /// </summary>
        private String _invId;

        /// <summary>
        ///     the value of the "PA_INV_REF" field.
        /// </summary>
        private String _invRef;

        /// <summary>
        ///     the value of the "PA_PAY_ID" field.
        /// </summary>
        private String _payId;

        /// <summary>
        ///     the value of the "PA_HIDDEN" field.
        /// </summary>
        private Byte? _hidden;

        /// <summary>
        ///     the value of the "PA_CURR_TYPE" field.
        /// </summary>
        private String _currType;

        /// <summary>
        ///     the value of the "PA_VALUE" field.
        /// </summary>
        private Decimal _value;

        /// <summary>
        ///     the value of the "PA_VALUE_BC" field.
        /// </summary>
        private Decimal _valueBc;

        /// <summary>
        ///     the value of the "PA_CREDIT_ID" field.
        /// </summary>
        private String _creditId;

        /// <summary>
        ///     the value of the "PA_CREDIT_REF" field.
        /// </summary>
        private String _creditRef;

        /// <summary>
        ///     the value of the "PA_BOOK_ID" field.
        /// </summary>
        private String _bookId;

        /// <summary>
        ///     the value of the "PA_MEP_ID" field.
        /// </summary>
        private String _mepId;

        /// <summary>
        ///     the value of the "PA_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "PA_VALUE_BC2" field.
        /// </summary>
        private Decimal _valueBc2;

        /// <summary>
        ///     the value of the "PA_DEL_ID" field.
        /// </summary>
        private String _delId;

        /// <summary>
        ///     the value of the "PA_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "PA_EXTERNAL" field.
        /// </summary>
        private Byte? _external;

        /// <summary>
        ///     the value of the "PA_REFUND_ID" field.
        /// </summary>
        private String _refundId;

        /// <summary>
        ///     the value of the "PA_DEALLOCATION" field.
        /// </summary>
        private Byte? _deallocation;

        /// <summary>
        ///     the value of the "PA_REVERSES_PA_ID" field.
        /// </summary>
        private String _reversesPaId;

        /// <summary>
        ///     the value of the "PA_ELEM_ID" field.
        /// </summary>
        private String _elemId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PA_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PA_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PA_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PA_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PA_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PA_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PA_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PA_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        ///     the value of the "PA_INV_ID" field.
        /// </summary>
        public String InvId
        {
            get { return _invId; }
            set { _invId = value; }
        }

        /// <summary>
        ///     the value of the "PA_INV_REF" field.
        /// </summary>
        public String InvRef
        {
            get { return _invRef; }
            set { _invRef = value; }
        }

        /// <summary>
        ///     the value of the "PA_PAY_ID" field.
        /// </summary>
        public String PayId
        {
            get { return _payId; }
            set { _payId = value; }
        }

        /// <summary>
        ///     the value of the "PA_HIDDEN" field.
        /// </summary>
        public Byte? Hidden
        {
            get { return _hidden; }
            set { _hidden = value; }
        }

        /// <summary>
        ///     the value of the "PA_CURR_TYPE" field.
        /// </summary>
        public String CurrType
        {
            get { return _currType; }
            set { _currType = value; }
        }

        /// <summary>
        ///     the value of the "PA_VALUE" field.
        /// </summary>
        public Decimal Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        ///     the value of the "PA_VALUE_BC" field.
        /// </summary>
        public Decimal ValueBc
        {
            get { return _valueBc; }
            set { _valueBc = value; }
        }

        /// <summary>
        ///     the value of the "PA_CREDIT_ID" field.
        /// </summary>
        public String CreditId
        {
            get { return _creditId; }
            set { _creditId = value; }
        }

        /// <summary>
        ///     the value of the "PA_CREDIT_REF" field.
        /// </summary>
        public String CreditRef
        {
            get { return _creditRef; }
            set { _creditRef = value; }
        }

        /// <summary>
        ///     the value of the "PA_BOOK_ID" field.
        /// </summary>
        public String BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        /// <summary>
        ///     the value of the "PA_MEP_ID" field.
        /// </summary>
        public String MepId
        {
            get { return _mepId; }
            set { _mepId = value; }
        }

        /// <summary>
        ///     the value of the "PA_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "PA_VALUE_BC2" field.
        /// </summary>
        public Decimal ValueBc2
        {
            get { return _valueBc2; }
            set { _valueBc2 = value; }
        }

        /// <summary>
        ///     the value of the "PA_DEL_ID" field.
        /// </summary>
        public String DelId
        {
            get { return _delId; }
            set { _delId = value; }
        }

        /// <summary>
        ///     the value of the "PA_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "PA_EXTERNAL" field.
        /// </summary>
        public Byte? External
        {
            get { return _external; }
            set { _external = value; }
        }

        /// <summary>
        ///     the value of the "PA_REFUND_ID" field.
        /// </summary>
        public String RefundId
        {
            get { return _refundId; }
            set { _refundId = value; }
        }

        /// <summary>
        ///     the value of the "PA_DEALLOCATION" field.
        /// </summary>
        public Byte? Deallocation
        {
            get { return _deallocation; }
            set { _deallocation = value; }
        }

        /// <summary>
        ///     the value of the "PA_REVERSES_PA_ID" field.
        /// </summary>
        public String ReversesPaId
        {
            get { return _reversesPaId; }
            set { _reversesPaId = value; }
        }

        /// <summary>
        ///     the value of the "PA_ELEM_ID" field.
        /// </summary>
        public String ElemId
        {
            get { return _elemId; }
            set { _elemId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PayAllocationRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PayAllocationRecord" /> object instance.
        /// </returns>
        public PayAllocationRecord Clone()
        {
            PayAllocationRecord record = new PayAllocationRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Date = this.Date;
            record.InvId = this.InvId;
            record.InvRef = this.InvRef;
            record.PayId = this.PayId;
            record.Hidden = this.Hidden;
            record.CurrType = this.CurrType;
            record.Value = this.Value;
            record.ValueBc = this.ValueBc;
            record.CreditId = this.CreditId;
            record.CreditRef = this.CreditRef;
            record.BookId = this.BookId;
            record.MepId = this.MepId;
            record.BatId = this.BatId;
            record.ValueBc2 = this.ValueBc2;
            record.DelId = this.DelId;
            record.Description = this.Description;
            record.External = this.External;
            record.RefundId = this.RefundId;
            record.Deallocation = this.Deallocation;
            record.ReversesPaId = this.ReversesPaId;
            record.ElemId = this.ElemId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PayAllocationRecord" /> instance is equal to another <see cref="PayAllocationRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PayAllocationRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PayAllocationRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Date == that.Date);
            result = result && (this.InvId.TrimOrNullify() == that.InvId.TrimOrNullify());
            result = result && (this.InvRef.TrimOrNullify() == that.InvRef.TrimOrNullify());
            result = result && (this.PayId.TrimOrNullify() == that.PayId.TrimOrNullify());
            result = result && (this.Hidden == that.Hidden);
            result = result && (this.CurrType.TrimOrNullify() == that.CurrType.TrimOrNullify());
            result = result && (this.Value == that.Value);
            result = result && (this.ValueBc == that.ValueBc);
            result = result && (this.CreditId.TrimOrNullify() == that.CreditId.TrimOrNullify());
            result = result && (this.CreditRef.TrimOrNullify() == that.CreditRef.TrimOrNullify());
            result = result && (this.BookId.TrimOrNullify() == that.BookId.TrimOrNullify());
            result = result && (this.MepId.TrimOrNullify() == that.MepId.TrimOrNullify());
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.ValueBc2 == that.ValueBc2);
            result = result && (this.DelId.TrimOrNullify() == that.DelId.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.External == that.External);
            result = result && (this.RefundId.TrimOrNullify() == that.RefundId.TrimOrNullify());
            result = result && (this.Deallocation == that.Deallocation);
            result = result && (this.ReversesPaId.TrimOrNullify() == that.ReversesPaId.TrimOrNullify());
            result = result && (this.ElemId.TrimOrNullify() == that.ElemId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
