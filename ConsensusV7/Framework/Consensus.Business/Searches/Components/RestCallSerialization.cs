using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public interface RestCallSerialization
    {
        /// <summary>
        /// Sets the depth to serialise the object to
        /// </summary>
        RestSerializationDepth GoToDepth { get; set; }

        /// <summary>
        /// Sets the depth up to which lists members are serialised rather than ignored.
        /// </summary>
        RestSerializationDepth ListsAtDepth { get; set; }

        /// <summary>
        /// Sets the depth to which to serialise list entries.
        /// </summary>
        RestSerializationDepth ListsToDepth { get; set; }

        /// <summary>
        /// List of attributes to ignore, by type name
        /// </summary>
        Dictionary<string, string[]> Ignore { get; }

        /// <summary>
        /// List of attributes to include, by type name
        /// </summary>
        Dictionary<string, string[]> Include { get; }
                
        /// <summary>
        /// Settings for depth of serialisation for individual lists, by type name
        /// </summary>
        Dictionary<string, Dictionary<string, RestSerializationDepth>> NamedListsResolveToDepth { get; }
    }
    
}
