using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="OpportunityXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerOpportunityXrefRepository : SqlServerRepository<OpportunityXrefRecord, String>, IOpportunityXrefRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Sales"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "OpportunityXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="OpportunityXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_OPPXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Opportunity_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="OpportunityXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="OpportunityXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, OpportunityXrefRecord record)
        {
            record.Id = dataRecord["OPPXREF_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["OPPXREF_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["OPPXREF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["OPPXREF_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["OPPXREF_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["OPPXREF_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["OPPXREF_RCV_FROM"].ConvertTo<String>();
            record.ProleId = dataRecord["OPPXREF_PROLE_ID"].ConvertTo<String>();
            record.OppId = dataRecord["OPPXREF_OPP_ID"].ConvertTo<String>();
            record.Principal = dataRecord["OPPXREF_PRINCIPAL"].ConvertTo<Byte?>();
            record.Relation = dataRecord["OPPXREF_RELATION"].ConvertTo<String>();
            record.Note = dataRecord["OPPXREF_NOTE"].ConvertTo<String>();
            record.Start = dataRecord["OPPXREF_START"].ConvertTo<DateTime?>();
            record.End = dataRecord["OPPXREF_END"].ConvertTo<DateTime?>();
            record.EndOrg = dataRecord["OPPXREF_END_ORG"].ConvertTo<Byte?>();
            record.DistOrg = dataRecord["OPPXREF_DIST_ORG"].ConvertTo<Byte?>();
            record.Salesman = dataRecord["OPPXREF_SALESMAN"].ConvertTo<String>();
            record.OrgName = dataRecord["OPPXREF_ORG_NAME"].ConvertTo<String>();
            record.PnName = dataRecord["OPPXREF_PN_NAME"].ConvertTo<String>();
            record.OrgId = dataRecord["OPPXREF_ORG_ID"].ConvertTo<String>();
            record.OrgPhone = dataRecord["OPPXREF_ORG_PHONE"].ConvertTo<String>();
            record.PnPhone = dataRecord["OPPXREF_PN_PHONE"].ConvertTo<String>();
            record.Rel1 = dataRecord["OPPXREF_REL_1"].ConvertTo<Byte?>();
            record.Rel2 = dataRecord["OPPXREF_REL_2"].ConvertTo<Byte?>();
            record.Rel3 = dataRecord["OPPXREF_REL_3"].ConvertTo<Byte?>();
            record.Rel4 = dataRecord["OPPXREF_REL_4"].ConvertTo<Byte?>();
            record.Rel5 = dataRecord["OPPXREF_REL_5"].ConvertTo<Byte?>();
            record.Rel6 = dataRecord["OPPXREF_REL_6"].ConvertTo<Byte?>();
            record.Value = dataRecord["OPPXREF_VALUE"].ConvertTo<Decimal?>();
            record.Share = dataRecord["OPPXREF_SHARE"].ConvertTo<Decimal?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="OpportunityXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, OpportunityXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_OPPXREF_ID", record.Id);
            this.MapParameterIn(command, "@PA_OPPXREF_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_OPPXREF_OPP_ID", record.OppId);
            this.MapParameterIn(command, "@PA_OPPXREF_PRINCIPAL", record.Principal);
            this.MapParameterIn(command, "@PA_OPPXREF_RELATION", record.Relation);
            this.MapParameterIn(command, "@PA_OPPXREF_NOTE", record.Note);
            this.MapParameterIn(command, "@PA_OPPXREF_START", record.Start == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Start);
            this.MapParameterIn(command, "@PA_OPPXREF_END", record.End == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.End);
            this.MapParameterIn(command, "@PA_OPPXREF_END_ORG", record.EndOrg);
            this.MapParameterIn(command, "@PA_OPPXREF_DIST_ORG", record.DistOrg);
            this.MapParameterIn(command, "@PA_OPPXREF_SALESMAN", record.Salesman);
            this.MapParameterIn(command, "@PA_OPPXREF_ORG_NAME", record.OrgName);
            this.MapParameterIn(command, "@PA_OPPXREF_PN_NAME", record.PnName);
            this.MapParameterIn(command, "@PA_OPPXREF_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_OPPXREF_ORG_PHONE", record.OrgPhone);
            this.MapParameterIn(command, "@PA_OPPXREF_PN_PHONE", record.PnPhone);
            this.MapParameterIn(command, "@PA_OPPXREF_REL_1", record.Rel1);
            this.MapParameterIn(command, "@PA_OPPXREF_REL_2", record.Rel2);
            this.MapParameterIn(command, "@PA_OPPXREF_REL_3", record.Rel3);
            this.MapParameterIn(command, "@PA_OPPXREF_REL_4", record.Rel4);
            this.MapParameterIn(command, "@PA_OPPXREF_REL_5", record.Rel5);
            this.MapParameterIn(command, "@PA_OPPXREF_REL_6", record.Rel6);
            this.MapParameterIn(command, "@PA_OPPXREF_VALUE", record.Value == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Value);
            this.MapParameterIn(command, "@PA_OPPXREF_SHARE", record.Share == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Share);
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
        ///     The <see cref="OpportunityXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, OpportunityXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_OPPXREF_ID", record.Id);
            record.ProleId = this.MapParameterOut(command, "@PA_OPPXREF_PROLE_ID", record.ProleId);
            record.OppId = this.MapParameterOut(command, "@PA_OPPXREF_OPP_ID", record.OppId);
            record.Principal = this.MapParameterOut(command, "@PA_OPPXREF_PRINCIPAL", record.Principal);
            record.Relation = this.MapParameterOut(command, "@PA_OPPXREF_RELATION", record.Relation);
            record.Note = this.MapParameterOut(command, "@PA_OPPXREF_NOTE", record.Note);
            record.Start = this.MapParameterOut(command, "@PA_OPPXREF_START", record.Start);
            record.End = this.MapParameterOut(command, "@PA_OPPXREF_END", record.End);
            record.EndOrg = this.MapParameterOut(command, "@PA_OPPXREF_END_ORG", record.EndOrg);
            record.DistOrg = this.MapParameterOut(command, "@PA_OPPXREF_DIST_ORG", record.DistOrg);
            record.Salesman = this.MapParameterOut(command, "@PA_OPPXREF_SALESMAN", record.Salesman);
            record.OrgName = this.MapParameterOut(command, "@PA_OPPXREF_ORG_NAME", record.OrgName);
            record.PnName = this.MapParameterOut(command, "@PA_OPPXREF_PN_NAME", record.PnName);
            record.OrgId = this.MapParameterOut(command, "@PA_OPPXREF_ORG_ID", record.OrgId);
            record.OrgPhone = this.MapParameterOut(command, "@PA_OPPXREF_ORG_PHONE", record.OrgPhone);
            record.PnPhone = this.MapParameterOut(command, "@PA_OPPXREF_PN_PHONE", record.PnPhone);
            record.Rel1 = this.MapParameterOut(command, "@PA_OPPXREF_REL_1", record.Rel1);
            record.Rel2 = this.MapParameterOut(command, "@PA_OPPXREF_REL_2", record.Rel2);
            record.Rel3 = this.MapParameterOut(command, "@PA_OPPXREF_REL_3", record.Rel3);
            record.Rel4 = this.MapParameterOut(command, "@PA_OPPXREF_REL_4", record.Rel4);
            record.Rel5 = this.MapParameterOut(command, "@PA_OPPXREF_REL_5", record.Rel5);
            record.Rel6 = this.MapParameterOut(command, "@PA_OPPXREF_REL_6", record.Rel6);
            record.Value = this.MapParameterOut(command, "@PA_OPPXREF_VALUE", record.Value);
            record.Share = this.MapParameterOut(command, "@PA_OPPXREF_SHARE", record.Share);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="OpportunityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='OpportunityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="OpportunityXrefRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<OpportunityXrefRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_OPPXREF_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="OpportunityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref='OpportunityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="OpportunityXrefRecord" /> instances that match the specified <paramref name='oppId' />.
        /// </returns>
        public IEnumerable<OpportunityXrefRecord> FetchAllByOppId(String oppId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OppId");
            this.MapParameterIn(command, "@PA_OPPXREF_OPP_ID", oppId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="OpportunityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='OpportunityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="OpportunityXrefRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<OpportunityXrefRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_OPPXREF_ORG_ID", orgId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IOpportunityXrefRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityXrefRecord> IOpportunityXrefRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances that match the specified <paramref name="oppId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityXrefRecord> IOpportunityXrefRepository.FetchAllByOppId(System.String oppId)
        {
            return this.FetchAllByOppId(oppId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityXrefRecord> IOpportunityXrefRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        #endregion
    }
}
