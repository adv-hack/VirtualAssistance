using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Represents the "C4Text" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class C4textRecord : Record<String>, Cloneable<C4textRecord>, IEquatable<C4textRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "TEXT_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "TEXT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "TEXT_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "TEXT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "TEXT_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "TEXT_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "TEXT_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "TEXT_OWNER_ID" field.
        /// </summary>
        private String _ownerId;

        /// <summary>
        ///     the value of the "TEXT_BODY" field.
        /// </summary>
        private String _body;

        /// <summary>
        ///     the value of the "TEXT_RTF" field.
        /// </summary>
        private String _rtf;

        /// <summary>
        ///     the value of the "TEXT_HTML" field.
        /// </summary>
        private String _html;

        /// <summary>
        ///     the value of the "TEXT_OWNER_URL" field.
        /// </summary>
        private String _ownerUrl;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "TEXT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_OWNER_ID" field.
        /// </summary>
        public String OwnerId
        {
            get { return _ownerId; }
            set { _ownerId = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_BODY" field.
        /// </summary>
        public String Body
        {
            get { return _body; }
            set { _body = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_RTF" field.
        /// </summary>
        public String Rtf
        {
            get { return _rtf; }
            set { _rtf = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_HTML" field.
        /// </summary>
        public String Html
        {
            get { return _html; }
            set { _html = value; }
        }

        /// <summary>
        ///     the value of the "TEXT_OWNER_URL" field.
        /// </summary>
        public String OwnerUrl
        {
            get { return _ownerUrl; }
            set { _ownerUrl = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="C4textRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="C4textRecord" /> object instance.
        /// </returns>
        public C4textRecord Clone()
        {
            C4textRecord record = new C4textRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Type = this.Type;
            record.OwnerId = this.OwnerId;
            record.Body = this.Body;
            record.Rtf = this.Rtf;
            record.Html = this.Html;
            record.OwnerUrl = this.OwnerUrl;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="C4textRecord" /> instance is equal to another <see cref="C4textRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="C4textRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(C4textRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.OwnerId.TrimOrNullify() == that.OwnerId.TrimOrNullify());
            result = result && (this.Body.TrimOrNullify() == that.Body.TrimOrNullify());
            result = result && (this.Rtf.TrimOrNullify() == that.Rtf.TrimOrNullify());
            result = result && (this.Html.TrimOrNullify() == that.Html.TrimOrNullify());
            result = result && (this.OwnerUrl.TrimOrNullify() == that.OwnerUrl.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
