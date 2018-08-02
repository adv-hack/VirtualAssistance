using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Represents the "MEMBER_BOM" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class MemberBomRecord : Record<String>, Cloneable<MemberBomRecord>, IEquatable<MemberBomRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "MBOM_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "MBOM_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "MBOM_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "MBOM_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "MBOM_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "MBOM_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "MBOM_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "MBOM_PARENT_ID" field.
        /// </summary>
        private String _parentId;

        /// <summary>
        ///     the value of the "MBOM_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "MBOM_GRADE_ID" field.
        /// </summary>
        private String _gradeId;

        /// <summary>
        ///     the value of the "MBOM_MAIN" field.
        /// </summary>
        private Byte? _main;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "MBOM_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "MBOM_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "MBOM_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "MBOM_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "MBOM_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "MBOM_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "MBOM_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "MBOM_PARENT_ID" field.
        /// </summary>
        public String ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
        }

        /// <summary>
        ///     the value of the "MBOM_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "MBOM_GRADE_ID" field.
        /// </summary>
        public String GradeId
        {
            get { return _gradeId; }
            set { _gradeId = value; }
        }

        /// <summary>
        ///     the value of the "MBOM_MAIN" field.
        /// </summary>
        public Byte? Main
        {
            get { return _main; }
            set { _main = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="MemberBomRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="MemberBomRecord" /> object instance.
        /// </returns>
        public MemberBomRecord Clone()
        {
            MemberBomRecord record = new MemberBomRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.ParentId = this.ParentId;
            record.ProdId = this.ProdId;
            record.GradeId = this.GradeId;
            record.Main = this.Main;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="MemberBomRecord" /> instance is equal to another <see cref="MemberBomRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="MemberBomRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(MemberBomRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.ParentId.TrimOrNullify() == that.ParentId.TrimOrNullify());
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.GradeId.TrimOrNullify() == that.GradeId.TrimOrNullify());
            result = result && (this.Main == that.Main);
            return result;
        }

        #endregion
    }
}
