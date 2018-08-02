using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Represents the "PortalUserRole" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PortaluserroleRecord : Record<Int32>, Cloneable<PortaluserroleRecord>, IEquatable<PortaluserroleRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PUR_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "PUR_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PUR_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "PUR_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PUR_PU_ID" field.
        /// </summary>
        private Int32 _puId;

        /// <summary>
        ///     the value of the "PUR_PR_ID" field.
        /// </summary>
        private Int32 _prId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PUR_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PUR_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PUR_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PUR_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PUR_PU_ID" field.
        /// </summary>
        public Int32 PuId
        {
            get { return _puId; }
            set { _puId = value; }
        }

        /// <summary>
        ///     the value of the "PUR_PR_ID" field.
        /// </summary>
        public Int32 PrId
        {
            get { return _prId; }
            set { _prId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PortaluserroleRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PortaluserroleRecord" /> object instance.
        /// </returns>
        public PortaluserroleRecord Clone()
        {
            PortaluserroleRecord record = new PortaluserroleRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.PuId = this.PuId;
            record.PrId = this.PrId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PortaluserroleRecord" /> instance is equal to another <see cref="PortaluserroleRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PortaluserroleRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PortaluserroleRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PuId == that.PuId);
            result = result && (this.PrId == that.PrId);
            return result;
        }

        #endregion
    }
}
