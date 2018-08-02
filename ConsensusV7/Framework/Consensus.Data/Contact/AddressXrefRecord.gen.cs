using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Address_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class AddressXrefRecord : Record<String>, Cloneable<AddressXrefRecord>, IEquatable<AddressXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ADDXREF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ADDXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ADDXREF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ADDXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ADDXREF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ADDXREF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ADDXREF_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "ADDXREF_START" field.
        /// </summary>
        private DateTime? _start;

        /// <summary>
        ///     the value of the "ADDXREF_END" field.
        /// </summary>
        private DateTime? _end;

        /// <summary>
        ///     the value of the "ADDXREF_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "ADDXREF_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "ADDXREF_PRINCIPAL" field.
        /// </summary>
        private Byte? _principal;

        /// <summary>
        ///     the value of the "ADDXREF_SALES_REP" field.
        /// </summary>
        private String _salesRep;

        /// <summary>
        ///     the value of the "ADDXREF_ADD_POSTCODE" field.
        /// </summary>
        private String _addPostcode;

        /// <summary>
        ///     the value of the "ADDXREF_ORG_NAME" field.
        /// </summary>
        private String _orgName;

        /// <summary>
        ///     the value of the "ADDXREF_ORG_DUNS" field.
        /// </summary>
        private String _orgDuns;

        /// <summary>
        ///     the value of the "ADDXREF_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ADDXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_START" field.
        /// </summary>
        public DateTime? Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_END" field.
        /// </summary>
        public DateTime? End
        {
            get { return _end; }
            set { _end = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_PRINCIPAL" field.
        /// </summary>
        public Byte? Principal
        {
            get { return _principal; }
            set { _principal = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_SALES_REP" field.
        /// </summary>
        public String SalesRep
        {
            get { return _salesRep; }
            set { _salesRep = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_ADD_POSTCODE" field.
        /// </summary>
        public String AddPostcode
        {
            get { return _addPostcode; }
            set { _addPostcode = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_ORG_NAME" field.
        /// </summary>
        public String OrgName
        {
            get { return _orgName; }
            set { _orgName = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_ORG_DUNS" field.
        /// </summary>
        public String OrgDuns
        {
            get { return _orgDuns; }
            set { _orgDuns = value; }
        }

        /// <summary>
        ///     the value of the "ADDXREF_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="AddressXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="AddressXrefRecord" /> object instance.
        /// </returns>
        public AddressXrefRecord Clone()
        {
            AddressXrefRecord record = new AddressXrefRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.AddId = this.AddId;
            record.Start = this.Start;
            record.End = this.End;
            record.Type = this.Type;
            record.OrgId = this.OrgId;
            record.Principal = this.Principal;
            record.SalesRep = this.SalesRep;
            record.AddPostcode = this.AddPostcode;
            record.OrgName = this.OrgName;
            record.OrgDuns = this.OrgDuns;
            record.ProleId = this.ProleId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="AddressXrefRecord" /> instance is equal to another <see cref="AddressXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="AddressXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(AddressXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.Start == that.Start);
            result = result && (this.End == that.End);
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.Principal == that.Principal);
            result = result && (this.SalesRep.TrimOrNullify() == that.SalesRep.TrimOrNullify());
            result = result && (this.AddPostcode.TrimOrNullify() == that.AddPostcode.TrimOrNullify());
            result = result && (this.OrgName.TrimOrNullify() == that.OrgName.TrimOrNullify());
            result = result && (this.OrgDuns.TrimOrNullify() == that.OrgDuns.TrimOrNullify());
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
