using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="UserGroupRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerUserGroupRepository : SqlServerRepository<UserGroupRecord, Int32>, IUserGroupRepository
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
            get { return "UserGroup"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="UserGroupRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_GROUP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "User_Group"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="UserGroupRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="UserGroupRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, UserGroupRecord record)
        {
            record.Id = dataRecord["GROUP_ID"].ConvertTo<Int32>();
            record.PrincipalId = dataRecord["GROUP_PRINCIPAL_ID"].ConvertTo<Int32>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="UserGroupRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, UserGroupRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_GROUP_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_GROUP_PRINCIPAL_ID", record.PrincipalId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PrincipalId);
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
        ///     The <see cref="UserGroupRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, UserGroupRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_GROUP_ID", record.Id);
            record.PrincipalId = this.MapParameterOut(command, "@PA_GROUP_PRINCIPAL_ID", record.PrincipalId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="UserGroupRecord" /> instances from the data store.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref='UserGroupModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="UserGroupRecord" /> instances that match the specified <paramref name='principalId' />.
        /// </returns>
        public IEnumerable<UserGroupRecord> FetchAllByPrincipalId(Int32 principalId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PrincipalId");
            this.MapParameterIn(command, "@PA_GROUP_PRINCIPAL_ID", principalId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IUserGroupRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Security.UserGroupRecord" /> instances from the data store.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserGroupModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Security.UserGroupRecord" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.UserGroupRecord> IUserGroupRepository.FetchAllByPrincipalId(System.Int32 principalId)
        {
            return this.FetchAllByPrincipalId(principalId);
        }

        #endregion
    }
}
