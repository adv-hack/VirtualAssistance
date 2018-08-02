using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface RestCallFactory : IFactory<RestCallModel>
    {
        RestCallModel RestCall(string Container, string ModelName, string MethodName);
                
        IRestCallSerializable Deserialize(IDictionary<string, object> dictionary);
        
    }
}
