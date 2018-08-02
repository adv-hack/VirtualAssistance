using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenObjectColumnRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerScreenObjectColumnRepository : SqlServerRepository<ScreenObjectColumnRecord, Int32>, IScreenObjectColumnRepository
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
            get { return "ScreenObjectColumn"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ScreenObjectColumnRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_OBJCOL_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Screen_Object_Column"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ScreenObjectColumnRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenObjectColumnRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ScreenObjectColumnRecord record)
        {
            record.Id = dataRecord["OBJCOL_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["OBJCOL_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["OBJCOL_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["OBJCOL_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["OBJCOL_MOD_BY"].ConvertTo<String>();
            record.ObjId = dataRecord["OBJCOL_OBJ_ID"].ConvertTo<Int32>();
            record.Ordinal = dataRecord["OBJCOL_ORDINAL"].ConvertTo<Int32>();
            record.Custom = dataRecord["OBJCOL_CUSTOM"].ConvertTo<String>();
            record.Exportable = dataRecord["OBJCOL_EXPORTABLE"].ConvertTo<Boolean>();
            record.Visible = dataRecord["OBJCOL_VISIBLE"].ConvertTo<Boolean>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenObjectColumnRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ScreenObjectColumnRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_OBJCOL_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_OBJCOL_OBJ_ID", record.ObjId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ObjId);
            this.MapParameterIn(command, "@PA_OBJCOL_ORDINAL", record.Ordinal == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Ordinal);
            this.MapParameterIn(command, "@PA_OBJCOL_CUSTOM", record.Custom);
            this.MapParameterIn(command, "@PA_OBJCOL_EXPORTABLE", record.Exportable);
            this.MapParameterIn(command, "@PA_OBJCOL_VISIBLE", record.Visible);
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
        ///     The <see cref="ScreenObjectColumnRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ScreenObjectColumnRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_OBJCOL_ID", record.Id);
            record.ObjId = this.MapParameterOut(command, "@PA_OBJCOL_OBJ_ID", record.ObjId);
            record.Ordinal = this.MapParameterOut(command, "@PA_OBJCOL_ORDINAL", record.Ordinal);
            record.Custom = this.MapParameterOut(command, "@PA_OBJCOL_CUSTOM", record.Custom);
            record.Exportable = this.MapParameterOut(command, "@PA_OBJCOL_EXPORTABLE", record.Exportable);
            record.Visible = this.MapParameterOut(command, "@PA_OBJCOL_VISIBLE", record.Visible);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ScreenObjectColumnRecord" /> instances from the data store.
        /// </summary>
        /// <param name="objId">
        ///     The value which identifies the <see cref='ScreenObjectColumnModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ScreenObjectColumnRecord" /> instances that match the specified <paramref name='objId' />.
        /// </returns>
        public IEnumerable<ScreenObjectColumnRecord> FetchAllByObjId(Int32 objId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ObjId");
            this.MapParameterIn(command, "@PA_OBJCOL_OBJ_ID", objId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IScreenObjectColumnRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenObjectColumnRecord" /> instances from the data store.
        /// </summary>
        /// <param name="objId">
        ///     The value which identifies the <see cref="!:ScreenObjectColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenObjectColumnRecord" /> instances that match the specified <paramref name="objId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenObjectColumnRecord> IScreenObjectColumnRepository.FetchAllByObjId(System.Int32 objId)
        {
            return this.FetchAllByObjId(objId);
        }

        #endregion
    }
}
