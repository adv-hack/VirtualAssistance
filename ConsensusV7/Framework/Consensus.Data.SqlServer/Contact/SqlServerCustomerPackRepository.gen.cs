using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CustomerPackRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCustomerPackRepository : SqlServerRepository<CustomerPackRecord, Int32>, ICustomerPackRepository
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
            get { return "CustomerPack"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CustomerPackRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CPA_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Customer_Pack"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CustomerPackRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CustomerPackRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CustomerPackRecord record)
        {
            record.Id = dataRecord["CPA_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["CPA_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["CPA_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["CPA_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["CPA_MOD_BY"].ConvertTo<String>();
            record.OrgId = dataRecord["CPA_ORG_ID"].ConvertTo<String>();
            record.PackId = dataRecord["CPA_PACK_ID"].ConvertTo<String>();
            record.Type = dataRecord["CPA_TYPE"].ConvertTo<String>();
            record.Suppress = dataRecord["CPA_SUPPRESS"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CustomerPackRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CustomerPackRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CPA_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_CPA_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_CPA_PACK_ID", record.PackId);
            this.MapParameterIn(command, "@PA_CPA_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_CPA_SUPPRESS", record.Suppress);
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
        ///     The <see cref="CustomerPackRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CustomerPackRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CPA_ID", record.Id);
            record.OrgId = this.MapParameterOut(command, "@PA_CPA_ORG_ID", record.OrgId);
            record.PackId = this.MapParameterOut(command, "@PA_CPA_PACK_ID", record.PackId);
            record.Type = this.MapParameterOut(command, "@PA_CPA_TYPE", record.Type);
            record.Suppress = this.MapParameterOut(command, "@PA_CPA_SUPPRESS", record.Suppress);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CustomerPackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='CustomerPackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CustomerPackRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<CustomerPackRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_CPA_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CustomerPackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref='CustomerPackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CustomerPackRecord" /> instances that match the specified <paramref name='packId' />.
        /// </returns>
        public IEnumerable<CustomerPackRecord> FetchAllByPackId(String packId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PackId");
            this.MapParameterIn(command, "@PA_CPA_PACK_ID", packId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICustomerPackRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.CustomerPackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:CustomerPackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.CustomerPackRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.CustomerPackRecord> ICustomerPackRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.CustomerPackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:CustomerPackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.CustomerPackRecord" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.CustomerPackRecord> ICustomerPackRepository.FetchAllByPackId(System.String packId)
        {
            return this.FetchAllByPackId(packId);
        }

        #endregion
    }
}
