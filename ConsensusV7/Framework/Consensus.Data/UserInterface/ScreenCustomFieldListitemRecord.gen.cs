using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "Screen_Custom_Field_ListItem" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ScreenCustomFieldListitemRecord : Record<Int32>, Cloneable<ScreenCustomFieldListitemRecord>, IEquatable<ScreenCustomFieldListitemRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CFLITEM_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "CFLITEM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "CFLITEM_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "CFLITEM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        private Int32 _cfieldId;

        /// <summary>
        ///     the value of the "CFLITEM_ID_VALUE" field.
        /// </summary>
        private String _idValue;

        /// <summary>
        ///     the value of the "CFLITEM_TEXT" field.
        /// </summary>
        private String _text;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CFLITEM_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "CFLITEM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "CFLITEM_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "CFLITEM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        public Int32 CfieldId
        {
            get { return _cfieldId; }
            set { _cfieldId = value; }
        }

        /// <summary>
        ///     the value of the "CFLITEM_ID_VALUE" field.
        /// </summary>
        public String IdValue
        {
            get { return _idValue; }
            set { _idValue = value; }
        }

        /// <summary>
        ///     the value of the "CFLITEM_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ScreenCustomFieldListitemRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ScreenCustomFieldListitemRecord" /> object instance.
        /// </returns>
        public ScreenCustomFieldListitemRecord Clone()
        {
            ScreenCustomFieldListitemRecord record = new ScreenCustomFieldListitemRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.CfieldId = this.CfieldId;
            record.IdValue = this.IdValue;
            record.Text = this.Text;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ScreenCustomFieldListitemRecord" /> instance is equal to another <see cref="ScreenCustomFieldListitemRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ScreenCustomFieldListitemRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ScreenCustomFieldListitemRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.CfieldId == that.CfieldId);
            result = result && (this.IdValue.TrimOrNullify() == that.IdValue.TrimOrNullify());
            result = result && (this.Text.TrimOrNullify() == that.Text.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
