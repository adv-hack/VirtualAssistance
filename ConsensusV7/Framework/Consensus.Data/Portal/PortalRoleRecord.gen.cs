using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Represents the "PORTAL_ROLE" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PortalRoleRecord : Record<Int32>, Cloneable<PortalRoleRecord>, IEquatable<PortalRoleRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PR_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PR_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PR_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PR_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PR_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PR_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PR_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "PR_CREATE" field.
        /// </summary>
        private String _create;

        /// <summary>
        ///     the value of the "PR_READ" field.
        /// </summary>
        private String _read;

        /// <summary>
        ///     the value of the "PR_UPDATE" field.
        /// </summary>
        private String _update;

        /// <summary>
        ///     the value of the "PR_DELETE" field.
        /// </summary>
        private String _delete;

        /// <summary>
        ///     the value of the "PR_IMP_PR_ID" field.
        /// </summary>
        private Int32? _impPrId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PR_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PR_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PR_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PR_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PR_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PR_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PR_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "PR_CREATE" field.
        /// </summary>
        public String Create
        {
            get { return _create; }
            set { _create = value; }
        }

        /// <summary>
        ///     the value of the "PR_READ" field.
        /// </summary>
        public String Read
        {
            get { return _read; }
            set { _read = value; }
        }

        /// <summary>
        ///     the value of the "PR_UPDATE" field.
        /// </summary>
        public String Update
        {
            get { return _update; }
            set { _update = value; }
        }

        /// <summary>
        ///     the value of the "PR_DELETE" field.
        /// </summary>
        public String Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }

        /// <summary>
        ///     the value of the "PR_IMP_PR_ID" field.
        /// </summary>
        public Int32? ImpPrId
        {
            get { return _impPrId; }
            set { _impPrId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PortalRoleRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PortalRoleRecord" /> object instance.
        /// </returns>
        public PortalRoleRecord Clone()
        {
            PortalRoleRecord record = new PortalRoleRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Title = this.Title;
            record.Create = this.Create;
            record.Read = this.Read;
            record.Update = this.Update;
            record.Delete = this.Delete;
            record.ImpPrId = this.ImpPrId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PortalRoleRecord" /> instance is equal to another <see cref="PortalRoleRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PortalRoleRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PortalRoleRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.Create.TrimOrNullify() == that.Create.TrimOrNullify());
            result = result && (this.Read.TrimOrNullify() == that.Read.TrimOrNullify());
            result = result && (this.Update.TrimOrNullify() == that.Update.TrimOrNullify());
            result = result && (this.Delete.TrimOrNullify() == that.Delete.TrimOrNullify());
            result = result && (this.ImpPrId == that.ImpPrId);
            return result;
        }

        #endregion
    }
}
