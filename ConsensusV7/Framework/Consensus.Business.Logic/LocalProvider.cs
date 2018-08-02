using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the programmatic access to the locally-executable factory collections.
    /// </summary>
    public partial class LocalProvider
    {
        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Searches namespace.
        /// </summary>
        private LocalSearchesFactoryCollection _searches;

        /// <summary>
        ///    Gets the collection of locally-executable factories which pertain to the Searches namespace.
        /// </summary>
        public LocalSearchesFactoryCollection Searches
        {
            get { return LocalFactoryCollection.Create(this, ref _searches); }
        }
    }
}
