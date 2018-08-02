using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Communications" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class CommunicationsRecord : Record<Int64>, Cloneable<CommunicationsRecord>, IEquatable<CommunicationsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "COMM_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "COMM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "COMM_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "COMM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        private String _deviceCode;

        /// <summary>
        ///     the value of the "COMM_DIALLING_CODE" field.
        /// </summary>
        private String _diallingCode;

        /// <summary>
        ///     the value of the "COMM_STD_CODE" field.
        /// </summary>
        private String _stdCode;

        /// <summary>
        ///     the value of the "COMM_EXTENSION" field.
        /// </summary>
        private String _extension;

        /// <summary>
        ///     the value of the "COMM_EX_DIRECTORY" field.
        /// </summary>
        private Int32? _exDirectory;

        /// <summary>
        ///     the value of the "COMM_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "COMM_VALID_FROM" field.
        /// </summary>
        private DateTime? _validFrom;

        /// <summary>
        ///     the value of the "COMM_ACTIVE" field.
        /// </summary>
        private Int32? _active;

        /// <summary>
        ///     the value of the "COMM_DEFAULT" field.
        /// </summary>
        private Int32? _default;

        /// <summary>
        ///     the value of the "COMM_PREFERRED" field.
        /// </summary>
        private Int32? _preferred;

        /// <summary>
        ///     the value of the "COMM_DEVICE_VALUE" field.
        /// </summary>
        private String _deviceValue;

        /// <summary>
        ///     the value of the "COMM_DEVICE_FULL_VALUE" field.
        /// </summary>
        private String _deviceFullValue;

        /// <summary>
        ///     the value of the "COMM_ADD_ID" field.
        /// </summary>
        private String _addId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "COMM_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "COMM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "COMM_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "COMM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        public String DeviceCode
        {
            get { return _deviceCode; }
            set { _deviceCode = value; }
        }

        /// <summary>
        ///     the value of the "COMM_DIALLING_CODE" field.
        /// </summary>
        public String DiallingCode
        {
            get { return _diallingCode; }
            set { _diallingCode = value; }
        }

        /// <summary>
        ///     the value of the "COMM_STD_CODE" field.
        /// </summary>
        public String StdCode
        {
            get { return _stdCode; }
            set { _stdCode = value; }
        }

        /// <summary>
        ///     the value of the "COMM_EXTENSION" field.
        /// </summary>
        public String Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }

        /// <summary>
        ///     the value of the "COMM_EX_DIRECTORY" field.
        /// </summary>
        public Int32? ExDirectory
        {
            get { return _exDirectory; }
            set { _exDirectory = value; }
        }

        /// <summary>
        ///     the value of the "COMM_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "COMM_VALID_FROM" field.
        /// </summary>
        public DateTime? ValidFrom
        {
            get { return _validFrom; }
            set { _validFrom = value; }
        }

        /// <summary>
        ///     the value of the "COMM_ACTIVE" field.
        /// </summary>
        public Int32? Active
        {
            get { return _active; }
            set { _active = value; }
        }

        /// <summary>
        ///     the value of the "COMM_DEFAULT" field.
        /// </summary>
        public Int32? Default
        {
            get { return _default; }
            set { _default = value; }
        }

        /// <summary>
        ///     the value of the "COMM_PREFERRED" field.
        /// </summary>
        public Int32? Preferred
        {
            get { return _preferred; }
            set { _preferred = value; }
        }

        /// <summary>
        ///     the value of the "COMM_DEVICE_VALUE" field.
        /// </summary>
        public String DeviceValue
        {
            get { return _deviceValue; }
            set { _deviceValue = value; }
        }

        /// <summary>
        ///     the value of the "COMM_DEVICE_FULL_VALUE" field.
        /// </summary>
        public String DeviceFullValue
        {
            get { return _deviceFullValue; }
            set { _deviceFullValue = value; }
        }

        /// <summary>
        ///     the value of the "COMM_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="CommunicationsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="CommunicationsRecord" /> object instance.
        /// </returns>
        public CommunicationsRecord Clone()
        {
            CommunicationsRecord record = new CommunicationsRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.DeviceCode = this.DeviceCode;
            record.DiallingCode = this.DiallingCode;
            record.StdCode = this.StdCode;
            record.Extension = this.Extension;
            record.ExDirectory = this.ExDirectory;
            record.Notes = this.Notes;
            record.ValidFrom = this.ValidFrom;
            record.Active = this.Active;
            record.Default = this.Default;
            record.Preferred = this.Preferred;
            record.DeviceValue = this.DeviceValue;
            record.DeviceFullValue = this.DeviceFullValue;
            record.AddId = this.AddId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="CommunicationsRecord" /> instance is equal to another <see cref="CommunicationsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="CommunicationsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(CommunicationsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.DeviceCode.TrimOrNullify() == that.DeviceCode.TrimOrNullify());
            result = result && (this.DiallingCode.TrimOrNullify() == that.DiallingCode.TrimOrNullify());
            result = result && (this.StdCode.TrimOrNullify() == that.StdCode.TrimOrNullify());
            result = result && (this.Extension.TrimOrNullify() == that.Extension.TrimOrNullify());
            result = result && (this.ExDirectory == that.ExDirectory);
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.ValidFrom == that.ValidFrom);
            result = result && (this.Active == that.Active);
            result = result && (this.Default == that.Default);
            result = result && (this.Preferred == that.Preferred);
            result = result && (this.DeviceValue.TrimOrNullify() == that.DeviceValue.TrimOrNullify());
            result = result && (this.DeviceFullValue.TrimOrNullify() == that.DeviceFullValue.TrimOrNullify());
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
