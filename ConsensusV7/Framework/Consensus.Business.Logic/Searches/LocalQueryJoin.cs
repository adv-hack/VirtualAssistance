using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class LocalQueryJoin : LocalQuerySource, QueryJoin, IQueryJoinableOn, IQueryJoinableAnd
    {
        #region fields

        /// <summary>
        ///    The ordinal number of the join. 
        /// </summary>
        private Int32 _ordinal;

        /// <summary>
        ///     The query model that the join belongs to.
        /// </summary>
        private LocalQueryModel _queryModel;

        /// <summary>
        ///     The conditions for the join.
        /// </summary>
        private List<LocalQueryCondition> _conditions;

        /// <summary>
        ///     The type of the join.
        /// </summary>
        private QueryJoinTypes _type;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the ordinal number of the join. 
        /// </summary>
        public Int32 Ordinal
        {
            get { return _ordinal; }
            set { _ordinal = value; }
        }

        /// <summary>
        ///    Gets the query model that the join belongs to.
        /// </summary>
        protected LocalQueryModel QueryModel
        {
            get { return _queryModel; }
        }

        /// <summary>
        ///    Gets or sets the conditions for the join.
        /// </summary>
        public List<LocalQueryCondition> Conditions
        {
            get
            {
                if (_conditions == null)
                    _conditions = new List<LocalQueryCondition>();

                return _conditions;
            }
        }

        /// <summary>
        ///    Gets or sets the type of the join.
        /// </summary>
        public QueryJoinTypes Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     Gets the SQL for this query element
        /// </summary>
        internal override String Sql
        {
            get
            {
                String sourceName = String.Format(this.Source < 0 ? "{0}" : "vConsensus{0}", this.Source);

                String returnValue = String.Empty;
                foreach (LocalQueryCondition condition in this.Conditions)
                    returnValue += (String.IsNullOrEmpty(returnValue) ? " on " : " and ") + condition.Sql;

                return String.Format(String.IsNullOrEmpty(this.Alias) ? " {0} join [{1}] " : " {0} join [{1}] as [{2}] ", this.Type, sourceName, this.Alias) + returnValue + Environment.NewLine;
            }
        }

        #endregion

        #region constructor

        public LocalQueryJoin(LocalQueryModel queryModel)
        {
            _queryModel = queryModel;
        }

        #endregion

        #region implementations

        QuerySources QuerySource.Source
        {
            get { return this.Source; }
        }

        String QuerySource.Alias
        {
            get { return this.Alias; }
        }

        QueryJoinTypes QueryJoin.Type
        {
            get { return this.Type; }
        }

        QueryCondition[] QueryJoin.Conditions
        {
            get { return this.Conditions.ToArray(); }
        }

        IQueryJoinableAnd IQueryJoinableOn.On(String correlation, QueryConditionTypes type, Object value)
        {
            return this.AddConditionValue(correlation, type, value);
        }

        IQueryJoinableAnd IQueryJoinableAnd.And(String correlation, QueryConditionTypes type, Object value)
        {
            return this.AddConditionValue(correlation, type, value);
        }

        IQueryJoinableAnd IQueryJoinableOn.OnCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation)
        {
            return this.AddConditionCorrelation(correlation, type, matchCorrelation);
        }

        IQueryJoinableAnd IQueryJoinableAnd.AndCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation)
        {
            return this.AddConditionCorrelation(correlation, type, matchCorrelation);
        }

        IQueryJoinableOn IQueryJoinable.Join(QuerySources source)
        {
            return this.QueryModel.Join(QueryJoinTypes.Inner, source, null);
        }

        IQueryJoinableOn IQueryJoinable.Join(QuerySources source, String alias)
        {
            return this.QueryModel.Join(QueryJoinTypes.Inner, source, alias);
        }

        IQueryJoinableOn IQueryJoinable.Join(QueryJoinTypes type, QuerySources source)
        {
            return this.QueryModel.Join(type, source, null);
        }

        IQueryJoinableOn IQueryJoinable.Join(QueryJoinTypes type, QuerySources source, String alias)
        {
            return this.QueryModel.Join(type, source, alias);
        }

        IQueryConditionableAnd IQueryConditionable.Where(String correlation, QueryConditionTypes type, Object value)
        {
            return this.QueryModel.AddConditionValue(correlation, type, value);
        }

        IQueryConditionableAnd IQueryConditionable.WhereRaw(String sql, Object value)
        {
            return this.QueryModel.AddConditionRaw(sql, value);
        }


        IQueryConditionableAnd IQueryConditionable.WhereCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation)
        {
            return this.QueryModel.AddConditionCorrelation(correlation, type, matchCorrelation);
        }

        IQueryOrderableAnd IQueryOrderable.OrderBy(String correlation)
        {
            return this.QueryModel.OrderBy(correlation, true);
        }

        IQueryOrderableAnd IQueryOrderable.OrderBy(String correlation, Boolean ascending)
        {
            return this.QueryModel.OrderBy(correlation, ascending);
        }

        Dictionary<String, Object>[] ISearchesRunnable.Run()
        {
            return this.QueryModel.RunQuery();
        }

        object IRunnable.Run()
        {
            return this.QueryModel.RunQuery();
        }

        IDictionary<string, object> ISearchesRunnable.Serialize()
        {
            return this.QueryModel.RunSerialize();
        }

        #endregion

        #region methods

        internal IQueryJoinableAnd AddConditionValue(String correlation, QueryConditionTypes type, Object value)
        {
            LocalQueryConditionValue condition = new LocalQueryConditionValue();
            condition.Correlation = correlation;
            condition.Type = type;
            condition.Value = value;
            condition.Ordinal = this.Conditions.Count + 1;
            condition.ParameterPrefix = String.Concat("join", this.Ordinal, "param");
            this.Conditions.Add(condition);
            return this;
        }

        internal IQueryJoinableAnd AddConditionCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation)
        {
            LocalQueryConditionCorrelation condition = new LocalQueryConditionCorrelation();
            condition.Correlation = correlation;
            condition.Type = type;
            condition.MatchCorrelation = matchCorrelation;
            condition.Ordinal = this.Conditions.Count + 1;
            this.Conditions.Add(condition);
            return this;
        }

        #endregion


    }
}
