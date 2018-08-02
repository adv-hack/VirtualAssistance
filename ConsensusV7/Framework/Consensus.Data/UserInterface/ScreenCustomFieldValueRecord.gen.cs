using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "Screen_Custom_Field_Value" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ScreenCustomFieldValueRecord : Record<Int32>, Cloneable<ScreenCustomFieldValueRecord>, IEquatable<ScreenCustomFieldValueRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CFVALUE_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "CFVALUE_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "CFVALUE_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "CFVALUE_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "CFVALUE_CFIELD_ID" field.
        /// </summary>
        private Int32 _cfieldId;

        /// <summary>
        ///     the value of the "CFVALUE_RECORD_ID" field.
        /// </summary>
        private String _recordId;

        /// <summary>
        ///     the value of the "CFVALUE_TEXT" field.
        /// </summary>
        private String _text;

        /// <summary>
        ///     the value of the "CFVALUE_NUMBER" field.
        /// </summary>
        private Decimal? _number;

        /// <summary>
        ///     the value of the "CFVALUE_ID_VALUE" field.
        /// </summary>
        private String _idValue;

        /// <summary>
        ///     the value of the "CFVALUE_DATE" field.
        /// </summary>
        private DateTime? _date;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CFVALUE_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "CFVALUE_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "CFVALUE_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "CFVALUE_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "CFVALUE_CFIELD_ID" field.
        /// </summary>
        public Int32 CfieldId
        {
            get { return _cfieldId; }
            set { _cfieldId = value; }
        }

        /// <summary>
        ///     the value of the "CFVALUE_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        /// <summary>
        ///     the value of the "CFVALUE_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        ///     the value of the "CFVALUE_NUMBER" field.
        /// </summary>
        public Decimal? Number
        {
            get { return _number; }
            set { _number = value; }
        }

        /// <summary>
        ///     the value of the "CFVALUE_ID_VALUE" field.
        /// </summary>
        public String IdValue
        {
            get { return _idValue; }
            set { _idValue = value; }
        }

        /// <summary>
        ///     the value of the "CFVALUE_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ScreenCustomFieldValueRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ScreenCustomFieldValueRecord" /> object instance.
        /// </returns>
        public ScreenCustomFieldValueRecord Clone()
        {
            ScreenCustomFieldValueRecord record = new ScreenCustomFieldValueRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.CfieldId = this.CfieldId;
            record.RecordId = this.RecordId;
            record.Text = this.Text;
            record.Number = this.Number;
            record.IdValue = this.IdValue;
            record.Date = this.Date;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ScreenCustomFieldValueRecord" /> instance is equal to another <see cref="ScreenCustomFieldValueRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ScreenCustomFieldValueRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ScreenCustomFieldValueRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.CfieldId == that.CfieldId);
            result = result && (this.RecordId.TrimOrNullify() == that.RecordId.TrimOrNullify());
            result = result && (this.Text.TrimOrNullify() == that.Text.TrimOrNullify());
            result = result && (this.Number == that.Number);
            result = result && (this.IdValue.TrimOrNullify() == that.IdValue.TrimOrNullify());
            result = result && (this.Date == that.Date);
            return result;
        }

        #endregion
    }
}
