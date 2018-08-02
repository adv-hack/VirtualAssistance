using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Represents the "District" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class DistrictRecord : Record<String>, Cloneable<DistrictRecord>, IEquatable<DistrictRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "DIS_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "DIS_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "DIS_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "DIS_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "DIS_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "DIS_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "DIS_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "DIS_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "DIS_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "DIS_CATEGORY" field.
        /// </summary>
        private String _category;

        /// <summary>
        ///     the value of the "DIS_GROUP" field.
        /// </summary>
        private String _group;

        /// <summary>
        ///     the value of the "DIS_REGION" field.
        /// </summary>
        private String _region;

        /// <summary>
        ///     the value of the "DIS_WEB" field.
        /// </summary>
        private Byte _web;

        /// <summary>
        ///     the value of the "DIS_EXT_URL" field.
        /// </summary>
        private String _extUrl;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "DIS_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "DIS_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "DIS_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "DIS_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "DIS_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "DIS_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "DIS_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "DIS_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "DIS_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "DIS_CATEGORY" field.
        /// </summary>
        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        ///     the value of the "DIS_GROUP" field.
        /// </summary>
        public String Group
        {
            get { return _group; }
            set { _group = value; }
        }

        /// <summary>
        ///     the value of the "DIS_REGION" field.
        /// </summary>
        public String Region
        {
            get { return _region; }
            set { _region = value; }
        }

        /// <summary>
        ///     the value of the "DIS_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return _web; }
            set { _web = value; }
        }

        /// <summary>
        ///     the value of the "DIS_EXT_URL" field.
        /// </summary>
        public String ExtUrl
        {
            get { return _extUrl; }
            set { _extUrl = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="DistrictRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="DistrictRecord" /> object instance.
        /// </returns>
        public DistrictRecord Clone()
        {
            DistrictRecord record = new DistrictRecord();
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
            record.Category = this.Category;
            record.Group = this.Group;
            record.Region = this.Region;
            record.Web = this.Web;
            record.ExtUrl = this.ExtUrl;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="DistrictRecord" /> instance is equal to another <see cref="DistrictRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="DistrictRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(DistrictRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Category.TrimOrNullify() == that.Category.TrimOrNullify());
            result = result && (this.Group.TrimOrNullify() == that.Group.TrimOrNullify());
            result = result && (this.Region.TrimOrNullify() == that.Region.TrimOrNullify());
            result = result && (this.Web == that.Web);
            result = result && (this.ExtUrl.TrimOrNullify() == that.ExtUrl.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
