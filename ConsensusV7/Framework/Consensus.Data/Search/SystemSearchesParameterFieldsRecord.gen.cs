using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents the "System_Searches_Parameter_Fields" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SystemSearchesParameterFieldsRecord : Record<Int32>, Cloneable<SystemSearchesParameterFieldsRecord>, IEquatable<SystemSearchesParameterFieldsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "SYSSP_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "SYSSP_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "SYSSP_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "SYSSP_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "SYSSP_SYSS_ID" field.
        /// </summary>
        private Int32 _syssId;

        /// <summary>
        ///     the value of the "SYSSP_DISPLAY_OPTION_TYPE" field.
        /// </summary>
        private Byte _displayOptionType;

        /// <summary>
        ///     the value of the "SYSSP_DISPLAY_ORDER" field.
        /// </summary>
        private Int32 _displayOrder;

        /// <summary>
        ///     the value of the "SYSSP_FIELD_NAME" field.
        /// </summary>
        private String _fieldName;

        /// <summary>
        ///     the value of the "SYSSP_DEFAULT_LABEL" field.
        /// </summary>
        private String _defaultLabel;

        /// <summary>
        ///     the value of the "SYSSP_LABEL" field.
        /// </summary>
        private String _label;

        /// <summary>
        ///     the value of the "SYSSP_FIELD_TYPE" field.
        /// </summary>
        private String _fieldType;

        /// <summary>
        ///     the value of the "SYSSP_WHERE_CLAUSE_OPERATOR" field.
        /// </summary>
        private String _whereClauseOperator;

        /// <summary>
        ///     the value of the "SYSSP_VISIBLE" field.
        /// </summary>
        private Byte _visible;

        /// <summary>
        ///     the value of the "SYSSP_VISIBLE_CONDITION" field.
        /// </summary>
        private String _visibleCondition;

        /// <summary>
        ///     the value of the "SYSSP_DEFAULT_VALUE" field.
        /// </summary>
        private String _defaultValue;

        /// <summary>
        ///     the value of the "SYSSP_CODE_LIST" field.
        /// </summary>
        private String _codeList;

        /// <summary>
        ///     the value of the "SYSSP_DATA" field.
        /// </summary>
        private String _data;

        /// <summary>
        ///     the value of the "SYSSP_WHERE_CLAUSE_OVERRIDE" field.
        /// </summary>
        private String _whereClauseOverride;

        /// <summary>
        ///     the value of the "SYSSP_PERMISSIONS" field.
        /// </summary>
        private String _permissions;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "SYSSP_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_SYSS_ID" field.
        /// </summary>
        public Int32 SyssId
        {
            get { return _syssId; }
            set { _syssId = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_DISPLAY_OPTION_TYPE" field.
        /// </summary>
        public Byte DisplayOptionType
        {
            get { return _displayOptionType; }
            set { _displayOptionType = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_DISPLAY_ORDER" field.
        /// </summary>
        public Int32 DisplayOrder
        {
            get { return _displayOrder; }
            set { _displayOrder = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_FIELD_NAME" field.
        /// </summary>
        public String FieldName
        {
            get { return _fieldName; }
            set { _fieldName = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_DEFAULT_LABEL" field.
        /// </summary>
        public String DefaultLabel
        {
            get { return _defaultLabel; }
            set { _defaultLabel = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_LABEL" field.
        /// </summary>
        public String Label
        {
            get { return _label; }
            set { _label = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_FIELD_TYPE" field.
        /// </summary>
        public String FieldType
        {
            get { return _fieldType; }
            set { _fieldType = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_WHERE_CLAUSE_OPERATOR" field.
        /// </summary>
        public String WhereClauseOperator
        {
            get { return _whereClauseOperator; }
            set { _whereClauseOperator = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_VISIBLE" field.
        /// </summary>
        public Byte Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_VISIBLE_CONDITION" field.
        /// </summary>
        public String VisibleCondition
        {
            get { return _visibleCondition; }
            set { _visibleCondition = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_DEFAULT_VALUE" field.
        /// </summary>
        public String DefaultValue
        {
            get { return _defaultValue; }
            set { _defaultValue = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_CODE_LIST" field.
        /// </summary>
        public String CodeList
        {
            get { return _codeList; }
            set { _codeList = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_DATA" field.
        /// </summary>
        public String Data
        {
            get { return _data; }
            set { _data = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_WHERE_CLAUSE_OVERRIDE" field.
        /// </summary>
        public String WhereClauseOverride
        {
            get { return _whereClauseOverride; }
            set { _whereClauseOverride = value; }
        }

        /// <summary>
        ///     the value of the "SYSSP_PERMISSIONS" field.
        /// </summary>
        public String Permissions
        {
            get { return _permissions; }
            set { _permissions = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SystemSearchesParameterFieldsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SystemSearchesParameterFieldsRecord" /> object instance.
        /// </returns>
        public SystemSearchesParameterFieldsRecord Clone()
        {
            SystemSearchesParameterFieldsRecord record = new SystemSearchesParameterFieldsRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.SyssId = this.SyssId;
            record.DisplayOptionType = this.DisplayOptionType;
            record.DisplayOrder = this.DisplayOrder;
            record.FieldName = this.FieldName;
            record.DefaultLabel = this.DefaultLabel;
            record.Label = this.Label;
            record.FieldType = this.FieldType;
            record.WhereClauseOperator = this.WhereClauseOperator;
            record.Visible = this.Visible;
            record.VisibleCondition = this.VisibleCondition;
            record.DefaultValue = this.DefaultValue;
            record.CodeList = this.CodeList;
            record.Data = this.Data;
            record.WhereClauseOverride = this.WhereClauseOverride;
            record.Permissions = this.Permissions;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SystemSearchesParameterFieldsRecord" /> instance is equal to another <see cref="SystemSearchesParameterFieldsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SystemSearchesParameterFieldsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SystemSearchesParameterFieldsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.SyssId == that.SyssId);
            result = result && (this.DisplayOptionType == that.DisplayOptionType);
            result = result && (this.DisplayOrder == that.DisplayOrder);
            result = result && (this.FieldName.TrimOrNullify() == that.FieldName.TrimOrNullify());
            result = result && (this.DefaultLabel.TrimOrNullify() == that.DefaultLabel.TrimOrNullify());
            result = result && (this.Label.TrimOrNullify() == that.Label.TrimOrNullify());
            result = result && (this.FieldType.TrimOrNullify() == that.FieldType.TrimOrNullify());
            result = result && (this.WhereClauseOperator.TrimOrNullify() == that.WhereClauseOperator.TrimOrNullify());
            result = result && (this.Visible == that.Visible);
            result = result && (this.VisibleCondition.TrimOrNullify() == that.VisibleCondition.TrimOrNullify());
            result = result && (this.DefaultValue.TrimOrNullify() == that.DefaultValue.TrimOrNullify());
            result = result && (this.CodeList.TrimOrNullify() == that.CodeList.TrimOrNullify());
            result = result && (this.Data.TrimOrNullify() == that.Data.TrimOrNullify());
            result = result && (this.WhereClauseOverride.TrimOrNullify() == that.WhereClauseOverride.TrimOrNullify());
            result = result && (this.Permissions.TrimOrNullify() == that.Permissions.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
