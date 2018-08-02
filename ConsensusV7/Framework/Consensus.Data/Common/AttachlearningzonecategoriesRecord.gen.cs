using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "AttachLearningZoneCategories" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class AttachlearningzonecategoriesRecord : Record<Int32>, Cloneable<AttachlearningzonecategoriesRecord>, IEquatable<AttachlearningzonecategoriesRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ATTLZC_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "ATTLZC_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ATTLZC_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "ATTLZC_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        private String _attId;

        /// <summary>
        ///     the value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        private Int32 _lzcId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ATTLZC_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ATTLZC_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ATTLZC_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ATTLZC_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        public String AttId
        {
            get { return _attId; }
            set { _attId = value; }
        }

        /// <summary>
        ///     the value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        public Int32 LzcId
        {
            get { return _lzcId; }
            set { _lzcId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="AttachlearningzonecategoriesRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="AttachlearningzonecategoriesRecord" /> object instance.
        /// </returns>
        public AttachlearningzonecategoriesRecord Clone()
        {
            AttachlearningzonecategoriesRecord record = new AttachlearningzonecategoriesRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.AttId = this.AttId;
            record.LzcId = this.LzcId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="AttachlearningzonecategoriesRecord" /> instance is equal to another <see cref="AttachlearningzonecategoriesRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="AttachlearningzonecategoriesRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(AttachlearningzonecategoriesRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.AttId.TrimOrNullify() == that.AttId.TrimOrNullify());
            result = result && (this.LzcId == that.LzcId);
            return result;
        }

        #endregion
    }
}
