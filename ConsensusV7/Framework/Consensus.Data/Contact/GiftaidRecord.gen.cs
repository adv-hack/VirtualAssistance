using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "GiftAid" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class GiftaidRecord : Record<Int32>, Cloneable<GiftaidRecord>, IEquatable<GiftaidRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "GIF_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "GIF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "GIF_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "GIF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "GIF_PN_ID" field.
        /// </summary>
        private String _pnId;

        /// <summary>
        ///     the value of the "GIF_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "GIF_ACTIVE" field.
        /// </summary>
        private Byte _active;

        /// <summary>
        ///     the value of the "GIF_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "GIF_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        /// <summary>
        ///     the value of the "GIF_COMMUNICATION" field.
        /// </summary>
        private Byte _communication;

        /// <summary>
        ///     the value of the "GIF_FIRST_NAME" field.
        /// </summary>
        private String _firstName;

        /// <summary>
        ///     the value of the "GIF_SURNAME" field.
        /// </summary>
        private String _surname;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "GIF_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "GIF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "GIF_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "GIF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "GIF_PN_ID" field.
        /// </summary>
        public String PnId
        {
            get { return _pnId; }
            set { _pnId = value; }
        }

        /// <summary>
        ///     the value of the "GIF_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "GIF_ACTIVE" field.
        /// </summary>
        public Byte Active
        {
            get { return _active; }
            set { _active = value; }
        }

        /// <summary>
        ///     the value of the "GIF_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "GIF_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        ///     the value of the "GIF_COMMUNICATION" field.
        /// </summary>
        public Byte Communication
        {
            get { return _communication; }
            set { _communication = value; }
        }

        /// <summary>
        ///     the value of the "GIF_FIRST_NAME" field.
        /// </summary>
        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        ///     the value of the "GIF_SURNAME" field.
        /// </summary>
        public String Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="GiftaidRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="GiftaidRecord" /> object instance.
        /// </returns>
        public GiftaidRecord Clone()
        {
            GiftaidRecord record = new GiftaidRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.PnId = this.PnId;
            record.Type = this.Type;
            record.Active = this.Active;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            record.Communication = this.Communication;
            record.FirstName = this.FirstName;
            record.Surname = this.Surname;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="GiftaidRecord" /> instance is equal to another <see cref="GiftaidRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="GiftaidRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(GiftaidRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PnId.TrimOrNullify() == that.PnId.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Active == that.Active);
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            result = result && (this.Communication == that.Communication);
            result = result && (this.FirstName.TrimOrNullify() == that.FirstName.TrimOrNullify());
            result = result && (this.Surname.TrimOrNullify() == that.Surname.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
