using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "PackType" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PacktypeRecord : Record<Int32>, Cloneable<PacktypeRecord>, IEquatable<PacktypeRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PACKTYP_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "PACKTYP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PACKTYP_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "PACKTYP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PACKTYP_TYPE" field.
        /// </summary>
        private Byte _type;

        /// <summary>
        ///     the value of the "PACKTYP_DESC" field.
        /// </summary>
        private String _desc;

        /// <summary>
        ///     the value of the "PACKTYP_STORED_PROC" field.
        /// </summary>
        private String _storedProc;

        /// <summary>
        ///     the value of the "PACKTYP_URL" field.
        /// </summary>
        private String _url;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PACKTYP_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PACKTYP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PACKTYP_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PACKTYP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PACKTYP_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "PACKTYP_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        ///     the value of the "PACKTYP_STORED_PROC" field.
        /// </summary>
        public String StoredProc
        {
            get { return _storedProc; }
            set { _storedProc = value; }
        }

        /// <summary>
        ///     the value of the "PACKTYP_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PacktypeRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PacktypeRecord" /> object instance.
        /// </returns>
        public PacktypeRecord Clone()
        {
            PacktypeRecord record = new PacktypeRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.Type = this.Type;
            record.Desc = this.Desc;
            record.StoredProc = this.StoredProc;
            record.Url = this.Url;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PacktypeRecord" /> instance is equal to another <see cref="PacktypeRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PacktypeRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PacktypeRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Type == that.Type);
            result = result && (this.Desc.TrimOrNullify() == that.Desc.TrimOrNullify());
            result = result && (this.StoredProc.TrimOrNullify() == that.StoredProc.TrimOrNullify());
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
