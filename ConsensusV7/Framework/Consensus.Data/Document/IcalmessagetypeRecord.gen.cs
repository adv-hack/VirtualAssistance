using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "ICalMessageType" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class IcalmessagetypeRecord : Record<Int32>, Cloneable<IcalmessagetypeRecord>, IEquatable<IcalmessagetypeRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ICMT_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ICMT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ICMT_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ICMT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ICMT_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "ICMT_VIEW" field.
        /// </summary>
        private String _view;

        /// <summary>
        ///     the value of the "ICMT_PROC" field.
        /// </summary>
        private String _proc;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ICMT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ICMT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ICMT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ICMT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ICMT_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "ICMT_VIEW" field.
        /// </summary>
        public String View
        {
            get { return _view; }
            set { _view = value; }
        }

        /// <summary>
        ///     the value of the "ICMT_PROC" field.
        /// </summary>
        public String Proc
        {
            get { return _proc; }
            set { _proc = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="IcalmessagetypeRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="IcalmessagetypeRecord" /> object instance.
        /// </returns>
        public IcalmessagetypeRecord Clone()
        {
            IcalmessagetypeRecord record = new IcalmessagetypeRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.Name = this.Name;
            record.View = this.View;
            record.Proc = this.Proc;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="IcalmessagetypeRecord" /> instance is equal to another <see cref="IcalmessagetypeRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="IcalmessagetypeRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(IcalmessagetypeRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.View.TrimOrNullify() == that.View.TrimOrNullify());
            result = result && (this.Proc.TrimOrNullify() == that.Proc.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
