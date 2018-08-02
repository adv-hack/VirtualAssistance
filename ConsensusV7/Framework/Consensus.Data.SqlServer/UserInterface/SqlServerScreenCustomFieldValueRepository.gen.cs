using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenCustomFieldValueRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerScreenCustomFieldValueRepository : SqlServerRepository<ScreenCustomFieldValueRecord, Int32>, IScreenCustomFieldValueRepository
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
            get { return "ScreenCustomFieldValue"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ScreenCustomFieldValueRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CFVALUE_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Screen_Custom_Field_Value"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ScreenCustomFieldValueRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenCustomFieldValueRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ScreenCustomFieldValueRecord record)
        {
            record.Id = dataRecord["CFVALUE_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["CFVALUE_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["CFVALUE_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["CFVALUE_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["CFVALUE_MOD_BY"].ConvertTo<String>();
            record.CfieldId = dataRecord["CFVALUE_CFIELD_ID"].ConvertTo<Int32>();
            record.RecordId = dataRecord["CFVALUE_RECORD_ID"].ConvertTo<String>();
            record.Text = dataRecord["CFVALUE_TEXT"].ConvertTo<String>();
            record.Number = dataRecord["CFVALUE_NUMBER"].ConvertTo<Decimal?>();
            record.IdValue = dataRecord["CFVALUE_ID_VALUE"].ConvertTo<String>();
            record.Date = dataRecord["CFVALUE_DATE"].ConvertTo<DateTime?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenCustomFieldValueRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ScreenCustomFieldValueRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CFVALUE_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_CFVALUE_CFIELD_ID", record.CfieldId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.CfieldId);
            this.MapParameterIn(command, "@PA_CFVALUE_RECORD_ID", record.RecordId);
            this.MapParameterIn(command, "@PA_CFVALUE_TEXT", record.Text);
            this.MapParameterIn(command, "@PA_CFVALUE_NUMBER", record.Number == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Number);
            this.MapParameterIn(command, "@PA_CFVALUE_ID_VALUE", record.IdValue);
            this.MapParameterIn(command, "@PA_CFVALUE_DATE", record.Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date);
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
        ///     The <see cref="ScreenCustomFieldValueRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ScreenCustomFieldValueRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CFVALUE_ID", record.Id);
            record.CfieldId = this.MapParameterOut(command, "@PA_CFVALUE_CFIELD_ID", record.CfieldId);
            record.RecordId = this.MapParameterOut(command, "@PA_CFVALUE_RECORD_ID", record.RecordId);
            record.Text = this.MapParameterOut(command, "@PA_CFVALUE_TEXT", record.Text);
            record.Number = this.MapParameterOut(command, "@PA_CFVALUE_NUMBER", record.Number);
            record.IdValue = this.MapParameterOut(command, "@PA_CFVALUE_ID_VALUE", record.IdValue);
            record.Date = this.MapParameterOut(command, "@PA_CFVALUE_DATE", record.Date);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ScreenCustomFieldValueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref='ScreenCustomFieldValueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ScreenCustomFieldValueRecord" /> instances that match the specified <paramref name='cfieldId' />.
        /// </returns>
        public IEnumerable<ScreenCustomFieldValueRecord> FetchAllByCfieldId(Int32 cfieldId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CfieldId");
            this.MapParameterIn(command, "@PA_CFVALUE_CFIELD_ID", cfieldId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IScreenCustomFieldValueRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Gets the value for a custom field for a given record.
        /// </summary>
        /// <param name="fieldId">
        ///     The custom field ID (which is associated with a page).
        /// </param>
        /// <param name="recordId">
        ///     The ID value of the record displayed on the page, converted to a string if required.
        /// </param>
        Consensus.UserInterface.ScreenCustomFieldValueRecord IScreenCustomFieldValueRepository.FetchByFieldIdAndRecordId(System.Int32 fieldId, System.String recordId)
        {
            return this.FetchByFieldIdAndRecordId(fieldId, recordId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenCustomFieldValueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldValueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenCustomFieldValueRecord" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenCustomFieldValueRecord> IScreenCustomFieldValueRepository.FetchAllByCfieldId(System.Int32 cfieldId)
        {
            return this.FetchAllByCfieldId(cfieldId);
        }

        #endregion
    }
}
