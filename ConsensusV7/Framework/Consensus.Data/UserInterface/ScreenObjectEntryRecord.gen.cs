using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "Screen_Object_Entry" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ScreenObjectEntryRecord : Record<Int32>, Cloneable<ScreenObjectEntryRecord>, IEquatable<ScreenObjectEntryRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "OBJENT_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "OBJENT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "OBJENT_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "OBJENT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        private Int32 _objId;

        /// <summary>
        ///     the value of the "OBJENT_ITEM_NORMAL" field.
        /// </summary>
        private String _itemNormal;

        /// <summary>
        ///     the value of the "OBJENT_ITEM_CUSTOM" field.
        /// </summary>
        private String _itemCustom;

        /// <summary>
        ///     the value of the "OBJENT_ITEM_HIDE" field.
        /// </summary>
        private Boolean _itemHide;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "OBJENT_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "OBJENT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "OBJENT_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "OBJENT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        public Int32 ObjId
        {
            get { return _objId; }
            set { _objId = value; }
        }

        /// <summary>
        ///     the value of the "OBJENT_ITEM_NORMAL" field.
        /// </summary>
        public String ItemNormal
        {
            get { return _itemNormal; }
            set { _itemNormal = value; }
        }

        /// <summary>
        ///     the value of the "OBJENT_ITEM_CUSTOM" field.
        /// </summary>
        public String ItemCustom
        {
            get { return _itemCustom; }
            set { _itemCustom = value; }
        }

        /// <summary>
        ///     the value of the "OBJENT_ITEM_HIDE" field.
        /// </summary>
        public Boolean ItemHide
        {
            get { return _itemHide; }
            set { _itemHide = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ScreenObjectEntryRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ScreenObjectEntryRecord" /> object instance.
        /// </returns>
        public ScreenObjectEntryRecord Clone()
        {
            ScreenObjectEntryRecord record = new ScreenObjectEntryRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.ObjId = this.ObjId;
            record.ItemNormal = this.ItemNormal;
            record.ItemCustom = this.ItemCustom;
            record.ItemHide = this.ItemHide;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ScreenObjectEntryRecord" /> instance is equal to another <see cref="ScreenObjectEntryRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ScreenObjectEntryRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ScreenObjectEntryRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.ObjId == that.ObjId);
            result = result && (this.ItemNormal.TrimOrNullify() == that.ItemNormal.TrimOrNullify());
            result = result && (this.ItemCustom.TrimOrNullify() == that.ItemCustom.TrimOrNullify());
            result = result && (this.ItemHide == that.ItemHide);
            return result;
        }

        #endregion
    }
}
