using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "Screen_Object_Column" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ScreenObjectColumnRecord : Record<Int32>, Cloneable<ScreenObjectColumnRecord>, IEquatable<ScreenObjectColumnRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "OBJCOL_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "OBJCOL_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "OBJCOL_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "OBJCOL_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "OBJCOL_OBJ_ID" field.
        /// </summary>
        private Int32 _objId;

        /// <summary>
        ///     the value of the "OBJCOL_ORDINAL" field.
        /// </summary>
        private Int32 _ordinal;

        /// <summary>
        ///     the value of the "OBJCOL_CUSTOM" field.
        /// </summary>
        private String _custom;

        /// <summary>
        ///     the value of the "OBJCOL_EXPORTABLE" field.
        /// </summary>
        private Boolean _exportable;

        /// <summary>
        ///     the value of the "OBJCOL_VISIBLE" field.
        /// </summary>
        private Boolean _visible;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "OBJCOL_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "OBJCOL_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "OBJCOL_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "OBJCOL_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "OBJCOL_OBJ_ID" field.
        /// </summary>
        public Int32 ObjId
        {
            get { return _objId; }
            set { _objId = value; }
        }

        /// <summary>
        ///     the value of the "OBJCOL_ORDINAL" field.
        /// </summary>
        public Int32 Ordinal
        {
            get { return _ordinal; }
            set { _ordinal = value; }
        }

        /// <summary>
        ///     the value of the "OBJCOL_CUSTOM" field.
        /// </summary>
        public String Custom
        {
            get { return _custom; }
            set { _custom = value; }
        }

        /// <summary>
        ///     the value of the "OBJCOL_EXPORTABLE" field.
        /// </summary>
        public Boolean Exportable
        {
            get { return _exportable; }
            set { _exportable = value; }
        }

        /// <summary>
        ///     the value of the "OBJCOL_VISIBLE" field.
        /// </summary>
        public Boolean Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ScreenObjectColumnRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ScreenObjectColumnRecord" /> object instance.
        /// </returns>
        public ScreenObjectColumnRecord Clone()
        {
            ScreenObjectColumnRecord record = new ScreenObjectColumnRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.ObjId = this.ObjId;
            record.Ordinal = this.Ordinal;
            record.Custom = this.Custom;
            record.Exportable = this.Exportable;
            record.Visible = this.Visible;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ScreenObjectColumnRecord" /> instance is equal to another <see cref="ScreenObjectColumnRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ScreenObjectColumnRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ScreenObjectColumnRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.ObjId == that.ObjId);
            result = result && (this.Ordinal == that.Ordinal);
            result = result && (this.Custom.TrimOrNullify() == that.Custom.TrimOrNullify());
            result = result && (this.Exportable == that.Exportable);
            result = result && (this.Visible == that.Visible);
            return result;
        }

        #endregion
    }
}
