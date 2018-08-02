using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Represents the "Workflow_Rec_Type" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class WorkflowRecTypeRecord : Record<String>, Cloneable<WorkflowRecTypeRecord>, IEquatable<WorkflowRecTypeRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "WRT_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "WRT_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "WRT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "WRT_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "WRT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "WRT_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "WRT_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "WRT_REC_TYPE" field.
        /// </summary>
        private String _recType;

        /// <summary>
        ///     the value of the "WRT_DESC" field.
        /// </summary>
        private String _desc;

        /// <summary>
        ///     the value of the "WRT_TABLE" field.
        /// </summary>
        private String _table;

        /// <summary>
        ///     the value of the "WRT_TABLE_KEY" field.
        /// </summary>
        private String _tableKey;

        /// <summary>
        ///     the value of the "WRT_SQL" field.
        /// </summary>
        private String _sql;

        /// <summary>
        ///     the value of the "WRT_PR_TYPE" field.
        /// </summary>
        private String _prType;

        /// <summary>
        ///     the value of the "WRT_SEARCH_ENTITY" field.
        /// </summary>
        private String _searchEntity;

        /// <summary>
        ///     the value of the "WRT_LINK_TO" field.
        /// </summary>
        private String _linkTo;

        /// <summary>
        ///     the value of the "WRT_PR_TYPE_TYPE" field.
        /// </summary>
        private String _prTypeType;

        /// <summary>
        ///     the value of the "WRT_QUERY" field.
        /// </summary>
        private Byte? _query;

        /// <summary>
        ///     the value of the "WRT_QUERY_SELECT" field.
        /// </summary>
        private String _querySelect;

        /// <summary>
        ///     the value of the "WRT_QUERY_MERGE" field.
        /// </summary>
        private String _queryMerge;

        /// <summary>
        ///     the value of the "WRT_ACT_TYPES" field.
        /// </summary>
        private String _actTypes;

        /// <summary>
        ///     the value of the "WRT_PR_ARG" field.
        /// </summary>
        private Byte _prArg;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "WRT_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "WRT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "WRT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "WRT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "WRT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "WRT_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "WRT_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "WRT_REC_TYPE" field.
        /// </summary>
        public String RecType
        {
            get { return _recType; }
            set { _recType = value; }
        }

        /// <summary>
        ///     the value of the "WRT_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        ///     the value of the "WRT_TABLE" field.
        /// </summary>
        public String Table
        {
            get { return _table; }
            set { _table = value; }
        }

        /// <summary>
        ///     the value of the "WRT_TABLE_KEY" field.
        /// </summary>
        public String TableKey
        {
            get { return _tableKey; }
            set { _tableKey = value; }
        }

        /// <summary>
        ///     the value of the "WRT_SQL" field.
        /// </summary>
        public String Sql
        {
            get { return _sql; }
            set { _sql = value; }
        }

        /// <summary>
        ///     the value of the "WRT_PR_TYPE" field.
        /// </summary>
        public String PrType
        {
            get { return _prType; }
            set { _prType = value; }
        }

        /// <summary>
        ///     the value of the "WRT_SEARCH_ENTITY" field.
        /// </summary>
        public String SearchEntity
        {
            get { return _searchEntity; }
            set { _searchEntity = value; }
        }

        /// <summary>
        ///     the value of the "WRT_LINK_TO" field.
        /// </summary>
        public String LinkTo
        {
            get { return _linkTo; }
            set { _linkTo = value; }
        }

        /// <summary>
        ///     the value of the "WRT_PR_TYPE_TYPE" field.
        /// </summary>
        public String PrTypeType
        {
            get { return _prTypeType; }
            set { _prTypeType = value; }
        }

        /// <summary>
        ///     the value of the "WRT_QUERY" field.
        /// </summary>
        public Byte? Query
        {
            get { return _query; }
            set { _query = value; }
        }

        /// <summary>
        ///     the value of the "WRT_QUERY_SELECT" field.
        /// </summary>
        public String QuerySelect
        {
            get { return _querySelect; }
            set { _querySelect = value; }
        }

        /// <summary>
        ///     the value of the "WRT_QUERY_MERGE" field.
        /// </summary>
        public String QueryMerge
        {
            get { return _queryMerge; }
            set { _queryMerge = value; }
        }

        /// <summary>
        ///     the value of the "WRT_ACT_TYPES" field.
        /// </summary>
        public String ActTypes
        {
            get { return _actTypes; }
            set { _actTypes = value; }
        }

        /// <summary>
        ///     the value of the "WRT_PR_ARG" field.
        /// </summary>
        public Byte PrArg
        {
            get { return _prArg; }
            set { _prArg = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="WorkflowRecTypeRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="WorkflowRecTypeRecord" /> object instance.
        /// </returns>
        public WorkflowRecTypeRecord Clone()
        {
            WorkflowRecTypeRecord record = new WorkflowRecTypeRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.RecType = this.RecType;
            record.Desc = this.Desc;
            record.Table = this.Table;
            record.TableKey = this.TableKey;
            record.Sql = this.Sql;
            record.PrType = this.PrType;
            record.SearchEntity = this.SearchEntity;
            record.LinkTo = this.LinkTo;
            record.PrTypeType = this.PrTypeType;
            record.Query = this.Query;
            record.QuerySelect = this.QuerySelect;
            record.QueryMerge = this.QueryMerge;
            record.ActTypes = this.ActTypes;
            record.PrArg = this.PrArg;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="WorkflowRecTypeRecord" /> instance is equal to another <see cref="WorkflowRecTypeRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="WorkflowRecTypeRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(WorkflowRecTypeRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.RecType.TrimOrNullify() == that.RecType.TrimOrNullify());
            result = result && (this.Desc.TrimOrNullify() == that.Desc.TrimOrNullify());
            result = result && (this.Table.TrimOrNullify() == that.Table.TrimOrNullify());
            result = result && (this.TableKey.TrimOrNullify() == that.TableKey.TrimOrNullify());
            result = result && (this.Sql.TrimOrNullify() == that.Sql.TrimOrNullify());
            result = result && (this.PrType.TrimOrNullify() == that.PrType.TrimOrNullify());
            result = result && (this.SearchEntity.TrimOrNullify() == that.SearchEntity.TrimOrNullify());
            result = result && (this.LinkTo.TrimOrNullify() == that.LinkTo.TrimOrNullify());
            result = result && (this.PrTypeType.TrimOrNullify() == that.PrTypeType.TrimOrNullify());
            result = result && (this.Query == that.Query);
            result = result && (this.QuerySelect.TrimOrNullify() == that.QuerySelect.TrimOrNullify());
            result = result && (this.QueryMerge.TrimOrNullify() == that.QueryMerge.TrimOrNullify());
            result = result && (this.ActTypes.TrimOrNullify() == that.ActTypes.TrimOrNullify());
            result = result && (this.PrArg == that.PrArg);
            return result;
        }

        #endregion
    }
}
