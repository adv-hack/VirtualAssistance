using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "ICalMessage" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class IcalmessageRecord : Record<Int32>, Cloneable<IcalmessageRecord>, IEquatable<IcalmessageRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ICM_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ICM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ICM_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ICM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ICM_ICMT_ID" field.
        /// </summary>
        private Int32? _icmtId;

        /// <summary>
        ///     the value of the "ICM_CURRENT" field.
        /// </summary>
        private Byte? _current;

        /// <summary>
        ///     the value of the "ICM_METHOD" field.
        /// </summary>
        private Byte? _method;

        /// <summary>
        ///     the value of the "ICM_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "ICM_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "ICM_SUBJECT" field.
        /// </summary>
        private String _subject;

        /// <summary>
        ///     the value of the "ICM_LOCATION" field.
        /// </summary>
        private String _location;

        /// <summary>
        ///     the value of the "ICM_TEXT" field.
        /// </summary>
        private String _text;

        /// <summary>
        ///     the value of the "ICM_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ICM_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ICM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ICM_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ICM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ICM_ICMT_ID" field.
        /// </summary>
        public Int32? IcmtId
        {
            get { return _icmtId; }
            set { _icmtId = value; }
        }

        /// <summary>
        ///     the value of the "ICM_CURRENT" field.
        /// </summary>
        public Byte? Current
        {
            get { return _current; }
            set { _current = value; }
        }

        /// <summary>
        ///     the value of the "ICM_METHOD" field.
        /// </summary>
        public Byte? Method
        {
            get { return _method; }
            set { _method = value; }
        }

        /// <summary>
        ///     the value of the "ICM_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "ICM_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "ICM_SUBJECT" field.
        /// </summary>
        public String Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        /// <summary>
        ///     the value of the "ICM_LOCATION" field.
        /// </summary>
        public String Location
        {
            get { return _location; }
            set { _location = value; }
        }

        /// <summary>
        ///     the value of the "ICM_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        ///     the value of the "ICM_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="IcalmessageRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="IcalmessageRecord" /> object instance.
        /// </returns>
        public IcalmessageRecord Clone()
        {
            IcalmessageRecord record = new IcalmessageRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.IcmtId = this.IcmtId;
            record.Current = this.Current;
            record.Method = this.Method;
            record.Name = this.Name;
            record.Description = this.Description;
            record.Subject = this.Subject;
            record.Location = this.Location;
            record.Text = this.Text;
            record.SelcoSpId = this.SelcoSpId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="IcalmessageRecord" /> instance is equal to another <see cref="IcalmessageRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="IcalmessageRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(IcalmessageRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.IcmtId == that.IcmtId);
            result = result && (this.Current == that.Current);
            result = result && (this.Method == that.Method);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.Subject.TrimOrNullify() == that.Subject.TrimOrNullify());
            result = result && (this.Location.TrimOrNullify() == that.Location.TrimOrNullify());
            result = result && (this.Text.TrimOrNullify() == that.Text.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
