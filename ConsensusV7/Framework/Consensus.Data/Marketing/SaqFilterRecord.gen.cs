using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents the "SAQ_FILTER" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SaqFilterRecord : Record<Int64>, Cloneable<SaqFilterRecord>, IEquatable<SaqFilterRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "F_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "F_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "F_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "F_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "F_DISPLAY_ORDER" field.
        /// </summary>
        private Int16 _displayOrder;

        /// <summary>
        ///     the value of the "F_DISPLAY" field.
        /// </summary>
        private Byte _display;

        /// <summary>
        ///     the value of the "F_TABLE_PREFIX" field.
        /// </summary>
        private String _tablePrefix;

        /// <summary>
        ///     the value of the "F_TABLE_DESC" field.
        /// </summary>
        private String _tableDesc;

        /// <summary>
        ///     the value of the "F_COLUMN_NAME" field.
        /// </summary>
        private String _columnName;

        /// <summary>
        ///     the value of the "F_COLUMN_TYPE" field.
        /// </summary>
        private String _columnType;

        /// <summary>
        ///     the value of the "F_COLUMN_LENGTH" field.
        /// </summary>
        private Int32? _columnLength;

        /// <summary>
        ///     the value of the "F_COLUMN_DESC" field.
        /// </summary>
        private String _columnDesc;

        /// <summary>
        ///     the value of the "F_CODE_LOOKUP" field.
        /// </summary>
        private Byte _codeLookup;

        /// <summary>
        ///     the value of the "F_CODE_HEADER" field.
        /// </summary>
        private String _codeHeader;

        /// <summary>
        ///     the value of the "F_CODE_VAL" field.
        /// </summary>
        private Byte? _codeVal;

        /// <summary>
        ///     the value of the "F_ID_IN_LOOKUP" field.
        /// </summary>
        private Byte _idInLookup;

        /// <summary>
        ///     the value of the "F_DEFAULT_OPERAND" field.
        /// </summary>
        private String _defaultOperand;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "F_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "F_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "F_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "F_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "F_DISPLAY_ORDER" field.
        /// </summary>
        public Int16 DisplayOrder
        {
            get { return _displayOrder; }
            set { _displayOrder = value; }
        }

        /// <summary>
        ///     the value of the "F_DISPLAY" field.
        /// </summary>
        public Byte Display
        {
            get { return _display; }
            set { _display = value; }
        }

        /// <summary>
        ///     the value of the "F_TABLE_PREFIX" field.
        /// </summary>
        public String TablePrefix
        {
            get { return _tablePrefix; }
            set { _tablePrefix = value; }
        }

        /// <summary>
        ///     the value of the "F_TABLE_DESC" field.
        /// </summary>
        public String TableDesc
        {
            get { return _tableDesc; }
            set { _tableDesc = value; }
        }

        /// <summary>
        ///     the value of the "F_COLUMN_NAME" field.
        /// </summary>
        public String ColumnName
        {
            get { return _columnName; }
            set { _columnName = value; }
        }

        /// <summary>
        ///     the value of the "F_COLUMN_TYPE" field.
        /// </summary>
        public String ColumnType
        {
            get { return _columnType; }
            set { _columnType = value; }
        }

        /// <summary>
        ///     the value of the "F_COLUMN_LENGTH" field.
        /// </summary>
        public Int32? ColumnLength
        {
            get { return _columnLength; }
            set { _columnLength = value; }
        }

        /// <summary>
        ///     the value of the "F_COLUMN_DESC" field.
        /// </summary>
        public String ColumnDesc
        {
            get { return _columnDesc; }
            set { _columnDesc = value; }
        }

        /// <summary>
        ///     the value of the "F_CODE_LOOKUP" field.
        /// </summary>
        public Byte CodeLookup
        {
            get { return _codeLookup; }
            set { _codeLookup = value; }
        }

        /// <summary>
        ///     the value of the "F_CODE_HEADER" field.
        /// </summary>
        public String CodeHeader
        {
            get { return _codeHeader; }
            set { _codeHeader = value; }
        }

        /// <summary>
        ///     the value of the "F_CODE_VAL" field.
        /// </summary>
        public Byte? CodeVal
        {
            get { return _codeVal; }
            set { _codeVal = value; }
        }

        /// <summary>
        ///     the value of the "F_ID_IN_LOOKUP" field.
        /// </summary>
        public Byte IdInLookup
        {
            get { return _idInLookup; }
            set { _idInLookup = value; }
        }

        /// <summary>
        ///     the value of the "F_DEFAULT_OPERAND" field.
        /// </summary>
        public String DefaultOperand
        {
            get { return _defaultOperand; }
            set { _defaultOperand = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SaqFilterRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SaqFilterRecord" /> object instance.
        /// </returns>
        public SaqFilterRecord Clone()
        {
            SaqFilterRecord record = new SaqFilterRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.DisplayOrder = this.DisplayOrder;
            record.Display = this.Display;
            record.TablePrefix = this.TablePrefix;
            record.TableDesc = this.TableDesc;
            record.ColumnName = this.ColumnName;
            record.ColumnType = this.ColumnType;
            record.ColumnLength = this.ColumnLength;
            record.ColumnDesc = this.ColumnDesc;
            record.CodeLookup = this.CodeLookup;
            record.CodeHeader = this.CodeHeader;
            record.CodeVal = this.CodeVal;
            record.IdInLookup = this.IdInLookup;
            record.DefaultOperand = this.DefaultOperand;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SaqFilterRecord" /> instance is equal to another <see cref="SaqFilterRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SaqFilterRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SaqFilterRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.DisplayOrder == that.DisplayOrder);
            result = result && (this.Display == that.Display);
            result = result && (this.TablePrefix.TrimOrNullify() == that.TablePrefix.TrimOrNullify());
            result = result && (this.TableDesc.TrimOrNullify() == that.TableDesc.TrimOrNullify());
            result = result && (this.ColumnName.TrimOrNullify() == that.ColumnName.TrimOrNullify());
            result = result && (this.ColumnType.TrimOrNullify() == that.ColumnType.TrimOrNullify());
            result = result && (this.ColumnLength == that.ColumnLength);
            result = result && (this.ColumnDesc.TrimOrNullify() == that.ColumnDesc.TrimOrNullify());
            result = result && (this.CodeLookup == that.CodeLookup);
            result = result && (this.CodeHeader.TrimOrNullify() == that.CodeHeader.TrimOrNullify());
            result = result && (this.CodeVal == that.CodeVal);
            result = result && (this.IdInLookup == that.IdInLookup);
            result = result && (this.DefaultOperand.TrimOrNullify() == that.DefaultOperand.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
