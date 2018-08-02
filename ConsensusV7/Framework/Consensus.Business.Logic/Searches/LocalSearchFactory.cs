using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class LocalSearchFactory : LocalFactory<LocalSearchModel>, SearchFactory
    {
        SearchModel SearchFactory.Search(SearchTypes type)
        {
            LocalSearchModel search = new LocalSearchModel(this.Provider);
            search.Type = type;
            return search;
        }
                
        public ISearchesRunnable Deserialize(IDictionary<string, object> dictionary)
        {
            LocalSearchModel result = new LocalSearchModel(this.Provider);

            foreach (string key in dictionary.Keys)
            {
                switch (key)
                {
                    case "Type":
                        SearchTypes st;
                        if (Enum.TryParse<SearchTypes>(dictionary[key].ToString(), out st))
                            result.Type = st;
                        break;
                    case "Parameters":
                        if (dictionary[key] is System.Collections.ArrayList)
                        {
                            foreach (object parameter in dictionary[key] as System.Collections.ArrayList)
                            {
                                if (parameter is IDictionary<string, object>)
                                {
                                    IDictionary<string, object> dparam = parameter as IDictionary<string, object>;
                                    LocalSearchParameter iparam = new LocalSearchParameter();
                                    result.Parameters.Add(iparam);
                                    foreach (string pkey in dparam.Keys)
                                    {
                                        switch (pkey)
                                        {
                                            case "Parameter":
                                                iparam.Parameter = dparam[pkey].ToString();
                                                break;
                                            case "Value":
                                                iparam.Value = dparam[pkey];
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
            }

            return result;
        }

    }
}
