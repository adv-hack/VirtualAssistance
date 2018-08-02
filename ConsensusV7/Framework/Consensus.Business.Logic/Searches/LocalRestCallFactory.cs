using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class LocalRestCallFactory : LocalFactory<LocalRestCallModel>, RestCallFactory
    {
        RestCallModel RestCallFactory.RestCall(string Container, string ModelName, string MethodName)
        {
            LocalRestCallModel restCall = new LocalRestCallModel(this.Provider);
            restCall.Container = Container;
            restCall.ModelName = ModelName;
            restCall.MethodName = MethodName;
            return restCall;
        }
                
        public IRestCallSerializable Deserialize(IDictionary<string, object> dictionary)
        {
            LocalRestCallModel result = new LocalRestCallModel(this.Provider);

            foreach (string key in dictionary.Keys)
            {
                switch (key)
                {
                    case "Container":
                        result.Container = dictionary[key].ToString();
                        break;
                    case "MethodName":
                        result.MethodName = dictionary[key].ToString();
                        break;
                    case "ModelName":
                        result.ModelName = dictionary[key].ToString();
                        break;
                    case "Parameters":
                        if (dictionary[key] is System.Collections.ArrayList)
                        {
                            foreach (object parameter in dictionary[key] as System.Collections.ArrayList)
                            {
                                if (parameter is IDictionary<string, object>)
                                {
                                    IDictionary<string, object> dparam = parameter as IDictionary<string, object>;
                                    LocalRestCallParameter iparam = new LocalRestCallParameter();
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
