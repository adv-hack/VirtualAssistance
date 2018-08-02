using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SystemSearchesParameterFieldsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSearchParameterRepository : SqlServerRepository<SystemSearchesParameterFieldsRecord, Int32>, ISearchParameterRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Search"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "SystemSearchesParameterFields"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SystemSearchesParameterFieldsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SYSSP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "System_Searches_Parameter_Fields"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SystemSearchesParameterFieldsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SystemSearchesParameterFieldsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SystemSearchesParameterFieldsRecord record)
        {
            record.Id = dataRecord["SYSSP_ID"].ConvertTo<Int32>();
            record.AddBy = dataRecord["SYSSP_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["SYSSP_ADD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["SYSSP_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["SYSSP_MOD_DATE"].ConvertTo<DateTime?>();
            record.SyssId = dataRecord["SYSSP_SYSS_ID"].ConvertTo<Int32>();
            record.DisplayOptionType = dataRecord["SYSSP_DISPLAY_OPTION_TYPE"].ConvertTo<Byte>();
            record.DisplayOrder = dataRecord["SYSSP_DISPLAY_ORDER"].ConvertTo<Int32>();
            record.FieldName = dataRecord["SYSSP_FIELD_NAME"].ConvertTo<String>();
            record.DefaultLabel = dataRecord["SYSSP_DEFAULT_LABEL"].ConvertTo<String>();
            record.Label = dataRecord["SYSSP_LABEL"].ConvertTo<String>();
            record.FieldType = dataRecord["SYSSP_FIELD_TYPE"].ConvertTo<String>();
            record.WhereClauseOperator = dataRecord["SYSSP_WHERE_CLAUSE_OPERATOR"].ConvertTo<String>();
            record.Visible = dataRecord["SYSSP_VISIBLE"].ConvertTo<Byte>();
            record.VisibleCondition = dataRecord["SYSSP_VISIBLE_CONDITION"].ConvertTo<String>();
            record.DefaultValue = dataRecord["SYSSP_DEFAULT_VALUE"].ConvertTo<String>();
            record.CodeList = dataRecord["SYSSP_CODE_LIST"].ConvertTo<String>();
            record.Data = dataRecord["SYSSP_DATA"].ConvertTo<String>();
            record.WhereClauseOverride = dataRecord["SYSSP_WHERE_CLAUSE_OVERRIDE"].ConvertTo<String>();
            record.Permissions = dataRecord["SYSSP_PERMISSIONS"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SystemSearchesParameterFieldsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SystemSearchesParameterFieldsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SYSSP_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_SYSSP_SYSS_ID", record.SyssId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SyssId);
            this.MapParameterIn(command, "@PA_SYSSP_DISPLAY_OPTION_TYPE", record.DisplayOptionType);
            this.MapParameterIn(command, "@PA_SYSSP_DISPLAY_ORDER", record.DisplayOrder == Int32.MinValue ? 0 : record.DisplayOrder);
            this.MapParameterIn(command, "@PA_SYSSP_FIELD_NAME", record.FieldName);
            this.MapParameterIn(command, "@PA_SYSSP_DEFAULT_LABEL", record.DefaultLabel);
            this.MapParameterIn(command, "@PA_SYSSP_LABEL", record.Label);
            this.MapParameterIn(command, "@PA_SYSSP_FIELD_TYPE", record.FieldType);
            this.MapParameterIn(command, "@PA_SYSSP_WHERE_CLAUSE_OPERATOR", record.WhereClauseOperator);
            this.MapParameterIn(command, "@PA_SYSSP_VISIBLE", record.Visible);
            this.MapParameterIn(command, "@PA_SYSSP_VISIBLE_CONDITION", record.VisibleCondition);
            this.MapParameterIn(command, "@PA_SYSSP_DEFAULT_VALUE", record.DefaultValue);
            this.MapParameterIn(command, "@PA_SYSSP_CODE_LIST", record.CodeList);
            this.MapParameterIn(command, "@PA_SYSSP_DATA", record.Data);
            this.MapParameterIn(command, "@PA_SYSSP_WHERE_CLAUSE_OVERRIDE", record.WhereClauseOverride);
            this.MapParameterIn(command, "@PA_SYSSP_PERMISSIONS", record.Permissions);
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
        ///     The <see cref="SystemSearchesParameterFieldsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SystemSearchesParameterFieldsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SYSSP_ID", record.Id);
            record.SyssId = this.MapParameterOut(command, "@PA_SYSSP_SYSS_ID", record.SyssId);
            record.DisplayOptionType = this.MapParameterOut(command, "@PA_SYSSP_DISPLAY_OPTION_TYPE", record.DisplayOptionType);
            record.DisplayOrder = this.MapParameterOut(command, "@PA_SYSSP_DISPLAY_ORDER", record.DisplayOrder);
            record.FieldName = this.MapParameterOut(command, "@PA_SYSSP_FIELD_NAME", record.FieldName);
            record.DefaultLabel = this.MapParameterOut(command, "@PA_SYSSP_DEFAULT_LABEL", record.DefaultLabel);
            record.Label = this.MapParameterOut(command, "@PA_SYSSP_LABEL", record.Label);
            record.FieldType = this.MapParameterOut(command, "@PA_SYSSP_FIELD_TYPE", record.FieldType);
            record.WhereClauseOperator = this.MapParameterOut(command, "@PA_SYSSP_WHERE_CLAUSE_OPERATOR", record.WhereClauseOperator);
            record.Visible = this.MapParameterOut(command, "@PA_SYSSP_VISIBLE", record.Visible);
            record.VisibleCondition = this.MapParameterOut(command, "@PA_SYSSP_VISIBLE_CONDITION", record.VisibleCondition);
            record.DefaultValue = this.MapParameterOut(command, "@PA_SYSSP_DEFAULT_VALUE", record.DefaultValue);
            record.CodeList = this.MapParameterOut(command, "@PA_SYSSP_CODE_LIST", record.CodeList);
            record.Data = this.MapParameterOut(command, "@PA_SYSSP_DATA", record.Data);
            record.WhereClauseOverride = this.MapParameterOut(command, "@PA_SYSSP_WHERE_CLAUSE_OVERRIDE", record.WhereClauseOverride);
            record.Permissions = this.MapParameterOut(command, "@PA_SYSSP_PERMISSIONS", record.Permissions);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SystemSearchesParameterFieldsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syssId">
        ///     The value which identifies the <see cref='SearchParameterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SystemSearchesParameterFieldsRecord" /> instances that match the specified <paramref name='syssId' />.
        /// </returns>
        public IEnumerable<SystemSearchesParameterFieldsRecord> FetchAllBySyssId(Int32 syssId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SyssId");
            this.MapParameterIn(command, "@PA_SYSSP_SYSS_ID", syssId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISearchParameterRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Search.SystemSearchesParameterFieldsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syssId">
        ///     The value which identifies the <see cref="!:SearchParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Search.SystemSearchesParameterFieldsRecord" /> instances that match the specified <paramref name="syssId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.SystemSearchesParameterFieldsRecord> ISearchParameterRepository.FetchAllBySyssId(System.Int32 syssId)
        {
            return this.FetchAllBySyssId(syssId);
        }

        #endregion
    }
}
