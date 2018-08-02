using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AkaRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerAkaRepository : SqlServerRepository<AkaRecord, Int32>, IAkaRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Contact"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Aka"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="AkaRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_AKA_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "AKA"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="AkaRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AkaRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, AkaRecord record)
        {
            record.Id = dataRecord["AKA_ID"].ConvertTo<Int32>();
            record.AddBy = dataRecord["AKA_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["AKA_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["AKA_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["AKA_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["AKA_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["AKA_RCV_DATE"].ConvertTo<DateTime?>();
            record.Name = dataRecord["AKA_NAME"].ConvertTo<String>();
            record.OrgId = dataRecord["AKA_ORG_ID"].ConvertTo<String>();
            record.PnId = dataRecord["AKA_PN_ID"].ConvertTo<String>();
            record.Type = dataRecord["AKA_TYPE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AkaRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, AkaRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_AKA_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_AKA_NAME", record.Name);
            this.MapParameterIn(command, "@PA_AKA_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_AKA_PN_ID", record.PnId);
            this.MapParameterIn(command, "@PA_AKA_TYPE", record.Type);
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
        ///     The <see cref="AkaRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, AkaRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_AKA_ID", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_AKA_NAME", record.Name);
            record.OrgId = this.MapParameterOut(command, "@PA_AKA_ORG_ID", record.OrgId);
            record.PnId = this.MapParameterOut(command, "@PA_AKA_PN_ID", record.PnId);
            record.Type = this.MapParameterOut(command, "@PA_AKA_TYPE", record.Type);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AkaRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='AkaModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AkaRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<AkaRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_AKA_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AkaRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref='AkaModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AkaRecord" /> instances that match the specified <paramref name='pnId' />.
        /// </returns>
        public IEnumerable<AkaRecord> FetchAllByPnId(String pnId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PnId");
            this.MapParameterIn(command, "@PA_AKA_PN_ID", pnId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IAkaRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.AkaRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:AkaModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.AkaRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.AkaRecord> IAkaRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.AkaRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref="!:AkaModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.AkaRecord" /> instances that match the specified <paramref name="pnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.AkaRecord> IAkaRepository.FetchAllByPnId(System.String pnId)
        {
            return this.FetchAllByPnId(pnId);
        }

        #endregion
    }
}
