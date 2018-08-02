using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents the "List_Member" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ListMemberRecord : Record<String>, Cloneable<ListMemberRecord>, IEquatable<ListMemberRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "LM_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "LM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "LM_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "LM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "LM_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "LM_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "LM_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "LM_LIST_ID" field.
        /// </summary>
        private String _listId;

        /// <summary>
        ///     the value of the "LM_PN_ID" field.
        /// </summary>
        private String _pnId;

        /// <summary>
        ///     the value of the "LM_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "LM_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "LM_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "LM_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "LM_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "LM_TERMS_READ" field.
        /// </summary>
        private Byte _termsRead;

        /// <summary>
        ///     the value of the "LM_TABLE_NAME" field.
        /// </summary>
        private String _tableName;

        /// <summary>
        ///     the value of the "LM_RECORD_ID" field.
        /// </summary>
        private String _recordId;

        /// <summary>
        ///     the value of the "LM_DISABLE" field.
        /// </summary>
        private Byte _disable;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "LM_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "LM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "LM_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "LM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "LM_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "LM_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "LM_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "LM_LIST_ID" field.
        /// </summary>
        public String ListId
        {
            get { return _listId; }
            set { _listId = value; }
        }

        /// <summary>
        ///     the value of the "LM_PN_ID" field.
        /// </summary>
        public String PnId
        {
            get { return _pnId; }
            set { _pnId = value; }
        }

        /// <summary>
        ///     the value of the "LM_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "LM_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "LM_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "LM_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "LM_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "LM_TERMS_READ" field.
        /// </summary>
        public Byte TermsRead
        {
            get { return _termsRead; }
            set { _termsRead = value; }
        }

        /// <summary>
        ///     the value of the "LM_TABLE_NAME" field.
        /// </summary>
        public String TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        /// <summary>
        ///     the value of the "LM_RECORD_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        /// <summary>
        ///     the value of the "LM_DISABLE" field.
        /// </summary>
        public Byte Disable
        {
            get { return _disable; }
            set { _disable = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ListMemberRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ListMemberRecord" /> object instance.
        /// </returns>
        public ListMemberRecord Clone()
        {
            ListMemberRecord record = new ListMemberRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.ListId = this.ListId;
            record.PnId = this.PnId;
            record.Title = this.Title;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Userchar3 = this.Userchar3;
            record.Userchar4 = this.Userchar4;
            record.TermsRead = this.TermsRead;
            record.TableName = this.TableName;
            record.RecordId = this.RecordId;
            record.Disable = this.Disable;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ListMemberRecord" /> instance is equal to another <see cref="ListMemberRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ListMemberRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ListMemberRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.ListId.TrimOrNullify() == that.ListId.TrimOrNullify());
            result = result && (this.PnId.TrimOrNullify() == that.PnId.TrimOrNullify());
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.TermsRead == that.TermsRead);
            result = result && (this.TableName.TrimOrNullify() == that.TableName.TrimOrNullify());
            result = result && (this.RecordId.TrimOrNullify() == that.RecordId.TrimOrNullify());
            result = result && (this.Disable == that.Disable);
            return result;
        }

        #endregion
    }
}
