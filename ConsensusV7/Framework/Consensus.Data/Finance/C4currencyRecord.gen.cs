using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "C4Currency" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class C4currencyRecord : Record<String>, Cloneable<C4currencyRecord>, IEquatable<C4currencyRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CURR_CODE" field.
        /// </summary>
        private String _code;

        /// <summary>
        ///     the value of the "CURR_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "CURR_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "CURR_CONV_FACTOR" field.
        /// </summary>
        private Decimal _convFactor;

        /// <summary>
        ///     the value of the "CURR_DISP_FACTOR" field.
        /// </summary>
        private Decimal _dispFactor;

        /// <summary>
        ///     the value of the "CURR_DESCRIP" field.
        /// </summary>
        private String _descrip;

        /// <summary>
        ///     the value of the "CURR_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "CURR_EURO" field.
        /// </summary>
        private Byte? _euro;

        /// <summary>
        ///     the value of the "CURR_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "CURR_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "CURR_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "CURR_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "CURR_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "CURR_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "CURR_CONV_FACT2" field.
        /// </summary>
        private Decimal _convFact2;

        /// <summary>
        ///     the value of the "CURR_SP_ID" field.
        /// </summary>
        private String _spId;

        /// <summary>
        ///     the value of the "CURR_SYMBOL_VALUE" field.
        /// </summary>
        private String _symbolValue;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CURR_CODE" field.
        /// </summary>
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        ///     the value of the "CURR_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "CURR_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "CURR_CONV_FACTOR" field.
        /// </summary>
        public Decimal ConvFactor
        {
            get { return _convFactor; }
            set { _convFactor = value; }
        }

        /// <summary>
        ///     the value of the "CURR_DISP_FACTOR" field.
        /// </summary>
        public Decimal DispFactor
        {
            get { return _dispFactor; }
            set { _dispFactor = value; }
        }

        /// <summary>
        ///     the value of the "CURR_DESCRIP" field.
        /// </summary>
        public String Descrip
        {
            get { return _descrip; }
            set { _descrip = value; }
        }

        /// <summary>
        ///     the value of the "CURR_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "CURR_EURO" field.
        /// </summary>
        public Byte? Euro
        {
            get { return _euro; }
            set { _euro = value; }
        }

        /// <summary>
        ///     the value of the "CURR_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "CURR_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "CURR_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "CURR_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "CURR_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "CURR_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "CURR_CONV_FACT2" field.
        /// </summary>
        public Decimal ConvFact2
        {
            get { return _convFact2; }
            set { _convFact2 = value; }
        }

        /// <summary>
        ///     the value of the "CURR_SP_ID" field.
        /// </summary>
        public String SpId
        {
            get { return _spId; }
            set { _spId = value; }
        }

        /// <summary>
        ///     the value of the "CURR_SYMBOL_VALUE" field.
        /// </summary>
        public String SymbolValue
        {
            get { return _symbolValue; }
            set { _symbolValue = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="C4currencyRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="C4currencyRecord" /> object instance.
        /// </returns>
        public C4currencyRecord Clone()
        {
            C4currencyRecord record = new C4currencyRecord();
            record.Id = this.Id;
            record.Code = this.Code;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            record.ConvFactor = this.ConvFactor;
            record.DispFactor = this.DispFactor;
            record.Descrip = this.Descrip;
            record.Lock = this.Lock;
            record.Euro = this.Euro;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.ConvFact2 = this.ConvFact2;
            record.SpId = this.SpId;
            record.SymbolValue = this.SymbolValue;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="C4currencyRecord" /> instance is equal to another <see cref="C4currencyRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="C4currencyRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(C4currencyRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Code.TrimOrNullify() == that.Code.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.ConvFactor == that.ConvFactor);
            result = result && (this.DispFactor == that.DispFactor);
            result = result && (this.Descrip.TrimOrNullify() == that.Descrip.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Euro == that.Euro);
            result = result && (this.ConvFact2 == that.ConvFact2);
            result = result && (this.SpId.TrimOrNullify() == that.SpId.TrimOrNullify());
            result = result && (this.SymbolValue.TrimOrNullify() == that.SymbolValue.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
