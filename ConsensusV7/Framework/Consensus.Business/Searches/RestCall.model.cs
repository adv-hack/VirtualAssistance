using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface RestCallModel : IModel, IRestCallSerializable
    {
        /// <summary>
        ///     The container containing the proxy on which the method is defined
        /// </summary>
        String Container { get; set; }

        /// <summary>
        ///     The name of the model the method is defined on
        /// </summary>
        String ModelName { get; set; }

        /// <summary>
        ///     The name of the method to be run
        /// </summary>
        string MethodName { get; set; }

        /// <summary>
        ///     Gets the parameters defined for the rest call.
        /// </summary>
        RestCallParameter[] Parameters { get; }

        /// <summary>
        ///     Gets the Serialisation
        /// </summary>
        RestCallSerialization Serialization { get; }

        /// <summary>
        ///     Add a parameter for the rest call
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        void AddParameter(String parameterName, Object value);
    }
}
