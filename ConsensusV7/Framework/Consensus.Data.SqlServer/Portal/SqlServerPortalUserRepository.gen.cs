using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PortalUserRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPortalUserRepository : SqlServerRepository<PortalUserRecord, Int32>, IPortalUserRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Portal"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "PortalUser"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PortalUserRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PU_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "PORTAL_USER"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PortalUserRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PortalUserRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PortalUserRecord record)
        {
            record.Id = dataRecord["PU_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["PU_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PU_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PU_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PU_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PU_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PU_RCV_FROM"].ConvertTo<String>();
            record.PrId = dataRecord["PU_PR_ID"].ConvertTo<Int32?>();
            record.ProleId = dataRecord["PU_PROLE_ID"].ConvertTo<String>();
            record.LoginId = dataRecord["PU_LOGIN_ID"].ConvertTo<String>();
            record.Password = dataRecord["PU_PASSWORD"].ConvertTo<String>();
            record.Barred = dataRecord["PU_BARRED"].ConvertTo<Byte?>();
            record.SysAdmin = dataRecord["PU_SYS_ADMIN"].ConvertTo<Byte?>();
            record.ShtLoginId = dataRecord["PU_SHT_LOGIN_ID"].ConvertTo<String>();
            record.Create = dataRecord["PU_CREATE"].ConvertTo<String>();
            record.Read = dataRecord["PU_READ"].ConvertTo<String>();
            record.Update = dataRecord["PU_UPDATE"].ConvertTo<String>();
            record.Delete = dataRecord["PU_DELETE"].ConvertTo<String>();
            record.Ntusername = dataRecord["PU_NTUSERNAME"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["PU_SELCO_SP_ID"].ConvertTo<String>();
            record.IncMyorg = dataRecord["PU_INC_MYORG"].ConvertTo<Byte>();
            record.AttemptCount = dataRecord["PU_ATTEMPT_COUNT"].ConvertTo<Byte?>();
            record.LockedUntil = dataRecord["PU_LOCKED_UNTIL"].ConvertTo<DateTime?>();
            record.ResetCode = dataRecord["PU_RESET_CODE"].ConvertTo<String>();
            record.PartnerSysRef = dataRecord["PU_PARTNER_SYS_REF"].ConvertTo<String>();
            record.SecretQuest = dataRecord["PU_SECRET_QUEST"].ConvertTo<String>();
            record.SecretAnswer = dataRecord["PU_SECRET_ANSWER"].ConvertTo<String>();
            record.FirstLogin = dataRecord["PU_FIRST_LOGIN"].ConvertTo<DateTime?>();
            record.LastLogin = dataRecord["PU_LAST_LOGIN"].ConvertTo<DateTime?>();
            record.NoLogins = dataRecord["PU_NO_LOGINS"].ConvertTo<Int64>();
            record.ResetValidUntil = dataRecord["PU_RESET_VALID_UNTIL"].ConvertTo<DateTime?>();
            record.ResetUrl = dataRecord["PU_RESET_URL"].ConvertTo<String>();
            record.Guid = dataRecord["PU_GUID"].ConvertTo<Guid>();
            record.AuthProvider = dataRecord["PU_AUTH_PROVIDER"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PortalUserRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PortalUserRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PU_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_PU_PR_ID", record.PrId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PrId);
            this.MapParameterIn(command, "@PA_PU_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_PU_LOGIN_ID", record.LoginId);
            this.MapParameterIn(command, "@PA_PU_PASSWORD", record.Password);
            this.MapParameterIn(command, "@PA_PU_BARRED", record.Barred);
            this.MapParameterIn(command, "@PA_PU_SYS_ADMIN", record.SysAdmin);
            this.MapParameterIn(command, "@PA_PU_SHT_LOGIN_ID", record.ShtLoginId);
            this.MapParameterIn(command, "@PA_PU_CREATE", record.Create);
            this.MapParameterIn(command, "@PA_PU_READ", record.Read);
            this.MapParameterIn(command, "@PA_PU_UPDATE", record.Update);
            this.MapParameterIn(command, "@PA_PU_DELETE", record.Delete);
            this.MapParameterIn(command, "@PA_PU_NTUSERNAME", record.Ntusername);
            this.MapParameterIn(command, "@PA_PU_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_PU_INC_MYORG", record.IncMyorg);
            this.MapParameterIn(command, "@PA_PU_ATTEMPT_COUNT", record.AttemptCount);
            this.MapParameterIn(command, "@PA_PU_LOCKED_UNTIL", record.LockedUntil == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LockedUntil);
            this.MapParameterIn(command, "@PA_PU_RESET_CODE", record.ResetCode);
            this.MapParameterIn(command, "@PA_PU_PARTNER_SYS_REF", record.PartnerSysRef);
            this.MapParameterIn(command, "@PA_PU_SECRET_QUEST", record.SecretQuest);
            this.MapParameterIn(command, "@PA_PU_SECRET_ANSWER", record.SecretAnswer);
            this.MapParameterIn(command, "@PA_PU_FIRST_LOGIN", record.FirstLogin == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.FirstLogin);
            this.MapParameterIn(command, "@PA_PU_LAST_LOGIN", record.LastLogin == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LastLogin);
            this.MapParameterIn(command, "@PA_PU_NO_LOGINS", record.NoLogins == Int64.MinValue ? 0 : record.NoLogins);
            this.MapParameterIn(command, "@PA_PU_RESET_VALID_UNTIL", record.ResetValidUntil == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ResetValidUntil);
            this.MapParameterIn(command, "@PA_PU_RESET_URL", record.ResetUrl);
            this.MapParameterIn(command, "@PA_PU_GUID", record.Guid);
            this.MapParameterIn(command, "@PA_PU_AUTH_PROVIDER", record.AuthProvider);
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
        ///     The <see cref="PortalUserRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PortalUserRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PU_ID", record.Id);
            record.PrId = this.MapParameterOut(command, "@PA_PU_PR_ID", record.PrId);
            record.ProleId = this.MapParameterOut(command, "@PA_PU_PROLE_ID", record.ProleId);
            record.LoginId = this.MapParameterOut(command, "@PA_PU_LOGIN_ID", record.LoginId);
            record.Password = this.MapParameterOut(command, "@PA_PU_PASSWORD", record.Password);
            record.Barred = this.MapParameterOut(command, "@PA_PU_BARRED", record.Barred);
            record.SysAdmin = this.MapParameterOut(command, "@PA_PU_SYS_ADMIN", record.SysAdmin);
            record.ShtLoginId = this.MapParameterOut(command, "@PA_PU_SHT_LOGIN_ID", record.ShtLoginId);
            record.Create = this.MapParameterOut(command, "@PA_PU_CREATE", record.Create);
            record.Read = this.MapParameterOut(command, "@PA_PU_READ", record.Read);
            record.Update = this.MapParameterOut(command, "@PA_PU_UPDATE", record.Update);
            record.Delete = this.MapParameterOut(command, "@PA_PU_DELETE", record.Delete);
            record.Ntusername = this.MapParameterOut(command, "@PA_PU_NTUSERNAME", record.Ntusername);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_PU_SELCO_SP_ID", record.SelcoSpId);
            record.IncMyorg = this.MapParameterOut(command, "@PA_PU_INC_MYORG", record.IncMyorg);
            record.AttemptCount = this.MapParameterOut(command, "@PA_PU_ATTEMPT_COUNT", record.AttemptCount);
            record.LockedUntil = this.MapParameterOut(command, "@PA_PU_LOCKED_UNTIL", record.LockedUntil);
            record.ResetCode = this.MapParameterOut(command, "@PA_PU_RESET_CODE", record.ResetCode);
            record.PartnerSysRef = this.MapParameterOut(command, "@PA_PU_PARTNER_SYS_REF", record.PartnerSysRef);
            record.SecretQuest = this.MapParameterOut(command, "@PA_PU_SECRET_QUEST", record.SecretQuest);
            record.SecretAnswer = this.MapParameterOut(command, "@PA_PU_SECRET_ANSWER", record.SecretAnswer);
            record.FirstLogin = this.MapParameterOut(command, "@PA_PU_FIRST_LOGIN", record.FirstLogin);
            record.LastLogin = this.MapParameterOut(command, "@PA_PU_LAST_LOGIN", record.LastLogin);
            record.NoLogins = this.MapParameterOut(command, "@PA_PU_NO_LOGINS", record.NoLogins);
            record.ResetValidUntil = this.MapParameterOut(command, "@PA_PU_RESET_VALID_UNTIL", record.ResetValidUntil);
            record.ResetUrl = this.MapParameterOut(command, "@PA_PU_RESET_URL", record.ResetUrl);
            record.Guid = this.MapParameterOut(command, "@PA_PU_GUID", record.Guid);
            record.AuthProvider = this.MapParameterOut(command, "@PA_PU_AUTH_PROVIDER", record.AuthProvider);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PortalUserRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='PortalUserModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PortalUserRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<PortalUserRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_PU_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PortalUserRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='PortalUserModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PortalUserRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<PortalUserRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_PU_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPortalUserRepository.TableName
        {
            get { return this.TableName; }
        }

        void IPortalUserRepository.Create(Consensus.Portal.PortalUserRecord record)
        {
            this.Create(record);
        }

        void IPortalUserRepository.Modify(Consensus.Portal.PortalUserRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Portal.PortalUserRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Portal.PortalUserRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.PortalUserRecord> IPortalUserRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Portal.PortalUserRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Portal.PortalUserRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.PortalUserRecord> IPortalUserRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        #endregion
    }
}
