using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Represents the "Opportunity_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class OpportunityXrefRecord : Record<String>, Cloneable<OpportunityXrefRecord>, IEquatable<OpportunityXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "OPPXREF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "OPPXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "OPPXREF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "OPPXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "OPPXREF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "OPPXREF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        private String _oppId;

        /// <summary>
        ///     the value of the "OPPXREF_PRINCIPAL" field.
        /// </summary>
        private Byte? _principal;

        /// <summary>
        ///     the value of the "OPPXREF_RELATION" field.
        /// </summary>
        private String _relation;

        /// <summary>
        ///     the value of the "OPPXREF_NOTE" field.
        /// </summary>
        private String _note;

        /// <summary>
        ///     the value of the "OPPXREF_START" field.
        /// </summary>
        private DateTime? _start;

        /// <summary>
        ///     the value of the "OPPXREF_END" field.
        /// </summary>
        private DateTime? _end;

        /// <summary>
        ///     the value of the "OPPXREF_END_ORG" field.
        /// </summary>
        private Byte? _endOrg;

        /// <summary>
        ///     the value of the "OPPXREF_DIST_ORG" field.
        /// </summary>
        private Byte? _distOrg;

        /// <summary>
        ///     the value of the "OPPXREF_SALESMAN" field.
        /// </summary>
        private String _salesman;

        /// <summary>
        ///     the value of the "OPPXREF_ORG_NAME" field.
        /// </summary>
        private String _orgName;

        /// <summary>
        ///     the value of the "OPPXREF_PN_NAME" field.
        /// </summary>
        private String _pnName;

        /// <summary>
        ///     the value of the "OPPXREF_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "OPPXREF_ORG_PHONE" field.
        /// </summary>
        private String _orgPhone;

        /// <summary>
        ///     the value of the "OPPXREF_PN_PHONE" field.
        /// </summary>
        private String _pnPhone;

        /// <summary>
        ///     the value of the "OPPXREF_REL_1" field.
        /// </summary>
        private Byte? _rel1;

        /// <summary>
        ///     the value of the "OPPXREF_REL_2" field.
        /// </summary>
        private Byte? _rel2;

        /// <summary>
        ///     the value of the "OPPXREF_REL_3" field.
        /// </summary>
        private Byte? _rel3;

        /// <summary>
        ///     the value of the "OPPXREF_REL_4" field.
        /// </summary>
        private Byte? _rel4;

        /// <summary>
        ///     the value of the "OPPXREF_REL_5" field.
        /// </summary>
        private Byte? _rel5;

        /// <summary>
        ///     the value of the "OPPXREF_REL_6" field.
        /// </summary>
        private Byte? _rel6;

        /// <summary>
        ///     the value of the "OPPXREF_VALUE" field.
        /// </summary>
        private Decimal? _value;

        /// <summary>
        ///     the value of the "OPPXREF_SHARE" field.
        /// </summary>
        private Decimal? _share;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "OPPXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        public String OppId
        {
            get { return _oppId; }
            set { _oppId = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_PRINCIPAL" field.
        /// </summary>
        public Byte? Principal
        {
            get { return _principal; }
            set { _principal = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_RELATION" field.
        /// </summary>
        public String Relation
        {
            get { return _relation; }
            set { _relation = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_NOTE" field.
        /// </summary>
        public String Note
        {
            get { return _note; }
            set { _note = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_START" field.
        /// </summary>
        public DateTime? Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_END" field.
        /// </summary>
        public DateTime? End
        {
            get { return _end; }
            set { _end = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_END_ORG" field.
        /// </summary>
        public Byte? EndOrg
        {
            get { return _endOrg; }
            set { _endOrg = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_DIST_ORG" field.
        /// </summary>
        public Byte? DistOrg
        {
            get { return _distOrg; }
            set { _distOrg = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_SALESMAN" field.
        /// </summary>
        public String Salesman
        {
            get { return _salesman; }
            set { _salesman = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_ORG_NAME" field.
        /// </summary>
        public String OrgName
        {
            get { return _orgName; }
            set { _orgName = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_PN_NAME" field.
        /// </summary>
        public String PnName
        {
            get { return _pnName; }
            set { _pnName = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_ORG_PHONE" field.
        /// </summary>
        public String OrgPhone
        {
            get { return _orgPhone; }
            set { _orgPhone = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_PN_PHONE" field.
        /// </summary>
        public String PnPhone
        {
            get { return _pnPhone; }
            set { _pnPhone = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_REL_1" field.
        /// </summary>
        public Byte? Rel1
        {
            get { return _rel1; }
            set { _rel1 = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_REL_2" field.
        /// </summary>
        public Byte? Rel2
        {
            get { return _rel2; }
            set { _rel2 = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_REL_3" field.
        /// </summary>
        public Byte? Rel3
        {
            get { return _rel3; }
            set { _rel3 = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_REL_4" field.
        /// </summary>
        public Byte? Rel4
        {
            get { return _rel4; }
            set { _rel4 = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_REL_5" field.
        /// </summary>
        public Byte? Rel5
        {
            get { return _rel5; }
            set { _rel5 = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_REL_6" field.
        /// </summary>
        public Byte? Rel6
        {
            get { return _rel6; }
            set { _rel6 = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_VALUE" field.
        /// </summary>
        public Decimal? Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        ///     the value of the "OPPXREF_SHARE" field.
        /// </summary>
        public Decimal? Share
        {
            get { return _share; }
            set { _share = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="OpportunityXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="OpportunityXrefRecord" /> object instance.
        /// </returns>
        public OpportunityXrefRecord Clone()
        {
            OpportunityXrefRecord record = new OpportunityXrefRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.ProleId = this.ProleId;
            record.OppId = this.OppId;
            record.Principal = this.Principal;
            record.Relation = this.Relation;
            record.Note = this.Note;
            record.Start = this.Start;
            record.End = this.End;
            record.EndOrg = this.EndOrg;
            record.DistOrg = this.DistOrg;
            record.Salesman = this.Salesman;
            record.OrgName = this.OrgName;
            record.PnName = this.PnName;
            record.OrgId = this.OrgId;
            record.OrgPhone = this.OrgPhone;
            record.PnPhone = this.PnPhone;
            record.Rel1 = this.Rel1;
            record.Rel2 = this.Rel2;
            record.Rel3 = this.Rel3;
            record.Rel4 = this.Rel4;
            record.Rel5 = this.Rel5;
            record.Rel6 = this.Rel6;
            record.Value = this.Value;
            record.Share = this.Share;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="OpportunityXrefRecord" /> instance is equal to another <see cref="OpportunityXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="OpportunityXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(OpportunityXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.OppId.TrimOrNullify() == that.OppId.TrimOrNullify());
            result = result && (this.Principal == that.Principal);
            result = result && (this.Relation.TrimOrNullify() == that.Relation.TrimOrNullify());
            result = result && (this.Note.TrimOrNullify() == that.Note.TrimOrNullify());
            result = result && (this.Start == that.Start);
            result = result && (this.End == that.End);
            result = result && (this.EndOrg == that.EndOrg);
            result = result && (this.DistOrg == that.DistOrg);
            result = result && (this.Salesman.TrimOrNullify() == that.Salesman.TrimOrNullify());
            result = result && (this.OrgName.TrimOrNullify() == that.OrgName.TrimOrNullify());
            result = result && (this.PnName.TrimOrNullify() == that.PnName.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.OrgPhone.TrimOrNullify() == that.OrgPhone.TrimOrNullify());
            result = result && (this.PnPhone.TrimOrNullify() == that.PnPhone.TrimOrNullify());
            result = result && (this.Rel1 == that.Rel1);
            result = result && (this.Rel2 == that.Rel2);
            result = result && (this.Rel3 == that.Rel3);
            result = result && (this.Rel4 == that.Rel4);
            result = result && (this.Rel5 == that.Rel5);
            result = result && (this.Rel6 == that.Rel6);
            result = result && (this.Value == that.Value);
            result = result && (this.Share == that.Share);
            return result;
        }

        #endregion
    }
}
