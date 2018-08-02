using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "GiftAidClaim" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class GiftaidclaimRecord : Record<Int32>, Cloneable<GiftaidclaimRecord>, IEquatable<GiftaidclaimRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "GAC_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "GAC_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "GAC_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "GAC_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        private String _submitterProleId;

        /// <summary>
        ///     the value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        private String _trusteeProleId;

        /// <summary>
        ///     the value of the "GAC_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "GAC_CLAIM_DATE" field.
        /// </summary>
        private DateTime _claimDate;

        /// <summary>
        ///     the value of the "GAC_DONATIONS_FROM" field.
        /// </summary>
        private DateTime _donationsFrom;

        /// <summary>
        ///     the value of the "GAC_DONATIONS_TO" field.
        /// </summary>
        private DateTime _donationsTo;

        /// <summary>
        ///     the value of the "GAC_ACCOUNTING_PERIOD_END" field.
        /// </summary>
        private DateTime _accountingPeriodEnd;

        /// <summary>
        ///     the value of the "GAC_HMRC_REFERENCE" field.
        /// </summary>
        private String _hmrcReference;

        /// <summary>
        ///     the value of the "GAC_REGULATOR_NAME" field.
        /// </summary>
        private String _regulatorName;

        /// <summary>
        ///     the value of the "GAC_REGULATOR_NUMBER" field.
        /// </summary>
        private String _regulatorNumber;

        /// <summary>
        ///     the value of the "GAC_ADJUSTMENT" field.
        /// </summary>
        private Decimal? _adjustment;

        /// <summary>
        ///     the value of the "GAC_PROCESS" field.
        /// </summary>
        private Byte _process;

        /// <summary>
        ///     the value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "GAC_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "GAC_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "GAC_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "GAC_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        public String SubmitterProleId
        {
            get { return _submitterProleId; }
            set { _submitterProleId = value; }
        }

        /// <summary>
        ///     the value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        public String TrusteeProleId
        {
            get { return _trusteeProleId; }
            set { _trusteeProleId = value; }
        }

        /// <summary>
        ///     the value of the "GAC_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "GAC_CLAIM_DATE" field.
        /// </summary>
        public DateTime ClaimDate
        {
            get { return _claimDate; }
            set { _claimDate = value; }
        }

        /// <summary>
        ///     the value of the "GAC_DONATIONS_FROM" field.
        /// </summary>
        public DateTime DonationsFrom
        {
            get { return _donationsFrom; }
            set { _donationsFrom = value; }
        }

        /// <summary>
        ///     the value of the "GAC_DONATIONS_TO" field.
        /// </summary>
        public DateTime DonationsTo
        {
            get { return _donationsTo; }
            set { _donationsTo = value; }
        }

        /// <summary>
        ///     the value of the "GAC_ACCOUNTING_PERIOD_END" field.
        /// </summary>
        public DateTime AccountingPeriodEnd
        {
            get { return _accountingPeriodEnd; }
            set { _accountingPeriodEnd = value; }
        }

        /// <summary>
        ///     the value of the "GAC_HMRC_REFERENCE" field.
        /// </summary>
        public String HmrcReference
        {
            get { return _hmrcReference; }
            set { _hmrcReference = value; }
        }

        /// <summary>
        ///     the value of the "GAC_REGULATOR_NAME" field.
        /// </summary>
        public String RegulatorName
        {
            get { return _regulatorName; }
            set { _regulatorName = value; }
        }

        /// <summary>
        ///     the value of the "GAC_REGULATOR_NUMBER" field.
        /// </summary>
        public String RegulatorNumber
        {
            get { return _regulatorNumber; }
            set { _regulatorNumber = value; }
        }

        /// <summary>
        ///     the value of the "GAC_ADJUSTMENT" field.
        /// </summary>
        public Decimal? Adjustment
        {
            get { return _adjustment; }
            set { _adjustment = value; }
        }

        /// <summary>
        ///     the value of the "GAC_PROCESS" field.
        /// </summary>
        public Byte Process
        {
            get { return _process; }
            set { _process = value; }
        }

        /// <summary>
        ///     the value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="GiftaidclaimRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="GiftaidclaimRecord" /> object instance.
        /// </returns>
        public GiftaidclaimRecord Clone()
        {
            GiftaidclaimRecord record = new GiftaidclaimRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.SubmitterProleId = this.SubmitterProleId;
            record.TrusteeProleId = this.TrusteeProleId;
            record.OrgId = this.OrgId;
            record.ClaimDate = this.ClaimDate;
            record.DonationsFrom = this.DonationsFrom;
            record.DonationsTo = this.DonationsTo;
            record.AccountingPeriodEnd = this.AccountingPeriodEnd;
            record.HmrcReference = this.HmrcReference;
            record.RegulatorName = this.RegulatorName;
            record.RegulatorNumber = this.RegulatorNumber;
            record.Adjustment = this.Adjustment;
            record.Process = this.Process;
            record.SelcoSpId = this.SelcoSpId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="GiftaidclaimRecord" /> instance is equal to another <see cref="GiftaidclaimRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="GiftaidclaimRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(GiftaidclaimRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.SubmitterProleId.TrimOrNullify() == that.SubmitterProleId.TrimOrNullify());
            result = result && (this.TrusteeProleId.TrimOrNullify() == that.TrusteeProleId.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.ClaimDate == that.ClaimDate);
            result = result && (this.DonationsFrom == that.DonationsFrom);
            result = result && (this.DonationsTo == that.DonationsTo);
            result = result && (this.AccountingPeriodEnd == that.AccountingPeriodEnd);
            result = result && (this.HmrcReference.TrimOrNullify() == that.HmrcReference.TrimOrNullify());
            result = result && (this.RegulatorName.TrimOrNullify() == that.RegulatorName.TrimOrNullify());
            result = result && (this.RegulatorNumber.TrimOrNullify() == that.RegulatorNumber.TrimOrNullify());
            result = result && (this.Adjustment == that.Adjustment);
            result = result && (this.Process == that.Process);
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
