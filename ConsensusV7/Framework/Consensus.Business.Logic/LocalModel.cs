using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for locally-executable business model instances which support the standardised business rules.
    /// </summary>
    public abstract partial class LocalModel
    {
        /// <summary>
        ///     Gets whether the underlying data structure has been persisted within the the persistence mechanism.
        /// </summary>
        public abstract Boolean IsPersisted
        {
            get;
        }

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        public abstract Boolean IsModified
        {
            get;
        }
    }
}
