using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SystemmenusxrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSystemMenuXRefRepository : SqlServerRepository<SystemmenusxrefRecord, Int32>, ISystemMenuXRefRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "UserInterface"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Systemmenusxref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SystemmenusxrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SMXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SystemMenusXRef"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SystemmenusxrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SystemmenusxrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SystemmenusxrefRecord record)
        {
            record.Id = dataRecord["SMXREF_ID"].ConvertTo<Int32>();
            record.SmenuId = dataRecord["SMXREF_SMENU_ID"].ConvertTo<Int32>();
            record.ModId = dataRecord["SMXREF_MOD_ID"].ConvertTo<Guid>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SystemmenusxrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SystemmenusxrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SMXREF_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_SMXREF_SMENU_ID", record.SmenuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SmenuId);
            this.MapParameterIn(command, "@PA_SMXREF_MOD_ID", record.ModId);
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
        ///     The <see cref="SystemmenusxrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SystemmenusxrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SMXREF_ID", record.Id);
            record.SmenuId = this.MapParameterOut(command, "@PA_SMXREF_SMENU_ID", record.SmenuId);
            record.ModId = this.MapParameterOut(command, "@PA_SMXREF_MOD_ID", record.ModId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SystemmenusxrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="smenuId">
        ///     The value which identifies the <see cref='SystemMenuXRefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SystemmenusxrefRecord" /> instances that match the specified <paramref name='smenuId' />.
        /// </returns>
        public IEnumerable<SystemmenusxrefRecord> FetchAllBySmenuId(Int32 smenuId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SmenuId");
            this.MapParameterIn(command, "@PA_SMXREF_SMENU_ID", smenuId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISystemMenuXRefRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.SystemmenusxrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="smenuId">
        ///     The value which identifies the <see cref="!:SystemMenuXRefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.SystemmenusxrefRecord" /> instances that match the specified <paramref name="smenuId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.SystemmenusxrefRecord> ISystemMenuXRefRepository.FetchAllBySmenuId(System.Int32 smenuId)
        {
            return this.FetchAllBySmenuId(smenuId);
        }

        #endregion
    }
}
