using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Represents the "PU_SITE" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PuSiteRecord : Record<Int32>, Cloneable<PuSiteRecord>, IEquatable<PuSiteRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PUSTE_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "PUSTE_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PUSTE_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "PUSTE_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PUSTE_RCV_DATE" field.
        /// </summary>
        private DateTime _rcvDate;

        /// <summary>
        ///     the value of the "PUSTE_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PUSTE_PU_ID" field.
        /// </summary>
        private Int32? _puId;

        /// <summary>
        ///     the value of the "PUSTE_PS_ID" field.
        /// </summary>
        private Int32? _psId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PUSTE_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PUSTE_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PUSTE_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PUSTE_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PUSTE_RCV_DATE" field.
        /// </summary>
        public DateTime RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PUSTE_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PUSTE_PU_ID" field.
        /// </summary>
        public Int32? PuId
        {
            get { return _puId; }
            set { _puId = value; }
        }

        /// <summary>
        ///     the value of the "PUSTE_PS_ID" field.
        /// </summary>
        public Int32? PsId
        {
            get { return _psId; }
            set { _psId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PuSiteRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PuSiteRecord" /> object instance.
        /// </returns>
        public PuSiteRecord Clone()
        {
            PuSiteRecord record = new PuSiteRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.PuId = this.PuId;
            record.PsId = this.PsId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PuSiteRecord" /> instance is equal to another <see cref="PuSiteRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PuSiteRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PuSiteRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PuId == that.PuId);
            result = result && (this.PsId == that.PsId);
            return result;
        }

        #endregion
    }
}
