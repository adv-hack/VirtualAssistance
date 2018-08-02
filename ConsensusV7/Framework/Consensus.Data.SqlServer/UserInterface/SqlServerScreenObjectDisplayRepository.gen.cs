using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenObjectDisplayRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerScreenObjectDisplayRepository : SqlServerRepository<ScreenObjectDisplayRecord, Int32>, IScreenObjectDisplayRepository
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
            get { return "ScreenObjectDisplay"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ScreenObjectDisplayRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_OBJDIS_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Screen_Object_Display"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ScreenObjectDisplayRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenObjectDisplayRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ScreenObjectDisplayRecord record)
        {
            record.Id = dataRecord["OBJDIS_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["OBJDIS_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["OBJDIS_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["OBJDIS_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["OBJDIS_MOD_BY"].ConvertTo<String>();
            record.ObjId = dataRecord["OBJDIS_OBJ_ID"].ConvertTo<Int32>();
            record.PrincipalId = dataRecord["OBJDIS_PRINCIPAL_ID"].ConvertTo<Int32>();
            record.Display = dataRecord["OBJDIS_DISPLAY"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenObjectDisplayRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ScreenObjectDisplayRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_OBJDIS_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_OBJDIS_OBJ_ID", record.ObjId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ObjId);
            this.MapParameterIn(command, "@PA_OBJDIS_PRINCIPAL_ID", record.PrincipalId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PrincipalId);
            this.MapParameterIn(command, "@PA_OBJDIS_DISPLAY", record.Display);
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
        ///     The <see cref="ScreenObjectDisplayRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ScreenObjectDisplayRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_OBJDIS_ID", record.Id);
            record.ObjId = this.MapParameterOut(command, "@PA_OBJDIS_OBJ_ID", record.ObjId);
            record.PrincipalId = this.MapParameterOut(command, "@PA_OBJDIS_PRINCIPAL_ID", record.PrincipalId);
            record.Display = this.MapParameterOut(command, "@PA_OBJDIS_DISPLAY", record.Display);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ScreenObjectDisplayRecord" /> instances from the data store.
        /// </summary>
        /// <param name="objId">
        ///     The value which identifies the <see cref='ScreenObjectDisplayModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ScreenObjectDisplayRecord" /> instances that match the specified <paramref name='objId' />.
        /// </returns>
        public IEnumerable<ScreenObjectDisplayRecord> FetchAllByObjId(Int32 objId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ObjId");
            this.MapParameterIn(command, "@PA_OBJDIS_OBJ_ID", objId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ScreenObjectDisplayRecord" /> instances from the data store.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref='ScreenObjectDisplayModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ScreenObjectDisplayRecord" /> instances that match the specified <paramref name='principalId' />.
        /// </returns>
        public IEnumerable<ScreenObjectDisplayRecord> FetchAllByPrincipalId(Int32 principalId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PrincipalId");
            this.MapParameterIn(command, "@PA_OBJDIS_PRINCIPAL_ID", principalId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IScreenObjectDisplayRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenObjectDisplayRecord" /> instances from the data store.
        /// </summary>
        /// <param name="objId">
        ///     The value which identifies the <see cref="!:ScreenObjectDisplayModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenObjectDisplayRecord" /> instances that match the specified <paramref name="objId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenObjectDisplayRecord> IScreenObjectDisplayRepository.FetchAllByObjId(System.Int32 objId)
        {
            return this.FetchAllByObjId(objId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenObjectDisplayRecord" /> instances from the data store.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:ScreenObjectDisplayModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenObjectDisplayRecord" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenObjectDisplayRecord> IScreenObjectDisplayRepository.FetchAllByPrincipalId(System.Int32 principalId)
        {
            return this.FetchAllByPrincipalId(principalId);
        }

        #endregion
    }
}
