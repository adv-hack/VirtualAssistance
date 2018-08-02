using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="UserCredentialRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerUserCredentialRepository : SqlServerRepository<UserCredentialRecord, Int32>, IUserCredentialRepository
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
            get { return "UserCredential"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="UserCredentialRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CREDENTIAL_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "User_Credential"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="UserCredentialRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="UserCredentialRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, UserCredentialRecord record)
        {
            record.Id = dataRecord["CREDENTIAL_ID"].ConvertTo<Int32>();
            record.User = dataRecord["CREDENTIAL_USER_ID"].ConvertTo<Int32>();
            record.Salt = dataRecord["CREDENTIAL_SALT"].ConvertTo<Byte[]>();
            record.Pass = dataRecord["CREDENTIAL_PASS"].ConvertTo<Byte[]>();
            record.Modified = dataRecord["CREDENTIAL_MODIFIED"].ConvertTo<DateTime>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="UserCredentialRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, UserCredentialRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CREDENTIAL_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_CREDENTIAL_USER_ID", record.User == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.User);
            this.MapParameterIn(command, "@PA_CREDENTIAL_SALT", record.Salt);
            this.MapParameterIn(command, "@PA_CREDENTIAL_PASS", record.Pass);
            this.MapParameterIn(command, "@PA_CREDENTIAL_MODIFIED", record.Modified == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Modified);
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
        ///     The <see cref="UserCredentialRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, UserCredentialRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CREDENTIAL_ID", record.Id);
            record.User = this.MapParameterOut(command, "@PA_CREDENTIAL_USER_ID", record.User);
            record.Salt = this.MapParameterOut(command, "@PA_CREDENTIAL_SALT", record.Salt);
            record.Pass = this.MapParameterOut(command, "@PA_CREDENTIAL_PASS", record.Pass);
            record.Modified = this.MapParameterOut(command, "@PA_CREDENTIAL_MODIFIED", record.Modified);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="UserCredentialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="user">
        ///     The value which identifies the <see cref='UserCredentialModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="UserCredentialRecord" /> instances that match the specified <paramref name='user' />.
        /// </returns>
        public IEnumerable<UserCredentialRecord> FetchAllByUser(Int32 user)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "User");
            this.MapParameterIn(command, "@PA_CREDENTIAL_USER_ID", user);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IUserCredentialRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserCredentialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="user">
        ///     The value which identifies the <see cref="!:UserCredentialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserCredentialRecord" /> instances that match the specified <paramref name="user" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserCredentialRecord> IUserCredentialRepository.FetchAllByUser(System.Int32 user)
        {
            return this.FetchAllByUser(user);
        }

        #endregion
    }
}
