using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Represents the "ACT_LINK_XREF" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ActLinkXrefRecord : Record<String>, Cloneable<ActLinkXrefRecord>, IEquatable<ActLinkXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ACTLINK_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ACTLINK_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ACTLINK_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ACTLINK_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ACTLINK_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ACTLINK_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        private String _actId;

        /// <summary>
        ///     the value of the "ACTLINK_TABLE_NUM" field.
        /// </summary>
        private Double? _tableNum;

        /// <summary>
        ///     the value of the "ACTLINK_REC_ID" field.
        /// </summary>
        private String _recId;

        /// <summary>
        ///     the value of the "ACTLINK_BOM_ID" field.
        /// </summary>
        private String _bomId;

        /// <summary>
        ///     the value of the "ACTLINK_TEXT" field.
        /// </summary>
        private String _text;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ACTLINK_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ACTLINK_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ACTLINK_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ACTLINK_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ACTLINK_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ACTLINK_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        public String ActId
        {
            get { return _actId; }
            set { _actId = value; }
        }

        /// <summary>
        ///     the value of the "ACTLINK_TABLE_NUM" field.
        /// </summary>
        public Double? TableNum
        {
            get { return _tableNum; }
            set { _tableNum = value; }
        }

        /// <summary>
        ///     the value of the "ACTLINK_REC_ID" field.
        /// </summary>
        public String RecId
        {
            get { return _recId; }
            set { _recId = value; }
        }

        /// <summary>
        ///     the value of the "ACTLINK_BOM_ID" field.
        /// </summary>
        public String BomId
        {
            get { return _bomId; }
            set { _bomId = value; }
        }

        /// <summary>
        ///     the value of the "ACTLINK_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ActLinkXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ActLinkXrefRecord" /> object instance.
        /// </returns>
        public ActLinkXrefRecord Clone()
        {
            ActLinkXrefRecord record = new ActLinkXrefRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.ActId = this.ActId;
            record.TableNum = this.TableNum;
            record.RecId = this.RecId;
            record.BomId = this.BomId;
            record.Text = this.Text;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ActLinkXrefRecord" /> instance is equal to another <see cref="ActLinkXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ActLinkXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ActLinkXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.ActId.TrimOrNullify() == that.ActId.TrimOrNullify());
            result = result && (this.TableNum == that.TableNum);
            result = result && (this.RecId.TrimOrNullify() == that.RecId.TrimOrNullify());
            result = result && (this.BomId.TrimOrNullify() == that.BomId.TrimOrNullify());
            result = result && (this.Text.TrimOrNullify() == that.Text.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
