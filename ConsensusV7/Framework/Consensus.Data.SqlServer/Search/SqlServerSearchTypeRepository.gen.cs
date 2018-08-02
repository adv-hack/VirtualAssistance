using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SystemSearchesRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSearchTypeRepository : SqlServerRepository<SystemSearchesRecord, Int32>, ISearchTypeRepository
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
            get { return "SystemSearches"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SystemSearchesRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SYSS_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "System_Searches"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SystemSearchesRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SystemSearchesRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SystemSearchesRecord record)
        {
            record.Id = dataRecord["SYSS_ID"].ConvertTo<Int32>();
            record.AddBy = dataRecord["SYSS_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["SYSS_ADD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["SYSS_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["SYSS_MOD_DATE"].ConvertTo<DateTime?>();
            record.Type = dataRecord["SYSS_TYPE"].ConvertTo<String>();
            record.SysType = dataRecord["SYSS_SYS_TYPE"].ConvertTo<Byte>();
            record.PageTitle = dataRecord["SYSS_PAGE_TITLE"].ConvertTo<String>();
            record.SearchDisplayName = dataRecord["SYSS_SEARCH_DISPLAY_NAME"].ConvertTo<String>();
            record.DisplayOrder = dataRecord["SYSS_DISPLAY_ORDER"].ConvertTo<Int32>();
            record.DbViewName = dataRecord["SYSS_DB_VIEW_NAME"].ConvertTo<String>();
            record.DbViewFields = dataRecord["SYSS_DB_VIEW_FIELDS"].ConvertTo<String>();
            record.OrderBy = dataRecord["SYSS_ORDER_BY"].ConvertTo<String>();
            record.DoubleClickActionColumn = dataRecord["SYSS_DOUBLE_CLICK_ACTION_COLUMN"].ConvertTo<Int32?>();
            record.DefaultSortColumn = dataRecord["SYSS_DEFAULT_SORT_COLUMN"].ConvertTo<String>();
            record.BannerText = dataRecord["SYSS_BANNER_TEXT"].ConvertTo<String>();
            record.ShowDropdown = dataRecord["SYSS_SHOW_DROPDOWN"].ConvertTo<Boolean>();
            record.Autosearch = dataRecord["SYSS_AUTOSEARCH"].ConvertTo<Boolean>();
            record.HideParameterSection = dataRecord["SYSS_HIDE_PARAMETER_SECTION"].ConvertTo<Boolean>();
            record.DefaultMaxResults = dataRecord["SYSS_DEFAULT_MAX_RESULTS"].ConvertTo<Int32>();
            record.CustomClientScript = dataRecord["SYSS_CUSTOM_CLIENT_SCRIPT"].ConvertTo<String>();
            record.Permissions = dataRecord["SYSS_PERMISSIONS"].ConvertTo<String>();
            record.ShowExportOption = dataRecord["SYSS_SHOW_EXPORT_OPTION"].ConvertTo<Boolean>();
            record.Multiselect = dataRecord["SYSS_MULTISELECT"].ConvertTo<Byte>();
            record.SearchCustom = dataRecord["SYSS_SEARCH_CUSTOM"].ConvertTo<String>();
            record.DbStoredProc = dataRecord["SYSS_DB_STORED_PROC"].ConvertTo<String>();
            record.UseStoredProc = dataRecord["SYSS_USE_STORED_PROC"].ConvertTo<Boolean?>();
            record.NewButton = dataRecord["SYSS_NEW_BUTTON"].ConvertTo<String>();
            record.SaveJson = dataRecord["SYSS_SAVE_JSON"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SystemSearchesRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SystemSearchesRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SYSS_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_SYSS_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_SYSS_SYS_TYPE", record.SysType);
            this.MapParameterIn(command, "@PA_SYSS_PAGE_TITLE", record.PageTitle);
            this.MapParameterIn(command, "@PA_SYSS_SEARCH_DISPLAY_NAME", record.SearchDisplayName);
            this.MapParameterIn(command, "@PA_SYSS_DISPLAY_ORDER", record.DisplayOrder == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DisplayOrder);
            this.MapParameterIn(command, "@PA_SYSS_DB_VIEW_NAME", record.DbViewName);
            this.MapParameterIn(command, "@PA_SYSS_DB_VIEW_FIELDS", record.DbViewFields);
            this.MapParameterIn(command, "@PA_SYSS_ORDER_BY", record.OrderBy);
            this.MapParameterIn(command, "@PA_SYSS_DOUBLE_CLICK_ACTION_COLUMN", record.DoubleClickActionColumn == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DoubleClickActionColumn);
            this.MapParameterIn(command, "@PA_SYSS_DEFAULT_SORT_COLUMN", record.DefaultSortColumn);
            this.MapParameterIn(command, "@PA_SYSS_BANNER_TEXT", record.BannerText);
            this.MapParameterIn(command, "@PA_SYSS_SHOW_DROPDOWN", record.ShowDropdown);
            this.MapParameterIn(command, "@PA_SYSS_AUTOSEARCH", record.Autosearch);
            this.MapParameterIn(command, "@PA_SYSS_HIDE_PARAMETER_SECTION", record.HideParameterSection);
            this.MapParameterIn(command, "@PA_SYSS_DEFAULT_MAX_RESULTS", record.DefaultMaxResults == Int32.MinValue ? 50 : record.DefaultMaxResults);
            this.MapParameterIn(command, "@PA_SYSS_CUSTOM_CLIENT_SCRIPT", record.CustomClientScript);
            this.MapParameterIn(command, "@PA_SYSS_PERMISSIONS", record.Permissions);
            this.MapParameterIn(command, "@PA_SYSS_SHOW_EXPORT_OPTION", record.ShowExportOption);
            this.MapParameterIn(command, "@PA_SYSS_MULTISELECT", record.Multiselect);
            this.MapParameterIn(command, "@PA_SYSS_SEARCH_CUSTOM", record.SearchCustom);
            this.MapParameterIn(command, "@PA_SYSS_DB_STORED_PROC", record.DbStoredProc);
            this.MapParameterIn(command, "@PA_SYSS_USE_STORED_PROC", record.UseStoredProc);
            this.MapParameterIn(command, "@PA_SYSS_NEW_BUTTON", record.NewButton);
            this.MapParameterIn(command, "@PA_SYSS_SAVE_JSON", record.SaveJson);
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
        ///     The <see cref="SystemSearchesRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SystemSearchesRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SYSS_ID", record.Id);
            record.Type = this.MapParameterOut(command, "@PA_SYSS_TYPE", record.Type);
            record.SysType = this.MapParameterOut(command, "@PA_SYSS_SYS_TYPE", record.SysType);
            record.PageTitle = this.MapParameterOut(command, "@PA_SYSS_PAGE_TITLE", record.PageTitle);
            record.SearchDisplayName = this.MapParameterOut(command, "@PA_SYSS_SEARCH_DISPLAY_NAME", record.SearchDisplayName);
            record.DisplayOrder = this.MapParameterOut(command, "@PA_SYSS_DISPLAY_ORDER", record.DisplayOrder);
            record.DbViewName = this.MapParameterOut(command, "@PA_SYSS_DB_VIEW_NAME", record.DbViewName);
            record.DbViewFields = this.MapParameterOut(command, "@PA_SYSS_DB_VIEW_FIELDS", record.DbViewFields);
            record.OrderBy = this.MapParameterOut(command, "@PA_SYSS_ORDER_BY", record.OrderBy);
            record.DoubleClickActionColumn = this.MapParameterOut(command, "@PA_SYSS_DOUBLE_CLICK_ACTION_COLUMN", record.DoubleClickActionColumn);
            record.DefaultSortColumn = this.MapParameterOut(command, "@PA_SYSS_DEFAULT_SORT_COLUMN", record.DefaultSortColumn);
            record.BannerText = this.MapParameterOut(command, "@PA_SYSS_BANNER_TEXT", record.BannerText);
            record.ShowDropdown = this.MapParameterOut(command, "@PA_SYSS_SHOW_DROPDOWN", record.ShowDropdown);
            record.Autosearch = this.MapParameterOut(command, "@PA_SYSS_AUTOSEARCH", record.Autosearch);
            record.HideParameterSection = this.MapParameterOut(command, "@PA_SYSS_HIDE_PARAMETER_SECTION", record.HideParameterSection);
            record.DefaultMaxResults = this.MapParameterOut(command, "@PA_SYSS_DEFAULT_MAX_RESULTS", record.DefaultMaxResults);
            record.CustomClientScript = this.MapParameterOut(command, "@PA_SYSS_CUSTOM_CLIENT_SCRIPT", record.CustomClientScript);
            record.Permissions = this.MapParameterOut(command, "@PA_SYSS_PERMISSIONS", record.Permissions);
            record.ShowExportOption = this.MapParameterOut(command, "@PA_SYSS_SHOW_EXPORT_OPTION", record.ShowExportOption);
            record.Multiselect = this.MapParameterOut(command, "@PA_SYSS_MULTISELECT", record.Multiselect);
            record.SearchCustom = this.MapParameterOut(command, "@PA_SYSS_SEARCH_CUSTOM", record.SearchCustom);
            record.DbStoredProc = this.MapParameterOut(command, "@PA_SYSS_DB_STORED_PROC", record.DbStoredProc);
            record.UseStoredProc = this.MapParameterOut(command, "@PA_SYSS_USE_STORED_PROC", record.UseStoredProc);
            record.NewButton = this.MapParameterOut(command, "@PA_SYSS_NEW_BUTTON", record.NewButton);
            record.SaveJson = this.MapParameterOut(command, "@PA_SYSS_SAVE_JSON", record.SaveJson);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISearchTypeRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
