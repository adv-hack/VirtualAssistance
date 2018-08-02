using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Customer_Pack" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class CustomerPackRecord : Record<Int32>, Cloneable<CustomerPackRecord>, IEquatable<CustomerPackRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CPA_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "CPA_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "CPA_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "CPA_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "CPA_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "CPA_PACK_ID" field.
        /// </summary>
        private String _packId;

        /// <summary>
        ///     the value of the "CPA_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "CPA_SUPPRESS" field.
        /// </summary>
        private Byte _suppress;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CPA_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "CPA_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "CPA_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "CPA_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "CPA_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "CPA_PACK_ID" field.
        /// </summary>
        public String PackId
        {
            get { return _packId; }
            set { _packId = value; }
        }

        /// <summary>
        ///     the value of the "CPA_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "CPA_SUPPRESS" field.
        /// </summary>
        public Byte Suppress
        {
            get { return _suppress; }
            set { _suppress = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="CustomerPackRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="CustomerPackRecord" /> object instance.
        /// </returns>
        public CustomerPackRecord Clone()
        {
            CustomerPackRecord record = new CustomerPackRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.OrgId = this.OrgId;
            record.PackId = this.PackId;
            record.Type = this.Type;
            record.Suppress = this.Suppress;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="CustomerPackRecord" /> instance is equal to another <see cref="CustomerPackRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="CustomerPackRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(CustomerPackRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.PackId.TrimOrNullify() == that.PackId.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Suppress == that.Suppress);
            return result;
        }

        #endregion
    }
}
