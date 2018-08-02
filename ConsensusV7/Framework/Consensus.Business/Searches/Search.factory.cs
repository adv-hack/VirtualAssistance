using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface SearchFactory : IFactory<SearchModel>
    {
        SearchModel Search(SearchTypes type);
                
        ISearchesRunnable Deserialize(IDictionary<string, object> dictionary);
        
    }
}
