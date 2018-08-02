using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "Screen_Custom_Field_Type" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ScreenCustomFieldTypeRecord : Record<String>, Cloneable<ScreenCustomFieldTypeRecord>, IEquatable<ScreenCustomFieldTypeRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CFTYPE_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "CFTYPE_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "CFTYPE_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "CFTYPE_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "CFTYPE_NAME" field.
        /// </summary>
        private String _name;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CFTYPE_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "CFTYPE_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "CFTYPE_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "CFTYPE_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "CFTYPE_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ScreenCustomFieldTypeRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ScreenCustomFieldTypeRecord" /> object instance.
        /// </returns>
        public ScreenCustomFieldTypeRecord Clone()
        {
            ScreenCustomFieldTypeRecord record = new ScreenCustomFieldTypeRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.Name = this.Name;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ScreenCustomFieldTypeRecord" /> instance is equal to another <see cref="ScreenCustomFieldTypeRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ScreenCustomFieldTypeRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ScreenCustomFieldTypeRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
