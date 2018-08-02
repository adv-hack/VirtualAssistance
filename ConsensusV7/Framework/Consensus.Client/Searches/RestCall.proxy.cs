using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Consensus.Searches
{
    public class RestCall : Proxy<RestCallModel>, IRestCallRunnable
    {
        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="RestCall" /> instance.
        /// </summary>
        public RestCall(RestCallModel model) : base(model)
        {

        }

        #endregion

        #region properties

        /// <summary>
        /// Structure containing controls for how the data is serialised when it
        /// is returned from a rest call.
        /// </summary>
        public RestCallSerialization Serialization
        {
            get
            {
                return this.Model.Serialization;
            }
        }

        #endregion

        #region methods

        public RestCall AddParameter(String parameterName, Object value)
        {
            this.Model.AddParameter(parameterName, value);
            return this;
        }

        public static RestCall Create<TModel>(string MethodName) where TModel : Proxy
        {
            string modelClassName = typeof(TModel).FullName;
            string[] modelBits = modelClassName.Split('.');
            return RestCall.Create(modelBits[1], modelBits[2], MethodName);
        }

        public static RestCall Create(String Container, String ModelName, String MethodName)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return RestCall.Create(site, Container, ModelName, MethodName);
        }

        public static RestCall Create(ConsensusSite site, String Container, String ModelName, String MethodName)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            RestCallModel model = provider.Searches.RestCall.RestCall(Container, ModelName, MethodName);
            return model == null ? null : new RestCall(model);
        }

        public static IRestCallSerializable Deserialize(IDictionary<string, object> dictionary)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return RestCall.Deserialize(site, dictionary);
        }

        public static IRestCallSerializable Deserialize(ConsensusSite site, IDictionary<string, object> dictionary)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Searches.RestCall.Deserialize(dictionary);
        }

        public IDictionary<string, object> Serialize()
        {
            return this.Model.Serialize();
        }

        public static IEnumerable<Proxy> RunDataSource(Dictionary<string, object> dataSource)
        {
            RestCallModel model = (RestCallModel)RestCall.Deserialize(dataSource);
            RestCall proxy = new RestCall(model);
            return proxy.Run();           
        }
        
        public IEnumerable<Proxy> Run()
        {
            IEnumerable<Proxy> result = new List<Proxy>();

            Type proxyType = Type.GetType("Consensus." + this.Model.Container + "." + this.Model.ModelName);
            if (proxyType != null)
            {
                MethodInfo createProxyInfo = proxyType.GetMethod("Create", new Type[0]);
                if (createProxyInfo != null)
                {
                    object proxy = createProxyInfo.Invoke(null, new object[0]);
                    if (proxy != null)
                    {
                        MethodInfo method = null;
                        IEnumerable<MethodInfo> methods = proxyType.GetMethods(BindingFlags.Static | BindingFlags.Public).Where(m => m.Name == this.Model.MethodName && !m.GetParameters().Any(p => p.Name == "site"));
                        if (methods.Count() > 0)
                        {
                            method = methods.First();
                        }
                        if (method != null)
                        {
                            ParameterInfo[] parameters = method.GetParameters();
                            object[] paramVals = new object[parameters.Length];

                            for (int i = 0; i < parameters.Length; i++)
                            {
                                RestCallParameter pSet = this.Model.Parameters.FirstOrDefault(p => p.Parameter == parameters[i].Name);
                                if (pSet != null)
                                {
                                    paramVals[i] = pSet.Value.ConvertTo(parameters[i].ParameterType);
                                }
                                else
                                {
                                    paramVals[i] = parameters[i].ParameterType.GetDefaultValue();
                                }
                            }

                            return method.Invoke(proxy, paramVals) as IEnumerable<Proxy>;
                        }
                    }
                }
            }

            return result;
        }
        

        object IRunnable.Run()
        {
            return this.Run();
        }


        #endregion
    }
}
