using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenObjectEntryRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerScreenObjectEntryRepository : SqlServerRepository<ScreenObjectEntryRecord, Int32>, IScreenObjectEntryRepository
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
            get { return "ScreenObjectEntry"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ScreenObjectEntryRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_OBJENT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Screen_Object_Entry"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ScreenObjectEntryRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenObjectEntryRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ScreenObjectEntryRecord record)
        {
            record.Id = dataRecord["OBJENT_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["OBJENT_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["OBJENT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["OBJENT_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["OBJENT_MOD_BY"].ConvertTo<String>();
            record.ObjId = dataRecord["OBJENT_OBJ_ID"].ConvertTo<Int32>();
            record.ItemNormal = dataRecord["OBJENT_ITEM_NORMAL"].ConvertTo<String>();
            record.ItemCustom = dataRecord["OBJENT_ITEM_CUSTOM"].ConvertTo<String>();
            record.ItemHide = dataRecord["OBJENT_ITEM_HIDE"].ConvertTo<Boolean>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenObjectEntryRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ScreenObjectEntryRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_OBJENT_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_OBJENT_OBJ_ID", record.ObjId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ObjId);
            this.MapParameterIn(command, "@PA_OBJENT_ITEM_NORMAL", record.ItemNormal);
            this.MapParameterIn(command, "@PA_OBJENT_ITEM_CUSTOM", record.ItemCustom);
            this.MapParameterIn(command, "@PA_OBJENT_ITEM_HIDE", record.ItemHide);
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
        ///     The <see cref="ScreenObjectEntryRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ScreenObjectEntryRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_OBJENT_ID", record.Id);
            record.ObjId = this.MapParameterOut(command, "@PA_OBJENT_OBJ_ID", record.ObjId);
            record.ItemNormal = this.MapParameterOut(command, "@PA_OBJENT_ITEM_NORMAL", record.ItemNormal);
            record.ItemCustom = this.MapParameterOut(command, "@PA_OBJENT_ITEM_CUSTOM", record.ItemCustom);
            record.ItemHide = this.MapParameterOut(command, "@PA_OBJENT_ITEM_HIDE", record.ItemHide);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ScreenObjectEntryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="objId">
        ///     The value which identifies the <see cref='ScreenObjectEntryModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ScreenObjectEntryRecord" /> instances that match the specified <paramref name='objId' />.
        /// </returns>
        public IEnumerable<ScreenObjectEntryRecord> FetchAllByObjId(Int32 objId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ObjId");
            this.MapParameterIn(command, "@PA_OBJENT_OBJ_ID", objId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IScreenObjectEntryRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenObjectEntryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="objId">
        ///     The value which identifies the <see cref="!:ScreenObjectEntryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenObjectEntryRecord" /> instances that match the specified <paramref name="objId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenObjectEntryRecord> IScreenObjectEntryRepository.FetchAllByObjId(System.Int32 objId)
        {
            return this.FetchAllByObjId(objId);
        }

        #endregion
    }
}
