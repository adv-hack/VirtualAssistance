using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Associates" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class AssociatesRecord : Record<Int32>, Cloneable<AssociatesRecord>, IEquatable<AssociatesRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ASSO_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "ASSO_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ASSO_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "ASSO_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ASSO_RCV_DATE" field.
        /// </summary>
        private DateTime _rcvDate;

        /// <summary>
        ///     the value of the "ASSO_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        private String _associateId;

        /// <summary>
        ///     the value of the "ASSO_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "ASSO_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "ASSO_TYPE" field.
        /// </summary>
        private Byte _type;

        /// <summary>
        ///     the value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        private String _typeName;

        /// <summary>
        ///     the value of the "ASSO_TYPE_CODE" field.
        /// </summary>
        private String _typeCode;

        /// <summary>
        ///     the value of the "ASSO_START_DATE" field.
        /// </summary>
        private DateTime? _startDate;

        /// <summary>
        ///     the value of the "ASSO_END_DATE" field.
        /// </summary>
        private DateTime? _endDate;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ASSO_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_RCV_DATE" field.
        /// </summary>
        public DateTime RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        public String AssociateId
        {
            get { return _associateId; }
            set { _associateId = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        public String TypeName
        {
            get { return _typeName; }
            set { _typeName = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_TYPE_CODE" field.
        /// </summary>
        public String TypeCode
        {
            get { return _typeCode; }
            set { _typeCode = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        ///     the value of the "ASSO_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="AssociatesRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="AssociatesRecord" /> object instance.
        /// </returns>
        public AssociatesRecord Clone()
        {
            AssociatesRecord record = new AssociatesRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.AssociateId = this.AssociateId;
            record.ProleId = this.ProleId;
            record.OrgId = this.OrgId;
            record.Type = this.Type;
            record.TypeName = this.TypeName;
            record.TypeCode = this.TypeCode;
            record.StartDate = this.StartDate;
            record.EndDate = this.EndDate;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="AssociatesRecord" /> instance is equal to another <see cref="AssociatesRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="AssociatesRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(AssociatesRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.AssociateId.TrimOrNullify() == that.AssociateId.TrimOrNullify());
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.TypeName.TrimOrNullify() == that.TypeName.TrimOrNullify());
            result = result && (this.TypeCode.TrimOrNullify() == that.TypeCode.TrimOrNullify());
            result = result && (this.StartDate == that.StartDate);
            result = result && (this.EndDate == that.EndDate);
            return result;
        }

        #endregion
    }
}
