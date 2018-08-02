using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SystemSearchesGridColumnsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSearchColumnRepository : SqlServerRepository<SystemSearchesGridColumnsRecord, Int32>, ISearchColumnRepository
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
            get { return "SystemSearchesGridColumns"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SystemSearchesGridColumnsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SYSSC_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "System_Searches_Grid_Columns"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SystemSearchesGridColumnsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SystemSearchesGridColumnsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SystemSearchesGridColumnsRecord record)
        {
            record.Id = dataRecord["SYSSC_ID"].ConvertTo<Int32>();
            record.AddBy = dataRecord["SYSSC_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["SYSSC_ADD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["SYSSC_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["SYSSC_MOD_DATE"].ConvertTo<DateTime?>();
            record.SyssId = dataRecord["SYSSC_SYSS_ID"].ConvertTo<Int32>();
            record.DisplayOrder = dataRecord["SYSSC_DISPLAY_ORDER"].ConvertTo<Int32>();
            record.FieldMapping = dataRecord["SYSSC_FIELD_MAPPING"].ConvertTo<String>();
            record.Name = dataRecord["SYSSC_NAME"].ConvertTo<String>();
            record.Label = dataRecord["SYSSC_LABEL"].ConvertTo<String>();
            record.TooltipText = dataRecord["SYSSC_TOOLTIP_TEXT"].ConvertTo<String>();
            record.Index = dataRecord["SYSSC_INDEX"].ConvertTo<String>();
            record.Width = dataRecord["SYSSC_WIDTH"].ConvertTo<Int32?>();
            record.Align = dataRecord["SYSSC_ALIGN"].ConvertTo<String>();
            record.Visible = dataRecord["SYSSC_VISIBLE"].ConvertTo<Boolean>();
            record.VisibleCondition = dataRecord["SYSSC_VISIBLE_CONDITION"].ConvertTo<String>();
            record.OutputType = dataRecord["SYSSC_OUTPUT_TYPE"].ConvertTo<Byte>();
            record.ShowInBasicResults = dataRecord["SYSSC_SHOW_IN_BASIC_RESULTS"].ConvertTo<Boolean>();
            record.Cellattr = dataRecord["SYSSC_CELLATTR"].ConvertTo<String>();
            record.SortType = dataRecord["SYSSC_SORT_TYPE"].ConvertTo<String>();
            record.Permissions = dataRecord["SYSSC_PERMISSIONS"].ConvertTo<String>();
            record.DisplayFormat = dataRecord["SYSSC_DISPLAY_FORMAT"].ConvertTo<String>();
            record.DisplayFormatTrue = dataRecord["SYSSC_DISPLAY_FORMAT_TRUE"].ConvertTo<String>();
            record.DisplayFormatFalse = dataRecord["SYSSC_DISPLAY_FORMAT_FALSE"].ConvertTo<String>();
            record.Key = dataRecord["SYSSC_KEY"].ConvertTo<Byte>();
            record.ColumnType = dataRecord["SYSSC_V7_COLUMN_TYPE"].ConvertTo<String>();
            record.ColumnHtml = dataRecord["SYSSC_V7_COLUMN_HTML"].ConvertTo<String>();
            record.ColumnLinkText = dataRecord["SYSSC_V7_COLUMN_LINK_TEXT"].ConvertTo<String>();
            record.ColumnLinkHref = dataRecord["SYSSC_V7_COLUMN_LINK_HREF"].ConvertTo<String>();
            record.ColumnIconTrueIcon = dataRecord["SYSSC_V7_COLUMN_ICON_TRUE_ICON"].ConvertTo<String>();
            record.ColumnIconTrueText = dataRecord["SYSSC_V7_COLUMN_ICON_TRUE_TEXT"].ConvertTo<String>();
            record.ColumnIconTrueCss = dataRecord["SYSSC_V7_COLUMN_ICON_TRUE_CSS"].ConvertTo<String>();
            record.ColumnIconFalseIcon = dataRecord["SYSSC_V7_COLUMN_ICON_FALSE_ICON"].ConvertTo<String>();
            record.ColumnIconFalseText = dataRecord["SYSSC_V7_COLUMN_ICON_FALSE_TEXT"].ConvertTo<String>();
            record.ColumnIconFalseCss = dataRecord["SYSSC_V7_COLUMN_ICON_FALSE_CSS"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SystemSearchesGridColumnsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SystemSearchesGridColumnsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SYSSC_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_SYSSC_SYSS_ID", record.SyssId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SyssId);
            this.MapParameterIn(command, "@PA_SYSSC_DISPLAY_ORDER", record.DisplayOrder == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DisplayOrder);
            this.MapParameterIn(command, "@PA_SYSSC_FIELD_MAPPING", record.FieldMapping);
            this.MapParameterIn(command, "@PA_SYSSC_NAME", record.Name);
            this.MapParameterIn(command, "@PA_SYSSC_LABEL", record.Label);
            this.MapParameterIn(command, "@PA_SYSSC_TOOLTIP_TEXT", record.TooltipText);
            this.MapParameterIn(command, "@PA_SYSSC_INDEX", record.Index);
            this.MapParameterIn(command, "@PA_SYSSC_WIDTH", record.Width == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Width);
            this.MapParameterIn(command, "@PA_SYSSC_ALIGN", record.Align);
            this.MapParameterIn(command, "@PA_SYSSC_VISIBLE", record.Visible);
            this.MapParameterIn(command, "@PA_SYSSC_VISIBLE_CONDITION", record.VisibleCondition);
            this.MapParameterIn(command, "@PA_SYSSC_OUTPUT_TYPE", record.OutputType);
            this.MapParameterIn(command, "@PA_SYSSC_SHOW_IN_BASIC_RESULTS", record.ShowInBasicResults);
            this.MapParameterIn(command, "@PA_SYSSC_CELLATTR", record.Cellattr);
            this.MapParameterIn(command, "@PA_SYSSC_SORT_TYPE", record.SortType);
            this.MapParameterIn(command, "@PA_SYSSC_PERMISSIONS", record.Permissions);
            this.MapParameterIn(command, "@PA_SYSSC_DISPLAY_FORMAT", record.DisplayFormat);
            this.MapParameterIn(command, "@PA_SYSSC_DISPLAY_FORMAT_TRUE", record.DisplayFormatTrue);
            this.MapParameterIn(command, "@PA_SYSSC_DISPLAY_FORMAT_FALSE", record.DisplayFormatFalse);
            this.MapParameterIn(command, "@PA_SYSSC_KEY", record.Key);
            this.MapParameterIn(command, "@PA_SYSSC_V7_COLUMN_TYPE", record.ColumnType);
            this.MapParameterIn(command, "@PA_SYSSC_V7_COLUMN_HTML", record.ColumnHtml);
            this.MapParameterIn(command, "@PA_SYSSC_V7_COLUMN_LINK_TEXT", record.ColumnLinkText);
            this.MapParameterIn(command, "@PA_SYSSC_V7_COLUMN_LINK_HREF", record.ColumnLinkHref);
            this.MapParameterIn(command, "@PA_SYSSC_V7_COLUMN_ICON_TRUE_ICON", record.ColumnIconTrueIcon);
            this.MapParameterIn(command, "@PA_SYSSC_V7_COLUMN_ICON_TRUE_TEXT", record.ColumnIconTrueText);
            this.MapParameterIn(command, "@PA_SYSSC_V7_COLUMN_ICON_TRUE_CSS", record.ColumnIconTrueCss);
            this.MapParameterIn(command, "@PA_SYSSC_V7_COLUMN_ICON_FALSE_ICON", record.ColumnIconFalseIcon);
            this.MapParameterIn(command, "@PA_SYSSC_V7_COLUMN_ICON_FALSE_TEXT", record.ColumnIconFalseText);
            this.MapParameterIn(command, "@PA_SYSSC_V7_COLUMN_ICON_FALSE_CSS", record.ColumnIconFalseCss);
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
        ///     The <see cref="SystemSearchesGridColumnsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SystemSearchesGridColumnsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SYSSC_ID", record.Id);
            record.SyssId = this.MapParameterOut(command, "@PA_SYSSC_SYSS_ID", record.SyssId);
            record.DisplayOrder = this.MapParameterOut(command, "@PA_SYSSC_DISPLAY_ORDER", record.DisplayOrder);
            record.FieldMapping = this.MapParameterOut(command, "@PA_SYSSC_FIELD_MAPPING", record.FieldMapping);
            record.Name = this.MapParameterOut(command, "@PA_SYSSC_NAME", record.Name);
            record.Label = this.MapParameterOut(command, "@PA_SYSSC_LABEL", record.Label);
            record.TooltipText = this.MapParameterOut(command, "@PA_SYSSC_TOOLTIP_TEXT", record.TooltipText);
            record.Index = this.MapParameterOut(command, "@PA_SYSSC_INDEX", record.Index);
            record.Width = this.MapParameterOut(command, "@PA_SYSSC_WIDTH", record.Width);
            record.Align = this.MapParameterOut(command, "@PA_SYSSC_ALIGN", record.Align);
            record.Visible = this.MapParameterOut(command, "@PA_SYSSC_VISIBLE", record.Visible);
            record.VisibleCondition = this.MapParameterOut(command, "@PA_SYSSC_VISIBLE_CONDITION", record.VisibleCondition);
            record.OutputType = this.MapParameterOut(command, "@PA_SYSSC_OUTPUT_TYPE", record.OutputType);
            record.ShowInBasicResults = this.MapParameterOut(command, "@PA_SYSSC_SHOW_IN_BASIC_RESULTS", record.ShowInBasicResults);
            record.Cellattr = this.MapParameterOut(command, "@PA_SYSSC_CELLATTR", record.Cellattr);
            record.SortType = this.MapParameterOut(command, "@PA_SYSSC_SORT_TYPE", record.SortType);
            record.Permissions = this.MapParameterOut(command, "@PA_SYSSC_PERMISSIONS", record.Permissions);
            record.DisplayFormat = this.MapParameterOut(command, "@PA_SYSSC_DISPLAY_FORMAT", record.DisplayFormat);
            record.DisplayFormatTrue = this.MapParameterOut(command, "@PA_SYSSC_DISPLAY_FORMAT_TRUE", record.DisplayFormatTrue);
            record.DisplayFormatFalse = this.MapParameterOut(command, "@PA_SYSSC_DISPLAY_FORMAT_FALSE", record.DisplayFormatFalse);
            record.Key = this.MapParameterOut(command, "@PA_SYSSC_KEY", record.Key);
            record.ColumnType = this.MapParameterOut(command, "@PA_SYSSC_V7_COLUMN_TYPE", record.ColumnType);
            record.ColumnHtml = this.MapParameterOut(command, "@PA_SYSSC_V7_COLUMN_HTML", record.ColumnHtml);
            record.ColumnLinkText = this.MapParameterOut(command, "@PA_SYSSC_V7_COLUMN_LINK_TEXT", record.ColumnLinkText);
            record.ColumnLinkHref = this.MapParameterOut(command, "@PA_SYSSC_V7_COLUMN_LINK_HREF", record.ColumnLinkHref);
            record.ColumnIconTrueIcon = this.MapParameterOut(command, "@PA_SYSSC_V7_COLUMN_ICON_TRUE_ICON", record.ColumnIconTrueIcon);
            record.ColumnIconTrueText = this.MapParameterOut(command, "@PA_SYSSC_V7_COLUMN_ICON_TRUE_TEXT", record.ColumnIconTrueText);
            record.ColumnIconTrueCss = this.MapParameterOut(command, "@PA_SYSSC_V7_COLUMN_ICON_TRUE_CSS", record.ColumnIconTrueCss);
            record.ColumnIconFalseIcon = this.MapParameterOut(command, "@PA_SYSSC_V7_COLUMN_ICON_FALSE_ICON", record.ColumnIconFalseIcon);
            record.ColumnIconFalseText = this.MapParameterOut(command, "@PA_SYSSC_V7_COLUMN_ICON_FALSE_TEXT", record.ColumnIconFalseText);
            record.ColumnIconFalseCss = this.MapParameterOut(command, "@PA_SYSSC_V7_COLUMN_ICON_FALSE_CSS", record.ColumnIconFalseCss);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SystemSearchesGridColumnsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syssId">
        ///     The value which identifies the <see cref='SearchColumnModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SystemSearchesGridColumnsRecord" /> instances that match the specified <paramref name='syssId' />.
        /// </returns>
        public IEnumerable<SystemSearchesGridColumnsRecord> FetchAllBySyssId(Int32 syssId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SyssId");
            this.MapParameterIn(command, "@PA_SYSSC_SYSS_ID", syssId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISearchColumnRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Search.SystemSearchesGridColumnsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syssId">
        ///     The value which identifies the <see cref="!:SearchColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Search.SystemSearchesGridColumnsRecord" /> instances that match the specified <paramref name="syssId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.SystemSearchesGridColumnsRecord> ISearchColumnRepository.FetchAllBySyssId(System.Int32 syssId)
        {
            return this.FetchAllBySyssId(syssId);
        }

        #endregion
    }
}
