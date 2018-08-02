using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenCustomFieldListitemRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerScreenCustomFieldListitemRepository : SqlServerRepository<ScreenCustomFieldListitemRecord, Int32>, IScreenCustomFieldListitemRepository
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
            get { return "ScreenCustomFieldListitem"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ScreenCustomFieldListitemRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CFLITEM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Screen_Custom_Field_ListItem"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ScreenCustomFieldListitemRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenCustomFieldListitemRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ScreenCustomFieldListitemRecord record)
        {
            record.Id = dataRecord["CFLITEM_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["CFLITEM_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["CFLITEM_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["CFLITEM_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["CFLITEM_MOD_BY"].ConvertTo<String>();
            record.CfieldId = dataRecord["CFLITEM_CFIELD_ID"].ConvertTo<Int32>();
            record.IdValue = dataRecord["CFLITEM_ID_VALUE"].ConvertTo<String>();
            record.Text = dataRecord["CFLITEM_TEXT"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenCustomFieldListitemRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ScreenCustomFieldListitemRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CFLITEM_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_CFLITEM_CFIELD_ID", record.CfieldId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.CfieldId);
            this.MapParameterIn(command, "@PA_CFLITEM_ID_VALUE", record.IdValue);
            this.MapParameterIn(command, "@PA_CFLITEM_TEXT", record.Text);
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
        ///     The <see cref="ScreenCustomFieldListitemRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ScreenCustomFieldListitemRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CFLITEM_ID", record.Id);
            record.CfieldId = this.MapParameterOut(command, "@PA_CFLITEM_CFIELD_ID", record.CfieldId);
            record.IdValue = this.MapParameterOut(command, "@PA_CFLITEM_ID_VALUE", record.IdValue);
            record.Text = this.MapParameterOut(command, "@PA_CFLITEM_TEXT", record.Text);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ScreenCustomFieldListitemRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref='ScreenCustomFieldListitemModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ScreenCustomFieldListitemRecord" /> instances that match the specified <paramref name='cfieldId' />.
        /// </returns>
        public IEnumerable<ScreenCustomFieldListitemRecord> FetchAllByCfieldId(Int32 cfieldId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CfieldId");
            this.MapParameterIn(command, "@PA_CFLITEM_CFIELD_ID", cfieldId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IScreenCustomFieldListitemRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenCustomFieldListitemRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldListitemModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenCustomFieldListitemRecord" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenCustomFieldListitemRecord> IScreenCustomFieldListitemRepository.FetchAllByCfieldId(System.Int32 cfieldId)
        {
            return this.FetchAllByCfieldId(cfieldId);
        }

        #endregion
    }
}
