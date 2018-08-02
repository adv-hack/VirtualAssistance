using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    class LocalRestCallSerialization : RestCallSerialization
    {
        #region fields

        private RestSerializationDepth _goToDepth = RestSerializationDepth.Root;
        private Dictionary<string, string[]> _ignore;
        private Dictionary<string, string[]> _include;
        private RestSerializationDepth _listsAtDepth = RestSerializationDepth.None;
        private RestSerializationDepth _listsToDepth = RestSerializationDepth.Root;
        private Dictionary<string, Dictionary<string, RestSerializationDepth>> _namedListsResolveToDepth;

        #endregion

        #region properties

        public RestSerializationDepth GoToDepth { get { return _goToDepth; } set { _goToDepth = value; } }

        public Dictionary<string, string[]> Ignore
        {
            get
            {
                if (_ignore == null)
                    _ignore = new Dictionary<string, string[]>();
                return _ignore;
            }
        }

        public Dictionary<string, string[]> Include
        {
            get
            {
                if (_include == null)
                    _include = new Dictionary<string, string[]>();
                return _include;
            }
        }

        public RestSerializationDepth ListsAtDepth { get { return _listsAtDepth; } set { _listsAtDepth = value; } }

        public RestSerializationDepth ListsToDepth { get { return _listsToDepth; } set { _listsToDepth = value; } }

        public Dictionary<string, Dictionary<string, RestSerializationDepth>> NamedListsResolveToDepth
        {
            get
            {
                if (_namedListsResolveToDepth == null)
                    _namedListsResolveToDepth = new Dictionary<string, Dictionary<string, RestSerializationDepth>>();
                return _namedListsResolveToDepth;
            }
        }

        #endregion
    }
}
