using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "Screen_Object_Display" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ScreenObjectDisplayRecord : Record<Int32>, Cloneable<ScreenObjectDisplayRecord>, IEquatable<ScreenObjectDisplayRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "OBJDIS_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "OBJDIS_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "OBJDIS_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "OBJDIS_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "OBJDIS_OBJ_ID" field.
        /// </summary>
        private Int32 _objId;

        /// <summary>
        ///     the value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        private Int32 _principalId;

        /// <summary>
        ///     the value of the "OBJDIS_DISPLAY" field.
        /// </summary>
        private Byte _display;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "OBJDIS_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "OBJDIS_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "OBJDIS_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "OBJDIS_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "OBJDIS_OBJ_ID" field.
        /// </summary>
        public Int32 ObjId
        {
            get { return _objId; }
            set { _objId = value; }
        }

        /// <summary>
        ///     the value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        public Int32 PrincipalId
        {
            get { return _principalId; }
            set { _principalId = value; }
        }

        /// <summary>
        ///     the value of the "OBJDIS_DISPLAY" field.
        /// </summary>
        public Byte Display
        {
            get { return _display; }
            set { _display = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ScreenObjectDisplayRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ScreenObjectDisplayRecord" /> object instance.
        /// </returns>
        public ScreenObjectDisplayRecord Clone()
        {
            ScreenObjectDisplayRecord record = new ScreenObjectDisplayRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.ObjId = this.ObjId;
            record.PrincipalId = this.PrincipalId;
            record.Display = this.Display;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ScreenObjectDisplayRecord" /> instance is equal to another <see cref="ScreenObjectDisplayRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ScreenObjectDisplayRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ScreenObjectDisplayRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.ObjId == that.ObjId);
            result = result && (this.PrincipalId == that.PrincipalId);
            result = result && (this.Display == that.Display);
            return result;
        }

        #endregion
    }
}
