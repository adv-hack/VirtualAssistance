using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="UserAccountRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerUserAccountRepository : SqlServerRepository<UserAccountRecord, Int32>, IUserAccountRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Security"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "UserAccount"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="UserAccountRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_USER_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "User_Account"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="UserAccountRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="UserAccountRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, UserAccountRecord record)
        {
            record.Id = dataRecord["USER_ID"].ConvertTo<Int32>();
            record.PrincipalId = dataRecord["USER_PRINCIPAL_ID"].ConvertTo<Int32>();
            record.PersonId = dataRecord["USER_PERSON_ID"].ConvertTo<String>();
            record.SelcoId = dataRecord["USER_SELCO_ID"].ConvertTo<String>();
            record.Status = dataRecord["USER_STATUS"].ConvertTo<Int32>();
            record.FailCount = dataRecord["USER_FAIL_COUNT"].ConvertTo<Int32>();
            record.LastLogin = dataRecord["USER_LAST_LOGIN"].ConvertTo<DateTime?>();
            record.Provider = dataRecord["USER_PROVIDER"].ConvertTo<String>();
            record.SysAdmin = dataRecord["USER_SYS_ADMIN"].ConvertTo<Byte?>();
            record.LicenseType = dataRecord["USER_LICENSE_TYPE"].ConvertTo<Int32>();
            record.RepId = dataRecord["USER_REP_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="UserAccountRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, UserAccountRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_USER_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_USER_PRINCIPAL_ID", record.PrincipalId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PrincipalId);
            this.MapParameterIn(command, "@PA_USER_PERSON_ID", record.PersonId);
            this.MapParameterIn(command, "@PA_USER_SELCO_ID", record.SelcoId);
            this.MapParameterIn(command, "@PA_USER_STATUS", record.Status == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Status);
            this.MapParameterIn(command, "@PA_USER_FAIL_COUNT", record.FailCount == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.FailCount);
            this.MapParameterIn(command, "@PA_USER_LAST_LOGIN", record.LastLogin == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LastLogin);
            this.MapParameterIn(command, "@PA_USER_PROVIDER", record.Provider);
            this.MapParameterIn(command, "@PA_USER_SYS_ADMIN", record.SysAdmin);
            this.MapParameterIn(command, "@PA_USER_LICENSE_TYPE", record.LicenseType == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LicenseType);
            this.MapParameterIn(command, "@PA_USER_REP_ID", record.RepId);
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
        ///     The <see cref="UserAccountRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, UserAccountRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_USER_ID", record.Id);
            record.PrincipalId = this.MapParameterOut(command, "@PA_USER_PRINCIPAL_ID", record.PrincipalId);
            record.PersonId = this.MapParameterOut(command, "@PA_USER_PERSON_ID", record.PersonId);
            record.SelcoId = this.MapParameterOut(command, "@PA_USER_SELCO_ID", record.SelcoId);
            record.Status = this.MapParameterOut(command, "@PA_USER_STATUS", record.Status);
            record.FailCount = this.MapParameterOut(command, "@PA_USER_FAIL_COUNT", record.FailCount);
            record.LastLogin = this.MapParameterOut(command, "@PA_USER_LAST_LOGIN", record.LastLogin);
            record.Provider = this.MapParameterOut(command, "@PA_USER_PROVIDER", record.Provider);
            record.SysAdmin = this.MapParameterOut(command, "@PA_USER_SYS_ADMIN", record.SysAdmin);
            record.LicenseType = this.MapParameterOut(command, "@PA_USER_LICENSE_TYPE", record.LicenseType);
            record.RepId = this.MapParameterOut(command, "@PA_USER_REP_ID", record.RepId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref='UserAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="UserAccountRecord" /> instances that match the specified <paramref name='principalId' />.
        /// </returns>
        public IEnumerable<UserAccountRecord> FetchAllByPrincipalId(Int32 principalId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PrincipalId");
            this.MapParameterIn(command, "@PA_USER_PRINCIPAL_ID", principalId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='UserAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="UserAccountRecord" /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<UserAccountRecord> FetchAllByPersonId(String personId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PersonId");
            this.MapParameterIn(command, "@PA_USER_PERSON_ID", personId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoId">
        ///     The value which identifies the <see cref='UserAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="UserAccountRecord" /> instances that match the specified <paramref name='selcoId' />.
        /// </returns>
        public IEnumerable<UserAccountRecord> FetchAllBySelcoId(String selcoId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoId");
            this.MapParameterIn(command, "@PA_USER_SELCO_ID", selcoId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="repId">
        ///     The value which identifies the <see cref='UserAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="UserAccountRecord" /> instances that match the specified <paramref name='repId' />.
        /// </returns>
        public IEnumerable<UserAccountRecord> FetchAllByRepId(String repId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "RepId");
            this.MapParameterIn(command, "@PA_USER_REP_ID", repId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IUserAccountRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a single <see cref="T:Consensus.Security.UserAccountRecord" /> instance from the data store.
        /// </summary>
        /// <param name="username">
        ///     The value which identifies the <see cref="T:Consensus.Security.UserAccountRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Security.UserAccountRecord" /> instance which matches the specified <paramref name="username" />.
        /// </returns>
        Consensus.Security.UserAccountRecord IUserAccountRepository.FetchByUsername(System.String username)
        {
            return this.FetchByUsername(username);
        }

        /// <summary>
        ///     Retrieves a string <see cref="T:System.String" /> value which contains the reporting URL.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:System.String" /> reporting URL.
        /// </returns>
        System.String IUserAccountRepository.ReportingURL(System.String portalPage)
        {
            return this.ReportingURL(portalPage);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserAccountRecord> IUserAccountRepository.FetchAllByPrincipalId(System.Int32 principalId)
        {
            return this.FetchAllByPrincipalId(principalId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserAccountRecord> IUserAccountRepository.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances that match the specified <paramref name="selcoId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserAccountRecord> IUserAccountRepository.FetchAllBySelcoId(System.String selcoId)
        {
            return this.FetchAllBySelcoId(selcoId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances from the data store.
        /// </summary>
        /// <param name="repId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserAccountRecord" /> instances that match the specified <paramref name="repId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserAccountRecord> IUserAccountRepository.FetchAllByRepId(System.String repId)
        {
            return this.FetchAllByRepId(repId);
        }

        #endregion
    }
}
