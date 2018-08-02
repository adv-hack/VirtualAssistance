using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AccountXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerAccountXrefRepository : SqlServerRepository<AccountXrefRecord, String>, IAccountXrefRepository
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
            get { return "AccountXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="AccountXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ACXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Account_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="AccountXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AccountXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, AccountXrefRecord record)
        {
            record.Id = dataRecord["ACXREF_ID"].ConvertTo<String>();
            record.Lock = dataRecord["ACXREF_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["ACXREF_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ACXREF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ACXREF_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ACXREF_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ACXREF_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["ACXREF_RCV_FROM"].ConvertTo<String>();
            record.AccId = dataRecord["ACXREF_ACC_ID"].ConvertTo<String>();
            record.OrgId = dataRecord["ACXREF_ORG_ID"].ConvertTo<String>();
            record.AddId = dataRecord["ACXREF_ADD_ID"].ConvertTo<String>();
            record.Main = dataRecord["ACXREF_MAIN"].ConvertTo<Byte?>();
            record.Invoice = dataRecord["ACXREF_INVOICE"].ConvertTo<Byte?>();
            record.Statement = dataRecord["ACXREF_STATEMENT"].ConvertTo<Byte?>();
            record.NoAddChange = dataRecord["ACXREF_NO_ADD_CHANGE"].ConvertTo<Byte?>();
            record.ProleId = dataRecord["ACXREF_PROLE_ID"].ConvertTo<String>();
            record.ForAttnOf = dataRecord["ACXREF_FOR_ATTN_OF"].ConvertTo<String>();
            record.Code = dataRecord["ACXREF_CODE"].ConvertTo<String>();
            record.Nominated = dataRecord["ACXREF_NOMINATED"].ConvertTo<Byte?>();
            record.InclHierarchy = dataRecord["ACXREF_INCL_HIERARCHY"].ConvertTo<Byte>();
            record.FromHierarchy = dataRecord["ACXREF_FROM_HIERARCHY"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AccountXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, AccountXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ACXREF_ID", record.Id);
            this.MapParameterIn(command, "@PA_ACXREF_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_ACXREF_ACC_ID", record.AccId);
            this.MapParameterIn(command, "@PA_ACXREF_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_ACXREF_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_ACXREF_MAIN", record.Main);
            this.MapParameterIn(command, "@PA_ACXREF_INVOICE", record.Invoice);
            this.MapParameterIn(command, "@PA_ACXREF_STATEMENT", record.Statement);
            this.MapParameterIn(command, "@PA_ACXREF_NO_ADD_CHANGE", record.NoAddChange);
            this.MapParameterIn(command, "@PA_ACXREF_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_ACXREF_FOR_ATTN_OF", record.ForAttnOf);
            this.MapParameterIn(command, "@PA_ACXREF_CODE", record.Code);
            this.MapParameterIn(command, "@PA_ACXREF_NOMINATED", record.Nominated);
            this.MapParameterIn(command, "@PA_ACXREF_INCL_HIERARCHY", record.InclHierarchy);
            this.MapParameterIn(command, "@PA_ACXREF_FROM_HIERARCHY", record.FromHierarchy);
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
        ///     The <see cref="AccountXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, AccountXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ACXREF_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_ACXREF_LOCK", record.Lock);
            record.AccId = this.MapParameterOut(command, "@PA_ACXREF_ACC_ID", record.AccId);
            record.OrgId = this.MapParameterOut(command, "@PA_ACXREF_ORG_ID", record.OrgId);
            record.AddId = this.MapParameterOut(command, "@PA_ACXREF_ADD_ID", record.AddId);
            record.Main = this.MapParameterOut(command, "@PA_ACXREF_MAIN", record.Main);
            record.Invoice = this.MapParameterOut(command, "@PA_ACXREF_INVOICE", record.Invoice);
            record.Statement = this.MapParameterOut(command, "@PA_ACXREF_STATEMENT", record.Statement);
            record.NoAddChange = this.MapParameterOut(command, "@PA_ACXREF_NO_ADD_CHANGE", record.NoAddChange);
            record.ProleId = this.MapParameterOut(command, "@PA_ACXREF_PROLE_ID", record.ProleId);
            record.ForAttnOf = this.MapParameterOut(command, "@PA_ACXREF_FOR_ATTN_OF", record.ForAttnOf);
            record.Code = this.MapParameterOut(command, "@PA_ACXREF_CODE", record.Code);
            record.Nominated = this.MapParameterOut(command, "@PA_ACXREF_NOMINATED", record.Nominated);
            record.InclHierarchy = this.MapParameterOut(command, "@PA_ACXREF_INCL_HIERARCHY", record.InclHierarchy);
            record.FromHierarchy = this.MapParameterOut(command, "@PA_ACXREF_FROM_HIERARCHY", record.FromHierarchy);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref='AccountXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AccountXrefRecord" /> instances that match the specified <paramref name='accId' />.
        /// </returns>
        public IEnumerable<AccountXrefRecord> FetchAllByAccId(String accId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AccId");
            this.MapParameterIn(command, "@PA_ACXREF_ACC_ID", accId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='AccountXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AccountXrefRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<AccountXrefRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_ACXREF_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref='AccountXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AccountXrefRecord" /> instances that match the specified <paramref name='addId' />.
        /// </returns>
        public IEnumerable<AccountXrefRecord> FetchAllByAddId(String addId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AddId");
            this.MapParameterIn(command, "@PA_ACXREF_ADD_ID", addId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='AccountXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AccountXrefRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<AccountXrefRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_ACXREF_PROLE_ID", proleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IAccountXrefRepository.TableName
        {
            get { return this.TableName; }
        }

        void IAccountXrefRepository.Create(Consensus.Finance.AccountXrefRecord record)
        {
            this.Create(record);
        }

        void IAccountXrefRepository.Modify(Consensus.Finance.AccountXrefRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="accId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances that match the specified <paramref name="accId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountXrefRecord> IAccountXrefRepository.FetchAllByAccId(System.String accId)
        {
            return this.FetchAllByAccId(accId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountXrefRecord> IAccountXrefRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountXrefRecord> IAccountXrefRepository.FetchAllByAddId(System.String addId)
        {
            return this.FetchAllByAddId(addId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.AccountXrefRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.AccountXrefRecord> IAccountXrefRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        #endregion
    }
}
