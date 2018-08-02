using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="GiftaidclaimRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerGiftaidclaimRepository : SqlServerRepository<GiftaidclaimRecord, Int32>, IGiftaidclaimRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Finance"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Giftaidclaim"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="GiftaidclaimRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_GAC_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "GiftAidClaim"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="GiftaidclaimRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="GiftaidclaimRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, GiftaidclaimRecord record)
        {
            record.Id = dataRecord["GAC_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["GAC_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["GAC_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["GAC_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["GAC_MOD_BY"].ConvertTo<String>();
            record.SubmitterProleId = dataRecord["GAC_SUBMITTER_PROLE_ID"].ConvertTo<String>();
            record.TrusteeProleId = dataRecord["GAC_TRUSTEE_PROLE_ID"].ConvertTo<String>();
            record.OrgId = dataRecord["GAC_ORG_ID"].ConvertTo<String>();
            record.ClaimDate = dataRecord["GAC_CLAIM_DATE"].ConvertTo<DateTime>();
            record.DonationsFrom = dataRecord["GAC_DONATIONS_FROM"].ConvertTo<DateTime>();
            record.DonationsTo = dataRecord["GAC_DONATIONS_TO"].ConvertTo<DateTime>();
            record.AccountingPeriodEnd = dataRecord["GAC_ACCOUNTING_PERIOD_END"].ConvertTo<DateTime>();
            record.HmrcReference = dataRecord["GAC_HMRC_REFERENCE"].ConvertTo<String>();
            record.RegulatorName = dataRecord["GAC_REGULATOR_NAME"].ConvertTo<String>();
            record.RegulatorNumber = dataRecord["GAC_REGULATOR_NUMBER"].ConvertTo<String>();
            record.Adjustment = dataRecord["GAC_ADJUSTMENT"].ConvertTo<Decimal?>();
            record.Process = dataRecord["GAC_PROCESS"].ConvertTo<Byte>();
            record.SelcoSpId = dataRecord["GAC_SELCO_SP_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="GiftaidclaimRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, GiftaidclaimRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_GAC_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_GAC_SUBMITTER_PROLE_ID", record.SubmitterProleId);
            this.MapParameterIn(command, "@PA_GAC_TRUSTEE_PROLE_ID", record.TrusteeProleId);
            this.MapParameterIn(command, "@PA_GAC_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_GAC_CLAIM_DATE", record.ClaimDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ClaimDate);
            this.MapParameterIn(command, "@PA_GAC_DONATIONS_FROM", record.DonationsFrom == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DonationsFrom);
            this.MapParameterIn(command, "@PA_GAC_DONATIONS_TO", record.DonationsTo == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DonationsTo);
            this.MapParameterIn(command, "@PA_GAC_ACCOUNTING_PERIOD_END", record.AccountingPeriodEnd == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AccountingPeriodEnd);
            this.MapParameterIn(command, "@PA_GAC_HMRC_REFERENCE", record.HmrcReference);
            this.MapParameterIn(command, "@PA_GAC_REGULATOR_NAME", record.RegulatorName);
            this.MapParameterIn(command, "@PA_GAC_REGULATOR_NUMBER", record.RegulatorNumber);
            this.MapParameterIn(command, "@PA_GAC_ADJUSTMENT", record.Adjustment == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Adjustment);
            this.MapParameterIn(command, "@PA_GAC_PROCESS", record.Process);
            this.MapParameterIn(command, "@PA_GAC_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@_AUDIT_USER_ID", UserId);
            this.MapParameterIn(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="GiftaidclaimRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, GiftaidclaimRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_GAC_ID", record.Id);
            record.SubmitterProleId = this.MapParameterOut(command, "@PA_GAC_SUBMITTER_PROLE_ID", record.SubmitterProleId);
            record.TrusteeProleId = this.MapParameterOut(command, "@PA_GAC_TRUSTEE_PROLE_ID", record.TrusteeProleId);
            record.OrgId = this.MapParameterOut(command, "@PA_GAC_ORG_ID", record.OrgId);
            record.ClaimDate = this.MapParameterOut(command, "@PA_GAC_CLAIM_DATE", record.ClaimDate);
            record.DonationsFrom = this.MapParameterOut(command, "@PA_GAC_DONATIONS_FROM", record.DonationsFrom);
            record.DonationsTo = this.MapParameterOut(command, "@PA_GAC_DONATIONS_TO", record.DonationsTo);
            record.AccountingPeriodEnd = this.MapParameterOut(command, "@PA_GAC_ACCOUNTING_PERIOD_END", record.AccountingPeriodEnd);
            record.HmrcReference = this.MapParameterOut(command, "@PA_GAC_HMRC_REFERENCE", record.HmrcReference);
            record.RegulatorName = this.MapParameterOut(command, "@PA_GAC_REGULATOR_NAME", record.RegulatorName);
            record.RegulatorNumber = this.MapParameterOut(command, "@PA_GAC_REGULATOR_NUMBER", record.RegulatorNumber);
            record.Adjustment = this.MapParameterOut(command, "@PA_GAC_ADJUSTMENT", record.Adjustment);
            record.Process = this.MapParameterOut(command, "@PA_GAC_PROCESS", record.Process);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_GAC_SELCO_SP_ID", record.SelcoSpId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="submitterProleId">
        ///     The value which identifies the <see cref='GiftaidclaimModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="GiftaidclaimRecord" /> instances that match the specified <paramref name='submitterProleId' />.
        /// </returns>
        public IEnumerable<GiftaidclaimRecord> FetchAllBySubmitterProleId(String submitterProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SubmitterProleId");
            this.MapParameterIn(command, "@PA_GAC_SUBMITTER_PROLE_ID", submitterProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trusteeProleId">
        ///     The value which identifies the <see cref='GiftaidclaimModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="GiftaidclaimRecord" /> instances that match the specified <paramref name='trusteeProleId' />.
        /// </returns>
        public IEnumerable<GiftaidclaimRecord> FetchAllByTrusteeProleId(String trusteeProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "TrusteeProleId");
            this.MapParameterIn(command, "@PA_GAC_TRUSTEE_PROLE_ID", trusteeProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='GiftaidclaimModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="GiftaidclaimRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<GiftaidclaimRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_GAC_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='GiftaidclaimModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="GiftaidclaimRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<GiftaidclaimRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_GAC_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IGiftaidclaimRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="submitterProleId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances that match the specified <paramref name="submitterProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.GiftaidclaimRecord> IGiftaidclaimRepository.FetchAllBySubmitterProleId(System.String submitterProleId)
        {
            return this.FetchAllBySubmitterProleId(submitterProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trusteeProleId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances that match the specified <paramref name="trusteeProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.GiftaidclaimRecord> IGiftaidclaimRepository.FetchAllByTrusteeProleId(System.String trusteeProleId)
        {
            return this.FetchAllByTrusteeProleId(trusteeProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.GiftaidclaimRecord> IGiftaidclaimRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.GiftaidclaimRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.GiftaidclaimRecord> IGiftaidclaimRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        #endregion
    }
}
