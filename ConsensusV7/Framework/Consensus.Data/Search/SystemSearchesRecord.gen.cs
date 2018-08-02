using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents the "System_Searches" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SystemSearchesRecord : Record<Int32>, Cloneable<SystemSearchesRecord>, IEquatable<SystemSearchesRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "SYSS_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "SYSS_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "SYSS_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "SYSS_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "SYSS_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "SYSS_SYS_TYPE" field.
        /// </summary>
        private Byte _sysType;

        /// <summary>
        ///     the value of the "SYSS_PAGE_TITLE" field.
        /// </summary>
        private String _pageTitle;

        /// <summary>
        ///     the value of the "SYSS_SEARCH_DISPLAY_NAME" field.
        /// </summary>
        private String _searchDisplayName;

        /// <summary>
        ///     the value of the "SYSS_DISPLAY_ORDER" field.
        /// </summary>
        private Int32 _displayOrder;

        /// <summary>
        ///     the value of the "SYSS_DB_VIEW_NAME" field.
        /// </summary>
        private String _dbViewName;

        /// <summary>
        ///     the value of the "SYSS_DB_VIEW_FIELDS" field.
        /// </summary>
        private String _dbViewFields;

        /// <summary>
        ///     the value of the "SYSS_ORDER_BY" field.
        /// </summary>
        private String _orderBy;

        /// <summary>
        ///     the value of the "SYSS_DOUBLE_CLICK_ACTION_COLUMN" field.
        /// </summary>
        private Int32? _doubleClickActionColumn;

        /// <summary>
        ///     the value of the "SYSS_DEFAULT_SORT_COLUMN" field.
        /// </summary>
        private String _defaultSortColumn;

        /// <summary>
        ///     the value of the "SYSS_BANNER_TEXT" field.
        /// </summary>
        private String _bannerText;

        /// <summary>
        ///     the value of the "SYSS_SHOW_DROPDOWN" field.
        /// </summary>
        private Boolean _showDropdown;

        /// <summary>
        ///     the value of the "SYSS_AUTOSEARCH" field.
        /// </summary>
        private Boolean _autosearch;

        /// <summary>
        ///     the value of the "SYSS_HIDE_PARAMETER_SECTION" field.
        /// </summary>
        private Boolean _hideParameterSection;

        /// <summary>
        ///     the value of the "SYSS_DEFAULT_MAX_RESULTS" field.
        /// </summary>
        private Int32 _defaultMaxResults;

        /// <summary>
        ///     the value of the "SYSS_CUSTOM_CLIENT_SCRIPT" field.
        /// </summary>
        private String _customClientScript;

        /// <summary>
        ///     the value of the "SYSS_PERMISSIONS" field.
        /// </summary>
        private String _permissions;

        /// <summary>
        ///     the value of the "SYSS_SHOW_EXPORT_OPTION" field.
        /// </summary>
        private Boolean _showExportOption;

        /// <summary>
        ///     the value of the "SYSS_MULTISELECT" field.
        /// </summary>
        private Byte _multiselect;

        /// <summary>
        ///     the value of the "SYSS_SEARCH_CUSTOM" field.
        /// </summary>
        private String _searchCustom;

        /// <summary>
        ///     the value of the "SYSS_DB_STORED_PROC" field.
        /// </summary>
        private String _dbStoredProc;

        /// <summary>
        ///     the value of the "SYSS_USE_STORED_PROC" field.
        /// </summary>
        private Boolean? _useStoredProc;

        /// <summary>
        ///     the value of the "SYSS_NEW_BUTTON" field.
        /// </summary>
        private String _newButton;

        /// <summary>
        ///     the value of the "SYSS_SAVE_JSON" field.
        /// </summary>
        private String _saveJson;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "SYSS_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_SYS_TYPE" field.
        /// </summary>
        public Byte SysType
        {
            get { return _sysType; }
            set { _sysType = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_PAGE_TITLE" field.
        /// </summary>
        public String PageTitle
        {
            get { return _pageTitle; }
            set { _pageTitle = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_SEARCH_DISPLAY_NAME" field.
        /// </summary>
        public String SearchDisplayName
        {
            get { return _searchDisplayName; }
            set { _searchDisplayName = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_DISPLAY_ORDER" field.
        /// </summary>
        public Int32 DisplayOrder
        {
            get { return _displayOrder; }
            set { _displayOrder = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_DB_VIEW_NAME" field.
        /// </summary>
        public String DbViewName
        {
            get { return _dbViewName; }
            set { _dbViewName = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_DB_VIEW_FIELDS" field.
        /// </summary>
        public String DbViewFields
        {
            get { return _dbViewFields; }
            set { _dbViewFields = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_ORDER_BY" field.
        /// </summary>
        public String OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_DOUBLE_CLICK_ACTION_COLUMN" field.
        /// </summary>
        public Int32? DoubleClickActionColumn
        {
            get { return _doubleClickActionColumn; }
            set { _doubleClickActionColumn = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_DEFAULT_SORT_COLUMN" field.
        /// </summary>
        public String DefaultSortColumn
        {
            get { return _defaultSortColumn; }
            set { _defaultSortColumn = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_BANNER_TEXT" field.
        /// </summary>
        public String BannerText
        {
            get { return _bannerText; }
            set { _bannerText = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_SHOW_DROPDOWN" field.
        /// </summary>
        public Boolean ShowDropdown
        {
            get { return _showDropdown; }
            set { _showDropdown = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_AUTOSEARCH" field.
        /// </summary>
        public Boolean Autosearch
        {
            get { return _autosearch; }
            set { _autosearch = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_HIDE_PARAMETER_SECTION" field.
        /// </summary>
        public Boolean HideParameterSection
        {
            get { return _hideParameterSection; }
            set { _hideParameterSection = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_DEFAULT_MAX_RESULTS" field.
        /// </summary>
        public Int32 DefaultMaxResults
        {
            get { return _defaultMaxResults; }
            set { _defaultMaxResults = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_CUSTOM_CLIENT_SCRIPT" field.
        /// </summary>
        public String CustomClientScript
        {
            get { return _customClientScript; }
            set { _customClientScript = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_PERMISSIONS" field.
        /// </summary>
        public String Permissions
        {
            get { return _permissions; }
            set { _permissions = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_SHOW_EXPORT_OPTION" field.
        /// </summary>
        public Boolean ShowExportOption
        {
            get { return _showExportOption; }
            set { _showExportOption = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_MULTISELECT" field.
        /// </summary>
        public Byte Multiselect
        {
            get { return _multiselect; }
            set { _multiselect = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_SEARCH_CUSTOM" field.
        /// </summary>
        public String SearchCustom
        {
            get { return _searchCustom; }
            set { _searchCustom = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_DB_STORED_PROC" field.
        /// </summary>
        public String DbStoredProc
        {
            get { return _dbStoredProc; }
            set { _dbStoredProc = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_USE_STORED_PROC" field.
        /// </summary>
        public Boolean? UseStoredProc
        {
            get { return _useStoredProc; }
            set { _useStoredProc = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_NEW_BUTTON" field.
        /// </summary>
        public String NewButton
        {
            get { return _newButton; }
            set { _newButton = value; }
        }

        /// <summary>
        ///     the value of the "SYSS_SAVE_JSON" field.
        /// </summary>
        public String SaveJson
        {
            get { return _saveJson; }
            set { _saveJson = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SystemSearchesRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SystemSearchesRecord" /> object instance.
        /// </returns>
        public SystemSearchesRecord Clone()
        {
            SystemSearchesRecord record = new SystemSearchesRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.Type = this.Type;
            record.SysType = this.SysType;
            record.PageTitle = this.PageTitle;
            record.SearchDisplayName = this.SearchDisplayName;
            record.DisplayOrder = this.DisplayOrder;
            record.DbViewName = this.DbViewName;
            record.DbViewFields = this.DbViewFields;
            record.OrderBy = this.OrderBy;
            record.DoubleClickActionColumn = this.DoubleClickActionColumn;
            record.DefaultSortColumn = this.DefaultSortColumn;
            record.BannerText = this.BannerText;
            record.ShowDropdown = this.ShowDropdown;
            record.Autosearch = this.Autosearch;
            record.HideParameterSection = this.HideParameterSection;
            record.DefaultMaxResults = this.DefaultMaxResults;
            record.CustomClientScript = this.CustomClientScript;
            record.Permissions = this.Permissions;
            record.ShowExportOption = this.ShowExportOption;
            record.Multiselect = this.Multiselect;
            record.SearchCustom = this.SearchCustom;
            record.DbStoredProc = this.DbStoredProc;
            record.UseStoredProc = this.UseStoredProc;
            record.NewButton = this.NewButton;
            record.SaveJson = this.SaveJson;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SystemSearchesRecord" /> instance is equal to another <see cref="SystemSearchesRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SystemSearchesRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SystemSearchesRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.SysType == that.SysType);
            result = result && (this.PageTitle.TrimOrNullify() == that.PageTitle.TrimOrNullify());
            result = result && (this.SearchDisplayName.TrimOrNullify() == that.SearchDisplayName.TrimOrNullify());
            result = result && (this.DisplayOrder == that.DisplayOrder);
            result = result && (this.DbViewName.TrimOrNullify() == that.DbViewName.TrimOrNullify());
            result = result && (this.DbViewFields.TrimOrNullify() == that.DbViewFields.TrimOrNullify());
            result = result && (this.OrderBy.TrimOrNullify() == that.OrderBy.TrimOrNullify());
            result = result && (this.DoubleClickActionColumn == that.DoubleClickActionColumn);
            result = result && (this.DefaultSortColumn.TrimOrNullify() == that.DefaultSortColumn.TrimOrNullify());
            result = result && (this.BannerText.TrimOrNullify() == that.BannerText.TrimOrNullify());
            result = result && (this.ShowDropdown == that.ShowDropdown);
            result = result && (this.Autosearch == that.Autosearch);
            result = result && (this.HideParameterSection == that.HideParameterSection);
            result = result && (this.DefaultMaxResults == that.DefaultMaxResults);
            result = result && (this.CustomClientScript.TrimOrNullify() == that.CustomClientScript.TrimOrNullify());
            result = result && (this.Permissions.TrimOrNullify() == that.Permissions.TrimOrNullify());
            result = result && (this.ShowExportOption == that.ShowExportOption);
            result = result && (this.Multiselect == that.Multiselect);
            result = result && (this.SearchCustom.TrimOrNullify() == that.SearchCustom.TrimOrNullify());
            result = result && (this.DbStoredProc.TrimOrNullify() == that.DbStoredProc.TrimOrNullify());
            result = result && (this.UseStoredProc == that.UseStoredProc);
            result = result && (this.NewButton.TrimOrNullify() == that.NewButton.TrimOrNullify());
            result = result && (this.SaveJson.TrimOrNullify() == that.SaveJson.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
