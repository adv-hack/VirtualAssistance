using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents the "System_Searches_Grid_Columns" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SystemSearchesGridColumnsRecord : Record<Int32>, Cloneable<SystemSearchesGridColumnsRecord>, IEquatable<SystemSearchesGridColumnsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "SYSSC_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "SYSSC_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "SYSSC_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "SYSSC_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        private Int32 _syssId;

        /// <summary>
        ///     the value of the "SYSSC_DISPLAY_ORDER" field.
        /// </summary>
        private Int32 _displayOrder;

        /// <summary>
        ///     the value of the "SYSSC_FIELD_MAPPING" field.
        /// </summary>
        private String _fieldMapping;

        /// <summary>
        ///     the value of the "SYSSC_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "SYSSC_LABEL" field.
        /// </summary>
        private String _label;

        /// <summary>
        ///     the value of the "SYSSC_TOOLTIP_TEXT" field.
        /// </summary>
        private String _tooltipText;

        /// <summary>
        ///     the value of the "SYSSC_INDEX" field.
        /// </summary>
        private String _index;

        /// <summary>
        ///     the value of the "SYSSC_WIDTH" field.
        /// </summary>
        private Int32? _width;

        /// <summary>
        ///     the value of the "SYSSC_ALIGN" field.
        /// </summary>
        private String _align;

        /// <summary>
        ///     the value of the "SYSSC_VISIBLE" field.
        /// </summary>
        private Boolean _visible;

        /// <summary>
        ///     the value of the "SYSSC_VISIBLE_CONDITION" field.
        /// </summary>
        private String _visibleCondition;

        /// <summary>
        ///     the value of the "SYSSC_OUTPUT_TYPE" field.
        /// </summary>
        private Byte _outputType;

        /// <summary>
        ///     the value of the "SYSSC_SHOW_IN_BASIC_RESULTS" field.
        /// </summary>
        private Boolean _showInBasicResults;

        /// <summary>
        ///     the value of the "SYSSC_CELLATTR" field.
        /// </summary>
        private String _cellattr;

        /// <summary>
        ///     the value of the "SYSSC_SORT_TYPE" field.
        /// </summary>
        private String _sortType;

        /// <summary>
        ///     the value of the "SYSSC_PERMISSIONS" field.
        /// </summary>
        private String _permissions;

        /// <summary>
        ///     the value of the "SYSSC_DISPLAY_FORMAT" field.
        /// </summary>
        private String _displayFormat;

        /// <summary>
        ///     the value of the "SYSSC_DISPLAY_FORMAT_TRUE" field.
        /// </summary>
        private String _displayFormatTrue;

        /// <summary>
        ///     the value of the "SYSSC_DISPLAY_FORMAT_FALSE" field.
        /// </summary>
        private String _displayFormatFalse;

        /// <summary>
        ///     the value of the "SYSSC_KEY" field.
        /// </summary>
        private Byte _key;

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_TYPE" field.
        /// </summary>
        private String _columnType;

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_HTML" field.
        /// </summary>
        private String _columnHtml;

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_LINK_TEXT" field.
        /// </summary>
        private String _columnLinkText;

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_LINK_HREF" field.
        /// </summary>
        private String _columnLinkHref;

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_TRUE_ICON" field.
        /// </summary>
        private String _columnIconTrueIcon;

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_TRUE_TEXT" field.
        /// </summary>
        private String _columnIconTrueText;

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_TRUE_CSS" field.
        /// </summary>
        private String _columnIconTrueCss;

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_FALSE_ICON" field.
        /// </summary>
        private String _columnIconFalseIcon;

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_FALSE_TEXT" field.
        /// </summary>
        private String _columnIconFalseText;

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_FALSE_CSS" field.
        /// </summary>
        private String _columnIconFalseCss;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "SYSSC_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        public Int32 SyssId
        {
            get { return _syssId; }
            set { _syssId = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_DISPLAY_ORDER" field.
        /// </summary>
        public Int32 DisplayOrder
        {
            get { return _displayOrder; }
            set { _displayOrder = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_FIELD_MAPPING" field.
        /// </summary>
        public String FieldMapping
        {
            get { return _fieldMapping; }
            set { _fieldMapping = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_LABEL" field.
        /// </summary>
        public String Label
        {
            get { return _label; }
            set { _label = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_TOOLTIP_TEXT" field.
        /// </summary>
        public String TooltipText
        {
            get { return _tooltipText; }
            set { _tooltipText = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_INDEX" field.
        /// </summary>
        public String Index
        {
            get { return _index; }
            set { _index = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_WIDTH" field.
        /// </summary>
        public Int32? Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_ALIGN" field.
        /// </summary>
        public String Align
        {
            get { return _align; }
            set { _align = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_VISIBLE" field.
        /// </summary>
        public Boolean Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_VISIBLE_CONDITION" field.
        /// </summary>
        public String VisibleCondition
        {
            get { return _visibleCondition; }
            set { _visibleCondition = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_OUTPUT_TYPE" field.
        /// </summary>
        public Byte OutputType
        {
            get { return _outputType; }
            set { _outputType = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_SHOW_IN_BASIC_RESULTS" field.
        /// </summary>
        public Boolean ShowInBasicResults
        {
            get { return _showInBasicResults; }
            set { _showInBasicResults = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_CELLATTR" field.
        /// </summary>
        public String Cellattr
        {
            get { return _cellattr; }
            set { _cellattr = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_SORT_TYPE" field.
        /// </summary>
        public String SortType
        {
            get { return _sortType; }
            set { _sortType = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_PERMISSIONS" field.
        /// </summary>
        public String Permissions
        {
            get { return _permissions; }
            set { _permissions = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_DISPLAY_FORMAT" field.
        /// </summary>
        public String DisplayFormat
        {
            get { return _displayFormat; }
            set { _displayFormat = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_DISPLAY_FORMAT_TRUE" field.
        /// </summary>
        public String DisplayFormatTrue
        {
            get { return _displayFormatTrue; }
            set { _displayFormatTrue = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_DISPLAY_FORMAT_FALSE" field.
        /// </summary>
        public String DisplayFormatFalse
        {
            get { return _displayFormatFalse; }
            set { _displayFormatFalse = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_KEY" field.
        /// </summary>
        public Byte Key
        {
            get { return _key; }
            set { _key = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_TYPE" field.
        /// </summary>
        public String ColumnType
        {
            get { return _columnType; }
            set { _columnType = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_HTML" field.
        /// </summary>
        public String ColumnHtml
        {
            get { return _columnHtml; }
            set { _columnHtml = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_LINK_TEXT" field.
        /// </summary>
        public String ColumnLinkText
        {
            get { return _columnLinkText; }
            set { _columnLinkText = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_LINK_HREF" field.
        /// </summary>
        public String ColumnLinkHref
        {
            get { return _columnLinkHref; }
            set { _columnLinkHref = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_TRUE_ICON" field.
        /// </summary>
        public String ColumnIconTrueIcon
        {
            get { return _columnIconTrueIcon; }
            set { _columnIconTrueIcon = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_TRUE_TEXT" field.
        /// </summary>
        public String ColumnIconTrueText
        {
            get { return _columnIconTrueText; }
            set { _columnIconTrueText = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_TRUE_CSS" field.
        /// </summary>
        public String ColumnIconTrueCss
        {
            get { return _columnIconTrueCss; }
            set { _columnIconTrueCss = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_FALSE_ICON" field.
        /// </summary>
        public String ColumnIconFalseIcon
        {
            get { return _columnIconFalseIcon; }
            set { _columnIconFalseIcon = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_FALSE_TEXT" field.
        /// </summary>
        public String ColumnIconFalseText
        {
            get { return _columnIconFalseText; }
            set { _columnIconFalseText = value; }
        }

        /// <summary>
        ///     the value of the "SYSSC_V7_COLUMN_ICON_FALSE_CSS" field.
        /// </summary>
        public String ColumnIconFalseCss
        {
            get { return _columnIconFalseCss; }
            set { _columnIconFalseCss = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SystemSearchesGridColumnsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SystemSearchesGridColumnsRecord" /> object instance.
        /// </returns>
        public SystemSearchesGridColumnsRecord Clone()
        {
            SystemSearchesGridColumnsRecord record = new SystemSearchesGridColumnsRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.SyssId = this.SyssId;
            record.DisplayOrder = this.DisplayOrder;
            record.FieldMapping = this.FieldMapping;
            record.Name = this.Name;
            record.Label = this.Label;
            record.TooltipText = this.TooltipText;
            record.Index = this.Index;
            record.Width = this.Width;
            record.Align = this.Align;
            record.Visible = this.Visible;
            record.VisibleCondition = this.VisibleCondition;
            record.OutputType = this.OutputType;
            record.ShowInBasicResults = this.ShowInBasicResults;
            record.Cellattr = this.Cellattr;
            record.SortType = this.SortType;
            record.Permissions = this.Permissions;
            record.DisplayFormat = this.DisplayFormat;
            record.DisplayFormatTrue = this.DisplayFormatTrue;
            record.DisplayFormatFalse = this.DisplayFormatFalse;
            record.Key = this.Key;
            record.ColumnType = this.ColumnType;
            record.ColumnHtml = this.ColumnHtml;
            record.ColumnLinkText = this.ColumnLinkText;
            record.ColumnLinkHref = this.ColumnLinkHref;
            record.ColumnIconTrueIcon = this.ColumnIconTrueIcon;
            record.ColumnIconTrueText = this.ColumnIconTrueText;
            record.ColumnIconTrueCss = this.ColumnIconTrueCss;
            record.ColumnIconFalseIcon = this.ColumnIconFalseIcon;
            record.ColumnIconFalseText = this.ColumnIconFalseText;
            record.ColumnIconFalseCss = this.ColumnIconFalseCss;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SystemSearchesGridColumnsRecord" /> instance is equal to another <see cref="SystemSearchesGridColumnsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SystemSearchesGridColumnsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SystemSearchesGridColumnsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.SyssId == that.SyssId);
            result = result && (this.DisplayOrder == that.DisplayOrder);
            result = result && (this.FieldMapping.TrimOrNullify() == that.FieldMapping.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Label.TrimOrNullify() == that.Label.TrimOrNullify());
            result = result && (this.TooltipText.TrimOrNullify() == that.TooltipText.TrimOrNullify());
            result = result && (this.Index.TrimOrNullify() == that.Index.TrimOrNullify());
            result = result && (this.Width == that.Width);
            result = result && (this.Align.TrimOrNullify() == that.Align.TrimOrNullify());
            result = result && (this.Visible == that.Visible);
            result = result && (this.VisibleCondition.TrimOrNullify() == that.VisibleCondition.TrimOrNullify());
            result = result && (this.OutputType == that.OutputType);
            result = result && (this.ShowInBasicResults == that.ShowInBasicResults);
            result = result && (this.Cellattr.TrimOrNullify() == that.Cellattr.TrimOrNullify());
            result = result && (this.SortType.TrimOrNullify() == that.SortType.TrimOrNullify());
            result = result && (this.Permissions.TrimOrNullify() == that.Permissions.TrimOrNullify());
            result = result && (this.DisplayFormat.TrimOrNullify() == that.DisplayFormat.TrimOrNullify());
            result = result && (this.DisplayFormatTrue.TrimOrNullify() == that.DisplayFormatTrue.TrimOrNullify());
            result = result && (this.DisplayFormatFalse.TrimOrNullify() == that.DisplayFormatFalse.TrimOrNullify());
            result = result && (this.Key == that.Key);
            result = result && (this.ColumnType.TrimOrNullify() == that.ColumnType.TrimOrNullify());
            result = result && (this.ColumnHtml.TrimOrNullify() == that.ColumnHtml.TrimOrNullify());
            result = result && (this.ColumnLinkText.TrimOrNullify() == that.ColumnLinkText.TrimOrNullify());
            result = result && (this.ColumnLinkHref.TrimOrNullify() == that.ColumnLinkHref.TrimOrNullify());
            result = result && (this.ColumnIconTrueIcon.TrimOrNullify() == that.ColumnIconTrueIcon.TrimOrNullify());
            result = result && (this.ColumnIconTrueText.TrimOrNullify() == that.ColumnIconTrueText.TrimOrNullify());
            result = result && (this.ColumnIconTrueCss.TrimOrNullify() == that.ColumnIconTrueCss.TrimOrNullify());
            result = result && (this.ColumnIconFalseIcon.TrimOrNullify() == that.ColumnIconFalseIcon.TrimOrNullify());
            result = result && (this.ColumnIconFalseText.TrimOrNullify() == that.ColumnIconFalseText.TrimOrNullify());
            result = result && (this.ColumnIconFalseCss.TrimOrNullify() == that.ColumnIconFalseCss.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
