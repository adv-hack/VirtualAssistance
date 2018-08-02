using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class Search : Proxy<SearchModel>, ISearchParameterable
    {
        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="Search" /> instance.
        /// </summary>
        public Search(SearchModel model) : base(model)
        {

        }

        #endregion

        #region methods

        public ISearchParameterable AddParameter(String parameterName, Object value)
        {
            return this.Model.AddParameter(parameterName, value);
        }

        public Dictionary<String, Object>[] Run()
        {
            return this.Model.Run();
        }

        object IRunnable.Run()
        {
            return this.Model.Run();
        }

        public static Search Create(SearchTypes type)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Search.Create(site, type);
        }

        public static Search Create(ConsensusSite site, SearchTypes type)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            SearchModel model = provider.Searches.Search.Search(type);
            return model == null ? null : new Search(model);
        }

        public static ISearchesRunnable Deserialize(IDictionary<string, object> dictionary)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Search.Deserialize(site, dictionary);
        }

        public static ISearchesRunnable Deserialize(ConsensusSite site, IDictionary<string, object> dictionary)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Searches.Search.Deserialize(dictionary);
        }

        public IDictionary<string, object> Serialize()
        {
            return this.Model.Serialize();
        }

        public static Dictionary<string, object>[] RunDataSource(Dictionary<string, object> dataSource)
        {
            return Search.Deserialize(dataSource).Run();
        }

        #endregion        
    }
}
