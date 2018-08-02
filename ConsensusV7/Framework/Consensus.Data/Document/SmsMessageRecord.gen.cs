using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "SMS_Message" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SmsMessageRecord : Record<Int32>, Cloneable<SmsMessageRecord>, IEquatable<SmsMessageRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "SMS_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "SMS_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "SMS_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "SMS_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "SMS_SMT_ID" field.
        /// </summary>
        private Int32? _smtId;

        /// <summary>
        ///     the value of the "SMS_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "SMS_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "SMS_TEXT" field.
        /// </summary>
        private String _text;

        /// <summary>
        ///     the value of the "SMS_CURRENT" field.
        /// </summary>
        private Boolean? _current;

        /// <summary>
        ///     the value of the "SMS_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "SMS_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "SMS_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "SMS_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "SMS_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "SMS_SMT_ID" field.
        /// </summary>
        public Int32? SmtId
        {
            get { return _smtId; }
            set { _smtId = value; }
        }

        /// <summary>
        ///     the value of the "SMS_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "SMS_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "SMS_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        ///     the value of the "SMS_CURRENT" field.
        /// </summary>
        public Boolean? Current
        {
            get { return _current; }
            set { _current = value; }
        }

        /// <summary>
        ///     the value of the "SMS_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SmsMessageRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SmsMessageRecord" /> object instance.
        /// </returns>
        public SmsMessageRecord Clone()
        {
            SmsMessageRecord record = new SmsMessageRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.SmtId = this.SmtId;
            record.Name = this.Name;
            record.Description = this.Description;
            record.Text = this.Text;
            record.Current = this.Current;
            record.SelcoSpId = this.SelcoSpId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SmsMessageRecord" /> instance is equal to another <see cref="SmsMessageRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SmsMessageRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SmsMessageRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.SmtId == that.SmtId);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.Text.TrimOrNullify() == that.Text.TrimOrNullify());
            result = result && (this.Current == that.Current);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
