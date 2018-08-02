using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="UserSessionRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerUserSessionRepository : SqlServerRepository<UserSessionRecord, Guid>, IUserSessionRepository
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
            get { return "UserSession"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="UserSessionRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SESSION_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "User_Session"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="UserSessionRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="UserSessionRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, UserSessionRecord record)
        {
            record.Id = dataRecord["SESSION_ID"].ConvertTo<Guid>();
            record.UserId = dataRecord["SESSION_USER_ID"].ConvertTo<Int32>();
            record.Active = dataRecord["SESSION_ACTIVE"].ConvertTo<DateTime>();
            record.Expiry = dataRecord["SESSION_EXPIRY"].ConvertTo<DateTime>();
            record.Status = dataRecord["SESSION_STATUS"].ConvertTo<Int32?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="UserSessionRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, UserSessionRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SESSION_ID", record.Id);
            this.MapParameterIn(command, "@PA_SESSION_USER_ID", record.UserId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.UserId);
            this.MapParameterIn(command, "@PA_SESSION_ACTIVE", record.Active == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Active);
            this.MapParameterIn(command, "@PA_SESSION_EXPIRY", record.Expiry == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Expiry);
            this.MapParameterIn(command, "@PA_SESSION_STATUS", record.Status == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Status);
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
        ///     The <see cref="UserSessionRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, UserSessionRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SESSION_ID", record.Id);
            record.UserId = this.MapParameterOut(command, "@PA_SESSION_USER_ID", record.UserId);
            record.Active = this.MapParameterOut(command, "@PA_SESSION_ACTIVE", record.Active);
            record.Expiry = this.MapParameterOut(command, "@PA_SESSION_EXPIRY", record.Expiry);
            record.Status = this.MapParameterOut(command, "@PA_SESSION_STATUS", record.Status);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="UserSessionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref='UserSessionModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="UserSessionRecord" /> instances that match the specified <paramref name='userId' />.
        /// </returns>
        public IEnumerable<UserSessionRecord> FetchAllByUserId(Int32 userId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "UserId");
            this.MapParameterIn(command, "@PA_SESSION_USER_ID", userId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IUserSessionRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserSessionRecord" /> instances from the data store.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:UserSessionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserSessionRecord" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserSessionRecord> IUserSessionRepository.FetchAllByUserId(System.Int32 userId)
        {
            return this.FetchAllByUserId(userId);
        }

        #endregion
    }
}
