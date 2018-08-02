using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Represents the "Committee" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class CommitteeRecord : Record<String>, Cloneable<CommitteeRecord>, IEquatable<CommitteeRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "COM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "COM_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "COM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "COM_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "COM_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "COM_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "COM_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "COM_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "COM_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "COM_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "COM_CATEGORY" field.
        /// </summary>
        private String _category;

        /// <summary>
        ///     the value of the "COM_GROUP" field.
        /// </summary>
        private String _group;

        /// <summary>
        ///     the value of the "COM_DIS_ID" field.
        /// </summary>
        private String _disId;

        /// <summary>
        ///     the value of the "COM_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "COM_BR_ID" field.
        /// </summary>
        private String _brId;

        /// <summary>
        ///     the value of the "COM_EXT_URL" field.
        /// </summary>
        private String _extUrl;

        /// <summary>
        ///     the value of the "COM_SHOW_ON_ORG" field.
        /// </summary>
        private Byte? _showOnOrg;

        /// <summary>
        ///     the value of the "COM_NO_PEOPLE" field.
        /// </summary>
        private Int32? _noPeople;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "COM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "COM_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "COM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "COM_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "COM_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "COM_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "COM_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "COM_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "COM_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "COM_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "COM_CATEGORY" field.
        /// </summary>
        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        ///     the value of the "COM_GROUP" field.
        /// </summary>
        public String Group
        {
            get { return _group; }
            set { _group = value; }
        }

        /// <summary>
        ///     the value of the "COM_DIS_ID" field.
        /// </summary>
        public String DisId
        {
            get { return _disId; }
            set { _disId = value; }
        }

        /// <summary>
        ///     the value of the "COM_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "COM_BR_ID" field.
        /// </summary>
        public String BrId
        {
            get { return _brId; }
            set { _brId = value; }
        }

        /// <summary>
        ///     the value of the "COM_EXT_URL" field.
        /// </summary>
        public String ExtUrl
        {
            get { return _extUrl; }
            set { _extUrl = value; }
        }

        /// <summary>
        ///     the value of the "COM_SHOW_ON_ORG" field.
        /// </summary>
        public Byte? ShowOnOrg
        {
            get { return _showOnOrg; }
            set { _showOnOrg = value; }
        }

        /// <summary>
        ///     the value of the "COM_NO_PEOPLE" field.
        /// </summary>
        public Int32? NoPeople
        {
            get { return _noPeople; }
            set { _noPeople = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="CommitteeRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="CommitteeRecord" /> object instance.
        /// </returns>
        public CommitteeRecord Clone()
        {
            CommitteeRecord record = new CommitteeRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.Name = this.Name;
            record.Status = this.Status;
            record.Type = this.Type;
            record.StartDate = this.StartDate;
            record.Category = this.Category;
            record.Group = this.Group;
            record.DisId = this.DisId;
            record.ProdId = this.ProdId;
            record.BrId = this.BrId;
            record.ExtUrl = this.ExtUrl;
            record.ShowOnOrg = this.ShowOnOrg;
            record.NoPeople = this.NoPeople;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="CommitteeRecord" /> instance is equal to another <see cref="CommitteeRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="CommitteeRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(CommitteeRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.Category.TrimOrNullify() == that.Category.TrimOrNullify());
            result = result && (this.Group.TrimOrNullify() == that.Group.TrimOrNullify());
            result = result && (this.DisId.TrimOrNullify() == that.DisId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.BrId.TrimOrNullify() == that.BrId.TrimOrNullify());
            result = result && (this.ExtUrl.TrimOrNullify() == that.ExtUrl.TrimOrNullify());
            result = result && (this.ShowOnOrg == that.ShowOnOrg);
            result = result && (this.NoPeople == that.NoPeople);
            return result;
        }

        #endregion
    }
}
