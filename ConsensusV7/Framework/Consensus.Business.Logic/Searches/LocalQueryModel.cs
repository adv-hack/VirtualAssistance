using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class LocalQueryModel : LocalModel, QueryModel, IQuerySourceable, IQueryJoinable, IQueryConditionableAnd, IQueryOrderableAnd
    {
        #region fields

        /// <summary>
        ///     Specifies the maximum number of records to be returned.
        /// </summary>
        private Int32? _top;

        /// <summary>
        ///     Specifies whether only distinct results are returned.
        /// </summary>
        private Boolean _distinct;

        /// <summary>
        ///     The collection of selections for the query.
        /// </summary>
        private List<LocalQuerySelect> _selects;

        /// <summary>
        ///     The source of the query
        /// </summary>
        private LocalQuerySource _source;

        /// <summary>
        ///     The collection of joins for the query.
        /// </summary>
        private List<LocalQueryJoin> _joins;

        /// <summary>
        ///     The collection of conditions for the query.
        /// </summary>
        private List<LocalQueryCondition> _wheres;

        /// <summary>
        ///     The collection of sort orders for the query.
        /// </summary>
        private List<LocalQueryOrder> _orders;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the the maximum number of records to be returned.
        /// </summary>
        public Int32? Top
        {
            get { return _top; }
            set { _top = value; }
        }

        /// <summary>
        ///    Gets or sets whether only distinct results are returned. 
        /// </summary>
        public Boolean Distinct
        {
            get { return _distinct; }
            set { _distinct = value; }
        }

        /// <summary>
        ///    Gets the collection of selections for the query.
        /// </summary>
        public List<LocalQuerySelect> Selects
        {
            get
            {
                if (_selects == null)
                    _selects = new List<LocalQuerySelect>();

                return _selects;
            }
            set
            {
                _selects = value;
            }
        }

        /// <summary>
        ///    Gets or sets the source of the query
        /// </summary>
        public LocalQuerySource Source
        {
            get { return _source; }
            set { _source = value; }
        }

        /// <summary>
        ///    Gets the collection of joins for the query.
        /// </summary>
        public List<LocalQueryJoin> Joins
        {
            get
            {
                if (_joins == null)
                    _joins = new List<LocalQueryJoin>();

                return _joins;
            }
            set
            {
                _joins = value;
            }
        }

        /// <summary>
        ///    Gets the collection of conditions for the query.
        /// </summary>
        public List<LocalQueryCondition> Wheres
        {
            get
            {
                if (_wheres == null)
                    _wheres = new List<LocalQueryCondition>();

                return _wheres;
            }
            set
            {
                _wheres = value;
            }
        }

        /// <summary>
        ///    Gets the collection of sort orders for the query.
        /// </summary>
        public List<LocalQueryOrder> Orders
        {
            get
            {
                if (_orders == null)
                    _orders = new List<LocalQueryOrder>();

                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

        public override Boolean IsPersisted
        {
            get { return false; }
        }

        public override Boolean IsModified
        {
            get { return true; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalQueryModel" /> instance.
        /// </summary>
        public LocalQueryModel(LocalProvider provider) : base(provider)
        {

        }

        #endregion

        #region implementations

        Int32? QueryModel.Top
        {
            get { return this.Top; }
            set { this.Top = value; }
        }

        Boolean QueryModel.Distinct
        {
            get { return this.Distinct; }
            set { this.Distinct = value; }
        }

        QuerySelection[] QueryModel.Selects
        {
            get { return this.Selects.ToArray(); }
            set { this.Selects = value.OfType<LocalQuerySelect>().ToList(); }
        }

        QuerySource QueryModel.Source
        {
            get { return this.Source; }
            set { this.Source = value as LocalQuerySource; }
        }

        QueryJoin[] QueryModel.Joins
        {
            get { return this.Joins.ToArray(); }
            set { this.Joins = value.OfType<LocalQueryJoin>().ToList(); }
        }

        QueryCondition[] QueryModel.Wheres
        {
            get { return this.Wheres.ToArray(); }
            set { this.Wheres = value.OfType<LocalQueryCondition>().ToList(); }
        }

        QueryOrder[] QueryModel.Orders
        {
            get { return this.Orders.ToArray(); }
            set { this.Orders = value.OfType<LocalQueryOrder>().ToList(); }
        }

        IQuerySourceable IQuerySelectable.Select(String column)
        {
            return this.Select(column);
        }

        IQuerySourceable IQuerySelectable.Select(String column, String alias)
        {
            return this.Select(column, alias);
        }

        IQueryJoinable IQuerySourceable.From(QuerySources source)
        {
            return this.From(source);
        }

        IQueryJoinable IQuerySourceable.From(QuerySources source, String alias)
        {
            return this.From(source, alias);
        }

        IQueryJoinableOn IQueryJoinable.Join(QuerySources source)
        {
            return this.Join(QueryJoinTypes.Inner, source, null);
        }

        IQueryJoinableOn IQueryJoinable.Join(QuerySources source, String alias)
        {
            return this.Join(QueryJoinTypes.Inner, source, alias);
        }

        IQueryJoinableOn IQueryJoinable.Join(QueryJoinTypes type, QuerySources source)
        {
            return this.Join(type, source, null);
        }

        IQueryJoinableOn IQueryJoinable.Join(QueryJoinTypes type, QuerySources source, String alias)
        {
            return this.Join(type, source, alias);
        }

        IQueryConditionableAnd IQueryConditionable.Where(String correlation, QueryConditionTypes type, Object value)
        {
            return this.AddConditionValue(correlation, type, value);
        }

        IQueryConditionableAnd IQueryConditionable.WhereCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation)
        {
            return this.AddConditionCorrelation(correlation, type, matchCorrelation);
        }

        IQueryConditionableAnd IQueryConditionable.WhereRaw(String sql, Object value)
        {
            return this.AddConditionRaw(sql, value);
        }

        IQueryConditionableAnd IQueryConditionableAnd.And(String correlation, QueryConditionTypes type, Object value)
        {
            return this.AddConditionValue(correlation, type, value);
        }

        IQueryConditionableAnd IQueryConditionableAnd.AndCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation)
        {
            return this.AddConditionCorrelation(correlation, type, matchCorrelation);
        }

        IQueryConditionableAnd IQueryConditionableAnd.AndRaw(String sql, Object value)
        {
            return this.AddConditionRaw(sql, value);
        }

        IQueryOrderableAnd IQueryOrderable.OrderBy(String correlation)
        {
            return this.OrderBy(correlation, true);
        }

        IQueryOrderableAnd IQueryOrderable.OrderBy(String correlation, Boolean ascending)
        {
            return this.OrderBy(correlation, ascending);
        }

        IQueryOrderableAnd IQueryOrderableAnd.ThenBy(String correlation)
        {
            return this.OrderBy(correlation, true);
        }

        IQueryOrderableAnd IQueryOrderableAnd.ThenBy(String correlation, Boolean ascending)
        {
            return this.OrderBy(correlation, ascending);
        }

        Dictionary<String, Object>[] ISearchesRunnable.Run()
        {
            return this.RunQuery();
        }
        object IRunnable.Run()
        {
            return this.RunQuery();
        }

        IDictionary<string, object> ISearchesRunnable.Serialize()
        {
            return this.RunSerialize();
        }

        #endregion

        #region methods

        internal IQuerySourceable Select(String column)
        {
            return this.Select(column, null);
        }

        internal IQuerySourceable Select(String column, String alias)
        {
            LocalQuerySelect select = new LocalQuerySelect();
            select.Column = column;
            select.Alias = alias;

            this.Selects.Add(select);
            return this;
        }

        internal IQueryJoinable From(QuerySources source)
        {
            return this.From(source, null);
        }

        internal IQueryJoinable From(QuerySources source, String alias)
        {
            this.Source = new LocalQuerySource();
            this.Source.Source = source;
            this.Source.Alias = alias;
            return this;
        }

        internal IQueryJoinableOn Join(QueryJoinTypes type, QuerySources source, String alias)
        {
            LocalQueryJoin join = new LocalQueryJoin(this);
            join.Type = type;
            join.Source = source;
            join.Alias = alias;
            join.Ordinal = this.Joins.Count + 1;
            this.Joins.Add(join);
            return join;
        }

        internal IQueryConditionableAnd AddConditionValue(String correlation, QueryConditionTypes type, Object value)
        {
            LocalQueryConditionValue condition = new LocalQueryConditionValue();
            condition.Correlation = correlation;
            condition.Type = type;
            condition.Value = value;
            condition.Ordinal = this.Wheres.Count + 1;
            condition.ParameterPrefix = "param";
            this.Wheres.Add(condition);
            return this;
        }

        internal IQueryConditionableAnd AddConditionCorrelation(String correlation, QueryConditionTypes type, String matchCorrelation)
        {
            LocalQueryConditionCorrelation condition = new LocalQueryConditionCorrelation();
            condition.Correlation = correlation;
            condition.Type = type;
            condition.MatchCorrelation = matchCorrelation;
            condition.Ordinal = this.Wheres.Count + 1;
            this.Wheres.Add(condition);
            return this;
        }

        internal IQueryConditionableAnd AddConditionRaw(String rawlSql, Object value)
        {
            LocalQueryConditionRaw condition = new LocalQueryConditionRaw();
            condition.RawCondition = rawlSql;
            condition.Value = value;
            condition.Ordinal = this.Wheres.Count + 1;
            condition.ParameterPrefix = "param";
            this.Wheres.Add(condition);
            return this;
        }

        internal IQueryOrderableAnd OrderBy(String correlation, Boolean ascending)
        {
            LocalQueryOrder order = new LocalQueryOrder();
            order.Correlation = correlation;
            order.Ascending = ascending;

            this.Orders.Add(order);
            return this;
        }

        internal Dictionary<String, Object>[] RunQuery()
        {
            StringBuilder selectBuilder = new StringBuilder();
            this.Selects.Execute(s => selectBuilder.Append((selectBuilder.Length == 0 ? " " : ", ") + s.Sql));

            StringBuilder whereBuilder = new StringBuilder();
            this.Wheres.Execute(w => whereBuilder.Append((whereBuilder.Length == 0 ? " where " : " and ") + w.Sql));

            StringBuilder joinBuilder = new StringBuilder();
            this.Joins.Execute(j => joinBuilder.Append(j.Sql + " "));

            StringBuilder orderBuilder = new StringBuilder();
            this.Orders.Execute(o => orderBuilder.Append((orderBuilder.Length == 0 ? " order by " : ", ") + o.Sql));
            
            // Construct the SQL statement from its elements
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select");
            sqlBuilder.Append(this.Distinct ? " distinct" : "");
            sqlBuilder.Append(this.Top != null ? " top " + this.Top.ToString() : "");
            sqlBuilder.Append(selectBuilder.ToString());
            sqlBuilder.Append(this.Source.Sql);
            sqlBuilder.Append(joinBuilder.ToString());
            sqlBuilder.Append(whereBuilder.ToString());
            sqlBuilder.Append(orderBuilder.ToString());

            // Construct the dictionary of parameters
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            foreach (LocalQueryConditionValue whereCondition in this.Wheres.OfType<LocalQueryConditionValue>())
                parameters.Add(whereCondition.ParameterName, whereCondition.Value);
            foreach (LocalQueryConditionValue joinCondition in this.Joins.SelectMany(join => join.Conditions.OfType<LocalQueryConditionValue>()))
                parameters.Add(joinCondition.ParameterName, joinCondition.Value);

            return this.Provider.DataProvider.ExecuteQuery(sqlBuilder.ToString(), parameters);
        }

        public override void Save()
        {
            throw new NotSupportedException();
        }

        public override void Delete()
        {
            throw new NotSupportedException();
        }

        internal IDictionary<string, object> RunSerialize()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();

            result.Add("Distinct", this.Distinct);
            result.Add("Top", this.Top);
            result.Add("Source", this.Source);
            result.Add("Selects", this.Selects);
            result.Add("Joins", this.Joins);
            result.Add("Wheres", this.Wheres);
            result.Add("Orders", this.Orders);

            return result;
        }

        #endregion
    }
}
