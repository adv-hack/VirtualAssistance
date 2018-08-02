using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "EVENT_PRODUCT" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class EventProductRecord : Record<Int32>, Cloneable<EventProductRecord>, IEquatable<EventProductRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "EP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "EP_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "EP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "EP_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "EP_COURSE_ID" field.
        /// </summary>
        private String _eventId;

        /// <summary>
        ///     the value of the "EP_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "EP_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "EP_QTY" field.
        /// </summary>
        private Int32? _qty;

        /// <summary>
        ///     the value of the "EP_DELEGATE_QTY" field.
        /// </summary>
        private Int32? _delegateQty;

        /// <summary>
        ///     the value of the "EP_BOM_ID" field.
        /// </summary>
        private String _bomId;

        /// <summary>
        ///     the value of the "EP_PREDELIV" field.
        /// </summary>
        private Byte _predeliv;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "EP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "EP_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "EP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "EP_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "EP_COURSE_ID" field.
        /// </summary>
        public String EventId
        {
            get { return _eventId; }
            set { _eventId = value; }
        }

        /// <summary>
        ///     the value of the "EP_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "EP_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "EP_QTY" field.
        /// </summary>
        public Int32? Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        /// <summary>
        ///     the value of the "EP_DELEGATE_QTY" field.
        /// </summary>
        public Int32? DelegateQty
        {
            get { return _delegateQty; }
            set { _delegateQty = value; }
        }

        /// <summary>
        ///     the value of the "EP_BOM_ID" field.
        /// </summary>
        public String BomId
        {
            get { return _bomId; }
            set { _bomId = value; }
        }

        /// <summary>
        ///     the value of the "EP_PREDELIV" field.
        /// </summary>
        public Byte Predeliv
        {
            get { return _predeliv; }
            set { _predeliv = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="EventProductRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="EventProductRecord" /> object instance.
        /// </returns>
        public EventProductRecord Clone()
        {
            EventProductRecord record = new EventProductRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.EventId = this.EventId;
            record.ProdId = this.ProdId;
            record.Notes = this.Notes;
            record.Qty = this.Qty;
            record.DelegateQty = this.DelegateQty;
            record.BomId = this.BomId;
            record.Predeliv = this.Predeliv;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="EventProductRecord" /> instance is equal to another <see cref="EventProductRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="EventProductRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(EventProductRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.EventId.TrimOrNullify() == that.EventId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Qty == that.Qty);
            result = result && (this.DelegateQty == that.DelegateQty);
            result = result && (this.BomId.TrimOrNullify() == that.BomId.TrimOrNullify());
            result = result && (this.Predeliv == that.Predeliv);
            return result;
        }

        #endregion
    }
}
