using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "QuickAccessLink" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class QuickaccesslinkRecord : Record<Int32>, Cloneable<QuickaccesslinkRecord>, IEquatable<QuickaccesslinkRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "QAL_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "QAL_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "QAL_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "QAL_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "QAL_USER_ID" field.
        /// </summary>
        private Int32 _userId;

        /// <summary>
        ///     the value of the "QAL_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "QAL_URL" field.
        /// </summary>
        private String _url;

        /// <summary>
        ///     the value of the "QAL_ICON" field.
        /// </summary>
        private String _icon;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "QAL_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "QAL_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "QAL_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "QAL_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "QAL_USER_ID" field.
        /// </summary>
        public Int32 UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        /// <summary>
        ///     the value of the "QAL_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "QAL_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        ///     the value of the "QAL_ICON" field.
        /// </summary>
        public String Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="QuickaccesslinkRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="QuickaccesslinkRecord" /> object instance.
        /// </returns>
        public QuickaccesslinkRecord Clone()
        {
            QuickaccesslinkRecord record = new QuickaccesslinkRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.UserId = this.UserId;
            record.Description = this.Description;
            record.Url = this.Url;
            record.Icon = this.Icon;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="QuickaccesslinkRecord" /> instance is equal to another <see cref="QuickaccesslinkRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="QuickaccesslinkRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(QuickaccesslinkRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.UserId == that.UserId);
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            result = result && (this.Icon.TrimOrNullify() == that.Icon.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
