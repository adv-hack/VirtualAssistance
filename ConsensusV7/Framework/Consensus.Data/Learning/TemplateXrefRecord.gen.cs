using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "Template_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class TemplateXrefRecord : Record<String>, Cloneable<TemplateXrefRecord>, IEquatable<TemplateXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "TXREF_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "TXREF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "TXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "TXREF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "TXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "TXREF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "TXREF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "TXREF_BOM_ID" field.
        /// </summary>
        private String _bomId;

        /// <summary>
        ///     the value of the "TXREF_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "TXREF_USAGE" field.
        /// </summary>
        private Byte? _usage;

        /// <summary>
        ///     the value of the "TXREF_QTY" field.
        /// </summary>
        private Double? _qty;

        /// <summary>
        ///     the value of the "TXREF_DEL_QTY" field.
        /// </summary>
        private Double? _delQty;

        /// <summary>
        ///     the value of the "TXREF_PER_DAY" field.
        /// </summary>
        private Byte? _perDay;

        /// <summary>
        ///     the value of the "TXREF_ARG_ID" field.
        /// </summary>
        private String _argId;

        /// <summary>
        ///     the value of the "TXREF_TYPE" field.
        /// </summary>
        private Byte _type;

        /// <summary>
        ///     the value of the "TXREF_PROF_KEY" field.
        /// </summary>
        private String _profKey;

        /// <summary>
        ///     the value of the "TXREF_PROF_VALUE" field.
        /// </summary>
        private String _profValue;

        /// <summary>
        ///     the value of the "TXREF_PROF_VALUE2" field.
        /// </summary>
        private String _profValue2;

        /// <summary>
        ///     the value of the "TXREF_RATIO" field.
        /// </summary>
        private Int32 _ratio;

        /// <summary>
        ///     the value of the "TXREF_UNT_TYPE" field.
        /// </summary>
        private String _untType;

        /// <summary>
        ///     the value of the "TXREF_TRAINER" field.
        /// </summary>
        private Byte? _trainer;

        /// <summary>
        ///     the value of the "TXREF_COST" field.
        /// </summary>
        private Decimal _cost;

        /// <summary>
        ///     the value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        private String _roomType;

        /// <summary>
        ///     the value of the "TXREF_INC_IN_BUDGET" field.
        /// </summary>
        private Byte _incInBudget;

        /// <summary>
        ///     the value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        private String _trainProleId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "TXREF_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_BOM_ID" field.
        /// </summary>
        public String BomId
        {
            get { return _bomId; }
            set { _bomId = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_USAGE" field.
        /// </summary>
        public Byte? Usage
        {
            get { return _usage; }
            set { _usage = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_QTY" field.
        /// </summary>
        public Double? Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_DEL_QTY" field.
        /// </summary>
        public Double? DelQty
        {
            get { return _delQty; }
            set { _delQty = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_PER_DAY" field.
        /// </summary>
        public Byte? PerDay
        {
            get { return _perDay; }
            set { _perDay = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_ARG_ID" field.
        /// </summary>
        public String ArgId
        {
            get { return _argId; }
            set { _argId = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_PROF_KEY" field.
        /// </summary>
        public String ProfKey
        {
            get { return _profKey; }
            set { _profKey = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_PROF_VALUE" field.
        /// </summary>
        public String ProfValue
        {
            get { return _profValue; }
            set { _profValue = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_PROF_VALUE2" field.
        /// </summary>
        public String ProfValue2
        {
            get { return _profValue2; }
            set { _profValue2 = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_RATIO" field.
        /// </summary>
        public Int32 Ratio
        {
            get { return _ratio; }
            set { _ratio = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_UNT_TYPE" field.
        /// </summary>
        public String UntType
        {
            get { return _untType; }
            set { _untType = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_TRAINER" field.
        /// </summary>
        public Byte? Trainer
        {
            get { return _trainer; }
            set { _trainer = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_COST" field.
        /// </summary>
        public Decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        public String RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_INC_IN_BUDGET" field.
        /// </summary>
        public Byte IncInBudget
        {
            get { return _incInBudget; }
            set { _incInBudget = value; }
        }

        /// <summary>
        ///     the value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        public String TrainProleId
        {
            get { return _trainProleId; }
            set { _trainProleId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="TemplateXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="TemplateXrefRecord" /> object instance.
        /// </returns>
        public TemplateXrefRecord Clone()
        {
            TemplateXrefRecord record = new TemplateXrefRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.BomId = this.BomId;
            record.ProdId = this.ProdId;
            record.Usage = this.Usage;
            record.Qty = this.Qty;
            record.DelQty = this.DelQty;
            record.PerDay = this.PerDay;
            record.ArgId = this.ArgId;
            record.Type = this.Type;
            record.ProfKey = this.ProfKey;
            record.ProfValue = this.ProfValue;
            record.ProfValue2 = this.ProfValue2;
            record.Ratio = this.Ratio;
            record.UntType = this.UntType;
            record.Trainer = this.Trainer;
            record.Cost = this.Cost;
            record.RoomType = this.RoomType;
            record.IncInBudget = this.IncInBudget;
            record.TrainProleId = this.TrainProleId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="TemplateXrefRecord" /> instance is equal to another <see cref="TemplateXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="TemplateXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(TemplateXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.BomId.TrimOrNullify() == that.BomId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.Usage == that.Usage);
            result = result && (this.Qty == that.Qty);
            result = result && (this.DelQty == that.DelQty);
            result = result && (this.PerDay == that.PerDay);
            result = result && (this.ArgId.TrimOrNullify() == that.ArgId.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.ProfKey.TrimOrNullify() == that.ProfKey.TrimOrNullify());
            result = result && (this.ProfValue.TrimOrNullify() == that.ProfValue.TrimOrNullify());
            result = result && (this.ProfValue2.TrimOrNullify() == that.ProfValue2.TrimOrNullify());
            result = result && (this.Ratio == that.Ratio);
            result = result && (this.UntType.TrimOrNullify() == that.UntType.TrimOrNullify());
            result = result && (this.Trainer == that.Trainer);
            result = result && (this.Cost == that.Cost);
            result = result && (this.RoomType.TrimOrNullify() == that.RoomType.TrimOrNullify());
            result = result && (this.IncInBudget == that.IncInBudget);
            result = result && (this.TrainProleId.TrimOrNullify() == that.TrainProleId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
