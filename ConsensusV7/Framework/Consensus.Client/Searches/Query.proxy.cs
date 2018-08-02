using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class Query : Proxy<QueryModel>, QueryModel
    {
        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="Query" /> instance.
        /// </summary>
        public Query(QueryModel model) : base(model)
        {

        }

        #endregion

        #region methods

        public static Query Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Query.Create(site);
        }

        public static Query Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            QueryModel model = provider.Searches.Query.Create();
            return model == null ? null : new Query(model);
        }

        public IQuerySourceable Select(String column)
        {
            return this.Model.Select(column);
        }

        public IQuerySourceable Select(String column, String alias)
        {
            return this.Model.Select(column, alias);
        }

        public static Dictionary<String, Object>[] Execute(Query query)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Query.Execute(site, query);
        }

        public static Dictionary<String, Object>[] Execute(ConsensusSite site, Query query)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Dictionary<String, Object>[] result = provider.Searches.Query.Execute(query.Model);
            return result;
        }

        public static ISearchesRunnable Deserialize(IDictionary<string, object> dictionary)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Query.Deserialize(site, dictionary);
        }

        public static ISearchesRunnable Deserialize(ConsensusSite site, IDictionary<string, object> dictionary)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Searches.Query.Deserialize(dictionary);
        }

        public IDictionary<string, object> Serialize()
        {
            if (this.Model is ISearchesRunnable)
                return ((ISearchesRunnable)this.Model).Serialize();
            else
                return null;
        }
        
        public static Dictionary<string, object>[] RunDataSource(Dictionary<string, object> dataSource)
        {
            return Query.Deserialize(dataSource).Run();
        }

        #endregion


        public Boolean Distinct
        {
            get { return this.Model.Distinct; }
            set { this.Model.Distinct = value; }
        }

        public Int32? Top
        {
            get { return this.Model.Top; }
            set { this.Model.Top = value; }
        }

        public QuerySelection[] Selects
        {
            get { return this.Model.Selects; }
            set { this.Model.Selects = value; }
        }

        public QuerySource Source
        {
            get { return this.Model.Source; }
            set { this.Model.Source = value; }
        }

        public QueryJoin[] Joins
        {
            get { return this.Model.Joins; }
            set { this.Model.Joins = value; }
        }

        public QueryCondition[] Wheres
        {
            get { return this.Model.Wheres; }
            set { this.Model.Wheres = value; }
        }

        public QueryOrder[] Orders
        {
            get { return this.Model.Orders; }
            set { this.Model.Orders = value; }
        }
                
    }
}
