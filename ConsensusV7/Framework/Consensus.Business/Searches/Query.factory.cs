using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface QueryFactory : IFactory<QueryModel>
    {
        QueryModel Create();
        
        Dictionary<String, Object>[] Execute(QueryModel query);

        ISearchesRunnable Deserialize(IDictionary<string, object> dictionary);        
    }
}
