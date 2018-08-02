using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents defines the columns that are displayed when performing a search within the application.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISearchColumnModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "SYSSC_OUTPUT_TYPE" field.
        /// </summary>
        Consensus.Search.SearchColumnOutputTypes OutputType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        Consensus.Search.ISearchTypeModel SearchType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SYSSC_SYSS_ID" field.
        /// </summary>
        System.Int32 SearchTypeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_DISPLAY_ORDER" field.
        /// </summary>
        System.Int32 Order
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_FIELD_MAPPING" field.
        /// </summary>
        System.String FieldName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_LABEL" field.
        /// </summary>
        System.String Label
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_TOOLTIP_TEXT" field.
        /// </summary>
        System.String ToolTip
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_VISIBLE" field.
        /// </summary>
        System.Boolean Visible
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_SHOW_IN_BASIC_RESULTS" field.
        /// </summary>
        System.Boolean ShowInBasicResults
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_TYPE" field.
        /// </summary>
        System.String ColumnType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_HTML" field.
        /// </summary>
        System.String ColumnHtml
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_LINK_TEXT" field.
        /// </summary>
        System.String ColumnLinkText
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_LINK_HREF" field.
        /// </summary>
        System.String ColumnLinkHref
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_ICON" field.
        /// </summary>
        System.String ColumnIconTrueIcon
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_TEXT" field.
        /// </summary>
        System.String ColumnIconTrueText
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_TRUE_CSS" field.
        /// </summary>
        System.String ColumnIconTrueCss
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_ICON" field.
        /// </summary>
        System.String ColumnIconFalseIcon
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_TEXT" field.
        /// </summary>
        System.String ColumnIconFalseText
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSC_V7_COLUMN_ICON_FALSE_CSS" field.
        /// </summary>
        System.String ColumnIconFalseCss
        {
            get;
            set;
        }
    }
}
